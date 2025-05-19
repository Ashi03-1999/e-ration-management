<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExitConfirmation
    Inherits System.Windows.Forms.Form

    Private Sub InitializeComponent()
        Me.btnYes = New System.Windows.Forms.Button()
        Me.btnNo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnYes
        '
        Me.btnYes.Location = New System.Drawing.Point(50, 50)
        Me.btnYes.Text = "Yes"
        '
        'btnNo
        '
        Me.btnNo.Location = New System.Drawing.Point(150, 50)
        Me.btnNo.Text = "No"
        '
        'ExitConfirmation
        '
        Me.ClientSize = New System.Drawing.Size(300, 150)
        Me.Controls.Add(Me.btnYes)
        Me.Controls.Add(Me.btnNo)
        Me.Text = "Are you sure you want to exit?"
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents btnYes As Button
    Friend WithEvents btnNo As Button
End Class
