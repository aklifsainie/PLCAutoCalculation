Imports System.ComponentModel.BackgroundWorker
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Net
Imports System.Net.Sockets
Imports System.Net.Dns
Imports System.Diagnostics.Eventing
Imports System.Runtime.Remoting.Contexts
Imports System.Diagnostics.Trace
Imports System.IO
Imports System.Windows.Forms.DataVisualization.Charting


'================================ IF HAVE ADDITIONAL PORTS ====================================
'                                                                                             =
'Function affected :                                                                          =
'------------------> MainForm_Load()                                                          =
'                           - Default setting for first time installation                     =
'                           - TCP Connection settings                                         =
'                           - Rename display connection string according to latest setting    =
'------------------> GoingToRunBGT() function                                                 =
'------------------> GoingToStopBGT() function                                                =
'                                                                              Aklif Sainie   =
'==============================================================================================



Public Class MainForm


    '########################## VARIABLES DECLARATION #################################

    Private objSQL As New SQLController
    Dim objSQLNGList As New SQLController

    'Constant variables
    Private Property TOTALMOUNT As Integer = objSQL.InitializeFixedVariables("TotalMount")
    Private Property HOUSINGRAWDATA As Integer = objSQL.InitializeFixedVariables("HousingRawData")
    Private Property CLBRAWDATA As Integer = objSQL.InitializeFixedVariables("CLBRawData")
    Private Property FBVALUETOTALINDEX As Integer = objSQL.InitializeFixedVariables("FBValueTotalIndex")
    Private Property TOTALPORT As Integer = objSQL.InitializeFixedVariables("TotalPort")
    Private Property PORT1TOPLC As Integer = objSQL.InitializeFixedVariables("Port1ToPLC")
    Private Property PORT2TOPLC As Integer = objSQL.InitializeFixedVariables("Port2ToPLC")
    Private Property PORT3TOPLC As Integer = objSQL.InitializeFixedVariables("Port3ToPLC")
    Private Property FEEDBACKSPACER As String = objSQL.InitializeFixedVariables("FeedbackSpacer")
    Private Property SINGLESPACER As String = objSQL.InitializeFixedVariables("SingleSpacer")
    Private Property OKRESULT As String = objSQL.InitializeFixedVariables("OKResult")
    Private Property NGRESULT As String = objSQL.InitializeFixedVariables("NGResult")
    Private Property DRAFTLOGNAME As String = objSQL.InitializeFixedVariables("DRAFTLogName")
    Private Property DATATRANSLOGNAME As String = objSQL.InitializeFixedVariables("DataTransactionLog")
    Private Property ALARMERROR As String = objSQL.InitializeFixedVariables("AlarmError")
    Private Property CONFIRMATIONTOPLC As String = objSQL.InitializeFixedVariables("ConfirmationToPLC")
    Private Property ERRORLOG As String = objSQL.InitializeFixedVariables("ErrorLog")
    Private Property EXPECTEDNG As String = objSQL.InitializeFixedVariables("ExpectedNG")

    'System variables
    Private Property actualIPAddress = GetPCIpAddress()
    Private Property dsMode As String
    Private Property feedbackMode As String
    Private Property station As String
    Private Property serialNo As String
    Private Property errorMessage As String
    Private housingMeasurement(HOUSINGRAWDATA) As Double
    Private clbMeasurement(CLBRAWDATA) As Double
    Private isPortConnected(2, TOTALPORT) As Boolean
    Private Property isStartServer As Boolean = False
    Private Property isSidebarOpen As Boolean = False
    Private Property isStartButtonPanel As Boolean = True

    Private Property Port1Confirmation As Boolean = False
    Private Property Port2Confirmation As Boolean = False
    Private Property Port3Confirmation As Boolean = False

    'Objects
    Private objTCP(TOTALPORT) As TCPController
    Private objBuffer As Buffer
    Private objAddress As New AddressController

    'Log file
    Dim DRAFTLog As String = DateTime.Today.ToString("yyyyMMdd") & "_" & DRAFTLOGNAME
    Dim DataTransLog As String = DATATRANSLOGNAME
    Dim LogFilePath As String = objSQL.InitializeFixedVariables("LogFilePath")
    Dim LogWriter1 As StreamWriter
    Dim LogWriter2 As StreamWriter
    Dim LogWriter3 As StreamWriter
    Dim ErrologWriter As StreamWriter
    Dim LogReader As StreamReader

    Dim newLBL(TOTALPORT) As Label

    '#################################################################################

    'CONSTRUCTOR
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
    End Sub


    '13/5/2022 Aklif Sainie : Initial creation of GetPCIpAddress() function
    'To get the this computer's current IP Address
    Public Function GetPCIpAddress()
        Dim PCHostName = GetHostName() 'Get PC hostname
        Return GetHostByName(PCHostName).AddressList(0).ToString() 'Get PC IP address
    End Function

    Public Sub CreateLogFilePath()
        If Not Directory.Exists(LogFilePath) Then 'If log folder not yet exist
            Directory.CreateDirectory(LogFilePath) 'Create folder
        End If

        If Not File.Exists(LogFilePath & DRAFTLog) Then
            LogWriter1 = My.Computer.FileSystem.OpenTextFileWriter(LogFilePath & DateTime.Today.ToString("yyyyMMdd") & "_Port1_" & DRAFTLOGNAME, True)
            LogWriter2 = My.Computer.FileSystem.OpenTextFileWriter(LogFilePath & DateTime.Today.ToString("yyyyMMdd") & "_Port2_" & DRAFTLOGNAME, True)
            LogWriter3 = My.Computer.FileSystem.OpenTextFileWriter(LogFilePath & DateTime.Today.ToString("yyyyMMdd") & "_Port3_" & DRAFTLOGNAME, True)
            'Log file header
            LogWriter1.WriteLine("Register,SerialNo,ActionName,Status")
            LogWriter2.WriteLine("Register,SerialNo,ActionName,Status")
            LogWriter3.WriteLine("Register,SerialNo,ActionName,Status")
            LogWriter1.Close()
            LogWriter2.Close()
            LogWriter3.Close()
        End If

        If Not File.Exists(LogFilePath & ERRORLOG) Then
            ErrologWriter = My.Computer.FileSystem.OpenTextFileWriter(LogFilePath & ERRORLOG, True)
            'Log file header
            ErrologWriter.WriteLine("RegistrationDate,ErrorMessage")
            ErrologWriter.Close()
        End If
    End Sub


    'Public Sub WriteToDRAFTLog1(snum As String, ActionName As String, Status As Boolean)

    '    Try
    '        CreateLogFilePath()
    '        LogWriter1 = My.Computer.FileSystem.OpenTextFileWriter(LogFilePath & DRAFTLog, True)
    '        LogWriter1.WriteLine(DateTime.Now & "," & snum & "," & ActionName & "," & Status)
    '        LogWriter1.Close()
    '    Catch ex As Exception
    '        Exit Sub
    '    End Try
    'End Sub

    'Public Sub WriteToDRAFTLog2(snum As String, ActionName As String, Status As Boolean)

    '    Try
    '        CreateLogFilePath()
    '        LogWriter2 = My.Computer.FileSystem.OpenTextFileWriter(LogFilePath & DRAFTLog, True)
    '        LogWriter2.WriteLine(DateTime.Now & "," & snum & "," & ActionName & "," & Status)
    '        LogWriter2.Close()
    '    Catch ex As Exception
    '        Exit Sub
    '    End Try
    'End Sub

    'Public Sub WriteToDRAFTLog3(snum As String, ActionName As String, Status As Boolean)

    '    Try
    '        CreateLogFilePath()
    '        LogWriter3 = My.Computer.FileSystem.OpenTextFileWriter(LogFilePath & DRAFTLog, True)
    '        LogWriter3.WriteLine(DateTime.Now & "," & snum & "," & ActionName & "," & Status)
    '        LogWriter3.Close()
    '    Catch ex As Exception
    '        Exit Sub
    '    End Try
    'End Sub


    'Public Sub WriteToErrorLog(Message As String)

    '    Try
    '        CreateLogFilePath()
    '        ErrologWriter = My.Computer.FileSystem.OpenTextFileWriter(LogFilePath & ERRORLOG, True)
    '        ErrologWriter.WriteLine(DateTime.Now & "," & Message)
    '        ErrologWriter.Close()

    '    Catch ex As Exception
    '        Exit Sub
    '    End Try
    'End Sub

    '11/5/2022 Aklif Sainie : Initial Creation of MainForm_Load
    Public Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Get mode
        Dim appMode As String = "RELEASE"

