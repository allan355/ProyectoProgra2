Imports System.Data.SqlClient

Public Class Conexion
    Dim ConexionS As SqlConnection

    Public Sub New()

    End Sub

    Public Function ObtenerConexion() As SqlConnection
        Return ConexionS
    End Function

    Public Function Open() As Boolean
        Try
            ConexionS = New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("dataEntities").ToString())
            ConexionS.Open()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function Close() As Boolean
        Try
            ConexionS.Close()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

End Class
