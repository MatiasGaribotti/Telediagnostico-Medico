Public Class ConsultaMedica
    Inherits Consulta
    Public Property Medico As Medico
    Public Property Desarrollo As String
    Public Property Chat As Chat

    Public Sub New(autoconsulta As Autoconsulta)
        MyBase.New(autoconsulta.Sucursal, autoconsulta.Paciente, autoconsulta.FechaHora, autoconsulta.Sintomas, autoconsulta.Diagnosticos)
        Me.Medico = New Medico

    End Sub

    Public Sub New(id As Integer, sucursal As Sucursal, paciente As Paciente, fechaHora As Date, sintomas As List(Of Sintoma), diagnosticos As List(Of Enfermedad), medico As Medico, desarrollo As String, chat As Chat)
        MyBase.New(id, sucursal, paciente, fechaHora, sintomas, diagnosticos)
        Me.Medico = medico
        Me.Desarrollo = desarrollo
        Me.Chat = chat

    End Sub
End Class
