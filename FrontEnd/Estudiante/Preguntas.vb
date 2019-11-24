Imports DTOS
Imports Logica

Public Class FRM_MAIN

    Dim tooltipProgress As ToolTip = New ToolTip()

    Const TextoComplete As String = "Adivinanzas." & vbNewLine & "En esta sección se pretende evaluar la capacidad de pensamiento lateral del estudiante. una única respuesta correcta."
    Const TextoSeleccionUnica As String = "Selección Única." & vbNewLine & "Por favor responder a cada pregunta seleccionando una de las opciones mostradas para cada pregunta respectivamente." & vbNewLine & "Solo una respuesta es correcta."
    Const TextoPareo As String = "Pareo"
    Dim time As Integer = 10
    Dim Pregunta As DTOS.Pregunta
    Dim Correctas As Integer = 0
    Sub ObtenerSiguientePregunta()
        Pregunta = GlobalClass.ListaPreguntaOrdenada.Item(GlobalClass.PreguntaPos)
        If Not Pregunta.Pareo Then
            gbxPareo.Visible = False
            gpbxResp.Visible = True
            If Pregunta.SelMultiple Then
                lbl_instruction.Text = TextoSeleccionUnica
                gbxSU.Visible = True
                gbxComplete.Visible = False
                rhtxtPregunta.Text = GlobalClass.PreguntaPos + 1 & "). " & Pregunta.Descripcion
                RAD_OPT1.Text = Pregunta.RespuestasList(0).Descripcion
                RAD_OPT2.Text = Pregunta.RespuestasList(1).Descripcion
                RAD_OPT3.Text = Pregunta.RespuestasList(2).Descripcion
                RAD_OPT4.Text = Pregunta.RespuestasList(3).Descripcion
            Else
                lbl_instruction.Text = TextoComplete
                gbxComplete.Visible = True
                gbxSU.Visible = False
                rhtxtPregunta.Text = GlobalClass.PreguntaPos + 1 & "). " & Pregunta.Descripcion
            End If
        Else

        End If

    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GlobalClass.ListaPreguntaOrdenada = PreguntasLogica.ObtenerPreguntas()
        'GlobalClass.ListaPreguntaOrdenada = GlobalClass.AleatorioIList(Of DTOS.Pregunta)(GlobalClass.ListaPregunta)
        ObtenerSiguientePregunta()
        pgsbProcesso.Minimum = 0
        pgsbProcesso.Maximum = GlobalClass.ListaPreguntaOrdenada.Count
        pgsbProcesso.Value = 0

        tooltipProgress.AutoPopDelay = 5000
        tooltipProgress.InitialDelay = 1000
        tooltipProgress.ReshowDelay = 500
        tooltipProgress.ShowAlways = True

        gpbxResp.Location = New Point(18, 145)
        gbxSU.Location = New Point(6, 120)

    End Sub

    Private Sub btn_next_Click(sender As Object, e As EventArgs) Handles btn_next.Click
        time = 10
        Timer1.Stop()
        GlobalClass.PreguntaPos += 1
        validarRespuesta()
        If pgsbProcesso.Value < pgsbProcesso.Maximum Then
            pgsbProcesso.Value += 1
            If pgsbProcesso.Value = pgsbProcesso.Maximum Then
                btn_next.Enabled = False
                MsgBox("Completado, su puntaje es de " & CalcularNota() & " puntos", MsgBoxStyle.OkOnly, "Información")
            Else
                ObtenerSiguientePregunta()

                time = 10
                Timer1.Start()
            End If
        End If
        limpiar()
    End Sub
    Function CalcularNota() As String
        Dim nota As Decimal = (100 / pgsbProcesso.Maximum) * Correctas
        Return nota.ToString()
    End Function
    Sub limpiar()
        RAD_OPT1.Checked = False
        RAD_OPT2.Checked = False
        RAD_OPT3.Checked = False
        RAD_OPT4.Checked = False
        txt_answer.Text = String.Empty
    End Sub
    Private Sub validarRespuesta()
        Dim bandera As Boolean = False
        If Pregunta.SelMultiple Then
            If RAD_OPT1.Checked Then
                bandera = PreguntasLogica.VerificarRespuesta(RAD_OPT1.Text, Pregunta)
            End If
            If RAD_OPT2.Checked Then
                bandera = PreguntasLogica.VerificarRespuesta(RAD_OPT2.Text, Pregunta)
            End If
            If RAD_OPT3.Checked Then
                bandera = PreguntasLogica.VerificarRespuesta(RAD_OPT3.Text, Pregunta)
            End If
            If RAD_OPT4.Checked Then
                bandera = PreguntasLogica.VerificarRespuesta(RAD_OPT4.Text, Pregunta)
            End If
        Else
            bandera = PreguntasLogica.VerificarRespuesta(txt_answer.Text, Pregunta)
        End If
        If bandera Then
            MessageBox.Show("Respuesta Correcta")
            Correctas += 1
        Else
            Dim resCorrecta As String = Pregunta.RespuestasList.FirstOrDefault(Function(S) S.Correcta = True).Descripcion
            MessageBox.Show("Respuesta incorrecta, la respuesta correcta es '" & resCorrecta & "'")
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If time > 0 Then
            time = time - 1
            lbl_time.Text = time
        Else
            Timer1.Enabled = False
        End If
        If time = 0 Then
            time = 10
            Timer1.Stop()
            MessageBox.Show("Tiempo agotado")
            btn_next_Click(New Object, New EventArgs)
            Timer1.Start()
        End If
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs)
        Dim a As FRM_PROF = New FRM_PROF()
        a.Show()
    End Sub

    Private Sub InicioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InicioToolStripMenuItem.Click
        Dim ventana As frm_prin = New frm_prin()
        ventana.Show()
        Me.Close()
    End Sub

    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub
End Class
