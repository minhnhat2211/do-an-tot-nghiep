Imports System.Data.SqlClient
Public Class nv_DANTOC
    Private DT As pd_DANTOC
    Private frm_DT As Form

    Public Sub New(ByRef f As Form)
        DT = New pd_DANTOC
        Me.frm_DT = f
    End Sub
    Public Sub HIENTHI()
        Dim LAY As DevExpress.XtraLayout.LayoutControl = CType(frm_DT.Controls("lay_DANTOC"), DevExpress.XtraLayout.LayoutControl)
        Dim GRD As DevExpress.XtraGrid.GridControl = CType(LAY.Controls("grd_DANTOC"), DevExpress.XtraGrid.GridControl)
        Dim spr() As SqlParameter = {New SqlParameter("@madantoc", DBNull.Value)}
        Dim text_MADANTOC As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_MADANTOC"), DevExpress.XtraEditors.TextEdit)
        Dim text_TENDANTOC As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_TENDANTOC"), DevExpress.XtraEditors.TextEdit)
        GRD.DataSource = Me.DT.getTable(spr)
        text_MADANTOC.DataBindings.Clear()

        text_MADANTOC.DataBindings.Add("Text", GRD.DataSource, "madantoc")
        text_TENDANTOC.DataBindings.Clear()
        text_TENDANTOC.DataBindings.Add("Text", GRD.DataSource, "tendantoc")


    End Sub

    Public Sub ADD()
        Dim Lay As DevExpress.XtraLayout.LayoutControl = CType(frm_DT.Controls("lay_DANTOC"), DevExpress.XtraLayout.LayoutControl)
        Dim text_MADANTOC As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_MADANTOC"), DevExpress.XtraEditors.TextEdit)
        Dim text_TENDANTOC As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_TENDANTOC"), DevExpress.XtraEditors.TextEdit)
        Dim spr() As SqlParameter = {
            New SqlParameter("@madantoc", text_MADANTOC.Text),
            New SqlParameter("@tendantoc", text_TENDANTOC.Text)
        }
        DT.Add(spr)
    End Sub
    Public Sub UPDATETRENTEXTBOX()
        Dim Lay As DevExpress.XtraLayout.LayoutControl = CType(frm_DT.Controls("lay_DANTOC"), DevExpress.XtraLayout.LayoutControl)
        Dim text_MADANTOC As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_MADANTOC"), DevExpress.XtraEditors.TextEdit)
        Dim text_TENDANTOC As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_TENDANTOC"), DevExpress.XtraEditors.TextEdit)
        Dim spr() As SqlParameter = {
            New SqlParameter("@madantoc", text_MADANTOC.Text),
            New SqlParameter("@tendantoc", text_TENDANTOC.Text)
        }
        DT.Update(spr)

    End Sub
    Public Sub DELETETRENTEXTBOX()
        Dim Lay As DevExpress.XtraLayout.LayoutControl = CType(frm_DT.Controls("lay_DANTOC"), DevExpress.XtraLayout.LayoutControl)
        Dim text_MADANTOC As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_MADANTOC"), DevExpress.XtraEditors.TextEdit)
        Dim spr() As SqlParameter = {New SqlParameter("@madantoc", text_MADANTOC.Text)}
        DT.Delete(spr)


    End Sub
End Class
