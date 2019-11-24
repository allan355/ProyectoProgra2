Public Class frm_prin

    Private Sub frm_prin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_date.Text = DateTime.Now.ToLongDateString()
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub

    Private Sub lbl_date_Click(sender As Object, e As EventArgs) Handles lbl_date.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ventana As FRM_PROF = New FRM_PROF()
        ventana.Show()
        Me.Hide()
    End Sub

    Private Sub btn_student_Click(sender As Object, e As EventArgs) Handles btn_student.Click
        Dim ventana As FRM_MAIN = New FRM_MAIN()
        ventana.Show()
        Me.Hide()
    End Sub
End Class
