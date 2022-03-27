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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ExitAdmitStudents = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.AdmitStd = New System.Windows.Forms.Button()
        Me.Female = New System.Windows.Forms.RadioButton()
        Me.Male = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GradDate = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.AdmDate = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.StudentNames = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.StudentAdm = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MainDbDataSet1 = New addmission.MainDbDataSet()
        Me.GroupBox1.SuspendLayout()
        CType(Me.MainDbDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.ExitAdmitStudents)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.AdmitStd)
        Me.GroupBox1.Controls.Add(Me.Female)
        Me.GroupBox1.Controls.Add(Me.Male)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.GradDate)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.AdmDate)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.StudentNames)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.StudentAdm)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1220, 870)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Admision Form"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(154, 205)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(416, 30)
        Me.ComboBox1.TabIndex = 1
        '
        'ExitAdmitStudents
        '
        Me.ExitAdmitStudents.Location = New System.Drawing.Point(363, 398)
        Me.ExitAdmitStudents.Name = "ExitAdmitStudents"
        Me.ExitAdmitStudents.Size = New System.Drawing.Size(167, 52)
        Me.ExitAdmitStudents.TabIndex = 21
        Me.ExitAdmitStudents.Text = "Exit"
        Me.ExitAdmitStudents.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(85, 210)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 21)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Course"
        '
        'AdmitStd
        '
        Me.AdmitStd.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.AdmitStd.ForeColor = System.Drawing.Color.White
        Me.AdmitStd.Location = New System.Drawing.Point(154, 398)
        Me.AdmitStd.Name = "AdmitStd"
        Me.AdmitStd.Size = New System.Drawing.Size(167, 52)
        Me.AdmitStd.TabIndex = 15
        Me.AdmitStd.Text = "Admit"
        Me.AdmitStd.UseVisualStyleBackColor = False
        '
        'Female
        '
        Me.Female.AutoSize = True
        Me.Female.Location = New System.Drawing.Point(282, 336)
        Me.Female.Name = "Female"
        Me.Female.Size = New System.Drawing.Size(94, 26)
        Me.Female.TabIndex = 14
        Me.Female.TabStop = True
        Me.Female.Text = "Female"
        Me.Female.UseVisualStyleBackColor = True
        '
        'Male
        '
        Me.Male.AutoSize = True
        Me.Male.Location = New System.Drawing.Point(151, 336)
        Me.Male.Name = "Male"
        Me.Male.Size = New System.Drawing.Size(71, 26)
        Me.Male.TabIndex = 13
        Me.Male.TabStop = True
        Me.Male.Text = "Male"
        Me.Male.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(77, 339)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 21)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Gender"
        '
        'GradDate
        '
        Me.GradDate.Location = New System.Drawing.Point(154, 298)
        Me.GradDate.Name = "GradDate"
        Me.GradDate.Size = New System.Drawing.Size(416, 29)
        Me.GradDate.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(42, 302)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 21)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Expiry Date"
        '
        'AdmDate
        '
        Me.AdmDate.Location = New System.Drawing.Point(154, 254)
        Me.AdmDate.Name = "AdmDate"
        Me.AdmDate.Size = New System.Drawing.Size(416, 29)
        Me.AdmDate.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 258)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 21)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Admission Date"
        '
        'StudentNames
        '
        Me.StudentNames.Location = New System.Drawing.Point(154, 156)
        Me.StudentNames.Name = "StudentNames"
        Me.StudentNames.Size = New System.Drawing.Size(416, 29)
        Me.StudentNames.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(85, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 21)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Name"
        '
        'StudentAdm
        '
        Me.StudentAdm.Location = New System.Drawing.Point(154, 110)
        Me.StudentAdm.Name = "StudentAdm"
        Me.StudentAdm.Size = New System.Drawing.Size(416, 29)
        Me.StudentAdm.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(66, 114)
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
        'AdmitStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1232, 873)
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
    Friend WithEvents GradDate As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents AdmDate As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents StudentNames As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents StudentAdm As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Male As RadioButton
    Friend WithEvents AdmitStd As Button
    Friend WithEvents Female As RadioButton
    Friend WithEvents MainDbDataSet1 As MainDbDataSet
    Friend WithEvents Label7 As Label
    Friend WithEvents ExitAdmitStudents As Button
    Friend WithEvents ComboBox1 As ComboBox
End Class
