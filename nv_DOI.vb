Imports System.Data.SqlClient

Public Class nv_DOI
    Private DOI As pd_DOI
    Private frm_DOI As Form
    Public Sub New(ByRef f As Form)
        DOI = New pd_DOI
        Me.frm_DOI = f
    End Sub
    Public Sub HIENTHI()
        Dim LAY As DevExpress.XtraLayout.LayoutControl = CType(frm_DOI.Controls("lay_DOI"), DevExpress.XtraLayout.LayoutControl)
        Dim GRD As DevExpress.XtraGrid.GridControl = CType(LAY.Controls("grd_DOI"), DevExpress.XtraGrid.GridControl)
        Dim text_MADOI As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_MADOI"), DevExpress.XtraEditors.TextEdit)
        Dim text_TENDOI As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_TENDOI"), DevExpress.XtraEditors.TextEdit)
        Dim combo_MALUCLUONG As DevExpress.XtraEditors.LookUpEdit = CType(LAY.Controls("combo_MALUCLUONG"), DevExpress.XtraEditors.LookUpEdit)
        Dim combo_MADONVI As DevExpress.XtraEditors.LookUpEdit = CType(LAY.Controls("combo_MADONVI"), DevExpress.XtraEditors.LookUpEdit)
        Dim spr() As SqlParameter = {New SqlParameter("@maDoi", DBNull.Value)}
        Dim spr_malucluong() As SqlParameter = {New SqlParameter("@maLucLuong", DBNull.Value)}
        Dim spr_madonvi() As SqlParameter = {New SqlParameter("@maDonVi", DBNull.Value)}
        Dim tb As DataTable = Me.DOI.getTable(spr)

        combo_MALUCLUONG.Properties.DataSource = Me.DOI.getMaLucLuong(spr_malucluong)
        combo_MALUCLUONG.Properties.DisplayMember = "tenLucLuong"
        combo_MALUCLUONG.Properties.ValueMember = "maLucLuong"
        combo_MADONVI.Properties.DataSource = Me.DOI.getMaDonVi(spr_madonvi)
        combo_MADONVI.Properties.DisplayMember = "tenDonVi"
        combo_MADONVI.Properties.ValueMember = "maDonVi"

        text_MADOI.DataBindings.Clear()
        text_MADOI.DataBindings.Add("Text", tb, "maDoi")
        text_TENDOI.DataBindings.Clear()
        text_TENDOI.DataBindings.Add("Text", tb, "tenDoi")
        combo_MALUCLUONG.DataBindings.Clear()
        combo_MALUCLUONG.DataBindings.Add("EditValue", tb, "maLucLuong")

        combo_MADONVI.DataBindings.Clear()
        combo_MADONVI.DataBindings.Add("EditValue", tb, "maDonVi")
        GRD.DataSource = tb


    End Sub
    Public Sub ADD()
        Dim Lay As DevExpress.XtraLayout.LayoutControl = CType(frm_DOI.Controls("lay_DOI"), DevExpress.XtraLayout.LayoutControl)
        Dim text_MADOI As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_MADOI"), DevExpress.XtraEditors.TextEdit)
        Dim text_TENDOI As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_TENDOI"), DevExpress.XtraEditors.TextEdit)
        Dim combo_MALUCLUONG As DevExpress.XtraEditors.LookUpEdit = CType(Lay.Controls("combo_MALUCLUONG"), DevExpress.XtraEditors.LookUpEdit)
        Dim combo_MADONVI As DevExpress.XtraEditors.LookUpEdit = CType(Lay.Controls("combo_MADONVI"), DevExpress.XtraEditors.LookUpEdit)
        Dim spr() As SqlParameter = {
            New SqlParameter("@maDoi", text_MADOI.Text),
            New SqlParameter("@tenDoi", text_TENDOI.Text),
            New SqlParameter("@maLucLuong", combo_MALUCLUONG.GetColumnValue(combo_MALUCLUONG.Properties.Columns(0))),
            New SqlParameter("@maDonVi", combo_MADONVI.GetColumnValue(combo_MADONVI.Properties.Columns(0)))
        }
        DOI.Add(spr)
    End Sub
    Public Sub UPDATETRENTEXTBOX()
        Dim Lay As DevExpress.XtraLayout.LayoutControl = CType(frm_DOI.Controls("lay_DOI"), DevExpress.XtraLayout.LayoutControl)
        Dim text_MADOI As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_MADOI"), DevExpress.XtraEditors.TextEdit)
        Dim text_TENDOI As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_TENDOI"), DevExpress.XtraEditors.TextEdit)
        Dim combo_MALUCLUONG As DevExpress.XtraEditors.LookUpEdit = CType(Lay.Controls("combo_MALUCLUONG"), DevExpress.XtraEditors.LookUpEdit)
        Dim combo_MADONVI As DevExpress.XtraEditors.LookUpEdit = CType(Lay.Controls("combo_MADONVI"), DevExpress.XtraEditors.LookUpEdit)
        Dim spr() As SqlParameter = {
            New SqlParameter("@maDoi", text_MADOI.Text),
            New SqlParameter("@tenDoi", text_TENDOI.Text),
            New SqlParameter("@maLucLuong", combo_MALUCLUONG.GetColumnValue(combo_MALUCLUONG.Properties.Columns(0))),
            New SqlParameter("@maDonVi", combo_MADONVI.GetColumnValue(combo_MADONVI.Properties.Columns(0)))
        }
        DOI.Update(spr)

    End Sub
    Public Sub DELETETRENTEXTBOX()
        Dim Lay As DevExpress.XtraLayout.LayoutControl = CType(frm_DOI.Controls("lay_DOI"), DevExpress.XtraLayout.LayoutControl)
        Dim text_MADOI As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_MADOI"), DevExpress.XtraEditors.TextEdit)
        Dim spr() As SqlParameter = {New SqlParameter("@maDoi", text_MADOI.Text)}
        DOI.Delete(spr)


    End Sub
End Class

