Imports RestSharp
Imports Newtonsoft.Json
Imports R1SimpleRestClient.Models.Response
Imports R1SimpleRestClient.Models.Project
Imports R1SimpleRestClient.Models.Report
Imports R1SimpleRestClient.Models.Job
Imports R1SimpleRestClient.Models


Public Class ConfigurationFunctions
    Public Function IsIWAMode(ByVal AuthToken As Models.Response.AuthToken, ByVal Server As String) As ApiResponse(Of Boolean)
        Dim client As New RestSharp.RestClient("https://" & Server & "/R1/api")
        client.CookieContainer = AuthToken.Data.Cookies
        Dim request = New RestSharp.RestRequest("configuration/IsIWAMode", Method.GET)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        Dim response As RestSharp.RestResponse = client.Execute(request)
        Return JsonConvert.DeserializeObject(Of ApiResponse(Of Boolean))(response.Content)

    End Function
    Public Function GetDefaultJobDataPath(ByVal AuthToken As Models.Response.AuthToken, ByVal Server As String) As ApiResponse(Of String)
        Dim client As New RestSharp.RestClient("https://" & Server & "/R1/api")
        client.CookieContainer = AuthToken.Data.Cookies
        Dim request = New RestSharp.RestRequest("configuration/getConfigurationType/DefaultCaseCollectedFilePath", Method.GET)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        Dim response As RestSharp.RestResponse = client.Execute(request)
        Return JsonConvert.DeserializeObject(Of ApiResponse(Of String))(response.Content)
    End Function
    Public Function GetDefaultProjectsPath(ByVal AuthToken As Models.Response.AuthToken, ByVal Server As String) As ApiResponse(Of String)
        Dim client As New RestSharp.RestClient("https://" & Server & "/R1/api")
        client.CookieContainer = AuthToken.Data.Cookies
        Dim request = New RestSharp.RestRequest("configuration/getConfigurationType/FTKDefaultPath", Method.GET)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        Dim response As RestSharp.RestResponse = client.Execute(request)
        Return JsonConvert.DeserializeObject(Of ApiResponse(Of String))(response.Content)

    End Function


End Class


