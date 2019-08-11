Imports MySql.Data.MySqlClient

Public Class login
    Dim conn As MySqlConnection
    Dim command As MySqlCommand
    Dim reader As MySqlDataReader


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password=;database=dahansheli"

        Try
            conn.Open()
            Dim query As String
            query = "SELECT * FROM dahansheli.admin WHERE username='" & TextBox1.Text & "' AND password='" & TextBox2.Text & "'"
            command = New MySqlCommand(query, conn)
            reader = command.ExecuteReader

            Dim count As Integer = 0

            While reader.Read
                count = count + 1
            End While

            If count = 1 Then
                Me.Hide()
                Dahansheli.Show()
            Else
                MsgBox("Incorrect Username and Password combination")

            End If

        Catch ex As Exception

        End Try


    End Sub

   
   
End Class