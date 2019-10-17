Public Class Adduser

    Public nombre_usr As String

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub lblNombreNuevoUsuario_Click(sender As Object, e As EventArgs) Handles lblNombreNuevoUsuario.Click

    End Sub

    Public Sub open()
        Me.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim nombre_usuario As String
        Dim nombre As String
        Dim apellido As String
        Dim correo As String
        Dim fechaNacimiento As Date
        Dim contrasenia As String

        Try

            Try
                nombre_usuario = TxtNombreUsuario.Text
                nombre = txtNombreNuevoUsuario.Text
                apellido = txtApellidoNuevoUsuario.Text
                correo = txtCorreoNuevoUsuario.Text
                contrasenia = txtContraseniaNuevaUsuario.Text

            Catch ex As Exception
                lblErrorAgrgarUsuario.Text = ex.Message
            End Try

            Try
                fechaNacimiento = calendar.SelectionRange.Start
            Catch ex As Exception
                lblErrorAgrgarUsuario.Text = ex.Message
            End Try
            Dim _Usuario As New nuevoUsuario(nombre_usuario, nombre, apellido, contrasenia, correo, fechaNacimiento)
            Dim connectionClass = New Connection_PgSQL
            Dim connection = New Npgsql.NpgsqlConnection()
            connection = connectionClass.OpenConnection()

            Dim cmd = New Npgsql.NpgsqlCommand()
            cmd.Connection = connection


            Dim commandString = "insert into usuario (nombre_usr, nombre, apellido, contraseña, correo, fecha_nac) values(@nombre_usuario,@nombre,@apellido,@contrasenia,@correo,@fechaNacimiento)"

            cmd.CommandText = commandString

            cmd.Parameters.Add("@nombre_usuario", NpgsqlTypes.NpgsqlDbType.Varchar, 20).Value = _Usuario.Nombre_usuario
            cmd.Parameters.Add("@nombre", NpgsqlTypes.NpgsqlDbType.Varchar, 20).Value = _Usuario.Nombre
            cmd.Parameters.Add("@apellido", NpgsqlTypes.NpgsqlDbType.Varchar, 20).Value = _Usuario.Apellido
            cmd.Parameters.Add("@contrasenia", NpgsqlTypes.NpgsqlDbType.Varchar, 20).Value = _Usuario.contrasenia
            cmd.Parameters.Add("@correo", NpgsqlTypes.NpgsqlDbType.Varchar, 20).Value = _Usuario.Correo
            cmd.Parameters.Add("@fechaNacimiento", NpgsqlTypes.NpgsqlDbType.Date).Value = _Usuario.FechaNacimiento

            nombre_usuario = nombre_usr

            Dim resultado As Integer

            resultado = cmd.ExecuteNonQuery()

            If (resultado >= 0) Then
                lblErrorAgrgarUsuario.Text = "Enhorabuena, usuario creado correctamente"
            Else
                lblErrorAgrgarUsuario.Text = "Le has errado al bizcochardo"
            End If

            connection.Close()
            cmd.Parameters.Clear()

            If cbxAdministrador.Checked Then
                Try
                    connection = connectionClass.OpenConnection()
                    cmd.Connection = connection

                    cmd.Parameters.Add("@nombre_usuario", NpgsqlTypes.NpgsqlDbType.Varchar, 20).Value = _Usuario.Nombre_usuario
                    commandString = "insert into administrador values (@nombre_usuario)"

                    Dim resultado2 As Integer
                    cmd.CommandText = commandString
                    resultado2 = cmd.ExecuteNonQuery()



                    If (resultado2 >= 0) Then
                        lblErrorAgrgarUsuario.Text = "Enhorabuena, usuario creado correctamente"
                    Else
                        lblErrorAgrgarUsuario.Text = "Le has errado al bizcochardo"
                    End If

                    connection.Close()
                    cmd.Parameters.Clear()
                Catch ex As Exception
                    lblError.Text = ex.Message
                End Try


            ElseIf cbxNormal.Checked Then

                AgregarNormal.Show()

            Else

            End If

        Catch ex As Exception
            lblErrorAgrgarUsuario.Text = ex.Message
        End Try



    End Sub

    Private Sub adduser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txtContraseniaNuevaUsuario.MaskInputRejected

    End Sub
End Class