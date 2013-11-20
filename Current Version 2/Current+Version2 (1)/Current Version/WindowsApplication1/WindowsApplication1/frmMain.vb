Public Class frmMain

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        'The only thing needed to check the password for the next form is:
        'First: The correct password (all correct passwords are in the PasswordVerify class)
        'Second: the form you are currently using (must use Me)
        'Third: the destination form
        PasswordVerify.PassCheck(PasswordVerify.m_levelOne, Me, frmAction)
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        frmParent.Close()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterParent
    End Sub
End Class
