<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Sales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sales))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BillnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateofbillingDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiscountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmtpayableDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BillingBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProjectDataSet16 = New WindowsApp1.ProjectDataSet16()
        Me.GO_BTN = New MetroFramework.Controls.MetroButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.total_sales = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.BillingBindingSource = New System.Windows.Forms.BindingSource(Me.components)

        Me.SalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BillingTableAdapter1 = New WindowsApp1.ProjectDataSet16TableAdapters.BillingTableAdapter()
        Me.TxtDob = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BillingBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProjectDataSet16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BillingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BillnoDataGridViewTextBoxColumn, Me.DateofbillingDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn, Me.VatDataGridViewTextBoxColumn, Me.DiscountDataGridViewTextBoxColumn, Me.AmtpayableDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BillingBindingSource1
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridView1.Location = New System.Drawing.Point(40, 223)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(641, 314)
        Me.DataGridView1.TabIndex = 73
        '
        'BillnoDataGridViewTextBoxColumn
        '
        Me.BillnoDataGridViewTextBoxColumn.DataPropertyName = "Bill_no"
        Me.BillnoDataGridViewTextBoxColumn.HeaderText = "Bill_no"
        Me.BillnoDataGridViewTextBoxColumn.Name = "BillnoDataGridViewTextBoxColumn"
        '
        'DateofbillingDataGridViewTextBoxColumn
        '
        Me.DateofbillingDataGridViewTextBoxColumn.DataPropertyName = "dateofbilling"
        Me.DateofbillingDataGridViewTextBoxColumn.HeaderText = "dateofbilling"
        Me.DateofbillingDataGridViewTextBoxColumn.Name = "DateofbillingDataGridViewTextBoxColumn"
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "Price"
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "Price"
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        '
        'VatDataGridViewTextBoxColumn
        '
        Me.VatDataGridViewTextBoxColumn.DataPropertyName = "Vat"
        Me.VatDataGridViewTextBoxColumn.HeaderText = "Vat"
        Me.VatDataGridViewTextBoxColumn.Name = "VatDataGridViewTextBoxColumn"
        '
        'DiscountDataGridViewTextBoxColumn
        '
        Me.DiscountDataGridViewTextBoxColumn.DataPropertyName = "Discount"
        Me.DiscountDataGridViewTextBoxColumn.HeaderText = "Discount"
        Me.DiscountDataGridViewTextBoxColumn.Name = "DiscountDataGridViewTextBoxColumn"
        '
        'AmtpayableDataGridViewTextBoxColumn
        '
        Me.AmtpayableDataGridViewTextBoxColumn.DataPropertyName = "Amt_payable"
        Me.AmtpayableDataGridViewTextBoxColumn.HeaderText = "Amt_payable"
        Me.AmtpayableDataGridViewTextBoxColumn.Name = "AmtpayableDataGridViewTextBoxColumn"
        '
        'BillingBindingSource1
        '
        Me.BillingBindingSource1.DataMember = "Billing"
        Me.BillingBindingSource1.DataSource = Me.ProjectDataSet16
        '
        'ProjectDataSet16
        '
        Me.ProjectDataSet16.DataSetName = "ProjectDataSet16"
        Me.ProjectDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GO_BTN
        '
        Me.GO_BTN.BackColor = System.Drawing.Color.Silver
        Me.GO_BTN.DisplayFocus = True
        Me.GO_BTN.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.GO_BTN.Location = New System.Drawing.Point(597, 150)
        Me.GO_BTN.Name = "GO_BTN"
        Me.GO_BTN.Size = New System.Drawing.Size(102, 44)
        Me.GO_BTN.TabIndex = 72
        Me.GO_BTN.Text = "GO...!!"
        Me.GO_BTN.UseCustomBackColor = True
        Me.GO_BTN.UseCustomForeColor = True
        Me.GO_BTN.UseSelectable = True
        Me.GO_BTN.UseStyleColors = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Castellar", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(36, 159)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(374, 25)
        Me.Label2.TabIndex = 70
        Me.Label2.Text = "Enter Date To View Sales :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Castellar", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label1.Location = New System.Drawing.Point(431, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 58)
        Me.Label1.TabIndex = 69
        Me.Label1.Text = "sales"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Lucida Bright", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(13, 38)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(107, 27)
        Me.Label10.TabIndex = 68
        Me.Label10.Text = "Label10"
        '
        'Timer1
        '
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.InitialImage = CType(resources.GetObject("PictureBox2.InitialImage"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(737, 94)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(448, 425)
        Me.PictureBox2.TabIndex = 74
        Me.PictureBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Castellar", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(402, 606)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(186, 25)
        Me.Label3.TabIndex = 75
        Me.Label3.Text = "Total Sales :"
        '
        'total_sales
        '
        Me.total_sales.Location = New System.Drawing.Point(612, 606)
        Me.total_sales.Name = "total_sales"
        Me.total_sales.Size = New System.Drawing.Size(142, 20)
        Me.total_sales.TabIndex = 76
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1125, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(36, 35)
        Me.PictureBox1.TabIndex = 80
        Me.PictureBox1.TabStop = False
        '
        'MetroButton2
        '
        Me.MetroButton2.BackgroundImage = CType(resources.GetObject("MetroButton2.BackgroundImage"), System.Drawing.Image)
        Me.MetroButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.MetroButton2.Location = New System.Drawing.Point(1205, 12)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(37, 35)
        Me.MetroButton2.TabIndex = 79
        Me.MetroButton2.UseSelectable = True
        '
        'MetroButton1
        '
        Me.MetroButton1.BackgroundImage = CType(resources.GetObject("MetroButton1.BackgroundImage"), System.Drawing.Image)
        Me.MetroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.MetroButton1.Location = New System.Drawing.Point(1167, 12)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(32, 33)
        Me.MetroButton1.TabIndex = 78
        Me.MetroButton1.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.MetroButton1.UseCustomBackColor = True
        Me.MetroButton1.UseCustomForeColor = True
        Me.MetroButton1.UseSelectable = True
        Me.MetroButton1.UseStyleColors = True
        '
        'SalesTableAdapter
        '

        '
        'BillingTableAdapter
        '

        '
        'BillingTableAdapter1
        '
        Me.BillingTableAdapter1.ClearBeforeFill = True
        '
        'TxtDob
        '
        Me.TxtDob.Location = New System.Drawing.Point(416, 159)
        Me.TxtDob.Name = "TxtDob"
        Me.TxtDob.Size = New System.Drawing.Size(155, 20)
        Me.TxtDob.TabIndex = 136
        '
        'Sales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1276, 687)
        Me.ControlBox = False
        Me.Controls.Add(Me.TxtDob)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MetroButton2)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.total_sales)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GO_BTN)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label10)
        Me.Name = "Sales"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BillingBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProjectDataSet16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BillingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GO_BTN As MetroFramework.Controls.MetroButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents total_sales As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents SalesBindingSource As BindingSource

    Friend WithEvents BillingBindingSource As BindingSource

    Friend WithEvents ProjectDataSet16 As ProjectDataSet16
    Friend WithEvents BillingBindingSource1 As BindingSource
    Friend WithEvents BillingTableAdapter1 As ProjectDataSet16TableAdapters.BillingTableAdapter
    Friend WithEvents BillnoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateofbillingDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VatDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiscountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AmtpayableDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TxtDob As TextBox
End Class
