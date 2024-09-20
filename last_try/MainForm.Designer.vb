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
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.OrangeRed
        Panel1.Controls.Add(LabelMReservations)
        Panel1.Controls.Add(LabelMRooms)
        Panel1.Controls.Add(LabelMClients)
        Panel1.Location = New Point(-2, 14)
        Panel1.Margin = New Padding(6, 5, 6, 5)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(414, 436)
        Panel1.TabIndex = 0
        ' 
        ' LabelMReservations
        ' 
        LabelMReservations.AutoSize = True
        LabelMReservations.Cursor = Cursors.Hand
        LabelMReservations.Location = New Point(79, 296)
        LabelMReservations.Margin = New Padding(6, 0, 6, 0)
        LabelMReservations.Name = "LabelMReservations"
        LabelMReservations.Size = New Size(290, 32)
        LabelMReservations.TabIndex = 2
        LabelMReservations.Text = "Manage Reservations"
        ' 
        ' LabelMRooms
        ' 
        LabelMRooms.AutoSize = True
        LabelMRooms.Cursor = Cursors.Hand
        LabelMRooms.Location = New Point(89, 171)
        LabelMRooms.Margin = New Padding(6, 0, 6, 0)
        LabelMRooms.Name = "LabelMRooms"
        LabelMRooms.Size = New Size(213, 32)
        LabelMRooms.TabIndex = 1
        LabelMRooms.Text = "Manage Rooms"
        ' 
        ' LabelMClients
        ' 
        LabelMClients.AutoSize = True
        LabelMClients.Cursor = Cursors.Hand
        LabelMClients.Location = New Point(89, 65)
        LabelMClients.Margin = New Padding(6, 0, 6, 0)
        LabelMClients.Name = "LabelMClients"
        LabelMClients.Size = New Size(212, 32)
        LabelMClients.TabIndex = 0
        LabelMClients.Text = "Manage Clients"
        ' 
        ' MainForm
        ' 
        AutoScaleDimensions = New SizeF(16.0F, 31.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1924, 848)
        Controls.Add(Panel1)
        Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        ForeColor = Color.White
        Margin = New Padding(6, 5, 6, 5)
        Name = "MainForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "MainForm"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents LabelMClients As Label
    Friend WithEvents LabelMReservations As Label
    Friend WithEvents LabelMRooms As Label
End Class