<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AgregarSerie
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNombrePelicula = New System.Windows.Forms.TextBox()
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
        'AgregarSerie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(726, 692)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtNombrePelicula)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial Black", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "AgregarSerie"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "addmovie"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNombrePelicula As TextBox
End Class
