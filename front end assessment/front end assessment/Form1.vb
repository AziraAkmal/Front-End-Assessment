Imports System.Data.DataTable
Imports System.Data.OleDb

Public Class Form1
    Dim con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Admin\Documents\Database1.accdb")
    Dim cmd As New OleDbCommand
    Dim i As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If con.state = ConnectionState.Open Then
            con.close()
        End If
        con.open()
        disp_data()
    End Sub

    Private Sub Runquery(ByVal query As String)
        Dim cmd As New OleDbCommand(query, con)
        cmd.Parameters.AddWithValue("@id", id.Text)
        cmd.Parameters.AddWithValue("@name", n.Text)
        cmd.Parameters.AddWithValue("@gender", gender.Text)
        cmd.Parameters.AddWithValue("@email", email.Text)
        cmd.Parameters.AddWithValue("@status", status.Text)
        cmd.ExecuteNonQuery()
    End Sub

    Public Sub disp_data()
        Dim cmd1 As New OleDbCommand
        cmd1 = con.createcommand()
        cmd1.CommandType = CommandType.Text
        cmd1.CommandText = "Select * from users"
        cmd1.ExecuteNonQuery()
        Dim da As New OleDbDataAdapter
        da.SelectCommand = cmd1
        Dim dt As New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub logout_Click(sender As Object, e As EventArgs) Handles logout.Click
        End
    End Sub

    Private Sub clear_Click(sender As Object, e As EventArgs) Handles clear.Click
        clear_data()
    End Sub

    Sub clear_data()
        id.Text = ""
        n.Text = ""
        gender.Text = ""
        email.Text = ""
        status.Text = ""
    End Sub

    Private Sub create_Click(sender As Object, e As EventArgs) Handles create.Click
        status.Text = "active"
        Dim inserquery As String = "insert into users (id,name,gender,email,status)values (@id,@nmae,@gender,@email,@status)"
        If (id.Text = "" Or n.Text = "" Or gender.Text = "" Or email.Text = "") Then
            MessageBox.Show("Please enter the details")

        Else
            Runquery(inserquery)
            MsgBox("Record successfully inserted!", MsgBoxStyle.Information, "Success")
        End If

        disp_data()
        clear_data()
    End Sub

    Private Sub update_Click(sender As Object, e As EventArgs) Handles updation.Click
        Dim updatequery As String = "update users set id=@id, name=@name,gender=@gender,email=@email, status=@status where id = @id"
        Runquery(updatequery)
        MsgBox("Record successfully updated!", MsgBoxStyle.Information, "Success")

        disp_data()
        clear_data()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            If con.state = ConnectionState.Open Then
                con.close()
            End If
            con.open()

            i = e.RowIndex
            Dim selectedRow As DataGridViewRow
            selectedRow = DataGridView1.Rows(i)
            id.Text = selectedRow.Cells(1).Value.ToString()
            n.Text = selectedRow.Cells(2).Value.ToString()
            email.Text = selectedRow.Cells(3).Value.ToString()
            gender.Text = selectedRow.Cells(4).Value.ToString()
            status.Text = selectedRow.Cells(5).Value.ToString()

        Catch ex As Exception
        End Try

        Dim cmd1 As New OleDbCommand
            cmd1 = con.createcommand()
            cmd1.CommandType = CommandType.Text
            cmd1.CommandText = "Select id, title, body from post where user_id = '" + id.Text + "'"
            cmd1.ExecuteNonQuery()
            Dim da1 As New OleDbDataAdapter
            da1.SelectCommand = cmd1
            Dim dt1 As New DataTable
            da1.Fill(dt1)
            DataGridView2.DataSource = dt1

            Dim cmd2 As New OleDbCommand
            cmd2 = con.createcommand()
            cmd2.CommandType = CommandType.Text
            cmd2.CommandText = "Select c.id, c.name, c.email, c.body from comment c,post p where c.post_id = p.id and p.user_id = '" + id.Text + "'"
            cmd2.ExecuteNonQuery()
            Dim da2 As New OleDbDataAdapter
            da2.SelectCommand = cmd2
            Dim dt2 As New DataTable
            da2.Fill(dt2)
            DataGridView3.DataSource = dt2

            Dim cmd3 As New OleDbCommand
            cmd3 = con.createcommand()
            cmd3.CommandType = CommandType.Text
            cmd3.CommandText = "Select id, title, due_on, status from todos where user_id = '" + id.Text + "'"
            cmd3.ExecuteNonQuery()
            Dim da3 As New OleDbDataAdapter
            da3.SelectCommand = cmd3
            Dim dt3 As New DataTable
            da3.Fill(dt3)
        DataGridView4.DataSource = dt3

    End Sub

    Private Sub search_Click(sender As Object, e As EventArgs) Handles search.Click
        cmd = con.createcommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Select * from users where id='" + id.Text + "'"
        If (id.Text = "") Then
            MessageBox.Show("Please enter the id number. Thank you.")
        Else
            cmd.ExecuteNonQuery()
            MsgBox("Successfully Search!", MsgBoxStyle.Information, "Success")

            Dim da As New OleDbDataAdapter
            da.SelectCommand = cmd
            Dim dt As New DataTable
            da.Fill(dt)
            DataGridView1.DataSource = dt

            Dim cmd1 As New OleDbCommand
            cmd1 = con.createcommand()
            cmd1.CommandType = CommandType.Text
            cmd1.CommandText = "Select id,title, body from post where user_id = '" + id.Text + "'"
            cmd1.ExecuteNonQuery()
            Dim da1 As New OleDbDataAdapter
            da1.SelectCommand = cmd1
            Dim dt1 As New DataTable
            da1.Fill(dt1)
            DataGridView2.DataSource = dt1

            Dim cmd2 As New OleDbCommand
            cmd2 = con.createcommand()
            cmd2.CommandType = CommandType.Text
            cmd2.CommandText = "Select c.id, c.name, c.email, c.body from comment c,post p where c.post_id = p.id and p.user_id = '" + id.Text + "'"
            cmd2.ExecuteNonQuery()
            Dim da2 As New OleDbDataAdapter
            da2.SelectCommand = cmd2
            Dim dt2 As New DataTable
            da2.Fill(dt2)
            DataGridView3.DataSource = dt2

            Dim cmd3 As New OleDbCommand
            cmd3 = con.createcommand()
            cmd3.CommandType = CommandType.Text
            cmd3.CommandText = "Select id, title, due_on, status from todos where user_id = '" + id.Text + "'"
            cmd3.ExecuteNonQuery()
            Dim da3 As New OleDbDataAdapter
            da3.SelectCommand = cmd3
            Dim dt3 As New DataTable
            da3.Fill(dt3)
            DataGridView4.DataSource = dt3

        End If

        clear_data()
    End Sub

    Private Sub delete_Click(sender As Object, e As EventArgs) Handles delete.Click
        If con.state = ConnectionState.Open Then
            con.close()
        End If
        con.open()

        cmd = con.createcommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "delete from users where id= '" & id.Text & "'"
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete the data?", "Delete Confirmation!", MessageBoxButtons.YesNo)
        If (id.Text = "" And result = DialogResult.No) Then
            MessageBox.Show("Cancel Data Deletion")
        ElseIf (result = DialogResult.Yes) Then
            cmd.ExecuteNonQuery()
            MsgBox("Delete Successfully", MsgBoxStyle.Information, "Success")
            disp_data()
        End If
        clear_data()
        disp_data()

    End Sub

    Private Sub display_Click(sender As Object, e As EventArgs) Handles display.Click
        disp_data()

        DataGridView2.DataSource.clear()
        DataGridView3.DataSource.clear()
        DataGridView4.DataSource.clear()

    End Sub

End Class
