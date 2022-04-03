Imports System.Data.OleDb
Public Class Form1
    Dim db As OleDbConnection = New OleDbConnection()
    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        If (Password.Text = "Admin") Then
            Form2.Show()
            Me.Hide()
            UserName.Clear()
            Password.Clear()
        ElseIf (Password.Text = "st") Then
            'db.ConnectionString = String.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Adm\Source\Repos\Admission\MainDb.mdb")
            db.ConnectionString = String.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\hp\source\repos\DB\MainDb.mdb")
            db.Open()
            Dim cmd As OleDbCommand = New OleDbCommand(String.Concat("SELECT * FROM Students WHERE AdmNo = @admissionNumber"), db)
            cmd.Parameters.AddWithValue("@admissionNumber", UserName.Text)
            Dim student As OleDbDataReader = cmd.ExecuteReader()
            If student.Read = True Then
                Portal.Tag = UserName.Text
                Portal.Show()
                UserName.Clear()
                Password.Clear()
                db.Close()
                Me.Hide()
            Else
                MessageBox.Show("Student Doesn't exit on the database")
                UserName.Clear()
                Password.Clear()
                db.Close()
            End If
        Else
            MessageBox.Show("Incorrect Password")
            UserName.Clear()
            Password.Clear()
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
