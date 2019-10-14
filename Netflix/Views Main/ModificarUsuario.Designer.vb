<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ModificarUsuario
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
        Me.txtFechaNacimientoUsuario = New System.Windows.Forms.TextBox()
        Me.lblFechaNacimientoUsuario = New System.Windows.Forms.Label()
        Me.txtApellidoNuevoUsuario = New System.Windows.Forms.TextBox()
        Me.lblApellidoNuevoUsuario = New System.Windows.Forms.Label()
        Me.txtNombreNuevoUsuario = New System.Windows.Forms.TextBox()
        Me.lblNombreNuevoUsuario = New System.Windows.Forms.Label()
        Me.btnModificarUsuario = New System.Windows.Forms.Button()
        Me.lblCorreiNuevoUsuario = New System.Windows.Forms.Label()
        Me.txtContraseniaNuevaUsuario = New System.Windows.Forms.TextBox()
        Me.lblContraseniaNuevaUsuario = New System.Windows.Forms.Label()
        Me.txtCorreoNuevoUsuario = New System.Windows.Forms.TextBox()
        Me.lblModificarUsuario = New System.Windows.Forms.Label()
        Me.txtNombreUsr = New System.Windows.Forms.TextBox()
        Me.lblError = New System.Windows.Forms.Label()
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
        'txtFechaNacimientoUsuario
        '
        Me.txtFechaNacimientoUsuario.Location = New System.Drawing.Point(48, 624)
        Me.txtFechaNacimientoUsuario.Name = "txtFechaNacimientoUsuario"
        Me.txtFechaNacimientoUsuario.Size = New System.Drawing.Size(320, 26)
        Me.txtFechaNacimientoUsuario.TabIndex = 64
        '
        'lblFechaNacimientoUsuario
        '
        Me.lblFechaNacimientoUsuario.AutoSize = True
        Me.lblFechaNacimientoUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.lblFechaNacimientoUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.lblFechaNacimientoUsuario.Location = New System.Drawing.Point(47, 576)
        Me.lblFechaNacimientoUsuario.Name = "lblFechaNacimientoUsuario"
        Me.lblFechaNacimientoUsuario.Size = New System.Drawing.Size(286, 39)
        Me.lblFechaNacimientoUsuario.TabIndex = 63
        Me.lblFechaNacimientoUsuario.Text = "Fecha nacimiento"
        '
        'txtApellidoNuevoUsuario
        '
        Me.txtApellidoNuevoUsuario.Location = New System.Drawing.Point(46, 320)
        Me.txtApellidoNuevoUsuario.Name = "txtApellidoNuevoUsuario"
        Me.txtApellidoNuevoUsuario.Size = New System.Drawing.Size(320, 26)
        Me.txtApellidoNuevoUsuario.TabIndex = 62
        '
        'lblApellidoNuevoUsuario
        '
        Me.lblApellidoNuevoUsuario.AutoSize = True
        Me.lblApellidoNuevoUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.lblApellidoNuevoUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.lblApellidoNuevoUsuario.Location = New System.Drawing.Point(65, 273)
        Me.lblApellidoNuevoUsuario.Name = "lblApellidoNuevoUsuario"
        Me.lblApellidoNuevoUsuario.Size = New System.Drawing.Size(242, 39)
        Me.lblApellidoNuevoUsuario.TabIndex = 61
        Me.lblApellidoNuevoUsuario.Text = "Apellido nuevo"
        '
        'txtNombreNuevoUsuario
        '
        Me.txtNombreNuevoUsuario.Location = New System.Drawing.Point(46, 224)
        Me.txtNombreNuevoUsuario.Name = "txtNombreNuevoUsuario"
        Me.txtNombreNuevoUsuario.Size = New System.Drawing.Size(320, 26)
        Me.txtNombreNuevoUsuario.TabIndex = 60
        '
        'lblNombreNuevoUsuario
        '
        Me.lblNombreNuevoUsuario.AutoSize = True
        Me.lblNombreNuevoUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.lblNombreNuevoUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.lblNombreNuevoUsuario.Location = New System.Drawing.Point(69, 176)
        Me.lblNombreNuevoUsuario.Name = "lblNombreNuevoUsuario"
        Me.lblNombreNuevoUsuario.Size = New System.Drawing.Size(240, 39)
        Me.lblNombreNuevoUsuario.TabIndex = 59
        Me.lblNombreNuevoUsuario.Text = "Nombre nuevo"
        '
        'btnModificarUsuario
        '
        Me.btnModificarUsuario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnModificarUsuario.FlatAppearance.BorderSize = 3
        Me.btnModificarUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnModificarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificarUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnModificarUsuario.Location = New System.Drawing.Point(512, 384)
        Me.btnModificarUsuario.Name = "btnModificarUsuario"
        Me.btnModificarUsuario.Size = New System.Drawing.Size(206, 44)
        Me.btnModificarUsuario.TabIndex = 58
        Me.btnModificarUsuario.Text = "Modificar"
        Me.btnModificarUsuario.UseVisualStyleBackColor = True
        '
        'lblCorreiNuevoUsuario
        '
        Me.lblCorreiNuevoUsuario.AutoSize = True
        Me.lblCorreiNuevoUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.lblCorreiNuevoUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.lblCorreiNuevoUsuario.Location = New System.Drawing.Point(77, 464)
        Me.lblCorreiNuevoUsuario.Name = "lblCorreiNuevoUsuario"
        Me.lblCorreiNuevoUsuario.Size = New System.Drawing.Size(223, 39)
        Me.lblCorreiNuevoUsuario.TabIndex = 57
        Me.lblCorreiNuevoUsuario.Text = "Correo nuevo"
        '
        'txtContraseniaNuevaUsuario
        '
        Me.txtContraseniaNuevaUsuario.Location = New System.Drawing.Point(46, 416)
        Me.txtContraseniaNuevaUsuario.Name = "txtContraseniaNuevaUsuario"
        Me.txtContraseniaNuevaUsuario.Size = New System.Drawing.Size(320, 26)
        Me.txtContraseniaNuevaUsuario.TabIndex = 56
        '
        'lblContraseniaNuevaUsuario
        '
        Me.lblContraseniaNuevaUsuario.AutoSize = True
        Me.lblContraseniaNuevaUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.lblContraseniaNuevaUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.lblContraseniaNuevaUsuario.Location = New System.Drawing.Point(35, 368)
        Me.lblContraseniaNuevaUsuario.Name = "lblContraseniaNuevaUsuario"
        Me.lblContraseniaNuevaUsuario.Size = New System.Drawing.Size(295, 39)
        Me.lblContraseniaNuevaUsuario.TabIndex = 55
        Me.lblContraseniaNuevaUsuario.Text = "Contraseña nueva"
        '
        'txtCorreoNuevoUsuario
        '
        Me.txtCorreoNuevoUsuario.Location = New System.Drawing.Point(47, 512)
        Me.txtCorreoNuevoUsuario.Name = "txtCorreoNuevoUsuario"
        Me.txtCorreoNuevoUsuario.Size = New System.Drawing.Size(321, 26)
        Me.txtCorreoNuevoUsuario.TabIndex = 54
        '
        'lblModificarUsuario
        '
        Me.lblModificarUsuario.AutoSize = True
        Me.lblModificarUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.lblModificarUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.lblModificarUsuario.Location = New System.Drawing.Point(242, 64)
        Me.lblModificarUsuario.Name = "lblModificarUsuario"
        Me.lblModificarUsuario.Size = New System.Drawing.Size(310, 39)
        Me.lblModificarUsuario.TabIndex = 52
        Me.lblModificarUsuario.Text = "Usuario a modificar"
        '
        'txtNombreUsr
        '
        Me.txtNombreUsr.Location = New System.Drawing.Point(232, 123)
        Me.txtNombreUsr.Name = "txtNombreUsr"
        Me.txtNombreUsr.Size = New System.Drawing.Size(320, 26)
        Me.txtNombreUsr.TabIndex = 65
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.Location = New System.Drawing.Point(501, 208)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(0, 19)
        Me.lblError.TabIndex = 66
        '
        'ModificarUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(843, 705)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.txtNombreUsr)
        Me.Controls.Add(Me.txtFechaNacimientoUsuario)
        Me.Controls.Add(Me.lblFechaNacimientoUsuario)
        Me.Controls.Add(Me.txtApellidoNuevoUsuario)
        Me.Controls.Add(Me.lblApellidoNuevoUsuario)
        Me.Controls.Add(Me.txtNombreNuevoUsuario)
        Me.Controls.Add(Me.lblNombreNuevoUsuario)
        Me.Controls.Add(Me.btnModificarUsuario)
        Me.Controls.Add(Me.lblCorreiNuevoUsuario)
        Me.Controls.Add(Me.txtContraseniaNuevaUsuario)
        Me.Controls.Add(Me.lblContraseniaNuevaUsuario)
        Me.Controls.Add(Me.txtCorreoNuevoUsuario)
        Me.Controls.Add(Me.lblModificarUsuario)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial Black", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ModificarUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "moduser"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtFechaNacimientoUsuario As TextBox
    Friend WithEvents lblFechaNacimientoUsuario As Label
    Friend WithEvents txtApellidoNuevoUsuario As TextBox
    Friend WithEvents lblApellidoNuevoUsuario As Label
    Friend WithEvents txtNombreNuevoUsuario As TextBox
    Friend WithEvents lblNombreNuevoUsuario As Label
    Friend WithEvents btnModificarUsuario As Button
    Friend WithEvents lblCorreiNuevoUsuario As Label
    Friend WithEvents txtContraseniaNuevaUsuario As TextBox
    Friend WithEvents lblContraseniaNuevaUsuario As Label
    Friend WithEvents txtCorreoNuevoUsuario As TextBox
    Friend WithEvents lblModificarUsuario As Label
    Friend WithEvents txtNombreUsr As TextBox
    Friend WithEvents lblError As Label
End Class
