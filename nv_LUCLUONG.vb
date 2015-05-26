Imports System.Data.SqlClient
Public Class nv_LUCLUONG
    Private LUCLUONG As pd_LUCLUONG
    Private frm_LUCLUONG As Form

    Public Sub New(ByRef f As Form)
        LUCLUONG = New pd_LUCLUONG
        Me.frm_LUCLUONG = f
    End Sub
    Public Sub HIENTHI()
        Dim LAY As DevExpress.XtraLayout.LayoutControl = CType(frm_LUCLUONG.Controls("lay_LUCLUONG"), DevExpress.XtraLayout.LayoutControl)
        Dim GRD As DevExpress.XtraGrid.GridControl = CType(LAY.Controls("grd_LUCLUONG"), DevExpress.XtraGrid.GridControl)
        Dim spr() As SqlParameter = {New SqlParameter("@malucluong", DBNull.Value)}
        Dim text_MALUCLUONG As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_MALUCLUONG"), DevExpress.XtraEditors.TextEdit)
        Dim text_TENLUCLUONG As DevExpress.XtraEditors.TextEdit = CType(LAY.Controls("txt_TENLUCLUONG"), DevExpress.XtraEditors.TextEdit)
        GRD.DataSource = Me.LUCLUONG.getTable(spr)
        text_MALUCLUONG.DataBindings.Clear()

        text_MALUCLUONG.DataBindings.Add("Text", GRD.DataSource, "malucluong")
        text_TENLUCLUONG.DataBindings.Clear()
        text_TENLUCLUONG.DataBindings.Add("Text", GRD.DataSource, "tenlucluong")


    End Sub

    Public Sub ADD()
        Dim Lay As DevExpress.XtraLayout.LayoutControl = CType(frm_LUCLUONG.Controls("lay_LUCLUONG"), DevExpress.XtraLayout.LayoutControl)
        Dim text_MALUCLUONG As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_MALUCLUONG"), DevExpress.XtraEditors.TextEdit)
        Dim text_TENLUCLUONG As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_TENLUCLUONG"), DevExpress.XtraEditors.TextEdit)
        Dim spr() As SqlParameter = {
            New SqlParameter("@maLUCLUONG", text_MALUCLUONG.Text),
            New SqlParameter("@tenlucluong", text_TENLUCLUONG.Text)
        }
        LUCLUONG.Add(spr)
    End Sub
    Public Sub UPDATETRENTEXTBOX()
        Dim Lay As DevExpress.XtraLayout.LayoutControl = CType(frm_LUCLUONG.Controls("lay_LUCLUONG"), DevExpress.XtraLayout.LayoutControl)
        Dim text_MALUCLUONG As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_MALUCLUONG"), DevExpress.XtraEditors.TextEdit)
        Dim text_TENLUCLUONG As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_TENLUCLUONG"), DevExpress.XtraEditors.TextEdit)
        Dim spr() As SqlParameter = {
            New SqlParameter("@maLUCLUONG", text_MALUCLUONG.Text),
            New SqlParameter("@tenlucluong", text_TENLUCLUONG.Text)
        }
        LUCLUONG.Update(spr)

    End Sub
    Public Sub DELETETRENTEXTBOX()
        Dim Lay As DevExpress.XtraLayout.LayoutControl = CType(frm_LUCLUONG.Controls("lay_LUCLUONG"), DevExpress.XtraLayout.LayoutControl)
        Dim text_MALUCLUONG As DevExpress.XtraEditors.TextEdit = CType(Lay.Controls("txt_MALUCLUONG"), DevExpress.XtraEditors.TextEdit)
        Dim spr() As SqlParameter = {New SqlParameter("@maLUCLUONG", text_MALUCLUONG.Text)}
        LUCLUONG.Delete(spr)



    End Sub
End Class
