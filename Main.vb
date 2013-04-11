Imports Microsoft.VisualBasic.FileIO
Imports Microsoft.VisualBasic.FileIO.TextFieldParser

Public Class frmMain
	Private m_entityTypes As Dictionary(Of String, ttsystem.EntityType)

	Private Sub cmdTestConnection_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTestConnection.Click
		Dim tt As New ttsystem.ttsystem
		Try
			Cursor.Current = Cursors.WaitCursor
			Dim sessionID As String = ConnectAndGetSessionID(tt)
			tt.Goodbye(sessionID)
			MessageBox.Show("Connection successful", "Test connection", MessageBoxButtons.OK, MessageBoxIcon.Information)
		Catch ex As Exception
			MessageBox.Show(ex.Message, "Test connection", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End Try
	End Sub

	Private Function ConnectAndGetSessionID(ByRef tt As ttsystem.ttsystem) As String
		tt.Url = txtURL.Text + "/ttxml"
		Dim helloOutput As ttsystem.HelloOutput = tt.Hello("1.0", "ENUS")
		Dim sessionID As String = helloOutput.SessionID
		Dim response As ttsystem.LoginStandardOutput = tt.LoginStandard(sessionID, txtUser.Text, txtPassword.Text)
		If response.ResultCode <> 0 Then
			Throw New Exception(response.Message)
		End If
		ConnectAndGetSessionID = sessionID
	End Function
End Class
