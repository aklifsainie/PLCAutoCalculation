Imports System.Windows.Forms

Public Class frmSettings

    Private objSQL As New SQLController
    Private currentServer As String
    Private currentDatabase As String
    Private currentIP As String
    Private currentPLCIP As String
    Private currentPort1 As String
    Private currentPort2 As String
    Private currentPort3 As String
    Private currentPort4 As String
    Private currentPort5 As String
    Private currentFixFBK As Double
    Private currentFixFBC As Double
    Private currentFixFBHK As Double
    Private currentMin As Integer
    Private currentMax As Integer
    Private currentSampleSize As Integer
    Private currentFBValueSaveK As Double
    Private currentFBValueSavec As Double
    Private currentFBValueSaveHK As Double
    Private currentFixedSpacerHKA As Double
    Private currentFixedSpacerHKC As Double
    Private currentFixedSpacerHCB As Double
    Private currentFixedSpacerHCD As Double
    Private currentFixedSpacerHHKA As Double
    Private currentFixedSpacerHHKC As Double
    Private currentSpecRange As Double
    Private currentSendDelay As Integer
    Private currentCLBdv As Double
    Private currentHousingDv As Double
    Private currentExpectedControl As Boolean
    Private currentFBFormula As String




    Public Sub frmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.dsMode = False Then
            rbtnDisableDS.Checked = True
            rbtnEnableDS.Checked = False
        ElseIf My.Settings.dsMode = True Then
            rbtnDisableDS.Checked = False
            rbtnEnableDS.Checked = True
        End If

        If My.Settings.ExpectedCLBControl = False Then
            rbtnOFF.Checked = True
            rbtnON.Checked = False
        ElseIf My.Settings.ExpectedCLBControl = True Then
            rbtnOFF.Checked = False
            rbtnON.Checked = True
        End If

        If My.Settings.FBFormula = "DIF" Then
            rbtnFBFormulaDIF.Checked = True
            rbtnFBFormulaIEF.Checked = False
            rbtnAklifTheory.Checked = False
        ElseIf My.Settings.FBFormula = "IDF" Then
            rbtnFBFormulaDIF.Checked = False
            rbtnFBFormulaIEF.Checked = True
            rbtnAklifTheory.Checked = False
        ElseIf My.Settings.FBFormula = "EDF" Then
            rbtnFBFormulaDIF.Checked = False
            rbtnFBFormulaIEF.Checked = False
            rbtnAklifTheory.Checked = True

        End If

        If My.Settings.feedback = "Disable" Then
            rbtnFeedbackDisable.Checked = True
            rbtnFeedbackEnable.Checked = False
            rbtnFixedFB.Checked = False
            rbtnMinMax.Checked = False
        ElseIf My.Settings.feedback = "Enable" Then
            rbtnFeedbackDisable.Checked = False
            rbtnFeedbackEnable.Checked = True
            rbtnFixedFB.Checked = False
            rbtnMinMax.Checked = False
        ElseIf My.Settings.feedback = "Fixed" Then
            rbtnFeedbackDisable.Checked = False
            rbtnFeedbackEnable.Checked = False
            rbtnFixedFB.Checked = True
            rbtnMinMax.Checked = False
        ElseIf My.Settings.feedback = "MinMax" Then
            rbtnFeedbackDisable.Checked = False
            rbtnFeedbackEnable.Checked = False
            rbtnFixedFB.Checked = False
            rbtnMinMax.Checked = True
        End If

        If My.Settings.SpacerMode = "Auto" Then
            rbtnSpacerAuto.Checked = True
            rbtnSpacerFixed.Checked = False
        ElseIf My.Settings.SpacerMode = "Fixed" Then
            rbtnSpacerAuto.Checked = False
            rbtnSpacerFixed.Checked = True
        End If

        currentServer = My.Settings.server
        currentDatabase = My.Settings.database
        currentIP = My.Settings.settingIPAddress
        currentPLCIP = My.Settings.PLCIP
        currentPort1 = My.Settings.Port1
        currentPort2 = My.Settings.Port2
        currentPort3 = My.Settings.Port3
        currentPort4 = My.Settings.Port4
        currentPort5 = My.Settings.OpenPort
        currentFixFBK = My.Settings.FixFBK
        currentFixFBC = My.Settings.FixFBC
        currentFixFBHK = My.Settings.FixFBHK
        currentMin = My.Settings.Min
        currentMax = My.Settings.Max
        currentSpecRange = My.Settings.SpecRange
        currentSendDelay = My.Settings.SendDelay

        currentSampleSize = My.Settings.SampleSize
        currentFBValueSaveK = My.Settings.FBValueSaveK
        currentFBValueSavec = My.Settings.FBValueSaveC
        currentFBValueSaveHK = My.Settings.FBValueSaveHK

        currentFixedSpacerHKA = My.Settings.H_KA
        currentFixedSpacerHKC = My.Settings.H_KC
        currentFixedSpacerHCB = My.Settings.H_CB
        currentFixedSpacerHCD = My.Settings.H_CD
        currentFixedSpacerHHKA = My.Settings.H_HKA
        currentFixedSpacerHHKC = My.Settings.H_HKC
        currentFBFormula = My.Settings.FBFormula



        'SQL connection 
        txtServer.Text = My.Settings.server
        txtDatabase.Text = My.Settings.database

        'TCP connection - PC
        txtSettingAddress.Text = My.Settings.settingIPAddress
        txtPort1.Text = My.Settings.Port1
        txtPort2.Text = My.Settings.Port2
        txtPort3.Text = My.Settings.Port3

        'Fix Feedback Value
        tbFixedFBK.Text = My.Settings.FixFBK
        tbFixedFBC.Text = My.Settings.FixFBC
        tbFixedFBHK.Text = My.Settings.FixFBHK

        'Min Max
        tbMin.Text = My.Settings.Min
        tbMax.Text = My.Settings.Max
        tbSampleSize.Text = My.Settings.SampleSize

        'cutoff
        txtCutOff.Text = My.Settings.cutOff
        If txtCutOff.Text = "0" Then
            txtCutOff.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
        Else
            txtCutOff.Text = My.Settings.cutOff
        End If

        'Fix spacer
        tbHKA.Text = My.Settings.H_KA
        tbHKC.Text = My.Settings.H_KC
        tbHCB.Text = My.Settings.H_CB
        tbHCD.Text = My.Settings.H_CD
        tbHHKA.Text = My.Settings.H_HKA
        tbHHKC.Text = My.Settings.H_HKC

        ' Specification Range
        tbSpecRange.Text = My.Settings.SpecRange

        ' Send Delay
        tbSendDelay.Text = My.Settings.SendDelay

        ' Design Value
        tbCLBdv.Text = My.Settings.CLBdv
        tbHousingDv.Text = My.Settings.Housingdv
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If rbtnDisableDS.Checked = True Then
            My.Settings.dsMode = False
        End If
        If rbtnEnableDS.Checked = True Then
            My.Settings.dsMode = True
        End If

        If rbtnOFF.Checked = True Then
            My.Settings.ExpectedCLBControl = False
        End If
        If rbtnON.Checked = True Then
            My.Settings.ExpectedCLBControl = True
        End If

        If rbtnFBFormulaDIF.Checked = True Then
            My.Settings.FBFormula = False
        End If
        If rbtnFBFormulaIEF.Checked = True Then
            My.Settings.FBFormula = True
        End If

        If rbtnFeedbackEnable.Checked = True Then
            My.Settings.feedback = "Enable"
        End If
        If rbtnFeedbackDisable.Checked = True Then
            My.Settings.feedback = "Disable"
        End If
        If rbtnFixedFB.Checked = True Then
            My.Settings.feedback = "Fixed"
        End If
        If rbtnMinMax.Checked = True Then
            My.Settings.feedback = "MinMax"
        End If

        If rbtnSpacerAuto.Checked = True Then
            My.Settings.SpacerMode = "Auto"
        End If
        If rbtnSpacerFixed.Checked = True Then
            My.Settings.SpacerMode = "Fixed"
        End If

        If rbtnFBFormulaDIF.Checked = True Then
            My.Settings.FBFormula = "DIF"
        End If
        If rbtnFBFormulaIEF.Checked = True Then
            My.Settings.FBFormula = "IDF"
        End If
        If rbtnAklifTheory.Checked = True Then
            My.Settings.FBFormula = "EDF"
        End If

        My.Settings.server = txtServer.Text
        My.Settings.database = txtDatabase.Text
        My.Settings.settingIPAddress = txtSettingAddress.Text
        My.Settings.Port1 = txtPort1.Text
        My.Settings.Port2 = txtPort2.Text
        My.Settings.Port3 = txtPort3.Text
        My.Settings.FixFBK = tbFixedFBK.Text
        My.Settings.FixFBC = tbFixedFBC.Text
        My.Settings.FixFBHK = tbFixedFBHK.Text
        My.Settings.Min = tbMin.Text
        My.Settings.Max = tbMax.Text
        My.Settings.SampleSize = tbSampleSize.Text
        My.Settings.FBValueSaveK = My.Settings.FixFBK
        My.Settings.FBValueSaveC = My.Settings.FixFBC
        My.Settings.FBValueSaveHK = My.Settings.FixFBHK

        My.Settings.cutOff = txtCutOff.Text

        My.Settings.H_KA = tbHKA.Text
        My.Settings.H_KC = tbHKC.Text
        My.Settings.H_CB = tbHCB.Text
        My.Settings.H_CD = tbHCD.Text
        My.Settings.H_HKA = tbHHKA.Text
        My.Settings.H_HKC = tbHHKC.Text

        My.Settings.CLBdv = tbCLBdv.Text
        My.Settings.Housingdv = tbHousingDv.Text

        My.Settings.SpecRange = tbSpecRange.Text
        My.Settings.SendDelay = tbSendDelay.Text
        My.Settings.Save()
        My.Settings.Reload()

        objSQL.InitializeConnectionString()

        Try
            If objSQL.CheckSQLConnection() = True Then
                Me.DialogResult = System.Windows.Forms.DialogResult.OK
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("No database connection. Kindly check the connection string or network." & vbCrLf & vbCrLf &
                   ex.Message)
        End Try
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click

        My.Settings.server = currentServer
        My.Settings.database = currentDatabase
        My.Settings.settingIPAddress = currentIP
        My.Settings.PLCIP = currentPLCIP
        My.Settings.Port1 = currentPort1
        My.Settings.Port2 = currentPort2
        My.Settings.Port3 = currentPort3
        My.Settings.Port4 = currentPort4
        My.Settings.OpenPort = currentPort5
        My.Settings.FixFBK = currentFixFBK
        My.Settings.FixFBC = currentFixFBC
        My.Settings.FixFBHK = currentFixFBHK
        My.Settings.Min = currentMin
        My.Settings.Max = currentMax
        My.Settings.SampleSize = currentSampleSize

        If txtCutOff.Text = "0" Then
            txtCutOff.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
        Else
            txtCutOff.Text = My.Settings.cutOff
        End If

        My.Settings.H_KA = currentFixedSpacerHKA
        My.Settings.H_KC = currentFixedSpacerHKC
        My.Settings.H_CB = currentFixedSpacerHCB
        My.Settings.H_CD = currentFixedSpacerHCD
        My.Settings.H_HKA = currentFixedSpacerHHKA
        My.Settings.H_HKC = currentFixedSpacerHHKC
        My.Settings.SpecRange = currentSpecRange
        My.Settings.SendDelay = currentSendDelay
        My.Settings.CLBdv = currentCLBdv
        My.Settings.Housingdv = currentHousingDv

        My.Settings.Save()
        My.Settings.Reload()

        'Dim frmMain As New MainForm
        'frmMain.MainForm_Load(Nothing, Nothing)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub



    Private Sub btnTestConnection_Click(sender As Object, e As EventArgs) Handles btnTestConnection.Click

        Dim NewServer As String = txtServer.Text
        Dim NewDatabase As String = txtDatabase.Text

        My.Settings.server = NewServer
        My.Settings.database = NewDatabase
        My.Settings.Save()
        My.Settings.Reload()

        Try
            objSQL.InitializeConnectionString()
            If objSQL.CheckSQLConnection() = True Then
                MsgBox("Database connected")
            End If

        Catch ex As Exception

            MsgBox("No database connection" & vbCrLf &
                       "Server : " & My.Settings.server & vbCrLf &
                       "Database : " & My.Settings.database & vbCrLf & vbCrLf &
                       ex.Message)

        End Try
    End Sub

    Private Sub btnGetPCIP_Click(sender As Object, e As EventArgs) Handles btnGetPCIP.Click
        txtSettingAddress.Text = My.Settings.pcIPAddress
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtCutOff.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
        ' My.Settings.cutOff = txtCutOff.Text
    End Sub
End Class