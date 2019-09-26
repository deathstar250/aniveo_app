Public Class AgregarPelicula
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim nombrePelicula As String
        'Dim linkPelicula As String
        'Dim linkCaratula As String
        'Try
        '    Try
        '        nombrePelicula = TextBox2.Text
        '        linkPelicula = usuariotxt.Text
        '        linkCaratula = TextBox1.Text


        '    Catch ex As Exception
        '        Label5.Text = ex.Message
        '    End Try


        '    Dim Pelicula As New agregarContenido(nombrePelicula, linkPelicula, linkCaratula)
        '    Dim connectionClass = New Connection_PgSQL
        '    Dim connection = New Npgsql.NpgsqlConnection()
        '    connection = connectionClass.OpenConnection()

        '    Dim cmd = New Npgsql.NpgsqlCommand()
        '    cmd.Connection = connection


        '    Dim commandString = "insert into usuario (nombrePelicula, linkPelicula, linkContenido) values(@nombrePelicula, @linkPelicula, @linkContenido)"

        '    cmd.CommandText = commandString

        '    cmd.Parameters.Add("@nombrePelicula", NpgsqlTypes.NpgsqlDbType.Varchar, 20).Value = Pelicula.nombrePelicula
        '    cmd.Parameters.Add("@linkPelicula", NpgsqlTypes.NpgsqlDbType.Varchar, 20).Value = Pelicula.linkPelicula
        '    cmd.Parameters.Add("@linkCaratula", NpgsqlTypes.NpgsqlDbType.Varchar, 20).Value = Pelicula.linkCaratula

        '    Dim resultado As Integer

        '    resultado = cmd.ExecuteNonQuery()

        '    If (resultado >= 0) Then
        '        Label5.Text = "Enhorabuena, pelicula creada correctamente"
        '    Else
        '        Label5.Text = "Le has errado al bizcochardo"
        '    End If

        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover
        Button1.ForeColor = System.Drawing.Color.DimGray

    End Sub
    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.ForeColor = Color.FromArgb(214, 175, 26)

    End Sub

End Class