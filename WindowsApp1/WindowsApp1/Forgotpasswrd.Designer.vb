<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Forgotpasswrd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Forgotpasswrd))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.Btnchange = New System.Windows.Forms.Button()
        Me.txtNewPassword = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.txtConfirmPassword = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.UsernameTextBox = New MetroFramework.Controls.MetroTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(806, 15)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(36, 35)
        Me.PictureBox2.TabIndex = 142
        Me.PictureBox2.TabStop = False
        '
        'MetroButton2
        '
        Me.MetroButton2.BackgroundImage = CType(resources.GetObject("MetroButton2.BackgroundImage"), System.Drawing.Image)
        Me.MetroButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.MetroButton2.Location = New System.Drawing.Point(886, 15)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(37, 35)
        Me.MetroButton2.TabIndex = 141
        Me.MetroButton2.UseSelectable = True
        '
        'MetroButton1
        '
        Me.MetroButton1.BackgroundImage = CType(resources.GetObject("MetroButton1.BackgroundImage"), System.Drawing.Image)
        Me.MetroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.MetroButton1.Location = New System.Drawing.Point(848, 15)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(32, 33)
        Me.MetroButton1.TabIndex = 140
        Me.MetroButton1.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.MetroButton1.UseCustomBackColor = True
        Me.MetroButton1.UseCustomForeColor = True
        Me.MetroButton1.UseSelectable = True
        Me.MetroButton1.UseStyleColors = True
        '
        'Btnchange
        '
        Me.Btnchange.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Btnchange.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnchange.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Btnchange.Location = New System.Drawing.Point(545, 479)
        Me.Btnchange.Name = "Btnchange"
        Me.Btnchange.Size = New System.Drawing.Size(143, 45)
        Me.Btnchange.TabIndex = 139
        Me.Btnchange.Text = "&CHANGE"
        Me.Btnchange.UseVisualStyleBackColor = False
        '
        'txtNewPassword
        '
        '
        '
        '
        Me.txtNewPassword.CustomButton.Image = Nothing
        Me.txtNewPassword.CustomButton.Location = New System.Drawing.Point(225, 1)
        Me.txtNewPassword.CustomButton.Name = ""
        Me.txtNewPassword.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtNewPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNewPassword.CustomButton.TabIndex = 1
        Me.txtNewPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNewPassword.CustomButton.UseSelectable = True
        Me.txtNewPassword.CustomButton.Visible = False
        Me.txtNewPassword.Lines = New String(-1) {}
        Me.txtNewPassword.Location = New System.Drawing.Point(527, 294)
        Me.txtNewPassword.MaxLength = 32767
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtNewPassword.PromptText = "*****"
        Me.txtNewPassword.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNewPassword.SelectedText = ""
        Me.txtNewPassword.SelectionLength = 0
        Me.txtNewPassword.SelectionStart = 0
        Me.txtNewPassword.ShortcutsEnabled = True
        Me.txtNewPassword.Size = New System.Drawing.Size(247, 23)
        Me.txtNewPassword.TabIndex = 138
        Me.txtNewPassword.UseCustomBackColor = True
        Me.txtNewPassword.UseCustomForeColor = True
        Me.txtNewPassword.UseSelectable = True
        Me.txtNewPassword.UseStyleColors = True
        Me.txtNewPassword.UseSystemPasswordChar = True
        Me.txtNewPassword.WaterMark = "*****"
        Me.txtNewPassword.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNewPassword.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel2.ForeColor = System.Drawing.Color.Gray
        Me.MetroLabel2.Location = New System.Drawing.Point(527, 266)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(209, 25)
        Me.MetroLabel2.TabIndex = 137
        Me.MetroLabel2.Text = "Enter &NEW PASSWORD"
        Me.MetroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MetroLabel2.UseCustomBackColor = True
        Me.MetroLabel2.UseCustomForeColor = True
        Me.MetroLabel2.UseStyleColors = True
        Me.MetroLabel2.WrapToLine = True
        '
        'txtConfirmPassword
        '
        '
        '
        '
        Me.txtConfirmPassword.CustomButton.Image = Nothing
        Me.txtConfirmPassword.CustomButton.Location = New System.Drawing.Point(225, 1)
        Me.txtConfirmPassword.CustomButton.Name = ""
        Me.txtConfirmPassword.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtConfirmPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtConfirmPassword.CustomButton.TabIndex = 1
        Me.txtConfirmPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtConfirmPassword.CustomButton.UseSelectable = True
        Me.txtConfirmPassword.CustomButton.Visible = False
        Me.txtConfirmPassword.Lines = New String(-1) {}
        Me.txtConfirmPassword.Location = New System.Drawing.Point(527, 392)
        Me.txtConfirmPassword.MaxLength = 32767
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtConfirmPassword.PromptText = "*****"
        Me.txtConfirmPassword.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtConfirmPassword.SelectedText = ""
        Me.txtConfirmPassword.SelectionLength = 0
        Me.txtConfirmPassword.SelectionStart = 0
        Me.txtConfirmPassword.ShortcutsEnabled = True
        Me.txtConfirmPassword.Size = New System.Drawing.Size(247, 23)
        Me.txtConfirmPassword.TabIndex = 136
        Me.txtConfirmPassword.UseCustomBackColor = True
        Me.txtConfirmPassword.UseCustomForeColor = True
        Me.txtConfirmPassword.UseSelectable = True
        Me.txtConfirmPassword.UseStyleColors = True
        Me.txtConfirmPassword.UseSystemPasswordChar = True
        Me.txtConfirmPassword.WaterMark = "*****"
        Me.txtConfirmPassword.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtConfirmPassword.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel3.ForeColor = System.Drawing.Color.Gray
        Me.MetroLabel3.Location = New System.Drawing.Point(527, 364)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(247, 25)
        Me.MetroLabel3.TabIndex = 135
        Me.MetroLabel3.Text = "&CONFIRM NEW PASSWORD"
        Me.MetroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MetroLabel3.UseCustomBackColor = True
        Me.MetroLabel3.UseCustomForeColor = True
        Me.MetroLabel3.UseStyleColors = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel1.ForeColor = System.Drawing.Color.Gray
        Me.MetroLabel1.Location = New System.Drawing.Point(527, 179)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(161, 25)
        Me.MetroLabel1.TabIndex = 134
        Me.MetroLabel1.Text = "Enter &USERNAME"
        Me.MetroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MetroLabel1.UseCustomBackColor = True
        Me.MetroLabel1.UseCustomForeColor = True
        Me.MetroLabel1.UseStyleColors = True
        Me.MetroLabel1.WrapToLine = True
        '
        'UsernameTextBox
        '
        '
        '
        '
        Me.UsernameTextBox.CustomButton.Image = Nothing
        Me.UsernameTextBox.CustomButton.Location = New System.Drawing.Point(225, 1)
        Me.UsernameTextBox.CustomButton.Name = ""
        Me.UsernameTextBox.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.UsernameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.UsernameTextBox.CustomButton.TabIndex = 1
        Me.UsernameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.UsernameTextBox.CustomButton.UseSelectable = True
        Me.UsernameTextBox.CustomButton.Visible = False
        Me.UsernameTextBox.Lines = New String(-1) {}
        Me.UsernameTextBox.Location = New System.Drawing.Point(527, 207)
        Me.UsernameTextBox.MaxLength = 32767
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UsernameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.UsernameTextBox.SelectedText = ""
        Me.UsernameTextBox.SelectionLength = 0
        Me.UsernameTextBox.SelectionStart = 0
        Me.UsernameTextBox.ShortcutsEnabled = True
        Me.UsernameTextBox.Size = New System.Drawing.Size(247, 23)
        Me.UsernameTextBox.TabIndex = 131
        Me.UsernameTextBox.UseSelectable = True
        Me.UsernameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.UsernameTextBox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Castellar", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label1.Location = New System.Drawing.Point(188, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(560, 58)
        Me.Label1.TabIndex = 130
        Me.Label1.Text = "CHANGE PASSWORD"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(52, 176)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(409, 318)
        Me.PictureBox1.TabIndex = 129
        Me.PictureBox1.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Lucida Bright", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(23, 23)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(107, 27)
        Me.Label10.TabIndex = 143
        Me.Label10.Text = "Label10"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Forgotpasswrd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(944, 584)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.MetroButton2)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.Btnchange)
        Me.Controls.Add(Me.txtNewPassword)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.txtConfirmPassword)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Forgotpasswrd"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents Btnchange As Button
    Friend WithEvents txtNewPassword As MetroFramework.Controls.MetroTextBox
    Protected Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtConfirmPassword As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Protected Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents UsernameTextBox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Timer1 As Timer
End Class
