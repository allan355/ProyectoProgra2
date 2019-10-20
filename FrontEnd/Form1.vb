Imports Logica

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.DataSource = TipoUsuarioLogica.ObtenerTipoUsuario()
        ComboBox1.ValueMember = "Id"
        ComboBox1.DisplayMember = "Descripcion"
    End Sub
End Class
