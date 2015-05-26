Imports System.Data
Imports System.Data.SqlClient

Public Class PROCESSDATA
    Private cn As SqlConnection

    Public Sub New()
        cn = New SqlConnection
        cn.ConnectionString = "Data Source=ASUS;Initial Catalog=QuanLyHoSoToiPham;Integrated Security=True"


    End Sub
    Public Sub Open()
        If cn.State = ConnectionState.Closed Then
            cn.Open()

        End If
    End Sub

    Public Sub Close()
        If cn.State = ConnectionState.Open Then
            cn.Close()

        End If
    End Sub
    Public Function Table(ByVal sql As String) As DataTable

        Dim tb As New DataTable
        Dim adp As New SqlDataAdapter(sql, cn)
        adp.Fill(tb)
        Return tb
    End Function

    Public Function Table(ByVal Name As String, ByVal pr As SqlParameter()) As DataTable

        Dim tb As New DataTable

        Dim cmd As New SqlCommand
        cmd.CommandText = Name
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = Me.cn
        Dim adp As SqlDataAdapter
        If IsDBNull(pr) = False Then
            cmd.Parameters.AddRange(pr)

        End If

        adp = New SqlDataAdapter(cmd)
        adp.Fill(tb)

        Return tb
    End Function
    Public Sub Exec_UpdateTable(ByVal SQL As String, ByVal tb As DataTable)
        Me.Open()
        Dim adp As New SqlDataAdapter(SQL, cn)

       
        Dim adb As New SqlCommandBuilder(adp)
        adp.Update(tb)
        Me.Close()
    End Sub

    Public Function ExeCuteprocedure(ByVal Name As String, ByVal pr As SqlParameter()) As Integer
        Me.Open()
        Dim tb As New DataTable

        Dim cmd As New SqlCommand
        cmd.CommandText = Name
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = Me.cn

        If IsDBNull(pr) = False Then
            cmd.Parameters.AddRange(pr)

        End If

        Dim k As Integer = cmd.ExecuteNonQuery()
        Me.Close()
        Return k
    End Function

    Public Function ExeCuteprocedureGetDataTable(ByVal Name As String, ByVal pr As SqlParameter()) As DataTable
        Me.Open()

        Dim tb As New DataTable

        Dim cmd As New SqlCommand
        cmd.CommandText = Name
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = Me.cn

        If IsDBNull(pr) = False Then
            cmd.Parameters.AddRange(pr)

        End If
        Dim adp As New SqlDataAdapter(cmd)
        adp.Fill(tb)
        Me.Close()

        Return tb
        
    End Function


    Public Function ExeCuteSQL(ByVal sql As String) As Integer
        Dim cmd As New SqlCommand(sql, cn)
        Me.Open()
        Dim k As Integer = cmd.ExecuteNonQuery()
        Me.Close()
        Return k


    End Function
End Class
