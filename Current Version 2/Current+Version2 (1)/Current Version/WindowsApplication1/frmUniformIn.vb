Public Class frmUniformIn


    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        'Clear all combo and textboxes, and datagrid
        cmbID.Dispose()
        txtRank.Clear()
        txtName.Clear()

        'Return to Action Form
        Me.Close()
        frmAction.Show()
    End Sub
End Class