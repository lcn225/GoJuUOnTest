Public Class Result_Form

    Public choose() As Integer

    Private Function LoadAnswer()
        Dim i = 0
        Dim result(TestMenu.NumOfQuestion_NumericUpDown.Value) As String

        FileOpen(1, "TestAnswer.txt", OpenMode.Input)   '打开txt
        Do While Not EOF(1)
            result(i) = LineInput(1)
            i = i + 1
        Loop                                            '把TXT全部写入result
        FileClose(1)
        Return result
    End Function
    '输出全部的"TestAnswer.txt"到字符串组，一个字符串一行

    Private Function LoadChoose()
        FileOpen(1, "Choose.txt", OpenMode.Input)
        Dim Choose(Test_Form.QuestionNum) As Integer
        Dim i As Integer, l As String
        For i = 0 To Test_Form.QuestionNum - 1
            l = LineInput(1)
            Choose(i) = Int(l)
        Next
        FileClose(1)
        '输出"Choose.txt"到Choose
        Return Choose
    End Function
    '输出全部的"Choose.txt"到字符串组

    Private Function input(ByVal row)
        Dim Result(10) As String            '设置返回字符串组（要在表格中显示的字符串）
        Dim i As Integer
        Dim AllAnswer() As String = LoadAnswer()

        Result(0) = Int(Mid(AllAnswer(row), 1, 4)) '设置第0位为题号
        Result(1) = Test_Form.ShowText(Test_Form.Exam, Int(Mid(AllAnswer(row), 1 * 14 + 1, 4)), Int(Mid(AllAnswer(row), 7 * 14 + 1, 4)))
        '设置第1位为谜面
        For i = 2 To 5
            Result(i) = Test_Form.ShowText(Test_Form.Exam, Int(Mid(AllAnswer(row), i * 14 + 1, 4)), Int(Mid(AllAnswer(row), 8 * 14 + 1, 4)))
        Next        '设置第2~5位为答案
        Result(6) = Int(Mid(AllAnswer(row), 6 * 14 + 1, 4))   '设置第6位为正确答案
        Return Result
    End Function
    '将"TestAnswer.txt"第row行的数据分解成若干数组

    Private Sub FillTab(ByVal row)

        Dim line() As String = input(row)
        Result_DataGridView.Rows.Add(line(0), line(1), line(2), line(3), line(4), line(5), line(line(6) + 2))
        '增加行

    End Sub
    '输入行数，将该行答题结果填入DGV

    Private Sub MarkChoose(ByVal row)
        Result_DataGridView.Rows(row).Cells(Me.choose(row) + 2).Style.ForeColor = Color.Red    '将选择的选项标红字
        If Result_DataGridView.Rows(row).Cells(Me.choose(row) + 2).Value = Result_DataGridView.Rows(row).Cells(6).Value Then
            Result_DataGridView.Rows(row).Cells(6).Style.BackColor = Color.Green
        End If  '将选对的题目的答案标绿底

    End Sub
    '输入行数，将该行答题结果标颜色

    Public Sub ResultStart()
        Test_Form.Hide()
        Title_Label.Text = "得分：" & Test_Form.Score & " / " & Test_Form.QuestionNum

        Result_DataGridView.Rows.Clear()
        Dim i As Integer = 0

        For i = 0 To Test_Form.QuestionNum - 1
            FillTab(i)
            MarkChoose(i)
        Next
    End Sub
    Private Sub Result_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        FileClose(1)
        FileClose(2)

        choose = LoadChoose()
        Me.ResultStart()

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Result_DataGridView.CellContentClick

    End Sub

    Private Sub Retry_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Retry_Button.Click
        Me.Result_DataGridView.ClearSelection()
        Me.Close()

    End Sub

    Private Sub Result_Form_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        TestMenu.Show()
    End Sub
End Class