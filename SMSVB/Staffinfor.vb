Imports MySql.Data.MySqlClient
Public Class Staffinfor
    Dim MYCONN As MySqlConnection
    Dim COMMAND1 As MySqlCommand
    Dim COMMAND2 As MySqlCommand
    Dim hash = New hashFunction
    Dim reader1 As MySqlDataReader
    Dim reader2 As MySqlDataReader

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MYCONN = New MySqlConnection

        MYCONN.ConnectionString = "server=localhost; userid=root; password=; database=SMS"


        Try
            MYCONN.Open()
            Dim Query1 As String
           
            Query1 =
"insert into SMS.staffinfor (StaffId,FullName,Gender,TelNumber,Region,City,SubjectTeaching,DOB,DateAdmitted,Hobby) values ('" & TextBox1.Text & "','" & TextBox3.Text & "','" & ComboBox1.Text & "','" & TextBox4.Text & "','" & ComboBox2.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & DateTimePicker1.Text & "','" & DateTimePicker2.Text & "','" & TextBox9.Text & "')  "
            COMMAND1 = New MySqlCommand(Query1, MYCONN)

            reader1 = COMMAND1.ExecuteReader

            MYCONN.Close()

            MYCONN.Open()
            Dim Query2 As String
            Dim pass = hash.fromstring(1234)
            Dim usertype = "teacher"
            Query2 = "insert into SMS.users (UserId,UserType,Password) values ('" & TextBox1.Text & "','" & usertype & "','" & pass & "')  "
            COMMAND2 = New MySqlCommand(Query2, MYCONN)
            reader2 = COMMAND2.ExecuteReader
            MessageBox.Show("Data Submited Successfully. Thank you!!!")
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MYCONN.Dispose()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        MagStuRecord.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        login.Show()
        Me.Hide()
    End Sub
End Class
