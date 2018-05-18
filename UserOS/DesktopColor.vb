Public Class DesktopColor
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Label2.Text = "Red" Then
            GUIDesktop.BackColor = Color.DarkRed
            Me.Hide()
        End If
        If Label2.Text = "Black" Then
            GUIDesktop.BackColor = Color.Black
            Hide()
        End If
        If Label2.Text = "Gray" Then
            GUIDesktop.BackColor = Color.Gray
            Hide()
        End If
        If Label2.Text = "Green" Then
            GUIDesktop.BackColor = Color.Green
            Me.Hide()
        End If
        If Label2.Text = "Teal" Then
            GUIDesktop.BackColor = Color.Teal
            Hide()
        End If
        If Label2.Text = "Blue" Then
            GUIDesktop.BackColor = Color.SteelBlue
            Hide()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label2.Text = "Red"
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label2.Text = "Black"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label2.Text = "Gray"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Label2.Text = "Green"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Label2.Text = "Teal"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Label2.Text = "Blue"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Hide()
    End Sub
End Class