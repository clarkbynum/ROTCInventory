Public Class frmVolunteer

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        'Clear text, combo boxes, and datagrid
        cmbID.Dispose()
        txtName.Clear()
        txtStartDate.Clear()
        txtStartTime.Clear()
        txtEndDate.Clear()
        txtEndTime.Clear()
        dgvVolunteer.Dispose()

        'Return to Action Form
        Me.Close()
        frmAction.Show()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

    End Sub
End Class