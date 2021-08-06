Imports System.Data.SqlClient
Public Class Login
    Public SQL As New SQLControl
    Dim x, y As Integer
    Dim newpoint As New Point

    Private Sub Close_Click(sender As Object, e As EventArgs) Handles Close.Click
        Application.Exit()
    End Sub
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Show()
    End Sub

    Private Sub Bt_Login_Click(sender As Object, e As EventArgs)
        My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)

        SQL.AddParam("@Username", "" & Tb_Usr.Text & "")
        SQL.AddParam("@Password", "" & Tb_Pwd.Text & "")
        SQL.ExecQuery("SELECT * FROM Admin WHERE username = @Username AND password = @Password")
        If SQL.DBDT.Rows.Count() <= 0 Then
            SQL.AddParam("@Username", "" & Tb_Usr.Text & "")
            SQL.AddParam("@Password", "" & Tb_Pwd.Text & "")
            SQL.ExecQuery("SELECT * FROM Userbaru WHERE username = @Username AND password = @Password")
            If SQL.DBDT.Rows.Count() <= 0 Then
                Me.Hide()
                GagalLogin.Show()
            Else
                Me.Hide()
                ProgMenu.Show()
                Tb_Usr.Text = "Username"
                Tb_Pwd.Text = "Password"
            End If
        Else
            Me.Hide()
            ProgMenu_Admin.Show()
            Tb_Usr.Text = "Username"
            Tb_Pwd.Text = "Password"
        End If






    End Sub

    Private Sub Minimaze_Click(sender As Object, e As EventArgs) Handles Minimaze.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub


    Private Sub PanelLogin_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelLogin.MouseMove
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            newpoint = Control.MousePosition
            newpoint.X -= x
            newpoint.Y -= y
            Me.Location = newpoint
            Application.DoEvents()
        End If
    End Sub

    Private Sub PanelLogin_Paint(sender As Object, e As PaintEventArgs) Handles PanelLogin.Paint

    End Sub


    Private Sub PanelLogin_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelLogin.MouseDown
        x = Control.MousePosition.X - Me.Location.X
        y = Control.MousePosition.Y - Me.Location.Y
    End Sub
End Class
