Public Class ListarContenido
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        lvContenido.Items.Clear()

        Try

            Dim commandString = "SELECT * FROM view_contenido order by 7"

            Dim connectionClass = New Connection_PgSQL()
            Dim connection As Npgsql.NpgsqlConnection
            connection = connectionClass.OpenConnection()

            Dim cmd = New Npgsql.NpgsqlCommand(commandString, connection)

            Dim reader As Npgsql.NpgsqlDataReader = cmd.ExecuteReader()

            If reader.HasRows Then
                Dim i As Integer = 0
                While reader.Read()
                    lvContenido.Items.Add(reader(0).ToString)
                    lvContenido.Items(i).SubItems.Add(reader(1).ToString)
                    lvContenido.Items(i).SubItems.Add(reader(2).ToString)
                    lvContenido.Items(i).SubItems.Add(reader(3).ToString)
                    lvContenido.Items(i).SubItems.Add(reader(4).ToString)
                    lvContenido.Items(i).SubItems.Add(reader(5).ToString)
                    lvContenido.Items(i).SubItems.Add(reader(6).ToString)
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





        'CREATE View view_contenido
        'as 
        'Select Case c.id,c.titulo,c.genero,c.fecha_estreno,c.duracion_minutos,c.duracion_segundos,
        'cs.idcapitulo, se.temporada from contenido c inner join capitulo s
        'On s.IDContenido = c.id inner join 
        'capitulo_serie  cs on s.IDCapitulo = cs.IDCapitulo
        'inner Join serie se on se.nombre = cs.nombreSerie;


    End Sub
End Class