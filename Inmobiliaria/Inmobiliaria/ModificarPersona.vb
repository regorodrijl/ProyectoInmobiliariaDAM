Imports MySql.Data.MySqlClient
Public Class ModificarPersona
    Public Dts As New DataSet
    Public Dta As MySqlDataAdapter
    Public conexion As MySqlConnection

    Private Sub ModificarPersona_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
                                           "Database=" & txtBaseDatosName & ";")
            '  MsgBox(conexion.State)

            ' MsgBox(conexion.State)
        Catch ex As MySqlException
            MessageBox.Show("No se ha podido conectar al servidor")
        End Try
        'cargar el combobox Cliente

        Dta = New MySqlDataAdapter("select * from persona  order by idPersona;", conexion)
        Dta.Fill(Dts, "persona")
        DtgPersonas.DataSource = Dts.Tables("persona")
    End Sub
    Private Sub cambio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DtgPersonas.SelectionChanged
        Dim fila As Integer = Me.DtgPersonas.CurrentCell.RowIndex

        Me.TxtNif.Text = Me.DtgPersonas.Item(1, fila).Value
        Me.TxtNombre.Text = Me.DtgPersonas.Item(2, fila).Value
        Me.TxtApellidos.Text = Me.DtgPersonas.Item(3, fila).Value
        Me.TxtDireccion.Text = Me.DtgPersonas.Item(4, fila).Value
        Me.TxtTelefono.Text = Me.DtgPersonas.Item(5, fila).Value
        Me.TxtTelef2.Text = Convert.ToString(Me.DtgPersonas.Item(6, fila).Value)
       
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles ButnCancelar.Click
        Me.Close()
    End Sub
    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Dim filaUsuario = Dts.Tables("persona").NewRow
        Dim Cbpersona As New MySqlCommandBuilder(Dta)

        Dim posicion As Integer
        posicion = Me.BindingContext(Dts.Tables("persona")).Position

        filaUsuario.BeginEdit()

        filaUsuario("dni") = TxtNif.Text
        filaUsuario("nombre") = TxtNombre.Text
        filaUsuario("apellidos") = TxtApellidos.Text
        filaUsuario("direccion") = TxtDireccion.Text
        filaUsuario("telefono1") = TxtTelefono.Text
        filaUsuario("telefono2") = TxtTelef2.Text

        filaUsuario.EndEdit()

        Dta.Update(Dts, "persona")
        Dts.AcceptChanges()

        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
    
End Class