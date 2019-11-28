<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistroUsuario
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtSApe = New System.Windows.Forms.TextBox()
        Me.txtPApe = New System.Windows.Forms.TextBox()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.cbxGenero = New System.Windows.Forms.ComboBox()
        Me.cbxTU = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Primer Apellido:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Segundo Apellido:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Cedula"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 202)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Genero"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 251)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "TipoUsuario"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(158, 27)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(121, 20)
        Me.txtNombre.TabIndex = 6
        '
        'txtSApe
        '
        Me.txtSApe.Location = New System.Drawing.Point(158, 155)
        Me.txtSApe.Name = "txtSApe"
        Me.txtSApe.Size = New System.Drawing.Size(121, 20)
        Me.txtSApe.TabIndex = 7
        '
        'txtPApe
        '
        Me.txtPApe.Location = New System.Drawing.Point(158, 111)
        Me.txtPApe.Name = "txtPApe"
        Me.txtPApe.Size = New System.Drawing.Size(121, 20)
        Me.txtPApe.TabIndex = 8
        '
        'txtCedula
        '
        Me.txtCedula.Location = New System.Drawing.Point(158, 69)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(121, 20)
        Me.txtCedula.TabIndex = 9
        '
        'cbxGenero
        '
        Me.cbxGenero.FormattingEnabled = True
        Me.cbxGenero.Location = New System.Drawing.Point(158, 199)
        Me.cbxGenero.Name = "cbxGenero"
        Me.cbxGenero.Size = New System.Drawing.Size(121, 21)
        Me.cbxGenero.TabIndex = 10
        '
        'cbxTU
        '
        Me.cbxTU.FormattingEnabled = True
        Me.cbxTU.Location = New System.Drawing.Point(158, 248)
        Me.cbxTU.Name = "cbxTU"
        Me.cbxTU.Size = New System.Drawing.Size(121, 21)
        Me.cbxTU.TabIndex = 11
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(204, 298)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Agregar Usuario"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RegistroUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(291, 339)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cbxTU)
        Me.Controls.Add(Me.cbxGenero)
        Me.Controls.Add(Me.txtCedula)
        Me.Controls.Add(Me.txtPApe)
        Me.Controls.Add(Me.txtSApe)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "RegistroUsuario"
        Me.Text = "Registro de Usuario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtSApe As TextBox
    Friend WithEvents txtPApe As TextBox
    Friend WithEvents txtCedula As TextBox
    Friend WithEvents cbxGenero As ComboBox
    Friend WithEvents cbxTU As ComboBox
    Friend WithEvents Button1 As Button
End Class
