<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
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
        Me.txtServer = New System.Windows.Forms.TextBox()
        Me.txtDatabase = New System.Windows.Forms.TextBox()
        Me.txtSettingAddress = New System.Windows.Forms.TextBox()
        Me.lblServerName = New System.Windows.Forms.Label()
        Me.lblSettingTitle = New System.Windows.Forms.Label()
        Me.lblDatabaseName = New System.Windows.Forms.Label()
        Me.lblSettingIpAddress = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.btnTestConnection = New System.Windows.Forms.Button()
        Me.gbSQLConnection = New System.Windows.Forms.GroupBox()
        Me.gbTCPConnection = New System.Windows.Forms.GroupBox()
        Me.lblPort3 = New System.Windows.Forms.Label()
        Me.txtPort3 = New System.Windows.Forms.TextBox()
        Me.lblPort2 = New System.Windows.Forms.Label()
        Me.txtPort2 = New System.Windows.Forms.TextBox()
        Me.btnGetPCIP = New System.Windows.Forms.Button()
        Me.lblPort1 = New System.Windows.Forms.Label()
        Me.txtPort1 = New System.Windows.Forms.TextBox()
        Me.rbtnEnableDS = New System.Windows.Forms.RadioButton()
        Me.rbtnDisableDS = New System.Windows.Forms.RadioButton()
        Me.lblDSMode = New System.Windows.Forms.Label()
        Me.lblFeedback = New System.Windows.Forms.Label()
        Me.rbtnFeedbackDisable = New System.Windows.Forms.RadioButton()
        Me.rbtnFeedbackEnable = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rbtnMinMax = New System.Windows.Forms.RadioButton()
        Me.rbtnFixedFB = New System.Windows.Forms.RadioButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.gbFixedFeedback = New System.Windows.Forms.GroupBox()
        Me.lblFixFBHK = New System.Windows.Forms.Label()
        Me.tbFixedFBHK = New System.Windows.Forms.TextBox()
        Me.lblFixFBC = New System.Windows.Forms.Label()
        Me.tbFixedFBC = New System.Windows.Forms.TextBox()
        Me.lblFixFBK = New System.Windows.Forms.Label()
        Me.tbFixedFBK = New System.Windows.Forms.TextBox()
        Me.gbMinMax = New System.Windows.Forms.GroupBox()
        Me.tbMax = New System.Windows.Forms.TextBox()
        Me.lblSampleSize = New System.Windows.Forms.Label()
        Me.tbSampleSize = New System.Windows.Forms.TextBox()
        Me.lblMinMax = New System.Windows.Forms.Label()
        Me.tbMin = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtCutOff = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.gbSpacerMode = New System.Windows.Forms.GroupBox()
        Me.rbtnSpacerFixed = New System.Windows.Forms.RadioButton()
        Me.rbtnSpacerAuto = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbHHKC = New System.Windows.Forms.TextBox()
        Me.tbHCD = New System.Windows.Forms.TextBox()
        Me.tbHCB = New System.Windows.Forms.TextBox()
        Me.tbHHKA = New System.Windows.Forms.TextBox()
        Me.tbHKC = New System.Windows.Forms.TextBox()
        Me.tbHKA = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.tbSpecRange = New System.Windows.Forms.TextBox()
        Me.gbSendDelay = New System.Windows.Forms.GroupBox()
        Me.tbSendDelay = New System.Windows.Forms.TextBox()
        Me.gbDesignValue = New System.Windows.Forms.GroupBox()
        Me.lblHousingDV = New System.Windows.Forms.Label()
        Me.lblCLBDV = New System.Windows.Forms.Label()
        Me.tbHousingDv = New System.Windows.Forms.TextBox()
        Me.tbCLBdv = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.rbtnON = New System.Windows.Forms.RadioButton()
        Me.rbtnOFF = New System.Windows.Forms.RadioButton()
        Me.pnlFBFormula = New System.Windows.Forms.Panel()
        Me.rbtnAklifTheory = New System.Windows.Forms.RadioButton()
        Me.lblFBFormula = New System.Windows.Forms.Label()
        Me.rbtnFBFormulaDIF = New System.Windows.Forms.RadioButton()
        Me.rbtnFBFormulaIEF = New System.Windows.Forms.RadioButton()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.gbSQLConnection.SuspendLayout()
        Me.gbTCPConnection.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.gbFixedFeedback.SuspendLayout()
        Me.gbMinMax.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gbSpacerMode.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.gbSendDelay.SuspendLayout()
        Me.gbDesignValue.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.pnlFBFormula.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtServer
        '
        Me.txtServer.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtServer.Location = New System.Drawing.Point(174, 25)
        Me.txtServer.Name = "txtServer"
        Me.txtServer.Size = New System.Drawing.Size(246, 26)
        Me.txtServer.TabIndex = 0
        '
        'txtDatabase
        '
        Me.txtDatabase.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDatabase.Location = New System.Drawing.Point(174, 51)
        Me.txtDatabase.Name = "txtDatabase"
        Me.txtDatabase.Size = New System.Drawing.Size(246, 26)
        Me.txtDatabase.TabIndex = 1
        '
        'txtSettingAddress
        '
        Me.txtSettingAddress.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSettingAddress.Location = New System.Drawing.Point(174, 27)
        Me.txtSettingAddress.Name = "txtSettingAddress"
        Me.txtSettingAddress.Size = New System.Drawing.Size(246, 26)
        Me.txtSettingAddress.TabIndex = 3
        '
        'lblServerName
        '
        Me.lblServerName.AutoSize = True
        Me.lblServerName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServerName.Location = New System.Drawing.Point(28, 28)
        Me.lblServerName.Name = "lblServerName"
        Me.lblServerName.Size = New System.Drawing.Size(54, 18)
        Me.lblServerName.TabIndex = 4
        Me.lblServerName.Text = "Server"
        '
        'lblSettingTitle
        '
        Me.lblSettingTitle.AutoSize = True
        Me.lblSettingTitle.Font = New System.Drawing.Font("Arial", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSettingTitle.ForeColor = System.Drawing.Color.Indigo
        Me.lblSettingTitle.Location = New System.Drawing.Point(18, 18)
        Me.lblSettingTitle.Name = "lblSettingTitle"
        Me.lblSettingTitle.Size = New System.Drawing.Size(119, 32)
        Me.lblSettingTitle.TabIndex = 5
        Me.lblSettingTitle.Text = "Settings"
        '
        'lblDatabaseName
        '
        Me.lblDatabaseName.AutoSize = True
        Me.lblDatabaseName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDatabaseName.Location = New System.Drawing.Point(28, 54)
        Me.lblDatabaseName.Name = "lblDatabaseName"
        Me.lblDatabaseName.Size = New System.Drawing.Size(77, 18)
        Me.lblDatabaseName.TabIndex = 6
        Me.lblDatabaseName.Text = "Database"
        '
        'lblSettingIpAddress
        '
        Me.lblSettingIpAddress.AutoSize = True
        Me.lblSettingIpAddress.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSettingIpAddress.Location = New System.Drawing.Point(28, 30)
        Me.lblSettingIpAddress.Name = "lblSettingIpAddress"
        Me.lblSettingIpAddress.Size = New System.Drawing.Size(84, 18)
        Me.lblSettingIpAddress.TabIndex = 8
        Me.lblSettingIpAddress.Text = "IP Address"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(675, 557)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(245, 51)
        Me.TableLayoutPanel1.TabIndex = 10
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.BackColor = System.Drawing.Color.Teal
        Me.OK_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OK_Button.FlatAppearance.BorderSize = 0
        Me.OK_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OK_Button.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OK_Button.ForeColor = System.Drawing.SystemColors.Window
        Me.OK_Button.Location = New System.Drawing.Point(6, 8)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(109, 35)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "Okay"
        Me.OK_Button.UseVisualStyleBackColor = False
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.FlatAppearance.BorderSize = 0
        Me.Cancel_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancel_Button.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel_Button.Location = New System.Drawing.Point(129, 8)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(109, 35)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        Me.Cancel_Button.UseVisualStyleBackColor = False
        '
        'btnTestConnection
        '
        Me.btnTestConnection.BackColor = System.Drawing.Color.Teal
        Me.btnTestConnection.FlatAppearance.BorderSize = 0
        Me.btnTestConnection.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTestConnection.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTestConnection.ForeColor = System.Drawing.SystemColors.Window
        Me.btnTestConnection.Location = New System.Drawing.Point(264, 83)
        Me.btnTestConnection.Name = "btnTestConnection"
        Me.btnTestConnection.Size = New System.Drawing.Size(156, 35)
        Me.btnTestConnection.TabIndex = 11
        Me.btnTestConnection.Text = "Test Connection"
        Me.btnTestConnection.UseVisualStyleBackColor = False
        '
        'gbSQLConnection
        '
        Me.gbSQLConnection.Controls.Add(Me.lblServerName)
        Me.gbSQLConnection.Controls.Add(Me.btnTestConnection)
        Me.gbSQLConnection.Controls.Add(Me.txtServer)
        Me.gbSQLConnection.Controls.Add(Me.txtDatabase)
        Me.gbSQLConnection.Controls.Add(Me.lblDatabaseName)
        Me.gbSQLConnection.Location = New System.Drawing.Point(12, 53)
        Me.gbSQLConnection.Name = "gbSQLConnection"
        Me.gbSQLConnection.Size = New System.Drawing.Size(440, 139)
        Me.gbSQLConnection.TabIndex = 12
        Me.gbSQLConnection.TabStop = False
        Me.gbSQLConnection.Text = "Database Connection"
        '
        'gbTCPConnection
        '
        Me.gbTCPConnection.Controls.Add(Me.lblPort3)
        Me.gbTCPConnection.Controls.Add(Me.txtPort3)
        Me.gbTCPConnection.Controls.Add(Me.lblPort2)
        Me.gbTCPConnection.Controls.Add(Me.txtPort2)
        Me.gbTCPConnection.Controls.Add(Me.btnGetPCIP)
        Me.gbTCPConnection.Controls.Add(Me.lblPort1)
        Me.gbTCPConnection.Controls.Add(Me.txtPort1)
        Me.gbTCPConnection.Controls.Add(Me.txtSettingAddress)
        Me.gbTCPConnection.Controls.Add(Me.lblSettingIpAddress)
        Me.gbTCPConnection.Location = New System.Drawing.Point(12, 198)
        Me.gbTCPConnection.Name = "gbTCPConnection"
        Me.gbTCPConnection.Size = New System.Drawing.Size(440, 222)
        Me.gbTCPConnection.TabIndex = 13
        Me.gbTCPConnection.TabStop = False
        Me.gbTCPConnection.Text = "TCP Connection"
        '
        'lblPort3
        '
        Me.lblPort3.AutoSize = True
        Me.lblPort3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPort3.Location = New System.Drawing.Point(28, 134)
        Me.lblPort3.Name = "lblPort3"
        Me.lblPort3.Size = New System.Drawing.Size(50, 18)
        Me.lblPort3.TabIndex = 16
        Me.lblPort3.Text = "Port 3"
        '
        'txtPort3
        '
        Me.txtPort3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPort3.Location = New System.Drawing.Point(174, 131)
        Me.txtPort3.Name = "txtPort3"
        Me.txtPort3.Size = New System.Drawing.Size(246, 26)
        Me.txtPort3.TabIndex = 15
        '
        'lblPort2
        '
        Me.lblPort2.AutoSize = True
        Me.lblPort2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPort2.Location = New System.Drawing.Point(28, 108)
        Me.lblPort2.Name = "lblPort2"
        Me.lblPort2.Size = New System.Drawing.Size(50, 18)
        Me.lblPort2.TabIndex = 14
        Me.lblPort2.Text = "Port 2"
        '
        'txtPort2
        '
        Me.txtPort2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPort2.Location = New System.Drawing.Point(174, 105)
        Me.txtPort2.Name = "txtPort2"
        Me.txtPort2.Size = New System.Drawing.Size(246, 26)
        Me.txtPort2.TabIndex = 13
        '
        'btnGetPCIP
        '
        Me.btnGetPCIP.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnGetPCIP.FlatAppearance.BorderSize = 0
        Me.btnGetPCIP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGetPCIP.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGetPCIP.ForeColor = System.Drawing.SystemColors.Window
        Me.btnGetPCIP.Location = New System.Drawing.Point(300, 179)
        Me.btnGetPCIP.Name = "btnGetPCIP"
        Me.btnGetPCIP.Size = New System.Drawing.Size(120, 25)
        Me.btnGetPCIP.TabIndex = 12
        Me.btnGetPCIP.Text = "Get PC IP Address"
        Me.btnGetPCIP.UseVisualStyleBackColor = False
        '
        'lblPort1
        '
        Me.lblPort1.AutoSize = True
        Me.lblPort1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPort1.Location = New System.Drawing.Point(28, 82)
        Me.lblPort1.Name = "lblPort1"
        Me.lblPort1.Size = New System.Drawing.Size(50, 18)
        Me.lblPort1.TabIndex = 11
        Me.lblPort1.Text = "Port 1"
        '
        'txtPort1
        '
        Me.txtPort1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPort1.Location = New System.Drawing.Point(174, 79)
        Me.txtPort1.Name = "txtPort1"
        Me.txtPort1.Size = New System.Drawing.Size(246, 26)
        Me.txtPort1.TabIndex = 9
        '
        'rbtnEnableDS
        '
        Me.rbtnEnableDS.AutoSize = True
        Me.rbtnEnableDS.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnEnableDS.Location = New System.Drawing.Point(192, 9)
        Me.rbtnEnableDS.Name = "rbtnEnableDS"
        Me.rbtnEnableDS.Size = New System.Drawing.Size(75, 22)
        Me.rbtnEnableDS.TabIndex = 14
        Me.rbtnEnableDS.TabStop = True
        Me.rbtnEnableDS.Text = "Enable"
        Me.rbtnEnableDS.UseVisualStyleBackColor = True
        '
        'rbtnDisableDS
        '
        Me.rbtnDisableDS.AutoSize = True
        Me.rbtnDisableDS.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnDisableDS.Location = New System.Drawing.Point(109, 9)
        Me.rbtnDisableDS.Name = "rbtnDisableDS"
        Me.rbtnDisableDS.Size = New System.Drawing.Size(80, 22)
        Me.rbtnDisableDS.TabIndex = 15
        Me.rbtnDisableDS.TabStop = True
        Me.rbtnDisableDS.Text = "Disable"
        Me.rbtnDisableDS.UseVisualStyleBackColor = True
        '
        'lblDSMode
        '
        Me.lblDSMode.AutoSize = True
        Me.lblDSMode.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDSMode.Location = New System.Drawing.Point(8, 9)
        Me.lblDSMode.Name = "lblDSMode"
        Me.lblDSMode.Size = New System.Drawing.Size(78, 19)
        Me.lblDSMode.TabIndex = 19
        Me.lblDSMode.Text = "DS Mode"
        '
        'lblFeedback
        '
        Me.lblFeedback.AutoSize = True
        Me.lblFeedback.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFeedback.Location = New System.Drawing.Point(8, 10)
        Me.lblFeedback.Name = "lblFeedback"
        Me.lblFeedback.Size = New System.Drawing.Size(84, 19)
        Me.lblFeedback.TabIndex = 22
        Me.lblFeedback.Text = "Feedback"
        '
        'rbtnFeedbackDisable
        '
        Me.rbtnFeedbackDisable.AutoSize = True
        Me.rbtnFeedbackDisable.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnFeedbackDisable.Location = New System.Drawing.Point(109, 10)
        Me.rbtnFeedbackDisable.Name = "rbtnFeedbackDisable"
        Me.rbtnFeedbackDisable.Size = New System.Drawing.Size(80, 22)
        Me.rbtnFeedbackDisable.TabIndex = 21
        Me.rbtnFeedbackDisable.TabStop = True
        Me.rbtnFeedbackDisable.Text = "Disable"
        Me.rbtnFeedbackDisable.UseVisualStyleBackColor = True
        '
        'rbtnFeedbackEnable
        '
        Me.rbtnFeedbackEnable.AutoSize = True
        Me.rbtnFeedbackEnable.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnFeedbackEnable.Location = New System.Drawing.Point(192, 10)
        Me.rbtnFeedbackEnable.Name = "rbtnFeedbackEnable"
        Me.rbtnFeedbackEnable.Size = New System.Drawing.Size(76, 22)
        Me.rbtnFeedbackEnable.TabIndex = 20
        Me.rbtnFeedbackEnable.TabStop = True
        Me.rbtnFeedbackEnable.Text = "Moving"
        Me.rbtnFeedbackEnable.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rbtnMinMax)
        Me.Panel1.Controls.Add(Me.rbtnFixedFB)
        Me.Panel1.Controls.Add(Me.lblFeedback)
        Me.Panel1.Controls.Add(Me.rbtnFeedbackEnable)
        Me.Panel1.Controls.Add(Me.rbtnFeedbackDisable)
        Me.Panel1.Location = New System.Drawing.Point(12, 426)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(440, 38)
        Me.Panel1.TabIndex = 23
        '
        'rbtnMinMax
        '
        Me.rbtnMinMax.AutoSize = True
        Me.rbtnMinMax.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnMinMax.Location = New System.Drawing.Point(347, 10)
        Me.rbtnMinMax.Name = "rbtnMinMax"
        Me.rbtnMinMax.Size = New System.Drawing.Size(80, 22)
        Me.rbtnMinMax.TabIndex = 24
        Me.rbtnMinMax.TabStop = True
        Me.rbtnMinMax.Text = "MinMax"
        Me.rbtnMinMax.UseVisualStyleBackColor = True
        '
        'rbtnFixedFB
        '
        Me.rbtnFixedFB.AutoSize = True
        Me.rbtnFixedFB.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnFixedFB.Location = New System.Drawing.Point(278, 10)
        Me.rbtnFixedFB.Name = "rbtnFixedFB"
        Me.rbtnFixedFB.Size = New System.Drawing.Size(65, 22)
        Me.rbtnFixedFB.TabIndex = 23
        Me.rbtnFixedFB.TabStop = True
        Me.rbtnFixedFB.Text = "Fixed"
        Me.rbtnFixedFB.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lblDSMode)
        Me.Panel2.Controls.Add(Me.rbtnEnableDS)
        Me.Panel2.Controls.Add(Me.rbtnDisableDS)
        Me.Panel2.Location = New System.Drawing.Point(12, 470)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(440, 38)
        Me.Panel2.TabIndex = 24
        '
        'gbFixedFeedback
        '
        Me.gbFixedFeedback.Controls.Add(Me.lblFixFBHK)
        Me.gbFixedFeedback.Controls.Add(Me.tbFixedFBHK)
        Me.gbFixedFeedback.Controls.Add(Me.lblFixFBC)
        Me.gbFixedFeedback.Controls.Add(Me.tbFixedFBC)
        Me.gbFixedFeedback.Controls.Add(Me.lblFixFBK)
        Me.gbFixedFeedback.Controls.Add(Me.tbFixedFBK)
        Me.gbFixedFeedback.Location = New System.Drawing.Point(458, 53)
        Me.gbFixedFeedback.Name = "gbFixedFeedback"
        Me.gbFixedFeedback.Size = New System.Drawing.Size(200, 139)
        Me.gbFixedFeedback.TabIndex = 25
        Me.gbFixedFeedback.TabStop = False
        Me.gbFixedFeedback.Text = "Fixed Feedback Value"
        '
        'lblFixFBHK
        '
        Me.lblFixFBHK.AutoSize = True
        Me.lblFixFBHK.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFixFBHK.Location = New System.Drawing.Point(47, 90)
        Me.lblFixFBHK.Name = "lblFixFBHK"
        Me.lblFixFBHK.Size = New System.Drawing.Size(33, 19)
        Me.lblFixFBHK.TabIndex = 5
        Me.lblFixFBHK.Text = "HK"
        '
        'tbFixedFBHK
        '
        Me.tbFixedFBHK.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbFixedFBHK.Location = New System.Drawing.Point(88, 86)
        Me.tbFixedFBHK.Name = "tbFixedFBHK"
        Me.tbFixedFBHK.Size = New System.Drawing.Size(92, 26)
        Me.tbFixedFBHK.TabIndex = 4
        '
        'lblFixFBC
        '
        Me.lblFixFBC.AutoSize = True
        Me.lblFixFBC.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFixFBC.Location = New System.Drawing.Point(47, 58)
        Me.lblFixFBC.Name = "lblFixFBC"
        Me.lblFixFBC.Size = New System.Drawing.Size(21, 19)
        Me.lblFixFBC.TabIndex = 3
        Me.lblFixFBC.Text = "C"
        '
        'tbFixedFBC
        '
        Me.tbFixedFBC.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbFixedFBC.Location = New System.Drawing.Point(88, 54)
        Me.tbFixedFBC.Name = "tbFixedFBC"
        Me.tbFixedFBC.Size = New System.Drawing.Size(92, 26)
        Me.tbFixedFBC.TabIndex = 2
        '
        'lblFixFBK
        '
        Me.lblFixFBK.AutoSize = True
        Me.lblFixFBK.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFixFBK.Location = New System.Drawing.Point(47, 24)
        Me.lblFixFBK.Name = "lblFixFBK"
        Me.lblFixFBK.Size = New System.Drawing.Size(21, 19)
        Me.lblFixFBK.TabIndex = 1
        Me.lblFixFBK.Text = "K"
        '
        'tbFixedFBK
        '
        Me.tbFixedFBK.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbFixedFBK.Location = New System.Drawing.Point(88, 20)
        Me.tbFixedFBK.Name = "tbFixedFBK"
        Me.tbFixedFBK.Size = New System.Drawing.Size(92, 26)
        Me.tbFixedFBK.TabIndex = 0
        '
        'gbMinMax
        '
        Me.gbMinMax.Controls.Add(Me.tbMax)
        Me.gbMinMax.Controls.Add(Me.lblSampleSize)
        Me.gbMinMax.Controls.Add(Me.tbSampleSize)
        Me.gbMinMax.Controls.Add(Me.lblMinMax)
        Me.gbMinMax.Controls.Add(Me.tbMin)
        Me.gbMinMax.Location = New System.Drawing.Point(458, 198)
        Me.gbMinMax.Name = "gbMinMax"
        Me.gbMinMax.Size = New System.Drawing.Size(200, 100)
        Me.gbMinMax.TabIndex = 26
        Me.gbMinMax.TabStop = False
        Me.gbMinMax.Text = "Min/Max Feedback"
        '
        'tbMax
        '
        Me.tbMax.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMax.Location = New System.Drawing.Point(148, 20)
        Me.tbMax.Name = "tbMax"
        Me.tbMax.Size = New System.Drawing.Size(46, 26)
        Me.tbMax.TabIndex = 4
        '
        'lblSampleSize
        '
        Me.lblSampleSize.AutoSize = True
        Me.lblSampleSize.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSampleSize.Location = New System.Drawing.Point(6, 58)
        Me.lblSampleSize.Name = "lblSampleSize"
        Me.lblSampleSize.Size = New System.Drawing.Size(103, 19)
        Me.lblSampleSize.TabIndex = 3
        Me.lblSampleSize.Text = "Sample Size"
        '
        'tbSampleSize
        '
        Me.tbSampleSize.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSampleSize.Location = New System.Drawing.Point(115, 54)
        Me.tbSampleSize.Name = "tbSampleSize"
        Me.tbSampleSize.Size = New System.Drawing.Size(79, 26)
        Me.tbSampleSize.TabIndex = 2
        '
        'lblMinMax
        '
        Me.lblMinMax.AutoSize = True
        Me.lblMinMax.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinMax.Location = New System.Drawing.Point(23, 24)
        Me.lblMinMax.Name = "lblMinMax"
        Me.lblMinMax.Size = New System.Drawing.Size(71, 19)
        Me.lblMinMax.TabIndex = 1
        Me.lblMinMax.Text = "Min/Max"
        '
        'tbMin
        '
        Me.tbMin.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMin.Location = New System.Drawing.Point(100, 20)
        Me.tbMin.Name = "tbMin"
        Me.tbMin.Size = New System.Drawing.Size(46, 26)
        Me.tbMin.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(51, 58)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Cut Off"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtCutOff
        '
        Me.txtCutOff.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCutOff.Location = New System.Drawing.Point(6, 26)
        Me.txtCutOff.Name = "txtCutOff"
        Me.txtCutOff.Size = New System.Drawing.Size(188, 26)
        Me.txtCutOff.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.txtCutOff)
        Me.GroupBox1.Location = New System.Drawing.Point(458, 306)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 96)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cut Off Datetime"
        '
        'gbSpacerMode
        '
        Me.gbSpacerMode.Controls.Add(Me.rbtnSpacerFixed)
        Me.gbSpacerMode.Controls.Add(Me.rbtnSpacerAuto)
        Me.gbSpacerMode.Location = New System.Drawing.Point(458, 408)
        Me.gbSpacerMode.Name = "gbSpacerMode"
        Me.gbSpacerMode.Size = New System.Drawing.Size(200, 91)
        Me.gbSpacerMode.TabIndex = 29
        Me.gbSpacerMode.TabStop = False
        Me.gbSpacerMode.Text = "Spacer Mode"
        '
        'rbtnSpacerFixed
        '
        Me.rbtnSpacerFixed.AutoSize = True
        Me.rbtnSpacerFixed.Location = New System.Drawing.Point(40, 52)
        Me.rbtnSpacerFixed.Name = "rbtnSpacerFixed"
        Me.rbtnSpacerFixed.Size = New System.Drawing.Size(87, 17)
        Me.rbtnSpacerFixed.TabIndex = 1
        Me.rbtnSpacerFixed.TabStop = True
        Me.rbtnSpacerFixed.Text = "Fixed Spacer"
        Me.rbtnSpacerFixed.UseVisualStyleBackColor = True
        '
        'rbtnSpacerAuto
        '
        Me.rbtnSpacerAuto.AutoSize = True
        Me.rbtnSpacerAuto.Location = New System.Drawing.Point(40, 29)
        Me.rbtnSpacerAuto.Name = "rbtnSpacerAuto"
        Me.rbtnSpacerAuto.Size = New System.Drawing.Size(121, 17)
        Me.rbtnSpacerAuto.TabIndex = 0
        Me.rbtnSpacerAuto.TabStop = True
        Me.rbtnSpacerAuto.Text = "Auto Double Spacer"
        Me.rbtnSpacerAuto.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.tbHHKC)
        Me.GroupBox2.Controls.Add(Me.tbHCD)
        Me.GroupBox2.Controls.Add(Me.tbHCB)
        Me.GroupBox2.Controls.Add(Me.tbHHKA)
        Me.GroupBox2.Controls.Add(Me.tbHKC)
        Me.GroupBox2.Controls.Add(Me.tbHKA)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(664, 53)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(251, 179)
        Me.GroupBox2.TabIndex = 30
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Fixed Spacer Mode"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(147, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 19)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Spacer 2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(54, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 19)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Spacer 1"
        '
        'tbHHKC
        '
        Me.tbHHKC.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbHHKC.Location = New System.Drawing.Point(158, 123)
        Me.tbHHKC.Name = "tbHHKC"
        Me.tbHHKC.Size = New System.Drawing.Size(70, 26)
        Me.tbHHKC.TabIndex = 12
        '
        'tbHCD
        '
        Me.tbHCD.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbHCD.Location = New System.Drawing.Point(158, 91)
        Me.tbHCD.Name = "tbHCD"
        Me.tbHCD.Size = New System.Drawing.Size(70, 26)
        Me.tbHCD.TabIndex = 11
        '
        'tbHCB
        '
        Me.tbHCB.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbHCB.Location = New System.Drawing.Point(58, 92)
        Me.tbHCB.Name = "tbHCB"
        Me.tbHCB.Size = New System.Drawing.Size(70, 26)
        Me.tbHCB.TabIndex = 10
        '
        'tbHHKA
        '
        Me.tbHHKA.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbHHKA.Location = New System.Drawing.Point(58, 124)
        Me.tbHHKA.Name = "tbHHKA"
        Me.tbHHKA.Size = New System.Drawing.Size(70, 26)
        Me.tbHHKA.TabIndex = 9
        '
        'tbHKC
        '
        Me.tbHKC.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbHKC.Location = New System.Drawing.Point(158, 56)
        Me.tbHKC.Name = "tbHKC"
        Me.tbHKC.Size = New System.Drawing.Size(70, 26)
        Me.tbHKC.TabIndex = 8
        '
        'tbHKA
        '
        Me.tbHKA.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbHKA.Location = New System.Drawing.Point(58, 57)
        Me.tbHKA.Name = "tbHKA"
        Me.tbHKA.Size = New System.Drawing.Size(70, 26)
        Me.tbHKA.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 19)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "HK"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 19)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "C"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "K"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.tbSpecRange)
        Me.GroupBox3.Location = New System.Drawing.Point(664, 238)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(251, 96)
        Me.GroupBox3.TabIndex = 31
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Specification Range +/-"
        '
        'tbSpecRange
        '
        Me.tbSpecRange.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSpecRange.Location = New System.Drawing.Point(8, 42)
        Me.tbSpecRange.Name = "tbSpecRange"
        Me.tbSpecRange.Size = New System.Drawing.Size(237, 26)
        Me.tbSpecRange.TabIndex = 2
        '
        'gbSendDelay
        '
        Me.gbSendDelay.Controls.Add(Me.tbSendDelay)
        Me.gbSendDelay.Location = New System.Drawing.Point(667, 341)
        Me.gbSendDelay.Name = "gbSendDelay"
        Me.gbSendDelay.Size = New System.Drawing.Size(251, 96)
        Me.gbSendDelay.TabIndex = 32
        Me.gbSendDelay.TabStop = False
        Me.gbSendDelay.Text = "Send Delay (Millisecond)"
        '
        'tbSendDelay
        '
        Me.tbSendDelay.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSendDelay.Location = New System.Drawing.Point(8, 42)
        Me.tbSendDelay.Name = "tbSendDelay"
        Me.tbSendDelay.Size = New System.Drawing.Size(237, 26)
        Me.tbSendDelay.TabIndex = 2
        '
        'gbDesignValue
        '
        Me.gbDesignValue.Controls.Add(Me.lblHousingDV)
        Me.gbDesignValue.Controls.Add(Me.lblCLBDV)
        Me.gbDesignValue.Controls.Add(Me.tbHousingDv)
        Me.gbDesignValue.Controls.Add(Me.tbCLBdv)
        Me.gbDesignValue.Location = New System.Drawing.Point(668, 443)
        Me.gbDesignValue.Name = "gbDesignValue"
        Me.gbDesignValue.Size = New System.Drawing.Size(247, 102)
        Me.gbDesignValue.TabIndex = 33
        Me.gbDesignValue.TabStop = False
        Me.gbDesignValue.Text = "Design Value"
        '
        'lblHousingDV
        '
        Me.lblHousingDV.AutoSize = True
        Me.lblHousingDV.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHousingDV.Location = New System.Drawing.Point(138, 25)
        Me.lblHousingDV.Name = "lblHousingDV"
        Me.lblHousingDV.Size = New System.Drawing.Size(74, 19)
        Me.lblHousingDV.TabIndex = 17
        Me.lblHousingDV.Text = "Housing"
        '
        'lblCLBDV
        '
        Me.lblCLBDV.AutoSize = True
        Me.lblCLBDV.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCLBDV.Location = New System.Drawing.Point(52, 25)
        Me.lblCLBDV.Name = "lblCLBDV"
        Me.lblCLBDV.Size = New System.Drawing.Size(43, 19)
        Me.lblCLBDV.TabIndex = 16
        Me.lblCLBDV.Text = "CLB"
        '
        'tbHousingDv
        '
        Me.tbHousingDv.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbHousingDv.Location = New System.Drawing.Point(140, 56)
        Me.tbHousingDv.Name = "tbHousingDv"
        Me.tbHousingDv.Size = New System.Drawing.Size(70, 26)
        Me.tbHousingDv.TabIndex = 8
        '
        'tbCLBdv
        '
        Me.tbCLBdv.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCLBdv.Location = New System.Drawing.Point(38, 57)
        Me.tbCLBdv.Name = "tbCLBdv"
        Me.tbCLBdv.Size = New System.Drawing.Size(70, 26)
        Me.tbCLBdv.TabIndex = 7
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.rbtnON)
        Me.GroupBox4.Controls.Add(Me.rbtnOFF)
        Me.GroupBox4.Location = New System.Drawing.Point(458, 505)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(200, 91)
        Me.GroupBox4.TabIndex = 30
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Expected CLB Control"
        '
        'rbtnON
        '
        Me.rbtnON.AutoSize = True
        Me.rbtnON.Location = New System.Drawing.Point(40, 52)
        Me.rbtnON.Name = "rbtnON"
        Me.rbtnON.Size = New System.Drawing.Size(58, 17)
        Me.rbtnON.TabIndex = 1
        Me.rbtnON.TabStop = True
        Me.rbtnON.Text = "Enable"
        Me.rbtnON.UseVisualStyleBackColor = True
        '
        'rbtnOFF
        '
        Me.rbtnOFF.AutoSize = True
        Me.rbtnOFF.Location = New System.Drawing.Point(40, 29)
        Me.rbtnOFF.Name = "rbtnOFF"
        Me.rbtnOFF.Size = New System.Drawing.Size(60, 17)
        Me.rbtnOFF.TabIndex = 0
        Me.rbtnOFF.TabStop = True
        Me.rbtnOFF.Text = "Disable"
        Me.rbtnOFF.UseVisualStyleBackColor = True
        '
        'pnlFBFormula
        '
        Me.pnlFBFormula.Controls.Add(Me.rbtnAklifTheory)
        Me.pnlFBFormula.Controls.Add(Me.lblFBFormula)
        Me.pnlFBFormula.Controls.Add(Me.rbtnFBFormulaDIF)
        Me.pnlFBFormula.Controls.Add(Me.rbtnFBFormulaIEF)
        Me.pnlFBFormula.Location = New System.Drawing.Point(12, 513)
        Me.pnlFBFormula.Name = "pnlFBFormula"
        Me.pnlFBFormula.Size = New System.Drawing.Size(440, 38)
        Me.pnlFBFormula.TabIndex = 34
        '
        'rbtnAklifTheory
        '
        Me.rbtnAklifTheory.AutoSize = True
        Me.rbtnAklifTheory.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnAklifTheory.Location = New System.Drawing.Point(278, 7)
        Me.rbtnAklifTheory.Name = "rbtnAklifTheory"
        Me.rbtnAklifTheory.Size = New System.Drawing.Size(73, 22)
        Me.rbtnAklifTheory.TabIndex = 21
        Me.rbtnAklifTheory.TabStop = True
        Me.rbtnAklifTheory.Text = "E-D+F"
        Me.rbtnAklifTheory.UseVisualStyleBackColor = True
        '
        'lblFBFormula
        '
        Me.lblFBFormula.AutoSize = True
        Me.lblFBFormula.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFBFormula.Location = New System.Drawing.Point(8, 9)
        Me.lblFBFormula.Name = "lblFBFormula"
        Me.lblFBFormula.Size = New System.Drawing.Size(98, 19)
        Me.lblFBFormula.TabIndex = 19
        Me.lblFBFormula.Text = "FB Formula"
        '
        'rbtnFBFormulaDIF
        '
        Me.rbtnFBFormulaDIF.AutoSize = True
        Me.rbtnFBFormulaDIF.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnFBFormulaDIF.Location = New System.Drawing.Point(109, 7)
        Me.rbtnFBFormulaDIF.Name = "rbtnFBFormulaDIF"
        Me.rbtnFBFormulaDIF.Size = New System.Drawing.Size(65, 22)
        Me.rbtnFBFormulaDIF.TabIndex = 14
        Me.rbtnFBFormulaDIF.TabStop = True
        Me.rbtnFBFormulaDIF.Text = "D-I+F"
        Me.rbtnFBFormulaDIF.UseVisualStyleBackColor = True
        '
        'rbtnFBFormulaIEF
        '
        Me.rbtnFBFormulaIEF.AutoSize = True
        Me.rbtnFBFormulaIEF.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnFBFormulaIEF.Location = New System.Drawing.Point(192, 7)
        Me.rbtnFBFormulaIEF.Name = "rbtnFBFormulaIEF"
        Me.rbtnFBFormulaIEF.Size = New System.Drawing.Size(65, 22)
        Me.rbtnFBFormulaIEF.TabIndex = 15
        Me.rbtnFBFormulaIEF.TabStop = True
        Me.rbtnFBFormulaIEF.Text = "I-D+F"
        Me.rbtnFBFormulaIEF.UseVisualStyleBackColor = True
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(927, 615)
        Me.Controls.Add(Me.pnlFBFormula)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.gbDesignValue)
        Me.Controls.Add(Me.gbSendDelay)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.gbSpacerMode)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbMinMax)
        Me.Controls.Add(Me.gbFixedFeedback)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.gbTCPConnection)
        Me.Controls.Add(Me.gbSQLConnection)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.lblSettingTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSettings"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.gbSQLConnection.ResumeLayout(False)
        Me.gbSQLConnection.PerformLayout()
        Me.gbTCPConnection.ResumeLayout(False)
        Me.gbTCPConnection.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.gbFixedFeedback.ResumeLayout(False)
        Me.gbFixedFeedback.PerformLayout()
        Me.gbMinMax.ResumeLayout(False)
        Me.gbMinMax.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbSpacerMode.ResumeLayout(False)
        Me.gbSpacerMode.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.gbSendDelay.ResumeLayout(False)
        Me.gbSendDelay.PerformLayout()
        Me.gbDesignValue.ResumeLayout(False)
        Me.gbDesignValue.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.pnlFBFormula.ResumeLayout(False)
        Me.pnlFBFormula.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtServer As TextBox
    Friend WithEvents txtDatabase As TextBox
    Friend WithEvents txtSettingAddress As TextBox
    Friend WithEvents lblServerName As Label
    Friend WithEvents lblSettingTitle As Label
    Friend WithEvents lblDatabaseName As Label
    Friend WithEvents lblSettingIpAddress As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents OK_Button As Button
    Friend WithEvents Cancel_Button As Button
    Friend WithEvents btnTestConnection As Button
    Friend WithEvents gbSQLConnection As GroupBox
    Friend WithEvents gbTCPConnection As GroupBox
    Friend WithEvents lblPort1 As Label
    Friend WithEvents txtPort1 As TextBox
    Friend WithEvents btnGetPCIP As Button
    Friend WithEvents rbtnEnableDS As RadioButton
    Friend WithEvents rbtnDisableDS As RadioButton
    Friend WithEvents lblPort3 As Label
    Friend WithEvents txtPort3 As TextBox
    Friend WithEvents lblPort2 As Label
    Friend WithEvents txtPort2 As TextBox
    Friend WithEvents lblDSMode As Label
    Friend WithEvents lblFeedback As Label
    Friend WithEvents rbtnFeedbackDisable As RadioButton
    Friend WithEvents rbtnFeedbackEnable As RadioButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents gbFixedFeedback As GroupBox
    Friend WithEvents lblFixFBHK As Label
    Friend WithEvents tbFixedFBHK As TextBox
    Friend WithEvents lblFixFBC As Label
    Friend WithEvents tbFixedFBC As TextBox
    Friend WithEvents lblFixFBK As Label
    Friend WithEvents tbFixedFBK As TextBox
    Friend WithEvents rbtnFixedFB As RadioButton
    Friend WithEvents rbtnMinMax As RadioButton
    Friend WithEvents gbMinMax As GroupBox
    Friend WithEvents lblMinMax As Label
    Friend WithEvents tbMin As TextBox
    Friend WithEvents lblSampleSize As Label
    Friend WithEvents tbSampleSize As TextBox
    Friend WithEvents tbMax As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtCutOff As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents gbSpacerMode As GroupBox
    Friend WithEvents rbtnSpacerFixed As RadioButton
    Friend WithEvents rbtnSpacerAuto As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tbHHKC As TextBox
    Friend WithEvents tbHCD As TextBox
    Friend WithEvents tbHCB As TextBox
    Friend WithEvents tbHHKA As TextBox
    Friend WithEvents tbHKC As TextBox
    Friend WithEvents tbHKA As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents tbSpecRange As TextBox
    Friend WithEvents gbSendDelay As GroupBox
    Friend WithEvents tbSendDelay As TextBox
    Friend WithEvents gbDesignValue As GroupBox
    Friend WithEvents lblHousingDV As Label
    Friend WithEvents lblCLBDV As Label
    Friend WithEvents tbHousingDv As TextBox
    Friend WithEvents tbCLBdv As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents rbtnON As RadioButton
    Friend WithEvents rbtnOFF As RadioButton
    Friend WithEvents pnlFBFormula As Panel
    Friend WithEvents lblFBFormula As Label
    Friend WithEvents rbtnFBFormulaDIF As RadioButton
    Friend WithEvents rbtnFBFormulaIEF As RadioButton
    Friend WithEvents rbtnAklifTheory As RadioButton
End Class
