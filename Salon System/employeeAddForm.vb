Imports System.Data.SqlClient
Public Class employeeAddForm
    Dim Con As New SqlConnection("Data Source=DESKTOP-TQTHBHK;Initial Catalog=SalonSystem;Integrated Security=True")
    Dim key
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



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtFname.Text = "" Or txtLname.Text = "" Or txtStreet.Text = "" Or txtCity.Text = "" Or txtNIC.Text = "" Or txtPhone.Text = "" Or txtEmail.Text = "" Or txtPosition.Text = "" Then
            MessageBox.Show("You can't Add Details. Some Important Details Missing!")
        Else
            Try
                Con.Open()
                Dim Query As String
                Query = "insert into EmployeeTbl values('" & txtFname.Text & "','" & txtLname.Text & "','" & txtStreet.Text & "','" & txtCity.Text & "','" & DpDOB.Value & "','" & txtNIC.Text & "','" & txtPhone.Text & "','" & txtEmail.Text & "','" & txtPosition.Text & "','" & txtQul.Text & "','" & cbStype.SelectedItem.ToString() & "','" & txtSalary.Text & "','" & DpJdate.Value & "')"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(Query, Con)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Employee Details added Successfully")
                Con.Close()

                Clear()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub


End Class