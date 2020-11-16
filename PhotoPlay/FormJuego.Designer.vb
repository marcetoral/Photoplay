<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormJuego
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnR2 = New System.Windows.Forms.Button()
        Me.btnR4 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblPregunta = New System.Windows.Forms.Label()
        Me.btnR1 = New System.Windows.Forms.Button()
        Me.btnR3 = New System.Windows.Forms.Button()
        Me.progressBar = New System.Windows.Forms.ProgressBar()
        Me.DirectorySearcher1 = New System.DirectoryServices.DirectorySearcher()
        Me.lblPuntos = New System.Windows.Forms.Label()
        Me.btnSeguir = New System.Windows.Forms.PictureBox()
        Me.Cora = New System.Windows.Forms.PictureBox()
        Me.pbBandera = New System.Windows.Forms.PictureBox()
        Me.Foto = New System.Windows.Forms.PictureBox()
        Me.lblVidas = New System.Windows.Forms.Label()
        Me.btnFifty = New System.Windows.Forms.PictureBox()
        CType(Me.btnSeguir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cora, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBandera, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Foto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnFifty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnR2
        '
        Me.btnR2.BackColor = System.Drawing.Color.MediumPurple
        Me.btnR2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnR2.FlatAppearance.BorderColor = System.Drawing.Color.Indigo
        Me.btnR2.FlatAppearance.BorderSize = 3
        Me.btnR2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Plum
        Me.btnR2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnR2.Font = New System.Drawing.Font("Bahnschrift Light", 16.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnR2.Location = New System.Drawing.Point(221, 614)
        Me.btnR2.Name = "btnR2"
        Me.btnR2.Size = New System.Drawing.Size(285, 76)
        Me.btnR2.TabIndex = 6
        Me.btnR2.Text = "Blebla"
        Me.btnR2.UseVisualStyleBackColor = False
        '
        'btnR4
        '
        Me.btnR4.BackColor = System.Drawing.Color.MediumPurple
        Me.btnR4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnR4.FlatAppearance.BorderColor = System.Drawing.Color.Indigo
        Me.btnR4.FlatAppearance.BorderSize = 3
        Me.btnR4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Plum
        Me.btnR4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnR4.Font = New System.Drawing.Font("Bahnschrift Light", 16.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnR4.Location = New System.Drawing.Point(530, 614)
        Me.btnR4.Name = "btnR4"
        Me.btnR4.Size = New System.Drawing.Size(289, 76)
        Me.btnR4.TabIndex = 7
        Me.btnR4.Text = "Blaa"
        Me.btnR4.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'lblPregunta
        '
        Me.lblPregunta.BackColor = System.Drawing.Color.Transparent
        Me.lblPregunta.Font = New System.Drawing.Font("Cambria", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPregunta.ForeColor = System.Drawing.Color.Thistle
        Me.lblPregunta.Location = New System.Drawing.Point(176, 9)
        Me.lblPregunta.Name = "lblPregunta"
        Me.lblPregunta.Size = New System.Drawing.Size(682, 85)
        Me.lblPregunta.TabIndex = 2
        Me.lblPregunta.Text = "Blaa bla blabla blablabla?"
        Me.lblPregunta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnR1
        '
        Me.btnR1.BackColor = System.Drawing.Color.MediumPurple
        Me.btnR1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnR1.FlatAppearance.BorderColor = System.Drawing.Color.Indigo
        Me.btnR1.FlatAppearance.BorderSize = 3
        Me.btnR1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Plum
        Me.btnR1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnR1.Font = New System.Drawing.Font("Bahnschrift Light", 16.25!, System.Drawing.FontStyle.Bold)
        Me.btnR1.Location = New System.Drawing.Point(221, 534)
        Me.btnR1.Name = "btnR1"
        Me.btnR1.Size = New System.Drawing.Size(285, 74)
        Me.btnR1.TabIndex = 4
        Me.btnR1.Text = "Este texto sólo es para ver si escribe dos lineas"
        Me.btnR1.UseVisualStyleBackColor = False
        '
        'btnR3
        '
        Me.btnR3.BackColor = System.Drawing.Color.MediumPurple
        Me.btnR3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnR3.FlatAppearance.BorderColor = System.Drawing.Color.Indigo
        Me.btnR3.FlatAppearance.BorderSize = 3
        Me.btnR3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Plum
        Me.btnR3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnR3.Font = New System.Drawing.Font("Bahnschrift Light", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnR3.Location = New System.Drawing.Point(530, 534)
        Me.btnR3.Name = "btnR3"
        Me.btnR3.Size = New System.Drawing.Size(289, 74)
        Me.btnR3.TabIndex = 5
        Me.btnR3.Text = "Blabla"
        Me.btnR3.UseVisualStyleBackColor = False
        '
        'progressBar
        '
        Me.progressBar.BackColor = System.Drawing.Color.DarkSlateGray
        Me.progressBar.ForeColor = System.Drawing.Color.OliveDrab
        Me.progressBar.Location = New System.Drawing.Point(192, 511)
        Me.progressBar.Margin = New System.Windows.Forms.Padding(1)
        Me.progressBar.MarqueeAnimationSpeed = 1
        Me.progressBar.Maximum = 1000
        Me.progressBar.Name = "progressBar"
        Me.progressBar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.progressBar.Size = New System.Drawing.Size(648, 10)
        Me.progressBar.Step = 1
        Me.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.progressBar.TabIndex = 8
        Me.progressBar.Value = 1000
        '
        'DirectorySearcher1
        '
        Me.DirectorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01")
        '
        'lblPuntos
        '
        Me.lblPuntos.AutoEllipsis = True
        Me.lblPuntos.BackColor = System.Drawing.Color.Transparent
        Me.lblPuntos.Font = New System.Drawing.Font("Bahnschrift SemiBold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPuntos.ForeColor = System.Drawing.Color.MediumVioletRed
        Me.lblPuntos.Location = New System.Drawing.Point(845, 197)
        Me.lblPuntos.Name = "lblPuntos"
        Me.lblPuntos.Size = New System.Drawing.Size(134, 51)
        Me.lblPuntos.TabIndex = 13
        Me.lblPuntos.Text = "0"
        Me.lblPuntos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSeguir
        '
        Me.btnSeguir.BackColor = System.Drawing.Color.Transparent
        Me.btnSeguir.BackgroundImage = Global.PhotoPlay.My.Resources.Resources.next1
        Me.btnSeguir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSeguir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSeguir.Location = New System.Drawing.Point(902, 327)
        Me.btnSeguir.Name = "btnSeguir"
        Me.btnSeguir.Size = New System.Drawing.Size(64, 64)
        Me.btnSeguir.TabIndex = 17
        Me.btnSeguir.TabStop = False
        Me.btnSeguir.Visible = False
        '
        'Cora
        '
        Me.Cora.BackColor = System.Drawing.Color.Transparent
        Me.Cora.BackgroundImage = Global.PhotoPlay.My.Resources.Resources.coraSi
        Me.Cora.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Cora.Location = New System.Drawing.Point(119, 197)
        Me.Cora.Name = "Cora"
        Me.Cora.Size = New System.Drawing.Size(47, 41)
        Me.Cora.TabIndex = 10
        Me.Cora.TabStop = False
        '
        'pbBandera
        '
        Me.pbBandera.BackColor = System.Drawing.Color.Transparent
        Me.pbBandera.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbBandera.Image = Global.PhotoPlay.My.Resources.Resources.rendir
        Me.pbBandera.Location = New System.Drawing.Point(863, 537)
        Me.pbBandera.Name = "pbBandera"
        Me.pbBandera.Size = New System.Drawing.Size(133, 118)
        Me.pbBandera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbBandera.TabIndex = 9
        Me.pbBandera.TabStop = False
        '
        'Foto
        '
        Me.Foto.BackColor = System.Drawing.Color.Transparent
        Me.Foto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Foto.Location = New System.Drawing.Point(234, 115)
        Me.Foto.Name = "Foto"
        Me.Foto.Size = New System.Drawing.Size(556, 378)
        Me.Foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Foto.TabIndex = 3
        Me.Foto.TabStop = False
        '
        'lblVidas
        '
        Me.lblVidas.AutoSize = True
        Me.lblVidas.BackColor = System.Drawing.Color.Transparent
        Me.lblVidas.Font = New System.Drawing.Font("Bahnschrift SemiBold", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVidas.ForeColor = System.Drawing.Color.DarkCyan
        Me.lblVidas.Location = New System.Drawing.Point(60, 194)
        Me.lblVidas.Name = "lblVidas"
        Me.lblVidas.Size = New System.Drawing.Size(40, 45)
        Me.lblVidas.TabIndex = 11
        Me.lblVidas.Text = "3"
        '
        'btnFifty
        '
        Me.btnFifty.BackColor = System.Drawing.Color.Transparent
        Me.btnFifty.BackgroundImage = Global.PhotoPlay.My.Resources.Resources.comodin
        Me.btnFifty.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnFifty.Location = New System.Drawing.Point(46, 569)
        Me.btnFifty.Name = "btnFifty"
        Me.btnFifty.Size = New System.Drawing.Size(139, 86)
        Me.btnFifty.TabIndex = 18
        Me.btnFifty.TabStop = False
        '
        'FormJuego
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateBlue
        Me.BackgroundImage = Global.PhotoPlay.My.Resources.Resources.FondoPregunta
        Me.ClientSize = New System.Drawing.Size(1028, 720)
        Me.Controls.Add(Me.btnFifty)
        Me.Controls.Add(Me.btnSeguir)
        Me.Controls.Add(Me.lblPuntos)
        Me.Controls.Add(Me.lblVidas)
        Me.Controls.Add(Me.Cora)
        Me.Controls.Add(Me.pbBandera)
        Me.Controls.Add(Me.progressBar)
        Me.Controls.Add(Me.btnR4)
        Me.Controls.Add(Me.btnR2)
        Me.Controls.Add(Me.btnR3)
        Me.Controls.Add(Me.btnR1)
        Me.Controls.Add(Me.Foto)
        Me.Controls.Add(Me.lblPregunta)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormJuego"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormJuego"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        CType(Me.btnSeguir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cora, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBandera, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Foto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnFifty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnR2 As Button
    Friend WithEvents btnR4 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Foto As PictureBox
    Friend WithEvents lblPregunta As Label
    Friend WithEvents btnR1 As Button
    Friend WithEvents btnR3 As Button
    Friend WithEvents progressBar As ProgressBar
    Friend WithEvents pbBandera As PictureBox
    Friend WithEvents Cora As PictureBox
    Friend WithEvents DirectorySearcher1 As DirectoryServices.DirectorySearcher
    Friend WithEvents lblPuntos As Label
    Friend WithEvents btnSeguir As PictureBox
    Friend WithEvents lblVidas As Label
    Friend WithEvents btnFifty As PictureBox
End Class
