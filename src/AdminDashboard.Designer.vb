<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminDashboard
    Inherits System.Windows.Forms.Form

    Private Sub InitializeComponent()
        Me.btnUserMgmt = New System.Windows.Forms.Button()
        Me.btnPriceList = New System.Windows.Forms.Button()
        Me.btnAllotRation = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnUserMgmt
        '
        Me.btnUserMgmt.Location = New System.Drawing.Point(50, 40)
        Me.btnUserMgmt.Size = New System.Drawing.Size(150, 30)
        Me.btnUserMgmt.Text = "User Management"
        '
        'btnPriceList
        '
        Me.btnPriceList.Location = New System.Drawing.Point(50, 80)
        Me.btnPriceList.Size = New System.Drawing.Size(150, 30)
        Me.btnPriceList.Text = "Price List"
        '
        'btnAllotRation
        '
        Me.btnAllotRation.Location = New System.Drawing.Point(50, 120)
        Me.btnAllotRation.Size = New System.Drawing.Size(150, 30)
        Me.btnAllotRation.Text = "Allot Ration"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(50, 160)
        Me.btnExit.Size = New System.Drawing.Size(150, 30)
        Me.btnExit.Text = "Exit"
        '
        'AdminDashboard
        '
        Me.ClientSize = New System.Drawing.Size(300, 250)
        Me.Controls.Add(Me.btnUserMgmt)
        Me.Controls.Add(Me.btnPriceList)
        Me.Controls.Add(Me.btnAllotRation)
        Me.Controls.Add(Me.btnExit)
        Me.Name = "AdminDashboard"
        Me.Text = "Admin Dashboard"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnUserMgmt As Button
    Friend WithEvents btnPriceList As Button
    Friend WithEvents btnAllotRation As Button
    Friend WithEvents btnExit As Button
End Class
