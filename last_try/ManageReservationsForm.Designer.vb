<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ManageReservationsForm
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
        DateTimePickerOUT = New DateTimePicker()
        DateTimePickerIN = New DateTimePicker()
        Label7 = New Label()
        Label6 = New Label()
        ComboBoxType = New ComboBox()
        Label3 = New Label()
        ComboBoxRoomNumber = New ComboBox()
        DataGridView1 = New DataGridView()
        ButtonEdit = New Button()
        ButtonRemove = New Button()
        TextBoxClientID = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        ButtonAdd = New Button()
        TextBoxReservationID = New TextBox()
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
        Panel1.BackColor = Color.LightSlateGray
        Panel1.Controls.Add(DateTimePickerOUT)
        Panel1.Controls.Add(DateTimePickerIN)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(ComboBoxType)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(ComboBoxRoomNumber)
        Panel1.Controls.Add(DataGridView1)
        Panel1.Controls.Add(ButtonEdit)
        Panel1.Controls.Add(ButtonRemove)
        Panel1.Controls.Add(TextBoxClientID)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(ButtonAdd)
        Panel1.Controls.Add(TextBoxReservationID)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Panel2)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1337, 700)
        Panel1.TabIndex = 3
        ' 
        ' DateTimePickerOUT
        ' 
        DateTimePickerOUT.CustomFormat = "dd-MM-yyyy"
        DateTimePickerOUT.Font = New Font("Microsoft Sans Serif", 13.8F)
        DateTimePickerOUT.Format = DateTimePickerFormat.Custom
        DateTimePickerOUT.Location = New Point(161, 510)
        DateTimePickerOUT.Name = "DateTimePickerOUT"
        DateTimePickerOUT.Size = New Size(391, 34)
        DateTimePickerOUT.TabIndex = 23
        ' 
        ' DateTimePickerIN
        ' 
        DateTimePickerIN.CustomFormat = "dd-MM-yyyy"
        DateTimePickerIN.Font = New Font("Microsoft Sans Serif", 13.8F)
        DateTimePickerIN.Format = DateTimePickerFormat.Custom
        DateTimePickerIN.Location = New Point(167, 442)
        DateTimePickerIN.Name = "DateTimePickerIN"
        DateTimePickerIN.Size = New Size(385, 34)
        DateTimePickerIN.TabIndex = 22
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(28, 510)
        Label7.Name = "Label7"
        Label7.Size = New Size(127, 29)
        Label7.TabIndex = 21
        Label7.Text = "Date OUT:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(56, 447)
        Label6.Name = "Label6"
        Label6.Size = New Size(99, 29)
        Label6.TabIndex = 20
        Label6.Text = "Date IN:"
        ' 
        ' ComboBoxType
        ' 
        ComboBoxType.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBoxType.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ComboBoxType.FormattingEnabled = True
        ComboBoxType.Location = New Point(167, 311)
        ComboBoxType.Name = "ComboBoxType"
        ComboBoxType.Size = New Size(385, 37)
        ComboBoxType.TabIndex = 19
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(10, 319)
        Label3.Name = "Label3"
        Label3.Size = New Size(151, 29)
        Label3.TabIndex = 18
        Label3.Text = " Room Type:"
        ' 
        ' ComboBoxRoomNumber
        ' 
        ComboBoxRoomNumber.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBoxRoomNumber.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ComboBoxRoomNumber.FormattingEnabled = True
        ComboBoxRoomNumber.Location = New Point(167, 375)
        ComboBoxRoomNumber.Name = "ComboBoxRoomNumber"
        ComboBoxRoomNumber.Size = New Size(385, 37)
        ComboBoxRoomNumber.TabIndex = 17
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.BackgroundColor = Color.LightGray
        DataGridView1.BorderStyle = BorderStyle.None
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(621, 175)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(704, 513)
        DataGridView1.TabIndex = 16
        ' 
        ' ButtonEdit
        ' 
        ButtonEdit.BackColor = Color.DarkRed
        ButtonEdit.Cursor = Cursors.Hand
        ButtonEdit.FlatStyle = FlatStyle.Flat
        ButtonEdit.Font = New Font("Microsoft Sans Serif", 13.8F)
        ButtonEdit.ForeColor = Color.White
        ButtonEdit.Location = New Point(201, 626)
        ButtonEdit.Name = "ButtonEdit"
        ButtonEdit.Size = New Size(166, 62)
        ButtonEdit.TabIndex = 15
        ButtonEdit.Text = "Edit"
        ButtonEdit.UseVisualStyleBackColor = False
        ' 
        ' ButtonRemove
        ' 
        ButtonRemove.BackColor = Color.DarkRed
        ButtonRemove.Cursor = Cursors.Hand
        ButtonRemove.FlatStyle = FlatStyle.Flat
        ButtonRemove.Font = New Font("Microsoft Sans Serif", 13.8F)
        ButtonRemove.ForeColor = Color.White
        ButtonRemove.Location = New Point(386, 626)
        ButtonRemove.Name = "ButtonRemove"
        ButtonRemove.Size = New Size(166, 62)
        ButtonRemove.TabIndex = 14
        ButtonRemove.Text = "Remove"
        ButtonRemove.UseVisualStyleBackColor = False
        ' 
        ' TextBoxClientID
        ' 
        TextBoxClientID.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBoxClientID.Location = New Point(167, 249)
        TextBoxClientID.Name = "TextBoxClientID"
        TextBoxClientID.Size = New Size(385, 34)
        TextBoxClientID.TabIndex = 11
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(45, 383)
        Label5.Name = "Label5"
        Label5.Size = New Size(116, 29)
        Label5.TabIndex = 10
        Label5.Text = "Room N°:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(45, 254)
        Label4.Name = "Label4"
        Label4.Size = New Size(110, 29)
        Label4.TabIndex = 8
        Label4.Text = "Client ID:"
        ' 
        ' ButtonAdd
        ' 
        ButtonAdd.BackColor = Color.DarkRed
        ButtonAdd.Cursor = Cursors.Hand
        ButtonAdd.FlatStyle = FlatStyle.Flat
        ButtonAdd.Font = New Font("Microsoft Sans Serif", 13.8F)
        ButtonAdd.ForeColor = Color.White
        ButtonAdd.Location = New Point(31, 626)
        ButtonAdd.Name = "ButtonAdd"
        ButtonAdd.Size = New Size(154, 62)
        ButtonAdd.TabIndex = 5
        ButtonAdd.Text = "Add"
        ButtonAdd.UseVisualStyleBackColor = False
        ' 
        ' TextBoxReservationID
        ' 
        TextBoxReservationID.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBoxReservationID.Location = New Point(167, 175)
        TextBoxReservationID.Name = "TextBoxReservationID"
        TextBoxReservationID.ReadOnly = True
        TextBoxReservationID.Size = New Size(385, 34)
        TextBoxReservationID.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(37, 178)
        Label2.Name = "Label2"
        Label2.Size = New Size(124, 29)
        Label2.TabIndex = 1
        Label2.Text = "Reserv ID:"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1337, 148)
        Panel2.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Goldenrod
        Label1.Dock = DockStyle.Fill
        Label1.Font = New Font("Microsoft Sans Serif", 43.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(1337, 148)
        Label1.TabIndex = 0
        Label1.Text = "Manage Reservations"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' ManageReservationsForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1337, 700)
        Controls.Add(Panel1)
        Name = "ManageReservationsForm"
        StartPosition = FormStartPosition.CenterScreen
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents ComboBoxRoomNumber As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ButtonEdit As Button
    Friend WithEvents ButtonRemove As Button
    Friend WithEvents TextBoxClientID As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ButtonAdd As Button
    Friend WithEvents TextBoxReservationID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBoxType As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DateTimePickerOUT As DateTimePicker
    Friend WithEvents DateTimePickerIN As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
End Class