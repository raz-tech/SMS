Imports MySql.Data.MySqlClient
'Imports System.Web.UI.Page


Public Class login
    Dim mysqlconn As MySqlConnection
    Dim command As MySqlCommand
    Dim hash = New hashFunction()
    Dim DataAdapter As New MySqlDataAdapter




   


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        Dim mysqlconn As MySqlConnection
        Dim command As MySqlCommand

        mysqlconn = New MySqlConnection
        Dim Reader As MySqlDataReader
        mysqlconn.ConnectionString =
            "server=localhost;userid=root;password=;database=SMS"


        Try
            mysqlconn.Open()
            Dim query As String
            query = "select * FROM SMS.Users where Userid='" & TextBox1.Text & "' and password='" & hash.fromstring(TextBox2.Text) & "'"



            command = New MySqlCommand(query, mysqlconn)
            Reader = command.ExecuteReader()



            Dim count As Integer
            count = 0
            While Reader.Read()
                count = count + 1
            End While
            If count = 1 Then
                Dim usertype = Reader("UserType")
                If usertype = "teacher" Then
                    Me.Hide()
                    teacherDashboard.Show()

                Else
                    Me.Hide()
                    adminHomePage.Show()
                End If
            Else

                MessageBox.Show("WRONG USERNAME AND PASSWORD COMBINATION")
            End If

            mysqlconn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            mysqlconn.Dispose()
        End Try

    End Sub

End Class