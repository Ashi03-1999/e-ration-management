Imports System.Data.SqlClient

Public Class UserManagement
    Dim con As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\RationDataBase.mdf;Integrated Security=True;User Instance=True")
    Dim cmd As New SqlCommand

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        con.Open()
        cmd = New SqlCommand("INSERT INTO UserManagementTbl (Name, PhNo, DOB, Gender, NoOfMembers, CardType, RationCardNo, Address, Username, Password) VALUES 
        ('" & txtName.Text & "', '" & txtPhNo.Text & "', '" & dtpDOB.Value.Date & "', '" & cmbGender.Text & "', '" & txtMembers.Text & "', '" & cmbCardType.Text & "', '" & txtRationCardNo.Text & "', '" & txtAddress.Text & "', '" & txtUsername.Text & "', '" & txtPassword.Text & "')", con)
        cmd.ExecuteNonQuery()
        MsgBox("User added successfully", MsgBoxStyle.Information)
        con.Close()
        ClearForm()
    End Sub

    Private Sub ClearForm()
        txtName.Clear()
        txtPhNo.Clear()
        txtMembers.Clear()
        txtRationCardNo.Clear()
        txtAddress.Clear()
        txtUsername.Clear()
        txtPassword.Clear()
        cmbGender.SelectedIndex = -1
        cmbCardType.SelectedIndex = -1
        dtpDOB.Value = Now
    End Sub
End Class
