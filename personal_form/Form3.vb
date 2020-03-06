Public Class Form3
    Public Property nam As String
    Public Property age As String
    Public Property add As String

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        l1.Text = "< " + nam + " >"
        l2.Text = "< " + age + " >"
        l3.Text = "< " + add + " >"
    End Sub
End Class