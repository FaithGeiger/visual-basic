 Private Sub btnDisplayData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplayData.Click

        Dim counter As Integer
        Dim strResults As String = ""
        Dim sngScores As Single = 0
        Dim sngAverage As Single = 0
        Dim sngListCount As Single = 0

        'The number of items on the list is assigned to intListCount
        sngListCount = Convert.ToSingle(lstStudentScore.Items.Count)

        'This for loop will iterate through each item in the list
        For counter = 0 To sngListCount - 1

            'Converts the student's score at the location of counter in the list and removes the percent sign
            sngScores = Convert.ToSingle(lstStudentScore.Items(counter).SubItems(1).Text.Replace("%", ""))
            'Adds the scores to the average
            sngAverage += sngScores

        Next

        'Sets the average
        sngAverage = sngAverage / sngListCount

        'Outputs the results to a message box
        strResults = "The average score is: " & Format(sngAverage, "0.00") & "%" & ControlChars.NewLine
        strResults &= "The number of scores: " & sngListCount
        MessageBox.Show(strResults, "Average Score")
    End Sub

    Private Sub btnCearForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCearForm.Click
        Me.Close()
    End Sub

    Private Sub btnEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnter.Click

        'Create a new form
        Dim studentForm As New frmStudentInfo

        'Create a new dataset for student data
        'adds the name to the dataset
        studentForm.ShowDialog()
        Do Until studentForm.txtStudentName.Text = ""
            Dim studentData As New ListViewItem(studentForm.txtStudentName.Text)

            'Adds the test score to the set
            studentData.SubItems.Add(studentForm.txtTestScore.Text & "%")

            'Checks to see that there is no null data
            If Not studentForm.txtStudentName.Text = "" Then
                lstStudentScore.Items.Add(studentData)

            End If
            studentForm.ShowDialog()
        Loop


    End Sub
