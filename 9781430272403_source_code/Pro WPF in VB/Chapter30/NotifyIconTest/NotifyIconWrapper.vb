Public Class NotifyIconWrapper

    ' Use just one instance of this window.
    Private win As New Window1()

    Private Sub cmdShowWindow_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdShowWindow.Click
        ' Show the window (and bring it to the forefront if it's already visible).
        If win.WindowState = System.Windows.WindowState.Minimized Then
            win.WindowState = System.Windows.WindowState.Normal
        End If

        win.Show()
        win.Activate()
    End Sub

    Private Sub cmdClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdClose.Click
        System.Windows.Application.Current.Shutdown()
    End Sub

End Class
