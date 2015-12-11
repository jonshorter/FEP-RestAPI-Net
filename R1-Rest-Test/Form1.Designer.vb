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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnRefreshProjectList = New System.Windows.Forms.Button()
        Me.btnJobCreate = New System.Windows.Forms.Button()
        Me.dgvprojects = New System.Windows.Forms.DataGridView()
        Me.projectname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ftkcaseid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDelete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colCreateJob = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.tabTopMenu = New System.Windows.Forms.TabControl()
        Me.tabSettings = New System.Windows.Forms.TabPage()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnAuth = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtServer = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblStatusSettings = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.btnSaveSettings = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.tabTesting = New System.Windows.Forms.TabPage()
        Me.tabBottomMenu = New System.Windows.Forms.TabControl()
        Me.tabCreateProject = New System.Windows.Forms.TabPage()
        Me.txtProjectDescription = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
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
        Me.btnUpdateProject = New System.Windows.Forms.Button()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.pgProject = New System.Windows.Forms.PropertyGrid()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tabJobs = New System.Windows.Forms.TabPage()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.dgvJobs = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtProjectID = New System.Windows.Forms.NumericUpDown()
        Me.comboJobAction = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lstTargets = New System.Windows.Forms.CheckedListBox()
        Me.btnRemoveSelectedTargets = New System.Windows.Forms.Button()
        Me.btnAddNewTarget = New System.Windows.Forms.Button()
        Me.txtNewTarget = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.comboJobType = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtJobName = New System.Windows.Forms.TextBox()
        Me.tabAlerts = New System.Windows.Forms.TabPage()
        Me.dgvAlertsWithCounts = New System.Windows.Forms.DataGridView()
        Me.AlertID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ArtifactName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblMeanTimeStat = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lstAlertSourceBreakdown = New System.Windows.Forms.ListBox()
        Me.lblTotalAutomatedResponses = New System.Windows.Forms.Label()
        Me.lblTotalResponses = New System.Windows.Forms.Label()
        Me.tabUser = New System.Windows.Forms.TabPage()
        Me.btnFindUser = New System.Windows.Forms.Button()
        Me.txtfindUser = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.tabGroups = New System.Windows.Forms.TabPage()
        Me.treeGroups = New System.Windows.Forms.TreeView()
        Me.tabTemplates = New System.Windows.Forms.TabPage()
        Me.btnGetTemplateID = New System.Windows.Forms.Button()
        Me.txtTemplateID = New System.Windows.Forms.TextBox()
        Me.listCategories = New System.Windows.Forms.ListBox()
        Me.listTemplates = New System.Windows.Forms.ListBox()
        Me.tabConfiguration = New System.Windows.Forms.TabPage()
        Me.btnIsIWAMode = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnAPICallCustom = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtapicallpath = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbRESTOPTION = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtapicallpostjson = New System.Windows.Forms.TextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.txtStatusStrip = New System.Windows.Forms.ToolStripStatusLabel()
        CType(Me.dgvprojects, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabTopMenu.SuspendLayout()
        Me.tabSettings.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.tabTesting.SuspendLayout()
        Me.tabBottomMenu.SuspendLayout()
        Me.tabCreateProject.SuspendLayout()
        Me.tabProjects.SuspendLayout()
        Me.tabJobs.SuspendLayout()
        CType(Me.dgvJobs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProjectID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.tabAlerts.SuspendLayout()
        CType(Me.dgvAlertsWithCounts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabUser.SuspendLayout()
        Me.tabGroups.SuspendLayout()
        Me.tabTemplates.SuspendLayout()
        Me.tabConfiguration.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnRefreshProjectList
        '
        Me.btnRefreshProjectList.Location = New System.Drawing.Point(8, 7)
        Me.btnRefreshProjectList.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRefreshProjectList.Name = "btnRefreshProjectList"
        Me.btnRefreshProjectList.Size = New System.Drawing.Size(185, 30)
        Me.btnRefreshProjectList.TabIndex = 1
        Me.btnRefreshProjectList.Text = "Refresh Project List"
        Me.btnRefreshProjectList.UseVisualStyleBackColor = True
        '
        'btnJobCreate
        '
        Me.btnJobCreate.Location = New System.Drawing.Point(333, 402)
        Me.btnJobCreate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnJobCreate.Name = "btnJobCreate"
        Me.btnJobCreate.Size = New System.Drawing.Size(128, 34)
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
        Me.dgvprojects.Location = New System.Drawing.Point(12, 62)
        Me.dgvprojects.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvprojects.Name = "dgvprojects"
        Me.dgvprojects.ReadOnly = True
        Me.dgvprojects.RowHeadersVisible = False
        Me.dgvprojects.Size = New System.Drawing.Size(432, 397)
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Red
        Me.colDelete.DefaultCellStyle = DataGridViewCellStyle1
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
        'tabTopMenu
        '
        Me.tabTopMenu.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tabTopMenu.Controls.Add(Me.tabSettings)
        Me.tabTopMenu.Controls.Add(Me.tabTesting)
        Me.tabTopMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.tabTopMenu.Location = New System.Drawing.Point(0, 0)
        Me.tabTopMenu.Margin = New System.Windows.Forms.Padding(4)
        Me.tabTopMenu.Name = "tabTopMenu"
        Me.tabTopMenu.SelectedIndex = 0
        Me.tabTopMenu.Size = New System.Drawing.Size(1263, 977)
        Me.tabTopMenu.TabIndex = 14
        '
        'tabSettings
        '
        Me.tabSettings.Controls.Add(Me.GroupBox5)
        Me.tabSettings.Controls.Add(Me.GroupBox4)
        Me.tabSettings.Controls.Add(Me.GroupBox3)
        Me.tabSettings.Location = New System.Drawing.Point(4, 28)
        Me.tabSettings.Margin = New System.Windows.Forms.Padding(4)
        Me.tabSettings.Name = "tabSettings"
        Me.tabSettings.Padding = New System.Windows.Forms.Padding(4)
        Me.tabSettings.Size = New System.Drawing.Size(1255, 945)
        Me.tabSettings.TabIndex = 0
        Me.tabSettings.Text = "Settings"
        Me.tabSettings.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btnLogout)
        Me.GroupBox5.Location = New System.Drawing.Point(437, 144)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Size = New System.Drawing.Size(284, 95)
        Me.GroupBox5.TabIndex = 29
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Logout"
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(85, 48)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(100, 28)
        Me.btnLogout.TabIndex = 26
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnAuth)
        Me.GroupBox4.Location = New System.Drawing.Point(437, 21)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Size = New System.Drawing.Size(284, 95)
        Me.GroupBox4.TabIndex = 28
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Login"
        '
        'btnAuth
        '
        Me.btnAuth.Location = New System.Drawing.Point(85, 48)
        Me.btnAuth.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAuth.Name = "btnAuth"
        Me.btnAuth.Size = New System.Drawing.Size(100, 28)
        Me.btnAuth.TabIndex = 26
        Me.btnAuth.Text = "Login"
        Me.btnAuth.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtServer)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.lblStatusSettings)
        Me.GroupBox3.Controls.Add(Me.txtUsername)
        Me.GroupBox3.Controls.Add(Me.btnSaveSettings)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.txtPassword)
        Me.GroupBox3.Location = New System.Drawing.Point(11, 21)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(384, 218)
        Me.GroupBox3.TabIndex = 27
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Settings"
        '
        'txtServer
        '
        Me.txtServer.Location = New System.Drawing.Point(103, 38)
        Me.txtServer.Margin = New System.Windows.Forms.Padding(4)
        Me.txtServer.Name = "txtServer"
        Me.txtServer.Size = New System.Drawing.Size(257, 22)
        Me.txtServer.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 42)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Server:"
        '
        'lblStatusSettings
        '
        Me.lblStatusSettings.AutoSize = True
        Me.lblStatusSettings.Location = New System.Drawing.Point(20, 170)
        Me.lblStatusSettings.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStatusSettings.Name = "lblStatusSettings"
        Me.lblStatusSettings.Size = New System.Drawing.Size(51, 17)
        Me.lblStatusSettings.TabIndex = 7
        Me.lblStatusSettings.Text = "Label4"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(103, 70)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(257, 22)
        Me.txtUsername.TabIndex = 2
        '
        'btnSaveSettings
        '
        Me.btnSaveSettings.Location = New System.Drawing.Point(261, 164)
        Me.btnSaveSettings.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSaveSettings.Name = "btnSaveSettings"
        Me.btnSaveSettings.Size = New System.Drawing.Size(100, 28)
        Me.btnSaveSettings.TabIndex = 6
        Me.btnSaveSettings.Text = "Save"
        Me.btnSaveSettings.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 74)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Username:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 106)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Password:"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(103, 102)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(257, 22)
        Me.txtPassword.TabIndex = 4
        '
        'tabTesting
        '
        Me.tabTesting.Controls.Add(Me.tabBottomMenu)
        Me.tabTesting.Controls.Add(Me.GroupBox1)
        Me.tabTesting.Location = New System.Drawing.Point(4, 28)
        Me.tabTesting.Margin = New System.Windows.Forms.Padding(4)
        Me.tabTesting.Name = "tabTesting"
        Me.tabTesting.Padding = New System.Windows.Forms.Padding(4)
        Me.tabTesting.Size = New System.Drawing.Size(1255, 945)
        Me.tabTesting.TabIndex = 1
        Me.tabTesting.Text = "APITest"
        Me.tabTesting.UseVisualStyleBackColor = True
        '
        'tabBottomMenu
        '
        Me.tabBottomMenu.Controls.Add(Me.tabCreateProject)
        Me.tabBottomMenu.Controls.Add(Me.tabProjects)
        Me.tabBottomMenu.Controls.Add(Me.tabJobs)
        Me.tabBottomMenu.Controls.Add(Me.tabAlerts)
        Me.tabBottomMenu.Controls.Add(Me.tabUser)
        Me.tabBottomMenu.Controls.Add(Me.tabGroups)
        Me.tabBottomMenu.Controls.Add(Me.tabTemplates)
        Me.tabBottomMenu.Controls.Add(Me.tabConfiguration)
        Me.tabBottomMenu.Location = New System.Drawing.Point(11, 138)
        Me.tabBottomMenu.Margin = New System.Windows.Forms.Padding(4)
        Me.tabBottomMenu.Name = "tabBottomMenu"
        Me.tabBottomMenu.SelectedIndex = 0
        Me.tabBottomMenu.Size = New System.Drawing.Size(1164, 769)
        Me.tabBottomMenu.TabIndex = 24
        '
        'tabCreateProject
        '
        Me.tabCreateProject.Controls.Add(Me.txtProjectDescription)
        Me.tabCreateProject.Controls.Add(Me.Label20)
        Me.tabCreateProject.Controls.Add(Me.Label15)
        Me.tabCreateProject.Controls.Add(Me.cmbProjectProcessingMode)
        Me.tabCreateProject.Controls.Add(Me.Label14)
        Me.tabCreateProject.Controls.Add(Me.txtProjectJobDataFolder)
        Me.tabCreateProject.Controls.Add(Me.Label13)
        Me.tabCreateProject.Controls.Add(Me.txtProjectCaseFolder)
        Me.tabCreateProject.Controls.Add(Me.Label12)
        Me.tabCreateProject.Controls.Add(Me.btnCreateProject)
        Me.tabCreateProject.Controls.Add(Me.txtProjectName)
        Me.tabCreateProject.Location = New System.Drawing.Point(4, 25)
        Me.tabCreateProject.Margin = New System.Windows.Forms.Padding(4)
        Me.tabCreateProject.Name = "tabCreateProject"
        Me.tabCreateProject.Padding = New System.Windows.Forms.Padding(4)
        Me.tabCreateProject.Size = New System.Drawing.Size(1156, 740)
        Me.tabCreateProject.TabIndex = 2
        Me.tabCreateProject.Text = "Create Project"
        Me.tabCreateProject.UseVisualStyleBackColor = True
        '
        'txtProjectDescription
        '
        Me.txtProjectDescription.Location = New System.Drawing.Point(169, 36)
        Me.txtProjectDescription.Margin = New System.Windows.Forms.Padding(4)
        Me.txtProjectDescription.Multiline = True
        Me.txtProjectDescription.Name = "txtProjectDescription"
        Me.txtProjectDescription.Size = New System.Drawing.Size(303, 59)
        Me.txtProjectDescription.TabIndex = 17
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(8, 39)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(131, 17)
        Me.Label20.TabIndex = 16
        Me.Label20.Text = "Project Description:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(481, 75)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(121, 17)
        Me.Label15.TabIndex = 15
        Me.Label15.Text = "Processing Mode:"
        '
        'cmbProjectProcessingMode
        '
        Me.cmbProjectProcessingMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProjectProcessingMode.FormattingEnabled = True
        Me.cmbProjectProcessingMode.Location = New System.Drawing.Point(643, 71)
        Me.cmbProjectProcessingMode.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbProjectProcessingMode.Name = "cmbProjectProcessingMode"
        Me.cmbProjectProcessingMode.Size = New System.Drawing.Size(303, 24)
        Me.cmbProjectProcessingMode.TabIndex = 14
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(481, 43)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(156, 17)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Job Data Folder (UNC):"
        '
        'txtProjectJobDataFolder
        '
        Me.txtProjectJobDataFolder.Location = New System.Drawing.Point(643, 39)
        Me.txtProjectJobDataFolder.Margin = New System.Windows.Forms.Padding(4)
        Me.txtProjectJobDataFolder.Name = "txtProjectJobDataFolder"
        Me.txtProjectJobDataFolder.Size = New System.Drawing.Size(303, 22)
        Me.txtProjectJobDataFolder.TabIndex = 12
        Me.txtProjectJobDataFolder.Text = "\\10.0.1.52\Share\JobData"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(481, 11)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(143, 17)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "Project Folder (UNC):"
        '
        'txtProjectCaseFolder
        '
        Me.txtProjectCaseFolder.Location = New System.Drawing.Point(643, 7)
        Me.txtProjectCaseFolder.Margin = New System.Windows.Forms.Padding(4)
        Me.txtProjectCaseFolder.Name = "txtProjectCaseFolder"
        Me.txtProjectCaseFolder.Size = New System.Drawing.Size(303, 22)
        Me.txtProjectCaseFolder.TabIndex = 10
        Me.txtProjectCaseFolder.Text = "\\10.0.1.52\Share\Projects"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(8, 11)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(97, 17)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "Project Name:"
        '
        'btnCreateProject
        '
        Me.btnCreateProject.Location = New System.Drawing.Point(761, 160)
        Me.btnCreateProject.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCreateProject.Name = "btnCreateProject"
        Me.btnCreateProject.Size = New System.Drawing.Size(185, 30)
        Me.btnCreateProject.TabIndex = 7
        Me.btnCreateProject.Text = "Create Project"
        Me.btnCreateProject.UseVisualStyleBackColor = True
        '
        'txtProjectName
        '
        Me.txtProjectName.Location = New System.Drawing.Point(169, 7)
        Me.txtProjectName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtProjectName.Name = "txtProjectName"
        Me.txtProjectName.Size = New System.Drawing.Size(303, 22)
        Me.txtProjectName.TabIndex = 8
        Me.txtProjectName.Text = "APIProject"
        '
        'tabProjects
        '
        Me.tabProjects.Controls.Add(Me.btnUpdateProject)
        Me.tabProjects.Controls.Add(Me.Label21)
        Me.tabProjects.Controls.Add(Me.pgProject)
        Me.tabProjects.Controls.Add(Me.Label9)
        Me.tabProjects.Controls.Add(Me.btnRefreshProjectList)
        Me.tabProjects.Controls.Add(Me.dgvprojects)
        Me.tabProjects.Location = New System.Drawing.Point(4, 25)
        Me.tabProjects.Margin = New System.Windows.Forms.Padding(4)
        Me.tabProjects.Name = "tabProjects"
        Me.tabProjects.Padding = New System.Windows.Forms.Padding(4)
        Me.tabProjects.Size = New System.Drawing.Size(1156, 740)
        Me.tabProjects.TabIndex = 0
        Me.tabProjects.Text = "Projects"
        Me.tabProjects.UseVisualStyleBackColor = True
        '
        'btnUpdateProject
        '
        Me.btnUpdateProject.Location = New System.Drawing.Point(995, 261)
        Me.btnUpdateProject.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUpdateProject.Name = "btnUpdateProject"
        Me.btnUpdateProject.Size = New System.Drawing.Size(153, 28)
        Me.btnUpdateProject.TabIndex = 18
        Me.btnUpdateProject.Text = "Update Project"
        Me.btnUpdateProject.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(448, 42)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(99, 17)
        Me.Label21.TabIndex = 17
        Me.Label21.Text = "Project Details"
        '
        'pgProject
        '
        Me.pgProject.HelpVisible = False
        Me.pgProject.Location = New System.Drawing.Point(452, 62)
        Me.pgProject.Margin = New System.Windows.Forms.Padding(4)
        Me.pgProject.Name = "pgProject"
        Me.pgProject.PropertySort = System.Windows.Forms.PropertySort.Alphabetical
        Me.pgProject.Size = New System.Drawing.Size(540, 398)
        Me.pgProject.TabIndex = 16
        Me.pgProject.ToolbarVisible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(8, 42)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 17)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Projects"
        '
        'tabJobs
        '
        Me.tabJobs.Controls.Add(Me.Label23)
        Me.tabJobs.Controls.Add(Me.dgvJobs)
        Me.tabJobs.Controls.Add(Me.txtProjectID)
        Me.tabJobs.Controls.Add(Me.comboJobAction)
        Me.tabJobs.Controls.Add(Me.Label17)
        Me.tabJobs.Controls.Add(Me.GroupBox2)
        Me.tabJobs.Controls.Add(Me.Label16)
        Me.tabJobs.Controls.Add(Me.comboJobType)
        Me.tabJobs.Controls.Add(Me.Label8)
        Me.tabJobs.Controls.Add(Me.Label7)
        Me.tabJobs.Controls.Add(Me.txtJobName)
        Me.tabJobs.Controls.Add(Me.btnJobCreate)
        Me.tabJobs.Location = New System.Drawing.Point(4, 25)
        Me.tabJobs.Margin = New System.Windows.Forms.Padding(4)
        Me.tabJobs.Name = "tabJobs"
        Me.tabJobs.Padding = New System.Windows.Forms.Padding(4)
        Me.tabJobs.Size = New System.Drawing.Size(1156, 740)
        Me.tabJobs.TabIndex = 1
        Me.tabJobs.Text = "Jobs"
        Me.tabJobs.UseVisualStyleBackColor = True
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(537, 18)
        Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(38, 17)
        Me.Label23.TabIndex = 22
        Me.Label23.Text = "Jobs"
        '
        'dgvJobs
        '
        Me.dgvJobs.AllowUserToAddRows = False
        Me.dgvJobs.AllowUserToDeleteRows = False
        Me.dgvJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvJobs.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.dgvJobs.Location = New System.Drawing.Point(533, 38)
        Me.dgvJobs.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvJobs.Name = "dgvJobs"
        Me.dgvJobs.ReadOnly = True
        Me.dgvJobs.RowHeadersVisible = False
        Me.dgvJobs.Size = New System.Drawing.Size(588, 242)
        Me.dgvJobs.TabIndex = 21
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "Job Name"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "Job Type"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.HeaderText = "Job Status"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.HeaderText = "JobID"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'txtProjectID
        '
        Me.txtProjectID.Location = New System.Drawing.Point(141, 9)
        Me.txtProjectID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtProjectID.Name = "txtProjectID"
        Me.txtProjectID.Size = New System.Drawing.Size(211, 22)
        Me.txtProjectID.TabIndex = 14
        '
        'comboJobAction
        '
        Me.comboJobAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboJobAction.FormattingEnabled = True
        Me.comboJobAction.Location = New System.Drawing.Point(141, 126)
        Me.comboJobAction.Margin = New System.Windows.Forms.Padding(4)
        Me.comboJobAction.Name = "comboJobAction"
        Me.comboJobAction.Size = New System.Drawing.Size(209, 24)
        Me.comboJobAction.TabIndex = 13
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(32, 129)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(78, 17)
        Me.Label17.TabIndex = 12
        Me.Label17.Text = "Job Action:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lstTargets)
        Me.GroupBox2.Controls.Add(Me.btnRemoveSelectedTargets)
        Me.GroupBox2.Controls.Add(Me.btnAddNewTarget)
        Me.GroupBox2.Controls.Add(Me.txtNewTarget)
        Me.GroupBox2.Location = New System.Drawing.Point(35, 191)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(427, 190)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Targets"
        '
        'lstTargets
        '
        Me.lstTargets.FormattingEnabled = True
        Me.lstTargets.Location = New System.Drawing.Point(8, 65)
        Me.lstTargets.Margin = New System.Windows.Forms.Padding(4)
        Me.lstTargets.Name = "lstTargets"
        Me.lstTargets.Size = New System.Drawing.Size(159, 106)
        Me.lstTargets.TabIndex = 4
        '
        'btnRemoveSelectedTargets
        '
        Me.btnRemoveSelectedTargets.Location = New System.Drawing.Point(189, 154)
        Me.btnRemoveSelectedTargets.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRemoveSelectedTargets.Name = "btnRemoveSelectedTargets"
        Me.btnRemoveSelectedTargets.Size = New System.Drawing.Size(175, 28)
        Me.btnRemoveSelectedTargets.TabIndex = 3
        Me.btnRemoveSelectedTargets.Text = "Remove Checked"
        Me.btnRemoveSelectedTargets.UseVisualStyleBackColor = True
        '
        'btnAddNewTarget
        '
        Me.btnAddNewTarget.Location = New System.Drawing.Point(189, 31)
        Me.btnAddNewTarget.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAddNewTarget.Name = "btnAddNewTarget"
        Me.btnAddNewTarget.Size = New System.Drawing.Size(100, 28)
        Me.btnAddNewTarget.TabIndex = 2
        Me.btnAddNewTarget.Text = "Add"
        Me.btnAddNewTarget.UseVisualStyleBackColor = True
        '
        'txtNewTarget
        '
        Me.txtNewTarget.Location = New System.Drawing.Point(8, 33)
        Me.txtNewTarget.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNewTarget.Name = "txtNewTarget"
        Me.txtNewTarget.Size = New System.Drawing.Size(159, 22)
        Me.txtNewTarget.TabIndex = 1
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(32, 11)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(73, 17)
        Me.Label16.TabIndex = 10
        Me.Label16.Text = "Project ID:"
        '
        'comboJobType
        '
        Me.comboJobType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboJobType.FormattingEnabled = True
        Me.comboJobType.Location = New System.Drawing.Point(141, 86)
        Me.comboJobType.Margin = New System.Windows.Forms.Padding(4)
        Me.comboJobType.Name = "comboJobType"
        Me.comboJobType.Size = New System.Drawing.Size(209, 24)
        Me.comboJobType.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(32, 90)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 17)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Job Type:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(32, 52)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 17)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Job Name:"
        '
        'txtJobName
        '
        Me.txtJobName.Location = New System.Drawing.Point(141, 48)
        Me.txtJobName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtJobName.Name = "txtJobName"
        Me.txtJobName.Size = New System.Drawing.Size(209, 22)
        Me.txtJobName.TabIndex = 5
        '
        'tabAlerts
        '
        Me.tabAlerts.Controls.Add(Me.dgvAlertsWithCounts)
        Me.tabAlerts.Controls.Add(Me.lblMeanTimeStat)
        Me.tabAlerts.Controls.Add(Me.Label18)
        Me.tabAlerts.Controls.Add(Me.lstAlertSourceBreakdown)
        Me.tabAlerts.Controls.Add(Me.lblTotalAutomatedResponses)
        Me.tabAlerts.Controls.Add(Me.lblTotalResponses)
        Me.tabAlerts.Location = New System.Drawing.Point(4, 25)
        Me.tabAlerts.Margin = New System.Windows.Forms.Padding(4)
        Me.tabAlerts.Name = "tabAlerts"
        Me.tabAlerts.Padding = New System.Windows.Forms.Padding(4)
        Me.tabAlerts.Size = New System.Drawing.Size(1156, 740)
        Me.tabAlerts.TabIndex = 3
        Me.tabAlerts.Text = "Alerts"
        Me.tabAlerts.UseVisualStyleBackColor = True
        '
        'dgvAlertsWithCounts
        '
        Me.dgvAlertsWithCounts.AllowUserToAddRows = False
        Me.dgvAlertsWithCounts.AllowUserToDeleteRows = False
        Me.dgvAlertsWithCounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAlertsWithCounts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AlertID, Me.ArtifactName, Me.Description})
        Me.dgvAlertsWithCounts.Location = New System.Drawing.Point(260, 94)
        Me.dgvAlertsWithCounts.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvAlertsWithCounts.Name = "dgvAlertsWithCounts"
        Me.dgvAlertsWithCounts.ReadOnly = True
        Me.dgvAlertsWithCounts.RowHeadersVisible = False
        Me.dgvAlertsWithCounts.Size = New System.Drawing.Size(599, 251)
        Me.dgvAlertsWithCounts.TabIndex = 20
        '
        'AlertID
        '
        Me.AlertID.HeaderText = "AlertID"
        Me.AlertID.Name = "AlertID"
        Me.AlertID.ReadOnly = True
        '
        'ArtifactName
        '
        Me.ArtifactName.HeaderText = "ArtifactName"
        Me.ArtifactName.Name = "ArtifactName"
        Me.ArtifactName.ReadOnly = True
        '
        'Description
        '
        Me.Description.HeaderText = "Description"
        Me.Description.Name = "Description"
        Me.Description.ReadOnly = True
        '
        'lblMeanTimeStat
        '
        Me.lblMeanTimeStat.AutoSize = True
        Me.lblMeanTimeStat.Location = New System.Drawing.Point(275, 17)
        Me.lblMeanTimeStat.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMeanTimeStat.Name = "lblMeanTimeStat"
        Me.lblMeanTimeStat.Size = New System.Drawing.Size(107, 17)
        Me.lblMeanTimeStat.TabIndex = 4
        Me.lblMeanTimeStat.Text = "Mean Time Stat"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(16, 74)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(160, 17)
        Me.Label18.TabIndex = 3
        Me.Label18.Text = "Alert Source Breakdown"
        '
        'lstAlertSourceBreakdown
        '
        Me.lstAlertSourceBreakdown.FormattingEnabled = True
        Me.lstAlertSourceBreakdown.ItemHeight = 16
        Me.lstAlertSourceBreakdown.Location = New System.Drawing.Point(20, 94)
        Me.lstAlertSourceBreakdown.Margin = New System.Windows.Forms.Padding(4)
        Me.lstAlertSourceBreakdown.Name = "lstAlertSourceBreakdown"
        Me.lstAlertSourceBreakdown.Size = New System.Drawing.Size(159, 116)
        Me.lstAlertSourceBreakdown.TabIndex = 2
        '
        'lblTotalAutomatedResponses
        '
        Me.lblTotalAutomatedResponses.AutoSize = True
        Me.lblTotalAutomatedResponses.Location = New System.Drawing.Point(16, 48)
        Me.lblTotalAutomatedResponses.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalAutomatedResponses.Name = "lblTotalAutomatedResponses"
        Me.lblTotalAutomatedResponses.Size = New System.Drawing.Size(187, 17)
        Me.lblTotalAutomatedResponses.TabIndex = 1
        Me.lblTotalAutomatedResponses.Text = "Total Automated Responses"
        '
        'lblTotalResponses
        '
        Me.lblTotalResponses.AutoSize = True
        Me.lblTotalResponses.Location = New System.Drawing.Point(16, 17)
        Me.lblTotalResponses.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalResponses.Name = "lblTotalResponses"
        Me.lblTotalResponses.Size = New System.Drawing.Size(115, 17)
        Me.lblTotalResponses.TabIndex = 0
        Me.lblTotalResponses.Text = "Total Responses"
        '
        'tabUser
        '
        Me.tabUser.Controls.Add(Me.btnFindUser)
        Me.tabUser.Controls.Add(Me.txtfindUser)
        Me.tabUser.Controls.Add(Me.Label22)
        Me.tabUser.Location = New System.Drawing.Point(4, 25)
        Me.tabUser.Margin = New System.Windows.Forms.Padding(4)
        Me.tabUser.Name = "tabUser"
        Me.tabUser.Padding = New System.Windows.Forms.Padding(4)
        Me.tabUser.Size = New System.Drawing.Size(1156, 740)
        Me.tabUser.TabIndex = 4
        Me.tabUser.Text = "User"
        Me.tabUser.UseVisualStyleBackColor = True
        '
        'btnFindUser
        '
        Me.btnFindUser.Location = New System.Drawing.Point(412, 18)
        Me.btnFindUser.Margin = New System.Windows.Forms.Padding(4)
        Me.btnFindUser.Name = "btnFindUser"
        Me.btnFindUser.Size = New System.Drawing.Size(100, 28)
        Me.btnFindUser.TabIndex = 2
        Me.btnFindUser.Text = "Find"
        Me.btnFindUser.UseVisualStyleBackColor = True
        '
        'txtfindUser
        '
        Me.txtfindUser.Location = New System.Drawing.Point(212, 21)
        Me.txtfindUser.Margin = New System.Windows.Forms.Padding(4)
        Me.txtfindUser.Name = "txtfindUser"
        Me.txtfindUser.Size = New System.Drawing.Size(191, 22)
        Me.txtfindUser.TabIndex = 1
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(15, 25)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(191, 17)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "Find Username or Lastname:"
        '
        'tabGroups
        '
        Me.tabGroups.Controls.Add(Me.treeGroups)
        Me.tabGroups.Location = New System.Drawing.Point(4, 25)
        Me.tabGroups.Name = "tabGroups"
        Me.tabGroups.Padding = New System.Windows.Forms.Padding(3)
        Me.tabGroups.Size = New System.Drawing.Size(1156, 740)
        Me.tabGroups.TabIndex = 5
        Me.tabGroups.Text = "Groups"
        Me.tabGroups.UseVisualStyleBackColor = True
        '
        'treeGroups
        '
        Me.treeGroups.Location = New System.Drawing.Point(20, 18)
        Me.treeGroups.Name = "treeGroups"
        Me.treeGroups.Size = New System.Drawing.Size(309, 171)
        Me.treeGroups.TabIndex = 0
        '
        'tabTemplates
        '
        Me.tabTemplates.Controls.Add(Me.btnGetTemplateID)
        Me.tabTemplates.Controls.Add(Me.txtTemplateID)
        Me.tabTemplates.Controls.Add(Me.listCategories)
        Me.tabTemplates.Controls.Add(Me.listTemplates)
        Me.tabTemplates.Location = New System.Drawing.Point(4, 25)
        Me.tabTemplates.Name = "tabTemplates"
        Me.tabTemplates.Size = New System.Drawing.Size(1156, 740)
        Me.tabTemplates.TabIndex = 6
        Me.tabTemplates.Text = "Templates"
        Me.tabTemplates.UseVisualStyleBackColor = True
        '
        'btnGetTemplateID
        '
        Me.btnGetTemplateID.Location = New System.Drawing.Point(314, 305)
        Me.btnGetTemplateID.Name = "btnGetTemplateID"
        Me.btnGetTemplateID.Size = New System.Drawing.Size(127, 35)
        Me.btnGetTemplateID.TabIndex = 3
        Me.btnGetTemplateID.Text = "Get Template ID"
        Me.btnGetTemplateID.UseVisualStyleBackColor = True
        '
        'txtTemplateID
        '
        Me.txtTemplateID.Location = New System.Drawing.Point(20, 311)
        Me.txtTemplateID.Name = "txtTemplateID"
        Me.txtTemplateID.Size = New System.Drawing.Size(274, 22)
        Me.txtTemplateID.TabIndex = 2
        '
        'listCategories
        '
        Me.listCategories.FormattingEnabled = True
        Me.listCategories.ItemHeight = 16
        Me.listCategories.Location = New System.Drawing.Point(464, 22)
        Me.listCategories.Name = "listCategories"
        Me.listCategories.Size = New System.Drawing.Size(408, 228)
        Me.listCategories.TabIndex = 1
        '
        'listTemplates
        '
        Me.listTemplates.FormattingEnabled = True
        Me.listTemplates.ItemHeight = 16
        Me.listTemplates.Location = New System.Drawing.Point(17, 22)
        Me.listTemplates.Name = "listTemplates"
        Me.listTemplates.Size = New System.Drawing.Size(408, 228)
        Me.listTemplates.TabIndex = 0
        '
        'tabConfiguration
        '
        Me.tabConfiguration.Controls.Add(Me.btnIsIWAMode)
        Me.tabConfiguration.Location = New System.Drawing.Point(4, 25)
        Me.tabConfiguration.Name = "tabConfiguration"
        Me.tabConfiguration.Padding = New System.Windows.Forms.Padding(3)
        Me.tabConfiguration.Size = New System.Drawing.Size(1156, 740)
        Me.tabConfiguration.TabIndex = 7
        Me.tabConfiguration.Text = "Configuration"
        Me.tabConfiguration.UseVisualStyleBackColor = True
        '
        'btnIsIWAMode
        '
        Me.btnIsIWAMode.Location = New System.Drawing.Point(22, 26)
        Me.btnIsIWAMode.Name = "btnIsIWAMode"
        Me.btnIsIWAMode.Size = New System.Drawing.Size(103, 27)
        Me.btnIsIWAMode.TabIndex = 0
        Me.btnIsIWAMode.Text = "IsIWAMode?"
        Me.btnIsIWAMode.UseVisualStyleBackColor = True
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
        Me.GroupBox1.Location = New System.Drawing.Point(11, 7)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(696, 123)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Custom API Call"
        '
        'btnAPICallCustom
        '
        Me.btnAPICallCustom.Location = New System.Drawing.Point(575, 65)
        Me.btnAPICallCustom.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAPICallCustom.Name = "btnAPICallCustom"
        Me.btnAPICallCustom.Size = New System.Drawing.Size(100, 28)
        Me.btnAPICallCustom.TabIndex = 16
        Me.btnAPICallCustom.Text = "Run"
        Me.btnAPICallCustom.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(380, 43)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 17)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "post json"
        '
        'txtapicallpath
        '
        Me.txtapicallpath.Location = New System.Drawing.Point(193, 64)
        Me.txtapicallpath.Margin = New System.Windows.Forms.Padding(4)
        Me.txtapicallpath.Name = "txtapicallpath"
        Me.txtapicallpath.Size = New System.Drawing.Size(181, 22)
        Me.txtapicallpath.TabIndex = 17
        Me.txtapicallpath.Text = "projects"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(189, 43)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 17)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "path. ie projects"
        '
        'cmbRESTOPTION
        '
        Me.cmbRESTOPTION.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRESTOPTION.FormattingEnabled = True
        Me.cmbRESTOPTION.Location = New System.Drawing.Point(24, 63)
        Me.cmbRESTOPTION.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbRESTOPTION.Name = "cmbRESTOPTION"
        Me.cmbRESTOPTION.Size = New System.Drawing.Size(160, 24)
        Me.cmbRESTOPTION.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 43)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 17)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Method:"
        '
        'txtapicallpostjson
        '
        Me.txtapicallpostjson.Location = New System.Drawing.Point(384, 65)
        Me.txtapicallpostjson.Margin = New System.Windows.Forms.Padding(4)
        Me.txtapicallpostjson.Name = "txtapicallpostjson"
        Me.txtapicallpostjson.Size = New System.Drawing.Size(181, 22)
        Me.txtapicallpostjson.TabIndex = 19
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.txtStatusStrip})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 983)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1263, 25)
        Me.StatusStrip1.TabIndex = 26
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'txtStatusStrip
        '
        Me.txtStatusStrip.Name = "txtStatusStrip"
        Me.txtStatusStrip.Size = New System.Drawing.Size(142, 20)
        Me.txtStatusStrip.Text = "Authenticated: False"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1263, 1008)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.tabTopMenu)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "R1-Rest-Test"
        CType(Me.dgvprojects, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabTopMenu.ResumeLayout(False)
        Me.tabSettings.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.tabTesting.ResumeLayout(False)
        Me.tabBottomMenu.ResumeLayout(False)
        Me.tabCreateProject.ResumeLayout(False)
        Me.tabCreateProject.PerformLayout()
        Me.tabProjects.ResumeLayout(False)
        Me.tabProjects.PerformLayout()
        Me.tabJobs.ResumeLayout(False)
        Me.tabJobs.PerformLayout()
        CType(Me.dgvJobs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProjectID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.tabAlerts.ResumeLayout(False)
        Me.tabAlerts.PerformLayout()
        CType(Me.dgvAlertsWithCounts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabUser.ResumeLayout(False)
        Me.tabUser.PerformLayout()
        Me.tabGroups.ResumeLayout(False)
        Me.tabTemplates.ResumeLayout(False)
        Me.tabTemplates.PerformLayout()
        Me.tabConfiguration.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnRefreshProjectList As System.Windows.Forms.Button
    Friend WithEvents btnJobCreate As System.Windows.Forms.Button
    Friend WithEvents dgvprojects As System.Windows.Forms.DataGridView
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
    Friend WithEvents tabJobs As System.Windows.Forms.TabPage
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtJobName As System.Windows.Forms.TextBox
    Friend WithEvents comboJobType As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
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
    Friend WithEvents projectname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ftkcaseid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDelete As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents colCreateJob As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents txtProjectDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents pgProject As System.Windows.Forms.PropertyGrid
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtProjectID As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnAuth As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents txtStatusStrip As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents btnUpdateProject As System.Windows.Forms.Button
    Friend WithEvents tabUser As System.Windows.Forms.TabPage
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents btnFindUser As System.Windows.Forms.Button
    Friend WithEvents txtfindUser As System.Windows.Forms.TextBox
    Friend WithEvents tabGroups As System.Windows.Forms.TabPage
    Friend WithEvents treeGroups As System.Windows.Forms.TreeView
    Friend WithEvents tabTemplates As System.Windows.Forms.TabPage
    Friend WithEvents listTemplates As System.Windows.Forms.ListBox
    Friend WithEvents tabConfiguration As System.Windows.Forms.TabPage
    Friend WithEvents btnIsIWAMode As System.Windows.Forms.Button
    Friend WithEvents listCategories As System.Windows.Forms.ListBox
    Friend WithEvents btnGetTemplateID As System.Windows.Forms.Button
    Friend WithEvents txtTemplateID As System.Windows.Forms.TextBox
    Friend WithEvents lblMeanTimeStat As System.Windows.Forms.Label
    Friend WithEvents dgvAlertsWithCounts As System.Windows.Forms.DataGridView
    Friend WithEvents AlertID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ArtifactName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Description As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents dgvJobs As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
