Public Class Custom

    Dim cString As String
    Private Sub start()
        tmrrun.Enabled = Not tmrrun.Enabled
        cString = tbxstring.Text
        tmrrun.Interval = tbxinterval.Text
    End Sub

    Private Sub tmrrun_Tick(sender As Object, e As EventArgs) Handles tmrrun.Tick
        lblexe.Text += 1
        SendKeys.Send(cString)
    End Sub

    Private Sub check()
        If _
            tbxinterval.Text _
            And
            IsNumeric(True) _
            Then
            start()
        End If
    End Sub

    Private Sub btnmenu_Click(sender As Object, e As EventArgs) Handles btnmenu.Click
        tmrrun.Enabled = False
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub StartStopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StartStopToolStripMenuItem.Click
        check()
    End Sub
End Class