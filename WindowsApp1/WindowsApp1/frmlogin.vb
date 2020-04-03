Imports System.Data.SqlClient
Public Class frmlogin

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click

        Dim con As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Project;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        con.Open()
        Dim cmd As New SqlCommand("SELECT * from LoginDetails where Username = '" & UsernameTextBox.Text & "' and Password = '" & PasswordTextBox.Text & "'", con)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)


        If dt.Rows.Count() <= 0 Then
            MetroFramework.MetroMessageBox.Show(Owner, "username or password invalid", "Notification")

        Else

            frmmain.Show()
            Me.Hide()

        End If

        ' Dim t As Integer
        't = 0
        't = t + 1
        'If UsernameTextBox.Text = "" And PasswordTextBox.Text <> "" Then
        'MetroFramework.MetroMessageBox.Show(Owner, "incorrect password")


        'ElseIf UsernameTextBox.Text <> " " And PasswordTextBox.Text = "" Then
        'MetroFramework.MetroMessageBox.Show(Owner, "user name invalid", "Notification")


        'ElseIf UsernameTextBox.Text <> "" And UsernameTextBox.Text <> "" Then
        'MetroFramework.MetroMessageBox.Show(Owner, "username or password invalid", "Notification")

        'End If


        'If t = 3 Then
        'MetroFramework.MetroMessageBox.Show(Owner, "Disable  Login more than 3 attempts", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        'Me.Close()
        'End If

    End Sub
    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        UsernameTextBox.Clear()
        PasswordTextBox.Clear()

        Me.Close()
    End Sub

    Private Sub frmlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label10.Text = Date.Now.ToString("dd-MM-yyyy hh:mm:ss")

    End Sub

    Private Sub MetroButton3_Click(sender As Object, e As EventArgs) Handles MetroButton3.Click
        Dim exit_app As String = MsgBox("Exit application?", vbQuestion + vbYesNo, "Exit")
        If exit_app = vbYes Then
            End
        End If
    End Sub


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Forgotpasswrd.Show()
        Me.Hide()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Signup.Show()
        Me.Hide()
    End Sub
End Class
