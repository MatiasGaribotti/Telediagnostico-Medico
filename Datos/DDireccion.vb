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
        MyBase.New()
        Me.Id = Id
        Me.Calle = Calle
        Me.Nro = Nro
        Me.Localidad = Localidad
        Me.Departamento = Departamento
        Me.Detalle = Detalle
    End Sub
    Public Sub New(DB_User As String,
                   DB_Password As String,
                   calle As String,
                   nro As Integer,
                   localidad As String,
                   departamento As Departamentos,
                   detalle As String)
        Me.DB_User = DB_User
        Me.DB_Password = DB_Password
        Me.Calle = calle
        Me.Nro = nro
        Me.Localidad = localidad
        Me.Departamento = departamento
        Me.Detalle = detalle
    End Sub

    Public Sub New(DB_User As String,
                   DB_Password As String,
                   calle As String,
                   nro As Integer,
                   localidad As String,
                   departamento As Departamentos)
        Me.DB_User = DB_User
        Me.DB_Password = DB_Password
        Me.Calle = calle
        Me.Nro = nro
        Me.Localidad = localidad
        Me.Departamento = departamento
    End Sub

    Public Function Insert() As Boolean
        If HasConnection() Then
            Dim con = Conectar()
        End If
    End Function

End Class
