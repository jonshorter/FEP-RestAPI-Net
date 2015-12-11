Imports RestSharp
Imports Newtonsoft.Json
Imports R1SimpleRestClient.Models.Response
Imports R1SimpleRestClient.Models.Project
Imports R1SimpleRestClient.Models.Report
Imports R1SimpleRestClient.Models.Job
Imports R1SimpleRestClient.Models


Public Class ProjectFunctions

    Public Function GetProjectList(ByVal AuthToken As Models.Response.AuthToken, ByVal Server As String, _
                                   Optional Search As String = "") As ApiResponse(Of List(Of ProjectPresenter))
        Dim client As New RestSharp.RestClient("https://" & Server & "/R1/api")
        client.CookieContainer = AuthToken.Data
        If Not Search = "" Then
            Search = "?where=" & Search
        End If
        Dim request = New RestSharp.RestRequest("projects" & Search, Method.GET)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        Dim response As RestSharp.RestResponse = client.Execute(request)
        Return JsonConvert.DeserializeObject(Of ApiResponse(Of List(Of ProjectPresenter)))(response.Content)

    End Function

    Public Function GetProjectDetails(ByVal AuthToken As Models.Response.AuthToken, ByVal Server As String, ByVal ProjectID As String) As ApiResponse(Of ProjectPresenter)
        Dim client As New RestSharp.RestClient("https://" & Server & "/R1/api")
        client.CookieContainer = AuthToken.Data
        Dim request = New RestSharp.RestRequest("projects/" & ProjectID, Method.GET)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        Dim response As RestSharp.RestResponse = client.Execute(request)
        Return JsonConvert.DeserializeObject(Of Models.Response.ApiResponse(Of ProjectPresenter))(response.Content)

    End Function

    Public Function GetProjectReports(ByVal AuthToken As Models.Response.AuthToken, ByVal Server As String, ByVal ProjectID As String) As ApiResponse(Of List(Of Models.Report.BasicReport))
        Dim client As New RestSharp.RestClient("https://" & Server & "/R1/api")
        client.CookieContainer = AuthToken.Data
        Dim request = New RestSharp.RestRequest("projects/" & ProjectID & "/reports/GetProjectReports", Method.GET)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        Dim response As RestSharp.RestResponse = client.Execute(request)
        Return JsonConvert.DeserializeObject(Of Models.Response.ApiResponse(Of List(Of Models.Report.BasicReport)))(response.Content)

    End Function

    Public Function DeleteProject(ByVal AuthToken As Models.Response.AuthToken, ByVal Server As String, ByVal ProjectID As String) As ApiResponse(Of Boolean)
        Dim client As New RestSharp.RestClient("https://" & Server & "/R1/api")
        client.CookieContainer = AuthToken.Data
        Dim request = New RestSharp.RestRequest("projects/" & ProjectID, Method.DELETE)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        Dim response As RestSharp.RestResponse = client.Execute(request)
        Return JsonConvert.DeserializeObject(Of Models.Response.ApiResponse(Of Boolean))(response.Content)
      
    End Function

    Public Function GetJobsForProject(ByVal AuthToken As Models.Response.AuthToken, ByVal Server As String, ByVal ProjectID As Long) As ApiResponse(Of List(Of JobInfo57))
        Dim client As New RestSharp.RestClient("https://" & Server & "/R1/api")
        client.CookieContainer = AuthToken.Data
        Dim request = New RestSharp.RestRequest("jobs/" & ProjectID, Method.GET)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        Dim response As RestSharp.RestResponse = client.Execute(request)
        Return JsonConvert.DeserializeObject(Of Models.Response.ApiResponse(Of List(Of JobInfo57)))(response.Content)
      
    End Function



    Public Function CreateProject(ByVal AuthToken As Response.AuthToken, ByVal Server As String, ByVal NewProject As NewProjectDefinition) As ApiResponse(Of NewProjectDefinition)
        Dim client As New RestSharp.RestClient("https://" & Server & "/R1/api")
        client.CookieContainer = AuthToken.Data
        Dim request = New RestSharp.RestRequest("projects", Method.POST)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        request.AddHeader("Accept", "application/json")
        request.Parameters.Clear()
        request.AddParameter("application/json", Newtonsoft.Json.JsonConvert.SerializeObject(NewProject), ParameterType.RequestBody)
        Dim response As RestSharp.RestResponse = client.Execute(request)
        Return JsonConvert.DeserializeObject(Of Models.Response.ApiResponse(Of NewProjectDefinition))(response.Content)

    End Function
    Public Function UpdateProject(ByVal AuthToken As Response.AuthToken, ByVal Server As String, ByVal UpdatedProject As ProjectPresenter) As ApiResponse(Of ProjectPresenter)
        Dim client As New RestSharp.RestClient("https://" & Server & "/R1/api")
        client.CookieContainer = AuthToken.Data
        Dim request = New RestSharp.RestRequest("projects", Method.PUT)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        request.AddHeader("Accept", "application/json")
        request.Parameters.Clear()
        request.AddParameter("application/json", Newtonsoft.Json.JsonConvert.SerializeObject(UpdatedProject), ParameterType.RequestBody)
        Dim response As RestSharp.RestResponse = client.Execute(request)
        Return JsonConvert.DeserializeObject(Of Models.Response.ApiResponse(Of ProjectPresenter))(response.Content)

    End Function
    Public Function GetJobResultReports(ByVal AuthToken As Models.Response.AuthToken, ByVal Server As String, ByVal ProjectID As Long, ByVal JobID As String)
        Dim client As New RestSharp.RestClient("https://" & Server & "/R1/api")
        client.CookieContainer = AuthToken.Data
        Dim request = New RestSharp.RestRequest("projects/" & ProjectID & "/jobs/jobresultreports/" & JobID & "/", Method.GET)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        Dim response As RestSharp.RestResponse = client.Execute(request)
        Select Case response.StatusCode
            Case Is = Net.HttpStatusCode.OK
                Dim apiresponse = JsonConvert.DeserializeObject(Of List(Of JobReportDataStatus))(response.Content)
                Return apiresponse
            Case Is = Net.HttpStatusCode.BadRequest
                Dim apiresponse = JsonConvert.DeserializeObject(Of [Error])(response.Content)
                Return "Error: " & apiresponse.Message & apiresponse.StatusCode
            Case Else
                Dim apiresponse = JsonConvert.DeserializeObject(Of [Error])(response.Content)
                Return "Error: " & apiresponse.Message & apiresponse.StatusCode
        End Select

        Return "If You See This.... GetJobResultReports"
    End Function
    Public Function GetJobResultsReportStatus(ByVal AuthToken As Models.Response.AuthToken, ByVal Server As String, ByVal ProjectID As Long, ByVal JobID As String) As ApiResponse(Of JobReportDataStatus)
        Dim client As New RestSharp.RestClient("https://" & Server & "/R1/api")
        client.CookieContainer = AuthToken.Data
        Dim request = New RestSharp.RestRequest("projects/" & ProjectID & "/jobs/jobresultsreportstatus/" & JobID & "/", Method.GET)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        Dim response As RestSharp.RestResponse = client.Execute(request)
        Return JsonConvert.DeserializeObject(Of Models.Response.ApiResponse(Of JobReportDataStatus))(response.Content)

    End Function
    Public Function GenerateJobDetailsReport(ByVal AuthToken As Models.Response.AuthToken, ByVal Server As String, ByVal ProjectID As Long, ByVal JobID As String) As ApiResponse(Of JobReportDataStatus)
        Dim client As New RestSharp.RestClient("https://" & Server & "/R1/api")
        client.CookieContainer = AuthToken.Data
        Dim request = New RestSharp.RestRequest("projects/" & ProjectID & "/jobs/generatejobdetailsreport/" & JobID, Method.GET)
        request.AddUrlSegment("id", JobID)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        Dim response As RestSharp.RestResponse = client.Execute(request)
        Return JsonConvert.DeserializeObject(Of Models.Response.ApiResponse(Of JobReportDataStatus))(response.Content)

    End Function



End Class


