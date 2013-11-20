Public Class frmAction

    Private Sub btnCadet_Click(sender As Object, e As EventArgs) Handles btnCadet.Click
        PasswordVerify.PassCheck(PasswordVerify.m_levelOne, Me, frmCadet)

    End Sub
    Private Sub btnOut_Click(sender As Object, e As EventArgs) Handles btnInOut.Click
        PasswordVerify.PassCheck(PasswordVerify.m_levelOne, Me, frmUniformOut)
    End Sub

    Private Sub btnIn_Click(sender As Object, e As EventArgs) Handles btnIn.Click
        PasswordVerify.PassCheck(PasswordVerify.m_levelOne, Me, frmUniformIn)

    End Sub

    Private Sub btnShip_Click(sender As Object, e As EventArgs) Handles btnShip.Click
        PasswordVerify.PassCheck(PasswordVerify.m_levelOne, Me, frmShipment)

    End Sub

    Private Sub btnVolunteer_Click(sender As Object, e As EventArgs) Handles btnVolunteer.Click
        PasswordVerify.PassCheck(PasswordVerify.m_levelOne, Me, frmVolunteer)

    End Sub

    Private Sub btnDonate_Click(sender As Object, e As EventArgs) Handles btnDonate.Click
        PasswordVerify.PassCheck(PasswordVerify.m_levelOne, Me, frmDonations)

    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        PasswordVerify.PassCheck(PasswordVerify.m_levelOne, Me, frmReports)

    End Sub
    
    Private Sub btnAddCadet_Click(sender As Object, e As EventArgs) Handles btnAddCadet.Click
        PasswordVerify.PassCheck(PasswordVerify.m_levelOne, Me, frmNewCadet)
    End Sub
End Class