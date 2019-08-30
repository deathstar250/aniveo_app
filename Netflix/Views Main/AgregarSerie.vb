Public Class AgregarSerie
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nombreSerie As String
        Dim linkSerie As String
        Dim linkCaratula As String
        Try
            Try
                nombreSerie = usuariotxt.Text
                linkSerie = TextBox2.Text
                linkCaratula = TextBox1.Text


            Catch ex As Exception
                Label5.Text = ex.Message
            End Try


            Dim Serie As New nuevaSerie(nombreSerie, linkSerie, linkCaratula)
            Dim connectionClass = New Connection_PgSQL
            Dim connection = New Npgsql.NpgsqlConnection()
            connection = connectionClass.OpenConnection()

            Dim cmd = New Npgsql.NpgsqlCommand()
            cmd.Connection = connection


            Dim commandString = "insert into usuario (nombreSerie, linkSerie, linkContenido) values(@nombreSerie, @linkSerie, @linkContenido)"

            cmd.CommandText = commandString

            cmd.Parameters.Add("@nombreSerie", NpgsqlTypes.NpgsqlDbType.Varchar, 20).Value = Serie.nombreSerie
            cmd.Parameters.Add("@linkSerie", NpgsqlTypes.NpgsqlDbType.Varchar, 20).Value = Serie.linkSerie
            cmd.Parameters.Add("@linkCaratula", NpgsqlTypes.NpgsqlDbType.Varchar, 20).Value = Serie.linkCaratula

            Dim resultado As Integer

            resultado = cmd.ExecuteNonQuery()

            If (resultado >= 0) Then
                Label5.Text = "Enhorabuena, serie creada correctamente"
            Else
                Label5.Text = "Le has errado al bizcochardo"
            End If

        Catch ex As Exception

        End Try
    End Sub
End Class