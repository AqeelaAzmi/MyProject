Imports System.Data.SqlClient

Public Class CustomerForm
    Dim Con As New SqlConnection("Data Source=DESKTOP-TQTHBHK;Initial Catalog=SalonSystem;Integrated Security=True")

    Dim key = 0
    Private Sub Clear()
        txtFName.Text = ""
        txtLName.Text = ""
        txtStreet.Text = ""
        txtCity.Text = ""
        txtNIC.Text = ""
        txtPhone.Text = ""
        txtEmail.Text = ""
        txtPAmount.Text = ""
        cbPmethod.SelectedIndex = -1
        dpDOB.Value = Format(Date.Now)
        dpRDate.Value = Format(Date.Now)

    End Sub

    Private Sub ShowData()
        Dim cmd As New SqlCommand("Select * from CustomerTbl", Con)
        Dim adapter As New SqlDataAdapter
        adapter.SelectCommand = cmd
        Dim dt As DataTable
        dt = New DataTable
        dt.Clear()
        adapter.Fill(dt)
        cusDGV.DataSource = dt

    End Sub




    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If MessageBox.Show("Are You want to close this form?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Me.Dispose()
        End If
    End Sub

    Private Sub CustomerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowData()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'delete btn
        If key = 0 Then
            MessageBox.Show("Select customer to Delete")
        Else
            Try
                If MessageBox.Show("Are You Relly want to delete this?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                    Con.Open()
                    Dim cmd As New SqlCommand("Delete from CustomerTbl where CusId='" & key & "'", Con)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Customer detils deleted successfully ")
                    Con.Close()
                    ShowData()
                    Clear()
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If key = 0 Then
            MessageBox.Show("Select Customer  to Edit")
        Else
            Try
                Con.Open()
                Dim Query As String
                Query = "Update CustomerTbl Set CusFName='" & txtFName.Text & "', CusLName='" & txtLName.Text & "', CusStreet='" & txtStreet.Text & "', CusCity='" & txtCity.Text & "', CusDOB='" & dpDOB.Value & "',CusNIC='" & txtNIC.Text & "',CusPhone='" & txtPhone.Text & "',CusEmail='" & txtEmail.Text & "',CusPAmount='" & txtPAmount.Text & "',CusPMethod='" & cbPmethod.SelectedItem.ToString() & "',CusRDate='" & dpRDate.Value & "' where CusId='" & key & "'"
                Dim cmd As New SqlCommand(Query, Con)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Details Saved Successfully")
                Con.Close()
                Clear()
                ShowData()

            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try
        End If
    End Sub


    Private Sub cusDGV_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles cusDGV.CellMouseDoubleClick

        Dim row As DataGridViewRow = cusDGV.Rows(e.RowIndex)
        key = Convert.ToInt32(row.Cells(0).Value.ToString())
        txtFName.Text = row.Cells(1).Value.ToString()
        txtLName.Text = row.Cells(2).Value.ToString()
        txtStreet.Text = row.Cells(3).Value.ToString()
        txtCity.Text = row.Cells(4).Value.ToString()
        dpDOB.Value = row.Cells(5).Value.ToString()
        txtNIC.Text = row.Cells(6).Value.ToString()
        txtPhone.Text = row.Cells(7).Value.ToString()
        txtEmail.Text = row.Cells(8).Value.ToString()
        txtPAmount.Text = row.Cells(9).Value.ToString()
        cbPmethod.SelectedItem = row.Cells(10).Value.ToString()
        dpRDate.Value = row.Cells(11).Value.ToString()
    End Sub
    Private Sub FilterData()
        Con.Open()
        Dim query = "select * from  CustomerTbl where CusFName like '%" & txtSearch.Text & "%'"
        Dim cmd As New SqlCommand(query, Con)
        Dim adapter As SqlDataAdapter
        cmd = New SqlCommand(query, Con)
        adapter = New SqlDataAdapter(cmd)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataTable
        ds = New DataTable
        adapter.Fill(ds)
        cusDGV.DataSource = ds
        Con.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        FilterData()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim addfrm As New AddCusForm
        addfrm.ShowDialog()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Clear()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ShowData()
        txtSearch.Clear()
    End Sub


End Class