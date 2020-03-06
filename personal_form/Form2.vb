Public Class Form2
    Public Property nam As String
    Public Property age As String
    Public Property add As String

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        l1.Text = nam
        l2.Text = age
        l3.Text = add
    End Sub

    Private Sub l3_Click(sender As Object, e As EventArgs) Handles l3.Click

    End Sub
End Class