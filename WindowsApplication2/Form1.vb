Public Class Form1

    Private Sub btnNhap_Click(sender As Object, e As EventArgs) Handles btnNhap.Click
        'khai báo biến userId và password nắm giữ mã đăng nhập và mật khẩu nhập vào
        Dim userId As String = txtUser.Text
        Dim password As String = txtPass.Text

        'Đăng nhập hợp lệ khi mã đăng nhập là 'user' hoặc 'admin'
        If (userId = "admin" AndAlso password = "abc12345") Then
            'Bậc hộp thoại thông báo chỉ chứa nút OK với biểu tượng info
            MessageBox.Show("Chúc mừng, bạn đã đăng nhập thành công !", _
                            "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim admin As New frmQuanly
            frmQuanly.Show()
            Me.Hide()


        ElseIf userId = "user" AndAlso password = "abc12345" Then
            MessageBox.Show("Chúc mừng, bạn đã đăng nhập thành công !", _
                            "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim user As New frmQuanly
            frmQuanly.Show()
            Me.Hide()
        ElseIf userId = "" AndAlso password = "" Then
            'Bậc hộp thoại thông báo chỉ chứa nút OK với biểu tượng error
            MessageBox.Show("Nhập tên hoặc mất khẩu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            MessageBox.Show("Nhập sai tên hoặc mất khẩu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim cuaso As DialogResult = MessageBox.Show("Bạn muốn thoát ứng dụng này", "Thông báo", _
                MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If (cuaso = DialogResult.Yes) Then
            Me.Close()
            Application.Exit()
        End If
    End Sub

End Class
