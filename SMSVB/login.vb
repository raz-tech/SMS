Imports MySql.Data.MySqlClient
Imports System.Text
Imports System.Security.Cryptography

Public Class login
    Dim mysqlconn As MySqlConnection
    Dim command As MySqlCommand
    Public Function fromstring(ByVal source As String) As String
        Dim bytes() As Byte
        Dim sb As New StringBuilder()
        If String.IsNullOrEmpty(source) Then
            Throw New ArgumentNullException

        End If
        bytes = Encoding.Default.GetBytes(source)
        bytes = SHA256.Create().ComputeHash(bytes)
        For x As Integer = 0 To bytes.Length - 1
            sb.Append(bytes(x).ToString("x2"))
        Next
        Return sb.ToString
    End Function


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim mysqlconn As MySqlConnection
        Dim command As MySqlCommand
        '  Dim reader As MySqlDataReader

        Dim hashcode As login
        hashcode = New login

        mysqlconn = New MySqlConnection
        Dim Reader As MySqlDataReader
        mysqlconn.ConnectionString =
            "server=localhost;userid=root;password=;database=SMS"


        Try
            mysqlconn.Open()
            Dim query As String
            query = "select * FROM SMS.Users where Userid='" & TextBox1.Text & "' and password='" & hashcode.fromstring(TextBox2.Text) & "'"

            command = New MySqlCommand(query, mysqlconn)
            Reader = command.ExecuteReader
            '' Dim ID, ADMIN_ID, TL_ID As String
            Dim count As Integer
            count = 0
            While Reader.Read
                count = count + 1
            End While
            If count = 1 Then
                adminHomePage.Show()
                Me.Hide()

                TextBox1.Clear()
                TextBox2.Clear()
            Else

                MessageBox.Show("ERROR ENCOUNTED DUE TO WRONG USER ID OR PASSWORD")
            End If

            mysqlconn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            mysqlconn.Dispose()
        End Try
    End Sub

End Class