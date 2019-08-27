Imports MySql.Data.MySqlClient

Public Class UpdateStaffRecords
    Dim myconn As MySqlConnection
    Dim command As MySqlCommand

  
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        
       
    End Sub

    

   
    Private Sub UpdateStaffRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mysqlconn As MySqlConnection
        Dim command As MySqlCommand

        mysqlconn = New MySqlConnection
        Dim Reader As MySqlDataReader
        mysqlconn.ConnectionString =
            "server=localhost;userid=root;password=;database=SMS"


        Try
            mysqlconn.Open()
            Dim query As String
            query = "select * FROM SMS.staffinfor where StaffId='" & login.TextBox1.Text & "' LIMIT 1"
            'MessageBox.Show(query)
            command = New MySqlCommand(query, mysqlconn)
            Reader = command.ExecuteReader()

            'If Reader.Read() Then
            txtAdYr.Text = Reader("DateAdmitted")
            MessageBox.Show(txtAdYr.Text)
            'txtCity.Text = Reader("City")
            'txtDoB.Text = Reader("DOB")
            'txtGender.Text = Reader("Gender")
            'txtHobby.Text = Reader("Hobby")
            'txtName.Text = Reader("FullName")
            'txtPhone.Text = Reader("TellNumber")
            'txtRegion.Text = Reader("Region")
            'txtSubject.Text = Reader("SubjectTeaching")

            'End If

            mysqlconn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            mysqlconn.Dispose()
        End Try
    End Sub
End Class