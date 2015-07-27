Imports System.Net
Imports System.Text
Imports System.IO
Imports RestSharp
Imports System.Windows.Forms
Imports Newtonsoft.Json

Public Class R1SimpleRestClient
    Inherits Authentication
    Public Functions As New ClientFunctions
    Private Authentication As New Authentication


    Public Function R1RestRequest(ByVal Server As String, ByVal APIUserName As String, ByVal APIPassword As String, ByVal Method As RestSharp.Method, ByVal apicall As String, Optional ByVal jsonstr As String = Nothing)
        ' Try
        Dim client As New RestSharp.RestClient("https://" & Server & "/R1/api")
        Dim auth = AuthenticateWithR1(Server, APIUserName, APIPassword)
        If Not auth.Error = True Then
            client.CookieContainer = auth.Data

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

                Select Case True

                    Case response.ResponseUri.AbsolutePath.Contains("/R1/api/alerts/getAlertSourceBreakdown/")
                        ' Dim content As List(Of R1SimpleRestModels.Models.AlertSourceBreakdownResult) = JsonConvert.DeserializeObject(Of List(Of R1SimpleRestModels.Models.AlertSourceBreakdownResult))(response.Content)
                        ' Return content
                        Return response.Content
                    Case response.ResponseUri.AbsolutePath.Contains("/jobs/jobresultsreportstatus/")
                        Return response.Content
                    Case response.ResponseUri.AbsolutePath.Contains("/R1/api/projects")
                        'Dim content As R1SimpleRestModels.Models.ApiResponse(Of Object) = JsonConvert.DeserializeObject(Of R1SimpleRestModels.Models.ApiResponse(Of Object))(response.Content)
                        'Return content
                        Return response.Content
                    Case response.ResponseUri.AbsolutePath.Contains("/R1/api/jobs")
                        'Dim content As R1SimpleRestModels.Models.ApiResponse(Of Object) = JsonConvert.DeserializeObject(Of R1SimpleRestModels.Models.ApiResponse(Of Object))(response.Content)
                        'Return content
                        Return response.Content
                    Case Else
                        Return response.Content

                End Select
            End If
        Else
            Return "Error:" & auth.Data
        End If

        '   Catch ex As Exception
        'MsgBox(ex.Message)
        '  Return ex.Message
        ' End Try
    End Function


End Class