#If DEBUG Then
        appMode = "DEBUG"
#End If

        If My.Settings.dsMode = False Then
            dsMode = "Inactive"
            lblMode.BackColor = Color.White
            lblMode.ForeColor = Color.Black
            lblMode.BorderStyle = BorderStyle.FixedSingle
        ElseIf My.Settings.dsMode = True Then
            dsMode = "Active"
            lblMode.BackColor = Color.Green
            lblMode.ForeColor = Color.White
            lblMode.BorderStyle = BorderStyle.None
        End If

        If My.Settings.feedback = "Disable" Then
            feedbackMode = "Disable"
            lblFeedbackMode.BackColor = Color.White
            lblFeedbackMode.ForeColor = Color.Black
            lblFeedbackMode.BorderStyle = BorderStyle.FixedSingle
        ElseIf My.Settings.feedback = "Enable" Then
            feedbackMode = "Enable"
            lblFeedbackMode.BackColor = Color.Green
            lblFeedbackMode.ForeColor = Color.White
            lblFeedbackMode.BorderStyle = BorderStyle.None

        ElseIf My.Settings.feedback = "Fixed" Then
            feedbackMode = "Fixed"
            lblFeedbackMode.BackColor = Color.DarkBlue
            lblFeedbackMode.ForeColor = Color.White
            lblFeedbackMode.BorderStyle = BorderStyle.None

        ElseIf My.Settings.feedback = "MinMax" Then
            feedbackMode = "MinMax"
            lblFeedbackMode.BackColor = Color.DarkGray
            lblFeedbackMode.ForeColor = Color.White
            lblFeedbackMode.BorderStyle = BorderStyle.None
        End If

        Me.Text = "DR Auto Feedback System - DRAFT v" & My.Application.Info.Version.ToString
        My.Settings.pcIPAddress = actualIPAddress
        My.Settings.Save()
        My.Settings.Reload()

        '##########################################################################################################
        '#############################---DEFAULT SETTINGS FOR FIRST TIME INSTALLATION---###########################
        '##########################################################################################################


        'Initilize the setting Ip Address @ Application Ip Address and the port numbers
        If My.Settings.settingIPAddress = "" Then
            My.Settings.settingIPAddress = "127.0.0.1"
        End If
        If My.Settings.PLCIP = "" Then
            My.Settings.PLCIP = "192.168.2.2"
        End If
        If My.Settings.Port1 = "" Then
            My.Settings.Port1 = "9001"
        End If
        If My.Settings.Port2 = "" Then
            My.Settings.Port2 = "9002"
        End If
        If My.Settings.Port3 = "" Then
            My.Settings.Port3 = "9003"
        End If

        ' Conditional server & database settings based on debug or release mode
#If DEBUG Then
        If My.Settings.server = "" Then
            My.Settings.server = "10.244.5.10"
        End If
        If My.Settings.database = "" Then
            My.Settings.database = "DRAFSystem_MY"
        End If
#Else
        If My.Settings.server = "" Then
            My.Settings.server = "BMMYEDKGTMS3"
        End If
        If My.Settings.database = "" Then
            My.Settings.database = "DRAFSystem_MY"
        End If
