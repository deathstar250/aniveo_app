<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ModificarSerie
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnModificarSerie = New System.Windows.Forms.Button()
        Me.lblDescripcionSerie = New System.Windows.Forms.Label()
        Me.txtLinkCaratulaSerie = New System.Windows.Forms.TextBox()
        Me.lblLinkSerie = New System.Windows.Forms.Label()
        Me.txtDescripcionSerie = New System.Windows.Forms.TextBox()
        Me.cbxModificarSerie = New System.Windows.Forms.ComboBox()
        Me.lblSerieAModificar = New System.Windows.Forms.Label()
        Me.txtTituloNuevoSerie = New System.Windows.Forms.TextBox()
        Me.lblTituloNuevoMSerie = New System.Windows.Forms.Label()
        Me.lblCapitulosSerie = New System.Windows.Forms.Label()
        Me.txtCapitulosSerie = New System.Windows.Forms.TextBox()
        Me.txtFechaEstrenoSerie = New System.Windows.Forms.TextBox()
        Me.lblFechaEstrenoMSerie = New System.Windows.Forms.Label()
        Me.cbxGeneroSerie = New System.Windows.Forms.ComboBox()
        Me.lblGeneroSerie = New System.Windows.Forms.Label()
        Me.lblCalificacionSerie = New System.Windows.Forms.Label()
        Me.txtCalificacionSerie = New System.Windows.Forms.TextBox()
        Me.lblRepartoSerie = New System.Windows.Forms.Label()
        Me.txtRepartoSerie = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 45.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 85)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "◄"
        '
        'btnModificarSerie
        '
        Me.btnModificarSerie.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnModificarSerie.FlatAppearance.BorderSize = 3
        Me.btnModificarSerie.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnModificarSerie.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificarSerie.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarSerie.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnModificarSerie.Location = New System.Drawing.Point(320, 640)
        Me.btnModificarSerie.Name = "btnModificarSerie"
        Me.btnModificarSerie.Size = New System.Drawing.Size(206, 44)
        Me.btnModificarSerie.TabIndex = 19
        Me.btnModificarSerie.Text = "Modificar"
        Me.btnModificarSerie.UseVisualStyleBackColor = True
        '
        'lblDescripcionSerie
        '
        Me.lblDescripcionSerie.AutoSize = True
        Me.lblDescripcionSerie.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.lblDescripcionSerie.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.lblDescripcionSerie.Location = New System.Drawing.Point(36, 464)
        Me.lblDescripcionSerie.Name = "lblDescripcionSerie"
        Me.lblDescripcionSerie.Size = New System.Drawing.Size(304, 39)
        Me.lblDescripcionSerie.TabIndex = 18
        Me.lblDescripcionSerie.Text = "Descripcion Nueva"
        '
        'txtLinkCaratulaSerie
        '
        Me.txtLinkCaratulaSerie.Location = New System.Drawing.Point(48, 416)
        Me.txtLinkCaratulaSerie.Name = "txtLinkCaratulaSerie"
        Me.txtLinkCaratulaSerie.Size = New System.Drawing.Size(320, 26)
        Me.txtLinkCaratulaSerie.TabIndex = 17
        '
        'lblLinkSerie
        '
        Me.lblLinkSerie.AutoSize = True
        Me.lblLinkSerie.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.lblLinkSerie.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.lblLinkSerie.Location = New System.Drawing.Point(-3, 368)
        Me.lblLinkSerie.Name = "lblLinkSerie"
        Me.lblLinkSerie.Size = New System.Drawing.Size(359, 39)
        Me.lblLinkSerie.TabIndex = 16
        Me.lblLinkSerie.Text = "Link de caratula nueva"
        '
        'txtDescripcionSerie
        '
        Me.txtDescripcionSerie.Location = New System.Drawing.Point(24, 512)
        Me.txtDescripcionSerie.Multiline = True
        Me.txtDescripcionSerie.Name = "txtDescripcionSerie"
        Me.txtDescripcionSerie.Size = New System.Drawing.Size(368, 96)
        Me.txtDescripcionSerie.TabIndex = 15
        '
        'cbxModificarSerie
        '
        Me.cbxModificarSerie.FormattingEnabled = True
        Me.cbxModificarSerie.Location = New System.Drawing.Point(240, 112)
        Me.cbxModificarSerie.Name = "cbxModificarSerie"
        Me.cbxModificarSerie.Size = New System.Drawing.Size(368, 26)
        Me.cbxModificarSerie.TabIndex = 14
        '
        'lblSerieAModificar
        '
        Me.lblSerieAModificar.AutoSize = True
        Me.lblSerieAModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.lblSerieAModificar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.lblSerieAModificar.Location = New System.Drawing.Point(269, 64)
        Me.lblSerieAModificar.Name = "lblSerieAModificar"
        Me.lblSerieAModificar.Size = New System.Drawing.Size(272, 39)
        Me.lblSerieAModificar.TabIndex = 13
        Me.lblSerieAModificar.Text = "Serie a modificar"
        '
        'txtTituloNuevoSerie
        '
        Me.txtTituloNuevoSerie.Location = New System.Drawing.Point(48, 224)
        Me.txtTituloNuevoSerie.Name = "txtTituloNuevoSerie"
        Me.txtTituloNuevoSerie.Size = New System.Drawing.Size(320, 26)
        Me.txtTituloNuevoSerie.TabIndex = 21
        '
        'lblTituloNuevoMSerie
        '
        Me.lblTituloNuevoMSerie.AutoSize = True
        Me.lblTituloNuevoMSerie.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.lblTituloNuevoMSerie.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.lblTituloNuevoMSerie.Location = New System.Drawing.Point(92, 176)
        Me.lblTituloNuevoMSerie.Name = "lblTituloNuevoMSerie"
        Me.lblTituloNuevoMSerie.Size = New System.Drawing.Size(203, 39)
        Me.lblTituloNuevoMSerie.TabIndex = 20
        Me.lblTituloNuevoMSerie.Text = "Titulo nuevo"
        '
        'lblCapitulosSerie
        '
        Me.lblCapitulosSerie.AutoSize = True
        Me.lblCapitulosSerie.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.lblCapitulosSerie.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.lblCapitulosSerie.Location = New System.Drawing.Point(112, 272)
        Me.lblCapitulosSerie.Name = "lblCapitulosSerie"
        Me.lblCapitulosSerie.Size = New System.Drawing.Size(160, 39)
        Me.lblCapitulosSerie.TabIndex = 22
        Me.lblCapitulosSerie.Text = "Capitulos"
        '
        'txtCapitulosSerie
        '
        Me.txtCapitulosSerie.Location = New System.Drawing.Point(48, 320)
        Me.txtCapitulosSerie.Name = "txtCapitulosSerie"
        Me.txtCapitulosSerie.Size = New System.Drawing.Size(320, 26)
        Me.txtCapitulosSerie.TabIndex = 23
        '
        'txtFechaEstrenoSerie
        '
        Me.txtFechaEstrenoSerie.Location = New System.Drawing.Point(479, 224)
        Me.txtFechaEstrenoSerie.Name = "txtFechaEstrenoSerie"
        Me.txtFechaEstrenoSerie.Size = New System.Drawing.Size(320, 26)
        Me.txtFechaEstrenoSerie.TabIndex = 25
        '
        'lblFechaEstrenoMSerie
        '
        Me.lblFechaEstrenoMSerie.AutoSize = True
        Me.lblFechaEstrenoMSerie.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.lblFechaEstrenoMSerie.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.lblFechaEstrenoMSerie.Location = New System.Drawing.Point(508, 176)
        Me.lblFechaEstrenoMSerie.Name = "lblFechaEstrenoMSerie"
        Me.lblFechaEstrenoMSerie.Size = New System.Drawing.Size(234, 39)
        Me.lblFechaEstrenoMSerie.TabIndex = 24
        Me.lblFechaEstrenoMSerie.Text = "Fecha estreno"
        '
        'cbxGeneroSerie
        '
        Me.cbxGeneroSerie.FormattingEnabled = True
        Me.cbxGeneroSerie.Location = New System.Drawing.Point(479, 320)
        Me.cbxGeneroSerie.Name = "cbxGeneroSerie"
        Me.cbxGeneroSerie.Size = New System.Drawing.Size(320, 26)
        Me.cbxGeneroSerie.TabIndex = 26
        '
        'lblGeneroSerie
        '
        Me.lblGeneroSerie.AutoSize = True
        Me.lblGeneroSerie.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.lblGeneroSerie.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.lblGeneroSerie.Location = New System.Drawing.Point(562, 272)
        Me.lblGeneroSerie.Name = "lblGeneroSerie"
        Me.lblGeneroSerie.Size = New System.Drawing.Size(130, 39)
        Me.lblGeneroSerie.TabIndex = 27
        Me.lblGeneroSerie.Text = "Genero"
        '
        'lblCalificacionSerie
        '
        Me.lblCalificacionSerie.AutoSize = True
        Me.lblCalificacionSerie.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.lblCalificacionSerie.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.lblCalificacionSerie.Location = New System.Drawing.Point(528, 368)
        Me.lblCalificacionSerie.Name = "lblCalificacionSerie"
        Me.lblCalificacionSerie.Size = New System.Drawing.Size(193, 39)
        Me.lblCalificacionSerie.TabIndex = 28
        Me.lblCalificacionSerie.Text = "Calificación"
        '
        'txtCalificacionSerie
        '
        Me.txtCalificacionSerie.AcceptsReturn = True
        Me.txtCalificacionSerie.Location = New System.Drawing.Point(480, 416)
        Me.txtCalificacionSerie.Name = "txtCalificacionSerie"
        Me.txtCalificacionSerie.Size = New System.Drawing.Size(320, 26)
        Me.txtCalificacionSerie.TabIndex = 29
        '
        'lblRepartoSerie
        '
        Me.lblRepartoSerie.AutoSize = True
        Me.lblRepartoSerie.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.lblRepartoSerie.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.lblRepartoSerie.Location = New System.Drawing.Point(560, 464)
        Me.lblRepartoSerie.Name = "lblRepartoSerie"
        Me.lblRepartoSerie.Size = New System.Drawing.Size(138, 39)
        Me.lblRepartoSerie.TabIndex = 31
        Me.lblRepartoSerie.Text = "Reparto"
        '
        'txtRepartoSerie
        '
        Me.txtRepartoSerie.Location = New System.Drawing.Point(455, 512)
        Me.txtRepartoSerie.Multiline = True
        Me.txtRepartoSerie.Name = "txtRepartoSerie"
        Me.txtRepartoSerie.Size = New System.Drawing.Size(368, 96)
        Me.txtRepartoSerie.TabIndex = 32
        '
        'ModificarSerie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(843, 705)
        Me.Controls.Add(Me.txtRepartoSerie)
        Me.Controls.Add(Me.lblRepartoSerie)
        Me.Controls.Add(Me.txtCalificacionSerie)
        Me.Controls.Add(Me.lblCalificacionSerie)
        Me.Controls.Add(Me.lblGeneroSerie)
        Me.Controls.Add(Me.cbxGeneroSerie)
        Me.Controls.Add(Me.txtFechaEstrenoSerie)
        Me.Controls.Add(Me.lblFechaEstrenoMSerie)
        Me.Controls.Add(Me.txtCapitulosSerie)
        Me.Controls.Add(Me.lblCapitulosSerie)
        Me.Controls.Add(Me.txtTituloNuevoSerie)
        Me.Controls.Add(Me.lblTituloNuevoMSerie)
        Me.Controls.Add(Me.btnModificarSerie)
        Me.Controls.Add(Me.lblDescripcionSerie)
        Me.Controls.Add(Me.txtLinkCaratulaSerie)
        Me.Controls.Add(Me.lblLinkSerie)
        Me.Controls.Add(Me.txtDescripcionSerie)
        Me.Controls.Add(Me.cbxModificarSerie)
        Me.Controls.Add(Me.lblSerieAModificar)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial Black", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ModificarSerie"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "modser"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnModificarSerie As Button
    Friend WithEvents lblDescripcionSerie As Label
    Friend WithEvents txtLinkCaratulaSerie As TextBox
    Friend WithEvents lblLinkSerie As Label
    Friend WithEvents txtDescripcionSerie As TextBox
    Friend WithEvents cbxModificarSerie As ComboBox
    Friend WithEvents lblSerieAModificar As Label
    Friend WithEvents txtTituloNuevoSerie As TextBox
    Friend WithEvents lblTituloNuevoMSerie As Label
    Friend WithEvents lblCapitulosSerie As Label
    Friend WithEvents txtCapitulosSerie As TextBox
    Friend WithEvents txtFechaEstrenoSerie As TextBox
    Friend WithEvents lblFechaEstrenoMSerie As Label
    Friend WithEvents cbxGeneroSerie As ComboBox
    Friend WithEvents lblGeneroSerie As Label
    Friend WithEvents lblCalificacionSerie As Label
    Friend WithEvents txtCalificacionSerie As TextBox
    Friend WithEvents lblRepartoSerie As Label
    Friend WithEvents txtRepartoSerie As TextBox
End Class
