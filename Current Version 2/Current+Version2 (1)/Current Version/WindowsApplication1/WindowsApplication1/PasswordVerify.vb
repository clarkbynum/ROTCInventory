Public Class PasswordVerify
    Public Shared m_levelOne As String = "1"
    Public Shared m_levelTwo As String = "abc"
    Public Shared errorMessage As String = "Incorrect Entry.  Please re-enter"
    Public Shared errorTitle As String = "Incorrect Entry"
    Public Shared passMessage As String = "Please enter password"
    Public Shared passTitle As String = "Enter Password"
    Public Shared passFailed As String = "Too many incorrect attempts, program quitting"
    Public Shared defaultPass As String = "1"


    Public Shared Sub PassCheck(ByVal correctPass As String, ByVal currentForm As Form, ByVal nextForm As Form)
        Dim passResult As Integer
        Dim passAttempt As String

        passAttempt = InputBox(PasswordVerify.passMessage, PasswordVerify.passTitle, defaultPass)

        If passAttempt = correctPass Then
            passResult = 1
        ElseIf passAttempt = "" Then
            passResult = 0
        Else
            passAttempt = InputBox(errorMessage & ". Attempts Remaining: 2", errorTitle, defaultPass)
            If passAttempt = correctPass Then
                passResult = 1
            ElseIf passAttempt = "" Then
                passResult = 0
            Else
                passAttempt = InputBox(errorMessage & ". Attempts Remaining: 1", errorTitle, defaultPass)
                If passAttempt = correctPass Then
                    passResult = 1
                ElseIf passAttempt = "" Then
                    passResult = 0
                Else
                    passResult = -1
                End If
            End If
        End If

        If passResult = 1 Then
            nextForm.MdiParent = frmParent
            currentForm.Hide()
            nextForm.WindowState = FormWindowState.Maximized

            nextForm.Show()
            'nextForm.StartPosition = FormStartPosition.CenterParent
        ElseIf passResult = -1 Then
            MsgBox(PasswordVerify.passFailed)
            frmMain.Close()
        End If

    End Sub
End Class
