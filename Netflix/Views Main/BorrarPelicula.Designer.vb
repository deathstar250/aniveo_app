<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BorrarPelicula
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
        Me.txtIdUsuario = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtUsuarioAEliminar = New System.Windows.Forms.TextBox()
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
        'txtIdUsuario
        '
        Me.txtIdUsuario.AutoSize = True
        Me.txtIdUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.txtIdUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.txtIdUsuario.Location = New System.Drawing.Point(137, 148)
        Me.txtIdUsuario.Name = "txtIdUsuario"
        Me.txtIdUsuario.Size = New System.Drawing.Size(479, 39)
        Me.txtIdUsuario.TabIndex = 7
        Me.txtIdUsuario.Text = "Seleccionar pelicula a eliminar"
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 3
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(260, 320)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(206, 44)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Eliminar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtUsuarioAEliminar
        '
        Me.txtUsuarioAEliminar.Location = New System.Drawing.Point(260, 240)
        Me.txtUsuarioAEliminar.Name = "txtUsuarioAEliminar"
        Me.txtUsuarioAEliminar.Size = New System.Drawing.Size(206, 26)
        Me.txtUsuarioAEliminar.TabIndex = 14
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.Location = New System.Drawing.Point(82, 41)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(0, 19)
        Me.lblError.TabIndex = 15
        '
        'BorrarPelicula
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(726, 638)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.txtUsuarioAEliminar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtIdUsuario)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial Black", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "BorrarPelicula"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "delmovie"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtIdUsuario As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents txtUsuarioAEliminar As TextBox
    Friend WithEvents lblError As Label
End Class
