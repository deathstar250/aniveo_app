Public Class ModificarPelicula
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub
    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) 
        btnModificarPelicula.ForeColor = System.Drawing.Color.DimGray

    End Sub
    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs)
        btnModificarPelicula.ForeColor = Color.FromArgb(214, 175, 26)

    End Sub

    Private Sub btnModificarPelicula_Click(sender As Object, e As EventArgs) Handles btnModificarPelicula.Click

        Try

            Dim titulo As String = txtTituloNuevoPelicula.Text
            Dim genero As String = txtGenero.Text
            Dim duracionM As Integer = txtDuracionPeliculaMinutos.Text
            Dim duracionS As Integer = txtDuracionPeliculaSegundos.Text
            Dim link As String = txtLinkPelicula.Text
            Dim sinposis As String = txtDescripcionPelicula.Text
            Dim calificacion As Integer = txtCalificacionPelicula.Text
            Dim reparto As String = txtRepartoPelicula.Text
            Dim id As Integer = txtId.Text


            'update contenido set titulo='1',genero='1',duracion_minutos=1,duracion_segundos=1,link='1',sinopsis='1',calificacion=1,reparto='1' where id=1;

            Dim connectionClass = New Connection_PgSQL
            Dim connection = New Npgsql.NpgsqlConnection()
            connection = connectionClass.OpenConnection()

            Dim cmd = New Npgsql.NpgsqlCommand()
            cmd.Connection = connection


            Dim commandString = "update contenido set titulo=@titulo,genero=@genero,duracion_minutos=@duracion_minutos,duracion_segundos=@duracion_segundos,link=@link,sinopsis=@sinopsis,calificacion=@calificacion,reparto=@reparto where id=@id;"

            cmd.CommandText = commandString

            cmd.Parameters.Add("@titulo", NpgsqlTypes.NpgsqlDbType.Varchar, 20).Value = titulo
            cmd.Parameters.Add("@genero", NpgsqlTypes.NpgsqlDbType.Varchar, 20).Value = genero
            cmd.Parameters.Add("@duracion_minutos", NpgsqlTypes.NpgsqlDbType.Integer).Value = duracionM
            cmd.Parameters.Add("@duracion_segundos", NpgsqlTypes.NpgsqlDbType.Integer).Value = duracionS
            cmd.Parameters.Add("@link", NpgsqlTypes.NpgsqlDbType.Varchar, 100).Value = link
            cmd.Parameters.Add("@sinopsis", NpgsqlTypes.NpgsqlDbType.Varchar, 100).Value = sinposis
            cmd.Parameters.Add("@calificacion", NpgsqlTypes.NpgsqlDbType.Integer).Value = calificacion
            cmd.Parameters.Add("@reparto", NpgsqlTypes.NpgsqlDbType.Varchar, 50).Value = reparto
            cmd.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = id

            Dim resultado As Integer

            resultado = cmd.ExecuteNonQuery()

            If (resultado >= 0) Then
                lblError.Text = "Cambios Efectuados"
            Else
                lblError.Text = "Error consulte soporte"
            End If

            connection.Close()
            cmd.Parameters.Clear()

        Catch ex As Exception
            lblError.Text = ex.Message
        End Try


    End Sub

    Private Sub lblModificarPelicula_Click(sender As Object, e As EventArgs) Handles lblModificarPelicula.Click

    End Sub

    Private Sub txtId_TextChanged(sender As Object, e As EventArgs) Handles txtId.TextChanged

    End Sub
End Class