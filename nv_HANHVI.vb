Imports System.Data.SqlClient
Public Class nv_HANHVI
    Private HANHVI As pd_HANHVI
    Private frm_HANHVI As Form

    Public Sub New(ByRef f As Form)
        HANHVI = New pd_HANHVI
        Me.frm_HANHVI = f
    End Sub
    Public Sub HIENTHI()
        Dim LAY As DevExpress.XtraLayout.LayoutControl = CType(frm_HANHVI.Controls("lay_HANHVI"), DevExpress.XtraLayout.LayoutControl)
        Dim GRD As DevExpress.XtraGrid.GridControl = CType(LAY.Controls("grd_HANHVI"), DevExpress.XtraGrid.GridControl)
        Dim spr() As SqlParameter = {New SqlParameter("@mahanhvi", DBNull.Value)}
        Dim text_MAHANHVI As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_MAHANHVI"), DevExpress.XtraEditors.TextEdit)
        Dim text_HANHVI As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_HANHVI"), DevExpress.XtraEditors.TextEdit)
        GRD.DataSource = Me.HANHVI.getTable(spr)
        text_MAHANHVI.DataBindings.Clear()

        text_MAHANHVI.DataBindings.Add("Text", GRD.DataSource, "mahanhvi")
        text_HANHVI.DataBindings.Clear()
        text_HANHVI.DataBindings.Add("Text", GRD.DataSource, "hanhvi")


    End Sub

    Public Sub ADD()
        Dim Lay As DevExpress.XtraLayout.LayoutControl = CType(frm_HANHVI.Controls("lay_HANHVI"), DevExpress.XtraLayout.LayoutControl)
        Dim text_MAHANHVI As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_MAHANHVI"), DevExpress.XtraEditors.TextEdit)
        Dim text_HANHVI As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_HANHVI"), DevExpress.XtraEditors.TextEdit)
        Dim spr() As SqlParameter = {
            New SqlParameter("@mahanhvi", text_MAHANHVI.Text),
            New SqlParameter("@hanhvi", text_HANHVI.Text)
        }
        HANHVI.Add(spr)
    End Sub
    Public Sub UPDATETRENTEXTBOX()
        Dim Lay As DevExpress.XtraLayout.LayoutControl = CType(frm_HANHVI.Controls("lay_HANHVI"), DevExpress.XtraLayout.LayoutControl)
        Dim text_MAHANHVI As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_mahanhvi"), DevExpress.XtraEditors.TextEdit)
        Dim text_HANHVI As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_HANHVI"), DevExpress.XtraEditors.TextEdit)
        Dim spr() As SqlParameter = {
            New SqlParameter("@mahanhvi", text_MAHANHVI.Text),
            New SqlParameter("@hanhvi", text_HANHVI.Text)
        }
        HANHVI.Update(spr)

    End Sub
    Public Sub DELETETRENTEXTBOX()
        Dim Lay As DevExpress.XtraLayout.LayoutControl = CType(frm_HANHVI.Controls("lay_HANHVI"), DevExpress.XtraLayout.LayoutControl)
        Dim text_MAHANHVI As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_MAHANHVI"), DevExpress.XtraEditors.TextEdit)
        Dim spr() As SqlParameter = {New SqlParameter("@mahanhvi", text_MAHANHVI.Text)}
        HANHVI.Delete(spr)


    End Sub
End Class
