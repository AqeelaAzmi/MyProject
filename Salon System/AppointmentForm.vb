Imports System.Data.SqlClient
Public Class AppointmentForm
    Dim con As New SqlConnection("Data Source=DESKTOP-TQTHBHK;Initial Catalog=SalonSystem;Integrated Security=True")
    Private Sub AppointmentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowData()
    End Sub
    Private Sub ShowData()
        Dim cmd As New SqlCommand("Select * from AppointmentTable order by AppointmentId desc", con)
        Dim adapter As New SqlDataAdapter
        adapter.SelectCommand = cmd
        Dim dt As New DataSet
        adapter.Fill(dt)

        For Each row In dt.Tables(0).Rows
            DGVAppointment.Rows.Add(row("AppointmentId").ToString(), row("CustomerName").ToString(), row("EmailAddress").ToString(), row("PhoneNumber"), row("AppointmentDate").ToString(), row("AppointmentTime").ToString(), row("StylistId").ToString(), row("StylistName"), row("Service").ToString(), row("price").ToString(), row("Details"))
        Next
    End Sub

    Private Sub filterData()
        'search
        Try
            DGVAppointment.Rows.Clear()
            Dim cmd As New SqlCommand("Select * from AppointmentTable where CustomerName like '%" & txtSearch.Text & "%'", con)
            Dim adapter As New SqlDataAdapter
            adapter.SelectCommand = cmd
            Dim dt As New DataSet
            adapter.Fill(dt)

            For Each row In dt.Tables(0).Rows
                DGVAppointment.Rows.Add(row("AppointmentId").ToString(), row("CustomerName").ToString(), row("EmailAddress").ToString(), row("PhoneNumber"), row("AppointmentDate").ToString(), row("AppointmentTime").ToString(), row("StylistId").ToString(), row("StylistName"), row("Service").ToString(), row("price").ToString(), row("Details"))
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim addappintment As New AddAppointmentForm
        addappintment.btnsave.Visible = False
        addappintment.ShowDialog()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If MessageBox.Show("Are You want to close this form?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Me.Dispose()
        End If
    End Sub

    Private Sub DGVAppointment_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVAppointment.CellContentClick
        Dim colname As String = DGVAppointment.Columns(e.ColumnIndex).Name
        Dim row As DataGridViewRow = DGVAppointment.Rows(e.RowIndex)
        Dim appointment As New AddAppointmentForm
        Dim key = Convert.ToInt32(row.Cells(0).Value.ToString())

        If colname = "Editbtn" Then
            appointment.addbtn.Visible = False
            Try
                AddAppointmentForm.editdetails = row.Cells("Column1").Value
                appointment.ShowDialog()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        ElseIf colname = "deletebtn" Then
            Try
                If MessageBox.Show("Are You Really want to delete this?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then

                    con.Open()
                    Dim cmd As New SqlCommand("Delete from AppointmentTable where AppointmentId='" & key & "'", con)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Details Deleted Successfully!")
                    con.Close()
                    ShowData()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)

        End Try

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ShowData()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        filterData()
    End Sub
End Class