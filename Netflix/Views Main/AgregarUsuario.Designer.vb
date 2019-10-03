<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Adduser
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblFechaNacimientoUsuario = New System.Windows.Forms.Label()
        Me.txtApellidoNuevoUsuario = New System.Windows.Forms.TextBox()
        Me.lblApellidoNuevoUsuario = New System.Windows.Forms.Label()
        Me.txtNombreNuevoUsuario = New System.Windows.Forms.TextBox()
        Me.lblNombreNuevoUsuario = New System.Windows.Forms.Label()
        Me.lblCorreiNuevoUsuario = New System.Windows.Forms.Label()
        Me.lblContraseniaNuevaUsuario = New System.Windows.Forms.Label()
        Me.txtCorreoNuevoUsuario = New System.Windows.Forms.TextBox()
        Me.calendar = New System.Windows.Forms.MonthCalendar()
        Me.TxtNombreUsuario = New System.Windows.Forms.TextBox()
        Me.lblNombreUsuario = New System.Windows.Forms.Label()
        Me.lblErrorAgrgarUsuario = New System.Windows.Forms.Label()
        Me.txtContraseniaNuevaUsuario = New System.Windows.Forms.MaskedTextBox()
        Me.lblError = New System.Windows.Forms.Label()
        Me.lblError1 = New System.Windows.Forms.Label()
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
        Me.Button1.Location = New System.Drawing.Point(283, 564)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(206, 44)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Subir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblFechaNacimientoUsuario
        '
        Me.lblFechaNacimientoUsuario.AutoSize = True
        Me.lblFechaNacimientoUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.lblFechaNacimientoUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.lblFechaNacimientoUsuario.Location = New System.Drawing.Point(409, 241)
        Me.lblFechaNacimientoUsuario.Name = "lblFechaNacimientoUsuario"
        Me.lblFechaNacimientoUsuario.Size = New System.Drawing.Size(286, 39)
        Me.lblFechaNacimientoUsuario.TabIndex = 73
        Me.lblFechaNacimientoUsuario.Text = "Fecha nacimiento"
        '
        'txtApellidoNuevoUsuario
        '
        Me.txtApellidoNuevoUsuario.Location = New System.Drawing.Point(43, 394)
        Me.txtApellidoNuevoUsuario.Name = "txtApellidoNuevoUsuario"
        Me.txtApellidoNuevoUsuario.Size = New System.Drawing.Size(322, 26)
        Me.txtApellidoNuevoUsuario.TabIndex = 2
        '
        'lblApellidoNuevoUsuario
        '
        Me.lblApellidoNuevoUsuario.AutoSize = True
        Me.lblApellidoNuevoUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.lblApellidoNuevoUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.lblApellidoNuevoUsuario.Location = New System.Drawing.Point(66, 337)
        Me.lblApellidoNuevoUsuario.Name = "lblApellidoNuevoUsuario"
        Me.lblApellidoNuevoUsuario.Size = New System.Drawing.Size(140, 39)
        Me.lblApellidoNuevoUsuario.TabIndex = 71
        Me.lblApellidoNuevoUsuario.Text = "Apellido"
        '
        'txtNombreNuevoUsuario
        '
        Me.txtNombreNuevoUsuario.Location = New System.Drawing.Point(43, 297)
        Me.txtNombreNuevoUsuario.Name = "txtNombreNuevoUsuario"
        Me.txtNombreNuevoUsuario.Size = New System.Drawing.Size(320, 26)
        Me.txtNombreNuevoUsuario.TabIndex = 1
        '
        'lblNombreNuevoUsuario
        '
        Me.lblNombreNuevoUsuario.AutoSize = True
        Me.lblNombreNuevoUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.lblNombreNuevoUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.lblNombreNuevoUsuario.Location = New System.Drawing.Point(66, 241)
        Me.lblNombreNuevoUsuario.Name = "lblNombreNuevoUsuario"
        Me.lblNombreNuevoUsuario.Size = New System.Drawing.Size(138, 39)
        Me.lblNombreNuevoUsuario.TabIndex = 69
        Me.lblNombreNuevoUsuario.Text = "Nombre"
        '
        'lblCorreiNuevoUsuario
        '
        Me.lblCorreiNuevoUsuario.AutoSize = True
        Me.lblCorreiNuevoUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.lblCorreiNuevoUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.lblCorreiNuevoUsuario.Location = New System.Drawing.Point(409, 133)
        Me.lblCorreiNuevoUsuario.Name = "lblCorreiNuevoUsuario"
        Me.lblCorreiNuevoUsuario.Size = New System.Drawing.Size(121, 39)
        Me.lblCorreiNuevoUsuario.TabIndex = 68
        Me.lblCorreiNuevoUsuario.Text = "Correo"
        '
        'lblContraseniaNuevaUsuario
        '
        Me.lblContraseniaNuevaUsuario.AutoSize = True
        Me.lblContraseniaNuevaUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.lblContraseniaNuevaUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.lblContraseniaNuevaUsuario.Location = New System.Drawing.Point(36, 432)
        Me.lblContraseniaNuevaUsuario.Name = "lblContraseniaNuevaUsuario"
        Me.lblContraseniaNuevaUsuario.Size = New System.Drawing.Size(193, 39)
        Me.lblContraseniaNuevaUsuario.TabIndex = 66
        Me.lblContraseniaNuevaUsuario.Text = "Contraseña"
        '
        'txtCorreoNuevoUsuario
        '
        Me.txtCorreoNuevoUsuario.Location = New System.Drawing.Point(393, 189)
        Me.txtCorreoNuevoUsuario.Name = "txtCorreoNuevoUsuario"
        Me.txtCorreoNuevoUsuario.Size = New System.Drawing.Size(321, 26)
        Me.txtCorreoNuevoUsuario.TabIndex = 4
        '
        'calendar
        '
        Me.calendar.Location = New System.Drawing.Point(405, 306)
        Me.calendar.Name = "calendar"
        Me.calendar.TabIndex = 5
        '
        'TxtNombreUsuario
        '
        Me.TxtNombreUsuario.Location = New System.Drawing.Point(45, 189)
        Me.TxtNombreUsuario.Name = "TxtNombreUsuario"
        Me.TxtNombreUsuario.Size = New System.Drawing.Size(320, 26)
        Me.TxtNombreUsuario.TabIndex = 0
        '
        'lblNombreUsuario
        '
        Me.lblNombreUsuario.AutoSize = True
        Me.lblNombreUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.lblNombreUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.lblNombreUsuario.Location = New System.Drawing.Point(68, 133)
        Me.lblNombreUsuario.Name = "lblNombreUsuario"
        Me.lblNombreUsuario.Size = New System.Drawing.Size(259, 39)
        Me.lblNombreUsuario.TabIndex = 0
        Me.lblNombreUsuario.Text = "Nombre usuario"
        '
        'lblErrorAgrgarUsuario
        '
        Me.lblErrorAgrgarUsuario.AutoSize = True
        Me.lblErrorAgrgarUsuario.Location = New System.Drawing.Point(49, 536)
        Me.lblErrorAgrgarUsuario.Name = "lblErrorAgrgarUsuario"
        Me.lblErrorAgrgarUsuario.Size = New System.Drawing.Size(0, 19)
        Me.lblErrorAgrgarUsuario.TabIndex = 77
        '
        'txtContraseniaNuevaUsuario
        '
        Me.txtContraseniaNuevaUsuario.Location = New System.Drawing.Point(43, 485)
        Me.txtContraseniaNuevaUsuario.Name = "txtContraseniaNuevaUsuario"
        Me.txtContraseniaNuevaUsuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContraseniaNuevaUsuario.Size = New System.Drawing.Size(322, 26)
        Me.txtContraseniaNuevaUsuario.TabIndex = 78
        Me.txtContraseniaNuevaUsuario.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.Location = New System.Drawing.Point(88, 45)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(0, 19)
        Me.lblError.TabIndex = 79
        '
        'lblError1
        '
        Me.lblError1.AutoSize = True
        Me.lblError1.Location = New System.Drawing.Point(227, 50)
        Me.lblError1.Name = "lblError1"
        Me.lblError1.Size = New System.Drawing.Size(0, 19)
        Me.lblError1.TabIndex = 80
        '
        'Adduser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(726, 638)
        Me.Controls.Add(Me.lblError1)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.txtContraseniaNuevaUsuario)
        Me.Controls.Add(Me.lblErrorAgrgarUsuario)
        Me.Controls.Add(Me.TxtNombreUsuario)
        Me.Controls.Add(Me.lblNombreUsuario)
        Me.Controls.Add(Me.calendar)
        Me.Controls.Add(Me.lblFechaNacimientoUsuario)
        Me.Controls.Add(Me.txtApellidoNuevoUsuario)
        Me.Controls.Add(Me.lblApellidoNuevoUsuario)
        Me.Controls.Add(Me.txtNombreNuevoUsuario)
        Me.Controls.Add(Me.lblNombreNuevoUsuario)
        Me.Controls.Add(Me.lblCorreiNuevoUsuario)
        Me.Controls.Add(Me.lblContraseniaNuevaUsuario)
        Me.Controls.Add(Me.txtCorreoNuevoUsuario)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial Black", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Adduser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "adduser"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents lblFechaNacimientoUsuario As Label
    Friend WithEvents txtApellidoNuevoUsuario As TextBox
    Friend WithEvents lblApellidoNuevoUsuario As Label
    Friend WithEvents txtNombreNuevoUsuario As TextBox
    Friend WithEvents lblNombreNuevoUsuario As Label
    Friend WithEvents lblCorreiNuevoUsuario As Label
    Friend WithEvents lblContraseniaNuevaUsuario As Label
    Friend WithEvents txtCorreoNuevoUsuario As TextBox
    Friend WithEvents calendar As MonthCalendar
    Friend WithEvents TxtNombreUsuario As TextBox
    Friend WithEvents lblNombreUsuario As Label
    Friend WithEvents lblErrorAgrgarUsuario As Label
    Friend WithEvents txtContraseniaNuevaUsuario As MaskedTextBox
    Friend WithEvents lblError As Label
    Friend WithEvents lblError1 As Label
End Class
