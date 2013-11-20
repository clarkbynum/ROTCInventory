Public Class frmReportCadets

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        'Clear combo boxes and data grid
        cmbID.Dispose()
        cmbRank.Dispose()
        cmbUniform.Dispose()
        cmbItem.Dispose()
        dgvRepCadets.Dispose()

        'Return to Reports Form
        Me.Close()
        frmReports.Show()

    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

    End Sub
End Class