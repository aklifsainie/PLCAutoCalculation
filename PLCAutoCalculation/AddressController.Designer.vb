<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddressController
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
        Me.YES_Button = New System.Windows.Forms.Button()
        Me.Manual_Button = New System.Windows.Forms.Button()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnKeep = New System.Windows.Forms.Button()
        Me.lblComputerIPLabel = New System.Windows.Forms.Label()
        Me.lblApplicationIPLabel = New System.Windows.Forms.Label()
        Me.lblComputerIP = New System.Windows.Forms.Label()
        Me.lblApplicationIP = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'YES_Button
        '
        Me.YES_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.YES_Button.BackColor = System.Drawing.Color.Teal
        Me.YES_Button.FlatAppearance.BorderSize = 0
        Me.YES_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.YES_Button.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.YES_Button.ForeColor = System.Drawing.SystemColors.Window
        Me.YES_Button.Location = New System.Drawing.Point(208, 244)
        Me.YES_Button.MinimumSize = New System.Drawing.Size(125, 15)
        Me.YES_Button.Name = "YES_Button"
        Me.YES_Button.Padding = New System.Windows.Forms.Padding(5)
        Me.YES_Button.Size = New System.Drawing.Size(125, 38)
        Me.YES_Button.TabIndex = 0
        Me.YES_Button.Text = "Yes"
        Me.YES_Button.UseVisualStyleBackColor = False
        '
        'Manual_Button
        '
        Me.Manual_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Manual_Button.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Manual_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Manual_Button.FlatAppearance.BorderSize = 0
        Me.Manual_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Manual_Button.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Manual_Button.ForeColor = System.Drawing.SystemColors.Window
        Me.Manual_Button.Location = New System.Drawing.Point(347, 244)
        Me.Manual_Button.MinimumSize = New System.Drawing.Size(125, 15)
        Me.Manual_Button.Name = "Manual_Button"
        Me.Manual_Button.Padding = New System.Windows.Forms.Padding(5)
        Me.Manual_Button.Size = New System.Drawing.Size(125, 38)
        Me.Manual_Button.TabIndex = 1
        Me.Manual_Button.Text = "Go to Setting"
        Me.Manual_Button.UseVisualStyleBackColor = False
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.Location = New System.Drawing.Point(45, 57)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(466, 90)
        Me.lblMessage.TabIndex = 1
        Me.lblMessage.Text = "The application's IP address setting is different with the computer's" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "IP address" &
    "." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Do you want to change the application's IP according to the" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "computer's IP " &
    "address?"
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Indigo
        Me.lblTitle.Location = New System.Drawing.Point(44, 26)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(254, 22)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Text = "The IP Address is different"
        '
        'btnKeep
        '
        Me.btnKeep.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnKeep.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKeep.Location = New System.Drawing.Point(486, 244)
        Me.btnKeep.MinimumSize = New System.Drawing.Size(125, 15)
        Me.btnKeep.Name = "btnKeep"
        Me.btnKeep.Padding = New System.Windows.Forms.Padding(5)
        Me.btnKeep.Size = New System.Drawing.Size(125, 38)
        Me.btnKeep.TabIndex = 3
        Me.btnKeep.Text = "Keep setting"
        '
        'lblComputerIPLabel
        '
        Me.lblComputerIPLabel.AutoSize = True
        Me.lblComputerIPLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComputerIPLabel.Location = New System.Drawing.Point(97, 172)
        Me.lblComputerIPLabel.Name = "lblComputerIPLabel"
        Me.lblComputerIPLabel.Size = New System.Drawing.Size(95, 18)
        Me.lblComputerIPLabel.TabIndex = 4
        Me.lblComputerIPLabel.Text = "Computer IP"
        '
        'lblApplicationIPLabel
        '
        Me.lblApplicationIPLabel.AutoSize = True
        Me.lblApplicationIPLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApplicationIPLabel.Location = New System.Drawing.Point(97, 200)
        Me.lblApplicationIPLabel.Name = "lblApplicationIPLabel"
        Me.lblApplicationIPLabel.Size = New System.Drawing.Size(104, 18)
        Me.lblApplicationIPLabel.TabIndex = 5
        Me.lblApplicationIPLabel.Text = "Application IP"
        '
        'lblComputerIP
        '
        Me.lblComputerIP.AutoSize = True
        Me.lblComputerIP.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComputerIP.Location = New System.Drawing.Point(238, 172)
        Me.lblComputerIP.Name = "lblComputerIP"
        Me.lblComputerIP.Size = New System.Drawing.Size(144, 18)
        Me.lblComputerIP.TabIndex = 6
        Me.lblComputerIP.Text = ":   000.000.000.000"
        Me.lblComputerIP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblApplicationIP
        '
        Me.lblApplicationIP.AutoSize = True
        Me.lblApplicationIP.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApplicationIP.Location = New System.Drawing.Point(238, 200)
        Me.lblApplicationIP.Name = "lblApplicationIP"
        Me.lblApplicationIP.Size = New System.Drawing.Size(144, 18)
        Me.lblApplicationIP.TabIndex = 7
        Me.lblApplicationIP.Text = ":   000.000.000.000"
        Me.lblApplicationIP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AddressController
        '
        Me.AcceptButton = Me.YES_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Manual_Button
        Me.ClientSize = New System.Drawing.Size(623, 294)
        Me.Controls.Add(Me.lblApplicationIP)
        Me.Controls.Add(Me.lblComputerIP)
        Me.Controls.Add(Me.lblApplicationIPLabel)
        Me.Controls.Add(Me.lblComputerIPLabel)
        Me.Controls.Add(Me.btnKeep)
        Me.Controls.Add(Me.YES_Button)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.Manual_Button)
        Me.Controls.Add(Me.lblMessage)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddressController"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents YES_Button As System.Windows.Forms.Button
    Friend WithEvents Manual_Button As System.Windows.Forms.Button
    Friend WithEvents lblMessage As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnKeep As Button
    Friend WithEvents lblComputerIPLabel As Label
    Friend WithEvents lblApplicationIPLabel As Label
    Friend WithEvents lblComputerIP As Label
    Friend WithEvents lblApplicationIP As Label
End Class
