<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Result_Form
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Title_Label = New System.Windows.Forms.Label()
        Me.Result_DataGridView = New System.Windows.Forms.DataGridView()
        Me.Num = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quertion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.A = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.B = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.D = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.答案 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Retry_Button = New System.Windows.Forms.Button()
        CType(Me.Result_DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Title_Label
        '
        Me.Title_Label.AutoSize = True
        Me.Title_Label.Location = New System.Drawing.Point(44, 56)
        Me.Title_Label.Name = "Title_Label"
        Me.Title_Label.Size = New System.Drawing.Size(41, 12)
        Me.Title_Label.TabIndex = 0
        Me.Title_Label.Text = "得分："
        '
        'Result_DataGridView
        '
        Me.Result_DataGridView.AllowUserToAddRows = False
        Me.Result_DataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Result_DataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Result_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Result_DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Num, Me.Quertion, Me.A, Me.B, Me.C, Me.D, Me.答案})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Result_DataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.Result_DataGridView.Location = New System.Drawing.Point(47, 102)
        Me.Result_DataGridView.Name = "Result_DataGridView"
        Me.Result_DataGridView.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Result_DataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.Result_DataGridView.Size = New System.Drawing.Size(423, 251)
        Me.Result_DataGridView.TabIndex = 1
        '
        'Num
        '
        Me.Num.HeaderText = "序号"
        Me.Num.MaxInputLength = 800
        Me.Num.Name = "Num"
        Me.Num.ReadOnly = True
        Me.Num.Width = 40
        '
        'Quertion
        '
        Me.Quertion.HeaderText = "题面"
        Me.Quertion.Name = "Quertion"
        Me.Quertion.ReadOnly = True
        Me.Quertion.Width = 60
        '
        'A
        '
        Me.A.HeaderText = "A"
        Me.A.Name = "A"
        Me.A.ReadOnly = True
        Me.A.Width = 50
        '
        'B
        '
        Me.B.HeaderText = "B"
        Me.B.Name = "B"
        Me.B.ReadOnly = True
        Me.B.Width = 50
        '
        'C
        '
        Me.C.HeaderText = "C"
        Me.C.Name = "C"
        Me.C.ReadOnly = True
        Me.C.Width = 50
        '
        'D
        '
        Me.D.HeaderText = "D"
        Me.D.Name = "D"
        Me.D.ReadOnly = True
        Me.D.Width = 50
        '
        '答案
        '
        Me.答案.HeaderText = "答案"
        Me.答案.Name = "答案"
        Me.答案.ReadOnly = True
        Me.答案.Width = 70
        '
        'Retry_Button
        '
        Me.Retry_Button.Location = New System.Drawing.Point(224, 382)
        Me.Retry_Button.Name = "Retry_Button"
        Me.Retry_Button.Size = New System.Drawing.Size(75, 21)
        Me.Retry_Button.TabIndex = 2
        Me.Retry_Button.Text = "再来一次"
        Me.Retry_Button.UseVisualStyleBackColor = True
        '
        'Result_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(502, 414)
        Me.Controls.Add(Me.Retry_Button)
        Me.Controls.Add(Me.Result_DataGridView)
        Me.Controls.Add(Me.Title_Label)
        Me.Name = "Result_Form"
        Me.Text = "Result"
        CType(Me.Result_DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Title_Label As System.Windows.Forms.Label
    Friend WithEvents Result_DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Retry_Button As System.Windows.Forms.Button
    Friend WithEvents Num As DataGridViewTextBoxColumn
    Friend WithEvents Quertion As DataGridViewTextBoxColumn
    Friend WithEvents A As DataGridViewTextBoxColumn
    Friend WithEvents B As DataGridViewTextBoxColumn
    Friend WithEvents C As DataGridViewTextBoxColumn
    Friend WithEvents D As DataGridViewTextBoxColumn
    Friend WithEvents 答案 As DataGridViewTextBoxColumn
End Class
