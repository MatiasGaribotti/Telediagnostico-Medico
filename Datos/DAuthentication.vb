Imports ADODB
Public Class DAuthentication
    Inherits DBConnection
    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(user As String, password As String)
        MyBase.New(user, password)
    End Sub

    Public Function Find(ci As Integer, password As String) As Recordset
        Dim rs As Recordset
        Dim query As String = "SELECT ci, esMedico, extendido, esPaciente, esPersonalRRHH, esRecepcionista FROM personas WHERE ci='" & ci & "' AND password='" & password & "';"

        If HasConnection() Then
            Dim con = Conectar()
            Try
                rs = con.Execute(query)
                Return rs
            Catch ex As Exception
                Console.WriteLine("ERROR en DAuthentication Find" & vbCrLf & ex.Message)
                Return Nothing
                'DataSet
            End Try
        End If
    End Function
End Class
