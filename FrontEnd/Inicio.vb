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




    End Sub
End Class
