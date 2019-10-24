﻿Imports System.Data.SqlClient

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
        Return List
    End Function

End Class