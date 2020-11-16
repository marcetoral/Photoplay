Imports MySql.Data.MySqlClient
Module Pregunta


    Public Function sacarPregunta(ByRef conexion As MySqlConnection, ByVal adaptador As MySqlDataAdapter, ByRef datos As DataSet, ByRef numPregunta As Integer, ByRef imgArray As ArrayList, ByRef contador As Integer)

        Dim consulta As String = "SELECT preguntas.Pregunta, preguntas.Respuesta1, preguntas.Respuesta2, preguntas.Respuesta3, preguntas.Respuesta4, preguntas.RespuestaCorrecta, preguntas.Foto FROM preguntas WHERE IdPregunta='" & numPregunta & "';"
        Dim correcta As Integer
        adaptador = New MySqlDataAdapter(consulta, conexion)
        datos = New DataSet()

        adaptador.Fill(datos, "preguntas")

        FormJuego.lblPregunta.Text = datos.Tables("preguntas").Rows(0).Item(0)
        FormJuego.btnR1.Text = datos.Tables("preguntas").Rows(0).Item(1)
        FormJuego.btnR2.Text = datos.Tables("preguntas").Rows(0).Item(2)
        FormJuego.btnR3.Text = datos.Tables("preguntas").Rows(0).Item(3)
        FormJuego.btnR4.Text = datos.Tables("preguntas").Rows(0).Item(4)




        FormJuego.Foto.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & datos.Tables("preguntas").Rows(0).Item(6).ToString)
        contador += 1
        correcta = datos.Tables("preguntas").Rows(0).Item(5)

        Return correcta

    End Function
    Public Sub sacarPista(ByRef conexion As MySqlConnection, ByVal adaptador As MySqlDataAdapter, ByRef datos As DataSet)

        Dim consulta As String = "SELECT preguntas.Pista FROM preguntas"

        adaptador = New MySqlDataAdapter(consulta, conexion)
        datos = New DataSet

        adaptador.Fill(datos, "preguntas")

        FormRanking.DataGridView1.DataSource = datos
        FormRanking.DataGridView1.DataMember = "preguntas"


    End Sub

End Module
