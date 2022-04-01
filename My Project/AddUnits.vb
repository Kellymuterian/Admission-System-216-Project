Imports System.Data.OleDb
Public Class AddUnits
    Dim db As OleDbConnection = New OleDbConnection
    Private Sub AddUnit_Click(sender As Object, e As EventArgs) Handles AddUnit.Click
        db.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\hp\source\repos\db\MainDb.mdb"
        db.Open()
        Dim insertCommand As String = "INSERT into Units([Name],[Description],[Lecturer],[CreditHours]) VALUES('" & UnitName.Text & "','" & Description.Text & "','" & Lec.Text & "','" & Credits.Text & "')"
        Dim cmd As OleDbCommand = New OleDbCommand(insertCommand, db)
        cmd.Parameters.Add(New OleDbParameter("Name", CType(UnitName.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Description", CType(Description.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Lecturer", CType(Lec.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("CreditHours", CType(Credits.Text, Integer)))
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            db.Close()
            UnitName.Clear()
            Description.Clear()
            Lec.Clear()
            Credits.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ExitAddUnits_Click(sender As Object, e As EventArgs) Handles ExitAddUnits.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class