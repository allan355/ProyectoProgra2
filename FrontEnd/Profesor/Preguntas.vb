Public Class frmPreguntas
    Sub llenarGrig()
        DataGridView1.DataSource = Logica.PreguntasLogica.ObtenerPreguntas().OrderBy(Function(x) x.Id).ToList()
        For Each a As DataGridViewColumn In DataGridView1.Columns
            a.ReadOnly = True
        Next
        'DataGridView1.Columns("GeneroId").Visible = False
        'DataGridView1.Columns("TipoUsuarioID").Visible = False
        Dim btn As New DataGridViewButtonColumn
        btn.HeaderText = "Acciones"
        btn.Text = "Eliminar"
        btn.Name = "btn"
        btn.UseColumnTextForButtonValue = True
        'btn.
        DataGridView1.Columns.Add(btn)
    End Sub
    Private Sub Estudiantes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarGrig()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)

        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso
           e.RowIndex >= 0 Then
            Dim result As DialogResult = MessageBox.Show("Seguro que desea eliminar la pregunta", "Eliminar", MessageBoxButtons.YesNoCancel)
            If result = DialogResult.Yes Then
                Logica.PreguntasLogica.EliminarPregunta(senderGrid.Rows(e.RowIndex).Cells("Id").Value)
                llenarGrig()
            End If
        End If
    End Sub

    Private Sub frmPreguntas_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub
End Class