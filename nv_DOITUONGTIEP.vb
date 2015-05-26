
Imports System.Data.SqlClient
Public Class nv_DOITUONGTIEP
    Private HOSODOITUONG As pd_HOSODOITUONG
    Private HOSO As pd_HOSO
    Private frm_DOITUONGTIEP As Form

    Public Sub New(ByRef f As Form)
        HOSODOITUONG = New pd_HOSODOITUONG
        HOSO = New pd_HOSO
        Me.frm_DOITUONGTIEP = f
    End Sub
    Public Sub HIENTHI()
        Dim LAY As DevExpress.XtraLayout.LayoutControl = CType(frm_DOITUONGTIEP.Controls("lay_DOITUONGTIEP"), DevExpress.XtraLayout.LayoutControl)
        Dim GRD As DevExpress.XtraGrid.GridControl = CType(LAY.Controls("grd_DOITUONGTIEP"), DevExpress.XtraGrid.GridControl)
        Dim combo_SOHOSO As DevExpress.XtraEditors.LookUpEdit = CType(LAY.Controls("combo_SOHOSO"), DevExpress.XtraEditors.LookUpEdit)
        Dim combo_SOTHE As DevExpress.XtraEditors.LookUpEdit = CType(LAY.Controls("combo_SOTHE"), DevExpress.XtraEditors.LookUpEdit)
        Dim combo_DANHMUCLOAIST As DevExpress.XtraEditors.LookUpEdit = CType(LAY.Controls("combo_DANHMUCLOAIST"), DevExpress.XtraEditors.LookUpEdit)
        Dim combo_DANHMUCHEST As DevExpress.XtraEditors.LookUpEdit = CType(LAY.Controls("combo_DANHMUCHEST"), DevExpress.XtraEditors.LookUpEdit)
        Dim combo_DOITUONGSTLOAI As DevExpress.XtraEditors.LookUpEdit = CType(LAY.Controls("combo_DOITUONGSTLOAI"), DevExpress.XtraEditors.LookUpEdit)
        Dim text_SODANHBAN As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_SODANHBAN"), DevExpress.XtraEditors.TextEdit)
        Dim text_NGAYLAPDANHBAN As DevExpress.XtraEditors.DateEdit = CType(LAY.Controls("txt_NGAYLAPDANHBAN"), DevExpress.XtraEditors.DateEdit)
        Dim text_DONVILAPDANHBAN As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_DONVILAP"), DevExpress.XtraEditors.TextEdit)
        Dim text_DIAPHUONGLAPDANHBAN As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_DIAPHUONGLAP"), DevExpress.XtraEditors.TextEdit)
        Dim combo_LOAIDOITUONG As DevExpress.XtraEditors.LookUpEdit = CType(LAY.Controls("combo_LOAIDOITUONG"), DevExpress.XtraEditors.LookUpEdit)
        Dim text_SOLUUTRU As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_SOLUUTRU"), DevExpress.XtraEditors.TextEdit)
        Dim text_NGAYNOPLUU As DevExpress.XtraEditors.DateEdit = CType(LAY.Controls("txt_NGAYNOPLUU"), DevExpress.XtraEditors.DateEdit)
        Dim text_NGAYKETTHUC As DevExpress.XtraEditors.DateEdit = CType(LAY.Controls("txt_NGAYKETTHUC"), DevExpress.XtraEditors.DateEdit)
        Dim text_LYDOKETTHUC As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_LYDOKETTHUC"), DevExpress.XtraEditors.TextEdit)


        Dim spr() As SqlParameter = {
                    New SqlParameter("@soHoSo", DBNull.Value)
                }
        Dim spr_hienthi() As SqlParameter = {
                New SqlParameter("@soHoSo", DBNull.Value)
            }
        Dim spr_loaiST() As SqlParameter = {
            New SqlParameter("@DMLoaiST", DBNull.Value)
        }
        Dim spr_heST() As SqlParameter = {
            New SqlParameter("@DMHeST", DBNull.Value)
        }
        Dim spr_doiTuongLoaiST() As SqlParameter = {
            New SqlParameter("@doiTuongSTLoai", DBNull.Value)
        }
        Dim spr_sothe() As SqlParameter = {
            New SqlParameter("@soThe", DBNull.Value)
        }
        Dim spr_maloai() As SqlParameter = {
            New SqlParameter("@maLoaiDoiTuong", DBNull.Value)
        }


        combo_SOHOSO.Properties.DataSource = Me.HOSODOITUONG.getSoHoSo(spr)
        combo_SOHOSO.Properties.DisplayMember = "soHoSo"
        combo_SOHOSO.Properties.ValueMember = "soHoSo"
        combo_LOAIDOITUONG.Properties.DataSource = Me.HOSODOITUONG.getmaLoai(spr_maloai)
        combo_LOAIDOITUONG.Properties.DisplayMember = "tenLoai"
        combo_LOAIDOITUONG.Properties.ValueMember = "maLoaiDoiTuong"
        combo_SOTHE.Properties.DataSource = Me.HOSODOITUONG.getsoThe(spr_sothe)
        combo_SOTHE.Properties.DisplayMember = "fullname"
        combo_SOTHE.Properties.ValueMember = "soThe"
        combo_DANHMUCLOAIST.Properties.DataSource = Me.HOSODOITUONG.getDMLoaiST(spr_loaiST)
        combo_DANHMUCLOAIST.Properties.DisplayMember = "tenLoaiST"
        combo_DANHMUCLOAIST.Properties.ValueMember = "DMLoaiST"
        combo_DANHMUCHEST.Properties.DataSource = Me.HOSODOITUONG.getDMHeST(spr_heST)
        combo_DANHMUCHEST.Properties.DisplayMember = "TenHeST"
        combo_DANHMUCHEST.Properties.ValueMember = "DMHeST"
        combo_DOITUONGSTLOAI.Properties.DataSource = Me.HOSODOITUONG.getdoiTuongSTLoai(spr_doiTuongLoaiST)
        combo_DOITUONGSTLOAI.Properties.DisplayMember = "tenDoiTuong"
        combo_DOITUONGSTLOAI.Properties.ValueMember = "doiTuongSTLoai"

        GRD.DataSource = Me.HOSODOITUONG.gethienthi(spr_hienthi)
        'If IsDBNull(GRD.DataSource) = False Then
        combo_SOHOSO.DataBindings.Clear()
        combo_SOHOSO.DataBindings.Add("EditValue", GRD.DataSource, "soHoSo")
        combo_SOTHE.DataBindings.Clear()
        combo_SOTHE.DataBindings.Add("EditValue", GRD.DataSource, "soThe")
        combo_DANHMUCHEST.DataBindings.Clear()
        combo_DANHMUCHEST.DataBindings.Add("EditValue", GRD.DataSource, "DMHeST")
        combo_DANHMUCLOAIST.DataBindings.Clear()
        combo_DANHMUCLOAIST.DataBindings.Add("EditValue", GRD.DataSource, "DMLoaiST")
        combo_DOITUONGSTLOAI.DataBindings.Clear()
        combo_DOITUONGSTLOAI.DataBindings.Add("EditValue", GRD.DataSource, "doiTuongSTLoai")
        combo_LOAIDOITUONG.DataBindings.Clear()
        combo_LOAIDOITUONG.DataBindings.Add("EditValue", GRD.DataSource, "maLoaiDoiTuong")
        text_SODANHBAN.DataBindings.Clear()
        text_SODANHBAN.DataBindings.Add("Text", GRD.DataSource, "soDanhBan")
        text_NGAYLAPDANHBAN.DataBindings.Clear()
        text_NGAYLAPDANHBAN.DataBindings.Add("Text", GRD.DataSource, "ngayLapDanhBan")
        text_DONVILAPDANHBAN.DataBindings.Clear()
        text_DONVILAPDANHBAN.DataBindings.Add("Text", GRD.DataSource, "donViLapDanhBan")
        text_DIAPHUONGLAPDANHBAN.DataBindings.Clear()
        text_DIAPHUONGLAPDANHBAN.DataBindings.Add("Text", GRD.DataSource, "diaPhuongLapDanhBan")
        text_SOLUUTRU.DataBindings.Clear()
        text_SOLUUTRU.DataBindings.Add("Text", GRD.DataSource, "soLuuTru")
        text_NGAYNOPLUU.DataBindings.Clear()
        text_NGAYNOPLUU.DataBindings.Add("Text", GRD.DataSource, "ngayNopLuu")
        text_NGAYKETTHUC.DataBindings.Clear()
        text_NGAYKETTHUC.DataBindings.Add("Text", GRD.DataSource, "ngayKetThuc")
        text_LYDOKETTHUC.DataBindings.Clear()
        text_LYDOKETTHUC.DataBindings.Add("Text", GRD.DataSource, "lyDoKetThuc")
        'End If



    End Sub

    Public Sub ADD()
        Dim LAY As DevExpress.XtraLayout.LayoutControl = CType(frm_DOITUONGTIEP.Controls("lay_DOITUONGTIEP"), DevExpress.XtraLayout.LayoutControl)
        Dim GRD As DevExpress.XtraGrid.GridControl = CType(LAY.Controls("grd_DOITUONGTIEP"), DevExpress.XtraGrid.GridControl)
        Dim combo_SOHOSO As DevExpress.XtraEditors.LookUpEdit = CType(LAY.Controls("combo_SOHOSO"), DevExpress.XtraEditors.LookUpEdit)
        Dim combo_SOTHE As DevExpress.XtraEditors.LookUpEdit = CType(LAY.Controls("combo_SOTHE"), DevExpress.XtraEditors.LookUpEdit)
        Dim combo_IDTOIDANHHANHVI As DevExpress.XtraEditors.LookUpEdit = CType(LAY.Controls("combo_IDTOIDANHHANHVI"), DevExpress.XtraEditors.LookUpEdit)
        Dim combo_DANHMUCLOAIST As DevExpress.XtraEditors.LookUpEdit = CType(LAY.Controls("combo_DANHMUCLOAIST"), DevExpress.XtraEditors.LookUpEdit)
        Dim combo_DANHMUCHEST As DevExpress.XtraEditors.LookUpEdit = CType(LAY.Controls("combo_DANHMUCHEST"), DevExpress.XtraEditors.LookUpEdit)
        Dim combo_DOITUONGSTLOAI As DevExpress.XtraEditors.LookUpEdit = CType(LAY.Controls("combo_DOITUONGSTLOAI"), DevExpress.XtraEditors.LookUpEdit)
        Dim text_SODANHBAN As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_SODANHBAN"), DevExpress.XtraEditors.TextEdit)
        Dim text_NGAYLAPDANHBAN As DevExpress.XtraEditors.DateEdit = CType(LAY.Controls("txt_NGAYLAPDANHBAN"), DevExpress.XtraEditors.DateEdit)
        Dim text_DONVILAP As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_DONVILAP"), DevExpress.XtraEditors.TextEdit)
        Dim text_DIAPHUONGLAP As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_DIAPHUONGLAP"), DevExpress.XtraEditors.TextEdit)
        Dim text_LOAIHOSO As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_LOAIHOSO"), DevExpress.XtraEditors.TextEdit)
        Dim combo_LOAIDOITUONG As DevExpress.XtraEditors.LookUpEdit = CType(LAY.Controls("combo_LOAIDOITUONG"), DevExpress.XtraEditors.LookUpEdit)
        Dim text_NGAYLAP As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_NGAYLAP"), DevExpress.XtraEditors.TextEdit)
        Dim text_NGAYDANGKY As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_NGAYDANGKY"), DevExpress.XtraEditors.TextEdit)
        Dim text_SOLUUTRU As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_SOLUUTRU"), DevExpress.XtraEditors.TextEdit)
        Dim text_NGAYNOPLUU As DevExpress.XtraEditors.DateEdit = CType(LAY.Controls("txt_NGAYNOPLUU"), DevExpress.XtraEditors.DateEdit)
        Dim text_NGAYKETTHUC As DevExpress.XtraEditors.DateEdit = CType(LAY.Controls("txt_NGAYKETTHUC"), DevExpress.XtraEditors.DateEdit)
        Dim text_LYDOKETTHUC As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_LYDOKETTHUC"), DevExpress.XtraEditors.TextEdit)
        Dim text_CANBOLAPHOSO As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_CANBOLAPHOSO"), DevExpress.XtraEditors.TextEdit)
        Dim text_DOILAPHOSO As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_DOILAPHOSO"), DevExpress.XtraEditors.TextEdit)
        Dim text_DONVILAPHOSO As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_DONVILAPHOSO"), DevExpress.XtraEditors.TextEdit)
        Dim text_DIAPHUONGLAPHOSO As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_DIAPHUONGLAPHOSO"), DevExpress.XtraEditors.TextEdit)
        Dim text_LUCLUONGLAPHOSO As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_LUCLUONGLAPHOSO"), DevExpress.XtraEditors.TextEdit)
        Dim text_THUTRUONGDONVI As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_THUTRUONGDONVI"), DevExpress.XtraEditors.TextEdit)
        Dim spr() As SqlParameter = {
            New SqlParameter("@soHoSo", combo_SOHOSO.GetColumnValue(combo_SOHOSO.Properties.Columns(0))),
            New SqlParameter("@soThe", combo_SOTHE.GetColumnValue(combo_SOTHE.Properties.Columns(0))),
            New SqlParameter("@soDanhBan", text_SODANHBAN.Text),
            New SqlParameter("@ngayLapDanhBan", text_NGAYLAPDANHBAN.DateTime),
            New SqlParameter("@donViLapDanhBan", text_DONVILAP.Text),
            New SqlParameter("@diaPhuongLapDanhBan", text_DIAPHUONGLAP.Text),
            New SqlParameter("@maLoaiDoiTuong", combo_LOAIDOITUONG.GetColumnValue(combo_LOAIDOITUONG.Properties.Columns(0))),
            New SqlParameter("@DMLoaiST", combo_DANHMUCLOAIST.GetColumnValue(combo_DANHMUCLOAIST.Properties.Columns(0))),
            New SqlParameter("@DMHeST", combo_DANHMUCHEST.GetColumnValue(combo_DANHMUCHEST.Properties.Columns(0))),
            New SqlParameter("@doiTuongSTLoai", combo_DOITUONGSTLOAI.GetColumnValue(combo_DOITUONGSTLOAI.Properties.Columns(0))),
            New SqlParameter("@soLuuTru", text_SOLUUTRU.Text),
            New SqlParameter("@ngayNopLuu", text_NGAYNOPLUU.DateTime),
            New SqlParameter("@ngayKetThuc", text_NGAYKETTHUC.DateTime),
            New SqlParameter("@lyDoKetThuc", text_LYDOKETTHUC.Text)
           }
        HOSODOITUONG.Add(spr)
    End Sub
    Public Sub DoDuLieu(ByVal soHoSo As String)
        Dim LAY As DevExpress.XtraLayout.LayoutControl = CType(frm_DOITUONGTIEP.Controls("lay_DOITUONGTIEP"), DevExpress.XtraLayout.LayoutControl)
        Dim GRD As DevExpress.XtraGrid.GridControl = CType(LAY.Controls("grd_DOITUONGTIEP"), DevExpress.XtraGrid.GridControl)

        Dim combo_SOHOSO As DevExpress.XtraEditors.LookUpEdit = CType(LAY.Controls("combo_SOHOSO"), DevExpress.XtraEditors.LookUpEdit)
        Dim combo_SOTHE As DevExpress.XtraEditors.LookUpEdit = CType(LAY.Controls("combo_SOTHE"), DevExpress.XtraEditors.LookUpEdit)
        Dim combo_DANHMUCLOAIST As DevExpress.XtraEditors.LookUpEdit = CType(LAY.Controls("combo_DANHMUCLOAIST"), DevExpress.XtraEditors.LookUpEdit)
        Dim combo_DANHMUCHEST As DevExpress.XtraEditors.LookUpEdit = CType(LAY.Controls("combo_DANHMUCHEST"), DevExpress.XtraEditors.LookUpEdit)
        Dim combo_DOITUONGSTLOAI As DevExpress.XtraEditors.LookUpEdit = CType(LAY.Controls("combo_DOITUONGSTLOAI"), DevExpress.XtraEditors.LookUpEdit)
        Dim text_SODANHBAN As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_SODANHBAN"), DevExpress.XtraEditors.TextEdit)
        Dim text_NGAYLAPDANHBAN As DevExpress.XtraEditors.DateEdit = CType(LAY.Controls("txt_NGAYLAPDANHBAN"), DevExpress.XtraEditors.DateEdit)
        Dim text_DONVILAP As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_DONVILAP"), DevExpress.XtraEditors.TextEdit)
        Dim text_DIAPHUONGLAPDANHBAN As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_DIAPHUONGLAP"), DevExpress.XtraEditors.TextEdit)
        Dim text_LOAIHOSO As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_LOAIHOSO"), DevExpress.XtraEditors.TextEdit)
        Dim combo_LOAIDOITUONG As DevExpress.XtraEditors.LookUpEdit = CType(LAY.Controls("combo_LOAIDOITUONG"), DevExpress.XtraEditors.LookUpEdit)
        Dim text_NGAYLAP As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_NGAYLAP"), DevExpress.XtraEditors.TextEdit)
        Dim text_NGAYDANGKY As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_NGAYDANGKY"), DevExpress.XtraEditors.TextEdit)
        Dim text_SOLUUTRU As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_SOLUUTRU"), DevExpress.XtraEditors.TextEdit)
        Dim text_NGAYNOPLUU As DevExpress.XtraEditors.DateEdit = CType(LAY.Controls("txt_NGAYNOPLUU"), DevExpress.XtraEditors.DateEdit)
        Dim text_NGAYKETTHUC As DevExpress.XtraEditors.DateEdit = CType(LAY.Controls("txt_NGAYKETTHUC"), DevExpress.XtraEditors.DateEdit)
        Dim text_LYDOKETTHUC As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_LYDOKETTHUC"), DevExpress.XtraEditors.TextEdit)
        Dim text_CANBOLAPHOSO As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_CANBOLAPHOSO"), DevExpress.XtraEditors.TextEdit)
        Dim text_DOILAPHOSO As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_DOILAPHOSO"), DevExpress.XtraEditors.TextEdit)
        Dim text_DONVILAPHOSO As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_DONVILAPHOSO"), DevExpress.XtraEditors.TextEdit)
        Dim text_DIAPHUONGLAPHOSO As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_DIAPHUONGLAPHOSO"), DevExpress.XtraEditors.TextEdit)
        Dim text_LUCLUONGLAPHOSO As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_LUCLUONGLAPHOSO"), DevExpress.XtraEditors.TextEdit)
        Dim text_THUTRUONGDONVI As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_THUTRUONGDONVI"), DevExpress.XtraEditors.TextEdit)
        Dim spr() As SqlParameter = {
            New SqlParameter("@soHoSo", soHoSo)
        }

        'Dim spr_GRD() As SqlParameter = {
        '    New SqlParameter("@soHoSo", soHoSo)
        '}
        'GRD.DataSource = HOSODOITUONG.gethienthi(spr_GRD)
        Dim dt As New DataTable
        dt = HOSODOITUONG.getTable(spr)
        For Each dr As DataRow In dt.Rows
            text_LOAIHOSO.Text = dr("maLoaiHoSo")
            text_NGAYLAP.Text = dr("ngayLap") & " "
            text_NGAYDANGKY.Text = dr("ngayDangKy") & " "
            text_CANBOLAPHOSO.Text = dr("fullname")
            text_DOILAPHOSO.Text = dr("tenDoi")
            text_DONVILAPHOSO.Text = dr("tenDonVi")
            text_DIAPHUONGLAPHOSO.Text = dr("diaDiem") & " "
            text_LUCLUONGLAPHOSO.Text = dr("tenLucLuong") & " "
            text_THUTRUONGDONVI.Text = dr("thuTruongDonVi") & " "
        Next

        'combo_SOHOSO.DataBindings.Clear()
        'combo_SOTHE.DataBindings.Clear()
        'combo_DANHMUCLOAIST.DataBindings.Clear()
        'combo_DANHMUCHEST.DataBindings.Clear()
        'combo_DOITUONGSTLOAI.DataBindings.Clear()
        'text_SODANHBAN.DataBindings.Clear()
        'text_NGAYLAPDANHBAN.DataBindings.Clear()
        'text_DONVILAP.DataBindings.Clear()
        'text_DIAPHUONGLAPDANHBAN.DataBindings.Clear()
        'text_LOAIHOSO.DataBindings.Clear()
        'combo_LOAIDOITUONG.DataBindings.Clear()
        'text_NGAYLAP.DataBindings.Clear()
        'text_NGAYDANGKY.DataBindings.Clear()
        'text_SOLUUTRU.DataBindings.Clear()
        'text_NGAYNOPLUU.DataBindings.Clear()
        'text_NGAYKETTHUC.DataBindings.Clear()
        'text_LYDOKETTHUC.DataBindings.Clear()
        'text_CANBOLAPHOSO.DataBindings.Clear()
        'text_DOILAPHOSO.DataBindings.Clear()
        'text_DONVILAPHOSO.DataBindings.Clear()
        'text_DIAPHUONGLAPHOSO.DataBindings.Clear()
        'text_LUCLUONGLAPHOSO.DataBindings.Clear()
        'text_THUTRUONGDONVI.DataBindings.Clear()



    End Sub
    Public Sub DELETETRENTEXTBOX()
        Dim Lay As DevExpress.XtraLayout.LayoutControl = CType(frm_DOITUONGTIEP.Controls("lay_DOITUONGTIEP"), DevExpress.XtraLayout.LayoutControl)
        Dim combo_SOHOSO As DevExpress.XtraEditors.LookUpEdit = CType(Lay.Controls("combo_SOHOSO"), DevExpress.XtraEditors.LookUpEdit)
        Dim combo_SOTHE As DevExpress.XtraEditors.LookUpEdit = CType(Lay.Controls("combo_SOTHE"), DevExpress.XtraEditors.LookUpEdit)
        Dim soHoSo As String = combo_SOHOSO.GetColumnValue(combo_SOHOSO.Properties.Columns(0))
        Dim soThe As String = combo_SOTHE.GetColumnValue(combo_SOTHE.Properties.Columns(0))
        Dim spr() As SqlParameter = {New SqlParameter("@soHoSo", soHoSo),
                                    New SqlParameter("@soThe", soThe)}
        HOSODOITUONG.Delete(spr)


    End Sub
    Public Sub UPDATETRENTEXTBOX()
        Dim Lay As DevExpress.XtraLayout.LayoutControl = CType(frm_DOITUONGTIEP.Controls("lay_DOITUONGTIEP"), DevExpress.XtraLayout.LayoutControl)
        Dim combo_SOHOSO As DevExpress.XtraEditors.LookUpEdit = CType(Lay.Controls("combo_SOHOSO"), DevExpress.XtraEditors.LookUpEdit)
        Dim combo_SOTHE As DevExpress.XtraEditors.LookUpEdit = CType(Lay.Controls("combo_SOTHE"), DevExpress.XtraEditors.LookUpEdit)
        Dim combo_DANHMUCLOAIST As DevExpress.XtraEditors.LookUpEdit = CType(Lay.Controls("combo_DANHMUCLOAIST"), DevExpress.XtraEditors.LookUpEdit)
        Dim combo_DANHMUCHEST As DevExpress.XtraEditors.LookUpEdit = CType(Lay.Controls("combo_DANHMUCHEST"), DevExpress.XtraEditors.LookUpEdit)
        Dim combo_DOITUONGSTLOAI As DevExpress.XtraEditors.LookUpEdit = CType(Lay.Controls("combo_DOITUONGSTLOAI"), DevExpress.XtraEditors.LookUpEdit)
        Dim text_SODANHBAN As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_SODANHBAN"), DevExpress.XtraEditors.TextEdit)
        Dim text_NGAYLAPDANHBAN As DevExpress.XtraEditors.DateEdit = CType(Lay.Controls("txt_NGAYLAPDANHBAN"), DevExpress.XtraEditors.DateEdit)
        Dim text_DONVILAP As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_DONVILAP"), DevExpress.XtraEditors.TextEdit)
        Dim text_DIAPHUONGLAP As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_DIAPHUONGLAP"), DevExpress.XtraEditors.TextEdit)
        Dim text_LOAIHOSO As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_LOAIHOSO"), DevExpress.XtraEditors.TextEdit)
        Dim combo_LOAIDOITUONG As DevExpress.XtraEditors.LookUpEdit = CType(Lay.Controls("combo_LOAIDOITUONG"), DevExpress.XtraEditors.LookUpEdit)
        Dim text_NGAYLAP As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_NGAYLAP"), DevExpress.XtraEditors.TextEdit)
        Dim text_NGAYDANGKY As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_NGAYDANGKY"), DevExpress.XtraEditors.TextEdit)
        Dim text_SOLUUTRU As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_SOLUUTRU"), DevExpress.XtraEditors.TextEdit)
        Dim text_NGAYNOPLUU As DevExpress.XtraEditors.DateEdit = CType(Lay.Controls("txt_NGAYNOPLUU"), DevExpress.XtraEditors.DateEdit)
        Dim text_NGAYKETTHUC As DevExpress.XtraEditors.DateEdit = CType(Lay.Controls("txt_NGAYKETTHUC"), DevExpress.XtraEditors.DateEdit)
        Dim text_LYDOKETTHUC As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_LYDOKETTHUC"), DevExpress.XtraEditors.TextEdit)
        Dim text_CANBOLAPHOSO As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_CANBOLAPHOSO"), DevExpress.XtraEditors.TextEdit)
        Dim text_DOILAPHOSO As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_DOILAPHOSO"), DevExpress.XtraEditors.TextEdit)
        Dim text_DONVILAPHOSO As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_DONVILAPHOSO"), DevExpress.XtraEditors.TextEdit)
        Dim text_DIAPHUONGLAPHOSO As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_DIAPHUONGLAPHOSO"), DevExpress.XtraEditors.TextEdit)
        Dim text_LUCLUONGLAPHOSO As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_LUCLUONGLAPHOSO"), DevExpress.XtraEditors.TextEdit)
        Dim text_THUTRUONGDONVI As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_THUTRUONGDONVI"), DevExpress.XtraEditors.TextEdit)
        Dim spr() As SqlParameter = {
             New SqlParameter("@soHoSo", combo_SOHOSO.GetColumnValue(combo_SOHOSO.Properties.Columns(0))),
             New SqlParameter("@soThe", combo_SOTHE.GetColumnValue(combo_SOTHE.Properties.Columns(0))),
             New SqlParameter("@soDanhBan", text_SODANHBAN.Text),
             New SqlParameter("@ngayLapDanhBan", text_NGAYLAPDANHBAN.DateTime),
             New SqlParameter("@donViLapDanhBan", text_DONVILAP.Text),
             New SqlParameter("@diaPhuongLapDanhBan", text_DIAPHUONGLAP.Text),
             New SqlParameter("@maLoaiDoiTuong", combo_LOAIDOITUONG.GetColumnValue(combo_LOAIDOITUONG.Properties.Columns(0))),
             New SqlParameter("@DMLoaiST", combo_DANHMUCLOAIST.GetColumnValue(combo_DANHMUCLOAIST.Properties.Columns(0))),
             New SqlParameter("@DMHeST", combo_DANHMUCHEST.GetColumnValue(combo_DANHMUCHEST.Properties.Columns(0))),
             New SqlParameter("@doiTuongSTLoai", combo_DOITUONGSTLOAI.GetColumnValue(combo_DOITUONGSTLOAI.Properties.Columns(0))),
             New SqlParameter("@soLuuTru", text_SOLUUTRU.Text),
             New SqlParameter("@ngayNopLuu", text_NGAYNOPLUU.DateTime),
             New SqlParameter("@ngayKetThuc", text_NGAYKETTHUC.DateTime),
             New SqlParameter("@lyDoKetThuc", text_LYDOKETTHUC.Text)
            }
        HOSODOITUONG.Update(spr)
    End Sub

End Class
