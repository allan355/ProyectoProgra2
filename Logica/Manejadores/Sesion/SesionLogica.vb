Public Class SesionLogica
    Public Shared Function InsertarSesion(ByVal sesion As DTOS.Sesion) As Boolean
        Return Data.Sesion.AgregarSesion(sesion)
    End Function

    Public Shared Function obtenerResultado(ByVal PreguntaId As Integer) As List(Of DTOS.ReportePregunta)
        Return Data.Sesion.obtenerRessultados(PreguntaId)
    End Function
End Class
