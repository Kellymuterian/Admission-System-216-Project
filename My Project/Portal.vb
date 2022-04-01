Imports System.Data.OleDb
Public Class Portal
    Dim db As OleDbConnection = New OleDbConnection()
    Dim admissionNumber As String
    Private Sub LogOut_Click(sender As Object, e As EventArgs) Handles LogOut.Click
        Me.Close()
        Form1.Show()
        'Me.Hide()
    End Sub

    Private Sub Portal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'db.ConnectionString = String.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Adm\Source\Repos\Admission\MainDb.mdb")
        db.ConnectionString = String.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\hp\source\repos\addmission\MainDb.mdb")
        db.Open()
        Dim cmd As OleDbCommand = New OleDbCommand(String.Concat("SELECT * FROM Students WHERE AdmNo = @admissionNumber"), db)
        cmd.Parameters.AddWithValue("@admissionNumber", Me.Tag.ToString())
        Dim student As OleDbDataReader = cmd.ExecuteReader()
        If student.Read = True Then
            StudentNames.Text = student(1)
            Label1.Text = "Welcome Dear " + student(1)
            UserName.Text = student(2)
            admissionNumber = student(2)
            AdmDate.Text = student(6)
            Course.Text = student(3)
            Status.Text = student(9)
            MaxCredits.Text = student(5).ToString() + " Credit Hours"
            GradDate.Text = student(7)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
<<<<<<< HEAD

=======
        Units.Tag = admissionNumber
        Units.Show()
        Me.Hide()
>>>>>>> fad4d439facbf90caf36664711d8a15ed57b9f57
    End Sub
End Class