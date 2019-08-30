Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Public Class addStudentRecord
    Dim myconn As MySqlConnection
    Dim command As MySqlCommand
    Public Property ErrorProvider1 As Object

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = Nothing Or TextBox3.Text = Nothing Or TextBox9.Text = Nothing Or ComboBox1.Text = Nothing _
        Or TextBox4.Text = Nothing Or TextBox2.Text = Nothing Or ComboBox2.Text = Nothing Or TextBox5.Text = Nothing Or TextBox6.Text = Nothing _
        Or TextBox8.Text = Nothing Or TextBox7.Text = Nothing Then

            MsgBox("Please fill the field", MsgBoxStyle.Information, MsgBoxStyle.Critical)
        Else
            myconn = New MySqlConnection

            myconn.ConnectionString = "server=localhost; userid=root; password=; database=SMS"
            Dim reader As MySqlDataReader
            Try
                myconn.Open()
                Dim Query As String
                Query =
    "insert into SMS.studentinfor (StudentID,FirstName,LastName,DOB,Address,Gender,City,District,Class,ParentContact,ParentFullName,Occupation,MOMONumber) values ('" & TextBox10.Text & "','" & TextBox1.Text & "','" & TextBox3.Text & "','" & DateTimePicker1.Text & "','" & TextBox9.Text & "','" & ComboBox1.Text & "','" & TextBox4.Text & "','" & TextBox2.Text & "','" & ComboBox2.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox8.Text & "','" & TextBox7.Text & "')  "
                command = New MySqlCommand(Query, myconn)
                reader = command.ExecuteReader
                MessageBox.Show("Form Submited Successfully. Thank you!!!")

                myconn.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                myconn.Dispose()
            End Try
        End If





    End Sub

    Private Sub coloring()
        Throw New NotImplementedException()
    End Sub




    Private Sub addStudentRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rn As Integer
        Dim ipper As Integer = 2009
        ''     Dim faculty As String = InputBox("Enter the School Short Code:")
        ' '    Dim year As Integer = InputBox("Enter the last two digit of the Admitted year:")
        Randomize()

        rn = Rnd() * ipper
        '    TextBox1.Text = faculty & "/" & rn & "/" & year
        TextBox10.Text = rn



    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MagStuRecord.Show()
        Me.Hide()

    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles TextBox10.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        login.Show()

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_Validated(sender As Object, e As EventArgs) Handles TextBox1.Validated

    End Sub

    Private Sub TextBox1_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles TextBox1.Validating
        '   sender As Object, e As CancelEventArgs   
        Dim ctl As Control = CType(sender, Control)
        If ctl.Text = "" Then
            e.Cancel = True
            '  ErrorProvider1.SetError(ctl, "Please enter a value")
            MsgBox("please enter a value")
        End If
        '   ErrorProvider1.Clear()

    End Sub

    Private Sub addStudentRecord_Validating(sender As Object, e As CancelEventArgs) Handles Me.Validating

    End Sub
End Class
