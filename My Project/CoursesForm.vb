Imports System.Data.OleDb
Public Class CoursesForm
    Private Sub CoursesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\hp\source\repos\addmission\MainDb.mdb")
        conn.Open()
        Dim cmd As New OleDbCommand("Select Description FROM Units order by Description", conn)
        Dim myreader As OleDbDataReader = cmd.ExecuteReader
        While myreader.Read
            CheckedListBox1.Items.Add(myreader(0))
        End While
        conn.Close()
    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox1.SelectedIndexChanged
        ListBox1.Items.Clear()
        For item As Integer = 0 To CheckedListBox1.CheckedItems.Count - 1
            ListBox1.Items.Add(CheckedListBox1.CheckedItems(item))
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Me.SelectedTableAdapter.Insert(ListBox1.)
        'Me.SelectedTableAdapter.Fill(Me.MainDbDataSet.Sel)
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class