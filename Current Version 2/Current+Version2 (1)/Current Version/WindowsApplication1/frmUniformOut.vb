Public Class frmUniformOut


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Me.Close()
        frmAction.Show()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

    End Sub

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        'Clear all combo and textboxes, and datagrid
        cmbID.Dispose()
        txtRank.Clear()
        txtName.Clear()
        cmbType.Dispose()
        cmbItem.Dispose()
        cmbSize.Dispose()
        dgvCheckOut.Dispose()

        'Return to Action Form
        Me.Close()
        frmAction.Show()
    End Sub
End Class