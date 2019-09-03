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
        Dim peliculaModificar As String
        Dim titulo As String
        Dim fechaEstreno As Date
        Dim duracion As Integer
        Dim genero As String
        Dim linkCaratula As String
        Dim calificacion As Integer
        Dim descripcion As String
        Dim reparto As String

        Try
            Try

                peliculaModificar = cbxModificarPelicula.SelectedItem
                titulo = txtTituloNuevoPelicula.Text
                fechaEstreno = txtFechaEstrenoPelicula.Text
                duracion = txtDuracionPelicula.Text
                genero = cbxGeneroPelicula.SelectedItem
                linkCaratula = txtLinkPelicula.Text
                calificacion = txtCalificacionPelicula.Text
                descripcion = txtDescripcionPelicula.Text
                reparto = txtRepartoPelicula.Text

            Catch ex As Exception
                Label2.Text = ex.Message
            End Try

            Dim connectionClass = New Connection_PgSQL
            Dim connection = New Npgsql.NpgsqlConnection()
            connection = connectionClass.OpenConnection()

            Dim cmd = New Npgsql.NpgsqlCommand()
            cmd.Connection = connection

            Dim commandString = "UPDATE 'pelicula' SET 'peliculaModificar' = '@peliculaModificar';
                                 UPDATE 'pelicula' SET 'titulo' = '@titulo';
                                 UPDATE 'pelicula' SET 'fechEstreno' = '@fechaEstreno';
                                 UPDATE 'pelicula' SET 'duracion' = '@duracion';
                                 UPDATE 'pelicula' SET 'genero' = '@genero';
                                 UPDATE 'pelicula' SET 'linkCaratula' = '@linkCaratula';
                                 UPDATE 'pelicula' SET 'calificacion' = '@calificacion';
                                 UPDATE 'pelicula' SET 'descripcion' = '@descripcion';
                                 UPDATE 'pelicula' SET 'reparto' = '@reparto';"

            cmd.CommandText = commandString

            Dim resultado As Integer

            resultado = cmd.ExecuteNonQuery()

            If (resultado >= 0) Then
                Label2.Text = "Enhorabuena, pelicula se modifico correctamente"
            Else
                Label2.Text = "Le has errado al bizcochardo"
            End If

        Catch ex As Exception

        End Try
    End Sub
End Class