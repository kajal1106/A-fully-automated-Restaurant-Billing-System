﻿Public Class frmlogin

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Dim t As Integer
        If UsernameTextBox.Text = "vamps" And PasswordTextBox.Text = "vamps" Then
            t = 0
            frmmain.Show()
            Me.Hide()

        Else
            t = t + 1
            If UsernameTextBox.Text = "vamps" And PasswordTextBox.Text <> "vamps" Then
                MetroFramework.MetroMessageBox.Show(Owner, "incorrect password")


            ElseIf UsernameTextBox.Text <> "vamps " And PasswordTextBox.Text = "vamps" Then
                MetroFramework.MetroMessageBox.Show(Owner, "user name invalid", "Notification")


            ElseIf UsernameTextBox.Text <> "vamps" And UsernameTextBox.Text <> "vamps" Then
                MetroFramework.MetroMessageBox.Show(Owner, "username or password invalid", "Notification")

            End If


            If t = 3 Then
                MetroFramework.MetroMessageBox.Show(Owner, "Disable  Login more than 3 attempts", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Me.Close()
            End If
        End If
    End Sub
    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        UsernameTextBox.Clear()
        PasswordTextBox.Clear()
    End Sub

    Private Sub frmlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label10.Text = Date.Now.ToString("dd-MM-yyyy hh:mm:ss")

    End Sub
End Class
