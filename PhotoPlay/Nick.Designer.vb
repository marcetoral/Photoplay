<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Nick
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
        Me.lblNick = New System.Windows.Forms.Label()
        Me.tbNick = New System.Windows.Forms.TextBox()
        Me.lblObligatorio = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNick
        '
        Me.lblNick.AutoSize = True
        Me.lblNick.BackColor = System.Drawing.Color.Transparent
        Me.lblNick.Font = New System.Drawing.Font("Segoe Print", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNick.ForeColor = System.Drawing.Color.YellowGreen
        Me.lblNick.Location = New System.Drawing.Point(398, 225)
        Me.lblNick.Name = "lblNick"
        Me.lblNick.Size = New System.Drawing.Size(243, 65)
        Me.lblNick.TabIndex = 0
        Me.lblNick.Text = "Tu nombre:"
        '
        'tbNick
        '
        Me.tbNick.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.tbNick.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbNick.Font = New System.Drawing.Font("Segoe Script", 23.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNick.ForeColor = System.Drawing.Color.Crimson
        Me.tbNick.Location = New System.Drawing.Point(409, 335)
        Me.tbNick.Name = "tbNick"
        Me.tbNick.Size = New System.Drawing.Size(237, 50)
        Me.tbNick.TabIndex = 1
        Me.tbNick.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblObligatorio
        '
        Me.lblObligatorio.AutoSize = True
        Me.lblObligatorio.BackColor = System.Drawing.Color.Transparent
        Me.lblObligatorio.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblObligatorio.ForeColor = System.Drawing.Color.Tomato
        Me.lblObligatorio.Location = New System.Drawing.Point(390, 404)
        Me.lblObligatorio.Name = "lblObligatorio"
        Me.lblObligatorio.Size = New System.Drawing.Size(63, 19)
        Me.lblObligatorio.TabIndex = 4
        Me.lblObligatorio.Text = "blabla"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.PhotoPlay.My.Resources.Resources._next
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(481, 441)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(88, 74)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Nick
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PhotoPlay.My.Resources.Resources.FondoNick
        Me.ClientSize = New System.Drawing.Size(1028, 720)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblObligatorio)
        Me.Controls.Add(Me.tbNick)
        Me.Controls.Add(Me.lblNick)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Nick"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nick"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNick As Label
    Friend WithEvents tbNick As TextBox
    Friend WithEvents lblObligatorio As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
