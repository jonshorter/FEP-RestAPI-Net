Imports RestSharp
Imports Newtonsoft.Json
Imports R1SimpleRestClient.Models.Response
Imports R1SimpleRestClient.Models.Project
Imports R1SimpleRestClient.Models.Report
Imports R1SimpleRestClient.Models.Job


Public Class ProjectFunctions
    '     Public Class Projects
    Public Function GetProjectList(ByVal Server As String, ByVal APIUserName As String, ByVal APIPassword As String)
        Dim client As New RestSharp.RestClient("https://" & Server & "/R1/api")
        Dim authentication As New Authentication
        Dim auth As Authentication.AuthToken = authentication.AuthenticateWithR1(Server, APIUserName, APIPassword)

        If auth.Error = True Then
            Return "Error: " & auth.Data
        End If
        client.CookieContainer = auth.Data
        Dim request = New RestSharp.RestRequest("projects", Method.GET)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        Dim response As RestSharp.RestResponse = client.Execute(request)
        Select Case response.StatusCode
            Case Is > 200 < 400
                Dim apiresponse = JsonConvert.DeserializeObject(Of ApiResponse(Of List(Of ProjectPresenter)))(response.Content)
                Select Case apiresponse.Success
                    Case True
                        Return apiresponse.Data
                    Case False
                        Return "Error: " & apiresponse.Error.Message.ToString
                End Select
            Case Is >= 400
                Return "Error: " & response.ErrorMessage
            Case Else
                Return "Error: " & response.ErrorMessage
        End Select

        Return "If You See This.... GetProjectList"
    End Function

    Public Function GetProjectDetails(ByVal Server As String, ByVal APIUserName As String, ByVal APIPassword As String, ByVal ProjectID As Long)
        Dim client As New RestSharp.RestClient("https://" & Server & "/R1/api")
        Dim authentication As New Authentication
        Dim auth As Authentication.AuthToken = authentication.AuthenticateWithR1(Server, APIUserName, APIPassword)
        If auth.Error = True Then
            Return "Error: " & auth.Data
        End If
        client.CookieContainer = auth.Data
        Dim request = New RestSharp.RestRequest("projects/" & ProjectID, Method.GET)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        Dim response As RestSharp.RestResponse = client.Execute(request)
        Select Case response.StatusCode
            Case Is > 200 < 400
                Dim apiresponse = JsonConvert.DeserializeObject(Of Models.Response.ApiResponse(Of ProjectPresenter))(response.Content)
                Select Case apiresponse.Success
                    Case True
                        Return apiresponse.Data
                    Case False
                        Return "Error: " & apiresponse.Error.Message.ToString
                End Select
            Case Is >= 400
                Return "Error: " & response.ErrorMessage
            Case Else
                Return "Error: " & response.ErrorMessage
        End Select

        Return "If You See This.... GetProjectDetails"
    End Function

    Public Function GetProjectReports(ByVal Server As String, ByVal APIUserName As String, ByVal APIPassword As String, ByVal ProjectID As Long)
        Dim client As New RestSharp.RestClient("https://" & Server & "/R1/api")
        Dim authentication As New Authentication
        Dim auth As Authentication.AuthToken = authentication.AuthenticateWithR1(Server, APIUserName, APIPassword)
        If auth.Error = True Then
            Return "Error: " & auth.Data
        End If
        client.CookieContainer = auth.Data
        Dim request = New RestSharp.RestRequest("projects/" & ProjectID & "/reports", Method.GET)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        Dim response As RestSharp.RestResponse = client.Execute(request)
        Select Case response.StatusCode
            Case Is > 200 < 400
                Dim apiresponse = JsonConvert.DeserializeObject(Of Models.Response.ApiResponse(Of List(Of Models.Report.BasicReport)))(response.Content)
                Select Case apiresponse.Success
                    Case True
                        Return apiresponse.Data
                    Case False
                        Return "Error: " & apiresponse.Error.Message.ToString
                End Select
            Case Is >= 400
                Return "Error: " & response.ErrorMessage
            Case Else
                Return "Error: " & response.ErrorMessage
        End Select

        Return "If You See This.... GetProjectReports"
    End Function

    Public Function DeleteProject(ByVal Server As String, ByVal APIUserName As String, ByVal APIPassword As String, ByVal ProjectID As Long)
        Dim client As New RestSharp.RestClient("https://" & Server & "/R1/api")
        Dim authentication As New Authentication
        Dim auth As Authentication.AuthToken = authentication.AuthenticateWithR1(Server, APIUserName, APIPassword)
        If auth.Error = True Then
            Return "Error: " & auth.Data
        End If
        client.CookieContainer = auth.Data
        Dim request = New RestSharp.RestRequest("projects/" & ProjectID, Method.DELETE)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        Dim response As RestSharp.RestResponse = client.Execute(request)
        Select Case response.StatusCode
            Case Is > 200 < 400
                Dim apiresponse = JsonConvert.DeserializeObject(Of Models.Response.ApiResponse(Of Boolean))(response.Content)
                Select Case apiresponse.Success
                    Case True
                        Return apiresponse.Data
                    Case False
                        Return "Error: " & apiresponse.Error.Message.ToString
                End Select
            Case Is >= 400
                Return "Error: " & response.ErrorMessage
            Case Else
                Return "Error: " & response.ErrorMessage
        End Select

        Return "If You See This.... DeleteProject"
    End Function

    Public Function GetJobsForProject(ByVal Server As String, ByVal APIUserName As String, ByVal APIPassword As String, ByVal ProjectID As Long)
        Dim client As New RestSharp.RestClient("https://" & Server & "/R1/api")
        Dim authentication As New Authentication
        Dim auth As Authentication.AuthToken = authentication.AuthenticateWithR1(Server, APIUserName, APIPassword)
        If auth.Error = True Then
            Return "Error: " & auth.Data
        End If
        client.CookieContainer = auth.Data
        Dim request = New RestSharp.RestRequest("jobs/" & ProjectID, Method.GET)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        Dim response As RestSharp.RestResponse = client.Execute(request)
        Select Case response.StatusCode
            Case Is > 200 < 400
                Dim apiresponse = JsonConvert.DeserializeObject(Of Models.Response.ApiResponse(Of List(Of JobInfo)))(response.Content)
                Select Case apiresponse.Success
                    Case True
                        Return apiresponse.Data
                    Case False
                        Return "Error: " & apiresponse.Error.Message.ToString
                End Select
            Case Is >= 400
                Return "Error: " & response.ErrorMessage
            Case Else
                Return "Error: " & response.ErrorMessage
        End Select

        Return "If You See This.... GetJobsForProject"
    End Function


    '  End Class

End Class


