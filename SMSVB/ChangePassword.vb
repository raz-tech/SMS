﻿Imports MySql.Data.MySqlClient
Public Class ChangePassword
    Dim myconn As MySqlConnection
    Dim command As MySqlCommand

    Dim hash = New hashFunction

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click



        myconn = New MySqlConnection

        myconn.ConnectionString = "server=localhost; userid=root; password=; database=SMS"
        Dim reader As MySqlDataReader
        Try
            myconn.Open()
            Dim Query As String
            Query =
"update SMS.users set  Password='" & hash.fromstring(TextBox1.Text) & "'  where userId='" & TextBox9.Text & "'  "
            command = New MySqlCommand(Query, myconn)
            reader = Command.ExecuteReader
            MessageBox.Show("PASSWORD UPDATED SUCCESSFULLY")

            myconn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            myconn.Dispose()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            myconn = New MySqlConnection
            myconn.ConnectionString = "server=localhost; userid=root;password=;DATABASE=SMS"

            Dim Command As New MySqlCommand("SELECT * FROM `users` WHERE UserId='" & TextBox9.Text & "' ", myconn)
            Command.Parameters.Add("@textbox10.text", MySqlDbType.Int64).Value = TextBox9.Text
            Dim reader As MySqlDataReader

            myconn.Open()
            reader = Command.ExecuteReader
            If reader.Read() Then
                TextBox9.Text = reader(0)

            End If
            myconn.Close()
        Finally
            myconn.Dispose()

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        myconn = New MySqlConnection

        myconn.ConnectionString = "server=localhost; userid=root; password=; database=SMS"
        Dim reader As MySqlDataReader

        Try
                myconn.Open()
            Dim Query As String


            Query =
"select *  from sms.users where Password='" & hash.fromstring(TextBox7.Text) & "' and userid='" & TextBox9.Text & "' "

                command = New MySqlCommand(Query, myconn)
                reader = command.ExecuteReader
            If reader.HasRows Then
                Button3.Enabled = True
                TextBox1.Enabled = True
                MsgBox("PASSWORD MATCHED, YOU CAN CHANGE NOW", MsgBoxStyle.Critical)
            Else

                Button3.Enabled = False
                TextBox1.Enabled = False
                MsgBox("PASSWORD DOES NOT MATCHED, CONTACT YOUR ADMIN", MsgBoxStyle.Critical)

            End If
            myconn.Close()

        Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally

                myconn.Dispose()


            End Try

    End Sub

    Private Sub ChangePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Enabled = False
    End Sub
End Class