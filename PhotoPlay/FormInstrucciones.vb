Public Class FormInstrucciones
    Private pagina As Integer = 1

    Private Sub Ajustes_Click(sender As Object, e As EventArgs) Handles Salir.Click
        Sonido.Click()
        Me.Close()
        Form1.Show()
        pagina = 1
    End Sub

    Private Sub FormInstrucciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PartidaNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Sonido.Click()
        Select Case [pagina]
            Case 1
                Me.BackgroundImage = My.Resources.FondoIns_2_
            Case 2
                Me.BackgroundImage = My.Resources.FondoIns_3_
            Case 3
                Me.BackgroundImage = My.Resources.FondoIns_4_
            Case 4
                Me.BackgroundImage = My.Resources.FondoIns_5_
        End Select
        If pagina < 5 Then
            pagina += 1
        End If


    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Sonido.Click()
        Select Case [pagina]
            Case 1
                Me.BackgroundImage = My.Resources.FondoIns_1_
            Case 2
                Me.BackgroundImage = My.Resources.FondoIns_1_
            Case 3
                Me.BackgroundImage = My.Resources.FondoIns_2_
            Case 4
                Me.BackgroundImage = My.Resources.FondoIns_3_
            Case 5
                Me.BackgroundImage = My.Resources.FondoIns_4_
        End Select
        If pagina > 1 Then
            pagina -= 1
        End If

    End Sub
End Class