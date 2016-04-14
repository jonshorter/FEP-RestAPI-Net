Imports RestSharp
Imports Newtonsoft.Json
Imports FEPRestClient.Models.Response
Imports FEPRestClient.Models.Project
Imports FEPRestClient.Models.Report
Imports FEPRestClient.Models.Job
Imports FEPRestClient.Models
Imports FEPRestClient.Models.Job2
Imports FEPRestClient.Models.Enums


Public Class ScriptPackagesFunctions
    

    Public Function GetFieldsByJobResult(ByVal jobResultID As String) As ApiResponse(Of List(Of String))

        Dim request = New RestSharp.RestRequest("scriptpackages/FieldsByJobResult/" & jobResultID, Method.GET)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        request.AddHeader("Authorization", "bearer " & Client.Token)
        Dim response As RestSharp.RestResponse = Client.RestClient.Execute(request)
        Client.UpdateToken(response.Headers)
        Return JsonConvert.DeserializeObject(Of ApiResponse(Of List(Of String)))(response.Content)

    End Function

End Class
