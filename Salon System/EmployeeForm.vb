Imports System.Data.SqlClient
Public Class EmployeeForm
    Dim Con As New SqlConnection("Data Source=DESKTOP-TQTHBHK;Initial Catalog=SalonSystem;Integrated Security=True")

    Dim key = 0
    Private Sub EmployeeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowData()
    End Sub

    Private Sub Clear()
        key = 0
        txtFname.Text = ""
        txtLname.Text = ""
        txtStreet.Text = ""
        txtCity.Text = ""
        txtNIC.Text = ""
        txtPhone.Text = ""
        txtEmail.Text = ""
        txtPosition.Text = ""
        txtQul.Text = ""
        cbStype.SelectedIndex = -1
        txtSalary.Text = ""
        DpDOB.Value = Format(Date.Now)
        DpJdate.Value = Format(Date.Now)


    End Sub

    Private Sub ShowData()
        Dim cmd As New SqlCommand("Select * from EmployeeTbl", Con)
        Dim adapter As New SqlDataAdapter
        adapter.SelectCommand = cmd
        Dim dt As New DataTable
        dt.Clear()
        adapter.Fill(dt)
        empDGV.DataSource = dt

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'delete btn
        If key = 0 Then
            MessageBox.Show("Select Employee to Delete")

        Else
            Try
                If MessageBox.Show("Are You Relly want to delete this?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                    Con.Open()
                    Dim qry As String
                    qry = "Delete from EmployeeTbl Where empid='" & key & "'"
                    Dim cmd As New SqlCommand(qry, Con)
                    cmd.ExecuteNonQuery()
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
            MessageBox.Show("Select Employeee  to Update")

        Else
            Try
                Con.Open()
                Dim Query As String
                Query = "update EmployeeTbl set empFName='" & txtFname.Text & "', empLName='" & txtLname.Text & "', empStreet='" & txtStreet.Text & "', empCity='" & txtCity.Text & "', empDOB='" & DpDOB.Value & "', empNIC='" & txtNIC.Text & "', empPhone='" & txtPhone.Text & "', empEmail='" & txtEmail.Text & "', empPosition='" & txtPosition.Text & "', empQualification='" & txtQul.Text & "', empSType='" & cbStype.SelectedItem.ToString() & "', empSAmount='" & txtSalary.Text & "',  empJDate='" & DpJdate.Value & "' where empid='" & key & "'"
                Dim cmd As New SqlCommand(Query, Con)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Detais Updted Successfullly")
                Con.Close()
                ShowData()
                Clear()
            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'exit btn
        If MessageBox.Show("Are You want to close the form?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Me.Dispose()
        End If
    End Sub




    Private Sub empDGV_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles empDGV.CellMouseDoubleClick


        Dim row As DataGridViewRow = empDGV.Rows(e.RowIndex)
        key = Convert.ToInt32(row.Cells(0).Value.ToString())
        txtFname.Text = row.Cells(1).Value.ToString()
        txtLname.Text = row.Cells(2).Value.ToString()
        txtStreet.Text = row.Cells(3).Value.ToString()
        txtCity.Text = row.Cells(4).Value.ToString()
        DpDOB.Value = row.Cells(5).Value.ToString()
        txtNIC.Text = row.Cells(6).Value.ToString()
        txtPhone.Text = row.Cells(7).Value.ToString()
        txtEmail.Text = row.Cells(8).Value.ToString()
        txtPosition.Text = row.Cells(9).Value.ToString()
        txtQul.Text = row.Cells(10).Value.ToString()
        cbStype.SelectedItem = row.Cells(11).Value.ToString()
        txtSalary.Text = row.Cells(12).Value.ToString()
        DpJdate.Value = row.Cells(13).Value.ToString()

    End Sub

    Private Sub FilterData()
        Con.Open()
        Dim query = "select * from EmployeeTbl where empFName like '%" & txtSearch.Text & "%'"
        Dim cmd As New SqlCommand(query, Con)
        Dim adapter As SqlDataAdapter
        ' Dim cmd As SqlCommand
        cmd = New SqlCommand(query, Con)
        adapter = New SqlDataAdapter(cmd)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataTable
        ds = New DataTable
        adapter.Fill(ds)
        empDGV.DataSource = ds
        Con.Close()
    End Sub
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        FilterData()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim addfrm As New employeeAddForm
        addfrm.ShowDialog()


    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        ShowData()
        txtSearch.Clear()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Clear()
    End Sub


End Class