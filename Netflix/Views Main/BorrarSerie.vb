Public Class BorrarSerie
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
        Dim seleccion As String
        Try
            Try

                ComboBox1.SelectedItem = seleccion

            Catch ex As Exception
                Label2.Text = ex.Message
            End Try

            Dim connectionClass = New Connection_PgSQL
            Dim connection = New Npgsql.NpgsqlConnection()
            connection = connectionClass.OpenConnection()

            Dim cmd = New Npgsql.NpgsqlCommand()
            cmd.Connection = connection

            Dim commandString = "ALTER TABLE @serie DROP COLUMN @seleccion"

            cmd.CommandText = commandString

            Dim resultado As Integer

            resultado = cmd.ExecuteNonQuery()

            If (resultado >= 0) Then
                Label2.Text = "Enhorabuena, la serie fue borrada correctamente"
            Else
                Label2.Text = "Le has errado al bizcochardo"
            End If

        Catch ex As Exception

        End Try
    End Sub
End Class