Imports Data

Public Class TipoUsuarioLogica
    Public Shared Function ObtenerTipoUsuario() As List(Of TipoUsuario)
        Dim context As dataEntities = New dataEntities()
        Return TipoUsuarioManejador.ObtenerTipoUsuario(context)
    End Function
End Class
