Public Class ProgMenu
    Public flagback As GlobalVariable
    Public SKID As SKID
    Dim x, y As Integer
    Dim newpoint As New Point
    Private Sub Closemenu_Click(sender As Object, e As EventArgs) Handles Closemenu.Click
        Application.Exit()
    End Sub

    Private Sub ProgMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Show()
        If flagback.Back = "True" Then
            Bt_Back.Visible = True
        End If
        If flagback.Back = "False" Then
            Bt_Back.Visible = False
        End If
    End Sub

    Private Sub Minimazemenu_Click(sender As Object, e As EventArgs) Handles Minimazemenu.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub


    Private Sub BTP29_Click(sender As Object, e As EventArgs) Handles Bt_P29.Click
        SKID.P29 = "True"
        SKID.P31 = "False"
        SKID.P32 = "False"
        SKID.P33 = "False"
        Me.Hide()
        SKIDP29.Show()
    End Sub

    Private Sub Logout_Click(sender As Object, e As EventArgs) Handles Logout.Click
        Me.Close()
        Login.Show()
        'MessageBox.Show("Berhasil Logout")
    End Sub

    Private Sub PanelMenu_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelMenu.MouseMove
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            newpoint = Control.MousePosition
            newpoint.X -= x
            newpoint.Y -= y
            Me.Location = newpoint
            Application.DoEvents()
        End If
    End Sub

    Private Sub Bt_P31_Click(sender As Object, e As EventArgs) Handles Bt_P31.Click
        SKID.P29 = "False"
        SKID.P31 = "True"
        SKID.P32 = "False"
        SKID.P33 = "False"
        Me.Hide()
        SKIDP29.Show()
    End Sub

    Private Sub Bt_P33_Click(sender As Object, e As EventArgs) Handles Bt_P33.Click
        SKID.P29 = "False"
        SKID.P31 = "False"
        SKID.P32 = "False"
        SKID.P33 = "True"
        Me.Hide()
        SKIDP29.Show()
    End Sub

    Private Sub Bt_P32_Click(sender As Object, e As EventArgs) Handles Bt_P32.Click
        SKID.P29 = "False"
        SKID.P31 = "False"
        SKID.P32 = "True"
        SKID.P33 = "False"
        Me.Hide()
        SKIDP29.Show()
    End Sub

    Private Sub Bt_Back_Click(sender As Object, e As EventArgs) Handles Bt_Back.Click
        flagback.Back = "False"
        Me.Close()
        ProgMenu_Admin.Show()
    End Sub

    Private Sub PanelMenu_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelMenu.MouseDown
        x = Control.MousePosition.X - Me.Location.X
        y = Control.MousePosition.Y - Me.Location.Y
    End Sub
End Class