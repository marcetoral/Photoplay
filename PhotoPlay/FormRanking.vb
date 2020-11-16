Imports MySql.Data.MySqlClient

Public Class FormRanking
    Dim datos As New DataSet
    Dim DTabla As New DataTable()
    Dim adaptador As New MySqlDataAdapter
    Private cadenaConexion As String = "server=127.0.0.1;database=photoplay3;user id=root;password='';port=3306;"
    Private conn As New MySqlConnection(cadenaConexion)
    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        Sonido.Click()
        Me.Close()
    End Sub
    Private Sub FormRanking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Ranking.ordenPuntuacion(conn, adaptador, datos)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then
            Ranking.ordenPuntuacion(conn, adaptador, datos)
        Else
            Ranking.ordenNombre(conn, adaptador, datos)
        End If
    End Sub


End Class