<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.LoginBox = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.User = New System.Windows.Forms.Label()
        Me.userbox = New System.Windows.Forms.TextBox()
        Me.pass = New System.Windows.Forms.Label()
        Me.Passbox = New System.Windows.Forms.TextBox()
        Me.LogBut = New System.Windows.Forms.Button()
        Me.ExBut = New System.Windows.Forms.Button()
        Me.LoginBox.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LoginBox
        '
        Me.LoginBox.Controls.Add(Me.PictureBox1)
        Me.LoginBox.Location = New System.Drawing.Point(13, 24)
        Me.LoginBox.Name = "LoginBox"
        Me.LoginBox.Size = New System.Drawing.Size(585, 285)
        Me.LoginBox.TabIndex = 0
        Me.LoginBox.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(15, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(570, 260)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'User
        '
        Me.User.AutoSize = True
        Me.User.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.User.Location = New System.Drawing.Point(28, 335)
        Me.User.Name = "User"
        Me.User.Size = New System.Drawing.Size(107, 21)
        Me.User.TabIndex = 1
        Me.User.Text = "Username :"
        '
        'userbox
        '
        Me.userbox.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userbox.Location = New System.Drawing.Point(152, 335)
        Me.userbox.Multiline = True
        Me.userbox.Name = "userbox"
        Me.userbox.Size = New System.Drawing.Size(156, 21)
        Me.userbox.TabIndex = 2
        '
        'pass
        '
        Me.pass.AutoSize = True
        Me.pass.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pass.Location = New System.Drawing.Point(32, 376)
        Me.pass.Name = "pass"
        Me.pass.Size = New System.Drawing.Size(91, 21)
        Me.pass.TabIndex = 3
        Me.pass.Text = "Password"
        '
        'Passbox
        '
        Me.Passbox.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Passbox.Location = New System.Drawing.Point(152, 376)
        Me.Passbox.Multiline = True
        Me.Passbox.Name = "Passbox"
        Me.Passbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Passbox.Size = New System.Drawing.Size(240, 21)
        Me.Passbox.TabIndex = 4
        '
        'LogBut
        '
        Me.LogBut.BackColor = System.Drawing.SystemColors.Window
        Me.LogBut.BackgroundImage = CType(resources.GetObject("LogBut.BackgroundImage"), System.Drawing.Image)
        Me.LogBut.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogBut.Location = New System.Drawing.Point(36, 442)
        Me.LogBut.Name = "LogBut"
        Me.LogBut.Size = New System.Drawing.Size(99, 92)
        Me.LogBut.TabIndex = 5
        Me.LogBut.UseVisualStyleBackColor = False
        '
        'ExBut
        '
        Me.ExBut.BackColor = System.Drawing.SystemColors.Window
        Me.ExBut.BackgroundImage = CType(resources.GetObject("ExBut.BackgroundImage"), System.Drawing.Image)
        Me.ExBut.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExBut.Location = New System.Drawing.Point(341, 442)
        Me.ExBut.Name = "ExBut"
        Me.ExBut.Size = New System.Drawing.Size(99, 92)
        Me.ExBut.TabIndex = 6
        Me.ExBut.UseVisualStyleBackColor = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGreen
        Me.ClientSize = New System.Drawing.Size(823, 556)
        Me.Controls.Add(Me.ExBut)
        Me.Controls.Add(Me.LogBut)
        Me.Controls.Add(Me.Passbox)
        Me.Controls.Add(Me.pass)
        Me.Controls.Add(Me.userbox)
        Me.Controls.Add(Me.User)
        Me.Controls.Add(Me.LoginBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.LoginBox.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LoginBox As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents User As Label
    Friend WithEvents userbox As TextBox
    Friend WithEvents pass As Label
    Friend WithEvents Passbox As TextBox
    Friend WithEvents LogBut As Button
    Friend WithEvents ExBut As Button
End Class
