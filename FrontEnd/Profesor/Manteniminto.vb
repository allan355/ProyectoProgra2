Public Class FRM_PROF
    Dim Pregunta As DTOS.Pregunta = New DTOS.Pregunta
    Dim Respuestas As List(Of DTOS.Respuesta) = New List(Of DTOS.Respuesta)
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        LST_ANSW.Items.Add(txt_answer.Text)
        txt_answer.Text = Nothing
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If LST_ANSW.SelectedItem IsNot Nothing Then
            LST_ANSW.Items.Remove(LST_ANSW.SelectedItem)
        Else
            MessageBox.Show("Seleccione una Respuesta a eliminar")
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxTipoPregunta.SelectedIndexChanged
        If Me.cbxTipoPregunta.SelectedIndex = 0 Then
            GP_DESA.Enabled = False
            GP_SU.Enabled = True
        End If
        If Me.cbxTipoPregunta.SelectedIndex = 1 Then
            GP_SU.Enabled = False
            GP_DESA.Enabled = True
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Sub Limpiar()
        txt_A.Text = Nothing
        txt_B.Text = Nothing
        txt_C.Text = Nothing
        txt_D.Text = Nothing
        LST_ANSW.Items.Clear()
        txt_answer.Text = Nothing
        txt_question = Nothing

        Pregunta = New DTOS.Pregunta
        Respuestas = New List(Of DTOS.Respuesta)
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        Pregunta.Descripcion = txt_question.Text.Trim()
        Pregunta.CategoriaId = 1
        Pregunta.TemaId = 1
        If cbxTipoPregunta.SelectedIndex = 0 Then
            Pregunta.SelMultiple = True
            If rbtnA.Checked Then
                Respuestas.Add(New DTOS.Respuesta() With {.Descripcion = txt_A.Text, .Correcta = True})
            Else
                Respuestas.Add(New DTOS.Respuesta() With {.Descripcion = txt_A.Text, .Correcta = False})
            End If
            If rbtnB.Checked Then
                Respuestas.Add(New DTOS.Respuesta() With {.Descripcion = txt_B.Text, .Correcta = True})
            Else
                Respuestas.Add(New DTOS.Respuesta() With {.Descripcion = txt_B.Text, .Correcta = False})
            End If
            If rbtnC.Checked Then
                Respuestas.Add(New DTOS.Respuesta() With {.Descripcion = txt_C.Text, .Correcta = True})
            Else
                Respuestas.Add(New DTOS.Respuesta() With {.Descripcion = txt_C.Text, .Correcta = False})
            End If
            If rbtnD.Checked Then
                Respuestas.Add(New DTOS.Respuesta() With {.Descripcion = txt_D.Text, .Correcta = True})
            Else
                Respuestas.Add(New DTOS.Respuesta() With {.Descripcion = txt_D.Text, .Correcta = False})
            End If

        Else
            Pregunta.SelMultiple = False
            For Each Resp As String In LST_ANSW.Items
                Respuestas.Add(New DTOS.Respuesta() With {.Descripcion = Resp, .Correcta = True})
            Next
        End If
        Pregunta.RespuestasList = Respuestas
        Logica.PreguntasLogica.AgregarPregunta(Pregunta)
        Limpiar()
    End Sub

    Private Sub FRM_PROF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbxTipoPregunta.SelectedIndex = 0
    End Sub
End Class
