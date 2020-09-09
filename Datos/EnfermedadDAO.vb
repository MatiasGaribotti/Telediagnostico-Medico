Imports ADODB
Imports Dominio
Public Class EnfermedadDAO
    Inherits DBConnection

    Public Function Find(nombre As String) As Short
        Dim id As Short = -1
        Dim recordSet As Recordset
        Dim query = "SELECT id FROM enfermedades " &
                    "WHERE nombre='" & nombre & "';"

        'Obtengo la conexión
        Try
            Conn = Conectar()
        Catch ex As Exception
            Throw ex
        End Try

        Try
            recordSet = Conn.Execute(query)


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
                    Throw New Exception("Más de una enfermedad encontrada para el nombre: " & nombre)
                Else
                    Return id
                End If
            Else
                'No se encontraron registros
                Throw New KeyNotFoundException("No se encontró ninguna enfermedad con el nombre: " & nombre)
            End If

        Catch ex As Exception
            Throw ex

        Finally
            Conn.Close()
        End Try
    End Function

    Public Function Insert(enfermedad As Enfermedad) As Boolean
        Dim saved = False

        Try
            Conn = Conectar()
        Catch ex As Exception
            Throw ex
        End Try

        Dim insertQuery = "INSERT INTO enfermedades(nombre, descripcion, urgencia) " &
                              "VALUES('" & enfermedad.Nombre & "','" & enfermedad.Descripcion & "'," & enfermedad.Urgencia & ");"

        Try
            Conn.Execute(insertQuery)
            saved = True
        Catch ex As Exception
            Console.WriteLine("Exception at DEnfermedad insert" & vbCrLf & ex.Message)
            saved = False
        End Try
        Conn.Close()

        Return saved
    End Function

    ' Funcion que obtiene de la BD las enfermedades
    ' que se encuentran en el sistema
    Public Function GetEnfermedades() As DataTable
        Dim dt As DataTable


        Return dt
    End Function

End Class
