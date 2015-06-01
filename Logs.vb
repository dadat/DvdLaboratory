Imports System.IO

Public Class Logs

    Sub New(ByVal textInput As String)
        myText = textInput
    End Sub

    Private Sub WriteLog()
        Try
            If Not File.Exists(Format(Today, "MM-dd-yyy") + ".txt") Then
                Dim file1 As StreamWriter = File.CreateText(Format(Today, "MM-dd-yyy") + ".txt")
                file1.WriteLine(myText)
                file1.Close()
            ElseIf File.Exists(Format(Today, "MM-dd-yyy") + ".txt") Then
                Dim file1 As StreamWriter = File.AppendText(Format(Today, "MM-dd-yyy") + ".txt")
                file1.WriteLine(myText)
                file1.Close()
            End If
        Catch ex As Exception

        End Try

    End Sub

    Public Sub GenerateLog()
        WriteLog()
    End Sub

    Private Sub AppendLogs()
        
    End Sub

    Private Sub WriteLogTXT()
        If Not System.IO.Directory.Exists(Application.StartupPath & "\Errors\") Then
            System.IO.Directory.CreateDirectory(Application.StartupPath & "\Errors")
        End If

        Dim date_file = CDate(DateTime.Now)
        Dim df As String = Format(date_file, "MMddyyyy")


        Dim fs As FileStream = New FileStream(Application.StartupPath & "\Errors\error_" & df & ".txt", FileMode.OpenOrCreate, FileAccess.ReadWrite)
        Dim s As StreamWriter = New StreamWriter(fs)
        s.Close()
        fs.Close()



        Dim fs1 As FileStream = New FileStream(Application.StartupPath & "\Errors\error_" & df & ".txt", FileMode.Append, FileAccess.Write)
        Dim s1 As StreamWriter = New StreamWriter(fs1)
        s1.Write(vbNewLine)
        s1.Write("Title: NOW")
        s1.Write("Message: MESSAGE HERE")
        s1.Write("Stack Trace: IDK")
        s1.Write("Date/Time: " & DateTime.Now.ToString & vbCrLf)
        s1.Write("===================================================================================================================")
        s1.Write(vbNewLine)
        s1.Close()
        fs1.Close()
    End Sub

    Public Sub GenerateLogsTXT()
        WriteLogTXT()
    End Sub

    Private myText As String
    Private myMessage As String

End Class
