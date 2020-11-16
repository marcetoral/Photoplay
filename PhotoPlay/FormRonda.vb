Public Class FormRonda
    Private Sub FormRonda_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Select Case FormJuego.ronda
            Case 1
                lblRonda.Text = "Ronda fácil!"
            Case 2
                lblRonda.Text = "Ronda media!"
            Case 3
                lblRonda.Text = "Ronda difícil! Memoriza bien la foto!"
            Case 4
                lblRonda.Text = "Ronda súper difícil!"
        End Select


    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Sonido.Click()
        FormJuego.siguientePregunta()
        Me.Close()
    End Sub

End Class