Imports MySql.Data.MySqlClient
Public Class NuevaVisita
    Dim Dts As New DataSet
    Dim Dta As MySqlDataAdapter
    Public conexion As MySqlConnection
    Dim id
    Private Sub NuevaVisita_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        Dta = New MySqlDataAdapter("select * from persona where cliente=true order by idPersona;", conexion)
        Dta.Fill(Dts, "cliente")
        'para juntar las 2 tablas para mostrar nombre+ apellidos
        Dts.Tables("cliente").Columns.Add("NombreCompleto", GetType(String), "nombre+' '+apellidos")

        CmbCliente.DataSource = Dts.Tables("cliente")
        CmbCliente.DisplayMember = "NombreCompleto"
        CmbCliente.ValueMember() = "nombre"
        CmbCliente.SelectedValue.ToString()
        'cargar el combobox Inmueble
        Dta = New MySqlDataAdapter("select * from inmueble order by idInmueble;", conexion)
        Dta.Fill(Dts, "inmueble")

        CmbInmueble.DataSource = Dts.Tables("inmueble")
        CmbInmueble.DisplayMember = "idInmueble"
        CmbInmueble.ValueMember() = "idInmueble"
        CmbInmueble.SelectedValue.ToString()

    End Sub
    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Close()
    End Sub
    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
End Class