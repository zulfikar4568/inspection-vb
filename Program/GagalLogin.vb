Public Class GagalLogin
    Dim x, y As Integer
    Dim newpoint As New Point
    Private Sub Close2_Click(sender As Object, e As EventArgs) Handles Close2.Click
        Application.Exit()
    End Sub

    Private Sub Bt_Wrong_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub PanelLoginSalah_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelLoginSalah.MouseDown
        x = Control.MousePosition.X - Me.Location.X
        y = Control.MousePosition.Y - Me.Location.Y
    End Sub


    Private Sub PanelLoginSalah_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelLoginSalah.MouseMove
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            newpoint = Control.MousePosition
            newpoint.X -= x
            newpoint.Y -= y
            Me.Location = newpoint
            Application.DoEvents()
        End If
    End Sub
End Class