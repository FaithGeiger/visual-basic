Private Sub frmWeeklyPayroll_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim intColumn0Width As Integer
        intColumn0Width = Me.Width - lstWeeklyPayroll.Columns(1).Width - lstWeeklyPayroll.Columns(2).Width - 12
        If intColumn0Width > 0 Then
            lstWeeklyPayroll.Columns(0).Width = intColumn0Width
        End If
    End Sub
    Private Sub btnEnterData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnterData.Click
        Dim objAddItemForm As New frmEnterData
        objAddItemForm.ShowDialog()
        Do Until objAddItemForm.txtEmployeeName.Text = ""
            Dim lviEnterData As New ListViewItem(objAddItemForm.txtEmployeeName.Text)
            lviEnterData.SubItems.Add(objAddItemForm.nudHours.Value)
            lviEnterData.SubItems.Add(Format$(objAddItemForm.txtRate.Text, "Currency"))
            lstWeeklyPayroll.Items.Add(lviEnterData)
            objAddItemForm.ShowDialog()
        Loop
    End Sub
    Private Sub btnTotalData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTotalData.Click
        Dim intIndex, intListCount As Integer
        Dim sngTotalSales As Single = 0
        Dim sngTotalWorkerPay As Single = 0
        Dim strPayRate As Single
        Dim sngHours As Single
        Dim strResults As String, strHours As String
        intListCount = Convert.ToInt32(lstWeeklyPayroll.Items.Count)
        For intIndex = 0 To intListCount - 1
            strHours = lstWeeklyPayroll.Items(intIndex).SubItems(1).Text
            strPayRate = lstWeeklyPayroll.Items(intIndex).SubItems(2).Text
            strHours = strHours.Replace("$", "0")
            sngHours = Convert.ToString(strHours)
            sngTotalSales += sngHours
            sngTotalWorkerPay += sngHours * strPayRate
        Next
        strResults = "Total Hours Worked: " & (sngTotalSales) & ControlChars.NewLine
        strResults &= "Total  Pay: " & Format$(sngTotalWorkerPay, "Currency")
        MessageBox.Show(strResults, "Total Hours Paid")
    End Sub
    Private Sub btnClearData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearData.Click
        Me.Close()
    End Sub
