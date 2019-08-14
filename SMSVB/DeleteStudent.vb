Imports MySql.Data.MySqlClient
Public Class DeleteStudent
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
"delete from  SMS.Studentinfor where FirstName='" & TextBox1.Text & "'"
            Command = New MySqlCommand(Query, myconn)
            reader = Command.ExecuteReader
            MessageBox.Show(" STUDENT DATA DELETED SUCCESSFULLY")

            myconn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            myconn.Dispose()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MagStuRecord.Show()
        Me.Close()
    End Sub
End Class