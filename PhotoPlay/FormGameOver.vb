
Imports MySql.Data.MySqlClient
Public Class FormGameOver

    Private cadenaConexion As String = "server=127.0.0.1;database=photoplay3;user id=root;password='';port=3306;"
    Private conn As New MySqlConnection(cadenaConexion)
    Dim adaptador As New MySqlDataAdapter
    Dim datos As New DataSet
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblGameOver.Click

    End Sub
    Private Sub FormGameOver_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (FormJuego.puntos < 10000) Then
            lblPuntos.Text = "Sólo " & FormJuego.puntos & " puntos? Hay que entrenar más eh!"
        Else
            lblPuntos.Text = FormJuego.puntos & " puntos! GG"
        End If
        Conexion.insertJugadorRecord()
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Form1.Show()
        Me.Close()
        FormJuego.Close()
    End Sub
End Class