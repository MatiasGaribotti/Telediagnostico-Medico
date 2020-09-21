Public MustInherit Class Consulta

    Protected Property Id As Integer
    Protected Property Sucursal As Sucursal
    Protected Property Paciente As Paciente
    Protected Property FechaHora As DateTime
    Protected Property Sintomas As List(Of Sintoma)
    Protected Property Diagnosticos As List(Of Diagnostico)

End Class
