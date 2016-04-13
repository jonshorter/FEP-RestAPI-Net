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

    Public Function GetFidelisXpsBaseUrl() As ApiResponse(Of String)

        Dim request = New RestSharp.RestRequest("configuration/GetFidelisXpsBaseUrl", Method.GET)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        request.AddHeader("Authorization", "bearer " & Client.Token)
        Dim response As RestSharp.RestResponse = Client.RestClient.Execute(request)
        Client.UpdateToken(response.Headers)
        Return JsonConvert.DeserializeObject(Of ApiResponse(Of String))(response.Content)

    End Function

    Public Function IsFipsComplianceEnabled() As ApiResponse(Of String)

        Dim request = New RestSharp.RestRequest("configuration/IsFipsComplianceEnabled", Method.GET)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        request.AddHeader("Authorization", "bearer " & Client.Token)
        Dim response As RestSharp.RestResponse = Client.RestClient.Execute(request)
        Client.UpdateToken(response.Headers)
        Return JsonConvert.DeserializeObject(Of ApiResponse(Of String))(response.Content)

    End Function


    Public Function ProductInfo() As ApiResponse(Of String)

        Dim request = New RestSharp.RestRequest("product-info", Method.GET)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        request.AddHeader("Authorization", "bearer " & Client.Token)
        Dim response As RestSharp.RestResponse = Client.RestClient.Execute(request)
        Client.UpdateToken(response.Headers)
        Return JsonConvert.DeserializeObject(Of ApiResponse(Of String))(response.Content)

    End Function

    Public Function getConfig() As ApiResponse(Of String)

        Dim request = New RestSharp.RestRequest("config/getConfig", Method.GET)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        request.AddHeader("Authorization", "bearer " & Client.Token)
        Dim response As RestSharp.RestResponse = Client.RestClient.Execute(request)
        Client.UpdateToken(response.Headers)
        Return JsonConvert.DeserializeObject(Of ApiResponse(Of String))(response.Content)

    End Function


End Class


