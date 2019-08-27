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
"update SMS.Studentinfor set FirstName='" & TextBox2.Text & "', LastName='" & TextBox3.Text & "',DOB='" & TextBox4.Text & "',Address='" & TextBox5.Text & "',Gender='" & TextBox6.Text & "',City='" & TextBox7.Text & "',District='" & TextBox8.Text & "',Class='" & TextBox9.Text & "',ParentContact='" & TextBox10.Text & "',ParentFullName='" & TextBox16.Text & "',Occupation='" & TextBox15.Text & "',MOMONumber='" & TextBox11.Text & "' where StudentId='" & TextBox1.Text & "'  "
            command = New MySqlCommand(Query, myconn)
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        myconn = New MySqlConnection
        myconn.ConnectionString = "server=localhost; userid=root;password=;DATABASE=SMS"

        Dim Command As New MySqlCommand("SELECT * FROM `studentinfor` WHERE StudentId='" & TextBox1.Text & "' ", myconn)
        '    Command.Parameters.Add("@textbox1.text", MySqlDbType.Int64).Value = TextBox1.Text
        Dim reader As MySqlDataReader

        myconn.Open()
        reader = Command.ExecuteReader
        If reader.Read() Then


            TextBox1.Text = reader("StudentId")
            TextBox2.Text = reader(1)
            TextBox3.Text = reader(2)

            TextBox4.Text = reader(3)
            TextBox5.Text = reader(4)
            TextBox6.Text = reader(5)
            TextBox7.Text = reader(6)
            TextBox8.Text = reader(7)
            TextBox9.Text = reader(8)
            TextBox10.Text = reader(9)
            '  TextBox11.Text = reader(9)
            TextBox12.Text = reader(10)
            TextBox13.Text = reader(11)
            TextBox14.Text = reader(12)

        End If
        myconn.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        login.Show()
        Me.Hide()

    End Sub

    Private Sub UpdateStudntRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class