Public Class FormRNG

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Dim numItem = txtNumbers.Text
        Dim objRNG As New RNG(numItem)
        Dim num = objRNG.GenerateRNG
        txtOutput.Text = num
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnEnc.Click
        Dim itemString = txtNumbers.Text
        Dim objRNG As New RNG(itemString)
        Dim strEnc = objRNG.EncryptData(itemString)
        txtOutput.Text = strEnc
    End Sub

    Private Sub btnGenRNG_Click(sender As Object, e As EventArgs) Handles btnGenRNG.Click
        Try
            lvPkmn.Items.Clear()
            Dim countPKM As Integer = Convert.ToInt16(txtGenRNG.Text)
            Dim objPKM As New RNG(1)
            Dim listPK = objPKM.GeneratePKMFromList(1, countPKM)
            For Each item In listPK
                Dim lvitem = New ListViewItem
                lvitem.Text = item.monName
                lvitem.SubItems.Add(item.monType)
                lvitem.SubItems.Add(item.monClass)

                lvPkmn.Items.Add(lvitem)

            Next
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try

    End Sub
End Class