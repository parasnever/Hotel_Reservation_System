Imports MySql.Data.MySqlClient
Imports Mysqlx.Expr

Public Class CLIENT
    Dim connection As New CONNECTION()


    'create a function to insert a new client
    Function addClient(ByVal fname As String, ByVal lname As String, ByVal phone As String, ByVal email As String) As Boolean
        Dim command As New MySqlCommand("INSERT INTO `clients`( `first_name`, `last_name`, `phone`, `email`) VALUES (@fn,@ln,@phn,@eml)", connection.getConnection())
        command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname
        command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname
        command.Parameters.Add("@phn", MySqlDbType.VarChar).Value = phone

        command.Parameters.Add("@eml", MySqlDbType.VarChar).Value = email
        connection.openConnection()

        If command.ExecuteNonQuery() > 0 Then
            connection.closeConnection()
            Return True

        Else
            connection.closeConnection()
            Return False
        End If
    End Function
    'create a function to edit the selected client
    Function editClient(ByVal id As Integer, ByVal fname As String, ByVal lname As String, ByVal phone As String, ByVal email As String) As Boolean
        Dim command As New MySqlCommand("UPDATE `clients` SET `first_name`=@fn,`last_name`=@ln,`phone`=@phn,`email`=@em WHERE `id`=@cid", connection.getConnection())
        command.Parameters.Add("@cid", MySqlDbType.Int32).Value = id
        command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname
        command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname
        command.Parameters.Add("@phn", MySqlDbType.VarChar).Value = phone

        command.Parameters.Add("@em", MySqlDbType.VarChar).Value = email
        connection.openConnection()

        If command.ExecuteNonQuery() > 0 Then
            connection.closeConnection()
            Return True

        Else
            connection.closeConnection()
            Return False
        End If

    End Function

    'create a function to edit the selectd client
    Function removeClient(ByVal cid As Integer) As Boolean
        Dim command As New MySqlCommand("DELETE FROM `clients` WHERE `id`=@cid", connection.getConnection())
        command.Parameters.Add("@cid", MySqlDbType.Int32).Value = cid

        connection.openConnection()

        If command.ExecuteNonQuery() > 0 Then
            connection.closeConnection()
            Return True

        Else
            connection.closeConnection()
            Return False
        End If

    End Function
    'create a function to get a list of all clients
    Function getAllClients() As DataTable

        Dim adapter As New MySqlDataAdapter()
        Dim command As New MySqlCommand()
        Dim table As New DataTable()

        Dim selectQuery As String = "SELECT * FROM `clients`"
        command.CommandText = selectQuery
        command.Connection = connection.getConnection()

        adapter.SelectCommand = command

        adapter.Fill(table)
        Return table
    End Function
End Class
