Public Class frmReports
    Private Sub btnCadets_Click(sender As Object, e As EventArgs) Handles btnCadets.Click
        Me.Close()
        frmReportCadets.Show()
    End Sub

    Private Sub btnInventory_Click(sender As Object, e As EventArgs) Handles btnInventory.Click
        Me.Close()
        frmReportInventory.Show()
    End Sub

    Private Sub btnDonations_Click(sender As Object, e As EventArgs) Handles btnDonations.Click
        Me.Close()
        frmReportsDonations.Show()
    End Sub

    Private Sub btnVolunteer_Click(sender As Object, e As EventArgs) Handles btnVolunteer.Click
        Me.Close()
        frmReportsVolunteer.Show()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        'Return to Action Form
        Me.Close()
        frmAction.Show()
    End Sub
End Class