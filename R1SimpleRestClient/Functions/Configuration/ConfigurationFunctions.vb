Imports RestSharp
Imports Newtonsoft.Json
Imports R1SimpleRestClient.Models.Response
Imports R1SimpleRestClient.Models.Project
Imports R1SimpleRestClient.Models.Report
Imports R1SimpleRestClient.Models.Job
Imports R1SimpleRestClient.Models


Public Class ConfigurationFunctions


    Public Function IsIWAMode(ByVal AuthToken As Models.Response.AuthToken, ByVal Server As String)
        Dim client As New RestSharp.RestClient("https://" & Server & "/R1/api")
        client.CookieContainer = AuthToken.Data
        Dim request = New RestSharp.RestRequest("configuration/IsIWAMode", Method.GET)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        Dim response As RestSharp.RestResponse = client.Execute(request)
        Select Case response.StatusCode
            Case Is > 200 < 400
                Dim apiresponse = JsonConvert.DeserializeObject(Of ApiResponse(Of Boolean))(response.Content)
                Select Case apiresponse.Success
                    Case True
                        Return apiresponse.Data
                    Case False
                        Return "Error: " & apiresponse.Error.Message.ToString
                End Select
            Case Is >= 400
                Return "Error: " & response.ErrorMessage
            Case Else
                Return "Error: " & response.ErrorMessage
        End Select

        Return "If You See This.... GetConfigurationIsIWAMode"
    End Function
    Public Function GetDefaultJobDataPath(ByVal AuthToken As Models.Response.AuthToken, ByVal Server As String)
        Dim client As New RestSharp.RestClient("https://" & Server & "/R1/api")
        client.CookieContainer = AuthToken.Data
        Dim request = New RestSharp.RestRequest("configuration/getConfigurationType/DefaultCaseCollectedFilePath", Method.GET)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        Dim response As RestSharp.RestResponse = client.Execute(request)
        Select Case response.StatusCode
            Case Is > 200 < 400
                Dim apiresponse = JsonConvert.DeserializeObject(Of ApiResponse(Of String))(response.Content)
                Select Case apiresponse.Success
                    Case True
                        Return apiresponse.Data
                    Case False
                        Return "Error: " & apiresponse.Error.Message.ToString
                End Select
            Case Is >= 400
                Return "Error: " & response.ErrorMessage
            Case Else
                Return "Error: " & response.ErrorMessage
        End Select

        Return "If You See This.... GetDefaultJobDataPath"
    End Function
    Public Function GetDefaultProjectsPath(ByVal AuthToken As Models.Response.AuthToken, ByVal Server As String)
        Dim client As New RestSharp.RestClient("https://" & Server & "/R1/api")
        client.CookieContainer = AuthToken.Data
        Dim request = New RestSharp.RestRequest("configuration/getConfigurationType/FTKDefaultPath", Method.GET)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        Dim response As RestSharp.RestResponse = client.Execute(request)
        Select Case response.StatusCode
            Case Is > 200 < 400
                Dim apiresponse = JsonConvert.DeserializeObject(Of ApiResponse(Of String))(response.Content)
                Select Case apiresponse.Success
                    Case True
                        Return apiresponse.Data
                    Case False
                        Return "Error: " & apiresponse.Error.Message.ToString
                End Select
            Case Is >= 400
                Return "Error: " & response.ErrorMessage
            Case Else
                Return "Error: " & response.ErrorMessage
        End Select

        Return "If You See This.... GetDefaultProjectsPath"
    End Function


End Class


