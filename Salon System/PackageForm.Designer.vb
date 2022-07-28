<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PackageForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PackageForm))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DGVpac = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btndel = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
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
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.DGVpac, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.ForestGreen
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1386, 82)
        Me.Panel1.TabIndex = 0
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Maroon
        Me.Button4.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button4.ForeColor = System.Drawing.Color.MintCream
        Me.Button4.Location = New System.Drawing.Point(1021, 37)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(103, 32)
        Me.Button4.TabIndex = 41
        Me.Button4.Text = "Exit"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.LawnGreen
        Me.Button5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button5.Location = New System.Drawing.Point(899, 37)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(103, 32)
        Me.Button5.TabIndex = 40
        Me.Button5.Text = "Add New"
        Me.Button5.UseVisualStyleBackColor = False
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
        Me.Label13.Size = New System.Drawing.Size(100, 22)
        Me.Label13.TabIndex = 39
        Me.Label13.Text = "Packages"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.DGVpac)
        Me.Panel2.Location = New System.Drawing.Point(12, 88)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(694, 485)
        Me.Panel2.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button1.Location = New System.Drawing.Point(599, 21)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 23)
        Me.Button1.TabIndex = 70
        Me.Button1.Text = "Refresh"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DGVpac
        '
        Me.DGVpac.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DGVpac.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVpac.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVpac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVpac.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGVpac.Location = New System.Drawing.Point(3, 50)
        Me.DGVpac.Name = "DGVpac"
        Me.DGVpac.RowTemplate.Height = 25
        Me.DGVpac.Size = New System.Drawing.Size(686, 373)
        Me.DGVpac.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel3.Controls.Add(Me.btndel)
        Me.Panel3.Controls.Add(Me.btnsave)
        Me.Panel3.Controls.Add(Me.txtdetails)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.txtsessions)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.txtduration)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.txtprice)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.txtname)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Location = New System.Drawing.Point(712, 138)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(458, 373)
        Me.Panel3.TabIndex = 2
        '
        'btndel
        '
        Me.btndel.BackColor = System.Drawing.Color.Red
        Me.btndel.Font = New System.Drawing.Font("News701 BT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btndel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btndel.Location = New System.Drawing.Point(278, 300)
        Me.btndel.Name = "btndel"
        Me.btndel.Size = New System.Drawing.Size(103, 32)
        Me.btndel.TabIndex = 69
        Me.btndel.Text = "Delete"
        Me.btndel.UseVisualStyleBackColor = False
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.SteelBlue
        Me.btnsave.Font = New System.Drawing.Font("News701 BT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnsave.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnsave.Location = New System.Drawing.Point(135, 300)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(103, 32)
        Me.btnsave.TabIndex = 42
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'txtdetails
        '
        Me.txtdetails.Location = New System.Drawing.Point(135, 183)
        Me.txtdetails.Name = "txtdetails"
        Me.txtdetails.Size = New System.Drawing.Size(283, 96)
        Me.txtdetails.TabIndex = 68
        Me.txtdetails.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(3, 183)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 19)
        Me.Label5.TabIndex = 67
        Me.Label5.Text = "Details"
        '
        'txtsessions
        '
        Me.txtsessions.Location = New System.Drawing.Point(136, 136)
        Me.txtsessions.Name = "txtsessions"
        Me.txtsessions.Size = New System.Drawing.Size(209, 23)
        Me.txtsessions.TabIndex = 66
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(3, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 19)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "Sessions"
        '
        'txtduration
        '
        Me.txtduration.Location = New System.Drawing.Point(135, 98)
        Me.txtduration.Name = "txtduration"
        Me.txtduration.Size = New System.Drawing.Size(209, 23)
        Me.txtduration.TabIndex = 64
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(3, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 19)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = "Duration"
        '
        'txtprice
        '
        Me.txtprice.Location = New System.Drawing.Point(135, 62)
        Me.txtprice.Name = "txtprice"
        Me.txtprice.Size = New System.Drawing.Size(209, 23)
        Me.txtprice.TabIndex = 62
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(3, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 19)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "Price"
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(135, 25)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(209, 23)
        Me.txtname.TabIndex = 60
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(3, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 19)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "Package Name"
        '
        'PackageForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1386, 523)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PackageForm"
        Me.Text = "PackageForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.DGVpac, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DGVpac As DataGridView
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtdetails As RichTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtsessions As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtduration As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtprice As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtname As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnsave As Button
    Friend WithEvents btndel As Button
    Friend WithEvents Button1 As Button
End Class
