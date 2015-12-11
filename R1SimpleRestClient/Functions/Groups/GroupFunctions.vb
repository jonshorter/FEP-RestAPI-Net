Imports RestSharp
Imports Newtonsoft.Json
Imports R1SimpleRestClient.Models.Response
Imports R1SimpleRestClient.Models.Project
Imports R1SimpleRestClient.Models.Report
Imports R1SimpleRestClient.Models.Job
Imports R1SimpleRestClient.Models


Public Class GroupFunctions

    Public Function GetGroups(ByVal AuthToken As Models.Response.AuthToken, ByVal Server As String) As ApiResponse(Of Groups)
        Dim client As New RestSharp.RestClient("https://" & Server & "/R1/api")
        client.CookieContainer = AuthToken.Data
        Dim request = New RestSharp.RestRequest("groups", Method.GET)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        Dim response As RestSharp.RestResponse = client.Execute(request)
        Return JsonConvert.DeserializeObject(Of ApiResponse(Of Groups))(response.Content)
    End Function



End Class


