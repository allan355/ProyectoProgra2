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
        Me.lbl_user = New System.Windows.Forms.Label()
        Me.txt_user = New System.Windows.Forms.TextBox()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.lbl_HS = New System.Windows.Forms.Label()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.btnNuevoUsuario = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_user
        '
        Me.lbl_user.AutoSize = True
        Me.lbl_user.BackColor = System.Drawing.Color.Transparent
        Me.lbl_user.Font = New System.Drawing.Font("MV Boli", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_user.ForeColor = System.Drawing.Color.White
        Me.lbl_user.Location = New System.Drawing.Point(150, 251)
        Me.lbl_user.Name = "lbl_user"
        Me.lbl_user.Size = New System.Drawing.Size(73, 28)
        Me.lbl_user.TabIndex = 0
        Me.lbl_user.Text = "Cedula"
        '
        'txt_user
        '
        Me.txt_user.Location = New System.Drawing.Point(155, 283)
        Me.txt_user.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_user.Name = "txt_user"
        Me.txt_user.Size = New System.Drawing.Size(132, 25)
        Me.txt_user.TabIndex = 1
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.Font = New System.Drawing.Font("MV Boli", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.Color.White
        Me.lbl_title.Location = New System.Drawing.Point(150, 126)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(134, 28)
        Me.lbl_title.TabIndex = 2
        Me.lbl_title.Text = "Matemáticas"
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
        Me.lbl_HS.BackColor = System.Drawing.Color.Transparent
        Me.lbl_HS.Font = New System.Drawing.Font("MV Boli", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_HS.ForeColor = System.Drawing.Color.White
        Me.lbl_HS.Location = New System.Drawing.Point(3, 14)
        Me.lbl_HS.Name = "lbl_HS"
        Me.lbl_HS.Size = New System.Drawing.Size(302, 28)
        Me.lbl_HS.TabIndex = 6
        Me.lbl_HS.Text = "Liceo Edgar Cervantes Villalta"
        '
        'lbl_date
        '
        Me.lbl_date.AutoSize = True
        Me.lbl_date.BackColor = System.Drawing.Color.Transparent
        Me.lbl_date.Font = New System.Drawing.Font("MV Boli", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_date.ForeColor = System.Drawing.Color.White
        Me.lbl_date.Location = New System.Drawing.Point(16, 57)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(292, 28)
        Me.lbl_date.TabIndex = 7
        Me.lbl_date.Text = "                            "
        '
        'btn_exit
        '
        Me.btn_exit.BackColor = System.Drawing.Color.Teal
        Me.btn_exit.Location = New System.Drawing.Point(8, 408)
        Me.btn_exit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(99, 28)
        Me.btn_exit.TabIndex = 8
        Me.btn_exit.Text = "Salir"
        Me.btn_exit.UseVisualStyleBackColor = False
        '
        'btnIngresar
        '
        Me.btnIngresar.BackColor = System.Drawing.Color.Teal
        Me.btnIngresar.Font = New System.Drawing.Font("MV Boli", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngresar.ForeColor = System.Drawing.Color.White
        Me.btnIngresar.Location = New System.Drawing.Point(293, 283)
        Me.btnIngresar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(99, 28)
        Me.btnIngresar.TabIndex = 4
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.UseVisualStyleBackColor = False
        '
        'btnNuevoUsuario
        '
        Me.btnNuevoUsuario.BackColor = System.Drawing.Color.Teal
        Me.btnNuevoUsuario.Font = New System.Drawing.Font("MV Boli", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevoUsuario.ForeColor = System.Drawing.Color.White
        Me.btnNuevoUsuario.Location = New System.Drawing.Point(293, 319)
        Me.btnNuevoUsuario.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnNuevoUsuario.Name = "btnNuevoUsuario"
        Me.btnNuevoUsuario.Size = New System.Drawing.Size(99, 44)
        Me.btnNuevoUsuario.TabIndex = 5
        Me.btnNuevoUsuario.Text = "Nuevo Usuario"
        Me.btnNuevoUsuario.UseVisualStyleBackColor = False
        '
        'frm_prin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(565, 449)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.lbl_date)
        Me.Controls.Add(Me.lbl_HS)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.btnNuevoUsuario)
        Me.Controls.Add(Me.btnIngresar)
        Me.Controls.Add(Me.txt_user)
        Me.Controls.Add(Me.lbl_user)
        Me.Font = New System.Drawing.Font("MV Boli", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.DarkRed
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frm_prin"
        Me.Text = "Aplicación"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_user As Label
    Friend WithEvents txt_user As TextBox
    Friend WithEvents lbl_title As Label
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents lbl_HS As Label
    Friend WithEvents lbl_date As Label
    Friend WithEvents btn_exit As Button
    Friend WithEvents btnIngresar As Button
    Friend WithEvents btnNuevoUsuario As Button
End Class
