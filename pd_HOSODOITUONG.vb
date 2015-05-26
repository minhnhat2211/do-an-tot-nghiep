Imports System.Data
Imports System.Data.SqlClient
Public Class pd_HOSODOITUONG
    Dim pr As PROCESSDATA
    Public Sub New()
        pr = New PROCESSDATA
    End Sub
    Public Sub Add(ByVal arrpr() As SqlParameter)
        pr.ExeCuteprocedure("ps_T_HoSo_DoiTuong_Add", arrpr)

    End Sub
    Public Sub AddAll(ByVal sql As String, ByVal tb As DataTable)
        pr.Exec_UpdateTable(sql, tb)

    End Sub
    Public Sub Delete(ByVal arrpr() As SqlParameter)
        pr.ExeCuteprocedure("ps_T_HoSo_DoiTuong_Delete", arrpr)

    End Sub
    Public Sub Update(ByVal arrpr() As SqlParameter)
        pr.ExeCuteprocedure("ps_T_HoSo_DoiTuong_Update", arrpr)

    End Sub


    Public Function getTable(ByVal arrpr() As SqlParameter) As DataTable

        Return pr.ExeCuteprocedureGetDataTable("ps_T_HoSo_DoiTuong_Select", arrpr)

    End Function
    Public Function getSoHoSo(ByVal arrpr() As SqlParameter) As DataTable

        Return pr.ExeCuteprocedureGetDataTable("ps_T_HOSODOITUONG_SOHOSO_Select", arrpr)

    End Function
    Public Function gethienthi(ByVal arrpr() As SqlParameter) As DataTable

        Return pr.ExeCuteprocedureGetDataTable("[ps_T_HOSODOITUONG_HIENTHI_Select]", arrpr)

    End Function

    Public Function getDMHeST(ByVal arrpr() As SqlParameter) As DataTable

        Return pr.ExeCuteprocedureGetDataTable("ps_T_DMHeST_Select", arrpr)

    End Function

    Public Function getDMLoaiST(ByVal arrpr() As SqlParameter) As DataTable

        Return pr.ExeCuteprocedureGetDataTable("ps_T_DMLoaiST_Select", arrpr)

    End Function
    Public Function getdoiTuongSTLoai(ByVal arrpr() As SqlParameter) As DataTable

        Return pr.ExeCuteprocedureGetDataTable("ps_T_DoiTuongSTLoai_Select", arrpr)

    End Function
    Public Function getsoThe(ByVal arrpr() As SqlParameter) As DataTable

        Return pr.ExeCuteprocedureGetDataTable("ps_T_DoiTuong_Select_HoTen", arrpr)

    End Function
    Public Function getmaLoai(ByVal arrpr() As SqlParameter) As DataTable

        Return pr.ExeCuteprocedureGetDataTable("ps_T_LoaiDoiTuong_Select", arrpr)

    End Function


    Public Function getid(ByVal arrpr() As SqlParameter) As DataTable

        Return pr.ExeCuteprocedureGetDataTable("ps_T_HoSo_DoiTuong_Select_byIDHoSoDoiTuong", arrpr)

    End Function
End Class
