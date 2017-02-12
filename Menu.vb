Public Class TestMenu

    Public TotalQty As Integer = 104
    Public TestRange(TotalQty - 1) As Integer
    'Public

    Private Sub GetTestRange()
        Dim i As Integer = 0
        If CheckBox1.Checked = True Then
            For i = 0 To 45
                TestRange(i) = 1
            Next
        End If
        '如果选中清音，在0~45的位置填入对应序号，否则不填
        '45个清音加拔音
        If CheckBox2.Checked = True Then
            For i = 46 To 70
                TestRange(i) = 1
            Next
        End If
        '如果选中浊音，在46~71的位置填入对应序号，否则不填
        '20个浊音，5个半浊音
        If CheckBox3.Checked = True Then
            For i = 71 To 103
                TestRange(i) = 1
            Next
        End If
        '如果选中拗音，在72~103的位置填入对应序号，否则不填
        '33个拗音
    End Sub
    '获得测试范围

    Private Sub Start_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Start_Button.Click

        GetTestRange()
        '获取测试范围
        Result_Form.QuestionNum = 0
        '测试编号清零
        Result_Form.Score = 0
        '分数清零

        Dim Inf As Boolean = infinite_CheckBox.Checked

        If Inf Then
            Inf_Test.Show()
            Inf_Test.NextQuestion()
            NumOfQuestion_NumericUpDown.Value = 998
        Else
            Test_Form.Show()
            Test_Form.NextQuestion()
        End If
        '根据勾选情况判断是否进入无尽模式

    End Sub
    '点击开始按钮开始考试

    Private Sub Menu_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For index = 1 To 104
            TestRange(index - 1) = "0"
        Next
        '考试范围初始化
    End Sub
End Class
