'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Namespace Sample

    Partial Public Class TipoLog
        Public Property Id As Integer
        Public Property Descripcion As String
    
        Public Overridable Property Log As ICollection(Of Log) = New HashSet(Of Log)
    
    End Class

End Namespace