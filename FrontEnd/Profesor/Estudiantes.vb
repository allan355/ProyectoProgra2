﻿Public Class Estudiantes
    Private Sub Estudiantes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = Logica.UsuarioLogica.ObtenerTodo()
        DataGridView1.Columns("GeneroId").Visible = False
        DataGridView1.Columns("TipoUsuarioID").Visible = False
    End Sub
End Class