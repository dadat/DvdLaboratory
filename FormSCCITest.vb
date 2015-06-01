Imports dvdresources

Public Class FormSCCITest

    Private Sub btnInsertCase_Click(sender As Object, e As EventArgs) Handles btnInsertCase.Click
        Dim objInsert As New DvdFunctions
        If objInsert.insertRecord = True Then
            MsgBox("Inserted")
        Else
            MsgBox(objInsert.myReturnMsg)
        End If
    End Sub
End Class