Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmKhachhang
    Dim tb As New DataTable
    Dim connectstr As String = "workstation id=ps01857.mssql.somee.com;packet size=4096;user id=thien;pwd=lechithien;data source=ps01857.mssql.somee.com;persist security info=False;initial catalog=ps01857"
    Public Sub Khachhang_load()
        Dim KetNoi As New SqlConnection(connectstr)
        'Tạo đối tượng chạy câu truy vấn 
        Dim sqlAdapter As New SqlDataAdapter("select * from Khachhang", KetNoi)
        Try
            sqlAdapter.Fill(tb)
        Catch ex As Exception
        End Try
        'Hiển thị dữ liệu Từ Datatable ra giao diện thông qua Datagridview
        DataGridView1.DataSource = tb
        KetNoi.Close()
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim index As Integer = DataGridView1.CurrentCell.RowIndex
        txtMaKH.Text = DataGridView1.Item(0, index).Value
        txtTenKH.Text = DataGridView1.Item(1, index).Value
        txtDiachi.Text = DataGridView1.Item(2, index).Value
        txtSdt.Text = DataGridView1.Item(3, index).Value


        tb.Clear()
        DataGridView1.DataSource = tb
        DataGridView1.DataSource = Nothing
        Khachhang_load()
    End Sub
   

    

    Private Sub frmKhachhang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tb.Clear()
        DataGridView1.DataSource = tb
        DataGridView1.DataSource = Nothing
        Khachhang_load()
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        Dim ketnoi As New SqlConnection(connectstr)
        ketnoi.Open()
        Dim stradd As String = " update KhachHang set TenKH = @TenKH ,DiaChi= @DiaChi,SDT = @SDT where MaKH = @MaKH "
        Dim com As New SqlCommand(stradd, ketnoi)
        Try
            'thêm dữ liệu vào câu truy vấn
            com.Parameters.AddWithValue("@MaKH", txtMaKH.Text)
            com.Parameters.AddWithValue("@TenKH", txtTenKH.Text)
            com.Parameters.AddWithValue("@DiaChi", txtDiachi.Text)
            com.Parameters.AddWithValue("@SDT", txtSdt.Text)


            com.ExecuteNonQuery()
            ketnoi.Close()
        Catch ex As Exception
            MessageBox.Show("ket noi khong thanh cong")
        End Try
        tb.Clear()
        DataGridView1.DataSource = tb
        DataGridView1.DataSource = Nothing
        Khachhang_load()
    End Sub

    Private Sub btnThemkh_Click(sender As Object, e As EventArgs) Handles btnThemkh.Click
        Dim query As String = String.Empty
        query &= "INSERT INTO KhachHang (MaKH,TenKH,DiaChi,SDT)"
        query &= "Values(@Makh,@TenKh,@Diachi,@SDT)"
        Using conn As New SqlConnection("workstation id=ps01857.mssql.somee.com;packet size=4096;user id=thien;pwd=lechithien;data source=ps01857.mssql.somee.com;persist security info=False;initial catalog=ps01857")
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@Makh", txtMaKH.Text)
                    .Parameters.AddWithValue("@TenKh", txtTenKH.Text)
                    .Parameters.AddWithValue("@Diachi", txtDiachi.Text)
                    .Parameters.AddWithValue("@SDT", txtSdt.Text)

                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    MessageBox.Show(ex.Message.ToString(), "Error Message")
                End Try
                tb.Clear()
                DataGridView1.DataSource = tb
                DataGridView1.DataSource = Nothing
                Khachhang_load()
            End Using
        End Using
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim ketnoi As New SqlConnection(connectstr)
        ketnoi.Open()
        Dim stradd As String = "Delete from  KhachHang where MaKH = @MaKH"
        Dim com As New SqlCommand(stradd, ketnoi)
        Try
            com.Parameters.AddWithValue("@MaKH", txtMaKH.Text)
            com.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Xoa khong thanh cong")
        End Try
        tb.Clear()
        DataGridView1.DataSource = tb
        DataGridView1.DataSource = Nothing
        Khachhang_load()
    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        frmQuanly.Show()
        Me.Close()

    End Sub
End Class