Imports System.IO
Imports System.Net.Sockets

Public Class TCP
    Public Const TOTALBGTASK As Integer = 4
    Public Property server As TcpListener
    Public Property client As TcpClient
    Public Property str As StreamReader
    Public Property stw As StreamWriter
    Public Property stwToPLC As StreamWriter
    Public Property strFromPLC As StreamReader
    Public Property connectionIP As String = My.Settings.settingIPAddress
    Public Property portNo As String
    Public Property serverStatus As Boolean = False ' Server started or stoped
    Public Property serverTrying As Boolean = False ' Trying to start or stop server

    Public Property TextSendToPLC As String = ""
End Class
