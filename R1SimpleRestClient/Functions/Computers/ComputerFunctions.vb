Imports RestSharp
Imports Newtonsoft.Json
Imports R1SimpleRestClient.Models.Response
Imports R1SimpleRestClient.Models.Project
Imports R1SimpleRestClient.Models.Report
Imports R1SimpleRestClient.Models.Job
Imports R1SimpleRestClient.Models


Public Class ComputerFunctions

    Public Function GetGroupComputers(ByVal AuthToken As Models.Response.AuthToken, ByVal Server As String, _
                                      Optional GroupID As String = "", Optional Count As Integer = 100, _
                                      Optional Start As Integer = 0, Optional SearchText As String = "") As ApiResponse(Of ComputersInGroup)
        Dim client As New RestSharp.RestClient("https://" & Server & "/R1/api")
        client.CookieContainer = AuthToken.Data.Cookies

        If Not GroupID = "" Then
            GroupID = "?groupid=" & GroupID & "&count=" & Count & "&start=" & Start
        End If
        If SearchText <> "" Then
            GroupID = GroupID & "&searchtext=" & SearchText
        End If



        Dim request = New RestSharp.RestRequest("computers/GetGroupComputers" & GroupID, Method.GET)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        Dim response As RestSharp.RestResponse = client.Execute(request)
        Return JsonConvert.DeserializeObject(Of ApiResponse(Of ComputersInGroup))(response.Content)

    End Function
    Public Function GetGroupComputerIds(ByVal AuthToken As Models.Response.AuthToken, ByVal Server As String, _
                                        Optional GroupId As String = "") As ApiResponse(Of List(Of String))
        Dim client As New RestSharp.RestClient("https://" & Server & "/R1/api")
        client.CookieContainer = AuthToken.Data.Cookies
        If Not GroupId = "" Then
            GroupId = "?groupid=" & GroupId
        End If
        Dim request = New RestSharp.RestRequest("computers/GetGroupComputerIds" & GroupId, Method.GET)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        Dim response As RestSharp.RestResponse = client.Execute(request)
        Return JsonConvert.DeserializeObject(Of ApiResponse(Of List(Of String)))(response.Content)

    End Function



End Class



