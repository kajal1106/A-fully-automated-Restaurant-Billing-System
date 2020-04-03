Imports System.Data.SqlClient

Public Class MenuItems
    Private Sub MenuItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True


        Dim sqlcon As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Project;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        Dim sqlcmd As New SqlCommand("SELECT * FROM FULL_Menu", sqlcon)
        Dim ad As New SqlDataAdapter(sqlcmd)
        Dim dt As New DataTable()
        ad.Fill(dt)
        DataGridView1.DataSource = dt
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

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        frmmain.Show()
        Me.Hide()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label10.Text = Date.Now.ToString("dd-MM-yyyy hh:mm:ss")
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub DataGridView1_click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        Dim frmnew As New EditItem
        frmnew.TxtItemCode.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString()
        frmnew.TxtItemName.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()
        frmnew.ComboCategory.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString()
        frmnew.TxtDescription.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString()
        frmnew.TxtPrice.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString()
        frmnew.ComboTax.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString()
        frmnew.ComboType.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString()
        frmnew.ShowDialog()
        Me.Hide()
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