Public Class frmShipment
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Me.Close()
        frmAction.Show()
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        'Clear all comboboxes
        cmbType.Dispose()
        cmbItem.Dispose()
        cmbSize.Dispose()

        'Return to Action Form
        Me.Close()
        frmAction.Show()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

    End Sub
End Class