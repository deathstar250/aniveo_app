﻿Public Class ModificarPelicula
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub
    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) 
        btnModificarPelicula.ForeColor = System.Drawing.Color.DimGray

    End Sub
    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) 
        btnModificarPelicula.ForeColor = Color.FromArgb(214, 175, 26)

    End Sub
End Class