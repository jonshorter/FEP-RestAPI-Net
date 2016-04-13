﻿
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
Imports FEPRestClient

Public Class Form1
    Public RestClient As New FEPRestClient.Client
    Public Auth As AuthToken = New FEPRestClient.Models.Response.AuthToken
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

        Dim rc As New FEPRestClient.Client
        Dim JobResponse As ApiResponse(Of List(Of JobInfo57)) = rc.Functions.Job.CreateJob(Me.Auth, txtServer.Text, nj)
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

                    Dim prjinfo = R1Client.Functions.Project.GetProjectDetails(Me.Auth, txtServer.Text, currproject).Data
                    pgProject.SelectedObject = prjinfo

                Case 2
                    Dim x = MsgBox("Are you sure you want to delete the project?", MsgBoxStyle.YesNo, "Delete Project?")
                    If x = 6 Then
                        Dim R1Client As New FEPRestClient.Client
                        Dim deleteproject = R1Client.Functions.Project.DeleteProject(Me.Auth, txtServer.Text, currproject)
                        If deleteproject.Data = True Then
                            MsgBox("Project # " & currproject & " deleted.")
                        Else
                            MsgBox("Failed To Delete Project # " & dgvprojects.Rows.Item(e.RowIndex).Cells(1).Value.ToString)
                        End If
                    End If
                Case 3
                    Dim R1Client As New FEPRestClient.Client
                    Dim prjinfo As ProjectPresenter = R1Client.Functions.Project.GetProjectDetails(Me.Auth, txtServer.Text, dgvprojects.Rows.Item(e.RowIndex).Cells(1).Value.ToString).Data

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

        'Try
        '    Dim rc As New R1SimpleRestClient.R1SimpleRestClient
        '    Dim Jobs As ApiResponse(Of JobData) = rc.Functions.Job.GetAllJobs(Me.Auth, txtServer.Text)
        '    dgvJobs.Rows.Clear()

        '    For Each job As JobInfo In Jobs.Data.jobs
        '        dgvJobs.Rows.Add(New String() {job.Name, job.JobType, job.Status, job.JobID.ToString})

        '    Next
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try

        'comboJobType.Items.Clear()
        'For Each item In GetType(JobTypes).GetEnumValues
        '    comboJobType.Items.Add(item)
        'Next
        'comboJobType.SelectedItem = R1SimpleRestClient.Models.Enums.JobTypes.SoftwareInventory

        'comboJobAction.Items.Clear()
        'For Each item In GetType(R1SimpleRestClient.Models.Enums.JobAction).GetEnumValues
        '    comboJobAction.Items.Add(item)
        'Next
        'comboJobAction.SelectedItem = R1SimpleRestClient.Models.Enums.JobAction.Create
    End Sub


    Private Sub btnCreateProject_Click(sender As Object, e As EventArgs) Handles btnCreateProject.Click
        Dim newproject As New NewProjectDefinition
        newproject.Name = txtProjectName.Text
        newproject.FTKCaseFolderPath = txtProjectCaseFolder.Text
        newproject.ResponsiveFilePath = txtProjectJobDataFolder.Text
        newproject.ProcessingMode = cmbProjectProcessingMode.SelectedItem
        newproject.Comments = txtProjectDescription.Text

        Dim rc As New FEPRestClient.Client
        Dim NewProjectResponse As NewProjectDefinition = rc.Functions.Project.CreateProject(Me.Auth, txtServer.Text, newproject).Data
        MsgBox("Project Created: " & NewProjectResponse.Name)
    End Sub

    Private Sub tabCreateProject_Enter(sender As Object, e As EventArgs) Handles tabCreateProject.Enter
        'Dim rc As New R1SimpleRestClient.R1SimpleRestClient
        'txtProjectCaseFolder.Text = rc.Functions.Configuration.GetDefaultProjectsPath(Me.Auth, txtServer.Text).Data
        'txtProjectJobDataFolder.Text = rc.Functions.Configuration.GetDefaultJobDataPath(Me.Auth, txtServer.Text).Data


        'cmbProjectProcessingMode.Items.Clear()
        'For Each item In GetType(ProcessModeEnum).GetEnumValues
        '    cmbProjectProcessingMode.Items.Add(item)
        'Next
        'cmbProjectProcessingMode.SelectedItem = R1SimpleRestClient.Models.Enums.ProcessModeEnum.Security



    End Sub
    Private Sub tabCreateProject_Paint(sender As Object, e As PaintEventArgs) Handles tabCreateProject.Paint

    End Sub
    Private Sub tabProjects_Enter(sender As Object, e As EventArgs) Handles tabProjects.Enter
        Try
            'RestClient.Functions()
            '    Dim rc As New R1SimpleRestClient.R1SimpleRestClient
            ' Dim Projects As List(Of ProjectPresenter) = RestClient.Functions.Project.GetProjectList(Me.Auth, txtServer.Text).Data
            '    dgvprojects.Rows.Clear()

            '    For Each project In Projects
            '        dgvprojects.Rows.Add(New String() {project.Name, project.ProjectId.ToString, "X", "0"})
            '    Next
        Catch ex As Exception
            '    MsgBox(ex.Message)
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


        'Dim R1Client As New R1SimpleRestClient.R1SimpleRestClient

        'lblTotalResponses.Text = "Total Responses: " & R1Client.Functions.Alert.GetTotalResponses(Me.Auth, txtServer.Text)

        'lblTotalAutomatedResponses.Text = "Total Automated Responses: " & R1Client.Functions.Alert.GetTotalAutomatedResponses(Me.Auth, txtServer.Text)

        'lstAlertSourceBreakdown.Items.Clear()
        'Dim alertSrcBreakdowns As List(Of AlertSourceBreakdownResult) = R1Client.Functions.Alert.GetAlertSourceBreakdown(Me.Auth, txtServer.Text)
        'For Each alertSrc As AlertSourceBreakdownResult In alertSrcBreakdowns
        '    lstAlertSourceBreakdown.Items.Add(alertSrc.Name & " " & alertSrc.Count)
        'Next

        'Dim meantime As List(Of MeanTimeStatistics) = R1Client.Functions.Alert.GetMeanTimeStatistics(Me.Auth, txtServer.Text)
        'lblMeanTimeStat.Text = "Mean Time Stat: " & meantime(0).meanTime


        'Try
        '    Dim rc As New R1SimpleRestClient.R1SimpleRestClient
        '    Dim Alerts As AlertsWithCounts = rc.Functions.Alert.GetAlertsWithCounts(Me.Auth, txtServer.Text)
        '    dgvAlertsWithCounts.Rows.Clear()

        '    For Each alert As AlertDataDetails In Alerts.entities
        '        dgvAlertsWithCounts.Rows.Add(New String() {alert.alertId, alert.artifactName, alert.description})
        '    Next
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
    End Sub

    Private Sub dgvprojectjobs_CellClick(sender As Object, e As DataGridViewCellEventArgs)

        If e.ColumnIndex = 0 Then
            '     Dim R1Client As New R1SimpleRestClient.R1SimpleRestClient
            '     Dim x = R1Client.Functions.Project.GenerateJobDetailsReport(Me.Auth, txtServer.Text, currproject, dgvprojectjobs.Rows.Item(e.RowIndex).Cells(3).Value.ToString)
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



    Private Sub btnAuth_Click(sender As Object, e As EventArgs)
        If tabTopMenu.TabPages.Contains(tabTesting) Then
            If Auth.Data.Cookies.Count > 0 Then
                MsgBox("Already Logged In")
            Else
                tabTopMenu.TabPages.Remove(tabTesting)
                Dim R1Auth As New FEPRestClient.R1Authentication
                Me.Auth = R1Auth.AuthenticateWithR1(txtServer.Text, txtUsername.Text, txtPassword.Text)
                If Me.Auth.Error = False Then
                    If Me.Auth.Error = False Then txtStatusStrip.Text = "Authenticated: True"
                    tabTopMenu.TabPages.Add(tabTesting)
                    tabTopMenu.SelectedTab = tabTesting
                End If

            End If
        Else
            Dim R1Auth As New FEPRestClient.R1Authentication
            Me.Auth = R1Auth.AuthenticateWithR1(txtServer.Text, txtUsername.Text, txtPassword.Text)
            If Me.Auth.Error = False Then
                txtStatusStrip.Text = "Authenticated: True"
                tabTopMenu.TabPages.Add(tabTesting)
                tabTopMenu.SelectedTab = tabTesting
            End If
        End If

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim r1logout As New FEPRestClient.R1Authentication
        r1logout.Logout(txtServer.Text, Me.Auth)
        txtStatusStrip.Text = "Authenticated: False"
        tabTopMenu.TabPages.Remove(tabTesting)
    End Sub

    Private Sub btnUpdateProject_Click(sender As Object, e As EventArgs) Handles btnUpdateProject.Click


        Dim projinfo As ProjectPresenter = pgProject.SelectedObject
        Dim R1Client As New FEPRestClient.Client
        Dim response As ProjectPresenter = R1Client.Functions.Project.UpdateProject(Me.Auth, txtServer.Text, projinfo).Data
        MsgBox("Project Updated")
        tabProjects_Enter(sender, e)

    End Sub

    Private Sub tabCreateProject_Click(sender As Object, e As EventArgs) Handles tabCreateProject.Click

    End Sub

    Private Sub Label22_Click(sender As Object, e As EventArgs) Handles Label22.Click

    End Sub

    Private Sub btnFindUser_Click(sender As Object, e As EventArgs) Handles btnFindUser.Click
        Dim rc As New FEPRestClient.Client
        Dim users As List(Of FEPRestClient.Models.User.UserLight) = rc.Functions.User.findUserByLastnameOrUsername(Me.Auth, txtServer.Text, txtfindUser.Text)
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
        Dim rc As New FEPRestClient.Client
        Dim IsIWAMode = rc.Functions.Configuration.IsIWAMode(Me.Auth, txtServer.Text).Data
        MsgBox(IsIWAMode)
    End Sub

    Private Sub btnGetTemplateID_Click(sender As Object, e As EventArgs) Handles btnGetTemplateID.Click
        Dim rc As New FEPRestClient.Client
        Dim template = rc.Functions.Templates.GetTemplate(Me.Auth, txtServer.Text, txtTemplateID.Text)
        MsgBox(template.Data.name)
    End Sub

    Private Sub tabGroups_Click(sender As Object, e As EventArgs) Handles tabGroups.Click

    End Sub

    Private Sub tabGroups_Enter(sender As Object, e As EventArgs) Handles tabGroups.Enter
        treeGroups.Nodes.Clear()
        Dim rc As New FEPRestClient.Client
        Dim groups As FEPRestClient.Models.Groups = rc.Functions.Groups.GetGroups(Me.Auth, txtServer.Text).Data
        Dim topnode As TreeNode = Me.treeGroups.Nodes.Add(groups.name)
        topnode.Name = groups.name
        For Each group In groups.children
            Dim x As TreeNode = topnode.Nodes.Add(group.name)
            x.Name = group.name
            GetAllChildren(x.Name, group)

        Next
    End Sub

    Private Sub tabTemplates_Enter(sender As Object, e As EventArgs) Handles tabTemplates.Enter
        Dim rc As New FEPRestClient.Client

        listTemplates.Items.Clear()
        listCategories.Items.Clear()

        Dim templates = rc.Functions.Templates.GetTemplates(Me.Auth, txtServer.Text)
        For Each template In templates.Data
            listTemplates.Items.Add(template.name)
        Next

        Dim categories = rc.Functions.Templates.GetCategories(Me.Auth, txtServer.Text)
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

        Dim rc As New FEPRestClient.Client
        Dim JobID = rc.Functions.Job.CreateJobFromTemplate(Me.Auth, txtServer.Text, nj, True)

        MsgBox("Job Created: " & JobID.Data)

    End Sub

    Private Sub tabThreatFilters_Click(sender As Object, e As EventArgs) Handles tabThreatFilters.Click

    End Sub

    Private Sub tabThreatFilters_Enter(sender As Object, e As EventArgs) Handles tabThreatFilters.Enter
        Dim rc As New FEPRestClient.Client

        listThreatFilters.Items.Clear()

        Dim apiresponse = rc.Functions.ThreatFilters.GetThreatFilters(Me.Auth, txtServer.Text)
        For Each tf In apiresponse.Data
            listThreatFilters.Items.Add(tf.Name)
        Next

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAuth6.Click
        Client.Username = txtUsername.Text
        Client.Password = txtPassword.Text
        Client.Server = txtServer.Text
        RestClient.Authenticate()
        If RestClient.IsAuthenticated = True Then
            txtStatusStrip.Text = "Authenticated: True"
            tabTopMenu.TabPages.Add(tabTesting)
            tabTopMenu.SelectedTab = tabTesting
        End If
    End Sub


End Class
