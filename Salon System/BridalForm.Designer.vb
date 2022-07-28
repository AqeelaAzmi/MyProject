<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BridalForm
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DGVservice = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Txtlocation = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.cbType = New System.Windows.Forms.ComboBox()
        Me.txtcomment = New System.Windows.Forms.TextBox()
        Me.Txtprice = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DGVservice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.DGVservice)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.txtSearch)
        Me.Panel1.Controls.Add(Me.Txtlocation)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.btncancel)
        Me.Panel1.Controls.Add(Me.btnsave)
        Me.Panel1.Controls.Add(Me.cbType)
        Me.Panel1.Controls.Add(Me.txtcomment)
        Me.Panel1.Controls.Add(Me.Txtprice)
        Me.Panel1.Controls.Add(Me.txtName)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1127, 625)
        Me.Panel1.TabIndex = 1
        '
        'DGVservice
        '
        Me.DGVservice.AllowUserToAddRows = False
        Me.DGVservice.AllowUserToDeleteRows = False
        Me.DGVservice.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGVservice.BackgroundColor = System.Drawing.Color.White
        Me.DGVservice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVservice.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.DGVservice.GridColor = System.Drawing.Color.White
        Me.DGVservice.Location = New System.Drawing.Point(422, 104)
        Me.DGVservice.Name = "DGVservice"
        Me.DGVservice.ReadOnly = True
        Me.DGVservice.RowHeadersVisible = False
        Me.DGVservice.RowTemplate.Height = 120
        Me.DGVservice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVservice.Size = New System.Drawing.Size(705, 518)
        Me.DGVservice.TabIndex = 3
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 50
        '
        'Column2
        '
        Me.Column2.HeaderText = "Name"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Type"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Price"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Comment"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "location"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.HeaderText = "image"
        Me.Column7.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column7.Width = 150
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Silver
        Me.Button4.Location = New System.Drawing.Point(293, 184)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(80, 30)
        Me.Button4.TabIndex = 53
        Me.Button4.Text = "Browse"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.SystemColors.Info
        Me.txtSearch.Location = New System.Drawing.Point(422, 70)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PlaceholderText = "Search Here"
        Me.txtSearch.Size = New System.Drawing.Size(265, 23)
        Me.txtSearch.TabIndex = 51
        '
        'Txtlocation
        '
        Me.Txtlocation.Location = New System.Drawing.Point(164, 407)
        Me.Txtlocation.Name = "Txtlocation"
        Me.Txtlocation.Size = New System.Drawing.Size(224, 23)
        Me.Txtlocation.TabIndex = 42
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(16, 407)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 19)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = " Image Location"
        '
        'btncancel
        '
        Me.btncancel.BackColor = System.Drawing.Color.Silver
        Me.btncancel.Location = New System.Drawing.Point(293, 454)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(80, 30)
        Me.btncancel.TabIndex = 40
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.Blue
        Me.btnsave.Location = New System.Drawing.Point(25, 454)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(80, 30)
        Me.btnsave.TabIndex = 39
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'cbType
        '
        Me.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbType.FormattingEnabled = True
        Me.cbType.Items.AddRange(New Object() {"Mehandhi Design", "Facial Design", "Hair Beauty", "Bridal dressing", "Others"})
        Me.cbType.Location = New System.Drawing.Point(164, 285)
        Me.cbType.Name = "cbType"
        Me.cbType.Size = New System.Drawing.Size(224, 23)
        Me.cbType.TabIndex = 37
        '
        'txtcomment
        '
        Me.txtcomment.Location = New System.Drawing.Point(164, 366)
        Me.txtcomment.Name = "txtcomment"
        Me.txtcomment.PlaceholderText = "Enter Comment"
        Me.txtcomment.Size = New System.Drawing.Size(224, 23)
        Me.txtcomment.TabIndex = 10
        '
        'Txtprice
        '
        Me.Txtprice.Location = New System.Drawing.Point(164, 326)
        Me.Txtprice.Name = "Txtprice"
        Me.Txtprice.PlaceholderText = "Enter Price"
        Me.Txtprice.Size = New System.Drawing.Size(224, 23)
        Me.Txtprice.TabIndex = 9
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(164, 248)
        Me.txtName.Name = "txtName"
        Me.txtName.PlaceholderText = "Enter Name"
        Me.txtName.Size = New System.Drawing.Size(224, 23)
        Me.txtName.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(25, 366)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 19)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Comment"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(25, 326)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 19)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Service Price"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(25, 285)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 19)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Service Type"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(25, 248)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 19)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Service Name"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Goldenrod
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1127, 53)
        Me.Panel2.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Crimson
        Me.Button2.Location = New System.Drawing.Point(1037, 13)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 34)
        Me.Button2.TabIndex = 39
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Sitka Text", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label13.Location = New System.Drawing.Point(97, 19)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(159, 28)
        Me.Label13.TabIndex = 37
        Me.Label13.Text = "Bridal Dressing"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LawnGreen
        Me.Button1.Location = New System.Drawing.Point(921, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 34)
        Me.Button1.TabIndex = 38
        Me.Button1.Text = "Add New"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(109, 81)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(161, 133)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Red
        Me.Button5.Location = New System.Drawing.Point(152, 454)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(80, 30)
        Me.Button5.TabIndex = 56
        Me.Button5.Text = "Delete"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'BridalForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1127, 625)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "BridalForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DGVservice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Txtlocation As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btncancel As Button
    Friend WithEvents btnsave As Button
    Friend WithEvents cbType As ComboBox
    Friend WithEvents txtcomment As TextBox
    Friend WithEvents Txtprice As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DGVservice As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewImageColumn
    Friend WithEvents Button5 As Button
End Class
