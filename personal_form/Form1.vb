Public Class Form1

    Private Sub btn_x_Click(sender As Object, e As EventArgs) Handles btn_x.Click
        Dim msg As New Form3
        msg.nam = tb_name.Text
        msg.age = tb_a.Text
        msg.add = tb_d.Text
        msg.Show()
    End Sub

    Private Sub btn_j_Click(sender As Object, e As EventArgs) Handles btn_j.Click
        Dim msg As New Form4
        msg.nam = tb_name.Text
        msg.age = tb_a.Text
        msg.add = tb_d.Text
        msg.Show()
    End Sub

    Private Sub tb_a_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_a.KeyPress
        If Char.IsNumber(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub btn_txt_Click(sender As Object, e As EventArgs) Handles btn_txt.Click
        Dim msg As New Form2
        msg.nam = tb_name.Text
        msg.age = tb_a.Text
        msg.add = tb_d.Text
        msg.Show()
    End Sub

    Private Sub ToolTip1_Popup(sender As Object, e As PopupEventArgs) Handles ToolTip1.Popup

    End Sub
End Class
