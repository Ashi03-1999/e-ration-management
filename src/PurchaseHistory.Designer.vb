<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PurchaseHistory
    Inherits System.Windows.Forms.Form

    Private Sub InitializeComponent()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.Dock = DockStyle.Fill
        Me.DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        '
        'PurchaseHistory
        '
        Me.ClientSize = New System.Drawing.Size(500, 300)
        Me.Controls.Add(Me.DataGridView1)
        Me.Text = "Purchase History"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
End Class
