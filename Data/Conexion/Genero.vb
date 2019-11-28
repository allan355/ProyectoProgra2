Imports System.Data.SqlClient

Public Class Genero
    Shared Function ObtenerGenero(ByVal _id As Integer) As DTOS.Genero
        Dim Con As Conexion = New Conexion()
        Dim cmd As SqlDataAdapter = New SqlDataAdapter()
        Dim DS As New DataSet()
        Dim gen As New DTOS.Genero()
        If Con.Open() Then
            cmd.SelectCommand = New SqlCommand("SELECT * FROM Genero where id=" & _id, Con.ObtenerConexion())
            cmd.Fill(DS)
            For i As Integer = 0 To DS.Tables(0).Rows.Count() - 1 Step 1
                gen.Id = DS.Tables(0).Rows(i)("Id")
                gen.Descripcion = DS.Tables(0).Rows(i)("Descripcion")
            Next
        End If
        Con.Close()
        Return gen
    End Function
    Shared Function ObtenerTodo() As List(Of DTOS.Genero)
        Dim Con As Conexion = New Conexion()
        Dim cmd As SqlDataAdapter = New SqlDataAdapter()
        Dim DS As New DataSet()
        Dim lst As List(Of DTOS.Genero) = New List(Of DTOS.Genero)
        If Con.Open() Then
            cmd.SelectCommand = New SqlCommand("SELECT * FROM Genero", Con.ObtenerConexion())
            cmd.Fill(DS)
            For i As Integer = 0 To DS.Tables(0).Rows.Count() - 1 Step 1
                Dim gen As New DTOS.Genero()
                gen.Id = DS.Tables(0).Rows(i)("Id")
                gen.Descripcion = DS.Tables(0).Rows(i)("Descripcion")
                lst.Add(gen)
            Next
        End If
        Con.Close()
        Return lst
    End Function
End Class
