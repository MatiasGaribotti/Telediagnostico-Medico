Imports Datos
Imports Dominio
Public Class ConsultaBUS
    Public Property consulta As ConsultaMedica

    Public Sub New()
        consulta = New ConsultaMedica(AutoconsultaBUS.instance.consulta)
    End Sub
End Class
