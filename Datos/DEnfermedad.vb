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
        Dim id As Short = -1
        Dim recordSet As Recordset
        Dim query = "SELECT id FROM enfermedades " &
                    "WHERE nombre='" & nombre & "';"

        If HasConnection() Then
            'Obtengo la conexión
            Dim con = Conectar()

            Try
                recordSet = con.Execute(query)


                'Si BOF (antes del primer registro) es verdadero
                'quiere decir que no hay registros.
                'No se encontró ninguna enfermedad con ese nombre.
                If Not recordSet.BOF Then

                    'Cuento la cantidad de registros
                    'Solo me servirá si el nombre coincide con
                    'una única enfermedad
                    Dim count As Integer = 0

                    ' Mientras que no esté mas adelante que
                    ' el último registro (EOF), ejecuto.
                    While Not recordSet.EOF
                        count += 1
                        id = CShort(recordSet.Fields("id").Value)
                        recordSet.MoveNext()
                    End While

                    If count > 1 Then
                        MsgBox("Más de una enfermedad encontrada para el nombre: " & nombre, MsgBoxStyle.Critical)
                    End If
                Else
                    'No se encontraron registros
                    MsgBox("No se encontró ninguna enfermedad con el nombre: " & nombre)
                End If

            Catch ex As Exception
                MsgBox("ERROR: " & ex.Message, MsgBoxStyle.Critical, "Find Enfermedad")
            End Try

            con.Close()
        End If
        Return id
    End Function

    Public Function Insert(nombre As String, descripcion As String, urgencia As String) As Boolean
        Dim saved = False

        If HasConnection() Then
            Dim con = Conectar()
            Dim insertQuery = "INSERT INTO enfermedades(nombre, descripcion, urgencia) " &
                              "VALUES('" & nombre & "','" & descripcion & "'," & urgencia & ");"

            Try
                con.Execute(insertQuery)
                saved = True
            Catch ex As Exception
                Console.WriteLine("Exception at DEnfermedad insert" & vbCrLf & ex.Message)
                saved = False
            End Try
            con.Close()
        End If
        Return saved
    End Function
End Class
