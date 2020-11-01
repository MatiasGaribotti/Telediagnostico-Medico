Imports ADODB
Imports Dominio
Public Class SintomaDAO
    Inherits DBConnection


    ''' <summary>
    ''' Ingresa un nuevo síntoma al sistema.
    ''' </summary>
    ''' <param name="sintoma">Objeto síntoma a ingresar.</param>
    Public Sub Insert(sintoma As Sintoma)
        Dim EnfermedadDAO As New EnfermedadDAO
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
                enfermedad.Id = EnfermedadDAO.GetEnfermedadByName(enfermedad.Nombre)
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

    Public Sub Insert(listaSintomas As List(Of Sintoma))

        For Each sintoma In listaSintomas
            Dim EnfermedadDAO As New EnfermedadDAO

            For Each enfermedad In sintoma.Enfermedades
                enfermedad.Id = EnfermedadDAO.GetEnfermedadByName(enfermedad.Nombre.Trim)
            Next

        Next

        Try
            Conn = Connect()
        Catch ex As Exception
            Throw ex
        End Try

        Try

            For Each sintoma In listaSintomas
                Conn.BeginTrans()
                Dim search = GetSintomaByName(sintoma.Nombre)
                If search IsNot Nothing Then
                    If Not search.Enabled Then
                        Dim enableSymptom = "UPDATE sintomas SET ENABLED=1 WHERE id=" & search.Id & ";"
                    End If

                Else
                    Dim recordSet As Recordset

                    Dim insertSintoma = "INSERT INTO sintomas(nombre,descripcion,tipo) " &
                                        "VALUES('" &
                    sintoma.Nombre & "','" &
                    sintoma.Descripcion & "'," &
                    sintoma.Tipo & ");"

                    Dim selectSintoma = "SELECT id FROM sintomas " &
                                        "WHERE nombre='" & sintoma.Nombre & "';"


                    Conn.Execute(insertSintoma)
                    recordSet = Conn.Execute(selectSintoma)

                    'Asigno el valor del campo id
                    'a la variable idSintoma
                    sintoma.Id = recordSet.Fields("id").Value

                End If

                For Each enfermedad In sintoma.Enfermedades
                    Try
                        AddSintomaEnfermedad(sintoma.Id, enfermedad.Id)

                    Catch ex As Exception

                    End Try
                Next
                Conn.CommitTrans()
            Next


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
        Conn.Execute(insert)
    End Sub

    Public Sub DelSintomaEnfermedad(idSintoma As Integer)
        Dim query = "DELETE FROM enfermedades_sintomas WHERE idSintoma=" & idSintoma & ";"
        Try
            Conn.Execute(query)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function GetSintomaByName(name As String) As Sintoma
        Dim query As String = "SELECT * FROM sintomas WHERE nombre='" & name & "';"
        Dim rs As Recordset
        Dim dt As New DataTable
        Dim da As New OleDb.OleDbDataAdapter

        rs = Conn.Execute(query)
        da.Fill(dt, rs)

        If dt.Rows.Count = 1 Then
            Dim row = dt.Rows.Item(0)
            Dim id = row.Field(Of Int32)("id")
            Dim tipo = [Enum].Parse(GetType(Sintoma.TiposSintomas), row.Field(Of String)("tipo"))
            Dim descripcion = row.Field(Of String)("descripcion")
            Dim enabled = CBool(row.Field(Of Int16)("ENABLED"))

            Return New Sintoma(id, name, descripcion, tipo, enabled)

        Else
            Return Nothing
        End If
    End Function

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
    ''' <returns>Retorna un DataTable con los datos recuperados</returns>
    Public Function GetSintomas(name As String) As DataTable
        Try
            Conn = Connect()

        Catch ex As Exception
            Throw ex
        End Try

        Dim query = "SELECT id,nombre,descripcion,tipo FROM sintomas AS S WHERE ENABLED=1" & " AND nombre LIKE '%" & name & "%';"

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
    ''' <param name="type">Tipo de sítntoma.</param>
    ''' <returns>Retorna un DataTable con los datos recuperados</returns>
    Public Function GetSintomas(type As Sintoma.TiposSintomas) As DataTable
        Try
            Conn = Connect()

        Catch ex As Exception
            Throw ex
        End Try

        Dim query = "SELECT id,nombre,descripcion,tipo FROM sintomas AS S WHERE ENABLED=1" & " AND S.tipo=" & type & ";"

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
    ''' <param name="name">Parte del contenido del nombre del síntoma</param>
    ''' <param name="type">Tipo de síntoma</param>
    ''' <returns>Retorna un DataTable con los datos recuperados</returns>
    Public Function GetSintomas(name As String, type As Sintoma.TiposSintomas) As DataTable
        Try
            Conn = Connect()

        Catch ex As Exception
            Throw ex
        End Try

        Dim query = "SELECT id,nombre,descripcion,tipo FROM sintomas AS S WHERE ENABLED=1" & " AND nombre LIKE '%" & name & "%'" & " AND S.tipo=" & type & ";"

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
                                "JOIN enfermedades AS E " &
                                "ON (ES.idEnfermedad = E.id) " &
                                "WHERE S.nombre LIKE '%" & name & "%' AND S.tipo=" & type & " AND ("

        Dim counter As Integer = 0

        For Each enfermedad As Enfermedad In enfermedades
            If counter = 0 Then
                query += " E.nombre LIKE '%" & enfermedad.Nombre & "%' "
            Else
                query += " OR E.nombre LIKE '%" & enfermedad.Nombre & "%' "

            End If
            counter += 1
        Next
        query += ") AND S.ENABLED=1 AND E.ENABLED=1 ORDER BY S.nombre;"

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
            Throw New Exception("Error al eliminar el síntoma ")
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
            DelSintomaEnfermedad(sintoma.Id)

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
        Dim query = "SELECT ES.idEnfermedad, E.nombre, E.descripcion, E.urgencia, E.cronica FROM enfermedades_sintomas AS ES JOIN enfermedades AS E ON(ES.idEnfermedad = E.id) WHERE idSintoma=" & id & " AND ENABLED=TRUE;"
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
                Dim descripcion = rs.Fields("descripcion").Value.ToString
                Dim urgencia = [Enum].Parse(GetType(Enfermedad.Urgencias), rs.Fields("urgencia").Value)
                Dim cronica = CBool(rs.Fields("cronica").Value)

                enfermedades.Add(New Enfermedad(idEnfermedad, nombre, descripcion, urgencia, cronica))
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
