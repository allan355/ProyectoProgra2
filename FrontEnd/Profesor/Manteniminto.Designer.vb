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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_PROF))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txt_question = New System.Windows.Forms.TextBox()
        Me.cbxTipoPregunta = New System.Windows.Forms.ComboBox()
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
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.btn_volver = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GP_SU.SuspendLayout()
        Me.GP_DESA.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-1, -5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(937, 459)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'txt_question
        '
        Me.txt_question.Location = New System.Drawing.Point(259, 49)
        Me.txt_question.Name = "txt_question"
        Me.txt_question.Size = New System.Drawing.Size(368, 20)
        Me.txt_question.TabIndex = 1
        '
        'cbxTipoPregunta
        '
        Me.cbxTipoPregunta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbxTipoPregunta.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxTipoPregunta.FormattingEnabled = True
        Me.cbxTipoPregunta.Items.AddRange(New Object() {"Selección Única", "Desarrollo", "Pareo"})
        Me.cbxTipoPregunta.Location = New System.Drawing.Point(390, 90)
        Me.cbxTipoPregunta.Name = "cbxTipoPregunta"
        Me.cbxTipoPregunta.Size = New System.Drawing.Size(140, 21)
        Me.cbxTipoPregunta.TabIndex = 2
        '
        'GP_SU
        '
        Me.GP_SU.BackgroundImage = CType(resources.GetObject("GP_SU.BackgroundImage"), System.Drawing.Image)
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
        Me.GP_SU.Location = New System.Drawing.Point(92, 125)
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
        Me.GP_DESA.BackgroundImage = CType(resources.GetObject("GP_DESA.BackgroundImage"), System.Drawing.Image)
        Me.GP_DESA.Controls.Add(Me.LST_ANSW)
        Me.GP_DESA.Controls.Add(Me.btn_delete)
        Me.GP_DESA.Controls.Add(Me.btn_add)
        Me.GP_DESA.Controls.Add(Me.txt_answer)
        Me.GP_DESA.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GP_DESA.Location = New System.Drawing.Point(174, 287)
        Me.GP_DESA.Name = "GP_DESA"
        Me.GP_DESA.Size = New System.Drawing.Size(587, 151)
        Me.GP_DESA.TabIndex = 4
        Me.GP_DESA.TabStop = False
        Me.GP_DESA.Text = "Desarrollo"
        '
        'LST_ANSW
        '
        Me.LST_ANSW.FormattingEnabled = True
        Me.LST_ANSW.Location = New System.Drawing.Point(28, 50)
        Me.LST_ANSW.Name = "LST_ANSW"
        Me.LST_ANSW.Size = New System.Drawing.Size(139, 95)
        Me.LST_ANSW.TabIndex = 3
        '
        'btn_delete
        '
        Me.btn_delete.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.Location = New System.Drawing.Point(374, 96)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(87, 23)
        Me.btn_delete.TabIndex = 2
        Me.btn_delete.Text = "Borrar"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_add
        '
        Me.btn_add.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.Location = New System.Drawing.Point(374, 28)
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
        'btn_agregar
        '
        Me.btn_agregar.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_agregar.Location = New System.Drawing.Point(785, 36)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(87, 23)
        Me.btn_agregar.TabIndex = 5
        Me.btn_agregar.Text = "Finalizar"
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'btn_volver
        '
        Me.btn_volver.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_volver.Location = New System.Drawing.Point(50, 36)
        Me.btn_volver.Name = "btn_volver"
        Me.btn_volver.Size = New System.Drawing.Size(87, 23)
        Me.btn_volver.TabIndex = 6
        Me.btn_volver.Text = "Volver"
        Me.btn_volver.UseVisualStyleBackColor = True
        '
        'FRM_PROF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(933, 450)
        Me.Controls.Add(Me.btn_volver)
        Me.Controls.Add(Me.btn_agregar)
        Me.Controls.Add(Me.GP_DESA)
        Me.Controls.Add(Me.GP_SU)
        Me.Controls.Add(Me.cbxTipoPregunta)
        Me.Controls.Add(Me.txt_question)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FRM_PROF"
        Me.Text = "Profesor"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GP_SU.ResumeLayout(False)
        Me.GP_SU.PerformLayout()
        Me.GP_DESA.ResumeLayout(False)
        Me.GP_DESA.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txt_question As TextBox
    Friend WithEvents cbxTipoPregunta As ComboBox
    Friend WithEvents GP_SU As GroupBox
    Friend WithEvents rbtnD As RadioButton
    Friend WithEvents rbtnC As RadioButton
    Friend WithEvents rbtnB As RadioButton
    Friend WithEvents rbtnA As RadioButton
    Friend WithEvents GP_DESA As GroupBox
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_add As Button
    Friend WithEvents txt_answer As TextBox
    Friend WithEvents LST_ANSW As ListBox
    Friend WithEvents txt_D As TextBox
    Friend WithEvents txt_C As TextBox
    Friend WithEvents txt_B As TextBox
    Friend WithEvents txt_A As TextBox
    Friend WithEvents btn_agregar As Button
    Friend WithEvents btn_volver As Button
End Class
