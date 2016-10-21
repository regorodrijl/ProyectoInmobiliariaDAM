Public Class NuevoLogin

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Close()
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        If txtBClave.Text = "" Or txtbUsuario.Text = "" Then
            MsgBox("Faltan Campos", MsgBoxStyle.Exclamation, "Rellene todos los campos.")
            Exit Sub
        End If

        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
End Class