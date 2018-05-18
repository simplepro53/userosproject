Public Class QuickOpen
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.SelectedItem = "MiniNote" Then
            MiniNote.Show()
        End If
        If ComboBox1.SelectedItem = "UserCore Shell" Then
            UserCore.Show()
        End If
        If ComboBox1.SelectedItem = "Settings Panel" Then
            Settingspanel.Show()
        End If
    End Sub
End Class