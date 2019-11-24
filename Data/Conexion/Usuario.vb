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
                U.Apellido = DS.Tables(0).Rows(i)("Apellido")
                U.GeneroId = DS.Tables(0).Rows(i)("GeneroId")
                U.TipoUsuarioId = DS.Tables(0).Rows(i)("TipoUsuarioId")
                U.TipoUsuario = TipoUsuario.ObtenerTU(U.TipoUsuarioId)
                U.Genero = Genero.ObtenerTU(U.GeneroId)
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
                U.GeneroId = DS.Tables(0).Rows(i)("GeneroId")
                U.TipoUsuarioId = DS.Tables(0).Rows(i)("TipoUsuarioId")
                U.TipoUsuario = TipoUsuario.ObtenerTU(U.TipoUsuarioId)
                U.Genero = Genero.ObtenerTU(U.GeneroId)
                Exit For
            Next
        End If
        Return U
    End Function


    Shared Function GuardarUsuario(ByVal _U As DTOS.Usuario) As Boolean
        Dim Con As Conexion = New Conexion()
        Dim cmd As SqlCommand = New SqlCommand()
        Dim List As New List(Of DTOS.Usuario)
        If Con.Open() Then
            cmd.Connection = Con.ObtenerConexion()
            cmd.CommandText = "insert into USUARIO(Nombre,Apellido,GeneroId,TipoUsuarioId) values('" & _U.Nombre & "','" & _U.Apellido & "'," & _U.GeneroId & "," & _U.TipoUsuarioId & ")"
            cmd.ExecuteNonQuery()
            Return True
        End If
        Return False
    End Function
End Class
