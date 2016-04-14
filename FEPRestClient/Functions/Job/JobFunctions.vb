Imports RestSharp
Imports Newtonsoft.Json
Imports FEPRestClient.Models.Response
Imports FEPRestClient.Models.Project
Imports FEPRestClient.Models.Report
Imports FEPRestClient.Models.Job
Imports FEPRestClient.Models
Imports FEPRestClient.Models.Job2
Imports FEPRestClient.Models.Enums


Public Class JobFunctions
    Public Function CreateJob(ByVal Job As JobDefinitionModel) As ApiResponse(Of List(Of JobInfo57))
     
        Dim request = New RestSharp.RestRequest("jobs", Method.PUT)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        request.AddHeader("Accept", "application/json")
        request.Parameters.Clear()
        request.AddParameter("application/json", Newtonsoft.Json.JsonConvert.SerializeObject(Job), ParameterType.RequestBody)
        request.AddHeader("Authorization", "bearer " & Client.Token)
        Dim response As RestSharp.RestResponse = Client.RestClient.Execute(request)
        Client.UpdateToken(response.Headers)
        Return JsonConvert.DeserializeObject(Of Models.Response.ApiResponse(Of List(Of JobInfo57)))(response.Content)

    End Function

    Public Function GetSetJobStatus(ByVal JobID As String, Optional Status As JobAction = JobAction.Status) As ApiResponse(Of List(Of JobStatus))
       
        Dim request = New RestSharp.RestRequest("jobs/" & JobID & "/" & Status, Method.GET)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        request.AddHeader("Accept", "application/json")
        request.Parameters.Clear()
        request.AddHeader("Authorization", "bearer " & Client.Token)
        Dim response As RestSharp.RestResponse = Client.RestClient.Execute(request)
        Client.UpdateToken(response.Headers)
        Return JsonConvert.DeserializeObject(Of Models.Response.ApiResponse(Of List(Of JobStatus)))(response.Content)

    End Function

    Public Function CreateJobFromTemplate(ByVal Job As JobFromTemplate, ByVal Execute As Boolean) As ApiResponse(Of String)
     
        Dim request = New RestSharp.RestRequest("jobs/createFromTemplate/" & Execute, Method.POST)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        request.AddHeader("Accept", "application/json")
        request.Parameters.Clear()
        request.AddParameter("application/json", Newtonsoft.Json.JsonConvert.SerializeObject(Job), ParameterType.RequestBody)
        request.AddHeader("Authorization", "bearer " & Client.Token)
        Dim response As RestSharp.RestResponse = Client.RestClient.Execute(request)
        Client.UpdateToken(response.Headers)
        Return JsonConvert.DeserializeObject(Of Models.Response.ApiResponse(Of String))(response.Content)
    End Function

    Public Function ResubmitJob(ByVal Job As ResubmitJobOptions) As ApiResponse(Of String)
       
        Dim request = New RestSharp.RestRequest("jobs/resubmitJob/", Method.POST)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        request.AddHeader("Accept", "application/json")
        request.Parameters.Clear()
        request.AddParameter("application/json", Newtonsoft.Json.JsonConvert.SerializeObject(Job), ParameterType.RequestBody)
        request.AddHeader("Authorization", "bearer " & Client.Token)
        Dim response As RestSharp.RestResponse = Client.RestClient.Execute(request)
        Client.UpdateToken(response.Headers)
        Return JsonConvert.DeserializeObject(Of Models.Response.ApiResponse(Of String))(response.Content)
    End Function

    Public Function GetAllJobs(Optional ByVal skip As Integer = 0, _
                               Optional ByVal take As Integer = 0, Optional ByVal sort As String = "CreatedDate Descending", _
                               Optional ByVal FacetSearchvar As Models.FacetSearch = Nothing) As ApiResponse(Of JobData)
        Dim Search = ""
        If Not FacetSearchVar Is Nothing Then
            Search = "?Search=" & Newtonsoft.Json.JsonConvert.SerializeObject(FacetSearchvar)
        End If
        Dim request = New RestSharp.RestRequest("jobs/getalljobs/" & skip & "/" & take & "/" & sort & Search, Method.GET)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        request.AddHeader("Authorization", "bearer " & Client.Token)
        Dim response As RestSharp.RestResponse = Client.RestClient.Execute(request)
        Client.UpdateToken(response.Headers)
        Return JsonConvert.DeserializeObject(Of Models.Response.ApiResponse(Of JobData))(response.Content)

    End Function
    Public Function GetJobResultsFacets(Optional ByVal OptionLimit As Integer = 15) As ApiResponse(Of List(Of Facets))

        Dim request = New RestSharp.RestRequest("jobs/getjobresultsfacets?optionLimit=" & OptionLimit, Method.GET)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        request.AddHeader("Authorization", "bearer " & Client.Token)
        Dim response As RestSharp.RestResponse = Client.RestClient.Execute(request)
        Client.UpdateToken(response.Headers)
        Return JsonConvert.DeserializeObject(Of Models.Response.ApiResponse(Of List(Of Facets)))(response.Content)

    End Function

    Public Function GetJobEndpointStatusCounts(ByVal jobResultID As String) As ApiResponse(Of Models.Job2.EndPointStatusCounts)

        Dim request = New RestSharp.RestRequest("jobs/getendpointstatuscounts/" & jobResultID, Method.GET)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        request.AddHeader("Authorization", "bearer " & Client.Token)
        Dim response As RestSharp.RestResponse = Client.RestClient.Execute(request)
        Client.UpdateToken(response.Headers)
        Return JsonConvert.DeserializeObject(Of ApiResponse(Of Models.Job2.EndPointStatusCounts))(response.Content)

    End Function

    Public Function GetJobResults(ByVal JobResultId As String, Optional Page As Integer = 1, Optional Count As Integer = 100, _
                                  Optional sortPropertyName As String = "_EndpointName", Optional isSortDescending As Boolean = False) As ElasticSearchResult
        Dim options As String
        options = "?page=" & Page
        options = options & "&count=" & Count
        options = options & "&sortPropertyName=" & sortPropertyName
        options = options & "&isSortDescending=" & isSortDescending

        Dim request = New RestSharp.RestRequest("jobresults/scriptjob_" & JobResultId & "/" & options, Method.POST)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        request.AddHeader("Authorization", "bearer " & Client.Token)
        Dim response As RestSharp.RestResponse = Client.RestClient.Execute(request)
        Client.UpdateToken(response.Headers)
        Dim elasticresponse = JsonConvert.DeserializeObject(Of Models.Response.ApiResponse(Of String))(response.Content)

        Dim y = JsonConvert.DeserializeObject(Of Models.ElasticSearchResult)(elasticresponse.Data)

        Return y

    End Function

    Public Function GetJobTargetResultsFacets(ByVal jobResultID As String, Optional ByVal OptionLimit As Integer = 15) As ApiResponse(Of List(Of Facets))

        Dim request = New RestSharp.RestRequest("jobs/getjobtargetresultsfacets/" & jobResultID & "?optionLimit=" & OptionLimit, Method.GET)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        request.AddHeader("Authorization", "bearer " & Client.Token)
        Dim response As RestSharp.RestResponse = Client.RestClient.Execute(request)
        Client.UpdateToken(response.Headers)
        Return JsonConvert.DeserializeObject(Of Models.Response.ApiResponse(Of List(Of Facets)))(response.Content)

    End Function

    Public Function GetJobStatus(ByVal JobID As String) As ApiResponse(Of JobInfo)

        Dim request = New RestSharp.RestRequest("jobs/getjobstatus/" & JobID, Method.GET)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        request.AddHeader("Authorization", "bearer " & Client.Token)
        Dim response As RestSharp.RestResponse = Client.RestClient.Execute(request)
        Client.UpdateToken(response.Headers)
        Return JsonConvert.DeserializeObject(Of Models.Response.ApiResponse(Of JobInfo))(response.Content)

    End Function

    Public Function CancelJobResult(ByVal JobResultID As String, ByVal CancelSchedule As Boolean) As ApiResponse(Of JobInfo)


        Dim request = New RestSharp.RestRequest("jobs/cancelJobResult/" & JobResultID & "/" & CancelSchedule, Method.GET)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        request.AddHeader("Authorization", "bearer " & Client.Token)
        Dim response As RestSharp.RestResponse = Client.RestClient.Execute(request)
        Client.UpdateToken(response.Headers)
        Return JsonConvert.DeserializeObject(Of Models.Response.ApiResponse(Of JobInfo))(response.Content)

    End Function

    Public Function CancelJobTargetResults(ByVal JobTargetResultID As List(Of String)) As ApiResponse(Of Boolean)


        Dim request = New RestSharp.RestRequest("jobs/cancelJobTargetResults/", Method.POST)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        request.AddHeader("Accept", "application/json")
        request.Parameters.Clear()
        request.AddParameter("application/json", Newtonsoft.Json.JsonConvert.SerializeObject(JobTargetResultID), ParameterType.RequestBody)
        request.AddHeader("Authorization", "bearer " & Client.Token)
        Dim response As RestSharp.RestResponse = Client.RestClient.Execute(request)
        Client.UpdateToken(response.Headers)
        Return JsonConvert.DeserializeObject(Of Models.Response.ApiResponse(Of Boolean))(response.Content)

    End Function

    Public Function SetJobSchedule(ByVal JobID As String, ByVal IsIncremental As Boolean, ByVal Schedule As SchedulerEventCore) As ApiResponse(Of SchedulerEventCore)


        Dim request = New RestSharp.RestRequest("jobs/jobSchedule/" & JobID & "/" & IsIncremental, Method.POST)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        request.AddHeader("Accept", "application/json")
        request.Parameters.Clear()
        request.AddParameter("application/json", Newtonsoft.Json.JsonConvert.SerializeObject(Schedule), ParameterType.RequestBody)
        request.AddHeader("Authorization", "bearer " & Client.Token)
        Dim response As RestSharp.RestResponse = Client.RestClient.Execute(request)
        Client.UpdateToken(response.Headers)
        Return JsonConvert.DeserializeObject(Of Models.Response.ApiResponse(Of SchedulerEventCore))(response.Content)

    End Function

    Public Function ThreatScanOptioms(ByVal JobResultID As String, ByVal TSOptions As Job2.ThreatScanJobOptions) As ApiResponse(Of Boolean)


        Dim request = New RestSharp.RestRequest("jobs/threatScanOptions/" & JobResultID, Method.POST)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        request.AddHeader("Accept", "application/json")
        request.Parameters.Clear()
        request.AddParameter("application/json", Newtonsoft.Json.JsonConvert.SerializeObject(TSOptions), ParameterType.RequestBody)
        request.AddHeader("Authorization", "bearer " & Client.Token)
        Dim response As RestSharp.RestResponse = Client.RestClient.Execute(request)
        Client.UpdateToken(response.Headers)
        Return JsonConvert.DeserializeObject(Of Models.Response.ApiResponse(Of Boolean))(response.Content)

    End Function

    Public Function GetJobStatusCounts(ByVal JobID As String) As ApiResponse(Of JobInfoStatusCounts)


        Dim request = New RestSharp.RestRequest("jobs/getjobendpointstatuscounts/" & JobID, Method.GET)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        request.AddHeader("Authorization", "bearer " & Client.Token)
        Dim response As RestSharp.RestResponse = Client.RestClient.Execute(request)
        Client.UpdateToken(response.Headers)
        Return JsonConvert.DeserializeObject(Of Models.Response.ApiResponse(Of JobInfoStatusCounts))(response.Content)

    End Function


    Public Function GetTargetStatus(ByVal JobID As String, ByVal ItemID As String) As ApiResponse(Of JobTargetsInfo)

        Dim request = New RestSharp.RestRequest("jobs/gettargetstatus/" & JobID & "/" & ItemID, Method.GET)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        request.AddHeader("Authorization", "bearer " & Client.Token)
        Dim response As RestSharp.RestResponse = Client.RestClient.Execute(request)
        Client.UpdateToken(response.Headers)
        Return JsonConvert.DeserializeObject(Of Models.Response.ApiResponse(Of JobTargetsInfo))(response.Content)

    End Function


    Public Function GetResponsivePath(ByVal JobID As String)

        Dim request = New RestSharp.RestRequest("jobs/responsivepath/" & Guid.Parse(JobID).ToString, Method.GET)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        request.AddHeader("Accept", "application/json")
        request.Parameters.Clear()
        request.AddParameter("application/json", JobID, ParameterType.RequestBody)
        request.AddHeader("Authorization", "bearer " & Client.Token)
        Dim response As RestSharp.RestResponse = Client.RestClient.Execute(request)
        Client.UpdateToken(response.Headers)
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

    Public Function GetJobTargets(ByVal JobID As String _
                                 , Optional ByVal skip As Integer = 0, _
                               Optional ByVal take As Integer = 75, Optional ByVal sort As String = "Name Ascending", _
                               Optional ByVal search As String = "") As ApiResponse(Of JobTargets)


        Dim request = New RestSharp.RestRequest("jobs/getjobtargets/" & JobID & "/" & skip & "/" & take & "/" & sort & "?search=" & search, Method.GET)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        request.AddHeader("Authorization", "bearer " & Client.Token)
        Dim response As RestSharp.RestResponse = Client.RestClient.Execute(request)
        Client.UpdateToken(response.Headers)
        Return JsonConvert.DeserializeObject(Of Models.Response.ApiResponse(Of JobTargets))(response.Content)

    End Function

    Public Function SetResponsivePath(ByVal JobID As String)

        Dim request = New RestSharp.RestRequest("jobs/responsivepath/" & Guid.Parse(JobID).ToString, Method.POST)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        request.AddHeader("Accept", "application/json")
        request.Parameters.Clear()
        request.AddParameter("application/json", JobID, ParameterType.RequestBody)
        request.AddHeader("Authorization", "bearer " & Client.Token)
        Dim response As RestSharp.RestResponse = Client.RestClient.Execute(request)
        Client.UpdateToken(response.Headers)
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
