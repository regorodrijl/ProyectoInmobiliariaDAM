<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarVisita
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModificarVisita))
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.CmbCliente = New System.Windows.Forms.ComboBox()
        Me.DtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.LblCliente = New System.Windows.Forms.Label()
        Me.LblInmueble = New System.Windows.Forms.Label()
        Me.CmbInmueble = New System.Windows.Forms.ComboBox()
        Me.LblFecha = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DtpHora = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DtgVisitas = New System.Windows.Forms.DataGridView()
        CType(Me.DtgVisitas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(12, 182)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAceptar.TabIndex = 11
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Location = New System.Drawing.Point(437, 182)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(75, 23)
        Me.BtnCerrar.TabIndex = 12
        Me.BtnCerrar.Text = "Cerrar"
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'CmbCliente
        '
        Me.CmbCliente.Enabled = False
        Me.CmbCliente.FormattingEnabled = True
        Me.CmbCliente.Location = New System.Drawing.Point(391, 25)
        Me.CmbCliente.Name = "CmbCliente"
        Me.CmbCliente.Size = New System.Drawing.Size(121, 21)
        Me.CmbCliente.TabIndex = 13
        '
        'DtpFecha
        '
        Me.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFecha.Location = New System.Drawing.Point(391, 97)
        Me.DtpFecha.Name = "DtpFecha"
        Me.DtpFecha.Size = New System.Drawing.Size(121, 20)
        Me.DtpFecha.TabIndex = 14
        '
        'LblCliente
        '
        Me.LblCliente.AutoSize = True
        Me.LblCliente.Location = New System.Drawing.Point(318, 28)
        Me.LblCliente.Name = "LblCliente"
        Me.LblCliente.Size = New System.Drawing.Size(42, 13)
        Me.LblCliente.TabIndex = 15
        Me.LblCliente.Text = "Cliente:"
        '
        'LblInmueble
        '
        Me.LblInmueble.AutoSize = True
        Me.LblInmueble.Location = New System.Drawing.Point(318, 59)
        Me.LblInmueble.Name = "LblInmueble"
        Me.LblInmueble.Size = New System.Drawing.Size(53, 13)
        Me.LblInmueble.TabIndex = 16
        Me.LblInmueble.Text = "Inmueble:"
        '
        'CmbInmueble
        '
        Me.CmbInmueble.Enabled = False
        Me.CmbInmueble.FormattingEnabled = True
        Me.CmbInmueble.Location = New System.Drawing.Point(391, 56)
        Me.CmbInmueble.Name = "CmbInmueble"
        Me.CmbInmueble.Size = New System.Drawing.Size(121, 21)
        Me.CmbInmueble.TabIndex = 17
        '
        'LblFecha
        '
        Me.LblFecha.AutoSize = True
        Me.LblFecha.Location = New System.Drawing.Point(339, 99)
        Me.LblFecha.Name = "LblFecha"
        Me.LblFecha.Size = New System.Drawing.Size(40, 13)
        Me.LblFecha.TabIndex = 18
        Me.LblFecha.Text = "Fecha:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(339, 133)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Hora:"
        '
        'DtpHora
        '
        Me.DtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DtpHora.Location = New System.Drawing.Point(391, 131)
        Me.DtpHora.Name = "DtpHora"
        Me.DtpHora.Size = New System.Drawing.Size(121, 20)
        Me.DtpHora.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Visitas:"
        '
        'DtgVisitas
        '
        Me.DtgVisitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgVisitas.Location = New System.Drawing.Point(12, 25)
        Me.DtgVisitas.Name = "DtgVisitas"
        Me.DtgVisitas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DtgVisitas.Size = New System.Drawing.Size(266, 120)
        Me.DtgVisitas.TabIndex = 21
        '
        'ModificarVisita
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(543, 234)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DtgVisitas)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DtpHora)
        Me.Controls.Add(Me.LblFecha)
        Me.Controls.Add(Me.CmbInmueble)
        Me.Controls.Add(Me.LblInmueble)
        Me.Controls.Add(Me.LblCliente)
        Me.Controls.Add(Me.DtpFecha)
        Me.Controls.Add(Me.CmbCliente)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ModificarVisita"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar Visita"
        CType(Me.DtgVisitas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnAceptar As System.Windows.Forms.Button
    Friend WithEvents BtnCerrar As System.Windows.Forms.Button
    Friend WithEvents CmbCliente As System.Windows.Forms.ComboBox
    Friend WithEvents DtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblCliente As System.Windows.Forms.Label
    Protected WithEvents LblInmueble As System.Windows.Forms.Label
    Friend WithEvents CmbInmueble As System.Windows.Forms.ComboBox
    Friend WithEvents LblFecha As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DtpHora As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DtgVisitas As System.Windows.Forms.DataGridView
End Class
