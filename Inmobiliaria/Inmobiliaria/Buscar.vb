Imports MySql.Data.MySqlClient
Public Class Buscar
    Public conexion As MySqlConnection
    Public DtaXestion As MySqlDataAdapter
    Dim Cb As MySqlCommandBuilder
    Public DtsXestion As New DataSet


    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Close()
    End Sub
    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub Buscar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        CmbBuscar.Items.Add("Propietario")
        CmbBuscar.Items.Add("Inmueble")
        CmbBuscar.Items.Add("Cliente")
        CmbBuscar.SelectedIndex = 0
    End Sub

    Private Sub CmbBuscar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbBuscar.SelectedIndexChanged
       
        If CmbBuscar.SelectedItem.ToString() = "Propietario" Then
            DtsXestion.Clear()
            Dtg.DataSource = Nothing
            DtaXestion = New MySqlDataAdapter("select * from persona where propietario = true order by idPersona;", conexion)
            DtaXestion.Fill(DtsXestion, "consulta1")
            Dtg.DataSource = DtsXestion.Tables("consulta1")

        End If
        If CmbBuscar.SelectedItem.ToString() = "Inmueble" Then
            DtsXestion.Clear()
            Dtg.DataSource = Nothing
            DtaXestion = New MySqlDataAdapter("select * from inmueble order by idInmueble;", conexion)
            DtaXestion.Fill(DtsXestion, "consulta")
            Dtg.DataSource = DtsXestion.Tables("consulta")
        End If
        If CmbBuscar.SelectedItem.ToString() = "Cliente" Then
            DtsXestion.Clear()
            Dtg.DataSource = Nothing
            DtaXestion = New MySqlDataAdapter("select * from persona where cliente=true order by idPersona;", conexion)
            DtaXestion.Fill(DtsXestion, "consulta2")
            Dtg.DataSource = DtsXestion.Tables("consulta2")
        End If
    End Sub

End Class