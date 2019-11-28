Imports DTOS
Imports Logica

Public Class FRM_MAIN
    Dim tooltipProgress As ToolTip = New ToolTip()
    Const TextoComplete As String = "Adivinanzas." & vbNewLine & "En esta sección se pretende evaluar la capacidad de pensamiento lateral del estudiante. una única respuesta correcta."
    Const TextoSeleccionUnica As String = "Selección Única." & vbNewLine & "Por favor responder a cada pregunta seleccionando una de las opciones mostradas para cada pregunta respectivamente." & vbNewLine & "Solo una respuesta es correcta."
    Const TextoPareo As String = "En las opciones desplegables de la columna A se muestran los valores de la Columna B." & vbNewLine & "Seleccione la opcion que concidere que es la correcta, para el valor correspondiente de la Columna A"
    Dim time As Integer = 90
    Dim Pregunta As DTOS.Pregunta
    Public Usuario As DTOS.Usuario
    Dim Correctas As Integer = 0
    Dim respuestas As List(Of DTOS.RespuestaXSesion) = New List(Of DTOS.RespuestaXSesion)
    Dim SesionGuardada As Boolean = False
    Function GuardarSesion() As Boolean
        Dim sesion As Sesion = New Sesion()
        sesion.MaxPreguntas = pgsbProcesso.Maximum
        sesion.ContadorRespuestas = GlobalClass.PreguntaPos
        sesion.UsuarioId = Usuario.Id
        sesion.RespuestasSesion = respuestas
        Return Logica.SesionLogica.InsertarSesion(sesion)
    End Function
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
            gbxPareo.Visible = True
            gpbxResp.Visible = False

            lbl_instruction.Text = TextoPareo

            cbxParResp1.DataSource = GlobalClass.AleatorioIList(Of DTOS.Respuesta)(Pregunta.RespuestasList)
            cbxParResp1.ValueMember = "Id"
            cbxParResp1.DisplayMember = "Descripcion"

            cbxParResp2.DataSource = GlobalClass.AleatorioIList(Of DTOS.Respuesta)(Pregunta.RespuestasList)
            cbxParResp2.ValueMember = "Id"
            cbxParResp2.DisplayMember = "Descripcion"

            cbxParResp3.DataSource = GlobalClass.AleatorioIList(Of DTOS.Respuesta)(Pregunta.RespuestasList)
            cbxParResp3.ValueMember = "Id"
            cbxParResp3.DisplayMember = "Descripcion"

            cbxParResp4.DataSource = GlobalClass.AleatorioIList(Of DTOS.Respuesta)(Pregunta.RespuestasList)
            cbxParResp4.ValueMember = "Id"
            cbxParResp4.DisplayMember = "Descripcion"

            cbxParResp5.DataSource = GlobalClass.AleatorioIList(Of DTOS.Respuesta)(Pregunta.RespuestasList)
            cbxParResp5.ValueMember = "Id"
            cbxParResp5.DisplayMember = "Descripcion"

            lblDerPareo1.Text = Pregunta.RespuestasList(0).Descripcion
            lblDerPareo2.Text = Pregunta.RespuestasList(1).Descripcion
            lblDerPareo3.Text = Pregunta.RespuestasList(2).Descripcion
            lblDerPareo4.Text = Pregunta.RespuestasList(3).Descripcion
            lblDerPareo5.Text = Pregunta.RespuestasList(4).Descripcion


            lblIzqPareo1.Text = Pregunta.PreguntaPareo(0).Descripcion
            lblIzqPareo2.Text = Pregunta.PreguntaPareo(1).Descripcion
            lblIzqPareo3.Text = Pregunta.PreguntaPareo(2).Descripcion
            lblIzqPareo4.Text = Pregunta.PreguntaPareo(3).Descripcion
            lblIzqPareo5.Text = Pregunta.PreguntaPareo(4).Descripcion
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
        lblUsuario.Text = Usuario.Nombre

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
                lblProgreso.Visible = False
                pgsbProcesso.Visible = False
                lblNota.Text = "Nota:" & CalcularNota()
                lblTimeStatic.Visible = False
                lbl_time.Visible = False
                MsgBox("Completado, su puntaje es de " & CalcularNota() & " puntos", MsgBoxStyle.OkOnly, "Información")
                SesionGuardada = GuardarSesion()
            Else
                ObtenerSiguientePregunta()
                time = 90
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
        Dim b1, b2, b3, b4, b5 As Boolean
        If Not Pregunta.Pareo Then
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
        Else
            b1 = PreguntasLogica.VerificarRespuesta(CType(cbxParResp1.SelectedItem, DTOS.Respuesta).Descripcion, Pregunta, 0)
            If b1 Then
                MessageBox.Show(Pregunta.PreguntaPareo(0).Descripcion & " - Respuesta Correcta")
            Else
                MessageBox.Show(Pregunta.PreguntaPareo(0).Descripcion & " - Respuesta incorrecta, la respuesta correcta es '" & Pregunta.PreguntaPareo(0).Respuesta.Descripcion & "'")
            End If
            b2 = PreguntasLogica.VerificarRespuesta(CType(cbxParResp2.SelectedItem, DTOS.Respuesta).Descripcion, Pregunta, 1)
            If b2 Then
                MessageBox.Show(Pregunta.PreguntaPareo(1).Descripcion & " - Respuesta Correcta")
            Else
                MessageBox.Show(Pregunta.PreguntaPareo(1).Descripcion & " - Respuesta incorrecta, la respuesta correcta es '" & Pregunta.PreguntaPareo(1).Respuesta.Descripcion & "'")
            End If
            b3 = PreguntasLogica.VerificarRespuesta(CType(cbxParResp3.SelectedItem, DTOS.Respuesta).Descripcion, Pregunta, 2)
            If b3 Then
                MessageBox.Show(Pregunta.PreguntaPareo(2).Descripcion & " - Respuesta Correcta")
            Else
                MessageBox.Show(Pregunta.PreguntaPareo(2).Descripcion & " - Respuesta incorrecta, la respuesta correcta es '" & Pregunta.PreguntaPareo(2).Respuesta.Descripcion & "'")
            End If
            b4 = PreguntasLogica.VerificarRespuesta(CType(cbxParResp4.SelectedItem, DTOS.Respuesta).Descripcion, Pregunta, 3)
            If b4 Then
                MessageBox.Show(Pregunta.PreguntaPareo(3).Descripcion & " - Respuesta Correcta")
            Else
                MessageBox.Show(Pregunta.PreguntaPareo(3).Descripcion & " - Respuesta incorrecta, la respuesta correcta es '" & Pregunta.PreguntaPareo(3).Respuesta.Descripcion & "'")
            End If
            b5 = PreguntasLogica.VerificarRespuesta(CType(cbxParResp5.SelectedItem, DTOS.Respuesta).Descripcion, Pregunta, 4)
            If b5 Then
                MessageBox.Show(Pregunta.PreguntaPareo(4).Descripcion & " - Respuesta Correcta")
            Else
                MessageBox.Show(Pregunta.PreguntaPareo(4).Descripcion & " - Respuesta incorrecta, la respuesta correcta es '" & Pregunta.PreguntaPareo(4).Respuesta.Descripcion & "'")
            End If
        End If

        Dim res As DTOS.RespuestaXSesion = New DTOS.RespuestaXSesion()
        If (bandera) Or (b1 And b2 And b3 And b4 And b5) Then
            res.Correcta = True
        Else
            res.Correcta = False
        End If
        res.PreguntaId = Pregunta.Id
        respuestas.Add(res)
    End Sub
    Function intATime(ByVal time As Integer) As String
        Dim min As Integer = Math.Floor(time / 60)
        Dim sec As Integer = (time Mod 60)
        Dim rtn As String
        rtn += min.ToString().PadLeft(2, "0") & ":"
        rtn += sec.ToString().PadLeft(2, "0")
        Return rtn
    End Function
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If time > 0 Then
            time = time - 1
            lbl_time.Text = intATime(time)
        Else
            Timer1.Enabled = False
        End If
        If time = 0 Then
            time = 90
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
    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs) Handles lblTimeStatic.Click

    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub FRM_MAIN_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        'Application.Exit()
        If Not SesionGuardada Then
            GuardarSesion()
        End If
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)
    End Sub
End Class
