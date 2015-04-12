Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class sanpham

    Dim tb As New DataTable
    Dim connectstr As String = "workstation id=ps01857.mssql.somee.com;packet size=4096;user id=thien;pwd=lechithien;data source=ps01857.mssql.somee.com;persist security info=False;initial catalog=ps01857"
    Public Sub dataload()
        Dim KetNoi As New SqlConnection(connectstr)
        Dim sql As New SqlDataAdapter("select * from sanpham", KetNoi)

        Try
            sql.Fill(tb)

        Catch ex As Exception
            dgvSanpham.DataSource = tb
            KetNoi.Close()
        End Try
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblMasp.Click

    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click

    End Sub
End Class