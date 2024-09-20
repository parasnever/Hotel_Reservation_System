Imports Mysqlx.Notice

Public Class ManageclientsForm
    Dim client As New CLIENT()
    Private Sub ManageclientsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = client.getAllClients()
    End Sub

    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click

        Dim fname As String = TextBoxFname.Text
        Dim lname As String = TextBoxLname.Text
        Dim phone As String = TextBoxPhone.Text
        Dim email As String = TextBoxEmail.Text

        If fname.Trim().Equals("") Or lname.Trim().Equals("") Or phone.Trim().Equals("") Then
            MessageBox.Show("Required First & Last Name, Phone", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            If client.addClient(fname, lname, phone, email) Then
                MessageBox.Show("New Client Added Successfully", "Add client", MessageBoxButtons.OK, MessageBoxIcon.Information)
                DataGridView1.DataSource = client.getAllClients()
            Else
                MessageBox.Show("Client Not Added", "Added Client", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If

    End Sub

    Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click

        Dim fname As String = TextBoxFname.Text
        Dim lname As String = TextBoxLname.Text
        Dim phone As String = TextBoxPhone.Text
        Dim email As String = TextBoxEmail.Text

        If TextBoxId.Text.Trim().Equals("") Then
            MessageBox.Show("Select The User You Want to Edit", "Missing ID", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            If fname.Trim().Equals("") Or lname.Trim().Equals("") Or phone.Trim().Equals("") Then
                MessageBox.Show("Required First & Last Name, Phone", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Else
                Dim id As Integer = Convert.ToInt32(TextBoxId.Text)
                If client.editClient(id, fname, lname, phone, email) Then
                    MessageBox.Show("Client Updated Successfully", "Edit client", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    DataGridView1.DataSource = client.getAllClients()
                Else
                    MessageBox.Show("Client Not Upadated", "Edit Client", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        End If



    End Sub

    Private Sub ButtonRemove_Click(sender As Object, e As EventArgs) Handles ButtonRemove.Click

        If TextBoxId.Text.Trim().Equals("") Then
            MessageBox.Show("Enter The Client Id", "Missing ID", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim id As Integer = Convert.ToInt32(TextBoxId.Text)
            If client.removeClient(id) Then
                MessageBox.Show("Client Deleted Successfully", "Delete client", MessageBoxButtons.OK, MessageBoxIcon.Information)
                DataGridView1.DataSource = client.getAllClients()

                ' clear boxes
                TextBoxId.Text = ""
                TextBoxFname.Text = ""
                TextBoxLname.Text = ""
                TextBoxPhone.Text = ""
                TextBoxEmail.Text = ""

            Else
                MessageBox.Show("Client Not Deleted", "Delete Client", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub
    ' display the selected datagridview row data into textboxes
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        TextBoxId.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString()
        TextBoxFname.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()
        TextBoxLname.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString()
        TextBoxPhone.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString()
        TextBoxEmail.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString()

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class