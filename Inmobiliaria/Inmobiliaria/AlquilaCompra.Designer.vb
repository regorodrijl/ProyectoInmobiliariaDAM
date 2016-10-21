<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AlquilaCompra
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AlquilaCompra))
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.CmbInmueble = New System.Windows.Forms.ComboBox()
        Me.LblInmueble = New System.Windows.Forms.Label()
        Me.LblCliente = New System.Windows.Forms.Label()
        Me.CmbCliente = New System.Windows.Forms.ComboBox()
        Me.LblFecha = New System.Windows.Forms.Label()
        Me.DtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(7, 125)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAceptar.TabIndex = 13
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Location = New System.Drawing.Point(192, 125)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(75, 23)
        Me.BtnCerrar.TabIndex = 14
        Me.BtnCerrar.Text = "Cerrar"
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'CmbInmueble
        '
        Me.CmbInmueble.FormattingEnabled = True
        Me.CmbInmueble.Location = New System.Drawing.Point(104, 43)
        Me.CmbInmueble.Name = "CmbInmueble"
        Me.CmbInmueble.Size = New System.Drawing.Size(121, 21)
        Me.CmbInmueble.TabIndex = 21
        '
        'LblInmueble
        '
        Me.LblInmueble.AutoSize = True
        Me.LblInmueble.Location = New System.Drawing.Point(31, 46)
        Me.LblInmueble.Name = "LblInmueble"
        Me.LblInmueble.Size = New System.Drawing.Size(53, 13)
        Me.LblInmueble.TabIndex = 20
        Me.LblInmueble.Text = "Inmueble:"
        '
        'LblCliente
        '
        Me.LblCliente.AutoSize = True
        Me.LblCliente.Location = New System.Drawing.Point(31, 15)
        Me.LblCliente.Name = "LblCliente"
        Me.LblCliente.Size = New System.Drawing.Size(42, 13)
        Me.LblCliente.TabIndex = 19
        Me.LblCliente.Text = "Cliente:"
        '
        'CmbCliente
        '
        Me.CmbCliente.FormattingEnabled = True
        Me.CmbCliente.Location = New System.Drawing.Point(104, 12)
        Me.CmbCliente.Name = "CmbCliente"
        Me.CmbCliente.Size = New System.Drawing.Size(121, 21)
        Me.CmbCliente.TabIndex = 18
        '
        'LblFecha
        '
        Me.LblFecha.AutoSize = True
        Me.LblFecha.Location = New System.Drawing.Point(31, 81)
        Me.LblFecha.Name = "LblFecha"
        Me.LblFecha.Size = New System.Drawing.Size(68, 13)
        Me.LblFecha.TabIndex = 23
        Me.LblFecha.Text = "Fecha Inicio:"
        '
        'DtpFecha
        '
        Me.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFecha.Location = New System.Drawing.Point(104, 75)
        Me.DtpFecha.Name = "DtpFecha"
        Me.DtpFecha.Size = New System.Drawing.Size(121, 20)
        Me.DtpFecha.TabIndex = 22
        '
        'AlquilaCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(279, 167)
        Me.Controls.Add(Me.LblFecha)
        Me.Controls.Add(Me.DtpFecha)
        Me.Controls.Add(Me.CmbInmueble)
        Me.Controls.Add(Me.LblInmueble)
        Me.Controls.Add(Me.LblCliente)
        Me.Controls.Add(Me.CmbCliente)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AlquilaCompra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alquila/Compra"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnAceptar As System.Windows.Forms.Button
    Friend WithEvents BtnCerrar As System.Windows.Forms.Button
    Friend WithEvents CmbInmueble As System.Windows.Forms.ComboBox
    Protected WithEvents LblInmueble As System.Windows.Forms.Label
    Friend WithEvents LblCliente As System.Windows.Forms.Label
    Friend WithEvents CmbCliente As System.Windows.Forms.ComboBox
    Friend WithEvents LblFecha As System.Windows.Forms.Label
    Friend WithEvents DtpFecha As System.Windows.Forms.DateTimePicker
End Class
