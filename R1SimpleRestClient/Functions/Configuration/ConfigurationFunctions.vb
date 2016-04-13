Imports RestSharp
Imports Newtonsoft.Json
Imports FEPRestClient.Models.Response
Imports FEPRestClient.Models.Project
Imports FEPRestClient.Models.Report
Imports FEPRestClient.Models.Job
Imports FEPRestClient.Models


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


