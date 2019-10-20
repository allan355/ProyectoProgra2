
Public Class TipoUsuarioLogica
    Public Shared Function ObtenerTipoUsuario() As List(Of DTOS.TipoUsuario)
        Return Data.TipoUsuario.ObtenerTodo()
    End Function
End Class
