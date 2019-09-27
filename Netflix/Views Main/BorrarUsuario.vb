Public Class BorrarUsuario
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub


    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover
        Button1.ForeColor = System.Drawing.Color.DimGray

    End Sub
    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.ForeColor = Color.FromArgb(214, 175, 26)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim usuarioAEliminar As String = txtUsuarioAEliminar.Text

        Dim connectionClass = New Connection_PgSQL
        Dim connection = New Npgsql.NpgsqlConnection()
        connection = connectionClass.OpenConnection()

        Dim cmd = New Npgsql.NpgsqlCommand()
        cmd.Connection = connection

        Dim commandString = "delete from usuario where nombre_usr = @nombre_usr"

        cmd.Parameters.Add("@nombre_usr", NpgsqlTypes.NpgsqlDbType.Varchar, 20).Value = usuarioAEliminar


        cmd.CommandText = commandString

        Dim resultado As Integer

        resultado = cmd.ExecuteNonQuery()

        If (resultado >= 0) Then
            lblInfo2.Text = "Ejecutado correctamente"
        Else
            lblInfo2.Text = "Fallo la ejecucion"
        End If

    End Sub
End Class