<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AgregarPelicula
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AgregarPelicula))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombrePelicula = New System.Windows.Forms.TextBox()
        Me.txtGenero = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDuracionMinutos = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDuracionSegundos = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtLink = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtSinopsis = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCalificacion = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtReparto = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.calendar = New System.Windows.Forms.MonthCalendar()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbxSerie = New System.Windows.Forms.CheckBox()
        Me.cbxPelicula = New System.Windows.Forms.CheckBox()
        Me.lblError = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
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
        'Button1
        '
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 3
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(261, 620)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(206, 44)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Subir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(37, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(295, 39)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Nombre contenido"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(346, 497)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 19)
        Me.Label5.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(37, 162)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 39)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Genero"
        '
        'txtNombrePelicula
        '
        Me.txtNombrePelicula.BackColor = System.Drawing.SystemColors.MenuText
        Me.txtNombrePelicula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombrePelicula.Font = New System.Drawing.Font("Arial", 10.25!)
        Me.txtNombrePelicula.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.txtNombrePelicula.Location = New System.Drawing.Point(44, 136)
        Me.txtNombrePelicula.Name = "txtNombrePelicula"
        Me.txtNombrePelicula.Size = New System.Drawing.Size(261, 23)
        Me.txtNombrePelicula.TabIndex = 14
        '
        'txtGenero
        '
        Me.txtGenero.BackColor = System.Drawing.SystemColors.MenuText
        Me.txtGenero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGenero.Font = New System.Drawing.Font("Arial", 10.25!)
        Me.txtGenero.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.txtGenero.Location = New System.Drawing.Point(44, 204)
        Me.txtGenero.Name = "txtGenero"
        Me.txtGenero.Size = New System.Drawing.Size(261, 23)
        Me.txtGenero.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(37, 230)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(282, 39)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Duracion minutos"
        '
        'txtDuracionMinutos
        '
        Me.txtDuracionMinutos.BackColor = System.Drawing.SystemColors.MenuText
        Me.txtDuracionMinutos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDuracionMinutos.Font = New System.Drawing.Font("Arial", 10.25!)
        Me.txtDuracionMinutos.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.txtDuracionMinutos.Location = New System.Drawing.Point(44, 272)
        Me.txtDuracionMinutos.Name = "txtDuracionMinutos"
        Me.txtDuracionMinutos.Size = New System.Drawing.Size(261, 23)
        Me.txtDuracionMinutos.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(37, 298)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(311, 39)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Duracion segundos"
        '
        'txtDuracionSegundos
        '
        Me.txtDuracionSegundos.BackColor = System.Drawing.SystemColors.MenuText
        Me.txtDuracionSegundos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDuracionSegundos.Font = New System.Drawing.Font("Arial", 10.25!)
        Me.txtDuracionSegundos.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.txtDuracionSegundos.Location = New System.Drawing.Point(44, 340)
        Me.txtDuracionSegundos.Name = "txtDuracionSegundos"
        Me.txtDuracionSegundos.Size = New System.Drawing.Size(261, 23)
        Me.txtDuracionSegundos.TabIndex = 21
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(37, 366)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 39)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Link"
        '
        'txtLink
        '
        Me.txtLink.BackColor = System.Drawing.SystemColors.MenuText
        Me.txtLink.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLink.Font = New System.Drawing.Font("Arial", 10.25!)
        Me.txtLink.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.txtLink.Location = New System.Drawing.Point(44, 399)
        Me.txtLink.Name = "txtLink"
        Me.txtLink.Size = New System.Drawing.Size(261, 23)
        Me.txtLink.TabIndex = 23
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(453, 94)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(147, 39)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Sinopsis"
        '
        'txtSinopsis
        '
        Me.txtSinopsis.BackColor = System.Drawing.SystemColors.MenuText
        Me.txtSinopsis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSinopsis.Font = New System.Drawing.Font("Arial", 10.25!)
        Me.txtSinopsis.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.txtSinopsis.Location = New System.Drawing.Point(385, 136)
        Me.txtSinopsis.Name = "txtSinopsis"
        Me.txtSinopsis.Size = New System.Drawing.Size(294, 23)
        Me.txtSinopsis.TabIndex = 100
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(453, 162)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(193, 39)
        Me.Label9.TabIndex = 101
        Me.Label9.Text = "Calificacion"
        '
        'txtCalificacion
        '
        Me.txtCalificacion.BackColor = System.Drawing.SystemColors.MenuText
        Me.txtCalificacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCalificacion.Font = New System.Drawing.Font("Arial", 10.25!)
        Me.txtCalificacion.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.txtCalificacion.Location = New System.Drawing.Point(385, 204)
        Me.txtCalificacion.Name = "txtCalificacion"
        Me.txtCalificacion.Size = New System.Drawing.Size(294, 23)
        Me.txtCalificacion.TabIndex = 102
        Me.txtCalificacion.Text = "Calificacion del 0-100"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(453, 230)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(138, 39)
        Me.Label10.TabIndex = 103
        Me.Label10.Text = "Reparto"
        '
        'txtReparto
        '
        Me.txtReparto.BackColor = System.Drawing.SystemColors.MenuText
        Me.txtReparto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtReparto.Font = New System.Drawing.Font("Arial", 10.25!)
        Me.txtReparto.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.txtReparto.Location = New System.Drawing.Point(385, 272)
        Me.txtReparto.Name = "txtReparto"
        Me.txtReparto.Size = New System.Drawing.Size(294, 23)
        Me.txtReparto.TabIndex = 104
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(431, 298)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(234, 39)
        Me.Label11.TabIndex = 105
        Me.Label11.Text = "Fecha estreno"
        '
        'calendar
        '
        Me.calendar.Location = New System.Drawing.Point(431, 376)
        Me.calendar.Name = "calendar"
        Me.calendar.TabIndex = 106
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbxSerie)
        Me.GroupBox1.Controls.Add(Me.cbxPelicula)
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(44, 438)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(261, 100)
        Me.GroupBox1.TabIndex = 107
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo de contenido"
        '
        'cbxSerie
        '
        Me.cbxSerie.AutoSize = True
        Me.cbxSerie.Location = New System.Drawing.Point(0, 71)
        Me.cbxSerie.Name = "cbxSerie"
        Me.cbxSerie.Size = New System.Drawing.Size(67, 23)
        Me.cbxSerie.TabIndex = 1
        Me.cbxSerie.Text = "Serie"
        Me.cbxSerie.UseVisualStyleBackColor = True
        '
        'cbxPelicula
        '
        Me.cbxPelicula.AutoSize = True
        Me.cbxPelicula.Location = New System.Drawing.Point(0, 38)
        Me.cbxPelicula.Name = "cbxPelicula"
        Me.cbxPelicula.Size = New System.Drawing.Size(89, 23)
        Me.cbxPelicula.TabIndex = 0
        Me.cbxPelicula.Text = "Pelicula"
        Me.cbxPelicula.UseVisualStyleBackColor = True
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.Location = New System.Drawing.Point(302, 50)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(0, 19)
        Me.lblError.TabIndex = 108
        '
        'AgregarPelicula
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(726, 692)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.calendar)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtReparto)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtCalificacion)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtSinopsis)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtLink)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtDuracionSegundos)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtDuracionMinutos)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtGenero)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtNombrePelicula)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial Black", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "AgregarPelicula"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "addmovie"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNombrePelicula As TextBox
    Friend WithEvents txtGenero As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDuracionMinutos As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDuracionSegundos As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtLink As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtSinopsis As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtCalificacion As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtReparto As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents calendar As MonthCalendar
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbxSerie As CheckBox
    Friend WithEvents cbxPelicula As CheckBox
    Friend WithEvents lblError As Label
End Class
