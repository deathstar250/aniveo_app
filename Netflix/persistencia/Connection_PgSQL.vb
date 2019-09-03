Public Class Connection_PgSQL
    Public Function OpenConnection() As Npgsql.NpgsqlConnection
        Dim connection As Npgsql.NpgsqlConnection
        connection = New Npgsql.NpgsqlConnection()

        Dim connectionString As String
        connectionString = "Server=10.1.1.66;Port=4444;User Id='postgres';Password='root';Database=ANIVEO"
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
