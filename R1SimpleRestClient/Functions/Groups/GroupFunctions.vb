Imports RestSharp
Imports Newtonsoft.Json
Imports FEPRestClient.Models.Response
Imports FEPRestClient.Models.Project
Imports FEPRestClient.Models.Report
Imports FEPRestClient.Models.Job
Imports FEPRestClient.Models


Public Class GroupFunctions

    Public Function GetGroups(ByVal AuthToken As Models.Response.AuthToken, ByVal Server As String) As ApiResponse(Of Groups)
        Dim client As New RestSharp.RestClient("https://" & Server & "/R1/api")
        client.CookieContainer = AuthToken.Data.Cookies
        Dim request = New RestSharp.RestRequest("groups", Method.GET)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        Dim response As RestSharp.RestResponse = client.Execute(request)
        Return JsonConvert.DeserializeObject(Of ApiResponse(Of Groups))(response.Content)
    End Function



End Class


