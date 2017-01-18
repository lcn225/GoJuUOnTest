Public Class Menu_Form

    Public TestRange(105) As Integer

    Private Sub GetTestRange()
        Dim i As Integer = 0
        Dim j As Integer
        If CheckBox1.Checked = True Then
            For j = 0 To 44
                TestRange(i) = j
                i = i + 1
            Next
        End If
        If CheckBox2.Checked = True Then
            For j = 0 To 24
                TestRange(i) = j + 45
                i = i + 1
            Next
        End If
        If CheckBox3.Checked = True Then
            For j = 0 To 35
                TestRange(i) = j + 70
                i = i + 1
            Next
        End If
    End Sub

    Private Sub Start_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Start_Button.Click
        GetTestRange()
        Test_Form.QuestionNum = 0
        Test_Form.Score = 0
        Test_Form.Show()
        Test_Form.StartTest()
    End Sub

    Private Sub Menu_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
