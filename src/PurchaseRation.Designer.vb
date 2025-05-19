<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PurchaseRation
    Inherits System.Windows.Forms.Form

    Private Sub InitializeComponent()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtItem = New System.Windows.Forms.TextBox()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.btnBuy = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnBuy
        '
        Me.btnBuy.Location = New System.Drawing.Point(150, 180)
        Me.btnBuy.Text = "Purchase"
        '
        'PurchaseRation
        '
        Me.ClientSize = New System.Drawing.Size(400, 240)
        Me.Controls.AddRange(New Control() {txtUsername, txtItem, txtQty, dtpDate, btnBuy})
        Me.Text = "Purchase Ration"
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtItem As TextBox
    Friend WithEvents txtQty As TextBox
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents btnBuy As Button
End Class
