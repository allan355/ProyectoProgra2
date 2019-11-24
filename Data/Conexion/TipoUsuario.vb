Imports System.Data.SqlClient

Public Class TipoUsuario
    Shared Function ObtenerTodo() As List(Of DTOS.TipoUsuario)
        Dim Con As Conexion = New Conexion()
        Dim cmd As SqlDataAdapter = New SqlDataAdapter()
        Dim DS As New DataSet()
        Dim List As New List(Of DTOS.TipoUsuario)
        If Con.Open() Then
            cmd.SelectCommand = New SqlCommand("SELECT * FROM TIPOUSUARIO", Con.ObtenerConexion())
            cmd.Fill(DS)
            For i As Integer = 0 To DS.Tables(0).Rows.Count() - 1 Step 1
                Dim TU As New DTOS.TipoUsuario()
                TU.Id = DS.Tables(0).Rows(i)("Id")
                TU.Descripcion = DS.Tables(0).Rows(i)("Descripcion")
                List.Add(TU)
            Next
        End If
        Con.Close()
        Return List
    End Function
    Shared Function ObtenerTU(ByVal _id) As DTOS.TipoUsuario
        Dim Con As Conexion = New Conexion()
        Dim cmd As SqlDataAdapter = New SqlDataAdapter()
        Dim DS As New DataSet()
        Dim TU As New DTOS.TipoUsuario()
        If Con.Open() Then
            cmd.SelectCommand = New SqlCommand("SELECT * FROM TIPOUSUARIO where id=" & _id, Con.ObtenerConexion())
            cmd.Fill(DS)
            For i As Integer = 0 To DS.Tables(0).Rows.Count() - 1 Step 1
                TU.Id = DS.Tables(0).Rows(i)("Id")
                TU.Descripcion = DS.Tables(0).Rows(i)("Descripcion")
            Next
        End If
        Con.Close()
        Return TU
    End Function

End Class
