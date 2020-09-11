Imports ADODB
Imports Dominio
Public Class SintomaDAO
    Inherits DBConnection

    ''' <summary>
    ''' Ingresa un nuevo síntoma al sistema.
    ''' </summary>
    ''' <param name="sintoma">Objeto síntoma a ingresar.</param>
    Public Sub Insert(sintoma As Sintoma)

        Dim recordSet As Recordset
        Dim idSintoma As Short

        Dim insertSintoma = "INSERT INTO sintomas(nombre,descripcion,tipo) " &
                                "VALUES('" &
                                sintoma.Nombre & "','" &
                                sintoma.Descripcion & "'," &
                                sintoma.Tipo & ");"

        Dim selectSintoma = "SELECT id FROM sintomas " &
                                "WHERE nombre='" & sintoma.Nombre & "' AND descripcion='" & sintoma.Descripcion & "' AND tipo=" & sintoma.Tipo & ";"

        Try
            Conn = Connect()

        Catch ex As Exception
            Throw ex
        End Try
        Try
            Conn.BeginTrans()
            Conn.Execute(insertSintoma)
            recordSet = Conn.Execute(selectSintoma)

            'Asigno el valor del campo id
            'a la variable idSintoma
            idSintoma = recordSet.Fields("id").Value

            For Each enfermedad In sintoma.Enfermedades
                AddSintomaEnfermedad(idSintoma, enfermedad.Id)
            Next
            Conn.CommitTrans()

        Catch ex As Exception
            Conn.RollbackTrans()
            Throw ex
        Finally
            Conn.Close()
        End Try
    End Sub

    ''' <summary>
    ''' Asocia una síntoma a una enfermedad.
    ''' </summary>
    ''' <param name="idSintoma">ID del síntoma a asociar.</param>
    ''' <param name="idEnfermedad">ID de la enfermedad con la que se asocia el sítnoma.</param>
    Public Sub AddSintomaEnfermedad(idSintoma As Short, idEnfermedad As Short)
        Dim insert = "INSERT INTO enfermedades_sintomas(idSintoma, idEnfermedad) " &
                     "VALUES(" & idSintoma & "," & idEnfermedad & ");"
        Try
            Conn.Execute(insert)
        Catch ex As Exception
            Throw New Exception("Error al asociar el síntoma con una enfermedad.")
        End Try
    End Sub

    Public Sub DelSintomaEnfermedad(sintoma As Sintoma)
        Dim query = "DELETE FROM enfermedades_sintomas WHERE idSintoma=" & sintoma.Id & ";"
        Try
            Conn.Execute(query)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    ''' <summary>
    ''' Obtiene todos los síntomas almacenados en la base de datos.
    ''' </summary>
    ''' <returns>Retorna un DataTable con los síntomas recuperados</returns>
    Public Function GetSintomas() As DataTable
        Conn = Connect()
        Dim rs = Conn.Execute("SELECT id,nombre,descripcion,tipo FROM sintomas WHERE ENABLED=1")
        Dim da As New OleDb.OleDbDataAdapter()
        Dim dt As New DataTable
        da.Fill(dt, rs)
        Return dt
    End Function


    ''' <summary>
    ''' Obtiene de la base de datos aquellos síntomas que cumplan con los parámetros pasados.
    ''' </summary>
    ''' <param name="name">Parte del contenido del nombre del síntoma</param>
    ''' <param name="type">Tipo de síntoma</param>
    ''' <returns>Retorna un DataTable con los datos recuperados</returns>
    Public Function GetSintomas(name As String, type As Sintoma.TiposSintomas) As DataTable
        Try
            Conn = Connect()

        Catch ex As Exception
            Throw ex
        End Try

        Dim query = "SELECT id,nombre,descripcion,tipo FROM sintomas  WHERE ENABLED=1" & " AND nombre LIKE '%" & name & "%'" & " AND s.tipo=" & type & ";"

        Try
            Dim rs = Conn.Execute(query)
            Dim da As New OleDb.OleDbDataAdapter()
            Dim dt As New DataTable
            da.Fill(dt, rs)
            Return dt

        Catch ex As Exception
            Throw ex
        Finally
            Conn.Close()
        End Try
    End Function


    ''' <summary>
    ''' Obtiene de la base de datos aquellos síntomas que cumplan con los parámetros pasados.
    ''' </summary>
    ''' <param name="name">Parte del contenido del nombre</param>
    ''' <param name="type">Tipo de síntoma</param>
    ''' <param name="enfermedades">Enfermedades asociadas</param>
    ''' <returns>Retorna un DataTable con los datos recuperados</returns>
    Public Function GetSintomas(name As String, type As Sintoma.TiposSintomas, enfermedades As List(Of Enfermedad)) As DataTable
        Dim dt As New DataTable()
        Dim rs As Recordset
        Dim da As New OleDb.OleDbDataAdapter

        Dim query As String = "SELECT S.id AS ID," &
                                "S.nombre AS Sintoma, " &
                                "S.descripcion AS Descripcion, " &
                                "S.tipo AS Tipo " &
                                "FROM sintomas AS S " &
                                "LEFT JOIN enfermedades_sintomas AS ES " &
                                "ON (S.ID = ES.idSintoma) " &
                                "WHERE S.nombre LIKE '%" & name & "%' AND S.tipo=" & type & " "

        For Each enfermedad As Enfermedad In enfermedades
            query += " OR E.nombre LIKE '%" & enfermedad.Nombre & "%' "
        Next
        query += "AND ENABLED=1 ORDER BY S.nombre;"

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
            Throw New Exception("Error al filtrar síntomas.")

        Finally
            Conn.Close()
        End Try
    End Function

    ''' <summary>
    ''' Da la baja lógica a un síntoma
    ''' </summary>
    Public Sub Delete(id As Short)
        Dim query As String = "UPDATE sintomas SET ENABLED=0 WHERE id=" & id & ";"
        Try
            Conn = Connect()

        Catch ex As Exception
            Throw ex
        End Try

        Try
            Conn.Execute(query)
        Catch ex As Exception
            Throw New Exception("Error al eliminar síntoma.")
        Finally
            Conn.Close()
        End Try
    End Sub

    ''' <summary>
    ''' Modifica un un síntoma
    ''' </summary>
    ''' <param name="sintoma">Información actualizada</param>
    Public Sub Modify(sintoma As Sintoma)
        Dim Updatequery As String = "UPDATE sintomas SET nombre='" & sintoma.Nombre & "', descripcion='" & sintoma.Descripcion & "', tipo=" & sintoma.Tipo & " WHERE id= " & sintoma.Id & ""

        Try
            Conn = Connect()

        Catch ex As Exception
            Throw ex
        End Try

        Try
            Conn.BeginTrans()
            Conn.Execute(Updatequery)
            DelSintomaEnfermedad(Conn)

            For Each enfermeadad In sintoma.Enfermedades
                AddSintomaEnfermedad(sintoma.Id, enfermeadad.Id)
            Next

            Conn.CommitTrans()
        Catch ex As Exception
            Conn.RollbackTrans()
            Throw ex
        Finally
            Conn.Close()
        End Try
    End Sub

    ''' <summary>
    ''' Obtiene una lista de enfermedades asociadas al síntoma con el ID ingresado.
    ''' </summary>
    ''' <param name="id">ID del síntoma</param>
    ''' <returns>Retorna una lista de enfermedades asociadas al síntoma.</returns>
    Public Function GetEnfermedadesAsociadas(id As Short) As List(Of Enfermedad)
        Dim rs As New Recordset()
        Dim query = "SELECT ES.idEnfermedad, E.nombre, E.urgencia FROM enfermedades_sintomas AS ES JOIN enfermedades AS E ON(ES.idEnfermedad = E.id) WHERE idSintoma=" & id & ";"
        Dim enfermedades As New List(Of Enfermedad)
        Try
            Dim Conn = Connect()

        Catch ex As Exception
            Throw ex
        End Try

        Try
            rs = Conn.Execute(query)
            While Not rs.EOF
                Dim idEnfermedad = CShort(rs.Fields("idEnfermedad").Value)
                Dim nombre = rs.Fields("nombre").Value.ToString
                Dim urgencia = rs.Fields("urgencia").Value

                enfermedades.Add(New Enfermedad(id, nombre, urgencia))
                rs.MoveNext()
            End While
        Catch ex As Exception
            Throw ex
        Finally
            Conn.Close()
        End Try

        Return enfermedades
    End Function
End Class
