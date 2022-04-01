Imports System.Data.OleDb

Public Class Units
    'Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Adm\Source\Repos\Admission\MainDb.mdb")
    Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\hp\source\repos\DB\MainDb.mdb")
    Dim maxCredits As Integer = 0
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

    Private Sub PLoad_data()
        conn.Open()
        Dim cmd As New OleDbCommand("select ID,Name,Description,Lecturer,CreditHours from Selected WHERE AdmNo = @admissionNumber", conn)
        cmd.Parameters.AddWithValue("@admissionNumber", Me.Tag.Adm.ToString())
        Dim dtb As New OleDbDataAdapter
        dtb.SelectCommand = cmd
        Dim Selected As New DataTable
        Selected.Clear()
        dtb.Fill(Selected)
        DataGridView2.DataSource = Selected
        conn.Close()
        For Each item As DataGridViewRow In DataGridView2.Rows
            maxCredits = maxCredits + 3
        Next
        MaxCreditsText.Text = maxCredits.ToString() + "/" + Me.Tag.MaxVd.ToString() + " Hours"
    End Sub


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
    Private Sub Units_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_data()
        PLoad_data()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For Each row As DataGridViewRow In DataGridView1.Rows
            Dim select1 As Boolean = Convert.ToBoolean(row.Cells("checkboxcol").Value)
            If select1 Then
                conn.Open()
                Dim sql As String = "insert into Selected (AdmNo,Name,Description,Lecturer,CreditHours) values(@AdmNumber,@Name,@Description,@Lecturer,@CreditHours)"
                Dim cmd1 As New OleDbCommand(sql, conn)
                cmd1.Parameters.AddWithValue("@AdmNumber", Me.Tag.Adm.ToString())
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

    Private Sub ExitAddUnits_Click(sender As Object, e As EventArgs) Handles ExitAddUnits.Click
        Portal.Show()
        Me.Close()

    End Sub
End Class