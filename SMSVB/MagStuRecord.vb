Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing
Public Class MagStuRecord
    Dim myconn As MySqlConnection
    Dim command As MySqlCommand

    Private Sub Button2_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub menuUpdate_Click(sender As Object, e As EventArgs) Handles menuUpdate.Click

        UpdateStudntRecord.Show()
        Me.Hide()
    End Sub

    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click
        addStudentRecord.Show()
        Me.Hide()

    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        DeleteStudent.Show()
        Me.Hide()
    End Sub

    Private Sub CreateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateToolStripMenuItem.Click

    End Sub

    Private Sub DatabaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DatabaseToolStripMenuItem.Click
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

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawImage(bitmap, 0, 0)
        Dim printview As RectangleF = e.PageSettings.PrintableArea
        If Me.ListView1.Height - printview.Height > 0 Then
            e.HasMorePages = True
        End If
    End Sub
    Private bitmap As Bitmap
    Private Sub InforToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InforToolStripMenuItem.Click
        Dim height As Integer = ListView1.Height
        '    ListView1.Height = ListView1.Items
        bitmap = New Bitmap(Me.ListView1.Width, Me.ListView1.Height)
        ListView1.DrawToBitmap(bitmap, New Rectangle(0, 0, Me.ListView1.Width, Me.ListView1.Height))
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
        PrintPreviewDialog1.ShowDialog()
        ListView1.Height = height


        PrintDocument1.Print()




    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SearchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchToolStripMenuItem.Click
        Dim StudentName = InputBox("Please Enter the Student Parent Number:", Name)
        myconn = New MySqlConnection
        myconn.ConnectionString = "server=localhost; userid=root;password=;DATABASE=SMS"

        Dim Command As New MySqlCommand("SELECT * FROM `studentinfor` WHERE ParentContact='" & StudentName & "' ", myconn)
        Command.Parameters.Add("@studentname", MySqlDbType.Int64).Value = StudentName
        Dim reader As MySqlDataReader

        Try
            myconn.Open()
            Dim Query As String
            Query = "select * from SMS.Studentinfor"
            Command = New MySqlCommand(Query, myconn)
            reader = Command.ExecuteReader(CommandBehavior.CloseConnection)
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

  
    Private Sub MagStuRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PrintDocument1.DefaultPageSettings.Landscape = True
    End Sub
End Class