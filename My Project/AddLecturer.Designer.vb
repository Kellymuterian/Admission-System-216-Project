<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddLecturer
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
        Me.ExitAdmitStudents = New System.Windows.Forms.Button()
        Me.AdmitStd = New System.Windows.Forms.Button()
        Me.LecNames = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LecFemale = New System.Windows.Forms.RadioButton()
        Me.LecMale = New System.Windows.Forms.RadioButton()
        Me.LecEmail = New System.Windows.Forms.TextBox()
        Me.LecPhone = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ExitAdmitStudents)
        Me.GroupBox1.Controls.Add(Me.AdmitStd)
        Me.GroupBox1.Controls.Add(Me.LecNames)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.LecFemale)
        Me.GroupBox1.Controls.Add(Me.LecMale)
        Me.GroupBox1.Controls.Add(Me.LecEmail)
        Me.GroupBox1.Controls.Add(Me.LecPhone)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(871, 531)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Lecturer Form"
        '
        'ExitAdmitStudents
        '
        Me.ExitAdmitStudents.Location = New System.Drawing.Point(362, 305)
        Me.ExitAdmitStudents.Name = "ExitAdmitStudents"
        Me.ExitAdmitStudents.Size = New System.Drawing.Size(173, 59)
        Me.ExitAdmitStudents.TabIndex = 6
        Me.ExitAdmitStudents.Text = "Exit"
        Me.ExitAdmitStudents.UseVisualStyleBackColor = True
        '
        'AdmitStd
        '
        Me.AdmitStd.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.AdmitStd.ForeColor = System.Drawing.Color.White
        Me.AdmitStd.Location = New System.Drawing.Point(125, 305)
        Me.AdmitStd.Name = "AdmitStd"
        Me.AdmitStd.Size = New System.Drawing.Size(181, 59)
        Me.AdmitStd.TabIndex = 5
        Me.AdmitStd.Text = "Add Lecturer"
        Me.AdmitStd.UseVisualStyleBackColor = False
        '
        'LecNames
        '
        Me.LecNames.Location = New System.Drawing.Point(125, 69)
        Me.LecNames.Name = "LecNames"
        Me.LecNames.Size = New System.Drawing.Size(336, 29)
        Me.LecNames.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 21)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Names"
        '
        'LecFemale
        '
        Me.LecFemale.AutoSize = True
        Me.LecFemale.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LecFemale.Location = New System.Drawing.Point(266, 227)
        Me.LecFemale.Name = "LecFemale"
        Me.LecFemale.Size = New System.Drawing.Size(87, 25)
        Me.LecFemale.TabIndex = 4
        Me.LecFemale.TabStop = True
        Me.LecFemale.Text = "Female"
        Me.LecFemale.UseVisualStyleBackColor = True
        '
        'LecMale
        '
        Me.LecMale.AutoSize = True
        Me.LecMale.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LecMale.Location = New System.Drawing.Point(125, 227)
        Me.LecMale.Name = "LecMale"
        Me.LecMale.Size = New System.Drawing.Size(67, 25)
        Me.LecMale.TabIndex = 3
        Me.LecMale.TabStop = True
        Me.LecMale.Text = "Male"
        Me.LecMale.UseVisualStyleBackColor = True
        '
        'LecEmail
        '
        Me.LecEmail.Location = New System.Drawing.Point(125, 168)
        Me.LecEmail.Name = "LecEmail"
        Me.LecEmail.Size = New System.Drawing.Size(336, 29)
        Me.LecEmail.TabIndex = 2
        '
        'LecPhone
        '
        Me.LecPhone.Location = New System.Drawing.Point(125, 121)
        Me.LecPhone.Name = "LecPhone"
        Me.LecPhone.Size = New System.Drawing.Size(336, 29)
        Me.LecPhone.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 172)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Email"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(28, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 21)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Phone"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 227)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Gender"
        '
        'AddLecturer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(888, 553)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "AddLecturer"
        Me.Text = "AddLecturer"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LecFemale As RadioButton
    Friend WithEvents LecMale As RadioButton
    Friend WithEvents LecEmail As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LecNames As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LecPhone As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents AdmitStd As Button
    Friend WithEvents ExitAdmitStudents As Button
End Class
