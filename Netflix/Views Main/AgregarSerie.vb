Public Class AgregarSerie
    Private Sub AgregarSerie_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Public Function TraerCantCapitulos()

        Try
            Dim clasecnn = New Connection_PgSQL
            Dim conexion As New Npgsql.NpgsqlConnection()
            conexion = clasecnn.OpenConnection()
            Dim cmd = New Npgsql.NpgsqlCommand()
            cmd.Connection = conexion
            Dim commandString = " select count(*) from capitulo"

            Dim id As Integer

            cmd.CommandText = commandString

            Dim lector As Npgsql.NpgsqlDataReader
            lector = cmd.ExecuteReader

            If lector.HasRows Then

                lector.Read()
                id = lector(0).ToString

                lector.Close()
                cmd.Parameters.Clear()

                Return id

            End If


        Catch ex As Exception
            lblError.Text = ex.Message
        End Try




    End Function

    Public Function CrearCapitulo()

        Try
            Dim id As Integer = AgregarPelicula.traerID() + 1
            Dim idCapitulo As Integer = TraerCantCapitulos() + 1


            Dim connectionClass = New Connection_PgSQL
            Dim connection = New Npgsql.NpgsqlConnection()
            connection = connectionClass.OpenConnection()

            Dim cmd = New Npgsql.NpgsqlCommand()
            cmd.Connection = connection

            Dim commandString = "insert into capitulo VALUES (@_id,@id_Capitulo);"
            cmd.CommandText = commandString
            cmd.Parameters.Add("@_id", NpgsqlTypes.NpgsqlDbType.Integer).Value = id
            cmd.Parameters.Add("@id_Capitulo", NpgsqlTypes.NpgsqlDbType.Integer).Value = idCapitulo

            Dim resultado As Integer

            resultado = cmd.ExecuteNonQuery()

            If (resultado >= 0) Then
                LblError.Text = "Enhorabuena, capitulo creado correctamente"
            Else
                LblError.Text = "Error al crear capitulo"
            End If

            connection.Close()
            cmd.Parameters.Clear()



        Catch ex As Exception
            LblError.Text = ex.Message
        End Try


    End Function

    Public Function crearSerie()
        Try
            Dim nombre As String = txtNombreSerie.Text
            Dim nombreTemporada As Integer = txtNombreTemporada.Text


            Dim connectionClass = New Connection_PgSQL
            Dim connection = New Npgsql.NpgsqlConnection()
            connection = connectionClass.OpenConnection()

            Dim cmd = New Npgsql.NpgsqlCommand()
            cmd.Connection = connection

            Dim commandString = "insert into serie VALUES (@nombre,@temporada);"
            cmd.CommandText = commandString
            cmd.Parameters.Add("@nombre", NpgsqlTypes.NpgsqlDbType.Varchar, 100).Value = nombre
            cmd.Parameters.Add("@temporada", NpgsqlTypes.NpgsqlDbType.Integer).Value = nombreTemporada

            Dim resultado As Integer

            resultado = cmd.ExecuteNonQuery()

            If (resultado >= 0) Then
                LblError.Text = "Enhorabuena, serie creada correctamente"
            Else
                LblError.Text = "Error al crear serie"
            End If

            connection.Close()
            cmd.Parameters.Clear()



        Catch ex As Exception
            LblError.Text = ex.Message
        End Try

    End Function

    Public Function crearSerieCapitulo()

        Try
            Dim idCapitulo As Integer = TraerCantCapitulos()
            Dim nombreSerie As String = txtNombreSerie.Text


            Dim connectionClass = New Connection_PgSQL
            Dim connection = New Npgsql.NpgsqlConnection()
            connection = connectionClass.OpenConnection()

            Dim cmd = New Npgsql.NpgsqlCommand()
            cmd.Connection = connection

            Dim commandString = "insert into capitulo_serie VALUES (@_id,@nombreSerie);"
            cmd.CommandText = commandString
            cmd.Parameters.Add("@_id", NpgsqlTypes.NpgsqlDbType.Integer).Value = idCapitulo
            cmd.Parameters.Add("@nombreSerie", NpgsqlTypes.NpgsqlDbType.Varchar, 30).Value = nombreSerie

            Dim resultado As Integer

            resultado = cmd.ExecuteNonQuery()

            If (resultado >= 0) Then
                LblError.Text = "Enhorabuena, capitulo-serie creado correctamente"
            Else
                LblError.Text = "Error al crear capitulo-serie"
            End If

            connection.Close()
            cmd.Parameters.Clear()



        Catch ex As Exception
            LblError.Text = ex.Message
        End Try

    End Function

    Private Sub lblInfo_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        CrearCapitulo()
        crearSerie()
        crearSerieCapitulo()

    End Sub

    Private Sub txtNombrePelicula_TextChanged(sender As Object, e As EventArgs) Handles txtNombreSerie.TextChanged

    End Sub
End Class