Public Class frmParent

    Private Sub frmParent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmMain.MdiParent = Me
        frmMain.WindowState = FormWindowState.Maximized

        frmMain.Show()
        
    End Sub
End Class