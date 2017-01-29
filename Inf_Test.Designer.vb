<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inf_Test
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Score_Label = New System.Windows.Forms.Label()
        Me.QuestionType_Label = New System.Windows.Forms.Label()
        Me.D_Button = New System.Windows.Forms.Button()
        Me.C_Button = New System.Windows.Forms.Button()
        Me.B_Button = New System.Windows.Forms.Button()
        Me.A_Button = New System.Windows.Forms.Button()
        Me.Question_Label = New System.Windows.Forms.Label()
        Me.Number_Label = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Score_Label
        '
        Me.Score_Label.AutoSize = True
        Me.Score_Label.Location = New System.Drawing.Point(404, 51)
        Me.Score_Label.Name = "Score_Label"
        Me.Score_Label.Size = New System.Drawing.Size(41, 12)
        Me.Score_Label.TabIndex = 19
        Me.Score_Label.Text = "Label1"
        '
        'QuestionType_Label
        '
        Me.QuestionType_Label.AutoSize = True
        Me.QuestionType_Label.Location = New System.Drawing.Point(184, 51)
        Me.QuestionType_Label.Name = "QuestionType_Label"
        Me.QuestionType_Label.Size = New System.Drawing.Size(41, 12)
        Me.QuestionType_Label.TabIndex = 18
        Me.QuestionType_Label.Text = "Label1"
        '
        'D_Button
        '
        Me.D_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D_Button.Location = New System.Drawing.Point(369, 272)
        Me.D_Button.Name = "D_Button"
        Me.D_Button.Size = New System.Drawing.Size(91, 37)
        Me.D_Button.TabIndex = 17
        Me.D_Button.Text = "N/A"
        Me.D_Button.UseVisualStyleBackColor = True
        '
        'C_Button
        '
        Me.C_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C_Button.Location = New System.Drawing.Point(272, 272)
        Me.C_Button.Name = "C_Button"
        Me.C_Button.Size = New System.Drawing.Size(91, 37)
        Me.C_Button.TabIndex = 16
        Me.C_Button.Text = "N/A"
        Me.C_Button.UseVisualStyleBackColor = True
        '
        'B_Button
        '
        Me.B_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_Button.Location = New System.Drawing.Point(173, 272)
        Me.B_Button.Name = "B_Button"
        Me.B_Button.Size = New System.Drawing.Size(93, 37)
        Me.B_Button.TabIndex = 15
        Me.B_Button.Text = "N/A"
        Me.B_Button.UseVisualStyleBackColor = True
        '
        'A_Button
        '
        Me.A_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.A_Button.Location = New System.Drawing.Point(76, 272)
        Me.A_Button.Name = "A_Button"
        Me.A_Button.Size = New System.Drawing.Size(91, 37)
        Me.A_Button.TabIndex = 14
        Me.A_Button.Text = "N/A"
        Me.A_Button.UseVisualStyleBackColor = True
        '
        'Question_Label
        '
        Me.Question_Label.AutoSize = True
        Me.Question_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 60.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Question_Label.Location = New System.Drawing.Point(215, 109)
        Me.Question_Label.Name = "Question_Label"
        Me.Question_Label.Size = New System.Drawing.Size(119, 91)
        Me.Question_Label.TabIndex = 13
        Me.Question_Label.Text = "あ"
        Me.Question_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Number_Label
        '
        Me.Number_Label.AutoSize = True
        Me.Number_Label.Location = New System.Drawing.Point(110, 51)
        Me.Number_Label.Name = "Number_Label"
        Me.Number_Label.Size = New System.Drawing.Size(23, 12)
        Me.Number_Label.TabIndex = 12
        Me.Number_Label.Text = "N/A"
        '
        'Inf_Test
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(537, 361)
        Me.Controls.Add(Me.Score_Label)
        Me.Controls.Add(Me.QuestionType_Label)
        Me.Controls.Add(Me.D_Button)
        Me.Controls.Add(Me.C_Button)
        Me.Controls.Add(Me.B_Button)
        Me.Controls.Add(Me.A_Button)
        Me.Controls.Add(Me.Question_Label)
        Me.Controls.Add(Me.Number_Label)
        Me.Name = "Inf_Test"
        Me.Text = "测试（无尽模式）"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Score_Label As Label
    Friend WithEvents QuestionType_Label As Label
    Friend WithEvents D_Button As Button
    Friend WithEvents C_Button As Button
    Friend WithEvents B_Button As Button
    Friend WithEvents A_Button As Button
    Friend WithEvents Question_Label As Label
    Friend WithEvents Number_Label As Label
End Class
