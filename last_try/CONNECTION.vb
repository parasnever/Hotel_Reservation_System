Imports MySql.Data.MySqlClient

Public Class CONNECTION
    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=vbnet_hotelreservation_db")

    'return the connection

    Function getConnection() As MySqlConnection
    Return CONNECTION

End Function

'open the connection
Sub openConnection()
    If CONNECTION.State = ConnectionState.Closed Then
        CONNECTION.Open()


    End If
End Sub

    'close the connection 
    Sub closeConnection()
        If CONNECTION.State = ConnectionState.Open Then
            CONNECTION.Close()

        End If
    End Sub
End Class