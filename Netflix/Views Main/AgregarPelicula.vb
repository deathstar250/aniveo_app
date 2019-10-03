Public Class AgregarPelicula

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            Dim _id As Integer = traerID() + 1
            Dim _titulo As String = txtNombrePelicula.Text
            Dim _genero As String = txtGenero.Text
            Dim _duracion_minutos As Integer = txtDuracionMinutos.Text
            Dim _duracion_segundos As Integer = txtDuracionSegundos.Text
            Dim _link As String = txtLink.Text
            Dim _sinopsis As String = txtSinopsis.Text
            Dim _calificacion_id As Integer = txtCalificacion.Text
            Dim _reparto As String = txtReparto.Text
            Dim _fecha_estreno As Date

            Try
                _fecha_estreno = calendar.SelectionRange.Start
            Catch ex As Exception
                lblError.Text = ex.Message
            End Try

            Dim contenido = New agregarContenido(_id, _titulo, _genero, _duracion_minutos, _duracion_segundos, _link, _sinopsis, _calificacion_id, _reparto, _fecha_estreno)





        Catch ex As Exception

        End Try
    End Sub

    Public Function traerID()

        Try
            Dim clasecnn = New Connection_PgSQL
            Dim conexion As New Npgsql.NpgsqlConnection()
            conexion = clasecnn.OpenConnection()
            Dim cmd = New Npgsql.NpgsqlCommand()
            cmd.Connection = conexion
            Dim commandString = " select count(*) from contenido"

            Dim id As Integer

            cmd.CommandText = commandString

            Dim lector As Npgsql.NpgsqlDataReader
            lector = cmd.ExecuteReader

            If lector.HasRows Then

                lector.Read()
                id = lector(0).ToString

                lector.Close()
                cmd.Parameters.Clear()
                lblError.Text = id
            End If


        Catch ex As Exception
            lblError.Text = ex.Message
        End Try


    End Function


    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover
        Button1.ForeColor = System.Drawing.Color.DimGray

    End Sub
    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.ForeColor = Color.FromArgb(214, 175, 26)

    End Sub

    Private Sub AgregarPelicula_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub txtSinopsis_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub txtCalificacion_TextChanged(sender As Object, e As EventArgs) Handles txtCalificacion.TextChanged

    End Sub
End Class