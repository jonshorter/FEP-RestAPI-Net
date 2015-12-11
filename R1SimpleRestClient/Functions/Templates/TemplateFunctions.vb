Imports RestSharp
Imports Newtonsoft.Json
Imports R1SimpleRestClient.Models.Response
Imports R1SimpleRestClient.Models.Project
Imports R1SimpleRestClient.Models.Report
Imports R1SimpleRestClient.Models.Job
Imports R1SimpleRestClient.Models


Public Class TemplateFunctions

    Public Function GetTemplates(ByVal AuthToken As Models.Response.AuthToken, ByVal Server As String) _
        As ApiResponse(Of List(Of Templates.Templates))
        Dim client As New RestSharp.RestClient("https://" & Server & "/R1/api")
        client.CookieContainer = AuthToken.Data.Cookies
        Dim request = New RestSharp.RestRequest("templates", Method.GET)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        Dim response As RestSharp.RestResponse = client.Execute(request)
        Dim apiresponse = JsonConvert.DeserializeObject(Of ApiResponse(Of List(Of Templates.Templates)))(response.Content)
        Return apiresponse
     
    End Function

    Public Function GetCategories(ByVal AuthToken As Models.Response.AuthToken, ByVal Server As String) _
        As ApiResponse(Of List(Of Templates.Categories))
        Dim client As New RestSharp.RestClient("https://" & Server & "/R1/api")
        client.CookieContainer = AuthToken.Data.Cookies
        Dim request = New RestSharp.RestRequest("templates/categories", Method.GET)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        Dim response As RestSharp.RestResponse = client.Execute(request)
        Dim apiresponse = JsonConvert.DeserializeObject(Of ApiResponse(Of List(Of Templates.Categories)))(response.Content)
        Return apiresponse
       
    End Function



    Public Function GetTemplate(ByVal AuthToken As Models.Response.AuthToken, ByVal Server As String, ByVal templateid As String) _
        As ApiResponse(Of Templates.TemplateInformation)

        Dim client As New RestSharp.RestClient("https://" & Server & "/R1/api")
        client.CookieContainer = AuthToken.Data.Cookies
        Dim request = New RestSharp.RestRequest("templates/" & templateid, Method.GET)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        Dim response As RestSharp.RestResponse = client.Execute(request)
        Dim apiresponse = JsonConvert.DeserializeObject(Of ApiResponse(Of Templates.TemplateInformation))(response.Content)
        Return apiresponse
    End Function



End Class


