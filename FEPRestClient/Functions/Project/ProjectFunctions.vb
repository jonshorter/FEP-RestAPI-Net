﻿Imports RestSharp
Imports Newtonsoft.Json
Imports FEPRestClient.Models.Response
Imports FEPRestClient.Models.Project
Imports FEPRestClient.Models.Report
Imports FEPRestClient.Models.Job
Imports FEPRestClient.Models


Public Class ProjectFunctions

    Public Function GetProjectFacets(Optional ByVal OptionLimit As Integer = 15) As ApiResponse(Of List(Of Facets))

        Dim request = New RestSharp.RestRequest("projectFacets/getprojectsfacets?optionLimit=" & OptionLimit, Method.GET)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        request.AddHeader("Authorization", "bearer " & Client.Token)
        Dim response As RestSharp.RestResponse = Client.RestClient.Execute(request)
        Client.UpdateToken(response.Headers)
        Return JsonConvert.DeserializeObject(Of Models.Response.ApiResponse(Of List(Of Facets)))(response.Content)

    End Function
    Public Function GetProjectList(Optional FacetSearchVar As FacetSearch = Nothing) As ApiResponse(Of List(Of ProjectPresenter))
        Dim Search = ""
        If Not FacetSearchVar Is Nothing Then
            Search = "?facetSearch=" & Newtonsoft.Json.JsonConvert.SerializeObject(FacetSearchVar)
        End If
        Dim request = New RestSharp.RestRequest("projects" & Search, Method.GET)
        request.AddHeader("Authorization", "bearer " & Client.Token)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        Dim response As RestSharp.RestResponse = Client.RestClient.Execute(request)
        Client.UpdateToken(response.Headers)
        Return JsonConvert.DeserializeObject(Of ApiResponse(Of List(Of ProjectPresenter)))(response.Content)

    End Function

    Public Function GetProjectDetails(ByVal ProjectID As String) As ApiResponse(Of ProjectPresenter)

        Dim request = New RestSharp.RestRequest("projects/" & ProjectID, Method.GET)
        request.AddHeader("Authorization", "bearer " & Client.Token)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        Dim response As RestSharp.RestResponse = Client.RestClient.Execute(request)
        Client.UpdateToken(response.Headers)
        Return JsonConvert.DeserializeObject(Of Models.Response.ApiResponse(Of ProjectPresenter))(response.Content)


    End Function

    Public Function GetProjectReports(ByVal ProjectID As String) As ApiResponse(Of List(Of Models.Report.BasicReport))

        Dim request = New RestSharp.RestRequest("projects/" & ProjectID & "/reports/GetProjectReports", Method.GET)
        request.AddHeader("Authorization", "bearer " & Client.Token)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        Dim response As RestSharp.RestResponse = Client.RestClient.Execute(request)
        Client.UpdateToken(response.Headers)
        Return JsonConvert.DeserializeObject(Of Models.Response.ApiResponse(Of List(Of Models.Report.BasicReport)))(response.Content)

    End Function

    Public Function DeleteProject(ByVal ProjectID As String) As ApiResponse(Of Boolean)

        Dim request = New RestSharp.RestRequest("projects/" & ProjectID, Method.DELETE)
        request.AddHeader("Authorization", "bearer " & Client.Token)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        Dim response As RestSharp.RestResponse = Client.RestClient.Execute(request)
        Client.UpdateToken(response.Headers)
        Return JsonConvert.DeserializeObject(Of Models.Response.ApiResponse(Of Boolean))(response.Content)

    End Function

    Public Function GetJobsForProject(ByVal ProjectID As Long) As ApiResponse(Of List(Of JobInfo57))

        Dim request = New RestSharp.RestRequest("jobs/" & ProjectID, Method.GET)
        request.AddHeader("Authorization", "bearer " & Client.Token)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        Dim response As RestSharp.RestResponse = Client.RestClient.Execute(request)
        Client.UpdateToken(response.Headers)
        Return JsonConvert.DeserializeObject(Of Models.Response.ApiResponse(Of List(Of JobInfo57)))(response.Content)

    End Function



    Public Function CreateProject(ByVal NewProject As NewProjectDefinition) As ApiResponse(Of NewProjectDefinition)

        Dim request = New RestSharp.RestRequest("projects", Method.POST)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        request.AddHeader("Accept", "application/json")
        request.Parameters.Clear()
        request.AddParameter("application/json", Newtonsoft.Json.JsonConvert.SerializeObject(NewProject), ParameterType.RequestBody)
        request.AddHeader("Authorization", "bearer " & Client.Token)
        Dim response As RestSharp.RestResponse = Client.RestClient.Execute(request)
        Client.UpdateToken(response.Headers)
        Return JsonConvert.DeserializeObject(Of Models.Response.ApiResponse(Of NewProjectDefinition))(response.Content)

    End Function

    Public Function CreateProjectSimple(ByVal NewProject As SimpleNewProject) As ApiResponse(Of NewProjectDefinition)

        Dim request = New RestSharp.RestRequest("projects", Method.POST)
        request.AddHeader("Authorization", "bearer " & Client.Token)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        request.AddHeader("Accept", "application/json")
        request.Parameters.Clear()
        request.AddParameter("application/json", Newtonsoft.Json.JsonConvert.SerializeObject(NewProject), ParameterType.RequestBody)
        Dim response As RestSharp.RestResponse = Client.RestClient.Execute(request)
        Client.UpdateToken(response.Headers)
        Return JsonConvert.DeserializeObject(Of Models.Response.ApiResponse(Of NewProjectDefinition))(response.Content)

    End Function
    Public Function UpdateProject(ByVal UpdatedProject As ProjectPresenter) As ApiResponse(Of ProjectPresenter)

        Dim request = New RestSharp.RestRequest("projects", Method.PUT)
        request.AddHeader("Authorization", "bearer " & Client.Token)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        request.AddHeader("Accept", "application/json")
        request.Parameters.Clear()
        request.AddParameter("application/json", Newtonsoft.Json.JsonConvert.SerializeObject(UpdatedProject), ParameterType.RequestBody)
        Dim response As RestSharp.RestResponse = Client.RestClient.Execute(request)
        Client.UpdateToken(response.Headers)
        Return JsonConvert.DeserializeObject(Of Models.Response.ApiResponse(Of ProjectPresenter))(response.Content)

    End Function
    Public Function GetJobResultReports(ByVal ProjectID As Long, ByVal JobID As String)

        Dim request = New RestSharp.RestRequest("projects/" & ProjectID & "/jobs/jobresultreports/" & JobID & "/", Method.GET)
        request.AddHeader("Authorization", "bearer " & Client.Token)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        Dim response As RestSharp.RestResponse = Client.RestClient.Execute(request)
        Client.UpdateToken(response.Headers)
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
    Public Function GetJobResultsReportStatus(ByVal ProjectID As Long, ByVal JobID As String) As ApiResponse(Of JobReportDataStatus)

        Dim request = New RestSharp.RestRequest("projects/" & ProjectID & "/jobs/jobresultsreportstatus/" & JobID & "/", Method.GET)
        request.AddHeader("Authorization", "bearer " & Client.Token)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        Dim response As RestSharp.RestResponse = Client.RestClient.Execute(request)
        Client.UpdateToken(response.Headers)
        Return JsonConvert.DeserializeObject(Of Models.Response.ApiResponse(Of JobReportDataStatus))(response.Content)

    End Function
    Public Function GenerateJobDetailsReport(ByVal ProjectID As Long, ByVal JobID As String) As ApiResponse(Of JobReportDataStatus)

        Dim request = New RestSharp.RestRequest("projects/" & ProjectID & "/jobs/generatejobdetailsreport/" & JobID, Method.GET)
        request.AddHeader("Authorization", "bearer " & Client.Token)
        request.AddUrlSegment("id", JobID)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        Dim response As RestSharp.RestResponse = Client.RestClient.Execute(request)
        Client.UpdateToken(response.Headers)
        Return JsonConvert.DeserializeObject(Of Models.Response.ApiResponse(Of JobReportDataStatus))(response.Content)

    End Function



End Class


