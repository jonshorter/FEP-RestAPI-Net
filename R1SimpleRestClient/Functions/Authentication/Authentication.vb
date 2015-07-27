Imports System.Net
Imports System.Text
Imports System.IO
Imports System.Windows.Forms
Imports R1SimpleRestClient.Models.Response

Public Class R1Authentication

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
        postreqstream.Close()
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
            authreturn.Data = cookiecon
            authreturn.Error = False
            Return authreturn
        Else
            Dim authreturn As New AuthToken
            authreturn.Data = "Bad Username or Password"
            authreturn.Error = True
            Return authreturn

        End If


    End Function
End Class
