Public Class MenuService


    Private Sub Panel1_Click(sender As Object, e As EventArgs) Handles Panel1.Click

        Dim face = New ServiceForm
        face.Show()
    End Sub
    Private Sub Panel1_MouseHover(sender As Object, e As EventArgs) Handles Panel1.MouseHover
        Panel1.BackColor = Color.Gold
    End Sub

    Private Sub Panel1_MouseLeave(sender As Object, e As EventArgs) Handles Panel1.MouseLeave
        Panel1.BackColor = Color.Bisque
    End Sub

    Private Sub Panel3_Click(sender As Object, e As EventArgs) Handles Panel3.Click
        Dim hair = New HairForm
        hair.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub

    Private Sub Panel4_Click(sender As Object, e As EventArgs) Handles Panel4.Click
        Dim mehandi = New MehendhiForm
        mehandi.Show()
    End Sub

    Private Sub Panel5_Click(sender As Object, e As EventArgs) Handles Panel5.Click
        Dim bridal = New BridalForm
        bridal.Show()
    End Sub

    Private Sub Panel6_Click(sender As Object, e As EventArgs) Handles Panel6.Click
        Dim other = New Otherservice
        other.Show()
    End Sub


End Class