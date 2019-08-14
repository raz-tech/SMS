Imports MySql.Data.MySqlClient
Public Class UpdateStudntRecord
    Dim myconn As MySqlConnection
    Dim command As MySqlCommand
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        myconn = New MySqlConnection

        myconn.ConnectionString = "server=localhost; userid=root; password=; database=tf_database"
        Dim reader As MySqlDataReader
        Try
            myconn.Open()
            Dim Query As String
            Query =
"update SMS.Studentinfor set Address='" & TextBox1.Text & "', MOMONumber='" & TextBox2.Text & "',Occupation='" & TextBox3.Text & "',Class='" & TextBox4.Text & "' where FirstName='" & TextBox8.Text & "'  "
            Command = New MySqlCommand(Query, myconn)
            reader = Command.ExecuteReader
            MessageBox.Show("DATA UPDATED")

            myconn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            myconn.Dispose()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MagStuRecord.Show()
        Me.Hide()
    End Sub
End Class