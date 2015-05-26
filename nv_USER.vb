Imports System.Data.SqlClient
Public Class nv_USER
    Private USER As pd_USER
    Private frm_USER As Form

    Public Sub New(ByRef f As Form)
        USER = New pd_USER
        Me.frm_USER = f
    End Sub
    Public Sub HIENTHI()
        Dim LAY As DevExpress.XtraLayout.LayoutControl = CType(frm_USER.Controls("lay_USER"), DevExpress.XtraLayout.LayoutControl)
        Dim GRD As DevExpress.XtraGrid.GridControl = CType(LAY.Controls("grd_USER"), DevExpress.XtraGrid.GridControl)
        Dim spr() As SqlParameter = {New SqlParameter("@ID_User", DBNull.Value)}
        Dim spr_group() As SqlParameter = {New SqlParameter("@ID_Group", DBNull.Value)}
        Dim spr_iduser() As SqlParameter = {New SqlParameter("@maCanBo", DBNull.Value)}
        Dim text_USERNAME As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_USERNAME"), DevExpress.XtraEditors.TextEdit)
        Dim text_PASSWORD As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_PASSWORD"), DevExpress.XtraEditors.TextEdit)
        Dim text_TRANGTHAI As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_TRANGTHAI"), DevExpress.XtraEditors.TextEdit)
        Dim combo_IDUSER As DevExpress.XtraEditors.LookUpEdit = CType(LAY.Controls("combo_IDUSER"), DevExpress.XtraEditors.LookUpEdit)
        Dim combo_IDGROUP As DevExpress.XtraEditors.LookUpEdit = CType(LAY.Controls("combo_IDGROUP"), DevExpress.XtraEditors.LookUpEdit)
        Dim tb As DataTable = Me.USER.getTable(spr)



        combo_IDGROUP.Properties.DataSource = Me.USER.getIDGROUP(spr_group)
        combo_IDGROUP.Properties.DisplayMember = "TenGroup"
        combo_IDGROUP.Properties.ValueMember = "ID_Group"
        combo_IDUSER.Properties.DataSource = Me.USER.getIDUSER(spr_iduser)
        combo_IDUSER.Properties.DisplayMember = "fullname"
        combo_IDUSER.Properties.ValueMember = "maCanBo"

        text_USERNAME.DataBindings.Clear()
        text_USERNAME.DataBindings.Add("Text", tb, "Username")
        text_PASSWORD.DataBindings.Clear()
        text_PASSWORD.DataBindings.Add("Text", tb, "Password")
        combo_IDUSER.DataBindings.Clear()
        combo_IDUSER.DataBindings.Add("EditValue", tb, "ID_User")
       
        combo_IDGROUP.DataBindings.Clear()
        combo_IDGROUP.DataBindings.Add("EditValue", tb, "ID_Group")
        GRD.DataSource = tb

    End Sub

    Public Sub ADD()
        Dim Lay As DevExpress.XtraLayout.LayoutControl = CType(frm_USER.Controls("lay_USER"), DevExpress.XtraLayout.LayoutControl)
        Dim text_USERNAME As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_USERNAME"), DevExpress.XtraEditors.TextEdit)
        Dim text_PASSWORD As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_PASSWORD"), DevExpress.XtraEditors.TextEdit)
        Dim combo_IDUSER As DevExpress.XtraEditors.LookUpEdit = CType(Lay.Controls("combo_IDUSER"), DevExpress.XtraEditors.LookUpEdit)
        Dim combo_IDGROUP As DevExpress.XtraEditors.LookUpEdit = CType(Lay.Controls("combo_IDGROUP"), DevExpress.XtraEditors.LookUpEdit)
        Dim spr() As SqlParameter = {
            New SqlParameter("@Username", text_USERNAME.Text),
            New SqlParameter("@Password", text_PASSWORD.Text),
            New SqlParameter("@ID_User", combo_IDUSER.GetColumnValue(combo_IDUSER.Properties.Columns(0))),
            New SqlParameter("@ID_Group", combo_IDGROUP.GetColumnValue(combo_IDGROUP.Properties.Columns(0)))
        }
        USER.Add(spr)
    End Sub
    Public Sub UPDATETRENTEXTBOX()
        Dim Lay As DevExpress.XtraLayout.LayoutControl = CType(frm_USER.Controls("lay_USER"), DevExpress.XtraLayout.LayoutControl)
        Dim combo_IDUSER As DevExpress.XtraEditors.LookUpEdit = CType(Lay.Controls("combo_IDUSER"), DevExpress.XtraEditors.LookUpEdit)
        Dim text_PASSWORD As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_PASSWORD"), DevExpress.XtraEditors.TextEdit)
        Dim combo_IDGROUP As DevExpress.XtraEditors.LookUpEdit = CType(Lay.Controls("combo_IDGROUP"), DevExpress.XtraEditors.LookUpEdit)
        Dim spr() As SqlParameter = {
            New SqlParameter("@ID_User", combo_IDUSER.GetColumnValue(combo_IDUSER.Properties.Columns(0))),
            New SqlParameter("@Password", text_PASSWORD.Text),
            New SqlParameter("@ID_Group", combo_IDGROUP.GetColumnValue(combo_IDGROUP.Properties.Columns(0)))
        }
        USER.Update(spr)

    End Sub
    Public Sub DELETETRENTEXTBOX()
        Dim Lay As DevExpress.XtraLayout.LayoutControl = CType(frm_USER.Controls("lay_USER"), DevExpress.XtraLayout.LayoutControl)
        Dim text_USERNAME As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_USERNAME"), DevExpress.XtraEditors.TextEdit)
        Dim text_TRANGTHAI As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_TRANGTHAI"), DevExpress.XtraEditors.TextEdit)
        Dim spr() As SqlParameter = {New SqlParameter("@Username", text_USERNAME.Text)}
        USER.Delete(spr)


    End Sub
End Class
