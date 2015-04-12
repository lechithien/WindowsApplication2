<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sanpham
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
        Me.lblMasp = New System.Windows.Forms.Label()
        Me.lblTensp = New System.Windows.Forms.Label()
        Me.lblSl = New System.Windows.Forms.Label()
        Me.lblDongia = New System.Windows.Forms.Label()
        Me.txtMasp = New System.Windows.Forms.TextBox()
        Me.txtTensp = New System.Windows.Forms.TextBox()
        Me.txtSl = New System.Windows.Forms.TextBox()
        Me.txtDongia = New System.Windows.Forms.TextBox()
        Me.txtChitiet = New System.Windows.Forms.TextBox()
        Me.lblChitiet = New System.Windows.Forms.Label()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.dgvSanpham = New System.Windows.Forms.DataGridView()
        CType(Me.dgvSanpham, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMasp
        '
        Me.lblMasp.AutoSize = True
        Me.lblMasp.Location = New System.Drawing.Point(28, 28)
        Me.lblMasp.Name = "lblMasp"
        Me.lblMasp.Size = New System.Drawing.Size(77, 13)
        Me.lblMasp.TabIndex = 0
        Me.lblMasp.Text = "Mã sản phẩm :"
        '
        'lblTensp
        '
        Me.lblTensp.AutoSize = True
        Me.lblTensp.Location = New System.Drawing.Point(28, 83)
        Me.lblTensp.Name = "lblTensp"
        Me.lblTensp.Size = New System.Drawing.Size(83, 13)
        Me.lblTensp.TabIndex = 1
        Me.lblTensp.Text = "Tên Sản phẩm :"
        '
        'lblSl
        '
        Me.lblSl.AutoSize = True
        Me.lblSl.Location = New System.Drawing.Point(28, 152)
        Me.lblSl.Name = "lblSl"
        Me.lblSl.Size = New System.Drawing.Size(26, 13)
        Me.lblSl.TabIndex = 2
        Me.lblSl.Text = "SL :"
        '
        'lblDongia
        '
        Me.lblDongia.AutoSize = True
        Me.lblDongia.Location = New System.Drawing.Point(28, 229)
        Me.lblDongia.Name = "lblDongia"
        Me.lblDongia.Size = New System.Drawing.Size(50, 13)
        Me.lblDongia.TabIndex = 3
        Me.lblDongia.Text = "Đơn giá :"
        '
        'txtMasp
        '
        Me.txtMasp.Location = New System.Drawing.Point(181, 28)
        Me.txtMasp.Name = "txtMasp"
        Me.txtMasp.Size = New System.Drawing.Size(100, 20)
        Me.txtMasp.TabIndex = 4
        '
        'txtTensp
        '
        Me.txtTensp.Location = New System.Drawing.Point(181, 98)
        Me.txtTensp.Name = "txtTensp"
        Me.txtTensp.Size = New System.Drawing.Size(100, 20)
        Me.txtTensp.TabIndex = 5
        '
        'txtSl
        '
        Me.txtSl.Location = New System.Drawing.Point(181, 152)
        Me.txtSl.Name = "txtSl"
        Me.txtSl.Size = New System.Drawing.Size(100, 20)
        Me.txtSl.TabIndex = 6
        '
        'txtDongia
        '
        Me.txtDongia.Location = New System.Drawing.Point(181, 222)
        Me.txtDongia.Name = "txtDongia"
        Me.txtDongia.Size = New System.Drawing.Size(100, 20)
        Me.txtDongia.TabIndex = 7
        '
        'txtChitiet
        '
        Me.txtChitiet.Location = New System.Drawing.Point(181, 272)
        Me.txtChitiet.Name = "txtChitiet"
        Me.txtChitiet.Size = New System.Drawing.Size(100, 20)
        Me.txtChitiet.TabIndex = 8
        '
        'lblChitiet
        '
        Me.lblChitiet.AutoSize = True
        Me.lblChitiet.Location = New System.Drawing.Point(28, 275)
        Me.lblChitiet.Name = "lblChitiet"
        Me.lblChitiet.Size = New System.Drawing.Size(94, 13)
        Me.lblChitiet.TabIndex = 9
        Me.lblChitiet.Text = "Chi tiết sản phẩm :"
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(86, 316)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(84, 29)
        Me.btnThem.TabIndex = 10
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(228, 316)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(85, 29)
        Me.btnXoa.TabIndex = 11
        Me.btnXoa.Text = "Xoá"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Location = New System.Drawing.Point(392, 316)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(76, 29)
        Me.btnSua.TabIndex = 12
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'dgvSanpham
        '
        Me.dgvSanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSanpham.Location = New System.Drawing.Point(339, 47)
        Me.dgvSanpham.Name = "dgvSanpham"
        Me.dgvSanpham.Size = New System.Drawing.Size(292, 217)
        Me.dgvSanpham.TabIndex = 13
        '
        'sanpham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(656, 407)
        Me.Controls.Add(Me.dgvSanpham)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.lblChitiet)
        Me.Controls.Add(Me.txtChitiet)
        Me.Controls.Add(Me.txtDongia)
        Me.Controls.Add(Me.txtSl)
        Me.Controls.Add(Me.txtTensp)
        Me.Controls.Add(Me.txtMasp)
        Me.Controls.Add(Me.lblDongia)
        Me.Controls.Add(Me.lblSl)
        Me.Controls.Add(Me.lblTensp)
        Me.Controls.Add(Me.lblMasp)
        Me.Name = "sanpham"
        Me.Text = "sanpham"
        CType(Me.dgvSanpham, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMasp As System.Windows.Forms.Label
    Friend WithEvents lblTensp As System.Windows.Forms.Label
    Friend WithEvents lblSl As System.Windows.Forms.Label
    Friend WithEvents lblDongia As System.Windows.Forms.Label
    Friend WithEvents txtMasp As System.Windows.Forms.TextBox
    Friend WithEvents txtTensp As System.Windows.Forms.TextBox
    Friend WithEvents txtSl As System.Windows.Forms.TextBox
    Friend WithEvents txtDongia As System.Windows.Forms.TextBox
    Friend WithEvents txtChitiet As System.Windows.Forms.TextBox
    Friend WithEvents lblChitiet As System.Windows.Forms.Label
    Friend WithEvents btnThem As System.Windows.Forms.Button
    Friend WithEvents btnXoa As System.Windows.Forms.Button
    Friend WithEvents btnSua As System.Windows.Forms.Button
    Friend WithEvents dgvSanpham As System.Windows.Forms.DataGridView
End Class
