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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.txtProjectName = New System.Windows.Forms.TextBox()
        Me.txtProjectDelete = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.projectname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ftkcaseid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.jobname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
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
        Me.txtapicallpostjson = New System.Windows.Forms.TextBox()
        Me.cmbRESTOPTION = New System.Windows.Forms.ComboBox()
        Me.txtapicallpath = New System.Windows.Forms.TextBox()
        Me.btnAPICallCustom = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.statconnection = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.tabProjects = New System.Windows.Forms.TabPage()
        Me.tabJobs = New System.Windows.Forms.TabPage()
        Me.txtJobName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.tabSettings.SuspendLayout()
        Me.tabTesting.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.tabProjects.SuspendLayout()
        Me.tabJobs.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(3, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(139, 24)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Create Project"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(3, 51)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(139, 24)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "List Projects"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(6, 425)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 24)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(6, 101)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(96, 28)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Jobs Put"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'txtProjectName
        '
        Me.txtProjectName.Location = New System.Drawing.Point(148, 6)
        Me.txtProjectName.Name = "txtProjectName"
        Me.txtProjectName.Size = New System.Drawing.Size(228, 20)
        Me.txtProjectName.TabIndex = 6
        Me.txtProjectName.Text = "APIProject"
        '
        'txtProjectDelete
        '
        Me.txtProjectDelete.Location = New System.Drawing.Point(87, 427)
        Me.txtProjectDelete.Name = "txtProjectDelete"
        Me.txtProjectDelete.Size = New System.Drawing.Size(76, 20)
        Me.txtProjectDelete.TabIndex = 7
        Me.txtProjectDelete.Text = "FTKCASEID"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.projectname, Me.ftkcaseid})
        Me.DataGridView1.Location = New System.Drawing.Point(73, 81)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(324, 151)
        Me.DataGridView1.TabIndex = 8
        '
        'projectname
        '
        Me.projectname.HeaderText = "Project"
        Me.projectname.Name = "projectname"
        Me.projectname.ReadOnly = True
        '
        'ftkcaseid
        '
        Me.ftkcaseid.HeaderText = "FTKCaseID"
        Me.ftkcaseid.Name = "ftkcaseid"
        Me.ftkcaseid.ReadOnly = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.jobname, Me.status})
        Me.DataGridView2.Location = New System.Drawing.Point(73, 250)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.Size = New System.Drawing.Size(324, 151)
        Me.DataGridView2.TabIndex = 9
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
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.tabSettings)
        Me.TabControl1.Controls.Add(Me.tabTesting)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(947, 729)
        Me.TabControl1.TabIndex = 14
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
        Me.tabTesting.Controls.Add(Me.TabControl2)
        Me.tabTesting.Controls.Add(Me.GroupBox1)
        Me.tabTesting.Controls.Add(Me.StatusStrip1)
        Me.tabTesting.Controls.Add(Me.btnConnect)
        Me.tabTesting.Location = New System.Drawing.Point(4, 25)
        Me.tabTesting.Name = "tabTesting"
        Me.tabTesting.Padding = New System.Windows.Forms.Padding(3)
        Me.tabTesting.Size = New System.Drawing.Size(939, 700)
        Me.tabTesting.TabIndex = 1
        Me.tabTesting.Text = "APITest"
        Me.tabTesting.UseVisualStyleBackColor = True
        '
        'txtapicallpostjson
        '
        Me.txtapicallpostjson.Location = New System.Drawing.Point(288, 53)
        Me.txtapicallpostjson.Name = "txtapicallpostjson"
        Me.txtapicallpostjson.Size = New System.Drawing.Size(137, 20)
        Me.txtapicallpostjson.TabIndex = 19
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
        'txtapicallpath
        '
        Me.txtapicallpath.Location = New System.Drawing.Point(145, 52)
        Me.txtapicallpath.Name = "txtapicallpath"
        Me.txtapicallpath.Size = New System.Drawing.Size(137, 20)
        Me.txtapicallpath.TabIndex = 17
        Me.txtapicallpath.Text = "projects"
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
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statconnection})
        Me.StatusStrip1.Location = New System.Drawing.Point(3, 675)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(933, 22)
        Me.StatusStrip1.TabIndex = 15
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'statconnection
        '
        Me.statconnection.Name = "statconnection"
        Me.statconnection.Size = New System.Drawing.Size(88, 17)
        Me.statconnection.Text = "Not Connected"
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(26, 112)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(75, 23)
        Me.btnConnect.TabIndex = 14
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(142, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "path. ie projects"
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
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.tabProjects)
        Me.TabControl2.Controls.Add(Me.tabJobs)
        Me.TabControl2.Location = New System.Drawing.Point(22, 144)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(411, 519)
        Me.TabControl2.TabIndex = 24
        '
        'tabProjects
        '
        Me.tabProjects.Controls.Add(Me.Button1)
        Me.tabProjects.Controls.Add(Me.txtProjectName)
        Me.tabProjects.Controls.Add(Me.Button2)
        Me.tabProjects.Controls.Add(Me.DataGridView1)
        Me.tabProjects.Controls.Add(Me.DataGridView2)
        Me.tabProjects.Controls.Add(Me.Button3)
        Me.tabProjects.Controls.Add(Me.txtProjectDelete)
        Me.tabProjects.Location = New System.Drawing.Point(4, 22)
        Me.tabProjects.Name = "tabProjects"
        Me.tabProjects.Padding = New System.Windows.Forms.Padding(3)
        Me.tabProjects.Size = New System.Drawing.Size(403, 493)
        Me.tabProjects.TabIndex = 0
        Me.tabProjects.Text = "Projects"
        Me.tabProjects.UseVisualStyleBackColor = True
        '
        'tabJobs
        '
        Me.tabJobs.Controls.Add(Me.Label7)
        Me.tabJobs.Controls.Add(Me.txtJobName)
        Me.tabJobs.Controls.Add(Me.Button5)
        Me.tabJobs.Location = New System.Drawing.Point(4, 22)
        Me.tabJobs.Name = "tabJobs"
        Me.tabJobs.Padding = New System.Windows.Forms.Padding(3)
        Me.tabJobs.Size = New System.Drawing.Size(403, 493)
        Me.tabJobs.TabIndex = 1
        Me.tabJobs.Text = "Jobs"
        Me.tabJobs.UseVisualStyleBackColor = True
        '
        'txtJobName
        '
        Me.txtJobName.Location = New System.Drawing.Point(106, 39)
        Me.txtJobName.Name = "txtJobName"
        Me.txtJobName.Size = New System.Drawing.Size(158, 20)
        Me.txtJobName.TabIndex = 5
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(947, 729)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "R1 RestAPI Test"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.tabSettings.ResumeLayout(False)
        Me.tabSettings.PerformLayout()
        Me.tabTesting.ResumeLayout(False)
        Me.tabTesting.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl2.ResumeLayout(False)
        Me.tabProjects.ResumeLayout(False)
        Me.tabProjects.PerformLayout()
        Me.tabJobs.ResumeLayout(False)
        Me.tabJobs.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents txtProjectName As System.Windows.Forms.TextBox
    Friend WithEvents txtProjectDelete As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents jobname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents status As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents projectname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ftkcaseid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabSettings As System.Windows.Forms.TabPage
    Friend WithEvents tabTesting As System.Windows.Forms.TabPage
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtServer As System.Windows.Forms.TextBox
    Friend WithEvents btnSaveSettings As System.Windows.Forms.Button
    Friend WithEvents btnConnect As System.Windows.Forms.Button
    Friend WithEvents lblStatusSettings As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents statconnection As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnAPICallCustom As System.Windows.Forms.Button
    Friend WithEvents txtapicallpath As System.Windows.Forms.TextBox
    Friend WithEvents txtapicallpostjson As System.Windows.Forms.TextBox
    Friend WithEvents cmbRESTOPTION As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents tabProjects As System.Windows.Forms.TabPage
    Friend WithEvents tabJobs As System.Windows.Forms.TabPage
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtJobName As System.Windows.Forms.TextBox

End Class
