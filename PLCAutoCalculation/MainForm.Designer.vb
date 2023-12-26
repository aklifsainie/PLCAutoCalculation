<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.lblFeedbackMode = New System.Windows.Forms.Label()
        Me.dgvNGSN = New System.Windows.Forms.DataGridView()
        Me.lblApplicationName = New System.Windows.Forms.Label()
        Me.rtxtLog = New System.Windows.Forms.RichTextBox()
        Me.msMainMenu = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DebugToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.bgtPort1 = New System.ComponentModel.BackgroundWorker()
        Me.bgtStartOpenPort = New System.ComponentModel.BackgroundWorker()
        Me.bgtPort2 = New System.ComponentModel.BackgroundWorker()
        Me.bgtPort3 = New System.ComponentModel.BackgroundWorker()
        Me.bgtPort4 = New System.ComponentModel.BackgroundWorker()
        Me.bgtSendToPLCPort2 = New System.ComponentModel.BackgroundWorker()
        Me.bgtSendToPLCPort3 = New System.ComponentModel.BackgroundWorker()
        Me.bgtSendToPLCPort4 = New System.ComponentModel.BackgroundWorker()
        Me.Port1Timer = New System.Windows.Forms.Timer(Me.components)
        Me.bgtStartingServer = New System.ComponentModel.BackgroundWorker()
        Me.bgtOpenPort = New System.ComponentModel.BackgroundWorker()
        Me.pnlSidebar = New System.Windows.Forms.Panel()
        Me.btnStartServer = New System.Windows.Forms.Button()
        Me.btnSetting = New System.Windows.Forms.Button()
        Me.pnlNavbar = New System.Windows.Forms.Panel()
        Me.btnHamburgerMenu = New System.Windows.Forms.Button()
        Me.lblMode = New System.Windows.Forms.Label()
        Me.tmSidebarOpen = New System.Windows.Forms.Timer(Me.components)
        Me.tmSidebarClose = New System.Windows.Forms.Timer(Me.components)
        Me.pnlMainContent = New System.Windows.Forms.Panel()
        Me.fpnlRawData = New System.Windows.Forms.FlowLayoutPanel()
        Me.fnlGroupHKA = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblTitleHousingKA = New System.Windows.Forms.Label()
        Me.lblValueHousingKA = New System.Windows.Forms.Label()
        Me.fnlGroupHKC = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblTitleHousingKC = New System.Windows.Forms.Label()
        Me.lblValueHousingKC = New System.Windows.Forms.Label()
        Me.fnlGroupHCB = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblTitleHousingCB = New System.Windows.Forms.Label()
        Me.lblValueHousingCB = New System.Windows.Forms.Label()
        Me.fnlGroupHCD = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblTitleHousingCD = New System.Windows.Forms.Label()
        Me.lblValueHousingCD = New System.Windows.Forms.Label()
        Me.fnlGroupHHKA = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblTitleHousingHKA = New System.Windows.Forms.Label()
        Me.lblValueHousingHKA = New System.Windows.Forms.Label()
        Me.fnlGroupHHKC = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblTitleHousingHKC = New System.Windows.Forms.Label()
        Me.lblValueHousingHKC = New System.Windows.Forms.Label()
        Me.fnlGroupCK = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblTitleHousingCK = New System.Windows.Forms.Label()
        Me.lblValueHousingCK = New System.Windows.Forms.Label()
        Me.fnlGroupCC = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblTitleHousingCC = New System.Windows.Forms.Label()
        Me.lblValueHousingCC = New System.Windows.Forms.Label()
        Me.fnlGroupCHK = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblTitleHousingCHK = New System.Windows.Forms.Label()
        Me.lblValueHousingCHK = New System.Windows.Forms.Label()
        Me.lblSN = New System.Windows.Forms.Label()
        Me.pnlStartServer = New System.Windows.Forms.Panel()
        Me.layPnlInfo = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblInfoPort1 = New System.Windows.Forms.Label()
        Me.lblInfoPort2 = New System.Windows.Forms.Label()
        Me.lblInfoPort3 = New System.Windows.Forms.Label()
        Me.lblInfoIpAddress = New System.Windows.Forms.Label()
        Me.lblInfoServer = New System.Windows.Forms.Label()
        Me.lblInfoDatabase = New System.Windows.Forms.Label()
        Me.lblTitlePort1 = New System.Windows.Forms.Label()
        Me.lblTitlePort2 = New System.Windows.Forms.Label()
        Me.lblTitlePort3 = New System.Windows.Forms.Label()
        Me.lblTitleIpAddress = New System.Windows.Forms.Label()
        Me.lblTitleServer = New System.Windows.Forms.Label()
        Me.lblTitleDatabase = New System.Windows.Forms.Label()
        Me.lblPort3Status = New System.Windows.Forms.Label()
        Me.lblPort2Status = New System.Windows.Forms.Label()
        Me.lblPort1Status = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.tmStartServerPanel = New System.Windows.Forms.Timer(Me.components)
        CType(Me.dgvNGSN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.msMainMenu.SuspendLayout()
        Me.pnlSidebar.SuspendLayout()
        Me.pnlNavbar.SuspendLayout()
        Me.pnlMainContent.SuspendLayout()
        Me.fpnlRawData.SuspendLayout()
        Me.fnlGroupHKA.SuspendLayout()
        Me.fnlGroupHKC.SuspendLayout()
        Me.fnlGroupHCB.SuspendLayout()
        Me.fnlGroupHCD.SuspendLayout()
        Me.fnlGroupHHKA.SuspendLayout()
        Me.fnlGroupHHKC.SuspendLayout()
        Me.fnlGroupCK.SuspendLayout()
        Me.fnlGroupCC.SuspendLayout()
        Me.fnlGroupCHK.SuspendLayout()
        Me.pnlStartServer.SuspendLayout()
        Me.layPnlInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblFeedbackMode
        '
        Me.lblFeedbackMode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFeedbackMode.AutoSize = True
        Me.lblFeedbackMode.BackColor = System.Drawing.Color.White
        Me.lblFeedbackMode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFeedbackMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblFeedbackMode.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFeedbackMode.Location = New System.Drawing.Point(972, 9)
        Me.lblFeedbackMode.Margin = New System.Windows.Forms.Padding(0)
        Me.lblFeedbackMode.MinimumSize = New System.Drawing.Size(80, 32)
        Me.lblFeedbackMode.Name = "lblFeedbackMode"
        Me.lblFeedbackMode.Size = New System.Drawing.Size(80, 32)
        Me.lblFeedbackMode.TabIndex = 75
        Me.lblFeedbackMode.Text = "FB" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "MODE"
        Me.lblFeedbackMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvNGSN
        '
        Me.dgvNGSN.AllowUserToAddRows = False
        Me.dgvNGSN.AllowUserToDeleteRows = False
        Me.dgvNGSN.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvNGSN.CausesValidation = False
        Me.dgvNGSN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvNGSN.Location = New System.Drawing.Point(35, 369)
        Me.dgvNGSN.Name = "dgvNGSN"
        Me.dgvNGSN.ReadOnly = True
        Me.dgvNGSN.RowHeadersWidth = 62
        Me.dgvNGSN.Size = New System.Drawing.Size(1074, 204)
        Me.dgvNGSN.TabIndex = 75
        '
        'lblApplicationName
        '
        Me.lblApplicationName.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblApplicationName.AutoSize = True
        Me.lblApplicationName.Font = New System.Drawing.Font("Arial", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApplicationName.ForeColor = System.Drawing.Color.White
        Me.lblApplicationName.Location = New System.Drawing.Point(57, 12)
        Me.lblApplicationName.Name = "lblApplicationName"
        Me.lblApplicationName.Size = New System.Drawing.Size(112, 28)
        Me.lblApplicationName.TabIndex = 59
        Me.lblApplicationName.Text = "DRAFT 2"
        '
        'rtxtLog
        '
        Me.rtxtLog.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtxtLog.AutoWordSelection = True
        Me.rtxtLog.BackColor = System.Drawing.Color.White
        Me.rtxtLog.EnableAutoDragDrop = True
        Me.rtxtLog.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtxtLog.Location = New System.Drawing.Point(451, 58)
        Me.rtxtLog.Name = "rtxtLog"
        Me.rtxtLog.ReadOnly = True
        Me.rtxtLog.Size = New System.Drawing.Size(655, 305)
        Me.rtxtLog.TabIndex = 5
        Me.rtxtLog.Text = ""
        '
        'msMainMenu
        '
        Me.msMainMenu.Enabled = False
        Me.msMainMenu.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.msMainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ToolsToolStripMenuItem})
        Me.msMainMenu.Location = New System.Drawing.Point(0, 0)
        Me.msMainMenu.Name = "msMainMenu"
        Me.msMainMenu.Padding = New System.Windows.Forms.Padding(4, 1, 0, 1)
        Me.msMainMenu.Size = New System.Drawing.Size(1109, 24)
        Me.msMainMenu.TabIndex = 1
        Me.msMainMenu.Text = "MenuStrip1"
        Me.msMainMenu.Visible = False
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 22)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(93, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingsToolStripMenuItem, Me.DebugToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(46, 22)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'DebugToolStripMenuItem
        '
        Me.DebugToolStripMenuItem.Name = "DebugToolStripMenuItem"
        Me.DebugToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.DebugToolStripMenuItem.Text = "Debug"
        '
        'bgtPort1
        '
        '
        'bgtPort2
        '
        '
        'bgtPort3
        '
        '
        'Port1Timer
        '
        Me.Port1Timer.Interval = 1000
        '
        'bgtStartingServer
        '
        '
        'pnlSidebar
        '
        Me.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.pnlSidebar.Controls.Add(Me.btnStartServer)
        Me.pnlSidebar.Controls.Add(Me.btnSetting)
        Me.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSidebar.Location = New System.Drawing.Point(0, 0)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Size = New System.Drawing.Size(35, 573)
        Me.pnlSidebar.TabIndex = 80
        '
        'btnStartServer
        '
        Me.btnStartServer.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btnStartServer.FlatAppearance.BorderSize = 0
        Me.btnStartServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStartServer.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStartServer.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnStartServer.Image = Global.PLCAutoCalculation.My.Resources.Resources.play
        Me.btnStartServer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStartServer.Location = New System.Drawing.Point(0, 83)
        Me.btnStartServer.Name = "btnStartServer"
        Me.btnStartServer.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnStartServer.Size = New System.Drawing.Size(205, 50)
        Me.btnStartServer.TabIndex = 3
        Me.btnStartServer.Text = "  Start"
        Me.btnStartServer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStartServer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnStartServer.UseVisualStyleBackColor = False
        '
        'btnSetting
        '
        Me.btnSetting.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btnSetting.FlatAppearance.BorderSize = 0
        Me.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSetting.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSetting.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnSetting.Image = CType(resources.GetObject("btnSetting.Image"), System.Drawing.Image)
        Me.btnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSetting.Location = New System.Drawing.Point(0, 139)
        Me.btnSetting.Name = "btnSetting"
        Me.btnSetting.Size = New System.Drawing.Size(205, 50)
        Me.btnSetting.TabIndex = 82
        Me.btnSetting.Text = "  Settings"
        Me.btnSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSetting.UseVisualStyleBackColor = False
        '
        'pnlNavbar
        '
        Me.pnlNavbar.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.pnlNavbar.Controls.Add(Me.btnHamburgerMenu)
        Me.pnlNavbar.Controls.Add(Me.lblApplicationName)
        Me.pnlNavbar.Controls.Add(Me.lblMode)
        Me.pnlNavbar.Controls.Add(Me.lblFeedbackMode)
        Me.pnlNavbar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlNavbar.Location = New System.Drawing.Point(35, 0)
        Me.pnlNavbar.Name = "pnlNavbar"
        Me.pnlNavbar.Size = New System.Drawing.Size(1074, 52)
        Me.pnlNavbar.TabIndex = 81
        '
        'btnHamburgerMenu
        '
        Me.btnHamburgerMenu.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnHamburgerMenu.BackColor = System.Drawing.Color.Transparent
        Me.btnHamburgerMenu.FlatAppearance.BorderSize = 0
        Me.btnHamburgerMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHamburgerMenu.Image = CType(resources.GetObject("btnHamburgerMenu.Image"), System.Drawing.Image)
        Me.btnHamburgerMenu.Location = New System.Drawing.Point(6, 5)
        Me.btnHamburgerMenu.Name = "btnHamburgerMenu"
        Me.btnHamburgerMenu.Size = New System.Drawing.Size(50, 43)
        Me.btnHamburgerMenu.TabIndex = 82
        Me.btnHamburgerMenu.UseVisualStyleBackColor = False
        '
        'lblMode
        '
        Me.lblMode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMode.AutoSize = True
        Me.lblMode.BackColor = System.Drawing.Color.White
        Me.lblMode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblMode.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMode.Location = New System.Drawing.Point(878, 8)
        Me.lblMode.Margin = New System.Windows.Forms.Padding(0)
        Me.lblMode.MinimumSize = New System.Drawing.Size(80, 32)
        Me.lblMode.Name = "lblMode"
        Me.lblMode.Size = New System.Drawing.Size(80, 32)
        Me.lblMode.TabIndex = 9
        Me.lblMode.Text = "MODE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "NAME"
        Me.lblMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tmSidebarOpen
        '
        Me.tmSidebarOpen.Interval = 1
        '
        'tmSidebarClose
        '
        Me.tmSidebarClose.Interval = 1
        '
        'pnlMainContent
        '
        Me.pnlMainContent.Controls.Add(Me.fpnlRawData)
        Me.pnlMainContent.Controls.Add(Me.lblSN)
        Me.pnlMainContent.Controls.Add(Me.rtxtLog)
        Me.pnlMainContent.Controls.Add(Me.dgvNGSN)
        Me.pnlMainContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMainContent.Location = New System.Drawing.Point(0, 0)
        Me.pnlMainContent.Name = "pnlMainContent"
        Me.pnlMainContent.Size = New System.Drawing.Size(1109, 573)
        Me.pnlMainContent.TabIndex = 82
        '
        'fpnlRawData
        '
        Me.fpnlRawData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fpnlRawData.AutoScroll = True
        Me.fpnlRawData.BackColor = System.Drawing.Color.Transparent
        Me.fpnlRawData.Controls.Add(Me.fnlGroupHKA)
        Me.fpnlRawData.Controls.Add(Me.fnlGroupHKC)
        Me.fpnlRawData.Controls.Add(Me.fnlGroupHCB)
        Me.fpnlRawData.Controls.Add(Me.fnlGroupHCD)
        Me.fpnlRawData.Controls.Add(Me.fnlGroupHHKA)
        Me.fpnlRawData.Controls.Add(Me.fnlGroupHHKC)
        Me.fpnlRawData.Controls.Add(Me.fnlGroupCK)
        Me.fpnlRawData.Controls.Add(Me.fnlGroupCC)
        Me.fpnlRawData.Controls.Add(Me.fnlGroupCHK)
        Me.fpnlRawData.Location = New System.Drawing.Point(41, 117)
        Me.fpnlRawData.Name = "fpnlRawData"
        Me.fpnlRawData.Size = New System.Drawing.Size(372, 246)
        Me.fpnlRawData.TabIndex = 78
        '
        'fnlGroupHKA
        '
        Me.fnlGroupHKA.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.fnlGroupHKA.Controls.Add(Me.lblTitleHousingKA)
        Me.fnlGroupHKA.Controls.Add(Me.lblValueHousingKA)
        Me.fnlGroupHKA.Location = New System.Drawing.Point(3, 3)
        Me.fnlGroupHKA.Name = "fnlGroupHKA"
        Me.fnlGroupHKA.Size = New System.Drawing.Size(117, 73)
        Me.fnlGroupHKA.TabIndex = 79
        '
        'lblTitleHousingKA
        '
        Me.lblTitleHousingKA.AutoSize = True
        Me.lblTitleHousingKA.BackColor = System.Drawing.Color.Transparent
        Me.lblTitleHousingKA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTitleHousingKA.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleHousingKA.Location = New System.Drawing.Point(3, 0)
        Me.lblTitleHousingKA.MaximumSize = New System.Drawing.Size(110, 0)
        Me.lblTitleHousingKA.MinimumSize = New System.Drawing.Size(110, 0)
        Me.lblTitleHousingKA.Name = "lblTitleHousingKA"
        Me.lblTitleHousingKA.Padding = New System.Windows.Forms.Padding(15, 5, 15, 5)
        Me.lblTitleHousingKA.Size = New System.Drawing.Size(110, 23)
        Me.lblTitleHousingKA.TabIndex = 78
        Me.lblTitleHousingKA.Text = "HousingK(A)"
        Me.lblTitleHousingKA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblValueHousingKA
        '
        Me.lblValueHousingKA.AutoSize = True
        Me.lblValueHousingKA.BackColor = System.Drawing.Color.White
        Me.lblValueHousingKA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblValueHousingKA.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValueHousingKA.Location = New System.Drawing.Point(3, 23)
        Me.lblValueHousingKA.MaximumSize = New System.Drawing.Size(110, 0)
        Me.lblValueHousingKA.MinimumSize = New System.Drawing.Size(110, 0)
        Me.lblValueHousingKA.Name = "lblValueHousingKA"
        Me.lblValueHousingKA.Padding = New System.Windows.Forms.Padding(10)
        Me.lblValueHousingKA.Size = New System.Drawing.Size(110, 41)
        Me.lblValueHousingKA.TabIndex = 79
        Me.lblValueHousingKA.Text = "13.4567"
        Me.lblValueHousingKA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'fnlGroupHKC
        '
        Me.fnlGroupHKC.Controls.Add(Me.lblTitleHousingKC)
        Me.fnlGroupHKC.Controls.Add(Me.lblValueHousingKC)
        Me.fnlGroupHKC.Location = New System.Drawing.Point(126, 3)
        Me.fnlGroupHKC.Name = "fnlGroupHKC"
        Me.fnlGroupHKC.Size = New System.Drawing.Size(117, 73)
        Me.fnlGroupHKC.TabIndex = 80
        '
        'lblTitleHousingKC
        '
        Me.lblTitleHousingKC.AutoSize = True
        Me.lblTitleHousingKC.BackColor = System.Drawing.Color.Transparent
        Me.lblTitleHousingKC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTitleHousingKC.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleHousingKC.Location = New System.Drawing.Point(3, 0)
        Me.lblTitleHousingKC.MaximumSize = New System.Drawing.Size(110, 0)
        Me.lblTitleHousingKC.MinimumSize = New System.Drawing.Size(110, 0)
        Me.lblTitleHousingKC.Name = "lblTitleHousingKC"
        Me.lblTitleHousingKC.Padding = New System.Windows.Forms.Padding(15, 5, 15, 5)
        Me.lblTitleHousingKC.Size = New System.Drawing.Size(110, 23)
        Me.lblTitleHousingKC.TabIndex = 78
        Me.lblTitleHousingKC.Text = "HousingK(C)"
        Me.lblTitleHousingKC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblValueHousingKC
        '
        Me.lblValueHousingKC.AutoSize = True
        Me.lblValueHousingKC.BackColor = System.Drawing.Color.White
        Me.lblValueHousingKC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblValueHousingKC.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValueHousingKC.Location = New System.Drawing.Point(3, 23)
        Me.lblValueHousingKC.MaximumSize = New System.Drawing.Size(110, 0)
        Me.lblValueHousingKC.MinimumSize = New System.Drawing.Size(110, 0)
        Me.lblValueHousingKC.Name = "lblValueHousingKC"
        Me.lblValueHousingKC.Padding = New System.Windows.Forms.Padding(10)
        Me.lblValueHousingKC.Size = New System.Drawing.Size(110, 41)
        Me.lblValueHousingKC.TabIndex = 79
        Me.lblValueHousingKC.Text = "13.4567"
        Me.lblValueHousingKC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'fnlGroupHCB
        '
        Me.fnlGroupHCB.Controls.Add(Me.lblTitleHousingCB)
        Me.fnlGroupHCB.Controls.Add(Me.lblValueHousingCB)
        Me.fnlGroupHCB.Location = New System.Drawing.Point(249, 3)
        Me.fnlGroupHCB.Name = "fnlGroupHCB"
        Me.fnlGroupHCB.Size = New System.Drawing.Size(117, 73)
        Me.fnlGroupHCB.TabIndex = 81
        '
        'lblTitleHousingCB
        '
        Me.lblTitleHousingCB.AutoSize = True
        Me.lblTitleHousingCB.BackColor = System.Drawing.Color.Transparent
        Me.lblTitleHousingCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTitleHousingCB.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleHousingCB.Location = New System.Drawing.Point(3, 0)
        Me.lblTitleHousingCB.MaximumSize = New System.Drawing.Size(110, 0)
        Me.lblTitleHousingCB.MinimumSize = New System.Drawing.Size(110, 0)
        Me.lblTitleHousingCB.Name = "lblTitleHousingCB"
        Me.lblTitleHousingCB.Padding = New System.Windows.Forms.Padding(15, 5, 15, 5)
        Me.lblTitleHousingCB.Size = New System.Drawing.Size(110, 23)
        Me.lblTitleHousingCB.TabIndex = 78
        Me.lblTitleHousingCB.Text = "HousingC(B)"
        Me.lblTitleHousingCB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblValueHousingCB
        '
        Me.lblValueHousingCB.AutoSize = True
        Me.lblValueHousingCB.BackColor = System.Drawing.Color.White
        Me.lblValueHousingCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblValueHousingCB.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValueHousingCB.Location = New System.Drawing.Point(3, 23)
        Me.lblValueHousingCB.MaximumSize = New System.Drawing.Size(110, 0)
        Me.lblValueHousingCB.MinimumSize = New System.Drawing.Size(110, 0)
        Me.lblValueHousingCB.Name = "lblValueHousingCB"
        Me.lblValueHousingCB.Padding = New System.Windows.Forms.Padding(10)
        Me.lblValueHousingCB.Size = New System.Drawing.Size(110, 41)
        Me.lblValueHousingCB.TabIndex = 79
        Me.lblValueHousingCB.Text = "13.4567"
        Me.lblValueHousingCB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'fnlGroupHCD
        '
        Me.fnlGroupHCD.Controls.Add(Me.lblTitleHousingCD)
        Me.fnlGroupHCD.Controls.Add(Me.lblValueHousingCD)
        Me.fnlGroupHCD.Location = New System.Drawing.Point(3, 82)
        Me.fnlGroupHCD.Name = "fnlGroupHCD"
        Me.fnlGroupHCD.Size = New System.Drawing.Size(117, 73)
        Me.fnlGroupHCD.TabIndex = 82
        '
        'lblTitleHousingCD
        '
        Me.lblTitleHousingCD.AutoSize = True
        Me.lblTitleHousingCD.BackColor = System.Drawing.Color.Transparent
        Me.lblTitleHousingCD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTitleHousingCD.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleHousingCD.Location = New System.Drawing.Point(3, 0)
        Me.lblTitleHousingCD.MaximumSize = New System.Drawing.Size(110, 0)
        Me.lblTitleHousingCD.MinimumSize = New System.Drawing.Size(110, 0)
        Me.lblTitleHousingCD.Name = "lblTitleHousingCD"
        Me.lblTitleHousingCD.Padding = New System.Windows.Forms.Padding(15, 5, 15, 5)
        Me.lblTitleHousingCD.Size = New System.Drawing.Size(110, 23)
        Me.lblTitleHousingCD.TabIndex = 78
        Me.lblTitleHousingCD.Text = "HousingC(D)"
        Me.lblTitleHousingCD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblValueHousingCD
        '
        Me.lblValueHousingCD.AutoSize = True
        Me.lblValueHousingCD.BackColor = System.Drawing.Color.White
        Me.lblValueHousingCD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblValueHousingCD.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValueHousingCD.Location = New System.Drawing.Point(3, 23)
        Me.lblValueHousingCD.MaximumSize = New System.Drawing.Size(110, 0)
        Me.lblValueHousingCD.MinimumSize = New System.Drawing.Size(110, 0)
        Me.lblValueHousingCD.Name = "lblValueHousingCD"
        Me.lblValueHousingCD.Padding = New System.Windows.Forms.Padding(10)
        Me.lblValueHousingCD.Size = New System.Drawing.Size(110, 41)
        Me.lblValueHousingCD.TabIndex = 79
        Me.lblValueHousingCD.Text = "13.4567"
        Me.lblValueHousingCD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'fnlGroupHHKA
        '
        Me.fnlGroupHHKA.Controls.Add(Me.lblTitleHousingHKA)
        Me.fnlGroupHHKA.Controls.Add(Me.lblValueHousingHKA)
        Me.fnlGroupHHKA.Location = New System.Drawing.Point(126, 82)
        Me.fnlGroupHHKA.Name = "fnlGroupHHKA"
        Me.fnlGroupHHKA.Size = New System.Drawing.Size(117, 73)
        Me.fnlGroupHHKA.TabIndex = 83
        '
        'lblTitleHousingHKA
        '
        Me.lblTitleHousingHKA.AutoSize = True
        Me.lblTitleHousingHKA.BackColor = System.Drawing.Color.Transparent
        Me.lblTitleHousingHKA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTitleHousingHKA.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleHousingHKA.Location = New System.Drawing.Point(3, 0)
        Me.lblTitleHousingHKA.MaximumSize = New System.Drawing.Size(110, 0)
        Me.lblTitleHousingHKA.MinimumSize = New System.Drawing.Size(110, 0)
        Me.lblTitleHousingHKA.Name = "lblTitleHousingHKA"
        Me.lblTitleHousingHKA.Padding = New System.Windows.Forms.Padding(15, 5, 15, 5)
        Me.lblTitleHousingHKA.Size = New System.Drawing.Size(110, 23)
        Me.lblTitleHousingHKA.TabIndex = 78
        Me.lblTitleHousingHKA.Text = "HousingHK(A)"
        Me.lblTitleHousingHKA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblValueHousingHKA
        '
        Me.lblValueHousingHKA.AutoSize = True
        Me.lblValueHousingHKA.BackColor = System.Drawing.Color.White
        Me.lblValueHousingHKA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblValueHousingHKA.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValueHousingHKA.Location = New System.Drawing.Point(3, 23)
        Me.lblValueHousingHKA.MaximumSize = New System.Drawing.Size(110, 0)
        Me.lblValueHousingHKA.MinimumSize = New System.Drawing.Size(110, 0)
        Me.lblValueHousingHKA.Name = "lblValueHousingHKA"
        Me.lblValueHousingHKA.Padding = New System.Windows.Forms.Padding(10)
        Me.lblValueHousingHKA.Size = New System.Drawing.Size(110, 41)
        Me.lblValueHousingHKA.TabIndex = 79
        Me.lblValueHousingHKA.Text = "13.4567"
        Me.lblValueHousingHKA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'fnlGroupHHKC
        '
        Me.fnlGroupHHKC.Controls.Add(Me.lblTitleHousingHKC)
        Me.fnlGroupHHKC.Controls.Add(Me.lblValueHousingHKC)
        Me.fnlGroupHHKC.Location = New System.Drawing.Point(249, 82)
        Me.fnlGroupHHKC.Name = "fnlGroupHHKC"
        Me.fnlGroupHHKC.Size = New System.Drawing.Size(117, 73)
        Me.fnlGroupHHKC.TabIndex = 84
        '
        'lblTitleHousingHKC
        '
        Me.lblTitleHousingHKC.AutoSize = True
        Me.lblTitleHousingHKC.BackColor = System.Drawing.Color.Transparent
        Me.lblTitleHousingHKC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTitleHousingHKC.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleHousingHKC.Location = New System.Drawing.Point(3, 0)
        Me.lblTitleHousingHKC.MaximumSize = New System.Drawing.Size(110, 0)
        Me.lblTitleHousingHKC.MinimumSize = New System.Drawing.Size(110, 0)
        Me.lblTitleHousingHKC.Name = "lblTitleHousingHKC"
        Me.lblTitleHousingHKC.Padding = New System.Windows.Forms.Padding(15, 5, 15, 5)
        Me.lblTitleHousingHKC.Size = New System.Drawing.Size(110, 23)
        Me.lblTitleHousingHKC.TabIndex = 78
        Me.lblTitleHousingHKC.Text = "HousingHK(C)"
        Me.lblTitleHousingHKC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblValueHousingHKC
        '
        Me.lblValueHousingHKC.AutoSize = True
        Me.lblValueHousingHKC.BackColor = System.Drawing.Color.White
        Me.lblValueHousingHKC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblValueHousingHKC.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValueHousingHKC.Location = New System.Drawing.Point(3, 23)
        Me.lblValueHousingHKC.MaximumSize = New System.Drawing.Size(110, 0)
        Me.lblValueHousingHKC.MinimumSize = New System.Drawing.Size(110, 0)
        Me.lblValueHousingHKC.Name = "lblValueHousingHKC"
        Me.lblValueHousingHKC.Padding = New System.Windows.Forms.Padding(10)
        Me.lblValueHousingHKC.Size = New System.Drawing.Size(110, 41)
        Me.lblValueHousingHKC.TabIndex = 79
        Me.lblValueHousingHKC.Text = "13.4567"
        Me.lblValueHousingHKC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'fnlGroupCK
        '
        Me.fnlGroupCK.Controls.Add(Me.lblTitleHousingCK)
        Me.fnlGroupCK.Controls.Add(Me.lblValueHousingCK)
        Me.fnlGroupCK.Location = New System.Drawing.Point(3, 161)
        Me.fnlGroupCK.Name = "fnlGroupCK"
        Me.fnlGroupCK.Size = New System.Drawing.Size(117, 73)
        Me.fnlGroupCK.TabIndex = 85
        '
        'lblTitleHousingCK
        '
        Me.lblTitleHousingCK.AutoSize = True
        Me.lblTitleHousingCK.BackColor = System.Drawing.Color.Transparent
        Me.lblTitleHousingCK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTitleHousingCK.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleHousingCK.Location = New System.Drawing.Point(3, 0)
        Me.lblTitleHousingCK.MaximumSize = New System.Drawing.Size(110, 0)
        Me.lblTitleHousingCK.MinimumSize = New System.Drawing.Size(110, 0)
        Me.lblTitleHousingCK.Name = "lblTitleHousingCK"
        Me.lblTitleHousingCK.Padding = New System.Windows.Forms.Padding(15, 5, 15, 5)
        Me.lblTitleHousingCK.Size = New System.Drawing.Size(110, 23)
        Me.lblTitleHousingCK.TabIndex = 78
        Me.lblTitleHousingCK.Text = "CLB K"
        Me.lblTitleHousingCK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblValueHousingCK
        '
        Me.lblValueHousingCK.AutoSize = True
        Me.lblValueHousingCK.BackColor = System.Drawing.Color.White
        Me.lblValueHousingCK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblValueHousingCK.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValueHousingCK.Location = New System.Drawing.Point(3, 23)
        Me.lblValueHousingCK.MaximumSize = New System.Drawing.Size(110, 0)
        Me.lblValueHousingCK.MinimumSize = New System.Drawing.Size(110, 0)
        Me.lblValueHousingCK.Name = "lblValueHousingCK"
        Me.lblValueHousingCK.Padding = New System.Windows.Forms.Padding(10)
        Me.lblValueHousingCK.Size = New System.Drawing.Size(110, 41)
        Me.lblValueHousingCK.TabIndex = 79
        Me.lblValueHousingCK.Text = "13.4567"
        Me.lblValueHousingCK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'fnlGroupCC
        '
        Me.fnlGroupCC.Controls.Add(Me.lblTitleHousingCC)
        Me.fnlGroupCC.Controls.Add(Me.lblValueHousingCC)
        Me.fnlGroupCC.Location = New System.Drawing.Point(126, 161)
        Me.fnlGroupCC.Name = "fnlGroupCC"
        Me.fnlGroupCC.Size = New System.Drawing.Size(117, 73)
        Me.fnlGroupCC.TabIndex = 86
        '
        'lblTitleHousingCC
        '
        Me.lblTitleHousingCC.AutoSize = True
        Me.lblTitleHousingCC.BackColor = System.Drawing.Color.Transparent
        Me.lblTitleHousingCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTitleHousingCC.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleHousingCC.Location = New System.Drawing.Point(3, 0)
        Me.lblTitleHousingCC.MaximumSize = New System.Drawing.Size(110, 0)
        Me.lblTitleHousingCC.MinimumSize = New System.Drawing.Size(110, 0)
        Me.lblTitleHousingCC.Name = "lblTitleHousingCC"
        Me.lblTitleHousingCC.Padding = New System.Windows.Forms.Padding(15, 5, 15, 5)
        Me.lblTitleHousingCC.Size = New System.Drawing.Size(110, 23)
        Me.lblTitleHousingCC.TabIndex = 78
        Me.lblTitleHousingCC.Text = "CLB C"
        Me.lblTitleHousingCC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblValueHousingCC
        '
        Me.lblValueHousingCC.AutoSize = True
        Me.lblValueHousingCC.BackColor = System.Drawing.Color.White
        Me.lblValueHousingCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblValueHousingCC.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValueHousingCC.Location = New System.Drawing.Point(3, 23)
        Me.lblValueHousingCC.MaximumSize = New System.Drawing.Size(110, 0)
        Me.lblValueHousingCC.MinimumSize = New System.Drawing.Size(110, 0)
        Me.lblValueHousingCC.Name = "lblValueHousingCC"
        Me.lblValueHousingCC.Padding = New System.Windows.Forms.Padding(10)
        Me.lblValueHousingCC.Size = New System.Drawing.Size(110, 41)
        Me.lblValueHousingCC.TabIndex = 79
        Me.lblValueHousingCC.Text = "13.4567"
        Me.lblValueHousingCC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'fnlGroupCHK
        '
        Me.fnlGroupCHK.Controls.Add(Me.lblTitleHousingCHK)
        Me.fnlGroupCHK.Controls.Add(Me.lblValueHousingCHK)
        Me.fnlGroupCHK.Location = New System.Drawing.Point(249, 161)
        Me.fnlGroupCHK.Name = "fnlGroupCHK"
        Me.fnlGroupCHK.Size = New System.Drawing.Size(117, 73)
        Me.fnlGroupCHK.TabIndex = 87
        '
        'lblTitleHousingCHK
        '
        Me.lblTitleHousingCHK.AutoSize = True
        Me.lblTitleHousingCHK.BackColor = System.Drawing.Color.Transparent
        Me.lblTitleHousingCHK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTitleHousingCHK.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleHousingCHK.Location = New System.Drawing.Point(3, 0)
        Me.lblTitleHousingCHK.MaximumSize = New System.Drawing.Size(110, 0)
        Me.lblTitleHousingCHK.MinimumSize = New System.Drawing.Size(110, 0)
        Me.lblTitleHousingCHK.Name = "lblTitleHousingCHK"
        Me.lblTitleHousingCHK.Padding = New System.Windows.Forms.Padding(15, 5, 15, 5)
        Me.lblTitleHousingCHK.Size = New System.Drawing.Size(110, 23)
        Me.lblTitleHousingCHK.TabIndex = 78
        Me.lblTitleHousingCHK.Text = "CLB HK"
        Me.lblTitleHousingCHK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblValueHousingCHK
        '
        Me.lblValueHousingCHK.AutoSize = True
        Me.lblValueHousingCHK.BackColor = System.Drawing.Color.White
        Me.lblValueHousingCHK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblValueHousingCHK.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValueHousingCHK.Location = New System.Drawing.Point(3, 23)
        Me.lblValueHousingCHK.MaximumSize = New System.Drawing.Size(110, 0)
        Me.lblValueHousingCHK.MinimumSize = New System.Drawing.Size(110, 0)
        Me.lblValueHousingCHK.Name = "lblValueHousingCHK"
        Me.lblValueHousingCHK.Padding = New System.Windows.Forms.Padding(10)
        Me.lblValueHousingCHK.Size = New System.Drawing.Size(110, 41)
        Me.lblValueHousingCHK.TabIndex = 79
        Me.lblValueHousingCHK.Text = "13.4567"
        Me.lblValueHousingCHK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSN
        '
        Me.lblSN.AutoSize = True
        Me.lblSN.BackColor = System.Drawing.Color.White
        Me.lblSN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSN.Font = New System.Drawing.Font("Segoe UI Semibold", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSN.Location = New System.Drawing.Point(45, 55)
        Me.lblSN.Name = "lblSN"
        Me.lblSN.Padding = New System.Windows.Forms.Padding(10)
        Me.lblSN.Size = New System.Drawing.Size(303, 57)
        Me.lblSN.TabIndex = 77
        Me.lblSN.Text = "AA2JXXXXXXXXXXXX"
        Me.lblSN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlStartServer
        '
        Me.pnlStartServer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlStartServer.BackColor = System.Drawing.SystemColors.Control
        Me.pnlStartServer.Controls.Add(Me.layPnlInfo)
        Me.pnlStartServer.Controls.Add(Me.lblPort3Status)
        Me.pnlStartServer.Controls.Add(Me.lblPort2Status)
        Me.pnlStartServer.Controls.Add(Me.lblPort1Status)
        Me.pnlStartServer.Controls.Add(Me.btnStart)
        Me.pnlStartServer.Location = New System.Drawing.Point(0, 0)
        Me.pnlStartServer.Name = "pnlStartServer"
        Me.pnlStartServer.Size = New System.Drawing.Size(1109, 598)
        Me.pnlStartServer.TabIndex = 80
        '
        'layPnlInfo
        '
        Me.layPnlInfo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.layPnlInfo.Controls.Add(Me.lblInfoPort1)
        Me.layPnlInfo.Controls.Add(Me.lblInfoPort2)
        Me.layPnlInfo.Controls.Add(Me.lblInfoPort3)
        Me.layPnlInfo.Controls.Add(Me.lblInfoIpAddress)
        Me.layPnlInfo.Controls.Add(Me.lblInfoServer)
        Me.layPnlInfo.Controls.Add(Me.lblInfoDatabase)
        Me.layPnlInfo.Controls.Add(Me.lblTitlePort1)
        Me.layPnlInfo.Controls.Add(Me.lblTitlePort2)
        Me.layPnlInfo.Controls.Add(Me.lblTitlePort3)
        Me.layPnlInfo.Controls.Add(Me.lblTitleIpAddress)
        Me.layPnlInfo.Controls.Add(Me.lblTitleServer)
        Me.layPnlInfo.Controls.Add(Me.lblTitleDatabase)
        Me.layPnlInfo.Location = New System.Drawing.Point(35, 58)
        Me.layPnlInfo.Name = "layPnlInfo"
        Me.layPnlInfo.Size = New System.Drawing.Size(1071, 97)
        Me.layPnlInfo.TabIndex = 4
        '
        'lblInfoPort1
        '
        Me.lblInfoPort1.AutoSize = True
        Me.lblInfoPort1.BackColor = System.Drawing.Color.White
        Me.lblInfoPort1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblInfoPort1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfoPort1.Location = New System.Drawing.Point(10, 10)
        Me.lblInfoPort1.Margin = New System.Windows.Forms.Padding(10)
        Me.lblInfoPort1.MinimumSize = New System.Drawing.Size(157, 40)
        Me.lblInfoPort1.Name = "lblInfoPort1"
        Me.lblInfoPort1.Size = New System.Drawing.Size(157, 40)
        Me.lblInfoPort1.TabIndex = 0
        Me.lblInfoPort1.Text = "Port1"
        Me.lblInfoPort1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblInfoPort2
        '
        Me.lblInfoPort2.AutoSize = True
        Me.lblInfoPort2.BackColor = System.Drawing.Color.White
        Me.lblInfoPort2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblInfoPort2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfoPort2.Location = New System.Drawing.Point(187, 10)
        Me.lblInfoPort2.Margin = New System.Windows.Forms.Padding(10)
        Me.lblInfoPort2.MinimumSize = New System.Drawing.Size(157, 40)
        Me.lblInfoPort2.Name = "lblInfoPort2"
        Me.lblInfoPort2.Size = New System.Drawing.Size(157, 40)
        Me.lblInfoPort2.TabIndex = 1
        Me.lblInfoPort2.Text = "Port2"
        Me.lblInfoPort2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblInfoPort3
        '
        Me.lblInfoPort3.AutoSize = True
        Me.lblInfoPort3.BackColor = System.Drawing.Color.White
        Me.lblInfoPort3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblInfoPort3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfoPort3.Location = New System.Drawing.Point(364, 10)
        Me.lblInfoPort3.Margin = New System.Windows.Forms.Padding(10)
        Me.lblInfoPort3.MinimumSize = New System.Drawing.Size(157, 40)
        Me.lblInfoPort3.Name = "lblInfoPort3"
        Me.lblInfoPort3.Size = New System.Drawing.Size(157, 40)
        Me.lblInfoPort3.TabIndex = 2
        Me.lblInfoPort3.Text = "Port3"
        Me.lblInfoPort3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblInfoIpAddress
        '
        Me.lblInfoIpAddress.AutoSize = True
        Me.lblInfoIpAddress.BackColor = System.Drawing.Color.White
        Me.lblInfoIpAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblInfoIpAddress.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfoIpAddress.Location = New System.Drawing.Point(541, 10)
        Me.lblInfoIpAddress.Margin = New System.Windows.Forms.Padding(10)
        Me.lblInfoIpAddress.MinimumSize = New System.Drawing.Size(157, 40)
        Me.lblInfoIpAddress.Name = "lblInfoIpAddress"
        Me.lblInfoIpAddress.Size = New System.Drawing.Size(157, 40)
        Me.lblInfoIpAddress.TabIndex = 3
        Me.lblInfoIpAddress.Text = "IPAddress"
        Me.lblInfoIpAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblInfoServer
        '
        Me.lblInfoServer.AutoSize = True
        Me.lblInfoServer.BackColor = System.Drawing.Color.White
        Me.lblInfoServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblInfoServer.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfoServer.Location = New System.Drawing.Point(718, 10)
        Me.lblInfoServer.Margin = New System.Windows.Forms.Padding(10)
        Me.lblInfoServer.MinimumSize = New System.Drawing.Size(157, 40)
        Me.lblInfoServer.Name = "lblInfoServer"
        Me.lblInfoServer.Size = New System.Drawing.Size(157, 40)
        Me.lblInfoServer.TabIndex = 8
        Me.lblInfoServer.Text = "Server"
        Me.lblInfoServer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblInfoDatabase
        '
        Me.lblInfoDatabase.AutoSize = True
        Me.lblInfoDatabase.BackColor = System.Drawing.Color.White
        Me.lblInfoDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblInfoDatabase.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfoDatabase.Location = New System.Drawing.Point(895, 10)
        Me.lblInfoDatabase.Margin = New System.Windows.Forms.Padding(10)
        Me.lblInfoDatabase.MinimumSize = New System.Drawing.Size(157, 40)
        Me.lblInfoDatabase.Name = "lblInfoDatabase"
        Me.lblInfoDatabase.Size = New System.Drawing.Size(157, 40)
        Me.lblInfoDatabase.TabIndex = 9
        Me.lblInfoDatabase.Text = "Database"
        Me.lblInfoDatabase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTitlePort1
        '
        Me.lblTitlePort1.AutoSize = True
        Me.lblTitlePort1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitlePort1.Location = New System.Drawing.Point(10, 60)
        Me.lblTitlePort1.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.lblTitlePort1.MinimumSize = New System.Drawing.Size(157, 0)
        Me.lblTitlePort1.Name = "lblTitlePort1"
        Me.lblTitlePort1.Size = New System.Drawing.Size(157, 15)
        Me.lblTitlePort1.TabIndex = 4
        Me.lblTitlePort1.Text = "Port 1"
        Me.lblTitlePort1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTitlePort2
        '
        Me.lblTitlePort2.AutoSize = True
        Me.lblTitlePort2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitlePort2.Location = New System.Drawing.Point(187, 60)
        Me.lblTitlePort2.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.lblTitlePort2.MinimumSize = New System.Drawing.Size(157, 0)
        Me.lblTitlePort2.Name = "lblTitlePort2"
        Me.lblTitlePort2.Size = New System.Drawing.Size(157, 15)
        Me.lblTitlePort2.TabIndex = 5
        Me.lblTitlePort2.Text = "Port 2"
        Me.lblTitlePort2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTitlePort3
        '
        Me.lblTitlePort3.AutoSize = True
        Me.lblTitlePort3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitlePort3.Location = New System.Drawing.Point(364, 60)
        Me.lblTitlePort3.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.lblTitlePort3.MinimumSize = New System.Drawing.Size(157, 0)
        Me.lblTitlePort3.Name = "lblTitlePort3"
        Me.lblTitlePort3.Size = New System.Drawing.Size(157, 15)
        Me.lblTitlePort3.TabIndex = 6
        Me.lblTitlePort3.Text = "Port 3"
        Me.lblTitlePort3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTitleIpAddress
        '
        Me.lblTitleIpAddress.AutoSize = True
        Me.lblTitleIpAddress.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleIpAddress.Location = New System.Drawing.Point(541, 60)
        Me.lblTitleIpAddress.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.lblTitleIpAddress.MinimumSize = New System.Drawing.Size(157, 0)
        Me.lblTitleIpAddress.Name = "lblTitleIpAddress"
        Me.lblTitleIpAddress.Size = New System.Drawing.Size(157, 15)
        Me.lblTitleIpAddress.TabIndex = 7
        Me.lblTitleIpAddress.Text = "IP Address"
        Me.lblTitleIpAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTitleServer
        '
        Me.lblTitleServer.AutoSize = True
        Me.lblTitleServer.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleServer.Location = New System.Drawing.Point(718, 60)
        Me.lblTitleServer.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.lblTitleServer.MinimumSize = New System.Drawing.Size(157, 0)
        Me.lblTitleServer.Name = "lblTitleServer"
        Me.lblTitleServer.Size = New System.Drawing.Size(157, 15)
        Me.lblTitleServer.TabIndex = 10
        Me.lblTitleServer.Text = "Server"
        Me.lblTitleServer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTitleDatabase
        '
        Me.lblTitleDatabase.AutoSize = True
        Me.lblTitleDatabase.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleDatabase.Location = New System.Drawing.Point(895, 60)
        Me.lblTitleDatabase.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.lblTitleDatabase.MinimumSize = New System.Drawing.Size(157, 0)
        Me.lblTitleDatabase.Name = "lblTitleDatabase"
        Me.lblTitleDatabase.Size = New System.Drawing.Size(157, 15)
        Me.lblTitleDatabase.TabIndex = 11
        Me.lblTitleDatabase.Text = "Database"
        Me.lblTitleDatabase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPort3Status
        '
        Me.lblPort3Status.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblPort3Status.AutoSize = True
        Me.lblPort3Status.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPort3Status.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.lblPort3Status.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblPort3Status.Location = New System.Drawing.Point(432, 523)
        Me.lblPort3Status.MinimumSize = New System.Drawing.Size(280, 0)
        Me.lblPort3Status.Name = "lblPort3Status"
        Me.lblPort3Status.Padding = New System.Windows.Forms.Padding(3)
        Me.lblPort3Status.Size = New System.Drawing.Size(280, 27)
        Me.lblPort3Status.TabIndex = 3
        Me.lblPort3Status.Text = "...waiting client to connect Port 3..."
        Me.lblPort3Status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblPort3Status.Visible = False
        '
        'lblPort2Status
        '
        Me.lblPort2Status.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblPort2Status.AutoSize = True
        Me.lblPort2Status.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPort2Status.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.lblPort2Status.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblPort2Status.Location = New System.Drawing.Point(432, 490)
        Me.lblPort2Status.MinimumSize = New System.Drawing.Size(280, 0)
        Me.lblPort2Status.Name = "lblPort2Status"
        Me.lblPort2Status.Padding = New System.Windows.Forms.Padding(3)
        Me.lblPort2Status.Size = New System.Drawing.Size(280, 27)
        Me.lblPort2Status.TabIndex = 2
        Me.lblPort2Status.Text = "...waiting client to connect Port 2..."
        Me.lblPort2Status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblPort2Status.Visible = False
        '
        'lblPort1Status
        '
        Me.lblPort1Status.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblPort1Status.AutoSize = True
        Me.lblPort1Status.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPort1Status.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.lblPort1Status.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblPort1Status.Location = New System.Drawing.Point(432, 457)
        Me.lblPort1Status.MinimumSize = New System.Drawing.Size(280, 0)
        Me.lblPort1Status.Name = "lblPort1Status"
        Me.lblPort1Status.Padding = New System.Windows.Forms.Padding(3)
        Me.lblPort1Status.Size = New System.Drawing.Size(280, 27)
        Me.lblPort1Status.TabIndex = 1
        Me.lblPort1Status.Text = "...waiting client to connect Port 1..."
        Me.lblPort1Status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblPort1Status.Visible = False
        '
        'btnStart
        '
        Me.btnStart.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnStart.BackColor = System.Drawing.SystemColors.Control
        Me.btnStart.FlatAppearance.BorderSize = 0
        Me.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStart.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.btnStart.Image = Global.PLCAutoCalculation.My.Resources.Resources.play__2_
        Me.btnStart.Location = New System.Drawing.Point(419, 148)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(270, 296)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Click to Start"
        Me.btnStart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'tmStartServerPanel
        '
        Me.tmStartServerPanel.Interval = 1
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1109, 573)
        Me.Controls.Add(Me.pnlNavbar)
        Me.Controls.Add(Me.pnlSidebar)
        Me.Controls.Add(Me.pnlStartServer)
        Me.Controls.Add(Me.pnlMainContent)
        Me.Controls.Add(Me.msMainMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.msMainMenu
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DR Auto Feedback System - DRAFT"
        CType(Me.dgvNGSN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.msMainMenu.ResumeLayout(False)
        Me.msMainMenu.PerformLayout()
        Me.pnlSidebar.ResumeLayout(False)
        Me.pnlNavbar.ResumeLayout(False)
        Me.pnlNavbar.PerformLayout()
        Me.pnlMainContent.ResumeLayout(False)
        Me.pnlMainContent.PerformLayout()
        Me.fpnlRawData.ResumeLayout(False)
        Me.fnlGroupHKA.ResumeLayout(False)
        Me.fnlGroupHKA.PerformLayout()
        Me.fnlGroupHKC.ResumeLayout(False)
        Me.fnlGroupHKC.PerformLayout()
        Me.fnlGroupHCB.ResumeLayout(False)
        Me.fnlGroupHCB.PerformLayout()
        Me.fnlGroupHCD.ResumeLayout(False)
        Me.fnlGroupHCD.PerformLayout()
        Me.fnlGroupHHKA.ResumeLayout(False)
        Me.fnlGroupHHKA.PerformLayout()
        Me.fnlGroupHHKC.ResumeLayout(False)
        Me.fnlGroupHHKC.PerformLayout()
        Me.fnlGroupCK.ResumeLayout(False)
        Me.fnlGroupCK.PerformLayout()
        Me.fnlGroupCC.ResumeLayout(False)
        Me.fnlGroupCC.PerformLayout()
        Me.fnlGroupCHK.ResumeLayout(False)
        Me.fnlGroupCHK.PerformLayout()
        Me.pnlStartServer.ResumeLayout(False)
        Me.pnlStartServer.PerformLayout()
        Me.layPnlInfo.ResumeLayout(False)
        Me.layPnlInfo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents msMainMenu As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnStartServer As Button
    Friend WithEvents rtxtLog As RichTextBox
    Friend WithEvents bgtPort1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents bgtStartOpenPort As System.ComponentModel.BackgroundWorker
    Friend WithEvents lblApplicationName As Label
    Friend WithEvents bgtPort2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents bgtPort3 As System.ComponentModel.BackgroundWorker
    Friend WithEvents bgtPort4 As System.ComponentModel.BackgroundWorker
    Friend WithEvents DebugToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents bgtSendToPLCPort2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents bgtSendToPLCPort3 As System.ComponentModel.BackgroundWorker
    Friend WithEvents bgtSendToPLCPort4 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Port1Timer As Timer
    Friend WithEvents bgtStartingServer As System.ComponentModel.BackgroundWorker
    Friend WithEvents bgtOpenPort As System.ComponentModel.BackgroundWorker
    Friend WithEvents dgvNGSN As DataGridView
    Friend WithEvents lblFeedbackMode As Label
    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents pnlNavbar As Panel
    Friend WithEvents btnHamburgerMenu As Button
    Friend WithEvents tmSidebarOpen As Timer
    Friend WithEvents tmSidebarClose As Timer
    Friend WithEvents btnSetting As Button
    Friend WithEvents pnlMainContent As Panel
    Friend WithEvents pnlStartServer As Panel
    Friend WithEvents btnStart As Button
    Friend WithEvents lblPort1Status As Label
    Friend WithEvents lblPort3Status As Label
    Friend WithEvents lblPort2Status As Label
    Friend WithEvents tmStartServerPanel As Timer
    Friend WithEvents layPnlInfo As FlowLayoutPanel
    Friend WithEvents lblInfoPort1 As Label
    Friend WithEvents lblInfoPort2 As Label
    Friend WithEvents lblInfoPort3 As Label
    Friend WithEvents lblInfoIpAddress As Label
    Friend WithEvents lblTitlePort1 As Label
    Friend WithEvents lblTitlePort2 As Label
    Friend WithEvents lblTitlePort3 As Label
    Friend WithEvents lblTitleIpAddress As Label
    Friend WithEvents lblMode As Label
    Friend WithEvents lblInfoServer As Label
    Friend WithEvents lblInfoDatabase As Label
    Friend WithEvents lblTitleServer As Label
    Friend WithEvents lblTitleDatabase As Label
    Friend WithEvents lblSN As Label
    Friend WithEvents fpnlRawData As FlowLayoutPanel
    Friend WithEvents fnlGroupHKA As FlowLayoutPanel
    Friend WithEvents lblTitleHousingKA As Label
    Friend WithEvents lblValueHousingKA As Label
    Friend WithEvents fnlGroupHKC As FlowLayoutPanel
    Friend WithEvents lblTitleHousingKC As Label
    Friend WithEvents lblValueHousingKC As Label
    Friend WithEvents fnlGroupHCB As FlowLayoutPanel
    Friend WithEvents lblTitleHousingCB As Label
    Friend WithEvents lblValueHousingCB As Label
    Friend WithEvents fnlGroupHCD As FlowLayoutPanel
    Friend WithEvents lblTitleHousingCD As Label
    Friend WithEvents lblValueHousingCD As Label
    Friend WithEvents fnlGroupHHKA As FlowLayoutPanel
    Friend WithEvents lblTitleHousingHKA As Label
    Friend WithEvents lblValueHousingHKA As Label
    Friend WithEvents fnlGroupHHKC As FlowLayoutPanel
    Friend WithEvents lblTitleHousingHKC As Label
    Friend WithEvents lblValueHousingHKC As Label
    Friend WithEvents fnlGroupCK As FlowLayoutPanel
    Friend WithEvents lblTitleHousingCK As Label
    Friend WithEvents lblValueHousingCK As Label
    Friend WithEvents fnlGroupCC As FlowLayoutPanel
    Friend WithEvents lblTitleHousingCC As Label
    Friend WithEvents lblValueHousingCC As Label
    Friend WithEvents fnlGroupCHK As FlowLayoutPanel
    Friend WithEvents lblTitleHousingCHK As Label
    Friend WithEvents lblValueHousingCHK As Label
End Class
