Imports MySql.Data.MySqlClient
Public Class teacherDashboard

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        DataGridView1.ClearSelection()
        Dim conn As MySqlConnection
        Dim DataAdapter As New MySqlDataAdapter
        Dim DataSet As New DataTable
        Dim Source As New BindingSource
        Dim command As MySqlCommand
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password=;database=sms"

        Try
            conn.Open()
            Dim query As String = "SELECT * FROM studentinfor"
            command = New MySqlCommand(query, conn)
            DataAdapter.SelectCommand = command
            DataAdapter.Fill(DataSet)
            Source.DataSource = DataSet
            DataGridView1.DataSource = Source
            DataAdapter.Update(DataSet)
            conn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub teacherDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.ClearSelection()
        Dim conn As MySqlConnection
        Dim DataAdapter As New MySqlDataAdapter
        Dim DataSet As New DataTable
        Dim Source As New BindingSource
        Dim command As MySqlCommand
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password=;database=sms"

        Try
            conn.Open()
            Dim query As String = "SELECT * FROM studentinfor"
            command = New MySqlCommand(query, conn)
            DataAdapter.SelectCommand = command
            DataAdapter.Fill(DataSet)
            Source.DataSource = DataSet
            DataGridView1.DataSource = Source
            DataAdapter.Update(DataSet)
            conn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        DataGridView1.ClearSelection()
        Dim conn As MySqlConnection
        Dim DataAdapter As New MySqlDataAdapter
        Dim DataSet As New DataTable
        Dim Source As New BindingSource
        Dim command As MySqlCommand
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password=;database=sms"

        Try
            conn.Open()
            Dim query As String = "SELECT * FROM examresult"
            command = New MySqlCommand(query, conn)
            DataAdapter.SelectCommand = command
            DataAdapter.Fill(DataSet)
            Source.DataSource = DataSet
            DataGridView1.DataSource = Source
            DataAdapter.Update(DataSet)
            conn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        addResult.ShowDialog()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MessageBox.Show("Not available yet")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        '   teacherProfile.ShowDialog()
        UpdateStaffRecords.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        login.Show()
    End Sub
End Class