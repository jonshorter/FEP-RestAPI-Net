<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnRefreshProjectList = New System.Windows.Forms.Button()
        Me.btnJobCreate = New System.Windows.Forms.Button()
        Me.dgvprojects = New System.Windows.Forms.DataGridView()
        Me.projectname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ftkcaseid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDelete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colCreateJob = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.dgvprojectjobs = New System.Windows.Forms.DataGridView()
        Me.jobname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tabTopMenu = New System.Windows.Forms.TabControl()
        Me.tabSettings = New System.Windows.Forms.TabPage()
        Me.lblStatusSettings = New System.Windows.Forms.Label()
        Me.btnSaveSettings = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtServer = New System.Windows.Forms.TextBox()
        Me.tabTesting = New System.Windows.Forms.TabPage()
        Me.tabBottomMenu = New System.Windows.Forms.TabControl()
        Me.tabCreateProject = New System.Windows.Forms.TabPage()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cmbProjectProcessingMode = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtProjectJobDataFolder = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtProjectCaseFolder = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnCreateProject = New System.Windows.Forms.Button()
        Me.txtProjectName = New System.Windows.Forms.TextBox()
        Me.tabProjects = New System.Windows.Forms.TabPage()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dgvProjectReports = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLink = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.colrptid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tabCreateJob = New System.Windows.Forms.TabPage()
        Me.comboJobAction = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lstTargets = New System.Windows.Forms.CheckedListBox()
        Me.btnRemoveSelectedTargets = New System.Windows.Forms.Button()
        Me.btnAddNewTarget = New System.Windows.Forms.Button()
        Me.txtNewTarget = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtProjectID = New System.Windows.Forms.TextBox()
        Me.comboJobType = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtJobName = New System.Windows.Forms.TextBox()
        Me.tabAlerts = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnAPICallCustom = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtapicallpath = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbRESTOPTION = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtapicallpostjson = New System.Windows.Forms.TextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblTotalResponses = New System.Windows.Forms.Label()
        Me.lblTotalAutomatedResponses = New System.Windows.Forms.Label()
        Me.lstAlertSourceBreakdown = New System.Windows.Forms.ListBox()
        Me.Label18 = New System.Windows.Forms.Label()
        CType(Me.dgvprojects, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvprojectjobs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabTopMenu.SuspendLayout()
        Me.tabSettings.SuspendLayout()
        Me.tabTesting.SuspendLayout()
        Me.tabBottomMenu.SuspendLayout()
        Me.tabCreateProject.SuspendLayout()
        Me.tabProjects.SuspendLayout()
        CType(Me.dgvProjectReports, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabCreateJob.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.tabAlerts.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnRefreshProjectList
        '
        Me.btnRefreshProjectList.Location = New System.Drawing.Point(6, 6)
        Me.btnRefreshProjectList.Name = "btnRefreshProjectList"
        Me.btnRefreshProjectList.Size = New System.Drawing.Size(139, 24)
        Me.btnRefreshProjectList.TabIndex = 1
        Me.btnRefreshProjectList.Text = "Refresh Project List"
        Me.btnRefreshProjectList.UseVisualStyleBackColor = True
        '
        'btnJobCreate
        '
        Me.btnJobCreate.Location = New System.Drawing.Point(250, 327)
        Me.btnJobCreate.Name = "btnJobCreate"
        Me.btnJobCreate.Size = New System.Drawing.Size(96, 28)
        Me.btnJobCreate.TabIndex = 4
        Me.btnJobCreate.Text = "Create Job"
        Me.btnJobCreate.UseVisualStyleBackColor = True
        '
        'dgvprojects
        '
        Me.dgvprojects.AllowUserToAddRows = False
        Me.dgvprojects.AllowUserToDeleteRows = False
        Me.dgvprojects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvprojects.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.projectname, Me.ftkcaseid, Me.colDelete, Me.colCreateJob})
        Me.dgvprojects.Location = New System.Drawing.Point(9, 50)
        Me.dgvprojects.Name = "dgvprojects"
        Me.dgvprojects.ReadOnly = True
        Me.dgvprojects.RowHeadersVisible = False
        Me.dgvprojects.Size = New System.Drawing.Size(324, 151)
        Me.dgvprojects.TabIndex = 8
        '
        'projectname
        '
        Me.projectname.HeaderText = "Project"
        Me.projectname.Name = "projectname"
        Me.projectname.ReadOnly = True
        '
        'ftkcaseid
        '
        Me.ftkcaseid.FillWeight = 20.0!
        Me.ftkcaseid.HeaderText = "FTKCaseID"
        Me.ftkcaseid.Name = "ftkcaseid"
        Me.ftkcaseid.ReadOnly = True
        Me.ftkcaseid.Width = 65
        '
        'colDelete
        '
        Me.colDelete.FillWeight = 5.0!
        Me.colDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.colDelete.HeaderText = "Delete"
        Me.colDelete.Name = "colDelete"
        Me.colDelete.ReadOnly = True
        Me.colDelete.ToolTipText = "Delete Project"
        Me.colDelete.Width = 45
        '
        'colCreateJob
        '
        Me.colCreateJob.FillWeight = 20.0!
        Me.colCreateJob.HeaderText = "Create Job"
        Me.colCreateJob.Name = "colCreateJob"
        Me.colCreateJob.ReadOnly = True
        Me.colCreateJob.Width = 75
        '
        'dgvprojectjobs
        '
        Me.dgvprojectjobs.AllowUserToAddRows = False
        Me.dgvprojectjobs.AllowUserToDeleteRows = False
        Me.dgvprojectjobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvprojectjobs.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.jobname, Me.status})
        Me.dgvprojectjobs.Location = New System.Drawing.Point(9, 219)
        Me.dgvprojectjobs.Name = "dgvprojectjobs"
        Me.dgvprojectjobs.ReadOnly = True
        Me.dgvprojectjobs.RowHeadersVisible = False
        Me.dgvprojectjobs.Size = New System.Drawing.Size(324, 151)
        Me.dgvprojectjobs.TabIndex = 9
        '
        'jobname
        '
        Me.jobname.HeaderText = "Job Name"
        Me.jobname.Name = "jobname"
        Me.jobname.ReadOnly = True
        '
        'status
        '
        Me.status.HeaderText = "Job Status"
        Me.status.Name = "status"
        Me.status.ReadOnly = True
        '
        'tabTopMenu
        '
        Me.tabTopMenu.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tabTopMenu.Controls.Add(Me.tabSettings)
        Me.tabTopMenu.Controls.Add(Me.tabTesting)
        Me.tabTopMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabTopMenu.Location = New System.Drawing.Point(0, 0)
        Me.tabTopMenu.Name = "tabTopMenu"
        Me.tabTopMenu.SelectedIndex = 0
        Me.tabTopMenu.Size = New System.Drawing.Size(947, 729)
        Me.tabTopMenu.TabIndex = 14
        '
        'tabSettings
        '
        Me.tabSettings.Controls.Add(Me.lblStatusSettings)
        Me.tabSettings.Controls.Add(Me.btnSaveSettings)
        Me.tabSettings.Controls.Add(Me.Label3)
        Me.tabSettings.Controls.Add(Me.txtPassword)
        Me.tabSettings.Controls.Add(Me.Label2)
        Me.tabSettings.Controls.Add(Me.txtUsername)
        Me.tabSettings.Controls.Add(Me.Label1)
        Me.tabSettings.Controls.Add(Me.txtServer)
        Me.tabSettings.Location = New System.Drawing.Point(4, 25)
        Me.tabSettings.Name = "tabSettings"
        Me.tabSettings.Padding = New System.Windows.Forms.Padding(3)
        Me.tabSettings.Size = New System.Drawing.Size(939, 700)
        Me.tabSettings.TabIndex = 0
        Me.tabSettings.Text = "Settings"
        Me.tabSettings.UseVisualStyleBackColor = True
        '
        'lblStatusSettings
        '
        Me.lblStatusSettings.AutoSize = True
        Me.lblStatusSettings.Location = New System.Drawing.Point(31, 157)
        Me.lblStatusSettings.Name = "lblStatusSettings"
        Me.lblStatusSettings.Size = New System.Drawing.Size(39, 13)
        Me.lblStatusSettings.TabIndex = 7
        Me.lblStatusSettings.Text = "Label4"
        '
        'btnSaveSettings
        '
        Me.btnSaveSettings.Location = New System.Drawing.Point(214, 121)
        Me.btnSaveSettings.Name = "btnSaveSettings"
        Me.btnSaveSettings.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveSettings.TabIndex = 6
        Me.btnSaveSettings.Text = "Save"
        Me.btnSaveSettings.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Password:"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(95, 71)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(194, 20)
        Me.txtPassword.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Username:"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(95, 45)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(194, 20)
        Me.txtUsername.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Server:"
        '
        'txtServer
        '
        Me.txtServer.Location = New System.Drawing.Point(95, 19)
        Me.txtServer.Name = "txtServer"
        Me.txtServer.Size = New System.Drawing.Size(194, 20)
        Me.txtServer.TabIndex = 0
        '
        'tabTesting
        '
        Me.tabTesting.Controls.Add(Me.tabBottomMenu)
        Me.tabTesting.Controls.Add(Me.GroupBox1)
        Me.tabTesting.Controls.Add(Me.StatusStrip1)
        Me.tabTesting.Location = New System.Drawing.Point(4, 25)
        Me.tabTesting.Name = "tabTesting"
        Me.tabTesting.Padding = New System.Windows.Forms.Padding(3)
        Me.tabTesting.Size = New System.Drawing.Size(939, 700)
        Me.tabTesting.TabIndex = 1
        Me.tabTesting.Text = "APITest"
        Me.tabTesting.UseVisualStyleBackColor = True
        '
        'tabBottomMenu
        '
        Me.tabBottomMenu.Controls.Add(Me.tabCreateProject)
        Me.tabBottomMenu.Controls.Add(Me.tabProjects)
        Me.tabBottomMenu.Controls.Add(Me.tabCreateJob)
        Me.tabBottomMenu.Controls.Add(Me.tabAlerts)
        Me.tabBottomMenu.Location = New System.Drawing.Point(8, 112)
        Me.tabBottomMenu.Name = "tabBottomMenu"
        Me.tabBottomMenu.SelectedIndex = 0
        Me.tabBottomMenu.Size = New System.Drawing.Size(873, 519)
        Me.tabBottomMenu.TabIndex = 24
        '
        'tabCreateProject
        '
        Me.tabCreateProject.Controls.Add(Me.Label15)
        Me.tabCreateProject.Controls.Add(Me.cmbProjectProcessingMode)
        Me.tabCreateProject.Controls.Add(Me.Label14)
        Me.tabCreateProject.Controls.Add(Me.txtProjectJobDataFolder)
        Me.tabCreateProject.Controls.Add(Me.Label13)
        Me.tabCreateProject.Controls.Add(Me.txtProjectCaseFolder)
        Me.tabCreateProject.Controls.Add(Me.Label12)
        Me.tabCreateProject.Controls.Add(Me.btnCreateProject)
        Me.tabCreateProject.Controls.Add(Me.txtProjectName)
        Me.tabCreateProject.Location = New System.Drawing.Point(4, 22)
        Me.tabCreateProject.Name = "tabCreateProject"
        Me.tabCreateProject.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCreateProject.Size = New System.Drawing.Size(865, 493)
        Me.tabCreateProject.TabIndex = 2
        Me.tabCreateProject.Text = "Create Project"
        Me.tabCreateProject.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 87)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(92, 13)
        Me.Label15.TabIndex = 15
        Me.Label15.Text = "Processing Mode:"
        '
        'cmbProjectProcessingMode
        '
        Me.cmbProjectProcessingMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProjectProcessingMode.FormattingEnabled = True
        Me.cmbProjectProcessingMode.Location = New System.Drawing.Point(127, 84)
        Me.cmbProjectProcessingMode.Name = "cmbProjectProcessingMode"
        Me.cmbProjectProcessingMode.Size = New System.Drawing.Size(228, 21)
        Me.cmbProjectProcessingMode.TabIndex = 14
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 61)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(117, 13)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Job Data Folder (UNC):"
        '
        'txtProjectJobDataFolder
        '
        Me.txtProjectJobDataFolder.Location = New System.Drawing.Point(127, 58)
        Me.txtProjectJobDataFolder.Name = "txtProjectJobDataFolder"
        Me.txtProjectJobDataFolder.Size = New System.Drawing.Size(228, 20)
        Me.txtProjectJobDataFolder.TabIndex = 12
        Me.txtProjectJobDataFolder.Text = "\\10.0.1.52\Share\JobData"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 35)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(107, 13)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "Project Folder (UNC):"
        '
        'txtProjectCaseFolder
        '
        Me.txtProjectCaseFolder.Location = New System.Drawing.Point(127, 32)
        Me.txtProjectCaseFolder.Name = "txtProjectCaseFolder"
        Me.txtProjectCaseFolder.Size = New System.Drawing.Size(228, 20)
        Me.txtProjectCaseFolder.TabIndex = 10
        Me.txtProjectCaseFolder.Text = "\\10.0.1.52\Share\Projects"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 9)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(74, 13)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "Project Name:"
        '
        'btnCreateProject
        '
        Me.btnCreateProject.Location = New System.Drawing.Point(216, 127)
        Me.btnCreateProject.Name = "btnCreateProject"
        Me.btnCreateProject.Size = New System.Drawing.Size(139, 24)
        Me.btnCreateProject.TabIndex = 7
        Me.btnCreateProject.Text = "Create Project"
        Me.btnCreateProject.UseVisualStyleBackColor = True
        '
        'txtProjectName
        '
        Me.txtProjectName.Location = New System.Drawing.Point(127, 6)
        Me.txtProjectName.Name = "txtProjectName"
        Me.txtProjectName.Size = New System.Drawing.Size(228, 20)
        Me.txtProjectName.TabIndex = 8
        Me.txtProjectName.Text = "APIProject"
        '
        'tabProjects
        '
        Me.tabProjects.Controls.Add(Me.Label11)
        Me.tabProjects.Controls.Add(Me.dgvProjectReports)
        Me.tabProjects.Controls.Add(Me.Label10)
        Me.tabProjects.Controls.Add(Me.Label9)
        Me.tabProjects.Controls.Add(Me.btnRefreshProjectList)
        Me.tabProjects.Controls.Add(Me.dgvprojects)
        Me.tabProjects.Controls.Add(Me.dgvprojectjobs)
        Me.tabProjects.Location = New System.Drawing.Point(4, 22)
        Me.tabProjects.Name = "tabProjects"
        Me.tabProjects.Padding = New System.Windows.Forms.Padding(3)
        Me.tabProjects.Size = New System.Drawing.Size(865, 493)
        Me.tabProjects.TabIndex = 0
        Me.tabProjects.Text = "Projects"
        Me.tabProjects.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(336, 34)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 13)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Reports"
        '
        'dgvProjectReports
        '
        Me.dgvProjectReports.AllowUserToAddRows = False
        Me.dgvProjectReports.AllowUserToDeleteRows = False
        Me.dgvProjectReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProjectReports.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.colStatus, Me.colLink, Me.colrptid})
        Me.dgvProjectReports.Location = New System.Drawing.Point(339, 50)
        Me.dgvProjectReports.Name = "dgvProjectReports"
        Me.dgvProjectReports.ReadOnly = True
        Me.dgvProjectReports.RowHeadersVisible = False
        Me.dgvProjectReports.Size = New System.Drawing.Size(459, 151)
        Me.dgvProjectReports.TabIndex = 12
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Type"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'colStatus
        '
        Me.colStatus.HeaderText = "Status"
        Me.colStatus.Name = "colStatus"
        Me.colStatus.ReadOnly = True
        '
        'colLink
        '
        Me.colLink.HeaderText = "Link"
        Me.colLink.Name = "colLink"
        Me.colLink.ReadOnly = True
        '
        'colrptid
        '
        Me.colrptid.HeaderText = "ReportID"
        Me.colrptid.Name = "colrptid"
        Me.colrptid.ReadOnly = True
        Me.colrptid.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 203)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 13)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Project Jobs"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 34)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Projects"
        '
        'tabCreateJob
        '
        Me.tabCreateJob.Controls.Add(Me.comboJobAction)
        Me.tabCreateJob.Controls.Add(Me.Label17)
        Me.tabCreateJob.Controls.Add(Me.GroupBox2)
        Me.tabCreateJob.Controls.Add(Me.Label16)
        Me.tabCreateJob.Controls.Add(Me.txtProjectID)
        Me.tabCreateJob.Controls.Add(Me.comboJobType)
        Me.tabCreateJob.Controls.Add(Me.Label8)
        Me.tabCreateJob.Controls.Add(Me.Label7)
        Me.tabCreateJob.Controls.Add(Me.txtJobName)
        Me.tabCreateJob.Controls.Add(Me.btnJobCreate)
        Me.tabCreateJob.Location = New System.Drawing.Point(4, 22)
        Me.tabCreateJob.Name = "tabCreateJob"
        Me.tabCreateJob.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCreateJob.Size = New System.Drawing.Size(865, 493)
        Me.tabCreateJob.TabIndex = 1
        Me.tabCreateJob.Text = "Create Job"
        Me.tabCreateJob.UseVisualStyleBackColor = True
        '
        'comboJobAction
        '
        Me.comboJobAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboJobAction.FormattingEnabled = True
        Me.comboJobAction.Location = New System.Drawing.Point(106, 102)
        Me.comboJobAction.Name = "comboJobAction"
        Me.comboJobAction.Size = New System.Drawing.Size(158, 21)
        Me.comboJobAction.TabIndex = 13
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(24, 105)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(60, 13)
        Me.Label17.TabIndex = 12
        Me.Label17.Text = "Job Action:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lstTargets)
        Me.GroupBox2.Controls.Add(Me.btnRemoveSelectedTargets)
        Me.GroupBox2.Controls.Add(Me.btnAddNewTarget)
        Me.GroupBox2.Controls.Add(Me.txtNewTarget)
        Me.GroupBox2.Location = New System.Drawing.Point(26, 155)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(320, 154)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Targets"
        '
        'lstTargets
        '
        Me.lstTargets.FormattingEnabled = True
        Me.lstTargets.Location = New System.Drawing.Point(6, 53)
        Me.lstTargets.Name = "lstTargets"
        Me.lstTargets.Size = New System.Drawing.Size(120, 94)
        Me.lstTargets.TabIndex = 4
        '
        'btnRemoveSelectedTargets
        '
        Me.btnRemoveSelectedTargets.Location = New System.Drawing.Point(142, 125)
        Me.btnRemoveSelectedTargets.Name = "btnRemoveSelectedTargets"
        Me.btnRemoveSelectedTargets.Size = New System.Drawing.Size(131, 23)
        Me.btnRemoveSelectedTargets.TabIndex = 3
        Me.btnRemoveSelectedTargets.Text = "Remove Checked"
        Me.btnRemoveSelectedTargets.UseVisualStyleBackColor = True
        '
        'btnAddNewTarget
        '
        Me.btnAddNewTarget.Location = New System.Drawing.Point(142, 25)
        Me.btnAddNewTarget.Name = "btnAddNewTarget"
        Me.btnAddNewTarget.Size = New System.Drawing.Size(75, 23)
        Me.btnAddNewTarget.TabIndex = 2
        Me.btnAddNewTarget.Text = "Add"
        Me.btnAddNewTarget.UseVisualStyleBackColor = True
        '
        'txtNewTarget
        '
        Me.txtNewTarget.Location = New System.Drawing.Point(6, 27)
        Me.txtNewTarget.Name = "txtNewTarget"
        Me.txtNewTarget.Size = New System.Drawing.Size(120, 20)
        Me.txtNewTarget.TabIndex = 1
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(24, 9)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(57, 13)
        Me.Label16.TabIndex = 10
        Me.Label16.Text = "Project ID:"
        '
        'txtProjectID
        '
        Me.txtProjectID.Location = New System.Drawing.Point(106, 6)
        Me.txtProjectID.Name = "txtProjectID"
        Me.txtProjectID.Size = New System.Drawing.Size(158, 20)
        Me.txtProjectID.TabIndex = 9
        '
        'comboJobType
        '
        Me.comboJobType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboJobType.FormattingEnabled = True
        Me.comboJobType.Location = New System.Drawing.Point(106, 70)
        Me.comboJobType.Name = "comboJobType"
        Me.comboJobType.Size = New System.Drawing.Size(158, 21)
        Me.comboJobType.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(24, 73)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Job Type:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(24, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Job Name:"
        '
        'txtJobName
        '
        Me.txtJobName.Location = New System.Drawing.Point(106, 39)
        Me.txtJobName.Name = "txtJobName"
        Me.txtJobName.Size = New System.Drawing.Size(158, 20)
        Me.txtJobName.TabIndex = 5
        '
        'tabAlerts
        '
        Me.tabAlerts.Controls.Add(Me.Label18)
        Me.tabAlerts.Controls.Add(Me.lstAlertSourceBreakdown)
        Me.tabAlerts.Controls.Add(Me.lblTotalAutomatedResponses)
        Me.tabAlerts.Controls.Add(Me.lblTotalResponses)
        Me.tabAlerts.Location = New System.Drawing.Point(4, 22)
        Me.tabAlerts.Name = "tabAlerts"
        Me.tabAlerts.Padding = New System.Windows.Forms.Padding(3)
        Me.tabAlerts.Size = New System.Drawing.Size(865, 493)
        Me.tabAlerts.TabIndex = 3
        Me.tabAlerts.Text = "Alerts"
        Me.tabAlerts.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnAPICallCustom)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtapicallpath)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cmbRESTOPTION)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtapicallpostjson)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(697, 100)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Custom API Call"
        '
        'btnAPICallCustom
        '
        Me.btnAPICallCustom.Location = New System.Drawing.Point(431, 53)
        Me.btnAPICallCustom.Name = "btnAPICallCustom"
        Me.btnAPICallCustom.Size = New System.Drawing.Size(75, 23)
        Me.btnAPICallCustom.TabIndex = 16
        Me.btnAPICallCustom.Text = "Run"
        Me.btnAPICallCustom.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(285, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "post json"
        '
        'txtapicallpath
        '
        Me.txtapicallpath.Location = New System.Drawing.Point(145, 52)
        Me.txtapicallpath.Name = "txtapicallpath"
        Me.txtapicallpath.Size = New System.Drawing.Size(137, 20)
        Me.txtapicallpath.TabIndex = 17
        Me.txtapicallpath.Text = "projects"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(142, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "path. ie projects"
        '
        'cmbRESTOPTION
        '
        Me.cmbRESTOPTION.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRESTOPTION.FormattingEnabled = True
        Me.cmbRESTOPTION.Location = New System.Drawing.Point(18, 51)
        Me.cmbRESTOPTION.Name = "cmbRESTOPTION"
        Me.cmbRESTOPTION.Size = New System.Drawing.Size(121, 21)
        Me.cmbRESTOPTION.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Method:"
        '
        'txtapicallpostjson
        '
        Me.txtapicallpostjson.Location = New System.Drawing.Point(288, 53)
        Me.txtapicallpostjson.Name = "txtapicallpostjson"
        Me.txtapicallpostjson.Size = New System.Drawing.Size(137, 20)
        Me.txtapicallpostjson.TabIndex = 19
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.StatusStrip1.Location = New System.Drawing.Point(3, 675)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(933, 22)
        Me.StatusStrip1.TabIndex = 15
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblTotalResponses
        '
        Me.lblTotalResponses.AutoSize = True
        Me.lblTotalResponses.Location = New System.Drawing.Point(12, 14)
        Me.lblTotalResponses.Name = "lblTotalResponses"
        Me.lblTotalResponses.Size = New System.Drawing.Size(87, 13)
        Me.lblTotalResponses.TabIndex = 0
        Me.lblTotalResponses.Text = "Total Responses"
        '
        'lblTotalAutomatedResponses
        '
        Me.lblTotalAutomatedResponses.AutoSize = True
        Me.lblTotalAutomatedResponses.Location = New System.Drawing.Point(12, 39)
        Me.lblTotalAutomatedResponses.Name = "lblTotalAutomatedResponses"
        Me.lblTotalAutomatedResponses.Size = New System.Drawing.Size(141, 13)
        Me.lblTotalAutomatedResponses.TabIndex = 1
        Me.lblTotalAutomatedResponses.Text = "Total Automated Responses"
        '
        'lstAlertSourceBreakdown
        '
        Me.lstAlertSourceBreakdown.FormattingEnabled = True
        Me.lstAlertSourceBreakdown.Location = New System.Drawing.Point(15, 76)
        Me.lstAlertSourceBreakdown.Name = "lstAlertSourceBreakdown"
        Me.lstAlertSourceBreakdown.Size = New System.Drawing.Size(120, 95)
        Me.lstAlertSourceBreakdown.TabIndex = 2
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(12, 60)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(122, 13)
        Me.Label18.TabIndex = 3
        Me.Label18.Text = "Alert Source Breakdown"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(947, 729)
        Me.Controls.Add(Me.tabTopMenu)
        Me.Name = "Form1"
        Me.Text = "R1-Rest-Test"
        CType(Me.dgvprojects, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvprojectjobs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabTopMenu.ResumeLayout(False)
        Me.tabSettings.ResumeLayout(False)
        Me.tabSettings.PerformLayout()
        Me.tabTesting.ResumeLayout(False)
        Me.tabTesting.PerformLayout()
        Me.tabBottomMenu.ResumeLayout(False)
        Me.tabCreateProject.ResumeLayout(False)
        Me.tabCreateProject.PerformLayout()
        Me.tabProjects.ResumeLayout(False)
        Me.tabProjects.PerformLayout()
        CType(Me.dgvProjectReports, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabCreateJob.ResumeLayout(False)
        Me.tabCreateJob.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.tabAlerts.ResumeLayout(False)
        Me.tabAlerts.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnRefreshProjectList As System.Windows.Forms.Button
    Friend WithEvents btnJobCreate As System.Windows.Forms.Button
    Friend WithEvents dgvprojects As System.Windows.Forms.DataGridView
    Friend WithEvents dgvprojectjobs As System.Windows.Forms.DataGridView
    Friend WithEvents jobname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents status As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tabTopMenu As System.Windows.Forms.TabControl
    Friend WithEvents tabSettings As System.Windows.Forms.TabPage
    Friend WithEvents tabTesting As System.Windows.Forms.TabPage
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtServer As System.Windows.Forms.TextBox
    Friend WithEvents btnSaveSettings As System.Windows.Forms.Button
    Friend WithEvents lblStatusSettings As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents btnAPICallCustom As System.Windows.Forms.Button
    Friend WithEvents txtapicallpath As System.Windows.Forms.TextBox
    Friend WithEvents txtapicallpostjson As System.Windows.Forms.TextBox
    Friend WithEvents cmbRESTOPTION As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tabBottomMenu As System.Windows.Forms.TabControl
    Friend WithEvents tabProjects As System.Windows.Forms.TabPage
    Friend WithEvents tabCreateJob As System.Windows.Forms.TabPage
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtJobName As System.Windows.Forms.TextBox
    Friend WithEvents comboJobType As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents dgvProjectReports As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colLink As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents colrptid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tabCreateProject As System.Windows.Forms.TabPage
    Friend WithEvents btnCreateProject As System.Windows.Forms.Button
    Friend WithEvents txtProjectName As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtProjectCaseFolder As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtProjectJobDataFolder As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cmbProjectProcessingMode As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtProjectID As System.Windows.Forms.TextBox
    Friend WithEvents projectname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ftkcaseid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDelete As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents colCreateJob As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnRemoveSelectedTargets As System.Windows.Forms.Button
    Friend WithEvents btnAddNewTarget As System.Windows.Forms.Button
    Friend WithEvents txtNewTarget As System.Windows.Forms.TextBox
    Friend WithEvents lstTargets As System.Windows.Forms.CheckedListBox
    Friend WithEvents comboJobAction As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents tabAlerts As System.Windows.Forms.TabPage
    Friend WithEvents lblTotalResponses As System.Windows.Forms.Label
    Friend WithEvents lblTotalAutomatedResponses As System.Windows.Forms.Label
    Friend WithEvents lstAlertSourceBreakdown As System.Windows.Forms.ListBox
    Friend WithEvents Label18 As System.Windows.Forms.Label

End Class
