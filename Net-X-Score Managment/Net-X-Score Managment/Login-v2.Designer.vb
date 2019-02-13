<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login_v2
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login_v2))
        Me.NsTheme1 = New Net_X_Score_Managment.NSTheme()
        Me.NsGroupBox1 = New Net_X_Score_Managment.NSGroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.passtxt = New Net_X_Score_Managment.NSTextBox()
        Me.usertxt = New Net_X_Score_Managment.NSTextBox()
        Me.NsLabel2 = New Net_X_Score_Managment.NSLabel()
        Me.NsLabel1 = New Net_X_Score_Managment.NSLabel()
        Me.NsButton2 = New Net_X_Score_Managment.NSButton()
        Me.NsButton1 = New Net_X_Score_Managment.NSButton()
        Me.NsButton3 = New Net_X_Score_Managment.NSButton()
        Me.NsButton4 = New Net_X_Score_Managment.NSButton()
        Me.NsCheckBox1 = New Net_X_Score_Managment.NSCheckBox()
        Me.NsTheme1.SuspendLayout()
        Me.NsGroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NsTheme1
        '
        Me.NsTheme1.AccentOffset = 42
        Me.NsTheme1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.NsTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.NsTheme1.Colors = New Net_X_Score_Managment.Bloom(-1) {}
        Me.NsTheme1.Controls.Add(Me.NsGroupBox1)
        Me.NsTheme1.Controls.Add(Me.NsButton2)
        Me.NsTheme1.Controls.Add(Me.NsButton1)
        Me.NsTheme1.Customization = ""
        Me.NsTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NsTheme1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.NsTheme1.Image = Nothing
        Me.NsTheme1.Location = New System.Drawing.Point(0, 0)
        Me.NsTheme1.Movable = True
        Me.NsTheme1.Name = "NsTheme1"
        Me.NsTheme1.NoRounding = False
        Me.NsTheme1.Sizable = True
        Me.NsTheme1.Size = New System.Drawing.Size(393, 201)
        Me.NsTheme1.SmartBounds = True
        Me.NsTheme1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.NsTheme1.TabIndex = 0
        Me.NsTheme1.Text = "Net-X"
        Me.NsTheme1.TransparencyKey = System.Drawing.Color.Empty
        Me.NsTheme1.Transparent = False
        '
        'NsGroupBox1
        '
        Me.NsGroupBox1.Controls.Add(Me.NsCheckBox1)
        Me.NsGroupBox1.Controls.Add(Me.NsButton4)
        Me.NsGroupBox1.Controls.Add(Me.NsButton3)
        Me.NsGroupBox1.Controls.Add(Me.PictureBox1)
        Me.NsGroupBox1.Controls.Add(Me.passtxt)
        Me.NsGroupBox1.Controls.Add(Me.usertxt)
        Me.NsGroupBox1.Controls.Add(Me.NsLabel2)
        Me.NsGroupBox1.Controls.Add(Me.NsLabel1)
        Me.NsGroupBox1.DrawSeperator = False
        Me.NsGroupBox1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NsGroupBox1.Location = New System.Drawing.Point(0, 31)
        Me.NsGroupBox1.Name = "NsGroupBox1"
        Me.NsGroupBox1.Size = New System.Drawing.Size(390, 170)
        Me.NsGroupBox1.SubTitle = ""
        Me.NsGroupBox1.TabIndex = 2
        Me.NsGroupBox1.Text = "NsGroupBox1"
        Me.NsGroupBox1.Title = "                 -------------Login Form-------------"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 33)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(83, 114)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'passtxt
        '
        Me.passtxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.passtxt.Location = New System.Drawing.Point(198, 62)
        Me.passtxt.MaxLength = 32767
        Me.passtxt.Multiline = False
        Me.passtxt.Name = "passtxt"
        Me.passtxt.ReadOnly = False
        Me.passtxt.Size = New System.Drawing.Size(179, 23)
        Me.passtxt.TabIndex = 3
        Me.passtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.passtxt.UseSystemPasswordChar = False
        '
        'usertxt
        '
        Me.usertxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.usertxt.Location = New System.Drawing.Point(198, 33)
        Me.usertxt.MaxLength = 32767
        Me.usertxt.Multiline = False
        Me.usertxt.Name = "usertxt"
        Me.usertxt.ReadOnly = False
        Me.usertxt.Size = New System.Drawing.Size(179, 23)
        Me.usertxt.TabIndex = 2
        Me.usertxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.usertxt.UseSystemPasswordChar = False
        '
        'NsLabel2
        '
        Me.NsLabel2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.NsLabel2.Location = New System.Drawing.Point(103, 62)
        Me.NsLabel2.Name = "NsLabel2"
        Me.NsLabel2.Size = New System.Drawing.Size(89, 23)
        Me.NsLabel2.TabIndex = 1
        Me.NsLabel2.Text = "NsLabel2"
        Me.NsLabel2.Value1 = " Password :"
        Me.NsLabel2.Value2 = ""
        '
        'NsLabel1
        '
        Me.NsLabel1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.NsLabel1.Location = New System.Drawing.Point(103, 33)
        Me.NsLabel1.Name = "NsLabel1"
        Me.NsLabel1.Size = New System.Drawing.Size(89, 23)
        Me.NsLabel1.TabIndex = 0
        Me.NsLabel1.Text = "NsLabel1"
        Me.NsLabel1.Value1 = "Username :"
        Me.NsLabel1.Value2 = ""
        '
        'NsButton2
        '
        Me.NsButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.NsButton2.Location = New System.Drawing.Point(325, 3)
        Me.NsButton2.Name = "NsButton2"
        Me.NsButton2.Size = New System.Drawing.Size(23, 23)
        Me.NsButton2.TabIndex = 1
        Me.NsButton2.Text = "-"
        Me.NsButton2.UseVisualStyleBackColor = True
        '
        'NsButton1
        '
        Me.NsButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.NsButton1.Location = New System.Drawing.Point(354, 3)
        Me.NsButton1.Name = "NsButton1"
        Me.NsButton1.Size = New System.Drawing.Size(36, 23)
        Me.NsButton1.TabIndex = 0
        Me.NsButton1.Text = "X"
        Me.NsButton1.UseVisualStyleBackColor = True
        '
        'NsButton3
        '
        Me.NsButton3.DialogResult = System.Windows.Forms.DialogResult.None
        Me.NsButton3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NsButton3.Location = New System.Drawing.Point(101, 121)
        Me.NsButton3.Name = "NsButton3"
        Me.NsButton3.Size = New System.Drawing.Size(170, 25)
        Me.NsButton3.TabIndex = 5
        Me.NsButton3.Text = "Login"
        Me.NsButton3.UseVisualStyleBackColor = True
        '
        'NsButton4
        '
        Me.NsButton4.DialogResult = System.Windows.Forms.DialogResult.None
        Me.NsButton4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NsButton4.Location = New System.Drawing.Point(279, 122)
        Me.NsButton4.Name = "NsButton4"
        Me.NsButton4.Size = New System.Drawing.Size(98, 25)
        Me.NsButton4.TabIndex = 6
        Me.NsButton4.Text = "Exit"
        Me.NsButton4.UseVisualStyleBackColor = True
        '
        'NsCheckBox1
        '
        Me.NsCheckBox1.Checked = False
        Me.NsCheckBox1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NsCheckBox1.Location = New System.Drawing.Point(198, 91)
        Me.NsCheckBox1.Name = "NsCheckBox1"
        Me.NsCheckBox1.Size = New System.Drawing.Size(167, 23)
        Me.NsCheckBox1.TabIndex = 7
        Me.NsCheckBox1.Text = "Remember Me"
        '
        'Login_v2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(393, 201)
        Me.Controls.Add(Me.NsTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login_v2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login_v2"
        Me.NsTheme1.ResumeLayout(False)
        Me.NsGroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents NsTheme1 As Net_X_Score_Managment.NSTheme
    Friend WithEvents NsGroupBox1 As Net_X_Score_Managment.NSGroupBox
    Friend WithEvents NsButton2 As Net_X_Score_Managment.NSButton
    Friend WithEvents NsButton1 As Net_X_Score_Managment.NSButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents passtxt As Net_X_Score_Managment.NSTextBox
    Friend WithEvents usertxt As Net_X_Score_Managment.NSTextBox
    Friend WithEvents NsLabel2 As Net_X_Score_Managment.NSLabel
    Friend WithEvents NsLabel1 As Net_X_Score_Managment.NSLabel
    Friend WithEvents NsCheckBox1 As Net_X_Score_Managment.NSCheckBox
    Friend WithEvents NsButton4 As Net_X_Score_Managment.NSButton
    Friend WithEvents NsButton3 As Net_X_Score_Managment.NSButton
End Class
