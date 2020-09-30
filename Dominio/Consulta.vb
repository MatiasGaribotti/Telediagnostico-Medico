Public MustInherit Class Consulta

    Public Property Id As Int64
    Public Property Sucursal As Sucursal
    Public Property Paciente As Paciente
    Public Property FechaHora As Date
    Public Property Sintomas As List(Of Sintoma)
    Public Property Diagnosticos As List(Of Enfermedad)

    Protected Sub New(id As Int64, paciente As Paciente)
        Me.Id = id
        Me.Sucursal = Env.CurrentSucursal
        Me.Paciente = paciente
        Me.FechaHora = Date.Now
        Me.Sintomas = New List(Of Sintoma)
        Me.Diagnosticos = New List(Of Enfermedad)
    End Sub

    Protected Sub New()
        Me.Id = -1
        Me.Sucursal = Env.CurrentSucursal
        Me.Paciente = New Paciente(Env.CurrentUser.Ci)
        Me.FechaHora = Date.Now
        Me.Sintomas = New List(Of Sintoma)
        Me.Diagnosticos = New List(Of Enfermedad)
    End Sub

    Protected Sub New(sucursal As Sucursal, paciente As Paciente, fechaHora As Date, sintomas As List(Of Sintoma), diagnosticos As List(Of Enfermedad))
        Me.Sucursal = sucursal
        Me.Paciente = paciente
        Me.FechaHora = fechaHora
        Me.Sintomas = sintomas
        Me.Diagnosticos = diagnosticos
    End Sub

    Protected Sub New(id As Integer, sucursal As Sucursal, paciente As Paciente, fechaHora As Date, sintomas As List(Of Sintoma), diagnosticos As List(Of Enfermedad))
        Me.Id = id
        Me.Sucursal = sucursal
        Me.Paciente = paciente
        Me.FechaHora = fechaHora
        Me.Sintomas = sintomas
        Me.Diagnosticos = diagnosticos
    End Sub

End Class
