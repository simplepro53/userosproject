Public Class Settingspanel
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        DesktopColor.show
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        DesktopColor.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        setup.Button3.Visible = True
        setup.FormBorderStyle = FormBorderStyle.None
        setup.BackColor = Color.DimGray
        setup.Label1.ForeColor = Color.White
        setup.Label2.Visible = True
        setup.PictureBox1.Visible = True
        DesktopColor.Button8.Visible = True
        DesktopColor.Button9.Visible = True
        DesktopColor.PictureBox1.Visible = True
        DesktopColor.Label3.Visible = True
        DesktopColor.BackColor = Color.DimGray
        DesktopColor.Label1.ForeColor = Color.White
        DesktopColor.Label2.ForeColor = Color.White
        DesktopColor.FormBorderStyle = FormBorderStyle.None
        AboutUserOS.FormBorderStyle = FormBorderStyle.None
        GUIDesktop.FormBorderStyle = FormBorderStyle.None
        GUIDesktop.Button3.Visible = True
        GUIDesktop.Button4.Visible = True
        AboutUserOS.PictureBox2.Visible = True
        AboutUserOS.Label5.Visible = True
        AboutUserOS.Button9.Visible = True
        AboutUserOS.Button8.Visible = True
        Label3.Visible = True
        PictureBox2.Visible = True
        Button8.Visible = True
        Button9.Visible = True
        FormBorderStyle = FormBorderStyle.None
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        setup.Button3.Visible = False
        setup.FormBorderStyle = FormBorderStyle.FixedDialog
        setup.BackColor = Color.WhiteSmoke
        setup.Label1.ForeColor = Color.Black
        setup.Label2.Visible = False
        setup.PictureBox1.Visible = False
        DesktopColor.Button8.Visible = False
        DesktopColor.Button9.Visible = False
        DesktopColor.PictureBox1.Visible = False
        DesktopColor.Label3.Visible = False
        DesktopColor.BackColor = Color.WhiteSmoke
        DesktopColor.Label1.ForeColor = Color.Black
        DesktopColor.Label2.ForeColor = Color.Black
        DesktopColor.FormBorderStyle = FormBorderStyle.FixedDialog
        AboutUserOS.FormBorderStyle = FormBorderStyle.FixedDialog
        GUIDesktop.FormBorderStyle = FormBorderStyle.FixedSingle
        GUIDesktop.Button3.Visible = False
        GUIDesktop.Button4.Visible = False
        AboutUserOS.PictureBox2.Visible = False
        AboutUserOS.Label5.Visible = False
        AboutUserOS.Button9.Visible = False
        AboutUserOS.Button8.Visible = False
        Label3.Visible = False
        PictureBox2.Visible = False
        Button8.Visible = False
        Button9.Visible = False
        FormBorderStyle = FormBorderStyle.FixedSingle
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Hide()
    End Sub
End Class