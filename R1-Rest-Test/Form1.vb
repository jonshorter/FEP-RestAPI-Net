Imports ADG.Wizard.Shared
Imports ADG.Wizard.Shared.Filters
Imports ADG.RIA.DataServices
Imports ADG.RIA.DataServices.Web.EncryptionType
Imports RestSharp
Imports System.Net
Imports System.Text
Imports System.IO
Imports System.Web
Imports Newtonsoft
Imports Newtonsoft.Json



Public Class Form1
    Dim r1c As New RestSharp.RestClient


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

  
        Dim newproject As New ADG.RIA.DataServices.Web.NewProjectDefinition
        newproject.Name = txtProjectName.Text
        newproject.FTKCaseFolderPath = "\\10.0.1.52\Share\Projects"
        newproject.ResponsiveFilePath = "\\10.0.1.52\Share\JobData"
        newproject.ProcessingMode = Web.ProcessModeEnum.Security

        Dim response = R1RestFunctions.R1RestRequest(Method.POST, "projects", Json.JsonConvert.SerializeObject(newproject))
        If response.GetType Is GetType(ADG.WebLab.Web.Controllers.API.ApiResponse(Of Object)) Then
            If response.Success = True Then
                Dim project = JsonConvert.DeserializeObject(Of ADG.RIA.DataServices.Web.NewProjectDefinition)(response.Data.ToString)

                MsgBox("Project " & project.name & " created successfully.")

            Else
                MsgBox(response.error.message)
            End If
        Else
            MsgBox(response)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DataGridView1.Rows.Clear()

        Dim response = R1RestFunctions.R1RestRequest(Method.GET, "projects")
        If response.GetType Is GetType(ADG.WebLab.Web.Controllers.API.ApiResponse(Of Object)) Then
            If response.Success = True Then
                Dim projects = JsonConvert.DeserializeObject(Of List(Of R1SimpleRestClasses.ProjectInformation))(response.Data.ToString)
                For Each item As R1SimpleRestClasses.ProjectInformation In projects
                    DataGridView1.Rows.Add(New String() {item.name, item.ftkCaseId})
                Next
            Else
                MsgBox(response.error.message)
            End If
        Else
            MsgBox(response)
        End If

    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
    

        Dim response = R1RestFunctions.R1RestRequest(Method.DELETE, "projects/" & txtProjectDelete.Text)
        If response.GetType Is GetType(ADG.WebLab.Web.Controllers.API.ApiResponse(Of Object)) Then
            If response.Success = True Then
                MsgBox("Project # " & txtProjectDelete.Text & " deleted.")
                txtProjectDelete.Text = "FTKCASEID"
            Else
                MsgBox(response.error.message)
            End If
        Else
            MsgBox(response)
        End If


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        'Dim client As New RestSharp.RestClient("https://10.0.1.52/R1/api")
        'client.CookieContainer = AuthenticateWithR1()

        Dim request = New RestSharp.RestRequest("projects", RestSharp.Method.OPTIONS)

        Dim r1cl As RestClient = r1c
        Dim response As RestSharp.RestResponse = r1cl.Execute(request)
        ' Dim content = response.Content
        Dim content As ADG.WebLab.Web.Controllers.API.ApiResponse(Of Object) = JsonConvert.DeserializeObject(Of ADG.WebLab.Web.Controllers.API.ApiResponse(Of Object))(response.Content)
        MsgBox(content.Data.ToString)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
      
        Dim nj As New ADG.WebLab.Web.Controllers.API.Job.JobDefinitionModel
        Dim njdef As New ADG.Wizard.Shared.JobDefinition
        nj.JobDef = njdef
        nj.JobDef.Name = txtJobName.Text
        nj.JobDef.JobType = JobTypes.SoftwareInventory

        nj.JobDef.SecondaryActionsEnabled = True

        nj.ProjectId = 2
        nj.JobAction = JobAction.Create
        Dim njc As New ADG.WebLab.Web.Controllers.API.Job.Target
        njc.Addresses = New List(Of String)
        njc.Addresses.Add("10.0.1.5")
        njc.SearchString = ""
        nj.ComputerTargets = njc

        Dim stc As New ADG.WebLab.Web.Controllers.API.Job.Target
        'nj.NetworkShareTargets = stc



        Dim response = R1RestFunctions.R1RestRequest(Method.PUT, "jobs", Json.JsonConvert.SerializeObject(nj))
        If response.GetType Is GetType(ADG.WebLab.Web.Controllers.API.ApiResponse(Of Object)) Then
            If response.Success = True Then
                Dim job = JsonConvert.DeserializeObject(Of List(Of ADG.WebLab.Web.Controllers.API.Job.JobInfo))(response.Data.ToString)

                MsgBox("Job " & job(0).Name & " created successfully.")

            Else
                MsgBox(response.error.message)
            End If
        Else
            MsgBox(response)
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtServer.Text = My.Settings.Server
        txtUsername.Text = My.Settings.Username
        txtPassword.Text = My.Settings.Password


    End Sub

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        DataGridView2.Rows.Clear()
        '  Dim client As New RestSharp.RestClient("https://10.0.1.52/R1/api")
        '  client.CookieContainer = AuthenticateWithR1()

        Dim request = New RestSharp.RestRequest("jobs/1", RestSharp.Method.GET)
        Dim r1cl As RestClient = r1c
        Dim response As RestSharp.RestResponse = r1cl.Execute(request)


        Dim returnjson As String = response.Content

        Dim JobList As R1SimpleRestClasses.JobList = JsonConvert.DeserializeObject(Of R1SimpleRestClasses.JobList)(returnjson)

        For Each item As ADG.WebLab.Web.Controllers.API.Job.JobInfo In JobList.data
            DataGridView2.Rows.Add(New String() {item.Name, item.Status})

        Next
    End Sub

    Private Sub jobload(callback As Action(Of RestSharp.RestResponse, RestSharp.RestRequestAsyncHandle))

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.RowEnter
        DataGridView2.Rows.Clear()
 

        Dim response = R1RestFunctions.R1RestRequest(Method.GET, "jobs/" & DataGridView1.Rows.Item(e.RowIndex).Cells(1).Value.ToString)
        If response.GetType Is GetType(ADG.WebLab.Web.Controllers.API.ApiResponse(Of Object)) Then
            If response.Success = True Then
                Dim jobs = JsonConvert.DeserializeObject(Of List(Of ADG.WebLab.Web.Controllers.API.Job.JobInfo))(response.Data.ToString)
                For Each item As ADG.WebLab.Web.Controllers.API.Job.JobInfo In jobs
                    DataGridView2.Rows.Add(New String() {item.Name, item.Status})
                Next
            Else
                MsgBox(response.error.message)
            End If
        Else
            MsgBox(response)
        End If


    End Sub

  

    Private Sub Button8_Click(sender As Object, e As EventArgs)

        'Dim client As New RestSharp.RestClient("https://10.0.1.52/R1/api")
        'client.CookieContainer = AuthenticateWithR1()

        Dim request = New RestSharp.RestRequest("projects", RestSharp.Method.OPTIONS)
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpSerializer.RestSharpJsonNetSerializer
        'Dim apirew As New ADG.WebLab.Web.Controllers.API.ApiRequest(Of ADG.WebLab.Web.Controllers.API.Project.IProjectService)
        'apirew.Options = New ADG.WebLab.Web.Controllers.API.ApiOptions

        '   apirew.Data.GetOptions()



        request.AddHeader("Accept", "application/json")
        request.Parameters.Clear()
        '     request.AddParameter("application/json", Json.JsonConvert.SerializeObject(apirew), ParameterType.RequestBody)


        ' request.AddObject(newproject)
        Dim r1cl As RestClient = r1c
        Dim response As RestSharp.RestResponse(Of ADG.WebLab.Web.Controllers.API.ApiResponse(Of Object)) = r1cl.Execute(request)
        '  Dim response As RestSharp.RestResponse = r1cl.Execute(request)
        Dim content = response.Data.Data
        MsgBox(content.ToString)
    End Sub

    Private Sub Button8_Click_1(sender As Object, e As EventArgs)
        DataGridView1.Rows.Clear()
        '  Dim client As New RestSharp.RestClient("https://10.0.1.52/R1/api")
        '  client.CookieContainer = AuthenticateWithR1()

        Dim request = New RestSharp.RestRequest("projects", RestSharp.Method.GET)

        'Dim r1cl As RestClient = r1c
        'Dim response As RestSharp.RestResponse = r1cl.Execute(request)
        'Dim returnjson As String = response.Content
        '---------------------
        request.RequestFormat = DataFormat.Json
        request.JsonSerializer = New RestSharpSerializer.RestSharpJsonNetSerializer


        Dim apioptions As New ADG.WebLab.Web.Controllers.API.ApiOptions
        apioptions.Where = "Name='User Case'"




        request.AddHeader("Accept", "application/json")
        request.Parameters.Clear()
        request.AddQueryParameter("Skip", "3")
        '------------------------
        ' request.AddObject(newproject)
        Dim r1cl As RestClient = r1c
        Dim response As RestSharp.RestResponse = r1cl.Execute(request)
        Dim returnjson As String = response.Content

        Dim ProjectList As R1SimpleRestClasses.ProjectList = JsonConvert.DeserializeObject(Of R1SimpleRestClasses.ProjectList)(returnjson)
        For Each item As R1SimpleRestClasses.ProjectInformation In ProjectList.data

            DataGridView1.Rows.Add(New String() {item.name, item.ftkCaseId})

        Next

    End Sub

    Private Sub btnSaveSettings_Click(sender As Object, e As EventArgs) Handles btnSaveSettings.Click
        My.Settings.Server = txtServer.Text
        My.Settings.Username = txtUsername.Text
        My.Settings.Password = txtPassword.Text
        My.Settings.Save()
        lblStatusSettings.Text = "Settings Saved"
    End Sub

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click

        r1c.BaseUrl = New Uri("https://" & txtServer.Text & "/R1/api")
        Dim r1ccon = R1RestFunctions.AuthenticateWithR1(txtServer.Text, txtUsername.Text, txtPassword.Text)
        If r1ccon.GetType Is GetType(String) Then
            MsgBox(r1ccon)
            statconnection.Text = "Not Connected - " & r1ccon
        Else
            r1c.CookieContainer = r1ccon
            statconnection.Text = "Connected"
        End If
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles tabSettings.Click

    End Sub

    Private Sub TabPage1_Enter(sender As Object, e As EventArgs) Handles tabSettings.Enter
        lblStatusSettings.Text = ""
    End Sub

    Private Sub StatusStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles StatusStrip1.ItemClicked

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles btnAPICallCustom.Click
   
        Dim response = R1RestFunctions.R1RestRequest(cmbRESTOPTION.SelectedItem, txtapicallpath.Text, txtapicallpostjson.Text)

        If response.GetType Is GetType(ADG.WebLab.Web.Controllers.API.ApiResponse(Of Object)) Then
            If response.Success = True Then
                MsgBox(response.Data.ToString)
            Else
                MsgBox(response.error.message)
            End If

        Else
            MsgBox(response)
        End If

        Dim newproject As New ADG.RIA.DataServices.Web.NewProjectDefinition
        newproject.Name = txtProjectName.Text
        newproject.FTKCaseFolderPath = "\\10.0.1.52\Share\Projects"
        newproject.ResponsiveFilePath = "\\10.0.1.52\Share\JobData"
        newproject.ProcessingMode = Web.ProcessModeEnum.Security

        txtapicallpostjson.Text = Json.JsonConvert.SerializeObject(newproject)

    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles tabTesting.Click

    End Sub

    Private Sub TabPage2_Enter(sender As Object, e As EventArgs) Handles tabTesting.Enter
        cmbRESTOPTION.Items.Clear()
        For Each item In GetType(RestSharp.Method).GetEnumValues
            cmbRESTOPTION.Items.Add(item)

        Next
        cmbRESTOPTION.SelectedItem = RestSharp.Method.GET

    End Sub

    Private Sub cmbRESTOPTION_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRESTOPTION.SelectedIndexChanged

    End Sub
End Class
