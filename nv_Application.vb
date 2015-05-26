Imports System.Data.SqlClient
Public Class nv_Application
    Private Application As pd_Application
    Private frm_Application As Form

    Public Sub New(ByRef f As Form)
        Application = New pd_Application
        Me.frm_Application = f
    End Sub
    Public Sub HIENTHI()
        Dim LAY As DevExpress.XtraLayout.LayoutControl = CType(frm_Application.Controls("lay_Application"), DevExpress.XtraLayout.LayoutControl)
        Dim GRD As DevExpress.XtraGrid.GridControl = CType(LAY.Controls("grd_Application"), DevExpress.XtraGrid.GridControl)
        Dim spr() As SqlParameter = {New SqlParameter("@ID_App", DBNull.Value)}
        Dim spr_menu() As SqlParameter = {New SqlParameter("@ID_Menu", DBNull.Value)}
        Dim text_IDAPP As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_IDAPP"), DevExpress.XtraEditors.TextEdit)
        Dim text_TENAPP As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_TENAPP"), DevExpress.XtraEditors.TextEdit)
        Dim combo_IDMENU As DevExpress.XtraEditors.LookUpEdit = CType(LAY.Controls("combo_IDMENU"), DevExpress.XtraEditors.LookUpEdit)
        Dim tb As DataTable = Me.Application.getTable(spr)
        GRD.DataSource = tb

        combo_IDMENU.Properties.DataSource = Me.Application.getIDMenu(spr_menu)
        combo_IDMENU.Properties.DisplayMember = "tenMenu"
        combo_IDMENU.Properties.ValueMember = "ID_Menu"

        text_IDAPP.DataBindings.Clear()
        text_IDAPP.DataBindings.Add("Text", tb, "ID_App")
        text_TENAPP.DataBindings.Clear()
        text_TENAPP.DataBindings.Add("Text", tb, "Ten_App")
        combo_IDMENU.DataBindings.Clear()
        combo_IDMENU.DataBindings.Add("EditValue", tb, "ID_Menu")


    End Sub

    Public Sub ADD()
        Dim Lay As DevExpress.XtraLayout.LayoutControl = CType(frm_Application.Controls("lay_Application"), DevExpress.XtraLayout.LayoutControl)
        Dim text_IDAPP As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_IDAPP"), DevExpress.XtraEditors.TextEdit)
        Dim text_TENAPP As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_TENAPP"), DevExpress.XtraEditors.TextEdit)
        Dim combo_IDMENU As DevExpress.XtraEditors.LookUpEdit = CType(Lay.Controls("combo_IDMENU"), DevExpress.XtraEditors.LookUpEdit)
        Dim spr() As SqlParameter = {
            New SqlParameter("@ID_App", text_IDAPP.Text),
            New SqlParameter("@Ten_App", text_TENAPP.Text),                                              
            New SqlParameter("@ID_Menu", combo_IDMENU.GetColumnValue(combo_IDMENU.Properties.Columns(0)))
        }
        Application.Add(spr)
    End Sub
    Public Sub UPDATETRENTEXTBOX()
        Dim Lay As DevExpress.XtraLayout.LayoutControl = CType(frm_Application.Controls("lay_Application"), DevExpress.XtraLayout.LayoutControl)
        Dim text_IDAPP As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_IDAPP"), DevExpress.XtraEditors.TextEdit)
        Dim text_TENAPP As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_TENAPP"), DevExpress.XtraEditors.TextEdit)
        Dim spr() As SqlParameter = {
            New SqlParameter("@Ten_App", text_TENAPP.Text)
        }
        Application.Update(spr)

    End Sub
    Public Sub DELETETRENTEXTBOX()
        Dim Lay As DevExpress.XtraLayout.LayoutControl = CType(frm_Application.Controls("lay_Application"), DevExpress.XtraLayout.LayoutControl)
        Dim text_IDAPP As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_IDAPP"), DevExpress.XtraEditors.TextEdit)
        Dim spr() As SqlParameter = {New SqlParameter("@ID_App", text_IDAPP.Text)}
        Application.Delete(spr)


    End Sub
End Class
