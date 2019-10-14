Public Class Inicio
    Private Sub Inicio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        Module1.user = txtUsuarioIngresado.Text



    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Form1.Show()


        Module1.user = txtUsuarioIngresado.Text

        Dim usrIngresado As String
        Dim pswingresado As String
        Dim usrBD As String
        Dim pswBD As String

        Try
            usrIngresado = txtUsuarioIngresado.Text
            pswingresado = txtContraseñaIngresada.Text
        Catch ex As Exception
            lblError.Text = ex.Message
        End Try

        Try
            Dim clasecnn = New Connection_PgSQL
            Dim conexion As New Npgsql.NpgsqlConnection()
            conexion = clasecnn.OpenConnection()

            Dim cmd = New Npgsql.NpgsqlCommand()
            cmd.Connection = conexion

            Dim commandString = "select nombre_usr,contraseña from usuario where nombre_usr = @nombre_usr"

            cmd.CommandText = commandString
            cmd.Parameters.AddWithValue("@nombre_usr", NpgsqlTypes.NpgsqlDbType.Varchar).Value = usrIngresado

            Dim lector As Npgsql.NpgsqlDataReader
            lector = cmd.ExecuteReader

            If lector.HasRows Then

                lector.Read()
                usrBD = lector(0).ToString
                pswBD = lector(1).ToString

                If usrBD = usrIngresado And pswBD = pswingresado Then
                    Form1.Show()
                Else
                    lblError.Text = "password o nombre de usuario erroeneos."
                End If

                'Dim tipoDOC = lector(1).ToString
                'txbNombre.Text = lector(2).ToString
                'txbApellido.Text = lector(3).ToString


                'If tipoDOC Then
                '    rbCedula.Checked = True
                'Else
                '    rbPaasaporte.Checked = True
                'End If

                lector.Close()

            End If


        Catch ex As Exception
            lblError.Text = ex.Message
        End Try





    End Sub

    Private Sub Inicio_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

    End Sub

    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover
        Button1.ForeColor = System.Drawing.Color.DimGray

    End Sub
    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.ForeColor = Color.FromArgb(214, 175, 26)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub
    Private Sub Button2_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover
        Button1.ForeColor = System.Drawing.Color.DimGray

    End Sub
    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.ForeColor = Color.FromArgb(214, 175, 26)

    End Sub
End Class