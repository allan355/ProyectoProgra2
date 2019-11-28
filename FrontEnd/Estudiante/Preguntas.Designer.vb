<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_MAIN
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lbl_instruction = New System.Windows.Forms.Label()
        Me.btn_next = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.gpbxResp = New System.Windows.Forms.GroupBox()
        Me.gbxComplete = New System.Windows.Forms.GroupBox()
        Me.lblRespuesta = New System.Windows.Forms.Label()
        Me.txt_answer = New System.Windows.Forms.TextBox()
        Me.gbxSU = New System.Windows.Forms.GroupBox()
        Me.RAD_OPT3 = New System.Windows.Forms.RadioButton()
        Me.RAD_OPT4 = New System.Windows.Forms.RadioButton()
        Me.RAD_OPT2 = New System.Windows.Forms.RadioButton()
        Me.RAD_OPT1 = New System.Windows.Forms.RadioButton()
        Me.rhtxtPregunta = New System.Windows.Forms.RichTextBox()
        Me.gbxPareo = New System.Windows.Forms.GroupBox()
        Me.cbxParResp1 = New System.Windows.Forms.ComboBox()
        Me.lblIzqPareo5 = New System.Windows.Forms.Label()
        Me.lblIzqPareo4 = New System.Windows.Forms.Label()
        Me.lblIzqPareo3 = New System.Windows.Forms.Label()
        Me.lblIzqPareo2 = New System.Windows.Forms.Label()
        Me.lblIzqPareo1 = New System.Windows.Forms.Label()
        Me.lblDerPareo5 = New System.Windows.Forms.Label()
        Me.lblDerPareo4 = New System.Windows.Forms.Label()
        Me.lblDerPareo3 = New System.Windows.Forms.Label()
        Me.lblDerPareo2 = New System.Windows.Forms.Label()
        Me.lblDerPareo1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblTimeStatic = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbl_time = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblProgreso = New System.Windows.Forms.ToolStripStatusLabel()
        Me.pgsbProcesso = New System.Windows.Forms.ToolStripProgressBar()
        Me.lblNota = New System.Windows.Forms.ToolStripStatusLabel()
        Me.cbxParResp2 = New System.Windows.Forms.ComboBox()
        Me.cbxParResp3 = New System.Windows.Forms.ComboBox()
        Me.cbxParResp4 = New System.Windows.Forms.ComboBox()
        Me.cbxParResp5 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.gpbxResp.SuspendLayout()
        Me.gbxComplete.SuspendLayout()
        Me.gbxSU.SuspendLayout()
        Me.gbxPareo.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_instruction
        '
        Me.lbl_instruction.AutoSize = True
        Me.lbl_instruction.BackColor = System.Drawing.Color.Transparent
        Me.lbl_instruction.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_instruction.Font = New System.Drawing.Font("MV Boli", 8.25!)
        Me.lbl_instruction.ForeColor = System.Drawing.Color.White
        Me.lbl_instruction.Location = New System.Drawing.Point(18, 70)
        Me.lbl_instruction.Name = "lbl_instruction"
        Me.lbl_instruction.Size = New System.Drawing.Size(613, 34)
        Me.lbl_instruction.TabIndex = 4
        Me.lbl_instruction.Text = "Adivinanzas. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "En esta sección se pretende evaluar la capacidad de pensamiento la" &
    "teral del estudiante. una única respuesta correcta." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btn_next
        '
        Me.btn_next.BackColor = System.Drawing.SystemColors.Window
        Me.btn_next.Cursor = System.Windows.Forms.Cursors.AppStarting
        Me.btn_next.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_next.Location = New System.Drawing.Point(549, 428)
        Me.btn_next.Name = "btn_next"
        Me.btn_next.Size = New System.Drawing.Size(87, 23)
        Me.btn_next.TabIndex = 6
        Me.btn_next.Text = "Siguiente"
        Me.btn_next.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'gpbxResp
        '
        Me.gpbxResp.Controls.Add(Me.gbxComplete)
        Me.gpbxResp.Controls.Add(Me.gbxSU)
        Me.gpbxResp.Controls.Add(Me.rhtxtPregunta)
        Me.gpbxResp.Location = New System.Drawing.Point(642, 146)
        Me.gpbxResp.Name = "gpbxResp"
        Me.gpbxResp.Size = New System.Drawing.Size(618, 190)
        Me.gpbxResp.TabIndex = 10
        Me.gpbxResp.TabStop = False
        '
        'gbxComplete
        '
        Me.gbxComplete.Controls.Add(Me.lblRespuesta)
        Me.gbxComplete.Controls.Add(Me.txt_answer)
        Me.gbxComplete.Location = New System.Drawing.Point(6, 120)
        Me.gbxComplete.Name = "gbxComplete"
        Me.gbxComplete.Size = New System.Drawing.Size(268, 65)
        Me.gbxComplete.TabIndex = 17
        Me.gbxComplete.TabStop = False
        '
        'lblRespuesta
        '
        Me.lblRespuesta.AutoSize = True
        Me.lblRespuesta.Location = New System.Drawing.Point(6, 16)
        Me.lblRespuesta.Name = "lblRespuesta"
        Me.lblRespuesta.Size = New System.Drawing.Size(60, 13)
        Me.lblRespuesta.TabIndex = 15
        Me.lblRespuesta.Text = "Respuesta"
        '
        'txt_answer
        '
        Me.txt_answer.Location = New System.Drawing.Point(9, 35)
        Me.txt_answer.Name = "txt_answer"
        Me.txt_answer.Size = New System.Drawing.Size(253, 20)
        Me.txt_answer.TabIndex = 14
        '
        'gbxSU
        '
        Me.gbxSU.Controls.Add(Me.RAD_OPT3)
        Me.gbxSU.Controls.Add(Me.RAD_OPT4)
        Me.gbxSU.Controls.Add(Me.RAD_OPT2)
        Me.gbxSU.Controls.Add(Me.RAD_OPT1)
        Me.gbxSU.Location = New System.Drawing.Point(280, 119)
        Me.gbxSU.Name = "gbxSU"
        Me.gbxSU.Size = New System.Drawing.Size(326, 65)
        Me.gbxSU.TabIndex = 16
        Me.gbxSU.TabStop = False
        '
        'RAD_OPT3
        '
        Me.RAD_OPT3.AutoSize = True
        Me.RAD_OPT3.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RAD_OPT3.Location = New System.Drawing.Point(8, 19)
        Me.RAD_OPT3.Name = "RAD_OPT3"
        Me.RAD_OPT3.Size = New System.Drawing.Size(14, 13)
        Me.RAD_OPT3.TabIndex = 2
        Me.RAD_OPT3.TabStop = True
        Me.RAD_OPT3.UseVisualStyleBackColor = True
        '
        'RAD_OPT4
        '
        Me.RAD_OPT4.AutoSize = True
        Me.RAD_OPT4.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RAD_OPT4.Location = New System.Drawing.Point(204, 19)
        Me.RAD_OPT4.Name = "RAD_OPT4"
        Me.RAD_OPT4.Size = New System.Drawing.Size(14, 13)
        Me.RAD_OPT4.TabIndex = 4
        Me.RAD_OPT4.TabStop = True
        Me.RAD_OPT4.UseVisualStyleBackColor = True
        '
        'RAD_OPT2
        '
        Me.RAD_OPT2.AutoSize = True
        Me.RAD_OPT2.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RAD_OPT2.Location = New System.Drawing.Point(204, 38)
        Me.RAD_OPT2.Name = "RAD_OPT2"
        Me.RAD_OPT2.Size = New System.Drawing.Size(14, 13)
        Me.RAD_OPT2.TabIndex = 1
        Me.RAD_OPT2.TabStop = True
        Me.RAD_OPT2.UseVisualStyleBackColor = True
        '
        'RAD_OPT1
        '
        Me.RAD_OPT1.AutoSize = True
        Me.RAD_OPT1.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RAD_OPT1.Location = New System.Drawing.Point(8, 38)
        Me.RAD_OPT1.Name = "RAD_OPT1"
        Me.RAD_OPT1.Size = New System.Drawing.Size(14, 13)
        Me.RAD_OPT1.TabIndex = 0
        Me.RAD_OPT1.TabStop = True
        Me.RAD_OPT1.UseVisualStyleBackColor = True
        '
        'rhtxtPregunta
        '
        Me.rhtxtPregunta.BackColor = System.Drawing.Color.Teal
        Me.rhtxtPregunta.Enabled = False
        Me.rhtxtPregunta.ForeColor = System.Drawing.Color.Black
        Me.rhtxtPregunta.Location = New System.Drawing.Point(6, 17)
        Me.rhtxtPregunta.Name = "rhtxtPregunta"
        Me.rhtxtPregunta.Size = New System.Drawing.Size(600, 96)
        Me.rhtxtPregunta.TabIndex = 14
        Me.rhtxtPregunta.Text = ""
        '
        'gbxPareo
        '
        Me.gbxPareo.Controls.Add(Me.cbxParResp5)
        Me.gbxPareo.Controls.Add(Me.cbxParResp4)
        Me.gbxPareo.Controls.Add(Me.cbxParResp3)
        Me.gbxPareo.Controls.Add(Me.cbxParResp2)
        Me.gbxPareo.Controls.Add(Me.cbxParResp1)
        Me.gbxPareo.Controls.Add(Me.lblIzqPareo5)
        Me.gbxPareo.Controls.Add(Me.lblIzqPareo4)
        Me.gbxPareo.Controls.Add(Me.lblIzqPareo3)
        Me.gbxPareo.Controls.Add(Me.lblIzqPareo2)
        Me.gbxPareo.Controls.Add(Me.lblIzqPareo1)
        Me.gbxPareo.Controls.Add(Me.lblDerPareo5)
        Me.gbxPareo.Controls.Add(Me.lblDerPareo4)
        Me.gbxPareo.Controls.Add(Me.lblDerPareo3)
        Me.gbxPareo.Controls.Add(Me.lblDerPareo2)
        Me.gbxPareo.Controls.Add(Me.lblDerPareo1)
        Me.gbxPareo.Location = New System.Drawing.Point(18, 145)
        Me.gbxPareo.Name = "gbxPareo"
        Me.gbxPareo.Size = New System.Drawing.Size(618, 277)
        Me.gbxPareo.TabIndex = 13
        Me.gbxPareo.TabStop = False
        '
        'cbxParResp1
        '
        Me.cbxParResp1.Font = New System.Drawing.Font("MV Boli", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxParResp1.FormattingEnabled = True
        Me.cbxParResp1.Location = New System.Drawing.Point(6, 13)
        Me.cbxParResp1.Name = "cbxParResp1"
        Me.cbxParResp1.Size = New System.Drawing.Size(121, 24)
        Me.cbxParResp1.TabIndex = 10
        '
        'lblIzqPareo5
        '
        Me.lblIzqPareo5.AutoSize = True
        Me.lblIzqPareo5.Font = New System.Drawing.Font("MV Boli", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIzqPareo5.ForeColor = System.Drawing.Color.White
        Me.lblIzqPareo5.Location = New System.Drawing.Point(133, 237)
        Me.lblIzqPareo5.Name = "lblIzqPareo5"
        Me.lblIzqPareo5.Size = New System.Drawing.Size(47, 16)
        Me.lblIzqPareo5.TabIndex = 9
        Me.lblIzqPareo5.Text = "Label7"
        '
        'lblIzqPareo4
        '
        Me.lblIzqPareo4.AutoSize = True
        Me.lblIzqPareo4.Font = New System.Drawing.Font("MV Boli", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIzqPareo4.ForeColor = System.Drawing.Color.White
        Me.lblIzqPareo4.Location = New System.Drawing.Point(133, 179)
        Me.lblIzqPareo4.Name = "lblIzqPareo4"
        Me.lblIzqPareo4.Size = New System.Drawing.Size(47, 16)
        Me.lblIzqPareo4.TabIndex = 8
        Me.lblIzqPareo4.Text = "Label8"
        '
        'lblIzqPareo3
        '
        Me.lblIzqPareo3.AutoSize = True
        Me.lblIzqPareo3.Font = New System.Drawing.Font("MV Boli", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIzqPareo3.ForeColor = System.Drawing.Color.White
        Me.lblIzqPareo3.Location = New System.Drawing.Point(133, 125)
        Me.lblIzqPareo3.Name = "lblIzqPareo3"
        Me.lblIzqPareo3.Size = New System.Drawing.Size(47, 16)
        Me.lblIzqPareo3.TabIndex = 7
        Me.lblIzqPareo3.Text = "Label9"
        '
        'lblIzqPareo2
        '
        Me.lblIzqPareo2.AutoSize = True
        Me.lblIzqPareo2.Font = New System.Drawing.Font("MV Boli", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIzqPareo2.ForeColor = System.Drawing.Color.White
        Me.lblIzqPareo2.Location = New System.Drawing.Point(133, 73)
        Me.lblIzqPareo2.Name = "lblIzqPareo2"
        Me.lblIzqPareo2.Size = New System.Drawing.Size(53, 16)
        Me.lblIzqPareo2.TabIndex = 6
        Me.lblIzqPareo2.Text = "Label10"
        '
        'lblIzqPareo1
        '
        Me.lblIzqPareo1.AutoSize = True
        Me.lblIzqPareo1.Font = New System.Drawing.Font("MV Boli", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIzqPareo1.ForeColor = System.Drawing.Color.White
        Me.lblIzqPareo1.Location = New System.Drawing.Point(133, 16)
        Me.lblIzqPareo1.Name = "lblIzqPareo1"
        Me.lblIzqPareo1.Size = New System.Drawing.Size(49, 16)
        Me.lblIzqPareo1.TabIndex = 5
        Me.lblIzqPareo1.Text = "Label11"
        '
        'lblDerPareo5
        '
        Me.lblDerPareo5.AutoSize = True
        Me.lblDerPareo5.Font = New System.Drawing.Font("MV Boli", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDerPareo5.ForeColor = System.Drawing.Color.White
        Me.lblDerPareo5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblDerPareo5.Location = New System.Drawing.Point(551, 237)
        Me.lblDerPareo5.Name = "lblDerPareo5"
        Me.lblDerPareo5.Size = New System.Drawing.Size(47, 16)
        Me.lblDerPareo5.TabIndex = 4
        Me.lblDerPareo5.Text = "Label6"
        Me.lblDerPareo5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblDerPareo4
        '
        Me.lblDerPareo4.AutoSize = True
        Me.lblDerPareo4.Font = New System.Drawing.Font("MV Boli", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDerPareo4.ForeColor = System.Drawing.Color.White
        Me.lblDerPareo4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblDerPareo4.Location = New System.Drawing.Point(551, 179)
        Me.lblDerPareo4.Name = "lblDerPareo4"
        Me.lblDerPareo4.Size = New System.Drawing.Size(47, 16)
        Me.lblDerPareo4.TabIndex = 3
        Me.lblDerPareo4.Text = "Label5"
        Me.lblDerPareo4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblDerPareo3
        '
        Me.lblDerPareo3.AutoSize = True
        Me.lblDerPareo3.Font = New System.Drawing.Font("MV Boli", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDerPareo3.ForeColor = System.Drawing.Color.White
        Me.lblDerPareo3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblDerPareo3.Location = New System.Drawing.Point(551, 125)
        Me.lblDerPareo3.Name = "lblDerPareo3"
        Me.lblDerPareo3.Size = New System.Drawing.Size(48, 16)
        Me.lblDerPareo3.TabIndex = 2
        Me.lblDerPareo3.Text = "Label4"
        Me.lblDerPareo3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblDerPareo2
        '
        Me.lblDerPareo2.AutoSize = True
        Me.lblDerPareo2.Font = New System.Drawing.Font("MV Boli", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDerPareo2.ForeColor = System.Drawing.Color.White
        Me.lblDerPareo2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblDerPareo2.Location = New System.Drawing.Point(551, 73)
        Me.lblDerPareo2.Name = "lblDerPareo2"
        Me.lblDerPareo2.Size = New System.Drawing.Size(47, 16)
        Me.lblDerPareo2.TabIndex = 1
        Me.lblDerPareo2.Text = "Label3"
        Me.lblDerPareo2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblDerPareo1
        '
        Me.lblDerPareo1.AutoSize = True
        Me.lblDerPareo1.Font = New System.Drawing.Font("MV Boli", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDerPareo1.ForeColor = System.Drawing.Color.White
        Me.lblDerPareo1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblDerPareo1.Location = New System.Drawing.Point(551, 16)
        Me.lblDerPareo1.Name = "lblDerPareo1"
        Me.lblDerPareo1.Size = New System.Drawing.Size(44, 16)
        Me.lblDerPareo1.TabIndex = 0
        Me.lblDerPareo1.Text = "Label1"
        Me.lblDerPareo1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(661, 24)
        Me.MenuStrip1.TabIndex = 14
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'InicioToolStripMenuItem
        '
        Me.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
        Me.InicioToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.InicioToolStripMenuItem.Text = "Inicio"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.StatusStrip1.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblTimeStatic, Me.lbl_time, Me.lblProgreso, Me.pgsbProcesso, Me.lblNota})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 457)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(661, 35)
        Me.StatusStrip1.TabIndex = 15
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblTimeStatic
        '
        Me.lblTimeStatic.Name = "lblTimeStatic"
        Me.lblTimeStatic.Size = New System.Drawing.Size(98, 30)
        Me.lblTimeStatic.Text = "Tiempo: "
        '
        'lbl_time
        '
        Me.lbl_time.Name = "lbl_time"
        Me.lbl_time.Size = New System.Drawing.Size(0, 30)
        '
        'lblProgreso
        '
        Me.lblProgreso.Name = "lblProgreso"
        Me.lblProgreso.Size = New System.Drawing.Size(446, 30)
        Me.lblProgreso.Spring = True
        Me.lblProgreso.Text = "Progreso:"
        Me.lblProgreso.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pgsbProcesso
        '
        Me.pgsbProcesso.Name = "pgsbProcesso"
        Me.pgsbProcesso.Size = New System.Drawing.Size(100, 29)
        '
        'lblNota
        '
        Me.lblNota.Name = "lblNota"
        Me.lblNota.Size = New System.Drawing.Size(0, 30)
        '
        'cbxParResp2
        '
        Me.cbxParResp2.Font = New System.Drawing.Font("MV Boli", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxParResp2.FormattingEnabled = True
        Me.cbxParResp2.Location = New System.Drawing.Point(6, 70)
        Me.cbxParResp2.Name = "cbxParResp2"
        Me.cbxParResp2.Size = New System.Drawing.Size(121, 24)
        Me.cbxParResp2.TabIndex = 11
        '
        'cbxParResp3
        '
        Me.cbxParResp3.Font = New System.Drawing.Font("MV Boli", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxParResp3.FormattingEnabled = True
        Me.cbxParResp3.Location = New System.Drawing.Point(6, 122)
        Me.cbxParResp3.Name = "cbxParResp3"
        Me.cbxParResp3.Size = New System.Drawing.Size(121, 24)
        Me.cbxParResp3.TabIndex = 12
        '
        'cbxParResp4
        '
        Me.cbxParResp4.Font = New System.Drawing.Font("MV Boli", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxParResp4.FormattingEnabled = True
        Me.cbxParResp4.Location = New System.Drawing.Point(6, 176)
        Me.cbxParResp4.Name = "cbxParResp4"
        Me.cbxParResp4.Size = New System.Drawing.Size(121, 24)
        Me.cbxParResp4.TabIndex = 13
        '
        'cbxParResp5
        '
        Me.cbxParResp5.Font = New System.Drawing.Font("MV Boli", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxParResp5.FormattingEnabled = True
        Me.cbxParResp5.Location = New System.Drawing.Point(6, 234)
        Me.cbxParResp5.Name = "cbxParResp5"
        Me.cbxParResp5.Size = New System.Drawing.Size(121, 24)
        Me.cbxParResp5.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MV Boli", 10.25!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(15, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 18)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Usuario:"
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Font = New System.Drawing.Font("MV Boli", 10.25!)
        Me.lblUsuario.ForeColor = System.Drawing.Color.White
        Me.lblUsuario.Location = New System.Drawing.Point(73, 35)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(71, 18)
        Me.lblUsuario.TabIndex = 17
        Me.lblUsuario.Text = "lblUsuario"
        '
        'FRM_MAIN
        '
        Me.AcceptButton = Me.btn_next
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(661, 492)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.gbxPareo)
        Me.Controls.Add(Me.gpbxResp)
        Me.Controls.Add(Me.btn_next)
        Me.Controls.Add(Me.lbl_instruction)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRM_MAIN"
        Me.Text = "Aplicación"
        Me.gpbxResp.ResumeLayout(False)
        Me.gbxComplete.ResumeLayout(False)
        Me.gbxComplete.PerformLayout()
        Me.gbxSU.ResumeLayout(False)
        Me.gbxSU.PerformLayout()
        Me.gbxPareo.ResumeLayout(False)
        Me.gbxPareo.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_instruction As Label
    Friend WithEvents btn_next As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents gpbxResp As GroupBox
    Friend WithEvents RAD_OPT4 As RadioButton
    Friend WithEvents RAD_OPT3 As RadioButton
    Friend WithEvents RAD_OPT1 As RadioButton
    Friend WithEvents RAD_OPT2 As RadioButton
    Friend WithEvents rhtxtPregunta As RichTextBox
    Friend WithEvents gbxComplete As GroupBox
    Friend WithEvents lblRespuesta As Label
    Friend WithEvents txt_answer As TextBox
    Friend WithEvents gbxSU As GroupBox
    Friend WithEvents gbxPareo As GroupBox
    Friend WithEvents lblDerPareo4 As Label
    Friend WithEvents lblDerPareo3 As Label
    Friend WithEvents lblDerPareo2 As Label
    Friend WithEvents lblDerPareo1 As Label
    Friend WithEvents lblIzqPareo5 As Label
    Friend WithEvents lblIzqPareo4 As Label
    Friend WithEvents lblIzqPareo3 As Label
    Friend WithEvents lblIzqPareo2 As Label
    Friend WithEvents lblIzqPareo1 As Label
    Friend WithEvents lblDerPareo5 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InicioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblTimeStatic As ToolStripStatusLabel
    Friend WithEvents lbl_time As ToolStripStatusLabel
    Friend WithEvents lblProgreso As ToolStripStatusLabel
    Friend WithEvents pgsbProcesso As ToolStripProgressBar
    Friend WithEvents cbxParResp1 As ComboBox
    Friend WithEvents lblNota As ToolStripStatusLabel
    Friend WithEvents cbxParResp2 As ComboBox
    Friend WithEvents cbxParResp5 As ComboBox
    Friend WithEvents cbxParResp4 As ComboBox
    Friend WithEvents cbxParResp3 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblUsuario As Label
End Class
