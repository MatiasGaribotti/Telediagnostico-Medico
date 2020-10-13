Imports ADODB
Imports Dominio

Public Class SucursalDAO
    Inherits DBConnection

    Public Function GetSucursales() As DataTable
        Dim rs As Recordset
        Dim dt As New DataTable
        Dim da As New OleDb.OleDbDataAdapter
        Dim query As String = "SELECT * FROM view_sucursales;"

        Try
            Conn = Connect()

        Catch ex As Exception
            Throw ex
        End Try

        Try
            rs = Conn.Execute(query)
            da.Fill(dt, rs)

        Catch ex As Exception
            Throw ex

        Finally
            Conn.Close()

        End Try

        Return dt
    End Function
End Class
