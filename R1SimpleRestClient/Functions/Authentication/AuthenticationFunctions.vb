Imports System.Net
Imports System.Text
Imports System.IO
Imports System.Windows.Forms
Imports R1SimpleRestClient.Models.Response
Imports RestSharp
Imports Newtonsoft.Json

Public Class R1Authentication

    Public Sub Logout57(ByVal Server As String, ByVal AuthToken As AuthToken)
        Try
            System.Net.ServicePointManager.ServerCertificateValidationCallback = _
    Function(se As Object, _
    cert As System.Security.Cryptography.X509Certificates.X509Certificate, _
    chain As System.Security.Cryptography.X509Certificates.X509Chain, _
    sslerror As System.Net.Security.SslPolicyErrors) True
            '----LogOut
            Dim client As New RestSharp.RestClient("https://" & Server & "/R1/ClientBin/ADG-RIA-Authentication-Web-Services-AuthenticationService.svc/binary")
            client.CookieContainer = AuthToken.Data.Cookies
            Dim request = New RestSharp.RestRequest("Logout", Method.POST)
            request.RequestFormat = DataFormat.Json
            request.JsonSerializer = New RestSharpJsonNetSerializer
            request.AddHeader("Accept", "application/json")
            request.Parameters.Clear()
            request.AddParameter("application/msbin1", "@Logouthttp://tempuri.org/", ParameterType.RequestBody)

            Dim response As RestSharp.RestResponse = client.Execute(request)
            Select Case response.StatusCode
                Case Is > 200 < 400
                    MsgBox("Logged out")
                Case Is >= 400
                    MsgBox("Error: " & response.ErrorMessage)
                Case Else
                    MsgBox("Error: " & response.ErrorMessage)
            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub Login(ByVal Server As String, ByVal Username As String, ByVal Password As String)
        Dim client As New RestSharp.RestClient("https://" & Server & "/R1/api/")
    
        Dim request = New RestSharp.RestRequest("authenticate", Method.GET)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        Dim response As RestSharp.RestResponse = client.Execute(request)


        '        Return "If You See This.... Logout"
    End Sub

    Public Sub Logout(ByVal Server As String, ByVal AuthToken As AuthToken)
        Dim client As New RestSharp.RestClient("https://" & Server & "/R1/api/")
        client.CookieContainer = AuthToken.Data.Cookies



        Dim request = New RestSharp.RestRequest("configuration/logout", Method.GET)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpJsonNetSerializer
        Dim response As RestSharp.RestResponse = client.Execute(request)
        Select Case response.StatusCode
            Case Is > 200 < 400
                Dim apiresponse = JsonConvert.DeserializeObject(Of Models.Response.ApiResponse(Of String))(response.Content)
                Select Case apiresponse.Success
                    Case True
                        MsgBox("Logged Out")
                    Case False
                        MsgBox("Error: " & apiresponse.Error.Message.ToString)
                End Select
            Case Is >= 400
                MsgBox("Error: " & response.ErrorMessage.ToString)
            Case Else
                MsgBox("Error: " & response.ErrorMessage.ToString)
        End Select

        '        Return "If You See This.... Logout"
    End Sub
    Public Function AuthenticateWithR1(ByVal R1Server As String, ByVal UserName As String, ByVal Password As String) As AuthToken

        System.Net.ServicePointManager.ServerCertificateValidationCallback = _
