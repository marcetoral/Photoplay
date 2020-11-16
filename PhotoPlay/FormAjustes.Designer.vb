<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAjustes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAjustes))
        Me.Salir = New System.Windows.Forms.PictureBox()
        Me.btnMusica = New System.Windows.Forms.PictureBox()
        Me.btnSonido = New System.Windows.Forms.PictureBox()
        CType(Me.Salir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMusica, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSonido, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Salir
        '
        Me.Salir.BackColor = System.Drawing.Color.Transparent
        Me.Salir.Location = New System.Drawing.Point(915, 31)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(68, 67)
        Me.Salir.TabIndex = 3
        Me.Salir.TabStop = False
        '
        'btnMusica
        '
        Me.btnMusica.BackColor = System.Drawing.Color.Transparent
        Me.btnMusica.Image = CType(resources.GetObject("btnMusica.Image"), System.Drawing.Image)
        Me.btnMusica.Location = New System.Drawing.Point(474, 64)
        Me.btnMusica.Name = "btnMusica"
        Me.btnMusica.Size = New System.Drawing.Size(113, 108)
        Me.btnMusica.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMusica.TabIndex = 6
        Me.btnMusica.TabStop = False
        '
        'btnSonido
        '
        Me.btnSonido.BackColor = System.Drawing.Color.Transparent
        Me.btnSonido.Image = CType(resources.GetObject("btnSonido.Image"), System.Drawing.Image)
        Me.btnSonido.Location = New System.Drawing.Point(474, 278)
        Me.btnSonido.Name = "btnSonido"
        Me.btnSonido.Size = New System.Drawing.Size(113, 108)
        Me.btnSonido.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnSonido.TabIndex = 7
        Me.btnSonido.TabStop = False
        '
        'FormAjustes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PhotoPlay.My.Resources.Resources.FondoAjustes
        Me.ClientSize = New System.Drawing.Size(1032, 727)
        Me.Controls.Add(Me.btnSonido)
        Me.Controls.Add(Me.btnMusica)
        Me.Controls.Add(Me.Salir)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormAjustes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormAjustes"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        CType(Me.Salir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMusica, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSonido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Salir As PictureBox
    Friend WithEvents btnMusica As PictureBox
    Friend WithEvents btnSonido As PictureBox
End Class
