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
                P.Pareo = DS.Tables(0).Rows(i)("Pareo")
                P.TemaId = DS.Tables(0).Rows(i)("TemaId")
                P.CategoriaId = DS.Tables(0).Rows(i)("CategoriaId")
                P.RespuestasList = ObtenerRespuestas(P.Id)
                If P.Pareo Then
                    P.PreguntaPareo = ObtenerPreguntasPareo(P.Id)
                End If
                List.Add(P)
            Next
        End If
        Return DTOS.GlobalClass.AleatorioIList(Of DTOS.Pregunta)(List)
    End Function
    Shared Function ObtenerPregunta(ByVal _id As Integer) As DTOS.Pregunta
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
                P.Pareo = DS.Tables(0).Rows(i)("Pareo")
                P.TemaId = DS.Tables(0).Rows(i)("TemaId")
                P.CategoriaId = DS.Tables(0).Rows(i)("CategoriaId")
                P.RespuestasList = ObtenerRespuestas(P.Id)
                If P.Pareo Then
                    P.PreguntaPareo = ObtenerPreguntasPareo(P.Id)

                End If
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
        Return DTOS.GlobalClass.AleatorioIList(Of DTOS.Respuesta)(ListaR)
    End Function
    Shared Function ObtenerRespuestasPareo(ByVal _id As Integer, ByVal pareoId As Integer) As DTOS.Respuesta
        Dim Con As Conexion = New Conexion()
        Dim cmd As SqlDataAdapter = New SqlDataAdapter()
        Dim DS As New DataSet()
        Dim R As New DTOS.Respuesta()
        If Con.Open() Then
            cmd.SelectCommand = New SqlCommand("SELECT * FROM Respuesta where preguntaid=" & _id & " and pareoid=" & pareoId, Con.ObtenerConexion())
            cmd.Fill(DS)
            For i As Integer = 0 To DS.Tables(0).Rows.Count() - 1 Step 1
                R.Id = DS.Tables(0).Rows(i)("Id")
                R.Descripcion = DS.Tables(0).Rows(i)("Descripcion")
                R.Correcta = DS.Tables(0).Rows(i)("Correcta")
                R.PreguntaId = DS.Tables(0).Rows(i)("PreguntaId")
            Next
        End If
        Return R
    End Function
    Shared Function ObtenerPreguntasPareo(ByVal _id As Integer) As List(Of DTOS.PreguntaPareo)
        Dim Con As Conexion = New Conexion()
        Dim cmd As SqlDataAdapter = New SqlDataAdapter()
        Dim DS As New DataSet()
        Dim ListaR As New List(Of DTOS.PreguntaPareo)
        If Con.Open() Then
            cmd.SelectCommand = New SqlCommand("SELECT * FROM preguntaPareo where preguntaid=" & _id, Con.ObtenerConexion())
            cmd.Fill(DS)
            For i As Integer = 0 To DS.Tables(0).Rows.Count() - 1 Step 1
                Dim R As New DTOS.PreguntaPareo()
                R.Id = DS.Tables(0).Rows(i)("Id")
                R.Descripcion = DS.Tables(0).Rows(i)("Descripcion")
                R.PreguntaId = DS.Tables(0).Rows(i)("PreguntaId")
                R.Respuesta = ObtenerRespuestasPareo(_id, R.Id)
                ListaR.Add(R)
            Next
        End If
        Return DTOS.GlobalClass.AleatorioIList(Of DTOS.PreguntaPareo)(ListaR)
    End Function

    Shared Function EliminarPregunta(ByVal _id As Integer) As Boolean
        Dim Con As Conexion = New Conexion()
        Dim ConObj As SqlConnection = Con.ObtenerConexion()
        Dim cmd As SqlCommand = New SqlCommand("delete from respuesta where preguntaid=@id; delete from pregunta where id=@id", ConObj)
        Dim DS As New DataSet()
        Dim ListaR As New List(Of DTOS.Respuesta)
        cmd.Parameters.Add("@id", DbType.String).Value = _id
        ConObj.Open()
        cmd.ExecuteNonQuery()
        Con.Close()
        Return True
    End Function


    Shared Function AgregarPregunta(ByVal Pregunta As DTOS.Pregunta) As Boolean
        Dim Con As Conexion = New Conexion()
        Dim ConObj As SqlConnection = Con.ObtenerConexion()
        Dim cmd As SqlCommand = New SqlCommand("Insert into Pregunta(Descripcion,SelMultiple,TemaId,CategoriaId,Pareo) output INSERTED.ID values (@Descripcion,@SelMultiple,@TemaId,@CategoriaId,@Pareo)", ConObj)
        Dim DS As New DataSet()
        Dim ListaR As New List(Of DTOS.Respuesta)
        cmd.Parameters.Add("@Descripcion", DbType.String).Value = Pregunta.Descripcion
        cmd.Parameters.Add("@SelMultiple", DbType.Boolean).Value = Pregunta.SelMultiple
        cmd.Parameters.Add("@TemaId", DbType.Int32).Value = Pregunta.TemaId
        cmd.Parameters.Add("@CategoriaId", DbType.Int32).Value = Pregunta.CategoriaId
        cmd.Parameters.Add("@Pareo", DbType.Boolean).Value = Pregunta.Pareo
        ConObj.Open()
        Dim PreguntaId As Integer = Convert.ToInt32(cmd.ExecuteScalar())
        If Pregunta.PreguntaPareo IsNot Nothing Then
            For Each par In Pregunta.PreguntaPareo
                par.PreguntaId = PreguntaId
                AgregarPareo(par, ConObj)
            Next
        End If
        If Pregunta.RespuestasList IsNot Nothing Then
            For Each resp In Pregunta.RespuestasList
                resp.PreguntaId = PreguntaId
                AgregarRespuesta(resp, ConObj)
            Next
        End If
        Con.Close()
        Return True
    End Function
    Shared Function AgregarPareo(ByVal par As DTOS.PreguntaPareo, ByVal Con As SqlConnection) As Boolean
        Dim cmd As SqlCommand = New SqlCommand("Insert into PreguntaPareo(Descripcion,PreguntaId) output INSERTED.ID values (@Descripcion,@PreguntaId)", Con)
        Dim DS As New DataSet()
        Dim ListaR As New List(Of DTOS.PreguntaPareo)
        cmd.Parameters.Add("@Descripcion", DbType.String).Value = par.Descripcion
        cmd.Parameters.Add("@PreguntaId", DbType.Int32).Value = par.PreguntaId
        Dim parid As Integer = cmd.ExecuteScalar()
        par.Respuesta.PareoId = parid
        par.Respuesta.PreguntaId = par.PreguntaId
        AgregarRespuesta(par.Respuesta, Con)
        Return True
    End Function

    Shared Function AgregarRespuesta(ByVal Respuesta As DTOS.Respuesta, ByVal Con As SqlConnection) As Boolean
        Dim cmd As SqlCommand = New SqlCommand("Insert into Respuesta(Descripcion,Correcta,PreguntaId,PareoId) output INSERTED.ID values (@Descripcion,@Correcta,@PreguntaId,@PareoId)", Con)
        Dim DS As New DataSet()
        Dim ListaR As New List(Of DTOS.Respuesta)
        cmd.Parameters.Add("@Descripcion", DbType.String).Value = Respuesta.Descripcion
        cmd.Parameters.Add("@Correcta", DbType.Boolean).Value = Respuesta.Correcta
        cmd.Parameters.Add("@PreguntaId", DbType.Int32).Value = Respuesta.PreguntaId
        cmd.Parameters.Add("@PareoId", DbType.Int32).Value = Respuesta.PareoId
        Dim respuestaId As Integer = cmd.ExecuteScalar()

        Return True
    End Function
End Class
