Public Class Diagnostico
    Public Property Enfermedad As Enfermedad
    Public Property Tratamiento As Tratamiento

    Public Sub New()
        Enfermedad = New Enfermedad
        Tratamiento = New Tratamiento
    End Sub

    Public Sub New(pEnfermedad As Enfermedad)
        Enfermedad = pEnfermedad
        Tratamiento = New Tratamiento
    End Sub

    Public Sub New(enfermedad As Enfermedad, tratamiento As Tratamiento)
        Me.New(enfermedad)
        Me.Tratamiento = tratamiento
    End Sub
End Class
