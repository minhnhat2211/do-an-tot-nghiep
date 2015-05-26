Imports System.Data.SqlClient
Imports System.Data
Public Class nv_DIENBIEN_BANGIAOHOSO
    Private PD As pd_FORM_DIENBIEN_BANGIAOHOSO
    Private PD_DIENBIEN As pd_DIENBIENHOSO
    Private PD_BANGIAO As pd_BANGIAO
    Private PD_CANBO As pd_CANBO
    Private frm As Form

    Public Sub New(ByRef f As Form)
        PD = New pd_FORM_DIENBIEN_BANGIAOHOSO
        PD_DIENBIEN = New pd_DIENBIENHOSO
        PD_BANGIAO = New pd_BANGIAO
        PD_CANBO = New pd_CANBO
        Me.frm = f
    End Sub
    Public Sub KiemTra(ByVal soHoSo As String)
        Dim LAY As DevExpress.XtraLayout.LayoutControl = CType(frm.Controls("lay_DIENBIEN_BANGIAOHOSO"), DevExpress.XtraLayout.LayoutControl)
        Dim GRD_CTDienBien As DevExpress.XtraGrid.GridControl = CType(LAY.Controls("grd_DIENBIENVAKETQUADIEUTRA"), DevExpress.XtraGrid.GridControl)
        Dim GRD_BanGiao As DevExpress.XtraGrid.GridControl = CType(LAY.Controls("grd_BANGIAOHOSO"), DevExpress.XtraGrid.GridControl)

        Dim spr_DB() As SqlParameter = {New SqlParameter("@maHoSo", soHoSo)}
        Dim spr_BG() As SqlParameter = {New SqlParameter("@maHoSo", soHoSo)}
        GRD_CTDienBien.DataSource = PD.Select_CTDienBien_DienBien(spr_DB)
        Dim tb_BanGiao1 As New DataTable
        tb_BanGiao1 = PD_BANGIAO.getTable(spr_BG)

        If tb_BanGiao1.Rows.Count <> 0 Then
            GRD_BanGiao.DataSource = tb_BanGiao1
        Else
            Dim tb_BanGiao As New DataTable
            Dim row_BG As DataRow
            tb_BanGiao.Columns.Add("thoiGian")
            tb_BanGiao.Columns.Add("maCanBoNhan")
            tb_BanGiao.Columns.Add("tenDoi")
            tb_BanGiao.Columns.Add("tenDonVi")
            tb_BanGiao.Columns.Add("diaPhuong")
            row_BG = tb_BanGiao.NewRow()
            row_BG(0) = ""
            row_BG(1) = ""
            row_BG(2) = ""
            row_BG(3) = ""
            row_BG(4) = ""
            tb_BanGiao.Rows.Add(row_BG)
            GRD_BanGiao.DataSource = tb_BanGiao
        End If
    End Sub

    Public Sub HIENTHI()
        Dim LAY As DevExpress.XtraLayout.LayoutControl = CType(frm.Controls("lay_DIENBIEN_BANGIAOHOSO"), DevExpress.XtraLayout.LayoutControl)
        Dim GRD_CTDienBien As DevExpress.XtraGrid.GridControl = CType(LAY.Controls("grd_DIENBIENVAKETQUADIEUTRA"), DevExpress.XtraGrid.GridControl)
        Dim GRD_BanGiao As DevExpress.XtraGrid.GridControl = CType(LAY.Controls("grd_BANGIAOHOSO"), DevExpress.XtraGrid.GridControl)
        Dim lk As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit = CType(GRD_BanGiao.RepositoryItems("RepositoryItemLookUpEdit1"), DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit)

        Dim tb_DienBien As New DataTable
        Dim tb_BanGiao As New DataTable

        tb_DienBien.Columns.Add("thoiGian")
        tb_DienBien.Columns.Add("dienBien")
        Dim row_DB As DataRow
        row_DB = tb_DienBien.NewRow()
        row_DB(0) = ""
        row_DB(1) = ""
        tb_DienBien.Rows.Add(row_DB)
        GRD_CTDienBien.DataSource = tb_DienBien

        Dim spr_CanBo() As SqlParameter = {New SqlParameter("@maCanBo", DBNull.Value)}
        lk.DataSource = PD_CANBO.getTable(spr_CanBo)
        lk.DisplayMember = "hoTen"
        lk.ValueMember = "maCanBo"

        tb_BanGiao.Columns.Add("thoiGian")
        tb_BanGiao.Columns.Add("maCanBoNhan")
        tb_BanGiao.Columns.Add("tenDoi")
        tb_BanGiao.Columns.Add("tenDonVi")
        tb_BanGiao.Columns.Add("diaPhuong")

        Dim row_BG As DataRow
        row_BG = tb_BanGiao.NewRow()
        row_BG(0) = ""
        row_BG(1) = ""
        row_BG(2) = ""
        row_BG(3) = ""
        row_BG(4) = ""
        tb_BanGiao.Rows.Add(row_BG)
        GRD_BanGiao.DataSource = tb_BanGiao
    End Sub
    Public Sub ADD_AllForm()
        Dim LAY As DevExpress.XtraLayout.LayoutControl = CType(frm.Controls("lay_DIENBIEN_BANGIAOHOSO"), DevExpress.XtraLayout.LayoutControl)
        Dim GRD_CTDienBien As DevExpress.XtraGrid.GridControl = CType(LAY.Controls("grd_DIENBIENVAKETQUADIEUTRA"), DevExpress.XtraGrid.GridControl)
        Dim GRD_BanGiao As DevExpress.XtraGrid.GridControl = CType(LAY.Controls("grd_BANGIAOHOSO"), DevExpress.XtraGrid.GridControl)
        Dim txt_SOHOSO As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_SOHOSO"), DevExpress.XtraEditors.TextEdit)

        Dim dt_CTDienBien As New DataTable
        Dim dt_BanGiao As New DataTable
        dt_CTDienBien = GRD_CTDienBien.DataSource

        Dim thoiGian As String
        Dim dienBien As String
        Dim soHoSo As String = txt_SOHOSO.Text

        Dim spr_delete() As SqlParameter = {New SqlParameter("@maHoSo", soHoSo)}
        PD.DELETE_CTDienBien_DienBien(spr_delete)

        Dim spr_CTDienBien() As SqlParameter
        Dim spr_BanGiao() As SqlParameter
        For Each dr_dienbien As DataRow In dt_CTDienBien.Rows
            thoiGian = dr_dienbien("thoiGian").ToString
            dienBien = dr_dienbien("dienBien").ToString

            spr_CTDienBien = {
                New SqlParameter("@thoiGian", thoiGian),
                New SqlParameter("@dienBien", dienBien),
                New SqlParameter("@maHoSo", soHoSo)
            }
            PD.Add_CTDienBien_DienBien(spr_CTDienBien)
        Next

        Dim thoiGianBanGiao As String
        Dim maCanBo As String
        dt_BanGiao = GRD_BanGiao.DataSource
        For Each dr As DataRow In dt_BanGiao.Rows
            thoiGianBanGiao = dr("thoiGian").ToString
            maCanBo = dr("maCanBoNhan").ToString
            spr_BanGiao = {
                New SqlParameter("@thoiGian", thoiGianBanGiao),
                New SqlParameter("@maCanBoNhan", maCanBo),
                New SqlParameter("@maHoSo", soHoSo)
            }
            PD.Add_BanGiao(spr_BanGiao)
        Next

    End Sub
    Public Function getTenDoi(ByVal maCanBo As String) As String
        Dim tenDoi As String = ""
        Dim spr_maCanBo() As SqlParameter = {
               New SqlParameter("@maCanBo", maCanBo)
           }
        Dim dt As DataTable = PD.Select_ThongTinCanBo(spr_maCanBo)
        For Each dr As DataRow In dt.Rows
            tenDoi = dr("tenDoi")
        Next
        Return tenDoi
    End Function
    Public Function getTenDonVi(ByVal maCanBo As String) As String
        Dim tenDonVi As String = ""
        Dim spr_maCanBo() As SqlParameter = {
               New SqlParameter("@maCanBo", maCanBo)
           }
        Dim dt As DataTable = PD.Select_ThongTinCanBo(spr_maCanBo)
        For Each dr As DataRow In dt.Rows
            tenDonVi = dr("tenDonVi")
        Next
        Return tenDonVi
    End Function
    Public Function getDiaPhuong(ByVal maCanBo As String) As String
        Dim diaPhuong As String = ""
        Dim spr_maCanBo() As SqlParameter = {
               New SqlParameter("@maCanBo", maCanBo)
           }
        Dim dt As DataTable = PD.Select_ThongTinCanBo(spr_maCanBo)
        For Each dr As DataRow In dt.Rows
            diaPhuong = dr("diaPhuong")
        Next
        Return diaPhuong
    End Function

    Public Sub ADD_DIENBEN()
        Dim LAY As DevExpress.XtraLayout.LayoutControl = CType(frm.Controls("lay_DIENBIEN_BANGIAOHOSO"), DevExpress.XtraLayout.LayoutControl)
        Dim GRD_CTDienBien As DevExpress.XtraGrid.GridControl = CType(LAY.Controls("grd_DIENBIENVAKETQUADIEUTRA"), DevExpress.XtraGrid.GridControl)
        Dim GRD_BanGiao As DevExpress.XtraGrid.GridControl = CType(LAY.Controls("grd_BANGIAOHOSO"), DevExpress.XtraGrid.GridControl)
        Dim txt_SOHOSO As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_SOHOSO"), DevExpress.XtraEditors.TextEdit)

        Dim dt_CTDienBien As New DataTable
        Dim dt_BanGiao As New DataTable
        dt_CTDienBien = GRD_CTDienBien.DataSource

        Dim thoiGian As String
        Dim dienBien As String
        Dim soHoSo As String = txt_SOHOSO.Text

        Dim spr_delete() As SqlParameter = {New SqlParameter("@maHoSo", soHoSo)}
        PD.DELETE_CTDienBien_DienBien(spr_delete)

        Dim spr_CTDienBien() As SqlParameter
        For Each dr_dienbien As DataRow In dt_CTDienBien.Rows
            thoiGian = dr_dienbien("thoiGian").ToString
            dienBien = dr_dienbien("dienBien").ToString

            spr_CTDienBien = {
                New SqlParameter("@thoiGian", thoiGian),
                New SqlParameter("@dienBien", dienBien),
                New SqlParameter("@maHoSo", soHoSo)
            }
            PD.Add_CTDienBien_DienBien(spr_CTDienBien)
        Next
    End Sub
    Public Sub ADD_BANGIAO()
        Dim LAY As DevExpress.XtraLayout.LayoutControl = CType(frm.Controls("lay_DIENBIEN_BANGIAOHOSO"), DevExpress.XtraLayout.LayoutControl)
        Dim GRD_CTDienBien As DevExpress.XtraGrid.GridControl = CType(LAY.Controls("grd_DIENBIENVAKETQUADIEUTRA"), DevExpress.XtraGrid.GridControl)
        Dim GRD_BanGiao As DevExpress.XtraGrid.GridControl = CType(LAY.Controls("grd_BANGIAOHOSO"), DevExpress.XtraGrid.GridControl)
        Dim txt_SOHOSO As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_SOHOSO"), DevExpress.XtraEditors.TextEdit)

        Dim dt_BanGiao As New DataTable

        Dim soHoSo As String = txt_SOHOSO.Text

        Dim thoiGianBanGiao As String
        Dim maCanBo As String
        Dim spr_delete() As SqlParameter = {New SqlParameter("@maHoSo", soHoSo)}
        PD.DELETE_BanGiao(spr_delete)
        Dim spr_BanGiao() As SqlParameter
        dt_BanGiao = GRD_BanGiao.DataSource
        For Each dr As DataRow In dt_BanGiao.Rows
            thoiGianBanGiao = dr("thoiGian").ToString
            maCanBo = dr("maCanBoNhan").ToString
            spr_BanGiao = {
                New SqlParameter("@thoiGian", thoiGianBanGiao),
                New SqlParameter("@maCanBoNhan", maCanBo),
                New SqlParameter("@maHoSo", soHoSo)
            }
            PD.Add_BanGiao(spr_BanGiao)
        Next
    End Sub

End Class
