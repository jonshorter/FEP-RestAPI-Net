﻿Imports RestSharp
Imports Newtonsoft.Json
Imports FEPRestClient.Models.Response
Imports FEPRestClient.Models.Project
Imports FEPRestClient.Models.Report
Imports FEPRestClient.Models.Job
Imports FEPRestClient.Models
Imports FEPRestClient.Models.Job2
Imports FEPRestClient.Models.Enums


Public Class JobFunctions
    Public Function CreateJob(ByVal AuthToken As Response.AuthToken, ByVal Server As String, ByVal Job As JobDefinitionModel) As ApiResponse(Of List(Of JobInfo57))
        Dim client As New RestSharp.RestClient("https://" & Server & "/R1/api")
        client.CookieContainer = AuthToken.Data.Cookies
        Dim request = New RestSharp.RestRequest("jobs", Method.PUT)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        request.AddHeader("Accept", "application/json")
        request.Parameters.Clear()
        request.AddParameter("application/json", Newtonsoft.Json.JsonConvert.SerializeObject(Job), ParameterType.RequestBody)
        Dim response As RestSharp.RestResponse = client.Execute(request)
        Return JsonConvert.DeserializeObject(Of Models.Response.ApiResponse(Of List(Of JobInfo57)))(response.Content)

    End Function

    Public Function GetSetJobStatus(ByVal AuthToken As Response.AuthToken, ByVal Server As String, ByVal JobID As String, Optional Status As JobAction = JobAction.Status) As ApiResponse(Of List(Of JobStatus))
        Dim client As New RestSharp.RestClient("https://" & Server & "/R1/api")
        client.CookieContainer = AuthToken.Data.Cookies
        Dim request = New RestSharp.RestRequest("jobs/" & JobID & "/" & Status, Method.GET)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        request.AddHeader("Accept", "application/json")
        request.Parameters.Clear()
        Dim response As RestSharp.RestResponse = client.Execute(request)
        Return JsonConvert.DeserializeObject(Of Models.Response.ApiResponse(Of List(Of JobStatus)))(response.Content)

    End Function

    Public Function CreateJobFromTemplate(ByVal AuthToken As Response.AuthToken, ByVal Server As String, ByVal Job As JobFromTemplate, ByVal Execute As Boolean) As ApiResponse(Of String)
        Dim client As New RestSharp.RestClient("https://" & Server & "/R1/api")
        client.CookieContainer = AuthToken.Data.Cookies
        Dim request = New RestSharp.RestRequest("jobs/createFromTemplate/" & Execute, Method.POST)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        request.AddHeader("Accept", "application/json")
        request.Parameters.Clear()
        request.AddParameter("application/json", Newtonsoft.Json.JsonConvert.SerializeObject(Job), ParameterType.RequestBody)
        Dim response As RestSharp.RestResponse = client.Execute(request)
        Return JsonConvert.DeserializeObject(Of Models.Response.ApiResponse(Of String))(response.Content)
    End Function

    Public Function ResubmitJob(ByVal AuthToken As Response.AuthToken, ByVal Server As String, ByVal Job As ResubmitJobOptions) As ApiResponse(Of String)
        Dim client As New RestSharp.RestClient("https://" & Server & "/R1/api")
        client.CookieContainer = AuthToken.Data.Cookies
        Dim request = New RestSharp.RestRequest("jobs/resubmitJob/", Method.POST)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        request.AddHeader("Accept", "application/json")
        request.Parameters.Clear()
        request.AddParameter("application/json", Newtonsoft.Json.JsonConvert.SerializeObject(Job), ParameterType.RequestBody)
        Dim response As RestSharp.RestResponse = client.Execute(request)
        Return JsonConvert.DeserializeObject(Of Models.Response.ApiResponse(Of String))(response.Content)
    End Function

    Public Function GetAllJobs(ByVal AuthToken As Models.Response.AuthToken, ByVal Server As String, Optional ByVal skip As Integer = 0, _
                               Optional ByVal take As Integer = 0, Optional ByVal sort As String = "CreatedDate Descending", _
                               Optional ByVal search As String = "") As ApiResponse(Of JobData)

        Dim client As New RestSharp.RestClient("https://" & Server & "/R1/api/jobs")
        client.CookieContainer = AuthToken.Data.Cookies

        Dim request = New RestSharp.RestRequest("getalljobs/" & skip & "/" & take & "/" & sort & "/" & search, Method.GET)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        Dim response As RestSharp.RestResponse = client.Execute(request)
        Return JsonConvert.DeserializeObject(Of Models.Response.ApiResponse(Of JobData))(response.Content)

    End Function

    Public Function GetJobStatus(ByVal AuthToken As Models.Response.AuthToken, ByVal Server As String, ByVal JobID As String) As ApiResponse(Of JobInfo)

        Dim client As New RestSharp.RestClient("https://" & Server & "/R1/api/jobs")
        client.CookieContainer = AuthToken.Data.Cookies
        Dim request = New RestSharp.RestRequest("getjobstatus/" & JobID, Method.GET)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        Dim response As RestSharp.RestResponse = client.Execute(request)
        Return JsonConvert.DeserializeObject(Of Models.Response.ApiResponse(Of JobInfo))(response.Content)

    End Function

    Public Function CancelJobResult(ByVal AuthToken As Models.Response.AuthToken, ByVal Server As String, ByVal JobResultID As String, ByVal CancelSchedule As Boolean) As ApiResponse(Of JobInfo)

        Dim client As New RestSharp.RestClient("https://" & Server & "/R1/api/jobs")
        client.CookieContainer = AuthToken.Data.Cookies
        Dim request = New RestSharp.RestRequest("cancelJobResult/" & JobResultID & "/" & CancelSchedule, Method.GET)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        Dim response As RestSharp.RestResponse = client.Execute(request)
        Return JsonConvert.DeserializeObject(Of Models.Response.ApiResponse(Of JobInfo))(response.Content)

    End Function

    Public Function CancelJobTargetResults(ByVal AuthToken As Models.Response.AuthToken, ByVal Server As String, ByVal JobTargetResultID As List(Of String)) As ApiResponse(Of Boolean)

        Dim client As New RestSharp.RestClient("https://" & Server & "/R1/api/jobs")
        client.CookieContainer = AuthToken.Data.Cookies
        Dim request = New RestSharp.RestRequest("cancelJobTargetResults/", Method.POST)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        request.AddHeader("Accept", "application/json")
        request.Parameters.Clear()
        request.AddParameter("application/json", Newtonsoft.Json.JsonConvert.SerializeObject(JobTargetResultID), ParameterType.RequestBody)
        Dim response As RestSharp.RestResponse = client.Execute(request)
        Return JsonConvert.DeserializeObject(Of Models.Response.ApiResponse(Of Boolean))(response.Content)

    End Function

    Public Function SetJobSchedule(ByVal AuthToken As Models.Response.AuthToken, ByVal Server As String, ByVal JobID As String, ByVal IsIncremental As Boolean, ByVal Schedule As SchedulerEventCore) As ApiResponse(Of SchedulerEventCore)

        Dim client As New RestSharp.RestClient("https://" & Server & "/R1/api/jobs")
        client.CookieContainer = AuthToken.Data.Cookies
        Dim request = New RestSharp.RestRequest("jobSchedule/" & JobID & "/" & IsIncremental, Method.POST)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        request.AddHeader("Accept", "application/json")
        request.Parameters.Clear()
        request.AddParameter("application/json", Newtonsoft.Json.JsonConvert.SerializeObject(Schedule), ParameterType.RequestBody)
        Dim response As RestSharp.RestResponse = client.Execute(request)
        Return JsonConvert.DeserializeObject(Of Models.Response.ApiResponse(Of SchedulerEventCore))(response.Content)

    End Function

    Public Function ThreatScanOptioms(ByVal AuthToken As Models.Response.AuthToken, ByVal Server As String, ByVal JobResultID As String, ByVal TSOptions As Job2.ThreatScanJobOptions) As ApiResponse(Of Boolean)

        Dim client As New RestSharp.RestClient("https://" & Server & "/R1/api/jobs")
        client.CookieContainer = AuthToken.Data.Cookies
        Dim request = New RestSharp.RestRequest("threatScanOptions/" & JobResultID, Method.POST)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        request.AddHeader("Accept", "application/json")
        request.Parameters.Clear()
        request.AddParameter("application/json", Newtonsoft.Json.JsonConvert.SerializeObject(TSOptions), ParameterType.RequestBody)
        Dim response As RestSharp.RestResponse = client.Execute(request)
        Return JsonConvert.DeserializeObject(Of Models.Response.ApiResponse(Of Boolean))(response.Content)

    End Function

    Public Function GetJobStatusCounts(ByVal AuthToken As Models.Response.AuthToken, ByVal Server As String, ByVal JobID As String) As ApiResponse(Of JobInfoStatusCounts)

        Dim client As New RestSharp.RestClient("https://" & Server & "/R1/api/jobs")
        client.CookieContainer = AuthToken.Data.Cookies
        Dim request = New RestSharp.RestRequest("getjobendpointstatuscounts/" & JobID, Method.GET)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        Dim response As RestSharp.RestResponse = client.Execute(request)
        Return JsonConvert.DeserializeObject(Of Models.Response.ApiResponse(Of JobInfoStatusCounts))(response.Content)

    End Function


    Public Function GetTargetStatus(ByVal AuthToken As Models.Response.AuthToken, ByVal Server As String, ByVal JobID As String, ByVal ItemID As String) As ApiResponse(Of JobTargetsInfo)

        Dim client As New RestSharp.RestClient("https://" & Server & "/R1/api/jobs")
        client.CookieContainer = AuthToken.Data.Cookies
        Dim request = New RestSharp.RestRequest("gettargetstatus/" & JobID & "/" & ItemID, Method.GET)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        Dim response As RestSharp.RestResponse = client.Execute(request)
        Return JsonConvert.DeserializeObject(Of Models.Response.ApiResponse(Of JobTargetsInfo))(response.Content)

    End Function


    Public Function GetResponsivePath(ByVal AuthToken As Response.AuthToken, ByVal Server As String, ByVal JobID As String)
        Dim client As New RestSharp.RestClient("https://" & Server & "/R1/api")
        client.CookieContainer = AuthToken.Data.Cookies
        Dim request = New RestSharp.RestRequest("jobs/responsivepath/" & Guid.Parse(JobID).ToString, Method.GET)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        request.AddHeader("Accept", "application/json")
        request.Parameters.Clear()
        request.AddParameter("application/json", JobID, ParameterType.RequestBody)
        Dim response As RestSharp.RestResponse = client.Execute(request)
        Select Case response.StatusCode
            Case Is > 200 < 400
                Return response.Content

            Case Is >= 400
                Return "Error: " & response.ErrorMessage
            Case Else
                Return "Error: " & response.ErrorMessage
        End Select
        Return "If You See This.... JobGetResponsivePath"
    End Function

    Public Function GetJobTargets(ByVal AuthToken As Models.Response.AuthToken, ByVal Server As String, ByVal JobID As String _
                                 , Optional ByVal skip As Integer = 0, _
                               Optional ByVal take As Integer = 75, Optional ByVal sort As String = "Name Ascending", _
                               Optional ByVal search As String = "") As ApiResponse(Of JobTargets)

        Dim client As New RestSharp.RestClient("https://" & Server & "/R1/api/jobs")
        client.CookieContainer = AuthToken.Data.Cookies
        Dim request = New RestSharp.RestRequest("getjobtargets/" & JobID & "/" & skip & "/" & take & "/" & sort & "/" & search, Method.GET)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        Dim response As RestSharp.RestResponse = client.Execute(request)
        Return JsonConvert.DeserializeObject(Of Models.Response.ApiResponse(Of JobTargets))(response.Content)

    End Function

    Public Function SetResponsivePath(ByVal AuthToken As Response.AuthToken, ByVal Server As String, ByVal JobID As String)
        Dim client As New RestSharp.RestClient("https://" & Server & "/R1/api")
        client.CookieContainer = AuthToken.Data.Cookies
        Dim request = New RestSharp.RestRequest("jobs/responsivepath/" & Guid.Parse(JobID).ToString, Method.POST)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        request.AddHeader("Accept", "application/json")
        request.Parameters.Clear()
        request.AddParameter("application/json", JobID, ParameterType.RequestBody)
        Dim response As RestSharp.RestResponse = client.Execute(request)
        Select Case response.StatusCode
            Case Is > 200 < 400
                Return response.Content

            Case Is >= 400
                Return "Error: " & response.ErrorMessage
            Case Else
                Return "Error: " & response.ErrorMessage
        End Select

        Return "If You See This.... JobSetResponsivePath"
    End Function



End Class
