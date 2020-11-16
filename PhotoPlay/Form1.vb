Imports MySql.Data.MySqlClient
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conexion.conexion()
        '    MessageBox.Show("Conectado a la base de datos")

    End Sub

    '************************* EVENTOS DE CLICK ***************************************'

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles Salir.Click
        Conexion.cerrarConexion()
        End
    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles Ajustes.Click
        Sonido.Click()
        FormAjustes.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles Instrucciones.Click
        Sonido.Click()
        FormInstrucciones.Show()
    End Sub

    Private Sub Jugar_Click(sender As Object, e As EventArgs) Handles Jugar.Click
        Sonido.Click()
        Nick.Show()
    End Sub

    Private Sub Ranking_Click(sender As Object, e As EventArgs) Handles Ranking.Click
        Sonido.Click()
        FormRanking.Show()
    End Sub

    '************************* EVENTOS HOVER ***************************************'

    Private Sub Salir_MouseHover(sender As Object, e As EventArgs) Handles Salir.MouseHover
        lblSeleccion.ForeColor = Color.Orange
        '   lblSeleccion.Location = New Point(455, 94)
        lblSeleccion.Text = "Salir"
    End Sub
    Private Sub Jugar_MouseHover(sender As Object, e As EventArgs) Handles Jugar.MouseHover
        lblSeleccion.ForeColor = Color.Gold
        '     lblSeleccion.Location = New Point(440, 94)
        lblSeleccion.Text = "Jugar"
    End Sub
    Private Sub Ajustes_MouseHover(sender As Object, e As EventArgs) Handles Ajustes.MouseHover
        lblSeleccion.ForeColor = Color.CornflowerBlue    'MidnightBlue
        '     lblSeleccion.Location = New Point(435, 94)
        lblSeleccion.Text = "Ajustes"
    End Sub
    Private Sub Instrucciones_MouseHover(sender As Object, e As EventArgs) Handles Instrucciones.MouseHover
        lblSeleccion.ForeColor = Color.Crimson
        '      lblSeleccion.Location = New Point(380, 94)
        lblSeleccion.Text = "Instrucciones"
    End Sub
    Private Sub Ranking_MouseHover(sender As Object, e As EventArgs) Handles Ranking.MouseHover
        lblSeleccion.ForeColor = Color.Violet
        '      lblSeleccion.Location = New Point(380, 94)
        lblSeleccion.Text = "Ranking"
    End Sub
    Private Sub Proximamente_MouseHover(sender As Object, e As EventArgs) Handles Proximamente.MouseHover
        lblSeleccion.ForeColor = Color.LightGreen
        '      lblSeleccion.Location = New Point(380, 94)
        lblSeleccion.Text = "Próximamente"
    End Sub

    Private Sub lblSeleccion_Click(sender As Object, e As EventArgs) Handles lblSeleccion.Click
        Dim opcion As String = lblSeleccion.Text
        Select Case opcion

            Case "Jugar"
                Nick.Show()
            Case "Ranking"
                FormRanking.Show()
            Case "Instrucciones"
                FormInstrucciones.Show()
            Case "Próximamente"
            Case "Ajustes"
                FormAjustes.Show()
            Case "Salir"
                Conexion.cerrarConexion()
                End
        End Select
    End Sub

End Class
