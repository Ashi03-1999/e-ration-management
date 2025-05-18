Public Class AdminDashboard
    Private Sub btnUserMgmt_Click(sender As Object, e As EventArgs) Handles btnUserMgmt.Click
        UserManagement.Show()
    End Sub

    Private Sub btnPriceList_Click(sender As Object, e As EventArgs) Handles btnPriceList.Click
        PriceList.Show()
    End Sub

    Private Sub btnAllotRation_Click(sender As Object, e As EventArgs) Handles btnAllotRation.Click
        RationAllotment.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ExitConfirmation.Show()
    End Sub
End Class
