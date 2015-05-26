Imports System.Data.SqlClient
Public Class nv_DMHEST
    Private DMHEST As pd_DMHEST
    Private frm_DMHEST As Form

    Public Sub New(ByRef f As Form)
        DMHEST = New pd_DMHEST
        Me.frm_DMHEST = f
    End Sub
    Public Sub HIENTHI()
        Dim LAY As DevExpress.XtraLayout.LayoutControl = CType(frm_DMHEST.Controls("lay_DMHEST"), DevExpress.XtraLayout.LayoutControl)
        Dim GRD As DevExpress.XtraGrid.GridControl = CType(LAY.Controls("grd_DMHEST"), DevExpress.XtraGrid.GridControl)
        Dim spr() As SqlParameter = {New SqlParameter("@DMHEST", DBNull.Value)}
        Dim text_DMHEST As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_DMHEST"), DevExpress.XtraEditors.TextEdit)
        Dim text_TENHEST As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_TENHEST"), DevExpress.XtraEditors.TextEdit)
        GRD.DataSource = Me.DMHEST.getTable(spr)
        text_DMHEST.DataBindings.Clear()
        text_DMHEST.DataBindings.Add("Text", GRD.DataSource, "DMHEST")
        text_TENHEST.DataBindings.Clear()
        text_TENHEST.DataBindings.Add("Text", GRD.DataSource, "TenHeST")


    End Sub

    Public Sub ADD()
        Dim Lay As DevExpress.XtraLayout.LayoutControl = CType(frm_DMHEST.Controls("lay_DMHEST"), DevExpress.XtraLayout.LayoutControl)
        Dim text_TENHEST As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_TENHEST"), DevExpress.XtraEditors.TextEdit)
        Dim spr() As SqlParameter = {
            New SqlParameter("@TenHeST", text_TENHEST.Text)
        }
        DMHEST.Add(spr)
    End Sub
    Public Sub UPDATETRENTEXTBOX()
        Dim Lay As DevExpress.XtraLayout.LayoutControl = CType(frm_DMHEST.Controls("lay_DMHEST"), DevExpress.XtraLayout.LayoutControl)
        Dim text_DMHEST As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_DMHEST"), DevExpress.XtraEditors.TextEdit)
        Dim text_TENHEST As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_TENHEST"), DevExpress.XtraEditors.TextEdit)
        Dim spr() As SqlParameter = {
            New SqlParameter("@DMHEST", text_DMHEST.Text),
            New SqlParameter("@TenHeST", text_TENHEST.Text)
        }
        DMHEST.Update(spr)

    End Sub
    Public Sub DELETETRENTEXTBOX()
        Dim Lay As DevExpress.XtraLayout.LayoutControl = CType(frm_DMHEST.Controls("lay_DMHEST"), DevExpress.XtraLayout.LayoutControl)
        Dim text_TENHEST As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_TENHEST"), DevExpress.XtraEditors.TextEdit)
        Dim spr() As SqlParameter = {New SqlParameter("@TenHeST", text_TENHEST.Text)}
        DMHEST.Delete(spr)



    End Sub
End Class
