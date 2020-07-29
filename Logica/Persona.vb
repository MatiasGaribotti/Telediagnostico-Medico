Imports Datos
Public Class Persona
    Public Function TestDBCon() As Boolean
        Dim db As New DBConnection()
        Return db.HasConnection()
    End Function
End Class
