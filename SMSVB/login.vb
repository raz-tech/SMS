Imports MySql.Data.MySqlClient




Public Class login
    Dim conn As MySqlConnection
    Dim command As MySqlCommand
    Dim reader As MySqlDataReader


    Private Sub Button1_Click(sender As Object, e As EventArgs)


    End Sub

   
   
    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        adminHomePage.Show()
        Me.Hide()

    End Sub
End Class