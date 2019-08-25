Public Class adminHomePage

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        dashbord.Show()
        Me.Hide()


    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim result = MsgBox("Are you sure you want logout?", MsgBoxStyle.YesNo, Title:="Logout")

        If result = 6 Then

            login.Show()
            Me.Hide()
        ElseIf result = 7 Then
            Me.Show()

        End If




    End Sub

    Private Sub adminHomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ChangePassword.Show()
        Me.Hide()
        Dim inputBox As String = ("Enter the user type:")
        Dim usertype = inputBox("UserType")
        If usertype = "teacher" Then
            Me.Hide()
            ChangePassword.Show()

        ElseIf usertype = "admin" Then

            Me.Hide()
            ChangePassword.Show()
        Else
            MessageBox.Show("Invalid request")
        End If
    End Sub
End Class