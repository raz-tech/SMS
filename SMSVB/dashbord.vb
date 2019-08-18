Public Class dashbord

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        adminHomePage.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MagStuRecord.Show()  ' it is been linked to the student management portal
        Me.Hide()

    End Sub
End Class