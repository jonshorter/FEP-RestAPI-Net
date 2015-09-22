﻿Imports RestSharp
Imports Newtonsoft.Json
Imports R1SimpleRestClient.Models.Response
Imports R1SimpleRestClient.Models.Project
Imports R1SimpleRestClient.Models.Report
Imports R1SimpleRestClient.Models.Job
Imports R1SimpleRestClient.Models


Public Class JobFunctions
    Public Function CreateJob(ByVal AuthToken As Response.AuthToken, ByVal Server As String, ByVal Job As JobDefinitionModel)
        Dim client As New RestSharp.RestClient("https://" & Server & "/R1/api")
        client.CookieContainer = AuthToken.Data
        Dim request = New RestSharp.RestRequest("jobs", Method.PUT)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        request.AddHeader("Accept", "application/json")
        request.Parameters.Clear()
        request.AddParameter("application/json", Newtonsoft.Json.JsonConvert.SerializeObject(Job), ParameterType.RequestBody)
        Dim response As RestSharp.RestResponse = client.Execute(request)
        Select Case response.StatusCode
            Case Is > 200 < 400
                Dim apiresponse = JsonConvert.DeserializeObject(Of Models.Response.ApiResponse(Of List(Of JobInfo57)))(response.Content)
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

        Return "If You See This.... CreateJob"

    End Function

    Public Function GetAllJobs(ByVal AuthToken As Models.Response.AuthToken, ByVal Server As String, Optional ByVal skip As Integer = 0, Optional ByVal take As Integer = 0, Optional ByVal sort As String = "CreatedDate Descending", Optional ByVal search As String = "")

        Dim client As New RestSharp.RestClient("https://" & Server & "/R1/api/jobs")
        client.CookieContainer = AuthToken.Data



        Dim request = New RestSharp.RestRequest("getalljobs/" & skip & "/" & take & "/" & sort & "/" & search, Method.GET)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        Dim response As RestSharp.RestResponse = client.Execute(request)
        Select Case response.StatusCode
            Case Is > 200 < 400
                Dim apiresponse = JsonConvert.DeserializeObject(Of Models.Response.ApiResponse(Of JobData))(response.Content)
                Select Case apiresponse.Success
                    Case True
                        Return apiresponse
                    Case False
                        Return "Error: " & apiresponse.Error.Message.ToString
                End Select
            Case Is >= 400
                Return "Error: " & response.ErrorMessage
            Case Else
                Return "Error: " & response.ErrorMessage
        End Select

        Return "If You See This.... GetAllJobs"
    End Function

    Public Function GetResponsivePath(ByVal AuthToken As Response.AuthToken, ByVal Server As String, ByVal JobID As String)
        Dim client As New RestSharp.RestClient("https://" & Server & "/R1/api")
        client.CookieContainer = AuthToken.Data
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

    Public Function SetResponsivePath(ByVal AuthToken As Response.AuthToken, ByVal Server As String, ByVal JobID As String)
        Dim client As New RestSharp.RestClient("https://" & Server & "/R1/api")
        client.CookieContainer = AuthToken.Data
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
