Imports MySql.Data.MySqlClient
Public Class Staffinfor
    Dim MYCONN As MySqlConnection
    Dim COMMAND As MySqlCommand

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MYCONN = New MySqlConnection

        MYCONN.ConnectionString = "server=localhost; userid=root; password=; database=SMS"
        Dim reader As MySqlDataReader
        Try
            MYCONN.Open()
            Dim Query As String
            Query =
"insert into SMS.staffinfor (StaffId,StaffPassword,FullName,Gender,TelNumber,Region,City,SubjectTeaching,DOB,DateAdmitted,Hobby) values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & ComboBox1.Text & "','" & TextBox4.Text & "','" & ComboBox2.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & DateTimePicker1.Text & "','" & DateTimePicker2.Text & "','" & TextBox9.Text & "')  "
            COMMAND = New MySqlCommand(Query, MYCONN)
            reader = COMMAND.ExecuteReader
            MessageBox.Show("Form Submited Successfully. Thank you!!!")

            MYCONN.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MYCONN.Dispose()
        End Try
    End Sub

    Private Sub Staffinfor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rn As Integer
        Dim ipper As Integer = 999
        Dim faculty As String = InputBox("Enter the Staff Short Code:")
        Dim year As Integer = InputBox("Enter the last two digit of the Admitted year:")
        Randomize()

        rn = Rnd() * ipper
        TextBox1.Text = faculty & "/" & rn & "/" & year
    End Sub
End Class