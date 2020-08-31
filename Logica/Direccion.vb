Public Class Direccion

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
        Id = -1
        Calle = "Default"
        Nro = -1
        Localidad = "Default"
        Departamento = Departamentos.Montevideo
    End Sub

    Public Sub New(
            id As UInteger,
            calle As String,
            nro As Integer,
            localidad As String,
            departamento As Departamentos,
            detalle As String)
        Me.Id = id
        Me.Calle = calle
        Me.Nro = nro
        Me.Localidad = localidad
        Me.Departamento = departamento
        Me.Detalle = detalle
    End Sub
    Public Sub New(calle As String,
                   nro As Integer,
                   localidad As String,
                   departamento As Departamentos,
                   detalle As String)
        Me.New(calle, nro, localidad, departamento)
        Me.Detalle = detalle
    End Sub

    Public Sub New(calle As String,
                   nro As Integer,
                   localidad As String,
                   departamento As Departamentos)
        Me.Calle = calle
        Me.Nro = nro
        Me.Localidad = localidad
        Me.Departamento = departamento
        Me.Detalle = ""
    End Sub

End Class
