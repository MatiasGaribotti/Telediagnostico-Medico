Imports ADODB
Imports Dominio
''' <summary>
''' Clase de accesso a la base de datos para patologías.
''' </summary>
Public Class EnfermedadDAO
    Inherits DBConnection

    ''' <summary>
    ''' Obtiene el ID de una enfermedad a partir de su nombre.
    ''' </summary>
    ''' <param name="nombre">Nombre de la enfermedad a buscar.</param>
    ''' <returns>Retorna el ID de la enfermedad engcontrada. Si encuentra más de una </returns>
    ''' <exception cref="Exception">Tirada cuando se encuentra más de una enfermedad con el nombre pasado como parámetro.</exception>
    ''' <exception cref="KeyNotFoundException">Tirada cuando no se encuentra ninguna enfermedad con el nombre pasado como parámetro.</exception>
    Public Function GetEnfermedadByName(nombre As String) As Short
        Dim id As Short = -1
        Dim recordSet As Recordset
        Dim query = "SELECT id FROM enfermedades " &
                    "WHERE nombre='" & nombre & "';"

        Try
            Conn = Connect()
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

    ''' <summary>
    ''' Comprueba si una enfermedad existe o no en el sistema.
    ''' </summary>
    ''' <param name="pName">Nombre de la enfermedad</param>
    ''' <returns>Retorna True si existe, de lo contrario False.</returns>
    Public Function ExistsEnfermedad(pName As String) As Boolean
        Try
            GetEnfermedadByName(pName)
            Return True
        Catch ex As KeyNotFoundException
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Ingresa una nueva enfermedad a la base de datos.
    ''' </summary>
    ''' <param name="enfermedad">Enfermedad a ingresar.</param>
    ''' <exception cref="ApplicationException">Tirada cuando no se pudo conectar con la base de datos.</exception>
    ''' <exception cref="Exception">Tirada cuando hubo un error en el ingreso de la enfermedad.</exception>
    Public Sub Insert(enfermedad As Enfermedad)

        Try
            Conn = Connect()
        Catch ex As ApplicationException
            Throw ex
        End Try

        Dim insertQuery = "INSERT INTO enfermedades(nombre, descripcion, urgencia, cronica) " &
                              "VALUES('" & enfermedad.Nombre & "','" & enfermedad.Descripcion & "'," & enfermedad.Urgencia & ", " & enfermedad.Cronica & ");"

        Try
            Conn.Execute(insertQuery)
        Catch ex As Exception
            Throw New Exception("error_enfermedad_ingresar " & enfermedad.Nombre & ".")
        Finally
            Conn.Close()

        End Try

    End Sub

    Public Sub Insert(enfermedades As List(Of Enfermedad))
        Try
            Conn = Connect()
        Catch ex As ApplicationException
            Throw ex
        End Try

        Conn.BeginTrans()
        Try

            For Each enfermedad In enfermedades

                Dim insertQuery = "INSERT INTO enfermedades(nombre, descripcion, urgencia, cronica) " &
                              "VALUES('" & enfermedad.Nombre & "','" & enfermedad.Descripcion & "'," & enfermedad.Urgencia & ", " & enfermedad.Cronica & ");"

                Conn.Execute(insertQuery)

            Next

            Conn.CommitTrans()
        Catch ex As Exception
            Conn.RollbackTrans()
            Throw New Exception(ex.Message)

        Finally
            Conn.Close()

        End Try

    End Sub

    Public Sub Modify(enfermedad As Enfermedad)
        Dim query = "UPDATE enfermedades SET nombre='" & enfermedad.Nombre & "', descripcion='" & enfermedad.Descripcion & "', urgencia=" & enfermedad.Urgencia & ", cronica=" & enfermedad.Cronica & " WHERE id=" & enfermedad.Id & ";"

        Try
            Conn = Connect()
        Catch ex As Exception
            Throw ex
        End Try

        Try
            Conn.Execute(query)
        Catch ex As Exception
            Throw New Exception("error_enfermedad_modificar")
        End Try

    End Sub

    Public Sub Delete(id As Short)
        Dim query = "UPDATE enfermedades SET ENABLED=0 WHERE id=" & id & ";"

        Try
            Conn = Connect()
        Catch ex As ApplicationException
            Throw ex
        End Try

        Try
            Conn.Execute(query)
        Catch ex As Exception
            Throw New Exception("error_enfermedad_eliminar")

        Finally
            Conn.Close()

        End Try
    End Sub

    ''' <summary>
    ''' Función que obtiene las enferemedades desde la base de datos.
    ''' </summary>
    ''' <returns>Retorna un objeto DataTable con las enfermedades halladas.</returns>
    ''' <exception cref="ApplicationException">Tirada cuando no se pudo conectar con la base de datos.</exception>
    ''' <exception cref="Exception">Tirada cuando hubo un error en la obtención de las enferemedades.</exception>
    Public Function GetEnfermedades() As DataTable
        Dim dt As New DataTable
        Dim rs As Recordset
        Dim da As New OleDb.OleDbDataAdapter
        Dim query = "SELECT id, nombre, cronica, urgencia, descripcion FROM enfermedades WHERE ENABLED=1;"

        Try
            Conn = Connect()
        Catch ex As ApplicationException
            Throw ex
        End Try

        Try
            rs = Conn.Execute(query)
            da.Fill(dt, rs)

        Catch ex As Exception
            Throw New Exception("Error al intener obtener enfermedades.")

        Finally
            Conn.Close()
        End Try

        Return dt
    End Function

    Public Function GetEnfermedades(nombre As String, urgencia As Enfermedad.Urgencias, cronica As Boolean) As DataTable
        Dim dt As New DataTable
        Dim rs As Recordset
        Dim da As New OleDb.OleDbDataAdapter
        Dim query = "SELECT id, nombre, cronica, urgencia, descripcion FROM enfermedades WHERE ENABLED=1 AND " &
            "nombre LIKE '%" & nombre & "%' AND " &
            "urgencia=" & urgencia & " AND " &
            "cronica=" & cronica & "" &
            ";"

        Try
            Conn = Connect()
        Catch ex As ApplicationException
            Throw ex
        End Try

        Try
            rs = Conn.Execute(query)
            da.Fill(dt, rs)

        Catch ex As Exception
            Throw New Exception("Error al intener obtener enfermedades.")

        Finally
            Conn.Close()
        End Try

        Return dt
    End Function

    Public Function GetSintomasAsociados(pIdEnfermedad As Short) As DataTable
        Dim dt As New DataTable
        Dim rs As Recordset
        Dim da As New OleDb.OleDbDataAdapter
        Dim query As String = "SELECT ES.idSintoma, S.nombre, S.descripcion, S.tipo FROM enfermedades_sintomas AS ES JOIN sintomas AS S ON(ES.idSintoma = S.id) WHERE idEnfermedad=" & pIdEnfermedad & " AND ENABLED=TRUE;"

        Try
            Conn = Connect()
        Catch ex As Exception
            Throw ex
        End Try

        Try
            rs = Conn.Execute(query)
            da.Fill(dt, rs)
            Return dt

        Catch ex As Exception
            Throw New Exception("No se pudo obtener los síntomas asociados.")
        End Try
    End Function

End Class
