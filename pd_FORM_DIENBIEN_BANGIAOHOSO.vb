Imports System.Data
Imports System.Data.SqlClient
Public Class pd_FORM_DIENBIEN_BANGIAOHOSO
    Dim pr As PROCESSDATA
    Public Sub New()
        pr = New PROCESSDATA
    End Sub
    Public Sub Add_CTDienBien_DienBien(ByVal arrpr() As SqlParameter)
        pr.ExeCuteprocedure("ps_T_ChiTietDienBien_DienBienHoSo_Add", arrpr)
    End Sub
    Public Sub DELETE_CTDienBien_DienBien(ByVal arrpr() As SqlParameter)
        pr.ExeCuteprocedure("ps_T_ChiTietDienBien_DienBienHoSo_Delete", arrpr)
    End Sub
    Public Function Select_CTDienBien_DienBien(ByVal arrpr() As SqlParameter) As DataTable
        Return pr.ExeCuteprocedureGetDataTable("ps_T_ChiTietDienBien_DienBienHoSo_Select", arrpr)
    End Function
    Public Sub Add_BanGiao(ByVal arrpr() As SqlParameter)
        pr.ExeCuteprocedure("ps_T_BanGiao_Add", arrpr)
    End Sub
    Public Sub DELETE_BanGiao(ByVal arrpr() As SqlParameter)
        pr.ExeCuteprocedure("ps_T_BanGiao_Delete", arrpr)
    End Sub
    Public Function Select_ThongTinCanBo(ByVal arrpr() As SqlParameter) As DataTable
        Return pr.ExeCuteprocedureGetDataTable("ps_T_CanBo_Doi_DonVi_Select", arrpr)
    End Function

    Public Function getTable(ByVal arrpr() As SqlParameter) As DataTable

        Return pr.ExeCuteprocedureGetDataTable("ps_T_DienBienHoSo_Select", arrpr)

    End Function

End Class
