Imports System.Security.Cryptography

Public Class GlobalClass
    Shared Property ListaPregunta As List(Of DTOS.Pregunta)
    Shared Property ListaPreguntaOrdenada As List(Of DTOS.Pregunta)
    Shared Property PreguntaPos As Integer


    Public Shared Function AleatorioIList(Of T)(inputList As IList(Of T)) As IList(Of T)
        Dim cryptoServiceProvider = New RNGCryptoServiceProvider()
        Dim count = inputList.Count
        While count > 1
            Dim bytes = New Byte(0) {}
            Do
                cryptoServiceProvider.GetBytes(bytes)
            Loop While Not (bytes(0) < count * ([Byte].MaxValue / count))
            Dim index = (bytes(0) Mod count)
            count -= 1
            Dim input = inputList(index)
            inputList(index) = inputList(count)
            inputList(count) = input
        End While
        Return inputList
    End Function
End Class
