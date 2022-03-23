Imports System.Data.OleDb
Public Class Form1
    Dim db As OleDbConnection = New OleDbConnection()
    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        Dim command As String
        db.ConnectionString = String.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\hp\source\repos\database\database\Database1.mdb")
        db.Open()
        command = "SELECT * FROM users WHERE [RegNo]=" & UserName.Text & " "
        Dim user As String = UserName.Text
        Dim cmd = New OleDbCommand(command, db)
        If (Password.Text = "Admin") Then
            Form2.Show()
            Me.Hide()
        ElseIf (Password.Text = "student") Then
            'Form3.AdmNo.Text = user
            'Form3.Show()
            Me.Hide()
        Else
            MessageBox.Show("Incorrect Password")
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
