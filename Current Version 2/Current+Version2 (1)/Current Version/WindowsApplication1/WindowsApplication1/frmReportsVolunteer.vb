Public Class frmReportsVolunteer

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Clear dates and data grid
        dtpStart.Dispose()
        dtpEnd.Dispose()
        dgvRepVolunteer.Dispose()

        'Return to Reports Form
        Me.Close()
        frmReports.Show()
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

    End Sub
End Class