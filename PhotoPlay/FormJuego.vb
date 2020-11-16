
Imports MySql.Data.MySqlClient
Public Class FormJuego
    '__________________________________________________________'
    '________________________VARIABLES_________________________'
    '__________________________________________________________'
    Private pregunta = 0
    Public ronda = 1
    Private respuestaCorrecta As Integer
    Public puntos As Integer = 0
    Private vidas = 3
    Private puntosMemo As Integer
    Public pregF As New ArrayList() 'Faciles
    Public pregM As New ArrayList() 'Medias
    Public pregD As New ArrayList() 'Dificiles
    Public pregMD As New ArrayList() 'Muy dificiles

    Private cadenaConexion As String = "server=127.0.0.1;database=photoplay3;user id=root;password='';port=3306;"
    Private conn As New MySqlConnection(cadenaConexion)
    Dim adaptador As New MySqlDataAdapter
    Dim datos As New DataSet
    Dim DTabla As New DataTable()


    '__________________________________________________________'
    '________________________FUNCIONES_________________________'
    '__________________________________________________________'
    Private Sub activarBtnsR(ByVal bool As Boolean)   'activa o desactiva los botones de respuesta
        If bool = True Then
            btnR1.Enabled = True
            btnR2.Enabled = True
            btnR3.Enabled = True
            btnR4.Enabled = True
            btnR4.Visible = True
        Else
            btnR1.Enabled = False
            btnR2.Enabled = False
            btnR3.Enabled = False
            btnR4.Enabled = False
        End If

    End Sub
    Private Sub visiblesBtnsR(ByVal bool As Boolean)   'visibles o no los botones de respuesta
        If bool = True Then
            btnR1.Visible = True
            btnR2.Visible = True
            btnR3.Visible = True
            btnR4.Visible = True
            btnR4.Visible = True
        Else
            btnR1.Visible = False
            btnR2.Visible = False
            btnR3.Visible = False
            btnR4.Visible = False
        End If

    End Sub
    Public Function generarRandom(ByVal bajo As Integer, ByVal alto As Integer) 'Genera un numero
        Randomize()
        Dim valor = (alto - bajo) * Rnd() + bajo
        Return valor
    End Function
    Public Function sacarIdPregunta(ByVal dificultad As Integer) 'TODO acortar el código de esta función

        Dim n = 1, r, x As Integer

        Select Case dificultad
            Case 1
                n = pregF.Count

                r = generarRandom(0, n - 1) 'sacar una posición al azar

                Do
                    If (pregF(r) <> 0) Then    'si no ha salido

                        x = pregF(r)  'guardar el valor de esa casilla en x

                        pregF(r) = 0   'marcar la casilla con un 0

                        Return x

                    Else    'si tiene un 0, es que ya ha salido, entonces busca en la siguiente casilla

                        If (r >= n - 1) Then 'si llega al final del bucle, vuelve a 0
                            r = 0
                        Else
                            r += 1
                        End If

                    End If
                Loop Until pregF(r) = -1 'repetir hasta entrar el if
            Case 2
                n = pregM.Count

                r = generarRandom(0, n - 1) 'sacar una posicion al azar

                Do
                    If (pregM(r) <> 0) Then    'si no ha salido

                        x = pregM(r)  'guardar el valor de esa casilla en x

                        pregM(r) = 0   'marcar la casilla con un 0

                        Return x

                    Else    'si tiene un 0, es que ya ha salido, entonces busca en la siguiente casilla

                        If (r >= n - 1) Then 'si llega al final del bucle, vuelve a 0
                            r = 0
                        Else
                            r += 1
                        End If

                    End If
                Loop Until pregM(r) = -1 'repetir hasta entrar el if
            Case 3
                n = pregD.Count

                r = generarRandom(0, n - 1) 'sacar una posicion al azar

                Do
                    If (pregD(r) <> 0) Then    'si no ha salido

                        x = pregD(r)  'guardar el valor de esa casilla en x

                        pregD(r) = 0   'marcar la casilla con un 0

                        Return x

                    Else    'si tiene un 0, es que ya ha salido, entonces busca en la siguiente casilla

                        If (r >= n - 1) Then 'si llega al final del bucle, vuelve a 0
                            r = 0
                        Else
                            r += 1
                        End If

                    End If
                Loop Until pregD(r) = -1 'repetir hasta entrar el if
            Case 4
                n = pregMD.Count

                r = generarRandom(0, n - 1) 'sacar una posicion al azar

                Do
                    If (pregMD(r) <> 0) Then    'si no ha salido

                        x = pregMD(r)  'guardar el valor de esa casilla en x

                        pregMD(r) = 0   'marcar la casilla con un 0

                        Return x

                    Else    'si tiene un 0, es que ya ha salido, entonces busca en la siguiente casilla

                        If (r >= n - 1) Then 'si llega al final del bucle, vuelve a 0
                            r = 0
                        Else
                            r += 1
                        End If

                    End If
                Loop Until pregMD(r) = -1 'repetir hasta entrar el if
        End Select



    End Function

    Private Sub FormJuego_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Inicializar los arrays

        Conexion.inicializarArrayPreguntas(1)
        Conexion.inicializarArrayPreguntas(2)
        Conexion.inicializarArrayPreguntas(3)
        Conexion.inicializarArrayPreguntas(4)


    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If progressBar.Value = 0 And ronda = 3 Then
            Timer1.Stop()
            visiblesBtnsR(True)
            activarBtnsR(True)
            puntosMemo = 1200
            lblPregunta.Visible = True
            Foto.Visible = False


            btnR1.BackColor = Color.SteelBlue
            btnR2.BackColor = Color.SteelBlue
            btnR3.BackColor = Color.SteelBlue
            btnR4.BackColor = Color.SteelBlue
            btnR2.Location = New Point(221, 614)

            If btnR4.Text = "$" Then   'Si es una pregunta de 3 respuestas, la cuarta resp. no la saca
                btnR4.Visible = False
                btnR2.Location = New Point(374, 614)
            End If

        ElseIf progressBar.Value = 0 Then
            Timer1.Stop()
                activarBtnsR(False)
                puntos = progressBar.Value
                btnSeguir.Visible = True
                Sonido.Incorrecto()
                btnR1.BackColor = Color.Firebrick

                Select Case respuestaCorrecta
                    Case 2
                        btnR2.BackColor = Color.YellowGreen
                    Case 3
                        btnR3.BackColor = Color.YellowGreen
                    Case 4
                        btnR4.BackColor = Color.YellowGreen
                End Select

                If vidas > 1 Then
                    vidas -= 1
                Else
                    FormGameOver.Show()

                End If
                lblVidas.Text = vidas
                btnFifty.Visible = False
                Return

        Else
            progressBar.Value -= 1
        End If

        If (progressBar.Value > 750) Then
            progressBar.ForeColor = Color.OliveDrab
        ElseIf (progressBar.Value > 500) Then
            progressBar.ForeColor = Color.Gold
        ElseIf (progressBar.Value > 250) Then
            progressBar.ForeColor = Color.Orange
        Else
            progressBar.ForeColor = Color.Firebrick
        End If

    End Sub

    Private Sub mostrarPantallaPregunta() 'Resetea los botones
        btnSeguir.Visible = False
        lblVidas.Visible = True
        Foto.Visible = True
        If (ronda = 3) Then
            activarBtnsR(False)
            visiblesBtnsR(False)
            progressBar.Value = 1000
            Timer1.Start()
            lblPregunta.Visible = False

        Else
            activarBtnsR(True)
            btnR1.BackColor = Color.SteelBlue
            btnR2.BackColor = Color.SteelBlue
            btnR3.BackColor = Color.SteelBlue
            btnR4.BackColor = Color.SteelBlue
            btnR2.Location = New Point(221, 614)

            If btnR4.Text = "$" Then   'Si es una pregunta des 3 respuestas, la cuarta resp. no la saca
                btnR4.Visible = False
                btnR2.Location = New Point(374, 614)
            End If


            progressBar.Value = 1000
            Timer1.Start()

        End If
    End Sub

    Public Sub siguientePregunta()

        Dim idPregunta As Integer

        If pregunta = 27 Then  'Primero comprueba si ha llegado al número de preguntas posibles 
            'En caso de que hayan salido todas las preguntas, y SÓLO en ese caso, se vuelven a repetir las dificiles
            Conexion.inicializarArrayPreguntas(4)

            idPregunta = sacarIdPregunta(ronda)

        Else  'sacar un id de una pregunta al azar según su dificultad

            idPregunta = sacarIdPregunta(ronda)

        End If

        'sacar la pregunta, respuestas y colocarlas a los botones. Hace return de la respuesta correcta
        respuestaCorrecta = Conexion.sacarPregunta(idPregunta)
        mostrarPantallaPregunta()

    End Sub

    '__________________________________________________________'
    '____________________EVENTOS_CLICK_________________________'
    '__________________________________________________________'

    Private Sub btnR1_Click(sender As Object, e As EventArgs) Handles btnR1.Click
        'Desactiva todos los botones, marca si es correcto o incorrecto 
        'En caso de incorrecto, muestra cual era el correcto
        'Actualiza las vidas
        Timer1.Stop()
        activarBtnsR(False)
        If (respuestaCorrecta = 1) Then
            Sonido.Correcto()
            btnR1.BackColor = Color.YellowGreen
            'Segun qué ronda sea, gana más puntos (ya que son más difíciles)
            Select Case ronda
                Case 1
                    puntos += progressBar.Value * 0.5
                Case 2
                    puntos += progressBar.Value
                Case 3
                    puntos += puntosMemo
                Case 4
                    puntos += progressBar.Value * 2
            End Select

            lblPuntos.Text = puntos
        Else
            Sonido.Incorrecto()
            btnR1.BackColor = Color.IndianRed

            Select Case respuestaCorrecta
                Case 2
                    btnR2.BackColor = Color.YellowGreen
                Case 3
                    btnR3.BackColor = Color.YellowGreen
                Case 4
                    btnR4.BackColor = Color.YellowGreen
            End Select

            If vidas > 1 Then
                vidas -= 1
            Else
                FormGameOver.Show()
            End If
            lblVidas.Text = vidas
        End If
        btnSeguir.Visible = True

    End Sub

    Private Sub btnR3_Click(sender As Object, e As EventArgs) Handles btnR3.Click

        Timer1.Stop()
        activarBtnsR(False)

        If (respuestaCorrecta = 3) Then
            Sonido.Correcto()
            btnR3.BackColor = Color.YellowGreen
            Select Case ronda
                Case 1
                    puntos += progressBar.Value * 0.5
                Case 2
                    puntos += progressBar.Value
                Case 3
                    puntos += puntosMemo
                Case 4
                    puntos += progressBar.Value * 2
            End Select

            lblPuntos.Text = puntos
        Else
            Sonido.Incorrecto()
            btnR3.BackColor = Color.IndianRed
            Select Case respuestaCorrecta
                Case 2
                    btnR2.BackColor = Color.YellowGreen
                Case 1
                    btnR1.BackColor = Color.YellowGreen
                Case 4
                    btnR4.BackColor = Color.YellowGreen
            End Select
            If vidas > 1 Then
                vidas -= 1
            Else
                FormGameOver.Show()
            End If
            lblVidas.Text = vidas
        End If
        btnSeguir.Visible = True

    End Sub

    Private Sub btnR2_Click(sender As Object, e As EventArgs) Handles btnR2.Click
        Timer1.Stop()
        activarBtnsR(False)
        If (respuestaCorrecta = 2) Then
            Sonido.Correcto()
            btnR2.BackColor = Color.YellowGreen
            Select Case ronda
                Case 1
                    puntos += progressBar.Value * 0.5
                Case 2
                    puntos += progressBar.Value
                Case 3
                    puntos += puntosMemo
                Case 4
                    puntos += progressBar.Value * 2
            End Select

            lblPuntos.Text = puntos
        Else
            Sonido.Incorrecto()
            btnR2.BackColor = Color.IndianRed
            Select Case respuestaCorrecta
                Case 1
                    btnR1.BackColor = Color.YellowGreen
                Case 3
                    btnR3.BackColor = Color.YellowGreen
                Case 4
                    btnR4.BackColor = Color.YellowGreen
            End Select
            If vidas > 1 Then
                vidas -= 1
            Else
                FormGameOver.Show()
            End If
            lblVidas.Text = vidas
        End If
        btnSeguir.Visible = True
    End Sub

    Private Sub btnR4_Click(sender As Object, e As EventArgs) Handles btnR4.Click
        Timer1.Stop()
        activarBtnsR(False)
        If (respuestaCorrecta = 4) Then
            Sonido.Correcto()
            btnR4.BackColor = Color.YellowGreen
            Select Case ronda
                Case 1
                    puntos += progressBar.Value * 0.5
                Case 2
                    puntos += progressBar.Value
                Case 3
                    puntos += puntosMemo
                Case 4
                    puntos += progressBar.Value * 2
            End Select
            lblPuntos.Text = puntos
        Else
            Sonido.Incorrecto()
            btnR4.BackColor = Color.IndianRed
            Select Case respuestaCorrecta
                Case 2
                    btnR2.BackColor = Color.YellowGreen
                Case 3
                    btnR3.BackColor = Color.YellowGreen
                Case 1
                    btnR1.BackColor = Color.YellowGreen
            End Select
            If vidas > 1 Then
                vidas -= 1
            Else
                FormGameOver.Show()
            End If
            lblVidas.Text = vidas
        End If
        btnSeguir.Visible = True
    End Sub

    Private Sub pbBandera_Click(sender As Object, e As EventArgs) Handles pbBandera.Click
        Sonido.Click()
        Dim resp As Integer = MessageBox.Show("¿Te rindes?", "Abandonar", MessageBoxButtons.YesNo)

        If resp = DialogResult.Yes Then
            Timer1.Stop()
            Form1.Show()
            Nick.Close()
            Me.Close()
        End If

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles btnSeguir.Click
        Sonido.Click()

        pregunta += 1  'Cuenta de las preguntas que han salido, y así saber la ronda

        Select Case pregunta
            Case 3
                ronda = 2
            Case 6
                ronda = 3
            Case 9
                ronda = 4
        End Select

        If pregunta = 3 Or pregunta = 6 Or pregunta = 9 Then
            FormRonda.Show()
        Else
            siguientePregunta()
        End If


    End Sub

    Private Sub btnFifty_Click_1(sender As Object, e As EventArgs) Handles btnFifty.Click
        Select Case respuestaCorrecta
            Case 1
                btnR2.Enabled = False
                btnR2.Text = ""
                btnR4.Enabled = False
                btnR4.Text = ""
            Case 2
                btnR3.Enabled = False
                btnR3.Text = ""
                btnR1.Enabled = False
                btnR1.Text = ""
            Case 3
                btnR2.Enabled = False
                btnR2.Text = ""
                btnR4.Enabled = False
                btnR4.Text = ""
            Case 4
                btnR1.Enabled = False
                btnR1.Text = ""
                btnR3.Enabled = False
                btnR3.Text = ""
        End Select
        btnFifty.Enabled = False
    End Sub
End Class