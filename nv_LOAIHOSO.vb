Imports System.Data.SqlClient
Public Class nv_LOAIHOSO
    Private LOAIHOSO As pd_LOAIHOSO
    Private frm_LOAIHOSO As Form

    Public Sub New(ByRef f As Form)
        LOAIHOSO = New pd_LOAIHOSO
        Me.frm_LOAIHOSO = f
    End Sub
    Public Sub HIENTHI()
        Dim LAY As DevExpress.XtraLayout.LayoutControl = CType(frm_LOAIHOSO.Controls("lay_LOAIHOSO"), DevExpress.XtraLayout.LayoutControl)
        Dim GRD As DevExpress.XtraGrid.GridControl = CType(LAY.Controls("grd_LOAIHOSO"), DevExpress.XtraGrid.GridControl)
        Dim spr() As SqlParameter = {New SqlParameter("@maloaihoso", DBNull.Value)}
        Dim text_MALOAIHOSO As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_MALOAIHOSO"), DevExpress.XtraEditors.TextEdit)
        Dim text_TENLOAIHOSO As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_TENLOAIHOSO"), DevExpress.XtraEditors.TextEdit)
        GRD.DataSource = Me.LOAIHOSO.getTable(spr)
        text_MALOAIHOSO.DataBindings.Clear()

        text_MALOAIHOSO.DataBindings.Add("Text", GRD.DataSource, "maloaihoso")
        text_TENLOAIHOSO.DataBindings.Clear()
        text_TENLOAIHOSO.DataBindings.Add("Text", GRD.DataSource, "tenloaihoso")


    End Sub

    Public Sub ADD()
        Dim Lay As DevExpress.XtraLayout.LayoutControl = CType(frm_LOAIHOSO.Controls("lay_LOAIHOSO"), DevExpress.XtraLayout.LayoutControl)
        Dim text_MALOAIHOSO As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_MALOAIHOSO"), DevExpress.XtraEditors.TextEdit)
        Dim text_TENLOAIHOSO As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_TENLOAIHOSO"), DevExpress.XtraEditors.TextEdit)
        Dim spr() As SqlParameter = {
            New SqlParameter("@maloaihoso", text_MALOAIHOSO.Text),
            New SqlParameter("@tenloaihoso", text_TENLOAIHOSO.Text)
        }
        LOAIHOSO.Add(spr)
    End Sub
    Public Sub UPDATETRENTEXTBOX()
        Dim Lay As DevExpress.XtraLayout.LayoutControl = CType(frm_LOAIHOSO.Controls("lay_LOAIHOSO"), DevExpress.XtraLayout.LayoutControl)
        Dim text_MALOAIHOSO As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_MALOAIHOSO"), DevExpress.XtraEditors.TextEdit)
        Dim text_TENLOAIHOSO As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_TENLOAIHOSO"), DevExpress.XtraEditors.TextEdit)
        Dim spr() As SqlParameter = {
            New SqlParameter("@maloaihoso", text_MALOAIHOSO.Text),
            New SqlParameter("@tenloaihoso", text_TENLOAIHOSO.Text)
        }
        LOAIHOSO.Update(spr)

    End Sub
    Public Sub DELETETRENTEXTBOX()
        Dim Lay As DevExpress.XtraLayout.LayoutControl = CType(frm_LOAIHOSO.Controls("lay_LOAIHOSO"), DevExpress.XtraLayout.LayoutControl)
        Dim text_MALOAIHOSO As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_MALOAIHOSO"), DevExpress.XtraEditors.TextEdit)
        Dim spr() As SqlParameter = {New SqlParameter("@maloaihoso", text_MALOAIHOSO.Text)}
        LOAIHOSO.Delete(spr)


    End Sub
End Class
