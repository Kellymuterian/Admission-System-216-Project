Imports System.Data.OleDb
Public Class AdmitStudent
    Dim db As OleDbConnection = New OleDbConnection()
    Private Sub AdmitStd_Click(sender As Object, e As EventArgs) Handles AdmitStd.Click
        db.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\hp\source\repos\addmission\MainDb.mdb"
        db.Open()
        Dim insertCommand As String = "INSERT into Students([FullNames],[AdmNo],[Course],[CourseId],[MaxCredit],[AdmDate],[ExpiryDate],[Gender]) VALUES('" & StudentNames.Text & "','" & StudentAdm.Text & "','" & StdCourse.Text & "','" & 1 & "','" & 18 & "','" & AdmDate.Text & "','" & GradDate.Text & "','" & "Male" & "')"
        Dim cmd As OleDbCommand = New OleDbCommand(insertCommand, db)
        cmd.Parameters.Add(New OleDbParameter("FullNames", CType(StudentNames.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("AdmNo", CType(StudentAdm.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Course", CType(StdCourse.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("CourseId", CType(1, Integer)))
        cmd.Parameters.Add(New OleDbParameter("MaxCredit", CType(18, Integer)))
        cmd.Parameters.Add(New OleDbParameter("AdmDate", CType(AdmDate.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("ExpiryDate", CType(GradDate.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Gender", CType("Male", String)))
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            db.Close()
            StudentNames.Clear()
            StudentAdm.Clear()
            StdCourse.Clear()
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
        db.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\hp\source\repos\addmission\MainDb.mdb"
        db.Open()
        Dim selectCommand = "SELECT * FROM Courses"
        Dim cmd As OleDbCommand = New OleDbCommand(selectCommand, db)
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        While reader.Read
            CheckedListBox1.Items.Add(reader(1))
            Label1.Text = reader.ToString()
        End While
        db.Close()
    End Sub
End Class