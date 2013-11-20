Public Class frmParent

    Private Sub frmParent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmMain.MdiParent = Me
        frmMain.WindowState = FormWindowState.Maximized

        frmMain.Show()
        
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        'MdiChildren.
    End Sub
End Class