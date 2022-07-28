<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PackageAddForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PackageAddForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnselect = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtdetails = New System.Windows.Forms.RichTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtsessions = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtduration = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtprice = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DGVaddpac = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Name1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DGVselectedpac = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtper = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.lblprice = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.lbldiscount = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.DGVaddpac, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVselectedpac, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Menu
        Me.Panel1.Controls.Add(Me.btnselect)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.txtdetails)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtsessions)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtduration)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtprice)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtname)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1096, 230)
        Me.Panel1.TabIndex = 0
        '
        'btnselect
        '
        Me.btnselect.Location = New System.Drawing.Point(744, 75)
        Me.btnselect.Name = "btnselect"
        Me.btnselect.Size = New System.Drawing.Size(111, 23)
        Me.btnselect.TabIndex = 58
        Me.btnselect.Text = "Select Item"
        Me.btnselect.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Lime
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 3
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chartreuse
        Me.Button1.Font = New System.Drawing.Font("Algerian", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(846, 164)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 28)
        Me.Button1.TabIndex = 57
        Me.Button1.Text = "ADD"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtdetails
        '
        Me.txtdetails.Location = New System.Drawing.Point(455, 75)
        Me.txtdetails.Name = "txtdetails"
        Me.txtdetails.Size = New System.Drawing.Size(283, 96)
        Me.txtdetails.TabIndex = 56
        Me.txtdetails.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(390, 75)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 19)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = "Details"
        '
        'txtsessions
        '
        Me.txtsessions.Location = New System.Drawing.Point(145, 75)
        Me.txtsessions.Name = "txtsessions"
        Me.txtsessions.Size = New System.Drawing.Size(209, 23)
        Me.txtsessions.TabIndex = 54
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(13, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 19)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Sessions"
        '
        'txtduration
        '
        Me.txtduration.Location = New System.Drawing.Point(765, 15)
        Me.txtduration.Name = "txtduration"
        Me.txtduration.Size = New System.Drawing.Size(209, 23)
        Me.txtduration.TabIndex = 52
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(686, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 19)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Duration"
        '
        'txtprice
        '
        Me.txtprice.Location = New System.Drawing.Point(455, 15)
        Me.txtprice.Name = "txtprice"
        Me.txtprice.Size = New System.Drawing.Size(209, 23)
        Me.txtprice.TabIndex = 50
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(390, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 19)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Price"
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(145, 15)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(209, 23)
        Me.txtname.TabIndex = 48
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(13, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 19)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "Package Name"
        '
        'DGVaddpac
        '
        Me.DGVaddpac.AllowUserToAddRows = False
        Me.DGVaddpac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVaddpac.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Name1, Me.Type, Me.Price})
        Me.DGVaddpac.Location = New System.Drawing.Point(3, 45)
        Me.DGVaddpac.Name = "DGVaddpac"
        Me.DGVaddpac.RowTemplate.Height = 25
        Me.DGVaddpac.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVaddpac.Size = New System.Drawing.Size(446, 244)
        Me.DGVaddpac.TabIndex = 1
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        '
        'Name1
        '
        Me.Name1.HeaderText = "Name"
        Me.Name1.Name = "Name1"
        '
        'Type
        '
        Me.Type.HeaderText = "Type"
        Me.Type.Name = "Type"
        '
        'Price
        '
        Me.Price.HeaderText = "Price"
        Me.Price.Name = "Price"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Menu
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.txtSearch)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.DGVaddpac)
        Me.Panel2.Location = New System.Drawing.Point(12, 248)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(553, 292)
        Me.Panel2.TabIndex = 1
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(8, 16)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(23, 23)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 60
        Me.PictureBox2.TabStop = False
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.SystemColors.Info
        Me.txtSearch.Location = New System.Drawing.Point(32, 16)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PlaceholderText = "Search Here"
        Me.txtSearch.Size = New System.Drawing.Size(240, 23)
        Me.txtSearch.TabIndex = 61
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Lime
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 3
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chartreuse
        Me.Button2.Font = New System.Drawing.Font("Algerian", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button2.Location = New System.Drawing.Point(459, 255)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(91, 28)
        Me.Button2.TabIndex = 59
        Me.Button2.Text = "ADD"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'DGVselectedpac
        '
        Me.DGVselectedpac.AllowUserToAddRows = False
        Me.DGVselectedpac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVselectedpac.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.DGVselectedpac.Location = New System.Drawing.Point(12, 13)
        Me.DGVselectedpac.Name = "DGVselectedpac"
        Me.DGVselectedpac.RowTemplate.Height = 25
        Me.DGVselectedpac.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVselectedpac.Size = New System.Drawing.Size(345, 197)
        Me.DGVselectedpac.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Name"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Price"
        Me.Column3.Name = "Column3"
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbltotal.ForeColor = System.Drawing.Color.Purple
        Me.lbltotal.Location = New System.Drawing.Point(162, 226)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(47, 26)
        Me.lbltotal.TabIndex = 1
        Me.lbltotal.Text = "0.00"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(3, 226)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 26)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Total Price"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(3, 257)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(153, 21)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Discount Percentage"
        '
        'txtper
        '
        Me.txtper.Location = New System.Drawing.Point(162, 257)
        Me.txtper.Name = "txtper"
        Me.txtper.Size = New System.Drawing.Size(38, 23)
        Me.txtper.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(280, 231)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(151, 21)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Discounted Amount"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Menu
        Me.Panel3.Controls.Add(Me.Button5)
        Me.Panel3.Controls.Add(Me.Button4)
        Me.Panel3.Controls.Add(Me.lblprice)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.Button3)
        Me.Panel3.Controls.Add(Me.lbldiscount)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.txtper)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.lbltotal)
        Me.Panel3.Controls.Add(Me.DGVselectedpac)
        Me.Panel3.Location = New System.Drawing.Point(571, 251)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(537, 289)
        Me.Panel3.TabIndex = 2
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Red
        Me.Button5.Location = New System.Drawing.Point(363, 158)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(93, 23)
        Me.Button5.TabIndex = 11
        Me.Button5.Text = "Remove"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(391, 187)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(93, 23)
        Me.Button4.TabIndex = 10
        Me.Button4.Text = "Set Price"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'lblprice
        '
        Me.lblprice.AutoSize = True
        Me.lblprice.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblprice.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblprice.Location = New System.Drawing.Point(437, 259)
        Me.lblprice.Name = "lblprice"
        Me.lblprice.Size = New System.Drawing.Size(47, 26)
        Me.lblprice.TabIndex = 9
        Me.lblprice.Text = "0.00"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(280, 259)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(141, 26)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Discount Price"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(206, 257)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(38, 23)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Go"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'lbldiscount
        '
        Me.lbldiscount.AutoSize = True
        Me.lbldiscount.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbldiscount.ForeColor = System.Drawing.Color.Purple
        Me.lbldiscount.Location = New System.Drawing.Point(437, 231)
        Me.lbldiscount.Name = "lbldiscount"
        Me.lbldiscount.Size = New System.Drawing.Size(38, 21)
        Me.lbldiscount.TabIndex = 6
        Me.lbldiscount.Text = "0.00"
        '
        'PackageAddForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(1120, 543)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "PackageAddForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add New Package"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DGVaddpac, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVselectedpac, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtprice As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtname As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtdetails As RichTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtsessions As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtduration As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents DGVaddpac As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnselect As Button
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Name1 As DataGridViewTextBoxColumn
    Friend WithEvents Type As DataGridViewTextBoxColumn
    Friend WithEvents Price As DataGridViewTextBoxColumn
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents DGVselectedpac As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents lbltotal As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtper As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lbldiscount As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents lblprice As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
End Class
