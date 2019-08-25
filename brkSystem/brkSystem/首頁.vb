Public Class 首頁
    Private Sub btnhead_Click(sender As Object, e As EventArgs) Handles btnhead.Click
        點餐頁面.Show()
        Me.Hide()
    End Sub

    Private Sub btnUse_Click(sender As Object, e As EventArgs) Handles btnUse.Click
        使用說明.Show()
        Me.Hide()
    End Sub

    Private Sub 首頁_DoubleClick(sender As Object, e As EventArgs) Handles Me.DoubleClick
        manager.Show()
        Me.Hide()
    End Sub

    Private Sub 首頁_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class