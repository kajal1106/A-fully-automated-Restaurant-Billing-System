<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditItem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditItem))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ComboType = New System.Windows.Forms.ComboBox()
        Me.ComboTax = New System.Windows.Forms.ComboBox()
        Me.ComboCategory = New System.Windows.Forms.ComboBox()
        Me.TxtPrice = New System.Windows.Forms.TextBox()
        Me.TxtDescription = New System.Windows.Forms.TextBox()
        Me.TxtItemName = New System.Windows.Forms.TextBox()
        Me.TxtItemCode = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Btn_search = New System.Windows.Forms.Button()
        Me.Btn_save = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ProjectDataSet12 = New WindowsApp1.ProjectDataSet12()
        Me.FULLMenuBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FULL_MenuTableAdapter = New WindowsApp1.ProjectDataSet12TableAdapters.FULL_MenuTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProjectDataSet12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FULLMenuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Label10.Location = New System.Drawing.Point(12, 26)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(97, 25)
        Me.Label10.TabIndex = 77
        Me.Label10.Text = "Label10"
        '
        'ButtonAdd
        '
        Me.ButtonAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ButtonAdd.Font = New System.Drawing.Font("Castellar", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAdd.ForeColor = System.Drawing.Color.Black
        Me.ButtonAdd.Location = New System.Drawing.Point(207, 584)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(146, 59)
        Me.ButtonAdd.TabIndex = 76
        Me.ButtonAdd.Text = "Edit"
        Me.ButtonAdd.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(978, 18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(36, 33)
        Me.PictureBox1.TabIndex = 75
        Me.PictureBox1.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Castellar", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(536, 437)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(33, 25)
        Me.Label9.TabIndex = 74
        Me.Label9.Text = "%"
        '
        'ComboType
        '
        Me.ComboType.FormattingEnabled = True
        Me.ComboType.Items.AddRange(New Object() {"Veg", "NonVeg"})
        Me.ComboType.Location = New System.Drawing.Point(392, 503)
        Me.ComboType.Name = "ComboType"
        Me.ComboType.Size = New System.Drawing.Size(138, 21)
        Me.ComboType.TabIndex = 73
        '
        'ComboTax
        '
        Me.ComboTax.FormattingEnabled = True
        Me.ComboTax.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.ComboTax.Location = New System.Drawing.Point(392, 437)
        Me.ComboTax.Name = "ComboTax"
        Me.ComboTax.Size = New System.Drawing.Size(138, 21)
        Me.ComboTax.TabIndex = 72
        '
        'ComboCategory
        '
        Me.ComboCategory.FormattingEnabled = True
        Me.ComboCategory.Items.AddRange(New Object() {"Chinese", "Indian", "Intercontinental"})
        Me.ComboCategory.Location = New System.Drawing.Point(390, 268)
        Me.ComboCategory.Name = "ComboCategory"
        Me.ComboCategory.Size = New System.Drawing.Size(133, 21)
        Me.ComboCategory.TabIndex = 71
        '
        'TxtPrice
        '
        Me.TxtPrice.Location = New System.Drawing.Point(390, 389)
        Me.TxtPrice.Name = "TxtPrice"
        Me.TxtPrice.Size = New System.Drawing.Size(137, 20)
        Me.TxtPrice.TabIndex = 70
        '
        'TxtDescription
        '
        Me.TxtDescription.Location = New System.Drawing.Point(390, 330)
        Me.TxtDescription.Name = "TxtDescription"
        Me.TxtDescription.Size = New System.Drawing.Size(137, 20)
        Me.TxtDescription.TabIndex = 69
        '
        'TxtItemName
        '
        Me.TxtItemName.Location = New System.Drawing.Point(389, 209)
        Me.TxtItemName.Name = "TxtItemName"
        Me.TxtItemName.Size = New System.Drawing.Size(134, 20)
        Me.TxtItemName.TabIndex = 68
        '
        'TxtItemCode
        '
        Me.TxtItemCode.Location = New System.Drawing.Point(389, 157)
        Me.TxtItemCode.Name = "TxtItemCode"
        Me.TxtItemCode.Size = New System.Drawing.Size(134, 20)
        Me.TxtItemCode.TabIndex = 67
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Castellar", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(178, 503)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 25)
        Me.Label8.TabIndex = 66
        Me.Label8.Text = "Type*"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Castellar", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(178, 437)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 25)
        Me.Label7.TabIndex = 65
        Me.Label7.Text = "Tax *"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Castellar", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(178, 384)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 25)
        Me.Label6.TabIndex = 64
        Me.Label6.Text = "Price *"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Castellar", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(178, 325)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(195, 25)
        Me.Label5.TabIndex = 63
        Me.Label5.Text = "Description *"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Castellar", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(178, 264)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(158, 25)
        Me.Label4.TabIndex = 62
        Me.Label4.Text = "Category*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Castellar", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(178, 210)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(175, 25)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "Item Name *"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Castellar", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(178, 157)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(169, 25)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "Item Code *"
        '
        'MetroButton2
        '
        Me.MetroButton2.BackgroundImage = CType(resources.GetObject("MetroButton2.BackgroundImage"), System.Drawing.Image)
        Me.MetroButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.MetroButton2.Location = New System.Drawing.Point(1058, 16)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(37, 35)
        Me.MetroButton2.TabIndex = 59
        Me.MetroButton2.UseSelectable = True
        '
        'MetroButton1
        '
        Me.MetroButton1.BackgroundImage = CType(resources.GetObject("MetroButton1.BackgroundImage"), System.Drawing.Image)
        Me.MetroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.MetroButton1.Location = New System.Drawing.Point(1020, 18)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(32, 33)
        Me.MetroButton1.TabIndex = 58
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
        Me.Label1.Location = New System.Drawing.Point(347, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(319, 58)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Edit Items"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Castellar", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(584, 169)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(468, 25)
        Me.Label11.TabIndex = 78
        Me.Label11.Text = "Enter Item Name to be searched:"
        '
        'Btn_search
        '
        Me.Btn_search.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Btn_search.Font = New System.Drawing.Font("Castellar", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_search.ForeColor = System.Drawing.Color.Black
        Me.Btn_search.Location = New System.Drawing.Point(695, 209)
        Me.Btn_search.Name = "Btn_search"
        Me.Btn_search.Size = New System.Drawing.Size(146, 59)
        Me.Btn_search.TabIndex = 80
        Me.Btn_search.Text = "Search"
        Me.Btn_search.UseVisualStyleBackColor = False
        '
        'Btn_save
        '
        Me.Btn_save.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Btn_save.Font = New System.Drawing.Font("Castellar", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_save.ForeColor = System.Drawing.Color.Black
        Me.Btn_save.Location = New System.Drawing.Point(423, 584)
        Me.Btn_save.Name = "Btn_save"
        Me.Btn_save.Size = New System.Drawing.Size(146, 59)
        Me.Btn_save.TabIndex = 81
        Me.Btn_save.Text = "Save"
        Me.Btn_save.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Castellar", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Location = New System.Drawing.Point(620, 584)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(146, 59)
        Me.Button3.TabIndex = 82
        Me.Button3.Text = "delete"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'ProjectDataSet12
        '
        Me.ProjectDataSet12.DataSetName = "ProjectDataSet12"
        Me.ProjectDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FULLMenuBindingSource
        '
        Me.FULLMenuBindingSource.DataMember = "FULL_Menu"
        Me.FULLMenuBindingSource.DataSource = Me.ProjectDataSet12
        '
        'FULL_MenuTableAdapter
        '
        Me.FULL_MenuTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(664, 296)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(270, 232)
        Me.Button1.TabIndex = 83
        Me.Button1.UseVisualStyleBackColor = False
        '
        'EditItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1103, 648)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Btn_save)
        Me.Controls.Add(Me.Btn_search)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.ButtonAdd)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.ComboType)
        Me.Controls.Add(Me.ComboTax)
        Me.Controls.Add(Me.ComboCategory)
        Me.Controls.Add(Me.TxtPrice)
        Me.Controls.Add(Me.TxtDescription)
        Me.Controls.Add(Me.TxtItemName)
        Me.Controls.Add(Me.TxtItemCode)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MetroButton2)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "EditItem"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProjectDataSet12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FULLMenuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label10 As Label
    Friend WithEvents ButtonAdd As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents ComboType As ComboBox
    Friend WithEvents ComboTax As ComboBox
    Friend WithEvents ComboCategory As ComboBox
    Friend WithEvents TxtPrice As TextBox
    Friend WithEvents TxtDescription As TextBox
    Friend WithEvents TxtItemName As TextBox
    Friend WithEvents TxtItemCode As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Btn_search As Button
    Friend WithEvents Btn_save As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents ProjectDataSet12 As ProjectDataSet12
    Friend WithEvents FULLMenuBindingSource As BindingSource
    Friend WithEvents FULL_MenuTableAdapter As ProjectDataSet12TableAdapters.FULL_MenuTableAdapter
    Friend WithEvents Button1 As Button
End Class
