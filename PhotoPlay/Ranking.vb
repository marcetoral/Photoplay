Imports MySql.Data.MySqlClient

Module Ranking

    Public Sub ordenPuntuacion(ByRef conexion As MySqlConnection, ByVal adaptador As MySqlDataAdapter, ByRef datos As DataSet)

        Dim consulta As String = "SELECT Nombre, MAX(Record) as Record from jugadores GROUP BY Nombre ORDER BY Record DESC"

        adaptador = New MySqlDataAdapter(consulta, conexion)
        datos = New DataSet

        adaptador.Fill(datos, "jugadores")

        FormRanking.DataGridView1.DataSource = datos
        FormRanking.DataGridView1.DataMember = "jugadores"


    End Sub
    Public Sub ordenNombre(ByRef conexion As MySqlConnection, ByVal adaptador As MySqlDataAdapter, ByRef datos As DataSet)

        Dim consulta As String = "SELECT Nombre, MAX(Record) as Record from jugadores GROUP BY Nombre ORDER BY Nombre ASC"

        adaptador = New MySqlDataAdapter(consulta, conexion)
        datos = New DataSet

        adaptador.Fill(datos, "jugadores")

        FormRanking.DataGridView1.DataSource = datos
        FormRanking.DataGridView1.DataMember = "jugadores"


    End Sub
End Module
