<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home_delivery
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home_delivery))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.GO_BTN = New MetroFramework.Controls.MetroButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ProjectDataSet3 = New WindowsApp1.ProjectDataSet3()
        Me.HomeDeliveryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HomeDeliveryTableAdapter = New WindowsApp1.ProjectDataSet3TableAdapters.HomeDeliveryTableAdapter()
        Me.HomedeliveryIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateOfBillingDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalVATDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmtpayableDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProjectDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HomeDeliveryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1038, 17)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(42, 36)
        Me.PictureBox1.TabIndex = 61
        Me.PictureBox1.TabStop = False
        '
        'MetroButton2
        '
        Me.MetroButton2.BackgroundImage = CType(resources.GetObject("MetroButton2.BackgroundImage"), System.Drawing.Image)
        Me.MetroButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.MetroButton2.Location = New System.Drawing.Point(1129, 17)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(43, 36)
        Me.MetroButton2.TabIndex = 60
        Me.MetroButton2.UseSelectable = True
        '
        'MetroButton1
        '
        Me.MetroButton1.BackgroundImage = CType(resources.GetObject("MetroButton1.BackgroundImage"), System.Drawing.Image)
        Me.MetroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.MetroButton1.Location = New System.Drawing.Point(1086, 17)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(37, 36)
        Me.MetroButton1.TabIndex = 59
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
        Me.Label1.Location = New System.Drawing.Point(310, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(466, 58)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "HOME DELIVERY"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Castellar", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(-8, 164)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(436, 25)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = "Enter Date Of Home Delivery :"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(453, 164)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(174, 23)
        Me.DateTimePicker1.TabIndex = 64
        '
        'GO_BTN
        '
        Me.GO_BTN.BackColor = System.Drawing.Color.Silver
        Me.GO_BTN.DisplayFocus = True
        Me.GO_BTN.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.GO_BTN.Location = New System.Drawing.Point(663, 145)
        Me.GO_BTN.Name = "GO_BTN"
        Me.GO_BTN.Size = New System.Drawing.Size(102, 44)
        Me.GO_BTN.TabIndex = 66
        Me.GO_BTN.Text = "GO...!!"
        Me.GO_BTN.UseCustomBackColor = True
        Me.GO_BTN.UseCustomForeColor = True
        Me.GO_BTN.UseSelectable = True
        Me.GO_BTN.UseStyleColors = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.HomedeliveryIDDataGridViewTextBoxColumn, Me.CustnameDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.PhoneDataGridViewTextBoxColumn, Me.DateOfBillingDataGridViewTextBoxColumn, Me.TotalVATDataGridViewTextBoxColumn, Me.AmtpayableDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.HomeDeliveryBindingSource
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridView1.Location = New System.Drawing.Point(42, 229)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(742, 427)
        Me.DataGridView1.TabIndex = 67
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.InitialImage = CType(resources.GetObject("PictureBox2.InitialImage"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(806, 109)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(448, 655)
        Me.PictureBox2.TabIndex = 68
        Me.PictureBox2.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Lucida Bright", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(26, 41)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(107, 27)
        Me.Label10.TabIndex = 69
        Me.Label10.Text = "Label10"
        '
        'ProjectDataSet3
        '
        Me.ProjectDataSet3.DataSetName = "ProjectDataSet3"
        Me.ProjectDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HomeDeliveryBindingSource
        '
        Me.HomeDeliveryBindingSource.DataMember = "HomeDelivery"
        Me.HomeDeliveryBindingSource.DataSource = Me.ProjectDataSet3
        '
        'HomeDeliveryTableAdapter
        '
        Me.HomeDeliveryTableAdapter.ClearBeforeFill = True
        '
        'HomedeliveryIDDataGridViewTextBoxColumn
        '
        Me.HomedeliveryIDDataGridViewTextBoxColumn.DataPropertyName = "homedeliveryID"
        Me.HomedeliveryIDDataGridViewTextBoxColumn.HeaderText = "homedeliveryID"
        Me.HomedeliveryIDDataGridViewTextBoxColumn.Name = "HomedeliveryIDDataGridViewTextBoxColumn"
        '
        'CustnameDataGridViewTextBoxColumn
        '
        Me.CustnameDataGridViewTextBoxColumn.DataPropertyName = "cust_name"
        Me.CustnameDataGridViewTextBoxColumn.HeaderText = "cust_name"
        Me.CustnameDataGridViewTextBoxColumn.Name = "CustnameDataGridViewTextBoxColumn"
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        '
        'PhoneDataGridViewTextBoxColumn
        '
        Me.PhoneDataGridViewTextBoxColumn.DataPropertyName = "Phone"
        Me.PhoneDataGridViewTextBoxColumn.HeaderText = "Phone"
        Me.PhoneDataGridViewTextBoxColumn.Name = "PhoneDataGridViewTextBoxColumn"
        '
        'DateOfBillingDataGridViewTextBoxColumn
        '
        Me.DateOfBillingDataGridViewTextBoxColumn.DataPropertyName = "DateOfBilling"
        Me.DateOfBillingDataGridViewTextBoxColumn.HeaderText = "DateOfBilling"
        Me.DateOfBillingDataGridViewTextBoxColumn.Name = "DateOfBillingDataGridViewTextBoxColumn"
        '
        'TotalVATDataGridViewTextBoxColumn
        '
        Me.TotalVATDataGridViewTextBoxColumn.DataPropertyName = "Total VAT"
        Me.TotalVATDataGridViewTextBoxColumn.HeaderText = "Total VAT"
        Me.TotalVATDataGridViewTextBoxColumn.Name = "TotalVATDataGridViewTextBoxColumn"
        '
        'AmtpayableDataGridViewTextBoxColumn
        '
        Me.AmtpayableDataGridViewTextBoxColumn.DataPropertyName = "Amt_payable"
        Me.AmtpayableDataGridViewTextBoxColumn.HeaderText = "Amt_payable"
        Me.AmtpayableDataGridViewTextBoxColumn.Name = "AmtpayableDataGridViewTextBoxColumn"
        '
        'Home_delivery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1280, 769)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GO_BTN)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MetroButton2)
        Me.Controls.Add(Me.MetroButton1)
        Me.Font = New System.Drawing.Font("Modern No. 20", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Home_delivery"
        Me.Padding = New System.Windows.Forms.Padding(23, 65, 23, 22)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProjectDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HomeDeliveryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents GO_BTN As MetroFramework.Controls.MetroButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents ProjectDataSet3 As ProjectDataSet3
    Friend WithEvents HomeDeliveryBindingSource As BindingSource
    Friend WithEvents HomeDeliveryTableAdapter As ProjectDataSet3TableAdapters.HomeDeliveryTableAdapter
    Friend WithEvents HomedeliveryIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateOfBillingDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalVATDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AmtpayableDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
