<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInstrucciones
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
        Me.Salir = New System.Windows.Forms.PictureBox()
        Me.lblInstrucciones = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.Salir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnNext, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Salir
        '
        Me.Salir.BackColor = System.Drawing.Color.Transparent
        Me.Salir.Location = New System.Drawing.Point(914, 28)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(71, 73)
        Me.Salir.TabIndex = 2
        Me.Salir.TabStop = False
        '
        'lblInstrucciones
        '
        Me.lblInstrucciones.AutoSize = True
        Me.lblInstrucciones.BackColor = System.Drawing.Color.Transparent
        Me.lblInstrucciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.lblInstrucciones.Location = New System.Drawing.Point(146, 106)
        Me.lblInstrucciones.Name = "lblInstrucciones"
        Me.lblInstrucciones.Size = New System.Drawing.Size(0, 31)
        Me.lblInstrucciones.TabIndex = 3
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.Transparent
        Me.btnNext.Location = New System.Drawing.Point(869, 594)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(71, 73)
        Me.btnNext.TabIndex = 4
        Me.btnNext.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Location = New System.Drawing.Point(75, 594)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(71, 73)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'FormInstrucciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PhotoPlay.My.Resources.Resources.FondoIns_1_
        Me.ClientSize = New System.Drawing.Size(1028, 722)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.lblInstrucciones)
        Me.Controls.Add(Me.Salir)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormInstrucciones"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormInstrucciones"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        CType(Me.Salir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnNext, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Salir As PictureBox
    Friend WithEvents lblInstrucciones As Label
    Friend WithEvents btnNext As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
