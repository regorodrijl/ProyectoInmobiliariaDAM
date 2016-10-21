<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NuevoInmueble
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NuevoInmueble))
        Me.TxtCP = New System.Windows.Forms.TextBox()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.TxtProvincia = New System.Windows.Forms.TextBox()
        Me.TxtDireccion = New System.Windows.Forms.TextBox()
        Me.LblMunicipio = New System.Windows.Forms.Label()
        Me.LblProvincia = New System.Windows.Forms.Label()
        Me.LblDireccion = New System.Windows.Forms.Label()
        Me.LblPrecio = New System.Windows.Forms.Label()
        Me.TxtBPrecio = New System.Windows.Forms.TextBox()
        Me.GBRadioB = New System.Windows.Forms.GroupBox()
        Me.RbOtro = New System.Windows.Forms.RadioButton()
        Me.RbBajo = New System.Windows.Forms.RadioButton()
        Me.RbGaraje = New System.Windows.Forms.RadioButton()
        Me.RbPiso = New System.Windows.Forms.RadioButton()
        Me.RbCasa = New System.Windows.Forms.RadioButton()
        Me.RbTerreno = New System.Windows.Forms.RadioButton()
        Me.LblHab = New System.Windows.Forms.Label()
        Me.TxtHab = New System.Windows.Forms.TextBox()
        Me.TxtBano = New System.Windows.Forms.TextBox()
        Me.LblBano = New System.Windows.Forms.Label()
        Me.CbLuz = New System.Windows.Forms.CheckBox()
        Me.CbAgua = New System.Windows.Forms.CheckBox()
        Me.TxtM2 = New System.Windows.Forms.TextBox()
        Me.LblM2 = New System.Windows.Forms.Label()
        Me.CmbPropietario = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CbGaraje = New System.Windows.Forms.CheckBox()
        Me.GBRadioB.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtCP
        '
        Me.TxtCP.Location = New System.Drawing.Point(139, 108)
        Me.TxtCP.MaxLength = 50
        Me.TxtCP.Name = "TxtCP"
        Me.TxtCP.Size = New System.Drawing.Size(132, 20)
        Me.TxtCP.TabIndex = 3
        Me.TxtCP.Tag = "2"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(423, 296)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancelar.TabIndex = 9
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(12, 292)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAceptar.TabIndex = 8
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'TxtProvincia
        '
        Me.TxtProvincia.Location = New System.Drawing.Point(139, 31)
        Me.TxtProvincia.MaxLength = 50
        Me.TxtProvincia.Name = "TxtProvincia"
        Me.TxtProvincia.Size = New System.Drawing.Size(132, 20)
        Me.TxtProvincia.TabIndex = 1
        Me.TxtProvincia.Tag = "1"
        '
        'TxtDireccion
        '
        Me.TxtDireccion.Location = New System.Drawing.Point(139, 69)
        Me.TxtDireccion.MaxLength = 150
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(132, 20)
        Me.TxtDireccion.TabIndex = 2
        Me.TxtDireccion.Tag = "3"
        '
        'LblMunicipio
        '
        Me.LblMunicipio.AutoSize = True
        Me.LblMunicipio.Location = New System.Drawing.Point(12, 111)
        Me.LblMunicipio.Name = "LblMunicipio"
        Me.LblMunicipio.Size = New System.Drawing.Size(24, 13)
        Me.LblMunicipio.TabIndex = 61
        Me.LblMunicipio.Text = "CP:"
        '
        'LblProvincia
        '
        Me.LblProvincia.AutoSize = True
        Me.LblProvincia.Location = New System.Drawing.Point(12, 34)
        Me.LblProvincia.Name = "LblProvincia"
        Me.LblProvincia.Size = New System.Drawing.Size(54, 13)
        Me.LblProvincia.TabIndex = 60
        Me.LblProvincia.Text = "Provincia:"
        '
        'LblDireccion
        '
        Me.LblDireccion.AutoSize = True
        Me.LblDireccion.Location = New System.Drawing.Point(12, 72)
        Me.LblDireccion.Name = "LblDireccion"
        Me.LblDireccion.Size = New System.Drawing.Size(55, 13)
        Me.LblDireccion.TabIndex = 59
        Me.LblDireccion.Text = "Dirección:"
        '
        'LblPrecio
        '
        Me.LblPrecio.AutoSize = True
        Me.LblPrecio.Location = New System.Drawing.Point(12, 146)
        Me.LblPrecio.Name = "LblPrecio"
        Me.LblPrecio.Size = New System.Drawing.Size(40, 13)
        Me.LblPrecio.TabIndex = 69
        Me.LblPrecio.Text = "Precio:"
        '
        'TxtBPrecio
        '
        Me.TxtBPrecio.Location = New System.Drawing.Point(139, 143)
        Me.TxtBPrecio.MaxLength = 150
        Me.TxtBPrecio.Name = "TxtBPrecio"
        Me.TxtBPrecio.Size = New System.Drawing.Size(132, 20)
        Me.TxtBPrecio.TabIndex = 4
        Me.TxtBPrecio.Tag = "4"
        '
        'GBRadioB
        '
        Me.GBRadioB.Controls.Add(Me.RbOtro)
        Me.GBRadioB.Controls.Add(Me.RbBajo)
        Me.GBRadioB.Controls.Add(Me.RbGaraje)
        Me.GBRadioB.Controls.Add(Me.RbPiso)
        Me.GBRadioB.Controls.Add(Me.RbCasa)
        Me.GBRadioB.Controls.Add(Me.RbTerreno)
        Me.GBRadioB.Location = New System.Drawing.Point(311, 28)
        Me.GBRadioB.Name = "GBRadioB"
        Me.GBRadioB.Size = New System.Drawing.Size(200, 100)
        Me.GBRadioB.TabIndex = 71
        Me.GBRadioB.TabStop = False
        Me.GBRadioB.Text = "Selecione Una Opción:"
        '
        'RbOtro
        '
        Me.RbOtro.AutoSize = True
        Me.RbOtro.Location = New System.Drawing.Point(112, 65)
        Me.RbOtro.Name = "RbOtro"
        Me.RbOtro.Size = New System.Drawing.Size(45, 17)
        Me.RbOtro.TabIndex = 77
        Me.RbOtro.TabStop = True
        Me.RbOtro.Text = "Otro"
        Me.RbOtro.UseVisualStyleBackColor = True
        '
        'RbBajo
        '
        Me.RbBajo.AutoSize = True
        Me.RbBajo.Location = New System.Drawing.Point(6, 65)
        Me.RbBajo.Name = "RbBajo"
        Me.RbBajo.Size = New System.Drawing.Size(46, 17)
        Me.RbBajo.TabIndex = 76
        Me.RbBajo.TabStop = True
        Me.RbBajo.Text = "Bajo"
        Me.RbBajo.UseVisualStyleBackColor = True
        '
        'RbGaraje
        '
        Me.RbGaraje.AutoSize = True
        Me.RbGaraje.Location = New System.Drawing.Point(112, 42)
        Me.RbGaraje.Name = "RbGaraje"
        Me.RbGaraje.Size = New System.Drawing.Size(56, 17)
        Me.RbGaraje.TabIndex = 75
        Me.RbGaraje.TabStop = True
        Me.RbGaraje.Text = "Garaje"
        Me.RbGaraje.UseVisualStyleBackColor = True
        '
        'RbPiso
        '
        Me.RbPiso.AutoSize = True
        Me.RbPiso.Location = New System.Drawing.Point(6, 21)
        Me.RbPiso.Name = "RbPiso"
        Me.RbPiso.Size = New System.Drawing.Size(45, 17)
        Me.RbPiso.TabIndex = 6
        Me.RbPiso.TabStop = True
        Me.RbPiso.Text = "Piso"
        Me.RbPiso.UseVisualStyleBackColor = True
        '
        'RbCasa
        '
        Me.RbCasa.AutoSize = True
        Me.RbCasa.Location = New System.Drawing.Point(112, 21)
        Me.RbCasa.Name = "RbCasa"
        Me.RbCasa.Size = New System.Drawing.Size(49, 17)
        Me.RbCasa.TabIndex = 73
        Me.RbCasa.TabStop = True
        Me.RbCasa.Text = "Casa"
        Me.RbCasa.UseVisualStyleBackColor = True
        '
        'RbTerreno
        '
        Me.RbTerreno.AutoSize = True
        Me.RbTerreno.Location = New System.Drawing.Point(6, 44)
        Me.RbTerreno.Name = "RbTerreno"
        Me.RbTerreno.Size = New System.Drawing.Size(62, 17)
        Me.RbTerreno.TabIndex = 72
        Me.RbTerreno.TabStop = True
        Me.RbTerreno.Text = "Terreno"
        Me.RbTerreno.UseVisualStyleBackColor = True
        '
        'LblHab
        '
        Me.LblHab.AutoSize = True
        Me.LblHab.Location = New System.Drawing.Point(12, 224)
        Me.LblHab.Name = "LblHab"
        Me.LblHab.Size = New System.Drawing.Size(87, 13)
        Me.LblHab.TabIndex = 72
        Me.LblHab.Text = "Nº Habitaciones:"
        Me.LblHab.Visible = False
        '
        'TxtHab
        '
        Me.TxtHab.Location = New System.Drawing.Point(139, 217)
        Me.TxtHab.Name = "TxtHab"
        Me.TxtHab.Size = New System.Drawing.Size(132, 20)
        Me.TxtHab.TabIndex = 73
        Me.TxtHab.Visible = False
        '
        'TxtBano
        '
        Me.TxtBano.Location = New System.Drawing.Point(139, 254)
        Me.TxtBano.Name = "TxtBano"
        Me.TxtBano.Size = New System.Drawing.Size(132, 20)
        Me.TxtBano.TabIndex = 75
        Me.TxtBano.Visible = False
        '
        'LblBano
        '
        Me.LblBano.AutoSize = True
        Me.LblBano.Location = New System.Drawing.Point(12, 261)
        Me.LblBano.Name = "LblBano"
        Me.LblBano.Size = New System.Drawing.Size(55, 13)
        Me.LblBano.TabIndex = 74
        Me.LblBano.Text = "Nº Baños:"
        Me.LblBano.Visible = False
        '
        'CbLuz
        '
        Me.CbLuz.AutoSize = True
        Me.CbLuz.Location = New System.Drawing.Point(311, 236)
        Me.CbLuz.Name = "CbLuz"
        Me.CbLuz.Size = New System.Drawing.Size(43, 17)
        Me.CbLuz.TabIndex = 77
        Me.CbLuz.Text = "Lúz"
        Me.CbLuz.UseVisualStyleBackColor = True
        Me.CbLuz.Visible = False
        '
        'CbAgua
        '
        Me.CbAgua.AutoSize = True
        Me.CbAgua.Location = New System.Drawing.Point(311, 256)
        Me.CbAgua.Name = "CbAgua"
        Me.CbAgua.Size = New System.Drawing.Size(51, 17)
        Me.CbAgua.TabIndex = 78
        Me.CbAgua.Text = "Agua"
        Me.CbAgua.UseVisualStyleBackColor = True
        Me.CbAgua.Visible = False
        '
        'TxtM2
        '
        Me.TxtM2.Location = New System.Drawing.Point(139, 177)
        Me.TxtM2.Name = "TxtM2"
        Me.TxtM2.Size = New System.Drawing.Size(132, 20)
        Me.TxtM2.TabIndex = 5
        Me.TxtM2.Tag = "5"
        '
        'LblM2
        '
        Me.LblM2.AutoSize = True
        Me.LblM2.Location = New System.Drawing.Point(12, 184)
        Me.LblM2.Name = "LblM2"
        Me.LblM2.Size = New System.Drawing.Size(96, 13)
        Me.LblM2.TabIndex = 79
        Me.LblM2.Text = "Metros Cuadrados:"
        '
        'CmbPropietario
        '
        Me.CmbPropietario.FormattingEnabled = True
        Me.CmbPropietario.Location = New System.Drawing.Point(390, 148)
        Me.CmbPropietario.Name = "CmbPropietario"
        Me.CmbPropietario.Size = New System.Drawing.Size(121, 21)
        Me.CmbPropietario.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(311, 155)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 82
        Me.Label1.Text = "Propietario:"
        '
        'CbGaraje
        '
        Me.CbGaraje.AutoSize = True
        Me.CbGaraje.Location = New System.Drawing.Point(311, 213)
        Me.CbGaraje.Name = "CbGaraje"
        Me.CbGaraje.Size = New System.Drawing.Size(57, 17)
        Me.CbGaraje.TabIndex = 83
        Me.CbGaraje.Text = "Garaje"
        Me.CbGaraje.UseVisualStyleBackColor = True
        Me.CbGaraje.Visible = False
        '
        'NuevoInmueble
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(521, 343)
        Me.Controls.Add(Me.CbGaraje)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CmbPropietario)
        Me.Controls.Add(Me.TxtM2)
        Me.Controls.Add(Me.LblM2)
        Me.Controls.Add(Me.CbAgua)
        Me.Controls.Add(Me.CbLuz)
        Me.Controls.Add(Me.TxtBano)
        Me.Controls.Add(Me.LblBano)
        Me.Controls.Add(Me.TxtHab)
        Me.Controls.Add(Me.LblHab)
        Me.Controls.Add(Me.GBRadioB)
        Me.Controls.Add(Me.TxtBPrecio)
        Me.Controls.Add(Me.LblPrecio)
        Me.Controls.Add(Me.TxtCP)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.TxtProvincia)
        Me.Controls.Add(Me.TxtDireccion)
        Me.Controls.Add(Me.LblMunicipio)
        Me.Controls.Add(Me.LblProvincia)
        Me.Controls.Add(Me.LblDireccion)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "NuevoInmueble"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nuevo Inmueble"
        Me.GBRadioB.ResumeLayout(False)
        Me.GBRadioB.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtCP As System.Windows.Forms.TextBox
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents BtnAceptar As System.Windows.Forms.Button
    Friend WithEvents TxtProvincia As System.Windows.Forms.TextBox
    Friend WithEvents TxtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents LblMunicipio As System.Windows.Forms.Label
    Friend WithEvents LblProvincia As System.Windows.Forms.Label
    Friend WithEvents LblDireccion As System.Windows.Forms.Label
    Friend WithEvents LblPrecio As System.Windows.Forms.Label
    Friend WithEvents TxtBPrecio As System.Windows.Forms.TextBox
    Friend WithEvents GBRadioB As System.Windows.Forms.GroupBox
    Friend WithEvents RbOtro As System.Windows.Forms.RadioButton
    Friend WithEvents RbBajo As System.Windows.Forms.RadioButton
    Friend WithEvents RbGaraje As System.Windows.Forms.RadioButton
    Friend WithEvents RbPiso As System.Windows.Forms.RadioButton
    Friend WithEvents RbCasa As System.Windows.Forms.RadioButton
    Friend WithEvents RbTerreno As System.Windows.Forms.RadioButton
    Friend WithEvents LblHab As System.Windows.Forms.Label
    Friend WithEvents TxtHab As System.Windows.Forms.TextBox
    Friend WithEvents TxtBano As System.Windows.Forms.TextBox
    Friend WithEvents LblBano As System.Windows.Forms.Label
    Friend WithEvents CbLuz As System.Windows.Forms.CheckBox
    Friend WithEvents CbAgua As System.Windows.Forms.CheckBox
    Friend WithEvents TxtM2 As System.Windows.Forms.TextBox
    Friend WithEvents LblM2 As System.Windows.Forms.Label
    Friend WithEvents CmbPropietario As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CbGaraje As System.Windows.Forms.CheckBox
End Class
