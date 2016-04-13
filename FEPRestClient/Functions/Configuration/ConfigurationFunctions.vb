Imports RestSharp
Imports Newtonsoft.Json
Imports FEPRestClient.Models.Response
Imports FEPRestClient.Models.Project
Imports FEPRestClient.Models.Report
Imports FEPRestClient.Models.Job
Imports FEPRestClient.Models


Public Class ConfigurationFunctions
    Public Function IsIWAMode() As ApiResponse(Of Boolean)
      
        Dim request = New RestSharp.RestRequest("configuration/IsIWAMode", Method.GET)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        request.AddHeader("Authorization", "bearer " & Client.Token)
        Dim response As RestSharp.RestResponse = Client.RestClient.Execute(request)
        Client.UpdateToken(response.Headers)
        Return JsonConvert.DeserializeObject(Of ApiResponse(Of Boolean))(response.Content)

    End Function
    Public Function GetDefaultJobDataPath() As ApiResponse(Of String)
        
        Dim request = New RestSharp.RestRequest("configuration/getConfigurationType/DefaultCaseCollectedFilePath", Method.GET)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        request.AddHeader("Authorization", "bearer " & Client.Token)
        Dim response As RestSharp.RestResponse = Client.RestClient.Execute(request)
        Client.UpdateToken(response.Headers)
        Return JsonConvert.DeserializeObject(Of ApiResponse(Of String))(response.Content)
    End Function
    Public Function GetDefaultProjectsPath() As ApiResponse(Of String)
       
        Dim request = New RestSharp.RestRequest("configuration/getConfigurationType/FTKDefaultPath", Method.GET)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        request.AddHeader("Authorization", "bearer " & Client.Token)
        Dim response As RestSharp.RestResponse = Client.RestClient.Execute(request)
        Client.UpdateToken(response.Headers)
        Return JsonConvert.DeserializeObject(Of ApiResponse(Of String))(response.Content)

    End Function


End Class


