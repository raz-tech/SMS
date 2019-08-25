Imports MySql.Data.MySqlClient
Public Class DeleteStudent
    Dim myconn As MySqlConnection
    Dim command As MySqlCommand

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '  MessageBox.Show("Are you sure that you want to delete the student?)
        If MsgBox("Are you sure to DELETE?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "WARNING") = MsgBoxResult.Yes Then
            MsgBox("YES Clicked.")

            myconn = New MySqlConnection

            myconn.ConnectionString = "server=localhost; userid=root; password=; database=sms"
            Dim reader As MySqlDataReader
            Try
                myconn.Open()
                Dim Query As String
                Query =
"delete from  SMS.Studentinfor where StudentId='" & TextBox1.Text & "'"
                command = New MySqlCommand(Query, myconn)
                reader = command.ExecuteReader
                MessageBox.Show(" STUDENT DATA DELETED SUCCESSFULLY")

                myconn.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                myconn.Dispose()
            End Try
        Else
            MsgBox("NO Clicked.")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MagStuRecord.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        myconn = New MySqlConnection
        myconn.ConnectionString = "server=localhost; userid=root;password=;DATABASE=SMS"
        Dim SDA As New MySqlDataAdapter
        Dim DBDATASET As New DataTable
        Dim bsource As New BindingSource
        Dim reader As MySqlDataReader

        Try
            myconn.Open()
            Dim Query As String
            Query = "select * from SMS.Studentinfor"
            command = New MySqlCommand(Query, myconn)
            reader = command.ExecuteReader(CommandBehavior.CloseConnection)
            ListView1.Items.Clear()
            Dim x As ListViewItem
            Do While reader.Read = True
                x = New ListViewItem(reader("StudentId").ToString)
                x.SubItems.Add(reader("FirstName"))
                x.SubItems.Add(reader("LastName"))
                x.SubItems.Add(reader("DOB"))
                x.SubItems.Add(reader("Address"))
                x.SubItems.Add(reader("Gender"))
                x.SubItems.Add(reader("City"))
                x.SubItems.Add(reader("District"))
                x.SubItems.Add(reader("Class"))
                x.SubItems.Add(reader("ParentContact"))
                x.SubItems.Add(reader("ParentFullName"))
                x.SubItems.Add(reader("Occupation"))
                x.SubItems.Add(reader("MOMONumber"))
                ListView1.Items.Add(x)
            Loop

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            myconn.Dispose()
            myconn.Close()

        End Try
    End Sub
    Dim bitmap As Bitmap
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim height As Integer = ListView1.Height
        '    ListView1.Height = ListView1.Items
        Bitmap = New Bitmap(Me.ListView1.Width, Me.ListView1.Height)
        ListView1.DrawToBitmap(bitmap, New Rectangle(0, 0, Me.ListView1.Width, Me.ListView1.Height))
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
        PrintPreviewDialog1.ShowDialog()
        ListView1.Height = height


        PrintDocument1.Print()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawImage(bitmap, 0, 0)
        Dim printview As RectangleF = e.PageSettings.PrintableArea
        If Me.ListView1.Height - printview.Height > 0 Then
            e.HasMorePages = True
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        login.Show()
        Me.Hide()
    End Sub
End Class