Imports System.Windows.Forms.DataVisualization.Charting

Public Class Graficos
    Private Sub Graficos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbxPregunta.DataSource = Logica.PreguntasLogica.ObtenerPreguntas()
        cbxPregunta.ValueMember = "Id"
        cbxPregunta.DisplayMember = "Descripcion"
    End Sub

    Private Sub CargarGrafico(ByVal Pregunta As DTOS.Pregunta)
        Dim Rep As List(Of DTOS.ReportePregunta) = Logica.SesionLogica.obtenerResultado(Pregunta.Id)
        Dim seriesArray As List(Of String) = New List(Of String)
        Dim pointsArray As List(Of Integer) = New List(Of Integer)

        For Each r As DTOS.ReportePregunta In Rep
            If r.Correcta Then
                seriesArray.Add("Correctos")
                pointsArray.Add(r.Cantidad)
            Else
                seriesArray.Add("Incorrectos")
                pointsArray.Add(r.Cantidad)
            End If
        Next
        Me.crtGrafico.Series.Clear()
        Me.crtGrafico.Titles.Clear()
        Me.crtGrafico.Palette = ChartColorPalette.SeaGreen

        Me.crtGrafico.Titles.Add(Pregunta.Descripcion)
        For i As Integer = 0 To seriesArray.Count - 1
            Dim series As Series = Me.crtGrafico.Series.Add(seriesArray(i))
            series.Points.Add(pointsArray(i))
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        CargarGrafico(cbxPregunta.SelectedItem)
    End Sub
End Class