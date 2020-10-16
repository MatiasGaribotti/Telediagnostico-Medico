Public Class Sucursal
    Public Property Id As Byte
    Public Property Nombre As String
    Public Property Telefonos As List(Of Integer)
    Public Property Direccion As Direccion

    Public Sub New()
        Me.Id = 0
        Me.Nombre = ""
        Me.Telefonos = New List(Of Integer)
        Me.Direccion = New Direccion
    End Sub

    Public Sub New(id As Byte)
        Me.Id = id
        Me.Nombre = ""
        Me.Telefonos = New List(Of Integer)
        Me.Direccion = New Direccion
    End Sub

    Public Sub New(id As Byte, nombre As String, direccion As Direccion)
        Me.Id = id
        Me.Nombre = nombre
        Me.Telefonos = New List(Of Integer)
        Me.Direccion = direccion
    End Sub

    Public Sub New(id As Byte, nombre As String, telefonos As List(Of Integer), direccion As Direccion)
        Me.Id = id
        Me.Nombre = nombre
        Me.Telefonos = telefonos
        Me.Direccion = direccion
    End Sub
End Class
