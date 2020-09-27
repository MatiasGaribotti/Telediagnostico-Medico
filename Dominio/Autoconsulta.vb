Public Class Autoconsulta
    Inherits Consulta

    Public Sub New()
        MyBase.New
    End Sub

    Public Sub New(sucursal As Sucursal, paciente As Paciente, fechaHora As Date, sintomas As List(Of Sintoma), diagnosticos As List(Of Enfermedad))
        MyBase.New(sucursal, paciente, fechaHora, sintomas, diagnosticos)
    End Sub

    Public Sub New(id As Integer, sucursal As Sucursal, paciente As Paciente, fechaHora As Date, sintomas As List(Of Sintoma), diagnosticos As List(Of Enfermedad))
        MyBase.New(id, sucursal, paciente, fechaHora, sintomas, diagnosticos)

    End Sub
End Class
