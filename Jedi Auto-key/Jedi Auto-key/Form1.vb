Public Class Form1
    Private Sub btnbhop_Click(sender As Object, e As EventArgs) Handles btnbhop.Click
        bhop.Show()
        Me.Hide()
    End Sub

    Private Sub btncustom_Click(sender As Object, e As EventArgs) Handles btncustom.Click
        Custom.Show()
        Me.Hide()
    End Sub

    Private Sub btni_Click(sender As Object, e As EventArgs) Handles btni.Click
        info.Show()
        Me.Hide()

    End Sub
End Class
