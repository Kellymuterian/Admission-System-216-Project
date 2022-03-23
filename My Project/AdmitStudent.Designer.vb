<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdmitStudent
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.AdmitStd = New System.Windows.Forms.Button()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.StudentCourse = New System.Windows.Forms.Label()
        Me.StudentNames = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.StudentAdm = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MainDbDataSet1 = New addmission.MainDbDataSet()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        CType(Me.MainDbDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton5)
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.RadioButton4)
        Me.GroupBox1.Controls.Add(Me.AdmitStd)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.StudentCourse)
        Me.GroupBox1.Controls.Add(Me.StudentNames)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.StudentAdm)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1031, 870)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Admision Form"
        '
        'AdmitStd
        '
        Me.AdmitStd.Location = New System.Drawing.Point(149, 381)
        Me.AdmitStd.Name = "AdmitStd"
        Me.AdmitStd.Size = New System.Drawing.Size(222, 52)
        Me.AdmitStd.TabIndex = 15
        Me.AdmitStd.Text = "Admit"
        Me.AdmitStd.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(277, 319)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(94, 26)
        Me.RadioButton2.TabIndex = 14
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Female"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(146, 319)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(71, 26)
        Me.RadioButton1.TabIndex = 13
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Male"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(72, 322)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 21)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Gender"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(149, 281)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(416, 29)
        Me.DateTimePicker2.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(37, 285)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 21)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Expiry Date"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(149, 237)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(416, 29)
        Me.DateTimePicker1.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 241)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 21)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Admission Date"
        '
        'StudentCourse
        '
        Me.StudentCourse.AutoSize = True
        Me.StudentCourse.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StudentCourse.Location = New System.Drawing.Point(80, 195)
        Me.StudentCourse.Name = "StudentCourse"
        Me.StudentCourse.Size = New System.Drawing.Size(62, 21)
        Me.StudentCourse.TabIndex = 5
        Me.StudentCourse.Text = "Course"
        '
        'StudentNames
        '
        Me.StudentNames.Location = New System.Drawing.Point(149, 140)
        Me.StudentNames.Name = "StudentNames"
        Me.StudentNames.Size = New System.Drawing.Size(416, 29)
        Me.StudentNames.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(80, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 21)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Name"
        '
        'StudentAdm
        '
        Me.StudentAdm.Location = New System.Drawing.Point(149, 94)
        Me.StudentAdm.Name = "StudentAdm"
        Me.StudentAdm.Size = New System.Drawing.Size(416, 29)
        Me.StudentAdm.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(61, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Adm No"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(251, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(239, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Admin New Student"
        '
        'MainDbDataSet1
        '
        Me.MainDbDataSet1.DataSetName = "MainDbDataSet"
        Me.MainDbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton3.Location = New System.Drawing.Point(349, 193)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(153, 25)
        Me.RadioButton3.TabIndex = 17
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Acturial Science"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton4.Location = New System.Drawing.Point(146, 193)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(170, 25)
        Me.RadioButton4.TabIndex = 16
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "Computer Science"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton5.Location = New System.Drawing.Point(533, 193)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(56, 25)
        Me.RadioButton5.TabIndex = 18
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "MIS"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'AdmitStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1043, 873)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "AdmitStudent"
        Me.Text = "AdmitStudent"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.MainDbDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents StudentCourse As Label
    Friend WithEvents StudentNames As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents StudentAdm As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents AdmitStd As Button
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents MainDbDataSet1 As MainDbDataSet
End Class
