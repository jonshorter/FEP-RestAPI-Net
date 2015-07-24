
Imports RestSharp
Imports System.Net
Imports System.Text
Imports System.IO
Imports System.Web
Imports Newtonsoft
Imports Newtonsoft.Json



Public Class Form1

    Dim currproject As Integer = 0


    Private Sub btnRefreshProjectList_Click(sender As Object, e As EventArgs) Handles btnRefreshProjectList.Click
        dgvprojects.Rows.Clear()

        Dim response = R1RestFunctions.R1RestRequest(Method.GET, "projects")
        If response.GetType Is GetType(R1SimpleRestModels.Models.ApiResponse(Of Object)) Then
            If response.Success = True Then
                Dim projects = JsonConvert.DeserializeObject(Of List(Of R1SimpleRestModels.Models.ProjectInformation))(response.Data.ToString)
                For Each item As R1SimpleRestModels.Models.ProjectInformation In projects
                    dgvprojects.Rows.Add(New String() {item.name, item.ftkCaseId, "X", "0"})
                Next
            Else
                MsgBox(response.error.message)
            End If
        Else
            MsgBox(response)
        End If

    End Sub




    Private Sub btnJobCreate_Click(sender As Object, e As EventArgs) Handles btnJobCreate.Click
        '<FIX MY REFERENCE - ADG.WebLab.Web.Controllers.API.Job.JobDefinitionModel
        '<FIX MY REFERENCE - ADG.Wizard.Shared.JobDefinition
        Dim nj As New R1SimpleRestModels.Models.JobDefinitionModel ' ADG.WebLab.Web.Controllers.API.Job.JobDefinitionModel
        Dim njdef As New Object 'ADG.Wizard.Shared.JobDefinition
        nj.JobDef = njdef
        nj.JobDef.Name = txtJobName.Text
        nj.JobDef.JobType = comboJobType.SelectedItem



        nj.ProjectId = txtProjectID.Text
        nj.JobAction = comboJobAction.SelectedItem
        Dim njc As New R1SimpleRestModels.Models.Target
        njc.Addresses = New List(Of String)
        For Each item In lstTargets.Items
            njc.Addresses.Add(item)
        Next

        ' njc.Addresses.Add("10.0.1.5")
        '  njc.SearchString = ""
        nj.ComputerTargets = njc

        'Dim stc As New ADG.WebLab.Web.Controllers.API.Job.Target
        'nj.NetworkShareTargets = stc



        Dim response = R1RestFunctions.R1RestRequest(Method.PUT, "jobs", Json.JsonConvert.SerializeObject(nj))
        If response.GetType Is GetType(R1SimpleRestModels.Models.ApiResponse(Of Object)) Then
            If response.Success = True Then
                Dim job = JsonConvert.DeserializeObject(Of List(Of R1SimpleRestModels.Models.JobInfo))(response.Data.ToString)

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
        Try
            If e.ColumnIndex = 0 Then
                dgvprojectjobs.Rows.Clear()
                currproject = dgvprojects.Rows.Item(e.RowIndex).Cells(1).Value.ToString

                Dim response = R1RestFunctions.R1RestRequest(Method.GET, "jobs/" & dgvprojects.Rows.Item(e.RowIndex).Cells(1).Value.ToString)
                If response.GetType Is GetType(R1SimpleRestModels.Models.ApiResponse(Of Object)) Then
                    If response.Success = True Then
                        Dim jobs = JsonConvert.DeserializeObject(Of List(Of R1SimpleRestModels.Models.JobInfo))(response.Data.ToString)
                        For Each job As R1SimpleRestModels.Models.JobInfo In jobs
                            dgvprojectjobs.Rows.Add(New String() {job.Name, job.JobType.ToString, job.Status, job.JobID.ToString})
                        Next
                    Else
                        MsgBox(response.error.message)
                    End If
                Else
                    MsgBox(response)
                End If

                response = R1RestFunctions.R1RestRequest(Method.GET, "projects/" & dgvprojects.Rows.Item(e.RowIndex).Cells(1).Value.ToString)
                If response.GetType Is GetType(R1SimpleRestModels.Models.ApiResponse(Of Object)) Then
                    If response.Success = True Then
                        Try
                            Dim prjinfo = JsonConvert.DeserializeObject(Of R1SimpleRestModels.Models.ProjectInformation)(response.Data.ToString)
                            pgProject.SelectedObject = prjinfo
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try

                    Else
                        MsgBox(response.error.message)
                    End If
                Else
                    MsgBox(response)
                End If

                dgvProjectReports.Rows.Clear()
                response = R1RestFunctions.R1RestRequest(Method.GET, "projects/" & dgvprojects.Rows.Item(e.RowIndex).Cells(1).Value.ToString & "/reports")
                If response.GetType Is GetType(R1SimpleRestModels.Models.ApiResponse(Of Object)) Then
                    If response.Success = True Then

                        Dim reports = JsonConvert.DeserializeObject(Of List(Of R1SimpleRestModels.Models.BasicReport))(response.Data.ToString)
                        If reports.Count > 0 Then
                            For Each report As R1SimpleRestModels.Models.BasicReport In reports
                                dgvProjectReports.Rows.Add(New String() {report.ReportInfo.Name, report.ReportInfo.ReportType.ToString, report.ReportInfo.Status.ToString, report.ReportInfo.FilePath, report.ReportInfo.ReportId})
                            Next
                        End If
                    Else
                        MsgBox(response.error.message)
                    End If
                Else
                    MsgBox(response)
                End If
            ElseIf e.ColumnIndex = 2 Then
                Dim x = MsgBox("Are you sure you want to delete the project?", MsgBoxStyle.YesNo, "Delete Project?")
                If x = 6 Then
                    Dim response = R1RestFunctions.R1RestRequest(Method.DELETE, "projects/" & dgvprojects.Rows.Item(e.RowIndex).Cells(1).Value.ToString)
                    If response.GetType Is GetType(R1SimpleRestModels.Models.ApiResponse(Of Object)) Then
                        If response.Success = True Then
                            MsgBox("Project # " & dgvprojects.Rows.Item(e.RowIndex).Cells(1).Value.ToString & " deleted.")
                        Else
                            MsgBox(response.error.message)
                        End If
                    Else
                        MsgBox(response)
                    End If
                End If

            ElseIf e.ColumnIndex = 3 Then
                txtProjectID.Text = dgvprojects.Rows.Item(e.RowIndex).Cells(1).Value.ToString
                tabBottomMenu.SelectedTab = tabCreateJob


            End If
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

        Dim response = R1RestFunctions.R1RestRequest(cmbRESTOPTION.SelectedItem, txtapicallpath.Text, txtapicallpostjson.Text)


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
        For Each item In GetType(R1SimpleRestModels.Models.JobTypes).GetEnumValues
            comboJobType.Items.Add(item)
        Next
        comboJobType.SelectedItem = R1SimpleRestModels.Models.JobTypes.SoftwareInventory

        comboJobAction.Items.Clear()
        For Each item In GetType(R1SimpleRestModels.Models.JobAction).GetEnumValues
            comboJobAction.Items.Add(item)
        Next
        comboJobAction.SelectedItem = R1SimpleRestModels.Models.JobAction.Create
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

        '<FIX MY REFERENCE - ADG.RIA.DataServices.Web.NewProjectDefinition
        Dim newproject As New Object ' ADG.RIA.DataServices.Web.NewProjectDefinition
        newproject.Name = txtProjectName.Text
        newproject.FTKCaseFolderPath = txtProjectCaseFolder.Text
        newproject.ResponsiveFilePath = txtProjectJobDataFolder.Text
        newproject.ProcessingMode = cmbProjectProcessingMode.SelectedItem
        newproject.Comments = txtProjectDescription.Text

        Dim response = R1RestFunctions.R1RestRequest(Method.POST, "projects", Json.JsonConvert.SerializeObject(newproject))
        If response.GetType Is GetType(R1SimpleRestModels.Models.ApiResponse(Of Object)) Then
            If response.Success = True Then
                ' 'ADG.RIA.DataServices.Web.NewProjectDefinition
                Dim project = JsonConvert.DeserializeObject(Of Object)(response.Data.ToString)

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
        For Each item In GetType(R1SimpleRestModels.Models.ProcessModeEnum).GetEnumValues
            cmbProjectProcessingMode.Items.Add(item)
        Next
        cmbProjectProcessingMode.SelectedItem = R1SimpleRestModels.Models.ProcessModeEnum.Security



    End Sub


    Private Sub tabProjects_Enter(sender As Object, e As EventArgs) Handles tabProjects.Enter
        dgvprojects.Rows.Clear()

        Dim response = R1RestFunctions.R1RestRequest(Method.GET, "projects")
        If response.GetType Is GetType(R1SimpleRestModels.Models.ApiResponse(Of Object)) Then
            If response.Success = True Then
                Dim projects = JsonConvert.DeserializeObject(Of List(Of R1SimpleRestModels.Models.ProjectInformation))(response.Data.ToString)
                For Each item As R1SimpleRestModels.Models.ProjectInformation In projects
                    dgvprojects.Rows.Add(New String() {item.name, item.ftkCaseId, "X", "0"})
                Next
            Else
                MsgBox(response.error.message)
            End If
        Else
            MsgBox(response)
        End If
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
        Dim response = R1RestFunctions.R1RestRequest(Method.GET, "alerts/getTotalResponses/?predicate=null")
        lblTotalResponses.Text = "Total Responses: " & response

        response = R1RestFunctions.R1RestRequest(Method.GET, "alerts/getTotalAutomatedResponses/?predicate=null")
        lblTotalAutomatedResponses.Text = "Total Automated Responses: " & response

        response = R1RestFunctions.R1RestRequest(Method.GET, "alerts/getAlertSourceBreakdown/?predicate=null")


        If response.GetType Is GetType(List(Of R1SimpleRestModels.Models.AlertSourceBreakdownResult)) Then
            If response.count > 0 Then
                lstAlertSourceBreakdown.Items.Clear()
                Dim alertSrcBreakdowns As List(Of R1SimpleRestModels.Models.AlertSourceBreakdownResult) = response
                For Each alertSrc As R1SimpleRestModels.Models.AlertSourceBreakdownResult In alertSrcBreakdowns
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

End Class
