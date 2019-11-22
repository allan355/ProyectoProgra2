Imports Logica

Public Class sample
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.DataSource = TipoUsuarioLogica.ObtenerTipoUsuario()
        ComboBox1.ValueMember = "Id"
        ComboBox1.DisplayMember = "Descripcion"

        Dim a As List(Of DTOS.Pregunta) = PreguntasLogica.ObtenerPreguntas()

        Console.WriteLine()

    End Sub
End Class
