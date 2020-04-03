<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Signup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Signup))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.PasswordTextBox = New MetroFramework.Controls.MetroTextBox()
        Me.MetroPasswordLabel = New MetroFramework.Controls.MetroLabel()
        Me.UsernameTextBox = New MetroFramework.Controls.MetroTextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MetroButton3 = New MetroFramework.Controls.MetroButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LogoPictureBox)
        Me.GroupBox1.Controls.Add(Me.MetroButton2)
        Me.GroupBox1.Controls.Add(Me.MetroButton1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(9, 102)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(555, 252)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SIGNUP"
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), System.Drawing.Image)
        Me.LogoPictureBox.Location = New System.Drawing.Point(14, 56)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(160, 162)
        Me.LogoPictureBox.TabIndex = 61
        Me.LogoPictureBox.TabStop = False
        '
        'MetroButton2
        '
        Me.MetroButton2.BackColor = System.Drawing.Color.Gray
        Me.MetroButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.MetroButton2.DisplayFocus = True
        Me.MetroButton2.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.MetroButton2.ForeColor = System.Drawing.Color.White
        Me.MetroButton2.Highlight = True
        Me.MetroButton2.Location = New System.Drawing.Point(366, 217)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(100, 29)
        Me.MetroButton2.TabIndex = 66
        Me.MetroButton2.Text = "CANCEL"
        Me.MetroButton2.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroButton2.UseCustomBackColor = True
        Me.MetroButton2.UseCustomForeColor = True
        Me.MetroButton2.UseSelectable = True
        Me.MetroButton2.UseStyleColors = True
        '
        'MetroButton1
        '
        Me.MetroButton1.BackColor = System.Drawing.Color.Gray
        Me.MetroButton1.DisplayFocus = True
        Me.MetroButton1.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.MetroButton1.ForeColor = System.Drawing.Color.White
        Me.MetroButton1.Highlight = True
        Me.MetroButton1.Location = New System.Drawing.Point(215, 217)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(111, 29)
        Me.MetroButton1.TabIndex = 65
        Me.MetroButton1.Text = "OK"
        Me.MetroButton1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroButton1.UseCustomBackColor = True
        Me.MetroButton1.UseCustomForeColor = True
        Me.MetroButton1.UseSelectable = True
        Me.MetroButton1.UseStyleColors = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel1.ForeColor = System.Drawing.Color.Gray
        Me.MetroLabel1.Location = New System.Drawing.Point(223, 158)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(111, 25)
        Me.MetroLabel1.TabIndex = 67
        Me.MetroLabel1.Text = "&USERNAME"
        Me.MetroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MetroLabel1.UseCustomBackColor = True
        Me.MetroLabel1.UseCustomForeColor = True
        Me.MetroLabel1.UseStyleColors = True
        Me.MetroLabel1.WrapToLine = True
        '
        'PasswordTextBox
        '
        '
        '
        '
        Me.PasswordTextBox.CustomButton.Image = Nothing
        Me.PasswordTextBox.CustomButton.Location = New System.Drawing.Point(198, 1)
        Me.PasswordTextBox.CustomButton.Name = ""
        Me.PasswordTextBox.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.PasswordTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.PasswordTextBox.CustomButton.TabIndex = 1
        Me.PasswordTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.PasswordTextBox.CustomButton.UseSelectable = True
        Me.PasswordTextBox.CustomButton.Visible = False
        Me.PasswordTextBox.Lines = New String(-1) {}
        Me.PasswordTextBox.Location = New System.Drawing.Point(223, 249)
        Me.PasswordTextBox.MaxLength = 32767
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.PasswordTextBox.PromptText = "*****"
        Me.PasswordTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.PasswordTextBox.SelectedText = ""
        Me.PasswordTextBox.SelectionLength = 0
        Me.PasswordTextBox.SelectionStart = 0
        Me.PasswordTextBox.ShortcutsEnabled = True
        Me.PasswordTextBox.Size = New System.Drawing.Size(220, 23)
        Me.PasswordTextBox.TabIndex = 64
        Me.PasswordTextBox.UseCustomBackColor = True
        Me.PasswordTextBox.UseCustomForeColor = True
        Me.PasswordTextBox.UseSelectable = True
        Me.PasswordTextBox.UseStyleColors = True
        Me.PasswordTextBox.UseSystemPasswordChar = True
        Me.PasswordTextBox.WaterMark = "*****"
        Me.PasswordTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.PasswordTextBox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MetroPasswordLabel
        '
        Me.MetroPasswordLabel.AutoSize = True
        Me.MetroPasswordLabel.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroPasswordLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroPasswordLabel.ForeColor = System.Drawing.Color.Gray
        Me.MetroPasswordLabel.Location = New System.Drawing.Point(223, 221)
        Me.MetroPasswordLabel.Name = "MetroPasswordLabel"
        Me.MetroPasswordLabel.Size = New System.Drawing.Size(112, 25)
        Me.MetroPasswordLabel.TabIndex = 63
        Me.MetroPasswordLabel.Text = "&PASSWORD"
        Me.MetroPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MetroPasswordLabel.UseCustomBackColor = True
        Me.MetroPasswordLabel.UseCustomForeColor = True
        Me.MetroPasswordLabel.UseStyleColors = True
        '
        'UsernameTextBox
        '
        '
        '
        '
        Me.UsernameTextBox.CustomButton.Image = Nothing
        Me.UsernameTextBox.CustomButton.Location = New System.Drawing.Point(198, 1)
        Me.UsernameTextBox.CustomButton.Name = ""
        Me.UsernameTextBox.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.UsernameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.UsernameTextBox.CustomButton.TabIndex = 1
        Me.UsernameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.UsernameTextBox.CustomButton.UseSelectable = True
        Me.UsernameTextBox.CustomButton.Visible = False
        Me.UsernameTextBox.Lines = New String(-1) {}
        Me.UsernameTextBox.Location = New System.Drawing.Point(223, 186)
        Me.UsernameTextBox.MaxLength = 32767
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UsernameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.UsernameTextBox.SelectedText = ""
        Me.UsernameTextBox.SelectionLength = 0
        Me.UsernameTextBox.SelectionStart = 0
        Me.UsernameTextBox.ShortcutsEnabled = True
        Me.UsernameTextBox.Size = New System.Drawing.Size(220, 23)
        Me.UsernameTextBox.TabIndex = 62
        Me.UsernameTextBox.UseSelectable = True
        Me.UsernameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.UsernameTextBox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'MetroButton3
        '
        Me.MetroButton3.BackgroundImage = CType(resources.GetObject("MetroButton3.BackgroundImage"), System.Drawing.Image)
        Me.MetroButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.MetroButton3.Location = New System.Drawing.Point(518, 35)
        Me.MetroButton3.Name = "MetroButton3"
        Me.MetroButton3.Size = New System.Drawing.Size(37, 35)
        Me.MetroButton3.TabIndex = 70
        Me.MetroButton3.UseSelectable = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Lucida Bright", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(23, 35)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(107, 27)
        Me.Label10.TabIndex = 69
        Me.Label10.Text = "Label10"
        '
        'Signup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(600, 398)
        Me.ControlBox = False
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.MetroPasswordLabel)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(Me.MetroButton3)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Signup"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LogoPictureBox As PictureBox
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Protected Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents PasswordTextBox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroPasswordLabel As MetroFramework.Controls.MetroLabel
    Friend WithEvents UsernameTextBox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Timer1 As Timer
    Friend WithEvents MetroButton3 As MetroFramework.Controls.MetroButton
    Friend WithEvents Label10 As Label
End Class
