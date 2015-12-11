Imports RestSharp
Imports Newtonsoft.Json
Imports R1SimpleRestClient.Models.Response
Imports R1SimpleRestClient.Models
Public Class AlertsFunctions
    Public Function GetTotalResponses(ByVal AuthToken As Models.Response.AuthToken, ByVal Server As String)
        Dim client As New RestSharp.RestClient("https://" & Server & "/R1/api")
        client.CookieContainer = AuthToken.Data.Cookies
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

    Public Function GetMeanTimeStatistics(ByVal AuthToken As Models.Response.AuthToken, ByVal Server As String) _
        As List(Of Models.Alert.MeanTimeStatistics)
        Dim client As New RestSharp.RestClient("https://" & Server & "/R1/api")
        client.CookieContainer = AuthToken.Data.Cookies
        Dim request = New RestSharp.RestRequest("alerts/getMeanTimeStatistics/?predicate=null", Method.GET)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        Dim response As RestSharp.RestResponse = client.Execute(request)
        Return JsonConvert.DeserializeObject(Of List(Of Models.Alert.MeanTimeStatistics))(response.Content)

    End Function

    Public Function GetTotalAutomatedResponses(ByVal AuthToken As Models.Response.AuthToken, ByVal Server As String)
        Dim client As New RestSharp.RestClient("https://" & Server & "/R1/api")
        client.CookieContainer = AuthToken.Data.Cookies
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

    Public Function GetAlertSourceBreakdown(ByVal AuthToken As Models.Response.AuthToken, ByVal Server As String) _
        As List(Of Models.Alert.AlertSourceBreakdownResult)
        Dim client As New RestSharp.RestClient("https://" & Server & "/R1/api")
        client.CookieContainer = AuthToken.Data.Cookies
        Dim request = New RestSharp.RestRequest("alerts/getAlertSourceBreakdown/?predicate=null", Method.GET)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        Dim response As RestSharp.RestResponse = client.Execute(request)
        Dim apiresponse = JsonConvert.DeserializeObject(Of List(Of Models.Alert.AlertSourceBreakdownResult))(response.Content)
        Return apiresponse

        
    End Function


    Public Function GetAlertDetails(ByVal AuthToken As Models.Response.AuthToken, ByVal Server As String, ByVal AlertID As String) _
        As Alert.AlertDetails
        Dim client As New RestSharp.RestClient("https://" & Server & "/R1/api")
        client.CookieContainer = AuthToken.Data.Cookies
        Dim request = New RestSharp.RestRequest("alerts/getAlertDetails/" & AlertID, Method.GET)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        Dim response As RestSharp.RestResponse = client.Execute(request)
        Dim apiresponse = JsonConvert.DeserializeObject(Of Alert.AlertDetails)(response.Content)
        Return apiresponse

      
    End Function


    Public Function GetAlertsWithCounts(ByVal AuthToken As Models.Response.AuthToken, ByVal Server As String, _
                                         Optional startIndex As Integer = 0, Optional pageSize As Integer = 500, _
                                         Optional orderByColumnName As String = "AlertID", Optional orderByDirection As String = "Descending", _
                                         Optional predicate As String = "null") As Alert.AlertsWithCounts

        Dim client As New RestSharp.RestClient("https://" & Server & "/R1/api")
        client.CookieContainer = AuthToken.Data.Cookies

        If Not predicate = "null" Then
            predicate = "(" & predicate & ")"
        End If

        Dim request = New RestSharp.RestRequest("alerts/getalertswithcounts/" & startIndex & "/" & pageSize _
                                                & "/" & orderByColumnName & "/" & orderByDirection _
                                                & "/?predicate=" & predicate, Method.GET)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        Dim response As RestSharp.RestResponse = client.Execute(request)
        Dim apiresponse = JsonConvert.DeserializeObject(Of Alert.AlertsWithCounts)(response.Content)
        Return apiresponse
    End Function

End Class
