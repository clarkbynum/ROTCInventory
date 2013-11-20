Public Class frmReportInventory

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        'clear combo boxes and data grid
        cmbUniform.Dispose()
        cmbItem.Dispose()
        dgvRepInventory.Dispose()

        'Return to Reports Form
        Me.Close()
        frmReports.Show()

    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

    End Sub
End Class