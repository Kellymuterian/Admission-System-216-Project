Imports System.Data.OleDb
Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles AdmtStdnt.Click
        AdmitStudent.Show()
        Me.Hide()
    End Sub

    Private Sub AddCourse_Click(sender As Object, e As EventArgs) Handles AddCourse.Click
        AddCourses.Show()
        Me.Hide()
    End Sub

    Private Sub AddUnitsAdmin_Click(sender As Object, e As EventArgs) Handles AddUnitsAdmin.Click
        AddUnits.Show()
        Me.Hide()
    End Sub

    Private Sub LogOut_Click(sender As Object, e As EventArgs) Handles LogOut.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class