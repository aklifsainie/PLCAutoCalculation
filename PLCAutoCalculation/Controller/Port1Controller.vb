Imports System.Data.SqlClient
Imports PLCAutoCalculation.Port1
Public Class Port1Controller
    Inherits Port1

    Private _sql As New SQLController

    ' Constructor
    Public Sub New()

    End Sub

    Public Function DBCLBHousingMeasurement()

        Dim q As String

        If _sql.Find(SerialNumber, "DBCLBHousingMeasurement", Nothing) = False Then
            q = "INSERT INTO [DRAFSystem_MY].[dbo].[DBCLBHousingMeasurement]
                            ([SerialNo],[HousingProductionDate],[H_KA],[H_KC],[H_CB],[H_CD],[H_HKA],[H_HKC],[CLBProductionDate],[C_K],[C_C],[C_HK])
                            VALUES
                            ('" + SerialNumber.ToString() + "'
                            ,GETDATE()
                            ," + HousingKA.ToString() + "
                            ," + HousingKC.ToString() + "
                            ," + HousingCB.ToString() + "
                            ," + HousingCD.ToString() + "
                            ," + HousingHKA.ToString() + "
                            ," + HousingHKC.ToString() + "
                            ,GETDATE()
                            ," + CLBK.ToString() + "
                            ," + CLBC.ToString() + "
                            ," + CLBHK.ToString() + ")"
            _sql = New SQLController(q)
            _sql.Insert()
        Else
            q = "UPDATE [DRAFSystem_MY].[dbo].[DBCLBHousingMeasurement]
                            SET HousingProductionDate = GETDATE()
                            ,[H_KA] = " + HousingKA.ToString() + "
                            ,[H_KC] = " + HousingKC.ToString() + "
                            ,[H_CB] = " + HousingCB.ToString() + "
                            ,[H_CD] = " + HousingCD.ToString() + "
                            ,[H_HKA] = " + HousingHKA.ToString() + "
                            ,[H_HKC] = " + HousingHKC.ToString() + "
                            ,[CLBProductionDate] = GETDATE()
                            ,[C_K] = " + CLBK.ToString() + "
                            ,[C_C] = " + CLBC.ToString() + "
                            ,[C_HK] = " + CLBHK.ToString() + " WHERE SerialNo = '" + SerialNumber + "'"
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
                    (SerialNo,DR2_ST1) VALUES ('" & SerialNumber & "', GETDATE())"
                _sql = New SQLController(q)
                _sql.Insert()
            Else
                q = "UPDATE [" & My.Settings.database & "].[dbo].[DBBarcodeProgressCLBHousing]
                 SET DR2_ST1 = GETDATE()
                 WHERE SerialNo = '" & SerialNumber & "'"
                _sql = New SQLController(q)
                _sql.Update()
            End If
        Catch ex As Exception
            Return False
        End Try

        Return True
    End Function

    Public Function MovingAverage()
        Dim calculate As Buffer = New Buffer(SerialNumber, HousingKA, HousingKC, HousingHKA, HousingHKC, HousingCB, HousingCD, CLBK, CLBHK, CLBC)
        calculate.MovingAverageCalculation()
        Return True
    End Function

    Public Function DSModeCalculation()
        Dim calculate As Buffer = New Buffer(SerialNumber)
        calculate.DSModeCalculation()
        Return True
    End Function

End Class
