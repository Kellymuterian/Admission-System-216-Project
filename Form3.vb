Imports System.Data.OleDb
Public Class Form3
    Dim db As OleDbConnection = New OleDbConnection()
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles AdmNo.Click

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim command As String
        db.ConnectionString = String.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\hp\source\repos\database\database\Database1.mdb")
        db.Open()
        command = "SELECT * FROM users WHERE [RegNo]=" & Me.AdmNo.Text & " "
        AdmNo.Text = Me.AdmNo.Text.ToString()
        FullNames.Text = "User One"
    End Sub
End Class