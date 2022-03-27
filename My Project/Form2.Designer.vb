<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.AddCourse = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.AdmtStdnt = New System.Windows.Forms.Button()
        Me.AddUnitsAdmin = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(283, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(295, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Welcome Back Admin"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'AddCourse
        '
        Me.AddCourse.Location = New System.Drawing.Point(354, 126)
        Me.AddCourse.Name = "AddCourse"
        Me.AddCourse.Size = New System.Drawing.Size(183, 55)
        Me.AddCourse.TabIndex = 1
        Me.AddCourse.Text = "Add Courses"
        Me.AddCourse.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.AddUnitsAdmin)
        Me.GroupBox1.Controls.Add(Me.AdmtStdnt)
        Me.GroupBox1.Controls.Add(Me.AddCourse)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(1, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1008, 665)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Admin Page"
        '
        'AdmtStdnt
        '
        Me.AdmtStdnt.Location = New System.Drawing.Point(354, 313)
        Me.AdmtStdnt.Name = "AdmtStdnt"
        Me.AdmtStdnt.Size = New System.Drawing.Size(183, 55)
        Me.AdmtStdnt.TabIndex = 5
        Me.AdmtStdnt.Text = "Admit Student"
        Me.AdmtStdnt.UseVisualStyleBackColor = True
        '
        'AddUnitsAdmin
        '
        Me.AddUnitsAdmin.Location = New System.Drawing.Point(354, 220)
        Me.AddUnitsAdmin.Name = "AddUnitsAdmin"
        Me.AddUnitsAdmin.Size = New System.Drawing.Size(183, 55)
        Me.AddUnitsAdmin.TabIndex = 6
        Me.AddUnitsAdmin.Text = "Add Units"
        Me.AddUnitsAdmin.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1021, 672)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents AddCourse As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents AdmitStudents As Button
    Friend WithEvents AddUnit As Button
    Friend WithEvents AdmtStdnt As Button
    Friend WithEvents AddUnitsAdmin As Button
End Class
