Imports MySql.Data.MySqlClient
Public Class Gestion
    Public conexion As MySqlConnection
    Public DtaXestion As MySqlDataAdapter
    Dim Cb As MySqlCommandBuilder
    Public DtsXestion As New DataSet
    Dim emple As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim txtServer As String = "127.0.0.1"
        Dim txtUsuario As String = "joseluis"
        Dim txtContrasena As String = "Nahyr17.7"
        Dim txtPuerto As String = "3306"
        Dim txtBaseDatosName As String = "inmobiliaria1"

        Try

            conexion = New MySqlConnection("Server=" & txtServer & ";" & _
                                           "Uid=" & txtUsuario & ";" & _
                                           "Pwd=" & txtContrasena & ";" & _
                                           "Port=" & txtPuerto & ";" & _
                                           "Database=" & txtBaseDatosName & ";Convert Zero Datetime=True;")
            '  MsgBox(conexion.State)

            ' MsgBox(conexion.State)
        Catch ex As MySqlException
            MessageBox.Show("No se ha podido conectar al servidor")
        End Try

        emple = Login.emple
        'datagridView
        DtaXestion = New MySqlDataAdapter("select * from visita order by idVisita;", conexion)
        DtaXestion.Fill(DtsXestion, "visita")
        DtgVisitas.DataSource = DtsXestion.Tables("visita")

        DtgVisitas.Columns(0).Width = 30
        DtgVisitas.Columns(0).HeaderText = "ID"
        DtgVisitas.Columns(1).Width = 70
        DtgVisitas.Columns(1).HeaderText = "Inmueble"
        DtgVisitas.Columns(2).Width = 70
        DtgVisitas.Columns(2).HeaderText = "Empleado"
        DtgVisitas.Columns(3).Width = 70
        DtgVisitas.Columns(3).HeaderText = "Cliente"
        DtgVisitas.Columns(4).HeaderText = "Fecha Visita"



    End Sub
    'Dim inserta
    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click, TsSalir.Click
        Me.Close()
    End Sub

    Private Sub NuevoUsuario_Click(sender As Object, e As EventArgs) Handles TsNuevoUsuario.Click
        Dim FrmNUsuario = New NuevoUsuario

        If FrmNUsuario.ShowDialog = DialogResult.Cancel Then
            Exit Sub
        End If

        DtaXestion = New MySqlDataAdapter("select * from persona order by idPersona;", conexion)
        'DtsXestion.Tables("persona").Clear()
        DtaXestion.Fill(DtsXestion, "persona")
        Dim CbCliente As New MySqlCommandBuilder(DtaXestion)

        Dim filaUsuario = DtsXestion.Tables("persona").NewRow
        'recogemos los datos para hacer la insercion
        With FrmNUsuario
            filaUsuario("dni") = .TxtNif.Text
            filaUsuario("nombre") = .TxtNombre.Text
            filaUsuario("apellidos") = .TxtApellidos.Text
            filaUsuario("direccion") = .TxtDireccion.Text
            filaUsuario("telefono1") = .TxtTelefono.Text
            filaUsuario("telefono2") = .TxtTelef2.Text
            filaUsuario("propietario") = .CbPropietario.CheckState
            filaUsuario("cliente") = .CbCliente.CheckState
            filaUsuario("empleado") = .CbEmpleado.CheckState
            filaUsuario("numeroSS") = .TxtNSS.Text
        End With
        DtsXestion.Tables("persona").Rows.Add(filaUsuario)

        DtaXestion.Update(DtsXestion, "persona")
        DtsXestion.AcceptChanges()
        ''''''
        'Hay q añadir cmbPropietario en inmueble pa asignar propietario a ese inmuble.
        ''''''''
        If FrmNUsuario.CbEmpleado.Checked = True Then
            'antes de abrir conexión nos aseguramos que no exista conexión establecida previa 
            If Not conexion Is Nothing Then conexion.Close()
            'abrimos conexión 
            conexion.Open()
            ' consulta
            Dim Comando As New MySqlCommand("select idPersona from persona where dni like '" & FrmNUsuario.TxtNif.Text & "';", conexion)
            ' obtenermos el resultado de la consulta anteriror
            Dim idper As Integer = Comando.ExecuteScalar()
            ' MsgBox("El id persona es." & idper.ToString & FrmNUsuario.usuario.ToString() & FrmNUsuario.clave.ToString())

            DtaXestion = New MySqlDataAdapter("select * from login;", conexion)
            DtaXestion.Fill(DtsXestion, "login")
            DtsXestion.Tables("login").Clear()

            Dim CbLogin As New MySqlCommandBuilder(DtaXestion)

            Dim filaLogin = DtsXestion.Tables("login").NewRow

            filaLogin("idPersonaEmplado") = idper.ToString
            filaLogin("usuario") = FrmNUsuario.usuario.ToString()
            filaLogin("clave") = FrmNUsuario.clave.ToString()
            'añadimos la fila al daraset
            DtsXestion.Tables("login").Rows.Add(filaLogin)
            'lo actualizamos y acetamos cambios para realizar modificacion en bd.
            DtaXestion.Update(DtsXestion, "login")
            DtsXestion.AcceptChanges()
        End If
    End Sub

    Private Sub NuevoInmueble_Click(sender As Object, e As EventArgs) Handles TsNuevoInmueble.Click
        'DtaXestion = New MySqlDataAdapter("select * from persona order by idPersona;", conexion)
        'DtaXestion.Fill(DtsXestion, "persona")
        Dim FrmNInmueble = New NuevoInmueble

        If FrmNInmueble.ShowDialog = DialogResult.Cancel Then
            Exit Sub
        End If

        DtaXestion = New MySqlDataAdapter("select * from inmueble;", conexion)
        'DtsXestion.Tables("persona").Clear()
        DtaXestion.Fill(DtsXestion, "inmueble")
        Dim Cbinmueble As New MySqlCommandBuilder(DtaXestion)
        'antes de abrir conexión nos aseguramos que no exista conexión establecida previa 
        If Not conexion Is Nothing Then conexion.Close()
        'abrimos conexión 
        conexion.Open()
        ' MsgBox(FrmNInmueble.CmbPropietario.SelectedValue.ToString())
        Dim Comando As New MySqlCommand("select idPersona from persona where nombre like '" & FrmNInmueble.CmbPropietario.SelectedValue.ToString() & "';", conexion)

        Dim IDnombre = Comando.ExecuteScalar()
        'MsgBox(IDnombre.ToString)
        Dim filaInmueble = DtsXestion.Tables("inmueble").NewRow
        'recogemos los datos para hacer la insercion
        With FrmNInmueble
            filaInmueble("direccion") = .TxtDireccion.Text
            filaInmueble("cp") = .TxtCP.Text
            filaInmueble("provincia") = .TxtProvincia.Text
            filaInmueble("precio") = CDbl(.TxtBPrecio.Text)

            filaInmueble("m2") = CInt(.TxtM2.Text)
            filaInmueble("idPersonaPropietario") = CInt(IDnombre)
            If .RbCasa.Checked Then
                filaInmueble("tipo") = "casa"
                filaInmueble("n_habitaciones") = .TxtHab.Text
                filaInmueble("n_banos") = .TxtBano.Text
                filaInmueble("garaje") = .CbGaraje.CheckState
            End If
            If .RbPiso.Checked Then
                filaInmueble("tipo") = "piso"
                filaInmueble("n_habitaciones") = .TxtHab.Text
                filaInmueble("n_banos") = .TxtBano.Text
                filaInmueble("garaje") = .CbGaraje.CheckState
            End If
            If .RbTerreno.Checked Then
                filaInmueble("tipo") = "terreno"
            End If
            If .RbOtro.Checked Then
                filaInmueble("tipo") = "otro"
            End If
            If .RbGaraje.Checked Then
                filaInmueble("tipo") = "garaje"
            End If
            If .RbBajo.Checked Then
                filaInmueble("tipo") = "bajo"
                filaInmueble("agua") = .CbAgua.CheckState
                filaInmueble("luz") = .CbLuz.CheckState
            End If
        End With
        DtsXestion.Tables("inmueble").Rows.Add(filaInmueble)
        DtaXestion.Update(DtsXestion, "inmueble")
        DtsXestion.AcceptChanges()



    End Sub
    Private Sub TsNuevoVisita_Click(sender As Object, e As EventArgs) Handles TsNuevoVisita.Click, BtnVisita.Click
        Dim FrmVisita = New NuevaVisita

        If FrmVisita.ShowDialog = DialogResult.Cancel Then
            Exit Sub
        End If
        DtaXestion = New MySqlDataAdapter("select * from visita;", conexion)
        'DtsXestion.Tables("persona").Clear()
        DtaXestion.Fill(DtsXestion, "visita")
        Dim Cbvisita As New MySqlCommandBuilder(DtaXestion)
        'para trear los datos necesarios.
        If Not conexion Is Nothing Then conexion.Close()
        'abrimos conexión 
        conexion.Open()
        Dim Comando As New MySqlCommand("select idPersona from persona where nombre like '" & FrmVisita.CmbCliente.SelectedValue.ToString() & "';", conexion)
        Dim IDCliente = Comando.ExecuteScalar() ' tenemos id persona

        FrmVisita.CmbInmueble.SelectedValue.ToString() ' tenemos id imueble

        Dim ComandoSql As New MySqlCommand("select idPersonaEmplado from login where usuario like '" & emple.ToString & "';", conexion)
        Dim IDempleado = ComandoSql.ExecuteScalar() 'tenemos id Empleado

        '  MsgBox(IDnombre & " " & FrmVisita.CmbInmueble.SelectedValue.ToString() & emple.ToString)
        Dim filaVisita = DtsXestion.Tables("visita").NewRow
        'recogemos los datos para hacer la insercion
        With FrmVisita
            filaVisita("idInmueble") = .CmbInmueble.SelectedValue.ToString()
            filaVisita("idPersonaEmpleado") = IDempleado
            filaVisita("idPersonaCliente") = IDCliente
            filaVisita("fecha_hora") = .DtpFecha.Value.ToShortDateString & " " & .DtpHora.Value.ToShortTimeString

        End With
        DtsXestion.Tables("visita").Rows.Add(filaVisita)
        DtaXestion.Update(DtsXestion, "visita")
        DtsXestion.AcceptChanges()

    End Sub

    Private Sub Ver_Click(sender As Object, e As EventArgs) Handles BtnVer.Click
        Dim FrmVer = New Ver
        If FrmVer.ShowDialog = DialogResult.Cancel Then
            Exit Sub
        End If
    End Sub


    Private Sub BtnAlquila_Click(sender As Object, e As EventArgs) Handles BtnAlquila.Click
        Dim FrmAlquila = New AlquilaCompra

        If FrmAlquila.ShowDialog = DialogResult.Cancel Then
            Exit Sub
        End If
        DtaXestion = New MySqlDataAdapter("select * from alquilacompra;", conexion)
        'DtsXestion.Tables("persona").Clear()
        DtaXestion.Fill(DtsXestion, "alquilacompra")
        Dim CbAlquila As New MySqlCommandBuilder(DtaXestion)
        'para trear los datos necesarios.
        If Not conexion Is Nothing Then conexion.Close()
        'abrimos conexión 
        conexion.Open()
        Dim Comando As New MySqlCommand("select idPersona from persona where nombre like '" & FrmAlquila.CmbCliente.SelectedValue.ToString() & "';", conexion)
        Dim IDCliente = Comando.ExecuteScalar() ' tenemos id persona

        FrmAlquila.CmbInmueble.SelectedValue.ToString() ' tenemos id imueble

        Dim ComandoSql As New MySqlCommand("select idPersonaEmplado from login where usuario like '" & emple.ToString & "';", conexion)
        Dim IDempleado = ComandoSql.ExecuteScalar() 'tenemos id Empleado

        '  MsgBox(IDnombre & " " & FrmVisita.CmbInmueble.SelectedValue.ToString() & emple.ToString)
        Dim filaAlquila = DtsXestion.Tables("alquilacompra").NewRow
        'recogemos los datos para hacer la insercion
        With FrmAlquila
            filaAlquila("idInmueble") = .CmbInmueble.SelectedValue.ToString()
            filaAlquila("idPersonaEmpleado") = IDempleado
            filaAlquila("idPersonaCliente") = IDCliente
            filaAlquila("fechaInicio") = .DtpFecha.Value ' .ToShortDateString

        End With
        DtsXestion.Tables("alquilacompra").Rows.Add(filaAlquila)
        DtaXestion.Update(DtsXestion, "alquilacompra")
        DtsXestion.AcceptChanges()

    End Sub

    Private Sub TsModificarVisita_Click(sender As Object, e As EventArgs) Handles TsModificarVisita.Click
        Dim FrmModVisita = New ModificarVisita
        If FrmModVisita.ShowDialog = DialogResult.Cancel Then
            Exit Sub
        End If
        Dim filaVisita = DtsXestion.Tables("visita").NewRow
        Dim Cbvisita As New MySqlCommandBuilder(DtaXestion)

        Dim posicion As Integer
        posicion = Me.BindingContext(DtsXestion.Tables("visita")).Position
        filaVisita = DtsXestion.Tables("visita").Rows(posicion)
        filaVisita.BeginEdit()
        filaVisita("fecha_hora") = FrmModVisita.DtpFecha.Value.ToShortDateString & " " & FrmModVisita.DtpHora.Value.ToShortTimeString
        filaVisita.EndEdit()
        DtaXestion.Update(DtsXestion, "visita")
        DtsXestion.AcceptChanges()
    End Sub
    Private Sub TsBuscar_Click(sender As Object, e As EventArgs) Handles TsBuscar.Click
        Dim FrmBuscar = New Buscar
        If FrmBuscar.ShowDialog = DialogResult.Cancel Then
            Exit Sub
        End If
    End Sub
    Private Sub TsModificarCEP_Click(sender As Object, e As EventArgs) Handles TsModificarCEP.Click
        Dim FrmModPersona = New ModificarPersona
        If FrmModPersona.ShowDialog = DialogResult.Cancel Then
            Exit Sub
        End If
        'Dim dta = ModificarPersona.Dta
        'Dim dts = ModificarPersona.Dts
        'If Not conexion Is Nothing Then conexion.Close()
        ''abrimos conexión 
        'conexion.Open()
        'Dim filaUsuario = dts.Tables("persona").NewRow
        'Dim Cbpersona As New MySqlCommandBuilder(dta)

        'Dim posicion As Integer
        'posicion = Me.BindingContext(dts.Tables("persona")).Position

        'filaUsuario.BeginEdit()
        'With FrmModPersona
        '    filaUsuario("dni") = .TxtNif.Text
        '    filaUsuario("nombre") = .TxtNombre.Text
        '    filaUsuario("apellidos") = .TxtApellidos.Text
        '    filaUsuario("direccion") = .TxtDireccion.Text
        '    filaUsuario("telefono1") = .TxtTelefono.Text
        '    filaUsuario("telefono2") = .TxtTelef2.Text
        'End With
        'filaUsuario.EndEdit()

        'dta.Update(dts, "persona")
        'dts.AcceptChanges()

    End Sub
End Class