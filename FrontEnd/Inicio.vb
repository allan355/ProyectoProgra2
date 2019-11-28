Public Class frm_prin

    Private Sub frm_prin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_date.Text = DateTime.Now.ToLongDateString()
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub

    Private Function ObtenerUsuario() As DTOS.Usuario
        Return Logica.UsuarioLogica.ObtenerUsuario(txt_user.Text.Trim())
    End Function

    Private Sub frm_prin_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Dim usu As DTOS.Usuario = ObtenerUsuario()
        If usu Is Nothing Or usu.Cedula Is Nothing Then
            MessageBox.Show("Cedula no encontrada")
            Return
        End If
        If usu.TipoUsuarioId = 2 Then
            Dim ventana As FRM_MAIN = New FRM_MAIN()
            ventana.Usuario = usu
            ventana.Show()
            Me.Hide()
        End If
        If usu.TipoUsuarioId = 1 Then
            Dim ventanaP As FRM_PROF = New FRM_PROF()
            ventanaP.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub btnNuevoUsuario_Click(sender As Object, e As EventArgs) Handles btnNuevoUsuario.Click
        Dim ventana As RegistroUsuario = New RegistroUsuario()
        ventana.TU = 2
        ventana.Editable = True
        ventana.Show()
        Me.Hide()
    End Sub
End Class
