<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuanly
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TàiKhoảnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ĐĂNGNHẬPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.THOÁTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuảnLýToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SảnPhẩmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TồnKhoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SảnPhẩmMớiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThôngTinToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NhânViênToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.miniKh = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TàiKhoảnToolStripMenuItem, Me.QuảnLýToolStripMenuItem, Me.ThôngTinToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(614, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TàiKhoảnToolStripMenuItem
        '
        Me.TàiKhoảnToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ĐĂNGNHẬPToolStripMenuItem, Me.THOÁTToolStripMenuItem})
        Me.TàiKhoảnToolStripMenuItem.Name = "TàiKhoảnToolStripMenuItem"
        Me.TàiKhoảnToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.TàiKhoảnToolStripMenuItem.Text = "Tài khoản"
        '
        'ĐĂNGNHẬPToolStripMenuItem
        '
        Me.ĐĂNGNHẬPToolStripMenuItem.Name = "ĐĂNGNHẬPToolStripMenuItem"
        Me.ĐĂNGNHẬPToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.ĐĂNGNHẬPToolStripMenuItem.Text = "ĐĂNG NHẬP"
        '
        'THOÁTToolStripMenuItem
        '
        Me.THOÁTToolStripMenuItem.Name = "THOÁTToolStripMenuItem"
        Me.THOÁTToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.THOÁTToolStripMenuItem.Text = "THOÁT"
        '
        'QuảnLýToolStripMenuItem
        '
        Me.QuảnLýToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SảnPhẩmToolStripMenuItem, Me.TồnKhoToolStripMenuItem, Me.SảnPhẩmMớiToolStripMenuItem})
        Me.QuảnLýToolStripMenuItem.Name = "QuảnLýToolStripMenuItem"
        Me.QuảnLýToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.QuảnLýToolStripMenuItem.Text = "Quản lý"
        '
        'SảnPhẩmToolStripMenuItem
        '
        Me.SảnPhẩmToolStripMenuItem.Name = "SảnPhẩmToolStripMenuItem"
        Me.SảnPhẩmToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.SảnPhẩmToolStripMenuItem.Text = "Loại sản phẩm"
        '
        'TồnKhoToolStripMenuItem
        '
        Me.TồnKhoToolStripMenuItem.Name = "TồnKhoToolStripMenuItem"
        Me.TồnKhoToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.TồnKhoToolStripMenuItem.Text = "Tồn kho"
        '
        'SảnPhẩmMớiToolStripMenuItem
        '
        Me.SảnPhẩmMớiToolStripMenuItem.Name = "SảnPhẩmMớiToolStripMenuItem"
        Me.SảnPhẩmMớiToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.SảnPhẩmMớiToolStripMenuItem.Text = "Sản phẩm mới"
        '
        'ThôngTinToolStripMenuItem
        '
        Me.ThôngTinToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NhânViênToolStripMenuItem, Me.miniKh})
        Me.ThôngTinToolStripMenuItem.Name = "ThôngTinToolStripMenuItem"
        Me.ThôngTinToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.ThôngTinToolStripMenuItem.Text = "Thông tin"
        '
        'NhânViênToolStripMenuItem
        '
        Me.NhânViênToolStripMenuItem.Name = "NhânViênToolStripMenuItem"
        Me.NhânViênToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NhânViênToolStripMenuItem.Text = "Nhân viên"
        '
        'miniKh
        '
        Me.miniKh.Name = "miniKh"
        Me.miniKh.Size = New System.Drawing.Size(152, 22)
        Me.miniKh.Text = "Khách hàng"
        '
        'frmQuanly
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(614, 309)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmQuanly"
        Me.Text = "MAIN"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents TàiKhoảnToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ĐĂNGNHẬPToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents THOÁTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuảnLýToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SảnPhẩmToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TồnKhoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SảnPhẩmMớiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ThôngTinToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NhânViênToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miniKh As System.Windows.Forms.ToolStripMenuItem
End Class
