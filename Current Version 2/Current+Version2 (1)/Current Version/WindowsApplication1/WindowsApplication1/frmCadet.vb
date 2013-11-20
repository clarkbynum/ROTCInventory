Public Class frmCadet
 
Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
    'Add new cadet to system
    Me.Close()
        PasswordVerify.PassCheck(PasswordVerify.m_levelOne, Me, frmNewCadet)
        'frmNewCadet.Show()
End Sub

Private Sub btnSave_Click(sender As Object, e As EventArgs)
    Me.Close()
    frmAction.Show()
End Sub

Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        'Me.Hide()
        'frm2Password.Show()
End Sub
Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnBack.Click
    'All data fields are cleared
    cmbID = Nothing
    txtRank.Clear()
    txtFName.Clear()
    txtLName.Clear()
    txtPhone.Clear()
    txtEmail.Clear()



    'Return to Action Form
    Me.Close()
    frmAction.Show()
End Sub

    Private Sub btnCadet_Click(sender As Object, e As EventArgs) Handles btnCadet.Click
        Dim cadets As DataTable = ProjectData1DataSet.Cadet
        Dim qryEmail = From cadet In ProjectData1DataSet.Cadet
                  Where cadet.CadetID = cmbID.Text
                  Select cadet.Email
        Dim qryLname = From cadet In ProjectData1DataSet.Cadet
              Where cadet.CadetID = cmbID.Text
             Select cadet.LastName

        Dim qryFname = From cadet In ProjectData1DataSet.Cadet
                  Where cadet.CadetID = cmbID.Text
                  Select cadet.FirstName

        Dim qryRank = From cadet In ProjectData1DataSet.Cadet
       Where cadet.CadetID = cmbID.Text
       Select cadet.Rank

        Dim qryPhone = From cadet In ProjectData1DataSet.Cadet
                 Where cadet.CadetID = cmbID.Text
                 Select cadet.Phone
        If cmbID.Text = "00638431" Then
            Me.Clothing_TypeTableAdapter.Fill(Me.ProjectData1DataSet.Clothing_Type)
        End If


        Try
            txtEmail.Text = qryEmail.FirstOrDefault.ToString()
            txtPhone.Text = qryPhone.FirstOrDefault.ToString()
            txtFName.Text = qryFname.FirstOrDefault.ToString()
            txtLName.Text = qryLname.FirstOrDefault.ToString()
            txtRank.Text = qryRank.FirstOrDefault.ToString()
        Catch ex As Exception

        End Try



    End Sub

Private Sub CadetBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
    Me.Validate()
    Me.CadetBindingSource.EndEdit()
    Me.TableAdapterManager.UpdateAll(Me.ProjectData1DataSet)

End Sub

    Private Sub frmCadet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ProjectData1DataSet.Clothing_Type' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'ProjectData1DataSet.Cadet' table. You can move, or remove it, as needed.
        Me.CadetTableAdapter.Fill(Me.ProjectData1DataSet.Cadet)

        cmbID.Text = ""

    End Sub





  
End Class
