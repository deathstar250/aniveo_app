﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inicio))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Nombre = New System.Windows.Forms.Label()
        Me.txtUsuarioIngresado = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtContraseñaIngresada = New System.Windows.Forms.TextBox()
        Me.lblError = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 3
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(564, 510)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(206, 44)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Aceptar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Nombre
        '
        Me.Nombre.AutoSize = True
        Me.Nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Nombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Nombre.Location = New System.Drawing.Point(607, 243)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Size = New System.Drawing.Size(135, 39)
        Me.Nombre.TabIndex = 3
        Me.Nombre.Text = "Usuario"
        '
        'txtUsuarioIngresado
        '
        Me.txtUsuarioIngresado.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txtUsuarioIngresado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsuarioIngresado.Font = New System.Drawing.Font("Arial", 10.25!)
        Me.txtUsuarioIngresado.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.txtUsuarioIngresado.Location = New System.Drawing.Point(555, 285)
        Me.txtUsuarioIngresado.Name = "txtUsuarioIngresado"
        Me.txtUsuarioIngresado.Size = New System.Drawing.Size(225, 23)
        Me.txtUsuarioIngresado.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(577, 351)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(193, 39)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Contraseña"
        '
        'txtContraseñaIngresada
        '
        Me.txtContraseñaIngresada.BackColor = System.Drawing.SystemColors.MenuText
        Me.txtContraseñaIngresada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContraseñaIngresada.Font = New System.Drawing.Font("Arial", 10.25!)
        Me.txtContraseñaIngresada.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.txtContraseñaIngresada.Location = New System.Drawing.Point(555, 405)
        Me.txtContraseñaIngresada.Name = "txtContraseñaIngresada"
        Me.txtContraseñaIngresada.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9787)
        Me.txtContraseñaIngresada.Size = New System.Drawing.Size(225, 23)
        Me.txtContraseñaIngresada.TabIndex = 6
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.ForeColor = System.Drawing.Color.Yellow
        Me.lblError.Location = New System.Drawing.Point(643, 466)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(0, 13)
        Me.lblError.TabIndex = 7
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 3
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(564, 560)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(206, 44)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Salir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Aniveo.My.Resources.Resources.milveinte
        Me.PictureBox1.Location = New System.Drawing.Point(36, -304)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1280, 720)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.txtContraseñaIngresada)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtUsuarioIngresado)
        Me.Controls.Add(Me.Nombre)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.ForeColor = System.Drawing.Color.Yellow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Inicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Nombre As Label
    Friend WithEvents txtUsuarioIngresado As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtContraseñaIngresada As TextBox
    Friend WithEvents lblError As Label
    Friend WithEvents Button2 As Button
End Class
