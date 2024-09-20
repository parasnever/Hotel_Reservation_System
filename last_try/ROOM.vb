
Imports System.Runtime.InteropServices.JavaScript.JSType
Imports MySql.Data.MySqlClient


Public Class ROOMS
    Dim connection As New CONNECTION()
    ' create a Function To Get a list Of all types of room
    Function getAllRoomsType() As DataTable

        Dim adapter As New MySqlDataAdapter()
        Dim command As New MySqlCommand()
        Dim table As New DataTable()

        Dim selectQuery As String = "SELECT * FROM `rooms_type`"
        command.CommandText = selectQuery
        command.Connection = connection.getConnection()



        adapter.SelectCommand = command

        adapter.Fill(table)
        Return table
    End Function
    ' create a Function To Get a list Of all rooms
    'and we can use this form to get the rooms count
    Function getAllRooms() As DataTable

        Dim adapter As New MySqlDataAdapter()
        Dim command As New MySqlCommand()
        Dim table As New DataTable()

        Dim selectQuery As String = "SELECT * FROM `rooms`"
        command.CommandText = selectQuery
        command.Connection = connection.getConnection()



        adapter.SelectCommand = command

        adapter.Fill(table)
        Return table
    End Function


    ' create a Function To Get room type
    Function getRoomType(ByVal number As Integer) As Integer

        Dim adapter As New MySqlDataAdapter()
        Dim command As New MySqlCommand()
        Dim table As New DataTable()

        Dim selectQuery As String = "SELECT * FROM `rooms` WHERE number=@num"
        command.Parameters.Add("@num", MySqlDbType.Int32).Value = number
        command.CommandText = selectQuery
        command.Connection = connection.getConnection()



        adapter.SelectCommand = command

        adapter.Fill(table)
        Return Convert.ToInt32(table.Rows(0)(1))
    End Function
    'create a function to get not reserved rooms by type

    Function getRoomsByType(ByVal roomType As Integer) As DataTable

        Dim adapter As New MySqlDataAdapter()
        Dim command As New MySqlCommand()
        Dim table As New DataTable()
        'yes mean the room is already reserved
        'and we need only the not reserved ones 
        Dim selectQuery As String = "SELECT * FROM `rooms` WHERE `type`=@tp AND `reserved`='No'"
        command.Parameters.Add("@tp", MySqlDbType.Int32).Value = roomType
        command.CommandText = selectQuery
        command.Connection = connection.getConnection()



        adapter.SelectCommand = command

        adapter.Fill(table)
        Return table
    End Function
    'create a function to add a new room
    Function addRoom(ByVal number As Integer, ByVal type As Integer, ByVal phone As String, ByVal reserved As String) As Boolean
        Dim command As New MySqlCommand("INSERT INTO `rooms`(`number`, `type`, `phone`, `reserved`) VALUES (@num,@tp,@phn,@rsv)", connection.getConnection())
        '@num,@tp,@phn,@rsv
        command.Parameters.Add("@num", MySqlDbType.Int32).Value = number
        command.Parameters.Add("@tp", MySqlDbType.Int32).Value = type
        command.Parameters.Add("@phn", MySqlDbType.VarChar).Value = phone

        command.Parameters.Add("@rsv", MySqlDbType.VarChar).Value = reserved
        connection.openConnection()

        If command.ExecuteNonQuery() > 0 Then
            connection.closeConnection()
            Return True

        Else
            connection.closeConnection()
            Return False
        End If


    End Function
    'create a function to edit a selected room
    Function editRoom(ByVal number As Integer, ByVal type As Integer, ByVal phone As String, ByVal reserved As String) As Boolean
        Dim command As New MySqlCommand("UPDATE `rooms` SET `type`=@tp,`phone`=@phn,`reserved`=@rsv WHERE `number`=@num", connection.getConnection())
        '@num,@tp,@phn,@rsv
        command.Parameters.Add("@num", MySqlDbType.Int32).Value = number
        command.Parameters.Add("@tp", MySqlDbType.Int32).Value = type
        command.Parameters.Add("@phn", MySqlDbType.VarChar).Value = phone

        command.Parameters.Add("@rsv", MySqlDbType.VarChar).Value = reserved
        connection.openConnection()

        If command.ExecuteNonQuery() > 0 Then
            connection.closeConnection()
            Return True

        Else
            connection.closeConnection()
            Return False
        End If


    End Function

    ' create a function to delete the selected room
    Function removeRoom(ByVal roomNumber As Integer) As Boolean
        Dim command As New MySqlCommand("DELETE FROM `rooms` WHERE `number`=@num", connection.getConnection())
        '@num
        command.Parameters.Add("@num", MySqlDbType.Int32).Value = roomNumber
        connection.openConnection()
        If command.ExecuteNonQuery() > 0 Then
            connection.closeConnection()
            Return True

        Else
            connection.closeConnection()
            Return False
        End If
    End Function



End Class