Public Class MainForm
    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()

    End Sub


    Private Sub LabelMClients_Click(sender As Object, e As EventArgs) Handles LabelMClients.Click
        Dim manage_Cl_Form As New ManageClientsForm()
        manage_Cl_Form.ShowDialog()
    End Sub

    Private Sub LabelMRooms_Click(sender As Object, e As EventArgs) Handles LabelMRooms.Click
        Dim manage_Rm_Form As New ManageRoomsForm()
        manage_Rm_Form.ShowDialog()


    End Sub

    Private Sub LabelMReservations_Click(sender As Object, e As EventArgs) Handles LabelMReservations.Click
        Dim manage_Rv_Form As New ManageReservationsForm()
        manage_Rv_Form.ShowDialog()
    End Sub

    Private Sub LabelMClients_MouseEnter(sender As Object, e As EventArgs) Handles LabelMClients.MouseEnter
        LabelMClients.ForeColor = Color.Yellow


    End Sub

    Private Sub LabelMClients_MouseLeave(sender As Object, e As EventArgs) Handles LabelMClients.MouseLeave
        LabelMClients.ForeColor = Color.White
    End Sub

    Private Sub LabelMRooms_MouseEnter(sender As Object, e As EventArgs) Handles LabelMRooms.MouseEnter
        LabelMRooms.ForeColor = Color.Yellow


    End Sub

    Private Sub LabelMRooms_MouseLeave(sender As Object, e As EventArgs) Handles LabelMRooms.MouseLeave
        LabelMRooms.ForeColor = Color.White

    End Sub

    Private Sub LabelMReservations_MouseEnter(sender As Object, e As EventArgs) Handles LabelMReservations.MouseEnter
        LabelMReservations.ForeColor = Color.Yellow


    End Sub

    Private Sub LabelMReservations_MouseLeave(sender As Object, e As EventArgs) Handles LabelMReservations.MouseLeave
        LabelMReservations.ForeColor = Color.White
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class