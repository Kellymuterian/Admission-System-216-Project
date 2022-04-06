Imports System.Data.OleDb
Public Class AddUnits
    Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Adm\source\repos\Admission\MainDb.mdb")
    ' Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\hp\source\repos\DB\MainDb.mdb")
    Private Sub AddUnit_Click(sender As Object, e As EventArgs) Handles AddUnit.Click
        conn.Open()
        Dim insertCommand As String = "INSERT into Units([Name],[Description],[Lecturer],[CreditHours]) VALUES('" & UnitName.Text & "','" & Description.Text & "','" & Lectureres.SelectedItem.ToString() & "','" & Credits.Text & "')"
        Dim cmd As OleDbCommand = New OleDbCommand(insertCommand, conn)
        cmd.Parameters.Add(New OleDbParameter("Name", CType(UnitName.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Description", CType(Description.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Lecturer", CType(Lectureres.SelectedItem.ToString(), String)))
        cmd.Parameters.Add(New OleDbParameter("CreditHours", CType(Credits.Text, Integer)))
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            conn.Close()
            UnitName.Clear()
            Description.Clear()
            Credits.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ExitAddUnits_Click(sender As Object, e As EventArgs) Handles ExitAddUnits.Click
        Form2.Show()
        Me.Close()
    End Sub
    Private Sub PLoad_data()
        conn.Open()
        Dim selectCommand = "SELECT * FROM Lecturers"
        Dim cmd As OleDbCommand = New OleDbCommand(selectCommand, conn)
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        While reader.Read
            Lectureres.Items.Add(reader(1))
        End While
        conn.Close()
    End Sub
    Private Sub AddUnits_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PLoad_data()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class