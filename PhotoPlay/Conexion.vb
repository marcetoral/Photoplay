Imports MySql.Data.MySqlClient

Module Conexion
    Private cadenaConexion As String = "server=127.0.0.1;database=photoplay3;user id=root;password='';port=3306;"
    Private conn As New MySqlConnection(cadenaConexion)
    Dim adaptador As New MySqlDataAdapter
    Dim datos As New DataSet
    Public Sub conexion()
        conn.Open()
    End Sub


    Public Function sacarPregunta(ByRef numPregunta As Integer)

        Dim consulta As String = "SELECT preguntas.Pregunta, preguntas.Respuesta1, preguntas.Respuesta2, preguntas.Respuesta3, preguntas.Respuesta4, preguntas.RespuestaCorrecta, preguntas.Foto FROM preguntas WHERE IdPregunta='" & numPregunta & "';"
        Dim correcta As Integer
        adaptador = New MySqlDataAdapter(consulta, conn)
        datos = New DataSet()

        adaptador.Fill(datos, "preguntas")

        FormJuego.btnR1.Text = datos.Tables(0).Rows(0).Item(1)
        FormJuego.btnR2.Text = datos.Tables(0).Rows(0).Item(2)
        FormJuego.btnR3.Text = datos.Tables(0).Rows(0).Item(3)
        FormJuego.btnR4.Text = datos.Tables(0).Rows(0).Item(4)

        FormJuego.lblPregunta.Text = datos.Tables(0).Rows(0).Item(0)

        FormJuego.Foto.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & datos.Tables("preguntas").Rows(0).Item(6).ToString)

        correcta = datos.Tables(0).Rows(0).Item(5)

        Return correcta

    End Function

    Public Sub sacarPista() 'solo hay 2 preguntas con pista asi que no lo uso al final

        Dim consulta As String = "SELECT preguntas.Pista FROM preguntas" 'where id=idPregunta

        adaptador = New MySqlDataAdapter(consulta, conn)
        datos = New DataSet

        adaptador.Fill(datos, "preguntas")

        FormRanking.DataGridView1.DataSource = datos
        FormRanking.DataGridView1.DataMember = "preguntas"


    End Sub 'solo hay 2 preguntas con pista, así que no lo uso al final

    Public Sub inicializarArrayPreguntas(ByVal dificultad As Integer)

        Dim consulta As String = "SELECT preguntas.IdPregunta FROM preguntas WHERE Dificultad='" & dificultad & "';"
        adaptador = New MySqlDataAdapter(consulta, conn)
        datos = New DataSet()

        adaptador.Fill(datos, 0)
        Dim i As Integer

        Select Case dificultad
            Case 1
                For i = 0 To datos.Tables(0).Rows.Count - 1
                    FormJuego.pregF.Add(datos.Tables(0).Rows(i).Item(0))
                Next
            Case 2
                For i = 0 To datos.Tables(0).Rows.Count - 1
                    FormJuego.pregM.Add(datos.Tables(0).Rows(i).Item(0))
                Next
            Case 3
                For i = 0 To datos.Tables(0).Rows.Count - 1
                    FormJuego.pregD.Add(datos.Tables(0).Rows(i).Item(0))
                Next
            Case 4
                For i = 0 To datos.Tables(0).Rows.Count - 1
                    FormJuego.pregMD.Add(datos.Tables(0).Rows(i).Item(0))
                Next
        End Select

    End Sub

    Public Sub insertJugadorRecord()

        Try
            Dim Comando As New MySqlCommand("INSERT INTO jugadores(Nombre, Record) VALUES('" & Nick.tbNick.Text & "','" & FormJuego.puntos & "')", conn)

            Comando.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error")
        End Try
        Nick.tbNick.Text = ""
    End Sub

    Public Sub cerrarConexion()
        conn.Close()
    End Sub

End Module
