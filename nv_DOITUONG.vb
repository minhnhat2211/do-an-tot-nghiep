Imports System.Data.SqlClient
Public Class nv_DOITUONG
    Private DOITUONG As pd_DOITUONG
    Private frm_DOITUONG As Form

    Public Sub New(ByRef f As Form)
        DOITUONG = New pd_DOITUONG
        Me.frm_DOITUONG = f
    End Sub
    Public Sub HIENTHI()
        Dim LAY As DevExpress.XtraLayout.LayoutControl = CType(frm_DOITUONG.Controls("lay_DOITUONG"), DevExpress.XtraLayout.LayoutControl)
        Dim GRD As DevExpress.XtraGrid.GridControl = CType(LAY.Controls("grd_DOITUONG"), DevExpress.XtraGrid.GridControl)
        Dim combo_GIOITINH As DevExpress.XtraEditors.LookUpEdit = CType(LAY.Controls("combo_GIOITINH"), DevExpress.XtraEditors.LookUpEdit)
        Dim combo_DANTOC As DevExpress.XtraEditors.LookUpEdit = CType(LAY.Controls("combo_DANTOC"), DevExpress.XtraEditors.LookUpEdit)
        Dim combo_QUOCTICH As DevExpress.XtraEditors.LookUpEdit = CType(LAY.Controls("combo_QUOCTICH"), DevExpress.XtraEditors.LookUpEdit)
        Dim text_MATHE As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_MATHE"), DevExpress.XtraEditors.TextEdit)
        Dim text_HODEM As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_HODEM"), DevExpress.XtraEditors.TextEdit)
        Dim text_TEN As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_TEN"), DevExpress.XtraEditors.TextEdit)
        Dim text_TENKHAC As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_TENKHAC"), DevExpress.XtraEditors.TextEdit)
        Dim text_NGAY As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_NGAY"), DevExpress.XtraEditors.TextEdit)
        Dim text_THANG As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_THANG"), DevExpress.XtraEditors.TextEdit)
        Dim text_NAM As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_NAM"), DevExpress.XtraEditors.TextEdit)
        Dim text_NGUYENQUAN As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_NGUYENQUAN"), DevExpress.XtraEditors.TextEdit)
        Dim text_NOIDKHKTT As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_NOIDKHKTT"), DevExpress.XtraEditors.TextEdit)
        Dim text_CHOOHIENNAY As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_CHOOHIENNAY"), DevExpress.XtraEditors.TextEdit)
        Dim text_NOIOKHAC As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_NOIOKHAC"), DevExpress.XtraEditors.TextEdit)
        Dim text_HOTENCHA As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_HOTENCHA"), DevExpress.XtraEditors.TextEdit)
        Dim text_HOTENME As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_HOTENME"), DevExpress.XtraEditors.TextEdit)
        Dim text_HOTENVOCHONG As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_HOTENVOCHONG"), DevExpress.XtraEditors.TextEdit)
        Dim text_TRINHDOHOCVAN As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_TRINHDOHOCVAN"), DevExpress.XtraEditors.TextEdit)
        Dim text_NGHENGHIEP As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_NGHENGHIEP"), DevExpress.XtraEditors.TextEdit)
        Dim text_CHUCVU As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_CHUCVU"), DevExpress.XtraEditors.TextEdit)
        Dim text_NOILAMVIEC As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_NOILAMVIEC"), DevExpress.XtraEditors.TextEdit)

        Dim spr() As SqlParameter = {
            New SqlParameter("@soThe", DBNull.Value)
        }
        Dim spr_gioitinh() As SqlParameter = {
            New SqlParameter("@gioiTinh", DBNull.Value)
        }
        Dim spr_dantoc() As SqlParameter = {
            New SqlParameter("@maDanToc", DBNull.Value)
        }
        Dim spr_quoctich() As SqlParameter = {
          New SqlParameter("@maQuocTich", DBNull.Value)
      }

        combo_GIOITINH.Properties.DataSource = Me.DOITUONG.getGioiTinh(spr_gioitinh)
        combo_GIOITINH.Properties.DisplayMember = "loaiGioiTinh"
        combo_GIOITINH.Properties.ValueMember = "gioiTinh"
        combo_DANTOC.Properties.DataSource = Me.DOITUONG.getMaDanToc(spr_dantoc)
        combo_DANTOC.Properties.DisplayMember = "tenDanToc"
        combo_DANTOC.Properties.ValueMember = "maDanToc"
        combo_QUOCTICH.Properties.DataSource = Me.DOITUONG.getMaQuocTich(spr_quoctich)
        combo_QUOCTICH.Properties.DisplayMember = "tenQuocTich"
        combo_QUOCTICH.Properties.ValueMember = "maQuocTich"


        GRD.DataSource = Me.DOITUONG.getTable(spr)

        combo_GIOITINH.DataBindings.Clear()
        combo_GIOITINH.DataBindings.Add("EditValue", GRD.DataSource, "gioiTinh")
        combo_DANTOC.DataBindings.Clear()
        combo_DANTOC.DataBindings.Add("EditValue", GRD.DataSource, "maDanToc")
        combo_QUOCTICH.DataBindings.Clear()
        combo_QUOCTICH.DataBindings.Add("EditValue", GRD.DataSource, "maQuocTich")
        text_MATHE.DataBindings.Clear()
        text_MATHE.DataBindings.Add("Text", GRD.DataSource, "soThe")
        text_HODEM.DataBindings.Clear()
        text_HODEM.DataBindings.Add("Text", GRD.DataSource, "hoDem")
        text_TEN.DataBindings.Clear()
        text_TEN.DataBindings.Add("Text", GRD.DataSource, "ten")
        text_TENKHAC.DataBindings.Clear()
        text_TENKHAC.DataBindings.Add("Text", GRD.DataSource, "tenKhac")
        text_NGAY.DataBindings.Clear()
        text_NGAY.DataBindings.Add("Text", GRD.DataSource, "namSinh")
        text_NGUYENQUAN.DataBindings.Clear()
        text_NGUYENQUAN.DataBindings.Add("Text", GRD.DataSource, "nguyenQuan")
        text_NOIDKHKTT.DataBindings.Clear()
        text_NOIDKHKTT.DataBindings.Add("Text", GRD.DataSource, "noiDKHKTT")
        text_CHOOHIENNAY.DataBindings.Clear()
        text_CHOOHIENNAY.DataBindings.Add("Text", GRD.DataSource, "choOHienNay")
        text_NOIOKHAC.DataBindings.Clear()
        text_NOIOKHAC.DataBindings.Add("Text", GRD.DataSource, "noiOKhac")
        text_HOTENCHA.DataBindings.Clear()
        text_HOTENCHA.DataBindings.Add("Text", GRD.DataSource, "hoTenCha")
        text_HOTENME.DataBindings.Clear()
        text_HOTENME.DataBindings.Add("Text", GRD.DataSource, "hoTenMe")
        text_HOTENVOCHONG.DataBindings.Clear()
        text_HOTENVOCHONG.DataBindings.Add("Text", GRD.DataSource, "hoTenVC")
        text_TRINHDOHOCVAN.DataBindings.Clear()
        text_TRINHDOHOCVAN.DataBindings.Add("Text", GRD.DataSource, "trinhDoHocVan")
        text_NGHENGHIEP.DataBindings.Clear()
        text_NGHENGHIEP.DataBindings.Add("Text", GRD.DataSource, "ngheNghiep")
        text_CHUCVU.DataBindings.Clear()
        text_CHUCVU.DataBindings.Add("Text", GRD.DataSource, "chucVu")
        text_NOILAMVIEC.DataBindings.Clear()
        text_NOILAMVIEC.DataBindings.Add("Text", GRD.DataSource, "noiLamViec")


    End Sub

    Public Sub ADD()
        Dim LAY As DevExpress.XtraLayout.LayoutControl = CType(frm_DOITUONG.Controls("lay_DOITUONG"), DevExpress.XtraLayout.LayoutControl)
        Dim combo_GIOITINH As DevExpress.XtraEditors.LookUpEdit = CType(LAY.Controls("combo_GIOITINH"), DevExpress.XtraEditors.LookUpEdit)
        Dim combo_DANTOC As DevExpress.XtraEditors.LookUpEdit = CType(LAY.Controls("combo_DANTOC"), DevExpress.XtraEditors.LookUpEdit)
        Dim combo_QUOCTICH As DevExpress.XtraEditors.LookUpEdit = CType(LAY.Controls("combo_QUOCTICH"), DevExpress.XtraEditors.LookUpEdit)
        Dim text_MATHE As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_MATHE"), DevExpress.XtraEditors.TextEdit)
        Dim text_HODEM As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_HODEM"), DevExpress.XtraEditors.TextEdit)
        Dim text_TEN As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_TEN"), DevExpress.XtraEditors.TextEdit)
        Dim text_TENKHAC As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_TENKHAC"), DevExpress.XtraEditors.TextEdit)
        Dim text_NGAY As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_NGAY"), DevExpress.XtraEditors.TextEdit)
        Dim text_THANG As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_THANG"), DevExpress.XtraEditors.TextEdit)
        Dim text_NAM As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_NAM"), DevExpress.XtraEditors.TextEdit)
        Dim text_NGUYENQUAN As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_NGUYENQUAN"), DevExpress.XtraEditors.TextEdit)
        Dim text_NOIDKHKTT As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_NOIDKHKTT"), DevExpress.XtraEditors.TextEdit)
        Dim text_CHOOHIENNAY As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_CHOOHIENNAY"), DevExpress.XtraEditors.TextEdit)
        Dim text_NOIOKHAC As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_NOIOKHAC"), DevExpress.XtraEditors.TextEdit)
        Dim text_HOTENCHA As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_HOTENCHA"), DevExpress.XtraEditors.TextEdit)
        Dim text_HOTENME As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_HOTENME"), DevExpress.XtraEditors.TextEdit)
        Dim text_HOTENVOCHONG As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_HOTENVOCHONG"), DevExpress.XtraEditors.TextEdit)
        Dim text_TRINHDOHOCVAN As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_TRINHDOHOCVAN"), DevExpress.XtraEditors.TextEdit)
        Dim text_NGHENGHIEP As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_NGHENGHIEP"), DevExpress.XtraEditors.TextEdit)
        Dim text_CHUCVU As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_CHUCVU"), DevExpress.XtraEditors.TextEdit)
        Dim text_NOILAMVIEC As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_NOILAMVIEC"), DevExpress.XtraEditors.TextEdit)

        Dim spr() As SqlParameter = {
            New SqlParameter("@soThe", text_MATHE.Text),
            New SqlParameter("@hoDem", text_HODEM.Text),
            New SqlParameter("@ten", text_TEN.Text),
            New SqlParameter("@tenKhac", text_TENKHAC.Text),
            New SqlParameter("@namSinh", text_NGAY.Text + "/" + text_THANG.Text + "/" + text_NAM.Text),
            New SqlParameter("@gioiTinh", combo_GIOITINH.GetColumnValue(combo_GIOITINH.Properties.Columns(0))),
            New SqlParameter("@nguyenQuan", text_NGUYENQUAN.Text),
            New SqlParameter("@noiDKHKTT", text_NOIDKHKTT.Text),
            New SqlParameter("@choOHienNay", text_CHOOHIENNAY.Text),
            New SqlParameter("@noiOKhac", text_NOIOKHAC.Text),
            New SqlParameter("@hoTenCha", text_HOTENCHA.Text),
            New SqlParameter("@hoTenMe", text_HOTENME.Text),
            New SqlParameter("@hoTenVC", text_HOTENVOCHONG.Text),
            New SqlParameter("@maDanToc", combo_DANTOC.GetColumnValue(combo_DANTOC.Properties.Columns(0))),
            New SqlParameter("@maQuocTich", combo_QUOCTICH.GetColumnValue(combo_QUOCTICH.Properties.Columns(0))),
            New SqlParameter("@trinhDoHocVan", text_TRINHDOHOCVAN.Text),
            New SqlParameter("@ngheNghiep", text_NGHENGHIEP.Text),
            New SqlParameter("@chucVu", text_CHUCVU.Text),
            New SqlParameter("@noiLamViec", text_NOILAMVIEC.Text)
        }
        DOITUONG.Add(spr)
    End Sub
    Public Sub DELETETRENTEXTBOX()
        Dim Lay As DevExpress.XtraLayout.LayoutControl = CType(frm_DOITUONG.Controls("lay_DOITUONG"), DevExpress.XtraLayout.LayoutControl)
        Dim text_MATHE As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_MATHE"), DevExpress.XtraEditors.TextEdit)
        Dim spr() As SqlParameter = {New SqlParameter("@soThe", text_MATHE.Text)}
        DOITUONG.Delete(spr)
    End Sub
    Public Sub UPDATE()
        Dim LAY As DevExpress.XtraLayout.LayoutControl = CType(frm_DOITUONG.Controls("lay_DOITUONG"), DevExpress.XtraLayout.LayoutControl)
        Dim combo_GIOITINH As DevExpress.XtraEditors.LookUpEdit = CType(LAY.Controls("combo_GIOITINH"), DevExpress.XtraEditors.LookUpEdit)
        Dim combo_DANTOC As DevExpress.XtraEditors.LookUpEdit = CType(LAY.Controls("combo_DANTOC"), DevExpress.XtraEditors.LookUpEdit)
        Dim combo_QUOCTICH As DevExpress.XtraEditors.LookUpEdit = CType(LAY.Controls("combo_QUOCTICH"), DevExpress.XtraEditors.LookUpEdit)
        Dim text_MATHE As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_MATHE"), DevExpress.XtraEditors.TextEdit)
        Dim text_HODEM As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_HODEM"), DevExpress.XtraEditors.TextEdit)
        Dim text_TEN As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_TEN"), DevExpress.XtraEditors.TextEdit)
        Dim text_TENKHAC As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_TENKHAC"), DevExpress.XtraEditors.TextEdit)
        Dim text_NGAY As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_NGAY"), DevExpress.XtraEditors.TextEdit)
        Dim text_THANG As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_THANG"), DevExpress.XtraEditors.TextEdit)
        Dim text_NAM As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_NAM"), DevExpress.XtraEditors.TextEdit)
        Dim text_NGUYENQUAN As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_NGUYENQUAN"), DevExpress.XtraEditors.TextEdit)
        Dim text_NOIDKHKTT As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_NOIDKHKTT"), DevExpress.XtraEditors.TextEdit)
        Dim text_CHOOHIENNAY As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_CHOOHIENNAY"), DevExpress.XtraEditors.TextEdit)
        Dim text_NOIOKHAC As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_NOIOKHAC"), DevExpress.XtraEditors.TextEdit)
        Dim text_HOTENCHA As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_HOTENCHA"), DevExpress.XtraEditors.TextEdit)
        Dim text_HOTENME As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_HOTENME"), DevExpress.XtraEditors.TextEdit)
        Dim text_HOTENVOCHONG As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_HOTENVOCHONG"), DevExpress.XtraEditors.TextEdit)
        Dim text_TRINHDOHOCVAN As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_TRINHDOHOCVAN"), DevExpress.XtraEditors.TextEdit)
        Dim text_NGHENGHIEP As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_NGHENGHIEP"), DevExpress.XtraEditors.TextEdit)
        Dim text_CHUCVU As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_CHUCVU"), DevExpress.XtraEditors.TextEdit)
        Dim text_NOILAMVIEC As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_NOILAMVIEC"), DevExpress.XtraEditors.TextEdit)

        Dim spr() As SqlParameter = {
            New SqlParameter("@soThe", text_MATHE.Text),
            New SqlParameter("@hoDem", text_HODEM.Text),
            New SqlParameter("@ten", text_TEN.Text),
            New SqlParameter("@tenKhac", text_TENKHAC.Text),
            New SqlParameter("@namSinh", text_NGAY.Text + "/" + text_THANG.Text + "/" + text_NAM.Text),
            New SqlParameter("@gioiTinh", combo_GIOITINH.GetColumnValue(combo_GIOITINH.Properties.Columns(0))),
            New SqlParameter("@nguyenQuan", text_NGUYENQUAN.Text),
            New SqlParameter("@noiDKHKTT", text_NOIDKHKTT.Text),
            New SqlParameter("@choOHienNay", text_CHOOHIENNAY.Text),
            New SqlParameter("@noiOKhac", text_NOIOKHAC.Text),
            New SqlParameter("@hoTenCha", text_HOTENCHA.Text),
            New SqlParameter("@hoTenMe", text_HOTENME.Text),
            New SqlParameter("@hoTenVC", text_HOTENVOCHONG.Text),
            New SqlParameter("@maDanToc", combo_DANTOC.GetColumnValue(combo_DANTOC.Properties.Columns(0))),
            New SqlParameter("@maQuocTich", combo_QUOCTICH.GetColumnValue(combo_QUOCTICH.Properties.Columns(0))),
            New SqlParameter("@trinhDoHocVan", text_TRINHDOHOCVAN.Text),
            New SqlParameter("@ngheNghiep", text_NGHENGHIEP.Text),
            New SqlParameter("@chucVu", text_CHUCVU.Text),
            New SqlParameter("@noiLamViec", text_NOILAMVIEC.Text)
        }
        DOITUONG.Update(spr)
    End Sub
    
End Class
