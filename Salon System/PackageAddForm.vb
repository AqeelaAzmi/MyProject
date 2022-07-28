Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class PackageAddForm
    Dim Con As New SqlConnection("Data Source=DESKTOP-TQTHBHK;Initial Catalog=SalonSystem;Integrated Security=True")

    Private Sub Clear()
        txtname.Text = ""
        txtprice.Text = ""
        txtduration.Text = ""
        txtsessions.Text = ""
        txtdetails.Text = ""
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtname.Text = "" Or txtprice.Text = "" Or txtdetails.Text = "" Then
            MessageBox.Show("You can't Add Details. Some Important Details Missing!")

        Else
            Try
                Con.Open()
                Dim Query As String
                Query = "insert into PackageTable Values('" & txtname.Text & "','" & txtprice.Text & "','" & txtduration.Text & "','" & txtsessions.Text & "','" & txtdetails.Text & "')"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(Query, Con)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Package Details Added Successfully")
                Con.Close()

                Clear()
            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try
        End If
    End Sub


    Private Sub FilterData()
        Try
            Dim adapter As SqlDataAdapter = New SqlDataAdapter()
            adapter.SelectCommand = New SqlCommand("select * from ServiceTable where ServiceName like '%" & txtSearch.Text & "%'", Con)
            Dim dt As DataSet = New DataSet()
            adapter.Fill(dt)
            For Each row In dt.Tables(0).Rows
                DGVaddpac.Rows.Add(row("ServiceID").ToString(), row("ServiceName").ToString(), row("ServiceType").ToString(), row("ServicePrice").ToString())
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub ShowData()

        Try
            Dim adapter As SqlDataAdapter = New SqlDataAdapter()
            adapter.SelectCommand = New SqlCommand("select * from ServiceTable", Con)
            Dim dt As DataSet = New DataSet()
            adapter.Fill(dt)
            For Each row In dt.Tables(0).Rows
                DGVaddpac.Rows.Add(row("ServiceID").ToString(), row("ServiceName").ToString(), row("ServiceType").ToString(), row("ServicePrice").ToString())
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub btnselect_Click(sender As Object, e As EventArgs) Handles btnselect.Click
        ShowData()
    End Sub



    Dim i, total
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Try
            Dim rnum As Integer = DGVselectedpac.Rows.Add()
            i = i + 1
            DGVselectedpac.Rows.Item(rnum).Cells("Column1").Value = i
            DGVselectedpac.Rows.Item(rnum).Cells("Column2").Value = DGVaddpac.SelectedCells(1).Value.ToString()
            DGVselectedpac.Rows.Item(rnum).Cells("Column3").Value = DGVaddpac.SelectedCells(3).Value.ToString()

            Dim tot = Convert.ToInt32(DGVselectedpac.Rows.Item(rnum).Cells("Column3").Value)

            total = total + tot
            Dim grdtot As String
            grdtot = "Rs " + Convert.ToString(total)
            lbltotal.Text = grdtot

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Dim dis, Amount

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim per = Convert.ToDouble(txtper.Text)
        dis = total * (per * 0.01)
        Dim discount As String
        discount = "Rs " + Convert.ToString(dis)
        lbldiscount.Text = discount
        Amount = total - dis

        Dim price As String
        price = "Rs " + Convert.ToString(Amount)
        lblprice.Text = price

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            Dim i
            i = Convert.ToInt32(DGVselectedpac.SelectedCells(2).Value.ToString())
            total = total - i
            Dim grdtot As String
            grdtot = "Rs " + Convert.ToString(total)
            lbltotal.Text = grdtot
            Dim index As Integer
            index = DGVselectedpac.CurrentCell.RowIndex
            DGVselectedpac.Rows.RemoveAt(index)

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        txtprice.Text = Amount
    End Sub
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        FilterData()
    End Sub
End Class