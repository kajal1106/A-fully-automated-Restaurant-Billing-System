Imports System.Data.SqlClient
Public Class Signup
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


    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Dim sqlcon As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Project;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        Dim sqlcmd As New SqlCommand("Insert into LoginDetails values ('" & UsernameTextBox.Text & "' , '" & PasswordTextBox.Text & "')", sqlcon)
        sqlcon.Open()
        sqlcmd.ExecuteNonQuery()
        If (sqlcmd.ExecuteNonQuery() > 0) Then
            MessageBox.Show("Account Created Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information)

            If (MessageBoxButtons.OK) Then
                Me.Hide()
                frmlogin.Show()
            End If

        End If

    End Sub
End Class