
Imports RestSharp
Imports System.Net
Imports System.Text
Imports System.IO
Imports System.Web
Imports Newtonsoft
Imports Newtonsoft.Json
Imports R1SimpleRestClient.Models.Response
Imports R1SimpleRestClient.Models.Job
Imports R1SimpleRestClient.Models.Report
Imports R1SimpleRestClient.Models.Enums
Imports R1SimpleRestClient.Models.Project
Imports R1SimpleRestClient.Models.Alert
Imports System.Collections.ObjectModel

Public Class Form1
    Public Auth As AuthToken = New R1SimpleRestClient.Models.Response.AuthToken
    Dim currproject As Integer = 0

    Private Sub btnRefreshProjectList_Click(sender As Object, e As EventArgs) Handles btnRefreshProjectList.Click
        tabProjects_Enter(sender, e)
    End Sub
    Private Sub btnJobCreate_Click(sender As Object, e As EventArgs) Handles btnJobCreate.Click

        Dim nj As New R1SimpleRestClient.Models.Job.JobDefinitionModel

        Dim njdef As New R1SimpleRestClient.Models.Job.JobDefinition
        nj.JobDef = njdef
        nj.JobDef.Name = txtJobName.Text
        nj.JobDef.JobType = comboJobType.SelectedItem
        nj.ProjectId = txtProjectID.Text
        nj.JobAction = comboJobAction.SelectedItem
        For Each item In lstTargets.Items
            nj.ComputerTargets.Addresses.Add(item)
        Next

        Dim rc As New R1SimpleRestClient.R1SimpleRestClient
        Dim JobResponse As List(Of JobInfo57) = rc.Functions.Job.CreateJob(Me.Auth, txtServer.Text, nj)
        If JobResponse.Count > 0 Then
            MsgBox("Job Created: " & JobResponse(0).Name)
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
                    Dim R1Client As New R1SimpleRestClient.R1SimpleRestClient
                    Dim Jobs As List(Of JobInfo57) = R1Client.Functions.Project.GetJobsForProject(Me.Auth, txtServer.Text, currproject)
                    dgvprojectjobs.Rows.Clear()
                    For Each job In Jobs
                        dgvprojectjobs.Rows.Add(New String() {job.Name, job.JobType.ToString, job.Status, job.JobID.ToString})
                    Next

                    Dim prjinfo = R1Client.Functions.Project.GetProjectDetails(Me.Auth, txtServer.Text, currproject)
                    pgProject.SelectedObject = prjinfo

                    Dim projectreports = R1Client.Functions.Project.GetProjectReports(Me.Auth, txtServer.Text, currproject)
                    dgvProjectReports.Rows.Clear()
                    For Each report As BasicReport In projectreports
                        dgvProjectReports.Rows.Add(New String() {report.ReportInfo.Name, report.ReportInfo.ReportType.ToString, report.ReportInfo.Status.ToString, report.ReportInfo.FilePath, report.ReportInfo.ReportId})
                    Next
                Case 2
                    Dim x = MsgBox("Are you sure you want to delete the project?", MsgBoxStyle.YesNo, "Delete Project?")
                    If x = 6 Then
                        Dim R1Client As New R1SimpleRestClient.R1SimpleRestClient
                        Dim deleteproject = R1Client.Functions.Project.DeleteProject(Me.Auth, txtServer.Text, currproject)
                        If deleteproject = True Then
                            MsgBox("Project # " & currproject & " deleted.")
                        Else
                            MsgBox("Failed To Delete Project # " & dgvprojects.Rows.Item(e.RowIndex).Cells(1).Value.ToString)
                        End If
                    End If
                Case 3
                    txtProjectID.Text = dgvprojects.Rows.Item(e.RowIndex).Cells(1).Value.ToString
                    tabBottomMenu.SelectedTab = tabCreateJob
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
            Dim R1Client As New R1SimpleRestClient.R1SimpleRestClient
            Dim response = R1Client.R1RestRequest(Me.Auth, txtServer.Text, cmbRESTOPTION.SelectedItem, txtapicallpath.Text, txtapicallpostjson.Text)
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


    Private Sub tabJobs_Enter(sender As Object, e As EventArgs) Handles tabCreateJob.Enter
        comboJobType.Items.Clear()
        For Each item In GetType(JobTypes).GetEnumValues
            comboJobType.Items.Add(item)
        Next
        comboJobType.SelectedItem = R1SimpleRestClient.Models.Enums.JobTypes.SoftwareInventory

        comboJobAction.Items.Clear()
        For Each item In GetType(R1SimpleRestClient.Models.Enums.JobAction).GetEnumValues
            comboJobAction.Items.Add(item)
        Next
        comboJobAction.SelectedItem = R1SimpleRestClient.Models.Enums.JobAction.Create
    End Sub

    Private Sub dgvProjectReports_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProjectReports.CellClick
        Try
            If e.ColumnIndex = 3 And dgvProjectReports.Rows.Item(e.RowIndex).Cells(2).Value.ToString = "Completed" Then
                System.Diagnostics.Process.Start(dgvProjectReports.Rows.Item(e.RowIndex).Cells(3).Value.ToString)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnCreateProject_Click(sender As Object, e As EventArgs) Handles btnCreateProject.Click
        Dim newproject As New NewProjectDefinition
        newproject.Name = txtProjectName.Text
        newproject.FTKCaseFolderPath = txtProjectCaseFolder.Text
        newproject.ResponsiveFilePath = txtProjectJobDataFolder.Text
        newproject.ProcessingMode = cmbProjectProcessingMode.SelectedItem
        newproject.Comments = txtProjectDescription.Text
       
        Dim rc As New R1SimpleRestClient.R1SimpleRestClient
        Dim NewProjectResponse As NewProjectDefinition = rc.Functions.Project.CreateProject(Me.Auth, txtServer.Text, newproject)
        MsgBox("Project Created: " & NewProjectResponse.Name)
    End Sub

    Private Sub tabCreateProject_Enter(sender As Object, e As EventArgs) Handles tabCreateProject.Enter
        cmbProjectProcessingMode.Items.Clear()
        For Each item In GetType(ProcessModeEnum).GetEnumValues
            cmbProjectProcessingMode.Items.Add(item)
        Next
        cmbProjectProcessingMode.SelectedItem = R1SimpleRestClient.Models.Enums.ProcessModeEnum.Security

      

    End Sub
    Private Sub tabCreateProject_Paint(sender As Object, e As PaintEventArgs) Handles tabCreateProject.Paint

    End Sub
    Private Sub tabProjects_Enter(sender As Object, e As EventArgs) Handles tabProjects.Enter
        Try
            Dim rc As New R1SimpleRestClient.R1SimpleRestClient
            Dim Projects As List(Of ProjectPresenter) = rc.Functions.Project.GetProjectList(Me.Auth, txtServer.Text)
            dgvprojects.Rows.Clear()

            For Each project In Projects
                dgvprojects.Rows.Add(New String() {project.Name, project.FtkCaseId, "X", "0"})
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            Dim rc As New R1SimpleRestClient.R1SimpleRestClient
            Dim Jobs As ApiResponse(Of JobData) = rc.Functions.Job.GetAllJobs(Me.Auth, txtServer.Text)
            dgvJobs.Rows.Clear()

            For Each job As JobInfo In Jobs.Data.jobs
                dgvJobs.Rows.Add(New String() {job.Name, job.Status, job.JobID.ToString})

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

    Private Sub tabCreateJob_Click(sender As Object, e As EventArgs) Handles tabCreateJob.Click

    End Sub

    Private Sub tabAlerts_Click(sender As Object, e As EventArgs) Handles tabAlerts.Click

    End Sub

    Private Sub tabAlerts_Enter(sender As Object, e As EventArgs) Handles tabAlerts.Enter


        Dim R1Client As New R1SimpleRestClient.R1SimpleRestClient

        lblTotalResponses.Text = "Total Responses: " & R1Client.Functions.Alert.GetTotalResponses(Me.Auth, txtServer.Text)

        lblTotalAutomatedResponses.Text = "Total Automated Responses: " & R1Client.Functions.Alert.GetTotalAutomatedResponses(Me.Auth, txtServer.Text)

        lstAlertSourceBreakdown.Items.Clear()
        Dim alertSrcBreakdowns As List(Of AlertSourceBreakdownResult) = R1Client.Functions.Alert.GetAlertSourceBreakdown(Me.Auth, txtServer.Text)
        For Each alertSrc As AlertSourceBreakdownResult In alertSrcBreakdowns
            lstAlertSourceBreakdown.Items.Add(alertSrc.Name & " " & alertSrc.Count)
        Next

        Dim meantime As List(Of MeanTimeStatistics) = R1Client.Functions.Alert.GetMeanTimeStatistics(Me.Auth, txtServer.Text)
        lblMeanTimeStat.Text = "Mean Time Stat: " & meantime(0).meanTime


        Try
            Dim rc As New R1SimpleRestClient.R1SimpleRestClient
            Dim Alerts As AlertsWithCounts = rc.Functions.Alert.GetAlertsWithCounts(Me.Auth, txtServer.Text)
            dgvAlertsWithCounts.Rows.Clear()

            For Each alert As AlertDataDetails In Alerts.entities
                dgvAlertsWithCounts.Rows.Add(New String() {alert.alertId, alert.artifactName, alert.description})
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgvprojectjobs_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvprojectjobs.CellClick

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

    Private Sub dgvProjectReports_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProjectReports.CellContentClick

    End Sub

    Private Sub dgvprojects_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvprojects.CellContentClick

    End Sub

    Private Sub dgvprojectjobs_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvprojectjobs.CellContentClick

    End Sub

    Private Sub dgvprojectjobs_Click(sender As Object, e As EventArgs) Handles dgvprojectjobs.Click

    End Sub


    Private Sub tabProjects_Click(sender As Object, e As EventArgs) Handles tabProjects.Click

    End Sub

    Private Sub StatusStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub



    Private Sub btnAuth_Click(sender As Object, e As EventArgs) Handles btnAuth.Click
        If tabTopMenu.TabPages.Contains(tabTesting) Then
            If Auth.Data.count > 0 Then
                MsgBox("Already Logged In")
            Else
                tabTopMenu.TabPages.Remove(tabTesting)
                Dim R1Auth As New R1SimpleRestClient.R1Authentication
                Me.Auth = R1Auth.AuthenticateWithR1(txtServer.Text, txtUsername.Text, txtPassword.Text)
                If Me.Auth.Error = False Then
                    If Me.Auth.Error = False Then txtStatusStrip.Text = "Authenticated: True"
                    tabTopMenu.TabPages.Add(tabTesting)
                    tabTopMenu.SelectedTab = tabTesting
                End If

            End If
        Else
                Dim R1Auth As New R1SimpleRestClient.R1Authentication
                Me.Auth = R1Auth.AuthenticateWithR1(txtServer.Text, txtUsername.Text, txtPassword.Text)
            If Me.Auth.Error = False Then
                txtStatusStrip.Text = "Authenticated: True"
                tabTopMenu.TabPages.Add(tabTesting)
                tabTopMenu.SelectedTab = tabTesting
            End If
        End If

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim r1logout As New R1SimpleRestClient.R1Authentication
        r1logout.Logout(txtServer.Text, Me.Auth)
        txtStatusStrip.Text = "Authenticated: False"
        tabTopMenu.TabPages.Remove(tabTesting)
    End Sub

    Private Sub btnUpdateProject_Click(sender As Object, e As EventArgs) Handles btnUpdateProject.Click


        Dim projinfo As ProjectPresenter = pgProject.SelectedObject
        Dim R1Client As New R1SimpleRestClient.R1SimpleRestClient
        Dim response As ProjectPresenter = R1Client.Functions.Project.UpdateProject(Me.Auth, txtServer.Text, projinfo)
        MsgBox("Project Updated")
        tabProjects_Enter(sender, e)

    End Sub

    Private Sub tabCreateProject_Click(sender As Object, e As EventArgs) Handles tabCreateProject.Click

    End Sub

    Private Sub Label22_Click(sender As Object, e As EventArgs) Handles Label22.Click

    End Sub

    Private Sub btnFindUser_Click(sender As Object, e As EventArgs) Handles btnFindUser.Click
        Dim rc As New R1SimpleRestClient.R1SimpleRestClient
        Dim users As List(Of R1SimpleRestClient.Models.User.UserLight) = rc.Functions.User.findUserByLastnameOrUsername(Me.Auth, txtServer.Text, txtfindUser.Text)
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

    Private Sub btnLoadGroupsTree_Click(sender As Object, e As EventArgs) Handles btnLoadGroupsTree.Click
        Dim rc As New R1SimpleRestClient.R1SimpleRestClient
        Dim groups As R1SimpleRestClient.Models.Groups = rc.Functions.Groups.GetGroups(Me.Auth, txtServer.Text)
        Dim topnode As TreeNode = Me.treeGroups.Nodes.Add(groups.name)
        topnode.Name = groups.name
        For Each group In groups.children
            Dim x As TreeNode = topnode.Nodes.Add(group.name)
            x.Name = group.name
            GetAllChildren(x.Name, group)
          
        Next
    End Sub

    Private Sub GetAllChildren(parent As String, children As R1SimpleRestClient.Models.Groups)
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
        Dim rc As New R1SimpleRestClient.R1SimpleRestClient
        Dim templates As List(Of R1SimpleRestClient.Models.Templates.Templates) = rc.Functions.Templates.GetTemplates(Me.Auth, txtServer.Text)
        For Each template In templates
            listTemplates.Items.Add(template.name)
        Next


        Dim categories As List(Of R1SimpleRestClient.Models.Templates.Categories) = rc.Functions.Templates.GetCategories(Me.Auth, txtServer.Text)
        For Each category In categories
            listCategories.Items.Add(category.name)
        Next
    End Sub

    Private Sub btnIsIWAMode_Click(sender As Object, e As EventArgs) Handles btnIsIWAMode.Click
        Dim rc As New R1SimpleRestClient.R1SimpleRestClient
        Dim IsIWAMode As Boolean = rc.Functions.Configuration.IsIWAMode(Me.Auth, txtServer.Text)
        MsgBox(IsIWAMode)
    End Sub

    Private Sub btnGetTemplateID_Click(sender As Object, e As EventArgs) Handles btnGetTemplateID.Click
        Dim rc As New R1SimpleRestClient.R1SimpleRestClient
        Dim template As R1SimpleRestClient.Models.Templates.TemplateInformation = rc.Functions.Templates.GetTemplate(Me.Auth, txtServer.Text, txtTemplateID.Text)
        MsgBox(template.name)
    End Sub
End Class
