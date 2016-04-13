Imports RestSharp
Imports Newtonsoft.Json
Imports FEPRestClient.Models.Response
Imports FEPRestClient.Models.Project
Imports FEPRestClient.Models.Report
Imports FEPRestClient.Models.Job
Imports FEPRestClient.Models


Public Class UserFunctions

    Public Function findUserByLastnameOrUsername(ByVal user As String)


        Dim request = New RestSharp.RestRequest("user/findUserByLastnameOrUsername/100/" & user, Method.GET)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        request.AddHeader("Authorization", "bearer " & Client.Token)
        Dim response As RestSharp.RestResponse = Client.RestClient.Execute(request)
        Client.UpdateToken(response.Headers)
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


