<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loginform
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
        Me.FormSkin1 = New Net_X_Score_Managment.FormSkin()
        Me.exitbutt = New Net_X_Score_Managment.FlatButton()
        Me.loginbutt = New Net_X_Score_Managment.FlatButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.passwordtxt = New Net_X_Score_Managment.FlatTextBox()
        Me.FlatLabel1 = New Net_X_Score_Managment.FlatLabel()
        Me.usernametxt = New Net_X_Score_Managment.FlatTextBox()
        Me.label1 = New Net_X_Score_Managment.FlatLabel()
        Me.FormSkin1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.exitbutt)
        Me.FormSkin1.Controls.Add(Me.loginbutt)
        Me.FormSkin1.Controls.Add(Me.PictureBox1)
        Me.FormSkin1.Controls.Add(Me.passwordtxt)
        Me.FormSkin1.Controls.Add(Me.FlatLabel1)
        Me.FormSkin1.Controls.Add(Me.usernametxt)
        Me.FormSkin1.Controls.Add(Me.label1)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(534, 227)
        Me.FormSkin1.TabIndex = 0
        Me.FormSkin1.Text = "--Net-X--"
        '
        'exitbutt
        '
        Me.exitbutt.BackColor = System.Drawing.Color.Transparent
        Me.exitbutt.BaseColor = System.Drawing.Color.IndianRed
        Me.exitbutt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.exitbutt.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.exitbutt.Location = New System.Drawing.Point(382, 183)
        Me.exitbutt.Name = "exitbutt"
        Me.exitbutt.Rounded = False
        Me.exitbutt.Size = New System.Drawing.Size(131, 32)
        Me.exitbutt.TabIndex = 6
        Me.exitbutt.Text = "Exit"
        Me.exitbutt.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'loginbutt
        '
        Me.loginbutt.BackColor = System.Drawing.Color.Transparent
        Me.loginbutt.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.loginbutt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.loginbutt.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.loginbutt.Location = New System.Drawing.Point(159, 183)
        Me.loginbutt.Name = "loginbutt"
        Me.loginbutt.Rounded = False
        Me.loginbutt.Size = New System.Drawing.Size(217, 32)
        Me.loginbutt.TabIndex = 5
        Me.loginbutt.Text = "Login"
        Me.loginbutt.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(12, 59)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(130, 156)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'passwordtxt
        '
        Me.passwordtxt.BackColor = System.Drawing.Color.Transparent
        Me.passwordtxt.Location = New System.Drawing.Point(159, 144)
        Me.passwordtxt.MaxLength = 32767
        Me.passwordtxt.Multiline = False
        Me.passwordtxt.Name = "passwordtxt"
        Me.passwordtxt.ReadOnly = False
        Me.passwordtxt.Size = New System.Drawing.Size(354, 29)
        Me.passwordtxt.TabIndex = 3
        Me.passwordtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.passwordtxt.TextColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.passwordtxt.UseSystemPasswordChar = True
        '
        'FlatLabel1
        '
        Me.FlatLabel1.AutoSize = True
        Me.FlatLabel1.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel1.ForeColor = System.Drawing.Color.Silver
        Me.FlatLabel1.Location = New System.Drawing.Point(154, 116)
        Me.FlatLabel1.Name = "FlatLabel1"
        Me.FlatLabel1.Size = New System.Drawing.Size(97, 25)
        Me.FlatLabel1.TabIndex = 2
        Me.FlatLabel1.Text = "Password"
        '
        'usernametxt
        '
        Me.usernametxt.BackColor = System.Drawing.Color.Transparent
        Me.usernametxt.Location = New System.Drawing.Point(159, 84)
        Me.usernametxt.MaxLength = 32767
        Me.usernametxt.Multiline = False
        Me.usernametxt.Name = "usernametxt"
        Me.usernametxt.ReadOnly = False
        Me.usernametxt.Size = New System.Drawing.Size(354, 29)
        Me.usernametxt.TabIndex = 1
        Me.usernametxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.usernametxt.TextColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.usernametxt.UseSystemPasswordChar = False
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.Color.Transparent
        Me.label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.Silver
        Me.label1.Location = New System.Drawing.Point(154, 56)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(101, 25)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Username"
        '
        'loginform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 227)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "loginform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Net-X-Login"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        Me.FormSkin1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FormSkin1 As Net_X_Score_Managment.FormSkin
    Friend WithEvents loginbutt As Net_X_Score_Managment.FlatButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents passwordtxt As Net_X_Score_Managment.FlatTextBox
    Friend WithEvents FlatLabel1 As Net_X_Score_Managment.FlatLabel
    Friend WithEvents usernametxt As Net_X_Score_Managment.FlatTextBox
    Friend WithEvents label1 As Net_X_Score_Managment.FlatLabel
    Friend WithEvents exitbutt As Net_X_Score_Managment.FlatButton

End Class
