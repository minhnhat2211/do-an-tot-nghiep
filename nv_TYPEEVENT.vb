Imports System.Data.SqlClient
Public Class nv_TYPEEVENT
    Private TYPEEVENT As pd_TYPEEVENT
    Private frm_TYPEEVENT As Form

    Public Sub New(ByRef f As Form)
        TYPEEVENT = New pd_TYPEEVENT
        Me.frm_TYPEEVENT = f
    End Sub
    Public Sub HIENTHI()
        Dim LAY As DevExpress.XtraLayout.LayoutControl = CType(frm_TYPEEVENT.Controls("lay_TYPEEVENT"), DevExpress.XtraLayout.LayoutControl)
        Dim GRD As DevExpress.XtraGrid.GridControl = CType(LAY.Controls("grd_TYPEEVENT"), DevExpress.XtraGrid.GridControl)
        Dim spr_group() As SqlParameter = {New SqlParameter("@ID_Menu", DBNull.Value)}
        Dim spr() As SqlParameter = {New SqlParameter("@ID_TYPEEVENT", DBNull.Value)}
        Dim text_IDTYPEEVENT As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_IDTYPEEVENT"), DevExpress.XtraEditors.TextEdit)
        Dim text_TENEVENT As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_TENEVENT"), DevExpress.XtraEditors.TextEdit)
        Dim combo_IDMENU As DevExpress.XtraEditors.LookUpEdit = CType(LAY.Controls("combo_IDMENU"), DevExpress.XtraEditors.LookUpEdit)
        Dim tb As DataTable = Me.TYPEEVENT.getTable(spr)
        GRD.DataSource = tb


        combo_IDMENU.Properties.DataSource = Me.TYPEEVENT.getIDMENU(spr_group)
        combo_IDMENU.Properties.DisplayMember = "tenMenu"
        combo_IDMENU.Properties.ValueMember = "ID_Menu"

        text_IDTYPEEVENT.DataBindings.Clear()
        text_IDTYPEEVENT.DataBindings.Add("Text", tb, "ID_TYPEEVENT")
        text_TENEVENT.DataBindings.Clear()
        text_TENEVENT.DataBindings.Add("Text", tb, "tenEVENT")
        combo_IDMENU.DataBindings.Clear()
        combo_IDMENU.DataBindings.Add("EditValue", tb, "ID_Menu")


    End Sub

    Public Sub ADD()
        Dim Lay As DevExpress.XtraLayout.LayoutControl = CType(frm_TYPEEVENT.Controls("lay_TYPEEVENT"), DevExpress.XtraLayout.LayoutControl)
        Dim text_TENEVENT As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_TENEVENT"), DevExpress.XtraEditors.TextEdit)
        Dim spr() As SqlParameter = {
            New SqlParameter("@TenEVENT", text_TENEVENT.Text)
        }
        TYPEEVENT.Add(spr)
    End Sub
    Public Sub UPDATETRENTEXTBOX()
        Dim Lay As DevExpress.XtraLayout.LayoutControl = CType(frm_TYPEEVENT.Controls("lay_TYPEEVENT"), DevExpress.XtraLayout.LayoutControl)
        Dim text_IDTYPEEVENT As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_IDTYPEEVENT"), DevExpress.XtraEditors.TextEdit)
        Dim text_TENTYPEEVENT As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_TENEVENT"), DevExpress.XtraEditors.TextEdit)
        Dim spr() As SqlParameter = {
            New SqlParameter("@ID_TYPEEVENT", text_IDTYPEEVENT.Text),
            New SqlParameter("@tenEVENT", text_TENTYPEEVENT.Text)
        }
        TYPEEVENT.Update(spr)

    End Sub
    Public Sub DELETETRENTEXTBOX()
        Dim Lay As DevExpress.XtraLayout.LayoutControl = CType(frm_TYPEEVENT.Controls("lay_TYPEEVENT"), DevExpress.XtraLayout.LayoutControl)
        Dim text_IDTYPEEVENT As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_IDTYPEEVENT"), DevExpress.XtraEditors.TextEdit)
        Dim spr() As SqlParameter = {New SqlParameter("@ID_TypeEvent", text_IDTYPEEVENT.Text)}
        TYPEEVENT.Delete(spr)



    End Sub
End Class
