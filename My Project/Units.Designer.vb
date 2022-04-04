<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Units
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.ExitAddUnits = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MaxCreditsText = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.Color.Black
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(517, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SeaGreen
        Me.Button1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(12, 224)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(149, 54)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Add Units"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(12, 301)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(576, 201)
        Me.DataGridView2.TabIndex = 2
        '
        'ExitAddUnits
        '
        Me.ExitAddUnits.BackColor = System.Drawing.Color.Salmon
        Me.ExitAddUnits.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitAddUnits.ForeColor = System.Drawing.Color.Black
        Me.ExitAddUnits.Location = New System.Drawing.Point(693, 12)
        Me.ExitAddUnits.Name = "ExitAddUnits"
        Me.ExitAddUnits.Size = New System.Drawing.Size(153, 54)
        Me.ExitAddUnits.TabIndex = 36
        Me.ExitAddUnits.Text = "Exit"
        Me.ExitAddUnits.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 177)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 21)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Max Credit Hours :"
        '
        'MaxCreditsText
        '
        Me.MaxCreditsText.AutoSize = True
        Me.MaxCreditsText.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaxCreditsText.Location = New System.Drawing.Point(176, 177)
        Me.MaxCreditsText.Name = "MaxCreditsText"
        Me.MaxCreditsText.Size = New System.Drawing.Size(49, 21)
        Me.MaxCreditsText.TabIndex = 38
        Me.MaxCreditsText.Text = "NaN"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.SeaGreen
        Me.Button2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Cornsilk
        Me.Button2.Location = New System.Drawing.Point(12, 521)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(149, 54)
        Me.Button2.TabIndex = 39
        Me.Button2.Text = "Drop Units"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Units
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1240, 818)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.MaxCreditsText)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.ExitAddUnits)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Units"
        Me.Text = "Units"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents ExitAddUnits As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents MaxCreditsText As Label
    Friend WithEvents Button2 As Button
End Class
