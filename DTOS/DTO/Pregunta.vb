Public Class Pregunta
    Public Property Id As Integer
    Public Property Descripcion As String
    Public Property SelMultiple As Boolean
    Public Property TemaId As Integer
    Public Property CategoriaId As Integer

    Public Property RespuestasList As List(Of Respuesta)

End Class
