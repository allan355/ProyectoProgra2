Public Class FRM_PROF
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click




        LST_ANSW.Items.Add(txt_answer.Text)

        txt_answer.Text = Nothing








    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click



        LST_ANSW.Items.RemoveAt(0)




    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged




        If Me.ComboBox1.SelectedIndex = 0 Then

            GP_DESA.Enabled = False
            GP_SU.Enabled = True


        Else

            GP_SU.Enabled = False
            GP_DESA.Enabled = True

        End If








    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click

        txt_A.Text = Nothing
        txt_B.Text = Nothing
        txt_C.Text = Nothing
        txt_D.Text = Nothing
        LST_ANSW.Items.Clear()
        txt_answer.Text = Nothing
        txt_question = Nothing


    End Sub

    Private Sub FRM_PROF_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
