Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        'resting the number up/down
        dudSaleItem.Value = 1
    End Sub

    Private Sub btnMakeChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMakeChange.Click

        Dim shrhalfdollars, shrquarters, shrdimes, shrnickels, shrpennies, shrchange As Short
        Dim strResults As String
        shrchange = 100 - dudSaleItem.Value

        If shrchange >= 50 Then
            shrhalfdollars += 1
            shrchange -= 50
        End If
        If shrchange >= 25 Then
            shrquarters += 1
            shrchange -= 25
        End If
        If shrchange >= 10 Then
            shrdimes += 1
            shrchange -= 10
        End If
        If shrchange >= 5 Then
            shrnickels += 1
            shrchange -= 5
        End If
        If shrchange >= 1 Then
            shrpennies += 1
            shrchange -= 1
        End If

        'Outputs the results to a message box
        strResults = "Half Dollars: " & shrhalfdollars & ControlChars.NewLine
        strResults &= "Quarters: " & shrquarters & ControlChars.NewLine
        strResults &= "Dimes: " & shrdimes & ControlChars.NewLine
        strResults &= "Nickels: " & shrnickels & ControlChars.NewLine
        strResults &= "Pennies: " & shrpennies & ControlChars.NewLine
        MessageBox.Show(strResults, "Change Amount")
    End Sub
