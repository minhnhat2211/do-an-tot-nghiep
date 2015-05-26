Imports System.Data.SqlClient
Public Class nv_DMLOAIST
    Private DMLOAIST As pd_DMLOAIST
    Private frm_DMLOAIST As Form

    Public Sub New(ByRef f As Form)
        DMLOAIST = New pd_DMLOAIST
        Me.frm_DMLOAIST = f
    End Sub
    Public Sub HIENTHI()
        Dim LAY As DevExpress.XtraLayout.LayoutControl = CType(frm_DMLOAIST.Controls("lay_DMLOAIST"), DevExpress.XtraLayout.LayoutControl)
        Dim GRD As DevExpress.XtraGrid.GridControl = CType(LAY.Controls("grd_DMLOAIST"), DevExpress.XtraGrid.GridControl)
        Dim spr() As SqlParameter = {New SqlParameter("@DMLOAIST", DBNull.Value)}
        Dim text_DMLOAIST As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_DMLOAIST"), DevExpress.XtraEditors.TextEdit)
        Dim text_TENLOAIST As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_TENLOAIST"), DevExpress.XtraEditors.TextEdit)
        GRD.DataSource = Me.DMLOAIST.getTable(spr)
        text_DMLOAIST.DataBindings.Clear()
        text_DMLOAIST.DataBindings.Add("Text", GRD.DataSource, "DMLOAIST")
        text_TENLOAIST.DataBindings.Clear()
        text_TENLOAIST.DataBindings.Add("Text", GRD.DataSource, "tenLoaiST")


    End Sub

    Public Sub ADD()
        Dim Lay As DevExpress.XtraLayout.LayoutControl = CType(frm_DMLOAIST.Controls("lay_DMLOAIST"), DevExpress.XtraLayout.LayoutControl)
        Dim text_TENLOAIST As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_TENLOAIST"), DevExpress.XtraEditors.TextEdit)
        Dim spr() As SqlParameter = {
            New SqlParameter("@tenLoaiST", text_TENLOAIST.Text)
        }
        DMLOAIST.Add(spr)
    End Sub
    Public Sub UPDATETRENTEXTBOX()
        Dim Lay As DevExpress.XtraLayout.LayoutControl = CType(frm_DMLOAIST.Controls("lay_DMLOAIST"), DevExpress.XtraLayout.LayoutControl)
        Dim text_DMLOAIST As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_DMLOAIST"), DevExpress.XtraEditors.TextEdit)
        Dim text_TENLOAIST As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_TENLOAIST"), DevExpress.XtraEditors.TextEdit)
        Dim spr() As SqlParameter = {
            New SqlParameter("@DMLOAIST", text_DMLOAIST.Text),
            New SqlParameter("@tenLoaiST", text_TENLOAIST.Text)
        }
        DMLOAIST.Update(spr)

    End Sub
    Public Sub DELETETRENTEXTBOX()
        Dim Lay As DevExpress.XtraLayout.LayoutControl = CType(frm_DMLOAIST.Controls("lay_DMLOAIST"), DevExpress.XtraLayout.LayoutControl)
        Dim text_TENLOAIST As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_TENLOAIST"), DevExpress.XtraEditors.TextEdit)
        Dim spr() As SqlParameter = {New SqlParameter("@tenLoaiST", text_TENLOAIST.Text)}
        DMLOAIST.Delete(spr)



    End Sub
End Class
