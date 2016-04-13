Imports RestSharp
Imports Newtonsoft.Json
Imports FEPRestClient.Models.Response
Imports FEPRestClient.Models.Project
Imports FEPRestClient.Models.Report
Imports FEPRestClient.Models.Job
Imports FEPRestClient.Models


Public Class UserFunctions

    Public Function findUserByLastnameOrUsername(ByVal AuthToken As Models.Response.AuthToken, ByVal Server As String, ByVal user As String)

        Dim client As New RestSharp.RestClient("https://" & Server & "/R1/api/user")
        client.CookieContainer = AuthToken.Data.Cookies



        Dim request = New RestSharp.RestRequest("findUserByLastnameOrUsername/100/" & user, Method.GET)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        Dim response As RestSharp.RestResponse = client.Execute(request)
        Dim apiresponse = JsonConvert.DeserializeObject(Of List(Of Models.User.UserLight))(response.Content)
        Select Case apiresponse.Count
            Case Is > 0
                Return apiresponse
            Case Else
                Dim blankuserlight As New List(Of Models.User.UserLight)
                Return blankuserlight
        End Select



        Return "If You See This.... GetAllJobs"
    End Function
End Class


