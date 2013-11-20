Imports System
Imports System.Data
Imports System.Data.SqlClient
Public Class frmNewCadet


    Private Sub frmCadetNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ProjectData1DataSet.Cadet' table. You can move, or remove it, as needed.
        Me.CadetTableAdapter.Fill(Me.ProjectData1DataSet.Cadet)

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'Me.Close()
        'frm3Password.Show()
    End Sub
    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        'Clear text and combo boxes, and datagrid
        txtID.Clear()
        txtFName.Clear()
        txtLName.Clear()
        txtPhone.Clear()
        txtEmail.Clear()
        cmbUniform = Nothing
        cmbItem = Nothing
        cmbSize = Nothing

        'Return to Action Form
        Me.Close()
        frmAction.Show()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        Dim index As Integer
        index = CadetDataGridView.SelectedRows.Item(0).Index


        'Clear text and combo boxes, and datagrid
        txtID.Clear()
        txtFName.Clear()
        txtLName.Clear()
        txtPhone.Clear()
        txtEmail.Clear()
        cmbUniform = Nothing
        cmbItem = Nothing
        cmbSize = Nothing


        'focus to ID
        txtID.Focus()

    End Sub

    Private Sub CadetBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CadetBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CadetBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ProjectData1DataSet)

    End Sub

    Private Sub Add_Click(sender As Object, e As EventArgs) Handles Add.Click



        Dim newCadetRow As ProjectData1DataSet.CadetRow
        newCadetRow = Me.ProjectData1DataSet.Cadet.NewCadetRow

        newCadetRow.CadetID = txtID.Text
        newCadetRow.LastName = txtLName.Text
        newCadetRow.FirstName = txtFName.Text
        newCadetRow.Rank = txtRank.Text
        newCadetRow.Phone = txtPhone.Text
        newCadetRow.Email = txtEmail.Text
        newCadetRow.MiddleInitial = "x"

        Me.ProjectData1DataSet.Cadet.Rows.Add(newCadetRow)
        Me.CadetTableAdapter.Update(Me.ProjectData1DataSet.Cadet)

        Me.ProjectData1DataSet.AcceptChanges()
        Me.Validate()
        Me.CadetBindingSource.EndEdit()

        Me.TableAdapterManager.UpdateAll(Me.ProjectData1DataSet)
        txtID.Clear()
        txtRank.Clear()
        txtFName.Clear()
        txtLName.Clear()
        txtPhone.Clear()
        txtEmail.Clear()
        cmbUniform = Nothing
        cmbItem = Nothing
        cmbSize = Nothing


        'focus to ID
        txtID.Focus()
    End Sub
End Class