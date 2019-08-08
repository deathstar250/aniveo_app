<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ModificarPelicula
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
        Me.txtRepartoPelicula = New System.Windows.Forms.TextBox()
        Me.lblRepartoPelicula = New System.Windows.Forms.Label()
        Me.txtCalificacionPelicula = New System.Windows.Forms.TextBox()
        Me.lblCalificacionPelicula = New System.Windows.Forms.Label()
        Me.lblGeneroPelicula = New System.Windows.Forms.Label()
        Me.cbxGeneroPelicula = New System.Windows.Forms.ComboBox()
        Me.txtFechaEstrenoPelicula = New System.Windows.Forms.TextBox()
        Me.lblFechaEstrenoPelicula = New System.Windows.Forms.Label()
        Me.txtDuracionPelicula = New System.Windows.Forms.TextBox()
        Me.lblDuracionPelicula = New System.Windows.Forms.Label()
        Me.txtTituloNuevoPelicula = New System.Windows.Forms.TextBox()
        Me.lblTituloNuevoPelicula = New System.Windows.Forms.Label()
        Me.btnModificarPelicula = New System.Windows.Forms.Button()
        Me.lblDescripcionPelicula = New System.Windows.Forms.Label()
        Me.txtLinkPelicula = New System.Windows.Forms.TextBox()
        Me.lblLinkPElicula = New System.Windows.Forms.Label()
        Me.txtDescripcionPelicula = New System.Windows.Forms.TextBox()
        Me.cbxModificarPelicula = New System.Windows.Forms.ComboBox()
        Me.lblModificarPelicula = New System.Windows.Forms.Label()
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
        'txtRepartoPelicula
        '
        Me.txtRepartoPelicula.Location = New System.Drawing.Point(466, 490)
        Me.txtRepartoPelicula.Multiline = True
        Me.txtRepartoPelicula.Name = "txtRepartoPelicula"
        Me.txtRepartoPelicula.Size = New System.Drawing.Size(368, 96)
        Me.txtRepartoPelicula.TabIndex = 51
        '
        'lblRepartoPelicula
        '
        Me.lblRepartoPelicula.AutoSize = True
        Me.lblRepartoPelicula.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.lblRepartoPelicula.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.lblRepartoPelicula.Location = New System.Drawing.Point(571, 442)
        Me.lblRepartoPelicula.Name = "lblRepartoPelicula"
        Me.lblRepartoPelicula.Size = New System.Drawing.Size(138, 39)
        Me.lblRepartoPelicula.TabIndex = 50
        Me.lblRepartoPelicula.Text = "Reparto"
        '
        'txtCalificacionPelicula
        '
        Me.txtCalificacionPelicula.Location = New System.Drawing.Point(491, 394)
        Me.txtCalificacionPelicula.Name = "txtCalificacionPelicula"
        Me.txtCalificacionPelicula.Size = New System.Drawing.Size(320, 26)
        Me.txtCalificacionPelicula.TabIndex = 49
        '
        'lblCalificacionPelicula
        '
        Me.lblCalificacionPelicula.AutoSize = True
        Me.lblCalificacionPelicula.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.lblCalificacionPelicula.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.lblCalificacionPelicula.Location = New System.Drawing.Point(539, 346)
        Me.lblCalificacionPelicula.Name = "lblCalificacionPelicula"
        Me.lblCalificacionPelicula.Size = New System.Drawing.Size(193, 39)
        Me.lblCalificacionPelicula.TabIndex = 48
        Me.lblCalificacionPelicula.Text = "Calificacion"
        '
        'lblGeneroPelicula
        '
        Me.lblGeneroPelicula.AutoSize = True
        Me.lblGeneroPelicula.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.lblGeneroPelicula.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.lblGeneroPelicula.Location = New System.Drawing.Point(573, 250)
        Me.lblGeneroPelicula.Name = "lblGeneroPelicula"
        Me.lblGeneroPelicula.Size = New System.Drawing.Size(130, 39)
        Me.lblGeneroPelicula.TabIndex = 47
        Me.lblGeneroPelicula.Text = "Genero"
        '
        'cbxGeneroPelicula
        '
        Me.cbxGeneroPelicula.FormattingEnabled = True
        Me.cbxGeneroPelicula.Location = New System.Drawing.Point(490, 298)
        Me.cbxGeneroPelicula.Name = "cbxGeneroPelicula"
        Me.cbxGeneroPelicula.Size = New System.Drawing.Size(320, 26)
        Me.cbxGeneroPelicula.TabIndex = 46
        '
        'txtFechaEstrenoPelicula
        '
        Me.txtFechaEstrenoPelicula.Location = New System.Drawing.Point(490, 202)
        Me.txtFechaEstrenoPelicula.Name = "txtFechaEstrenoPelicula"
        Me.txtFechaEstrenoPelicula.Size = New System.Drawing.Size(320, 26)
        Me.txtFechaEstrenoPelicula.TabIndex = 45
        '
        'lblFechaEstrenoPelicula
        '
        Me.lblFechaEstrenoPelicula.AutoSize = True
        Me.lblFechaEstrenoPelicula.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.lblFechaEstrenoPelicula.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.lblFechaEstrenoPelicula.Location = New System.Drawing.Point(519, 154)
        Me.lblFechaEstrenoPelicula.Name = "lblFechaEstrenoPelicula"
        Me.lblFechaEstrenoPelicula.Size = New System.Drawing.Size(234, 39)
        Me.lblFechaEstrenoPelicula.TabIndex = 44
        Me.lblFechaEstrenoPelicula.Text = "Fecha estreno"
        '
        'txtDuracionPelicula
        '
        Me.txtDuracionPelicula.Location = New System.Drawing.Point(59, 298)
        Me.txtDuracionPelicula.Name = "txtDuracionPelicula"
        Me.txtDuracionPelicula.Size = New System.Drawing.Size(320, 26)
        Me.txtDuracionPelicula.TabIndex = 43
        '
        'lblDuracionPelicula
        '
        Me.lblDuracionPelicula.AutoSize = True
        Me.lblDuracionPelicula.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.lblDuracionPelicula.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.lblDuracionPelicula.Location = New System.Drawing.Point(123, 250)
        Me.lblDuracionPelicula.Name = "lblDuracionPelicula"
        Me.lblDuracionPelicula.Size = New System.Drawing.Size(154, 39)
        Me.lblDuracionPelicula.TabIndex = 42
        Me.lblDuracionPelicula.Text = "Duracion"
        '
        'txtTituloNuevoPelicula
        '
        Me.txtTituloNuevoPelicula.Location = New System.Drawing.Point(59, 202)
        Me.txtTituloNuevoPelicula.Name = "txtTituloNuevoPelicula"
        Me.txtTituloNuevoPelicula.Size = New System.Drawing.Size(320, 26)
        Me.txtTituloNuevoPelicula.TabIndex = 41
        '
        'lblTituloNuevoPelicula
        '
        Me.lblTituloNuevoPelicula.AutoSize = True
        Me.lblTituloNuevoPelicula.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.lblTituloNuevoPelicula.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.lblTituloNuevoPelicula.Location = New System.Drawing.Point(103, 154)
        Me.lblTituloNuevoPelicula.Name = "lblTituloNuevoPelicula"
        Me.lblTituloNuevoPelicula.Size = New System.Drawing.Size(203, 39)
        Me.lblTituloNuevoPelicula.TabIndex = 40
        Me.lblTituloNuevoPelicula.Text = "Titulo nuevo"
        '
        'btnModificarPelicula
        '
        Me.btnModificarPelicula.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnModificarPelicula.FlatAppearance.BorderSize = 3
        Me.btnModificarPelicula.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnModificarPelicula.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificarPelicula.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarPelicula.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnModificarPelicula.Location = New System.Drawing.Point(331, 618)
        Me.btnModificarPelicula.Name = "btnModificarPelicula"
        Me.btnModificarPelicula.Size = New System.Drawing.Size(206, 44)
        Me.btnModificarPelicula.TabIndex = 39
        Me.btnModificarPelicula.Text = "Modificar"
        Me.btnModificarPelicula.UseVisualStyleBackColor = True
        '
        'lblDescripcionPelicula
        '
        Me.lblDescripcionPelicula.AutoSize = True
        Me.lblDescripcionPelicula.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.lblDescripcionPelicula.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.lblDescripcionPelicula.Location = New System.Drawing.Point(47, 442)
        Me.lblDescripcionPelicula.Name = "lblDescripcionPelicula"
        Me.lblDescripcionPelicula.Size = New System.Drawing.Size(304, 39)
        Me.lblDescripcionPelicula.TabIndex = 38
        Me.lblDescripcionPelicula.Text = "Descripcion Nueva"
        '
        'txtLinkPelicula
        '
        Me.txtLinkPelicula.Location = New System.Drawing.Point(59, 394)
        Me.txtLinkPelicula.Name = "txtLinkPelicula"
        Me.txtLinkPelicula.Size = New System.Drawing.Size(320, 26)
        Me.txtLinkPelicula.TabIndex = 37
        '
        'lblLinkPElicula
        '
        Me.lblLinkPElicula.AutoSize = True
        Me.lblLinkPElicula.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.lblLinkPElicula.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.lblLinkPElicula.Location = New System.Drawing.Point(8, 346)
        Me.lblLinkPElicula.Name = "lblLinkPElicula"
        Me.lblLinkPElicula.Size = New System.Drawing.Size(359, 39)
        Me.lblLinkPElicula.TabIndex = 36
        Me.lblLinkPElicula.Text = "Link de caratula nueva"
        '
        'txtDescripcionPelicula
        '
        Me.txtDescripcionPelicula.Location = New System.Drawing.Point(35, 490)
        Me.txtDescripcionPelicula.Multiline = True
        Me.txtDescripcionPelicula.Name = "txtDescripcionPelicula"
        Me.txtDescripcionPelicula.Size = New System.Drawing.Size(368, 96)
        Me.txtDescripcionPelicula.TabIndex = 35
        '
        'cbxModificarPelicula
        '
        Me.cbxModificarPelicula.FormattingEnabled = True
        Me.cbxModificarPelicula.Location = New System.Drawing.Point(251, 90)
        Me.cbxModificarPelicula.Name = "cbxModificarPelicula"
        Me.cbxModificarPelicula.Size = New System.Drawing.Size(368, 26)
        Me.cbxModificarPelicula.TabIndex = 34
        '
        'lblModificarPelicula
        '
        Me.lblModificarPelicula.AutoSize = True
        Me.lblModificarPelicula.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.lblModificarPelicula.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.lblModificarPelicula.Location = New System.Drawing.Point(251, 42)
        Me.lblModificarPelicula.Name = "lblModificarPelicula"
        Me.lblModificarPelicula.Size = New System.Drawing.Size(313, 39)
        Me.lblModificarPelicula.TabIndex = 33
        Me.lblModificarPelicula.Text = "Pelicula a modificar"
        '
        'ModificarPelicula
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(843, 705)
        Me.Controls.Add(Me.txtRepartoPelicula)
        Me.Controls.Add(Me.lblRepartoPelicula)
        Me.Controls.Add(Me.txtCalificacionPelicula)
        Me.Controls.Add(Me.lblCalificacionPelicula)
        Me.Controls.Add(Me.lblGeneroPelicula)
        Me.Controls.Add(Me.cbxGeneroPelicula)
        Me.Controls.Add(Me.txtFechaEstrenoPelicula)
        Me.Controls.Add(Me.lblFechaEstrenoPelicula)
        Me.Controls.Add(Me.txtDuracionPelicula)
        Me.Controls.Add(Me.lblDuracionPelicula)
        Me.Controls.Add(Me.txtTituloNuevoPelicula)
        Me.Controls.Add(Me.lblTituloNuevoPelicula)
        Me.Controls.Add(Me.btnModificarPelicula)
        Me.Controls.Add(Me.lblDescripcionPelicula)
        Me.Controls.Add(Me.txtLinkPelicula)
        Me.Controls.Add(Me.lblLinkPElicula)
        Me.Controls.Add(Me.txtDescripcionPelicula)
        Me.Controls.Add(Me.cbxModificarPelicula)
        Me.Controls.Add(Me.lblModificarPelicula)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial Black", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ModificarPelicula"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "modmovie"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtRepartoPelicula As TextBox
    Friend WithEvents lblRepartoPelicula As Label
    Friend WithEvents txtCalificacionPelicula As TextBox
    Friend WithEvents lblCalificacionPelicula As Label
    Friend WithEvents lblGeneroPelicula As Label
    Friend WithEvents cbxGeneroPelicula As ComboBox
    Friend WithEvents txtFechaEstrenoPelicula As TextBox
    Friend WithEvents lblFechaEstrenoPelicula As Label
    Friend WithEvents txtDuracionPelicula As TextBox
    Friend WithEvents lblDuracionPelicula As Label
    Friend WithEvents txtTituloNuevoPelicula As TextBox
    Friend WithEvents lblTituloNuevoPelicula As Label
    Friend WithEvents btnModificarPelicula As Button
    Friend WithEvents lblDescripcionPelicula As Label
    Friend WithEvents txtLinkPelicula As TextBox
    Friend WithEvents lblLinkPElicula As Label
    Friend WithEvents txtDescripcionPelicula As TextBox
    Friend WithEvents cbxModificarPelicula As ComboBox
    Friend WithEvents lblModificarPelicula As Label
End Class
