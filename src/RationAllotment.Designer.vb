<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RationAllotment
    Inherits System.Windows.Forms.Form

    Private Sub InitializeComponent()
        Me.txtCardNo = New System.Windows.Forms.TextBox()
        Me.cmbCardType = New System.Windows.Forms.ComboBox()
        Me.txtItems = New System.Windows.Forms.TextBox()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.btnAllot = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtCardNo
        '
        Me.txtCardNo.Location = New System.Drawing.Point(120, 30)
        '
        'cmbCardType
        '
        Me.cmbCardType.Location = New System.Drawing.Point(120, 70)
        Me.cmbCardType.Items.AddRange(New Object() {"APL", "BPL"})
        '
        'txtItems
        '
        Me.txtItems.Location = New System.Drawing.Point(120, 110)
        '
        'dtpDate
        '
        Me.dtpDate.Location = New System.Drawing.Point(120, 150)
        '
        'btnAllot
        '
        Me.btnAllot.Location = New System.Drawing.Point(150, 190)
        Me.btnAllot.Text = "Allot Ration"
        '
        'RationAllotment
        '
        Me.ClientSize = New System.Drawing.Size(400, 250)
        Me.Controls.AddRange(New Control() {txtCardNo, cmbCardType, txtItems, dtpDate, btnAllot})
        Me.Text = "Ration Allotment"
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents txtCardNo As TextBox
    Friend WithEvents cmbCardType As ComboBox
    Friend WithEvents txtItems As TextBox
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents btnAllot As Button
End Class

