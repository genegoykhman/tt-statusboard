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
		Me.GroupBox1 = New System.Windows.Forms.GroupBox
		Me.cmdTestConnection = New System.Windows.Forms.Button
		Me.Label6 = New System.Windows.Forms.Label
		Me.Label5 = New System.Windows.Forms.Label
		Me.Label4 = New System.Windows.Forms.Label
		Me.txtPassword = New System.Windows.Forms.TextBox
		Me.txtUser = New System.Windows.Forms.TextBox
		Me.txtURL = New System.Windows.Forms.TextBox
		Me.frameData = New System.Windows.Forms.GroupBox
		Me.chkTodayByCategory = New System.Windows.Forms.CheckBox
		Me.chkTodayByProject = New System.Windows.Forms.CheckBox
		Me.chkTodayByClient = New System.Windows.Forms.CheckBox
		Me.GroupBox2 = New System.Windows.Forms.GroupBox
		Me.Label1 = New System.Windows.Forms.Label
		Me.txtDestinationFolder = New System.Windows.Forms.TextBox
		Me.cmdUpdateNow = New System.Windows.Forms.Button
		Me.chk30DayByCategory = New System.Windows.Forms.CheckBox
		Me.chk30DayByProject = New System.Windows.Forms.CheckBox
		Me.chk30DayByClient = New System.Windows.Forms.CheckBox
		Me.GroupBox1.SuspendLayout()
		Me.frameData.SuspendLayout()
		Me.GroupBox2.SuspendLayout()
		Me.SuspendLayout()
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
		Me.GroupBox1.Location = New System.Drawing.Point(13, 12)
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
		'frameData
		'
		Me.frameData.Controls.Add(Me.chk30DayByCategory)
		Me.frameData.Controls.Add(Me.chk30DayByProject)
		Me.frameData.Controls.Add(Me.chk30DayByClient)
		Me.frameData.Controls.Add(Me.chkTodayByCategory)
		Me.frameData.Controls.Add(Me.chkTodayByProject)
		Me.frameData.Controls.Add(Me.chkTodayByClient)
		Me.frameData.Location = New System.Drawing.Point(14, 198)
		Me.frameData.Name = "frameData"
		Me.frameData.Size = New System.Drawing.Size(473, 95)
		Me.frameData.TabIndex = 1
		Me.frameData.TabStop = False
		Me.frameData.Text = "Data"
		'
		'chkTodayByCategory
		'
		Me.chkTodayByCategory.AutoSize = True
		Me.chkTodayByCategory.Location = New System.Drawing.Point(22, 66)
		Me.chkTodayByCategory.Name = "chkTodayByCategory"
		Me.chkTodayByCategory.Size = New System.Drawing.Size(144, 17)
		Me.chkTodayByCategory.TabIndex = 2
		Me.chkTodayByCategory.Text = "Today's time by Category"
		Me.chkTodayByCategory.UseVisualStyleBackColor = True
		'
		'chkTodayByProject
		'
		Me.chkTodayByProject.AutoSize = True
		Me.chkTodayByProject.Location = New System.Drawing.Point(22, 43)
		Me.chkTodayByProject.Name = "chkTodayByProject"
		Me.chkTodayByProject.Size = New System.Drawing.Size(135, 17)
		Me.chkTodayByProject.TabIndex = 1
		Me.chkTodayByProject.Text = "Today's time by Project"
		Me.chkTodayByProject.UseVisualStyleBackColor = True
		'
		'chkTodayByClient
		'
		Me.chkTodayByClient.AutoSize = True
		Me.chkTodayByClient.Location = New System.Drawing.Point(22, 20)
		Me.chkTodayByClient.Name = "chkTodayByClient"
		Me.chkTodayByClient.Size = New System.Drawing.Size(128, 17)
		Me.chkTodayByClient.TabIndex = 0
		Me.chkTodayByClient.Text = "Today's time by Client"
		Me.chkTodayByClient.UseVisualStyleBackColor = True
		'
		'GroupBox2
		'
		Me.GroupBox2.Controls.Add(Me.Label1)
		Me.GroupBox2.Controls.Add(Me.txtDestinationFolder)
		Me.GroupBox2.Location = New System.Drawing.Point(14, 134)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Size = New System.Drawing.Size(472, 58)
		Me.GroupBox2.TabIndex = 2
		Me.GroupBox2.TabStop = False
		Me.GroupBox2.Text = "Destination"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(6, 22)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(36, 13)
		Me.Label1.TabIndex = 8
		Me.Label1.Text = "Folder"
		'
		'txtDestinationFolder
		'
		Me.txtDestinationFolder.Location = New System.Drawing.Point(65, 19)
		Me.txtDestinationFolder.Name = "txtDestinationFolder"
		Me.txtDestinationFolder.Size = New System.Drawing.Size(390, 20)
		Me.txtDestinationFolder.TabIndex = 7
		Me.txtDestinationFolder.Text = "Z:\Public"
		'
		'cmdUpdateNow
		'
		Me.cmdUpdateNow.Location = New System.Drawing.Point(380, 304)
		Me.cmdUpdateNow.Name = "cmdUpdateNow"
		Me.cmdUpdateNow.Size = New System.Drawing.Size(106, 50)
		Me.cmdUpdateNow.TabIndex = 3
		Me.cmdUpdateNow.Text = "Update Now"
		Me.cmdUpdateNow.UseVisualStyleBackColor = True
		'
		'chk30DayByCategory
		'
		Me.chk30DayByCategory.AutoSize = True
		Me.chk30DayByCategory.Location = New System.Drawing.Point(192, 66)
		Me.chk30DayByCategory.Name = "chk30DayByCategory"
		Me.chk30DayByCategory.Size = New System.Drawing.Size(139, 17)
		Me.chk30DayByCategory.TabIndex = 5
		Me.chk30DayByCategory.Text = "30-day time by Category"
		Me.chk30DayByCategory.UseVisualStyleBackColor = True
		'
		'chk30DayByProject
		'
		Me.chk30DayByProject.AutoSize = True
		Me.chk30DayByProject.Location = New System.Drawing.Point(192, 43)
		Me.chk30DayByProject.Name = "chk30DayByProject"
		Me.chk30DayByProject.Size = New System.Drawing.Size(130, 17)
		Me.chk30DayByProject.TabIndex = 4
		Me.chk30DayByProject.Text = "30-day time by Project"
		Me.chk30DayByProject.UseVisualStyleBackColor = True
		'
		'chk30DayByClient
		'
		Me.chk30DayByClient.AutoSize = True
		Me.chk30DayByClient.Location = New System.Drawing.Point(192, 20)
		Me.chk30DayByClient.Name = "chk30DayByClient"
		Me.chk30DayByClient.Size = New System.Drawing.Size(123, 17)
		Me.chk30DayByClient.TabIndex = 3
		Me.chk30DayByClient.Text = "30-day time by Client"
		Me.chk30DayByClient.UseVisualStyleBackColor = True
		'
		'frmMain
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(498, 366)
		Me.Controls.Add(Me.cmdUpdateNow)
		Me.Controls.Add(Me.GroupBox2)
		Me.Controls.Add(Me.frameData)
		Me.Controls.Add(Me.GroupBox1)
		Me.Name = "frmMain"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "TimeTiger StatusBoard"
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.frameData.ResumeLayout(False)
		Me.frameData.PerformLayout()
		Me.GroupBox2.ResumeLayout(False)
		Me.GroupBox2.PerformLayout()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
	Friend WithEvents txtUser As System.Windows.Forms.TextBox
	Friend WithEvents txtURL As System.Windows.Forms.TextBox
	Friend WithEvents Label6 As System.Windows.Forms.Label
	Friend WithEvents Label5 As System.Windows.Forms.Label
	Friend WithEvents Label4 As System.Windows.Forms.Label
	Friend WithEvents txtPassword As System.Windows.Forms.TextBox
	Friend WithEvents cmdTestConnection As System.Windows.Forms.Button
	Friend WithEvents frameData As System.Windows.Forms.GroupBox
	Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents txtDestinationFolder As System.Windows.Forms.TextBox
	Friend WithEvents cmdUpdateNow As System.Windows.Forms.Button
	Friend WithEvents chkTodayByCategory As System.Windows.Forms.CheckBox
	Friend WithEvents chkTodayByProject As System.Windows.Forms.CheckBox
	Friend WithEvents chkTodayByClient As System.Windows.Forms.CheckBox
	Friend WithEvents chk30DayByCategory As System.Windows.Forms.CheckBox
	Friend WithEvents chk30DayByProject As System.Windows.Forms.CheckBox
	Friend WithEvents chk30DayByClient As System.Windows.Forms.CheckBox

End Class
