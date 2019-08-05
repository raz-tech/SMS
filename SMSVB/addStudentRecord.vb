Imports MySql.Data.MySqlClient
Public Class addStudentRecord
    Dim myconn As MySqlConnection
    Dim command As MySqlCommand
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MYCONN = New MySqlConnection

        MYCONN.ConnectionString = "server=localhost; userid=root; password=; database=SMS"
        Dim reader As MySqlDataReader
        Try
            MYCONN.Open()
            Dim Query As String
            Query =
"insert into SMS.studentinfor (Id,FirstName,LastName,DOB,Address,Gender,City,District,Class,ParentFullName,Occupation,ParentNumber) values ('" & TextBox8.Text & "','" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & ComboBox1.Text & "','" & DateTimePicker1.Text & "','" & TextBox4.Text & "','" & ComboBox2.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "')  "
            command = New MySqlCommand(Query, MYCONN)
            reader = command.ExecuteReader
            MessageBox.Show("Form Submited Successfully. Thank you!!!")

            MYCONN.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MYCONN.Dispose()
        End Try

    End Sub

  
    Private Sub addStudentRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rn As Integer
        Dim ipper As Integer = 2009
        Dim faculty As String = InputBox("Enter the School Short Code:")
        Dim year As Integer = InputBox("Enter the last two digit of the Admitted year:")
        Randomize()

        rn = Rnd() * ipper
        TextBox1.Text = faculty & "/" & rn & "/" & year
    End Sub
End Class
