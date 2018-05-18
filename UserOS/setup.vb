Public Class setup
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DesktopColor.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button3.Visible = True
        FormBorderStyle = FormBorderStyle.None
        BackColor = Color.DimGray
        Label1.ForeColor = Color.White
        Label2.Visible = True
        PictureBox1.Visible = True
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
        Settingspanel.Label3.Visible = True
        Settingspanel.PictureBox2.Visible = True
        Settingspanel.Button8.Visible = True
        Settingspanel.Button9.Visible = True
        Settingspanel.FormBorderStyle = FormBorderStyle.None
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Button3.Visible = False
        FormBorderStyle = FormBorderStyle.FixedDialog
        BackColor = Color.WhiteSmoke
        Label1.ForeColor = Color.Black
        Label2.Visible = False
        PictureBox1.Visible = False
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
        Settingspanel.Label3.Visible = False
        Settingspanel.PictureBox2.Visible = False
        Settingspanel.Button8.Visible = False
        Settingspanel.Button9.Visible = False
        Settingspanel.FormBorderStyle = FormBorderStyle.FixedSingle
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        UserCore.Show()
        Me.Hide()
    End Sub

    Private Sub setup_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class