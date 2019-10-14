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

    Private Sub BtnModificarUsuario_Click(sender As Object, e As EventArgs) Handles btnModificarUsuario.Click

        Dim nombreUsuario As String
        Dim nombre As String
        Dim apellido As String
        Dim password As String
        Dim correo As String
        Dim fecha As String


        Try

            nombreUsuario = txtNombreUsr.Text
            nombre = txtNombreNuevoUsuario.Text
            apellido = txtApellidoNuevoUsuario.Text
            password = txtContraseniaNuevaUsuario.Text
            correo = txtCorreoNuevoUsuario.Text
            fecha = txtFechaNacimientoUsuario.Text

        Catch ex As Exception
            lblError.Text = ex.Message
        End Try

        Try
            Dim clasecnn = New Connection_PgSQL
            Dim conexion As New Npgsql.NpgsqlConnection()
            conexion = clasecnn.OpenConnection()

            Dim cmd = New Npgsql.NpgsqlCommand()
            cmd.Connection = conexion

            Dim commandString = "select * from usuario where nombre_usr = @nombre_usr"

            cmd.CommandText = commandString
            cmd.Parameters.AddWithValue("@nombre_usr", NpgsqlTypes.NpgsqlDbType.Varchar).Value = nombreUsuario

            Dim lector As Npgsql.NpgsqlDataReader
            lector = cmd.ExecuteReader

            If lector.HasRows Then

                lector.Read()
                nombreUsuario = lector(0).ToString
                nombre = lector(1).ToString
                apellido = lector(2).ToString
                password = lector(3).ToString
                correo = lector(4).ToString
                fecha = lector(5).ToString
                lector.Close()

            End If

            conexion.Close()
            cmd.Parameters.Clear()

        Catch ex As Exception
            lblError.Text = ex.Message
        End Try

        Try

            Dim _Usuario As New nuevoUsuario(nombreUsuario, nombre, apellido, password, correo, fecha)
            Dim connectionClass = New Connection_PgSQL
            Dim connection = New Npgsql.NpgsqlConnection()
            connection = connectionClass.OpenConnection()

            Dim cmd = New Npgsql.NpgsqlCommand()
            cmd.Connection = connection


            Dim commandString = "update usuario set  nombre = @nombre, apellido = @apellido, contraseña=@contrasenia, correo=@correo where nombre_usr = @nombre_usuario "

            cmd.CommandText = commandString

            cmd.Parameters.Add("@nombre_usuario", NpgsqlTypes.NpgsqlDbType.Varchar, 20).Value = _Usuario.Nombre_usuario
            cmd.Parameters.Add("@nombre", NpgsqlTypes.NpgsqlDbType.Varchar, 20).Value = _Usuario.Nombre
            cmd.Parameters.Add("@apellido", NpgsqlTypes.NpgsqlDbType.Varchar, 20).Value = _Usuario.Apellido
            cmd.Parameters.Add("@contrasenia", NpgsqlTypes.NpgsqlDbType.Varchar, 20).Value = _Usuario.contrasenia
            cmd.Parameters.Add("@correo", NpgsqlTypes.NpgsqlDbType.Varchar, 20).Value = _Usuario.Correo
            cmd.Parameters.Add("@fechaNacimiento", NpgsqlTypes.NpgsqlDbType.Date).Value = _Usuario.FechaNacimiento

            Dim resultado As Integer

            resultado = cmd.ExecuteNonQuery()

            If (resultado >= 0) Then
                lblError.Text = "Enhorabuena, usuario creado correctamente"
            Else
                lblError.Text = "Le has errado al bizcochardo"
            End If

            connection.Close()
            cmd.Parameters.Clear()

        Catch ex As Exception

        End Try



    End Sub
End Class