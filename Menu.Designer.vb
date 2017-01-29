<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TestMenu
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
        Me.Title_Label = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.NumOfQuestion_Label = New System.Windows.Forms.Label()
        Me.NumOfQuestion_NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Start_Button = New System.Windows.Forms.Button()
        Me.Left_ListBox = New System.Windows.Forms.ListBox()
        Me.Right_ListBox = New System.Windows.Forms.ListBox()
        Me.infinite_CheckBox = New System.Windows.Forms.CheckBox()
        CType(Me.NumOfQuestion_NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Title_Label
        '
        Me.Title_Label.AutoSize = True
        Me.Title_Label.Location = New System.Drawing.Point(74, 53)
        Me.Title_Label.Name = "Title_Label"
        Me.Title_Label.Size = New System.Drawing.Size(95, 12)
        Me.Title_Label.TabIndex = 2
        Me.Title_Label.Text = "五十音测试 v1.1"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(77, 222)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(48, 16)
        Me.CheckBox1.TabIndex = 3
        Me.CheckBox1.Text = "清音"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(133, 222)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(84, 16)
        Me.CheckBox2.TabIndex = 4
        Me.CheckBox2.Text = "浊音半浊音"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(225, 222)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(48, 16)
        Me.CheckBox3.TabIndex = 5
        Me.CheckBox3.Text = "拗音"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'NumOfQuestion_Label
        '
        Me.NumOfQuestion_Label.AutoSize = True
        Me.NumOfQuestion_Label.Location = New System.Drawing.Point(327, 222)
        Me.NumOfQuestion_Label.Name = "NumOfQuestion_Label"
        Me.NumOfQuestion_Label.Size = New System.Drawing.Size(29, 12)
        Me.NumOfQuestion_Label.TabIndex = 6
        Me.NumOfQuestion_Label.Text = "题数"
        '
        'NumOfQuestion_NumericUpDown
        '
        Me.NumOfQuestion_NumericUpDown.Location = New System.Drawing.Point(365, 222)
        Me.NumOfQuestion_NumericUpDown.Name = "NumOfQuestion_NumericUpDown"
        Me.NumOfQuestion_NumericUpDown.Size = New System.Drawing.Size(85, 21)
        Me.NumOfQuestion_NumericUpDown.TabIndex = 7
        Me.NumOfQuestion_NumericUpDown.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'Start_Button
        '
        Me.Start_Button.Location = New System.Drawing.Point(225, 374)
        Me.Start_Button.Name = "Start_Button"
        Me.Start_Button.Size = New System.Drawing.Size(75, 21)
        Me.Start_Button.TabIndex = 10
        Me.Start_Button.Text = "开始测试"
        Me.Start_Button.UseVisualStyleBackColor = True
        '
        'Left_ListBox
        '
        Me.Left_ListBox.FormattingEnabled = True
        Me.Left_ListBox.ItemHeight = 12
        Me.Left_ListBox.Items.AddRange(New Object() {"罗马音", "平假名", "片假名"})
        Me.Left_ListBox.Location = New System.Drawing.Point(80, 105)
        Me.Left_ListBox.Name = "Left_ListBox"
        Me.Left_ListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.Left_ListBox.Size = New System.Drawing.Size(120, 88)
        Me.Left_ListBox.TabIndex = 13
        '
        'Right_ListBox
        '
        Me.Right_ListBox.FormattingEnabled = True
        Me.Right_ListBox.ItemHeight = 12
        Me.Right_ListBox.Items.AddRange(New Object() {"罗马音", "平假名", "片假名"})
        Me.Right_ListBox.Location = New System.Drawing.Point(330, 105)
        Me.Right_ListBox.Name = "Right_ListBox"
        Me.Right_ListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.Right_ListBox.Size = New System.Drawing.Size(120, 88)
        Me.Right_ListBox.TabIndex = 14
        '
        'infinite_CheckBox
        '
        Me.infinite_CheckBox.AutoSize = True
        Me.infinite_CheckBox.Location = New System.Drawing.Point(80, 289)
        Me.infinite_CheckBox.Name = "infinite_CheckBox"
        Me.infinite_CheckBox.Size = New System.Drawing.Size(72, 16)
        Me.infinite_CheckBox.TabIndex = 15
        Me.infinite_CheckBox.Text = "无尽模式"
        Me.infinite_CheckBox.UseVisualStyleBackColor = True
        '
        'TestMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(537, 448)
        Me.Controls.Add(Me.infinite_CheckBox)
        Me.Controls.Add(Me.Right_ListBox)
        Me.Controls.Add(Me.Left_ListBox)
        Me.Controls.Add(Me.Start_Button)
        Me.Controls.Add(Me.NumOfQuestion_NumericUpDown)
        Me.Controls.Add(Me.NumOfQuestion_Label)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Title_Label)
        Me.Name = "TestMenu"
        Me.Text = "五十音测试软件"
        CType(Me.NumOfQuestion_NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Title_Label As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents NumOfQuestion_Label As System.Windows.Forms.Label
    Friend WithEvents NumOfQuestion_NumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents Start_Button As System.Windows.Forms.Button
    Friend WithEvents Left_ListBox As System.Windows.Forms.ListBox
    Friend WithEvents Right_ListBox As System.Windows.Forms.ListBox
    Friend WithEvents infinite_CheckBox As CheckBox
End Class
