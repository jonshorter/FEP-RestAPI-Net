﻿
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

Public Class Form1
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

        '   Dim njc As New R1SimpleRestModels.Models.Target
        '  njc.Addresses = New List(Of String)

        For Each item In lstTargets.Items
            ' njc.Addresses.Add(item)
            nj.ComputerTargets.Addresses.Add(item)
        Next
        ' nj.ComputerTargets = njc


        'Dim stc As New R1SimpleRestModels.Models.Target
        'nj.NetworkShareTargets = stc


        Dim R1Client As New R1SimpleRestClient.R1SimpleRestClient
        Dim response = R1Client.R1RestRequest(txtServer.Text, txtUsername.Text, txtPassword.Text, Method.PUT, "jobs", Json.JsonConvert.SerializeObject(nj))
        If response.GetType Is GetType(ApiResponse(Of Object)) Then
            If response.Success = True Then
                Dim job = JsonConvert.DeserializeObject(Of List(Of JobInfo))(response.Data.ToString)

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
    Private Sub jobload(callback As Action(Of RestSharp.RestResponse, RestSharp.RestRequestAsyncHandle))

    End Sub

    Private Sub dgvprojects_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvprojects.CellClick
        currproject = dgvprojects.Rows.Item(e.RowIndex).Cells(1).Value.ToString
        Try
            Select Case e.ColumnIndex
                Case 0
                    Dim R1Client As New R1SimpleRestClient.R1SimpleRestClient
                    Dim Jobs As List(Of JobInfo) = R1Client.Functions.Project.GetJobsForProject(txtServer.Text, txtUsername.Text, txtPassword.Text, currproject)
                    dgvprojectjobs.Rows.Clear()
                    For Each job In Jobs
                        dgvprojectjobs.Rows.Add(New String() {job.Name, job.JobType.ToString, job.Status, job.JobID.ToString})
                    Next

                    Dim prjinfo = R1Client.Functions.Project.GetProjectDetails(txtServer.Text, txtUsername.Text, txtPassword.Text, currproject)
                    pgProject.SelectedObject = prjinfo

                    Dim projectreports = R1Client.Functions.Project.GetProjectReports(txtServer.Text, txtUsername.Text, txtPassword.Text, currproject)
                    dgvProjectReports.Rows.Clear()
                    For Each report As BasicReport In projectreports
                        dgvProjectReports.Rows.Add(New String() {report.ReportInfo.Name, report.ReportInfo.ReportType.ToString, report.ReportInfo.Status.ToString, report.ReportInfo.FilePath, report.ReportInfo.ReportId})
                    Next
                Case 2
                    Dim x = MsgBox("Are you sure you want to delete the project?", MsgBoxStyle.YesNo, "Delete Project?")
                    If x = 6 Then
                        Dim R1Client As New R1SimpleRestClient.R1SimpleRestClient
                        Dim deleteproject = R1Client.Functions.Project.DeleteProject(txtServer.Text, txtUsername.Text, txtPassword.Text, currproject)
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
        Dim R1Client As New R1SimpleRestClient.R1SimpleRestClient
        Dim response = R1Client.R1RestRequest(txtServer.Text, txtUsername.Text, txtPassword.Text, cmbRESTOPTION.SelectedItem, txtapicallpath.Text, txtapicallpostjson.Text)
        MsgBox(response.ToString)
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

        Dim R1Client As New R1SimpleRestClient.R1SimpleRestClient
        Dim response = R1Client.R1RestRequest(txtServer.Text, txtUsername.Text, txtPassword.Text, Method.POST, "projects", Json.JsonConvert.SerializeObject(newproject))
        If response.GetType Is GetType(ApiResponse(Of Object)) Then
            If response.Success = True Then
                Dim project = JsonConvert.DeserializeObject(Of NewProjectDefinition)(response.Data.ToString)
                MsgBox("Project " & project.Name & " created successfully.")
            Else
                MsgBox(response.error.message)
            End If
        Else
            MsgBox(response)
        End If
    End Sub
    Private Sub tabCreateProject_Paint(sender As Object, e As PaintEventArgs) Handles tabCreateProject.Paint
        cmbProjectProcessingMode.Items.Clear()
        For Each item In GetType(ProcessModeEnum).GetEnumValues
            cmbProjectProcessingMode.Items.Add(item)
        Next
        cmbProjectProcessingMode.SelectedItem = R1SimpleRestClient.Models.Enums.ProcessModeEnum.Security
    End Sub
    Private Sub tabProjects_Enter(sender As Object, e As EventArgs) Handles tabProjects.Enter
        Dim rc As New R1SimpleRestClient.R1SimpleRestClient
        Dim Projects As List(Of ProjectPresenter) = rc.Functions.Project.GetProjectList(txtServer.Text, txtUsername.Text, txtPassword.Text)
        dgvprojects.Rows.Clear()

        For Each project In Projects
            dgvprojects.Rows.Add(New String() {project.Name, project.FtkCaseId, "X", "0"})
        Next
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
        Dim response = R1Client.R1RestRequest(txtServer.Text, txtUsername.Text, txtPassword.Text, Method.GET, "alerts/getTotalResponses/?predicate=null")
        lblTotalResponses.Text = "Total Responses: " & response

        response = R1Client.R1RestRequest(txtServer.Text, txtUsername.Text, txtPassword.Text, Method.GET, "alerts/getTotalAutomatedResponses/?predicate=null")
        lblTotalAutomatedResponses.Text = "Total Automated Responses: " & response

        response = R1Client.R1RestRequest(txtServer.Text, txtUsername.Text, txtPassword.Text, Method.GET, "alerts/getAlertSourceBreakdown/?predicate=null")


        If response.GetType Is GetType(List(Of AlertSourceBreakdownResult)) Then
            If response.count > 0 Then
                lstAlertSourceBreakdown.Items.Clear()
                Dim alertSrcBreakdowns As List(Of AlertSourceBreakdownResult) = response
                For Each alertSrc As AlertSourceBreakdownResult In alertSrcBreakdowns
                    lstAlertSourceBreakdown.Items.Add(alertSrc.Name & " " & alertSrc.Count)
                Next
            Else
                MsgBox(response.error.message)
            End If
        Else
            MsgBox(response)
        End If


    End Sub

    Private Sub dgvprojectjobs_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvprojectjobs.CellClick

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
End Class