Imports System.Windows.Forms

Public Class AddressController

    Private Result As String

    Private Sub YES_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YES_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Result = "OK"
        Status()
        Me.Close()
    End Sub

    Private Sub Manual_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Manual_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Result = "Cancel"
        Status()
        Me.Close()
    End Sub

    Private Sub btnKeep_Click(sender As Object, e As EventArgs) Handles btnKeep.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Abort
        Result = "Abort"
        Status()
        Me.Close()
    End Sub

    Public Function Status() As String
        Return Result
    End Function

    Private Sub AddressController_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblApplicationIP.Text = ":    " & My.Settings.settingIPAddress
        lblComputerIP.Text = ":    " & My.Settings.pcIPAddress
    End Sub
End Class
