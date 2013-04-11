Imports Microsoft.VisualBasic.FileIO
Imports Microsoft.VisualBasic.FileIO.TextFieldParser
Imports System.IO
Imports System.Collections

Public Class frmMain
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

	Private Sub cmdUpdateNow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpdateNow.Click
		Dim tt As New ttsystem.ttsystem
		Try
			Cursor.Current = Cursors.WaitCursor
			Dim sessionID As String = ConnectAndGetSessionID(tt)
			GenerateReports(tt, sessionID)
			tt.Goodbye(sessionID)
		Catch ex As Exception
			MessageBox.Show(ex.Message, "Test connection", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End Try
	End Sub

	Private Sub GenerateReports(ByRef tt As ttsystem.ttsystem, ByRef sessionID As String)
		If (chkTodayByClient.Checked = True) Then
			GenerateTimeReportWithDateRange(tt, sessionID, Date.Today, Date.Today, "Client")
		End If
		If (chkTodayByProject.Checked = True) Then
			GenerateTimeReportWithDateRange(tt, sessionID, Date.Today, Date.Today, "Project")
		End If
		If (chkTodayByCategory.Checked = True) Then
			GenerateTimeReportWithDateRange(tt, sessionID, Date.Today, Date.Today, "Category")
		End If
		If (chk30DayByClient.Checked = True) Then
			GenerateTimeReportWithDateRange(tt, sessionID, Date.Today.AddDays(-30), Date.Today, "Client")
		End If
		If (chk30DayByProject.Checked = True) Then
			GenerateTimeReportWithDateRange(tt, sessionID, Date.Today.AddDays(-30), Date.Today, "Project")
		End If
		If (chk30DayByCategory.Checked = True) Then
			GenerateTimeReportWithDateRange(tt, sessionID, Date.Today.AddDays(-30), Date.Today, "Category")
		End If
		MsgBox("Done", MsgBoxStyle.Information)
	End Sub

	Private Sub GenerateTimeReportWithDateRange(ByRef tt As ttsystem.ttsystem, ByRef sessionID As String, ByRef dFrom As Date, ByRef dTo As Date, ByRef entityType As String)
		Dim entities As ttsystem.GetAllEntitiesOutput
		entities = tt.GetAllEntities(sessionID, "0", "0")
		Dim entityLookup As New Dictionary(Of String, String)
		BuildEntityLookupWithEntityType(entities.EntityNodes, entityType, entityLookup)

		Dim sFrom As String = dFrom.ToString("yyyyMMdd")
		Dim sTo As String = dTo.ToString("yyyyMMdd")

		' Get a good name for the report
		Dim dateDiff As TimeSpan = dTo - dFrom
		Dim sDays = (dateDiff.Days).ToString() + "-day"

		Dim listResults As New Dictionary(Of String, String)
		GenerateTimeReport(tt, sessionID, sFrom, sTo, entityLookup, listResults)
		SaveResultsAsJSON(listResults, txtDestinationFolder.Text + "\" + sDays + "-" + entityType.ToLower() + ".json", IIf(sDays = "0-Day", "Today's", sDays) + " time by " + entityType)
	End Sub

	Private Sub SaveResultsAsJSON(ByRef listResults As Dictionary(Of String, String), ByRef outputFileName As String, ByRef reportTitle As String)
		Using outFile As New StreamWriter(outputFileName)
			outFile.Write("{ ""graph"" : { ""title"" : """ + reportTitle)
			outFile.Write(""", ""datasequences"" : [ { ""title"" : ""Hours"", ""datapoints"" : [")
			For Each desiredEntityName As String In listResults.Keys
				Dim sSecs As String = listResults(desiredEntityName)
				Dim sDuration As String = (Convert.ToDouble(sSecs) / 3600).ToString(".00")	 ' 2 decimal places
				outFile.Write("{ ""title"" : """ + PrepEntityName(desiredEntityName) + """, ""value"" : " + sDuration + " }," + vbCrLf)
			Next
			outFile.Write("] } ] } }")
		End Using
	End Sub

	Private Function PrepEntityName(ByVal original As String) As String
		Dim work As String = original
		If (work.Length > 10) Then
			work = work.Substring(0, 9) + "..."
		End If
		work = work.Replace("""", "\x22")
		Return work
	End Function

	Private Sub BuildEntityLookupWithEntityType(ByRef nodes As ttsystem.EntityNode(), ByRef entityType As String, ByRef entityLookup As Dictionary(Of String, String))
		' Recurse through all entities in the system

		For Each node As ttsystem.EntityNode In nodes
			If (node.ChildNodes.Length > 0) Then
				BuildEntityLookupWithEntityTypeRecurse(node.ChildNodes, entityType, entityLookup, "")
			End If
		Next
	End Sub

	Private Sub BuildEntityLookupWithEntityTypeRecurse(ByRef nodes As ttsystem.EntityNode(), ByRef entityType As String, ByRef entityLookup As Dictionary(Of String, String), ByVal rollupToEntityName As String)
		For Each node As ttsystem.EntityNode In nodes
			Dim rollupChildren As String = rollupToEntityName
			If node.EntityTypeName = entityType And rollupChildren.Length = 0 Then
				rollupChildren = node.EntityName
			End If

			If rollupChildren.Length > 0 And node.ChildNodes.Length = 0 Then	' Lowest level
				entityLookup(node.UID) = rollupChildren
			End If

			' Recurse into children

			If (node.ChildNodes.Length > 0) Then
				BuildEntityLookupWithEntityTypeRecurse(node.ChildNodes, entityType, entityLookup, rollupChildren)
			End If
		Next
	End Sub

	Private Sub GenerateTimeReport(ByRef tt As ttsystem.ttsystem, ByRef sessionID As String, ByRef fromDate As String, ByRef toDate As String, ByRef entityLookup As Dictionary(Of String, String), ByRef listResults As Dictionary(Of String, String))
		Dim logs As ttsystem.GetTimeLogsOutput
		logs = tt.GetTimeLogs(sessionID, "", fromDate, toDate, "7", "0", "")
		For Each log As ttsystem.TimeLog In logs.TimeLogs
			AddLogToResults(log, entityLookup, listResults)
		Next
	End Sub

	Private Sub AddLogToResults(ByRef log As ttsystem.TimeLog, ByRef entityLookup As Dictionary(Of String, String), ByRef listResults As Dictionary(Of String, String))
		' Find the type-appropriate item to which this log belongs

		Dim desiredEntityName As String = LookupLogInEntityList(log, entityLookup)
		If (desiredEntityName.Length = 0) Then
			' Couldn't find the entity, perhaps because we lack appropriate permissions?
			Debug.Assert(False)
			Exit Sub
		End If

		' See if we already have a results entry for it

		Dim iSecs As Integer = 0
		If listResults.ContainsKey(desiredEntityName) Then
			iSecs = Convert.ToInt32(listResults(desiredEntityName))
		End If

		Dim iAdditionalSecs As Integer = Convert.ToInt32(log.Duration)
		listResults(desiredEntityName) = (iSecs + iAdditionalSecs).ToString()
	End Sub

	Private Function LookupLogInEntityList(ByRef log As ttsystem.TimeLog, ByRef entityLookup As Dictionary(Of String, String)) As String
		' Naively check every lowest level entity ID in the log's allocation.
		' We could in theory optimize this by just checking the lowest-level types related
		' to the entity type we're querying, but this is sufficiently performant as-is

		For Each entry As ttsystem.AllocationEntry In log.Allocation
			If entityLookup.ContainsKey(entry.EntityID) Then
				Return entityLookup(entry.EntityID)
			End If
		Next
		' Not found
		Return ""
	End Function
End Class
