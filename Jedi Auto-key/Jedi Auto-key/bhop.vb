Public Class bhop
    Private Sub bhop_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Space And btnstart.Focused Then
            e.Handled = True
        End If
    End Sub
    Private Sub bhoptoggle()
        tmrbhop.Enabled = Not tmrbhop.Enabled
    End Sub
    Private Sub bhop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KeyPreview = True
    End Sub
    Private Sub btnstart_Click(sender As Object, e As EventArgs) Handles btnstart.Click
        bhoptoggle()
    End Sub

    Private Sub tmrbhop_Tick(sender As Object, e As EventArgs) Handles tmrbhop.Tick
        lblhopcount.Text += 1
        SendKeys.Send(" ")
    End Sub

    Private Sub btnmenu_Click(sender As Object, e As EventArgs) Handles btnmenu.Click
        tmrbhop.Enabled = False
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub StartStopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StartStopToolStripMenuItem.Click
        bhoptoggle()
    End Sub
End Class