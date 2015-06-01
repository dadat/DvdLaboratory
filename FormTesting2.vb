Public Class FormTesting2

    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        lvTest.Items.Clear()
        Dim dateColoredSTART As DateTime
        Dim dateREDXPIRED As DateTime
        Dim dateREDXXX As DateTime
        Dim dateREDXX As DateTime
        Dim dateREDX As DateTime
        Dim iListTest As New List(Of StrucTest)
        Dim listTest As New StrucTest
        Dim listTest1 As New StrucTest
        Dim listTest2 As New StrucTest
        Dim listTest3 As New StrucTest
        Dim listTest4 As New StrucTest
        Dim listTest5 As New StrucTest
        Dim listTest6 As New StrucTest
        Dim listTest7 As New StrucTest
        Dim listTest8 As New StrucTest
        With listTest
            .myName = "Monkey D Luffy"
            .myAge = "19"
            .myDate = New Date(2015, 3, 4)
        End With
        iListTest.Add(listTest)
        With listTest1
            .myName = "Sakuragi"
            .myAge = "46"
            .myDate = New Date(2015, 3, 5)
        End With
        iListTest.Add(listTest1)
        With listTest2
            .myName = "Son Goku"
            .myAge = "250"
            .myDate = New Date(2015, 3, 6)
        End With
        iListTest.Add(listTest2)
        With listTest3
            .myName = "Tesla"
            .myAge = "61"
            .myDate = New Date(2015, 3, 9)
        End With
        iListTest.Add(listTest3)
        With listTest4
            .myName = "Leonardo"
            .myAge = "78"
            .myDate = New Date(2015, 3, 10)
        End With
        iListTest.Add(listTest4)
        With listTest5
            .myName = "Aragorn"
            .myAge = "152"
            .myDate = New Date(2015, 3, 11)
        End With
        iListTest.Add(listTest5)
        With listTest6
            .myName = "Elie"
            .myAge = "22"
            .myDate = Today
        End With
        iListTest.Add(listTest6)
        With listTest7
            .myName = "Sharyn"
            .myAge = "23"
            .myDate = New DateTime(2015, 3, 13)
        End With
        iListTest.Add(listTest7)
        With listTest8
            .myName = "David"
            .myAge = "23"
            .myDate = New DateTime(2015, 3, 14)
        End With
        iListTest.Add(listTest8)
        iListTest.Reverse()
        For Each item In iListTest
            dateColoredSTART = New DateTime(2015, Today.Month, Today.Day - 3)
            dateREDXPIRED = New DateTime(2015, Today.Month, Today.Day - 2)
            dateREDXXX = New DateTime(2015, Today.Month, Today.Day - 1)
            dateREDXX = New DateTime(2015, Today.Month, Today.Day)
            dateREDX = New DateTime(2015, Today.Month, Today.Day + 1)
            Dim lvItem As New ListViewItem
            lvItem.Text = item.myName
            lvItem.SubItems.Add(item.myAge)
            lvItem.SubItems.Add(item.myDate)
            lvItem.ForeColor = Color.FromArgb(61, 153, 73)
            If item.myDate > dateColoredSTART And item.myDate < dateREDX Then
                lvItem.BackColor = Color.FromArgb(227, 196, 183)
                lvItem.ForeColor = Color.FromArgb(61, 153, 83)
            End If

            If item.myDate > dateColoredSTART And item.myDate < dateREDXX Then
                lvItem.BackColor = Color.FromArgb(190, 130, 125)
                lvItem.ForeColor = Color.WhiteSmoke
            End If

            If item.myDate > dateColoredSTART And item.myDate < dateREDXXX Then
                lvItem.BackColor = Color.FromArgb(171, 96, 96)
                lvItem.ForeColor = Color.WhiteSmoke
            End If

            If item.myDate < dateREDXPIRED Then
                lvItem.BackColor = Color.FromArgb(221, 217, 207)
                lvItem.ForeColor = Color.FromArgb(0, 0, 0)
            End If

            lvTest.Items.Add(lvItem)
        Next


    End Sub
End Class