Imports MySql.Data.MySqlClient
Public Class addStudentRecord
    'declearing the fields outside to make it global to be used in multiple functions and subs



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        'taking student details
        Dim sFirstName = studentFirstName.Text
        Dim sLastName = studentLastName.Text
        Dim sOtherName = studentOtherName.Text
        Dim sId = studentId.Text
        Dim sGraduation = graduation.Text
        Dim sAdmission = admission.Text
        Dim sDateOfBirth = studentDate.Value.Date
        Dim sClass = studentClass.Text

        Dim sGender


        'taking student father datails
        Dim fFirstName = fatherFirstName.Text
        Dim fLastName = motherLastName.Text
        Dim fEmail = fatherEmail.Text
        Dim fTelephone = fatherTelephone.Text
        Dim fAddress = fatherAddress.Text

        'taking student mother details
        Dim mFirstName = motherFirstName.Text
        Dim mlastName = motherFirstName.Text
        Dim mEmail = motherEmail.Text
        Dim mAddress = motherAddress.Text
        Dim mPhone = motherTelephone.Text
        If radioFemale.Checked Then
            sGender = radioFemale.Text
        ElseIf radioMale.Checked Then
            sGender = radioMale.Text
        End If
        'database connections
        Dim reader As MySqlDataReader
        Dim con As MySqlConnection = New MySqlConnection
        Dim command As MySqlCommand

        Try
            con.ConnectionString = "server=localhost; userid=root;password=;DATABASE=SMS"
            con.Open()


            Dim sql = "INSERT INTO studentinfor(StudentId, FirstName, LastName, otherName, DOB, Gender, 
                            Class, FatherContact, FatherFirstName,FatherLastName, FatherAddress, 
                            FatherEmail, MotherFirstName, MotherLastName, MotherContact, MotherAddress, MotherEmail) 
                    VALUES ('" & sId & "','" & sFirstName & "', '" & sLastName & "', '" & sOtherName & "', '" & sDateOfBirth & "', '" & sGender & "', '" & sClass & "', '" & fTelephone & "', 
            '" & fFirstName & "', '" & fLastName & "', '" & fAddress & "', '" & fEmail & "', '" & mFirstName & "', '" & mlastName & "', 
            '" & mPhone & "','" & mAddress & "', '" & mEmail & "')"
            command = New MySqlCommand(sql, con)

            reader = command.ExecuteReader
            MessageBox.Show("Data submited seccessfully!")


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try


        ' Validate the user inputs before submitting to the datebase

    End Sub

    Private Sub addStudentRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim admissionDate = New DateTimePicker()
        admission.Text = admissionDate.Value.Date.Year
        graduation.Text = admissionDate.Value.Date.Year + 4
        studentClass.SelectedIndex = 0

    End Sub



    Private Sub admission_Enter(sender As Object, e As EventArgs) Handles admission.Enter
        MessageBox.Show("Sorry you cannot change this value")
    End Sub


    Private Sub graduation_Enter(sender As Object, e As EventArgs) Handles graduation.Enter
        MessageBox.Show("Sorry you cannot change this value")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure?", "clear form data", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            ' Clearing student data
            studentFirstName.Clear()
            studentLastName.Clear()
            studentLastName.Clear()
            studentOtherName.Clear()
            studentDate.ResetText()
            If radioFemale.Checked Then
                radioFemale.ResetText()
            ElseIf radioMale.Checked Then
                radioMale.ResetText()
            End If
            ' Clearing student father datails
            fatherFirstName.Clear()
            fatherLastName.Clear()
            fatherEmail.Clear()
            fatherTelephone.Clear()
            fatherAddress.Clear()

            ' Clearing student mother details
            motherFirstName.Clear()
            motherFirstName.Clear()
            motherEmail.Clear()
            motherAddress.Clear()
            motherTelephone.Clear()





        End If



    End Sub
End Class
