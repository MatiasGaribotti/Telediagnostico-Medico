Imports ADODB
Public Class DEnfermedad
    Inherits DBConnection
    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(user As String, password As String)
        MyBase.New(user, password)
    End Sub

    Public Function Find(nombre) As Short
        Dim id = -1
        Dim recordSet As Recordset
        Dim query = "SELECT id FROM enfermedades " &
                    "WHERE nombre='" & nombre & "';"

        If HasConnection() Then
            Dim con = Conectar()

            Try
                recordSet = con.Execute(query)

                If recordSet.RecordCount = 0 Then
                    MsgBox("No se ha encontrado la enfermedad " & nombre & ".")
                    id = -1

                ElseIf recordSet.RecordCount > 1 Then
                    MsgBox("Se ha encontrado más de una enfermedad.")
                    id = -1
                ElseIf recordSet.RecordCount = 1 Then
                    'Mensaje de Debug
                    Console.WriteLine("ENFERMEDAD FOUND: " & nombre & "," & id)
                    id = recordSet.Fields("id").Value
                End If

            Catch ex As Exception
                MsgBox("No se ha encontrado la enfermedad " & nombre & ".")
                id = -1
            End Try
        End If

        Return id
    End Function
End Class
