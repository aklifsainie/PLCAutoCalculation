Imports System.Math
Imports System.Math.PI

Public Class Buffer

    Private objSQL As New SQLController


    'Private CLBDESIGNVALUE As Double
    'Private HOUSINGDESIGNVALUE As Double
    'Private MAGNIFICATION As Double
    'Private HOUSINGRAWDATA As Integer
    'Private CLBRAWDATA As Integer
    'Private TOTALMOUNT As Integer
    'Private TOTALPOINT As Integer
    'Private COSINEVALUE As Double
    'Private spacers As String
    'Private CONSTANTVARIABLE As Double


    ''Constant variables for calculation
    'Private CLBRAWDATA As Integer = InitializeConstantVariables("CLBRawData")
    'Private HOUSINGRAWDATA As Integer = InitializeConstantVariables("HousingRawData")
    'Private TOTALMOUNT As Integer = InitializeConstantVariables("TotalMount")
    'Private TOTALPOINT As Integer = InitializeConstantVariables("TotalPoint")
    'Private CLBDESIGNVALUE As Double = InitializeConstantVariables("CLBDesignValue")
    'Private HOUSINGDESIGNVALUE As Double = InitializeConstantVariables("HousingDesignValue")
    'Private MAGNIFICATION As Double = InitializeConstantVariables("Magnification")
    'Private COSINEVALUE As Double = InitializeConstantVariables("CosineValue") * (PI / 180)
    'Private spacers As String = InitializeConstantVariables("SpacerChoice")
    'Private CONSTANTVARIABLE As Double = InitializeConstantVariables("ConstantVariable")

    'Constant variables for calculation
    Private CLBRAWDATA As Integer = InitializeConstantVariables("CLBRawData")
    Private HOUSINGRAWDATA As Integer = InitializeConstantVariables("HousingRawData")
    Private TOTALMOUNT As Integer = InitializeConstantVariables("TotalMount")
    Private TOTALPOINT As Integer = InitializeConstantVariables("TotalPoint")
    Private DSTOTALPARAMETER As Integer = InitializeConstantVariables("DSParameter")
    Private CLBDESIGNVALUE As Double
    Private HOUSINGDESIGNVALUE As Double
    Private MAGNIFICATION As Double
    Private COSINEVALUE As Double
    Private spacers As String
    Private CONSTANTVARIABLE As Double

    Private spacerArray As String()
    Private chosenSpacer As Double
    Private chosenSpacer1 As Double
    Private chosenSpacer2 As Double
    Private correctID As Integer
    Dim countDoubleSpacer As Integer

    'Raw data variables
    Private serialno As String
    Private housingMeasurement(TOTALMOUNT, TOTALPOINT) As Double
    Private clbMeasurement(CLBRAWDATA) As Double

    'Calculated variables
    'Private spacer(CLBRAWDATA) As Double
    Private housingAverage As Double 'to be used in HousingAverageValue() function
    Private c0 As Double 'calculated correction value
    Private mountName As String
    Private angle As Double
    Private clbCorrectionValue As Double
    Private housingCorrectionValue As Double
    Private tilt(TOTALMOUNT) As Double
    Private dsCorrectionValue As Double
    Private dsParameter(DSTOTALPARAMETER) As Double
    Private differenceTowardSpacer As Double
    Private remainingDifference As Double
    Private expectedCLB As Double


    'CONSTRUCTOR
    ' 25/9/2023 Aklif Sainie : Initial creation for DS Mode implementation 2oct 2023 - Major Modification
    Public Sub New(ByVal sn As String)
        serialno = sn
    End Sub

    '18/8/2022 Aklif Sainie : Initial creation of Buffer class constructor
    Public Sub New(ByVal sn As String,
                    ByVal h1 As Double,
                    ByVal h2 As Double,
                    ByVal h3 As Double,
                    ByVal h4 As Double,
                    ByVal h5 As Double,
                    ByVal h6 As Double,
                    ByVal c1 As Double,
                    ByVal c2 As Double,
                    ByVal c3 As Double)
        serialno = sn
        housingMeasurement(0, 0) = h1
        housingMeasurement(0, 1) = h2
        housingMeasurement(1, 0) = h3
        housingMeasurement(1, 1) = h4
        housingMeasurement(2, 0) = h5
        housingMeasurement(2, 1) = h6
        clbMeasurement(0) = c1
        clbMeasurement(1) = c2
        clbMeasurement(2) = c3

        'CLBDESIGNVALUE = InitializeConstantVariables("CLBDesignValue")
        'HOUSINGDESIGNVALUE = InitializeConstantVariables("HousingDesignValue")
        'MAGNIFICATION = InitializeConstantVariables("Magnification")
        'HOUSINGRAWDATA = InitializeConstantVariables("HousingRawData")
        'CLBRAWDATA = InitializeConstantVariables("CLBRawData")
        'TOTALMOUNT = InitializeConstantVariables("TotalMount")
        'TOTALPOINT = InitializeConstantVariables("TotalPoint")
        'COSINEVALUE = InitializeConstantVariables("CosineValue") * (PI / 180)
        'spacers = InitializeConstantVariables("SpacerChoice")
        'CONSTANTVARIABLE = InitializeConstantVariables("ConstantVariable")
    End Sub

    '2022/7/8 Aklif Sainie : Initial creation of InitializeConstantVariables() function
    Public Function InitializeConstantVariables(parameter As String)
        Dim value As String = objSQL.InitializeFixedVariables(parameter)
        Return value
    End Function

    '18/8/2022 Aklif Sainie : initial creation of HousingAverageValue() function
    Public Function HousingAverageValue(measurement1 As Decimal, measurement2 As Decimal) As Double
        'If My.Settings.dsMode = False Then
        '    housingAverage = (measurement1 + measurement2) / TOTALPOINT
        'ElseIf My.Settings.dsMode = True Then
        '    housingAverage = ((measurement1 + measurement2) / TOTALPOINT) - HOUSINGDESIGNVALUE
        'End If
        housingAverage = (measurement1 + measurement2) / TOTALPOINT
        Return housingAverage
    End Function

    '18/8/2022 Aklif Sainie : Initial creation of CorrectionValue() function
    Public Function CorrectionValue(measurement As Decimal, designV As Decimal, previousfb As Decimal) As Double
        c0 = measurement - designV - previousfb
        Return c0
    End Function

    Public Function HousingMinimumValue(data1 As Decimal, data2 As Decimal) As Integer

        If data1 < data2 Then
            Return 1
        Else
            Return -1
        End If
    End Function

    '18/8/2022 Aklif Sainie : Initial creation of MovingAverageCalculation() function
    Public Function MovingAverageCalculation() As Boolean

        ''Redeclare variables incase have master changes during production running
        CLBDESIGNVALUE = My.Settings.CLBdv
        HOUSINGDESIGNVALUE = My.Settings.Housingdv
        MAGNIFICATION = InitializeConstantVariables("Magnification")
        COSINEVALUE = InitializeConstantVariables("CosineValue") * (PI / 180)
        spacers = InitializeConstantVariables("SpacerChoice")
        CONSTANTVARIABLE = InitializeConstantVariables("ConstantVariable")



        Try
            'Loop for each mount H,C,HK
            For i = 0 To TOTALMOUNT - 1
                If i = 0 Then
                    mountName = "K"
                ElseIf i = 1 Then
                    mountName = "HK"
                ElseIf i = 2 Then
                    mountName = "C"
                End If

                Dim PREVIOUSFEEDBACK As Double
                Dim REFERENCEFEEDBACKSN As String

                If My.Settings.feedback = "Disable" Then
                    PREVIOUSFEEDBACK = 0
                    REFERENCEFEEDBACKSN = "Disable"
                ElseIf My.Settings.feedback = "Enable" Then
                    PREVIOUSFEEDBACK = objSQL.GetPreviousFBValue(mountName)
                    REFERENCEFEEDBACKSN = objSQL.ReferenceFBSN
                ElseIf My.Settings.feedback = "Fixed" Then
                    If mountName = "K" Then
                        PREVIOUSFEEDBACK = My.Settings.FixFBK
                    ElseIf mountName = "C" Then
                        PREVIOUSFEEDBACK = My.Settings.FixFBC
                    ElseIf mountName = "HK" Then
                        PREVIOUSFEEDBACK = My.Settings.FixFBHK
                    End If
                    REFERENCEFEEDBACKSN = "Fixed"
                ElseIf My.Settings.feedback = "MinMax" Then
                    PREVIOUSFEEDBACK = objSQL.GetPreviousFBValue(mountName)
                    REFERENCEFEEDBACKSN = objSQL.ReferenceFBSN
                End If

                'Clb correction value calculation
                clbCorrectionValue = CorrectionValue(clbMeasurement(i), CLBDESIGNVALUE, PREVIOUSFEEDBACK)

                'Get housing average value from both point(A&C or B&D) for a mount THEN calculate housing correction value
                Dim average = HousingAverageValue(housingMeasurement(i, 0), housingMeasurement(i, 1))
                housingCorrectionValue = CorrectionValue(average, HOUSINGDESIGNVALUE, 0)

                Dim smallest As Double
                Dim largest As Double


                If housingMeasurement(i, 0) < housingMeasurement(i, 1) Then
                    smallest = housingMeasurement(i, 0)
                    largest = housingMeasurement(i, 1)
                Else
                    smallest = housingMeasurement(i, 1)
                    largest = housingMeasurement(i, 0)
                End If

                angle = HousingMinimumValue(housingMeasurement(i, 0), housingMeasurement(i, 1)) * (smallest - largest)
                If i = 0 Or i = 1 Then
                    MAGNIFICATION = InitializeConstantVariables("MAGNIFICATION")
                    tilt(i) = angle * MAGNIFICATION
                ElseIf i = 2 Then
                    MAGNIFICATION = 0
                    tilt(i) = (tilt(0) + tilt(1)) / 2
                End If

                differenceTowardSpacer = ((clbCorrectionValue) / (Cos(COSINEVALUE))) + (housingCorrectionValue) + (tilt(i)) + CONSTANTVARIABLE

                'Split spacer choices between delimeter ","
                spacerArray = spacers.Split(New Char() {","})

                Dim spacerSeq As Double(,) 'Declare 2D array variable without index number
                Dim countSpacer As Integer = 0
                countDoubleSpacer = 0

                'Count total spacer
                For Each spacer As String In spacerArray
                    countSpacer = countSpacer + 1
                Next

                '----------------------24/9/2022 Aklif Sainie : Double spacer combination algorithm ------------------
                Dim minusValue As Integer = countSpacer
                Dim newSpacer(countSpacer, countSpacer) As Double 'this is double spacer value with 2d array

                '2d array of double spacer
                For a = 0 To countSpacer - 1
                    For b = 0 To countSpacer - minusValue
                        'MsgBox("(" & a & "," & b & ")")
                        newSpacer(a, b) = Convert.ToDouble(spacerArray(a)) + Convert.ToDouble(spacerArray(b))
                        'MsgBox("2d Array : " & newSpacer(a, b))
                        countDoubleSpacer = countDoubleSpacer + 1
                    Next
                    minusValue = minusValue - 1
                Next
                'MsgBox(countDoubleSpacer)

                'Rearrange array into 1d array of single spacer
                Dim newSpacerArray(countDoubleSpacer) As Double ' this is doubel spacer value with 1d array
                Dim minusValue1 As Integer = countSpacer
                Dim c As Integer = 0
                For a = 0 To countSpacer - 1
                    For b = 0 To countSpacer - minusValue1
                        newSpacerArray(c) = newSpacer(a, b)
                        'MsgBox("1d Array : " & newSpacerArray(c))
                        c = c + 1
                    Next
                    minusValue1 = minusValue1 - 1
                Next

                '-----------------------------------------------------------------------------------------------------

                ReDim spacerSeq(2, countDoubleSpacer) 'Redeclare array variable with index number
                Dim differences(countDoubleSpacer) As Integer


                ' To check if the diffenreces is negative value, If -ve, multiply by -1. Then sort from smallest to largest.
                For j = 0 To countDoubleSpacer - 1
                    spacerSeq(0, j) = newSpacerArray(j)
                    spacerSeq(1, j) = newSpacerArray(j) - differenceTowardSpacer

                    If spacerSeq(1, j) < 0 Then
                        spacerSeq(1, j) = spacerSeq(1, j) * -1
                    End If
                Next

                'FOR DOUBLE SPACER - KINDLY DONT DELETE 
                'For j = 0 To countSpacer - 1
                '    newSpacerArray(j) = Convert.ToDouble(spacerArray(j))
                '    spacerSeq(0, j) = newSpacerArray(j)
                '    spacerSeq(1, j) = newSpacerArray(j) - differenceTowardSpacer

                '    If spacerSeq(1, j) < 0 Then
                '        spacerSeq(1, j) = spacerSeq(1, j) * -1
                '    End If
                'Next

                'bubble sort : to sort the spacer differences in ascending order
                For k = 0 To countDoubleSpacer - 1
                    For l = 0 To countDoubleSpacer - 1
                        If spacerSeq(1, l) > spacerSeq(1, l + 1) Then
                            Dim Temp As Double
                            Dim Temp2 As Double

                            Temp = spacerSeq(0, l)
                            Temp2 = spacerSeq(1, l)

                            spacerSeq(0, l) = spacerSeq(0, l + 1)
                            spacerSeq(1, l) = spacerSeq(1, l + 1)

                            spacerSeq(0, l + 1) = Temp
                            spacerSeq(1, l + 1) = Temp2
                        End If
                    Next
                Next

                If My.Settings.dsMode = True Then
                    correctID = 1
                End If

                chosenSpacer = spacerSeq(0, 1)



                Dim minusValue2 As Integer = countSpacer
                Dim d As Integer = 0
                For a = 0 To countSpacer - 1
                    For b = 0 To countSpacer - minusValue2
                        'MsgBox(newSpacer(a, b))
                        If chosenSpacer = newSpacer(a, b) Then
                            'MsgBox("chosen spacer : " & chosenSpacer & ", newspacer : " & newSpacer(a, b))
                            'MsgBox(chosenSpacer1 & "," & chosenSpacer2)
                            chosenSpacer1 = Convert.ToDouble(spacerArray(a))
                            chosenSpacer2 = Convert.ToDouble(spacerArray(b))
                        End If
                        d = d + 1
                    Next
                    minusValue2 = minusValue2 - 1
                Next

                remainingDifference = chosenSpacer - differenceTowardSpacer
                expectedCLB = CLBDESIGNVALUE - (remainingDifference * Cos(COSINEVALUE))
                dsCorrectionValue = 0

                If objSQL.DBSpacerChoiceCalculation(serialno,
                                                    correctID,
                                                    mountName,
                                                    FormatNumber(clbMeasurement(i), 4),
                                                    FormatNumber(CLBDESIGNVALUE, 4),
                                                    FormatNumber(clbCorrectionValue, 4),
                                                    FormatNumber(average, 4),
                                                    FormatNumber(HOUSINGDESIGNVALUE, 4),
                                                    FormatNumber(housingCorrectionValue, 4),
                                                    FormatNumber(dsCorrectionValue, 4),
                                                    FormatNumber(MAGNIFICATION, 4),
                                                    FormatNumber(angle, 4),
                                                    FormatNumber(tilt(i), 4),
                                                    REFERENCEFEEDBACKSN,
                                                    FormatNumber(PREVIOUSFEEDBACK, 4),
                                                    FormatNumber(differenceTowardSpacer, 4),
                                                    FormatNumber(chosenSpacer, 4),
                                                    FormatNumber(chosenSpacer1, 4),
                                                    FormatNumber(chosenSpacer2, 4),
                                                    FormatNumber(remainingDifference, 4),
                                                    FormatNumber(expectedCLB, 4)) = True Then
                End If
            Next
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    '1/9/2022 Aklif Sainie : Initial Creation for DSModeCalculation function
    '25/9/2023 Aklif Sainie : Major modification - DS Mode implementation on 2 October 2023
    Public Function DSModeCalculation() As Boolean

        objSQL = New SQLController()
        If objSQL.Find(serialno, "DSCalculationResult", Nothing) = True Then
            objSQL = New SQLController("DELETE FROM [" + My.Settings.database + "].[dbo].[DSCalculationResult] WHERE SerialNo = '" + serialno + "'")
            objSQL.Delete()
        End If

        If objSQL.Find(serialno, "DBSpacerChoiceCalculation", "K','C','HK") = True Then
            objSQL = New SQLController("DELETE FROM [" + My.Settings.database + "].[dbo].[DBSpacerChoiceCalculation] WHERE SerialNo = '" + serialno + "'")
            objSQL.Delete()
        End If

        If objSQL.Find(serialno, "DSCalculationResult", Nothing) = True Then
            objSQL = New SQLController("DELETE FROM [" + My.Settings.database + "].[dbo].[DBSpacerChoiceCalculation] WHERE SerialNo = '" + serialno + "'")
            objSQL.Delete()
        End If

        Dim queryVariable As String = ""
        Dim queryDSCalc As String = ""
        Dim queryOverall As String = ""
        Dim queryInsert As String = ""
        Dim queryInsertSpacer As String = ""

        Dim fbvalueK As String = ""
        Dim fbvalueC As String = ""
        Dim fbvalueHK As String = ""

        If My.Settings.feedback = "Fixed" Then
            fbvalueK = My.Settings.FBValueSaveK.ToString()
            fbvalueC = My.Settings.FBValueSaveC.ToString()
            fbvalueHK = My.Settings.FBValueSaveHK.ToString()
        ElseIf My.Settings.feedback = "MinMax" Or My.Settings.feedback = "Enable" Then
            fbvalueK = "@PREVIOUSFBK"
            fbvalueC = "@PREVIOUSFBC"
            fbvalueHK = "@PREVIOUSFBHK"
        ElseIf My.Settings.feedback = "Disable" Then
            fbvalueK = "0"
            fbvalueC = "0"
            fbvalueHK = "0"
        End If
        '---------------------------------------INSERT TO DSCALCULATIONRESULT TABLE -------------------------------------------------
        queryVariable = "-- VARIABLES
                        DECLARE @SN AS nvarchar(16) = '" & serialno & "'
                        DECLARE @HousingK AS decimal(10,4) = (SELECT (H_KA+H_KC)/2 FROM [DRAFSystem_MY].[dbo].[DBCLBHousingMeasurement] WHERE SerialNo = @SN)
                        DECLARE @HousingC AS decimal(10,4) = (SELECT (H_CB+H_CD)/2 FROM [DRAFSystem_MY].[dbo].[DBCLBHousingMeasurement] WHERE SerialNo = @SN)
                        DECLARE @HousingHK AS decimal(10,4) = (SELECT (H_HKA+H_HKC)/2 FROM [DRAFSystem_MY].[dbo].[DBCLBHousingMeasurement] WHERE SerialNo = @SN)
                        DECLARE @CLBK AS decimal(10,4) = (SELECT C_K FROM [DRAFSystem_MY].[dbo].[DBCLBHousingMeasurement] WHERE SerialNo = @SN)
                        DECLARE @CLBC AS decimal(10,4) = (SELECT C_C FROM [DRAFSystem_MY].[dbo].[DBCLBHousingMeasurement] WHERE SerialNo = @SN)
                        DECLARE @CLBHK AS decimal(10,4) = (SELECT C_HK FROM [DRAFSystem_MY].[dbo].[DBCLBHousingMeasurement] WHERE SerialNo = @SN)

                        -- MASTER
                        DECLARE @CLBDV decimal(10, 4) = (SELECT CONVERT(decimal(10, 4), RTRIM([Value])) FROM [DRAFSystem_MY].[dbo].[MasterCLBHousingFixedValue] WHERE [Description] = 'CLBDesignValue')
                        DECLARE @HDV decimal(10, 4) = (SELECT CONVERT(decimal(10, 4), RTRIM([Value])) FROM [DRAFSystem_MY].[dbo].[MasterCLBHousingFixedValue] WHERE [Description] = 'HousingDesignValue')
                        DECLARE @Magnification decimal(10, 4) = (SELECT CONVERT(decimal(10, 4), RTRIM([Value])) FROM [DRAFSystem_MY].[dbo].[MasterCLBHousingFixedValue] WHERE [Description] = 'Magnification')
                        DECLARE @COSValue decimal(10, 4) = RADIANS((SELECT CONVERT(decimal(10, 4), RTRIM([Value])) FROM [DRAFSystem_MY].[dbo].[MasterCLBHousingFixedValue] WHERE [Description] = 'CosineValue'))
                        DECLARE @Constant decimal(10, 4) = (SELECT CONVERT(decimal(10, 4), RTRIM([Value])) FROM [DRAFSystem_MY].[dbo].[MasterCLBHousingFixedValue] WHERE [Description] = 'ConstantVariable')
                        DECLARE @CORRECTID INT = (SELECT TOP(1) [correct_id] FROM [DRAFSystem_MY].[dbo].[DS_Correct_Data_Table] ORDER BY correct_id DESC)

                        -- CALCULATE VALUE
                        DECLARE @AngleK decimal(10,4) = (SELECT CASE WHEN (H_KA-H_KC) < 0 THEN (H_KA-H_KC)*(-1) ELSE (H_KA-H_KC) END AS Angle FROM [DRAFSystem_MY].[dbo].[DBCLBHousingMeasurement] WHERE SerialNo = @SN)
                        DECLARE @AngleC decimal(10,4) = (SELECT CASE WHEN (H_CB-H_CD) < 0 THEN (H_CB-H_CD)*(-1) ELSE (H_CB-H_CD) END AS Angle FROM [DRAFSystem_MY].[dbo].[DBCLBHousingMeasurement] WHERE SerialNo = @SN)
                        DECLARE @AngleHK decimal(10,4) = (SELECT CASE WHEN (H_HKA-H_HKC) < 0 THEN (H_HKA-H_HKC)*(-1) ELSE (H_HKA-H_HKC) END AS Angle FROM [DRAFSystem_MY].[dbo].[DBCLBHousingMeasurement] WHERE SerialNo = @SN)
                        DECLARE @TiltK decimal(10,4) = @Magnification*@AngleK
                        DECLARE @TiltHK decimal(10,4) = @Magnification*@AngleHK
                        DECLARE @TiltC decimal(10,4) = (@TiltHK+@TiltK)/2

                        -- DS CORRECT VALUE
                        DECLARE @a1_K decimal(18,8) = (SELECT a1_K FROM [DRAFSystem_MY].[dbo].[DS_Correct_Data_Table] WHERE correct_id = @CORRECTID)
                        DECLARE @a2_K decimal(18,8) = (SELECT a2_K FROM [DRAFSystem_MY].[dbo].[DS_Correct_Data_Table] WHERE correct_id = @CORRECTID)
                        DECLARE @a3_K decimal(18,8) = (SELECT a3_K FROM [DRAFSystem_MY].[dbo].[DS_Correct_Data_Table] WHERE correct_id = @CORRECTID)
                        DECLARE @a4_K decimal(18,8) = (SELECT a4_K FROM [DRAFSystem_MY].[dbo].[DS_Correct_Data_Table] WHERE correct_id = @CORRECTID)
                        DECLARE @a5_K decimal(18,8) = (SELECT a5_K FROM [DRAFSystem_MY].[dbo].[DS_Correct_Data_Table] WHERE correct_id = @CORRECTID)
                        DECLARE @a6_K decimal(18,8) = (SELECT a6_K FROM [DRAFSystem_MY].[dbo].[DS_Correct_Data_Table] WHERE correct_id = @CORRECTID)
                        DECLARE @a7_K decimal(18,8) = (SELECT a7_K FROM [DRAFSystem_MY].[dbo].[DS_Correct_Data_Table] WHERE correct_id = @CORRECTID)
                        DECLARE @a8_K decimal(18,8) = (SELECT a8_K FROM [DRAFSystem_MY].[dbo].[DS_Correct_Data_Table] WHERE correct_id = @CORRECTID)
                        DECLARE @a9_K decimal(18,8) = (SELECT a9_K FROM [DRAFSystem_MY].[dbo].[DS_Correct_Data_Table] WHERE correct_id = @CORRECTID)
                        DECLARE @a10_K decimal(18,8) = (SELECT a10_K FROM [DRAFSystem_MY].[dbo].[DS_Correct_Data_Table] WHERE correct_id = @CORRECTID)
                        DECLARE @a11_K decimal(18,8) = (SELECT a11_K FROM [DRAFSystem_MY].[dbo].[DS_Correct_Data_Table] WHERE correct_id = @CORRECTID)
                        DECLARE @a12_K decimal(18,8) = (SELECT a12_K FROM [DRAFSystem_MY].[dbo].[DS_Correct_Data_Table] WHERE correct_id = @CORRECTID)
                        DECLARE @a13_K decimal(18,8) = (SELECT a13_K FROM [DRAFSystem_MY].[dbo].[DS_Correct_Data_Table] WHERE correct_id = @CORRECTID)
                        DECLARE @a14_K decimal(18,8) = (SELECT a14_K FROM [DRAFSystem_MY].[dbo].[DS_Correct_Data_Table] WHERE correct_id = @CORRECTID)
                        DECLARE @a1_C decimal(18,8) = (SELECT a1_C FROM [DRAFSystem_MY].[dbo].[DS_Correct_Data_Table] WHERE correct_id = @CORRECTID)
                        DECLARE @a2_C decimal(18,8) = (SELECT a2_C FROM [DRAFSystem_MY].[dbo].[DS_Correct_Data_Table] WHERE correct_id = @CORRECTID)
                        DECLARE @a3_C decimal(18,8) = (SELECT a3_C FROM [DRAFSystem_MY].[dbo].[DS_Correct_Data_Table] WHERE correct_id = @CORRECTID)
                        DECLARE @a4_C decimal(18,8) = (SELECT a4_C FROM [DRAFSystem_MY].[dbo].[DS_Correct_Data_Table] WHERE correct_id = @CORRECTID)
                        DECLARE @a5_C decimal(18,8) = (SELECT a5_C FROM [DRAFSystem_MY].[dbo].[DS_Correct_Data_Table] WHERE correct_id = @CORRECTID)
                        DECLARE @a6_C decimal(18,8) = (SELECT a6_C FROM [DRAFSystem_MY].[dbo].[DS_Correct_Data_Table] WHERE correct_id = @CORRECTID)
                        DECLARE @a7_C decimal(18,8) = (SELECT a7_C FROM [DRAFSystem_MY].[dbo].[DS_Correct_Data_Table] WHERE correct_id = @CORRECTID)
                        DECLARE @a8_C decimal(18,8) = (SELECT a8_C FROM [DRAFSystem_MY].[dbo].[DS_Correct_Data_Table] WHERE correct_id = @CORRECTID)
                        DECLARE @a9_C decimal(18,8) = (SELECT a9_C FROM [DRAFSystem_MY].[dbo].[DS_Correct_Data_Table] WHERE correct_id = @CORRECTID)
                        DECLARE @a10_C decimal(18,8) = (SELECT a10_C FROM [DRAFSystem_MY].[dbo].[DS_Correct_Data_Table] WHERE correct_id = @CORRECTID)
                        DECLARE @a11_C decimal(18,8) = (SELECT a11_C FROM [DRAFSystem_MY].[dbo].[DS_Correct_Data_Table] WHERE correct_id = @CORRECTID)
                        DECLARE @a12_C decimal(18,8) = (SELECT a12_C FROM [DRAFSystem_MY].[dbo].[DS_Correct_Data_Table] WHERE correct_id = @CORRECTID)
                        DECLARE @a13_C decimal(18,8) = (SELECT a13_C FROM [DRAFSystem_MY].[dbo].[DS_Correct_Data_Table] WHERE correct_id = @CORRECTID)
                        DECLARE @a14_C decimal(18,8) = (SELECT a14_C FROM [DRAFSystem_MY].[dbo].[DS_Correct_Data_Table] WHERE correct_id = @CORRECTID)
                        DECLARE @a1_HK decimal(18,8) = (SELECT a1_HK FROM [DRAFSystem_MY].[dbo].[DS_Correct_Data_Table] WHERE correct_id = @CORRECTID)
                        DECLARE @a2_HK decimal(18,8) = (SELECT a2_HK FROM [DRAFSystem_MY].[dbo].[DS_Correct_Data_Table] WHERE correct_id = @CORRECTID)
                        DECLARE @a3_HK decimal(18,8) = (SELECT a3_HK FROM [DRAFSystem_MY].[dbo].[DS_Correct_Data_Table] WHERE correct_id = @CORRECTID)
                        DECLARE @a4_HK decimal(18,8) = (SELECT a4_HK FROM [DRAFSystem_MY].[dbo].[DS_Correct_Data_Table] WHERE correct_id = @CORRECTID)
                        DECLARE @a5_HK decimal(18,8) = (SELECT a5_HK FROM [DRAFSystem_MY].[dbo].[DS_Correct_Data_Table] WHERE correct_id = @CORRECTID)
                        DECLARE @a6_HK decimal(18,8) = (SELECT a6_HK FROM [DRAFSystem_MY].[dbo].[DS_Correct_Data_Table] WHERE correct_id = @CORRECTID)
                        DECLARE @a7_HK decimal(18,8) = (SELECT a7_HK FROM [DRAFSystem_MY].[dbo].[DS_Correct_Data_Table] WHERE correct_id = @CORRECTID)
                        DECLARE @a8_HK decimal(18,8) = (SELECT a8_HK FROM [DRAFSystem_MY].[dbo].[DS_Correct_Data_Table] WHERE correct_id = @CORRECTID)
                        DECLARE @a9_HK decimal(18,8) = (SELECT a9_HK FROM [DRAFSystem_MY].[dbo].[DS_Correct_Data_Table] WHERE correct_id = @CORRECTID)
                        DECLARE @a10_HK decimal(18,8) = (SELECT a10_HK FROM [DRAFSystem_MY].[dbo].[DS_Correct_Data_Table] WHERE correct_id = @CORRECTID)
                        DECLARE @a11_HK decimal(18,8) = (SELECT a11_HK FROM [DRAFSystem_MY].[dbo].[DS_Correct_Data_Table] WHERE correct_id = @CORRECTID)
                        DECLARE @a12_HK decimal(18,8) = (SELECT a12_HK FROM [DRAFSystem_MY].[dbo].[DS_Correct_Data_Table] WHERE correct_id = @CORRECTID)
                        DECLARE @a13_HK decimal(18,8) = (SELECT a13_HK FROM [DRAFSystem_MY].[dbo].[DS_Correct_Data_Table] WHERE correct_id = @CORRECTID)
                        DECLARE @a14_HK decimal(18,8) = (SELECT a14_HK FROM [DRAFSystem_MY].[dbo].[DS_Correct_Data_Table] WHERE correct_id = @CORRECTID)


                        -- Feedback Value
                        DECLARE @PreviousSN As varchar(16) = (
	                        SELECT TOP (1) [SerialNo]
	                        FROM [DRAFSystem_MY].[dbo].[DBSpacerChoiceCalculation]
	                        WHERE Mount = 'K'
	                        AND FeedbackValue IS NOT NULL
	                        ORDER BY UpdatedDate DESC
                        )


                        DECLARE @PREVIOUSFBK decimal(10,4) = (
	                        SELECT TOP (1) [FeedbackValue]
	                        FROM [DRAFSystem_MY].[dbo].[DBSpacerChoiceCalculation]
	                        WHERE Mount = 'K'
	                        AND FeedbackValue IS NOT NULL
	                        AND SerialNo = @PreviousSN
                        )

                        DECLARE @PREVIOUSFBC decimal(10,4) = (
	                        SELECT TOP (1) [FeedbackValue]
	                        FROM [DRAFSystem_MY].[dbo].[DBSpacerChoiceCalculation]
	                        WHERE Mount = 'C'
	                        AND FeedbackValue IS NOT NULL
	                        AND SerialNo = @PreviousSN
                        )
                        DECLARE @PREVIOUSFBHK decimal(10,4) = (
	                        SELECT TOP (1) [FeedbackValue]
	                        FROM [DRAFSystem_MY].[dbo].[DBSpacerChoiceCalculation]
	                        WHERE Mount = 'HK'
	                        AND FeedbackValue IS NOT NULL
	                        AND SerialNo = @PreviousSN
                        )
                        "

        queryInsert = "INSERT INTO [" & My.Settings.database & "].[dbo].[DSCalculationResult]"

        queryDSCalc = "SELECT TOP(1) @SN As SerialNo, Expected.*, @CLBDV AS CLBDV
                        ,POWER((@CLBDV-(ExpectedCLBPositionK)),2) AS DiffK
                        ,POWER((@CLBDV-(ExpectedCLBPositionC)),2) AS DiffC
                        ,POWER((@CLBDV-(ExpectedCLBPositionHK)),2) AS DiffHK
                        ,POWER((@CLBDV-(ExpectedCLBPositionK)),2)+POWER((@CLBDV-(ExpectedCLBPositionC)),2)+POWER((@CLBDV-(ExpectedCLBPositionHK)),2) AS TotalDiff
                        ,@PreviousSN AS ReferenceFeedbackSN
                        FROM (
	                        SELECT *
	                        ,(CLBKa1_dsK)+(CLBCa2_dsK)+(CLBHKa3_dsK)+(HousingKa4_dsK)+(HousingCa5_dsK)+(HousingHKa6_dsK)+(SpacerKa7_dsK)+(SpacerCa8_dsK)+(SpacerHKa9_dsK)+(TiltKa10_dsK)+(TiltCa11_dsK)+(TiltHKa12_dsK)+(Bump_dsK)+(a14K)+(FeedbackValue_dsK) As ExpectedCLBPositionK
	                        ,(CLBKa1_dsC)+(CLBCa2_dsC)+(CLBHKa3_dsC)+(HousingKa4_dsC)+(HousingCa5_dsC)+(HousingHKa6_dsC)+(SpacerKa7_dsC)+(SpacerCa8_dsC)+(SpacerHKa9_dsC)+(TiltKa10_dsC)+(TiltCa11_dsC)+(TiltHKa12_dsC)+(Bump_dsC)+(a14C)+(FeedbackValue_dsC) As ExpectedCLBPositionC
	                        ,(CLBKa1_dsHK)+(CLBCa2_dsHK)+(CLBHKa3_dsHK)+(HousingKa4_dsHK)+(HousingCa5_dsHK)+(HousingHKa6_dsHK)+(SpacerKa7_dsHK)+(SpacerCa8_dsHK)+(SpacerHKa9_dsHK)+(TiltKa10_dsHK)+(TiltCa11_dsHK)+(TiltHKa12_dsHK)+(Bump_dsHK)+(a14HK)+(FeedbackValue_dsHK )As ExpectedCLBPositionHK
	                        FROM (
		                        SELECT dbl.[Id],dbl.[K],dbl.[C],dbl.[HK]
		                        ,(SELECT C_K FROM [DRAFSystem_MY].[dbo].[DBCLBHousingMeasurement] WHERE SerialNo = @SN) AS CLBK
		                        ,(SELECT C_C FROM [DRAFSystem_MY].[dbo].[DBCLBHousingMeasurement] WHERE SerialNo = @SN) AS CLBC
		                        ,(SELECT C_HK FROM [DRAFSystem_MY].[dbo].[DBCLBHousingMeasurement] WHERE SerialNo = @SN) AS CLBHK
		                        ,(SELECT C_K*@a1_K FROM [DRAFSystem_MY].[dbo].[DBCLBHousingMeasurement] WHERE SerialNo = @SN) AS CLBKa1_dsK
		                        ,(SELECT C_C*@a2_K FROM [DRAFSystem_MY].[dbo].[DBCLBHousingMeasurement] WHERE SerialNo = @SN) AS CLBCa2_dsK
		                        ,(SELECT C_HK*@a3_K FROM [DRAFSystem_MY].[dbo].[DBCLBHousingMeasurement] WHERE SerialNo = @SN) AS CLBHKa3_dsK
		                        ,@HousingK*@a4_K AS HousingKa4_dsK
		                        ,@HousingC*@a5_K AS HousingCa5_dsK
		                        ,@HousingHK*@a6_K AS HousingHKa6_dsK
		                        ,dbl.K*@a7_K AS SpacerKa7_dsK
		                        ,dbl.C*@a8_K AS SpacerCa8_dsK
		                        ,dbl.HK*@a9_K AS SpacerHKa9_dsK
		                        ,@TiltK*@a10_K AS TiltKa10_dsK
		                        ,@TiltC*@a11_K AS TiltCa11_dsK
		                        ,@TiltHK*@a12_K AS TiltHKa12_dsK
		                        ,((@CLBC) - ((@CLBHK+@CLBK)/2))*@a13_K AS Bump_dsK
		                        ,@a14_K AS a14K
		                        ,(" & fbvalueK & ") As FeedbackValue_dsK

		                        ,(SELECT C_K*@a1_C FROM [DRAFSystem_MY].[dbo].[DBCLBHousingMeasurement] WHERE SerialNo = @SN) AS CLBKa1_dsC
		                        ,(SELECT C_C*@a2_C FROM [DRAFSystem_MY].[dbo].[DBCLBHousingMeasurement] WHERE SerialNo = @SN) AS CLBCa2_dsC
		                        ,(SELECT C_HK*@a3_C FROM [DRAFSystem_MY].[dbo].[DBCLBHousingMeasurement] WHERE SerialNo = @SN) AS CLBHKa3_dsC
		                        ,@HousingK*@a4_C AS HousingKa4_dsC
		                        ,@HousingC*@a5_C AS HousingCa5_dsC
		                        ,@HousingHK*@a6_C AS HousingHKa6_dsC
		                        ,dbl.K*@a7_C AS SpacerKa7_dsC
		                        ,dbl.C*@a8_C AS SpacerCa8_dsC
		                        ,dbl.HK*@a9_C AS SpacerHKa9_dsC
		                        ,@TiltK*@a10_C AS TiltKa10_dsC
		                        ,@TiltC*@a11_C AS TiltCa11_dsC
		                        ,@TiltHK*@a12_C AS TiltHKa12_dsC
		                        ,((@CLBC) - ((@CLBHK+@CLBK)/2))*@a13_C AS Bump_dsC
		                        ,@a14_C AS a14C
		                        ,(" & fbvalueC & ") As FeedbackValue_dsC

		                        ,(SELECT C_K*@a1_HK FROM [DRAFSystem_MY].[dbo].[DBCLBHousingMeasurement] WHERE SerialNo = @SN) AS CLBKa1_dsHK
		                        ,(SELECT C_C*@a2_HK FROM [DRAFSystem_MY].[dbo].[DBCLBHousingMeasurement] WHERE SerialNo = @SN) AS CLBCa2_dsHK
		                        ,(SELECT C_HK*@a3_HK FROM [DRAFSystem_MY].[dbo].[DBCLBHousingMeasurement] WHERE SerialNo = @SN) AS CLBHKa3_dsHK
		                        ,@HousingK*@a4_HK AS HousingKa4_dsHK
		                        ,@HousingC*@a5_HK AS HousingCa5_dsHK
		                        ,@HousingHK*@a6_HK AS HousingHKa6_dsHK
		                        ,dbl.K*@a7_HK AS SpacerKa7_dsHK
		                        ,dbl.C*@a8_HK AS SpacerCa8_dsHK
		                        ,dbl.HK*@a9_HK AS SpacerHKa9_dsHK
		                        ,@TiltK*@a10_HK AS TiltKa10_dsHK
		                        ,@TiltC*@a11_HK AS TiltCa11_dsHK
		                        ,@TiltHK*@a12_HK AS TiltHKa12_dsHK
		                        ,((@CLBC) - ((@CLBHK+@CLBK)/2))*@a13_HK AS Bump_dsHK
		                        ,@a14_HK AS a14HK
		                        ,(" & fbvalueHK & ") As FeedbackValue_dsHK

		                        FROM [DRAFSystem_MY].[dbo].[MasterDoubleSpacerCombination] dbl
	                        ) AS Expected
                        ) AS Expected
                        ORDER BY TotalDiff ASC;"

        queryInsertSpacer = "INSERT INTO [DRAFSystem_MY].[dbo].[DBSpacerChoiceCalculation]
                            SELECT MAIN.SerialNo, @CORRECTID As correct_id, 'K' As Mount, MAIN.C_K As CLBHeight
                            ,@CLBDV AS CLBDesignValue
                            ,MAIN.C_K-(@CLBDV)-(" & fbvalueK & ") AS CLBCorrectionValue
                            ,(MAIN.H_KA+MAIN.H_KC)/2 AS HousingAverage
                            ,@HDV As HousingDesignValue
                            ,((MAIN.H_KA+MAIN.H_KC)/2)-(@HDV) AS HousingCorrectionValue
                            ,0.0000 AS DSCorrectionValue
                            ,@Magnification AS Magnification
                            ,@AngleK AS Angle
                            ,@TiltK AS Tilt
                            ,SUBMAIN.ReferenceFeedbackSN
                            ,CONVERT(decimal(10,4),SUBMAIN.FeedbackValue_dsK) AS ReferenceFeedbackValue -- VARIABLE
                            ,SUBMAIN.DiffK AS DiffTowardSpacer -- VARIABLE
                            ,SUBMAIN.K AS DoubleSpacerChoice -- VARIABLE
                            ,(SELECT Spacer1 FROM [DRAFSystem_MY].[dbo].[DoubleSpacerMaster] WHERE DoubleSpacerValue = SUBMAIN.K) AS SpacerChoice -- VARIABLE
                            ,(SELECT Spacer2 FROM [DRAFSystem_MY].[dbo].[DoubleSpacerMaster] WHERE DoubleSpacerValue = SUBMAIN.K) AS SpacerChoice2 -- VARIABLE
                            ,(SUBMAIN.K)-(SUBMAIN.DiffK) AS RemainingDifference
                            ,SUBMAIN.ExpectedCLBPositionK AS ExpectedCLB --VARIABLE
                            ,(" & fbvalueK & ") AS FeedbackValue
                            ,GETDATE() AS RegistrationDate
                            ,GETDATE() AS UpdatedDate
                            ,NULL Remarks
                            FROM [DRAFSystem_MY].[dbo].[DBCLBHousingMeasurement] MAIN
                            LEFT JOIN [DRAFSystem_MY].[dbo].[DSCalculationResult] SUBMAIN ON MAIN.SerialNo = SUBMAIN.SerialNo
                            WHERE MAIN.SerialNo = @SN

                            UNION ALL

                            SELECT MAIN.SerialNo, @CORRECTID As correct_id, 'C' As Mount, MAIN.C_C As CLBHeight
                            ,@CLBDV AS CLBDesignValue
                            ,MAIN.C_C-(@CLBDV)-(" & fbvalueC & ") AS CLBCorrectionValue --VARIABLE
                            ,(MAIN.H_CB+MAIN.H_CD)/2 AS HousingAverage --VARIABLE
                            ,@HDV As HousingDesignValue
                            ,((MAIN.H_CB+MAIN.H_CD)/2)-(@HDV) AS HousingCorrectionValue --VARIABLE
                            ,0.0000 AS DSCorrectionValue
                            ,@Magnification AS Magnification
                            ,@AngleC AS Angle --VARIABLE
                            ,@TiltC AS Tilt --VARIABLE
                            ,SUBMAIN.ReferenceFeedbackSN
                            ,CONVERT(decimal(10,4),SUBMAIN.FeedbackValue_dsC) AS ReferenceFeedbackValue -- VARIABLE
                            ,SUBMAIN.DiffC AS DiffTowardSpacer -- VARIABLE
                            ,SUBMAIN.C AS DoubleSpacerChoice -- VARIABLE
                            ,(SELECT Spacer1 FROM [DRAFSystem_MY].[dbo].[DoubleSpacerMaster] WHERE DoubleSpacerValue = SUBMAIN.C) AS SpacerChoice -- VARIABLE
                            ,(SELECT Spacer2 FROM [DRAFSystem_MY].[dbo].[DoubleSpacerMaster] WHERE DoubleSpacerValue = SUBMAIN.C) AS SpacerChoice2 -- VARIABLE
                            ,(SUBMAIN.C)-(SUBMAIN.DiffC) AS RemainingDifference --VARIABLE
                            ,SUBMAIN.ExpectedCLBPositionC AS ExpectedCLB --VARIABLE
                            ,(" & fbvalueC & ") AS FeedbackValue
                            ,GETDATE() AS RegistrationDate
                            ,GETDATE() AS UpdatedDate
                            ,NULL Remarks
                            FROM [DRAFSystem_MY].[dbo].[DBCLBHousingMeasurement] MAIN
                            LEFT JOIN [DRAFSystem_MY].[dbo].[DSCalculationResult] SUBMAIN ON MAIN.SerialNo = SUBMAIN.SerialNo
                            WHERE MAIN.SerialNo = @SN

                            UNION ALL

                            SELECT MAIN.SerialNo, @CORRECTID As correct_id, 'HK' As Mount, MAIN.C_HK As CLBHeight
                            ,@CLBDV AS CLBDesignValue
                            ,MAIN.C_HK-(@CLBDV)-(" & fbvalueHK & ") AS CLBCorrectionValue --VARIABLE
                            ,(MAIN.H_HKA+MAIN.H_HKC)/2 AS HousingAverage --VARIABLE
                            ,@HDV As HousingDesignValue
                            ,((MAIN.H_HKA+MAIN.H_HKC)/2)-(@HDV) AS HousingCorrectionValue --VARIABLE
                            ,0.0000 AS DSCorrectionValue
                            ,@Magnification AS Magnification
                            ,@AngleHK AS Angle --VARIABLE
                            ,@TiltHK AS Tilt --VARIABLE
                            ,SUBMAIN.ReferenceFeedbackSN
                            ,CONVERT(decimal(10,4),SUBMAIN.FeedbackValue_dsHK) AS ReferenceFeedbackValue -- VARIABLE
                            ,SUBMAIN.DiffHK AS DiffTowardSpacer -- VARIABLE
                            ,SUBMAIN.HK AS DoubleSpacerChoice -- VARIABLE
                            ,(SELECT Spacer1 FROM [DRAFSystem_MY].[dbo].[DoubleSpacerMaster] WHERE DoubleSpacerValue = SUBMAIN.HK) AS SpacerChoice -- VARIABLE
                            ,(SELECT Spacer2 FROM [DRAFSystem_MY].[dbo].[DoubleSpacerMaster] WHERE DoubleSpacerValue = SUBMAIN.HK) AS SpacerChoice2 -- VARIABLE
                            ,(SUBMAIN.HK)-(SUBMAIN.DiffHK) AS RemainingDifference --VARIABLE
                            ,SUBMAIN.ExpectedCLBPositionHK AS ExpectedCLB --VARIABLE
                            ,(" & fbvalueHK & ") AS FeedbackValue
                            ,GETDATE() AS RegistrationDate
                            ,GETDATE() AS UpdatedDate
                            ,NULL Remarks
                            FROM [DRAFSystem_MY].[dbo].[DBCLBHousingMeasurement] MAIN
                            LEFT JOIN [DRAFSystem_MY].[dbo].[DSCalculationResult] SUBMAIN ON MAIN.SerialNo = SUBMAIN.SerialNo
                            WHERE MAIN.SerialNo = @SN
                            "

        queryOverall = queryVariable & vbCrLf & vbCrLf & queryInsert & vbCrLf & vbCrLf & queryDSCalc & vbCrLf & vbCrLf & queryInsertSpacer


        objSQL = New SQLController(queryOverall)
        objSQL.Insert()

        queryVariable = ""
        queryDSCalc = ""
        queryOverall = ""
        queryInsert = ""
        '---------------------------------------------------------------------------------------------------------------


        Return True
    End Function

    Public Function DoubleSpacerCalculation(spacerArray As Double, totalSpacer As Integer) As Double(,)
        Dim minusValue As Integer = totalSpacer
        For i = 0 To totalSpacer - 1
            For j = 0 To totalSpacer - minusValue
                MsgBox("(" & totalSpacer & "," & minusValue & ")")
            Next
            minusValue = minusValue - 1
        Next
    End Function

End Class
