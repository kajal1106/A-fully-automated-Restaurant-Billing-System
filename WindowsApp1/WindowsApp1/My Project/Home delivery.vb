Imports System.Data.SqlClient


Public Class Home_delivery

    Dim sqlcon As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Project;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")

    Private Sub Home_delivery_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ProjectDataSet3.HomeDelivery' table. You can move, or remove it, as needed.
        Me.HomeDeliveryTableAdapter.Fill(Me.ProjectDataSet3.HomeDelivery)
        Timer1.Enabled = True

        Dim sqlcmd As New SqlCommand("SELECT * FROM HomeDelivery", sqlcon)
        Dim ad As New SqlDataAdapter(sqlcmd)
        Dim dt As New DataTable()
        ad.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label10.Text = Date.Now.ToString("dd-MM-yyyy hh:mm:ss")
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        frmmain.Show()
        Me.Hide()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

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

    Private Sub GO_BTN_Click(sender As Object, e As EventArgs) Handles GO_BTN.Click
        Dim datetd As String
        datetd = DateTimePicker1.Value.ToString("dd-MM-yyyy")
        Dim sqlcon As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Project;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        Dim sqlcmd As New SqlCommand("SELECT * FROM HomeDelivery where dateofbilling = '" + datetd + "'", sqlcon)
        Dim ad As New SqlDataAdapter(sqlcmd)
        Dim dt As New DataTable()
        ad.Fill(dt)
        DataGridView1.DataSource = dt

    End Sub
End Class