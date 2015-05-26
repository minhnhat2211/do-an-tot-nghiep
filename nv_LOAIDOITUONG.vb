Imports System.Data.SqlClient
Public Class nv_LOAIDOITUONG
    Private LOAIDOITUONG As pd_LOAIDOITUONG
    Private frm_LOAIDOITUONG As Form

    Public Sub New(ByRef f As Form)
        LOAIDOITUONG = New pd_LOAIDOITUONG
        Me.frm_LOAIDOITUONG = f
    End Sub
    Public Sub HIENTHI()
        Dim LAY As DevExpress.XtraLayout.LayoutControl = CType(frm_LOAIDOITUONG.Controls("lay_LOAIDOITUONG"), DevExpress.XtraLayout.LayoutControl)
        Dim GRD As DevExpress.XtraGrid.GridControl = CType(LAY.Controls("grd_LOAIDOITUONG"), DevExpress.XtraGrid.GridControl)
        Dim spr() As SqlParameter = {New SqlParameter("@maLoaiDoiTuong", DBNull.Value)}
        Dim text_MALOAIDOITUONG As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_MALOAIDOITUONG"), DevExpress.XtraEditors.TextEdit)
        Dim text_TENLOAI As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_TENLOAI"), DevExpress.XtraEditors.TextEdit)
        GRD.DataSource = Me.LOAIDOITUONG.getTable(spr)
        text_MALOAIDOITUONG.DataBindings.Clear()
        text_MALOAIDOITUONG.DataBindings.Add("Text", GRD.DataSource, "maLoaiDoiTuong")
        text_TENLOAI.DataBindings.Clear()
        text_TENLOAI.DataBindings.Add("Text", GRD.DataSource, "tenLoai")


    End Sub

    Public Sub ADD()
        Dim Lay As DevExpress.XtraLayout.LayoutControl = CType(frm_LOAIDOITUONG.Controls("lay_LOAIDOITUONG"), DevExpress.XtraLayout.LayoutControl)
        Dim text_TENLOAI As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_TENLOAI"), DevExpress.XtraEditors.TextEdit)
        Dim spr() As SqlParameter = {
            New SqlParameter("@tenLoai", text_TENLOAI.Text)
        }
        LOAIDOITUONG.Add(spr)
    End Sub
    Public Sub UPDATETRENTEXTBOX()
        Dim Lay As DevExpress.XtraLayout.LayoutControl = CType(frm_LOAIDOITUONG.Controls("lay_LOAIDOITUONG"), DevExpress.XtraLayout.LayoutControl)
        Dim text_MALOAIDOITUONG As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_MALOAIDOITUONG"), DevExpress.XtraEditors.TextEdit)
        Dim text_TENLOAI As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_TENLOAI"), DevExpress.XtraEditors.TextEdit)
        Dim spr() As SqlParameter = {
            New SqlParameter("@maLoaiDoiTuong", text_MALOAIDOITUONG.Text),
            New SqlParameter("@tenLoai", text_TENLOAI.Text)
        }
        LOAIDOITUONG.Update(spr)

    End Sub
    Public Sub DELETETRENTEXTBOX()
        Dim Lay As DevExpress.XtraLayout.LayoutControl = CType(frm_LOAIDOITUONG.Controls("lay_LOAIDOITUONG"), DevExpress.XtraLayout.LayoutControl)
        Dim text_TENLOAI As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_TENLOAI"), DevExpress.XtraEditors.TextEdit)
        Dim spr() As SqlParameter = {New SqlParameter("@tenLoai", text_TENLOAI.Text)}
        LOAIDOITUONG.Delete(spr)



    End Sub
End Class
