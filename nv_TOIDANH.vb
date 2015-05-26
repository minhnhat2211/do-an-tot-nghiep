Imports System.Data.SqlClient
Public Class nv_TOIDANH
    Private TOIDANH As pd_TOIDANH
    Private frm_TOIDANH As Form

    Public Sub New(ByRef f As Form)
        TOIDANH = New pd_TOIDANH
        Me.frm_TOIDANH = f
    End Sub
    Public Sub HIENTHI()
        Dim LAY As DevExpress.XtraLayout.LayoutControl = CType(frm_TOIDANH.Controls("lay_TOIDANH"), DevExpress.XtraLayout.LayoutControl)
        Dim GRD As DevExpress.XtraGrid.GridControl = CType(LAY.Controls("grd_TOIDANH"), DevExpress.XtraGrid.GridControl)
        Dim spr() As SqlParameter = {New SqlParameter("@maTOIDANH", DBNull.Value)}
        Dim text_MATOIDANH As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_MATOIDANH"), DevExpress.XtraEditors.TextEdit)
        Dim text_TENTOIDANH As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_TENTOIDANH"), DevExpress.XtraEditors.TextEdit)
        GRD.DataSource = Me.TOIDANH.getTable(spr)
        text_MATOIDANH.DataBindings.Clear()

        text_MATOIDANH.DataBindings.Add("Text", GRD.DataSource, "maTOIDANH")
        text_TENTOIDANH.DataBindings.Clear()
        text_TENTOIDANH.DataBindings.Add("Text", GRD.DataSource, "TENTOIDANH")


    End Sub

    Public Sub ADD()
        Dim Lay As DevExpress.XtraLayout.LayoutControl = CType(frm_TOIDANH.Controls("lay_TOIDANH"), DevExpress.XtraLayout.LayoutControl)
        Dim text_MATOIDANH As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_MATOIDANH"), DevExpress.XtraEditors.TextEdit)
        Dim text_TENTOIDANH As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_TENTOIDANH"), DevExpress.XtraEditors.TextEdit)
        Dim spr() As SqlParameter = {
            New SqlParameter("@maTOIDANH", text_MATOIDANH.Text),
            New SqlParameter("@tenTOIDANH", text_TENTOIDANH.Text)
        }
        TOIDANH.Add(spr)
    End Sub
    Public Sub UPDATETRENTEXTBOX()
        Dim Lay As DevExpress.XtraLayout.LayoutControl = CType(frm_TOIDANH.Controls("lay_TOIDANH"), DevExpress.XtraLayout.LayoutControl)
        Dim text_MATOIDANH As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_maTOIDANH"), DevExpress.XtraEditors.TextEdit)
        Dim text_TENTOIDANH As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_tenTOIDANH"), DevExpress.XtraEditors.TextEdit)
        Dim spr() As SqlParameter = {
            New SqlParameter("@maTOIDANH", text_MATOIDANH.Text),
            New SqlParameter("@tenTOIDANH", text_TENTOIDANH.Text)
        }
        TOIDANH.Update(spr)

    End Sub
    Public Sub DELETETRENTEXTBOX()
        Dim Lay As DevExpress.XtraLayout.LayoutControl = CType(frm_TOIDANH.Controls("lay_TOIDANH"), DevExpress.XtraLayout.LayoutControl)
        Dim text_MATOIDANH As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_MATOIDANH"), DevExpress.XtraEditors.TextEdit)
        Dim spr() As SqlParameter = {New SqlParameter("@maTOIDANH", text_MATOIDANH.Text)}
        TOIDANH.Delete(spr)


    End Sub
End Class
