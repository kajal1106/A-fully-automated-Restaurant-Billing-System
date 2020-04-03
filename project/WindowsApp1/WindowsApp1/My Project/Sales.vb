Imports System.Data.SqlClient

Public Class Sales
    Private Sub Sales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label10.Text = Date.Now.ToString("dd-MM-yyyy hh:mm:ss")
    End Sub

    Private Sub GO_BTN_Click(sender As Object, e As EventArgs) Handles GO_BTN.Click
        Dim sqlcon As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Sales;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        Dim sqlcmd As New SqlCommand("SELECT * FROM Sales", sqlcon)
        Dim ad As New SqlDataAdapter(sqlcmd)
        Dim dt As New DataTable()
        ad.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub
End Class