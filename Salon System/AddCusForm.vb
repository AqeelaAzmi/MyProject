Imports System.Data.SqlClient

Public Class AddCusForm
    Dim Con As New SqlConnection("Data Source=DESKTOP-TQTHBHK;Initial Catalog=SalonSystem;Integrated Security=True")

    Private Sub Clear()
        txtFname.Text = ""
        txtLname.Text = ""
        txtStreet.Text = ""
        txtCity.Text = ""
        txtNIC.Text = ""
        txtPhone.Text = ""
        txtEmail.Text = ""
        txtPAmount.Text = ""
        cbPmethod.SelectedIndex = -1
        DpDOB.Value = Format(Date.Now)
        dpRDate.Value = Format(Date.Now)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtFname.Text = "" Or txtLname.Text = "" Or txtStreet.Text = "" Or txtCity.Text = "" Or txtNIC.Text = "" Or txtPhone.Text = "" Or txtEmail.Text = "" Or txtPAmount.Text = "" Then
            MessageBox.Show("You can't Add Details. Some Important Details Missing!")

        Else
            Try
                Con.Open()
                Dim Query As String
                Query = "insert into CustomerTbl Values('" & txtFname.Text & "','" & txtLname.Text & "','" & txtStreet.Text & "','" & txtCity.Text & "','" & DpDOB.Value & "','" & txtNIC.Text & "','" & txtPhone.Text & "','" & txtEmail.Text & "','" & txtPAmount.Text & "','" & cbPmethod.SelectedItem.ToString() & "','" & dpRDate.Value & "')"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(Query, Con)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Customer Details Added Successfully")
                Con.Close()
                'ShowData()
                Clear()
            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try
        End If
    End Sub
End Class