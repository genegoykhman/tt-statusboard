<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
		Me.Label1 = New System.Windows.Forms.Label
		Me.GroupBox1 = New System.Windows.Forms.GroupBox
		Me.cmdTestConnection = New System.Windows.Forms.Button
		Me.Label6 = New System.Windows.Forms.Label
		Me.Label5 = New System.Windows.Forms.Label
		Me.Label4 = New System.Windows.Forms.Label
		Me.txtPassword = New System.Windows.Forms.TextBox
		Me.txtUser = New System.Windows.Forms.TextBox
		Me.txtURL = New System.Windows.Forms.TextBox
		Me.GroupBox1.SuspendLayout()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(12, 19)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(146, 13)
		Me.Label1.TabIndex = 2
		Me.Label1.Text = "TimeTiger StatusBoard Query"
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.cmdTestConnection)
		Me.GroupBox1.Controls.Add(Me.Label6)
		Me.GroupBox1.Controls.Add(Me.Label5)
		Me.GroupBox1.Controls.Add(Me.Label4)
		Me.GroupBox1.Controls.Add(Me.txtPassword)
		Me.GroupBox1.Controls.Add(Me.txtUser)
		Me.GroupBox1.Controls.Add(Me.txtURL)
		Me.GroupBox1.Location = New System.Drawing.Point(15, 47)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(473, 116)
		Me.GroupBox1.TabIndex = 0
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "TimeTiger Server Connection"
		'
		'cmdTestConnection
		'
		Me.cmdTestConnection.Location = New System.Drawing.Point(305, 25)
		Me.cmdTestConnection.Name = "cmdTestConnection"
		Me.cmdTestConnection.Size = New System.Drawing.Size(150, 46)
		Me.cmdTestConnection.TabIndex = 4
		Me.cmdTestConnection.Text = "Test connection"
		Me.cmdTestConnection.UseVisualStyleBackColor = True
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Location = New System.Drawing.Point(6, 80)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(53, 13)
		Me.Label6.TabIndex = 8
		Me.Label6.Text = "Password"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(6, 54)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(29, 13)
		Me.Label5.TabIndex = 7
		Me.Label5.Text = "User"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(6, 28)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(29, 13)
		Me.Label4.TabIndex = 6
		Me.Label4.Text = "URL"
		'
		'txtPassword
		'
		Me.txtPassword.Location = New System.Drawing.Point(65, 77)
		Me.txtPassword.Name = "txtPassword"
		Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
		Me.txtPassword.Size = New System.Drawing.Size(127, 20)
		Me.txtPassword.TabIndex = 3
		'
		'txtUser
		'
		Me.txtUser.Location = New System.Drawing.Point(65, 51)
		Me.txtUser.Name = "txtUser"
		Me.txtUser.Size = New System.Drawing.Size(127, 20)
		Me.txtUser.TabIndex = 2
		Me.txtUser.Text = "DAVE"
		'
		'txtURL
		'
		Me.txtURL.Location = New System.Drawing.Point(65, 25)
		Me.txtURL.Name = "txtURL"
		Me.txtURL.Size = New System.Drawing.Size(234, 20)
		Me.txtURL.TabIndex = 1
		Me.txtURL.Text = "https://www.timetiger.com/online/sample"
		'
		'frmMain
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(498, 181)
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.Label1)
		Me.Name = "frmMain"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "TimeTiger StatusBoard tool"
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
	Friend WithEvents txtUser As System.Windows.Forms.TextBox
	Friend WithEvents txtURL As System.Windows.Forms.TextBox
	Friend WithEvents Label6 As System.Windows.Forms.Label
	Friend WithEvents Label5 As System.Windows.Forms.Label
	Friend WithEvents Label4 As System.Windows.Forms.Label
	Friend WithEvents txtPassword As System.Windows.Forms.TextBox
	Friend WithEvents cmdTestConnection As System.Windows.Forms.Button

End Class
