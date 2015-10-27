    Dim a, b, c, d, f, g As Integer

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged

        For a = 0 To 100 Step 1
            ListBox1.Items.Add(CStr(a))
        Next

        For b = 40 To 0 Step -2
            ListBox2.Items.Add(CStr(b))
        Next

        For c = -15 To 15 Step 1
            ListBox3.Items.Add(CStr(c))
        Next

        For d = 50 To -50 Step -5
            ListBox4.Items.Add(CStr(d))
        Next

        For f = 75 To 0 Step -5
            ListBox5.Items.Add(CStr(f))
        Next

        For g = 0 To 30 Step 3
            ListBox6.Items.Add(CStr(g))
        Next
    End Sub