Function(se As Object, _
cert As System.Security.Cryptography.X509Certificates.X509Certificate, _
chain As System.Security.Cryptography.X509Certificates.X509Chain, _
sslerror As System.Net.Security.SslPolicyErrors) True

        '---------------------Get Cookies & Form Variables------------------------------

        Dim postReq As HttpWebRequest = WebRequest.Create("https://" & R1Server & "/R1/Login.aspx")
        postReq.Method = "GET"
        Dim encoding As New UTF8Encoding
        Try
            Dim postresponse As HttpWebResponse = postReq.GetResponse()

            Dim cookiecon As New System.Net.CookieContainer()
            Dim respcookies() = postresponse.Headers.GetValues("Set-Cookie")
            For Each item In respcookies
                Dim tc As New System.Net.Cookie
                Dim ts1 = item.Split(";"c)
                tc.Name = ts1(0).Split("="c)(0)
                tc.Value = ts1(0).Split("="c)(1)
                tc.Path = "/"
                If ts1(2) = " secure" Then tc.Secure = True
                If ts1(3) = " HttpOnly" Then tc.HttpOnly = True
                cookiecon.Add(New Uri("https://" & R1Server & "/R1/Login.aspx"), tc)
            Next
            Dim CSRFToken As String = ""
            Dim VIEWState As String = ""
            Dim EventValidation As String = ""
            Dim postreqreader As New StreamReader(postresponse.GetResponseStream())
            Dim thepage As String = postreqreader.ReadToEnd
            Dim wbrowse As New WebBrowser
            wbrowse.Navigate("about:blank")
            Dim pghtml As HtmlDocument
            Dim wbrowsedoc = wbrowse.Document
            wbrowsedoc.Write(thepage)
            pghtml = wbrowsedoc
            VIEWState = Uri.EscapeDataString(pghtml.GetElementById("__VIEWSTATE").GetAttribute("value"))
            CSRFToken = Uri.EscapeDataString(pghtml.GetElementById("__CSRFTOKEN").GetAttribute("value"))
            EventValidation = Uri.EscapeDataString(pghtml.GetElementById("__EVENTVALIDATION").GetAttribute("value"))

            '-----------------------Login Method----------------------------

            Dim PostData As String = "__CSRFTOKEN=" & CSRFToken & "&__LASTFOCUS=&__EVENTTARGET=&__EVENTARGUMENT=&__VIEWSTATE=" & VIEWState & "&__EVENTVALIDATION=" & EventValidation & "&Login1%24UserName=" & UserName & "&Login1%24Password=" & Password & "&Login1%24LoginButton=Sign+In&hiddenHash="
            Dim byteData As Byte() = encoding.GetBytes(PostData)
            postReq = WebRequest.Create("https://" & R1Server & "/R1/Login.aspx")
            postReq.Method = "POST"
            postReq.KeepAlive = True
            postReq.CookieContainer = cookiecon
            postReq.Host = R1Server

            postReq.Headers.Add("DNT", "1")

            postReq.ContentType = "application/x-www-form-urlencoded"

            postReq.Referer = "https://" & R1Server & "/R1/Login.aspx"
            postReq.UserAgent = "Mozilla/5.0 (Windows; U; Windows NT 6.1; ru; rv:1.9.2.3) Gecko/20100401 Firefox/4.0 (.NET CLR 3.5.30729)"
            postReq.ContentLength = byteData.Length

            postReq.AllowAutoRedirect = False

            Dim postreqstream As Stream = postReq.GetRequestStream()
            postreqstream.Write(byteData, 0, byteData.Length)
            postresponse = postReq.GetResponse()
            postreqreader = New StreamReader(postresponse.GetResponseStream())

            '  thepage = postreqreader2.ReadToEn\

            Dim authrespcookies() = postresponse.Headers.GetValues("Set-Cookie")
            If Not authrespcookies Is Nothing Then
                For Each item In authrespcookies
                    Dim tc As New System.Net.Cookie
                    Dim ts1 = item.Split(";"c)
                    tc.Name = ts1(0).Split("="c)(0)
                    tc.Value = ts1(0).Split("="c)(1)
                    tc.Path = "/"
                    '  If ts1(2) = " secure" Then tc.Secure = True
                    If ts1(2) = " HttpOnly" Then tc.HttpOnly = True

                    cookiecon.Add(New Uri("https://" & R1Server & "/R1/Login.aspx"), tc)
                Next
                postreqreader.Close()
                postresponse.Close()
                postreqstream.Close()

                'Return Cookie COntainer
                Dim authreturn As New AuthToken
                authreturn.Data.Cookies = cookiecon
                authreturn.Data.Message = "Authenticated"
                authreturn.Error = False
                Return authreturn
            Else
                Dim authreturn As New AuthToken
                authreturn.Data.Message = "Bad Username or Password"
                authreturn.Error = True
                Return authreturn

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Dim authreturn As New AuthToken
            authreturn.Data.Message = ex.Message
            authreturn.Error = True
            Return authreturn
        End Try

    End Function
End Class
