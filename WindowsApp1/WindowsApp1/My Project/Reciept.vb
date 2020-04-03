Imports System.Data.SqlClient
Imports System.Windows.Forms


Public Class Reciept
    Private Sub Reciept_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ProjectDataSet18.addorder' table. You can move, or remove it, as needed.
        Me.AddorderTableAdapter.Fill(Me.ProjectDataSet18.addorder)


        TxtDob.Text = DateTime.Now.ToShortDateString()
    End Sub

    Private Sub auto_increment_value_in_textbox_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim no As Int16 = 0

        Try

            Dim con As New SqlClient.SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Project;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
            con.Open()
            Dim cmd As New SqlCommand("SELECT max(Bill_no) FROM addorder", con)
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)

            no = dt.Rows(0)(0).ToString()
            TxtBillno.Text = no + 1
        Catch
            TxtBillno.Text = "1"
        End Try
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conn As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Project;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")

        conn.Open()
        Dim sqlcmd As New SqlCommand("Delete from addorder", conn)
        sqlcmd.ExecuteNonQuery()
        conn.Close()


        Me.Close()
        Billing.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click




        Dim sqlcon As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Project;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        Dim sqlcmd As New SqlCommand("SELECT * FROM addorder", sqlcon)

        Dim ad As New SqlDataAdapter(sqlcmd)
        Dim dt As New DataTable()
        ad.Fill(dt)
        DataGridView1.DataSource = dt


        PrintDocument1.Print()


    End Sub


    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim bm As New Bitmap(Me.Panel1.Width, Me.Panel1.Height)

        Panel1.DrawToBitmap(bm, New Rectangle(0, 0, Me.Panel1.Width, Me.Panel1.Height))

        e.Graphics.DrawImage(bm, 0, 0)
        Dim aPS As New PageSetupDialog
        aPS.Document = PrintDocument1
        '
        ' On the 1-rst call to the print dialog initialize the document's 
        ' properties. On subsequent calls use what was previously set.
        '

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim exit_app As String = MsgBox("Exit application?", vbQuestion + vbYesNo, "Exit")
        If exit_app = vbYes Then
            End
        End If

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
