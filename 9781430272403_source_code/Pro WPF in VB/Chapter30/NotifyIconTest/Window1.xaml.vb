Imports System.ComponentModel

Public Class Window1

    Private Sub window_Closing(ByVal sender As Object, ByVal e As CancelEventArgs)
        ' Don't close the window, because we might need it later.
        ' Just conceal it.
        e.Cancel = True
        Me.WindowState = WindowState.Minimized
        Me.ShowInTaskbar = False
    End Sub

End Class
