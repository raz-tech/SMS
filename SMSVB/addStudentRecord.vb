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
"insert into SMS.studentinfor (FirstName,LastName,DOB,Address,Gender,City,District,Class,ParentContact,ParentFullName,Occupation,MOMONumber) values ('" & TextBox1.Text & "','" & TextBox3.Text & "','" & DateTimePicker1.Text & "','" & TextBox9.Text & "','" & ComboBox1.Text & "','" & TextBox4.Text & "','" & TextBox2.Text & "','" & ComboBox2.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox8.Text & "','" & TextBox7.Text & "')  "
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

  
    ' Private Sub addStudentRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '     Dim rn As Integer
    '     Dim ipper As Integer = 2009
    ''     Dim faculty As String = InputBox("Enter the School Short Code:")
    ' '    Dim year As Integer = InputBox("Enter the last two digit of the Admitted year:")
    '     Randomize()

    '     rn = Rnd() * ipper
    ''     TextBox1.Text = faculty & "/" & rn & "/" & year
    '     textbox1.text=rn
    ' End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MagStuRecord.Show()
        Me.Hide()

    End Sub
End Class
