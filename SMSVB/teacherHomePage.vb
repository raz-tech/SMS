Imports MySql.Data.MySqlClient


Public Class teacherHomePage
    Dim myconn As MySqlConnection
    Dim command As MySqlCommand
    Private Sub teacherHomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myconn = New MySqlConnection

        myconn.ConnectionString = "server=localhost; userid=root; password=; database=sms"
        Dim reader As MySqlDataReader
        Try
            myconn.Open()
            Dim Query As String
            Dim login = New login
            Dim userid = login.TextBox1.Text
            MessageBox.Show(userid)
            Query = "SELECT * FROM staffinfor WHERE StaffId = '" & userid & "' LIMIT 1"
            command = New MySqlCommand(Query, myconn)
            reader = command.ExecuteReader

            Dim count As Integer
            count = 0
            While reader.Read()
                count = count + 1
            End While

            If count = 1 Then
                Dim fullname = reader("FullName")
                TextBox2.Text = fullname

            Else

                MessageBox.Show("WRONG USERNAME AND PASSWORD COMBINATION")
            End If

            myconn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            myconn.Dispose()
        End Try
    End Sub
End Class