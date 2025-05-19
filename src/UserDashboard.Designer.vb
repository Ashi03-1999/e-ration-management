<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserDashboard
    Inherits System.Windows.Forms.Form

    Private Sub InitializeComponent()
        Me.btnPurchase = New System.Windows.Forms.Button()
        Me.btnHistory = New System.Windows.Forms.Button()
        Me.btnPriceList = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnPurchase
        '
        Me.btnPurchase.Location = New System.Drawing.Point(50, 40)
        Me.btnPurchase.Size = New System.Drawing.Size(150, 30)
        Me.btnPurchase.Text = "Purchase Ration"
        '
        'btnHistory
        '
        Me.btnHistory.Location = New System.Drawing.Point(50, 80)
        Me.btnHistory.Size = New System.Drawing.Size(150, 30)
        Me.btnHistory.Text = "Purchase History"
        '
        'btnPriceList
        '
        Me.btnPriceList.Location = New System.Drawing.Point(50, 120)
        Me.btnPriceList.Size = New System.Drawing.Size(150, 30)
        Me.btnPriceList.Text = "View Price List"
        '
        'UserDashboard
        '
        Me.ClientSize = New System.Drawing.Size(300, 200)
        Me.Controls.Add(Me.btnPurchase)
        Me.Controls.Add(Me.btnHistory)
        Me.Controls.Add(Me.btnPriceList)
        Me.Name = "UserDashboard"
        Me.Text = "User Dashboard"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnPurchase As Button
    Friend WithEvents btnHistory As Button
    Friend WithEvents btnPriceList As Button
End Class
