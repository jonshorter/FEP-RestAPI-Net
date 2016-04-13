Imports RestSharp
Imports Newtonsoft.Json
Imports FEPRestClient.Models.Response
Imports FEPRestClient.Models.Project
Imports FEPRestClient.Models.Report
Imports FEPRestClient.Models.Job
Imports FEPRestClient.Models


Public Class TemplateFunctions

    Public Function GetTemplates() As ApiResponse(Of List(Of Templates.Templates))

        Dim request = New RestSharp.RestRequest("templates", Method.GET)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        request.AddHeader("Authorization", "bearer " & Client.Token)
        Dim response As RestSharp.RestResponse = Client.RestClient.Execute(request)
        Client.UpdateToken(response.Headers)
        Dim apiresponse = JsonConvert.DeserializeObject(Of ApiResponse(Of List(Of Templates.Templates)))(response.Content)
        Return apiresponse

    End Function

    Public Function GetTemplateIdByName(ByVal TemplateName As String) As String
      
        Dim request = New RestSharp.RestRequest("templates", Method.GET)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        request.AddHeader("Authorization", "bearer " & Client.Token)
        Dim response As RestSharp.RestResponse = Client.RestClient.Execute(request)
        Client.UpdateToken(response.Headers)
        Dim apiresponse = JsonConvert.DeserializeObject(Of ApiResponse(Of List(Of Templates.Templates)))(response.Content)
        Dim fndtemplate As String = ""
        For Each template In apiresponse.Data
            If template.name = TemplateName Then
                fndtemplate = template.templateID
            End If
        Next
        Return fndtemplate

    End Function

    Public Function GetCategories() As ApiResponse(Of List(Of Templates.Categories))

        Dim request = New RestSharp.RestRequest("templates/categories", Method.GET)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        request.AddHeader("Authorization", "bearer " & Client.Token)
        Dim response As RestSharp.RestResponse = Client.RestClient.Execute(request)
        Client.UpdateToken(response.Headers)
        Dim apiresponse = JsonConvert.DeserializeObject(Of ApiResponse(Of List(Of Templates.Categories)))(response.Content)
        Return apiresponse

    End Function



    Public Function GetTemplate(ByVal templateid As String) As ApiResponse(Of Templates.TemplateInformation)

 
        Dim request = New RestSharp.RestRequest("templates/" & templateid, Method.GET)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        request.AddHeader("Authorization", "bearer " & Client.Token)
        Dim response As RestSharp.RestResponse = Client.RestClient.Execute(request)
        Client.UpdateToken(response.Headers)
        Dim apiresponse = JsonConvert.DeserializeObject(Of ApiResponse(Of Templates.TemplateInformation))(response.Content)
        Return apiresponse
    End Function



End Class


