Public Class Application

    Private component As NotifyIconWrapper

    Private Sub Application_Startup(ByVal sender As Object, ByVal e As System.Windows.StartupEventArgs) Handles Me.Startup
        Me.ShutdownMode = ShutdownMode.OnExplicitShutdown
        component = New NotifyIconWrapper()
    End Sub

    Private Sub Application_Exit(ByVal sender As Object, ByVal e As System.Windows.ExitEventArgs) Handles Me.Exit
        component.Dispose()
    End Sub

End Class
