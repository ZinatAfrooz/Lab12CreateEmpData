<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtMiddleName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtEmpNum = New System.Windows.Forms.TextBox()
        Me.txtTelNumber = New System.Windows.Forms.TextBox()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblMiddleName = New System.Windows.Forms.Label()
        Me.lblEmpNum = New System.Windows.Forms.Label()
        Me.lblTelNum = New System.Windows.Forms.Label()
        Me.cmbDepartment = New System.Windows.Forms.ComboBox()
        Me.lblDepartment = New System.Windows.Forms.Label()
        Me.txtExtension = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblExtension = New System.Windows.Forms.Label()
        Me.lblEmailAddress = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter Employee Data"
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(53, 49)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(57, 13)
        Me.lblFirstName.TabIndex = 1
        Me.lblFirstName.Text = "First Name"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(130, 49)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(100, 20)
        Me.txtFirstName.TabIndex = 2
        '
        'txtMiddleName
        '
        Me.txtMiddleName.Location = New System.Drawing.Point(130, 89)
        Me.txtMiddleName.Name = "txtMiddleName"
        Me.txtMiddleName.Size = New System.Drawing.Size(100, 20)
        Me.txtMiddleName.TabIndex = 3
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(130, 125)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(100, 20)
        Me.txtLastName.TabIndex = 4
        '
        'txtEmpNum
        '
        Me.txtEmpNum.Location = New System.Drawing.Point(130, 163)
        Me.txtEmpNum.Name = "txtEmpNum"
        Me.txtEmpNum.Size = New System.Drawing.Size(100, 20)
        Me.txtEmpNum.TabIndex = 5
        '
        'txtTelNumber
        '
        Me.txtTelNumber.Location = New System.Drawing.Point(130, 241)
        Me.txtTelNumber.Name = "txtTelNumber"
        Me.txtTelNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtTelNumber.TabIndex = 6
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(52, 132)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(58, 13)
        Me.lblLastName.TabIndex = 7
        Me.lblLastName.Text = "Last Name"
        '
        'lblMiddleName
        '
        Me.lblMiddleName.AutoSize = True
        Me.lblMiddleName.Location = New System.Drawing.Point(41, 96)
        Me.lblMiddleName.Name = "lblMiddleName"
        Me.lblMiddleName.Size = New System.Drawing.Size(69, 13)
        Me.lblMiddleName.TabIndex = 8
        Me.lblMiddleName.Text = "Middle Name"
        '
        'lblEmpNum
        '
        Me.lblEmpNum.AutoSize = True
        Me.lblEmpNum.Location = New System.Drawing.Point(17, 170)
        Me.lblEmpNum.Name = "lblEmpNum"
        Me.lblEmpNum.Size = New System.Drawing.Size(93, 13)
        Me.lblEmpNum.TabIndex = 9
        Me.lblEmpNum.Text = "Employee Number"
        '
        'lblTelNum
        '
        Me.lblTelNum.AutoSize = True
        Me.lblTelNum.Location = New System.Drawing.Point(12, 248)
        Me.lblTelNum.Name = "lblTelNum"
        Me.lblTelNum.Size = New System.Drawing.Size(98, 13)
        Me.lblTelNum.TabIndex = 10
        Me.lblTelNum.Text = "Telephone Number"
        '
        'cmbDepartment
        '
        Me.cmbDepartment.FormattingEnabled = True
        Me.cmbDepartment.Items.AddRange(New Object() {"Accounting", "Administration", "Marketing", "MIS", "Sales"})
        Me.cmbDepartment.Location = New System.Drawing.Point(130, 205)
        Me.cmbDepartment.Name = "cmbDepartment"
        Me.cmbDepartment.Size = New System.Drawing.Size(121, 21)
        Me.cmbDepartment.TabIndex = 11
        '
        'lblDepartment
        '
        Me.lblDepartment.AutoSize = True
        Me.lblDepartment.Location = New System.Drawing.Point(53, 213)
        Me.lblDepartment.Name = "lblDepartment"
        Me.lblDepartment.Size = New System.Drawing.Size(62, 13)
        Me.lblDepartment.TabIndex = 12
        Me.lblDepartment.Text = "Department"
        '
        'txtExtension
        '
        Me.txtExtension.Location = New System.Drawing.Point(130, 281)
        Me.txtExtension.Name = "txtExtension"
        Me.txtExtension.Size = New System.Drawing.Size(100, 20)
        Me.txtExtension.TabIndex = 13
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(130, 322)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(100, 20)
        Me.txtEmail.TabIndex = 14
        '
        'lblExtension
        '
        Me.lblExtension.AutoSize = True
        Me.lblExtension.Location = New System.Drawing.Point(48, 288)
        Me.lblExtension.Name = "lblExtension"
        Me.lblExtension.Size = New System.Drawing.Size(53, 13)
        Me.lblExtension.TabIndex = 15
        Me.lblExtension.Text = "Extension"
        '
        'lblEmailAddress
        '
        Me.lblEmailAddress.AutoSize = True
        Me.lblEmailAddress.Location = New System.Drawing.Point(48, 329)
        Me.lblEmailAddress.Name = "lblEmailAddress"
        Me.lblEmailAddress.Size = New System.Drawing.Size(73, 13)
        Me.lblEmailAddress.TabIndex = 16
        Me.lblEmailAddress.Text = "Email Address"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(55, 375)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 17
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(176, 375)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 18
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(300, 375)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 19
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 415)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblEmailAddress)
        Me.Controls.Add(Me.lblExtension)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtExtension)
        Me.Controls.Add(Me.lblDepartment)
        Me.Controls.Add(Me.cmbDepartment)
        Me.Controls.Add(Me.lblTelNum)
        Me.Controls.Add(Me.lblEmpNum)
        Me.Controls.Add(Me.lblMiddleName)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.txtTelNumber)
        Me.Controls.Add(Me.txtEmpNum)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtMiddleName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Employee Data"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtMiddleName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtEmpNum As TextBox
    Friend WithEvents txtTelNumber As TextBox
    Friend WithEvents lblLastName As Label
    Friend WithEvents lblMiddleName As Label
    Friend WithEvents lblEmpNum As Label
    Friend WithEvents lblTelNum As Label
    Friend WithEvents cmbDepartment As ComboBox
    Friend WithEvents lblDepartment As Label
    Friend WithEvents txtExtension As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblExtension As Label
    Friend WithEvents lblEmailAddress As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
