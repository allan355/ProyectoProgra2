<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Graficos
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Me.crtGrafico = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.cbxPregunta = New System.Windows.Forms.ComboBox()
        Me.btnConsultar = New System.Windows.Forms.Button()
        CType(Me.crtGrafico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'crtGrafico
        '
        Me.crtGrafico.BackColor = System.Drawing.Color.Teal
        Me.crtGrafico.BorderlineColor = System.Drawing.SystemColors.Window
        ChartArea1.Name = "ChartArea1"
        Me.crtGrafico.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.crtGrafico.Legends.Add(Legend1)
        Me.crtGrafico.Location = New System.Drawing.Point(12, 94)
        Me.crtGrafico.Name = "crtGrafico"
        Me.crtGrafico.Size = New System.Drawing.Size(776, 301)
        Me.crtGrafico.TabIndex = 0
        '
        'cbxPregunta
        '
        Me.cbxPregunta.FormattingEnabled = True
        Me.cbxPregunta.Location = New System.Drawing.Point(12, 67)
        Me.cbxPregunta.Name = "cbxPregunta"
        Me.cbxPregunta.Size = New System.Drawing.Size(121, 21)
        Me.cbxPregunta.TabIndex = 1
        '
        'btnConsultar
        '
        Me.btnConsultar.BackColor = System.Drawing.Color.Teal
        Me.btnConsultar.Font = New System.Drawing.Font("MV Boli", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultar.ForeColor = System.Drawing.Color.White
        Me.btnConsultar.Location = New System.Drawing.Point(139, 65)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(75, 34)
        Me.btnConsultar.TabIndex = 2
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.UseVisualStyleBackColor = False
        '
        'Graficos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.cbxPregunta)
        Me.Controls.Add(Me.crtGrafico)
        Me.Name = "Graficos"
        Me.Text = "Graficos"
        CType(Me.crtGrafico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents crtGrafico As DataVisualization.Charting.Chart
    Friend WithEvents cbxPregunta As ComboBox
    Friend WithEvents btnConsultar As Button
End Class
