Public Class frmShipment
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Me.Close()
        frmAction.Show()
    End Sub
  

    Private Sub btnDelete_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Me.dgvShipment.Rows.Add(cmbType.Text, cmbItem.Text, cmbSize.Text, txtQuantity.Text)
        cmbItem.Items.Clear()
        cmbItem.Text = ""
        cmbSize.Items.Clear()
        cmbSize.Text = ""
        cmbType.Items.Clear()
        cmbType.Text = ""
        txtQuantity.Clear()

    End Sub

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        'Clear all comboboxes
        cmbType.Dispose()
        cmbItem.Dispose()
        cmbSize.Dispose()
        txtQuantity.Clear()

        'Return to Action Form
        Me.Close()
        frmAction.Show()
    End Sub
End Class