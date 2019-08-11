Imports MySql.Data.MySqlClient
Imports System.Text
Imports System.Security.Cryptography
Public Class Staffinfor
    Dim MYCONN As MySqlConnection
    Dim COMMAND As MySqlCommand
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim hashcode As Staffinfor
        hashcode = New Staffinfor
        MYCONN = New MySqlConnection

        MYCONN.ConnectionString = "server=localhost; userid=root; password=; database=SMS"
        Dim reader As MySqlDataReader
        Try
            MYCONN.Open()
            Dim Query As String
            Query =
"insert into SMS.staffinfor (StaffId,StaffPassword,FullName,Gender,TelNumber,Region,City,SubjectTeaching,DOB,DateAdmitted,Hobby) values ('" & TextBox1.Text & "','" & hashcode.fromstring(TextBox2.Text) & "','" & TextBox3.Text & "','" & ComboBox1.Text & "','" & TextBox4.Text & "','" & ComboBox2.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & DateTimePicker1.Text & "','" & DateTimePicker2.Text & "','" & TextBox9.Text & "')  "
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

    'Private Sub Staffinfor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    Dim rn As Integer
    '    Dim ipper As Integer = 999
    ''    Dim faculty As String = InputBox("Enter the Staff Short Code:")
    ' '   Dim year As Integer = InputBox("Enter the last two digit of the Admitted year:")
    '    Randomize()

    '    rn = Rnd() * ipper
    '  '  TextBox1.Text = faculty & "/" & rn & "/" & year
    '    'textbox.text=rn
    'End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)


    End Sub
End Class
