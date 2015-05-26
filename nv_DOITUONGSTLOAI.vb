Imports System.Data.SqlClient
Public Class nv_DOITUONGSTLOAI
    Private DOITUONGSTLOAI As pd_DOITUONGSTLOAI
    Private frm_DOITUONGSTLOAI As Form

    Public Sub New(ByRef f As Form)
        doiTuongSTLoai = New pd_DOITUONGSTLOAI
        Me.frm_doiTuongSTLoai = f
    End Sub
    Public Sub HIENTHI()
        Dim LAY As DevExpress.XtraLayout.LayoutControl = CType(frm_doiTuongSTLoai.Controls("lay_DOITUONGSTLOAI"), DevExpress.XtraLayout.LayoutControl)
        Dim GRD As DevExpress.XtraGrid.GridControl = CType(LAY.Controls("grd_DOITUONGSTLOAI"), DevExpress.XtraGrid.GridControl)
        Dim spr() As SqlParameter = {New SqlParameter("@DOITUONGSTLOAI", DBNull.Value)}
        Dim text_DOITUONGSTLOAI As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_DOITUONGSTLOAI"), DevExpress.XtraEditors.TextEdit)
        Dim text_TENDOITUONG As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_TENDOITUONG"), DevExpress.XtraEditors.TextEdit)
        GRD.DataSource = Me.DOITUONGSTLOAI.getTable(spr)
        text_DOITUONGSTLOAI.DataBindings.Clear()
        text_DOITUONGSTLOAI.DataBindings.Add("Text", GRD.DataSource, "DOITUONGSTLOAI")
        text_TENDOITUONG.DataBindings.Clear()
        text_TENDOITUONG.DataBindings.Add("Text", GRD.DataSource, "tenDoiTuong")


    End Sub

    Public Sub ADD()
        Dim Lay As DevExpress.XtraLayout.LayoutControl = CType(frm_DOITUONGSTLOAI.Controls("lay_DOITUONGSTLOAI"), DevExpress.XtraLayout.LayoutControl)
        Dim text_TENDOITUONG As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_TENDOITUONG"), DevExpress.XtraEditors.TextEdit)
        Dim spr() As SqlParameter = {
            New SqlParameter("@tenDoiTuong", text_TENDOITUONG.Text)
        }
        DOITUONGSTLOAI.Add(spr)
    End Sub
    Public Sub UPDATETRENTEXTBOX()
        Dim Lay As DevExpress.XtraLayout.LayoutControl = CType(frm_DOITUONGSTLOAI.Controls("lay_DOITUONGSTLOAI"), DevExpress.XtraLayout.LayoutControl)
        Dim text_DOITUONGSTLOAI As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_DOITUONGSTLOAI"), DevExpress.XtraEditors.TextEdit)
        Dim text_TENDOITUONG As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_TENDOITUONG"), DevExpress.XtraEditors.TextEdit)
        Dim spr() As SqlParameter = {
            New SqlParameter("@DOITUONGSTLOAI", text_DOITUONGSTLOAI.Text),
            New SqlParameter("@tenDoiTuong", text_TENDOITUONG.Text)
        }
        DOITUONGSTLOAI.Update(spr)

    End Sub
    Public Sub DELETETRENTEXTBOX()
        Dim Lay As DevExpress.XtraLayout.LayoutControl = CType(frm_DOITUONGSTLOAI.Controls("lay_DOITUONGSTLOAI"), DevExpress.XtraLayout.LayoutControl)
        Dim text_TENDOITUONG As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_TENDOITUONG"), DevExpress.XtraEditors.TextEdit)
        Dim spr() As SqlParameter = {New SqlParameter("@tenDoiTuong", text_TENDOITUONG.Text)}
        DOITUONGSTLOAI.Delete(spr)



    End Sub
End Class
