Public Class Nick
    Private Sub Nick_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblObligatorio.Text = ""
        tbNick.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Sonido.Click()
        If tbNick.Text.Contains(" ") Then
            lblObligatorio.Text = "No puede contener espacios"

        ElseIf tbNick.Text = "" Then
            lblObligatorio.Text = "Debes escribir un nombre!"

        Else
            Me.Hide()
            FormJuego.Show()
            FormRonda.Show()
            Form1.Hide()
        End If
    End Sub
    Private Sub tbNick_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tbNick.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1_Click(sender, e)
        End If
    End Sub

End Class