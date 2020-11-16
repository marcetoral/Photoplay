Module Sonido
    Dim ruta As String = My.Application.Info.DirectoryPath
    Dim media As System.Media.SoundPlayer
    Dim audio As Boolean = True
    Dim musica As Boolean

    Public Sub MusicaFondo()  'Activar/desactivar la musica de fondo
        If (Not musica) Then
            My.Computer.Audio.Play(My.Resources.BackgroundMusic, AudioPlayMode.BackgroundLoop)
            FormAjustes.btnMusica.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "speakerOn.png")
            musica = True
        Else
            My.Computer.Audio.Stop()
            FormAjustes.btnMusica.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "speakerOff.png")
            musica = False
        End If
    End Sub

    Public Sub SonidoEfectos()  'Activar/desactivar los efectos de sonido
        If (Not audio) Then
            audio = True
            FormAjustes.btnSonido.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "speakerOn.png")
        Else
            audio = False
            FormAjustes.btnSonido.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "speakerOff.png")
        End If
    End Sub


    Public Sub Click()
        media = New System.Media.SoundPlayer(ruta + "\click.wav")
        If (audio) Then
            media.Play()
        End If

    End Sub
    Public Sub Correcto()
        media = New System.Media.SoundPlayer(ruta + "\correcto.wav")
        If (audio) Then
            media.Play()
        End If
    End Sub
    Public Sub Incorrecto()
        media = New System.Media.SoundPlayer(ruta + "\incorrecto.wav")
        If (audio) Then
            media.Play()
        End If
    End Sub
End Module
