Imports System.Data.OleDb
Public Class Form2
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub AdmitStudents_Click(sender As Object, e As EventArgs) Handles AdmitStudents.Click
        AdmitStudent.Show()
        Me.Hide()
    End Sub
End Class