Public Class frmDonations

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'The program will save the data in the database, and clear all textboxes and datagrid
        cmbType.Dispose()
        cmbItem.Dispose()
        cmbSize.Dispose()
        dgvDonations.Dispose()
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Me.Close()
        frmAction.Show()
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        'Clear all textboxes and datagrid
        cmbType.Dispose()
        cmbItem.Dispose()
        cmbSize.Dispose()
        dgvDonations.Dispose()

        'Return to Action Form
        Me.Close()
        frmAction.Show()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

    End Sub
End Class