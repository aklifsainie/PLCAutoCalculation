Imports System.Data.SqlClient

Public Class SQL

#If DEBUG Then
    Public Property DBUSER As String = "bradmin"
    Public Property DBPASSWORD As String = "KMBR_admin"
#Else
    Public Property DBUSER As String = "DRadmin"
    Public Property DBPASSWORD As String = "Spacer@bmmy"
#End If
    Public Property con As New SqlConnection
    Public Property cmd As SqlCommand
    Public Property sqlDR As SqlDataReader
    Public Property dt As DataTable
    Public Property sqlDA As New SqlDataAdapter
    Public Property ds As New DataSet
    Public Property dsDGV As New DataSet
    Public Property Query As String
End Class
