<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AplicacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarAplicacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PeliculaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarPeliculaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarPeliculaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarPeliculaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BorrarUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Useresq = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.MenuStrip1.Font = New System.Drawing.Font("Arial Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AplicacionToolStripMenuItem, Me.PeliculaToolStripMenuItem, Me.UsuariosToolStripMenuItem, Me.ToolStripMenuItem3})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1280, 25)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AplicacionToolStripMenuItem
        '
        Me.AplicacionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarAplicacionToolStripMenuItem})
        Me.AplicacionToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.AplicacionToolStripMenuItem.Name = "AplicacionToolStripMenuItem"
        Me.AplicacionToolStripMenuItem.Size = New System.Drawing.Size(89, 21)
        Me.AplicacionToolStripMenuItem.Text = "Aplicacion"
        '
        'CerrarAplicacionToolStripMenuItem
        '
        Me.CerrarAplicacionToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.CerrarAplicacionToolStripMenuItem.Name = "CerrarAplicacionToolStripMenuItem"
        Me.CerrarAplicacionToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.CerrarAplicacionToolStripMenuItem.Text = "Cerrar Aplicacion"
        '
        'PeliculaToolStripMenuItem
        '
        Me.PeliculaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarPeliculaToolStripMenuItem, Me.EliminarPeliculaToolStripMenuItem, Me.ToolStripMenuItem1, Me.ModificarPeliculaToolStripMenuItem})
        Me.PeliculaToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.PeliculaToolStripMenuItem.Name = "PeliculaToolStripMenuItem"
        Me.PeliculaToolStripMenuItem.Size = New System.Drawing.Size(86, 21)
        Me.PeliculaToolStripMenuItem.Text = "Contenido"
        '
        'AgregarPeliculaToolStripMenuItem
        '
        Me.AgregarPeliculaToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.AgregarPeliculaToolStripMenuItem.Name = "AgregarPeliculaToolStripMenuItem"
        Me.AgregarPeliculaToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.AgregarPeliculaToolStripMenuItem.Text = "Agregar contenido"
        '
        'EliminarPeliculaToolStripMenuItem
        '
        Me.EliminarPeliculaToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.EliminarPeliculaToolStripMenuItem.Name = "EliminarPeliculaToolStripMenuItem"
        Me.EliminarPeliculaToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.EliminarPeliculaToolStripMenuItem.Text = "Eliminar contenido"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(206, 22)
        Me.ToolStripMenuItem1.Text = "Listar contenido"
        '
        'ModificarPeliculaToolStripMenuItem
        '
        Me.ModificarPeliculaToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.ModificarPeliculaToolStripMenuItem.Name = "ModificarPeliculaToolStripMenuItem"
        Me.ModificarPeliculaToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.ModificarPeliculaToolStripMenuItem.Text = "Modificar contenido"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarUsuarioToolStripMenuItem, Me.BorrarUsuarioToolStripMenuItem, Me.ToolStripMenuItem2, Me.ModificarUsuarioToolStripMenuItem})
        Me.UsuariosToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(77, 21)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'AgregarUsuarioToolStripMenuItem
        '
        Me.AgregarUsuarioToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.AgregarUsuarioToolStripMenuItem.Name = "AgregarUsuarioToolStripMenuItem"
        Me.AgregarUsuarioToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.AgregarUsuarioToolStripMenuItem.Text = "Agregar Usuario"
        '
        'BorrarUsuarioToolStripMenuItem
        '
        Me.BorrarUsuarioToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.BorrarUsuarioToolStripMenuItem.Name = "BorrarUsuarioToolStripMenuItem"
        Me.BorrarUsuarioToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.BorrarUsuarioToolStripMenuItem.Text = "Borrar Usuario"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(189, 22)
        Me.ToolStripMenuItem2.Text = "Listar Usuario"
        '
        'ModificarUsuarioToolStripMenuItem
        '
        Me.ModificarUsuarioToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.ModificarUsuarioToolStripMenuItem.Name = "ModificarUsuarioToolStripMenuItem"
        Me.ModificarUsuarioToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.ModificarUsuarioToolStripMenuItem.Text = "Modificar usuario"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem4, Me.ToolStripMenuItem5})
        Me.ToolStripMenuItem3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(102, 21)
        Me.ToolStripMenuItem3.Text = "Comentarios"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(202, 22)
        Me.ToolStripMenuItem4.Text = "Listar comentarios"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(202, 22)
        Me.ToolStripMenuItem5.Text = "Borrar comentarios"
        '
        'Useresq
        '
        Me.Useresq.AutoSize = True
        Me.Useresq.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.Useresq.Font = New System.Drawing.Font("Arial Black", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Useresq.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Useresq.Location = New System.Drawing.Point(1073, -2)
        Me.Useresq.Name = "Useresq"
        Me.Useresq.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Useresq.Size = New System.Drawing.Size(18, 27)
        Me.Useresq.TabIndex = 3
        Me.Useresq.Text = "-"
        Me.Useresq.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(5.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BackgroundImage = Global.Aniveo.My.Resources.Resources.milveinte
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.ControlBox = False
        Me.Controls.Add(Me.Useresq)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Impact", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "x"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PeliculaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarPeliculaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarPeliculaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AplicacionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarAplicacionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarUsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BorrarUsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Useresq As Label
    Friend WithEvents ModificarPeliculaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarUsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As ToolStripMenuItem
End Class
