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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_MAIN))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.lbl_instruction = New System.Windows.Forms.Label()
        Me.btn_next = New System.Windows.Forms.Button()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lbl_time = New System.Windows.Forms.Label()
        Me.gpbxComplete = New System.Windows.Forms.GroupBox()
        Me.txt_adivinanza = New System.Windows.Forms.RichTextBox()
        Me.lblRespuesta = New System.Windows.Forms.Label()
        Me.txt_answer = New System.Windows.Forms.TextBox()
        Me.GP_Q_A = New System.Windows.Forms.GroupBox()
        Me.txtPreguntaSU = New System.Windows.Forms.RichTextBox()
        Me.RAD_OPT4 = New System.Windows.Forms.RadioButton()
        Me.RAD_OPT3 = New System.Windows.Forms.RadioButton()
        Me.RAD_OPT1 = New System.Windows.Forms.RadioButton()
        Me.RAD_OPT2 = New System.Windows.Forms.RadioButton()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbxComplete.SuspendLayout()
        Me.GP_Q_A.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-7, -6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1090, 500)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.SystemColors.Window
        Me.lbl_title.Font = New System.Drawing.Font("Times New Roman", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Image = CType(resources.GetObject("lbl_title.Image"), System.Drawing.Image)
        Me.lbl_title.Location = New System.Drawing.Point(397, 42)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(102, 24)
        Me.lbl_title.TabIndex = 1
        Me.lbl_title.Text = "Desarrollo"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.SystemColors.Window
        Me.ProgressBar1.ForeColor = System.Drawing.SystemColors.Window
        Me.ProgressBar1.Location = New System.Drawing.Point(759, 31)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(117, 23)
        Me.ProgressBar1.TabIndex = 2
        '
        'lbl_instruction
        '
        Me.lbl_instruction.AutoSize = True
        Me.lbl_instruction.BackColor = System.Drawing.SystemColors.Window
        Me.lbl_instruction.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_instruction.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_instruction.Image = CType(resources.GetObject("lbl_instruction.Image"), System.Drawing.Image)
        Me.lbl_instruction.Location = New System.Drawing.Point(120, 105)
        Me.lbl_instruction.Name = "lbl_instruction"
        Me.lbl_instruction.Size = New System.Drawing.Size(618, 32)
        Me.lbl_instruction.TabIndex = 4
        Me.lbl_instruction.Text = "Adivinanzas. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "En esta sección se pretende evaluar la capacidad de pensamiento la" &
    "teral del estudiante. una única respuesta correcta." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btn_next
        '
        Me.btn_next.BackColor = System.Drawing.SystemColors.Window
        Me.btn_next.Cursor = System.Windows.Forms.Cursors.AppStarting
        Me.btn_next.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_next.Location = New System.Drawing.Point(521, 413)
        Me.btn_next.Name = "btn_next"
        Me.btn_next.Size = New System.Drawing.Size(87, 23)
        Me.btn_next.TabIndex = 6
        Me.btn_next.Text = "Siguiente"
        Me.btn_next.UseVisualStyleBackColor = False
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.SystemColors.Window
        Me.btn_back.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.Location = New System.Drawing.Point(274, 413)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(87, 23)
        Me.btn_back.TabIndex = 7
        Me.btn_back.Text = "Menú"
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'lbl_time
        '
        Me.lbl_time.AutoSize = True
        Me.lbl_time.BackColor = System.Drawing.SystemColors.Window
        Me.lbl_time.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_time.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lbl_time.Image = CType(resources.GetObject("lbl_time.Image"), System.Drawing.Image)
        Me.lbl_time.Location = New System.Drawing.Point(132, 31)
        Me.lbl_time.Name = "lbl_time"
        Me.lbl_time.Size = New System.Drawing.Size(24, 15)
        Me.lbl_time.TabIndex = 8
        Me.lbl_time.Text = "     "
        '
        'gpbxComplete
        '
        Me.gpbxComplete.Controls.Add(Me.txt_adivinanza)
        Me.gpbxComplete.Controls.Add(Me.lblRespuesta)
        Me.gpbxComplete.Controls.Add(Me.txt_answer)
        Me.gpbxComplete.Location = New System.Drawing.Point(120, 140)
        Me.gpbxComplete.Name = "gpbxComplete"
        Me.gpbxComplete.Size = New System.Drawing.Size(618, 190)
        Me.gpbxComplete.TabIndex = 10
        Me.gpbxComplete.TabStop = False
        '
        'txt_adivinanza
        '
        Me.txt_adivinanza.BackColor = System.Drawing.SystemColors.Window
        Me.txt_adivinanza.Enabled = False
        Me.txt_adivinanza.Location = New System.Drawing.Point(6, 17)
        Me.txt_adivinanza.Name = "txt_adivinanza"
        Me.txt_adivinanza.Size = New System.Drawing.Size(600, 96)
        Me.txt_adivinanza.TabIndex = 14
        Me.txt_adivinanza.Text = ""
        '
        'lblRespuesta
        '
        Me.lblRespuesta.AutoSize = True
        Me.lblRespuesta.Location = New System.Drawing.Point(3, 166)
        Me.lblRespuesta.Name = "lblRespuesta"
        Me.lblRespuesta.Size = New System.Drawing.Size(65, 13)
        Me.lblRespuesta.TabIndex = 13
        Me.lblRespuesta.Text = "Respuestas"
        '
        'txt_answer
        '
        Me.txt_answer.Location = New System.Drawing.Point(74, 163)
        Me.txt_answer.Name = "txt_answer"
        Me.txt_answer.Size = New System.Drawing.Size(532, 20)
        Me.txt_answer.TabIndex = 12
        '
        'GP_Q_A
        '
        Me.GP_Q_A.BackgroundImage = CType(resources.GetObject("GP_Q_A.BackgroundImage"), System.Drawing.Image)
        Me.GP_Q_A.Controls.Add(Me.txtPreguntaSU)
        Me.GP_Q_A.Controls.Add(Me.RAD_OPT4)
        Me.GP_Q_A.Controls.Add(Me.RAD_OPT3)
        Me.GP_Q_A.Controls.Add(Me.RAD_OPT1)
        Me.GP_Q_A.Controls.Add(Me.RAD_OPT2)
        Me.GP_Q_A.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GP_Q_A.Location = New System.Drawing.Point(114, 157)
        Me.GP_Q_A.Name = "GP_Q_A"
        Me.GP_Q_A.Size = New System.Drawing.Size(618, 190)
        Me.GP_Q_A.TabIndex = 11
        Me.GP_Q_A.TabStop = False
        Me.GP_Q_A.Text = "Selección Única"
        '
        'txtPreguntaSU
        '
        Me.txtPreguntaSU.BackColor = System.Drawing.SystemColors.Window
        Me.txtPreguntaSU.Enabled = False
        Me.txtPreguntaSU.Location = New System.Drawing.Point(6, 19)
        Me.txtPreguntaSU.Name = "txtPreguntaSU"
        Me.txtPreguntaSU.Size = New System.Drawing.Size(600, 96)
        Me.txtPreguntaSU.TabIndex = 15
        Me.txtPreguntaSU.Text = ""
        '
        'RAD_OPT4
        '
        Me.RAD_OPT4.AutoSize = True
        Me.RAD_OPT4.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RAD_OPT4.Location = New System.Drawing.Point(351, 140)
        Me.RAD_OPT4.Name = "RAD_OPT4"
        Me.RAD_OPT4.Size = New System.Drawing.Size(71, 17)
        Me.RAD_OPT4.TabIndex = 4
        Me.RAD_OPT4.TabStop = True
        Me.RAD_OPT4.Text = "Su padre"
        Me.RAD_OPT4.UseVisualStyleBackColor = True
        '
        'RAD_OPT3
        '
        Me.RAD_OPT3.AutoSize = True
        Me.RAD_OPT3.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RAD_OPT3.Location = New System.Drawing.Point(15, 140)
        Me.RAD_OPT3.Name = "RAD_OPT3"
        Me.RAD_OPT3.Size = New System.Drawing.Size(75, 17)
        Me.RAD_OPT3.TabIndex = 2
        Me.RAD_OPT3.TabStop = True
        Me.RAD_OPT3.Text = "Su madre"
        Me.RAD_OPT3.UseVisualStyleBackColor = True
        '
        'RAD_OPT1
        '
        Me.RAD_OPT1.AutoSize = True
        Me.RAD_OPT1.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RAD_OPT1.Location = New System.Drawing.Point(192, 140)
        Me.RAD_OPT1.Name = "RAD_OPT1"
        Me.RAD_OPT1.Size = New System.Drawing.Size(58, 17)
        Me.RAD_OPT1.TabIndex = 0
        Me.RAD_OPT1.TabStop = True
        Me.RAD_OPT1.Text = "Su Tía"
        Me.RAD_OPT1.UseVisualStyleBackColor = True
        '
        'RAD_OPT2
        '
        Me.RAD_OPT2.AutoSize = True
        Me.RAD_OPT2.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RAD_OPT2.Location = New System.Drawing.Point(535, 140)
        Me.RAD_OPT2.Name = "RAD_OPT2"
        Me.RAD_OPT2.Size = New System.Drawing.Size(77, 17)
        Me.RAD_OPT2.TabIndex = 1
        Me.RAD_OPT2.TabStop = True
        Me.RAD_OPT2.Text = "Su abuela"
        Me.RAD_OPT2.UseVisualStyleBackColor = True
        '
        'FRM_MAIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1077, 495)
        Me.Controls.Add(Me.GP_Q_A)
        Me.Controls.Add(Me.gpbxComplete)
        Me.Controls.Add(Me.lbl_time)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.btn_next)
        Me.Controls.Add(Me.lbl_instruction)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FRM_MAIN"
        Me.Text = "Aplicación"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbxComplete.ResumeLayout(False)
        Me.gpbxComplete.PerformLayout()
        Me.GP_Q_A.ResumeLayout(False)
        Me.GP_Q_A.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbl_title As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents lbl_instruction As Label
    Friend WithEvents btn_next As Button
    Friend WithEvents btn_back As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lbl_time As Label
    Friend WithEvents gpbxComplete As GroupBox
    Friend WithEvents lblRespuesta As Label
    Friend WithEvents txt_answer As TextBox
    Friend WithEvents GP_Q_A As GroupBox
    Friend WithEvents RAD_OPT4 As RadioButton
    Friend WithEvents RAD_OPT3 As RadioButton
    Friend WithEvents RAD_OPT1 As RadioButton
    Friend WithEvents RAD_OPT2 As RadioButton
    Friend WithEvents txt_adivinanza As RichTextBox
    Friend WithEvents txtPreguntaSU As RichTextBox
End Class
