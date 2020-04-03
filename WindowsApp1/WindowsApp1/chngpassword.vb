Public Class chngpassword

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

    Private Sub chngpassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label10.Text = Date.Now.ToString("dd-MM-yyyy hh:mm:ss")

    End Sub

    Private Sub Btnchange_Click(sender As Object, e As EventArgs) Handles Btnchange.Click
        If My.Settings.Username = UsernameTextBox.Text And My.Settings.Password = CurrentPasswordTextBox.Text Then
            If txtNewPassword.Text = txtConfirmPassword.Text Then
                My.Settings.Username = txtCurrentUsername.Text
                My.Settings.Password = CurrentPasswordTextBox.Text
                My.Settings.Save()
                MetroFramework.MetroMessageBox.Show(Owner, "Password Saved!", "Notification")

            Else
                MetroFramework.MetroMessageBox.Show(Owner, "Password don't Match!", "Notification")

            End If
            MetroFramework.MetroMessageBox.Show(Owner, "Wrong Current Password and Username", "Notification")

        Else
        End If
    End Sub
End Class