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

    Private Sub AddLec_Click(sender As Object, e As EventArgs) Handles AddLec.Click
        AddLecturer.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        ClassList.Show()
        Me.Hide()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class