<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserManagement
    Inherits System.Windows.Forms.Form

    Private Sub InitializeComponent()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.dtpDOB = New System.Windows.Forms.DateTimePicker()
        Me.cmbGender = New System.Windows.Forms.ComboBox()
        Me.txtMembers = New System.Windows.Forms.TextBox()
        Me.cmbCardType = New System.Windows.Forms.ComboBox()
        Me.txtCardNo = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(120, 20)
        Me.txtName.Size = New System.Drawing.Size(200, 20)
        Me.txtName.PlaceholderText = "Name"
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(120, 50)
        '
        'dtpDOB
        '
        Me.dtpDOB.Location = New System.Drawing.Point(120, 80)
        '
        'cmbGender
        '
        Me.cmbGender.Location = New System.Drawing.Point(120, 110)
        Me.cmbGender.Items.AddRange(New Object() {"Male", "Female", "Other"})
        '
        'txtMembers
        '
        Me.txtMembers.Location = New System.Drawing.Point(120, 140)
        '
        'cmbCardType
        '
        Me.cmbCardType.Location = New System.Drawing.Point(120, 170)
        Me.cmbCardType.Items.AddRange(New Object() {"APL", "BPL"})
        '
        'txtCardNo
        '
        Me.txtCardNo.Location = New System.Drawing.Point(120, 200)
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(120, 230)
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(120, 260)
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(120, 290)
        Me.txtPassword.PasswordChar = "*"c
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(150, 330)
        Me.btnAdd.Text = "Add User"
        '
        'UserManagement
        '
        Me.ClientSize = New System.Drawing.Size(400, 400)
        Me.Controls.AddRange(New Control() {txtName, txtPhone, dtpDOB, cmbGender, txtMembers, cmbCardType, txtCardNo, txtAddress, txtUsername, txtPassword, btnAdd})
        Me.Text = "User Management"
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents dtpDOB As DateTimePicker
    Friend WithEvents cmbGender As ComboBox
    Friend WithEvents txtMembers As TextBox
    Friend WithEvents cmbCardType As ComboBox
    Friend WithEvents txtCardNo As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnAdd As Button
End Class
