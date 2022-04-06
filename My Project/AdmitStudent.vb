Imports System.Data.OleDb
Public Class AdmitStudent
    Dim db As OleDbConnection = New OleDbConnection()
    Dim maxCredits As Integer
    Dim credits As New List(Of Integer)
    Dim gender As String = "Male"
    Private Sub AdmitStd_Click(sender As Object, e As EventArgs) Handles AdmitStd.Click
        If Male.Checked Then
            gender = "Male"
        ElseIf Female.Checked Then
            gender = "Female"
        End If
        db.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\hp\source\repos\DB\MainDb.mdb"
        'db.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\hp\source\repos\addmission\MainDb.mdb"
        db.Open()
        Dim insertCommand As String = "INSERT into Students([FullNames],[AdmNo],[Course],[CourseId],[MaxCredit],[AdmDate],[ExpiryDate],[Gender],[Status]) VALUES('" & StudentNames.Text & "','" & StudentAdm.Text & "','" & ComboBox1.SelectedItem.ToString() & "','" & ComboBox1.SelectedIndex + 1 & "','" & maxCredits & "','" & AdmDate.Text & "','" & GradDate.Text & "','" & gender & "','" & "active" & "')"
        Dim cmd As OleDbCommand = New OleDbCommand(insertCommand, db)
        cmd.Parameters.Add(New OleDbParameter("FullNames", CType(StudentNames.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("AdmNo", CType(StudentAdm.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Course", CType(ComboBox1.SelectedItem.ToString(), String)))
        cmd.Parameters.Add(New OleDbParameter("CourseId", CType(1, Integer)))
        cmd.Parameters.Add(New OleDbParameter("MaxCredit", CType(18, Integer)))
        cmd.Parameters.Add(New OleDbParameter("AdmDate", CType(AdmDate.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("ExpiryDate", CType(GradDate.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Gender", CType(gender, String)))
        cmd.Parameters.Add(New OleDbParameter("Status", CType("active", String)))
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            db.Close()
            StudentNames.Clear()
            StudentAdm.Clear()
            'ComboBox1.SelectedItem.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
            db.Close()
        End Try
    End Sub

    Private Sub ExitAdmitStudents_Click(sender As Object, e As EventArgs) Handles ExitAdmitStudents.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub AdmitStudent_Load(sender As Object, e As EventArgs) Handles Me.Load
        'db.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Adm\Source\Repos\Admission\MainDb.mdb"
        db.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\hp\source\repos\DB\MainDb.mdb"
        db.Open()
        Dim selectCommand = "SELECT * FROM Courses"
        Dim cmd As OleDbCommand = New OleDbCommand(selectCommand, db)
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        While reader.Read
            ComboBox1.Items.Add(reader(1))
            credits.Add(Integer.Parse(reader(3)))
        End While
        db.Close()

    End Sub

    Private Sub ComboBox1_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedValueChanged
        maxCredits = credits.Item(ComboBox1.SelectedIndex)
    End Sub


End Class