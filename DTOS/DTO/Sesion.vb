Public Class Sesion
    Public Property Id As Integer
    Public Property ContadorRespuestas As Integer
    Public Property UsuarioId As Integer
    Public Property MaxPreguntas As Integer
    Public Property RespuestasSesion As List(Of DTOS.RespuestaXSesion)
End Class
