<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClassList
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
        Me.Lectureres = New System.Windows.Forms.ComboBox()
        Me.ExitAddUnits = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Generate = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(Me.Lectureres)
        Me.GroupBox1.Controls.Add(Me.ExitAddUnits)
        Me.GroupBox1.Controls.Add(Me.DataGridView2)
        Me.GroupBox1.Controls.Add(Me.Generate)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1211, 848)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Class List"
        '
        'Lectureres
        '
        Me.Lectureres.FormattingEnabled = True
        Me.Lectureres.Location = New System.Drawing.Point(80, 114)
        Me.Lectureres.Name = "Lectureres"
        Me.Lectureres.Size = New System.Drawing.Size(416, 28)
        Me.Lectureres.TabIndex = 38
        '
        'ExitAddUnits
        '
        Me.ExitAddUnits.BackColor = System.Drawing.Color.Salmon
        Me.ExitAddUnits.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitAddUnits.ForeColor = System.Drawing.Color.Black
        Me.ExitAddUnits.Location = New System.Drawing.Point(924, 669)
        Me.ExitAddUnits.Name = "ExitAddUnits"
        Me.ExitAddUnits.Size = New System.Drawing.Size(149, 54)
        Me.ExitAddUnits.TabIndex = 37
        Me.ExitAddUnits.Text = "Exit"
        Me.ExitAddUnits.UseVisualStyleBackColor = False
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.ColumnHeadersHeight = 30
        Me.DataGridView2.Location = New System.Drawing.Point(645, 77)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.RowTemplate.Height = 30
        Me.DataGridView2.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.Size = New System.Drawing.Size(428, 410)
        Me.DataGridView2.TabIndex = 24
        '
        'Generate
        '
        Me.Generate.BackColor = System.Drawing.Color.RoyalBlue
        Me.Generate.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Generate.ForeColor = System.Drawing.Color.White
        Me.Generate.Location = New System.Drawing.Point(80, 161)
        Me.Generate.Name = "Generate"
        Me.Generate.Size = New System.Drawing.Size(149, 54)
        Me.Generate.TabIndex = 23
        Me.Generate.Text = "Generate"
        Me.Generate.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(597, 18)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Select a lecturers from the drop down below and click the generate button"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(-1, 114)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 21)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Lecturer"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(300, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Generate a classlist for the lecturers"
        '
        'ClassList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1226, 864)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ClassList"
        Me.Text = "ClassList"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Generate As Button
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents ExitAddUnits As Button
    Friend WithEvents Lectureres As ComboBox
End Class
