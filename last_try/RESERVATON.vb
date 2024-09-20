Imports MySql.Data.MySqlClient

Public Class RESERVATION
    Dim connection As New CONNECTION()
    'add reservation function
    Function addReservation(ByVal roomNumber As Integer, ByVal clientID As Integer, ByVal dateIn As Date, ByVal dateOut As Date) As Boolean
        Dim command As New MySqlCommand("INSERT INTO `reservations`(`client_ID`, `room_Number`, `dataIN`, `dateOUT`) VALUES (@cid,@rn,@dtin,@dtot)", connection.getConnection())
        '@cid,@rn,@dtin,@dtot
        command.Parameters.Add("@cid", MySqlDbType.Int32).Value = clientID
        command.Parameters.Add("@rn", MySqlDbType.Int32).Value = roomNumber
        command.Parameters.Add("@dtin", MySqlDbType.Date).Value = dateIn


        command.Parameters.Add("@dtot", MySqlDbType.Date).Value = dateOut

        connection.openConnection()

        If command.ExecuteNonQuery() > 0 Then
            ' Set the room to reserved
            Dim setRoomToReservedCommand As New MySqlCommand("UPDATE `rooms` SET `reserved`='Yes' WHERE `number`=@num", connection.getConnection())
            setRoomToReservedCommand.Parameters.Add("@num", MySqlDbType.Int32).Value = roomNumber
            setRoomToReservedCommand.ExecuteNonQuery()

            connection.closeConnection()
            Return True
        Else
            connection.closeConnection()
            Return False
        End If


    End Function
    'edit reservation function
    Function editReservation(ByVal reservId As Integer, ByVal roomNumber As Integer, ByVal clientID As Integer, ByVal dateIn As Date, ByVal dateOut As Date) As Boolean
        Dim command As New MySqlCommand("UPDATE `reservations` SET `client_ID`=@cid,`room_Number`=@rn,`dataIN`=@dtin,`dateOUT`=@dtot WHERE `reservID`=@rvid;", connection.getConnection())
        '@cid,@rn,@dtin,@dtot
        command.Parameters.Add("@rvid", MySqlDbType.Int32).Value = reservId
        command.Parameters.Add("@cid", MySqlDbType.Int32).Value = clientID
        command.Parameters.Add("@rn", MySqlDbType.Int32).Value = roomNumber
        command.Parameters.Add("@dtin", MySqlDbType.Date).Value = dateIn


        command.Parameters.Add("@dtot", MySqlDbType.Date).Value = dateOut

        connection.openConnection()

        If command.ExecuteNonQuery() > 0 Then
            connection.closeConnection()
            Return True

        Else
            connection.closeConnection()
            Return False
        End If


    End Function

    'remove reservation function
    Function removeReservation(ByVal reservId As Integer, ByVal roomNumber As Integer) As Boolean
        Dim command As New MySqlCommand("DELETE FROM `reservations` WHERE `reservID`=@rvid;", connection.getConnection())
        '@cid,@rn,@dtin,@dtot
        command.Parameters.Add("@rvid", MySqlDbType.Int32).Value = reservId

        connection.openConnection()

        If command.ExecuteNonQuery() > 0 Then

            'set the room to not reserved
            Dim setRoomToNotReservedCommand As New MySqlCommand("UPDATE `rooms` SET `reserved`='No' WHERE `number`=@num", connection.getConnection())
            setRoomToNotReservedCommand.Parameters.Add("@num", MySqlDbType.Int32).Value = roomNumber
            setRoomToNotReservedCommand.ExecuteNonQuery()
            connection.closeConnection()
            Return True

        Else
            connection.closeConnection()
            Return False
        End If


    End Function

    'get all reservation function
    Function getAllReservation() As DataTable
        Dim adapter As New MySqlDataAdapter()
        Dim command As New MySqlCommand()
        Dim table As New DataTable()

        Dim selectQuery As String = "SELECT * FROM `reservations`"
        command.CommandText = selectQuery
        command.Connection = connection.getConnection()



        adapter.SelectCommand = command

        adapter.Fill(table)
        Return table
    End Function
End Class