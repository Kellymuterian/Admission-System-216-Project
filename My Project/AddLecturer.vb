Imports System.Data.OleDb
Public Class AddLecturer
    Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Adm\source\repos\Admission\MainDb.mdb")
    'Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\hp\source\repos\DB\MainDb.mdb")
    Private Sub ExitAdmitStudents_Click(sender As Object, e As EventArgs) Handles ExitAdmitStudents.Click
        Form2.Show()
        Me.Close()
    End Sub
    Private Sub AdmitStd_Click(sender As Object, e As EventArgs) Handles AdmitStd.Click
        Dim gender As String = "Male"
        If LecFemale.Checked Then
            gender = "Female"
        End If
        conn.Open()
        Dim sql As String = "insert into Lecturers (Name,Email,Phone,Gender) values(@Name,@Email,@Phone,@Gender)"
        Dim cmd1 As New OleDbCommand(sql, conn)
        cmd1.Parameters.AddWithValue("@Name", LecNames.Text)
        cmd1.Parameters.AddWithValue("@Email", LecEmail.Text)
        cmd1.Parameters.AddWithValue("@Phone", LecPhone.Text)
        cmd1.Parameters.AddWithValue("@Gender", gender)
        cmd1.ExecuteNonQuery()
        conn.Close()
        LecEmail.Clear()
        LecNames.Clear()
        LecPhone.Clear()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub LecNames_TextChanged(sender As Object, e As EventArgs) Handles LecNames.TextChanged

    End Sub
End Class