Imports MySql.Data.MySqlClient
Public Class Ver
    Dim Dts As New DataSet
    Dim Dta As MySqlDataAdapter
    Public conexion As MySqlConnection
    Dim id
    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Close()
    End Sub
    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub Ver_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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


        
        Cliente(DtgPersonas)
        Inmueble(DtgInmuebles)
        Visitas(DtgVisitas)
    End Sub
    Private Sub Visitas(dtg As DataGridView)
        'Visita
        Dta = New MySqlDataAdapter("select * from visita order by idVisita;", conexion)
        Dta.Fill(Dts, "visita")
        dtg.DataSource = Dts.Tables("visita")

        dtg.Columns(0).Width = 30
        dtg.Columns(0).HeaderText = "ID"
        dtg.Columns(1).Width = 30
        dtg.Columns(1).HeaderText = "Inm"
        dtg.Columns(2).Width = 30
        dtg.Columns(2).HeaderText = "Emple"
        dtg.Columns(3).Width = 30
        dtg.Columns(3).HeaderText = "Cli"
        dtg.Columns(4).HeaderText = "Fecha Visita"
        ' dtg.Columns("Matricula").DefaultCellStyle.Font = New Font("Times New Roman", 12, FontStyle.Bold)




    End Sub
    Private Sub Inmueble(dtg As DataGridView)
        'Inmueble
        Dta = New MySqlDataAdapter("select * from inmueble order by idInmueble;", conexion)
        Dta.Fill(Dts, "inmueble")
        dtg.DataSource = Dts.Tables("inmueble")

        dtg.Columns(0).Width = 30
        dtg.Columns(0).HeaderText = "ID"
        dtg.Columns(1).Width = 30
        dtg.Columns(1).HeaderText = "Prop"
        dtg.Columns(2).Width = 100
        dtg.Columns(2).HeaderText = "Dirección"
        dtg.Columns(3).Width = 50
        dtg.Columns(3).HeaderText = "CP"
        dtg.Columns(4).Width = 100
        dtg.Columns(4).HeaderText = "Provincia"
        dtg.Columns(5).Width = 75
        dtg.Columns(5).HeaderText = "Precio"
        dtg.Columns(6).Width = 50
        dtg.Columns(6).HeaderText = "m2"
        dtg.Columns(7).Width = 75
        dtg.Columns(7).HeaderText = "Tipo"
        dtg.Columns(8).Width = 25
        dtg.Columns(8).HeaderText = "Habi"
        dtg.Columns(9).Width = 25
        dtg.Columns(9).HeaderText = "Baño"
        dtg.Columns(10).Width = 25
        dtg.Columns(10).HeaderText = "Gara"
        dtg.Columns(11).Width = 25
        dtg.Columns(11).HeaderText = "Agua"
        dtg.Columns(12).Width = 25
        dtg.Columns(12).HeaderText = "Lúz"

    End Sub

    Private Sub Cliente(dtg As DataGridView)
        'Cliente
        Dta = New MySqlDataAdapter("select * from persona where cliente=true order by idPersona;", conexion)
        Dta.Fill(Dts, "cliente")
        dtg.DataSource = Dts.Tables("cliente")


        dtg.Columns(0).Width = 30
        dtg.Columns(0).HeaderText = "ID"
        dtg.Columns(1).Width = 100
        dtg.Columns(1).HeaderText = "DNI"
        dtg.Columns(2).Width = 100
        dtg.Columns(2).HeaderText = "Nombre"
        dtg.Columns(3).Width = 100
        dtg.Columns(3).HeaderText = "Apellidos"
        dtg.Columns(4).Width = 100
        dtg.Columns(4).HeaderText = "Dirección"
        dtg.Columns(5).Width = 100
        dtg.Columns(5).HeaderText = "Teléfono"
    End Sub
End Class