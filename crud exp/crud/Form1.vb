Imports MySql.Data.MySqlClient

Public Class Form1
    Dim conn As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=vb")
    Dim i As Integer
    Dim r As MySqlDataReader

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGV_load() ' Load data when the form loads
    End Sub

    Public Sub DGV_load()
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            DataGridView1.Rows.Clear() ' Clear existing rows before loading new data
            Dim cmd As New MySqlCommand("SELECT * FROM vb_crudwithpic", conn)
            r = cmd.ExecuteReader
            While r.Read
                DataGridView1.Rows.Add(r("PRONO"), r("PRONAME"), r("PRICE"), r("PROGROUP"), r("EXPDATE"), r("STATUS"))
            End While
        Catch ex As Exception
            MsgBox("Error loading data: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            If r IsNot Nothing Then
                r.Close()
            End If
        End Try
        clearing()
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        save()
        DGV_load() ' Reload data after saving
    End Sub

    Public Sub save()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("INSERT INTO `vb_crudwithpic`(`PRONO`, `PRONAME`, `PRICE`, `PROGROUP`, `EXPDATE`, `STATUS`) VALUES (@PRONO,@PRONAME,@PRICE,@PROGROUP,@EXPDATE,@STATUS)", conn)
            cmd.Parameters.AddWithValue("@PRONO", prono.Text)
            cmd.Parameters.AddWithValue("@PRONAME", proname.Text)
            cmd.Parameters.AddWithValue("@PRICE", CDec(price.Text))
            cmd.Parameters.AddWithValue("@PROGROUP", progroup.Text)
            cmd.Parameters.AddWithValue("@EXPDATE", CDate(expd.Value))
            cmd.Parameters.AddWithValue("@STATUS", CBool(stat.Checked))
            i = cmd.ExecuteNonQuery()
            If i > 0 Then
                MessageBox.Show("Record Saved", "vb_crudwithpic", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Record Not Saved", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    Public Sub clearing()
        prono.Clear()
        proname.Clear()
        price.Clear()
        progroup.Text = ""
        expd.Value = Now
        stat.CheckState = False



    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        prono.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString()
        proname.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()
        price.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString()
        progroup.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString()
        expd.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString()
        prono.ReadOnly = True
        btn_save.Enabled = False

        ' Convert value to CheckState enumeration
        Dim isChecked As Boolean = Convert.ToBoolean(DataGridView1.CurrentRow.Cells(5).Value)
        If isChecked Then
            stat.Checked = CheckState.Checked
        Else
            stat.Checked = CheckState.Unchecked
        End If
    End Sub
    Sub edit()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("UPDATE `vb_crudwithpic` SET `PRONO`=@PRONO,`PRONAME`=@PRONAME,`PRICE`=@PRICE,`PROGROUP`=@PROGROUP,`EXPDATE`=@EXPDATE,`STATUS`=@STATUS WHERE `PRONO` = @PRONO", conn)
            cmd.Parameters.AddWithValue("@PRONO", prono.Text)
            cmd.Parameters.AddWithValue("@PRONAME", proname.Text)
            cmd.Parameters.AddWithValue("@PRICE", CDec(price.Text))
            cmd.Parameters.AddWithValue("@PROGROUP", progroup.Text)
            cmd.Parameters.AddWithValue("@EXPDATE", CDate(expd.Value))
            cmd.Parameters.AddWithValue("@STATUS", CBool(stat.Checked))
            i = cmd.ExecuteNonQuery()
            If i > 0 Then
                MessageBox.Show("Record Updated", "vb_crudwithpic", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Record Not Updated", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
        DGV_load()
    End Sub
    Private Sub update_Click(sender As Object, e As EventArgs) Handles update.Click
        edit()


    End Sub
    Public Sub delete_id()

        If MsgBox("Are you sure do Delete this product?", MsgBoxStyle.Question + vbYesNo) = vbYes Then
            Try
                conn.Open()
                Dim cmd As New MySqlCommand("DELETE FROM `vb_crudwithpic`  WHERE `PRONO` = @PRONO", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@PRONO", prono.Text)
                i = cmd.ExecuteNonQuery

                If i > 0 Then
                    MessageBox.Show("Record DELETED", "vb_crudwithpic", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Record Not DELETED", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                conn.Close()
            End Try
            clearing()
            DGV_load()
        Else
            Return

        End If

    End Sub
    Private Sub delete_Click(sender As Object, e As EventArgs) Handles delete.Click
        delete_id()
    End Sub

    Private Sub clear_Click(sender As Object, e As EventArgs) Handles clear.Click
        clearing()
    End Sub

    Private Sub search_TextChanged(sender As Object, e As EventArgs) Handles search.TextChanged
        Dim searchText As String = search.Text.Trim()

        ' Check if the search text is empty
        If searchText = "" Then
            ' If search text is empty, reload all data
            DGV_load()
            Return
        End If

        ' Clear existing rows before loading new data
        DataGridView1.Rows.Clear()

        Try
            conn.Open()

            ' Use a parameterized query to avoid SQL injection
            Dim cmd As New MySqlCommand("SELECT * FROM vb_crudwithpic WHERE PRONAME LIKE @searchText", conn)
            cmd.Parameters.AddWithValue("@searchText", "%" & searchText & "%") ' Use '%' for wildcard search

            Dim r As MySqlDataReader = cmd.ExecuteReader()

            While r.Read
                ' Add the rows that match the search criteria
                DataGridView1.Rows.Add(r("PRONO"), r("PRONAME"), r("PRICE"), r("PROGROUP"), r("EXPDATE"), r("STATUS"))
            End While

        Catch ex As Exception
            MsgBox("Error loading data: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

End Class

