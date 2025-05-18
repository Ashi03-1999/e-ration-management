Imports System.Data.SqlClient

Public Class PurchaseRation
    Dim con As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\RationDataBase.mdf;Integrated Security=True;User Instance=True")

    Private Sub btnBuy_Click(sender As Object, e As EventArgs) Handles btnBuy.Click
        con.Open()
        Dim cmd As New SqlCommand("INSERT INTO PurchaseTbl (Username, ItemName, Quantity, PurchaseDate) VALUES (@u, @i, @q, @d)", con)
        cmd.Parameters.AddWithValue("@u", txtUsername.Text)
        cmd.Parameters.AddWithValue("@i", txtItem.Text)
        cmd.Parameters.AddWithValue("@q", txtQty.Text)
        cmd.Parameters.AddWithValue("@d", dtpDate.Value)
        cmd.ExecuteNonQuery()
        MsgBox("Purchase Recorded", MsgBoxStyle.Information)
        con.Close()
    End Sub
End Class
