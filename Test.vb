Imports System
Imports System.IO
Public Class Test_Form

    Public Exam() As String = GetExam()
    '读取csv，生成题库
    Public Range As Integer = Exam.Length
    '测试范围
    Public QuestionNum As Integer
    '问题序号
    Public Score As Integer
    '得分
    Private AnswerSeed() As Integer
    '答案队列

    Public Function LoadCSV() As String()

        Dim sr As StreamReader = New StreamReader("list.CSV")
        Dim line(TestMenu.TotalNum - 1) As String

        Dim i As Integer = 0
        Do
            line(i) = sr.ReadLine()
            i = i + 1
        Loop Until sr.Peek = -1
        sr.Close()

        Return line

    End Function
    '读取五十音列表CSV到题库

    Private Function GetExam() As String()
        Dim line(TestMenu.TotalNum - 1) As String
        Dim Length = 0
        Dim j = 0
        line = LoadCSV()
        '读取全部题库

        For i = 1 To line.Length
            If TestMenu.TestRange(i - 1) <> "0" Then
                Length = Length + 1
            End If
        Next
        '获得最终题库长度Length（根据考试范围）

        Dim Exam(Length - 1) As String

        For i = 1 To line.Length
            If TestMenu.TestRange(i - 1) <> "0" Then
                Exam(j) = line(i - 1)
                j = j + 1
            End If
        Next
        '根据考试范围筛选题库

        Return Exam
    End Function
    '根据选择的考试范围筛选题库

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
                temp = TestMenu.Left_ListBox.GetSelected(i) And TestMenu.Right_ListBox.GetSelected(j)
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
        '如果两边都没选，则将结果设为全选

        Randomize()
        seed = Int(Total * Rnd()) + 1
        '获得随机种子seed（1-Total）

        j = 1
        For i = 0 To 8
            If List(i) = 1 Then
                If j <> seed Then
                    j = j + 1
                Else : Exit For
                End If
            End If
        Next
        '遍历List，跳过不等于1的情况（即没选的组合），第seed个组合即是随机结果

        Result(0) = i \ 3   '问题种类。0为罗马音，1为平假名，2为片假名
        Result(1) = i Mod 3 '答案种类。0为罗马音，1为平假名，2为片假名
        Return Result

    End Function
    '返回随机题型，Result(a,b)。a为问题，b为答案。a与b范围为0~2。0为罗马音，1为平假名，2为片假名

    Private Function RandamAnswerQueue(ByVal Seed) As Integer()
        Dim list(Range - 1) As Integer, i As Integer, rd As Integer, t As Integer
        Dim result(4) As Integer

        Randomize()

        For i = 0 To Range - 1
            list(i) = i
        Next
        '初始化List，生成序列

        For i = 0 To Range - 2
            rd = Fix(Rnd() * (Range - i)) + i
            t = list(i)
            list(i) = list(rd)
            list(rd) = t
        Next
        '生成随机序列

        For i = 0 To 3
            If list(i) <> Seed Then
                result(i) = list(i)
                '给result前四位安排List的前四位
            Else : result(i) = list(4)
                '如果List前四位有正确答案，给result的相应位置安上错误答案
                '∵不可能有两个正确答案∴如果前四位有正确答案，第五位肯定是错误答案
            End If
        Next
        '给result前四位安置随机序号

        Dim RightAnswer As Integer

        RightAnswer = Int(Rnd() * (UBound(result) - LBound(result)))
        '生成正确答案所在位置(0~3)
        result(RightAnswer) = Seed
        '安置正确答案
        result(4) = RightAnswer
        '记录答案位置

        Return result
    End Function
    '输入一个题库序号（随机数），针对这个序号生成一个答案序列，前四位是四个答案序号，第五位是正确答案位置

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
    '输入列表、序号、类型，返回对应的字符。字符值为列表（一般为Exam）内第X个假名的0.罗马音/1.平假名/2.片假名

    Public Sub NextQuestion()
        QuestionNum = QuestionNum + 1
        '初始化题目
        Randomize()
        Dim QuestionSeed As Integer = Int(Range * Rnd())
        '随机生成考点序号，范围为0~Range
        Dim RandomType As Integer() = RandamQueType()
        '确定题型
        AnswerSeed = RandamAnswerQueue(QuestionSeed)
        '获得备选答案字符串

        QuestionType_Label.Text = TestMenu.Left_ListBox.Items(RandomType(0)) + "→" + TestMenu.Right_ListBox.Items(RandomType(1))
        '显示题型

        Score_Label.Text = "得分：" & Score
        '显示得分

        Me.Number_Label.Text = QuestionNum & " / " & TestMenu.NumOfQuestion_NumericUpDown.Value
        '显示当前题号

        Question_Label.Text = ShowText(Exam, QuestionSeed, RandomType(0))
        '显示题目

        A_Button.Text = ShowText(Exam, AnswerSeed(0), RandomType(1))
        B_Button.Text = ShowText(Exam, AnswerSeed(1), RandomType(1))
        C_Button.Text = ShowText(Exam, AnswerSeed(2), RandomType(1))
        D_Button.Text = ShowText(Exam, AnswerSeed(3), RandomType(1))

        PrintLine(1, QuestionNum, QuestionSeed, AnswerSeed(0), AnswerSeed(1), AnswerSeed(2), AnswerSeed(3), AnswerSeed(4), RandomType(0), RandomType(1))
        '在"TestAnswer.txt"依次写入0题号，1考点，2答案A，3答案B，4答案C，5答案D，6正确答案序号，7题面类型，8答案类型

    End Sub
    '下一题


    Public Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        GetExam()
        '读取题库

        FileOpen(1, "TestAnswer.txt", OpenMode.Output)
        FileOpen(2, "Choose.txt", OpenMode.Output)

    End Sub

    Private Sub A_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A_Button.Click
        PrintLine(2, 0)
        If AnswerSeed(4) = 0 Then
            Score = Score + 1
        End If

        If QuestionNum = TestMenu.NumOfQuestion_NumericUpDown.Value Then
            Result_Form.Show()
            Me.Close()
        Else : NextQuestion()
        End If

    End Sub
    '按下按钮后，将结果写入"Choose.txt"，如果正确，分数+1。如果题目答完，显示得分，否则下一题。

    Private Sub B_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Button.Click
        PrintLine(2, 1)
        If AnswerSeed(4) = 1 Then
            Score = Score + 1
        End If

        If QuestionNum = TestMenu.NumOfQuestion_NumericUpDown.Value Then
            Result_Form.Show()
            Me.Close()
        Else : NextQuestion()
        End If
    End Sub
    '按下按钮后，将结果写入"Choose.txt"，如果正确，分数+1。如果题目答完，显示得分，否则下一题。

    Private Sub C_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C_Button.Click
        PrintLine(2, 2)
        If AnswerSeed(4) = 2 Then
            Score = Score + 1
        End If

        If QuestionNum = TestMenu.NumOfQuestion_NumericUpDown.Value Then
            Result_Form.Show()
            Me.Close()
        Else : NextQuestion()
        End If
    End Sub
    '按下按钮后，将结果写入"Choose.txt"，如果正确，分数+1。如果题目答完，显示得分，否则下一题。

    Private Sub D_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D_Button.Click
        PrintLine(2, 3)
        If AnswerSeed(4) = 3 Then
            Score = Score + 1
        End If

        If QuestionNum = TestMenu.NumOfQuestion_NumericUpDown.Value Then
            Result_Form.Show()
            Me.Close()
        Else : NextQuestion()
        End If
    End Sub
    '按下按钮后，将结果写入"Choose.txt"，如果正确，分数+1。如果题目答完，显示得分，否则下一题。

    Private Sub Test_Form_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.Closing
        FileClose(1)
        FileClose(2)
    End Sub


End Class