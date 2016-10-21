<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarPersona
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
        Me.TxtTelef2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtApellidos = New System.Windows.Forms.TextBox()
        Me.ButnCancelar = New System.Windows.Forms.Button()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtDireccion = New System.Windows.Forms.TextBox()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.LblTelefono = New System.Windows.Forms.Label()
        Me.LblNif = New System.Windows.Forms.Label()
        Me.LblApellido = New System.Windows.Forms.Label()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.LblDireccion = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DtgPersonas = New System.Windows.Forms.DataGridView()
        Me.TxtNif = New System.Windows.Forms.TextBox()
        CType(Me.DtgPersonas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtTelef2
        '
        Me.TxtTelef2.Location = New System.Drawing.Point(429, 305)
        Me.TxtTelef2.MaxLength = 15
        Me.TxtTelef2.Name = "TxtTelef2"
        Me.TxtTelef2.Size = New System.Drawing.Size(132, 20)
        Me.TxtTelef2.TabIndex = 88
        Me.TxtTelef2.Tag = "4"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(371, 308)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 89
        Me.Label1.Text = "Teléfono 2:"
        '
        'TxtApellidos
        '
        Me.TxtApellidos.Location = New System.Drawing.Point(429, 229)
        Me.TxtApellidos.MaxLength = 50
        Me.TxtApellidos.Name = "TxtApellidos"
        Me.TxtApellidos.Size = New System.Drawing.Size(132, 20)
        Me.TxtApellidos.TabIndex = 72
        Me.TxtApellidos.Tag = "2"
        '
        'ButnCancelar
        '
        Me.ButnCancelar.Location = New System.Drawing.Point(471, 378)
        Me.ButnCancelar.Name = "ButnCancelar"
        Me.ButnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.ButnCancelar.TabIndex = 77
        Me.ButnCancelar.Text = "Cancelar"
        Me.ButnCancelar.UseVisualStyleBackColor = True
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(151, 378)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAceptar.TabIndex = 76
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(207, 229)
        Me.TxtNombre.MaxLength = 50
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(132, 20)
        Me.TxtNombre.TabIndex = 71
        Me.TxtNombre.Tag = "1"
        '
        'TxtDireccion
        '
        Me.TxtDireccion.Location = New System.Drawing.Point(207, 308)
        Me.TxtDireccion.MaxLength = 150
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(132, 20)
        Me.TxtDireccion.TabIndex = 75
        Me.TxtDireccion.Tag = "5"
        '
        'TxtTelefono
        '
        Me.TxtTelefono.Location = New System.Drawing.Point(429, 269)
        Me.TxtTelefono.MaxLength = 15
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(132, 20)
        Me.TxtTelefono.TabIndex = 74
        Me.TxtTelefono.Tag = "4"
        '
        'LblTelefono
        '
        Me.LblTelefono.AutoSize = True
        Me.LblTelefono.Location = New System.Drawing.Point(371, 272)
        Me.LblTelefono.Name = "LblTelefono"
        Me.LblTelefono.Size = New System.Drawing.Size(52, 13)
        Me.LblTelefono.TabIndex = 82
        Me.LblTelefono.Text = "Teléfono:"
        '
        'LblNif
        '
        Me.LblNif.AutoSize = True
        Me.LblNif.Location = New System.Drawing.Point(143, 272)
        Me.LblNif.Name = "LblNif"
        Me.LblNif.Size = New System.Drawing.Size(29, 13)
        Me.LblNif.TabIndex = 81
        Me.LblNif.Text = "DNI:"
        '
        'LblApellido
        '
        Me.LblApellido.AutoSize = True
        Me.LblApellido.Location = New System.Drawing.Point(374, 232)
        Me.LblApellido.Name = "LblApellido"
        Me.LblApellido.Size = New System.Drawing.Size(52, 13)
        Me.LblApellido.TabIndex = 80
        Me.LblApellido.Text = "Apellidos:"
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Location = New System.Drawing.Point(141, 232)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(47, 13)
        Me.LblNombre.TabIndex = 79
        Me.LblNombre.Text = "Nombre:"
        '
        'LblDireccion
        '
        Me.LblDireccion.AutoSize = True
        Me.LblDireccion.Location = New System.Drawing.Point(141, 308)
        Me.LblDireccion.Name = "LblDireccion"
        Me.LblDireccion.Size = New System.Drawing.Size(55, 13)
        Me.LblDireccion.TabIndex = 78
        Me.LblDireccion.Text = "Dirección:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(51, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 92
        Me.Label2.Text = "Personas:"
        '
        'DtgPersonas
        '
        Me.DtgPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgPersonas.Location = New System.Drawing.Point(54, 32)
        Me.DtgPersonas.Name = "DtgPersonas"
        Me.DtgPersonas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DtgPersonas.Size = New System.Drawing.Size(611, 157)
        Me.DtgPersonas.TabIndex = 91
        '
        'TxtNif
        '
        Me.TxtNif.Location = New System.Drawing.Point(207, 269)
        Me.TxtNif.MaxLength = 9
        Me.TxtNif.Name = "TxtNif"
        Me.TxtNif.Size = New System.Drawing.Size(132, 20)
        Me.TxtNif.TabIndex = 93
        Me.TxtNif.Tag = "3"
        '
        'ModificarPersona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(739, 414)
        Me.Controls.Add(Me.TxtNif)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DtgPersonas)
        Me.Controls.Add(Me.TxtTelef2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtApellidos)
        Me.Controls.Add(Me.ButnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.TxtDireccion)
        Me.Controls.Add(Me.TxtTelefono)
        Me.Controls.Add(Me.LblTelefono)
        Me.Controls.Add(Me.LblNif)
        Me.Controls.Add(Me.LblApellido)
        Me.Controls.Add(Me.LblNombre)
        Me.Controls.Add(Me.LblDireccion)
        Me.Name = "ModificarPersona"
        Me.Text = "ModificarPersona"
        CType(Me.DtgPersonas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtTelef2 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtApellidos As System.Windows.Forms.TextBox
    Friend WithEvents ButnCancelar As System.Windows.Forms.Button
    Friend WithEvents BtnAceptar As System.Windows.Forms.Button
    Friend WithEvents TxtNombre As System.Windows.Forms.TextBox
    Friend WithEvents TxtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents TxtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents LblTelefono As System.Windows.Forms.Label
    Friend WithEvents LblNif As System.Windows.Forms.Label
    Friend WithEvents LblApellido As System.Windows.Forms.Label
    Friend WithEvents LblNombre As System.Windows.Forms.Label
    Friend WithEvents LblDireccion As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DtgPersonas As System.Windows.Forms.DataGridView
    Friend WithEvents TxtNif As System.Windows.Forms.TextBox
End Class
