Imports MySql.Data.MySqlClient
Public Class Login

    Public Mysqlconnection As MySqlConnection
    Public myadapter As New MySqlDataAdapter
    Public emple As String

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        MsgBox("Adios!!!!!!!!!")
        Me.Close() ' cerramos formulario
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        'Para establecer conexion con la base de datos.
        Mysqlconnection = New MySqlConnection()
        Dim txtServer As String = "127.0.0.1"
        Dim txtUsuario As String = "joseluis"
        Dim txtContrasena As String = "Nahyr17.7"
        Dim txtPuerto As String = "3306"
        Dim txtBaseDatosName As String = "inmobiliaria1"

        Try

            Mysqlconnection = New MySqlConnection("Server=" & txtServer & ";" & _
                                           "Uid=" & txtUsuario & ";" & _
                                           "Pwd=" & txtContrasena & ";" & _
                                           "Port=" & txtPuerto & ";" & _
                                           "Database=" & txtBaseDatosName & ";")
            Mysqlconnection.Open()

            MsgBox("Conexion correcta")
        Catch myerror As MySqlException
            MsgBox("no se pudo conectar a la bd" & myerror.Message)
            'Catch ex As Exception
        End Try
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        emple = txtbUsuario.Text
        Dim sqlquery As String = "SELECT * FROM login WHERE  clave='" & txtBClave.Text & "';"
        Dim command As New MySqlCommand
        command.Connection = Mysqlconnection
        command.CommandText = sqlquery
        myadapter.SelectCommand = command
        Dim mydata As MySqlDataReader
        mydata = command.ExecuteReader()
        If mydata.HasRows = 0 Then
            MsgBox("USUARIO INVALIDO : " & txtbUsuario.Text & " – " & txtBClave.Text)
            txtbUsuario.Text = "" 'restablecemos para que vuelva a poder escribir
            txtBClave.Text = ""
            Mysqlconnection.Close()
        Else
            'MsgBox("OK


            Me.Hide() 'ocultamos el formulario ya que no queremos que nos siga apareciendo 
            Gestion.Show() ' y arrancamos el siguientes que es gestion
            ' para que no se cerrar la aplcacion y para que no se quedara colgada al cerrar una ventana tuvimos que cambiar
            ' la forma de cerrar el programa, en las propiedades del proyecto.

            Mysqlconnection.Close()
            MsgBox("Buenos Días " & txtbUsuario.Text & " !!")
            Me.Close()
        End If
    End Sub

End Class
