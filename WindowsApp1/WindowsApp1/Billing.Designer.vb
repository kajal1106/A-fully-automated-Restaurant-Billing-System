<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Billing
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Billing))
        Me.InvoiceNo1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TxtPrice = New System.Windows.Forms.TextBox()
        Me.TxtVAT = New System.Windows.Forms.TextBox()
        Me.TxtDiscount = New System.Windows.Forms.TextBox()
        Me.TxtPayableAmount = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Payable_amount = New System.Windows.Forms.Label()
        Me.discount = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.quantitytxtbox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.OrNo1 = New System.Windows.Forms.Label()
        Me.DateAddedLabel1 = New System.Windows.Forms.Label()
        Me.ButtonRemove = New System.Windows.Forms.Button()
        Me.Buttoncheckout = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.RadioButton_homedelivery = New System.Windows.Forms.RadioButton()
        Me.RadioButton_walkin = New System.Windows.Forms.RadioButton()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtBillno = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxItemCode = New System.Windows.Forms.ComboBox()
        Me.TxtDob = New System.Windows.Forms.TextBox()
        Me.txtItemName = New System.Windows.Forms.TextBox()
        Me.ItemName = New System.Windows.Forms.Label()
        Me.ProjectDataSet2 = New WindowsApp1.ProjectDataSet2()
        Me.FULLMenuBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FULL_MenuTableAdapter = New WindowsApp1.ProjectDataSet2TableAdapters.FULL_MenuTableAdapter()
        Me.ItemcodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TaxDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProjectDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FULLMenuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'InvoiceNo1
        '
        Me.InvoiceNo1.Location = New System.Drawing.Point(178, 139)
        Me.InvoiceNo1.Name = "InvoiceNo1"
        Me.InvoiceNo1.Size = New System.Drawing.Size(77, 23)
        Me.InvoiceNo1.TabIndex = 129
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(957, 261)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(307, 309)
        Me.PictureBox2.TabIndex = 125
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1088, 23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(36, 35)
        Me.PictureBox1.TabIndex = 124
        Me.PictureBox1.TabStop = False
        '
        'TxtPrice
        '
        Me.TxtPrice.Location = New System.Drawing.Point(541, 481)
        Me.TxtPrice.Name = "TxtPrice"
        Me.TxtPrice.Size = New System.Drawing.Size(100, 20)
        Me.TxtPrice.TabIndex = 123
        '
        'TxtVAT
        '
        Me.TxtVAT.Location = New System.Drawing.Point(541, 524)
        Me.TxtVAT.Name = "TxtVAT"
        Me.TxtVAT.Size = New System.Drawing.Size(100, 20)
        Me.TxtVAT.TabIndex = 122
        '
        'TxtDiscount
        '
        Me.TxtDiscount.Location = New System.Drawing.Point(541, 564)
        Me.TxtDiscount.Name = "TxtDiscount"
        Me.TxtDiscount.Size = New System.Drawing.Size(100, 20)
        Me.TxtDiscount.TabIndex = 121
        '
        'TxtPayableAmount
        '
        Me.TxtPayableAmount.Location = New System.Drawing.Point(541, 601)
        Me.TxtPayableAmount.Name = "TxtPayableAmount"
        Me.TxtPayableAmount.Size = New System.Drawing.Size(100, 20)
        Me.TxtPayableAmount.TabIndex = 120
        Me.TxtPayableAmount.Text = " "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Castellar", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(310, 493)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(136, 19)
        Me.Label9.TabIndex = 119
        Me.Label9.Text = "Total Price"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Castellar", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(310, 525)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(123, 19)
        Me.Label8.TabIndex = 118
        Me.Label8.Text = "Total VAT"
        '
        'Payable_amount
        '
        Me.Payable_amount.AutoSize = True
        Me.Payable_amount.Font = New System.Drawing.Font("Castellar", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Payable_amount.ForeColor = System.Drawing.Color.Black
        Me.Payable_amount.Location = New System.Drawing.Point(310, 602)
        Me.Payable_amount.Name = "Payable_amount"
        Me.Payable_amount.Size = New System.Drawing.Size(192, 19)
        Me.Payable_amount.TabIndex = 117
        Me.Payable_amount.Text = "Payable Amount"
        '
        'discount
        '
        Me.discount.AutoSize = True
        Me.discount.Font = New System.Drawing.Font("Castellar", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.discount.ForeColor = System.Drawing.Color.Black
        Me.discount.Location = New System.Drawing.Point(310, 563)
        Me.discount.Name = "discount"
        Me.discount.Size = New System.Drawing.Size(111, 19)
        Me.discount.TabIndex = 116
        Me.discount.Text = "Discount"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(26, 23)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 23)
        Me.Label10.TabIndex = 126
        Me.Label10.Text = "Label10"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'quantitytxtbox
        '
        Me.quantitytxtbox.Location = New System.Drawing.Point(690, 235)
        Me.quantitytxtbox.Name = "quantitytxtbox"
        Me.quantitytxtbox.Size = New System.Drawing.Size(138, 20)
        Me.quantitytxtbox.TabIndex = 127
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(311, 119)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 13)
        Me.Label6.TabIndex = 134
        Me.Label6.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(311, 79)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 13)
        Me.Label7.TabIndex = 133
        Me.Label7.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(311, 97)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(0, 13)
        Me.Label11.TabIndex = 132
        Me.Label11.Visible = False
        '
        'OrNo1
        '
        Me.OrNo1.AutoSize = True
        Me.OrNo1.Location = New System.Drawing.Point(703, 90)
        Me.OrNo1.Name = "OrNo1"
        Me.OrNo1.Size = New System.Drawing.Size(0, 13)
        Me.OrNo1.TabIndex = 131
        '
        'DateAddedLabel1
        '
        Me.DateAddedLabel1.Location = New System.Drawing.Point(805, 90)
        Me.DateAddedLabel1.Name = "DateAddedLabel1"
        Me.DateAddedLabel1.Size = New System.Drawing.Size(104, 23)
        Me.DateAddedLabel1.TabIndex = 130
        '
        'ButtonRemove
        '
        Me.ButtonRemove.BackColor = System.Drawing.Color.Transparent
        Me.ButtonRemove.Font = New System.Drawing.Font("Bradley Hand ITC", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRemove.ForeColor = System.Drawing.Color.Black
        Me.ButtonRemove.Location = New System.Drawing.Point(43, 481)
        Me.ButtonRemove.Name = "ButtonRemove"
        Me.ButtonRemove.Size = New System.Drawing.Size(114, 46)
        Me.ButtonRemove.TabIndex = 115
        Me.ButtonRemove.Text = "Remove"
        Me.ButtonRemove.UseVisualStyleBackColor = False
        '
        'Buttoncheckout
        '
        Me.Buttoncheckout.Font = New System.Drawing.Font("Bradley Hand ITC", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buttoncheckout.ForeColor = System.Drawing.Color.Black
        Me.Buttoncheckout.Location = New System.Drawing.Point(45, 553)
        Me.Buttoncheckout.Name = "Buttoncheckout"
        Me.Buttoncheckout.Size = New System.Drawing.Size(112, 42)
        Me.Buttoncheckout.TabIndex = 114
        Me.Buttoncheckout.Text = "Check Out"
        Me.Buttoncheckout.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Location = New System.Drawing.Point(43, 276)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(745, 199)
        Me.Panel1.TabIndex = 113
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ItemcodeDataGridViewTextBoxColumn, Me.ItemnameDataGridViewTextBoxColumn, Me.CategoryDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn, Me.TaxDataGridViewTextBoxColumn, Me.TypeDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.FULLMenuBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(745, 199)
        Me.DataGridView1.TabIndex = 0
        '
        'RadioButton_homedelivery
        '
        Me.RadioButton_homedelivery.AutoSize = True
        Me.RadioButton_homedelivery.Font = New System.Drawing.Font("Castellar", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_homedelivery.ForeColor = System.Drawing.Color.Black
        Me.RadioButton_homedelivery.Location = New System.Drawing.Point(900, 149)
        Me.RadioButton_homedelivery.Name = "RadioButton_homedelivery"
        Me.RadioButton_homedelivery.Size = New System.Drawing.Size(186, 23)
        Me.RadioButton_homedelivery.TabIndex = 112
        Me.RadioButton_homedelivery.TabStop = True
        Me.RadioButton_homedelivery.Text = "Home Delivery"
        Me.RadioButton_homedelivery.UseVisualStyleBackColor = True
        '
        'RadioButton_walkin
        '
        Me.RadioButton_walkin.AutoSize = True
        Me.RadioButton_walkin.Font = New System.Drawing.Font("Castellar", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_walkin.ForeColor = System.Drawing.Color.Black
        Me.RadioButton_walkin.Location = New System.Drawing.Point(763, 149)
        Me.RadioButton_walkin.Name = "RadioButton_walkin"
        Me.RadioButton_walkin.Size = New System.Drawing.Size(114, 23)
        Me.RadioButton_walkin.TabIndex = 111
        Me.RadioButton_walkin.TabStop = True
        Me.RadioButton_walkin.Text = "Walk In"
        Me.RadioButton_walkin.UseVisualStyleBackColor = True
        '
        'ButtonAdd
        '
        Me.ButtonAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ButtonAdd.Font = New System.Drawing.Font("Cooper Black", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAdd.ForeColor = System.Drawing.Color.Black
        Me.ButtonAdd.Location = New System.Drawing.Point(848, 190)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(138, 54)
        Me.ButtonAdd.TabIndex = 110
        Me.ButtonAdd.Text = "ADD"
        Me.ButtonAdd.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Castellar", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(348, 166)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(177, 19)
        Me.Label5.TabIndex = 109
        Me.Label5.Text = "Date of Billing"
        '
        'TxtBillno
        '
        Me.TxtBillno.Location = New System.Drawing.Point(162, 165)
        Me.TxtBillno.Name = "TxtBillno"
        Me.TxtBillno.Size = New System.Drawing.Size(121, 20)
        Me.TxtBillno.TabIndex = 108
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Castellar", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(569, 236)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 19)
        Me.Label4.TabIndex = 107
        Me.Label4.Text = "Quantity"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Castellar", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(23, 236)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 19)
        Me.Label3.TabIndex = 106
        Me.Label3.Text = "Item Code"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Castellar", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(53, 166)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 19)
        Me.Label2.TabIndex = 105
        Me.Label2.Text = "Bill No."
        '
        'MetroButton2
        '
        Me.MetroButton2.BackgroundImage = CType(resources.GetObject("MetroButton2.BackgroundImage"), System.Drawing.Image)
        Me.MetroButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.MetroButton2.Location = New System.Drawing.Point(1168, 23)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(37, 35)
        Me.MetroButton2.TabIndex = 103
        Me.MetroButton2.UseSelectable = True
        '
        'MetroButton1
        '
        Me.MetroButton1.BackgroundImage = CType(resources.GetObject("MetroButton1.BackgroundImage"), System.Drawing.Image)
        Me.MetroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.MetroButton1.Location = New System.Drawing.Point(1130, 23)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(32, 33)
        Me.MetroButton1.TabIndex = 102
        Me.MetroButton1.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.MetroButton1.UseCustomBackColor = True
        Me.MetroButton1.UseCustomForeColor = True
        Me.MetroButton1.UseSelectable = True
        Me.MetroButton1.UseStyleColors = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Castellar", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label1.Location = New System.Drawing.Point(493, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(235, 58)
        Me.Label1.TabIndex = 104
        Me.Label1.Text = "BILLING"
        '
        'ComboBoxItemCode
        '
        Me.ComboBoxItemCode.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.FULLMenuBindingSource, "Item_name", True))
        Me.ComboBoxItemCode.DataSource = Me.FULLMenuBindingSource
        Me.ComboBoxItemCode.DisplayMember = "Item_code"
        Me.ComboBoxItemCode.FormattingEnabled = True
        Me.ComboBoxItemCode.Location = New System.Drawing.Point(146, 235)
        Me.ComboBoxItemCode.Name = "ComboBoxItemCode"
        Me.ComboBoxItemCode.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxItemCode.TabIndex = 101
        Me.ComboBoxItemCode.ValueMember = "Item_code"
        '
        'TxtDob
        '
        Me.TxtDob.Location = New System.Drawing.Point(541, 164)
        Me.TxtDob.Name = "TxtDob"
        Me.TxtDob.Size = New System.Drawing.Size(155, 20)
        Me.TxtDob.TabIndex = 135
        '
        'txtItemName
        '
        Me.txtItemName.Location = New System.Drawing.Point(425, 235)
        Me.txtItemName.Multiline = True
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.Size = New System.Drawing.Size(138, 20)
        Me.txtItemName.TabIndex = 137
        '
        'ItemName
        '
        Me.ItemName.AutoSize = True
        Me.ItemName.Font = New System.Drawing.Font("Castellar", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemName.ForeColor = System.Drawing.Color.Black
        Me.ItemName.Location = New System.Drawing.Point(296, 237)
        Me.ItemName.Name = "ItemName"
        Me.ItemName.Size = New System.Drawing.Size(121, 19)
        Me.ItemName.TabIndex = 136
        Me.ItemName.Text = "Item Name"
        '
        'ProjectDataSet2
        '
        Me.ProjectDataSet2.DataSetName = "ProjectDataSet2"
        Me.ProjectDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FULLMenuBindingSource
        '
        Me.FULLMenuBindingSource.DataMember = "FULL_Menu"
        Me.FULLMenuBindingSource.DataSource = Me.ProjectDataSet2
        '
        'FULL_MenuTableAdapter
        '
        Me.FULL_MenuTableAdapter.ClearBeforeFill = True
        '
        'ItemcodeDataGridViewTextBoxColumn
        '
        Me.ItemcodeDataGridViewTextBoxColumn.DataPropertyName = "Item_code"
        Me.ItemcodeDataGridViewTextBoxColumn.HeaderText = "Item_code"
        Me.ItemcodeDataGridViewTextBoxColumn.Name = "ItemcodeDataGridViewTextBoxColumn"
        '
        'ItemnameDataGridViewTextBoxColumn
        '
        Me.ItemnameDataGridViewTextBoxColumn.DataPropertyName = "Item_name"
        Me.ItemnameDataGridViewTextBoxColumn.HeaderText = "Item_name"
        Me.ItemnameDataGridViewTextBoxColumn.Name = "ItemnameDataGridViewTextBoxColumn"
        '
        'CategoryDataGridViewTextBoxColumn
        '
        Me.CategoryDataGridViewTextBoxColumn.DataPropertyName = "Category"
        Me.CategoryDataGridViewTextBoxColumn.HeaderText = "Category"
        Me.CategoryDataGridViewTextBoxColumn.Name = "CategoryDataGridViewTextBoxColumn"
        '
        'DescriptionDataGridViewTextBoxColumn
        '
        Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "Price"
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "Price"
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        '
        'TaxDataGridViewTextBoxColumn
        '
        Me.TaxDataGridViewTextBoxColumn.DataPropertyName = "Tax"
        Me.TaxDataGridViewTextBoxColumn.HeaderText = "Tax"
        Me.TaxDataGridViewTextBoxColumn.Name = "TaxDataGridViewTextBoxColumn"
        '
        'TypeDataGridViewTextBoxColumn
        '
        Me.TypeDataGridViewTextBoxColumn.DataPropertyName = "Type"
        Me.TypeDataGridViewTextBoxColumn.HeaderText = "Type"
        Me.TypeDataGridViewTextBoxColumn.Name = "TypeDataGridViewTextBoxColumn"
        '
        'Billing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1314, 718)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtItemName)
        Me.Controls.Add(Me.ItemName)
        Me.Controls.Add(Me.TxtDob)
        Me.Controls.Add(Me.InvoiceNo1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TxtPrice)
        Me.Controls.Add(Me.TxtVAT)
        Me.Controls.Add(Me.TxtDiscount)
        Me.Controls.Add(Me.TxtPayableAmount)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Payable_amount)
        Me.Controls.Add(Me.discount)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.quantitytxtbox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.OrNo1)
        Me.Controls.Add(Me.DateAddedLabel1)
        Me.Controls.Add(Me.ButtonRemove)
        Me.Controls.Add(Me.Buttoncheckout)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.RadioButton_homedelivery)
        Me.Controls.Add(Me.RadioButton_walkin)
        Me.Controls.Add(Me.ButtonAdd)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtBillno)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MetroButton2)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBoxItemCode)
        Me.Name = "Billing"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProjectDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FULLMenuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents InvoiceNo1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TxtPrice As TextBox
    Friend WithEvents TxtVAT As TextBox
    Friend WithEvents TxtDiscount As TextBox
    Friend WithEvents TxtPayableAmount As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Payable_amount As Label
    Friend WithEvents discount As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label10 As Label
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents quantitytxtbox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents OrNo1 As Label
    Friend WithEvents DateAddedLabel1 As Label
    Friend WithEvents ButtonRemove As Button
    Friend WithEvents Buttoncheckout As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents RadioButton_homedelivery As RadioButton
    Friend WithEvents RadioButton_walkin As RadioButton
    Friend WithEvents ButtonAdd As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtBillno As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBoxItemCode As ComboBox
    Friend WithEvents TxtDob As TextBox
    Friend WithEvents txtItemName As TextBox
    Friend WithEvents ItemName As Label
    Friend WithEvents ProjectDataSet2 As ProjectDataSet2
    Friend WithEvents FULLMenuBindingSource As BindingSource
    Friend WithEvents FULL_MenuTableAdapter As ProjectDataSet2TableAdapters.FULL_MenuTableAdapter
    Friend WithEvents ItemcodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CategoryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TaxDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
