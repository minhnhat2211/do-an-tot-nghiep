Imports System.Data.SqlClient
Public Class nv_DONVI
    Private DONVI As pd_DONVI
    Private frm_DONVI As Form
    Public Sub New(ByRef f As Form)
        DONVI = New pd_DONVI
        Me.frm_DONVI = f
    End Sub
    Public Sub HIENTHI()
        Dim LAY As DevExpress.XtraLayout.LayoutControl = CType(frm_DONVI.Controls("lay_DONVI"), DevExpress.XtraLayout.LayoutControl)
        Dim GRD As DevExpress.XtraGrid.GridControl = CType(LAY.Controls("grd_DONVI"), DevExpress.XtraGrid.GridControl)
        Dim spr() As SqlParameter = {New SqlParameter("@madonvi", DBNull.Value)}
        Dim text_MADONVI As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_madonvi"), DevExpress.XtraEditors.TextEdit)
        Dim text_TENDONVI As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_tendonvi"), DevExpress.XtraEditors.TextEdit)
        Dim text_DIAPHUONG As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_diaphuong"), DevExpress.XtraEditors.TextEdit)
        Dim text_THUTRUONGDONVI As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_THUTRUONGDONVI"), DevExpress.XtraEditors.TextEdit)
        GRD.DataSource = Me.DONVI.getTable(spr)
        text_MADONVI.DataBindings.Clear()

        text_MADONVI.DataBindings.Add("Text", GRD.DataSource, "madonvi")
        text_TENDONVI.DataBindings.Clear()
        text_TENDONVI.DataBindings.Add("Text", GRD.DataSource, "tendonvi")
        text_DIAPHUONG.DataBindings.Clear()
        text_DIAPHUONG.DataBindings.Add("Text", GRD.DataSource, "diaphuong")
        text_THUTRUONGDONVI.DataBindings.Clear()
        text_THUTRUONGDONVI.DataBindings.Add("Text", GRD.DataSource, "thuTruongDonVi")

    End Sub
    Public Sub ADD()
        Dim Lay As DevExpress.XtraLayout.LayoutControl = CType(frm_DONVI.Controls("lay_DONVI"), DevExpress.XtraLayout.LayoutControl)
        Dim text_MADONVI As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_madonvi"), DevExpress.XtraEditors.TextEdit)
        Dim text_TENDONVI As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_tendonvi"), DevExpress.XtraEditors.TextEdit)
        Dim text_DIAPHUONG As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_diaphuong"), DevExpress.XtraEditors.TextEdit)
        Dim text_THUTRUONGDONVI As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_THUTRUONGDONVI"), DevExpress.XtraEditors.TextEdit)
        Dim spr() As SqlParameter = {
            New SqlParameter("@madonvi", text_MADONVI.Text),
            New SqlParameter("@tendonvi", text_TENDONVI.Text),
             New SqlParameter("@diaphuong", text_DIAPHUONG.Text),
            New SqlParameter("@thuTruongDonVi", text_THUTRUONGDONVI.Text)
        }
        DONVI.Add(spr)
    End Sub
    Public Sub UPDATETRENTEXTBOX()
        Dim Lay As DevExpress.XtraLayout.LayoutControl = CType(frm_DONVI.Controls("lay_DONVI"), DevExpress.XtraLayout.LayoutControl)
        Dim text_MADONVI As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_madonvi"), DevExpress.XtraEditors.TextEdit)
        Dim text_TENDONVI As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_tendonvi"), DevExpress.XtraEditors.TextEdit)
        Dim text_DIAPHUONG As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_diaphuong"), DevExpress.XtraEditors.TextEdit)
        Dim text_THUTRUONGDONVI As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_THUTRUONGDONVI"), DevExpress.XtraEditors.TextEdit)
        Dim spr() As SqlParameter = {
            New SqlParameter("@madonvi", text_MADONVI.Text),
            New SqlParameter("@tendonvi", text_TENDONVI.Text),
             New SqlParameter("@diaphuong", text_DIAPHUONG.Text),
            New SqlParameter("@thuTruongDonVi", text_THUTRUONGDONVI.Text)
        }
        DONVI.Update(spr)

    End Sub
    Public Sub DELETETRENTEXTBOX()
        Dim Lay As DevExpress.XtraLayout.LayoutControl = CType(frm_DONVI.Controls("lay_DONVI"), DevExpress.XtraLayout.LayoutControl)
        Dim text_MADONVI As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_MADONVI"), DevExpress.XtraEditors.TextEdit)
        Dim spr() As SqlParameter = {New SqlParameter("@madonvi", text_MADONVI.Text)}
        DONVI.Delete(spr)


    End Sub
End Class