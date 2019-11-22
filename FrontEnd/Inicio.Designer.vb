<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_prin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_prin))
        Me.lbl_user = New System.Windows.Forms.Label()
        Me.txt_user = New System.Windows.Forms.TextBox()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_student = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.lbl_HS = New System.Windows.Forms.Label()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.btn_exit = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_user
        '
        Me.lbl_user.AutoSize = True
        Me.lbl_user.BackColor = System.Drawing.SystemColors.Window
        Me.lbl_user.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_user.Image = CType(resources.GetObject("lbl_user.Image"), System.Drawing.Image)
        Me.lbl_user.Location = New System.Drawing.Point(223, 172)
        Me.lbl_user.Name = "lbl_user"
        Me.lbl_user.Size = New System.Drawing.Size(136, 19)
        Me.lbl_user.TabIndex = 0
        Me.lbl_user.Text = "Nombre de usuario"
        '
        'txt_user
        '
        Me.txt_user.Location = New System.Drawing.Point(227, 225)
        Me.txt_user.Name = "txt_user"
        Me.txt_user.Size = New System.Drawing.Size(116, 20)
        Me.txt_user.TabIndex = 1
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.SystemColors.Window
        Me.lbl_title.Font = New System.Drawing.Font("Times New Roman", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Image = CType(resources.GetObject("lbl_title.Image"), System.Drawing.Image)
        Me.lbl_title.Location = New System.Drawing.Point(198, 86)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(192, 36)
        Me.lbl_title.TabIndex = 2
        Me.lbl_title.Text = "Matemáticas"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-5, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(653, 398)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'btn_student
        '
        Me.btn_student.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_student.Location = New System.Drawing.Point(143, 287)
        Me.btn_student.Name = "btn_student"
        Me.btn_student.Size = New System.Drawing.Size(87, 23)
        Me.btn_student.TabIndex = 4
        Me.btn_student.Text = "Estudiante"
        Me.btn_student.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(327, 287)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Profesor"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'lbl_HS
        '
        Me.lbl_HS.AutoSize = True
        Me.lbl_HS.BackColor = System.Drawing.SystemColors.Window
        Me.lbl_HS.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_HS.Image = CType(resources.GetObject("lbl_HS.Image"), System.Drawing.Image)
        Me.lbl_HS.Location = New System.Drawing.Point(3, 11)
        Me.lbl_HS.Name = "lbl_HS"
        Me.lbl_HS.Size = New System.Drawing.Size(214, 19)
        Me.lbl_HS.TabIndex = 6
        Me.lbl_HS.Text = "Liceo Edgar Cervantes Villalta"
        '
        'lbl_date
        '
        Me.lbl_date.AutoSize = True
        Me.lbl_date.BackColor = System.Drawing.SystemColors.Window
        Me.lbl_date.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_date.Image = CType(resources.GetObject("lbl_date.Image"), System.Drawing.Image)
        Me.lbl_date.Location = New System.Drawing.Point(14, 46)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(121, 19)
        Me.lbl_date.TabIndex = 7
        Me.lbl_date.Text = "                            "
        '
        'btn_exit
        '
        Me.btn_exit.Location = New System.Drawing.Point(456, 12)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(87, 23)
        Me.btn_exit.TabIndex = 8
        Me.btn_exit.Text = "Salir"
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'frm_prin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(574, 365)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.lbl_date)
        Me.Controls.Add(Me.lbl_HS)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_student)
        Me.Controls.Add(Me.txt_user)
        Me.Controls.Add(Me.lbl_user)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frm_prin"
        Me.Text = "Aplicación"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_user As Label
    Friend WithEvents txt_user As TextBox
    Friend WithEvents lbl_title As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_student As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents lbl_HS As Label
    Friend WithEvents lbl_date As Label
    Friend WithEvents btn_exit As Button
End Class
