Public Class ManageRoomsForm
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
    Dim room As New ROOMS()
    Private Sub ManageRoomsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' populate the combobox with rooms type from database
        ComboBoxType.DataSource = room.getAllRoomsType()
        ComboBoxType.DisplayMember = "label"
        ComboBoxType.ValueMember = "id"

        'display all rooms data in the datagridview
        DataGridView1.DataSource = room.getAllRooms()
        'display the number of rooms
        LabelRoomsCount.Text = room.getAllRooms().Rows.Count.ToString() + " Room"
    End Sub

    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        Try
            Dim type As Integer = Convert.ToInt32(ComboBoxType.SelectedValue)
            Dim phone As String = TextBoxPhone.Text
            Dim reserved As String = ""
            If RadioButtonYes.Checked Then
                reserved = "Yes"
            ElseIf RadioButtonNo.Checked Then
                reserved = "No"

            End If
            If TextBoxNumber.Text.Trim().Equals("") Or TextBoxPhone.Text.Trim().Equals("") Then
                MessageBox.Show("Make Sure to Enter The Room Number and The Phone Number", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Else
                Dim number As Integer = Convert.ToInt32(TextBoxNumber.Text)

                If room.addRoom(number, type, phone, reserved) Then
                    MessageBox.Show("Room Added Successfully", "Add Room", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    DataGridView1.DataSource = room.getAllRooms()
                    'display the number of rooms
                    LabelRoomsCount.Text = room.getAllRooms().Rows.Count.ToString() + " Room"
                Else
                    MessageBox.Show("Room Not Added", "Add Room", MessageBoxButtons.OK, MessageBoxIcon.Error)


                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Duplicate Room Number", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click
        Try
            Dim type As Integer = Convert.ToInt32(ComboBoxType.SelectedValue)
            Dim phone As String = TextBoxPhone.Text
            Dim reserved As String = ""
            If RadioButtonYes.Checked Then
                reserved = "Yes"
            ElseIf RadioButtonNo.Checked Then
                reserved = "No"

            End If
            If TextBoxNumber.Text.Trim().Equals("") Or TextBoxPhone.Text.Trim().Equals("") Then
                MessageBox.Show("Make Sure to Enter The Room Number and The Phone Number", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Else
                Dim number As Integer = Convert.ToInt32(TextBoxNumber.Text)

                If room.editRoom(number, type, phone, reserved) Then
                    MessageBox.Show("Room Updated Successfully", "Edit Room", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    DataGridView1.DataSource = room.getAllRooms()
                Else
                    MessageBox.Show("Room Not Updated", "Edit Room", MessageBoxButtons.OK, MessageBoxIcon.Error)


                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub ButtonRemove_Click(sender As Object, e As EventArgs) Handles ButtonRemove.Click
        Try
            Dim number As Integer = Convert.ToInt32(TextBoxNumber.Text)
            If room.removeRoom(number) Then
                MessageBox.Show("Room Deleted Successfully", "Delete Room", MessageBoxButtons.OK, MessageBoxIcon.Information)
                DataGridView1.DataSource = room.getAllRooms()
                'reset and clear fields
                TextBoxNumber.Text = ""
                ComboBoxType.SelectedIndex = 0
                TextBoxPhone.Text = ""
                RadioButtonYes.Checked = True
                'display the number of rooms
                LabelRoomsCount.Text = room.getAllRooms().Rows.Count.ToString() + " Room"
            Else

                MessageBox.Show("Room Not Deleted", "Delete Room", MessageBoxButtons.OK, MessageBoxIcon.Warning)





            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        TextBoxNumber.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString()
        ComboBoxType.SelectedValue = DataGridView1.CurrentRow.Cells(1).Value
        TextBoxPhone.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString()
        Dim reserved As String = DataGridView1.CurrentRow.Cells(3).Value.ToString()

        If reserved.Equals("Yes") Then
            RadioButtonYes.Checked = True

        ElseIf reserved.Equals("No") Then
            RadioButtonNo.Checked = True

        End If
    End Sub


End Class