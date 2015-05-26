Imports System.Data.SqlClient
Public Class nv_TOIDANHHANHVI
    Private TOIDANHHANHVI As pd_TOIDANHHANHVI
    Private HANHVI As pd_HANHVI
    Private TOIDANH As pd_TOIDANH
    Private HOSO As pd_HOSO
    Private DOITUONG As pd_DOITUONG
    Private HOSODOITUONG As pd_HOSODOITUONG
    Private frm_TOIDANHHANHVI As Form

    Public Sub New(ByRef f As Form)
        TOIDANHHANHVI = New pd_TOIDANHHANHVI
        HANHVI = New pd_HANHVI
        TOIDANH = New pd_TOIDANH
        HOSO = New pd_HOSO
        DOITUONG = New pd_DOITUONG
        HOSODOITUONG = New pd_HOSODOITUONG
        Me.frm_TOIDANHHANHVI = f
    End Sub

    

    Public Sub HIENTHI()
        Dim LAY As DevExpress.XtraLayout.LayoutControl = CType(frm_TOIDANHHANHVI.Controls("lay_TOIDANHHANHVI"), DevExpress.XtraLayout.LayoutControl)
        Dim GRD_TOIDANHHANHVI As DevExpress.XtraGrid.GridControl = CType(LAY.Controls("grd_TOIDANHHANHVI"), DevExpress.XtraGrid.GridControl)
        Dim combo_IDHOSODOITUONG As DevExpress.XtraEditors.LookUpEdit = CType(LAY.Controls("combo_IDHOSODOITUONG"), DevExpress.XtraEditors.LookUpEdit)
        Dim lk_hanhvi As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit = CType(GRD_TOIDANHHANHVI.RepositoryItems("RepositoryItemLookUpEdit1"), DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit)
        Dim lk_toidanh As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit = CType(GRD_TOIDANHHANHVI.RepositoryItems("RepositoryItemLookUpEdit2"), DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit)


        Dim spr_idHoSoDoiTuong() As SqlParameter = {New SqlParameter("@id_hoSoDoiTuong", DBNull.Value)}
        combo_IDHOSODOITUONG.Properties.DataSource = Me.HOSODOITUONG.getid(spr_idHoSoDoiTuong)
        combo_IDHOSODOITUONG.Properties.DisplayMember = "fullname"
        combo_IDHOSODOITUONG.Properties.DisplayMember = "soHoSo"
        combo_IDHOSODOITUONG.Properties.DisplayMember = "soThe"
        combo_IDHOSODOITUONG.Properties.ValueMember = "id_hoSoDoiTuong"



       

        Dim spr_hanhVi() As SqlParameter = {New SqlParameter("@maHanhVi", DBNull.Value)}
        lk_hanhvi.DataSource = HANHVI.getTable(spr_hanhVi)
        lk_hanhvi.DisplayMember = "hanhVi"
        lk_hanhvi.ValueMember = "maHanhVi"
        Dim spr_toiDanh() As SqlParameter = {New SqlParameter("@maToiDanh", DBNull.Value)}
        lk_toidanh.DataSource = TOIDANH.getTable(spr_toiDanh)
        lk_toidanh.DisplayMember = "tenToiDanh"
        lk_toidanh.ValueMember = "maToiDanh"

        Dim tb_TOIDANHHANHVI As New DataTable
        tb_TOIDANHHANHVI.Columns.Add("id_hoSoDoiTuong")
        tb_TOIDANHHANHVI.Columns.Add("maHanhVi")
        tb_TOIDANHHANHVI.Columns.Add("maToiDanh")
        tb_TOIDANHHANHVI.Columns.Add("donViXuLy")
        tb_TOIDANHHANHVI.Columns.Add("diaPhuongXuLy")
        tb_TOIDANHHANHVI.Columns.Add("hinhThucXuLy")
        tb_TOIDANHHANHVI.Columns.Add("thoiGian")
        tb_TOIDANHHANHVI.Columns.Add("mucDoXuLy")

        Dim row As DataRow
        row = tb_TOIDANHHANHVI.NewRow()
        row(0) = ""
        row(1) = ""
        row(2) = ""
        row(3) = ""
        row(4) = ""
        tb_TOIDANHHANHVI.Rows.Add(row)
        GRD_TOIDANHHANHVI.DataSource = tb_TOIDANHHANHVI
    End Sub
    Public Sub ADD()
        Dim LAY As DevExpress.XtraLayout.LayoutControl = CType(frm_TOIDANHHANHVI.Controls("lay_TOIDANHHANHVI"), DevExpress.XtraLayout.LayoutControl)
        Dim GRD As DevExpress.XtraGrid.GridControl = CType(LAY.Controls("grd_TOIDANHHANHVI"), DevExpress.XtraGrid.GridControl)
        Dim combo_IDHOSODOITUONG As DevExpress.XtraEditors.LookUpEdit = CType(LAY.Controls("combo_IDHOSODOITUONG"), DevExpress.XtraEditors.LookUpEdit)
        Dim dt As New DataTable



        Dim id_hoSoDoiTuong As String = combo_IDHOSODOITUONG.GetColumnValue(combo_IDHOSODOITUONG.Properties.Columns(0))
        Dim maHanhVi As String
        Dim maToiDanh As String
        Dim donViXuLy As String
        Dim diaPhuongXuLy As String
        Dim hinhThucXuLy As String
        Dim thoiGian As String
        Dim mucDoXuLy As String

        Dim spr_delete() As SqlParameter = {
            New SqlParameter("@id_hoSoDoiTuong", id_hoSoDoiTuong)
        }
        TOIDANHHANHVI.Delete(spr_delete)
        Dim spr() As SqlParameter
        dt = GRD.DataSource
        For Each dr As DataRow In dt.Rows
            maHanhVi = dr("maHanhVi").ToString
            maToiDanh = dr("maToiDanh").ToString
            donViXuLy = dr("donViXuLy").ToString
            diaPhuongXuLy = dr("diaPhuongXuLy").ToString
            hinhThucXuLy = dr("hinhThucXuLy").ToString
            thoiGian = dr("thoiGian").ToString
            mucDoXuLy = dr("mucDoXuLy").ToString
            spr = {
                New SqlParameter("@id_hoSoDoiTuong", id_hoSoDoiTuong),
                New SqlParameter("maHanhVi", maHanhVi),
                New SqlParameter("maToiDanh", maToiDanh),
                New SqlParameter("@donViXuLy", donViXuLy),
                New SqlParameter("@diaPhuongXuLy", diaPhuongXuLy),
                New SqlParameter("@hinhThucXuLy", hinhThucXuLy),
                New SqlParameter("@thoiGian", thoiGian),
                New SqlParameter("@mucDoXuLy", mucDoXuLy)
            }
            TOIDANHHANHVI.Add(spr)
        Next
    End Sub

End Class
