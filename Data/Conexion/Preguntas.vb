Imports System.Data.SqlClient

Public Class Preguntas

    Shared Function ObtenerTodo() As List(Of DTOS.Pregunta)
        Dim Con As Conexion = New Conexion()
        Dim cmd As SqlDataAdapter = New SqlDataAdapter()
        Dim DS As New DataSet()
        Dim List As New List(Of DTOS.Pregunta)
        If Con.Open() Then
            cmd.SelectCommand = New SqlCommand("SELECT * FROM Pregunta", Con.ObtenerConexion())
            cmd.Fill(DS)
            For i As Integer = 0 To DS.Tables(0).Rows.Count() - 1 Step 1
                Dim P As New DTOS.Pregunta()
                P.Id = DS.Tables(0).Rows(i)("Id")
                P.Descripcion = DS.Tables(0).Rows(i)("Descripcion")
                P.SelMultiple = DS.Tables(0).Rows(i)("SelMultiple")
                P.TemaId = DS.Tables(0).Rows(i)("TemaId")
                P.CategoriaId = DS.Tables(0).Rows(i)("CategoriaId")
                P.RespuestasList = ObtenerRespuestas(P.Id)
                List.Add(P)
            Next
        End If
        Return List
    End Function
    Shared Function ObtenerUsuario(ByVal _id As Integer) As DTOS.Pregunta
        Dim Con As Conexion = New Conexion()
        Dim cmd As SqlDataAdapter = New SqlDataAdapter()
        Dim DS As New DataSet()
        Dim P As New DTOS.Pregunta()
        If Con.Open() Then
            cmd.SelectCommand = New SqlCommand("SELECT * FROM Pregunta where id=" & _id, Con.ObtenerConexion())
            cmd.Fill(DS)
            For i As Integer = 0 To DS.Tables(0).Rows.Count() - 1 Step 1
                P.Id = DS.Tables(0).Rows(i)("Id")
                P.Descripcion = DS.Tables(0).Rows(i)("Descripcion")
                P.SelMultiple = DS.Tables(0).Rows(i)("SelMultiple")
                P.TemaId = DS.Tables(0).Rows(i)("TemaId")
                P.CategoriaId = DS.Tables(0).Rows(i)("CategoriaId")
                P.RespuestasList = ObtenerRespuestas(P.Id)
                Exit For
            Next
        End If
        Return P
    End Function
    Shared Function ObtenerRespuestas(ByVal _id As Integer) As List(Of DTOS.Respuesta)
        Dim Con As Conexion = New Conexion()
        Dim cmd As SqlDataAdapter = New SqlDataAdapter()
        Dim DS As New DataSet()
        Dim ListaR As New List(Of DTOS.Respuesta)
        If Con.Open() Then
            cmd.SelectCommand = New SqlCommand("SELECT * FROM Respuesta where preguntaid=" & _id, Con.ObtenerConexion())
            cmd.Fill(DS)
            For i As Integer = 0 To DS.Tables(0).Rows.Count() - 1 Step 1
                Dim R As New DTOS.Respuesta()
                R.Id = DS.Tables(0).Rows(i)("Id")
                R.Descripcion = DS.Tables(0).Rows(i)("Descripcion")
                R.Correcta = DS.Tables(0).Rows(i)("Correcta")
                R.PreguntaId = DS.Tables(0).Rows(i)("PreguntaId")
                ListaR.Add(R)
            Next
        End If
        Return ListaR
    End Function
End Class
