Imports System.Data.SqlClient
Public Class nv_CHITIETDIENBIEN
    Private DT As pd_CHITIETDIENBIEN
    Private frm_CHITIETDIENBIEN As Form
    Public Sub New(ByRef f As Form)
        DT = New pd_CHITIETDIENBIEN
        Me.frm_CHITIETDIENBIEN = f
    End Sub
    Public Sub HIENTHI()
        Dim LAY As DevExpress.XtraLayout.LayoutControl = CType(frm_CHITIETDIENBIEN.Controls("lay_CHITIETDIENBIEN"), DevExpress.XtraLayout.LayoutControl)
        Dim GRD As DevExpress.XtraGrid.GridControl = CType(LAY.Controls("grd_CHITIETDIENBIEN"), DevExpress.XtraGrid.GridControl)
        Dim spr() As SqlParameter = {New SqlParameter("@madienbien", DBNull.Value)}
        Dim text_MADIENBIEN As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_MADIENBIEN"), DevExpress.XtraEditors.TextEdit)
        Dim text_THOIGIAN As DevExpress.XtraEditors.DateEdit = CType(LAY.Controls("txt_THOIGIAN"), DevExpress.XtraEditors.DateEdit)
        Dim text_DIENBIEN As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_DIENBIEN"), DevExpress.XtraEditors.TextEdit)
        GRD.DataSource = Me.DT.getTable(spr)
        text_MADIENBIEN.DataBindings.Clear()

        text_MADIENBIEN.DataBindings.Add("Text", GRD.DataSource, "madienbien")
        text_THOIGIAN.DataBindings.Clear()
        text_THOIGIAN.DataBindings.Add("Text", GRD.DataSource, "thoigian")
        text_DIENBIEN.DataBindings.Clear()
        text_DIENBIEN.DataBindings.Add("Text", GRD.DataSource, "dienbien")

    End Sub
    Public Sub ADD()
        Dim Lay As DevExpress.XtraLayout.LayoutControl = CType(frm_CHITIETDIENBIEN.Controls("lay_CHITIETDIENBIEN"), DevExpress.XtraLayout.LayoutControl)
        Dim text_MADIENBIEN As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_MADIENBIEN"), DevExpress.XtraEditors.TextEdit)
        Dim text_THOIGIAN As DevExpress.XtraEditors.DateEdit = CType(Lay.Controls("txt_THOIGIAN"), DevExpress.XtraEditors.DateEdit)
        Dim text_DIENBIEN As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_DIENBIEN"), DevExpress.XtraEditors.TextEdit)
        Dim spr() As SqlParameter = {
            New SqlParameter("@madienbien", text_MADIENBIEN.Text),
            New SqlParameter("@thoigian", text_THOIGIAN.DateTime),
             New SqlParameter("@dienbien", text_DIENBIEN.Text)
        }
        DT.Add(spr)
    End Sub
    Public Sub UPDATETRENTEXTBOX()
        Dim Lay As DevExpress.XtraLayout.LayoutControl = CType(frm_CHITIETDIENBIEN.Controls("lay_CHITIETDIENBIEN"), DevExpress.XtraLayout.LayoutControl)
        Dim text_MADIENBIEN As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_MADIENBIEN"), DevExpress.XtraEditors.TextEdit)
        Dim text_THOIGIAN As DevExpress.XtraEditors.DateEdit = CType(Lay.Controls("txt_THOIGIAN"), DevExpress.XtraEditors.DateEdit)
        Dim text_DIENBIEN As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_DIENBIEN"), DevExpress.XtraEditors.TextEdit)
        Dim spr() As SqlParameter = {
            New SqlParameter("@madienbien", text_MADIENBIEN.Text),
            New SqlParameter("@thoigian", text_THOIGIAN.DateTime),
             New SqlParameter("@dienbien", text_DIENBIEN.Text)
        }
        DT.Update(spr)

    End Sub
    Public Sub DELETETRENTEXTBOX()
        Dim Lay As DevExpress.XtraLayout.LayoutControl = CType(frm_CHITIETDIENBIEN.Controls("lay_CHITIETDIENBIEN"), DevExpress.XtraLayout.LayoutControl)
        Dim text_MADIENBIEN As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_MADIENBIEN"), DevExpress.XtraEditors.TextEdit)
        Dim spr() As SqlParameter = {
           New SqlParameter("@madienbien", text_MADIENBIEN.Text)
       }
        DT.Delete(spr)


    End Sub
End Class
