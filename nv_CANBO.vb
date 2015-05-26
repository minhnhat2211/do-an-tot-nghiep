Imports System.Data.SqlClient

Public Class nv_CANBO
    Private CANBO As pd_CANBO
    Private frm_CANBO As Form
    Public Sub New(ByRef f As Form)
        CANBO = New pd_CANBO
        Me.frm_CANBO = f
    End Sub
    Public Sub HIENTHI()
        Dim LAY As DevExpress.XtraLayout.LayoutControl = CType(frm_CANBO.Controls("lay_CANBO"), DevExpress.XtraLayout.LayoutControl)
        Dim GRD As DevExpress.XtraGrid.GridControl = CType(LAY.Controls("grd_CANBO"), DevExpress.XtraGrid.GridControl)
        Dim text_MACANBO As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_MACANBO"), DevExpress.XtraEditors.TextEdit)
        Dim text_HODEM As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_HODEM"), DevExpress.XtraEditors.TextEdit)
        Dim text_TEN As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_TEN"), DevExpress.XtraEditors.TextEdit)
        Dim text_NGAYSINH As DevExpress.XtraEditors.DateEdit = CType(LAY.Controls("txt_NGAYSINH"), DevExpress.XtraEditors.DateEdit)
        Dim text_DIACHI As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_DIACHI"), DevExpress.XtraEditors.TextEdit)
        Dim text_DIENTHOAI As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_DIENTHOAI"), DevExpress.XtraEditors.TextEdit)
        Dim combo_MADOI As DevExpress.XtraEditors.LookUpEdit = CType(LAY.Controls("combo_MADOI"), DevExpress.XtraEditors.LookUpEdit)
        Dim text_CHUCVU As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_CHUCVU"), DevExpress.XtraEditors.TextEdit)


        Dim spr() As SqlParameter = {New SqlParameter("@maCANBO", DBNull.Value)}
        Dim spr_madoi() As SqlParameter = {New SqlParameter("@maDoi", DBNull.Value)}

        Dim tb As DataTable = Me.CANBO.getTable(spr)

        combo_MADOI.Properties.DataSource = Me.CANBO.getMaDoi(spr_madoi)
        combo_MADOI.Properties.DisplayMember = "tenDoi"
        combo_MADOI.Properties.ValueMember = "maDoi"
       

        text_MACANBO.DataBindings.Clear()
        text_MACANBO.DataBindings.Add("Text", tb, "maCANBO")
        text_HODEM.DataBindings.Clear()
        text_HODEM.DataBindings.Add("Text", tb, "HODEM")

        text_TEN.DataBindings.Clear()
        text_TEN.DataBindings.Add("Text", tb, "ten")
        text_NGAYSINH.DataBindings.Clear()
        text_NGAYSINH.DataBindings.Add("Text", tb, "ngaySinh")

        text_DIACHI.DataBindings.Clear()
        text_DIACHI.DataBindings.Add("Text", tb, "diaChi")
        text_DIENTHOAI.DataBindings.Clear()
        text_DIENTHOAI.DataBindings.Add("Text", tb, "dienThoai")

        text_CHUCVU.DataBindings.Clear()
        text_CHUCVU.DataBindings.Add("Text", tb, "chucVu")
        combo_MADOI.DataBindings.Clear()
        combo_MADOI.DataBindings.Add("EditValue", tb, "maDoi")

        
        GRD.DataSource = tb


    End Sub
    Public Sub ADD()
        Dim Lay As DevExpress.XtraLayout.LayoutControl = CType(frm_CANBO.Controls("lay_CANBO"), DevExpress.XtraLayout.LayoutControl)
        Dim text_MACANBO As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_MACANBO"), DevExpress.XtraEditors.TextEdit)
        Dim text_HODEM As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_HODEM"), DevExpress.XtraEditors.TextEdit)
        Dim text_TEN As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_TEN"), DevExpress.XtraEditors.TextEdit)
        Dim text_NGAYSINH As DevExpress.XtraEditors.DateEdit = CType(Lay.Controls("txt_NGAYSINH"), DevExpress.XtraEditors.DateEdit)
        Dim text_DIACHI As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_DIACHI"), DevExpress.XtraEditors.TextEdit)
        Dim text_DIENTHOAI As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_DIENTHOAI"), DevExpress.XtraEditors.TextEdit)
        Dim combo_MADOI As DevExpress.XtraEditors.LookUpEdit = CType(Lay.Controls("combo_MADOI"), DevExpress.XtraEditors.LookUpEdit)
        Dim text_CHUCVU As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_CHUCVU"), DevExpress.XtraEditors.TextEdit)
        Dim spr() As SqlParameter = {
            New SqlParameter("@maCANBO", text_MACANBO.Text),
            New SqlParameter("@HODEM", text_HODEM.Text),
            New SqlParameter("@ten", text_TEN.Text),
            New SqlParameter("@ngaySinh", text_NGAYSINH.Text),
            New SqlParameter("@diaChi", text_DIACHI.Text),
            New SqlParameter("@dienThoai", text_DIENTHOAI.Text),
            New SqlParameter("@maDoi", combo_MADOI.GetColumnValue(combo_MADOI.Properties.Columns(0))),
            New SqlParameter("@chucVu", text_CHUCVU.Text)
        }
        CANBO.Add(spr)
    End Sub
    Public Sub UPDATETRENTEXTBOX()
        Dim Lay As DevExpress.XtraLayout.LayoutControl = CType(frm_CANBO.Controls("lay_CANBO"), DevExpress.XtraLayout.LayoutControl)
        Dim text_MACANBO As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_MACANBO"), DevExpress.XtraEditors.TextEdit)
        Dim text_HODEM As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_HODEM"), DevExpress.XtraEditors.TextEdit)
        Dim text_TEN As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_TEN"), DevExpress.XtraEditors.TextEdit)
        Dim text_NGAYSINH As DevExpress.XtraEditors.DateEdit = CType(Lay.Controls("txt_NGAYSINH"), DevExpress.XtraEditors.DateEdit)
        Dim text_DIACHI As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_DIACHI"), DevExpress.XtraEditors.TextEdit)
        Dim text_DIENTHOAI As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_DIENTHOAI"), DevExpress.XtraEditors.TextEdit)
        Dim combo_MADOI As DevExpress.XtraEditors.LookUpEdit = CType(Lay.Controls("combo_MADOI"), DevExpress.XtraEditors.LookUpEdit)
        Dim text_CHUCVU As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_CHUCVU"), DevExpress.XtraEditors.TextEdit)
        Dim spr() As SqlParameter = {
             New SqlParameter("@maCANBO", text_MACANBO.Text),
             New SqlParameter("@HODEM", text_HODEM.Text),
             New SqlParameter("@ten", text_TEN.Text),
             New SqlParameter("@ngaySinh", text_NGAYSINH.Text),
             New SqlParameter("@diaChi", text_DIACHI.Text),
             New SqlParameter("@dienThoai", text_DIENTHOAI.Text),
             New SqlParameter("@maDoi", combo_MADOI.GetColumnValue(combo_MADOI.Properties.Columns(0))),
             New SqlParameter("@chucVu", text_CHUCVU.Text)
         }
        CANBO.Update(spr)

    End Sub
    Public Sub DELETETRENTEXTBOX()
        Dim Lay As DevExpress.XtraLayout.LayoutControl = CType(frm_CANBO.Controls("lay_CANBO"), DevExpress.XtraLayout.LayoutControl)
        Dim text_MACANBO As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_MACANBO"), DevExpress.XtraEditors.TextEdit)
        Dim spr() As SqlParameter = {New SqlParameter("@maCANBO", text_MACANBO.Text)}
        CANBO.Delete(spr)


    End Sub
End Class

