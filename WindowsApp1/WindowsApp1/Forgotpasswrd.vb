Imports System.Data.SqlClient
Public Class Forgotpasswrd
    Private Sub Forgotpasswrd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label10.Text = Date.Now.ToString("dd-MM-yyyy hh:mm:ss")

    End Sub

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

    Private Sub Btnchange_Click(sender As Object, e As EventArgs) Handles Btnchange.Click
        Dim name As String
        Dim pass As String
        Dim newpass As String

        name = UsernameTextBox.Text
        pass = txtNewPassword.Text
        newpass = txtConfirmPassword.Text

        If (pass = newpass) Then
            Dim con As New SqlClient.SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Project;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
            con.Open()
            Dim cmd As New SqlClient.SqlCommand("Update LoginDetails set Password ='" & pass & "' where Username ='" & name & "' ", con)
            If (cmd.ExecuteNonQuery() > 0) Then
                MetroFramework.MetroMessageBox.Show(Owner, "Password Changed!", "Notification")
                If (MessageBoxButtons.OK) Then
                    frmlogin.Show()
                End If
            Else
                MetroFramework.MetroMessageBox.Show(Owner, "Account not found", "Notification")
            End If
        Else
            MetroFramework.MetroMessageBox.Show(Owner, "Password don't match!", "Notification")

        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        frmlogin.Show()
        Me.Hide()
    End Sub
End Class