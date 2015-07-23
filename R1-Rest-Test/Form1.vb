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



    Private Sub btnRefreshProjectList_Click(sender As Object, e As EventArgs) Handles btnRefreshProjectList.Click
        dgvprojects.Rows.Clear()

        Dim response = R1RestFunctions.R1RestRequest(Method.GET, "projects")
        If response.GetType Is GetType(ADG.WebLab.Web.Controllers.API.ApiResponse(Of Object)) Then
            If response.Success = True Then
                Dim projects = JsonConvert.DeserializeObject(Of List(Of R1SimpleRestClasses.ProjectInformation))(response.Data.ToString)
                For Each item As R1SimpleRestClasses.ProjectInformation In projects
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

        Dim nj As New ADG.WebLab.Web.Controllers.API.Job.JobDefinitionModel
        Dim njdef As New ADG.Wizard.Shared.JobDefinition
        nj.JobDef = njdef
        nj.JobDef.Name = txtJobName.Text
        nj.JobDef.JobType = comboJobType.SelectedItem



        nj.ProjectId = txtProjectID.Text
        nj.JobAction = comboJobAction.SelectedItem
        Dim njc As New ADG.WebLab.Web.Controllers.API.Job.Target
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



    Private Sub jobload(callback As Action(Of RestSharp.RestResponse, RestSharp.RestRequestAsyncHandle))

    End Sub

    Private Sub dgvprojects_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvprojects.CellContentClick
        Try
            If e.ColumnIndex = 2 Then
                Dim x = MsgBox("Are you sure you want to delete the project?", MsgBoxStyle.YesNo, "Delete Project?")
                If x = 6 Then
                    Dim response = R1RestFunctions.R1RestRequest(Method.DELETE, "projects/" & dgvprojects.Rows.Item(e.RowIndex).Cells(1).Value.ToString)
                    If response.GetType Is GetType(ADG.WebLab.Web.Controllers.API.ApiResponse(Of Object)) Then
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

    Private Sub dgvprojects_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvprojects.RowEnter
        dgvprojectjobs.Rows.Clear()


        Dim response = R1RestFunctions.R1RestRequest(Method.GET, "jobs/" & dgvprojects.Rows.Item(e.RowIndex).Cells(1).Value.ToString)
        If response.GetType Is GetType(ADG.WebLab.Web.Controllers.API.ApiResponse(Of Object)) Then
            If response.Success = True Then
                Dim jobs = JsonConvert.DeserializeObject(Of List(Of ADG.WebLab.Web.Controllers.API.Job.JobInfo))(response.Data.ToString)
                For Each job As ADG.WebLab.Web.Controllers.API.Job.JobInfo In jobs
                    dgvprojectjobs.Rows.Add(New String() {job.Name, job.Status})
                Next
            Else
                MsgBox(response.error.message)
            End If
        Else
            MsgBox(response)
        End If

        dgvProjectReports.Rows.Clear()
        response = R1RestFunctions.R1RestRequest(Method.GET, "projects/" & dgvprojects.Rows.Item(e.RowIndex).Cells(1).Value.ToString & "/reports")
        If response.GetType Is GetType(ADG.WebLab.Web.Controllers.API.ApiResponse(Of Object)) Then
            If response.Success = True Then

                Dim reports = JsonConvert.DeserializeObject(Of List(Of ADG.WebLab.Web.Controllers.API.Reports.BasicReport))(response.Data.ToString)
                If reports.Count > 0 Then
                    For Each report As ADG.WebLab.Web.Controllers.API.Reports.BasicReport In reports
                        dgvProjectReports.Rows.Add(New String() {report.ReportInfo.Name, report.ReportInfo.ReportType.ToString, report.ReportInfo.Status.ToString, report.ReportInfo.FilePath, report.ReportInfo.ReportId})
                    Next
                End If
            Else
                MsgBox(response.error.message)
            End If
        Else
            MsgBox(response)
        End If


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

        If response.GetType Is GetType(ADG.WebLab.Web.Controllers.API.ApiResponse(Of Object)) Then
            If response.Success = True Then
                MsgBox(response.Data.ToString)
            Else
                MsgBox(response.error.message)
            End If

        Else
            MsgBox(response)
        End If

       

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
        For Each item In GetType(ADG.Wizard.Shared.JobTypes).GetEnumValues
            comboJobType.Items.Add(item)
        Next
        comboJobType.SelectedItem = JobTypes.SoftwareInventory

        comboJobAction.Items.Clear()
        For Each item In GetType(JobAction).GetEnumValues
            comboJobAction.Items.Add(item)
        Next
        comboJobAction.SelectedItem = JobAction.Create
    End Sub

    Private Sub dgvProjectReports_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProjectReports.CellContentClick
        Try
            If e.ColumnIndex = 3 And dgvProjectReports.Rows.Item(e.RowIndex).Cells(2).Value.ToString = "Completed" Then
                System.Diagnostics.Process.Start(dgvProjectReports.Rows.Item(e.RowIndex).Cells(3).Value.ToString)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

   
    Private Sub btnCreateProject_Click(sender As Object, e As EventArgs) Handles btnCreateProject.Click


        Dim newproject As New ADG.RIA.DataServices.Web.NewProjectDefinition
        newproject.Name = txtProjectName.Text
        newproject.FTKCaseFolderPath = txtProjectCaseFolder.Text
        newproject.ResponsiveFilePath = txtProjectJobDataFolder.Text
        newproject.ProcessingMode = cmbProjectProcessingMode.SelectedItem

        Dim response = R1RestFunctions.R1RestRequest(Method.POST, "projects", Json.JsonConvert.SerializeObject(newproject))
        If response.GetType Is GetType(ADG.WebLab.Web.Controllers.API.ApiResponse(Of Object)) Then
            If response.Success = True Then
                Dim project = JsonConvert.DeserializeObject(Of ADG.RIA.DataServices.Web.NewProjectDefinition)(response.Data.ToString)

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
        For Each item In GetType(Web.ProcessModeEnum).GetEnumValues
            cmbProjectProcessingMode.Items.Add(item)
        Next
        cmbProjectProcessingMode.SelectedItem = Web.ProcessModeEnum.Security



    End Sub


    Private Sub tabProjects_Enter(sender As Object, e As EventArgs) Handles tabProjects.Enter
        dgvprojects.Rows.Clear()

        Dim response = R1RestFunctions.R1RestRequest(Method.GET, "projects")
        If response.GetType Is GetType(ADG.WebLab.Web.Controllers.API.ApiResponse(Of Object)) Then
            If response.Success = True Then
                Dim projects = JsonConvert.DeserializeObject(Of List(Of R1SimpleRestClasses.ProjectInformation))(response.Data.ToString)
                For Each item As R1SimpleRestClasses.ProjectInformation In projects
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


        If response.GetType Is GetType(List(Of R1SimpleRestClasses.AlertSourceBreakdownResult)) Then
            If response.count > 0 Then
                lstAlertSourceBreakdown.Items.Clear()
                Dim alertSrcBreakdowns As List(Of R1SimpleRestClasses.AlertSourceBreakdownResult) = response
                For Each alertSrc As R1SimpleRestClasses.AlertSourceBreakdownResult In alertSrcBreakdowns
                    lstAlertSourceBreakdown.Items.Add(alertSrc.Name & " " & alertSrc.Count)
                Next
            Else
                MsgBox(response.error.message)
            End If
        Else
            MsgBox(response)
        End If


    End Sub
End Class
