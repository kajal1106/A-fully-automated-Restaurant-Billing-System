Imports System.Data.SqlClient


Public Class EditItem
    Dim index As Integer
    Dim sqlcon As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Menu Items;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")


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

    Private Sub EditItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ProjectDataSet12.FULL_Menu' table. You can move, or remove it, as needed.
        Me.FULL_MenuTableAdapter.Fill(Me.ProjectDataSet12.FULL_Menu)


        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label10.Text = Date.Now.ToString("dd-MM-yyyy hh:mm:ss")
    End Sub

    Public Sub FilterData(valueToSearch As String)
        ' SELECT * FROM FULL_Menu '%F%'
        Dim searchQuery As String = "SELECT * FROM FULL_Menu where concat (Item_code , Item_name , Category) like '%" & valueToSearch & "%' "

        Dim sqlcon As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Project;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        Dim sqlcmd As New SqlCommand(searchQuery, sqlcon)
        Dim ad As New SqlDataAdapter(sqlcmd)
        Dim dt As New DataTable()
        ad.Fill(dt)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        frmmain.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_search.Click

        MenuItems.Show()
        Me.Hide()
    End Sub



    Private Sub TxtSearch_SelectedIndexChanged(sender As Object, e As EventArgs)
        Dim cn As New SqlClient.SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Project;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        Dim cmd As New SqlClient.SqlCommand
        Dim tbl As New DataTable
        Dim reader As SqlClient.SqlDataReader
        Try
            cn.Open()
            Dim sql As String
            sql = "Select * from FULL_Menu where Item_name = '" + TxtItemName.Text + "'"
            cmd = New SqlClient.SqlCommand(sql, cn)
            reader = cmd.ExecuteReader
            While reader.Read
                TxtItemCode = reader.Item("Item_code")
                TxtItemName = reader.Item("Item_name")
                ComboCategory = reader.Item("Category")
                TxtDescription = reader.Item("Description")
                TxtPrice = reader.Item("Price")
                ComboTax = reader.Item("Tax")
                ComboType = reader.Item("Type")

            End While
            cn.Close()
        Catch ex As Exception


        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Btn_save.Click




        Dim ch As Double
        Try
            ch = ""
            If TxtItemName.Text = " " Then

                ch = TxtItemName.Text = 0
            End If
            If TxtItemCode.Text = "" OrElse TxtItemName.Text = "" OrElse ComboCategory.Text = "" OrElse TxtDescription.Text = "" OrElse TxtPrice.Text = "" OrElse ComboTax.Text = "" OrElse ComboType.Text = "" Then
                MessageBox.Show("All Fields Are Mandatory")

            ElseIf (Convert.ToInt16(ch) >= 65) OrElse (Convert.ToInt16(ch) <= 90) OrElse (Convert.ToInt16(ch) >= 97) OrElse (Convert.ToInt16(ch) <= 122) Then
                MessageBox.Show("Item Name Must Contain Alphabets")
            End If
        Catch ex As Exception

        End Try


        Dim sqlcon As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Project;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        sqlcon.Open()

        Dim sqlcmd As New SqlCommand("Update FULL_Menu set Item_Name='" & TxtItemName.Text & "' , Category= '" & ComboCategory.SelectedValue.ToString() & "' , Description= '" & TxtDescription.Text & "' , Price= " + TxtPrice.Text + " ,Tax= " & ComboTax.SelectedValue.ToString() & ", Type='" & ComboType.SelectedValue.ToString() & "' where  Item_code = " & TxtItemCode.Text & ")", sqlcon)
        sqlcmd.ExecuteNonQuery()
        MessageBox.Show("Saved Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        sqlcon.Close()
    End Sub

    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click

        TxtItemName.ReadOnly = False
        ComboCategory.Enabled = True
        TxtDescription.ReadOnly = False
        TxtPrice.ReadOnly = False
        ComboTax.Enabled = True
        ComboType.Enabled = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim conn As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Project;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        conn.Open()
        Dim sqlcmd As New SqlCommand("Delete from FULL_Menu ", conn)
        '' Item_code = " & TxtItemCode.Text & " , Item_Name='" & TxtItemName.Text & "' , Category= '" & ComboCategory.SelectedValue.ToString() & "' , Description= '" & TxtDescription.Text & "' , Price= " + TxtPrice.Text + " ,Tax= " & ComboTax.SelectedValue.ToString() & ", Type='" & ComboType.SelectedValue.ToString() & "')", conn)
        sqlcmd.ExecuteNonQuery()
        If MessageBox.Show("Do you really want to Delete this Record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then

            MsgBox("Operation Cancelled")

            Exit Sub

        End If
        MessageBox.Show("Data has been successfully Deleted!")
        conn.Close()
    End Sub
End Class