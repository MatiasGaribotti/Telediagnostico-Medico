Imports System.Data.Odbc
Public Class DDireccion
    Inherits DBConnection
    Public Property Id As Integer
    Public Property Calle As String
    Public Property Nro As Integer
    Public Property Localidad As String
    Public Property Departamento As Departamentos
    Public Property Detalle As String

    Public Enum Departamentos
        Montevideo = 1
        Canelones
        San_Jose
        Colonia
        Maldonado
        Rocha
        Lavalleja
        Florida
        Flores
        Soriano
        Rio_Negro
        Durazno
        Treinta_y_Tres
        Cerro_Largo
        Tacuarembó
        Paysandú
        Salto
        Rivera
        Artigas
    End Enum

    Public Sub New()
        MyBase.New()
        Id = -1
        Calle = "Default"
        Nro = -1
        Localidad = "Default"
        Departamento = Departamentos.Montevideo
    End Sub

    Public Sub New(Id As UInteger,
                   Calle As String,
                   Nro As Integer,
                   Localidad As String,
                   Departamento As Departamentos,
                   Detalle As String)
        Me.Id = Id
        Me.Calle = Calle
        Me.Nro = Nro
        Me.Localidad = Localidad
        Me.Departamento = Departamento
        Me.Detalle = Detalle
    End Sub
    Public Sub New(
                   calle As String,
                   nro As Integer,
                   localidad As String,
                   departamento As Departamentos,
                   detalle As String)
        Me.Calle = calle
        Me.Nro = nro
        Me.Localidad = localidad
        Me.Departamento = departamento
        Me.Detalle = detalle
    End Sub

    Public Sub New(
                   calle As String,
                   nro As Integer,
                   localidad As String,
                   departamento As Departamentos)
        Me.Calle = calle
        Me.Nro = nro
        Me.Localidad = localidad
        Me.Departamento = departamento
        Me.Detalle = ""
    End Sub

    Public Sub Insert(connection As OdbcConnection)
        If HasConnection() Then
            Try
                Dim query = "INSERT INTO direcciones(calle, numero, localidad, departamento, detalles) VALUES(?,?,?,?,?)"
                Dim cmd As New OdbcCommand(query, connection)
                cmd.Parameters.Add(New OdbcParameter("calle", Me.Calle))
                cmd.Parameters.Add(New OdbcParameter("numero", Me.Nro))
                cmd.Parameters.Add(New OdbcParameter("localidad", Me.Localidad))
                cmd.Parameters.Add(New OdbcParameter("departamento", Me.Departamento))
                cmd.Parameters.Add(New OdbcParameter("detalle", Me.Detalle))
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                Throw ex
            End Try
        End If
    End Sub
End Class
