<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_PROF
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.cbxTipoPregunta = New System.Windows.Forms.ComboBox()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.btn_volver = New System.Windows.Forms.Button()
        Me.gbxPreguntas = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_question = New System.Windows.Forms.TextBox()
        Me.GP_SU = New System.Windows.Forms.GroupBox()
        Me.txt_D = New System.Windows.Forms.TextBox()
        Me.txt_C = New System.Windows.Forms.TextBox()
        Me.txt_B = New System.Windows.Forms.TextBox()
        Me.txt_A = New System.Windows.Forms.TextBox()
        Me.rbtnD = New System.Windows.Forms.RadioButton()
        Me.rbtnC = New System.Windows.Forms.RadioButton()
        Me.rbtnB = New System.Windows.Forms.RadioButton()
        Me.rbtnA = New System.Windows.Forms.RadioButton()
        Me.GP_DESA = New System.Windows.Forms.GroupBox()
        Me.LST_ANSW = New System.Windows.Forms.ListBox()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.txt_answer = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gbxPareo = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblIzqPareo5 = New System.Windows.Forms.TextBox()
        Me.lblIzqPareo4 = New System.Windows.Forms.TextBox()
        Me.lblIzqPareo3 = New System.Windows.Forms.TextBox()
        Me.lblIzqPareo2 = New System.Windows.Forms.TextBox()
        Me.lblIzqPareo1 = New System.Windows.Forms.TextBox()
        Me.lblDerPareo5 = New System.Windows.Forms.TextBox()
        Me.lblDerPareo4 = New System.Windows.Forms.TextBox()
        Me.lblDerPareo3 = New System.Windows.Forms.TextBox()
        Me.lblDerPareo2 = New System.Windows.Forms.TextBox()
        Me.lblDerPareo1 = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerUsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerPreguntasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarProfesorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerGraficoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.gbxPreguntas.SuspendLayout()
        Me.GP_SU.SuspendLayout()
        Me.GP_DESA.SuspendLayout()
        Me.gbxPareo.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbxTipoPregunta
        '
        Me.cbxTipoPregunta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbxTipoPregunta.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxTipoPregunta.FormattingEnabled = True
        Me.cbxTipoPregunta.Items.AddRange(New Object() {"Selección Única", "Desarrollo", "Pareo"})
        Me.cbxTipoPregunta.Location = New System.Drawing.Point(113, 37)
        Me.cbxTipoPregunta.Name = "cbxTipoPregunta"
        Me.cbxTipoPregunta.Size = New System.Drawing.Size(140, 21)
        Me.cbxTipoPregunta.TabIndex = 2
        '
        'btn_agregar
        '
        Me.btn_agregar.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_agregar.Location = New System.Drawing.Point(599, 367)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(87, 40)
        Me.btn_agregar.TabIndex = 5
        Me.btn_agregar.Text = "Agregar Pregunta"
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'btn_volver
        '
        Me.btn_volver.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_volver.Location = New System.Drawing.Point(6, 384)
        Me.btn_volver.Name = "btn_volver"
        Me.btn_volver.Size = New System.Drawing.Size(87, 23)
        Me.btn_volver.TabIndex = 6
        Me.btn_volver.Text = "Volver"
        Me.btn_volver.UseVisualStyleBackColor = True
        '
        'gbxPreguntas
        '
        Me.gbxPreguntas.Controls.Add(Me.Label1)
        Me.gbxPreguntas.Controls.Add(Me.txt_question)
        Me.gbxPreguntas.Controls.Add(Me.GP_SU)
        Me.gbxPreguntas.Controls.Add(Me.GP_DESA)
        Me.gbxPreguntas.Location = New System.Drawing.Point(698, 40)
        Me.gbxPreguntas.Name = "gbxPreguntas"
        Me.gbxPreguntas.Size = New System.Drawing.Size(680, 286)
        Me.gbxPreguntas.TabIndex = 8
        Me.gbxPreguntas.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Encabezado"
        '
        'txt_question
        '
        Me.txt_question.Location = New System.Drawing.Point(6, 32)
        Me.txt_question.Multiline = True
        Me.txt_question.Name = "txt_question"
        Me.txt_question.Size = New System.Drawing.Size(668, 81)
        Me.txt_question.TabIndex = 1
        '
        'GP_SU
        '
        Me.GP_SU.Controls.Add(Me.txt_D)
        Me.GP_SU.Controls.Add(Me.txt_C)
        Me.GP_SU.Controls.Add(Me.txt_B)
        Me.GP_SU.Controls.Add(Me.txt_A)
        Me.GP_SU.Controls.Add(Me.rbtnD)
        Me.GP_SU.Controls.Add(Me.rbtnC)
        Me.GP_SU.Controls.Add(Me.rbtnB)
        Me.GP_SU.Controls.Add(Me.rbtnA)
        Me.GP_SU.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GP_SU.ForeColor = System.Drawing.Color.Black
        Me.GP_SU.Location = New System.Drawing.Point(2, 119)
        Me.GP_SU.Name = "GP_SU"
        Me.GP_SU.Size = New System.Drawing.Size(281, 94)
        Me.GP_SU.TabIndex = 3
        Me.GP_SU.TabStop = False
        Me.GP_SU.Text = "Selección Única"
        '
        'txt_D
        '
        Me.txt_D.Location = New System.Drawing.Point(203, 58)
        Me.txt_D.Name = "txt_D"
        Me.txt_D.Size = New System.Drawing.Size(70, 20)
        Me.txt_D.TabIndex = 5
        '
        'txt_C
        '
        Me.txt_C.Location = New System.Drawing.Point(203, 19)
        Me.txt_C.Name = "txt_C"
        Me.txt_C.Size = New System.Drawing.Size(70, 20)
        Me.txt_C.TabIndex = 5
        '
        'txt_B
        '
        Me.txt_B.Location = New System.Drawing.Point(52, 58)
        Me.txt_B.Name = "txt_B"
        Me.txt_B.Size = New System.Drawing.Size(80, 20)
        Me.txt_B.TabIndex = 5
        '
        'txt_A
        '
        Me.txt_A.Location = New System.Drawing.Point(52, 19)
        Me.txt_A.Name = "txt_A"
        Me.txt_A.Size = New System.Drawing.Size(80, 20)
        Me.txt_A.TabIndex = 5
        '
        'rbtnD
        '
        Me.rbtnD.AutoSize = True
        Me.rbtnD.Location = New System.Drawing.Point(157, 61)
        Me.rbtnD.Name = "rbtnD"
        Me.rbtnD.Size = New System.Drawing.Size(33, 17)
        Me.rbtnD.TabIndex = 3
        Me.rbtnD.TabStop = True
        Me.rbtnD.Text = "D"
        Me.rbtnD.UseVisualStyleBackColor = True
        '
        'rbtnC
        '
        Me.rbtnC.AutoSize = True
        Me.rbtnC.Location = New System.Drawing.Point(156, 19)
        Me.rbtnC.Name = "rbtnC"
        Me.rbtnC.Size = New System.Drawing.Size(34, 17)
        Me.rbtnC.TabIndex = 2
        Me.rbtnC.Text = "C"
        Me.rbtnC.UseVisualStyleBackColor = True
        '
        'rbtnB
        '
        Me.rbtnB.AutoSize = True
        Me.rbtnB.Location = New System.Drawing.Point(7, 61)
        Me.rbtnB.Name = "rbtnB"
        Me.rbtnB.Size = New System.Drawing.Size(33, 17)
        Me.rbtnB.TabIndex = 1
        Me.rbtnB.TabStop = True
        Me.rbtnB.Text = "B"
        Me.rbtnB.UseVisualStyleBackColor = True
        '
        'rbtnA
        '
        Me.rbtnA.AutoSize = True
        Me.rbtnA.Location = New System.Drawing.Point(7, 19)
        Me.rbtnA.Name = "rbtnA"
        Me.rbtnA.Size = New System.Drawing.Size(33, 17)
        Me.rbtnA.TabIndex = 0
        Me.rbtnA.TabStop = True
        Me.rbtnA.Text = "A"
        Me.rbtnA.UseVisualStyleBackColor = True
        '
        'GP_DESA
        '
        Me.GP_DESA.Controls.Add(Me.LST_ANSW)
        Me.GP_DESA.Controls.Add(Me.btn_delete)
        Me.GP_DESA.Controls.Add(Me.btn_add)
        Me.GP_DESA.Controls.Add(Me.txt_answer)
        Me.GP_DESA.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GP_DESA.Location = New System.Drawing.Point(289, 119)
        Me.GP_DESA.Name = "GP_DESA"
        Me.GP_DESA.Size = New System.Drawing.Size(400, 151)
        Me.GP_DESA.TabIndex = 4
        Me.GP_DESA.TabStop = False
        Me.GP_DESA.Text = "Desarrollo"
        '
        'LST_ANSW
        '
        Me.LST_ANSW.FormattingEnabled = True
        Me.LST_ANSW.Location = New System.Drawing.Point(7, 50)
        Me.LST_ANSW.Name = "LST_ANSW"
        Me.LST_ANSW.Size = New System.Drawing.Size(292, 95)
        Me.LST_ANSW.TabIndex = 3
        '
        'btn_delete
        '
        Me.btn_delete.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.Location = New System.Drawing.Point(305, 55)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(87, 23)
        Me.btn_delete.TabIndex = 2
        Me.btn_delete.Text = "Borrar"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_add
        '
        Me.btn_add.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.Location = New System.Drawing.Point(305, 19)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(87, 23)
        Me.btn_add.TabIndex = 1
        Me.btn_add.Text = "Agregar"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'txt_answer
        '
        Me.txt_answer.Location = New System.Drawing.Point(7, 19)
        Me.txt_answer.Name = "txt_answer"
        Me.txt_answer.Size = New System.Drawing.Size(292, 20)
        Me.txt_answer.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Tipo de Pregunta"
        '
        'gbxPareo
        '
        Me.gbxPareo.Controls.Add(Me.Label5)
        Me.gbxPareo.Controls.Add(Me.Label4)
        Me.gbxPareo.Controls.Add(Me.Label3)
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
        Me.gbxPareo.Location = New System.Drawing.Point(12, 65)
        Me.gbxPareo.Name = "gbxPareo"
        Me.gbxPareo.Size = New System.Drawing.Size(680, 286)
        Me.gbxPareo.TabIndex = 14
        Me.gbxPareo.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(145, 270)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(353, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "El Valor de la columna A, se asociara con el Valor de la Columna B"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(481, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Columna B"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Columna A"
        '
        'lblIzqPareo5
        '
        Me.lblIzqPareo5.Location = New System.Drawing.Point(9, 244)
        Me.lblIzqPareo5.Name = "lblIzqPareo5"
        Me.lblIzqPareo5.Size = New System.Drawing.Size(147, 20)
        Me.lblIzqPareo5.TabIndex = 9
        '
        'lblIzqPareo4
        '
        Me.lblIzqPareo4.Location = New System.Drawing.Point(9, 186)
        Me.lblIzqPareo4.Name = "lblIzqPareo4"
        Me.lblIzqPareo4.Size = New System.Drawing.Size(147, 20)
        Me.lblIzqPareo4.TabIndex = 8
        '
        'lblIzqPareo3
        '
        Me.lblIzqPareo3.Location = New System.Drawing.Point(9, 134)
        Me.lblIzqPareo3.Name = "lblIzqPareo3"
        Me.lblIzqPareo3.Size = New System.Drawing.Size(147, 20)
        Me.lblIzqPareo3.TabIndex = 7
        '
        'lblIzqPareo2
        '
        Me.lblIzqPareo2.Location = New System.Drawing.Point(9, 80)
        Me.lblIzqPareo2.Name = "lblIzqPareo2"
        Me.lblIzqPareo2.Size = New System.Drawing.Size(147, 20)
        Me.lblIzqPareo2.TabIndex = 6
        '
        'lblIzqPareo1
        '
        Me.lblIzqPareo1.Location = New System.Drawing.Point(9, 26)
        Me.lblIzqPareo1.Name = "lblIzqPareo1"
        Me.lblIzqPareo1.Size = New System.Drawing.Size(147, 20)
        Me.lblIzqPareo1.TabIndex = 5
        '
        'lblDerPareo5
        '
        Me.lblDerPareo5.Location = New System.Drawing.Point(484, 244)
        Me.lblDerPareo5.Name = "lblDerPareo5"
        Me.lblDerPareo5.Size = New System.Drawing.Size(147, 20)
        Me.lblDerPareo5.TabIndex = 4
        '
        'lblDerPareo4
        '
        Me.lblDerPareo4.Location = New System.Drawing.Point(484, 186)
        Me.lblDerPareo4.Name = "lblDerPareo4"
        Me.lblDerPareo4.Size = New System.Drawing.Size(147, 20)
        Me.lblDerPareo4.TabIndex = 3
        '
        'lblDerPareo3
        '
        Me.lblDerPareo3.Location = New System.Drawing.Point(484, 132)
        Me.lblDerPareo3.Name = "lblDerPareo3"
        Me.lblDerPareo3.Size = New System.Drawing.Size(147, 20)
        Me.lblDerPareo3.TabIndex = 2
        '
        'lblDerPareo2
        '
        Me.lblDerPareo2.Location = New System.Drawing.Point(484, 80)
        Me.lblDerPareo2.Name = "lblDerPareo2"
        Me.lblDerPareo2.Size = New System.Drawing.Size(147, 20)
        Me.lblDerPareo2.TabIndex = 1
        '
        'lblDerPareo1
        '
        Me.lblDerPareo1.Location = New System.Drawing.Point(484, 26)
        Me.lblDerPareo1.Name = "lblDerPareo1"
        Me.lblDerPareo1.Size = New System.Drawing.Size(147, 20)
        Me.lblDerPareo1.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(707, 24)
        Me.MenuStrip1.TabIndex = 15
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerUsuariosToolStripMenuItem, Me.VerPreguntasToolStripMenuItem, Me.AgregarProfesorToolStripMenuItem, Me.VerGraficoToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'VerUsuariosToolStripMenuItem
        '
        Me.VerUsuariosToolStripMenuItem.Name = "VerUsuariosToolStripMenuItem"
        Me.VerUsuariosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.VerUsuariosToolStripMenuItem.Text = "Ver Usuarios"
        '
        'VerPreguntasToolStripMenuItem
        '
        Me.VerPreguntasToolStripMenuItem.Name = "VerPreguntasToolStripMenuItem"
        Me.VerPreguntasToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.VerPreguntasToolStripMenuItem.Text = "Ver Preguntas"
        '
        'AgregarProfesorToolStripMenuItem
        '
        Me.AgregarProfesorToolStripMenuItem.Name = "AgregarProfesorToolStripMenuItem"
        Me.AgregarProfesorToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AgregarProfesorToolStripMenuItem.Text = "Agregar Profesor"
        '
        'VerGraficoToolStripMenuItem
        '
        Me.VerGraficoToolStripMenuItem.Name = "VerGraficoToolStripMenuItem"
        Me.VerGraficoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.VerGraficoToolStripMenuItem.Text = "Ver Grafico"
        '
        'FRM_PROF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(707, 416)
        Me.Controls.Add(Me.gbxPareo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.gbxPreguntas)
        Me.Controls.Add(Me.btn_volver)
        Me.Controls.Add(Me.btn_agregar)
        Me.Controls.Add(Me.cbxTipoPregunta)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FRM_PROF"
        Me.Text = "Profesor"
        Me.gbxPreguntas.ResumeLayout(False)
        Me.gbxPreguntas.PerformLayout()
        Me.GP_SU.ResumeLayout(False)
        Me.GP_SU.PerformLayout()
        Me.GP_DESA.ResumeLayout(False)
        Me.GP_DESA.PerformLayout()
        Me.gbxPareo.ResumeLayout(False)
        Me.gbxPareo.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbxTipoPregunta As ComboBox
    Friend WithEvents btn_agregar As Button
    Friend WithEvents btn_volver As Button
    Private WithEvents gbxPreguntas As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_question As TextBox
    Friend WithEvents GP_SU As GroupBox
    Friend WithEvents txt_D As TextBox
    Friend WithEvents txt_C As TextBox
    Friend WithEvents txt_B As TextBox
    Friend WithEvents txt_A As TextBox
    Friend WithEvents rbtnD As RadioButton
    Friend WithEvents rbtnC As RadioButton
    Friend WithEvents rbtnB As RadioButton
    Friend WithEvents rbtnA As RadioButton
    Friend WithEvents GP_DESA As GroupBox
    Friend WithEvents LST_ANSW As ListBox
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_add As Button
    Friend WithEvents txt_answer As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents gbxPareo As GroupBox
    Friend WithEvents lblIzqPareo5 As TextBox
    Friend WithEvents lblIzqPareo4 As TextBox
    Friend WithEvents lblIzqPareo3 As TextBox
    Friend WithEvents lblIzqPareo2 As TextBox
    Friend WithEvents lblIzqPareo1 As TextBox
    Friend WithEvents lblDerPareo5 As TextBox
    Friend WithEvents lblDerPareo4 As TextBox
    Friend WithEvents lblDerPareo3 As TextBox
    Friend WithEvents lblDerPareo2 As TextBox
    Friend WithEvents lblDerPareo1 As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerUsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents VerPreguntasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarProfesorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerGraficoToolStripMenuItem As ToolStripMenuItem
End Class
