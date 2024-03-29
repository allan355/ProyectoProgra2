﻿Public Class FRM_PROF
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
            gbxPreguntas.Visible = True
            gbxPareo.Visible = False
        End If
        If Me.cbxTipoPregunta.SelectedIndex = 1 Then
            GP_SU.Enabled = False
            GP_DESA.Enabled = True
            gbxPreguntas.Visible = True
            gbxPareo.Visible = False
        End If
        If Me.cbxTipoPregunta.SelectedIndex = 2 Then
            gbxPreguntas.Visible = False
            gbxPareo.Visible = True
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

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
        End If
        If cbxTipoPregunta.SelectedIndex = 1 Then
            Pregunta.SelMultiple = False
            For Each Resp As String In LST_ANSW.Items
                Respuestas.Add(New DTOS.Respuesta() With {.Descripcion = Resp, .Correcta = True})
            Next
        End If
        If cbxTipoPregunta.SelectedIndex = 2 Then
            Pregunta.Pareo = True
            Dim listaPareo As List(Of DTOS.PreguntaPareo) = New List(Of DTOS.PreguntaPareo)
            listaPareo.Add(New DTOS.PreguntaPareo() With {.Descripcion = lblIzqPareo1.Text, .Respuesta = New DTOS.Respuesta() With {.Descripcion = lblDerPareo1.Text, .Correcta = True}})
            listaPareo.Add(New DTOS.PreguntaPareo() With {.Descripcion = lblIzqPareo2.Text, .Respuesta = New DTOS.Respuesta() With {.Descripcion = lblDerPareo2.Text, .Correcta = True}})
            listaPareo.Add(New DTOS.PreguntaPareo() With {.Descripcion = lblIzqPareo3.Text, .Respuesta = New DTOS.Respuesta() With {.Descripcion = lblDerPareo3.Text, .Correcta = True}})
            listaPareo.Add(New DTOS.PreguntaPareo() With {.Descripcion = lblIzqPareo4.Text, .Respuesta = New DTOS.Respuesta() With {.Descripcion = lblDerPareo4.Text, .Correcta = True}})
            listaPareo.Add(New DTOS.PreguntaPareo() With {.Descripcion = lblIzqPareo5.Text, .Respuesta = New DTOS.Respuesta() With {.Descripcion = lblDerPareo5.Text, .Correcta = True}})
            Pregunta.PreguntaPareo = listaPareo
        End If
        Pregunta.RespuestasList = Respuestas
        Logica.PreguntasLogica.AgregarPregunta(Pregunta)
        Limpiar()
    End Sub

    Private Sub FRM_PROF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbxTipoPregunta.SelectedIndex = 0
        gbxPreguntas.Location = New Point(12, 65)
    End Sub

    Private Sub VerUsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerUsuariosToolStripMenuItem.Click
        Dim ventana As Estudiantes = New Estudiantes()
        ventana.Show()
    End Sub

    Private Sub VerPreguntasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerPreguntasToolStripMenuItem.Click
        Dim ventana As frmPreguntas = New frmPreguntas()
        ventana.Show()
    End Sub

    Private Sub FRM_PROF_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub AgregarProfesorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarProfesorToolStripMenuItem.Click
        Dim ventana As RegistroUsuario = New RegistroUsuario()
        ventana.TU = 1
        ventana.Editable = True
        ventana.Show()
    End Sub

    Private Sub VerGraficoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerGraficoToolStripMenuItem.Click
        Dim ventana As Graficos = New Graficos()
        ventana.Show()
    End Sub
End Class
