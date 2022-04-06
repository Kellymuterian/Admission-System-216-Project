Imports System.Data.OleDb
Public Class ClassList
    'Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Adm\source\repos\VB Database\MainDb.mdb")
    Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\hp\source\repos\DB\MainDb.mdb")

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
    Private Sub ClassList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PLoad_data()
    End Sub

    Private Sub ExitAddUnits_Click(sender As Object, e As EventArgs) Handles ExitAddUnits.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Generate_Click(sender As Object, e As EventArgs) Handles Generate.Click
        conn.Open()
        Dim geStudents = "SELECT AdmNo, FullNames from Students WHERE AdmNo IN (SELECT AdmNo FROM Selected WHERE Lecturer=@lec)"
        Dim cmd As OleDbCommand = New OleDbCommand(geStudents, conn)
        cmd.Parameters.AddWithValue("@lec", Lectureres.SelectedItem.ToString())
        Dim dtb As New OleDbDataAdapter
        dtb.SelectCommand = cmd
        Dim Selected As New DataTable
        Selected.Clear()
        dtb.Fill(Selected)
        DataGridView2.DataSource = Selected
        conn.Close()
    End Sub
End Class