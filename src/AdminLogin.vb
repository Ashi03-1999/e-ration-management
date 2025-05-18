Imports System.Data.SqlClient

Public Class AdminLogin
    Dim con As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\RationDataBase.mdf;Integrated Security=True;User Instance=True")
    Dim cmd As New SqlCommand

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        con.Open()
        cmd = New SqlCommand("SELECT * FROM AdminTbl WHERE Username = '" & txtUsername.Text & "' AND Password = '" & txtPassword.Text & "'", con)
        Dim dr As SqlDataReader = cmd.ExecuteReader()
        If dr.Read() Then
            MsgBox("Login Successful", MsgBoxStyle.Information)
            AdminDashboard.Show()
            Me.Hide()
        Else
            MsgBox("Invalid username or password", MsgBoxStyle.Critical)
        End If
        con.Close()
    End Sub
End Class
