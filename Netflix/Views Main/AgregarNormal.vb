Public Class AgregarNormal
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        Try

            Dim nombre_usr As String = Adduser.nombre_usr
            Dim descripcion As String = txtDescripcion.Text
            Dim link As String = txtLinkImagen.Text


            Dim connectionClass = New Connection_PgSQL
            Dim connection = New Npgsql.NpgsqlConnection()
            connection = connectionClass.OpenConnection()

            Dim cmd = New Npgsql.NpgsqlCommand()
            cmd.Connection = connection

            Dim commandString = "insert into normal VALUES (@nombreUsr,@descripcion,@link);"
            cmd.CommandText = commandString
            cmd.Parameters.Add("@nombreUsr", NpgsqlTypes.NpgsqlDbType.Integer).Value = nombre_usr
            cmd.Parameters.Add("@descripcion", NpgsqlTypes.NpgsqlDbType.Varchar, 30).Value = descripcion
            cmd.Parameters.Add("@link", NpgsqlTypes.NpgsqlDbType.Varchar, 30).Value = link

            Dim resultado As Integer

            resultado = cmd.ExecuteNonQuery()

            If (resultado >= 0) Then
                LblError.Text = "Enhorabuena, Usario normal creado correctamente"
            Else
                LblError.Text = "Error al crear capitulo-serie"
            End If

            connection.Close()
            cmd.Parameters.Clear()



        Catch ex As Exception
            LblError.Text = ex.Message
        End Try


    End Sub
End Class