Imports System.Data.SqlClient
Public Class nv_QUOCTICH
    Private QUOCTICH As pd_QUOCTICH
    Private frm_QUOCTICH As Form

    Public Sub New(ByRef f As Form)
        QUOCTICH = New pd_QUOCTICH
        Me.frm_QUOCTICH = f
    End Sub
    Public Sub HIENTHI()
        Dim LAY As DevExpress.XtraLayout.LayoutControl = CType(frm_QUOCTICH.Controls("lay_QUOCTICH"), DevExpress.XtraLayout.LayoutControl)
        Dim GRD As DevExpress.XtraGrid.GridControl = CType(LAY.Controls("grd_QUOCTICH"), DevExpress.XtraGrid.GridControl)
        Dim spr() As SqlParameter = {New SqlParameter("@maQUOCTICH", DBNull.Value)}
        Dim text_MAQUOCTICH As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_MAQUOCTICH"), DevExpress.XtraEditors.TextEdit)
        Dim text_TENQUOCTICH As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_TENQUOCTICH"), DevExpress.XtraEditors.TextEdit)
        GRD.DataSource = Me.QUOCTICH.getTable(spr)
        text_MAQUOCTICH.DataBindings.Clear()

        text_MAQUOCTICH.DataBindings.Add("Text", GRD.DataSource, "maQUOCTICH")
        text_TENQUOCTICH.DataBindings.Clear()
        text_TENQUOCTICH.DataBindings.Add("Text", GRD.DataSource, "TENQUOCTICH")


    End Sub

    Public Sub ADD()
        Dim Lay As DevExpress.XtraLayout.LayoutControl = CType(frm_QUOCTICH.Controls("lay_QUOCTICH"), DevExpress.XtraLayout.LayoutControl)
        Dim text_MAQUOCTICH As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_MAQUOCTICH"), DevExpress.XtraEditors.TextEdit)
        Dim text_TENQUOCTICH As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_TENQUOCTICH"), DevExpress.XtraEditors.TextEdit)
        Dim spr() As SqlParameter = {
            New SqlParameter("@maQUOCTICH", text_MAQUOCTICH.Text),
            New SqlParameter("@tenQUOCTICH", text_TENQUOCTICH.Text)
        }
        QUOCTICH.Add(spr)
    End Sub
    Public Sub UPDATETRENTEXTBOX()
        Dim Lay As DevExpress.XtraLayout.LayoutControl = CType(frm_QUOCTICH.Controls("lay_QUOCTICH"), DevExpress.XtraLayout.LayoutControl)
        Dim text_MAQUOCTICH As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_maQUOCTICH"), DevExpress.XtraEditors.TextEdit)
        Dim text_TENQUOCTICH As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_tenQUOCTICH"), DevExpress.XtraEditors.TextEdit)
        Dim spr() As SqlParameter = {
            New SqlParameter("@maQUOCTICH", text_MAQUOCTICH.Text),
            New SqlParameter("@tenQUOCTICH", text_TENQUOCTICH.Text)
        }
        QUOCTICH.Update(spr)

    End Sub
    Public Sub DELETETRENTEXTBOX()
        Dim Lay As DevExpress.XtraLayout.LayoutControl = CType(frm_QUOCTICH.Controls("lay_QUOCTICH"), DevExpress.XtraLayout.LayoutControl)
        Dim text_MAQUOCTICH As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_MAQUOCTICH"), DevExpress.XtraEditors.TextEdit)
        Dim spr() As SqlParameter = {New SqlParameter("@maQUOCTICH", text_MAQUOCTICH.Text)}
        QUOCTICH.Delete(spr)


    End Sub
End Class
