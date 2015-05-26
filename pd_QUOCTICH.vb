﻿Imports System.Data
Imports System.Data.SqlClient
Public Class pd_QUOCTICH
    Dim pr As PROCESSDATA
    Public Sub New()
        pr = New PROCESSDATA
    End Sub
    Public Sub Add(ByVal arrpr() As SqlParameter)
        pr.ExeCuteprocedure("ps_T_QuocTich_Add", arrpr)

    End Sub
    Public Sub AddAll(ByVal sql As String, ByVal tb As DataTable)
        pr.Exec_UpdateTable(sql, tb)

    End Sub
    Public Sub Delete(ByVal arrpr() As SqlParameter)
        pr.ExeCuteprocedure("ps_T_QuocTich_Delete", arrpr)

    End Sub
    Public Sub Update(ByVal arrpr() As SqlParameter)
        pr.ExeCuteprocedure("ps_T_QuocTich_Update", arrpr)

    End Sub

    Public Function getTable(ByVal arrpr() As SqlParameter) As DataTable

        Return pr.ExeCuteprocedureGetDataTable("ps_T_QuocTich_Select", arrpr)

    End Function

End Class

