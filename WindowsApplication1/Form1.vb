Option Explicit On
Imports System.IO

Public Class Form1


    'CREAMOS UNA COLECCION USANDO LA CLASE HASHTABLE
    Private Mi_imagen As New Hashtable()

    'VARIABLE PARA ACCEDER AL CUADRO DE DIALOGO
    Dim opp As New OpenFileDialog


    'SUB QUE AGREGA LOS ARCHIVOS A LA LISTA Y A LA COLECCION MI_IMAGEN
    Private Sub Agregar_Archivos(ByVal Nombre_Largo As String)
        'obtenemos el nombre de archivo y eliminandos la ruta 
        Dim nombre_Archivo As String = Path.GetFileName(Nombre_Largo)
        'agregamos la ruta completa
        If Not Mi_imagen.ContainsKey(nombre_Archivo) Then
            Mi_imagen.Add(nombre_Archivo, Nombre_Largo)
            'agregamos solo el nombre del archivo a la lista.
            Lis.Items.Add(nombre_Archivo)
        End If
    End Sub

    'FUNCION PARA ACCEDER A LA COLECCION
    Private Function Obtener_nombre_Largo(ByVal Archivo_Buscado As String) As String
        'Define un par de clave y valor de diccionario que se puede establecer o recuperar.
        Dim entra As DictionaryEntry
        'recorremos cada elemento de la colección de Mi_imagen
        For Each entra In Mi_imagen
            'si encontramos el elemento deseado
            If entra.Key Is Archivo_Buscado Then
                'devolvemos la información sobre él.
                Return entra.Value.ToString()
            End If
        Next 'de no ser así, devolvemos una cadena vacía.
        Return ""
    End Function

    'CODIGO PARA ABRIR Y CARGAR LAS IMAGENES
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            'establecemos el filtro para el tipo de archivos que deseamos
            opp.Filter = "Archivos de imagen (*.jpg) | *.jpg" 'etc, etc..
            If opp.ShowDialog() = DialogResult.OK Then
                'agregamos los elementos a la lista
                Dim archivos() As String = opp.FileNames
                Dim i As Integer
                For i = 0 To archivos.Length - 1
                    Agregar_Archivos(archivos(i))
                Next
            End If
            'Capturamos algun error
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    'LEEMOS CARACTERISTICAS DE INICIO
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Esto es para seleccionar varios o todos los archivos de la carpeta en opp
        opp.Multiselect = True
        nom.Text = "Nombre: "
    End Sub

    'SUB PARA VISUALLIZAR LAS IMAGENES
    Sub imagen()
        Try
            Pic.Image = Image.FromFile(Obtener_nombre_Largo(Lis.SelectedItem.ToString()))
            nom.Text = "Nombre: " & Lis.Text
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    'BORRAMOS LAS IMAGENES
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Lis.Items.Clear()
        Pic.Image = Nothing
        nom.Text = "Nom: "
    End Sub

    Private Sub Lis_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Lis.Click
        Call imagen()
    End Sub

    Private Sub Lis_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lis.SelectedIndexChanged
        Call imagen()
    End Sub
    'iniciamos depuracion..

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call imagen()
    End Sub
End Class
