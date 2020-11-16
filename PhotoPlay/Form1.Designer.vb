<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Salir = New System.Windows.Forms.PictureBox()
        Me.Ajustes = New System.Windows.Forms.PictureBox()
        Me.Instrucciones = New System.Windows.Forms.PictureBox()
        Me.Jugar = New System.Windows.Forms.PictureBox()
        Me.lblSeleccion = New System.Windows.Forms.Label()
        Me.Ranking = New System.Windows.Forms.PictureBox()
        Me.Proximamente = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.Salir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ajustes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Instrucciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Jugar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ranking, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Proximamente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Salir
        '
        Me.Salir.BackColor = System.Drawing.Color.Transparent
        Me.Salir.Location = New System.Drawing.Point(477, 408)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(65, 98)
        Me.Salir.TabIndex = 0
        Me.Salir.TabStop = False
        '
        'Ajustes
        '
        Me.Ajustes.BackColor = System.Drawing.Color.Transparent
        Me.Ajustes.Location = New System.Drawing.Point(548, 361)
        Me.Ajustes.Name = "Ajustes"
        Me.Ajustes.Size = New System.Drawing.Size(89, 89)
        Me.Ajustes.TabIndex = 1
        Me.Ajustes.TabStop = False
        '
        'Instrucciones
        '
        Me.Instrucciones.BackColor = System.Drawing.Color.Transparent
        Me.Instrucciones.Location = New System.Drawing.Point(377, 361)
        Me.Instrucciones.Name = "Instrucciones"
        Me.Instrucciones.Size = New System.Drawing.Size(94, 78)
        Me.Instrucciones.TabIndex = 2
        Me.Instrucciones.TabStop = False
        '
        'Jugar
        '
        Me.Jugar.BackColor = System.Drawing.Color.Transparent
        Me.Jugar.Location = New System.Drawing.Point(477, 219)
        Me.Jugar.Name = "Jugar"
        Me.Jugar.Size = New System.Drawing.Size(65, 98)
        Me.Jugar.TabIndex = 3
        Me.Jugar.TabStop = False
        '
        'lblSeleccion
        '
        Me.lblSeleccion.BackColor = System.Drawing.Color.Transparent
        Me.lblSeleccion.Font = New System.Drawing.Font("Segoe Print", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeleccion.ForeColor = System.Drawing.Color.Gold
        Me.lblSeleccion.Location = New System.Drawing.Point(331, 102)
        Me.lblSeleccion.Name = "lblSeleccion"
        Me.lblSeleccion.Size = New System.Drawing.Size(359, 71)
        Me.lblSeleccion.TabIndex = 4
        Me.lblSeleccion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Ranking
        '
        Me.Ranking.BackColor = System.Drawing.Color.Transparent
        Me.Ranking.Location = New System.Drawing.Point(548, 265)
        Me.Ranking.Name = "Ranking"
        Me.Ranking.Size = New System.Drawing.Size(89, 90)
        Me.Ranking.TabIndex = 5
        Me.Ranking.TabStop = False
        '
        'Proximamente
        '
        Me.Proximamente.BackColor = System.Drawing.Color.Transparent
        Me.Proximamente.Location = New System.Drawing.Point(382, 274)
        Me.Proximamente.Name = "Proximamente"
        Me.Proximamente.Size = New System.Drawing.Size(88, 80)
        Me.Proximamente.TabIndex = 6
        Me.Proximamente.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DeepPink
        Me.Label1.Location = New System.Drawing.Point(42, 674)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 14)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Beta 1.8.4"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PhotoPlay.My.Resources.Resources.FondoInicio
        Me.ClientSize = New System.Drawing.Size(1028, 720)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Proximamente)
        Me.Controls.Add(Me.Ranking)
        Me.Controls.Add(Me.lblSeleccion)
        Me.Controls.Add(Me.Jugar)
        Me.Controls.Add(Me.Instrucciones)
        Me.Controls.Add(Me.Ajustes)
        Me.Controls.Add(Me.Salir)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        CType(Me.Salir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ajustes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Instrucciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Jugar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ranking, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Proximamente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Salir As PictureBox
    Friend WithEvents Ajustes As PictureBox
    Friend WithEvents Instrucciones As PictureBox
    Friend WithEvents Jugar As PictureBox
    Friend WithEvents lblSeleccion As Label
    Friend WithEvents Ranking As PictureBox
    Friend WithEvents Proximamente As PictureBox
    Friend WithEvents Label1 As Label
End Class
