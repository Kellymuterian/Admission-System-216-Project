Imports System.Data.OleDb

Public Class Units
    Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Adm\source\repos\VB Database\MainDb.mdb")
    ' Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\hp\source\repos\DB\MainDb.mdb")
    Dim maxCredits As Integer = 0
    Dim unitsRegistered As List(Of String) = New List(Of String)
    Private Sub Load_data()
        conn.Open()
        Dim cmd As New OleDbCommand("select ID, Name, Description, Lecturer, CreditHours from Units", conn)
        Dim dt As New OleDbDataAdapter
        dt.SelectCommand = cmd
        Dim Selected As New DataTable
        Selected.Clear()
        dt.Fill(Selected)
        DataGridView1.DataSource = Selected
        conn.Close()
        Dim checkboxcol As New DataGridViewCheckBoxColumn
        'checkboxcol.Width = 40
        'checkboxcol.Name = "checkboxcol"
        'DataGridView1.Columns.Insert(0, checkboxcol)
    End Sub

    Private Sub PLoad_data()
        conn.Open()
        Dim cmd As New OleDbCommand("select ID,Name,Description,Lecturer,CreditHours from Selected WHERE AdmNo = @admissionNumber", conn)
        cmd.Parameters.AddWithValue("@admissionNumber", Me.Tag.ToString().Substring(0, 7))
        Dim dtb As New OleDbDataAdapter
        dtb.SelectCommand = cmd
        Dim Selected As New DataTable
        Selected.Clear()
        dtb.Fill(Selected)
        DataGridView2.DataSource = Selected
        conn.Close()
        For Each item As DataGridViewRow In DataGridView2.Rows
            maxCredits = maxCredits + 3
            unitsRegistered.Add(item.Cells(2).ToString())
            Console.WriteLine(unitsRegistered.Item(0).ToString())
        Next
        MaxCreditsText.Text = maxCredits.ToString() + "/" + Me.Tag.ToString().Substring(8) + " Hours"
    End Sub
    Private Sub Units_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PLoad_data()
        Load_data()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If maxCredits > Integer.Parse(Me.Tag.ToString().Substring(8)) Then
            MessageBox.Show("You've exceeded you maximum creadit hours")
        Else
            For Each row As DataGridViewRow In DataGridView1.Rows
                Dim select1 As Boolean = Convert.ToBoolean(row.Cells("checkboxcol").Value)
                If select1 Then
                    conn.Open()
                    Dim sql As String = "insert into Selected (AdmNo,Name,Description,Lecturer,CreditHours) values(@AdmNumber,@Name,@Description,@Lecturer,@CreditHours)"
                    Dim cmd1 As New OleDbCommand(sql, conn)
                    cmd1.Parameters.AddWithValue("@AdmNumber", Me.Tag.ToString().Substring(0, 7))
                    cmd1.Parameters.AddWithValue("@Name", row.Cells("Name").Value)
                    cmd1.Parameters.AddWithValue("@Description", row.Cells("Description").Value)
                    cmd1.Parameters.AddWithValue("@Lecturer", row.Cells("Lecturer").Value)
                    cmd1.Parameters.AddWithValue("@CreditHours", row.Cells("CreditHours").Value)
                    cmd1.ExecuteNonQuery()
                    conn.Close()
                End If
            Next
            PLoad_data()
            MessageBox.Show("YOU HAVE SUBMITTED UNITS")
        End If
    End Sub
    Private Sub ExitAddUnits_Click(sender As Object, e As EventArgs) Handles ExitAddUnits.Click
        Portal.Show()
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        'If Convert.ToBoolean(DataGridView1.Rows(e.RowIndex).Cells(0).Value) Then
        If maxCredits > Integer.Parse(Me.Tag.ToString().Substring(8)) Or maxCredits + Integer.Parse(DataGridView1.Rows(e.RowIndex).Cells(5).Value) > Integer.Parse(Me.Tag.ToString().Substring(8)) Then
                MessageBox.Show("You've exceeded you maximum creadit hours  ")
            Else
            If unitsRegistered.Contains(DataGridView1.Rows(e.RowIndex).Cells(2).ToString()) Then
                MaxCreditsText.Text = maxCredits.ToString() + "/" + unitsRegistered.Item(0) + Me.Tag.ToString().Substring(8) + " Hours"

                MessageBox.Show("You've already selected this unit ")
            Else
                maxCredits = maxCredits + Integer.Parse(DataGridView1.Rows(e.RowIndex).Cells(5).Value)
                MaxCreditsText.Text = maxCredits.ToString() + "/" + Me.Tag.ToString().Substring(8) + " Hours"
            End If

            End If
        'Else
        'MessageBox.Show("You've already " + Convert.ToBoolean(DataGridView1.Rows(e.RowIndex).Cells(0).Value).ToString())
        'End If

    End Sub
End Class