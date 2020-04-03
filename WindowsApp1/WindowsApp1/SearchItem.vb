Imports System.Data.SqlClient

Public Class SearchItem
    Dim index As Integer
    Dim sqlcon As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Menu Items;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")


    Public Sub FilterData(valueToSearch As String)
        ' SELECT * FROM FULL_Menu '%F%'
        Dim searchQuery As String = "SELECT * FROM FULL_Menu where concat (Item_code , Item_name , Category) like '%" & valueToSearch & "%' "

        Dim sqlcon As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Menu Items;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        Dim sqlcmd As New SqlCommand(searchQuery, sqlcon)
        Dim ad As New SqlDataAdapter(sqlcmd)
        Dim dt As New DataTable()
        ad.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        frmmain.Show()
        Me.Hide()
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Dim out_app As String = MsgBox("Logout from application?", vbQuestion + vbYesNo, "Logout")
        If out_app = vbYes Then
            Me.Hide()
            frmlogin.Show()
        End If
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Dim exit_app As String = MsgBox("Exit application?", vbQuestion + vbYesNo, "Exit")
        If exit_app = vbYes Then
            End
        End If
    End Sub

    Private Sub SearchItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label10.Text = Date.Now.ToString("dd-MM-yyyy hh:mm:ss")
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick, DataGridView1.CellClick
        FilterData("")


        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView1.Rows(index)
        TxtSearch.Text = selectedRow.Cells(0).Value.ToString()
        TxtSearch.Text = selectedRow.Cells(1).Value.ToString()
        TxtSearch.Text = selectedRow.Cells(2).Value.ToString()
        TxtSearch.Text = selectedRow.Cells(3).Value.ToString()
        TxtSearch.Text = selectedRow.Cells(4).Value.ToString()


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TxtSearch.TextChanged
        FilterData(TxtSearch.Text)
    End Sub

    Private Sub GO_BTN_Click(sender As Object, e As EventArgs) Handles GO_BTN.Click
        FilterData(TxtSearch.Text)
    End Sub
End Class