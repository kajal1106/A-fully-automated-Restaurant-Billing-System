Imports System.Data.OleDb
Imports System.Object

Public Class alreceipt
    Private Sub alreceipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ProjectDataSet13.Billing' table. You can move, or remove it, as needed.
        Me.BillingTableAdapter.Fill(Me.ProjectDataSet13.Billing)

        Call connectDatabase()
        Label2.Text = Billing.OrNo1.Text
        Label4.Text = Billing.DateAddedLabel1.Text
        Call loadOrder()

        'Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub loadorder()
        Dim c As Integer
        Dim cn As New SqlClient.SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Project;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        Dim cmd As New SqlClient.SqlCommand
        Dim reader As SqlClient.SqlDataReader
        Try
            cn.Open()
            Dim sql As String
            sql = "Select * from addorder where Order_no. = '" & Label2.Text & "'"
            cmd = New SqlClient.SqlCommand(sql, cn)
            reader = cmd.ExecuteReader
            If reader.HasRows Then
                While reader.Read
                    DataGridView1.Rows.Add()
                    DataGridView1.Item(0, c).Value = reader.Item(2)
                    DataGridView1.Item(1, c).Value = reader.Item(5)
                    DataGridView1.Item(2, c).Value = reader.Item(6)
                    DataGridView1.Item(3, c).Value = reader.Item(7)
                    'DataGridView1.Item(4, c).Value =reader.Item(6)
                    c = c + 1
                End While
            Else
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim exit_app As String = MsgBox("Exit application?", vbQuestion + vbYesNo, "Exit")
        If exit_app = vbYes Then
            End
        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Call DisconnectDatabase()

        Me.Close()

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

End Class