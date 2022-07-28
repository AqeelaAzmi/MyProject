Imports System.Data.SqlClient
Public Class PackageForm
    Dim Con As New SqlConnection("Data Source=DESKTOP-TQTHBHK;Initial Catalog=SalonSystem;Integrated Security=True")

    Private Sub ShowData()
        Dim cmd As New SqlCommand("Select * from PackageTable", Con)
        Dim adapter As New SqlDataAdapter
        adapter.SelectCommand = cmd
        Dim dt As New DataTable
        dt.Clear()
        adapter.Fill(dt)
        DGVpac.DataSource = dt

    End Sub

    Private Sub Clear()
        txtname.Text = ""
        txtprice.Text = ""
        txtduration.Text = ""
        txtsessions.Text = ""
        txtdetails.Text = ""
    End Sub


    Private Sub PackageForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowData()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim addpac = New PackageAddForm
        addpac.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If MessageBox.Show("Are You want to close this form?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Me.Dispose()
        End If
    End Sub

    Dim key
    Private Sub DGVpac_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGVpac.CellMouseDoubleClick
        Dim row As DataGridViewRow = DGVpac.Rows(e.RowIndex)
        key = Convert.ToInt32(row.Cells(0).Value.ToString())
        txtname.Text = row.Cells(1).Value.ToString()
        txtprice.Text = row.Cells(2).Value.ToString()
        txtduration.Text = row.Cells(3).Value.ToString()
        txtsessions.Text = row.Cells(4).Value.ToString()
        txtdetails.Text = row.Cells(5).Value.ToString()
    End Sub

    Private Sub btndel_Click(sender As Object, e As EventArgs) Handles btndel.Click
        If key = 0 Then
            MessageBox.Show("Select Item to Delete")


        Else


            Try
                If MessageBox.Show("Are You Really want to Delete this?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then

                    Con.Open()
                    Dim qry As String
                    qry = "Delete from PackageTable Where Id='" & key & "'"
                    Dim cmd As New SqlCommand(qry, Con)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Details Deleted Successfullly")
                    Con.Close()
                    ShowData()
                    Clear()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                End Try

            End If
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If key = 0 Then
            MessageBox.Show("Select Item to Edit")

        Else
            Try
                Con.Open()
                Dim Query As String
                Query = "update PackageTable set pacName='" & txtname.Text & "', PacPrice='" & txtprice.Text & "', PacDuration='" & txtduration.Text & "', PacSession='" & txtsessions.Text & "', PacDetails='" & txtdetails.Text & "'  where Id='" & key & "'"
                Dim cmd As New SqlCommand(Query, Con)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Details Updted Successfullly")
                Con.Close()
                ShowData()
                Clear()
            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ShowData()
    End Sub
End Class