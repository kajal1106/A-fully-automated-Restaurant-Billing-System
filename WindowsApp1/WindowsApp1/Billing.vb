Imports System.Data.SqlClient


Public Class Billing
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

    Private Sub MetroTile2_Click(sender As Object, e As EventArgs)
        MenuItems.Show()
        Me.Hide()
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        frmmain.Show()
        Me.Hide()
    End Sub

    Private Sub Billing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ProjectDataSet2.FULL_Menu' table. You can move, or remove it, as needed.
        Me.FULL_MenuTableAdapter1.Fill(Me.ProjectDataSet2.FULL_Menu)
        'TODO: This line of code loads data into the 'ProjectDataSet1.FULL_Menu' table. You can move, or remove it, as needed.
        Me.FULL_MenuTableAdapter.Fill(Me.ProjectDataSet1.FULL_Menu)

        Call cleartextbox()
        Call loadorder()



        Timer1.Enabled = True
    End Sub

    Private Sub cleartextbox()
        TxtBillno.Text = ""
        ComboBoxItemCode.Text = ""
        quantitytxtbox.Text = ""
        TxtPrice.Text = ""
        TxtVAT.Text = ""
        TxtDiscount.Text = ""
        TxtPayableAmount.Text = ""


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label10.Text = Date.Now.ToString("dd-MM-yyyy hh:mm:ss")

    End Sub

    Private Sub TxtDiscount_TextChanged(sender As Object, e As EventArgs) Handles TxtDiscount.TextChanged

    End Sub

    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        Try
            TxtPayableAmount.Text = TxtPrice.Text * quantitytxtbox.Text
        Catch
        End Try
        If quantitytxtbox.Text = "" Then
            MsgBox("Input Qty")
        ElseIf ComboBoxItemCode.Text = "" Then
            MsgBox("Input Code")
        Else
        End If
        Call loadorder()


        '' Dim res = MessageBox.Show("Do You want to add items ?", "", MessageBoxButtons.YesNo)
        ''If res = DialogResult.Yes Then

        ''Dim con As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Project;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        ''con.Open()
        ''Dim cmd As New SqlCommand("Insert into addorder values ( '" & ComboBoxItemCode.SelectedItem.ToString() & "'  ,'" & quantitytxtbox.Text & "', '" & TxtPrice.Text & "')", con)
        ''cmd.ExecuteNonQuery()
        ''MessageBox.Show("Items Added")
        ''con.Close()
        ''MsgBox("Data Added!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCCESS")
        ''End If
    End Sub

    Private Sub ButtonRemove_Click(sender As Object, e As EventArgs) Handles ButtonRemove.Click
        Call cleartextbox()
    End Sub

    Private Sub ComboBoxItemCode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxItemCode.SelectedIndexChanged
        Dim cn As New SqlClient.SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Project;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        Dim cmd As New SqlClient.SqlCommand
        Dim tbl As New DataTable
        Dim reader As SqlClient.SqlDataReader
        Try
            cn.Open()
            Dim sql As String
            sql = "Select * from FULL_Menu where Item_code = '" + ComboBoxItemCode.Text + "'"
            cmd = New SqlClient.SqlCommand(sql, cn)
            reader = cmd.ExecuteReader
            While reader.Read
                TxtPrice.Text = reader.Item("Price")
                TxtVAT.Text = reader.Item("")
                TxtDiscount = reader.Item("")
                TxtPayableAmount = reader.Item("Price")

            End While
            cn.Close()
        Catch ex As Exception


        End Try
    End Sub

    Private Sub Buttoncheckout_Click(sender As Object, e As EventArgs) Handles Buttoncheckout.Click
        Reciept.Label2.Text = OrNo1.Text
        Reciept.Label4.Text = DateAddedLabel1.Text
        Reciept.Label24.Text = TxtPrice.Text
        Reciept.Label26.Text = TxtVAT.Text
        Reciept.Label28.Text = TxtPayableAmount.Text

        Reciept.Label13.Text = InvoiceNo1.Text
        Me.Hide()
        Reciept.Show()



    End Sub
    Private Sub loadorder()
        Dim c As Integer
        Dim cn As New SqlClient.SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Project;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        Dim cmd As New SqlClient.SqlCommand
        Dim reader As SqlClient.SqlDataReader
        Try
            cn.Open()
            Dim sql As String
            sql = "Select * from addorder where Order_no. = '" + TxtBillno.Text + "'"
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
End Class