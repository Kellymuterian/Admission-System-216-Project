<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Portal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Portal))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MaxCredits = New System.Windows.Forms.Label()
        Me.StudentNames = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.UserName = New System.Windows.Forms.Label()
        Me.Course = New System.Windows.Forms.Label()
        Me.GradDate = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Status = New System.Windows.Forms.Label()
        Me.AdmDate = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LogOut = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.LogOut)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(5, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1183, 745)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Student Portal"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.DataGridView2)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.MaxCredits)
        Me.GroupBox2.Controls.Add(Me.StudentNames)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.UserName)
        Me.GroupBox2.Controls.Add(Me.Course)
        Me.GroupBox2.Controls.Add(Me.GradDate)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Status)
        Me.GroupBox2.Controls.Add(Me.AdmDate)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(0, 90)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(588, 649)
        Me.GroupBox2.TabIndex = 39
        Me.GroupBox2.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Berlin Sans FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(38, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 23)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Course :"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.Location = New System.Drawing.Point(6, 352)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(556, 291)
        Me.DataGridView2.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Berlin Sans FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(41, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 23)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Name :"
        '
        'MaxCredits
        '
        Me.MaxCredits.AutoSize = True
        Me.MaxCredits.Font = New System.Drawing.Font("Berlin Sans FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaxCredits.Location = New System.Drawing.Point(144, 126)
        Me.MaxCredits.Name = "MaxCredits"
        Me.MaxCredits.Size = New System.Drawing.Size(52, 23)
        Me.MaxCredits.TabIndex = 38
        Me.MaxCredits.Text = "NuN"
        '
        'StudentNames
        '
        Me.StudentNames.AutoSize = True
        Me.StudentNames.Font = New System.Drawing.Font("Berlin Sans FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StudentNames.Location = New System.Drawing.Point(144, 19)
        Me.StudentNames.Name = "StudentNames"
        Me.StudentNames.Size = New System.Drawing.Size(52, 23)
        Me.StudentNames.TabIndex = 24
        Me.StudentNames.Text = "NuN"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Berlin Sans FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(-3, 126)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(119, 23)
        Me.Label11.TabIndex = 37
        Me.Label11.Text = "Max Credits :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Berlin Sans FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 23)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Adm No :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Berlin Sans FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(4, 309)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(151, 23)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "Units Registered "
        '
        'UserName
        '
        Me.UserName.AutoSize = True
        Me.UserName.Font = New System.Drawing.Font("Berlin Sans FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserName.Location = New System.Drawing.Point(144, 51)
        Me.UserName.Name = "UserName"
        Me.UserName.Size = New System.Drawing.Size(52, 23)
        Me.UserName.TabIndex = 26
        Me.UserName.Text = "NuN"
        '
        'Course
        '
        Me.Course.AutoSize = True
        Me.Course.Font = New System.Drawing.Font("Berlin Sans FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Course.Location = New System.Drawing.Point(144, 89)
        Me.Course.Name = "Course"
        Me.Course.Size = New System.Drawing.Size(52, 23)
        Me.Course.TabIndex = 28
        Me.Course.Text = "NuN"
        '
        'GradDate
        '
        Me.GradDate.AutoSize = True
        Me.GradDate.Font = New System.Drawing.Font("Berlin Sans FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GradDate.Location = New System.Drawing.Point(144, 242)
        Me.GradDate.Name = "GradDate"
        Me.GradDate.Size = New System.Drawing.Size(52, 23)
        Me.GradDate.TabIndex = 34
        Me.GradDate.Text = "NuN"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Berlin Sans FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(38, 164)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 23)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Status :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Berlin Sans FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(-34, 242)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(150, 23)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Exp Grad Date :"
        '
        'Status
        '
        Me.Status.AutoSize = True
        Me.Status.Font = New System.Drawing.Font("Berlin Sans FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Status.Location = New System.Drawing.Point(144, 164)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(52, 23)
        Me.Status.TabIndex = 30
        Me.Status.Text = "NuN"
        '
        'AdmDate
        '
        Me.AdmDate.AutoSize = True
        Me.AdmDate.Font = New System.Drawing.Font("Berlin Sans FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdmDate.Location = New System.Drawing.Point(144, 204)
        Me.AdmDate.Name = "AdmDate"
        Me.AdmDate.Size = New System.Drawing.Size(52, 23)
        Me.AdmDate.TabIndex = 32
        Me.AdmDate.Text = "NuN"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Berlin Sans FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(4, 204)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 23)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Adm Date :"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(1015, 106)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 52)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Enroll Units"
        Me.Button1.UseCompatibleTextRendering = True
        Me.Button1.UseVisualStyleBackColor = False
        '
        'LogOut
        '
        Me.LogOut.BackColor = System.Drawing.Color.LightCoral
        Me.LogOut.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogOut.ForeColor = System.Drawing.Color.White
        Me.LogOut.Location = New System.Drawing.Point(1015, 27)
        Me.LogOut.Name = "LogOut"
        Me.LogOut.Size = New System.Drawing.Size(150, 52)
        Me.LogOut.TabIndex = 1
        Me.LogOut.Text = "Log Out"
        Me.LogOut.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(370, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(316, 32)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Welcome Dear Student"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(7, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(158, 51)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Portal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 749)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Portal"
        Me.Text = "Portal"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LogOut As Button
    Friend WithEvents StudentNames As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents UserName As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GradDate As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents AdmDate As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Status As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Course As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents MaxCredits As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
End Class
