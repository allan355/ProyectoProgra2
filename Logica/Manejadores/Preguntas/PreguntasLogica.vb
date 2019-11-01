Public Class PreguntasLogica
    Public Shared Function ObtenerPreguntas() As List(Of DTOS.Pregunta)
        Return Data.Preguntas.ObtenerTodo()
    End Function
End Class
