Imports DTOS
Imports Logica

Public Class FRM_MAIN
    Const TextoComplete As String = "Adivinanzas." & vbNewLine & "En esta sección se pretende evaluar la capacidad de pensamiento lateral del estudiante. una única respuesta correcta."
    Const TextoSeleccionUnica As String = "Selección Única." & vbNewLine & "Por favor responder a cada pregunta seleccionando una de las opciones mostradas para cada pregunta respectivamente." & vbNewLine & "Solo una respuesta es correcta."
    Dim time As Integer = 10
    Dim Pregunta As DTOS.Pregunta
    Dim Correctas As Integer = 0
    Sub ObtenerSiguientePregunta()
        Pregunta = GlobalClass.ListaPreguntaOrdenada.Item(GlobalClass.PreguntaPos)
        If Pregunta.SelMultiple Then
            lbl_instruction.Text = TextoSeleccionUnica
            GP_Q_A.Visible = True
            gpbxComplete.Visible = False
            txtPreguntaSU.Text = GlobalClass.PreguntaPos + 1 & "). " & Pregunta.Descripcion
            RAD_OPT1.Text = Pregunta.RespuestasList(0).Descripcion
            RAD_OPT2.Text = Pregunta.RespuestasList(1).Descripcion
            RAD_OPT3.Text = Pregunta.RespuestasList(2).Descripcion
            RAD_OPT4.Text = Pregunta.RespuestasList(3).Descripcion
        Else
            lbl_instruction.Text = TextoComplete
            GP_Q_A.Visible = False
            gpbxComplete.Visible = True
            txt_adivinanza.Text = GlobalClass.PreguntaPos + 1 & "). " & Pregunta.Descripcion
        End If
    End Sub

    Private Sub FontDialog1_Apply(sender As Object, e As EventArgs)

    End Sub

    Private Sub lbl_adivinanza_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lbl_instruction_Click(sender As Object, e As EventArgs) Handles lbl_instruction.Click

    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GlobalClass.ListaPreguntaOrdenada = PreguntasLogica.ObtenerPreguntas()
        ObtenerSiguientePregunta()
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = GlobalClass.ListaPreguntaOrdenada.Count
        ProgressBar1.Value = 0

    End Sub

    Private Sub btn_next_Click(sender As Object, e As EventArgs) Handles btn_next.Click
        time = 10
        Timer1.Stop()
        GlobalClass.PreguntaPos += 1
        validarRespuesta()
        If ProgressBar1.Value < ProgressBar1.Maximum Then
            ProgressBar1.Value += 1
            If ProgressBar1.Value = ProgressBar1.Maximum Then
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
        Dim nota As Decimal = (100 / ProgressBar1.Maximum) * Correctas



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

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Dim a As FRM_PROF = New FRM_PROF()
        a.Show()
    End Sub
End Class
