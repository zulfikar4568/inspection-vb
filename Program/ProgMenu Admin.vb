
Public Class ProgMenu_Admin
    Public Flag_back As GlobalVariable
    Dim x, y As Integer
    Dim newpoint As New Point

    Private Sub Closemenu_Click(sender As Object, e As EventArgs) Handles Closemenu.Click
        Application.Exit()
    End Sub

    Private Sub ProgMenu_Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Show()
    End Sub

    Private Sub Minimazemenu_Click(sender As Object, e As EventArgs) Handles Minimazemenu.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub


    Private Sub Logout_Click(sender As Object, e As EventArgs) Handles Logout.Click
        Me.Hide()
        Login.Show()
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

    Private Sub Bt_DataKondisi_Click(sender As Object, e As EventArgs) Handles Bt_DataKondisi.Click
        Flag_back.Back = "True"
        Me.Hide()
        ProgMenu.Show()
    End Sub

    Private Sub Bt_AddIc_Click(sender As Object, e As EventArgs) Handles Bt_AddIc.Click
        Me.Hide()
        EditInspeksi.Show()
    End Sub

    Private Sub Bt_Historical_Click(sender As Object, e As EventArgs) Handles Bt_Historical.Click
        Me.Hide()
        Historical.Show()
    End Sub

    Private Sub Bt_Grafik_Click(sender As Object, e As EventArgs) Handles Bt_Grafik.Click
        Me.Hide()
        Chart.Show()
    End Sub

    Private Sub PanelMenu_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelMenu.MouseDown
        x = Control.MousePosition.X - Me.Location.X
        y = Control.MousePosition.Y - Me.Location.Y
    End Sub
End Class