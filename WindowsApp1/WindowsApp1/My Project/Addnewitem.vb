Imports System.Data.SqlClient

Public Class Addnewitem
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
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
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label10.Text = Date.Now.ToString("dd-MM-yyyy hh:mm:ss")

    End Sub

    Private Sub Addnewitem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub
    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        If MsgBox("Are you sure you want to Add Data?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "WARNING") = MsgBoxResult.Yes Then

            Dim sqlcon As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Project;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
            sqlcon.Open()

            Dim sqlcmd As New SqlCommand("insert into FULL_Menu values(" & TxtItemCode.Text & " ,'" & TxtItemName.Text & "' , '" & ComboCategory.SelectedItem.ToString() & "' , '" & TxtDescription.Text & "' , " + TxtPrice.Text + " , " & ComboTax.SelectedItem.ToString() & ", '" & ComboType.SelectedItem.ToString() & "')", sqlcon)
            sqlcmd.ExecuteNonQuery()
            sqlcon.Close()

            MsgBox("Data Added!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCCESS")
            'Me.Hide()
            'MenuItems.Show()


        End If

    End Sub

    Private Sub ComboCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboCategory.SelectedIndexChanged

    End Sub
End Class