Public Class frmUniformsInOut


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Me.Close()
        frmAction.Show()
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        'Clear all combo and textboxes, and datagrid
        cmbID.Dispose()
        txtRank.Clear()
        txtName.Clear()
        cmbType.Dispose()
        cmbItem.Dispose()
        cmbSize.Dispose()
        dgvCheckInOut.Dispose()

        'Return to Action Form
        Me.Close()
        frmAction.Show()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        'Me.Hide()
        'frm10Password.Show()
    End Sub
End Class