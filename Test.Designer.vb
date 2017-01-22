<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Test_Form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Number_Label = New System.Windows.Forms.Label()
        Me.Question_Label = New System.Windows.Forms.Label()
        Me.A_Button = New System.Windows.Forms.Button()
        Me.B_Button = New System.Windows.Forms.Button()
        Me.D_Button = New System.Windows.Forms.Button()
        Me.C_Button = New System.Windows.Forms.Button()
        Me.QuestionType_Label = New System.Windows.Forms.Label()
        Me.Score_Label = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Number_Label
        '
        Me.Number_Label.AutoSize = True
        Me.Number_Label.Location = New System.Drawing.Point(113, 61)
        Me.Number_Label.Name = "Number_Label"
        Me.Number_Label.Size = New System.Drawing.Size(23, 12)
        Me.Number_Label.TabIndex = 0
        Me.Number_Label.Text = "N/A"
        '
        'Question_Label
        '
        Me.Question_Label.AutoSize = True
        Me.Question_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 60.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Question_Label.Location = New System.Drawing.Point(218, 119)
        Me.Question_Label.Name = "Question_Label"
        Me.Question_Label.Size = New System.Drawing.Size(119, 91)
        Me.Question_Label.TabIndex = 1
        Me.Question_Label.Text = "あ"
        Me.Question_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'A_Button
        '
        Me.A_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.A_Button.Location = New System.Drawing.Point(79, 282)
        Me.A_Button.Name = "A_Button"
        Me.A_Button.Size = New System.Drawing.Size(91, 37)
        Me.A_Button.TabIndex = 2
        Me.A_Button.Text = "N/A"
        Me.A_Button.UseVisualStyleBackColor = True
        '
        'B_Button
        '
        Me.B_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_Button.Location = New System.Drawing.Point(176, 282)
        Me.B_Button.Name = "B_Button"
        Me.B_Button.Size = New System.Drawing.Size(93, 37)
        Me.B_Button.TabIndex = 3
        Me.B_Button.Text = "N/A"
        Me.B_Button.UseVisualStyleBackColor = True
        '
        'D_Button
        '
        Me.D_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D_Button.Location = New System.Drawing.Point(372, 282)
        Me.D_Button.Name = "D_Button"
        Me.D_Button.Size = New System.Drawing.Size(91, 37)
        Me.D_Button.TabIndex = 5
        Me.D_Button.Text = "N/A"
        Me.D_Button.UseVisualStyleBackColor = True
        '
        'C_Button
        '
        Me.C_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C_Button.Location = New System.Drawing.Point(275, 282)
        Me.C_Button.Name = "C_Button"
        Me.C_Button.Size = New System.Drawing.Size(91, 37)
        Me.C_Button.TabIndex = 4
        Me.C_Button.Text = "N/A"
        Me.C_Button.UseVisualStyleBackColor = True
        '
        'QuestionType_Label
        '
        Me.QuestionType_Label.AutoSize = True
        Me.QuestionType_Label.Location = New System.Drawing.Point(187, 61)
        Me.QuestionType_Label.Name = "QuestionType_Label"
        Me.QuestionType_Label.Size = New System.Drawing.Size(41, 12)
        Me.QuestionType_Label.TabIndex = 10
        Me.QuestionType_Label.Text = "Label1"
        '
        'Score_Label
        '
        Me.Score_Label.AutoSize = True
        Me.Score_Label.Location = New System.Drawing.Point(407, 61)
        Me.Score_Label.Name = "Score_Label"
        Me.Score_Label.Size = New System.Drawing.Size(41, 12)
        Me.Score_Label.TabIndex = 11
        Me.Score_Label.Text = "Label1"
        '
        'Test_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(540, 446)
        Me.Controls.Add(Me.Score_Label)
        Me.Controls.Add(Me.QuestionType_Label)
        Me.Controls.Add(Me.D_Button)
        Me.Controls.Add(Me.C_Button)
        Me.Controls.Add(Me.B_Button)
        Me.Controls.Add(Me.A_Button)
        Me.Controls.Add(Me.Question_Label)
        Me.Controls.Add(Me.Number_Label)
        Me.Name = "Test_Form"
        Me.Text = "Test"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Number_Label As System.Windows.Forms.Label
    Friend WithEvents Question_Label As System.Windows.Forms.Label
    Friend WithEvents A_Button As System.Windows.Forms.Button
    Friend WithEvents B_Button As System.Windows.Forms.Button
    Friend WithEvents D_Button As System.Windows.Forms.Button
    Friend WithEvents C_Button As System.Windows.Forms.Button
    Friend WithEvents QuestionType_Label As System.Windows.Forms.Label
    Friend WithEvents Score_Label As System.Windows.Forms.Label
End Class
