Public Class NuevoUsuario
    'son para pasar los datos al formulario principal
    Public usuario
    Public clave
    Private Sub CheckBox(sender As Object, e As EventArgs) Handles CbEmpleado.CheckedChanged
        If CbEmpleado.Checked Then
            TxtNSS.Visible = True
            LblNSS.Visible = True
        Else
            TxtNSS.Visible = False
            LblNSS.Visible = False
        End If
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        If TxtNombre.Text = "" Or TxtApellidos.Text = "" Or TxtNif.Text = "" Or TxtDireccion.Text = "" Or TxtTelefono.Text = "" Or (CbPropietario.Checked = False And CbCliente.Checked = False And CbEmpleado.Checked = False) Then

            MsgBox("Faltan Datos.")
            Exit Sub
        End If

        If CbEmpleado.Checked Then
            If (TxtNSS.Text = "") Then
                MsgBox("Su Nuevo Usuario es un Empleado, debe rellenar lo siguiente: Nº Seguiridad Social")
                Exit Sub
            End If

            MsgBox("Su Nuevo Usuario es un Empleado, debe crear su login.")

            Dim FrmNLogin = New NuevoLogin

            If FrmNLogin.ShowDialog = DialogResult.Cancel Then
                Exit Sub
            End If

            With FrmNLogin
                usuario = .txtbUsuario.Text
                clave = .txtBClave.Text
            End With

        End If
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
    Private Sub TxtBanoHabi_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TxtTelefono.KeyPress, TxtTelef2.KeyPress
        Dim validos As String = "1234567890" + Chr(8)
        If Not validos.Contains(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles ButnCancelar.Click
        Me.Close()
    End Sub
End Class