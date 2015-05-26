Imports System.Data.SqlClient
Public Class nv_GROUP
    Private GROUP As pd_GROUP
    Private frm_GROUP As Form

    Public Sub New(ByRef f As Form)
        GROUP = New pd_GROUP
        Me.frm_GROUP = f
    End Sub
    Public Sub HIENTHI()
        Dim LAY As DevExpress.XtraLayout.LayoutControl = CType(frm_GROUP.Controls("lay_GROUP"), DevExpress.XtraLayout.LayoutControl)
        Dim GRD As DevExpress.XtraGrid.GridControl = CType(LAY.Controls("grd_GROUP"), DevExpress.XtraGrid.GridControl)
        Dim spr() As SqlParameter = {New SqlParameter("@ID_Group", DBNull.Value)}
        Dim text_IDGROUP As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_IDGROUP"), DevExpress.XtraEditors.TextEdit)
        Dim text_TENGROUP As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_TENGROUP"), DevExpress.XtraEditors.TextEdit)
        GRD.DataSource = Me.GROUP.getTable(spr)
        text_IDGROUP.DataBindings.Clear()
        text_IDGROUP.DataBindings.Add("Text", GRD.DataSource, "ID_GROUP")
        text_TENGROUP.DataBindings.Clear()
        text_TENGROUP.DataBindings.Add("Text", GRD.DataSource, "tenGROUP")


    End Sub

    Public Sub ADD()
        Dim Lay As DevExpress.XtraLayout.LayoutControl = CType(frm_GROUP.Controls("lay_GROUP"), DevExpress.XtraLayout.LayoutControl)
        Dim text_TENGROUP As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_TENGROUP"), DevExpress.XtraEditors.TextEdit)
        Dim spr() As SqlParameter = {
            New SqlParameter("@TenGroup", text_TENGROUP.Text)
        }
        GROUP.Add(spr)
    End Sub
    Public Sub UPDATETRENTEXTBOX()
        Dim Lay As DevExpress.XtraLayout.LayoutControl = CType(frm_GROUP.Controls("lay_GROUP"), DevExpress.XtraLayout.LayoutControl)
        Dim text_IDGROUP As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_IDGROUP"), DevExpress.XtraEditors.TextEdit)
        Dim text_TENGROUP As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_TENGROUP"), DevExpress.XtraEditors.TextEdit)
        Dim spr() As SqlParameter = {
            New SqlParameter("@ID_Group", text_IDGROUP.Text),
            New SqlParameter("@tenGROUP", text_TENGROUP.Text)
        }
        GROUP.Update(spr)

    End Sub
    Public Sub DELETETRENTEXTBOX()
        Dim Lay As DevExpress.XtraLayout.LayoutControl = CType(frm_GROUP.Controls("lay_GROUP"), DevExpress.XtraLayout.LayoutControl)
        Dim text_TENGROUP As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_TENGROUP"), DevExpress.XtraEditors.TextEdit)
        Dim spr() As SqlParameter = {New SqlParameter("@TenGroup", text_TENGROUP.Text)}
        GROUP.Delete(spr)



    End Sub
End Class
