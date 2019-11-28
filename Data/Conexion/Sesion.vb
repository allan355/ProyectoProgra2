Imports System.Data.SqlClient

Public Class Sesion

    Shared Function AgregarSesion(ByVal sesion As DTOS.Sesion) As Boolean
        Dim Con As Conexion = New Conexion()
        Dim ConObj As SqlConnection = Con.ObtenerConexion()
        Dim cmd As SqlCommand = New SqlCommand("Insert into Sesion(UsuarioId,ContadorRespuestas,MaxPreguntas) output INSERTED.ID values (@UsuarioId,@ContadorRespuestas,@MaxPreguntas)", ConObj)
        Dim DS As New DataSet()
        Dim ListaR As New List(Of DTOS.Respuesta)
        cmd.Parameters.Add("@UsuarioId", DbType.String).Value = sesion.UsuarioId
        cmd.Parameters.Add("@ContadorRespuestas", DbType.Int32).Value = sesion.ContadorRespuestas
        cmd.Parameters.Add("@MaxPreguntas", DbType.Int32).Value = sesion.MaxPreguntas
        ConObj.Open()
        Dim PreguntaId As Integer = Convert.ToInt32(cmd.ExecuteScalar())
        If sesion.RespuestasSesion IsNot Nothing Then
            For Each par In sesion.RespuestasSesion
                par.SesionId = PreguntaId
                AgregarRespuesta(par, ConObj)
            Next
        End If

        Con.Close()
        Return True
    End Function


    Shared Function AgregarRespuesta(ByVal Respuesta As DTOS.RespuestaXSesion, ByVal Con As SqlConnection) As Boolean
        Dim cmd As SqlCommand = New SqlCommand("Insert into RespuestaXSesion(PreguntaId,SesionId,Correcta) output INSERTED.ID values (@PreguntaId,@SesionId,@Correcta)", Con)
        Dim DS As New DataSet()
        Dim ListaR As New List(Of DTOS.Respuesta)
        cmd.Parameters.Add("@PreguntaId", DbType.Int32).Value = Respuesta.PreguntaId
        cmd.Parameters.Add("@SesionId", DbType.Int32).Value = Respuesta.SesionId
        cmd.Parameters.Add("@Correcta", DbType.Boolean).Value = Respuesta.Correcta
        Dim respuestaId As Integer = cmd.ExecuteScalar()

        Return True
    End Function

    Public Shared Function obtenerRessultados(ByVal PreguntaId As Integer) As List(Of DTOS.ReportePregunta)
        Dim Con As Conexion = New Conexion()
        Dim cmd As SqlDataAdapter = New SqlDataAdapter()
        Dim DS As New DataSet()
        Dim List As New List(Of DTOS.ReportePregunta)
        If Con.Open() Then
            cmd.SelectCommand = New SqlCommand("select count(1) Cantidad, Correcta,PreguntaId from pregunta p inner join RespuestaXSesion rs on p.Id = rs.PreguntaId where PreguntaId=" & PreguntaId & " group by Correcta,PreguntaId order by Correcta", Con.ObtenerConexion())
            cmd.Fill(DS)
            For i As Integer = 0 To DS.Tables(0).Rows.Count() - 1 Step 1
                Dim P As New DTOS.ReportePregunta()
                P.Cantidad = DS.Tables(0).Rows(i)("Cantidad")
                P.Correcta = DS.Tables(0).Rows(i)("Correcta")
                P.PreguntaId = DS.Tables(0).Rows(i)("PreguntaId")

                List.Add(P)
            Next
        End If
        Return (List)
    End Function
End Class
