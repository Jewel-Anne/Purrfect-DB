Imports System.Data.SqlClient
Public Class MainForm
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        exec_proc_sp_sel_01()
    End Sub

    Public Sub exec_proc_sp_sel_01()
        Try
            connect()
            cmd = New SqlCommand("sp_sel_01", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandTimeout = 0
            cmd.Parameters.AddWithValue("@clientname", txtSearch.Text)
            rdr = cmd.ExecuteReader

            dgvTable.Rows.Clear()
            While rdr.Read
                dgvTable.Rows.Add(rdr.Item("id").ToString, rdr.Item("clientname").ToString, rdr.Item("contactno").ToString, rdr.Item("address").ToString, rdr.Item("petname").ToString, rdr.Item("age").ToString, rdr.Item("breed").ToString, rdr.Item("color").ToString, rdr.Item("sex").ToString, rdr.Item("species").ToString, rdr.Item("Date").ToString, rdr.Item("time").ToString, rdr.Item("services").ToString, rdr.Item("totalpayment").ToString)
            End While
            dgvTable.ClearSelection()
        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbExclamation, "Message")
        End Try
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        exec_proc_sp_sel_01()
    End Sub

    Private Sub dgvTable_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTable.CellDoubleClick
        If e.RowIndex >= 0 Then
            With Details
                .txtId.Text = dgvTable.CurrentRow.Cells("id").Value
                .txtClientname.Text = dgvTable.CurrentRow.Cells("clientname").Value
                .txtContact.Text = dgvTable.CurrentRow.Cells("contactno").Value
                .txtAddress.Text = dgvTable.CurrentRow.Cells("address").Value
                .txtPetname.Text = dgvTable.CurrentRow.Cells("petname").Value
                .txtAge.Text = dgvTable.CurrentRow.Cells("age").Value
                .txtBreed.Text = dgvTable.CurrentRow.Cells("breed").Value
                .txtColor.Text = dgvTable.CurrentRow.Cells("color").Value
                If dgvTable.CurrentRow.Cells("sex").Value = "Male" Then
                    .rbMale.Checked = True
                ElseIf dgvTable.CurrentRow.Cells("sex").Value = "Female" Then
                    .rbFemale.Checked = True
                End If
                .txtSpecies.Text = dgvTable.CurrentRow.Cells("species").Value
                .dtpDate.Text = dgvTable.CurrentRow.Cells("coldate").Value
                .dtpTime.Text = dgvTable.CurrentRow.Cells("coltime").Value
                .cmbServices.Text = dgvTable.CurrentRow.Cells("services").Value
                .txtTotal.Text = dgvTable.CurrentRow.Cells("total").Value
                .btnSave.Enabled = False
                .ShowDialog()
            End With
        End If
    End Sub

    Private Sub lblX_Click(sender As Object, e As EventArgs) Handles lblX.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        With Details
            .btnUpdate.Enabled = False
            .btnDelete.Enabled = False
            .exec_proc_sp_sel_02()
            .ShowDialog()
        End With
    End Sub

    Private Sub dgvTable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTable.CellContentClick

    End Sub
End Class