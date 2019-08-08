Public Class Connection_PgSQL
    Public Function OpenConnection() As Npgsql.NpgsqlConnection
        Dim connection As Npgsql.NpgsqlConnection
        connection = New Npgsql.NpgsqlConnection()

        Dim connectionString As String
        connectionString = "Server=127.0.0.1;Port=4444;Database=ANIVEO;User Id=postgres;Password=root;"
        Try
            connection.ConnectionString = connectionString
            connection.Open()
        Catch ex As Exception
            connection.Close()
            Throw ex
        End Try

        Return connection
    End Function
End Class
