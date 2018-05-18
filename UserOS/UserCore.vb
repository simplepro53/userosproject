Public Class UserCore
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "startdesk /gfx" Then
            GUIDesktop.Show()
            Me.Hide()
        End If
        If TextBox1.Text = "shellhelp" Then
            UserCoreShell.show
        End If
        If TextBox1.Text = "gfxpanel" Then
            Settingspanel.Show()
        End If
        If TextBox1.Text = "gfxnote" Then
            MiniNote.Show()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AboutUserOS.Show()
    End Sub
End Class
