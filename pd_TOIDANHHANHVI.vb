Imports System.Data
Imports System.Data.SqlClient
Public Class pd_TOIDANHHANHVI
    Dim pr As PROCESSDATA
    Public Sub New()
        pr = New PROCESSDATA
    End Sub
    Public Sub Add(ByVal arrpr() As SqlParameter)
        pr.ExeCuteprocedure("ps_T_ToiDanh_HanhVi_Add", arrpr)

    End Sub
    Public Sub AddAll(ByVal sql As String, ByVal tb As DataTable)
        pr.Exec_UpdateTable(sql, tb)

    End Sub
    Public Sub Delete(ByVal arrpr() As SqlParameter)
        pr.ExeCuteprocedure("ps_T_ToiDanh_HanhVi_Delete", arrpr)

    End Sub
    Public Sub Update(ByVal arrpr() As SqlParameter)
        pr.ExeCuteprocedure("ps_T_ToiDanh_HanhVi_Update", arrpr)

    End Sub

    Public Function getTable(ByVal arrpr() As SqlParameter) As DataTable

        Return pr.ExeCuteprocedureGetDataTable("ps_T_ToiDanh_HanhVi_Select", arrpr)

    End Function
    Public Function getMaToiDanh(ByVal arrpr() As SqlParameter) As DataTable

        Return pr.ExeCuteprocedureGetDataTable("ps_T_TOIDANHHANHVI_MATOIDANH_Select", arrpr)

    End Function

    Public Function getMaHanhVi(ByVal arrpr() As SqlParameter) As DataTable

        Return pr.ExeCuteprocedureGetDataTable("ps_T_TOIDANHHANHVI_MAHANHVI_Select", arrpr)

    End Function

End Class

