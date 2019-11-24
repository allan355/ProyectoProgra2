Public Class Pregunta
    Public Property Id As Integer
    Public Property Descripcion As String
    Public Property SelMultiple As Boolean
    Public Property TemaId As Integer
    Public Property CategoriaId As Integer
    Public Property Pareo As Boolean
    Public Property RespuestasList As List(Of Respuesta)
    Public Property PreguntaPareo As List(Of PreguntaPareo)

End Class
