<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

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
        Panel1 = New Panel()
        ButtonLogin = New Button()
        TextBoxPassword = New TextBox()
        Label3 = New Label()
        TextBoxUsername = New TextBox()
        Label2 = New Label()
        Panel2 = New Panel()
        Label1 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Gray
        Panel1.Controls.Add(ButtonLogin)
        Panel1.Controls.Add(TextBoxPassword)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(TextBoxUsername)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Panel2)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(800, 450)
        Panel1.TabIndex = 0
        ' 
        ' ButtonLogin
        ' 
        ButtonLogin.BackColor = Color.LimeGreen
        ButtonLogin.Cursor = Cursors.Hand
        ButtonLogin.FlatStyle = FlatStyle.Flat
        ButtonLogin.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ButtonLogin.ForeColor = Color.White
        ButtonLogin.Location = New Point(46, 313)
        ButtonLogin.Name = "ButtonLogin"
        ButtonLogin.Size = New Size(728, 73)
        ButtonLogin.TabIndex = 5
        ButtonLogin.Text = "Login"
        ButtonLogin.UseVisualStyleBackColor = False
        ' 
        ' TextBoxPassword
        ' 
        TextBoxPassword.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBoxPassword.Location = New Point(172, 248)
        TextBoxPassword.Name = "TextBoxPassword"
        TextBoxPassword.Size = New Size(602, 34)
        TextBoxPassword.TabIndex = 4
        TextBoxPassword.Text = "gaha"
        TextBoxPassword.UseSystemPasswordChar = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(46, 248)
        Label3.Name = "Label3"
        Label3.Size = New Size(126, 29)
        Label3.TabIndex = 3
        Label3.Text = "Password:"
        ' 
        ' TextBoxUsername
        ' 
        TextBoxUsername.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBoxUsername.Location = New Point(172, 183)
        TextBoxUsername.Name = "TextBoxUsername"
        TextBoxUsername.Size = New Size(602, 34)
        TextBoxUsername.TabIndex = 2
        TextBoxUsername.Text = "sujal"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(46, 183)
        Label2.Name = "Label2"
        Label2.Size = New Size(130, 29)
        Label2.TabIndex = 1
        Label2.Text = "Username:"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(3, 3)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(797, 130)
        Panel2.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Gold
        Label1.Dock = DockStyle.Fill
        Label1.Font = New Font("Microsoft Sans Serif", 43.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.ImageAlign = ContentAlignment.MiddleRight
        Label1.Location = New Point(0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(797, 130)
        Label1.TabIndex = 0
        Label1.Text = "Sign In"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        MaximizeBox = False
        Name = "LoginForm"
        StartPosition = FormStartPosition.CenterScreen
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonLogin As Button
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxUsername As TextBox
End Class