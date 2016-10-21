<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gestion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Gestion))
        Me.DtgVisitas = New System.Windows.Forms.DataGridView()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.TsEmpresa = New System.Windows.Forms.ToolStrip()
        Me.TsNuevo = New System.Windows.Forms.ToolStripDropDownButton()
        Me.TsNuevoUsuario = New System.Windows.Forms.ToolStripMenuItem()
        Me.TsNuevoInmueble = New System.Windows.Forms.ToolStripMenuItem()
        Me.TsNuevoVisita = New System.Windows.Forms.ToolStripMenuItem()
        Me.TsBuscar = New System.Windows.Forms.ToolStripButton()
        Me.TsModificar = New System.Windows.Forms.ToolStripSplitButton()
        Me.TsModificarCEP = New System.Windows.Forms.ToolStripMenuItem()
        Me.TsModificarVisita = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarInmuebleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.TsSalir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.LblVisitas = New System.Windows.Forms.Label()
        Me.BtnVisita = New System.Windows.Forms.Button()
        Me.BtnVer = New System.Windows.Forms.Button()
        Me.BtnAlquila = New System.Windows.Forms.Button()
        CType(Me.DtgVisitas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TsEmpresa.SuspendLayout()
        Me.SuspendLayout()
        '
        'DtgVisitas
        '
        Me.DtgVisitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgVisitas.Location = New System.Drawing.Point(12, 58)
        Me.DtgVisitas.Name = "DtgVisitas"
        Me.DtgVisitas.Size = New System.Drawing.Size(386, 181)
        Me.DtgVisitas.TabIndex = 3
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Location = New System.Drawing.Point(323, 245)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(75, 23)
        Me.BtnCerrar.TabIndex = 2
        Me.BtnCerrar.Text = "Cerrar"
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'TsEmpresa
        '
        Me.TsEmpresa.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TsNuevo, Me.TsBuscar, Me.TsModificar, Me.ToolStripSeparator1, Me.TsSalir, Me.ToolStripButton1})
        Me.TsEmpresa.Location = New System.Drawing.Point(0, 0)
        Me.TsEmpresa.Name = "TsEmpresa"
        Me.TsEmpresa.Size = New System.Drawing.Size(410, 25)
        Me.TsEmpresa.TabIndex = 21
        Me.TsEmpresa.Text = "ToolStrip1"
        '
        'TsNuevo
        '
        Me.TsNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TsNuevo.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TsNuevoUsuario, Me.TsNuevoInmueble, Me.TsNuevoVisita})
        Me.TsNuevo.Image = CType(resources.GetObject("TsNuevo.Image"), System.Drawing.Image)
        Me.TsNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsNuevo.Name = "TsNuevo"
        Me.TsNuevo.Size = New System.Drawing.Size(29, 22)
        Me.TsNuevo.Text = "Nuevo"
        '
        'TsNuevoUsuario
        '
        Me.TsNuevoUsuario.Name = "TsNuevoUsuario"
        Me.TsNuevoUsuario.Size = New System.Drawing.Size(162, 22)
        Me.TsNuevoUsuario.Text = "Nuevo C / E / P"
        '
        'TsNuevoInmueble
        '
        Me.TsNuevoInmueble.Name = "TsNuevoInmueble"
        Me.TsNuevoInmueble.Size = New System.Drawing.Size(162, 22)
        Me.TsNuevoInmueble.Text = "Nuevo Inmueble"
        '
        'TsNuevoVisita
        '
        Me.TsNuevoVisita.Name = "TsNuevoVisita"
        Me.TsNuevoVisita.Size = New System.Drawing.Size(162, 22)
        Me.TsNuevoVisita.Text = "Nueva Visita"
        '
        'TsBuscar
        '
        Me.TsBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TsBuscar.Image = CType(resources.GetObject("TsBuscar.Image"), System.Drawing.Image)
        Me.TsBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsBuscar.Name = "TsBuscar"
        Me.TsBuscar.Size = New System.Drawing.Size(23, 22)
        Me.TsBuscar.Text = "Buscar"
        '
        'TsModificar
        '
        Me.TsModificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TsModificar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TsModificarCEP, Me.TsModificarVisita, Me.ModificarInmuebleToolStripMenuItem})
        Me.TsModificar.Image = CType(resources.GetObject("TsModificar.Image"), System.Drawing.Image)
        Me.TsModificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsModificar.Name = "TsModificar"
        Me.TsModificar.Size = New System.Drawing.Size(32, 22)
        Me.TsModificar.Text = "Modificar"
        '
        'TsModificarCEP
        '
        Me.TsModificarCEP.Name = "TsModificarCEP"
        Me.TsModificarCEP.Size = New System.Drawing.Size(178, 22)
        Me.TsModificarCEP.Text = "Modificar C/E/P"
        '
        'TsModificarVisita
        '
        Me.TsModificarVisita.Name = "TsModificarVisita"
        Me.TsModificarVisita.Size = New System.Drawing.Size(178, 22)
        Me.TsModificarVisita.Text = "Modificar Visita"
        '
        'ModificarInmuebleToolStripMenuItem
        '
        Me.ModificarInmuebleToolStripMenuItem.Name = "ModificarInmuebleToolStripMenuItem"
        Me.ModificarInmuebleToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.ModificarInmuebleToolStripMenuItem.Text = "Modificar Inmueble"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'TsSalir
        '
        Me.TsSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TsSalir.Image = CType(resources.GetObject("TsSalir.Image"), System.Drawing.Image)
        Me.TsSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsSalir.Name = "TsSalir"
        Me.TsSalir.Size = New System.Drawing.Size(23, 22)
        Me.TsSalir.Text = "Salir de la Aplicación"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "Imprimir"
        '
        'LblVisitas
        '
        Me.LblVisitas.AutoSize = True
        Me.LblVisitas.Location = New System.Drawing.Point(13, 29)
        Me.LblVisitas.Name = "LblVisitas"
        Me.LblVisitas.Size = New System.Drawing.Size(85, 13)
        Me.LblVisitas.TabIndex = 22
        Me.LblVisitas.Text = "Visitas a realizar:"
        '
        'BtnVisita
        '
        Me.BtnVisita.Location = New System.Drawing.Point(16, 245)
        Me.BtnVisita.Name = "BtnVisita"
        Me.BtnVisita.Size = New System.Drawing.Size(75, 23)
        Me.BtnVisita.TabIndex = 23
        Me.BtnVisita.Text = "Nueva Visita"
        Me.BtnVisita.UseVisualStyleBackColor = True
        '
        'BtnVer
        '
        Me.BtnVer.Location = New System.Drawing.Point(232, 245)
        Me.BtnVer.Name = "BtnVer"
        Me.BtnVer.Size = New System.Drawing.Size(75, 23)
        Me.BtnVer.TabIndex = 1
        Me.BtnVer.Text = "Ver Todo"
        Me.BtnVer.UseVisualStyleBackColor = True
        '
        'BtnAlquila
        '
        Me.BtnAlquila.Location = New System.Drawing.Point(110, 245)
        Me.BtnAlquila.Name = "BtnAlquila"
        Me.BtnAlquila.Size = New System.Drawing.Size(103, 23)
        Me.BtnAlquila.TabIndex = 25
        Me.BtnAlquila.Text = "Alquila/Compra"
        Me.BtnAlquila.UseVisualStyleBackColor = True
        '
        'Gestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(410, 280)
        Me.Controls.Add(Me.BtnAlquila)
        Me.Controls.Add(Me.BtnVer)
        Me.Controls.Add(Me.BtnVisita)
        Me.Controls.Add(Me.LblVisitas)
        Me.Controls.Add(Me.TsEmpresa)
        Me.Controls.Add(Me.DtgVisitas)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(555, 0)
        Me.Name = "Gestion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestión"
        CType(Me.DtgVisitas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TsEmpresa.ResumeLayout(False)
        Me.TsEmpresa.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DtgVisitas As System.Windows.Forms.DataGridView
    Friend WithEvents BtnCerrar As System.Windows.Forms.Button
    Friend WithEvents TsEmpresa As System.Windows.Forms.ToolStrip
    Friend WithEvents TsNuevo As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents TsNuevoUsuario As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TsNuevoInmueble As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TsNuevoVisita As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TsSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents LblVisitas As System.Windows.Forms.Label
    Friend WithEvents BtnVisita As System.Windows.Forms.Button
    Friend WithEvents BtnVer As System.Windows.Forms.Button
    Friend WithEvents BtnAlquila As System.Windows.Forms.Button
    Friend WithEvents TsModificar As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents TsModificarCEP As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TsModificarVisita As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificarInmuebleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TsBuscar As System.Windows.Forms.ToolStripButton
End Class
