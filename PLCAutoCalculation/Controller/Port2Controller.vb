Imports Microsoft.VisualBasic.Devices

Public Class Port2Controller
    Inherits Port2
    Private _sql As New SQLController
    Public Function DBCLBHousingMeasurement()

        Dim q As String

        If _sql.Find(SerialNumber, "DBCLBHousingMeasurement", Nothing) = False Then
            q = "INSERT INTO [DRAFSystem_MY].[dbo].[DBCLBHousingMeasurement]
                            ([SerialNo],[CLBProductionDate],[CLB_ResultK],[CLB_ResultC],[CLB_ResultHK],[InspectionResult])
                            VALUES
                            ('" & SerialNumber.ToString() & "'
                            ,GETDATE()
                            ," & ResultCLBK.ToString() & "
                            ," & ResultCLBC.ToString() & "
                            ," & ResultCLBHK.ToString() & ")"
            _sql = New SQLController(q)
            _sql.Insert()
        Else
            q = "UPDATE [DRAFSystem_MY].[dbo].[DBCLBHousingMeasurement]
                            SET [CLB_ResultK] = " & ResultCLBK.ToString() & "
                            ,[CLB_ResultC] = " & ResultCLBC.ToString() & "
                            ,[CLB_ResultHK] = " & ResultCLBHK.ToString() & "
                            ,[InspectionResult] = NULL
                            ,[CLBProductionDate] = GETDATE() WHERE SerialNo = '" & SerialNumber & "'"
            _sql = New SQLController(q)
            _sql.Update()
        End If
        Return True
    End Function

    Public Function ProgressStation() As Boolean
        Dim q As String

        Try
            If _sql.Find(SerialNumber, "DBBarcodeProgressCLBHousing", Nothing) = False Then
                q = "INSERT INTO [" & My.Settings.database & "].[dbo].[DBBarcodeProgressCLBHousing]
                    (SerialNo,DR2_ST6) VALUES ('" & SerialNumber & "', GETDATE())"
                _sql = New SQLController(q)
                _sql.Insert()
            Else
                q = "UPDATE [" & My.Settings.database & "].[dbo].[DBBarcodeProgressCLBHousing]
                 SET DR2_ST6 = GETDATE()
                 WHERE SerialNo = '" & SerialNumber & "'"
                _sql = New SQLController(q)
                _sql.Update()
            End If
        Catch ex As Exception
            Return False
        End Try

        Return True
    End Function
End Class
