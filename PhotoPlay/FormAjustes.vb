Public Class FormAjustes
    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        Sonido.Click()
        Me.Close()
    End Sub


    Private Sub btnDesActivarMusica_Click(sender As Object, e As EventArgs) Handles btnMusica.Click
        Sonido.MusicaFondo()
        Sonido.Click()
    End Sub

    Private Sub btnSonido_Click(sender As Object, e As EventArgs) Handles btnSonido.Click
        Sonido.SonidoEfectos()
        Sonido.Click()
    End Sub
End Class