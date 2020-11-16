<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormGameOver
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormGameOver))
        Me.lblGameOver = New System.Windows.Forms.Label()
        Me.btnHome = New System.Windows.Forms.PictureBox()
        Me.lblPuntos = New System.Windows.Forms.Label()
        CType(Me.btnHome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblGameOver
        '
        Me.lblGameOver.AutoSize = True
        Me.lblGameOver.BackColor = System.Drawing.Color.Transparent
        Me.lblGameOver.Font = New System.Drawing.Font("Segoe Print", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGameOver.ForeColor = System.Drawing.Color.YellowGreen
        Me.lblGameOver.Location = New System.Drawing.Point(296, 50)
        Me.lblGameOver.Name = "lblGameOver"
        Me.lblGameOver.Size = New System.Drawing.Size(485, 112)
        Me.lblGameOver.TabIndex = 0
        Me.lblGameOver.Text = "Game Over :c"
        '
        'btnHome
        '
        Me.btnHome.BackColor = System.Drawing.Color.Transparent
        Me.btnHome.BackgroundImage = CType(resources.GetObject("btnHome.BackgroundImage"), System.Drawing.Image)
        Me.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnHome.Location = New System.Drawing.Point(481, 535)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(58, 63)
        Me.btnHome.TabIndex = 2
        Me.btnHome.TabStop = False
        '
        'lblPuntos
        '
        Me.lblPuntos.BackColor = System.Drawing.Color.Transparent
        Me.lblPuntos.Font = New System.Drawing.Font("Bahnschrift SemiBold", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPuntos.ForeColor = System.Drawing.Color.MediumTurquoise
        Me.lblPuntos.Location = New System.Drawing.Point(332, 205)
        Me.lblPuntos.Name = "lblPuntos"
        Me.lblPuntos.Size = New System.Drawing.Size(383, 241)
        Me.lblPuntos.TabIndex = 3
        Me.lblPuntos.Text = "Puntos"
        Me.lblPuntos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormGameOver
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1028, 720)
        Me.Controls.Add(Me.lblPuntos)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.lblGameOver)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormGameOver"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormGameOver"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        CType(Me.btnHome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblGameOver As Label
    Friend WithEvents btnHome As PictureBox
    Friend WithEvents lblPuntos As Label
End Class
