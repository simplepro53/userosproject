Public Class GUIDesktop
    Private Sub ExitToShellToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToShellToolStripMenuItem.Click
        UserCore.Show()
        Me.Hide()
    End Sub

    Private Sub ExitUserOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitUserOSToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub AboutUserOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutUserOSToolStripMenuItem.Click
        AboutUserOS.show
    End Sub

    Private Sub SettingsPanelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsPanelToolStripMenuItem.Click
        Settingspanel.show
    End Sub

    Private Sub MiniNoteTemporaryNoteProgramToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MiniNoteToolStripMenuItem.Click
        MiniNote.Show()
    End Sub

    Private Sub UserCoreShellToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserCoreShellToolStripMenuItem.Click
        UserCore.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        UserCore.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Settingspanel.Show()
    End Sub

    Private Sub QuickOpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuickOpenToolStripMenuItem.Click
        QuickOpen.Show()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        QuickOpen.Show()
    End Sub

    Private Sub UserSystemBrowserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserSystemBrowserToolStripMenuItem.Click
        UserSystemBrowser.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub
End Class