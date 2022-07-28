Imports System.Data.SqlClient
Public Class AddAppointmentForm
    Public Shared editdetails As String
    Dim con As New SqlConnection("Data Source=DESKTOP-TQTHBHK;Initial Catalog=SalonSystem;Integrated Security=True")

    Private Sub AddAppointmentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        information()
        servicedata()
        employeedetails()
    End Sub

    Private Sub addbtn_Click(sender As Object, e As EventArgs) Handles addbtn.Click

        If txtcusname.Text = "" And txtEAddress.Text = "" And txtPhno.Text = "" And txtStylistId.Text = "" And txtstylistname.Text = "" And txtRService.Text = "" Then
            MessageBox.Show("some important Details are missing ", "Missing Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Try
                con.Open()
                Dim qry As String
                qry = "insert into AppointmentTable values('" & txtcusname.Text & "','" & txtEAddress.Text & "','" & txtPhno.Text & "',
                '" & DTappoinment.Value & "','" & CBTime.SelectedItem.ToString() & "','" & txtStylistId.Text & "','" & txtstylistname.Text & "','" & txtRService.Text & "','" & txtprice.Text & "','" & txtAdetails.Text & "')"
                Dim cmd As New SqlCommand(qry, con)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Appointment Details has been added")




            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If
    End Sub

    Private Sub information()
        If editdetails > 0 Then
            Try
                con.Open()
                Dim cmd As New SqlCommand("Select * from AppointmentTable where AppointmentId='" & editdetails & "'", con)
                Dim adapter As New SqlDataAdapter(cmd)
                Dim table As New DataTable
                adapter.Fill(table)
                con.Close()
                Label6.Text = table.Rows(0)(0).ToString()
                txtcusname.Text = table.Rows(0)(1).ToString()
                txtEAddress.Text = table.Rows(0)(2).ToString()
                txtPhno.Text = table.Rows(0)(3).ToString()
                DTappoinment.Value = table.Rows(0)(4).ToString()
                CBTime.SelectedItem = table.Rows(0)(5).ToString()
                txtStylistId.Text = table.Rows(0)(6).ToString()
                txtstylistname.Text = table.Rows(0)(7).ToString()
                txtRService.Text = table.Rows(0)(8).ToString()
                txtprice.Text = table.Rows(0)(9).ToString()
                txtAdetails.Text = table.Rows(0)(10).ToString()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub



    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click

        Try
            con.Open()
            Dim query As String
            query = "update AppointmentTable set  CustomerName='" & txtcusname.Text & "', EmailAddress='" & txtEAddress.Text & "', PhoneNumber='" & txtPhno.Text & "', AppointmentDate='" & DTappoinment.Value & "',
            AppointmentTime='" & CBTime.SelectedItem.ToString() & "', StylistId='" & txtStylistId.Text & "', StylistName='" & txtstylistname.Text & "', Service='" & txtRService.Text & "', price='" & txtprice.Text & "', Details='" & txtAdetails.Text & "' where AppointmentId='" & Label6.Text & "'"

            Dim cmd As New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            MessageBox.Show("details Saved Successfully")
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)


        End Try
    End Sub

    Private Sub servicedata()

        Try
            Dim cmd As New SqlCommand("Select ServiceId,Servicename,ServicePrice from ServiceTable", con)
            Dim adapter As New SqlDataAdapter
            adapter.SelectCommand = cmd
            Dim dt As New DataTable
            dt.Clear()
            adapter.Fill(dt)
            serviceDGV.DataSource = dt

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub serviceDGV_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles serviceDGV.CellMouseDoubleClick

        Dim row As DataGridViewRow = serviceDGV.Rows(e.RowIndex)
        'key = Convert.ToInt32(row.Cells(0).Value.ToString())
        txtRService.Text = row.Cells(1).Value.ToString()
        txtprice.Text = row.Cells(2).Value.ToString()

    End Sub

    Private Sub cussrchbtn_Click(sender As Object, e As EventArgs) Handles cussrchbtn.Click

        Try
            con.Open()
            Dim cmd As New SqlCommand("select CusFName,CusPhone,CusEmail from CustomerTbl where CusPhone='" & txtPhno.Text & "'", con)
            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable
            adapter.Fill(table)
            con.Close()

            txtcusname.Text = table.Rows(0)(0).ToString()
            txtEAddress.Text = table.Rows(0)(2).ToString()
            txtPhno.Text = table.Rows(0)(1).ToString()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub employeedetails()

        Try
            Dim cmd As New SqlCommand("Select empid,empFName,empPosition from EmployeeTbl", con)
            Dim adapter As New SqlDataAdapter
            adapter.SelectCommand = cmd
            Dim dt As New DataTable
            dt.Clear()
            adapter.Fill(dt)
            EmpdtlDGV.DataSource = dt

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub EmpdtlDGV_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles EmpdtlDGV.CellMouseDoubleClick
        Dim row As DataGridViewRow = EmpdtlDGV.Rows(e.RowIndex)
        txtStylistId.Text = row.Cells(0).Value.ToString()
        txtstylistname.Text = row.Cells(1).Value.ToString()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            con.Open()
            Dim qry As String
            qry = "select StylistName, AppointmentDate, AppointmentTime, Service from AppointmentTable where StylistId='" & txtStylistId.Text & "' and AppointmentDate='" & DTappoinment.Value & "'"
            Dim cmd As New SqlCommand(qry, con)
            Dim adapter As New SqlDataAdapter
            adapter.SelectCommand = cmd
            Dim dt As New DataTable
            dt.Clear()
            adapter.Fill(dt)
            EmpdtlDGV.DataSource = dt
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        employeedetails()
    End Sub
End Class