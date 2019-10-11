Imports Data

Public Class TipoUsuarioManejador
    Public Shared Function ObtenerTipoUsuario(ByVal context As dataEntities) As List(Of TipoUsuario)
        Return context.TipoUsuario.Select(Function(x) New TipoUsuario() With {.Descripcion = x.Descripcion, .Id = x.Id}).ToList()
    End Function
End Class
