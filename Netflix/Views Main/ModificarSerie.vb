Public Class ModificarSerie
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles btnModificarSerie.MouseHover
        btnModificarSerie.ForeColor = System.Drawing.Color.DimGray

    End Sub
    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles btnModificarSerie.MouseLeave
        btnModificarSerie.ForeColor = Color.FromArgb(214, 175, 26)

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles lblCalificacionSerie.Click

    End Sub

    Private Sub txtCalificacion_TextChanged(sender As Object, e As EventArgs) Handles txtCalificacionSerie.TextChanged

    End Sub
End Class