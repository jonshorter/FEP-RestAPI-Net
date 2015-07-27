Imports RestSharp
Imports Newtonsoft.Json
Imports R1SimpleRestClient.Models.Response
Imports R1SimpleRestClient.Models
Public Class AlertFunctions
    Public Function GetTotalResponses(ByVal AuthToken As Models.Response.AuthToken, ByVal Server As String)
        Dim client As New RestSharp.RestClient("https://" & Server & "/R1/api")
        client.CookieContainer = AuthToken.Data
        Dim request = New RestSharp.RestRequest("alerts/getTotalResponses/?predicate=null", Method.GET)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        Dim response As RestSharp.RestResponse = client.Execute(request)
        Select Case response.StatusCode
            Case Is > 200 < 400
                Return response.Content
            Case Is >= 400
                Return "Error: " & response.ErrorMessage
            Case Else
                Return "Error: " & response.ErrorMessage
        End Select

        Return "If You See This.... Alerts-GetTotalResponses"
    End Function
    Public Function GetTotalAutomatedResponses(ByVal AuthToken As Models.Response.AuthToken, ByVal Server As String)
        Dim client As New RestSharp.RestClient("https://" & Server & "/R1/api")
        client.CookieContainer = AuthToken.Data
        Dim request = New RestSharp.RestRequest("alerts/getTotalAutomatedResponses/?predicate=null", Method.GET)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        Dim response As RestSharp.RestResponse = client.Execute(request)
        Select Case response.StatusCode
            Case Is > 200 < 400
                Return response.Content
            Case Is >= 400
                Return "Error: " & response.ErrorMessage
            Case Else
                Return "Error: " & response.ErrorMessage
        End Select

        Return "If You See This.... Alerts-GetTotalAutomatedResponses"
    End Function

    Public Function GetAlertSourceBreakdown(ByVal AuthToken As Models.Response.AuthToken, ByVal Server As String)
        Dim client As New RestSharp.RestClient("https://" & Server & "/R1/api")
        client.CookieContainer = AuthToken.Data
        Dim request = New RestSharp.RestRequest("alerts/getAlertSourceBreakdown/?predicate=null", Method.GET)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        Dim response As RestSharp.RestResponse = client.Execute(request)
        Select Case response.StatusCode
            Case Is > 200 < 400
                Dim apiresponse = JsonConvert.DeserializeObject(Of List(Of Models.Alert.AlertSourceBreakdownResult))(response.Content)
                Return apiresponse
            Case Is >= 400
                Return "Error: " & response.ErrorMessage
            Case Else
                Return "Error: " & response.ErrorMessage
        End Select

        Return "If You See This.... Alerts-GetAlertSourceBreakdown"
    End Function


End Class
