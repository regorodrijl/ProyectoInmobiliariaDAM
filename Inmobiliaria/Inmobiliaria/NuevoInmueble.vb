Imports MySql.Data.MySqlClient
Public Class NuevoInmueble
    Dim DtsNInmueble As New DataSet
    Dim DtaNInmueble As MySqlDataAdapter
    Public conexion As MySqlConnection
    Dim id
    Private Sub NuevoInmueble_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        'cargar el combobox

        DtaNInmueble = New MySqlDataAdapter("select * from persona where propietario=true order by idPersona;", conexion)
        DtaNInmueble.Fill(DtsNInmueble, "persona")
        'para juntar las 2 tablas para mostrar nombre+ apellidos
        DtsNInmueble.Tables("persona").Columns.Add("NombreCompleto", GetType(String), "nombre+' '+apellidos")

        CmbPropietario.DataSource = DtsNInmueble.Tables("persona")
        CmbPropietario.DisplayMember = "NombreCompleto"
        CmbPropietario.ValueMember() = "nombre"
        CmbPropietario.SelectedValue.ToString()

        'Dim CbCliente As New MySqlCommandBuilder(DtaNInmueble)
        RbPiso.Checked = True

    End Sub
   
    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        If TxtProvincia.Text = "" Or TxtCP.Text = "" Or TxtDireccion.Text = "" Or TxtBPrecio.Text = "" Or TxtM2.Text = "" Then
            MsgBox("Faltan Datos.")
            Exit Sub
        End If


        ' MsgBox(CmbPropietario.ValueMember.ToString & " o " & CmbPropietario.SelectedValue.ToString())

        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
    Private Sub TxtTotal_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TxtBPrecio.KeyPress, TxtM2.KeyPress
        Dim validos As String = "1234567890.," + Chr(8)
        If Not validos.Contains(e.KeyChar) Then
            e.Handled = True
        End If
        If e.KeyChar = "." Then
            e.KeyChar = CChar(",")
        End If

    End Sub
    Private Sub TxtBanoHabi_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TxtBano.KeyPress, TxtHab.KeyPress, TxtCP.KeyPress
        Dim validos As String = "1234567890" + Chr(8)
        If Not validos.Contains(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub RadioButtoon_CheckedChanged(sender As Object, e As EventArgs) Handles RbPiso.CheckedChanged, RbBajo.CheckedChanged, RbCasa.CheckedChanged
        If RbCasa.Checked Or RbPiso.Checked Then
            LblHab.Visible = True
            TxtHab.Visible = True
            LblBano.Visible = True
            TxtBano.Visible = True
            CbGaraje.Visible = True

        Else
            LblBano.Visible = False
            TxtBano.Visible = False
            LblHab.Visible = False
            TxtHab.Visible = False
            CbGaraje.Visible = False

        End If

        If RbBajo.Checked Then
            CbAgua.Visible = True
            CbLuz.Visible = True
        Else
            CbAgua.Visible = False
            CbLuz.Visible = False

        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub
End Class