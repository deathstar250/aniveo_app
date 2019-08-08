Public Class Inicio
    Private Sub Inicio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        Module1.user = usuariotxt.Text

        Form1.Show()
        Me.Hide()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Module1.user = usuariotxt.Text

        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Inicio_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Form1.Show()
    End Sub

    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover
        Button1.ForeColor = System.Drawing.Color.DimGray

    End Sub
    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.ForeColor = Color.FromArgb(214, 175, 26)

    End Sub


End Class