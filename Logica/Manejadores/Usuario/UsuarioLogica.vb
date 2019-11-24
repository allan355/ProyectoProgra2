Imports Data

Public Class UsuarioLogica
    Public Shared Function ObtenerTodo() As List(Of DTOS.Usuario)
        Return Usuario.ObtenerTodo()
    End Function
End Class
