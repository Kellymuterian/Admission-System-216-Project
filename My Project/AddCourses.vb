Imports System.Data.OleDb
Public Class AddCourses
    Dim db As OleDbConnection = New OleDbConnection()
    Private Sub AddCourse_Click(sender As Object, e As EventArgs) Handles AddCourse.Click
        ' db.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\hp\source\repos\DB\MainDb.mdb"
        db.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Adm\source\repos\Admission\MainDb.mdb"
        db.Open()
        Dim insertCommand As String = "INSERT into Courses([Name],[Desc],[MaxCredits],[Level],[School],[Department],[Duration]) VALUES('" & CourseName.Text & "','" & CourseDesc.Text & "','" & MaxCredits.Text & "','" & Level.Text & "','" & Schl.Text & "','" & Dptment.Text & "','" & Duration.Text & "')"
        Dim cmd As OleDbCommand = New OleDbCommand(insertCommand, db)
        cmd.Parameters.Add(New OleDbParameter("Name", CType(CourseName.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Desc", CType(CourseDesc.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("MaxCredits", CType(MaxCredits.Text, Integer)))
        cmd.Parameters.Add(New OleDbParameter("Level", CType(Level.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("School", CType(Schl.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Department", CType(Dptment.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Duration", CType(Duration.Text, Integer)))
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            db.Close()
            CourseName.Clear()
            CourseDesc.Clear()
            MaxCredits.Clear()
            Level.Clear()
            Schl.Clear()
            Dptment.Clear()
            Duration.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
            db.Close()
        End Try
    End Sub

    Private Sub ExitAddCourses_Click(sender As Object, e As EventArgs) Handles ExitAddCourses.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub CourseName_TextChanged(sender As Object, e As EventArgs) Handles CourseName.TextChanged

    End Sub
End Class