Imports System
Imports System.IO
Public Class Test_Form

    Public CSVLength As Integer = 45                '题库数量
    Public Range As Integer = CSVLength  '测试范围
    Public Exam() As String = LoadCSV()        '读取csv，生成题库
    Public QuestionNum As Integer           '问题序号
    Public Score As Integer                 '得分
    Private AnswerSeed() As Integer         '答案队列

    Public Function LoadCSV() As String()

        Dim sr As StreamReader = New StreamReader("list.CSV")
        Dim line(Range) As String

        Dim i As Integer = 0
        Do
            line(i) = sr.ReadLine()
            i = i + 1
        Loop Until sr.Peek = -1
        sr.Close()

        Return line

    End Function

    Private Function RandamQueType() As Integer()
        Dim List(8) As Integer
        Dim Result(1) As Integer

        Dim Total As Integer = 0
        Dim seed As Integer
        Dim i As Integer
        Dim j As Integer
        Dim temp As Boolean

        For i = 0 To 2
            For j = 0 To 2
                temp = Menu_Form.Left_ListBox.GetSelected(i) And Menu_Form.Right_ListBox.GetSelected(j)
                If temp And (i <> j) Then
                    List(i * 3 + j) = 1
                    Total = Total + 1
                End If
            Next
        Next
        '遍历各种左右组合，如果该组合可形成题目，则记该组合为1

        If Total = 0 Then
            List = {0, 1, 1, 1, 0, 1, 1, 1, 0}
            Total = 6
        End If

        Randomize()
        seed = Int(Total * Rnd()) + 1

        j = 1
        For i = 0 To 8
            If List(i) = 1 Then
                If j <> seed Then
                    j = j + 1
                Else : Exit For
                End If
            End If
        Next

        Result(0) = i \ 3   '问题种类。0为罗马音，1为平假名，2为片假名
        Result(1) = i Mod 3 '答案种类。0为罗马音，1为平假名，2为片假名
        Return Result

    End Function

    Private Function RandamAnswerQueue(ByVal Seed) As Integer()
        Dim list(Range - 1) As Integer, i As Integer, rd As Integer, t As Integer
        Dim result(4) As Integer
        Randomize()
        For i = 0 To Range - 1
            list(i) = i
        Next
        For i = 0 To Range - 2
            rd = Fix(Rnd() * (Range - i)) + i
            t = list(i)
            list(i) = list(rd)
            list(rd) = t
        Next

        For i = 0 To 3
            If list(i) <> Seed Then
                result(i) = list(i)
            Else : result(i) = list(4)
            End If                      '如果有答案已经等于正确答案，换之
        Next                            '给result前四位安置随机序号

        t = Int(Rnd() * (UBound(result) - LBound(result)))    '生成正确答案所在位置
        result(t) = Seed                '安置正确答案
        result(4) = t                   '记录答案位置

        Return result
    End Function

    Public Function ShowText(ByVal list, ByVal Num, ByVal type)
        Dim result As String = ""
        Dim flag1 As Integer, flag2 As Integer
        flag1 = InStr(list(Num), ",")
        flag2 = InStr(flag1 + 1, list(Num), ",")
        Select Case type
            Case 0
                result = Mid(list(Num), 1, flag1 - 1)
            Case 1
                result = Mid(list(Num), flag1 + 1, flag2 - flag1 - 1)
            Case 2
                result = Mid(list(Num), flag2 + 1, Len(list(Num)) - flag2)
        End Select
        Return result
    End Function

    Public Sub StartTest()
        QuestionNum = QuestionNum + 1   '初始化题目
        Randomize()
        Dim QuestionSeed As Integer = Int(Range * Rnd())        '问题随机号
        Dim RandomType As Integer() = RandamQueType()           '确定题型
        AnswerSeed = RandamAnswerQueue(QuestionSeed)

        QuestionType_Label.Text = Menu_Form.Left_ListBox.Items(RandomType(0)) + "→" + Menu_Form.Right_ListBox.Items(RandomType(1))  '显示题型
        Score_Label.Text = "得分：" & Score                    '显示得分
        Me.Number_Label.Text = QuestionNum & " / " & Menu_Form.NumOfQuestion_NumericUpDown.Value    '显示当前题号
        Question_Label.Text = ShowText(Exam, QuestionSeed, RandomType(0))   '显示题目

        A_Button.Text = ShowText(Exam, AnswerSeed(0), RandomType(1))
        B_Button.Text = ShowText(Exam, AnswerSeed(1), RandomType(1))
        C_Button.Text = ShowText(Exam, AnswerSeed(2), RandomType(1))
        D_Button.Text = ShowText(Exam, AnswerSeed(3), RandomType(1))

        PrintLine(1, QuestionNum, QuestionSeed, AnswerSeed(0), AnswerSeed(1), AnswerSeed(2), AnswerSeed(3), AnswerSeed(4), RandomType(0), RandomType(1))
        '依次写入0题号，1考点，2答案A，3答案B，4答案C，5答案D，6正确答案序号，7题面类型，8答案类型

    End Sub

    Public Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        FileOpen(1, "TestAnswer.txt", OpenMode.Output)
        FileOpen(2, "Choose.txt", OpenMode.Output)


    End Sub


    Private Sub A_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A_Button.Click
        PrintLine(2, 0)
        If AnswerSeed(4) = 0 Then
            Score = Score + 1
        End If

        If QuestionNum = Menu_Form.NumOfQuestion_NumericUpDown.Value Then
            FileClose(1)
            FileClose(2)
            Result_Form.ResultStart()
            Result_Form.Show()
        Else : StartTest()
        End If

    End Sub

    Private Sub B_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Button.Click
        PrintLine(2, 1)
        If AnswerSeed(4) = 1 Then
            Score = Score + 1
        End If

        If QuestionNum = Menu_Form.NumOfQuestion_NumericUpDown.Value Then
            FileClose(1)
            FileClose(2)
            Result_Form.ResultStart()
            Result_Form.Show()
        Else : StartTest()
        End If
    End Sub

    Private Sub C_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C_Button.Click
        PrintLine(2, 2)
        If AnswerSeed(4) = 2 Then
            Score = Score + 1
        End If

        If QuestionNum = Menu_Form.NumOfQuestion_NumericUpDown.Value Then
            FileClose(1)
            FileClose(2)
            Result_Form.ResultStart()
            Result_Form.Show()
        Else : StartTest()
        End If
    End Sub

    Private Sub D_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D_Button.Click
        PrintLine(2, 3)
        If AnswerSeed(4) = 3 Then
            Score = Score + 1
        End If

        If QuestionNum = Menu_Form.NumOfQuestion_NumericUpDown.Value Then
            FileClose(1)
            FileClose(2)
            Result_Form.ResultStart()
            Result_Form.Show()
        Else : StartTest()
        End If
    End Sub
End Class