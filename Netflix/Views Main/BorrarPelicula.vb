Public Class BorrarPelicula
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover
        Button1.ForeColor = System.Drawing.Color.DimGray

    End Sub
    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.ForeColor = Color.FromArgb(214, 175, 26)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            Dim id_contenido As Integer = txtUsuarioAEliminar.Text

            Dim connectionClass = New Connection_PgSQL
            Dim connection = New Npgsql.NpgsqlConnection()
            connection = connectionClass.OpenConnection()

            Dim cmd = New Npgsql.NpgsqlCommand()
            cmd.Connection = connection
            Dim resultado As Integer

            Dim commandString = "delete from pelicula where idcontenido = @_id"
            cmd.CommandText = commandString
            cmd.Parameters.Add("@_id", NpgsqlTypes.NpgsqlDbType.Integer).Value = id_contenido
            resultado = cmd.ExecuteNonQuery()

            commandString = "delete from contenido where id = @_id"
            cmd.CommandText = commandString
            resultado = cmd.ExecuteNonQuery()

            If (resultado >= 0) Then
                lblError.Text = "Enhorabuena, eliminado corretamente"
            Else
                lblError.Text = "Error al eliminar"
            End If

            connection.Close()
            cmd.Parameters.Clear()


        Catch ex As Exception
            lblError.Text = ex.Message
        End Try
    End Sub
End Class