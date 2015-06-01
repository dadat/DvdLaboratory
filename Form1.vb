Public Class Form1

    Private Sub btnWrite_Click(sender As Object, e As EventArgs) Handles btnWrite.Click
        Dim textInput As String = txtInput.Text
        Dim oLogs As New Logs(textInput)
        oLogs.GenerateLog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Do
            Dim textInput = txtInput.Text + " " + Date.Now
            Dim oLogs As New Logs(textInput)
            oLogs.GenerateLog()
        Loop
    End Sub

    Private Sub btnLogsNew_Click(sender As Object, e As EventArgs) Handles btnLogsNew.Click
        Do
            Dim textInput = Date.Now
            Dim oLogs As New Logs(textInput)
            oLogs.GenerateLogsTXT()
        Loop
    End Sub
End Class
