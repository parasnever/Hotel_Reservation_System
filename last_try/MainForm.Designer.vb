<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        LabelMReservations = New Label()
        LabelMRooms = New Label()
        LabelMClients = New Label()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.ForeColor = Color.Black
        Panel1.Location = New Point(1, 406)
        Panel1.Margin = New Padding(6, 5, 6, 5)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(416, 367)
        Panel1.TabIndex = 0
        ' 
        ' LabelMReservations
        ' 
        LabelMReservations.AutoSize = True
        LabelMReservations.BackColor = Color.Teal
        LabelMReservations.Cursor = Cursors.Hand
        LabelMReservations.Font = New Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold)
        LabelMReservations.ForeColor = Color.White
        LabelMReservations.Location = New Point(24, 196)
        LabelMReservations.Margin = New Padding(6, 0, 6, 0)
        LabelMReservations.Name = "LabelMReservations"
        LabelMReservations.Size = New Size(367, 39)
        LabelMReservations.TabIndex = 2
        LabelMReservations.Text = "Manage Reservations"
        ' 
        ' LabelMRooms
        ' 
        LabelMRooms.AutoSize = True
        LabelMRooms.BackColor = Color.Teal
        LabelMRooms.Cursor = Cursors.Hand
        LabelMRooms.Font = New Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold)
        LabelMRooms.ForeColor = Color.White
        LabelMRooms.Location = New Point(24, 102)
        LabelMRooms.Margin = New Padding(6, 0, 6, 0)
        LabelMRooms.Name = "LabelMRooms"
        LabelMRooms.Size = New Size(269, 39)
        LabelMRooms.TabIndex = 1
        LabelMRooms.Text = "Manage Rooms"
        ' 
        ' LabelMClients
        ' 
        LabelMClients.AutoSize = True
        LabelMClients.BackColor = Color.Teal
        LabelMClients.Cursor = Cursors.Hand
        LabelMClients.Font = New Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold)
        LabelMClients.ForeColor = Color.White
        LabelMClients.Location = New Point(24, 9)
        LabelMClients.Margin = New Padding(6, 0, 6, 0)
        LabelMClients.Name = "LabelMClients"
        LabelMClients.Size = New Size(268, 39)
        LabelMClients.TabIndex = 0
        LabelMClients.Text = "Manage Clients"
        ' 
        ' MainForm
        ' 
        AutoScaleDimensions = New SizeF(16F, 31F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Brown
        BackgroundImage = My.Resources.Resources.djd
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1422, 777)
        Controls.Add(LabelMReservations)
        Controls.Add(Panel1)
        Controls.Add(LabelMRooms)
        Controls.Add(LabelMClients)
        Cursor = Cursors.Hand
        Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        ForeColor = Color.GreenYellow
        Margin = New Padding(6, 5, 6, 5)
        Name = "MainForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "MainForm"
        WindowState = FormWindowState.Maximized
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents LabelMClients As Label
    Friend WithEvents LabelMReservations As Label
    Friend WithEvents LabelMRooms As Label
End Class