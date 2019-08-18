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
        '   Dim reader As MySqlDataReader

        Try
            myconn.Open()
            Dim Query As String
            Query = "select * from SMS.Studentinfor"
            command = New MySqlCommand(Query, myconn)
            SDA.SelectCommand = command
            SDA.Fill(DBDATASET)
            bsource.DataSource = DBDATASET
            Me.DataGridView1.DataSource = bsource
            SDA.Update(DBDATASET)
            myconn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            myconn.Dispose()

        End Try
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawImage(Bitmap, 0, 0)
        Dim printview As RectangleF = e.PageSettings.PrintableArea
        If Me.DataGridView1.Height - printview.Height > 0 Then
            e.HasMorePages = True
            '      PrintDocument1.DefaultPageSettings.Landscape = True
        End If
    End Sub
    Private bitmap As Bitmap
    Private Sub InforToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InforToolStripMenuItem.Click
        Dim height As Integer = DataGridView1.Height
        DataGridView1.Height = DataGridView1.RowCount * DataGridView1.RowTemplate.Height
        bitmap = New Bitmap(Me.DataGridView1.Width, Me.DataGridView1.Height)
        DataGridView1.DrawToBitmap(bitmap, New Rectangle(0, 0, Me.DataGridView1.Width, Me.DataGridView1.Height))
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
        PrintPreviewDialog1.ShowDialog()
        DataGridView1.Height = Height


        PrintDocument1.Print()
        '   sender As Object, e As EventArgs

        '   Private Sub btnPrevieworPrint_Click() Handles btnPrevieworPrint.Click()

        '   PageSetupDialog1.PageSettings = PrintDocument1.PrinterSettings.DefaultPageSettings
        '  If PageSetupDialog1.ShowDialog() = DialogResult.OK Then
        '  PrintPreview()

        'End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SearchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchToolStripMenuItem.Click
        Dim StudentName = InputBox("Please Enter the Student Parent Number:", Name)
        myconn = New MySqlConnection
        myconn.ConnectionString = "server=localhost; userid=root;password=;DATABASE=SMS"

        Dim Command As New MySqlCommand("SELECT * FROM `studentinfor` WHERE ParentContact='" & StudentName & "' ", myconn)
        Command.Parameters.Add("@studentname", MySqlDbType.Int64).Value = StudentName
        'Dim reader As MySqlDataReader

        Dim SDA As New MySqlDataAdapter
        Dim DBDATASET As New DataTable
        Dim bsource As New BindingSource

        Try
            myconn.Open()

            SDA.SelectCommand = Command
            SDA.Fill(DBDATASET)
            bsource.DataSource = DBDATASET
            Me.DataGridView1.DataSource = bsource
            SDA.Update(DBDATASET)
            myconn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            myconn.Dispose()

        End Try
    End Sub

  
    Private Sub MagStuRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PrintDocument1.DefaultPageSettings.Landscape = True
    End Sub
End Class