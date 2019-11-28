Public Class RegistroUsuario
    Public TU As Integer
    Public Editable As Boolean
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim usu As DTOS.Usuario = New DTOS.Usuario()
        usu.Apellido1 = txtPApe.Text.Trim()
        usu.Apellido2 = txtSApe.Text.Trim()
        usu.Nombre = txtNombre.Text.Trim()
        usu.GeneroId = cbxGenero.SelectedValue
        usu.TipoUsuarioId = cbxTU.SelectedValue
        usu.Cedula = txtCedula.Text.Trim()
        Logica.UsuarioLogica.GuardarUsuario(usu)
    End Sub

    Private Sub SetEditable()
        txtPApe.Enabled = Editable
        txtSApe.Enabled = Editable
        txtNombre.Enabled = Editable
        cbxGenero.Enabled = Editable
        cbxTU.Enabled = Editable
        txtCedula.Enabled = Editable
        Button1.Enabled = Editable
    End Sub

    Private Sub RegistroUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbxTU.DataSource = Logica.TipoUsuarioLogica.ObtenerTipoUsuario()
        cbxTU.ValueMember = "Id"
        cbxTU.DisplayMember = "Descripcion"

        cbxGenero.DataSource = Logica.GeneroLogica.ObtenerTodo()
        cbxGenero.ValueMember = "Id"
        cbxGenero.DisplayMember = "Descripcion"

        cbxTU.SelectedValue = TU
        cbxTU.Enabled = False
    End Sub
End Class