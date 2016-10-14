Partial Class NotifyIconWrapper
    Inherits System.ComponentModel.Component

    <System.Diagnostics.DebuggerNonUserCode()> _
    Public Sub New(ByVal container As System.ComponentModel.IContainer)
        MyClass.New()

        'Required for Windows.Forms Class Composition Designer support
        If (container IsNot Nothing) Then
            container.Add(Me)
        End If

    End Sub

    <System.Diagnostics.DebuggerNonUserCode()> _
    Public Sub New()
        MyBase.New()

        'This call is required by the Component Designer.
        InitializeComponent()

    End Sub

    'Component overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Component Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Component Designer
    'It can be modified using the Component Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NotifyIconWrapper))
        Me.contextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdShowWindow = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdClose = New System.Windows.Forms.ToolStripMenuItem
        Me.notifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.contextMenuStrip1.SuspendLayout()
        '
        'contextMenuStrip1
        '
        Me.contextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdShowWindow, Me.cmdClose})
        Me.contextMenuStrip1.Name = "contextMenuStrip1"
        Me.contextMenuStrip1.Size = New System.Drawing.Size(151, 48)
        '
        'cmdShowWindow
        '
        Me.cmdShowWindow.Name = "cmdShowWindow"
        Me.cmdShowWindow.Size = New System.Drawing.Size(150, 22)
        Me.cmdShowWindow.Text = "Show Window"
        '
        'cmdClose
        '
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(150, 22)
        Me.cmdClose.Text = "Close"
        '
        'notifyIcon1
        '
        Me.notifyIcon1.ContextMenuStrip = Me.contextMenuStrip1
        Me.notifyIcon1.Icon = CType(resources.GetObject("notifyIcon1.Icon"), System.Drawing.Icon)
        Me.notifyIcon1.Text = "NotifyIcon Test"
        Me.notifyIcon1.Visible = True
        Me.contextMenuStrip1.ResumeLayout(False)

    End Sub
    Private WithEvents contextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Private WithEvents cmdShowWindow As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents cmdClose As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents notifyIcon1 As System.Windows.Forms.NotifyIcon

End Class
