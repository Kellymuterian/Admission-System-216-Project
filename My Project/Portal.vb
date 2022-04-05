Imports System.Data.OleDb
Public Class Portal
    Dim db As OleDbConnection = New OleDbConnection()
    'Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Adm\source\repos\VB Database\MainDb.mdb")
    Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\hp\source\repos\DB\MainDb.mdb")
    Dim admissionNumber As String
    Dim maxCDr As Integer
    Private Sub LogOut_Click(sender As Object, e As EventArgs) Handles LogOut.Click
        Me.Close()
        Form1.Show()
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
    End Sub

    Private Sub Portal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'db.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Adm\source\repos\VB Database\MainDb.mdb"
        db.ConnectionString = String.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\hp\source\repos\DB\MainDb.mdb")
        db.Open()
        PLoad_data()
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
            maxCDr = student(5)
            GradDate.Text = student(7)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Units.Tag = admissionNumber + " " + maxCDr.ToString()
        Units.Show()
        Me.Hide()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class