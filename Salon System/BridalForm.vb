Imports System.Data.SqlClient
Imports System.IO

Public Class BridalForm
    Dim Con As New SqlConnection("Data Source=DESKTOP-TQTHBHK;Initial Catalog=SalonSystem;Integrated Security=True")
    Dim key = 0

    Private Sub view()
        Try
            Dim adapter As SqlDataAdapter = New SqlDataAdapter()
            adapter.SelectCommand = New SqlCommand("select * from ServiceTable where ServiceType = 'Bridal dressing'", Con)
            Dim dt As DataSet = New DataSet()
            adapter.Fill(dt)
            For Each row In dt.Tables(0).Rows
                DGVservice.Rows.Add(row("ServiceID").ToString(), row("ServiceName").ToString(), row("ServiceType").ToString(), row("ServicePrice").ToString(), row("SrviceDetail").ToString(), row("srviceImageloc").ToString(), File.ReadAllBytes(row("srviceImageloc").ToString()))
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub BridalForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        view()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ofd As New OpenFileDialog
        ofd.Filter = "choose Image(*.jpg;*.png;*.gif;*.pdf) |*.jpg;*.png;*.gif;*.pdf"
        If (ofd.ShowDialog() = DialogResult.OK) Then
            PictureBox1.Image = Image.FromFile(ofd.FileName)
            Txtlocation.Text = ofd.FileName.ToString()
        End If
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click

        If (btncancel.Text = "&Exit") Then
            'update coding
            Try
                ' Dim adapter As SqlDataAdapter = New SqlDataAdapter()
                Con.Open()
                Dim query = "update ServiceTable set ServiceName='" & txtName.Text & "', ServiceType='" & cbType.SelectedItem.ToString() & "', ServicePrice='" & Txtprice.Text & "', SrviceDetail='" & txtcomment.Text & "', SrviceImageloc='" & Txtlocation.Text & "' where ServiceId='" & key & "'"
                Dim cmd As SqlCommand = New SqlCommand(query, Con)

                Dim x = cmd.ExecuteNonQuery()
                Con.Close()
                If (x) Then
                    MessageBox.Show("Updated picture Sucessfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("picture not Updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End If

                DGVservice.Rows.Clear()
                txtName.Clear()
                cbType.SelectedIndex = -1
                Txtprice.Clear()
                txtcomment.Clear()
                Txtlocation.Clear()
                btncancel.Text = "Exit"
                view()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        Else
            'save coding
            ' Dim adapter As SqlDataAdapter = New SqlDataAdapter()
            Try
                Con.Open()
                Dim cmd As SqlCommand = New SqlCommand("insert into ServiceTable Values ('" & txtName.Text & "','" & cbType.SelectedItem.ToString() & "','" & Txtprice.Text & "','" & txtcomment.Text & "','" & Txtlocation.Text & "')", Con)

                Dim x = cmd.ExecuteNonQuery()
                Con.Close()
                If (x) Then
                    MessageBox.Show("saved picture Sucessfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("picture not Saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End If

                DGVservice.Rows.Clear()
                txtName.Clear()
                cbType.SelectedIndex = -1
                Txtprice.Clear()
                txtcomment.Clear()
                Txtlocation.Clear()
                view()


            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try
        End If
    End Sub
    Private Sub FilterData()


        Try
            DGVservice.Rows.Clear()
            Dim adapter As SqlDataAdapter = New SqlDataAdapter()
            adapter.SelectCommand = New SqlCommand("select * from ServiceTable where ServiceName like '%" & txtSearch.Text & "%'", Con)
            Dim dt As DataSet = New DataSet()
            adapter.Fill(dt)
            For Each row In dt.Tables(0).Rows
                DGVservice.Rows.Add(row("ServiceID").ToString(), row("ServiceName").ToString(), row("ServiceType").ToString(), row("ServicePrice").ToString(), row("SrviceDetail").ToString(), row("srviceImageloc").ToString(), File.ReadAllBytes(row("srviceImageloc").ToString()))
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        FilterData()
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        DGVservice.Rows.Clear()
        txtName.Clear()
        cbType.SelectedIndex = -1
        Txtprice.Clear()
        txtcomment.Clear()
        Txtlocation.Clear()
        PictureBox1.Dispose()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim ofd As New OpenFileDialog
        ofd.Filter = "choose Image(*.jpg;*.png;*.gif;*.pdf) |*.jpg;*.png;*.gif;*.pdf"
        If (ofd.ShowDialog() = DialogResult.OK) Then
            PictureBox1.Image = Image.FromFile(ofd.FileName)
            Txtlocation.Text = ofd.FileName.ToString()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MessageBox.Show("Are You want to close this form?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Me.Dispose()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'delete btn
        If key = 0 Then
            MessageBox.Show("Select Item to Delete")
        Else
            Try
                If MessageBox.Show("Are You Relly want to delete this?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                    Con.Open()
                    Dim cmd As New SqlCommand("Delete from ServiceTable where ServiceId='" & key & "'", Con)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Item detils deleted successfully ")
                    Con.Close()
                    view()
                    DGVservice.Rows.Clear()
                    txtName.Clear()
                    cbType.SelectedIndex = -1
                    Txtprice.Clear()
                    txtcomment.Clear()
                    Txtlocation.Clear()
                    PictureBox1.Dispose()
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub
End Class