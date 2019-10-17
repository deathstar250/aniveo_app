Public Class BorrarComentarios
    Private Sub BorrarComentarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim id_Comentario As Integer = txtComentarioAEliminar.Text

            Dim connectionClass = New Connection_PgSQL
            Dim connection = New Npgsql.NpgsqlConnection()
            connection = connectionClass.OpenConnection()

            Dim cmd = New Npgsql.NpgsqlCommand()
            cmd.Connection = connection
            Dim resultado As Integer

            Dim commandString = "delete from comentario_contenido where id_comentario = @_id"
            cmd.CommandText = commandString
            cmd.Parameters.Add("@_id", NpgsqlTypes.NpgsqlDbType.Integer).Value = id_Comentario
            resultado = cmd.ExecuteNonQuery()

            commandString = "delete from comentario where id = @_id"
            cmd.CommandText = commandString
            resultado = cmd.ExecuteNonQuery()

            If (resultado >= 0) Then
                'lblError.Text = "Enhorabuena, eliminado corretamente"
            Else
                'lblError.Text = "Error al eliminar"
            End If

            connection.Close()
            cmd.Parameters.Clear()


        Catch ex As Exception
            'lblError.Text = ex.Message
        End Try
    End Sub
End Class