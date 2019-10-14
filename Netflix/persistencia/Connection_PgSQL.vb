Public Class Connection_PgSQL
    Public Function OpenConnection() As Npgsql.NpgsqlConnection
        Dim connection As Npgsql.NpgsqlConnection
        connection = New Npgsql.NpgsqlConnection()

        Dim connectionString As String
        'connectionString = "Server=10.1.2.5;Port=5432;Database=Aniveo;UserId=postgres;Password=aniveo;"
        connectionString = "Server=localhost;Port=4444;Database=Aniveo2;UserId=postgres;Password=root;"
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
