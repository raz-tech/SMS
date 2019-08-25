Imports MySql.Data.MySqlClient

Public Class UpdateStaffRecords
    Dim myconn As MySqlConnection
    Dim command As MySqlCommand

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        myconn = New MySqlConnection
        myconn.ConnectionString = "server=localhost; userid=root;password=;DATABASE=SMS"

        Dim Command As New MySqlCommand("SELECT * FROM `Staffinfor` WHERE StaffId='" & TextBox1.Text & "' ", myconn)
        Command.Parameters.Add("@textbox1.text", MySqlDbType.Int64).Value = TextBox1.Text
        Dim reader As MySqlDataReader

        myconn.Open()
        reader = Command.ExecuteReader
        If reader.Read() Then


            TextBox1.Text = reader("StaffId")
            TextBox2.Text = reader("FullName")
            TextBox3.Text = reader("Gender")

            TextBox4.Text = reader("TelNumber")
            TextBox5.Text = reader("Region")
            TextBox6.Text = reader("city")
            TextBox7.Text = reader("SubjectTeaching")
            TextBox8.Text = reader("DOB")
            TextBox9.Text = reader("DateAdmitted")
            TextBox10.Text = reader("Hobby")


        End If
        myconn.Close()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        myconn = New MySqlConnection

        myconn.ConnectionString = "server=localhost; userid=root; password=; database=SMS"
        Dim reader As MySqlDataReader
        Try
            myconn.Open()
            Dim Query As String
            Query =
"update SMS.Staffinfor set  FullName='" & TextBox2.Text & "',Gender='" & TextBox3.Text & "',TelNumber='" & TextBox4.Text & "',Region='" & TextBox5.Text & "',City='" & TextBox6.Text & "',SubjectTeaching='" & TextBox7.Text & "',DOB='" & TextBox8.Text & "',DateAdmitted='" & TextBox9.Text & "',Hobby='" & TextBox10.Text & "'  where StaffId='" & TextBox1.Text & "'  "
            command = New MySqlCommand(Query, myconn)
            reader = command.ExecuteReader
            MessageBox.Show("DATA UPDATED SUCCESSFULLY")

            myconn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            myconn.Dispose()
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        myconn = New MySqlConnection

        myconn.ConnectionString = "server=localhost; userid=root; password=; database=sms"
        Dim reader As MySqlDataReader
        Try
            myconn.Open()
            Dim Query As String
            Query =
"delete from  SMS.Staffinfor where StaffId='" & TextBox1.Text & "'"
            command = New MySqlCommand(Query, myconn)
            reader = command.ExecuteReader
            MessageBox.Show(" STUDENT DATA DELETED SUCCESSFULLY")

            myconn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            myconn.Dispose()
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        login.Show()
        Me.Hide()

    End Sub
End Class