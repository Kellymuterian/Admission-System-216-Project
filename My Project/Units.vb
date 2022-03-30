Imports System.Configuration
Imports System.Data
Imports System.Data.OleDb

Public Class Units
    Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Adm\Source\Repos\Admission\MainDb.mdb")
    Private Sub Load_data()
        conn.Open()
        Dim cmd As New OleDbCommand("select ID,Name,Description,Lecturer,CreditHours from Units", conn)
        Dim dt As New OleDbDataAdapter
        dt.SelectCommand = cmd
        Dim Selected As New DataTable
        Selected.Clear()
        dt.Fill(Selected)
        DataGridView1.DataSource = Selected
        conn.Close()
        Dim checkboxcol As New DataGridViewCheckBoxColumn
        checkboxcol.Width = 40
        checkboxcol.Name = "checkboxcol"
        DataGridView1.Columns.Insert(0, checkboxcol)

    End Sub



    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Units_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_data()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For Each row As DataGridViewRow In DataGridView1.Rows
            Dim select1 As Boolean = Convert.ToBoolean(row.Cells("checkboxcol").Value)
            If select1 Then
                conn.Open()
                Dim sql As String = "insert into Selected (ID,Name,Description,Lecturer,CreditHours) values(@ID,@Name,@Description,@Lecturer,@CreditHours)"

                'Dim cmd As OleDbCommand = New OleDbCommand(String.Concat("SELECT * FROM Students WHERE AdmNo = @admissionNumber"), conn)
                'cmd.Parameters.AddWithValue("@AdmNo", row.Cells("AdmNo").Value)

                Dim cmd1 As New OleDbCommand(sql, conn)






                cmd1.Parameters.AddWithValue("@ID", row.Cells("ID").Value)
                cmd1.Parameters.AddWithValue("@Name", row.Cells("Name").Value)
                cmd1.Parameters.AddWithValue("@Description", row.Cells("Description").Value)
                cmd1.Parameters.AddWithValue("@Lecturer", row.Cells("Lecturer").Value)
                cmd1.Parameters.AddWithValue("@CreditHours", row.Cells("CreditHours").Value)
                cmd1.ExecuteNonQuery()
                conn.Close()
            End If
        Next
        MessageBox.Show("YOU HAVE SUBMITTED UNITS")
    End Sub
End Class