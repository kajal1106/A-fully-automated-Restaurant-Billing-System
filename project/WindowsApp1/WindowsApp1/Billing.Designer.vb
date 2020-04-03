<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Billing
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Billing))
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtBillno = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtDOB = New System.Windows.Forms.TextBox()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.RadioButton_walkin = New System.Windows.Forms.RadioButton()
        Me.RadioButton_homedelivery = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ComboBoxItemCode = New System.Windows.Forms.ComboBox()
        Me.ComboBoxQuantity = New System.Windows.Forms.ComboBox()
        Me.Buttoncheckout = New System.Windows.Forms.Button()
        Me.ButtonRemove = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtPayableAmount = New System.Windows.Forms.TextBox()
        Me.TxtDiscount = New System.Windows.Forms.TextBox()
        Me.TxtVAT = New System.Windows.Forms.TextBox()
        Me.TxtPrice = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroButton1
        '
        Me.MetroButton1.BackgroundImage = CType(resources.GetObject("MetroButton1.BackgroundImage"), System.Drawing.Image)
        Me.MetroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.MetroButton1.Location = New System.Drawing.Point(1102, 15)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(32, 33)
        Me.MetroButton1.TabIndex = 15
        Me.MetroButton1.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.MetroButton1.UseCustomBackColor = True
        Me.MetroButton1.UseCustomForeColor = True
        Me.MetroButton1.UseSelectable = True
        Me.MetroButton1.UseStyleColors = True
        '
        'MetroButton2
        '
        Me.MetroButton2.BackgroundImage = CType(resources.GetObject("MetroButton2.BackgroundImage"), System.Drawing.Image)
        Me.MetroButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.MetroButton2.Location = New System.Drawing.Point(1140, 15)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(37, 35)
        Me.MetroButton2.TabIndex = 19
        Me.MetroButton2.UseSelectable = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Castellar", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(25, 158)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 19)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Bill No."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Castellar", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(11, 228)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 19)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Item Code"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Castellar", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(302, 228)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 19)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Quantity"
        '
        'TxtBillno
        '
        Me.TxtBillno.Location = New System.Drawing.Point(134, 157)
        Me.TxtBillno.Name = "TxtBillno"
        Me.TxtBillno.Size = New System.Drawing.Size(121, 20)
        Me.TxtBillno.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Castellar", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(361, 158)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(177, 19)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Date of Billing"
        '
        'TxtDOB
        '
        Me.TxtDOB.Location = New System.Drawing.Point(544, 156)
        Me.TxtDOB.Name = "TxtDOB"
        Me.TxtDOB.Size = New System.Drawing.Size(125, 20)
        Me.TxtDOB.TabIndex = 28
        '
        'ButtonAdd
        '
        Me.ButtonAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ButtonAdd.Font = New System.Drawing.Font("Bradley Hand ITC", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAdd.ForeColor = System.Drawing.Color.Black
        Me.ButtonAdd.Location = New System.Drawing.Point(638, 205)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(95, 42)
        Me.ButtonAdd.TabIndex = 29
        Me.ButtonAdd.Text = "ADD"
        Me.ButtonAdd.UseVisualStyleBackColor = False
        '
        'RadioButton_walkin
        '
        Me.RadioButton_walkin.AutoSize = True
        Me.RadioButton_walkin.Font = New System.Drawing.Font("Castellar", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_walkin.ForeColor = System.Drawing.Color.Black
        Me.RadioButton_walkin.Location = New System.Drawing.Point(721, 153)
        Me.RadioButton_walkin.Name = "RadioButton_walkin"
        Me.RadioButton_walkin.Size = New System.Drawing.Size(114, 23)
        Me.RadioButton_walkin.TabIndex = 30
        Me.RadioButton_walkin.TabStop = True
        Me.RadioButton_walkin.Text = "Walk In"
        Me.RadioButton_walkin.UseVisualStyleBackColor = True
        '
        'RadioButton_homedelivery
        '
        Me.RadioButton_homedelivery.AutoSize = True
        Me.RadioButton_homedelivery.Font = New System.Drawing.Font("Castellar", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_homedelivery.ForeColor = System.Drawing.Color.Black
        Me.RadioButton_homedelivery.Location = New System.Drawing.Point(841, 153)
        Me.RadioButton_homedelivery.Name = "RadioButton_homedelivery"
        Me.RadioButton_homedelivery.Size = New System.Drawing.Size(186, 23)
        Me.RadioButton_homedelivery.TabIndex = 31
        Me.RadioButton_homedelivery.TabStop = True
        Me.RadioButton_homedelivery.Text = "Home Delivery"
        Me.RadioButton_homedelivery.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Location = New System.Drawing.Point(15, 268)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(843, 199)
        Me.Panel1.TabIndex = 32
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(843, 199)
        Me.DataGridView1.TabIndex = 0
        '
        'ComboBoxItemCode
        '
        Me.ComboBoxItemCode.FormattingEnabled = True
        Me.ComboBoxItemCode.Location = New System.Drawing.Point(134, 227)
        Me.ComboBoxItemCode.Name = "ComboBoxItemCode"
        Me.ComboBoxItemCode.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxItemCode.TabIndex = 1
        '
        'ComboBoxQuantity
        '
        Me.ComboBoxQuantity.FormattingEnabled = True
        Me.ComboBoxQuantity.Location = New System.Drawing.Point(423, 227)
        Me.ComboBoxQuantity.Name = "ComboBoxQuantity"
        Me.ComboBoxQuantity.Size = New System.Drawing.Size(133, 21)
        Me.ComboBoxQuantity.TabIndex = 33
        '
        'Buttoncheckout
        '
        Me.Buttoncheckout.Font = New System.Drawing.Font("Bradley Hand ITC", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buttoncheckout.ForeColor = System.Drawing.Color.Black
        Me.Buttoncheckout.Location = New System.Drawing.Point(17, 545)
        Me.Buttoncheckout.Name = "Buttoncheckout"
        Me.Buttoncheckout.Size = New System.Drawing.Size(112, 42)
        Me.Buttoncheckout.TabIndex = 34
        Me.Buttoncheckout.Text = "Check Out"
        Me.Buttoncheckout.UseVisualStyleBackColor = True
        '
        'ButtonRemove
        '
        Me.ButtonRemove.BackColor = System.Drawing.Color.Transparent
        Me.ButtonRemove.Font = New System.Drawing.Font("Bradley Hand ITC", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRemove.ForeColor = System.Drawing.Color.Black
        Me.ButtonRemove.Location = New System.Drawing.Point(15, 473)
        Me.ButtonRemove.Name = "ButtonRemove"
        Me.ButtonRemove.Size = New System.Drawing.Size(114, 46)
        Me.ButtonRemove.TabIndex = 35
        Me.ButtonRemove.Text = "Remove"
        Me.ButtonRemove.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Castellar", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(282, 555)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 19)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Discount"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Castellar", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(282, 594)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(192, 19)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Payable Amount"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Castellar", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(282, 517)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(123, 19)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "Total VAT"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Castellar", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(282, 485)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(136, 19)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "Total Price"
        '
        'TxtPayableAmount
        '
        Me.TxtPayableAmount.Location = New System.Drawing.Point(513, 593)
        Me.TxtPayableAmount.Name = "TxtPayableAmount"
        Me.TxtPayableAmount.Size = New System.Drawing.Size(100, 20)
        Me.TxtPayableAmount.TabIndex = 40
        Me.TxtPayableAmount.Text = " "
        '
        'TxtDiscount
        '
        Me.TxtDiscount.Location = New System.Drawing.Point(513, 556)
        Me.TxtDiscount.Name = "TxtDiscount"
        Me.TxtDiscount.Size = New System.Drawing.Size(100, 20)
        Me.TxtDiscount.TabIndex = 41
        '
        'TxtVAT
        '
        Me.TxtVAT.Location = New System.Drawing.Point(513, 516)
        Me.TxtVAT.Name = "TxtVAT"
        Me.TxtVAT.Size = New System.Drawing.Size(100, 20)
        Me.TxtVAT.TabIndex = 42
        '
        'TxtPrice
        '
        Me.TxtPrice.Location = New System.Drawing.Point(513, 473)
        Me.TxtPrice.Name = "TxtPrice"
        Me.TxtPrice.Size = New System.Drawing.Size(100, 20)
        Me.TxtPrice.TabIndex = 43
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Castellar", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label1.Location = New System.Drawing.Point(465, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(235, 58)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "BILLING"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1060, 15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(36, 35)
        Me.PictureBox1.TabIndex = 44
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(895, 250)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(307, 309)
        Me.PictureBox2.TabIndex = 52
        Me.PictureBox2.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(-2, 15)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(97, 25)
        Me.Label10.TabIndex = 56
        Me.Label10.Text = "Label10"
        '
        'Billing
        '
        Me.ApplyImageInvert = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BackImage = CType(resources.GetObject("$this.BackImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1214, 662)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TxtPrice)
        Me.Controls.Add(Me.TxtVAT)
        Me.Controls.Add(Me.TxtDiscount)
        Me.Controls.Add(Me.TxtPayableAmount)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ButtonRemove)
        Me.Controls.Add(Me.Buttoncheckout)
        Me.Controls.Add(Me.ComboBoxQuantity)
        Me.Controls.Add(Me.ComboBoxItemCode)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.RadioButton_homedelivery)
        Me.Controls.Add(Me.RadioButton_walkin)
        Me.Controls.Add(Me.ButtonAdd)
        Me.Controls.Add(Me.TxtDOB)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtBillno)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MetroButton2)
        Me.Controls.Add(Me.MetroButton1)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Billing"
        Me.Style = MetroFramework.MetroColorStyle.[Default]
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        Me.Theme = MetroFramework.MetroThemeStyle.[Default]
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.DodgerBlue
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtBillno As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtDOB As TextBox
    Friend WithEvents ButtonAdd As Button
    Friend WithEvents RadioButton_walkin As RadioButton
    Friend WithEvents RadioButton_homedelivery As RadioButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ComboBoxItemCode As ComboBox
    Friend WithEvents ComboBoxQuantity As ComboBox
    Friend WithEvents Buttoncheckout As Button
    Friend WithEvents ButtonRemove As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtPayableAmount As TextBox
    Friend WithEvents TxtDiscount As TextBox
    Friend WithEvents TxtVAT As TextBox
    Friend WithEvents TxtPrice As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label10 As Label
End Class
