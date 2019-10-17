<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ListarContenido
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
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.lblInfo2 = New System.Windows.Forms.Label()
        Me.lvContenido = New System.Windows.Forms.ListView()
        Me.ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Titulo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Genero = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.fecha = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Minutos = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Segundos = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.capitulo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
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
        Me.Button1.Location = New System.Drawing.Point(247, 512)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(206, 44)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Listar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.lblInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.lblInfo.Location = New System.Drawing.Point(210, 44)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(265, 39)
        Me.lblInfo.TabIndex = 10
        Me.lblInfo.Text = "Listar Contenido"
        '
        'lblInfo2
        '
        Me.lblInfo2.AutoSize = True
        Me.lblInfo2.Location = New System.Drawing.Point(330, 298)
        Me.lblInfo2.Name = "lblInfo2"
        Me.lblInfo2.Size = New System.Drawing.Size(0, 19)
        Me.lblInfo2.TabIndex = 14
        '
        'lvContenido
        '
        Me.lvContenido.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.Titulo, Me.Genero, Me.fecha, Me.Minutos, Me.Segundos, Me.capitulo})
        Me.lvContenido.Location = New System.Drawing.Point(47, 103)
        Me.lvContenido.Name = "lvContenido"
        Me.lvContenido.Size = New System.Drawing.Size(667, 379)
        Me.lvContenido.TabIndex = 15
        Me.lvContenido.UseCompatibleStateImageBehavior = False
        Me.lvContenido.View = System.Windows.Forms.View.Details
        '
        'ID
        '
        Me.ID.DisplayIndex = 0
        Me.ID.Text = "ID"
        '
        'Titulo
        '
        Me.Titulo.DisplayIndex = 1
        Me.Titulo.Text = "Titulo"
        Me.Titulo.Width = 111
        '
        'Genero
        '
        Me.Genero.DisplayIndex = 2
        Me.Genero.Text = "Genero"
        Me.Genero.Width = 92
        '
        'fecha
        '
        Me.fecha.DisplayIndex = 3
        Me.fecha.Text = "fecha"
        '
        'Minutos
        '
        Me.Minutos.Text = "Minutos"
        Me.Minutos.Width = 73
        '
        'Segundos
        '
        Me.Segundos.Text = "Segundos"
        Me.Segundos.Width = 88
        '
        'capitulo
        '
        Me.capitulo.Text = "temporada"
        Me.capitulo.Width = 124
        '
        'ListarContenido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(726, 638)
        Me.Controls.Add(Me.lvContenido)
        Me.Controls.Add(Me.lblInfo2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial Black", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ListarContenido"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "delcomment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents lblInfo As Label
    Friend WithEvents lblInfo2 As Label
    Friend WithEvents lvContenido As ListView
    Friend WithEvents ID As ColumnHeader
    Friend WithEvents Titulo As ColumnHeader
    Friend WithEvents Genero As ColumnHeader
    Friend WithEvents fecha As ColumnHeader
    Friend WithEvents Minutos As ColumnHeader
    Friend WithEvents Segundos As ColumnHeader
    Friend WithEvents capitulo As ColumnHeader
End Class
