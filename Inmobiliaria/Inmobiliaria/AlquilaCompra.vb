Imports MySql.Data.MySqlClient
'Libreria agregada a traves de refecencias y en ficha COM agregar objeto word.
Imports Microsoft.Office.Interop.Word 'control de office
Imports System.IO 'sistema de archivos
Imports Microsoft.Office.Interop
Public Class AlquilaCompra
    Dim Dts As New DataSet
    Dim Dta As MySqlDataAdapter
    Public conexion As MySqlConnection
    Private Sub Alquila_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
                                           "Database=" & txtBaseDatosName & ";Convert Zero Datetime=True")
            '  MsgBox(conexion.State)

            ' MsgBox(conexion.State)
        Catch ex As MySqlException
            MessageBox.Show("No se ha podido conectar al servidor")
        End Try

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
        'cerramos si pincha en cancelar
        Me.Close()
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        MsgBox("Se generará el Contrato.")
        Dim MSWord As New Word.Application
        Dim Documento As Word.Document

        
        Dim fecha = DtpFecha.Value.ToString("yyyy-MM-dd-HH-mm-ss")
        'fecha = Format(CDate(fecha), "yyyy-MM-dd")

        
        MsgBox("El Contrato se guardará en : C:\Users\Jose Luis\Desktop\Proyecto\DocContrato\documento" & fecha & ".docx")
        'FileCopy(origen, destino)
        FileCopy("C:\Users\Jose Luis\Desktop\Proyecto\Doc\Contrato-de-arrendamiento-de-vivienda.docx", "C:\Users\Jose Luis\Desktop\Proyecto\DocContrato\documento" & fecha & ".docx")
        Documento = MSWord.Documents.Open("C:\Users\Jose Luis\Desktop\Proyecto\DocContrato\documento" & fecha & ".docx")
        ''''''''''''''''''''''''''''''''''''''''''''''
        'CONSULTAS
        '''''''''''''''''''''''''''''''''''''''''''''''
        If Not conexion Is Nothing Then conexion.Close()
        'abrimos conexión 
        conexion.Open()
        ' MsgBox(FrmNInmueble.CmbPropietario.SelectedValue.ToString())
        'propi
        Dim NombreProp As New MySqlCommand("SELECT p.nombre FROM inmueble i,persona p WHERE i.idPersonaPropietario like p.idPersona and i.idInmueble like '" & CmbInmueble.SelectedValue.ToString() & "';", conexion)
        Dim nomProp = NombreProp.ExecuteScalar()
        Dim DNIProp As New MySqlCommand("SELECT p.dni FROM inmueble i,persona p WHERE i.idPersonaPropietario like p.idPersona and i.idInmueble like '" & CmbInmueble.SelectedValue.ToString() & "';", conexion)
        Dim dniPro = DNIProp.ExecuteScalar()
        Dim DireProp As New MySqlCommand("SELECT p.direccion FROM inmueble i,persona p WHERE i.idPersonaPropietario like p.idPersona and i.idInmueble like '" & CmbInmueble.SelectedValue.ToString() & "';", conexion)
        Dim direPro = DireProp.ExecuteScalar()

        'inquilino
        Dim nomInq = CmbCliente.SelectedValue.ToString()
        Dim DniInq As New MySqlCommand("SELECT dni from persona where cliente=true and nombre like '" & CmbCliente.SelectedValue.ToString() & "';", conexion)
        Dim dniIn = DniInq.ExecuteScalar()
        Dim DireInq As New MySqlCommand("SELECT direccion from persona where cliente=true and nombre like '" & CmbCliente.SelectedValue.ToString() & "';", conexion)
        Dim direIn = DireInq.ExecuteScalar()

        'inmueble
        Dim DireciInmueb As New MySqlCommand("SELECT direccion from inmueble where idInmueble like '" & CmbInmueble.SelectedValue.ToString() & "';", conexion)
        Dim direInmu = DireciInmueb.ExecuteScalar()
        Dim PrecioInmueb As New MySqlCommand("SELECT precio from inmueble where idInmueble like '" & CmbInmueble.SelectedValue.ToString() & "';", conexion)
        Dim precioInmu = PrecioInmueb.ExecuteScalar()
        

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'DOCUMENTO
        Documento.Bookmarks.Item("direccionInmueble").Range.Text = direInmu.ToString
        Documento.Bookmarks.Item("DireccionInquilino").Range.Text = direIn.ToString
        Documento.Bookmarks.Item("DireccionPropietario").Range.Text = direPro.ToString

        Documento.Bookmarks.Item("DniInquilino").Range.Text = dniIn.ToString
        Documento.Bookmarks.Item("DniPropietario").Range.Text = dniPro.ToString

        Documento.Bookmarks.Item("FirmaDNIInqui").Range.Text = dniIn.ToString
        Documento.Bookmarks.Item("FirmaDNIProp").Range.Text = dniPro.ToString
        Documento.Bookmarks.Item("FirmaNomInqui").Range.Text = nomInq.ToString
        Documento.Bookmarks.Item("FirmaNomProp").Range.Text = nomProp.ToString

        'Documento.Bookmarks.Item("m2inmueble").Range.Text = txtapellido.Text

        Documento.Bookmarks.Item("NombreInquilino").Range.Text = nomInq.ToString
        Documento.Bookmarks.Item("NombrePropietario").Range.Text = nomProp.ToString
        Documento.Bookmarks.Item("NomInqui").Range.Text = nomInq.ToString
        Documento.Bookmarks.Item("NomProp").Range.Text = nomProp.ToString

        Documento.Bookmarks.Item("PrecioInmueble").Range.Text = precioInmu.ToString

        Documento.Save()
        MSWord.Visible = True

        Me.DialogResult = System.Windows.Forms.DialogResult.OK

    End Sub
End Class