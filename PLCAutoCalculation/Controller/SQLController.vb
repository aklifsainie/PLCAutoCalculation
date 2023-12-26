Imports System.Data.Sql
Imports System.Data.SqlClient
Imports PLCAutoCalculation.SQL


Public Class SQLController

    Inherits SQL
    Private RowCount As Integer
    Public ReferenceFBSN As String



    Public Sub New()
        InitializeConnectionString()
    End Sub

    Public Sub New(q As String)
        Query = q
    End Sub

    '2022/5/10 Aklif Sainie : Initial creation
    'Initialize database connection
    Public Sub InitializeConnectionString()
        con = New SqlConnection With {.ConnectionString = "Server = " & My.Settings.server & ";
                                                                Database = " & My.Settings.database & ";
                                                                User ID = " & DBUSER & ";
                                                                Password = " & DBPASSWORD}
    End Sub


    Public Function Insert() As Boolean
        Try
            InitializeConnectionString()
            con.Open()
            cmd = New SqlCommand(Query, con)
            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            con.Close()
            Return False
        End Try
        Return True
    End Function

    Public Function Update() As Boolean
        Try
            InitializeConnectionString()
            con.Open()
            cmd = New SqlCommand(Query, con)
            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            con.Close()
            Return False
        End Try
        Return True
    End Function

    Public Function Delete() As Boolean
        Try
            InitializeConnectionString()
            con.Open()
            cmd = New SqlCommand(Query, con)
            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            con.Close()
            Return False
        End Try
        Return True
    End Function

    Public Function Find(SN As String, tableName As String, mount As String) As Boolean

        If tableName <> "DBSpacerChoiceCalculation" Then
            Dim serialNoName As String
            If tableName = "DBMovingAverageSNList" Then
                serialNoName = "MainSerialNo"
                Query = "SELECT " & serialNoName & " FROM [" & My.Settings.database & "].[dbo].[" & tableName & "] WHERE " & serialNoName & " = '" & SN & "' AND Mount = '" & mount & "'"
            Else
                serialNoName = "SerialNo"
                Query = "SELECT " & serialNoName & " FROM [" & My.Settings.database & "].[dbo].[" & tableName & "] WHERE " & serialNoName & " = '" & SN & "'"
            End If

        Else
            Query = "SELECT SerialNo FROM [" & My.Settings.database & "].[dbo].[" & tableName & "] WHERE SerialNo = '" & SN & "' AND Mount IN ('" & mount & "')"
        End If


        Try
            con.Open()
            cmd = New SqlCommand(Query, con)
            sqlDR = cmd.ExecuteReader()
            sqlDR.Read()

            If sqlDR.HasRows() Then
                con.Close()
                Return True
            Else
                con.Close()
                Return False
            End If
        Catch ex As Exception
            con.Close()
        End Try
    End Function

    Public Function InitializeFixedVariables(parameter As String)
        Dim value As String
        Query = "SELECT [Description], [Value], [TotalParameter], [ArgumentIndexNo] FROM [" & My.Settings.database & "].[dbo].[MasterCLBHousingFixedValue]
                 WHERE Description = '" & parameter & "'"

        Try
            con.Open()
            cmd = New SqlCommand(Query, con)
            sqlDR = cmd.ExecuteReader()
            sqlDR.Read()

            If parameter = "FeedbackSpacer" Or parameter = "SingleSpacer" Then
                value = sqlDR("Value") & "," & sqlDR("TotalParameter") & "," & sqlDR("ArgumentIndexNo")
            Else
                value = sqlDR("Value")
            End If

            con.Close()
        Catch ex As Exception
            con.Close()
            Return False
        End Try
        Return value
    End Function

    '2022/5/10 Aklif Sainie : Initial creation
    'Check database connection
    Public Function CheckSQLConnection() As Boolean
        Try
            Dim Status As Boolean = False
            con.Open()
            Status = True
            con.Close()

            Return Status
        Catch ex As Exception
            con.Close()
            Return False
        End Try
    End Function

    Public Function DBSpacerChoiceCalculation(sno As String,
                                                correct_id As Integer,
                                                m As String,
                                                clbdata As Double,
                                                clbDV As Double,
                                                clbC0 As Double,
                                                av As Double,
                                                hoDV As Double,
                                                hoC0 As Double,
                                                dsC0 As Double,
                                                mag As Double,
                                                sudut As Double,
                                                tlt As Double,
                                                refSN As String,
                                                refValue As Double,
                                                difftwrdSpacer As Double,
                                                spacerChoose As Double,
                                                spacerChoose1 As Double,
                                                spacerChoose2 As Double,
                                                remaindiff As Double,
                                                expectCLB As Double) As Boolean

        If Find(sno, "DBSpacerChoiceCalculation", m) = False Then
            Query = "INSERT INTO [" & My.Settings.database & "].[dbo].[DBSpacerChoiceCalculation]
                 ([SerialNo]
                ,[correct_id]
                ,[Mount]
                ,[CLBHeight]
                ,[CLBDesignValue]
                ,[CLBCorrectionValue]
                ,[HousingAverage]
                ,[HousingDesignValue]
                ,[HousingCorrectionValue]
                ,[DSCorrectionValue]
                ,[Magnification]
                ,[Angle]
                ,[Tilt]
                ,[ReferenceFeedbackSN]
                ,[ReferenceFeedbackValue]
                ,[DiffTowardSpacer]
                ,[DoubleSpacerChoice]
                ,[SpacerChoice]
                ,[SpacerChoice2]
                ,[RemainingDifference], [ExpectedCLB], [RegistrationDate], [UpdatedDate])
                 VALUES ('" & sno & "',
                            " & correct_id & ",
                            '" & m & "',
                            " & clbdata & ",
                            " & clbDV & ",
                            " & clbC0 & ",
                            " & av & ",
                            " & hoDV & ",
                            " & hoC0 & ",
                            " & dsC0 & ",
                            " & mag & ",
                            " & sudut & ",
                            " & tlt & ",
                            '" & refSN & "',
                            " & refValue & ",
                            " & difftwrdSpacer & ",
                            " & spacerChoose & ",
                            " & spacerChoose1 & ",
                            " & spacerChoose2 & ",
                            " & remaindiff & ",
                            " & expectCLB & ", GETDATE(), GETDATE())"
        Else
            Query = "UPDATE [" & My.Settings.database & "].[dbo].[DBSpacerChoiceCalculation]
                 SET [correct_id] = " & correct_id & ",
                [CLBHeight] = " & clbdata & ",
                [CLBDesignValue] = " & clbDV & ",
                [CLBCorrectionValue] = " & clbC0 & ",
                [HousingAverage] = " & av & ",
                [HousingDesignValue] = " & hoDV & ",
                [HousingCorrectionValue] = " & hoC0 & ",
                [DSCorrectionValue] = " & dsC0 & ",
                [Magnification] = " & mag & ",
                [Angle] = " & sudut & ",
                [Tilt] = " & tlt & ",
                [ReferenceFeedbackSN] = '" & refSN & "',
                [ReferenceFeedbackValue] = " & refValue & ",
                [DiffTowardSpacer] = " & difftwrdSpacer & ",
                [DoubleSpacerChoice] = " & spacerChoose & ",
                [SpacerChoice] = " & spacerChoose1 & ",
                [SpacerChoice2] = " & spacerChoose2 & ",
                [RemainingDifference] = " & remaindiff & ",
                [ExpectedCLB] = " & expectCLB & ",
                [RegistrationDate] = GETDATE(),
                [UpdatedDate] = GETDATE()
                WHERE [SerialNo] = '" & sno & "' AND [Mount] = '" & m & "'"
        End If



        Try
            con.Open()
            cmd = New SqlCommand(Query, con)
            cmd.ExecuteNonQuery()
            con.Close()
            Return True
        Catch ex As Exception
            con.Close()
            Return False
        End Try
    End Function

    Public Function GetSpacer(serialNo As String) As String

        Query = "SELECT Mount,
                    FORMAT(CONVERT(int, SpacerChoice*1000),'000') AS SpacerChoice
                    FROM [" & My.Settings.database & "].[dbo].[DBSpacerChoiceCalculation]
                    WHERE SerialNo = '" & serialNo & "' AND Mount = 'K'

                    UNION ALL

                    SELECT Mount,
                    FORMAT(CONVERT(int, SpacerChoice*1000),'000') AS SpacerChoice
                    FROM [" & My.Settings.database & "].[dbo].[DBSpacerChoiceCalculation]
                    WHERE SerialNo = '" & serialNo & "' AND Mount = 'C'

                    UNION ALL

                    SELECT Mount,
                    FORMAT(CONVERT(int, SpacerChoice*1000),'000') AS SpacerChoice
                    FROM [" & My.Settings.database & "].[dbo].[DBSpacerChoiceCalculation]
                    WHERE SerialNo = '" & serialNo & "' AND Mount = 'HK'

                    UNION ALL

                    SELECT Mount,
                    FORMAT(CONVERT(int, SpacerChoice2*1000),'000') AS SpacerChoice
                    FROM [" & My.Settings.database & "].[dbo].[DBSpacerChoiceCalculation]
                    WHERE SerialNo = '" & serialNo & "' AND Mount = 'K'

                    UNION ALL

                    SELECT Mount,
                    FORMAT(CONVERT(int, SpacerChoice2*1000),'000') AS SpacerChoice
                    FROM [" & My.Settings.database & "].[dbo].[DBSpacerChoiceCalculation]
                    WHERE SerialNo = '" & serialNo & "' AND Mount = 'C'

                    UNION ALL

                    SELECT Mount,
                    FORMAT(CONVERT(int, SpacerChoice2*1000),'000') AS SpacerChoice
                    FROM [" & My.Settings.database & "].[dbo].[DBSpacerChoiceCalculation]
                    WHERE SerialNo = '" & serialNo & "' AND Mount = 'HK'"
        Dim Spacers As String = ""

        Try
            sqlDA = New SqlDataAdapter
            con.Open()
            cmd = New SqlCommand(Query, con)
            sqlDA.SelectCommand = cmd
            ds = New DataSet
            sqlDA.Fill(ds)
            con.Close()
            RowCount = ds.Tables(0).Rows.Count

            For i = 0 To RowCount - 1
                Spacers = Spacers & ds.Tables(0).Rows(i).Item(1).ToString()

                If i <> RowCount - 1 Then
                    Spacers = Spacers & " "
                End If
            Next
            ds.Tables(0).Clear()
        Catch ex As Exception
            con.Close()
        End Try
        Return Spacers
    End Function



    Public Function ProgressStation(NumberSerial As String, stationName As String) As Boolean
        Dim result As Boolean = False

        If stationName = "ST1" Then
            stationName = "DR2_ST1"
        ElseIf stationName = "DRSub" Then
            stationName = "DR2_ST1"
        ElseIf stationName = "ST4" Then
            stationName = "DR2_ST4"
        ElseIf stationName = "ST6" Then
            stationName = "DR2_ST6"
        ElseIf stationName = "DR4_ST5" Then
            stationName = "DR4_ST5"
        ElseIf stationName = "DR4_ST5_AfterRepair" Then
            stationName = "DR4_ST5_AfterRepair"
        End If


        If Find(NumberSerial, "DBBarcodeProgressCLBHousing", Nothing) = False Then
            Query = "INSERT INTO [" & My.Settings.database & "].[dbo].[DBBarcodeProgressCLBHousing]
                    (SerialNo) VALUES ('" & NumberSerial & "')"
            Try
                con.Open()
                cmd = New SqlCommand(Query, con)
                cmd.ExecuteNonQuery()
                con.Close()
                result = True
            Catch ex As Exception
                con.Close()
                Return result
            End Try
        End If

        Query = "UPDATE [" & My.Settings.database & "].[dbo].[DBBarcodeProgressCLBHousing]
                 SET " & stationName & " = GETDATE()
                 WHERE SerialNo = '" & NumberSerial & "'"


        Try
            con.Open()
            cmd = New SqlCommand(Query, con)
            cmd.ExecuteNonQuery()
            con.Close()
            result = True
        Catch ex As Exception
            con.Close()
            Return result
        End Try
        Return result
    End Function

    Public Function CalculateFbValue(snum As String, mount As String) As Double
        'snum is serial number
        'mount is the mount on CLB K, C or HK
        Dim TotalRow As Integer = 0

        ' Check serial number exist or not 
        If Find(snum, "DBMovingAverageSNList", mount) = True Then


            ' If exist copy to EXCHANGE SN LIST
            ' THEN DELETE SN FROM DBMovingAverageSNList
            Query = "INSERT INTO [" & My.Settings.database & "].[dbo].[DBExchangeMovingAvgSNList]
                    SELECT [MainSerialNo]
                    ,[Mount]
                    ,[MASerialNo]
                    ,[ExpectedCLB]
                    ,[CLB_Result]
                    ,[FeedbackValue]
                    ,GETDATE() AS [ExchangeDate]
                    FROM [" & My.Settings.database & "].[dbo].[DBMovingAverageSNList]
                    WHERE MainSerialNo = '" & snum & "'
                    DELETE FROM [" & My.Settings.database & "].[dbo].[DBMovingAverageSNList]
                    WHERE MainSerialNo = '" & snum & "'"

            Try
                con.Open()
                cmd = New SqlCommand(Query, con)
                cmd.ExecuteNonQuery()
                con.Close()
            Catch ex As Exception
                con.Close()
                Return False
            End Try
        End If

        Dim AverageFeedback As Double
        Dim parameter As String = ""

        If mount = "K" Then
            parameter = "B.CLB_ResultK"
        ElseIf mount = "C" Then
            parameter = "B.CLB_ResultC"
        ElseIf mount = "HK" Then
            parameter = "B.CLB_ResultHK"
        End If

        If My.Settings.feedback = "Enable" Then

            Query = "INSERT INTO [" & My.Settings.database & "].[dbo].[DBMovingAverageSNList]
                SELECT TOP (" & My.Settings.SampleSize & ") '" & snum & "' As MainSerialNo,
                A.[Mount],
                A.[SerialNo] As MASerialNo,
                A.[ExpectedCLB]," & parameter & ",
                (A.ExpectedCLB-(" & parameter & ")) AS FeedbackValue
                FROM [" & My.Settings.database & "].[dbo].[DBSpacerChoiceCalculation] A
                LEFT JOIN [" & My.Settings.database & "].[dbo].[DBCLBHousingMeasurement] B
                ON A.SerialNo = B.SerialNo
                WHERE A.Mount = '" & mount & "'
                AND " & parameter & " IS NOT NULL
                ORDER BY A.UpdatedDate DESC"

            Try
                con.Open()
                cmd = New SqlCommand(Query, con)
                cmd.ExecuteNonQuery()
                con.Close()
                Query = ""
            Catch ex As Exception
                con.Close()
                Return False
            End Try

            Query = "SELECT AVG(FeedbackValue) AS AverageFeedbackValue
                    FROM (
                     SELECT TOP (" & My.Settings.SampleSize & ") A.[SerialNo],
                     A.[Mount],A.[ExpectedCLB]," & parameter & ",
                     (A.ExpectedCLB-(" & parameter & ")) AS FeedbackValue
                     FROM [" & My.Settings.database & "].[dbo].[DBSpacerChoiceCalculation] A
                     LEFT JOIN [" & My.Settings.database & "].[dbo].[DBCLBHousingMeasurement] B
                     ON A.SerialNo = B.SerialNo
                     WHERE A.Mount = '" & mount & "'
                        AND " & parameter & " IS NOT NULL
                     ORDER BY A.UpdatedDate DESC
                    )Table1"
        ElseIf My.Settings.feedback = "MinMax" Then
            If My.Settings.cutOff = "0" Then
                My.Settings.cutOff = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
            End If

            ' Count total unit after cutoff
            Dim QCheck = "SELECT COUNT(*) AS TOTAL FROM (SELECT A.[SerialNo],
       	                    A.[Mount],A.[ExpectedCLB]," & parameter & ",
       	                    (A.ExpectedCLB-(" & parameter & ")) AS FeedbackValue, A.UpdatedDate
       	                    FROM [" & My.Settings.database & "].[dbo].[DBSpacerChoiceCalculation] A
       	                    LEFT JOIN [" & My.Settings.database & "].[dbo].[DBCLBHousingMeasurement] B
       	                    ON A.SerialNo = B.SerialNo 
       	                    WHERE A.Mount = '" & mount & "' AND A.UpdatedDate > '" + My.Settings.cutOff + "'
       	                    AND " & parameter & " IS NOT NULL)T1"
            Try
                con.Open()
                cmd = New SqlCommand(QCheck, con)
                sqlDR = cmd.ExecuteReader()
                sqlDR.Read()

                If sqlDR.HasRows() Then
                    TotalRow = sqlDR("TOTAL")
                Else
                    TotalRow = 1
                End If

                con.Close()
            Catch ex As Exception
                con.Close()
                Return False
            End Try

            If TotalRow Mod My.Settings.SampleSize = 0 Then

                Query = "INSERT INTO [" & My.Settings.database & "].[dbo].[DBMovingAverageSNList]
                        SELECT '" & snum & "' AS MainSerialNo,B.Mount, B.SerialNo AS MASerialNo, B.ExpectedCLB, " & parameter & ", B.FeedbackValue FROM (
	                        SELECT * ,ROW_NUMBER() OVER(ORDER BY " & parameter & ") AS RowNum FROM(
		                        SELECT TOP 20 A.[SerialNo],
		                        A.[Mount],A.[ExpectedCLB]," & parameter & "
		                        ,(A.ExpectedCLB-(" & parameter & ")) AS FeedbackValue, A.UpdatedDate
		                        FROM [" & My.Settings.database & "].[dbo].[DBSpacerChoiceCalculation] A
		                        LEFT JOIN [" & My.Settings.database & "].[dbo].[DBCLBHousingMeasurement] B
		                        ON A.SerialNo = B.SerialNo
		                        WHERE A.Mount = '" & mount & "'  
		                        AND " & parameter & " IS NOT NULL  
		                        ORDER BY A.UpdatedDate DESC
	                        )B
                        ) B
                        WHERE RowNum BETWEEN " & My.Settings.Min.ToString() & " AND " & My.Settings.Max.ToString()

                Try
                    con.Open()
                    cmd = New SqlCommand(Query, con)
                    cmd.ExecuteNonQuery()
                    con.Close()
                Catch ex As Exception
                    con.Close()
                    Return False
                End Try
                'Query = "SELECT 
                'CASE WHEN COUNT(*) <= " & My.Settings.SampleSize & " THEN AVG(FEEDBACKVALUE) -- first 30 unit
                'WHEN COUNT(*) > " & My.Settings.SampleSize & " AND COUNT(*) <= (" & My.Settings.SampleSize & " + " & My.Settings.SampleSize & ")  THEN (SELECT AVG(FEEDBACKVALUE) FROM ( -- next 30 unit 
                'SELECT * FROM (
                '    SELECT * , ROW_NUMBER() OVER(ORDER BY t1.FEEDBACKVALUE) AS RowNum
                '    FROM (
                '        SELECT TOP (" & My.Settings.SampleSize & ") A.[SerialNo],
                '        A.[Mount],A.[ExpectedCLB]," & parameter & ",
                '        (A.ExpectedCLB-" & parameter & ") AS FeedbackValue, A.UpdatedDate
                '        FROM [" & My.Settings.database & "].[dbo].[DBSpacerChoiceCalculation] A
                '        LEFT JOIN [" & My.Settings.database & "].[dbo].[DBCLBHousingMeasurement] B
                '        ON A.SerialNo = B.SerialNo
                '        WHERE A.Mount = " & mount & "
                '        AND " & parameter & " IS NOT NULL
                '        ORDER BY A.UpdatedDate ASC
                '    )t1
                ')T2 WHERE T2.RowNum BETWEEN " & My.Settings.Min & " and " & My.Settings.Max & "
                ')RR) 
                'ELSE 
                '(SELECT AVG(FEEDBACKVALUE) FROM ( -- next 60 unit 
                'SELECT * FROM (
                '    SELECT * , ROW_NUMBER() OVER(ORDER BY t1.FEEDBACKVALUE) AS RowNum
                '    FROM (
                '        SELECT TOP (" & My.Settings.SampleSize & ") A.[SerialNo],
                '        A.[Mount],A.[ExpectedCLB]," & parameter & ",
                '        (A.ExpectedCLB-" & parameter & ") AS FeedbackValue, A.UpdatedDate
                '        FROM [" & My.Settings.database & "].[dbo].[DBSpacerChoiceCalculation] A
                '        LEFT JOIN [" & My.Settings.database & "].[dbo].[DBCLBHousingMeasurement] B
                '        ON A.SerialNo = B.SerialNo
                '        WHERE A.Mount = " & mount & "
                '        AND " & parameter & " IS NOT NULL
                '        ORDER BY A.UpdatedDate ASC
                '    )t1
                ')T2 WHERE T2.RowNum BETWEEN " & My.Settings.Min & " and " & My.Settings.Max & "
                ')RR) + (SELECT AVG(FEEDBACKVALUE) FROM ( -- next 60 unit PLUS
                'SELECT * FROM (
                '    SELECT * , ROW_NUMBER() OVER(ORDER BY t1.FEEDBACKVALUE) AS RowNum
                '    FROM (
                '        SELECT TOP (" & My.Settings.SampleSize & ") A.[SerialNo],
                '        A.[Mount],A.[ExpectedCLB]," & parameter & ",
                '        (A.ExpectedCLB-" & parameter & ") AS FeedbackValue, A.UpdatedDate
                '        FROM [" & My.Settings.database & "].[dbo].[DBSpacerChoiceCalculation] A
                '        LEFT JOIN [" & My.Settings.database & "].[dbo].[DBCLBHousingMeasurement] B
                '        ON A.SerialNo = B.SerialNo
                '        WHERE A.Mount = " & mount & "
                '        AND " & parameter & " IS NOT NULL
                '        ORDER BY A.UpdatedDate DESC
                '    )t1
                ')T2 WHERE T2.RowNum BETWEEN " & My.Settings.Min & " and " & My.Settings.Max & "
                ')RR)
                'END AS KIK FROM(
                '    SELECT * , ROW_NUMBER() OVER(ORDER BY t1.FEEDBACKVALUE) AS RowNum
                '    FROM (
                '        SELECT TOP (100) A.[SerialNo],
                '        A.[Mount],A.[ExpectedCLB]," & parameter & ",
                '        (A.ExpectedCLB-" & parameter & ") AS FeedbackValue, A.UpdatedDate
                '        FROM [" & My.Settings.database & "].[dbo].[DBSpacerChoiceCalculation] A
                '        LEFT JOIN [" & My.Settings.database & "].[dbo].[DBCLBHousingMeasurement] B
                '        ON A.SerialNo = B.SerialNo
                '        WHERE A.Mount = " & mount & "
                '        AND " & parameter & " IS NOT NULL
                '        ORDER BY A.UpdatedDate DESC
                '    )t1
                ')T2"

                'Query = "SELECT CASE 
                '        WHEN COUNT(*) % " & My.Settings.SampleSize & " = 0 THEN  
                '        (SELECT AVG(" & parameter & ") - 13.85 FROM(
                '             SELECT TOP " & My.Settings.SampleSize & " A.[SerialNo],
                '                A.[Mount],A.[ExpectedCLB]," & parameter & ",
                '                (A.ExpectedCLB-" & parameter & ") AS FeedbackValue, A.UpdatedDate
                '                FROM [" & My.Settings.database & "].[dbo].[DBSpacerChoiceCalculation] A
                '                LEFT JOIN [" & My.Settings.database & "].[dbo].[DBCLBHousingMeasurement] B
                '                ON A.SerialNo = B.SerialNo
                '                WHERE A.Mount = '" & mount & "'
                '                AND " & parameter & " IS NOT NULL 
                '          ORDER BY UpdatedDate)B )
                '        ELSE 
                '        (0)
                '         END AverageFeedbackValue
                '         FROM (
                '             SELECT A.[SerialNo],
                '                A.[Mount],A.[ExpectedCLB]," & parameter & ",
                '                (A.ExpectedCLB-" & parameter & ") AS FeedbackValue, A.UpdatedDate
                '                FROM [" & My.Settings.database & "].[dbo].[DBSpacerChoiceCalculation] A
                '                LEFT JOIN [" & My.Settings.database & "].[dbo].[DBCLBHousingMeasurement] B
                '                ON A.SerialNo = B.SerialNo
                '                WHERE A.Mount = '" & mount & "'
                '                AND " & parameter & " IS NOT NULL) T1"

                If My.Settings.FBFormula = "DIF" Then
                    Query = "SELECT " & My.Settings.CLBdv.ToString() & " - (AVG(" & parameter & "))  AS 'AverageFeedbackValue' FROM(
                            SELECT * ,ROW_NUMBER() OVER(ORDER BY " & parameter & ") AS RowNum FROM(
    	                        SELECT TOP " & My.Settings.SampleSize & " A.[SerialNo],
       	                        A.[Mount],A.[ExpectedCLB]," & parameter & ",
       	                        (A.ExpectedCLB-(" & parameter & ")) AS FeedbackValue, A.UpdatedDate
       	                        FROM [" & My.Settings.database & "].[dbo].[DBSpacerChoiceCalculation] A
       	                        LEFT JOIN [" & My.Settings.database & "].[dbo].[DBCLBHousingMeasurement] B
       	                        ON A.SerialNo = B.SerialNo
       	                        WHERE A.Mount = '" & mount & "'  
       	                        AND " & parameter & " IS NOT NULL  
		                        ORDER BY UpdatedDate DESC)B )B
		                WHERE RowNum BETWEEN " & My.Settings.Min & " AND " & My.Settings.Max
                ElseIf My.Settings.FBFormula = "IDF" Then

                    Query = "SELECT " & My.Settings.CLBdv.ToString() & " - (AVG(" & parameter & "))  AS 'AverageFeedbackValue' FROM(
                            SELECT * ,ROW_NUMBER() OVER(ORDER BY " & parameter & ") AS RowNum FROM(
    	                        SELECT TOP " & My.Settings.SampleSize & " A.[SerialNo],
       	                        A.[Mount],A.[ExpectedCLB]," & parameter & ",
       	                        (A.ExpectedCLB-(" & parameter & ")) AS FeedbackValue, A.UpdatedDate
       	                        FROM [" & My.Settings.database & "].[dbo].[DBSpacerChoiceCalculation] A
       	                        LEFT JOIN [" & My.Settings.database & "].[dbo].[DBCLBHousingMeasurement] B
       	                        ON A.SerialNo = B.SerialNo
       	                        WHERE A.Mount = '" & mount & "'  
       	                        AND " & parameter & " IS NOT NULL  
		                        ORDER BY UpdatedDate DESC)B )B
		                WHERE RowNum BETWEEN " & My.Settings.Min & " AND " & My.Settings.Max

                ElseIf My.Settings.FBFormula = "EDF" Then

                    Query = "SELECT " & My.Settings.CLBdv.ToString() & "-(AVG(" & parameter & "))  AS 'd-i', AVG(FeedbackValue) As 'i-e', (" & My.Settings.CLBdv & "-(AVG(" & parameter & ")))-(AVG(FeedbackValue)) AS 'AverageFeedbackValue' FROM(
                                SELECT * ,ROW_NUMBER() OVER(ORDER BY " & parameter & ") AS RowNum FROM(
    	                            SELECT TOP " & My.Settings.SampleSize & " A.[SerialNo],
       	                            A.[Mount],A.[ExpectedCLB]," & parameter & ",
       	                            (" & parameter & "-(A.ExpectedCLB)) AS FeedbackValue, A.UpdatedDate
       	                            FROM [" & My.Settings.database & "].[dbo].[DBSpacerChoiceCalculation] A
       	                            LEFT JOIN [" & My.Settings.database & "].[dbo].[DBCLBHousingMeasurement] B
       	                            ON A.SerialNo = B.SerialNo
       	                            WHERE A.Mount = '" & mount & "'  
       	                            AND " & parameter & " IS NOT NULL  
		                            ORDER BY UpdatedDate DESC
	                            )B 
                            )B
                            WHERE RowNum BETWEEN " & My.Settings.Min & " AND " & My.Settings.Max
                End If

            Else
                Query = "0"
                If mount = "K" Or mount = "k" Then
                    AverageFeedback = My.Settings.FBValueSaveK
                ElseIf mount = "C" Or mount = "c" Then
                    AverageFeedback = My.Settings.FBValueSaveC
                ElseIf mount = "HK" Or mount = "hk" Or mount = "Hk" Or mount = "hK" Then
                    AverageFeedback = My.Settings.FBValueSaveHK
                End If
                ' AverageFeedback = My.Settings.FBValueSaveK
            End If

        End If



        If Query <> "0" Then
            Try
                con.Open()
                cmd = New SqlCommand(Query, con)
                sqlDR = cmd.ExecuteReader()
                sqlDR.Read()

                If sqlDR.HasRows() Then

                    If My.Settings.FBFormula = "DIF" Or My.Settings.FBFormula = "EDF" Then
                        If mount = "K" Or mount = "k" Then
                            AverageFeedback = sqlDR("AverageFeedbackValue") + My.Settings.FBValueSaveK
                            My.Settings.FixFBK = AverageFeedback
                        ElseIf mount = "C" Or mount = "c" Then
                            AverageFeedback = sqlDR("AverageFeedbackValue") + My.Settings.FBValueSaveC
                            My.Settings.FixFBC = AverageFeedback
                        ElseIf mount = "HK" Or mount = "hk" Or mount = "Hk" Or mount = "hK" Then
                            AverageFeedback = sqlDR("AverageFeedbackValue") + My.Settings.FBValueSaveHK
                            My.Settings.FixFBHK = AverageFeedback
                        End If
                    ElseIf My.Settings.FBFormula = "IDF" Then
                        If mount = "K" Or mount = "k" Then
                            AverageFeedback = sqlDR("AverageFeedbackValue") + My.Settings.FBValueSaveK
                            My.Settings.FixFBK = AverageFeedback
                        ElseIf mount = "C" Or mount = "c" Then
                            AverageFeedback = sqlDR("AverageFeedbackValue") + My.Settings.FBValueSaveC
                            My.Settings.FixFBC = AverageFeedback
                        ElseIf mount = "HK" Or mount = "hk" Or mount = "Hk" Or mount = "hK" Then
                            AverageFeedback = sqlDR("AverageFeedbackValue") + My.Settings.FBValueSaveHK
                            My.Settings.FixFBHK = AverageFeedback
                        End If
                    End If


                    If My.Settings.feedback = "MinMax" Then
                        If mount = "K" Or mount = "k" Then
                            My.Settings.FBValueSaveK = AverageFeedback
                        ElseIf mount = "C" Or mount = "c" Then
                            My.Settings.FBValueSaveC = AverageFeedback
                        ElseIf mount = "HK" Or mount = "hk" Or mount = "Hk" Or mount = "hK" Then
                            My.Settings.FBValueSaveHK = AverageFeedback
                        End If
                    End If
                End If
                My.Settings.Save()
                My.Settings.Reload()
                con.Close()
            Catch ex As Exception
                con.Close()
                Return False
            End Try
        End If


        Return AverageFeedback
    End Function

    Public Function StoreFeedbackValue(fbv As Double, snum As String, mountname As String) As Boolean

        Query = "UPDATE [" & My.Settings.database & "].[dbo].[DBSpacerChoiceCalculation]
                 SET FeedbackValue = " & fbv & ", UpdatedDate = GETDATE()
                 WHERE SerialNo = '" & snum & "' AND Mount = '" & mountname & "'"

        Try
            con.Open()
            cmd = New SqlCommand(Query, con)
            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            con.Close()
            Return False
        End Try

        Return True
    End Function

    Public Function UpdateInspetionResult(snum As String, result As Boolean)
        Dim r As String
        If result = True Then
            r = "OK"
        ElseIf result = False Then
            r = "NG"
        End If

        Query = "UPDATE [" & My.Settings.database & "].[dbo].[DBCLBHousingMeasurement]
                 SET InspectionResult = '" & r & "'
                 WHERE SerialNo = '" & snum & "'"

        Try
            con.Open()
            cmd = New SqlCommand(Query, con)
            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            con.Close()
        End Try

        Return True
    End Function

    Public Function GetInspectionResult(sn As String) As String

        Dim Inspection As String

        'Query = "SELECT SerialNo, NGType FROM (
        '     SELECT TABLE1.SerialNo, 'CLB height NG' AS NGType FROM (
        '      SELECT SerialNo, InspectionResult AS 'NGType'
        '      FROM [" & My.Settings.database & "].[dbo].[DBCLBHousingMeasurement]
        '      WHERE InspectionResult = 'NG'
        '     )TABLE1
        '     LEFT JOIN [" & My.Settings.database & "].[dbo].[DBBarcodeProgressCLBHousing] B
        '     ON TABLE1.SerialNo = B.SerialNo
        '     WHERE TABLE1.NGType = 'NG'
        '     AND B.DR4_ST5 IS NOT NULL
        '     AND B.DR4_ST5_AfterRepair IS NULL

        '     UNION ALL


        '     SELECT SerialNo,
        '     CASE
        '      WHEN DR2_ST1 IS NULL THEN 'DR2 ST1 data not found'
        '      WHEN DR2_ST6 IS NULL THEN 'DR2 ST6 data not found'
        '     END As NGType
        '     FROM [" & My.Settings.database & "].[dbo].[DBBarcodeProgressCLBHousing]
        '     WHERE DR4_ST5 IS NOT NULL
        '     AND (
        '      DR2_ST6 IS NULL
        '      OR DR2_ST1 IS NULL
        '     )

        '     UNION ALL 

        '     SELECT TABLE2.SerialNo, TABLE2.NGType FROM (
        '      SELECT SerialNo, 'Spacer calculation not found' AS NGType
        '      FROM [" & My.Settings.database & "].[dbo].[DBCLBHousingMeasurement]
        '      WHERE SerialNo NOT IN (
        '       SELECT SerialNo
        '       FROM [" & My.Settings.database & "].[dbo].[DBSpacerChoiceCalculation]
        '      )
        '     )TABLE2
        '     INNER JOIN [" & My.Settings.database & "].[dbo].[DBBarcodeProgressCLBHousing] B
        '     ON TABLE2.SerialNo = B.SerialNo
        '     WHERE B.DR4_ST5 IS NOT NULL
        '    )MAINTABLE1
        '    WHERE MAINTABLE1.SerialNo = '" & sn & "'"

        Query = "SELECT [SerialNo], [InspectionResult] FROM [" & My.Settings.database & "].[dbo].[DBCLBHousingMeasurement] WHERE SerialNo = '" & sn & "'"

        Try
            con.Open()
            cmd = New SqlCommand(Query, con)
            sqlDR = cmd.ExecuteReader()
            sqlDR.Read()


            If IsDBNull(sqlDR("SerialNo")) Then
                Inspection = "No serial number"
            Else
                If sqlDR.HasRows() Then
                    If IsDBNull(sqlDR("InspectionResult")) Then
                        Inspection = "NULL"
                    Else
                        Inspection = sqlDR("InspectionResult")
                    End If
                End If
            End If

            con.Close()
        Catch ex As Exception
            con.Close()
        End Try
        Return Inspection
    End Function


    Public Function GetPreviousFBValue(mount As String) As Double

        Dim previousfb As Double

        Query = "SELECT TOP (1) [SerialNo],[FeedbackValue]
                FROM [" & My.Settings.database & "].[dbo].[DBSpacerChoiceCalculation]
                WHERE Mount = '" & mount & "'
                AND FeedbackValue IS NOT NULL
                ORDER BY UpdatedDate DESC"

        Try
            con.Open()
            cmd = New SqlCommand(Query, con)
            sqlDR = cmd.ExecuteReader()
            sqlDR.Read()


            If IsDBNull(sqlDR("FeedbackValue")) Then
                previousfb = 0
            Else
                If sqlDR.HasRows() Then
                    If IsDBNull(sqlDR("FeedbackValue")) Then
                        previousfb = 0
                    Else
                        ReferenceFBSN = sqlDR("SerialNo")
                        previousfb = sqlDR("FeedbackValue")
                    End If
                End If
            End If

            con.Close()
        Catch ex As Exception
            con.Close()
        End Try
        Return previousfb
    End Function

    '12/10/2022 Aklif Sainie : Initial creation
    Public Function GetNGSN() As DataSet

        'Query = "SELECT A.SerialNo, A.InspectionResult AS 'BladeResult'
        '        FROM [" & My.Settings.database & "].[dbo].[DBCLBHousingMeasurement] A
        '        LEFT JOIN [" & My.Settings.database & "].[dbo].[DBBarcodeProgressCLBHousing] B
        '        ON A.SerialNo = B.SerialNo
        '        WHERE A.InspectionResult = 'NG'
        '        AND B.DR4_ST5 IS NOT NULL
        '        AND B.DR4_ST5_AfterRepair IS NULL"

        'Query = "SELECT A.SerialNo, A.InspectionResult AS 'BladeResult'
        '            FROM [" & My.Settings.database & "].[dbo].[DBCLBHousingMeasurement] A 
        '            LEFT JOIN [" & My.Settings.database & "].[dbo].[DBBarcodeProgressCLBHousing] B
        '            ON A.SerialNo = B.SerialNo
        '            WHERE A.InspectionResult = 'NG'
        '            AND B.DR4_ST5 IS NOT NULL
        '            AND B.DR4_ST5_AfterRepair IS NULL"

        'Query = "SELECT TABLE1.SerialNo, TABLE1.BladeResult FROM (
        '         SELECT SerialNo, InspectionResult AS 'BladeResult'
        '         FROM [" & My.Settings.database & "].[dbo].[DBCLBHousingMeasurement]
        '         WHERE InspectionResult = 'NG'
        '        )TABLE1
        '        LEFT JOIN [" & My.Settings.database & "].[dbo].[DBBarcodeProgressCLBHousing] B
        '        ON TABLE1.SerialNo = B.SerialNo
        '        WHERE TABLE1.BladeResult = 'NG'
        '        AND B.DR4_ST5 IS NOT NULL
        '        AND B.DR4_ST5_AfterRepair IS NULL"

        'Query = "
        '            SELECT MainTable1.SerialNo, SubTable1.ErrorMessage FROM (
        '             SELECT TABLE1.SerialNo, 1 AS NGType
        '             FROM (
        '              SELECT SerialNo, InspectionResult AS 'NGType'
        '              FROM [" & My.Settings.database & "].[dbo].[DBCLBHousingMeasurement]
        '              WHERE InspectionResult = 'NG'
        '             )TABLE1
        '             LEFT JOIN [" & My.Settings.database & "].[dbo].[DBBarcodeProgressCLBHousing] B
        '             ON TABLE1.SerialNo = B.SerialNo
        '             WHERE TABLE1.NGType = 'NG'
        '             AND B.DR4_ST5 IS NOT NULL
        '             AND B.DR4_ST5_AfterRepair IS NULL

        '             UNION ALL

        '             SELECT SerialNo,
        '             CASE
        '              WHEN DR2_ST1 IS NULL THEN 2
        '              WHEN DR2_ST6 IS NULL THEN 4
        '             END As NGType
        '             FROM [" & My.Settings.database & "].[dbo].[DBBarcodeProgressCLBHousing]
        '             WHERE DR4_ST5 IS NOT NULL
        '             AND (
        '              DR2_ST6 IS NULL
        '              OR DR2_ST1 IS NULL
        '             )

        '             UNION ALL 

        '             SELECT TABLE2.SerialNo, TABLE2.NGType FROM (
        '              SELECT SerialNo, 7 AS NGType
        '              FROM [" & My.Settings.database & "].[dbo].[DBCLBHousingMeasurement]
        '              WHERE SerialNo NOT IN (
        '               SELECT SerialNo
        '               FROM [" & My.Settings.database & "].[dbo].[DBSpacerChoiceCalculation]
        '              )
        '             )TABLE2
        '             INNER JOIN [" & My.Settings.database & "].[dbo].[DBBarcodeProgressCLBHousing] B
        '             ON TABLE2.SerialNo = B.SerialNo
        '             WHERE B.DR4_ST5 IS NOT NULL
        '            ) MainTable1
        '            LEFT JOIN [" & My.Settings.database & "].[dbo].[MasterErrorMessage] SubTable1
        '            ON MainTable1.NGType = SubTable1.ErrorID

        '            ORDER BY SerialNo ASC"


        'Query = "SELECT * FROM (
        '         SELECT TOP(1000)
        '            [SerialNo],[HousingProductionDate],[H_KA],[H_KC],[H_CB],[H_CD],[H_HKA],[H_HKC],[C_K],[C_C],[C_HK]
        '         FROM [" + My.Settings.database + "].[dbo].[DBCLBHousingMeasurement]
        '         ORDER BY HousingProductionDate DESC
        '        )Main
        '        ORDER BY HousingProductionDate DESC"

        Query = "SELECT TOP(1000)
                [SerialNo],[HousingProductionDate],[H_KA],[H_KC],[H_CB],[H_CD],[H_HKA],[H_HKC],[C_K],[C_C],[C_HK],
                [CLB_ResultK],[CLB_ResultC],[CLB_ResultHK],[InspectionResult]
                FROM [" + My.Settings.database + "].[dbo].[DBCLBHousingMeasurement]
                ORDER BY HousingProductionDate DESC"

        Try
            sqlDA = New SqlDataAdapter
            con.Open()
            cmd = New SqlCommand(Query, con)
            sqlDA.SelectCommand = cmd
            dsDGV = New DataSet
            sqlDA.Fill(dsDGV)
            con.Close()
        Catch ex As Exception
            con.Close()
        End Try
        Return dsDGV
    End Function

    Public Function CheckProgressStation(serialNo As String, StationName As String) As Boolean
        Dim Result As Boolean

        Query = "SELECT SerialNo, " & StationName & " FROM [" & My.Settings.database & "].[dbo].[DBBarcodeProgressCLBHousing] WHERE SerialNo = '" & serialNo & "'"

        Try
            con.Open()
            cmd = New SqlCommand(Query, con)
            sqlDR = cmd.ExecuteReader()
            sqlDR.Read()

            If IsDBNull(sqlDR(StationName)) Then
                Result = False
            Else
                Result = True
            End If
            con.Close()
        Catch ex As Exception
            con.Close()
        End Try

        Return Result
    End Function

    Public Function CheckExpectedCLBSpec(serialNo As String) As Boolean
        Dim Result As Boolean
        Dim TotalOK As Integer
        Query = "SELECT COUNT(*) AS TotalExpectedOK FROM (
	                SELECT [SerialNo], [ExpectedCLB]
	                FROM [" & My.Settings.database & "].[dbo].[DBSpacerChoiceCalculation]
	                WHERE SerialNo = '" & serialNo & "'
	                AND ExpectedCLB BETWEEN (" + My.Settings.CLBdv.ToString() + ")-" + My.Settings.SpecRange.ToString() + "
	                AND (" + My.Settings.CLBdv.ToString() + ")+" + My.Settings.SpecRange.ToString() + "
                )T1"

        Try
            con.Open()
            cmd = New SqlCommand(Query, con)
            sqlDR = cmd.ExecuteReader()
            sqlDR.Read()

            TotalOK = sqlDR("TotalExpectedOK")

            If TotalOK = 3 Then
                Result = True
            Else
                Result = False
            End If
            con.Close()
        Catch ex As Exception
            con.Close()
        End Try

        Return Result
    End Function

End Class
