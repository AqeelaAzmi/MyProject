<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BillForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BillForm))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Dgvservice = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgvpackage = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblbal = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.lblbalance = New System.Windows.Forms.Label()
        Me.txtcash = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbldisamount = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.lbldiscountPer = New System.Windows.Forms.Label()
        Me.subtotal = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txtdiscount = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvbill = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.prntbtn = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.Dgvservice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvpackage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.dgvbill, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Location = New System.Drawing.Point(446, 83)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(485, 566)
        Me.Panel1.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(3, 5)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(478, 452)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Dgvservice)
        Me.TabPage1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(470, 424)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Services"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Dgvservice
        '
        Me.Dgvservice.AllowUserToAddRows = False
        Me.Dgvservice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Dgvservice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgvservice.Location = New System.Drawing.Point(6, 6)
        Me.Dgvservice.Name = "Dgvservice"
        Me.Dgvservice.RowTemplate.Height = 25
        Me.Dgvservice.Size = New System.Drawing.Size(458, 415)
        Me.Dgvservice.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgvpackage)
        Me.TabPage2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(470, 424)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Packages"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgvpackage
        '
        Me.dgvpackage.AllowUserToAddRows = False
        Me.dgvpackage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvpackage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvpackage.Location = New System.Drawing.Point(3, 6)
        Me.dgvpackage.Name = "dgvpackage"
        Me.dgvpackage.RowTemplate.Height = 25
        Me.dgvpackage.Size = New System.Drawing.Size(461, 412)
        Me.dgvpackage.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SkyBlue
        Me.Panel2.Controls.Add(Me.Button4)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1386, 82)
        Me.Panel2.TabIndex = 2
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Brown
        Me.Button4.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Location = New System.Drawing.Point(987, 47)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(103, 32)
        Me.Button4.TabIndex = 41
        Me.Button4.Text = "Exit"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(32, 39)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(37, 34)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 40
        Me.PictureBox1.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label13.Location = New System.Drawing.Point(72, 47)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(67, 22)
        Me.Label13.TabIndex = 39
        Me.Label13.Text = "Billing"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel3.Controls.Add(Me.Button2)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.dgvbill)
        Me.Panel3.Location = New System.Drawing.Point(0, 83)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(447, 566)
        Me.Panel3.TabIndex = 3
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Red
        Me.Button2.Location = New System.Drawing.Point(358, 255)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Remove"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel4.Controls.Add(Me.lblbal)
        Me.Panel4.Controls.Add(Me.Button3)
        Me.Panel4.Controls.Add(Me.lblbalance)
        Me.Panel4.Controls.Add(Me.txtcash)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.lbldisamount)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.Button1)
        Me.Panel4.Controls.Add(Me.lbltotal)
        Me.Panel4.Controls.Add(Me.lbldiscountPer)
        Me.Panel4.Controls.Add(Me.subtotal)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Controls.Add(Me.txtdiscount)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Location = New System.Drawing.Point(0, 287)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(447, 261)
        Me.Panel4.TabIndex = 1
        '
        'lblbal
        '
        Me.lblbal.AutoSize = True
        Me.lblbal.Location = New System.Drawing.Point(43, 147)
        Me.lblbal.Name = "lblbal"
        Me.lblbal.Size = New System.Drawing.Size(41, 15)
        Me.lblbal.TabIndex = 16
        Me.lblbal.Text = "Label8"
        Me.lblbal.Visible = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Button3.Location = New System.Drawing.Point(365, 191)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "Balance"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'lblbalance
        '
        Me.lblbalance.AutoSize = True
        Me.lblbalance.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblbalance.ForeColor = System.Drawing.Color.Peru
        Me.lblbalance.Location = New System.Drawing.Point(362, 227)
        Me.lblbalance.Name = "lblbalance"
        Me.lblbalance.Size = New System.Drawing.Size(40, 21)
        Me.lblbalance.TabIndex = 14
        Me.lblbalance.Text = "Rs.0"
        '
        'txtcash
        '
        Me.txtcash.Location = New System.Drawing.Point(294, 167)
        Me.txtcash.Name = "txtcash"
        Me.txtcash.Size = New System.Drawing.Size(146, 23)
        Me.txtcash.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Sitka Small", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.DarkKhaki
        Me.Label7.Location = New System.Drawing.Point(164, 229)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 19)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Balance"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Sitka Small", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.DarkKhaki
        Me.Label5.Location = New System.Drawing.Point(167, 167)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 19)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Cash"
        '
        'lbldisamount
        '
        Me.lbldisamount.AutoSize = True
        Me.lbldisamount.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbldisamount.ForeColor = System.Drawing.Color.Peru
        Me.lbldisamount.Location = New System.Drawing.Point(362, 95)
        Me.lbldisamount.Name = "lbldisamount"
        Me.lbldisamount.Size = New System.Drawing.Size(40, 21)
        Me.lbldisamount.TabIndex = 10
        Me.lbldisamount.Text = "Rs.0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Sitka Small", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.DarkKhaki
        Me.Label6.Location = New System.Drawing.Point(164, 98)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 19)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Discount Amount"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Khaki
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(12, 83)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Set Disccount"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbltotal.ForeColor = System.Drawing.Color.Maroon
        Me.lbltotal.Location = New System.Drawing.Point(362, 129)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(49, 26)
        Me.lbltotal.TabIndex = 8
        Me.lbltotal.Text = "Rs.0"
        '
        'lbldiscountPer
        '
        Me.lbldiscountPer.AutoSize = True
        Me.lbldiscountPer.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbldiscountPer.ForeColor = System.Drawing.Color.Peru
        Me.lbldiscountPer.Location = New System.Drawing.Point(362, 60)
        Me.lbldiscountPer.Name = "lbldiscountPer"
        Me.lbldiscountPer.Size = New System.Drawing.Size(31, 21)
        Me.lbldiscountPer.TabIndex = 7
        Me.lbldiscountPer.Text = "0%"
        '
        'subtotal
        '
        Me.subtotal.AutoSize = True
        Me.subtotal.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.subtotal.ForeColor = System.Drawing.Color.Peru
        Me.subtotal.Location = New System.Drawing.Point(362, 19)
        Me.subtotal.Name = "subtotal"
        Me.subtotal.Size = New System.Drawing.Size(40, 21)
        Me.subtotal.TabIndex = 6
        Me.subtotal.Text = "Rs.0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Sitka Small", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.DarkKhaki
        Me.Label4.Location = New System.Drawing.Point(167, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 19)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Total"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Sitka Small", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.DarkKhaki
        Me.Label3.Location = New System.Drawing.Point(164, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Discount Persentage"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Sitka Small", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.DarkKhaki
        Me.Label2.Location = New System.Drawing.Point(164, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Sub Total"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Black
        Me.Panel5.Location = New System.Drawing.Point(148, 1)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(2, 260)
        Me.Panel5.TabIndex = 2
        '
        'txtdiscount
        '
        Me.txtdiscount.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtdiscount.Location = New System.Drawing.Point(12, 44)
        Me.txtdiscount.Name = "txtdiscount"
        Me.txtdiscount.Size = New System.Drawing.Size(100, 23)
        Me.txtdiscount.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Sitka Small", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Goldenrod
        Me.Label1.Location = New System.Drawing.Point(12, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Discount Persentage"
        '
        'dgvbill
        '
        Me.dgvbill.AllowUserToAddRows = False
        Me.dgvbill.AllowUserToDeleteRows = False
        Me.dgvbill.AllowUserToResizeColumns = False
        Me.dgvbill.AllowUserToResizeRows = False
        Me.dgvbill.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvbill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvbill.BackgroundColor = System.Drawing.Color.White
        Me.dgvbill.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvbill.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvbill.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvbill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvbill.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.dgvbill.GridColor = System.Drawing.Color.White
        Me.dgvbill.Location = New System.Drawing.Point(4, 4)
        Me.dgvbill.Name = "dgvbill"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvbill.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvbill.RowTemplate.Height = 25
        Me.dgvbill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvbill.Size = New System.Drawing.Size(347, 278)
        Me.dgvbill.TabIndex = 0
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
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel6.Controls.Add(Me.Button5)
        Me.Panel6.Controls.Add(Me.prntbtn)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(0, 621)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1386, 93)
        Me.Panel6.TabIndex = 4
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.SteelBlue
        Me.Button5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button5.Location = New System.Drawing.Point(162, 8)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 32)
        Me.Button5.TabIndex = 1
        Me.Button5.Text = "Clear"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'prntbtn
        '
        Me.prntbtn.BackColor = System.Drawing.Color.SteelBlue
        Me.prntbtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.prntbtn.Location = New System.Drawing.Point(336, 8)
        Me.prntbtn.Name = "prntbtn"
        Me.prntbtn.Size = New System.Drawing.Size(75, 32)
        Me.prntbtn.TabIndex = 0
        Me.prntbtn.Text = "Print Bill"
        Me.prntbtn.UseVisualStyleBackColor = False
        '
        'BillForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1386, 714)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "BillForm"
        Me.Text = "BillForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.Dgvservice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgvpackage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.dgvbill, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Dgvservice As DataGridView
    Friend WithEvents dgvpackage As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents dgvbill As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lbltotal As Label
    Friend WithEvents lbldiscountPer As Label
    Friend WithEvents subtotal As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents txtdiscount As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents lbldisamount As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents prntbtn As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents lblbalance As Label
    Friend WithEvents txtcash As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents lblbal As Label
End Class
