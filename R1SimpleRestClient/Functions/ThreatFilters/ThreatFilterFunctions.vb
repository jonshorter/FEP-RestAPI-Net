Imports RestSharp
Imports Newtonsoft.Json
Imports FEPRestClient.Models.Response
Imports FEPRestClient.Models.Project
Imports FEPRestClient.Models.Report
Imports FEPRestClient.Models.Job
Imports FEPRestClient.Models


Public Class ThreatFilterFunctions
    Public Function GetThreatFilters(Optional page As Integer = 1, Optional count As Integer = 100, Optional filter As String = "") As ApiResponse(Of List(Of ThreatFilters.ThreatFilterInfo))


        If Not filter = "" Then
            filter = "&filter=" & filter
        End If

        Dim request = New RestSharp.RestRequest("threatfilters/" & page & "?count=" & count & filter, Method.GET)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        request.AddHeader("Authorization", "bearer " & Client.Token)
        Dim response As RestSharp.RestResponse = Client.RestClient.Execute(request)
        Client.UpdateToken(response.Headers)
        Dim apiresponse = JsonConvert.DeserializeObject(Of ApiResponse(Of List(Of ThreatFilters.ThreatFilterInfo)))(response.Content)
        Return apiresponse

    End Function

    Public Function GetThreatFilterIDs() As ApiResponse(Of List(Of Integer))

        Dim request = New RestSharp.RestRequest("threatfilters/ids", Method.GET)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        request.AddHeader("Authorization", "bearer " & Client.Token)
        Dim response As RestSharp.RestResponse = Client.RestClient.Execute(request)
        Client.UpdateToken(response.Headers)
        Dim apiresponse = JsonConvert.DeserializeObject(Of ApiResponse(Of List(Of Integer)))(response.Content)
        Return apiresponse

    End Function

End Class


