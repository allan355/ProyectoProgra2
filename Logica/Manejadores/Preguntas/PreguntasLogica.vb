Public Class PreguntasLogica
    Public Shared Function ObtenerPreguntas() As List(Of DTOS.Pregunta)
        Return Data.Preguntas.ObtenerTodo()
    End Function

    Public Shared Function AgregarPregunta(ByVal Pregunta As DTOS.Pregunta) As Boolean
        Return Data.Preguntas.AgregarPregunta(Pregunta)
    End Function

    Public Shared Function EliminarPregunta(ByVal _id As Integer) As Boolean
        Return Data.Preguntas.EliminarPregunta(_id)
    End Function

    Public Shared Function VerificarRespuesta(ByVal Respuesta As String, ByVal Preg As DTOS.Pregunta, Optional pos As Integer = 0) As Boolean
        Dim bandera As Boolean = False
        If Preg.Pareo Then
            If Respuesta.Trim().ToUpper().Equals(Preg.PreguntaPareo(pos).Respuesta.Descripcion.Trim().ToUpper) Then
                bandera = True
            End If
        Else
            For i As Integer = 0 To Preg.RespuestasList.Count() - 1 Step 1
                If Respuesta.Trim().ToUpper().Equals(Preg.RespuestasList(i).Descripcion.Trim().ToUpper) Then
                    If Preg.RespuestasList(i).Correcta Then
                        bandera = True
                        Exit For
                    Else
                        bandera = False
                    End If
                End If
            Next
        End If
        Return bandera
        'sample
    End Function
End Class
