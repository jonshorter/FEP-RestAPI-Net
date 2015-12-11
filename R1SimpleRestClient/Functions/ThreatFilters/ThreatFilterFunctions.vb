Imports RestSharp
Imports Newtonsoft.Json
Imports R1SimpleRestClient.Models.Response
Imports R1SimpleRestClient.Models.Project
Imports R1SimpleRestClient.Models.Report
Imports R1SimpleRestClient.Models.Job
Imports R1SimpleRestClient.Models


Public Class ThreatFilterFunctions
    Public Function GetThreatFilters(ByVal AuthToken As Models.Response.AuthToken, ByVal Server As String, _
                                        Optional page As Integer = 1)

        Dim client As New RestSharp.RestClient("https://" & Server & "/R1/api")
        client.CookieContainer = AuthToken.Data

        Dim request = New RestSharp.RestRequest("threatfilters/" & page, Method.GET)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        Dim response As RestSharp.RestResponse = client.Execute(request)
        Select Case response.StatusCode
            Case Is > 200 < 400
                Dim apiresponse = JsonConvert.DeserializeObject(Of ThreatFilters.ThreatFilters)(response.Content)
                Return apiresponse
            Case Is >= 400
                Return "Error: " & response.ErrorMessage
            Case Else
                Return "Error: " & response.ErrorMessage
        End Select

        Return "If You See This.... ThreatFilters-GetThreatFilters"
    End Function

    Public Function GetThreatFilterIDs(ByVal AuthToken As Models.Response.AuthToken, ByVal Server As String _
                                   )

        Dim client As New RestSharp.RestClient("https://" & Server & "/R1/api")
        client.CookieContainer = AuthToken.Data

        Dim request = New RestSharp.RestRequest("threatfilters/ids", Method.GET)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        Dim response As RestSharp.RestResponse = client.Execute(request)
        Select Case response.StatusCode
            Case Is > 200 < 400
                Dim apiresponse = JsonConvert.DeserializeObject(Of ApiResponse(Of List(Of Integer)))(response.Content)
                Return apiresponse
            Case Is >= 400
                Return "Error: " & response.ErrorMessage
            Case Else
                Return "Error: " & response.ErrorMessage
        End Select

        Return "If You See This.... ThreatFilters-GetThreatFilterIDs"
    End Function

End Class


