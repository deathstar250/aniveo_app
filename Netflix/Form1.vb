﻿Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Useresq.Text = user


    End Sub


    Private Sub CerrarAplicacionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarAplicacionToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AgregarPeliculaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarPeliculaToolStripMenuItem.Click
        AgregarPelicula.ShowDialog()
    End Sub

    Private Sub EliminarPeliculaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarPeliculaToolStripMenuItem.Click
        BorrarPelicula.ShowDialog()
    End Sub

    Private Sub ModificarPeliculaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarPeliculaToolStripMenuItem.Click
        ModificarPelicula.ShowDialog()
    End Sub

    Private Sub AgregarUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarUsuarioToolStripMenuItem.Click
        Adduser.open()
    End Sub

    Private Sub BorrarUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BorrarUsuarioToolStripMenuItem.Click
        BorrarUsuario.ShowDialog()
    End Sub

    Private Sub ModificarUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarUsuarioToolStripMenuItem.Click
        ModificarUsuario.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        ListarComentarios.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        BorrarComentarios.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        ListarUsuario.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        ListarContenido.ShowDialog()
    End Sub
End Class
