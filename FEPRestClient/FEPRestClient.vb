Imports System.Net
Imports System.Text
Imports System.IO
Imports RestSharp
Imports System.Windows.Forms
Imports Newtonsoft.Json
Imports FEPRestClient.Models.Response

Public Class Client
    Public Functions As New ClientFunctions
    Public Property Username As String = ""
    Public Property Password As String = ""
    Public Property Server As String
    Public Property IgnoreSSL As Boolean = False
    Public Shared Token As String = ""
    Public Shared RestClient As New RestSharp.RestClient


    Public ReadOnly Property IsAuthenticated As Boolean
        Get
            If Token <> "" Then
                Return True
            Else
                Return False
            End If
        End Get
    End Property
    Public Function AcceptAllCertifications(ByVal sender As Object, ByVal certification As System.Security.Cryptography.X509Certificates.X509Certificate, ByVal chain As System.Security.Cryptography.X509Certificates.X509Chain, ByVal sslPolicyErrors As System.Net.Security.SslPolicyErrors) As Boolean
        Return True
    End Function
    Public Sub Authenticate()
        If IgnoreSSL = True Then
            ServicePointManager.ServerCertificateValidationCallback = AddressOf AcceptAllCertifications
        End If
        RestClient.BaseUrl = New Uri("https://" & Server & "/Endpoint/api/")

        Dim request = New RestSharp.RestRequest("authenticate?username=" & Username & "&password=" & Password, Method.GET)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        Dim response As RestSharp.RestResponse = RestClient.Execute(request)
        Select Case response.StatusCode
            Case 200
                Dim reply = JsonConvert.DeserializeObject(Of ApiResponse(Of Models.Authentication.Token))(response.Content)
                If reply.Success = False Then
                    MsgBox(reply.Error.Message)
                Else
                    Token = reply.Data.Token
                End If
            Case Else
                MsgBox(response.Content)
        End Select
    End Sub



    Public Shared Sub UpdateToken(ByVal TokenHeader As List(Of RestSharp.Parameter))
        For Each header In TokenHeader
            If header.Name = "Fidelis-Endpoint-Token" Then
                Token = header.Value
            End If
        Next
    End Sub

    

    Public Function CustomRequest(ByVal Method As RestSharp.Method, ByVal apicall As String, Optional ByVal jsonstr As String = Nothing)
        Dim request = New RestSharp.RestRequest(apicall, Method)
        If Not jsonstr Is Nothing Then
            request.RequestFormat = DataFormat.Json
            request.JsonSerializer = New RestSharp.Serializers.JsonSerializer
            request.AddHeader("Accept", "application/json")
            request.Parameters.Clear()
            request.AddParameter("application/json", jsonstr, ParameterType.RequestBody)
        End If
        request.AddHeader("Authorization", "bearer " & Token)

        Dim response As RestSharp.RestResponse = RestClient.Execute(request)
        If response.StatusCode <> 200 Then
            Return "Error: Not Found" & vbCrLf & response.Content
        Else
            UpdateToken(response.Headers)
            Return response.Content
        End If

    End Function

    Public Sub Logout()
        Dim request = New RestSharp.RestRequest("configuration/logout", Method.GET)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        request.AddHeader("Authorization", "bearer " & Client.Token)
        Dim response As RestSharp.RestResponse = Client.RestClient.Execute(request)
        Client.UpdateToken(response.Headers)
        Dim apiresponse = JsonConvert.DeserializeObject(Of Models.Response.ApiResponse(Of String))(response.Content)
        Select Case apiresponse.Success
            Case True
                MsgBox("Logged Out")
            Case False
                MsgBox("Error: " & apiresponse.Error.Message.ToString)
        End Select
     

    End Sub


End Class




