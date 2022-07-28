Public Class Home_Page
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Emp = New EmployeeForm
        Emp.MdiParent = Me
        Emp.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cus = New CustomerForm
        cus.MdiParent = Me
        cus.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If pnlservice.Height = 8 Then
            pnlservice.Height = 180
        Else
            pnlservice.Height = 8
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim facial = New ServiceForm
        facial.MdiParent = Me
        facial.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim hair = New HairForm
        hair.MdiParent = Me
        hair.Show()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim mehendhi = New MehendhiForm
        mehendhi.MdiParent = Me
        mehendhi.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim bridal = New BridalForm
        bridal.MdiParent = Me
        bridal.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim other = New Otherservice
        other.MdiParent = Me
        other.Show()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim pac = New PackageForm
        pac.MdiParent = Me
        pac.Show()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim appointment = New AppointmentForm
        appointment.MdiParent = Me
        appointment.Show()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim bill = New BillForm
        bill.MdiParent = Me
        bill.Show()
    End Sub
End Class