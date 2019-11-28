Imports Data

Public Class UsuarioLogica
    Public Shared Function ObtenerTodo() As List(Of DTOS.Usuario)
        Return Usuario.ObtenerTodo()
    End Function
    Public Shared Function ObtenerUsuario(ByVal cedula As String) As DTOS.Usuario
        Return Usuario.ObtenerUsuario(cedula)
    End Function
    Public Shared Function GuardarUsuario(ByVal _u As DTOS.Usuario) As Boolean
        Return Usuario.GuardarUsuario(_u)
    End Function
End Class
