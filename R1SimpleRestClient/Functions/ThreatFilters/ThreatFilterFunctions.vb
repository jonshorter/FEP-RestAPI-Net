Imports RestSharp
Imports Newtonsoft.Json
Imports R1SimpleRestClient.Models.Response
Imports R1SimpleRestClient.Models.Project
Imports R1SimpleRestClient.Models.Report
Imports R1SimpleRestClient.Models.Job
Imports R1SimpleRestClient.Models


Public Class ThreatFilterFunctions
    Public Function GetThreatFilters(ByVal AuthToken As Models.Response.AuthToken, ByVal Server As String, _
                                        Optional page As Integer = 1, Optional count As Integer = 100, Optional filter As String = "") As ApiResponse(Of List(Of ThreatFilters.ThreatFilterInfo))

        Dim client As New RestSharp.RestClient("https://" & Server & "/R1/api")
        client.CookieContainer = AuthToken.Data.Cookies

        If Not filter = "" Then
            filter = "&filter=" & filter
        End If

        Dim request = New RestSharp.RestRequest("threatfilters/" & page & "?count=" & count & filter, Method.GET)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        Dim response As RestSharp.RestResponse = client.Execute(request)
        Dim apiresponse = JsonConvert.DeserializeObject(Of ApiResponse(Of List(Of ThreatFilters.ThreatFilterInfo)))(response.Content)
        Return apiresponse

    End Function

    Public Function GetThreatFilterIDs(ByVal AuthToken As Models.Response.AuthToken, ByVal Server As String _
                                   ) As ApiResponse(Of List(Of Integer))

        Dim client As New RestSharp.RestClient("https://" & Server & "/R1/api")
        client.CookieContainer = AuthToken.Data.Cookies

        Dim request = New RestSharp.RestRequest("threatfilters/ids", Method.GET)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        Dim response As RestSharp.RestResponse = client.Execute(request)
        Dim apiresponse = JsonConvert.DeserializeObject(Of ApiResponse(Of List(Of Integer)))(response.Content)
        Return apiresponse
        
    End Function

End Class


