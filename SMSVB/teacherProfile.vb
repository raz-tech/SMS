Imports MySql.Data.MySqlClient
Public Class teacherProfile
    Dim mysqlconn As MySqlConnection
    Dim command As MySqlCommand

    'Dim DataAdapter As New MySqlDataAdapter
    Private Sub teacherProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mysqlconn As MySqlConnection
        Dim command As MySqlCommand

        mysqlconn = New MySqlConnection
        Dim Reader As MySqlDataReader
        mysqlconn.ConnectionString =
            "server=localhost;userid=root;password=;database=SMS"
        Dim user = New login
        MessageBox.Show(user.TextBox1.Text)

        Try
            mysqlconn.Open()
            Dim query As String
            query = "select * FROM SMS.staffinfor where StaffId='" & user.TextBox1.Text & "'"



            command = New MySqlCommand(query, mysqlconn)


            Reader = command.ExecuteReader()
            If Reader.Read() Then
                MessageBox.Show(Reader("StaffId"))
            End If






            mysqlconn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            mysqlconn.Dispose()
        End Try

    End Sub

End Class