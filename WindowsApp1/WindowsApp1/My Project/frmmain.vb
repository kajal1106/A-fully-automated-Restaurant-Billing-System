Public Class frmmain


    Private Sub frmmain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label10.Text = Date.Now.ToString("dd-MM-yyyy hh:mm:ss")

    End Sub
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Dim exit_app As String = MsgBox("Exit application?", vbQuestion + vbYesNo, "Exit")
        If exit_app = vbYes Then
            End
        End If
    End Sub



    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim out_app As String = MsgBox("Logout from application?", vbQuestion + vbYesNo, "Logout")
        If out_app = vbYes Then
            Me.Hide()
            frmlogin.Show()
        End If
    End Sub

    Private Sub AddCategoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddCategoryToolStripMenuItem.Click
        Addnewitem.Show()
        Me.Hide()
    End Sub

    Private Sub ViewStockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewStockToolStripMenuItem.Click
        MenuItems.Show()
        Me.Hide()

    End Sub

    Private Sub SearcToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearcToolStripMenuItem.Click
        SearchItem.Show()
        Me.Hide()
    End Sub

    Private Sub MetroDateTime1_ValueChanged(sender As Object, e As EventArgs)


        Console.WriteLine("Current Date: ")
        Dim dt As Date = Today
        Console.WriteLine("Today is: {0}", dt)

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
    Private Sub HomeDeliveryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeDeliveryToolStripMenuItem.Click
        Home_delivery.Show()
        Me.Hide()
    End Sub

    Private Sub SalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalesToolStripMenuItem.Click
        Dim frmSales As New Sales()
        frmSales.Show()
        Me.Hide()
    End Sub

    Private Sub BillingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BillingToolStripMenuItem.Click

        Billing.Show()
        Me.Hide()
    End Sub

    Private Sub ReportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportsToolStripMenuItem.Click


    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        MessageBox.Show(Owner, "If any issue in Software Contact. "" or Call """)
    End Sub

    Private Sub PaymentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PaymentToolStripMenuItem.Click
        EditItem.Show()
        Me.Hide()
    End Sub

    Private Sub DiscountToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Discount.Show()
        Me.Hide()
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        chngpassword.Show()
        Me.Hide()
    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        Forgotpasswrd.Show()
        Me.Hide()
    End Sub

    Private Sub SIGNUPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SIGNUPToolStripMenuItem.Click
        Signup.Show()
        Me.Hide()
    End Sub
End Class