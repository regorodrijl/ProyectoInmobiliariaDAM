<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NuevoUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NuevoUsuario))
        Me.TxtApellidos = New System.Windows.Forms.TextBox()
        Me.ButnCancelar = New System.Windows.Forms.Button()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.TxtNif = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtDireccion = New System.Windows.Forms.TextBox()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.LblTelefono = New System.Windows.Forms.Label()
        Me.LblNif = New System.Windows.Forms.Label()
        Me.LblApellido = New System.Windows.Forms.Label()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.LblDireccion = New System.Windows.Forms.Label()
        Me.CbEmpleado = New System.Windows.Forms.CheckBox()
        Me.CbPropietario = New System.Windows.Forms.CheckBox()
        Me.CbCliente = New System.Windows.Forms.CheckBox()
        Me.LblNSS = New System.Windows.Forms.Label()
        Me.TxtNSS = New System.Windows.Forms.TextBox()
        Me.TxtTelef2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TxtApellidos
        '
        Me.TxtApellidos.Location = New System.Drawing.Point(300, 19)
        Me.TxtApellidos.MaxLength = 50
        Me.TxtApellidos.Name = "TxtApellidos"
        Me.TxtApellidos.Size = New System.Drawing.Size(132, 20)
        Me.TxtApellidos.TabIndex = 53
        Me.TxtApellidos.Tag = "2"
        '
        'ButnCancelar
        '
        Me.ButnCancelar.Location = New System.Drawing.Point(300, 268)
        Me.ButnCancelar.Name = "ButnCancelar"
        Me.ButnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.ButnCancelar.TabIndex = 58
        Me.ButnCancelar.Text = "Cancelar"
        Me.ButnCancelar.UseVisualStyleBackColor = True
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(119, 268)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAceptar.TabIndex = 57
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'TxtNif
        '
        Me.TxtNif.Location = New System.Drawing.Point(78, 59)
        Me.TxtNif.MaxLength = 9
        Me.TxtNif.Name = "TxtNif"
        Me.TxtNif.Size = New System.Drawing.Size(132, 20)
        Me.TxtNif.TabIndex = 54
        Me.TxtNif.Tag = "3"
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(78, 19)
        Me.TxtNombre.MaxLength = 50
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(132, 20)
        Me.TxtNombre.TabIndex = 52
        Me.TxtNombre.Tag = "1"
        '
        'TxtDireccion
        '
        Me.TxtDireccion.Location = New System.Drawing.Point(78, 102)
        Me.TxtDireccion.MaxLength = 255
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(132, 20)
        Me.TxtDireccion.TabIndex = 56
        Me.TxtDireccion.Tag = "5"
        '
        'TxtTelefono
        '
        Me.TxtTelefono.Location = New System.Drawing.Point(300, 59)
        Me.TxtTelefono.MaxLength = 15
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(132, 20)
        Me.TxtTelefono.TabIndex = 55
        Me.TxtTelefono.Tag = "4"
        '
        'LblTelefono
        '
        Me.LblTelefono.AutoSize = True
        Me.LblTelefono.Location = New System.Drawing.Point(242, 62)
        Me.LblTelefono.Name = "LblTelefono"
        Me.LblTelefono.Size = New System.Drawing.Size(52, 13)
        Me.LblTelefono.TabIndex = 63
        Me.LblTelefono.Text = "Teléfono:"
        '
        'LblNif
        '
        Me.LblNif.AutoSize = True
        Me.LblNif.Location = New System.Drawing.Point(14, 62)
        Me.LblNif.Name = "LblNif"
        Me.LblNif.Size = New System.Drawing.Size(29, 13)
        Me.LblNif.TabIndex = 62
        Me.LblNif.Text = "DNI:"
        '
        'LblApellido
        '
        Me.LblApellido.AutoSize = True
        Me.LblApellido.Location = New System.Drawing.Point(245, 22)
        Me.LblApellido.Name = "LblApellido"
        Me.LblApellido.Size = New System.Drawing.Size(52, 13)
        Me.LblApellido.TabIndex = 61
        Me.LblApellido.Text = "Apellidos:"
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Location = New System.Drawing.Point(12, 22)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(47, 13)
        Me.LblNombre.TabIndex = 60
        Me.LblNombre.Text = "Nombre:"
        '
        'LblDireccion
        '
        Me.LblDireccion.AutoSize = True
        Me.LblDireccion.Location = New System.Drawing.Point(12, 102)
        Me.LblDireccion.Name = "LblDireccion"
        Me.LblDireccion.Size = New System.Drawing.Size(55, 13)
        Me.LblDireccion.TabIndex = 59
        Me.LblDireccion.Text = "Dirección:"
        '
        'CbEmpleado
        '
        Me.CbEmpleado.AutoSize = True
        Me.CbEmpleado.Location = New System.Drawing.Point(134, 190)
        Me.CbEmpleado.Name = "CbEmpleado"
        Me.CbEmpleado.Size = New System.Drawing.Size(73, 17)
        Me.CbEmpleado.TabIndex = 64
        Me.CbEmpleado.Text = "Empleado"
        Me.CbEmpleado.UseVisualStyleBackColor = True
        '
        'CbPropietario
        '
        Me.CbPropietario.AutoSize = True
        Me.CbPropietario.Location = New System.Drawing.Point(134, 144)
        Me.CbPropietario.Name = "CbPropietario"
        Me.CbPropietario.Size = New System.Drawing.Size(76, 17)
        Me.CbPropietario.TabIndex = 65
        Me.CbPropietario.Text = "Propietario"
        Me.CbPropietario.UseVisualStyleBackColor = True
        '
        'CbCliente
        '
        Me.CbCliente.AutoSize = True
        Me.CbCliente.Location = New System.Drawing.Point(134, 167)
        Me.CbCliente.Name = "CbCliente"
        Me.CbCliente.Size = New System.Drawing.Size(58, 17)
        Me.CbCliente.TabIndex = 66
        Me.CbCliente.Text = "Cliente"
        Me.CbCliente.UseVisualStyleBackColor = True
        '
        'LblNSS
        '
        Me.LblNSS.AutoSize = True
        Me.LblNSS.Location = New System.Drawing.Point(134, 214)
        Me.LblNSS.Name = "LblNSS"
        Me.LblNSS.Size = New System.Drawing.Size(105, 13)
        Me.LblNSS.TabIndex = 67
        Me.LblNSS.Text = "Nº Seguridad Social:"
        Me.LblNSS.Visible = False
        '
        'TxtNSS
        '
        Me.TxtNSS.Location = New System.Drawing.Point(245, 211)
        Me.TxtNSS.MaxLength = 20
        Me.TxtNSS.Name = "TxtNSS"
        Me.TxtNSS.Size = New System.Drawing.Size(143, 20)
        Me.TxtNSS.TabIndex = 68
        Me.TxtNSS.Visible = False
        '
        'TxtTelef2
        '
        Me.TxtTelef2.Location = New System.Drawing.Point(300, 95)
        Me.TxtTelef2.MaxLength = 15
        Me.TxtTelef2.Name = "TxtTelef2"
        Me.TxtTelef2.Size = New System.Drawing.Size(132, 20)
        Me.TxtTelef2.TabIndex = 69
        Me.TxtTelef2.Tag = "4"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(242, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "Teléfono 2:"
        '
        'NuevoUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(456, 311)
        Me.Controls.Add(Me.TxtTelef2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtNSS)
        Me.Controls.Add(Me.LblNSS)
        Me.Controls.Add(Me.CbCliente)
        Me.Controls.Add(Me.CbPropietario)
        Me.Controls.Add(Me.CbEmpleado)
        Me.Controls.Add(Me.TxtApellidos)
        Me.Controls.Add(Me.ButnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.TxtNif)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.TxtDireccion)
        Me.Controls.Add(Me.TxtTelefono)
        Me.Controls.Add(Me.LblTelefono)
        Me.Controls.Add(Me.LblNif)
        Me.Controls.Add(Me.LblApellido)
        Me.Controls.Add(Me.LblNombre)
        Me.Controls.Add(Me.LblDireccion)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "NuevoUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nuevo Empleado/Cliente/Proveedor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtApellidos As System.Windows.Forms.TextBox
    Friend WithEvents ButnCancelar As System.Windows.Forms.Button
    Friend WithEvents BtnAceptar As System.Windows.Forms.Button
    Friend WithEvents TxtNif As System.Windows.Forms.TextBox
    Friend WithEvents TxtNombre As System.Windows.Forms.TextBox
    Friend WithEvents TxtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents TxtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents LblTelefono As System.Windows.Forms.Label
    Friend WithEvents LblNif As System.Windows.Forms.Label
    Friend WithEvents LblApellido As System.Windows.Forms.Label
    Friend WithEvents LblNombre As System.Windows.Forms.Label
    Friend WithEvents LblDireccion As System.Windows.Forms.Label
    Friend WithEvents CbEmpleado As System.Windows.Forms.CheckBox
    Friend WithEvents CbPropietario As System.Windows.Forms.CheckBox
    Friend WithEvents CbCliente As System.Windows.Forms.CheckBox
    Friend WithEvents LblNSS As System.Windows.Forms.Label
    Friend WithEvents TxtNSS As System.Windows.Forms.TextBox
    Friend WithEvents TxtTelef2 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
