Public Class adminHomePage

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim result = MsgBox("Are you sure you want logout?", MsgBoxStyle.YesNo, Title:="Logout")

        If result = 6 Then
            Me.Close()
            login.Show()
        ElseIf result = 7 Then
            Me.Show()

        End If




    End Sub
End Class