﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchItem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SearchItem))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtSearch = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GO_BTN = New MetroFramework.Controls.MetroButton()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Castellar", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label1.Location = New System.Drawing.Point(297, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(380, 58)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Search Item"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Castellar", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(7, 148)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(394, 25)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Enter Item To Be Searched :"
        '
        'TxtSearch
        '
        Me.TxtSearch.Location = New System.Drawing.Point(435, 155)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.Size = New System.Drawing.Size(118, 20)
        Me.TxtSearch.TabIndex = 41
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(741, 269)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(311, 230)
        Me.PictureBox1.TabIndex = 51
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(855, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(36, 33)
        Me.PictureBox2.TabIndex = 55
        Me.PictureBox2.TabStop = False
        '
        'MetroButton2
        '
        Me.MetroButton2.BackgroundImage = CType(resources.GetObject("MetroButton2.BackgroundImage"), System.Drawing.Image)
        Me.MetroButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.MetroButton2.Location = New System.Drawing.Point(935, 10)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(37, 35)
        Me.MetroButton2.TabIndex = 54
        Me.MetroButton2.UseSelectable = True
        '
        'MetroButton1
        '
        Me.MetroButton1.BackgroundImage = CType(resources.GetObject("MetroButton1.BackgroundImage"), System.Drawing.Image)
        Me.MetroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.MetroButton1.Location = New System.Drawing.Point(897, 12)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(32, 33)
        Me.MetroButton1.TabIndex = 53
        Me.MetroButton1.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.MetroButton1.UseCustomBackColor = True
        Me.MetroButton1.UseCustomForeColor = True
        Me.MetroButton1.UseSelectable = True
        Me.MetroButton1.UseStyleColors = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(1, 20)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(97, 25)
        Me.Label10.TabIndex = 58
        Me.Label10.Text = "Label10"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridView1.Location = New System.Drawing.Point(12, 214)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(723, 344)
        Me.DataGridView1.TabIndex = 59
        '
        'GO_BTN
        '
        Me.GO_BTN.BackColor = System.Drawing.Color.Silver
        Me.GO_BTN.DisplayFocus = True
        Me.GO_BTN.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.GO_BTN.Location = New System.Drawing.Point(600, 148)
        Me.GO_BTN.Name = "GO_BTN"
        Me.GO_BTN.Size = New System.Drawing.Size(102, 44)
        Me.GO_BTN.TabIndex = 67
        Me.GO_BTN.Text = "GO...!!"
        Me.GO_BTN.UseCustomBackColor = True
        Me.GO_BTN.UseCustomForeColor = True
        Me.GO_BTN.UseSelectable = True
        Me.GO_BTN.UseStyleColors = True
        '
        'SearchItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(1075, 581)
        Me.Controls.Add(Me.GO_BTN)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.MetroButton2)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TxtSearch)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "SearchItem"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtSearch As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents Label10 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GO_BTN As MetroFramework.Controls.MetroButton
End Class
