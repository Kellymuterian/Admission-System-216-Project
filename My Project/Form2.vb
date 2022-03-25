Imports System.Data.OleDb
Public Class Form2
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles AdmtStdnt.Click
        AdmitStudent.Show()
        Me.Hide()
    End Sub
End Class