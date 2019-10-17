<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AgregarNormal
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtLinkImagen = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtNombreTemporada = New System.Windows.Forms.TextBox()
        Me.LblError = New System.Windows.Forms.Label()
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(346, 497)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 19)
        Me.Label5.TabIndex = 15
        '
        'btnAceptar
        '
        Me.btnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnAceptar.FlatAppearance.BorderSize = 3
        Me.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnAceptar.Location = New System.Drawing.Point(271, 233)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(206, 44)
        Me.btnAceptar.TabIndex = 17
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(94, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(196, 39)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Descripcion"
        '
        'txtLinkImagen
        '
        Me.txtLinkImagen.AutoSize = True
        Me.txtLinkImagen.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.txtLinkImagen.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.txtLinkImagen.Location = New System.Drawing.Point(382, 114)
        Me.txtLinkImagen.Name = "txtLinkImagen"
        Me.txtLinkImagen.Size = New System.Drawing.Size(203, 39)
        Me.txtLinkImagen.TabIndex = 19
        Me.txtLinkImagen.Text = "Link Imagen"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.SystemColors.MenuText
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcion.Font = New System.Drawing.Font("Arial", 10.25!)
        Me.txtDescripcion.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.txtDescripcion.Location = New System.Drawing.Point(85, 169)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(261, 23)
        Me.txtDescripcion.TabIndex = 20
        '
        'txtNombreTemporada
        '
        Me.txtNombreTemporada.BackColor = System.Drawing.SystemColors.MenuText
        Me.txtNombreTemporada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombreTemporada.Font = New System.Drawing.Font("Arial", 10.25!)
        Me.txtNombreTemporada.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.txtNombreTemporada.Location = New System.Drawing.Point(389, 169)
        Me.txtNombreTemporada.Name = "txtNombreTemporada"
        Me.txtNombreTemporada.Size = New System.Drawing.Size(325, 23)
        Me.txtNombreTemporada.TabIndex = 21
        '
        'LblError
        '
        Me.LblError.AutoSize = True
        Me.LblError.Location = New System.Drawing.Point(101, 60)
        Me.LblError.Name = "LblError"
        Me.LblError.Size = New System.Drawing.Size(0, 19)
        Me.LblError.TabIndex = 22
        '
        'AgregarNormal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(726, 445)
        Me.Controls.Add(Me.LblError)
        Me.Controls.Add(Me.txtNombreTemporada)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtLinkImagen)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial Black", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "AgregarNormal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "addmovie"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnAceptar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtLinkImagen As Label
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents txtNombreTemporada As TextBox
    Friend WithEvents LblError As Label
End Class
