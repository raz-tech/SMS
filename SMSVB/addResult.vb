Imports MySql.Data.MySqlClient
Public Class addResult

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim myconn As MySqlConnection
        Dim command As MySqlCommand
        MYCONN = New MySqlConnection

        MYCONN.ConnectionString = "server=localhost; userid=root; password=; database=SMS"
        Dim reader As MySqlDataReader
        Try
            MYCONN.Open()
            Dim Query As String
            Dim total As Integer = Val(midTerm.Text) + Val(endTerm.Text)
            Query =
"insert into SMS.examResult (firstName,lastName,academicYear,term,midTerm,endTerm,totalMark) values ('" & firstName.Text & "','" & lastName.Text & "','" & academicYear.Text & "','" & term.Text & "','" & midTerm.Text & "','" & endTerm.Text & "','" & total & "')  "
            Command = New MySqlCommand(Query, MYCONN)
            reader = Command.ExecuteReader
            MessageBox.Show("Result Submited Successfully. Thank you!!!")

            MYCONN.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MYCONN.Dispose()
        End Try
    End Sub
End Class