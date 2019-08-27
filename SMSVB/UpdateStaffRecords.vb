Imports MySql.Data.MySqlClient

Public Class UpdateStaffRecords
    Dim myconn As MySqlConnection
    Dim command As MySqlCommand

  
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        myconn = New MySqlConnection

        myconn.ConnectionString = "server=localhost; userid=root; password=; database=sms"
        Dim reader As MySqlDataReader
        Try
            myconn.Open()
            Dim Query As String
            Query = "UPDATE SMS.staffinfor set TelNumber='" & txtPhone.Text & "', Region='" & txtRegion.Text & "', City='" & txtCity.Text & "',DOB='" & txtDoB.Text & "',Hobby='" & txtHobby.Text & "' WHERE StaffId='" & login.TextBox1.Text & "'"
            command = New MySqlCommand(Query, myconn)
            reader = command.ExecuteReader
            MessageBox.Show("DATA UPDATED")

            myconn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            myconn.Dispose()
        End Try
        Me.Close()

    End Sub

    

   
    Private Sub UpdateStaffRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mysqlconn As MySqlConnection
        Dim command As MySqlCommand

        mysqlconn = New MySqlConnection
        Dim Reader As MySqlDataReader
        mysqlconn.ConnectionString =
            "server=localhost;userid=root;password=;database=SMS"
            mysqlconn.Open()
            Dim query As String
            query = "select * FROM SMS.staffinfor where StaffId='" & login.TextBox1.Text & "' LIMIT 1"
            'MessageBox.Show(query)
            command = New MySqlCommand(query, mysqlconn)
            Reader = command.ExecuteReader()

        If Reader.Read() Then
            txtAdYr.Text = Reader("DateAdmitted")
            ' MessageBox.Show(txtAdYr.Text)
            txtCity.Text = Reader("City")
            txtDoB.Text = Reader("DOB")
            txtGender.Text = Reader("Gender")
            txtHobby.Text = Reader("Hobby")
            txtName.Text = Reader("FullName")
            txtPhone.Text = Reader("TelNumber")
            txtRegion.Text = Reader("Region")
            txtSubject.Text = Reader("SubjectTeaching")

        End If

        mysqlconn.Close()


    End Sub

    Private Sub txtName_Click(sender As Object, e As EventArgs) Handles txtName.Click
        MessageBox.Show("you cannot update this field")
    End Sub




    Private Sub txtGender_Click(sender As Object, e As EventArgs) Handles txtGender.Click
        MessageBox.Show("you cannot update this field")
    End Sub

    Private Sub txtSubject_Click(sender As Object, e As EventArgs) Handles txtSubject.Click
        MessageBox.Show("you cannot update this field")
    End Sub

    Private Sub txtAdYr_Click(sender As Object, e As EventArgs) Handles txtAdYr.Click
        MessageBox.Show("you cannot update this field")
    End Sub
End Class