Imports System.Net
Imports System.Text
Imports System.IO
Imports RestSharp
Imports System.Windows.Forms
Imports Newtonsoft.Json
Imports R1SimpleRestClient.Models.Response

Public Class R1SimpleRestClient
    Inherits R1Authentication
    Public Functions As New ClientFunctions
    Private Authentication As New R1Authentication
    Public Token As String

    Public Sub Authenticate(ByVal Server As String, ByVal Username As String, ByVal Password As String)
        Dim client As New RestSharp.RestClient("https://" & Server & "/Endpoint/api/")
        Dim request = New RestSharp.RestRequest("authenticate?username=" & Username & "&password=" & Password, Method.GET)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        Dim response As RestSharp.RestResponse = client.Execute(request)
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

    Public Function v6RestRequest(ByVal Server As String, ByVal Method As RestSharp.Method, ByVal apicall As String, Optional ByVal jsonstr As String = Nothing)

        Dim client As New RestSharp.RestClient("https://" & Server & "/Endpoint/api")

        Dim request = New RestSharp.RestRequest(apicall, Method)
        If Not jsonstr Is Nothing Then

            request.RequestFormat = DataFormat.Json
            request.JsonSerializer = New RestSharp.Serializers.JsonSerializer
            request.AddHeader("Accept", "application/json")
            request.Parameters.Clear()
            request.AddParameter("application/json", jsonstr, ParameterType.RequestBody)
        End If
        request.AddHeader("Authorization", "bearer " & Token)

        Dim response As RestSharp.RestResponse = client.Execute(request)
        If response.StatusCode = HttpStatusCode.NotFound Then
            Return "Error: Not Found" & vbCrLf & response.Content
        Else
            Return response.Content
        End If

    End Function


    Public Function R1RestRequest(ByVal AuthToken As Models.Response.AuthToken, ByVal Server As String, ByVal Method As RestSharp.Method, ByVal apicall As String, Optional ByVal jsonstr As String = Nothing)

        Dim client As New RestSharp.RestClient("https://" & Server & "/R1/api")
        client.CookieContainer = AuthToken.Data.Cookies

        Dim request = New RestSharp.RestRequest(apicall, Method)
        If Not jsonstr Is Nothing Then

            request.RequestFormat = DataFormat.Json
            request.JsonSerializer = New RestSharp.Serializers.JsonSerializer
            request.AddHeader("Accept", "application/json")
            request.Parameters.Clear()
            request.AddParameter("application/json", jsonstr, ParameterType.RequestBody)
        End If

        Dim response As RestSharp.RestResponse = client.Execute(request)
        If response.StatusCode = HttpStatusCode.NotFound Then
            Return "Error: Not Found" & vbCrLf & response.Content
        Else
            Return response.Content
        End If

    End Function


End Class




