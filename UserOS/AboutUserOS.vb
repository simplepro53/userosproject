Public Class AboutUserOS
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Hide()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
    End Sub
End Class