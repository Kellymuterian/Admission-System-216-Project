﻿Public Class Form1
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles Password.TextChanged

    End Sub

<<<<<<< HEAD
    Private Sub UserName_TextChanged(sender As Object, e As EventArgs) Handles UserName.TextChanged

    End Sub

    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        If (Password.Text = "Lakers") Then
            Form2.Show()
            Me.Hide()
        Else
            MessageBox.Show("Incorrect Password")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub
=======
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
>>>>>>> d473dca21b84e61543d1d88a22358249f5797479
End Class
