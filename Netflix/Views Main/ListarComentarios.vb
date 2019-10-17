Public Class ListarComentarios
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        lvlComenrarios.Items.Clear()

        Try

            Dim commandString = "SELECT * FROM view_com"

            Dim connectionClass = New Connection_PgSQL()
            Dim connection As Npgsql.NpgsqlConnection
            connection = connectionClass.OpenConnection()

            Dim cmd = New Npgsql.NpgsqlCommand(commandString, connection)

            Dim reader As Npgsql.NpgsqlDataReader = cmd.ExecuteReader()

            If reader.HasRows Then
                Dim i As Integer = 0
                While reader.Read()
                    lvlComenrarios.Items.Add(reader(0).ToString)
                    lvlComenrarios.Items(i).SubItems.Add(reader(1).ToString)
                    lvlComenrarios.Items(i).SubItems.Add(reader(2).ToString)
                    lvlComenrarios.Items(i).SubItems.Add(reader(3).ToString)
                    'lvlComenrarios.Items(0).SubItems.Add(reader(0).ToString)
                    'lvlComenrarios.Items(1).SubItems.Add(reader(1).ToString)
                    'lvlComenrarios.Items(2).SubItems.Add(reader(2).ToString)
                    'lvlComenrarios.Items(3).SubItems.Add(reader(3).ToString)
                    'lvlComenrarios.Items(4).SubItems.Add(reader(4).ToString)
                    'lvlComenrarios.Items(5).SubItems.Add(reader(5).ToString)
                    i += 1

                End While
            End If


        Catch ex As Exception
            lblError.Text = ex.Message
        End Try
    End Sub
End Class