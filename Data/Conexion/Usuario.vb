Imports System.Data.SqlClient

Public Class Usuario

    Shared Function ObtenerTodo() As List(Of DTOS.Usuario)
        Dim Con As Conexion = New Conexion()
        Dim cmd As SqlDataAdapter = New SqlDataAdapter()
        Dim DS As New DataSet()
        Dim List As New List(Of DTOS.Usuario)
        If Con.Open() Then
            cmd.SelectCommand = New SqlCommand("SELECT * FROM usuario", Con.ObtenerConexion())
            cmd.Fill(DS)
            For i As Integer = 0 To DS.Tables(0).Rows.Count() - 1 Step 1
                Dim U As New DTOS.Usuario()
                U.Id = DS.Tables(0).Rows(i)("Id")
                U.Nombre = DS.Tables(0).Rows(i)("Nombre")
                U.Apellido1 = DS.Tables(0).Rows(i)("Apellido1")
                U.Apellido2 = DS.Tables(0).Rows(i)("Apellido2")
                U.Cedula = DS.Tables(0).Rows(i)("Cedula")
                U.GeneroId = DS.Tables(0).Rows(i)("GeneroId")
                U.TipoUsuarioId = DS.Tables(0).Rows(i)("TipoUsuarioId")
                U.TipoUsuario = TipoUsuario.ObtenerTU(U.TipoUsuarioId)
                U.Genero = Genero.ObtenerGenero(U.GeneroId)
                List.Add(U)
            Next
        End If
        Return List
    End Function
    Shared Function ObtenerUsuario(ByVal _id As Integer) As DTOS.Usuario
        Dim Con As Conexion = New Conexion()
        Dim cmd As SqlDataAdapter = New SqlDataAdapter()
        Dim DS As New DataSet()
        Dim U As New DTOS.Usuario()
        If Con.Open() Then
            cmd.SelectCommand = New SqlCommand("SELECT * FROM usuario where id=" & _id, Con.ObtenerConexion())
            cmd.Fill(DS)
            For i As Integer = 0 To DS.Tables(0).Rows.Count() - 1 Step 1
                U.Id = DS.Tables(0).Rows(i)("Id")
                U.Nombre = DS.Tables(0).Rows(i)("Nombre")
                U.Apellido1 = DS.Tables(0).Rows(i)("Apellido1")
                U.Apellido2 = DS.Tables(0).Rows(i)("Apellido2")
                U.Cedula = DS.Tables(0).Rows(i)("Cedula")
                U.GeneroId = DS.Tables(0).Rows(i)("GeneroId")
                U.TipoUsuarioId = DS.Tables(0).Rows(i)("TipoUsuarioId")
                U.TipoUsuario = TipoUsuario.ObtenerTU(U.TipoUsuarioId)
                U.Genero = Genero.ObtenerGenero(U.GeneroId)
                Exit For
            Next
        End If
        Return U
    End Function
    Shared Function ObtenerUsuario(ByVal cedula As String) As DTOS.Usuario
        Dim Con As Conexion = New Conexion()
        Dim cmd As SqlDataAdapter = New SqlDataAdapter()
        Dim DS As New DataSet()
        Dim U As New DTOS.Usuario()
        If Con.Open() Then
            cmd.SelectCommand = New SqlCommand("SELECT * FROM usuario where cedula='" & cedula & "'", Con.ObtenerConexion())
            cmd.Fill(DS)
            For i As Integer = 0 To DS.Tables(0).Rows.Count() - 1 Step 1
                U.Id = DS.Tables(0).Rows(i)("Id")
                U.Nombre = DS.Tables(0).Rows(i)("Nombre")
                U.Apellido1 = DS.Tables(0).Rows(i)("Apellido1")
                U.Apellido2 = DS.Tables(0).Rows(i)("Apellido2")
                U.Cedula = DS.Tables(0).Rows(i)("Cedula")
                U.GeneroId = DS.Tables(0).Rows(i)("GeneroId")
                U.TipoUsuarioId = DS.Tables(0).Rows(i)("TipoUsuarioId")
                U.TipoUsuario = TipoUsuario.ObtenerTU(U.TipoUsuarioId)
                U.Genero = Genero.ObtenerGenero(U.GeneroId)
                Exit For
            Next
        End If
        Return U
    End Function


    Shared Function GuardarUsuario(ByVal _U As DTOS.Usuario) As Boolean
        Dim Con As Conexion = New Conexion()
        Dim ConObj As SqlConnection = Con.ObtenerConexion()
        Dim cmd As SqlCommand = New SqlCommand("Insert into Usuario(Nombre, Apellido1, Apellido2, GeneroId, TipoUsuarioId, Cedula) output INSERTED.ID values (@Nombre, @Apellido1, @Apellido2, @GeneroId, @TipoUsuarioId, @Cedula)", ConObj)
        Dim DS As New DataSet()
        Dim ListaR As New List(Of DTOS.Respuesta)
        cmd.Parameters.Add("@Nombre", DbType.String).Value = _U.Nombre
        cmd.Parameters.Add("@Apellido1", DbType.String).Value = _U.Apellido1
        cmd.Parameters.Add("@Apellido2", DbType.String).Value = _U.Apellido2
        cmd.Parameters.Add("@Cedula", DbType.String).Value = _U.Cedula
        cmd.Parameters.Add("@GeneroId", DbType.Int32).Value = _U.GeneroId
        cmd.Parameters.Add("@TipoUsuarioId", DbType.Int32).Value = _U.TipoUsuarioId
        ConObj.Open()
        Dim PreguntaId As Integer = Convert.ToInt32(cmd.ExecuteScalar())
        Con.Close()
        Return True
    End Function
End Class
