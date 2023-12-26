Imports System.IO
Imports System.Net
Imports System.Net.Sockets
Imports System.Net.Dns
Imports System.Threading



'11/5/2022 Aklif Sainie : Initial creation
'TCP controller class

Public Class TCPController
    Inherits TCP
    ' ------BG TASKS INDEX DESCRIPTION------

    ' 0 - Raw data and calculation
    ' 1 - Spacer request and feedback
    ' 2 - Housing assembly judgement
    ' 3 - Result inquiry at DR5

    '---------------------------------------

    ' Constructor
    Public Sub New()

    End Sub

    Public Sub New(t As String)
        TextSendToPLC = t
    End Sub

    ' Constructor
    Public Sub New(ip As String, p As String)
        connectionIP = ip
        portNo = p
    End Sub


    Public Function IsServerClientConnected()

        Try
            If str.BaseStream.CanRead = True Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function GetPCIpAddress()
        Dim PCHostName = GetHostName() 'Get PC hostname
        Return GetHostByName(PCHostName).AddressList(0).ToString() 'Get PC IP address
    End Function

    Public Function StartServer(portNo As String)
        If serverStatus = False Then
            serverTrying = True
            Try

                If portNo = 0 Then
                    portNo = My.Settings.Port1
                ElseIf portNo = 1 Then
                    portNo = My.Settings.Port2
                ElseIf portNo = 2 Then
                    portNo = My.Settings.Port3
                End If


                'Bind IP address and port number into server TCPlistener
                server = New TcpListener(IPAddress.Parse(connectionIP), portNo)


                'Start all servers listener
                server.Start()


                'Indicates that all servers has started
                serverStatus = True


                'Threading.ThreadPool.QueueUserWorkItem(AddressOf IsListen)


                client = server.AcceptTcpClient


                str = New StreamReader(client.GetStream())
                stw = New StreamWriter(client.GetStream())

                stw.AutoFlush = True

            Catch ex As Exception
                serverStatus = False
                'MsgBox(ex.Message)
            End Try
            serverTrying = False
        End If

        Return True

    End Function

    '17/8/2022 Aklif Sainie : Initial creation
    'To read data sent by client(PLC) to server (PC Application)
    Public Function GetSTR()
        Return str.ReadLine
    End Function

    Public Function StopServer()
        If serverStatus = True Then
            serverTrying = True
            Try
                'Close all clients connection
                client.Close()

                'Stop all servers
                server.Stop()

                'Indicates all servers has been stoped
                serverStatus = False
            Catch ex As Exception
                server.Stop()
                Return False
            End Try
            'ElseIf serverStatus = False Then
            '    If serverTrying = False Then
            '        server.Stop()
            '    End If
        End If
        serverTrying = False
        Return True
    End Function

    ' 17/8/2022 Aklif Sainie : Initial creation
    ' To send data from server(PC application) to client(PLC)
    Public Sub TextToSend(text As String)
        Try
            stw.WriteLine(text)
            stw.Flush()
        Catch ex As Exception

        End Try
    End Sub
End Class
