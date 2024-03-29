﻿Imports RestSharp
Imports Newtonsoft.Json
Imports FEPRestClient.Models.Response
Imports FEPRestClient.Models
Public Class AlertsFunctions
    Public Function GetTotalResponses()
        Dim request = New RestSharp.RestRequest("alerts/getTotalResponses/?predicate=null", Method.GET)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        request.AddHeader("Authorization", "bearer " & Client.Token)
        Dim response As RestSharp.RestResponse = Client.RestClient.Execute(request)
        Client.UpdateToken(response.Headers)
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

    Public Function GetMeanTimeStatistics() _
        As List(Of Models.Alert.MeanTimeStatistics)

        Dim request = New RestSharp.RestRequest("alerts/getMeanTimeStatistics/?predicate=null", Method.GET)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        request.AddHeader("Authorization", "bearer " & Client.Token)
        Dim response As RestSharp.RestResponse = Client.RestClient.Execute(request)
        Client.UpdateToken(response.Headers)
        Return JsonConvert.DeserializeObject(Of List(Of Models.Alert.MeanTimeStatistics))(response.Content)

    End Function

    Public Function GetTotalAutomatedResponses()
        Dim request = New RestSharp.RestRequest("alerts/getTotalAutomatedResponses/?predicate=null", Method.GET)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        request.AddHeader("Authorization", "bearer " & Client.Token)
        Dim response As RestSharp.RestResponse = Client.RestClient.Execute(request)
        Client.UpdateToken(response.Headers)
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

    Public Function GetAlertSourceBreakdown() _
        As List(Of Models.Alert.AlertSourceBreakdownResult)
   
        Dim request = New RestSharp.RestRequest("alerts/getAlertSourceBreakdown/?predicate=null", Method.GET)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        request.AddHeader("Authorization", "bearer " & Client.Token)
        Dim response As RestSharp.RestResponse = Client.RestClient.Execute(request)
        Client.UpdateToken(response.Headers)
        Dim apiresponse = JsonConvert.DeserializeObject(Of List(Of Models.Alert.AlertSourceBreakdownResult))(response.Content)
        Return apiresponse


    End Function


    Public Function GetAlertDetails(ByVal AlertID As String) _
        As Alert.AlertDetails
   
        Dim request = New RestSharp.RestRequest("alerts/getAlertDetails/" & AlertID, Method.GET)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        request.AddHeader("Authorization", "bearer " & Client.Token)
        Dim response As RestSharp.RestResponse = Client.RestClient.Execute(request)
        Client.UpdateToken(response.Headers)
        Dim apiresponse = JsonConvert.DeserializeObject(Of Alert.AlertDetails)(response.Content)
        Return apiresponse


    End Function


    Public Function GetAlertsWithCounts(Optional startIndex As Integer = 0, Optional pageSize As Integer = 500, _
                                         Optional orderByColumnName As String = "AlertID", Optional orderByDirection As String = "Descending", _
                                         Optional predicate As String = "null") As Alert.AlertsWithCounts

      
        If Not predicate = "null" Then
            predicate = "(" & predicate & ")"
        End If

        Dim request = New RestSharp.RestRequest("alerts/getalertswithcounts/" & startIndex & "/" & pageSize _
                                                & "/" & orderByColumnName & "/" & orderByDirection _
                                                & "/?predicate=" & predicate, Method.GET)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        request.AddHeader("Authorization", "bearer " & Client.Token)
        Dim response As RestSharp.RestResponse = Client.RestClient.Execute(request)
        Client.UpdateToken(response.Headers)
        Dim apiresponse = JsonConvert.DeserializeObject(Of Alert.AlertsWithCounts)(response.Content)
        Return apiresponse
    End Function

    Public Function GetAlertGroupByStats(ByVal GroupByProperty As Alert.AlertGroupProperty, Optional startIndex As Integer = 0, Optional pageSize As Integer = 500, _
                                     Optional orderByColumnName As String = "AlertID", Optional orderByDirection As String = "Descending", _
                                     Optional predicate As String = "null") As Alert.AlertStats

 
        If Not predicate = "null" Then
            predicate = "(" & predicate & ")"
        End If

        Dim request = New RestSharp.RestRequest("alerts/getalertgroupbystats/" & GroupByProperty & "/" & startIndex & "/" & pageSize _
                                                & "/" & orderByColumnName & "/" & orderByDirection _
                                                & "/?predicate=" & predicate, Method.GET)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        request.AddHeader("Authorization", "bearer " & Client.Token)
        Dim response As RestSharp.RestResponse = Client.RestClient.Execute(request)
        Client.UpdateToken(response.Headers)
        Dim apiresponse = JsonConvert.DeserializeObject(Of Alert.AlertStats)(response.Content)
        Return apiresponse
    End Function

    Public Function GetAlertsOverTime(ByVal timeSpan As Alert.TimeSpanGrouping, Optional predicate As String = "null") As Alert.AlertsOverTime

    
        If Not predicate = "null" Then
            predicate = "(" & predicate & ")"
        End If

        Dim request = New RestSharp.RestRequest("alerts/getAlertsOverTime/" & timeSpan & "/" & "/?predicate=" & predicate, Method.GET)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        request.AddHeader("Authorization", "bearer " & Client.Token)
        Dim response As RestSharp.RestResponse = Client.RestClient.Execute(request)
        Client.UpdateToken(response.Headers)
        Dim apiresponse = JsonConvert.DeserializeObject(Of Alert.AlertsOverTime)(response.Content)
        Return apiresponse
    End Function

End Class
