
Imports RestSharp
Imports System.Net
Imports System.Text
Imports System.IO
Imports System.Web
Imports Newtonsoft
Imports Newtonsoft.Json
Imports FEPRestClient.Models.Response
Imports FEPRestClient.Models.Job
Imports FEPRestClient.Models.Report
Imports FEPRestClient.Models.Enums
Imports FEPRestClient.Models.Project
Imports FEPRestClient.Models.Alert
Imports System.Collections.ObjectModel

Public Class Form1
    Public RestClient As New FEPRestClient.Client
    Dim currproject As String = 0

    Private Sub btnRefreshProjectList_Click(sender As Object, e As EventArgs) Handles btnRefreshProjectList.Click
        tabProjects_Enter(sender, e)
    End Sub
    Private Sub btnJobCreate_Click(sender As Object, e As EventArgs) Handles btnJobCreate.Click

        Dim nj As New FEPRestClient.Models.Job.JobDefinitionModel

        Dim njdef As New FEPRestClient.Models.Job.JobDefinition
        nj.JobDef = njdef
        nj.JobDef.Name = txtJobName.Text
        '   nj.JobDef.JobType = comboJobType.SelectedItem
        nj.JobDef.JobType = JobTypes.SoftwareInventory
        nj.ProjectId = txtFTKID.Text
        nj.JobDef.ProjectId = txtProjectID.Text
        nj.JobAction = comboJobAction.SelectedItem

        For Each item In lstTargets.Items
            nj.ComputerTargets.Addresses.Add(item)
        Next


        Dim JobResponse As ApiResponse(Of List(Of JobInfo57)) = RestClient.Functions.Job.CreateJob(nj)
        If JobResponse.Success = True Then
            MsgBox("Job Created: " & JobResponse.Data(0).Name)
        Else
            MsgBox(JobResponse.Error.Message)
        End If




    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtServer.Text = My.Settings.Server
        txtUsername.Text = My.Settings.Username
        txtPassword.Text = My.Settings.Password
        tabTopMenu.TabPages.Remove(tabTesting)
    End Sub
    Private Sub jobload(callback As Action(Of RestSharp.RestResponse, RestSharp.RestRequestAsyncHandle))

    End Sub

    Private Sub dgvprojects_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvprojects.CellClick
        currproject = dgvprojects.Rows.Item(e.RowIndex).Cells(1).Value.ToString
        Try
            Select Case e.ColumnIndex
                Case 0
                    Dim R1Client As New FEPRestClient.Client

                    Dim prjinfo = R1Client.Functions.Project.GetProjectDetails(currproject).Data
                    pgProject.SelectedObject = prjinfo

                Case 2
                    Dim x = MsgBox("Are you sure you want to delete the project?", MsgBoxStyle.YesNo, "Delete Project?")
                    If x = 6 Then
                        Dim R1Client As New FEPRestClient.Client
                        Dim deleteproject = R1Client.Functions.Project.DeleteProject(currproject)
                        If deleteproject.Data = True Then
                            MsgBox("Project # " & currproject & " deleted.")
                        Else
                            MsgBox("Failed To Delete Project # " & dgvprojects.Rows.Item(e.RowIndex).Cells(1).Value.ToString)
                        End If
                    End If
                Case 3
                    Dim R1Client As New FEPRestClient.Client
                    Dim prjinfo As ProjectPresenter = R1Client.Functions.Project.GetProjectDetails(dgvprojects.Rows.Item(e.RowIndex).Cells(1).Value.ToString).Data

                    txtProjectID.Text = prjinfo.ProjectId
                    txtFTKID.Text = prjinfo.FtkCaseId
                    tabBottomMenu.SelectedTab = tabJobs
            End Select

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnSaveSettings_Click(sender As Object, e As EventArgs) Handles btnSaveSettings.Click
        My.Settings.Server = txtServer.Text
        My.Settings.Username = txtUsername.Text
        My.Settings.Password = txtPassword.Text
        My.Settings.Save()
        lblStatusSettings.Text = "Settings Saved"


    End Sub

    Private Sub tabSettings_Enter(sender As Object, e As EventArgs) Handles tabSettings.Enter
        lblStatusSettings.Text = ""
    End Sub
    Private Sub btnAPICallCustom_Click(sender As Object, e As EventArgs) Handles btnAPICallCustom.Click
        Try

            Dim response = RestClient.CustomRequest(cmbRESTOPTION.SelectedItem, txtapicallpath.Text, txtapicallpostjson.Text)
            MsgBox(response.ToString)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub tabTesting_Enter(sender As Object, e As EventArgs) Handles tabTesting.Enter
        cmbRESTOPTION.Items.Clear()
        For Each item In GetType(RestSharp.Method).GetEnumValues
            cmbRESTOPTION.Items.Add(item)
        Next
        cmbRESTOPTION.SelectedItem = RestSharp.Method.GET
    End Sub


    Private Sub tabJobs_Enter(sender As Object, e As EventArgs) Handles tabJobs.Enter

        Try

            Dim Jobs As ApiResponse(Of JobData) = RestClient.Functions.Job.GetAllJobs()
            dgvJobs.Rows.Clear()

            For Each job As JobInfo In Jobs.Data.jobs
                dgvJobs.Rows.Add(New String() {job.Name, job.JobType, job.Status, job.JobID.ToString})

            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        comboJobType.Items.Clear()
        For Each item In GetType(JobTypes).GetEnumValues
            comboJobType.Items.Add(item)
        Next
        comboJobType.SelectedItem = FEPRestClient.Models.Enums.JobTypes.SoftwareInventory

        comboJobAction.Items.Clear()
        For Each item In GetType(FEPRestClient.Models.Enums.JobAction).GetEnumValues
            comboJobAction.Items.Add(item)
        Next
        comboJobAction.SelectedItem = FEPRestClient.Models.Enums.JobAction.Create
    End Sub


    Private Sub btnCreateProject_Click(sender As Object, e As EventArgs) Handles btnCreateProject.Click
        Dim newproject As New NewProjectDefinition
        newproject.Name = txtProjectName.Text
        newproject.FTKCaseFolderPath = txtProjectCaseFolder.Text
        newproject.ResponsiveFilePath = txtProjectJobDataFolder.Text
        newproject.ProcessingMode = cmbProjectProcessingMode.SelectedItem
        newproject.Comments = txtProjectDescription.Text


        Dim NewProjectResponse As NewProjectDefinition = RestClient.Functions.Project.CreateProject(newproject).Data
        MsgBox("Project Created: " & NewProjectResponse.Name)
    End Sub

    Private Sub tabCreateProject_Enter(sender As Object, e As EventArgs) Handles tabCreateProject.Enter
        'Dim rc As New R1SimpleRestClient.R1SimpleRestClient
        txtProjectCaseFolder.Text = RestClient.Functions.Configuration.GetDefaultProjectsPath().Data
        txtProjectJobDataFolder.Text = RestClient.Functions.Configuration.GetDefaultJobDataPath().Data


        cmbProjectProcessingMode.Items.Clear()
        For Each item In GetType(ProcessModeEnum).GetEnumValues
            cmbProjectProcessingMode.Items.Add(item)
        Next
        cmbProjectProcessingMode.SelectedItem = FEPRestClient.Models.Enums.ProcessModeEnum.Security



    End Sub
    Private Sub tabCreateProject_Paint(sender As Object, e As PaintEventArgs) Handles tabCreateProject.Paint

    End Sub
    Private Sub tabProjects_Enter(sender As Object, e As EventArgs) Handles tabProjects.Enter
        Try
          
            Dim Projects As List(Of ProjectPresenter) = RestClient.Functions.Project.GetProjectList.Data
            dgvprojects.Rows.Clear()

            For Each project In Projects
                dgvprojects.Rows.Add(New String() {project.Name, project.ProjectId.ToString, "X", "0"})
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Private Sub btnAddNewTarget_Click(sender As Object, e As EventArgs) Handles btnAddNewTarget.Click
        lstTargets.Items.Add(txtNewTarget.Text)
    End Sub

    Private Sub btnRemoveSelectedTargets_Click(sender As Object, e As EventArgs) Handles btnRemoveSelectedTargets.Click
        With lstTargets
            If .CheckedItems.Count > 0 Then
                For checked As Integer = .CheckedItems.Count - 1 To 0 Step -1
                    .Items.Remove(.CheckedItems(checked))
                Next
            End If
        End With
    End Sub

    Private Sub tabCreateJob_Click(sender As Object, e As EventArgs) Handles tabJobs.Click

    End Sub

    Private Sub tabAlerts_Click(sender As Object, e As EventArgs) Handles tabAlerts.Click

    End Sub

    Private Sub tabAlerts_Enter(sender As Object, e As EventArgs) Handles tabAlerts.Enter


        lblTotalResponses.Text = "Total Responses: " & RestClient.Functions.Alert.GetTotalResponses()

        lblTotalAutomatedResponses.Text = "Total Automated Responses: " & RestClient.Functions.Alert.GetTotalAutomatedResponses()

        lstAlertSourceBreakdown.Items.Clear()
        Dim alertSrcBreakdowns As List(Of AlertSourceBreakdownResult) = RestClient.Functions.Alert.GetAlertSourceBreakdown()
        For Each alertSrc As AlertSourceBreakdownResult In alertSrcBreakdowns
            lstAlertSourceBreakdown.Items.Add(alertSrc.Name & " " & alertSrc.Count)
        Next

        Dim meantime As List(Of MeanTimeStatistics) = RestClient.Functions.Alert.GetMeanTimeStatistics()
        If meantime.Count > 0 Then
            lblMeanTimeStat.Text = "Mean Time Stat: " & meantime(0).meanTime
        End If



        Try

            Dim Alerts As AlertsWithCounts = RestClient.Functions.Alert.GetAlertsWithCounts()
            dgvAlertsWithCounts.Rows.Clear()

            For Each alert As AlertDataDetails In Alerts.entities
                dgvAlertsWithCounts.Rows.Add(New String() {alert.alertId, alert.artifactName, alert.description})
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgvprojectjobs_CellClick(sender As Object, e As DataGridViewCellEventArgs)

        If e.ColumnIndex = 0 Then

            ' Dim x = RestClient.Functions.Project.GenerateJobDetailsReport(currproject, dgvprojectjobs.Rows.Item(e.RowIndex).Cells(3).Value.ToString)
            '     MsgBox(x)

        End If

        'NOT IMPLEMENTED YET

        'Try
        '    If e.ColumnIndex = 0 Then
        '        dgvprojectjobreports.Rows.Clear()


        '        Dim response = R1RestFunctions.R1RestRequest(Method.GET, "projects/" & currproject & "/jobs/jobresultreports/" & dgvprojectjobs.Rows.Item(e.RowIndex).Cells(3).Value.ToString & "/")
        '        If response.GetType Is GetType(R1SimpleRestModels.Models.ApiResponse(Of Object)) Then
        '            If response.Success = True Then
        '                Dim reportstatus = JsonConvert.DeserializeObject(Of R1SimpleRestModels.Models.ApiResponse(Of ADG.RIA.DataServices.Web.JobReportDataStatus))(response.Data.ToString)
        '                ' For Each report As ADG.RIA.DataServices.Web.JobReportDataStatus In reports.Data
        '                dgvprojectjobreports.Rows.Add(New String() {reportstatus.Data.Status, reportstatus.Data.ReportType.ToString})
        '                'Next
        '            Else
        '                MsgBox(response.error.message)
        '            End If
        '        Else
        '            MsgBox(response)
        '        End If

        '    End If
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
    End Sub

    Private Sub dgvProjectReports_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub dgvprojects_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvprojects.CellContentClick

    End Sub

    Private Sub dgvprojectjobs_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub dgvprojectjobs_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub tabProjects_Click(sender As Object, e As EventArgs) Handles tabProjects.Click

    End Sub

    Private Sub StatusStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub




    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        RestClient.Logout()
        txtStatusStrip.Text = "Authenticated: False"
        tabTopMenu.TabPages.Remove(tabTesting)
    End Sub

    Private Sub btnUpdateProject_Click(sender As Object, e As EventArgs) Handles btnUpdateProject.Click


        Dim projinfo As ProjectPresenter = pgProject.SelectedObject
        Dim R1Client As New FEPRestClient.Client
        Dim response As ProjectPresenter = R1Client.Functions.Project.UpdateProject(projinfo).Data
        MsgBox("Project Updated")
        tabProjects_Enter(sender, e)

    End Sub

    Private Sub tabCreateProject_Click(sender As Object, e As EventArgs) Handles tabCreateProject.Click

    End Sub

    Private Sub Label22_Click(sender As Object, e As EventArgs) Handles Label22.Click

    End Sub

    Private Sub btnFindUser_Click(sender As Object, e As EventArgs) Handles btnFindUser.Click

        Dim users As List(Of FEPRestClient.Models.User.UserLight) = RestClient.Functions.User.findUserByLastnameOrUsername(txtfindUser.Text)
        If users.Count > 0 Then
            Dim UsersMessage As String = ""
            For Each user In users
                UsersMessage = UsersMessage & vbCrLf & "User Found: " & user.firstname & " " & user.lastname & vbCrLf & "Username: " & user.username
            Next
            MsgBox(UsersMessage)
        Else
            MsgBox("No Results Found")
        End If

    End Sub

    Private Sub btnLoadGroupsTree_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GetAllChildren(parent As String, children As FEPRestClient.Models.Groups)
        Dim subnode() As TreeNode = treeGroups.Nodes.Find(parent, True)
        If subnode.Count > 0 Then
            For Each subgroup In children.children
                Dim y As TreeNode = subnode(0).Nodes.Add(subgroup.name)
                y.Name = subgroup.name
                GetAllChildren(y.Name, subgroup)
            Next
        End If
    End Sub

    Private Sub tabTemplates_Click(sender As Object, e As EventArgs) Handles tabTemplates.Click

    End Sub

    Private Sub btnIsIWAMode_Click(sender As Object, e As EventArgs) Handles btnIsIWAMode.Click

        Dim IsIWAMode = RestClient.Functions.Configuration.IsIWAMode().Data
        MsgBox(IsIWAMode)
    End Sub

    Private Sub btnGetTemplateID_Click(sender As Object, e As EventArgs) Handles btnGetTemplateID.Click

        Dim template = RestClient.Functions.Templates.GetTemplate(txtTemplateID.Text)
        MsgBox(template.Data.name)
    End Sub

    Private Sub tabGroups_Click(sender As Object, e As EventArgs) Handles tabGroups.Click

    End Sub

    Private Sub tabGroups_Enter(sender As Object, e As EventArgs) Handles tabGroups.Enter
        treeGroups.Nodes.Clear()

        Dim groups As FEPRestClient.Models.Groups = RestClient.Functions.Groups.GetGroups().Data
        Dim topnode As TreeNode = Me.treeGroups.Nodes.Add(groups.name)
        topnode.Name = groups.name
        For Each group In groups.children
            Dim x As TreeNode = topnode.Nodes.Add(group.name)
            x.Name = group.name
            GetAllChildren(x.Name, group)

        Next
    End Sub

    Private Sub tabTemplates_Enter(sender As Object, e As EventArgs) Handles tabTemplates.Enter
    
        listTemplates.Items.Clear()
        listCategories.Items.Clear()

        Dim templates = RestClient.Functions.Templates.GetTemplates()
        For Each template In templates.Data
            listTemplates.Items.Add(template.name)
        Next

        Dim categories = RestClient.Functions.Templates.GetCategories()
        For Each category In categories.Data
            listCategories.Items.Add(category.name)
        Next
    End Sub

    Private Sub btnJobFromTemplate_Click(sender As Object, e As EventArgs) Handles btnJobFromTemplate.Click
        Dim nj As New FEPRestClient.Models.Job2.JobFromTemplate
        nj.ProjectId = "648354e3-e55b-4f5e-9576-5ca4a9507a9c"
        nj.TemplateId = "8b8f0411-4743-4914-959d-2f48194c1cc4"
        nj.ComputerTargets.Add("ee045e18-306b-409a-aa28-8c8e4726051c")

        '  For Each item In lstTargets.Items
        ' nj.ComputerTargets.Addresses.Add(item)
        ' Next

        Dim JobID = RestClient.Functions.Job.CreateJobFromTemplate(nj, True)

        MsgBox("Job Created: " & JobID.Data)

    End Sub

    Private Sub tabThreatFilters_Click(sender As Object, e As EventArgs) Handles tabThreatFilters.Click

    End Sub

    Private Sub tabThreatFilters_Enter(sender As Object, e As EventArgs) Handles tabThreatFilters.Enter
      
        listThreatFilters.Items.Clear()

        Dim apiresponse = RestClient.Functions.ThreatFilters.GetThreatFilters()
        For Each tf In apiresponse.Data
            listThreatFilters.Items.Add(tf.Name)
        Next

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAuth6.Click

        RestClient.Username = txtUsername.Text
        RestClient.Password = txtPassword.Text
        RestClient.Server = txtServer.Text
        RestClient.Authenticate()
        If RestClient.IsAuthenticated = True Then
            txtStatusStrip.Text = "Authenticated: True"
            tabTopMenu.TabPages.Add(tabTesting)
            tabTopMenu.SelectedTab = tabTesting
        End If


    End Sub


End Class
