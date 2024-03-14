Imports System.Data.SqlClient


Public Class Details
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If txtClientname.Text = Nothing Then
            MsgBox("Client Name is empty.", vbOKOnly + vbExclamation, "Message")
        ElseIf txtContact.Text = Nothing Then
            MsgBox("Contact Number is empty.", vbOKOnly + vbExclamation, "Message")
        ElseIf txtAddress.Text = Nothing Then
            MsgBox("Address is empty.", vbOKOnly + vbExclamation, "Message")
        ElseIf txtPetname.Text = Nothing Then
            MsgBox("Pet Name is empty.", vbOKOnly + vbExclamation, "Message")
        ElseIf txtAge.Text = Nothing Then
            MsgBox("Age is empty.", vbOKOnly + vbExclamation, "Message")
        ElseIf txtBreed.Text = Nothing Then
            MsgBox("Breed is empty.", vbOKOnly + vbExclamation, "Message")
        ElseIf txtColor.Text = Nothing Then
            MsgBox("Color is empty.", vbOKOnly + vbExclamation, "Message")
        ElseIf txtSpecies.Text = Nothing Then
            MsgBox("Species is empty.", vbOKOnly + vbExclamation, "Message")
        ElseIf cmbServices.Text = Nothing Then
            MsgBox("Services is empty.", vbOKOnly + vbExclamation, "Message")
        ElseIf txtTotal.Text = Nothing Then
            MsgBox("Total Payment is empty.", vbOKOnly + vbExclamation, "Message")
        Else
            Dim answer As VariantType
            answer = MsgBox("Do you want to save this record?", vbYesNo + vbQuestion, "Message")
            If answer = vbYes Then
                exec_proc_sp_ins_01()
            End If
        End If

    End Sub

    Public Sub exec_proc_sp_ins_01()
        Try
            connect()
            cmd = New SqlCommand("sp_ins_01", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandTimeout = 0
            cmd.Parameters.AddWithValue("@clientname", txtClientname.Text)
            cmd.Parameters.AddWithValue("@contactno", txtContact.Text)
            cmd.Parameters.AddWithValue("@address", txtAddress.Text)
            cmd.Parameters.AddWithValue("@petname", txtPetname.Text)
            cmd.Parameters.AddWithValue("@age", txtAge.Text)
            cmd.Parameters.AddWithValue("@breed", txtBreed.Text)
            cmd.Parameters.AddWithValue("@color", txtColor.Text)
            If rbMale.Checked Then
                cmd.Parameters.AddWithValue("@sex", rbMale.Text)
            ElseIf rbFemale.Checked Then
                cmd.Parameters.AddWithValue("@sex", rbFemale.Text)
            End If
            cmd.Parameters.AddWithValue("@species", txtSpecies.Text)
            cmd.Parameters.AddWithValue("@date", dtpDate.Text)
            cmd.Parameters.AddWithValue("@time", dtpTime.Text)
            cmd.Parameters.AddWithValue("@services", cmbServices.Text)
            cmd.Parameters.AddWithValue("@totalpayment", txtTotal.Text)
            cmd.ExecuteNonQuery()
            MsgBox("Record has been saved.", vbOKOnly + vbInformation, "Message")
            MainForm.exec_proc_sp_sel_01()
            Me.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbExclamation, "Message")
        End Try
    End Sub

    Public Sub exec_proc_sp_sel_02()
        Try
            connect()
            cmd = New SqlCommand("sp_sel_02", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandTimeout = 0
            rdr = cmd.ExecuteReader

            If rdr.Read Then
                txtId.Text = rdr.Item("id")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbExclamation, "Message")
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtClientname.Text = Nothing Then
            MsgBox("Client Name is empty.", vbOKOnly + vbExclamation, "Message")
        ElseIf txtContact.Text = Nothing Then
            MsgBox("Contact Number is empty.", vbOKOnly + vbExclamation, "Message")
        ElseIf txtAddress.Text = Nothing Then
            MsgBox("Address is empty.", vbOKOnly + vbExclamation, "Message")
        ElseIf txtPetname.Text = Nothing Then
            MsgBox("Pet Name is empty.", vbOKOnly + vbExclamation, "Message")
        ElseIf txtAge.Text = Nothing Then
            MsgBox("Age is empty.", vbOKOnly + vbExclamation, "Message")
        ElseIf txtBreed.Text = Nothing Then
            MsgBox("Breed is empty.", vbOKOnly + vbExclamation, "Message")
        ElseIf txtColor.Text = Nothing Then
            MsgBox("Color is empty.", vbOKOnly + vbExclamation, "Message")
        ElseIf txtSpecies.Text = Nothing Then
            MsgBox("Species is empty.", vbOKOnly + vbExclamation, "Message")
        ElseIf cmbServices.Text = Nothing Then
            MsgBox("Services is empty.", vbOKOnly + vbExclamation, "Message")
        ElseIf txtTotal.Text = Nothing Then
            MsgBox("Total Payment is empty.", vbOKOnly + vbExclamation, "Message")
        Else
            Dim answer As VariantType
            answer = MsgBox("Do you want to save this record?", vbYesNo + vbQuestion, "Message")
            If answer = vbYes Then
                exec_proc_sp_upd_01()
            End If
        End If

    End Sub

    Public Sub exec_proc_sp_upd_01()
        Try
            connect()
            cmd = New SqlCommand("sp_upd_01", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandTimeout = 0
            cmd.Parameters.AddWithValue("@id", txtId.Text)
            cmd.Parameters.AddWithValue("@clientname", txtClientname.Text)
            cmd.Parameters.AddWithValue("@contactno", txtContact.Text)
            cmd.Parameters.AddWithValue("@address", txtAddress.Text)
            cmd.Parameters.AddWithValue("@petname", txtPetname.Text)
            cmd.Parameters.AddWithValue("@age", txtAge.Text)
            cmd.Parameters.AddWithValue("@breed", txtBreed.Text)
            cmd.Parameters.AddWithValue("@color", txtColor.Text)
            If rbMale.Checked Then
                cmd.Parameters.AddWithValue("@sex", rbMale.Text)
            ElseIf rbFemale.Checked Then
                cmd.Parameters.AddWithValue("@sex", rbFemale.Text)
            End If
            cmd.Parameters.AddWithValue("@species", txtSpecies.Text)
            cmd.Parameters.AddWithValue("@date", dtpDate.Text)
            cmd.Parameters.AddWithValue("@time", dtpTime.Text)
            cmd.Parameters.AddWithValue("@services", cmbServices.Text)
            cmd.Parameters.AddWithValue("@totalpayment", txtTotal.Text)
            cmd.ExecuteNonQuery()
            MsgBox("Record has been updated.", vbOKOnly + vbInformation, "Message")
            MainForm.exec_proc_sp_sel_01()
            Me.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbExclamation, "Message")
        End Try
    End Sub


    Public Sub exec_proc_sp_del_01()
        Try
            connect()
            cmd = New SqlCommand("sp_del_01", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandTimeout = 0
            cmd.Parameters.AddWithValue("@id", txtId.Text)
            cmd.ExecuteNonQuery()
            MsgBox("Record has been deleted.", vbOKOnly + vbInformation, "Message")
            MainForm.exec_proc_sp_sel_01()
            Me.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbExclamation, "Message")
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim answer As VariantType
        answer = MsgBox("Do you want to delete this record?", vbYesNo + vbQuestion, "Message")
        If answer = vbYes Then
            exec_proc_sp_del_01()
        End If

    End Sub

    Private Sub Details_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub

    Private Sub cmbServices_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbServices.SelectedIndexChanged
        If cmbServices.Text = "Grooming" Then
            lblPrice.Text = "500.00"
        ElseIf cmbServices.Text = "Vaccination" Then
            lblPrice.Text = "700.00"
        ElseIf cmbServices.Text = "Wound Treatment" Then
            lblPrice.Text = "200.00"
        ElseIf cmbServices.Text = "X-Ray" Then
            lblPrice.Text = "300.00"
        ElseIf cmbServices.Text = "Deworming Care" Then
            lblPrice.Text = "250.00"
        ElseIf cmbServices.Text = "Dental Care" Then
            lblPrice.Text = "1000.00"
        ElseIf cmbServices.Text = "Tick and Fleas Care" Then
            lblPrice.Text = "350.00"
        ElseIf cmbServices.Text = "Spay/Neuter" Then
            lblPrice.Text = "300.00"
        End If







    End Sub

    Private Sub BackgroundWorker2_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class