Imports System.Data.SqlClient
Imports System.Drawing.Printing

Public Class BillForm
    Dim con As New SqlConnection("Data Source=DESKTOP-TQTHBHK;Initial Catalog=SalonSystem;Integrated Security=True")

    Private Sub servicedata()
        Dim cmd As New SqlCommand("Select ServiceId,ServiceType,ServiceName,ServicePrice from ServiceTable", con)
        Dim adapter As New SqlDataAdapter
        adapter.SelectCommand = cmd
        Dim dt As DataTable
        dt = New DataTable
        dt.Clear()
        adapter.Fill(dt)
        Dgvservice.DataSource = dt

    End Sub

    Private Sub packagedata()
        Dim cmd As New SqlCommand("Select Id,PacName,PacPrice from PackageTable", con)
        Dim adapter As New SqlDataAdapter
        adapter.SelectCommand = cmd
        Dim dt As DataTable
        dt = New DataTable
        dt.Clear()
        adapter.Fill(dt)
        dgvpackage.DataSource = dt


    End Sub

    Private Sub BillForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        servicedata()
        packagedata()


    End Sub


    Dim i, total, tot
    Dim actotal As Double
    Dim shwtot As String
    Private Sub calculate()
        tot = tot + total

        shwtot = "Rs." + Convert.ToString(tot)
        subtotal.Text = shwtot
        lbltotal.Text = shwtot
        lblbal.Text = Convert.ToString(tot) 'for balance calculating 

    End Sub


    Private Sub Dgvservice_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles Dgvservice.CellMouseDoubleClick

        Try
            Dim rnum As Integer = dgvbill.Rows.Add()
            i = i + 1
            Dim row As DataGridViewRow = Dgvservice.Rows(e.RowIndex)
            dgvbill.Rows.Item(rnum).Cells("Column1").Value = i
            dgvbill.Rows.Item(rnum).Cells("Column2").Value = row.Cells(2).Value.ToString()
            dgvbill.Rows.Item(rnum).Cells("Column3").Value = row.Cells(3).Value.ToString()

            total = Convert.ToDouble(dgvbill.Rows.Item(rnum).Cells("Column3").Value)

            calculate()
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub dgvpackage_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvpackage.CellMouseDoubleClick
        Try
            Dim rnum As Integer = dgvbill.Rows.Add()
            i = i + 1
            Dim row As DataGridViewRow = dgvpackage.Rows(e.RowIndex)
            dgvbill.Rows.Item(rnum).Cells("Column1").Value = i
            dgvbill.Rows.Item(rnum).Cells("Column2").Value = row.Cells(1).Value.ToString()
            dgvbill.Rows.Item(rnum).Cells("Column3").Value = row.Cells(2).Value.ToString()
            total = Convert.ToDouble(dgvbill.Rows.Item(rnum).Cells("Column3").Value)

            calculate()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub


    Dim disper

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtdiscount.Text = "" Then
            lbltotal.Text = shwtot
            lbldiscountPer.Text = "0%"

        Else
            'Discount calculation
            lbldiscountPer.Text = txtdiscount.Text + "%"
            Dim persentage = Convert.ToDouble(txtdiscount.Text)
            Dim disprice = total * (persentage / 100)
            lbldisamount.Text = "Rs." + Convert.ToString(disprice)

            actotal = tot - disprice
            lbltotal.Text = "Rs." + Convert.ToString(actotal)

            lblbal.Text = Convert.ToString(actotal) 'for balance calculating 

        End If
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'balance btn
        Dim cash = Convert.ToDouble(txtcash.Text)
        Dim amount = Convert.ToDouble(lblbal.Text)
        Dim balance = cash - amount
        lblbalance.Text = Convert.ToString(balance)

    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Remove btn
        Try
            Dim a
            a = Convert.ToInt32(dgvbill.SelectedCells(2).Value.ToString())
            tot = tot - a

            shwtot = "Rs " + Convert.ToString(tot)
            subtotal.Text = shwtot

            Dim index As Integer
            index = dgvbill.CurrentCell.RowIndex
            dgvbill.Rows.RemoveAt(index)

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If MessageBox.Show("Are You want to close this form?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Me.Dispose()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'Clear btn
        subtotal.Text = "Rs. 0"
        lbldiscountPer.Text = "0%"
        lbldisamount.Text = "Rs. 0"
        lbltotal.Text = "Rs.0"
        lblbalance.Text = "Rs.0"

        dgvbill.Rows.Clear()
        tot = 0
        txtcash.Text = ""
        txtdiscount.Text = ""
    End Sub

    'Bill printing.....................................................................................

    Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog

    Private Sub prntbtn_Click(sender As Object, e As EventArgs) Handles prntbtn.Click
        PPD.Document = PD
        PPD.ShowDialog()
    End Sub


    Private Sub PD_BeginPrint(sender As Object, e As Printing.PrintEventArgs) Handles PD.BeginPrint
        Dim pagesetup As New PageSettings
        pagesetup.PaperSize = New PaperSize("Custom", 250, 500)
        PD.DefaultPageSettings = pagesetup
    End Sub

    Private Sub PD_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PD.PrintPage
        Dim f8 As New Font("Calibri", 8, FontStyle.Regular)
        Dim f10 As New Font("Calibri", 10, FontStyle.Regular)
        Dim f10b As New Font("Calibri", 10, FontStyle.Bold)
        Dim f14 As New Font("French Script MT", 16, FontStyle.Bold)

        Dim leftmargin As Integer = PD.DefaultPageSettings.Margins.Left
        Dim centermargin As Integer = PD.DefaultPageSettings.PaperSize.Width / 2
        Dim rightmargin As Integer = PD.DefaultPageSettings.PaperSize.Width

        'font alignment
        Dim right As New StringFormat
        Dim center As New StringFormat
        right.Alignment = StringAlignment.Far
        center.Alignment = StringAlignment.Center

        Dim line As String
        line = "================================================"
        e.Graphics.DrawString("Lavish salon", f14, Brushes.Black, centermargin, 5, center)
        e.Graphics.DrawString("24,Green city,Galle", f10, Brushes.Black, centermargin, 25, center)
        e.Graphics.DrawString("Tel 0775656566", f8, Brushes.Black, centermargin, 40, center)
        e.Graphics.DrawString("Date : ", f8, Brushes.Black, 0, 60)
        e.Graphics.DrawString(Date.Now, f8, Brushes.Black, 25, 60)
        e.Graphics.DrawString(line, f8, Brushes.Black, 0, 80)

        Dim height As Integer 'DGV Position
        Dim i As Long
        dgvbill.AllowUserToAddRows = False
        For row As Integer = 0 To dgvbill.RowCount - 1
            height += 15
            e.Graphics.DrawString(dgvbill.Rows(row).Cells(0).Value.ToString, f10, Brushes.Black, 0, 80 + height)
            e.Graphics.DrawString(dgvbill.Rows(row).Cells(1).Value.ToString, f10, Brushes.Black, 25, 80 + height)
            e.Graphics.DrawString(dgvbill.Rows(row).Cells(2).Value.ToString, f10, Brushes.Black, 200, 80 + height)
        Next
        Dim height2 As Integer
        height2 = 100 + height
        e.Graphics.DrawString(line, f8, Brushes.Black, 0, height2)
        e.Graphics.DrawString("Total : ", f10, Brushes.Black, 0, 35 + height2)
        e.Graphics.DrawString(subtotal.Text, f10, Brushes.Black, 150, 35 + height2)
        e.Graphics.DrawString("Discount Amount :", f10, Brushes.Black, 0, 55 + height2)
        e.Graphics.DrawString(lbldisamount.Text, f10, Brushes.Black, 150, 55 + height2)
        e.Graphics.DrawString("Actual Amount :", f10b, Brushes.Black, 0, 75 + height2)
        e.Graphics.DrawString(lbltotal.Text, f10b, Brushes.Black, 150, 75 + height2)
        e.Graphics.DrawString("Cash : ", f10, Brushes.Black, 0, 95 + height2)
        e.Graphics.DrawString(txtcash.Text, f10, Brushes.Black, 150, 95 + height2)
        e.Graphics.DrawString("Balance : ", f10b, Brushes.Black, 0, 115 + height2)
        e.Graphics.DrawString(lblbalance.Text, f10, Brushes.Black, 150, 115 + height2)
        e.Graphics.DrawString("THANK YOU COME AGAIN ", f8, Brushes.Black, centermargin, 145 + height2, center)

    End Sub


End Class