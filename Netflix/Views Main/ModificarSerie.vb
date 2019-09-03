Public Class ModificarSerie
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles btnModificarSerie.MouseHover
        btnModificarSerie.ForeColor = System.Drawing.Color.DimGray

    End Sub
    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles btnModificarSerie.MouseLeave
        btnModificarSerie.ForeColor = Color.FromArgb(214, 175, 26)

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles lblCalificacionSerie.Click

    End Sub

    Private Sub txtCalificacion_TextChanged(sender As Object, e As EventArgs) Handles txtCalificacionSerie.TextChanged

    End Sub

    Private Sub btnModificarSerie_Click(sender As Object, e As EventArgs) Handles btnModificarSerie.Click
        Dim serieModificar As String
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

                serieModificar = cbxModificarSerie.SelectedItem
                titulo = txtTituloNuevoSerie.Text
                fechaEstreno = txtFechaEstrenoSerie.Text
                duracion = txtDescripcionSerie.Text
                genero = cbxGeneroSerie.SelectedItem
                linkCaratula = txtLinkCaratulaSerie.Text
                calificacion = txtCalificacionSerie.Text
                descripcion = txtDescripcionSerie.Text
                reparto = txtRepartoSerie.Text

            Catch ex As Exception
                Label2.Text = ex.Message
            End Try

            Dim connectionClass = New Connection_PgSQL
            Dim connection = New Npgsql.NpgsqlConnection()
            connection = connectionClass.OpenConnection()

            Dim cmd = New Npgsql.NpgsqlCommand()
            cmd.Connection = connection

            Dim commandString = "UPDATE 'serie' SET 'serieModificar' = '@serieModificar';
                                 UPDATE 'serie' SET 'titulo' = '@titulo';
                                 UPDATE 'serie' SET 'fechEstreno' = '@fechaEstreno';
                                 UPDATE 'serie' SET 'duracion' = '@duracion';
                                 UPDATE 'serie' SET 'genero' = '@genero';
                                 UPDATE 'serie' SET 'linkCaratula' = '@linkCaratula';
                                 UPDATE 'serie' SET 'calificacion' = '@calificacion';
                                 UPDATE 'serie' SET 'descripcion' = '@descripcion';
                                 UPDATE 'serie' SET 'reparto' = '@reparto';"

            cmd.CommandText = commandString

            Dim resultado As Integer

            resultado = cmd.ExecuteNonQuery()

            If (resultado >= 0) Then
                Label2.Text = "Enhorabuena, serie se modifico correctamente"
            Else
                Label2.Text = "Le has errado al bizcochardo"
            End If

        Catch ex As Exception

        End Try

    End Sub
End Class