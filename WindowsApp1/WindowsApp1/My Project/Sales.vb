Imports System.Data.SqlClient

Public Class Sales
    Private Sub Sales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ProjectDataSet16.Billing' table. You can move, or remove it, as needed.
        'Me.BillingTableAdapter1.Fill(Me.ProjectDataSet16.Billing)


        Timer1.Enabled = True

        TxtDob.Text = DateTime.Now.ToShortDateString()

        Dim sqlcon As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Project;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        Dim sqlcmd As New SqlCommand("Select * FROM Billing ", sqlcon)
        Dim ad As New SqlDataAdapter(sqlcmd)
        Dim dt As New DataTable()

        ad.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label10.Text = Date.Now.ToString("dd-MM-yyyy hh:mm:ss")
    End Sub

    Private Sub GO_BTN_Click(sender As Object, e As EventArgs) Handles GO_BTN.Click

        Dim con As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Project;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        con.Open()
        Dim cmd As New SqlCommand("SELECT COUNT(*) as 'Number of Rows' FROM Billing where [dateofbilling] = '?' ", con)
        cmd.Parameters.AddWithValue("@date", Now.ToString("dd-MM-yyyy"))

        Dim count As Int16 = Convert.ToInt16(cmd.ExecuteScalar())
        total_sales.Text = count.ToString
        con.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        frmmain.Show()
        Me.Hide()
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Dim exit_app As String = MsgBox("Exit application?", vbQuestion + vbYesNo, "Exit")
        If exit_app = vbYes Then
            End
        End If
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Dim out_app As String = MsgBox("Logout from application?", vbQuestion + vbYesNo, "Logout")
        If out_app = vbYes Then
            Me.Hide()
            frmlogin.Show()
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles DataGridView1.CellPainting
        If e.ColumnIndex = -1 AndAlso e.RowIndex > -1 AndAlso e.RowIndex < DataGridView1.Rows.Count - 1 Then
            Dim indexstring As String = (e.RowIndex + 1).ToString
            Dim sz As SizeF = e.Graphics.MeasureString(indexstring, DataGridView1.Font)
            Dim pt As New PointF(e.CellBounds.Width - sz.Width, e.CellBounds.Y + (e.CellBounds.Height / 1.18 - sz.Height))
            e.Paint(e.CellBounds, DataGridViewPaintParts.All)
            e.Graphics.DrawString(indexstring, DataGridView1.Font, Brushes.Black, pt)
            e.Handled = True
        End If
    End Sub
End Class