Public Class LoginForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtname.Text = "" Or txtpass.Text = "" Then
            MessageBox.Show("Enter UserName and Password")
        ElseIf txtname.Text = "Admin" And txtpass.Text = "Admin@123" Then
            Dim home = New Home_Page
            home.Show()
            Me.Hide()

        Else
            MessageBox.Show("Wrong UserName or Password")

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtname.Text = ""
        txtpass.Text = ""
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txtpass.UseSystemPasswordChar = False
        Else
            txtpass.UseSystemPasswordChar = True
        End If
    End Sub





End Class