#End If
        My.Settings.Save()
        My.Settings.Reload()

        ' If the setting Ip Address(application Ip address) is not the same
        ' with the computer Ip address, then it will pop out confirmation windows to change Ip
        If My.Settings.settingIPAddress <> My.Settings.pcIPAddress Then
            objAddress.ShowDialog()
            If objAddress.Status() = "OK" Then
                My.Settings.settingIPAddress = My.Settings.pcIPAddress
                My.Settings.Save()
                My.Settings.Reload()
            ElseIf objAddress.Status() = "Cancel" Then
                OpenSettings()
            End If
        End If

        lblValueHousingKA.Text = ""
        lblValueHousingKC.Text = ""
        lblValueHousingCB.Text = ""
        lblValueHousingCD.Text = ""
        lblValueHousingHKA.Text = ""
        lblValueHousingHKC.Text = ""
        lblValueHousingCK.Text = ""
        lblValueHousingCC.Text = ""
        lblValueHousingCHK.Text = ""
        lblSN.Text = ""

        lblMode.Text = "DS Mode" & vbCrLf & dsMode
        lblFeedbackMode.Text = "Feedback" & vbCrLf & feedbackMode
        lblInfoPort1.Text = My.Settings.Port1
        lblInfoPort2.Text = My.Settings.Port2
        lblInfoPort3.Text = My.Settings.Port3
        lblInfoIpAddress.Text = My.Settings.settingIPAddress
        lblInfoServer.Text = My.Settings.server
        lblInfoDatabase.Text = My.Settings.database
        '##########################################################################################################
        '##########################################################################################################
        '##########################################################################################################
        Try
            'Initialize SQL connection variables
            objSQL.InitializeConnectionString()

            'Error handling for SQL connection
            If objSQL.CheckSQLConnection() = True Then

                'RefreshDGVNGSN()
                '##########################################################################################################
                '##################################---TCP Connection Initialization---#####################################
                '##########################################################################################################

                'For loop - To initialize TCP connection for all different port numbers
                Dim PortNumber As String
                For i = 0 To TOTALPORT - 1
                    objTCP(i) = New TCPController(actualIPAddress, PortNumber)
                Next

                CreateLogFilePath()

                CheckForIllegalCrossThreadCalls = False
                'txtMessage.Focus()
            Else
                WriteToRTB("Database connection string error")
            End If
        Catch ex As Exception
            WriteToRTB(ex.Message)
        End Try

    End Sub

    Public Sub ClearDGVSNList()
        dgvNGSN.DataSource = Nothing
        objSQL.ds.Clear()
    End Sub

    Public Sub DGVRawData()
        Try
            ' Save current position
            Dim rowIndex As Integer = dgvNGSN.FirstDisplayedScrollingRowIndex
            Dim columnIndex As Integer = dgvNGSN.FirstDisplayedScrollingColumnIndex



            'dgvNGSN.DataSource = Nothing
            dgvNGSN.DataSource = objSQLNGList.GetNGSN().Tables(0)
            dgvNGSN.AutoGenerateColumns = False
            dgvNGSN.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill


            ' Restore position
            If rowIndex <> -1 AndAlso rowIndex < dgvNGSN.RowCount Then
                dgvNGSN.FirstDisplayedScrollingRowIndex = rowIndex
            End If
            If columnIndex <> -1 AndAlso columnIndex < dgvNGSN.ColumnCount Then
                dgvNGSN.FirstDisplayedScrollingColumnIndex = columnIndex
            End If
        Catch ex As Exception

        End Try

    End Sub

    ' 20/8/2022 Aklif Sainie : Initial creation of ResetAllVariables() function
    ' To clear all system variables value
    Private Sub ResetAllVariables()
        station = ""
        serialNo = ""
        errorMessage = ""
        For n = 0 To HOUSINGRAWDATA - 1
            housingMeasurement(n) = 0
        Next
        For p = 0 To CLBRAWDATA - 1
            clbMeasurement(p) = 0
        Next
    End Sub


    ' Going to settings form
    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        OpenSettings()
    End Sub

    Private Sub OpenSettings()
        Dim objDialogPassword As New dlgPassword
        Dim objSettings As New frmSettings

        If objDialogPassword.ShowDialog() <> System.Windows.Forms.DialogResult.OK Then
            Exit Sub
        End If

        If objSettings.ShowDialog() <> System.Windows.Forms.DialogResult.OK Then
            Exit Sub
        End If

        '#########################################################################################
        '##########---RENAME DISPLAYED CONNECTION STRING ACCORDING TO LATEST SETTINGS---##########
        '#########################################################################################

        Me.Text = "DR Auto Feedback System - DRAFT v" & My.Application.Info.Version.ToString

        lblInfoIpAddress.Text = My.Settings.settingIPAddress
        lblInfoServer.Text = My.Settings.server
        lblInfoDatabase.Text = My.Settings.database
        lblInfoPort1.Text = My.Settings.Port1
        lblInfoPort2.Text = My.Settings.Port2
        lblInfoPort3.Text = My.Settings.Port3

        If My.Settings.dsMode = False Then
            dsMode = "Inactive"
            lblMode.BackColor = Color.White
            lblMode.ForeColor = Color.Black
            lblMode.BorderStyle = BorderStyle.FixedSingle
        ElseIf My.Settings.dsMode = True Then
            dsMode = "Active"
            lblMode.BackColor = Color.Green
            lblMode.ForeColor = Color.White
            lblMode.BorderStyle = BorderStyle.None
        End If

        If My.Settings.feedback = "Disable" Then
            feedbackMode = "Disable"
            lblFeedbackMode.BackColor = Color.White
            lblFeedbackMode.ForeColor = Color.Black
            lblFeedbackMode.BorderStyle = BorderStyle.FixedSingle
        ElseIf My.Settings.feedback = "Enable" Then
            feedbackMode = "Enable"
            lblFeedbackMode.BackColor = Color.Green
            lblFeedbackMode.ForeColor = Color.White
            lblFeedbackMode.BorderStyle = BorderStyle.None
        ElseIf My.Settings.feedback = "Fixed" Then
            feedbackMode = "Fixed"
            lblFeedbackMode.BackColor = Color.DarkBlue
            lblFeedbackMode.ForeColor = Color.White
            lblFeedbackMode.BorderStyle = BorderStyle.None
        ElseIf My.Settings.feedback = "MinMax" Then
            feedbackMode = "MinMax"
            lblFeedbackMode.BackColor = Color.DarkGray
            lblFeedbackMode.ForeColor = Color.White
            lblFeedbackMode.BorderStyle = BorderStyle.None
        End If

        lblMode.Text = "DS Mode" & vbCrLf & dsMode
        lblFeedbackMode.Text = "Feedback" & vbCrLf & feedbackMode
        '#########################################################################################
        '#########################################################################################
        '#########################################################################################
    End Sub



    ' Close and exit application
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        If btnStart.Text = "Click to Start" Then

            For i = 0 To TOTALPORT - 1
                isPortConnected(0, i) = False
            Next

            ' UI changing
            btnStart.Text = "Click to Stop"
            btnStart.Image = My.Resources.stop_button

            btnStartServer.Text = "  Stop"
            btnStartServer.Image = My.Resources.stop_button__1_

            lblPort1Status.Visible = True
            lblPort2Status.Visible = True
            lblPort3Status.Visible = True

            isStartServer = True

            'User interface changes after start server
            WriteToRTB("::SERVER STARTED::")
            WriteToRTB(".....Waiting for client request.....")

            'Start background task for data transfer port 9001,9002,9003,9004
            bgtStartingServer = New System.ComponentModel.BackgroundWorker
            bgtStartingServer.RunWorkerAsync()
            bgtStartingServer.WorkerSupportsCancellation = True
            Port1Timer.Start()
        ElseIf btnStart.Text = "Click to Stop" Then

            'UI changing
            btnStart.Text = "Click to Start"
            btnStart.Image = My.Resources.play__2_

            btnStartServer.Text = "  Start"
            btnStartServer.Image = My.Resources.play

            lblPort1Status.Visible = False
            lblPort1Status.Image = Nothing
            lblPort1Status.Text = "...waiting client to connect Port 1..."

            lblPort2Status.Visible = False
            lblPort2Status.Image = Nothing
            lblPort2Status.Text = "...waiting client to connect Port 2..."

            lblPort3Status.Visible = False
            lblPort3Status.Image = Nothing
            lblPort3Status.Text = "...waiting client to connect Port 3..."

            Port1Confirmation = False
            Port2Confirmation = False
            Port3Confirmation = False
            isStartServer = False

            Port1Timer.Stop()
            bgtStartingServer.CancelAsync()
            StartServer()
        End If
    End Sub

    Private Sub btnStartServer_Click(sender As Object, e As EventArgs) Handles btnStartServer.Click

        If btnStartServer.Text = "  Stop" Then
            'UI changing
            btnStart.Text = "Click to Start"
            btnStart.Image = My.Resources.play__2_

            btnStartServer.Text = "  Start"
            btnStartServer.Image = My.Resources.play

            lblPort1Status.Visible = False
            lblPort1Status.Image = Nothing
            lblPort1Status.Text = "...waiting client to connect Port 1..."

            lblPort2Status.Visible = False
            lblPort2Status.Image = Nothing
            lblPort2Status.Text = "...waiting client to connect Port 2..."

            lblPort3Status.Visible = False
            lblPort3Status.Image = Nothing
            lblPort3Status.Text = "...waiting client to connect Port 3..."

            Port1Confirmation = False
            Port2Confirmation = False
            Port3Confirmation = False
            isStartServer = False

            Port1Timer.Stop()
            pnlStartServer.Visible = True
            bgtStartingServer.CancelAsync()
            StartServer()
        ElseIf btnStartServer.Text = "  Start" Then
            If isStartServer = False Then
                MsgBox("Kindly use the main button to start server", 0, "Error")
            End If
        End If
    End Sub

    Private Sub bgtStartingServer_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgtStartingServer.DoWork
        StartServer()
    End Sub


    Public Sub StartServer()
        If btnStart.Text = "Click to Stop" Then

            For i = 0 To TOTALPORT - 1

                'Start servers - Server ports are separated by objects array of TCPController
                objTCP(i).StartServer(i)

                'Run all background tasks
                ' The Background tasks is for data transaction management - how it react and manage data
                StartPortBGT(i + 1)
                WriteToRTB("Port " & i + 1 & " has connected to client.")
                'isPortConnected(1, i) = True
            Next


        ElseIf btnStartServer.Text = "Click to Start" Then

            'Stop all 4 servers
            For i = 0 To TOTALPORT - 1

                If objTCP(i).StopServer() = True Then
                    GoingToStopBGT(i + 1)
                End If
            Next

            WriteToRTB(Convert.ToString(Date.Now) + " >>> ::SERVER HAS STOPPED::")

            'Empty all application variables and value on UI
            ResetAllVariables() 'Value of application variables


        End If
    End Sub


    Public Sub StopServer()
        If btnStartServer.Text = "  Stop" Then

            'Stop all 4 servers
            For i = 0 To TOTALPORT - 1

                If objTCP(i).StopServer() = True Then
                    GoingToStopBGT(i + 1)
                End If
            Next

            WriteToRTB(Convert.ToString(Date.Now) + " >>> ::SERVER HAS STOPPED::")

            'Empty all application variables and value on UI
            ResetAllVariables() 'Value of application variables

            'UI changing
            btnStartServer.Text = "  Start"
            btnStartServer.ForeColor = Color.White
            btnStartServer.BackColor = Color.Teal
        End If
    End Sub



    Public Sub StartPortBGT(port As Integer)

        If port = 1 Then
            bgtPort1 = New System.ComponentModel.BackgroundWorker
            bgtPort1.RunWorkerAsync()
            bgtPort1.WorkerSupportsCancellation = True
        ElseIf port = 2 Then
            bgtPort2 = New System.ComponentModel.BackgroundWorker
            bgtPort2.RunWorkerAsync()
            bgtPort2.WorkerSupportsCancellation = True
        ElseIf port = 3 Then
            bgtPort3 = New System.ComponentModel.BackgroundWorker
            bgtPort3.RunWorkerAsync()
            bgtPort3.WorkerSupportsCancellation = True
        ElseIf port = 4 Then
            bgtPort4 = New System.ComponentModel.BackgroundWorker
            bgtPort4.RunWorkerAsync()
            bgtPort4.WorkerSupportsCancellation = True
        End If
        'WriteToRTB("Port " & port & " has connected to client.")
    End Sub

    Public Sub GoingToStopBGT(port As Integer)

        Try
            If port = 1 Then
                bgtPort1.CancelAsync()
            ElseIf port = 2 Then
                bgtPort2.CancelAsync()
            ElseIf port = 3 Then
                bgtPort3.CancelAsync()
            End If
        Catch ex As Exception

        End Try

    End Sub

    Public Sub RestartServer(PortNo As Integer)
        objTCP(PortNo - 1).StopServer()
        GoingToStopBGT(PortNo)
        objTCP(PortNo - 1).StartServer(PortNo - 1)
        StartPortBGT(PortNo)
    End Sub


    '15/8/2022 Aklif Sainie : Initial creation of bgtPort1 function
    Private Sub bgtPort1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgtPort1.DoWork


        'Data sample Housing : ST1, ABC00001, 13,12,13,14,15,16 
        'Data sample CLB : SUB1, 10,10,10
        Dim splitData As String()

        While (objTCP(0).IsServerClientConnected = True)
            Try
                Dim rawDataPort1 As String = ""
                rawDataPort1 = objTCP(0).GetSTR()
                If rawDataPort1 = "1" Then

                    Threading.Thread.Sleep(My.Settings.InitConnectDelay)
                    objTCP(PORT1TOPLC - 1).TextToSend("10\r")
                    lblPort1Status.Text = "Port 1 connected"
                    lblPort1Status.Image = My.Resources.yes
                    Port1Confirmation = True
                    RestartServer(1)
                    Exit While
                End If

                If rawDataPort1 = Nothing Or rawDataPort1 = "" Or rawDataPort1 = vbNullChar Then
                    RestartServer(1)
                    Exit While
                End If

                If Port1Confirmation = True Then

                    Dim rawData2 As String = rawDataPort1.Replace(vbNullChar, "")
                    splitData = rawData2.Split(New Char() {"_"}) 'split between delimiter

                    WriteToRTB("PLC > Port 1 : " & rawData2)

                    ' ERROR HANDLING
                    'serial number 
                    If splitData(5) = "" Or splitData(5) = Nothing Then
                        Threading.Thread.Sleep(My.Settings.SendDelay)
                        objTCP(PORT1TOPLC - 1).TextToSend(ALARMERROR)
                        Exit Try
                    End If


                    ' ERROR HANDLING
                    ' CLB K
                    If splitData(1).ToString().Length <> 5 Then
                        WriteToRTB("Port 1 : Number of digit for blade is incorrect : " & splitData(1))
                        Threading.Thread.Sleep(My.Settings.SendDelay)
                        objTCP(PORT1TOPLC - 1).TextToSend(ALARMERROR)
                        Exit Try
                    End If

                    ' ERROR HANDLING
                    ' CLB C
                    If splitData(2).ToString().Length <> 5 Then
                        WriteToRTB("Port 1 : Number of digit for blade is incorrect : " & splitData(2))
                        Threading.Thread.Sleep(My.Settings.SendDelay)
                        objTCP(PORT1TOPLC - 1).TextToSend(ALARMERROR)
                        Exit Try
                    End If

                    ' ERROR HANDLING
                    ' CLB HK
                    If splitData(3).ToString().Length <> 5 Then
                        Threading.Thread.Sleep(My.Settings.SendDelay)
                        objTCP(PORT1TOPLC - 1).TextToSend(ALARMERROR)
                        Exit Try
                    End If

                    ' ERROR HANDLING
                    ' HousingK A
                    If splitData(6).ToString().Length <> 5 Then
                        Threading.Thread.Sleep(My.Settings.SendDelay)
                        objTCP(PORT1TOPLC - 1).TextToSend(ALARMERROR)
                        Exit Try
                    End If

                    ' ERROR HANDLING
                    ' HousingK C
                    If splitData(7).ToString().Length <> 5 Then
                        Threading.Thread.Sleep(My.Settings.SendDelay)
                        objTCP(PORT1TOPLC - 1).TextToSend(ALARMERROR)
                        Exit Try
                    End If

                    ' ERROR HANDLING
                    ' HousingC B
                    If splitData(8).ToString().Length <> 5 Then
                        Threading.Thread.Sleep(My.Settings.SendDelay)
                        objTCP(PORT1TOPLC - 1).TextToSend(ALARMERROR)
                        Exit Try
                    End If

                    ' ERROR HANDLING
                    ' HousingC D
                    If splitData(9).ToString().Length <> 5 Then
                        Threading.Thread.Sleep(My.Settings.SendDelay)
                        objTCP(PORT1TOPLC - 1).TextToSend(ALARMERROR)
                        Exit Try
                    End If

                    ' ERROR HANDLING
                    ' HousingHK A
                    If splitData(10).ToString().Length <> 5 Then
                        Threading.Thread.Sleep(My.Settings.SendDelay)
                        objTCP(PORT1TOPLC - 1).TextToSend(ALARMERROR)
                        Exit Try
                    End If

                    ' ERROR HANDLING
                    ' HousingHK C
                    If splitData(11).ToString().Length <> 5 Then
                        Threading.Thread.Sleep(My.Settings.SendDelay)
                        objTCP(PORT1TOPLC - 1).TextToSend(ALARMERROR)
                        Exit Try
                    End If

                    '--------------------------------------------------------------------------
                    serialNo = splitData(5).ToString()
                    ' Populate data to model class of Port1Controller
                    Dim populateRawData As New Port1Controller With {
                        .CLBK = splitData(1) / 1000,
                        .CLBC = splitData(2) / 1000,
                        .CLBHK = splitData(3) / 1000,
                        .SerialNumber = splitData(5).ToString(),
                        .HousingKA = splitData(6) / 1000,
                        .HousingKC = splitData(7) / 1000,
                        .HousingCB = splitData(8) / 1000,
                        .HousingCD = splitData(9) / 1000,
                        .HousingHKA = splitData(10) / 1000,
                        .HousingHKC = splitData(11) / 1000
                    }

                    ' Interface Changes
                    lblValueHousingKA.Text = splitData(6) / 1000
                    lblValueHousingKC.Text = splitData(7) / 1000
                    lblValueHousingCB.Text = splitData(8) / 1000
                    lblValueHousingCD.Text = splitData(9) / 1000
                    lblValueHousingHKA.Text = splitData(10) / 1000
                    lblValueHousingHKC.Text = splitData(11) / 1000
                    lblValueHousingCK.Text = splitData(1) / 1000
                    lblValueHousingCC.Text = splitData(2) / 1000
                    lblValueHousingCHK.Text = splitData(3) / 1000
                    lblSN.Text = splitData(5).ToString()

                    ' Execute Function DBCLBHousingMeasurement() in Port1Controller to store data
                    populateRawData.DBCLBHousingMeasurement()

                    ' Execute Function ProgressStation() in Port1Controller to store data
                    populateRawData.ProgressStation()


                    If My.Settings.dsMode = False Then ' Moving Average Algorithm

                        ' Calculate using moving average algorigthm then store calculated value into database
                        ' Data store in DBSpacerChoiceCalculation table
                        If populateRawData.MovingAverage() = True Then
                            WriteToRTB("PC > Port 1 : Spacer for " & splitData(5).ToString() & " calculated and stored into the database.")
                            SendSpacer()
                        Else
                            WriteToRTB("PC > Port 1 : (" & serialNo & ") Failed to calculate spacer selection and no calculation data was stored into the database")
                            'SendText(ALARMERROR, 1)
                        End If

                    ElseIf My.Settings.dsMode = True Then ' DS Mode Algorithm

                        If populateRawData.DSModeCalculation() = True Then
                            WriteToRTB("PC > Port 1 : Spacer for " & serialNo & " calculated using DS Mode functionality and has stored into the database.")
                            SendSpacer()
                        Else
                            WriteToRTB("PC > Port 1 : (" & serialNo & ") Failed to calculate spacer selection and no calculation data was stored into the database")
                        End If

                    End If
                End If
            Catch ex As Exception
                RestartServer(1)
                Exit While
            End Try
        End While
    End Sub

    '18/8/2022 Aklif Sainie : Initial creation of bgtPort2 function
    Private Sub bgtPort2_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgtPort2.DoWork


        Dim ReceiveMessagePort2 As String = "" 'will receive serialnumber
        Dim splitDataBGT2 As String()
        While (objTCP(1).IsServerClientConnected = True)

            'Data sample : SerialNo, CLB K measurement, CLB C measurement, CLB HK measurement
            Try
                ReceiveMessagePort2 = objTCP(1).GetSTR()

                If ReceiveMessagePort2 = "2" Then
                    If Port1Confirmation = True Then
                        Threading.Thread.Sleep(My.Settings.InitConnectDelay)
                        objTCP(PORT2TOPLC - 1).TextToSend("20\r")
                        lblPort2Status.Text = "Port 2 connected"
                        lblPort2Status.Image = My.Resources.yes
                        Port2Confirmation = True

                    End If
                    RestartServer(2)
                    Exit While
                End If

                If ReceiveMessagePort2 = Nothing Or ReceiveMessagePort2 = "" Or ReceiveMessagePort2 = vbNullChar Then
                    RestartServer(2)
                    Exit While
                End If

                If Port2Confirmation = True Then
                    ReceiveMessagePort2 = ReceiveMessagePort2.Replace(vbNullChar, "")
                    splitDataBGT2 = ReceiveMessagePort2.Split(New Char() {"_"})
                    WriteToRTB("PLC > Port 2 : " & ReceiveMessagePort2)


                    'station remark
                    If splitDataBGT2(0) <> "ST6" Then
                        objTCP(PORT2TOPLC - 1).TextToSend(ALARMERROR)
                        Exit Try
                    End If

                    'Serial number
                    If splitDataBGT2(1) = "" Then
                        objTCP(PORT2TOPLC - 1).TextToSend(ALARMERROR)
                        Exit Try
                    End If

                    'CLB Height K
                    If splitDataBGT2(2).ToString.Length <> 5 Then
                        objTCP(PORT2TOPLC - 1).TextToSend(ALARMERROR)
                        Exit Try
                    End If

                    'CLB Height C
                    If splitDataBGT2(3).ToString.Length <> 5 Then
                        objTCP(PORT2TOPLC - 1).TextToSend(ALARMERROR)
                        Exit Try
                    End If

                    'CLB Height HK
                    If splitDataBGT2(4).ToString.Length <> 5 Then
                        objTCP(PORT2TOPLC - 1).TextToSend(ALARMERROR)
                        Exit Try
                    End If

                    ' Populate data to class Port2Controller
                    Dim populateRawData As New Port2Controller With {
                        .SerialNumber = splitDataBGT2(1),
                        .ResultCLBK = splitDataBGT2(2) / 1000,
                        .ResultCLBC = splitDataBGT2(3) / 1000,
                        .ResultCLBHK = splitDataBGT2(4) / 1000
                    }

                    ' Execute Function DBCLBHousingMeasurement() in Port1Controller to store data
                    populateRawData.DBCLBHousingMeasurement()

                    ' Execute Function ProgressStation() in Port1Controller to store data
                    populateRawData.ProgressStation()

                    WriteToRTB("Port 2 : Station 6 raw data and progress station has been inserted into the database")
                    Dim mountName As String
                    Dim fbValue(TOTALMOUNT) As Double

                    'Calculate Feedback value for each mount K, C, HK --> So total loop is 3
                    For i = 0 To TOTALMOUNT - 1

                        If i = 0 Then
                            mountName = "K"
                        ElseIf i = 1 Then
                            mountName = "C"
                        ElseIf i = 2 Then
                            mountName = "HK"
                        End If

                        'Judge if NG or OK, Spec must be between +- setting SpecRange
                        If splitDataBGT2(i + 2) / 1000 < (My.Settings.CLBdv - My.Settings.SpecRange) Or splitDataBGT2(i + 2) / 1000 > (My.Settings.CLBdv + My.Settings.SpecRange) Then

                            'Result is NG
                            objSQL.UpdateInspetionResult(splitDataBGT2(1), False)
                        Else

                            If objSQL.GetInspectionResult(splitDataBGT2(1)) = "NG" Then
                                objSQL.UpdateInspetionResult(splitDataBGT2(1), False)
                            ElseIf objSQL.GetInspectionResult(splitDataBGT2(1)) = "OK" Or objSQL.GetInspectionResult(splitDataBGT2(1)) = "NULL" Then
                                objSQL.UpdateInspetionResult(splitDataBGT2(1), True)
                            ElseIf objSQL.GetInspectionResult(splitDataBGT2(1)) = "No serial number" Then
                                WriteToRTB("splitDataBGT2(1) : No serial number found for inspection result at mount " & mountName)
                            End If
                        End If

                        'Calculate feedback value through SQL query
                        fbValue(i) = objSQL.CalculateFbValue(splitDataBGT2(1), mountName)

                        'Store the calculated feedback value into database
                        If objSQL.StoreFeedbackValue(fbValue(i), splitDataBGT2(1), mountName) = True Then
                            WriteToRTB("Port 2 : Feedback value for mount " & mountName & " calculated : " & fbValue(i))
                        Else
                            WriteToRTB("Port 2 : Failed to calculate feedback value mount " & mountName & " for " & splitDataBGT2(1))
                        End If
                    Next

                    'Update progress station 6
                    If objSQL.ProgressStation(splitDataBGT2(1), "ST6") = False Then
                        WriteToRTB("Port 2 : Failed to update progress DR2 station(ST6) into the database")
                        Exit Try
                    End If

                    Threading.Thread.Sleep(My.Settings.SendDelay)
                    objTCP(PORT2TOPLC - 1).TextToSend(CONFIRMATIONTOPLC)
                    WriteToRTB("Port 2 : Progress DR2 station (ST6) updated")
                End If
            Catch ex As Exception
                RestartServer(2)
                Exit While
            End Try
        End While
    End Sub

    '25/11/2022 Aklif Sainie : Initial creation
    Public Sub SendSpacer() 'Send spacer value after calculated

        Dim spacertexttosend As String

        Dim getSpacer As String
        Dim getSpacer2 As String()

        If My.Settings.SpacerMode = "Auto" Then
            getSpacer = objSQL.GetSpacer(serialNo)
        ElseIf My.Settings.SpacerMode = "Fixed" Then
            getSpacer = Format(My.Settings.H_KA * 1000, "000") & " " &
                    Format(My.Settings.H_CB * 1000, "000") & " " &
                    Format(My.Settings.H_HKA * 1000, "000") & " " &
                    Format(My.Settings.H_KC * 1000, "000") & " " &
                    Format(My.Settings.H_CD * 1000, "000") & " " &
                    Format(My.Settings.H_HKC * 1000, "000")
        End If
        getSpacer2 = getSpacer.Split(New Char() {" "})

        Dim FeedbackSpacerSplit As String()
        Dim FeedbackText As String()
        Dim TotalParameter As Integer
        Dim ArgumentIndexNo As Integer

        If getSpacer2(3) = "000" And getSpacer2(4) = "000" And getSpacer2(5) = "000" Then
            FeedbackSpacerSplit = SINGLESPACER.Split(New Char() {","})
            FeedbackText = FeedbackSpacerSplit(0).Split(New Char() {"#"})
            TotalParameter = FeedbackSpacerSplit(1)
            ArgumentIndexNo = FeedbackSpacerSplit(2)
        Else
            FeedbackSpacerSplit = FEEDBACKSPACER.Split(New Char() {","})
            FeedbackText = FeedbackSpacerSplit(0).Split(New Char() {"#"})
            TotalParameter = FeedbackSpacerSplit(1)
            ArgumentIndexNo = FeedbackSpacerSplit(2)
        End If

        WriteToRTB("PLC > Port 1 : Request spacer for " & serialNo)
        spacertexttosend = ""

        'Get the spacer value and send to PLC according to spacer command (can refer MasterCLBHousingFixedValue table column value(FeedbackSpacer)
        For a = 0 To TotalParameter - 1
            If a = ArgumentIndexNo - 1 Then
                FeedbackText(a) = getSpacer
            End If
            spacertexttosend = spacertexttosend & FeedbackText(a)
        Next

        Threading.Thread.Sleep(My.Settings.SendDelay)

        If My.Settings.ExpectedCLBControl = True Then
            If objSQL.CheckExpectedCLBSpec(serialNo) = True Then
                objTCP(PORT1TOPLC - 1).TextToSend(spacertexttosend)
                WriteToRTB("PC > Port 1 : " & spacertexttosend)
            Else
                objTCP(PORT1TOPLC - 1).TextToSend(EXPECTEDNG)
                WriteToRTB("PC > Port 1 : " & EXPECTEDNG)
                WriteToRTB("PC > Port 1 : Expected CLB position calculated was out of specification")
            End If
        ElseIf My.Settings.ExpectedCLBControl = False Then
            objTCP(PORT1TOPLC - 1).TextToSend(spacertexttosend)
            WriteToRTB("PC > Port 1 : " & spacertexttosend)
        End If


    End Sub

    '30/8/2022 Aklif Sainie : Initial creation of bgtPort3 function
    Private Sub bgtPort3_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgtPort3.DoWork

        Dim ReceiveMessagePort3 As String = ""
        Dim sendMessage As String
        While (objTCP(2).IsServerClientConnected = True)
            'Data sample : Remarks, SerialNo
            Try
                ReceiveMessagePort3 = objTCP(2).GetSTR()
                If ReceiveMessagePort3 = "3" Then

                    If Port2Confirmation = True Then
                        Threading.Thread.Sleep(My.Settings.InitConnectDelay)
                        objTCP(PORT3TOPLC - 1).TextToSend("30\r")
                        lblPort3Status.Text = "Port 3 connected"
                        lblPort3Status.Image = My.Resources.yes
                        Port3Confirmation = True
                        pnlStartServer.Visible = False

                    End If
                    RestartServer(3)
                    Exit While
                End If

                If ReceiveMessagePort3 = Nothing Or ReceiveMessagePort3 = "" Or ReceiveMessagePort3 = vbNullChar Then
                    RestartServer(3)
                    Exit While
                End If

                If Port3Confirmation = True Then
                    Dim splitData As String()
                    Dim remarks As String

                    ReceiveMessagePort3 = ReceiveMessagePort3.Replace(vbNullChar, "")
                    splitData = ReceiveMessagePort3.Split(New Char() {"_"})

                    WriteToRTB("PLC > Port 3 : " & ReceiveMessagePort3)

                    'Station remarks
                    If splitData(0) <> "DR4" Then
                        objTCP(PORT3TOPLC - 1).TextToSend(ALARMERROR)
                        Exit Try
                    End If

                    If splitData(1) = "" Then
                        objTCP(PORT3TOPLC - 1).TextToSend(ALARMERROR)
                        Exit Try
                    End If



                    remarks = splitData(0)

                    'Note : splitData() array variable index details
                    '---------splitData(0) - remarks
                    '---------splitData(1) - serial number

                    If remarks = "DR4" Or remarks = "RESULT" Then
                        WriteToRTB("PLC > Port 3 : Getting inspection result for " & splitData(1) & "...")
                        objSQL.ProgressStation(splitData(1), "DR4_ST5")

                        sendMessage = objSQL.GetInspectionResult(splitData(1))

                        If sendMessage = "NG" Or sendMessage = "" Then
                            sendMessage = NGRESULT
                        ElseIf sendMessage = "OK" Then
                            sendMessage = OKRESULT
                        End If

                        WriteToRTB("PC > Port 3 : " & sendMessage)
                        Threading.Thread.Sleep(My.Settings.SendDelay)
                        objTCP(PORT3TOPLC - 1).TextToSend(sendMessage)
                    ElseIf remarks = "REPAIR" Then

                        If objSQL.CheckProgressStation(splitData(1), "DR4_ST5") = False Then
                            WriteToRTB("Port 3 : No progress data at Station5(DR4)")
                            Exit Try
                        End If

                        objSQL.ProgressStation(splitData(1), "DR4_ST5_AfterRepair")
                        WriteToRTB("Port 3 : Repair unit recorded : " & splitData(1))
                    Else
                        'WriteToErrorLog("Unknown command : " & remarks)
                    End If
                End If
            Catch ex As Exception
                RestartServer(3)
                Exit While
            End Try
        End While

    End Sub

    Private Sub WriteToRTB(Message As String)
        Me.rtxtLog.HideSelection = False 'To display scroll down to the latest incoming data into the rich text box
        Me.rtxtLog.Invoke(New MethodInvoker(Function()
                                                rtxtLog.AppendText(Convert.ToString(Date.Now) + " >>> " + Message + Environment.NewLine)
                                            End Function))
    End Sub


    Private Sub btnClear_Click(sender As Object, e As EventArgs)
        ResetAllVariables()
    End Sub

    Private Sub Port1Timer_Tick(sender As Object, e As EventArgs) Handles Port1Timer.Tick
        DGVRawData()
    End Sub

    Private Sub btnHamburgerMenu_Click(sender As Object, e As EventArgs) Handles btnHamburgerMenu.Click
        If isSidebarOpen = False Then
            tmSidebarOpen.Start()
        ElseIf isSidebarOpen = True Then
            tmSidebarClose.Start()
        End If

    End Sub

    Private Sub timerSidebarOpen(sender As Object, e As EventArgs) Handles tmSidebarOpen.Tick
        Dim xMax As Integer = 205
        Dim yMax As Integer = 574


        If isSidebarOpen = False Then
            If pnlSidebar.Width = xMax Then
                isSidebarOpen = True
                tmSidebarOpen.Stop()
            Else
                pnlSidebar.Size = New Size(pnlSidebar.Width + 10, yMax)
            End If
        End If
    End Sub

    Private Sub tmSidebarClose_Tick(sender As Object, e As EventArgs) Handles tmSidebarClose.Tick

        Dim xMin As Integer = 35
        Dim yMin As Integer = 574


        If isSidebarOpen = True Then
            If pnlSidebar.Width = xMin Then
                isSidebarOpen = False
                tmSidebarClose.Stop()
            Else
                pnlSidebar.Size = New Size(pnlSidebar.Width - 10, yMin)
            End If

        End If
    End Sub

    Private Sub btnSetting_Click(sender As Object, e As EventArgs) Handles btnSetting.Click
        If isStartServer = True Then
            MsgBox("Please stop server first to make changes in application settings", 0, "Error")
            Exit Sub
        End If
        OpenSettings()
    End Sub

    Private Sub tmStartServerPanel_Tick(sender As Object, e As EventArgs) Handles tmStartServerPanel.Tick
        Dim xMax As Integer = 0
        Dim yMax As Integer = 574
        Dim currentLocationY = pnlStartServer.Location.Y


        If isStartButtonPanel = True Then
            If pnlStartServer.Location.Y = yMax Then
                isStartButtonPanel = False
                tmStartServerPanel.Stop()
            Else
                pnlStartServer.Location = New Point(xMax, currentLocationY + 10)
            End If
        End If
    End Sub

    Private Sub MainForm_MaximumSizeChanged(sender As Object, e As EventArgs) Handles MyBase.MaximumSizeChanged
        lblSN.Text = "This is maximum"
    End Sub

    Private Sub MainForm_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If WindowState.ToString() = "Maximized" Then
            Dim wPnlGroup As Integer = 234
            Dim hPnlGroup As Integer = 146

            fnlGroupHKA.Size = New Size(wPnlGroup, hPnlGroup)
            fnlGroupHKC.Size = New Size(wPnlGroup, hPnlGroup)
            fnlGroupHCB.Size = New Size(wPnlGroup, hPnlGroup)
            fnlGroupHCD.Size = New Size(wPnlGroup, hPnlGroup)
            fnlGroupHHKA.Size = New Size(wPnlGroup, hPnlGroup)
            fnlGroupHHKC.Size = New Size(wPnlGroup, hPnlGroup)
            fnlGroupCK.Size = New Size(wPnlGroup, hPnlGroup)
            fnlGroupCC.Size = New Size(wPnlGroup, hPnlGroup)
            fnlGroupCHK.Size = New Size(wPnlGroup, hPnlGroup)

            Dim wLblTitle As Integer = 220
            Dim hLblTitle As Integer = 0
            Dim fontLblTitle As Integer = 12

            lblTitleHousingKA.MaximumSize = New Size(wLblTitle, hLblTitle)
            lblTitleHousingKA.MinimumSize = New Size(wLblTitle, hLblTitle)
            lblTitleHousingKA.Font = New Font("Segoe UI", fontLblTitle)

            lblTitleHousingKC.MaximumSize = New Size(wLblTitle, hLblTitle)
            lblTitleHousingKC.MinimumSize = New Size(wLblTitle, hLblTitle)
            lblTitleHousingKC.Font = New Font("Segoe UI", fontLblTitle)

            lblTitleHousingCB.MaximumSize = New Size(wLblTitle, hLblTitle)
            lblTitleHousingCB.MinimumSize = New Size(wLblTitle, hLblTitle)
            lblTitleHousingCB.Font = New Font("Segoe UI", fontLblTitle)

            lblTitleHousingCD.MaximumSize = New Size(wLblTitle, hLblTitle)
            lblTitleHousingCD.MinimumSize = New Size(wLblTitle, hLblTitle)
            lblTitleHousingCD.Font = New Font("Segoe UI", fontLblTitle)

            lblTitleHousingHKA.MaximumSize = New Size(wLblTitle, hLblTitle)
            lblTitleHousingHKA.MinimumSize = New Size(wLblTitle, hLblTitle)
            lblTitleHousingHKA.Font = New Font("Segoe UI", fontLblTitle)

            lblTitleHousingHKC.MaximumSize = New Size(wLblTitle, hLblTitle)
            lblTitleHousingHKC.MinimumSize = New Size(wLblTitle, hLblTitle)
            lblTitleHousingHKC.Font = New Font("Segoe UI", fontLblTitle)

            lblTitleHousingCK.MaximumSize = New Size(wLblTitle, hLblTitle)
            lblTitleHousingCK.MinimumSize = New Size(wLblTitle, hLblTitle)
            lblTitleHousingCK.Font = New Font("Segoe UI", fontLblTitle)

            lblTitleHousingCC.MaximumSize = New Size(wLblTitle, hLblTitle)
            lblTitleHousingCC.MinimumSize = New Size(wLblTitle, hLblTitle)
            lblTitleHousingCC.Font = New Font("Segoe UI", fontLblTitle)

            lblTitleHousingCHK.MaximumSize = New Size(wLblTitle, hLblTitle)
            lblTitleHousingCHK.MinimumSize = New Size(wLblTitle, hLblTitle)
            lblTitleHousingCHK.Font = New Font("Segoe UI", fontLblTitle)

            Dim wLblValue As Integer = 220
            Dim hLblValue As Integer = 100
            Dim fontLblValue As Integer = 20

            lblValueHousingKA.MaximumSize = New Size(wLblValue, hLblValue)
            lblValueHousingKA.MinimumSize = New Size(wLblValue, hLblValue)
            lblValueHousingKA.Font = New Font("Segoe UI", fontLblValue, FontStyle.Bold)

            lblValueHousingKC.MaximumSize = New Size(wLblValue, hLblValue)
            lblValueHousingKC.MinimumSize = New Size(wLblValue, hLblValue)
            lblValueHousingKC.Font = New Font("Segoe UI", fontLblValue, FontStyle.Bold)

            lblValueHousingCB.MaximumSize = New Size(wLblValue, hLblValue)
            lblValueHousingCB.MinimumSize = New Size(wLblValue, hLblValue)
            lblValueHousingCB.Font = New Font("Segoe UI", fontLblValue, FontStyle.Bold)

            lblValueHousingCD.MaximumSize = New Size(wLblValue, hLblValue)
            lblValueHousingCD.MinimumSize = New Size(wLblValue, hLblValue)
            lblValueHousingCD.Font = New Font("Segoe UI", fontLblValue, FontStyle.Bold)

            lblValueHousingHKA.MaximumSize = New Size(wLblValue, hLblValue)
            lblValueHousingHKA.MinimumSize = New Size(wLblValue, hLblValue)
            lblValueHousingHKA.Font = New Font("Segoe UI", fontLblValue, FontStyle.Bold)

            lblValueHousingHKC.MaximumSize = New Size(wLblValue, hLblValue)
            lblValueHousingHKC.MinimumSize = New Size(wLblValue, hLblValue)
            lblValueHousingHKC.Font = New Font("Segoe UI", fontLblValue, FontStyle.Bold)

            lblValueHousingCK.MaximumSize = New Size(wLblValue, hLblValue)
            lblValueHousingCK.MinimumSize = New Size(wLblValue, hLblValue)
            lblValueHousingCK.Font = New Font("Segoe UI", fontLblValue, FontStyle.Bold)

            lblValueHousingCC.MaximumSize = New Size(wLblValue, hLblValue)
            lblValueHousingCC.MinimumSize = New Size(wLblValue, hLblValue)
            lblValueHousingCC.Font = New Font("Segoe UI", fontLblValue, FontStyle.Bold)

            lblValueHousingCHK.MaximumSize = New Size(wLblValue, hLblValue)
            lblValueHousingCHK.MinimumSize = New Size(wLblValue, hLblValue)
            lblValueHousingCHK.Font = New Font("Segoe UI", fontLblValue, FontStyle.Bold)

        ElseIf WindowState.ToString() = "Normal" Then
            Dim wPnlGroup As Integer = 117
            Dim hPnlGroup As Integer = 73

            fnlGroupHKA.Size = New Size(wPnlGroup, hPnlGroup)
            fnlGroupHKC.Size = New Size(wPnlGroup, hPnlGroup)
            fnlGroupHCB.Size = New Size(wPnlGroup, hPnlGroup)
            fnlGroupHCD.Size = New Size(wPnlGroup, hPnlGroup)
            fnlGroupHHKA.Size = New Size(wPnlGroup, hPnlGroup)
            fnlGroupHHKC.Size = New Size(wPnlGroup, hPnlGroup)
            fnlGroupCK.Size = New Size(wPnlGroup, hPnlGroup)
            fnlGroupCC.Size = New Size(wPnlGroup, hPnlGroup)
            fnlGroupCHK.Size = New Size(wPnlGroup, hPnlGroup)

            Dim wLblTitle As Integer = 110
            Dim hLblTitle As Integer = 0
            Dim fontLblTitle As Integer = 8

            lblTitleHousingKA.MaximumSize = New Size(wLblTitle, hLblTitle)
            lblTitleHousingKA.MinimumSize = New Size(wLblTitle, hLblTitle)
            lblTitleHousingKA.Font = New Font("Segoe UI", fontLblTitle)

            lblTitleHousingKC.MaximumSize = New Size(wLblTitle, hLblTitle)
            lblTitleHousingKC.MinimumSize = New Size(wLblTitle, hLblTitle)
            lblTitleHousingKC.Font = New Font("Segoe UI", fontLblTitle)

            lblTitleHousingCB.MaximumSize = New Size(wLblTitle, hLblTitle)
            lblTitleHousingCB.MinimumSize = New Size(wLblTitle, hLblTitle)
            lblTitleHousingCB.Font = New Font("Segoe UI", fontLblTitle)

            lblTitleHousingCD.MaximumSize = New Size(wLblTitle, hLblTitle)
            lblTitleHousingCD.MinimumSize = New Size(wLblTitle, hLblTitle)
            lblTitleHousingCD.Font = New Font("Segoe UI", fontLblTitle)

            lblTitleHousingHKA.MaximumSize = New Size(wLblTitle, hLblTitle)
            lblTitleHousingHKA.MinimumSize = New Size(wLblTitle, hLblTitle)
            lblTitleHousingHKA.Font = New Font("Segoe UI", fontLblTitle)

            lblTitleHousingHKC.MaximumSize = New Size(wLblTitle, hLblTitle)
            lblTitleHousingHKC.MinimumSize = New Size(wLblTitle, hLblTitle)
            lblTitleHousingHKC.Font = New Font("Segoe UI", fontLblTitle)

            lblTitleHousingCK.MaximumSize = New Size(wLblTitle, hLblTitle)
            lblTitleHousingCK.MinimumSize = New Size(wLblTitle, hLblTitle)
            lblTitleHousingCK.Font = New Font("Segoe UI", fontLblTitle)

            lblTitleHousingCC.MaximumSize = New Size(wLblTitle, hLblTitle)
            lblTitleHousingCC.MinimumSize = New Size(wLblTitle, hLblTitle)
            lblTitleHousingCC.Font = New Font("Segoe UI", fontLblTitle)

            lblTitleHousingCHK.MaximumSize = New Size(wLblTitle, hLblTitle)
            lblTitleHousingCHK.MinimumSize = New Size(wLblTitle, hLblTitle)
            lblTitleHousingCHK.Font = New Font("Segoe UI", fontLblTitle)

            Dim wLblValue As Integer = 110
            Dim hLblValue As Integer = 0
            Dim fontLblValue As Integer = 12

            lblValueHousingKA.MaximumSize = New Size(wLblValue, hLblValue)
            lblValueHousingKA.MinimumSize = New Size(wLblValue, hLblValue)
            lblValueHousingKA.Font = New Font("Segoe UI", fontLblValue, FontStyle.Regular)

            lblValueHousingKC.MaximumSize = New Size(wLblValue, hLblValue)
            lblValueHousingKC.MinimumSize = New Size(wLblValue, hLblValue)
            lblValueHousingKC.Font = New Font("Segoe UI", fontLblValue, FontStyle.Regular)

            lblValueHousingCB.MaximumSize = New Size(wLblValue, hLblValue)
            lblValueHousingCB.MinimumSize = New Size(wLblValue, hLblValue)
            lblValueHousingCB.Font = New Font("Segoe UI", fontLblValue, FontStyle.Regular)

            lblValueHousingCD.MaximumSize = New Size(wLblValue, hLblValue)
            lblValueHousingCD.MinimumSize = New Size(wLblValue, hLblValue)
            lblValueHousingCD.Font = New Font("Segoe UI", fontLblValue, FontStyle.Regular)

            lblValueHousingHKA.MaximumSize = New Size(wLblValue, hLblValue)
            lblValueHousingHKA.MinimumSize = New Size(wLblValue, hLblValue)
            lblValueHousingHKA.Font = New Font("Segoe UI", fontLblValue, FontStyle.Regular)

            lblValueHousingHKC.MaximumSize = New Size(wLblValue, hLblValue)
            lblValueHousingHKC.MinimumSize = New Size(wLblValue, hLblValue)
            lblValueHousingHKC.Font = New Font("Segoe UI", fontLblValue, FontStyle.Regular)

            lblValueHousingCK.MaximumSize = New Size(wLblValue, hLblValue)
            lblValueHousingCK.MinimumSize = New Size(wLblValue, hLblValue)
            lblValueHousingCK.Font = New Font("Segoe UI", fontLblValue, FontStyle.Regular)

            lblValueHousingCC.MaximumSize = New Size(wLblValue, hLblValue)
            lblValueHousingCC.MinimumSize = New Size(wLblValue, hLblValue)
            lblValueHousingCC.Font = New Font("Segoe UI", fontLblValue, FontStyle.Regular)

            lblValueHousingCHK.MaximumSize = New Size(wLblValue, hLblValue)
            lblValueHousingCHK.MinimumSize = New Size(wLblValue, hLblValue)
            lblValueHousingCHK.Font = New Font("Segoe UI", fontLblValue, FontStyle.Regular)
        End If
    End Sub
End Class
