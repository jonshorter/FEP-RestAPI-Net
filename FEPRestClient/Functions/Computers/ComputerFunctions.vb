Imports RestSharp
Imports Newtonsoft.Json
Imports FEPRestClient.Models.Response
Imports FEPRestClient.Models.Project
Imports FEPRestClient.Models.Report
Imports FEPRestClient.Models.Job
Imports FEPRestClient.Models


Public Class ComputerFunctions

    Public Function GetGroupComputers(Optional GroupID As String = "", Optional Count As Integer = 100, _
                                      Optional Start As Integer = 0, Optional SearchText As String = "") As ApiResponse(Of ComputersInGroup)
     
        If Not GroupID = "" Then
            GroupID = "?groupid=" & GroupID & "&count=" & Count & "&start=" & Start
        End If
        If SearchText <> "" Then
            GroupID = GroupID & "&searchtext=" & SearchText
        End If



        Dim request = New RestSharp.RestRequest("computers/GetGroupComputers" & GroupID, Method.GET)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        request.AddHeader("Authorization", "bearer " & Client.Token)
        Dim response As RestSharp.RestResponse = Client.RestClient.Execute(request)
        Client.UpdateToken(response.Headers)

        Return JsonConvert.DeserializeObject(Of ApiResponse(Of ComputersInGroup))(response.Content)

    End Function
    Public Function GetGroupComputerIds(Optional GroupId As String = "") As ApiResponse(Of List(Of String))
        If Not GroupId = "" Then
            GroupId = "?groupid=" & GroupId
        End If
        Dim request = New RestSharp.RestRequest("computers/GetGroupComputerIds" & GroupId, Method.GET)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        request.AddHeader("Authorization", "bearer " & Client.Token)
        Dim response As RestSharp.RestResponse = Client.RestClient.Execute(request)
        Client.UpdateToken(response.Headers)
        Return JsonConvert.DeserializeObject(Of ApiResponse(Of List(Of String)))(response.Content)

    End Function



End Class



