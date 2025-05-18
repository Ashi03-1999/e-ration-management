Imports System.Data.SqlClient

Public Class PurchaseHistory
    Dim con As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\RationDataBase.mdf;Integrated Security=True;User Instance=True")

    Private Sub PurchaseHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.Open()
        Dim da As New SqlDataAdapter("SELECT * FROM PurchaseTbl WHERE Username = 'testuser'", con) ' Replace 'testuser' with actual user
        Dim dt As New DataTable()
        da.Fill(dt)
        DataGridView1.DataSource = dt
        con.Close()
    End Sub
End Class
