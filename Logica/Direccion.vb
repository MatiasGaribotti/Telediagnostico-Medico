Public Class Direccion

    Public Property Id As Integer
    Public Property Calle As String
    Public Property Nro As Integer
    Public Property Localidad As String
    Public Property Departamento As String
    Public Property Detalle As String
    Public Shared ReadOnly Departamentos As New List(Of String)({"Montevideo",
                                                                 "Canelones",
                                                                 "San_Jose",
                                                                 "Colonia",
                                                                "Maldonado",
                                                                "Rocha",
                                                                "Lavalleja",
                                                                "Florida",
                                                                "Flores",
                                                                "Soriano",
                                                                "Rio_Negro",
                                                                "Durazno",
                                                                "Treinta_y_Tres",
                                                                "Cerro_Largo",
                                                                "Tacuarembó",
                                                                "Paysandú",
                                                                "Salto",
                                                                "Rivera",
                                                                "Artigas"}
                                                                )

    Public Sub New()
        Id = -1
        Calle = "Default"
        Nro = -1
        Localidad = "Default"
        Departamento = "Default"
    End Sub

    Public Sub New(
            id As UInteger,
            calle As String,
            nro As Integer,
            localidad As String,
            departamento As String,
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
                   departamento As String,
                   detalle As String)
        Me.New(calle, nro, localidad, departamento)
        Me.Detalle = detalle
    End Sub

    Public Sub New(calle As String,
                   nro As Integer,
                   localidad As String,
                   departamento As String)
        Me.Calle = calle
        Me.Nro = nro
        Me.Localidad = localidad
        Me.Departamento = departamento
    End Sub

End Class
