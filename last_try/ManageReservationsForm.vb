Imports Mysqlx.XDevAPI

Public Class ManageReservationsForm
    Dim room As New ROOMS()
    Dim reservation As New RESERVATION()
    Private Sub ManageReservationsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'populate the datagridview with all the reservation
        DataGridView1.DataSource = reservation.getAllReservation()


        'populate the combobox type with all room's type
        ComboBoxType.DataSource = room.getAllRoomsType()
        ComboBoxType.DisplayMember = "label"
        ComboBoxType.ValueMember = "id"

        'populate the combobox room number with all the not reserved room numbers
        Dim roomType As Integer = Convert.ToInt32(ComboBoxType.SelectedValue.ToString())
        ComboBoxRoomNumber.DataSource = room.getRoomsByType(roomType)

        ComboBoxRoomNumber.DisplayMember = "number"
        ComboBoxRoomNumber.ValueMember = "number"

    End Sub

    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click


        Try
            Dim clientId As Integer = Convert.ToInt32(TextBoxClientID.Text)
            Dim roomNumber As Integer = Convert.ToInt32(ComboBoxRoomNumber.SelectedValue.ToString())
            Dim dateIn As Date = DateTimePickerIN.Value
            Dim dateOut As Date = DateTimePickerOUT.Value

            If DateTime.Compare(dateIn.Date, DateTime.Now.Date) < 0 Then
                MessageBox.Show("The Date In must be = Or > to today Date", "Invalid Date In", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf DateTime.Compare(dateOut.Date, dateIn.Date) < 0 Then
                MessageBox.Show("The Date Out must be = Or > to Date In", "Invalid Date Out", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                If reservation.addReservation(roomNumber, clientId, dateIn, dateOut) Then
                    MessageBox.Show("Reservation Added Successfully", "Add Reservation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    DataGridView1.DataSource = reservation.getAllReservation()
                    'we need to refresh the combobox to show only the not reserved rooms
                    ComboBoxType.DataSource = room.getAllRoomsType()

                Else
                    MessageBox.Show("Reservation Not Added", "Add Reservation", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End If

            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Add reservation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub



    Private Sub ComboBoxType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxType.SelectedIndexChanged
        Try
            'display room numbers depending on the selected type
            Dim roomType As Integer = Convert.ToInt32(ComboBoxType.SelectedValue.ToString())
            ComboBoxRoomNumber.DataSource = room.getRoomsByType(roomType)

            ComboBoxRoomNumber.DisplayMember = "number"
            ComboBoxRoomNumber.ValueMember = "number"


        Catch ex As Exception


        End Try


    End Sub

    Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click
        Try
            Dim reservationId As Integer = Convert.ToInt32(TextBoxReservationID.Text)
            Dim clientId As Integer = Convert.ToInt32(TextBoxClientID.Text)
            Dim roomNumber As Integer = Convert.ToInt32(DataGridView1.CurrentRow.Cells(2).Value.ToString())
            Dim dateIn As Date = DateTimePickerIN.Value
            Dim dateOut As Date = DateTimePickerOUT.Value

            If DateTime.Compare(dateIn.Date, DateTime.Now.Date) < 0 Then
                MessageBox.Show("The Date In must be = Or > to today Date", "Invalid Date In", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf DateTime.Compare(dateOut.Date, dateIn.Date) < 0 Then
                MessageBox.Show("The Date Out must be = Or > to Date In", "Invalid Date Out", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else

                If reservation.editReservation(reservationId, roomNumber, clientId, dateIn, dateOut) Then
                    MessageBox.Show("Reservation Upadated Successfully", "Add Reservation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    DataGridView1.DataSource = reservation.getAllReservation()
                Else
                    MessageBox.Show("Reservation Not Upadated", "Add Reservation", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End If

            End If



        Catch ex As Exception
            MessageBox.Show(ex.Message, "Edit reservation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub ButtonRemove_Click(sender As Object, e As EventArgs) Handles ButtonRemove.Click
        Try
            Dim reservationId As Integer = Convert.ToInt32(TextBoxReservationID.Text)
            Dim roomNumber As Integer = Convert.ToInt32(DataGridView1.CurrentRow.Cells(2).Value.ToString())

            If reservation.removeReservation(reservationId, roomNumber) Then
                MessageBox.Show("Reservation Deleted Successfully", "Remove Reservation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                DataGridView1.DataSource = reservation.getAllReservation()
            Else
                MessageBox.Show("Reservation Not Deleted", "Remove Reservation", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Remove reservation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try



    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        'display datagridview selected row data into the input fields
        TextBoxReservationID.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString()
        TextBoxClientID.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()
        'to display the selectd room number we need first to select the room type
        Dim roomNumber As Integer = Convert.ToInt32(DataGridView1.CurrentRow.Cells(2).Value.ToString())
        ComboBoxType.SelectedValue = room.getRoomType(roomNumber)
        ComboBoxRoomNumber.SelectedValue = DataGridView1.CurrentRow.Cells(2).Value.ToString()
        DateTimePickerIN.Value = DataGridView1.CurrentRow.Cells(3).Value
        DateTimePickerOUT.Value = DataGridView1.CurrentRow.Cells(4).Value



    End Sub
End Class
'we need to display room numbers depending on the selected type
'we have to add foreign key for the table rooms(rooms & rooms_type)
'->ALTER TABLE rooms ADD CONSTRAINT fk_type_id FOREIGN KEY(type) REFERENCES rooms_type(id) ON DELETE CASCADE ON UPDATE CASCADE

'we have to add foreign key for the table reservations(reservations & rooms)
'->ALTER TABLE reservations ADD CONSTRAINT fk_room_number FOREIGN KEY(room_Number) REFERENCES rooms(number) ON DELETE CASCADE ON UPDATE CASCADE
'we have to add foreign key for the table reservations(reservations & clients)

'->ALTER TABLE reservations ADD CONSTRAINT fk_client_id FOREIGN KEY(client_ID) REFERENCES clients(id) ON DELETE CASCADE ON UPDATE CASCADE

' SOME FIXES WE NEED TO DO
'only display the not reserved room in the combobox[DONE]
'fix the date in and date out[DONE]
'the date in must be = or >today date[DONE]
'the date out must be = 0r >date in[DONE]

'when we add a reservation we need to set this room to reserved
'when we remove a reservation we need to set this room to not reserved

'the error come from the room number
'because the room will not show up in the combobox ( the room is alreaddy reserved and we only show the not reserved one)
'to fix date wer will get the room number from the datagridview







