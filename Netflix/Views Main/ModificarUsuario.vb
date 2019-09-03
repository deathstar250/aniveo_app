Public Class ModificarUsuario
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub Button1_MouseHover(sender As Object, e As EventArgs)
        btnModificarUsuario.ForeColor = System.Drawing.Color.DimGray

    End Sub
    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs)
        btnModificarUsuario.ForeColor = Color.FromArgb(214, 175, 26)

    End Sub

    Private Sub btnModificarUsuario_Click(sender As Object, e As EventArgs) Handles btnModificarUsuario.Click
        Dim nombre As String
        Dim apellido As String
        Dim contrasenia As String
        Dim correo As String
        Dim fechaNacimiento As Date


        Try
            Try

                nombre = txtNombreNuevoUsuario.Text
                apellido = txtApellidoNuevoUsuario.Text
                contrasenia = txtContraseniaNuevaUsuario.Text
                correo = txtCorreoNuevoUsuario.Text
                fechaNacimiento = txtFechaNacimientoUsuario.Text


            Catch ex As Exception
                Label2.Text = ex.Message
            End Try

            Dim connectionClass = New Connection_PgSQL
            Dim connection = New Npgsql.NpgsqlConnection()
            connection = connectionClass.OpenConnection()

            Dim cmd = New Npgsql.NpgsqlCommand()
            cmd.Connection = connection

            Dim commandString = "UPDATE 'usuario' SET 'nombre' = '@nombre';
                                 UPDATE 'usuario' SET 'apellido' = '@apellido';
                                 UPDATE 'usuario' SET 'contrasenia' = '@contrasenia';
                                 UPDATE 'usuario' SET 'correo' = '@correo';
                                 UPDATE 'usuario' SET 'fechaNacimiento' = '@fechaNacimiento';"

            cmd.CommandText = commandString

            Dim resultado As Integer

            resultado = cmd.ExecuteNonQuery()

            If (resultado >= 0) Then
                Label2.Text = "Enhorabuena, el usuario se modifico correctamente"
            Else
                Label2.Text = "Le has errado al bizcochardo"
            End If

        Catch ex As Exception

        End Try

    End Sub
End Class