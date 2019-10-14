Public Class ListarUsuario
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        lvUsuarios.Items.Clear()

        Try

            Dim commandString = "SELECT * FROM USUARIO"

            Dim connectionClass = New Connection_PgSQL()
            Dim connection As Npgsql.NpgsqlConnection
            connection = connectionClass.OpenConnection()

            Dim cmd = New Npgsql.NpgsqlCommand(commandString, connection)

            Dim reader As Npgsql.NpgsqlDataReader = cmd.ExecuteReader()

            If reader.HasRows Then
                Dim i As Integer = 0
                While reader.Read()
                    lvUsuarios.Items.Add(reader(0).ToString)
                    lvUsuarios.Items(i).SubItems.Add(reader(1).ToString)
                    lvUsuarios.Items(i).SubItems.Add(reader(2).ToString)
                    lvUsuarios.Items(i).SubItems.Add(reader(3).ToString)
                    lvUsuarios.Items(i).SubItems.Add(reader(4).ToString)
                    lvUsuarios.Items(i).SubItems.Add(reader(5).ToString)
                    'lvUsuarios.Items(0).SubItems.Add(reader(0).ToString)
                    'lvUsuarios.Items(1).SubItems.Add(reader(1).ToString)
                    'lvUsuarios.Items(2).SubItems.Add(reader(2).ToString)
                    'lvUsuarios.Items(3).SubItems.Add(reader(3).ToString)
                    'lvUsuarios.Items(4).SubItems.Add(reader(4).ToString)
                    'lvUsuarios.Items(5).SubItems.Add(reader(5).ToString)
                    i += 1

                End While
            End If


        Catch ex As Exception

        End Try


    End Sub
End Class