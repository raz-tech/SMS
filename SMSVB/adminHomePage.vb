Public Class adminHomePage
    Public userD As String


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        dashbord.Show()
        Me.Hide()


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
        Dim nas = login.TextBox1.Text

        
    End Sub





End Class