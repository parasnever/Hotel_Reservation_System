<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ManageclientsForm
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
        DataGridView1 = New DataGridView()
        ButtonEdit = New Button()
        ButtonRemove = New Button()
        TextBoxLname = New TextBox()
        Label6 = New Label()
        TextBoxPhone = New TextBox()
        Label5 = New Label()
        TextBoxFname = New TextBox()
        Label4 = New Label()
        TextBoxEmail = New TextBox()
        Label3 = New Label()
        ButtonAdd = New Button()
        TextBoxId = New TextBox()
        Label2 = New Label()
        Panel2 = New Panel()
        Label1 = New Label()
        Panel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Gray
        Panel1.Controls.Add(DataGridView1)
        Panel1.Controls.Add(ButtonEdit)
        Panel1.Controls.Add(ButtonRemove)
        Panel1.Controls.Add(TextBoxLname)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(TextBoxPhone)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(TextBoxFname)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(TextBoxEmail)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(ButtonAdd)
        Panel1.Controls.Add(TextBoxId)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Panel2)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1234, 721)
        Panel1.TabIndex = 1
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.BackgroundColor = Color.LightGray
        DataGridView1.BorderStyle = BorderStyle.None
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(605, 175)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(617, 503)
        DataGridView1.TabIndex = 16
        ' 
        ' ButtonEdit
        ' 
        ButtonEdit.BackColor = Color.DodgerBlue
        ButtonEdit.Cursor = Cursors.Hand
        ButtonEdit.FlatStyle = FlatStyle.Flat
        ButtonEdit.Font = New Font("Microsoft Sans Serif", 13.8F)
        ButtonEdit.ForeColor = Color.White
        ButtonEdit.Location = New Point(201, 544)
        ButtonEdit.Name = "ButtonEdit"
        ButtonEdit.Size = New Size(166, 62)
        ButtonEdit.TabIndex = 15
        ButtonEdit.Text = "Edit"
        ButtonEdit.UseVisualStyleBackColor = False
        ' 
        ' ButtonRemove
        ' 
        ButtonRemove.BackColor = Color.DodgerBlue
        ButtonRemove.Cursor = Cursors.Hand
        ButtonRemove.FlatStyle = FlatStyle.Flat
        ButtonRemove.Font = New Font("Microsoft Sans Serif", 13.8F)
        ButtonRemove.ForeColor = Color.White
        ButtonRemove.Location = New Point(386, 544)
        ButtonRemove.Name = "ButtonRemove"
        ButtonRemove.Size = New Size(166, 62)
        ButtonRemove.TabIndex = 14
        ButtonRemove.Text = "Remove"
        ButtonRemove.UseVisualStyleBackColor = False
        ' 
        ' TextBoxLname
        ' 
        TextBoxLname.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBoxLname.Location = New Point(167, 300)
        TextBoxLname.Name = "TextBoxLname"
        TextBoxLname.Size = New Size(385, 34)
        TextBoxLname.TabIndex = 13
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(31, 300)
        Label6.Name = "Label6"
        Label6.Size = New Size(134, 29)
        Label6.TabIndex = 12
        Label6.Text = "Last Name:"
        ' 
        ' TextBoxPhone
        ' 
        TextBoxPhone.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBoxPhone.Location = New Point(167, 369)
        TextBoxPhone.Name = "TextBoxPhone"
        TextBoxPhone.Size = New Size(385, 34)
        TextBoxPhone.TabIndex = 11
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(72, 372)
        Label5.Name = "Label5"
        Label5.Size = New Size(89, 29)
        Label5.TabIndex = 10
        Label5.Text = "Phone:"
        ' 
        ' TextBoxFname
        ' 
        TextBoxFname.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBoxFname.Location = New Point(167, 235)
        TextBoxFname.Name = "TextBoxFname"
        TextBoxFname.Size = New Size(385, 34)
        TextBoxFname.TabIndex = 9
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(31, 235)
        Label4.Name = "Label4"
        Label4.Size = New Size(137, 29)
        Label4.TabIndex = 8
        Label4.Text = "First Name:"
        ' 
        ' TextBoxEmail
        ' 
        TextBoxEmail.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBoxEmail.Location = New Point(167, 433)
        TextBoxEmail.Name = "TextBoxEmail"
        TextBoxEmail.Size = New Size(385, 34)
        TextBoxEmail.TabIndex = 7
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(81, 433)
        Label3.Name = "Label3"
        Label3.Size = New Size(80, 29)
        Label3.TabIndex = 6
        Label3.Text = "Email:"
        ' 
        ' ButtonAdd
        ' 
        ButtonAdd.BackColor = Color.DodgerBlue
        ButtonAdd.Cursor = Cursors.Hand
        ButtonAdd.FlatStyle = FlatStyle.Flat
        ButtonAdd.Font = New Font("Microsoft Sans Serif", 13.8F)
        ButtonAdd.ForeColor = Color.White
        ButtonAdd.Location = New Point(31, 544)
        ButtonAdd.Name = "ButtonAdd"
        ButtonAdd.Size = New Size(154, 62)
        ButtonAdd.TabIndex = 5
        ButtonAdd.Text = "Add"
        ButtonAdd.UseVisualStyleBackColor = False
        ' 
        ' TextBoxId
        ' 
        TextBoxId.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBoxId.Location = New Point(167, 175)
        TextBoxId.Name = "TextBoxId"
        TextBoxId.ReadOnly = True
        TextBoxId.Size = New Size(385, 34)
        TextBoxId.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(119, 175)
        Label2.Name = "Label2"
        Label2.Size = New Size(42, 29)
        Label2.TabIndex = 1
        Label2.Text = "ID:"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(2, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1229, 147)
        Panel2.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Gold
        Label1.Dock = DockStyle.Fill
        Label1.Font = New Font("Microsoft Sans Serif", 43.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(1229, 147)
        Label1.TabIndex = 0
        Label1.Text = "Manage Clients"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' ManageClientsForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1234, 721)
        Controls.Add(Panel1)
        Name = "ManageClientsForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ManageclientsForm"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents ButtonAdd As Button
    Friend WithEvents TextBoxId As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxFname As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxEmail As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxLname As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxPhone As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ButtonEdit As Button
    Friend WithEvents ButtonRemove As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class