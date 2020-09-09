Imports ADODB
Imports Dominio
Public Class DSintoma
    Inherits DBConnection
    Public Sub Insert()
        If HasConnection() Then
            Dim con As Connection = Conectar()
            Dim recordSet As Recordset
            Dim idSintoma As Short

            Dim insertSintoma = "INSERT INTO sintomas(nombre,descripcion,tipo) " &
                                "VALUES('" &
                                Nombre & "','" &
                                Descripcion & "'," &
                                Tipo & ");"

            Dim selectSintoma = "SELECT id FROM sintomas " &
                                "WHERE nombre='" & Nombre & "' AND descripcion='" & Descripcion & "' AND tipo=" & Tipo & ";"

            Try
                con.BeginTrans()
                con.Execute(insertSintoma)
                recordSet = con.Execute(selectSintoma)

                'Asigno el valor del campo id
                'a la variable idSintoma
                idSintoma = recordSet.Fields("id").Value

                For Each enfermedad In Enfermedades
                    AddSintomaEnfermedad(idSintoma, enfermedad.Id, con)
                Next
                con.CommitTrans()

            Catch ex As Exception
                con.RollbackTrans()
                Throw ex
            Finally
                con.Close()
            End Try
        Else
            Throw New ApplicationException("No hay conexión con la base de datos.")
        End If
    End Sub

    Public Sub AddSintomaEnfermedad(idSintoma As Short, idEnfermedad As Short, con As Connection)
        Dim insert = "INSERT INTO enfermedades_sintomas(idSintoma, idEnfermedad) " &
                     "VALUES(" & idSintoma & "," & idEnfermedad & ");"
        Try
            con.Execute(insert)
        Catch ex As Exception
            Throw New Exception("Error al asociar el síntoma con una enfermedad.")
            con.RollbackTrans()
        End Try
    End Sub

    Public Sub DelSintomaEnfermedad(con As Connection)
        Dim query = "DELETE FROM enfermedades_sintomas WHERE idSintoma=" & Me.Id & ";"
        Try
            con.Execute(query)
        Catch ex As Exception
            con.RollbackTrans()
        End Try
    End Sub

    Public Function GetSintomas() As DataTable
        Dim connection = Conectar()
        Dim rs = connection.Execute("SELECT id,nombre,descripcion,tipo FROM sintomas WHERE ENABLED=1")
        Dim da As New OleDb.OleDbDataAdapter()
        Dim dt As New DataTable
        da.Fill(dt, rs)
        Return dt
    End Function

    Public Function GetSintomas(query As String) As DataTable
        Dim connection = Conectar()
        Dim rs = connection.Execute(query)
        Dim da As New OleDb.OleDbDataAdapter()
        Dim dt As New DataTable
        da.Fill(dt, rs)
        Return dt
    End Function


    Public Function Filter() As DataTable
        Dim dt As New DataTable()
        Dim query As String = "SELECT S.id AS ID," &
                                "S.nombre AS Sintoma, " &
                                "S.descripcion AS Descripcion, " &
                                "S.tipo AS Tipo " &
                                "FROM sintomas AS S " &
                                "LEFT JOIN enfermedades_sintomas AS ES " &
                                "ON (S.ID = ES.idSintoma) " &
                                "WHERE S.nombre LIKE '%" & Nombre & "%' AND S.tipo=" & Tipo & " "

        If Enfermedades.Count > 0 Then
            For Each enfermedad As DEnfermedad In Enfermedades
                query += " OR E.nombre LIKE '%" & enfermedad.Nombre & "%' "
            Next
        End If
        query += "AND ENABLED=1 ORDER BY S.nombre;"

        If HasConnection() Then
            GetSintomas(query)
        End If

        Return dt
    End Function

    'Método que da la baja lógica a un síntoma
    Public Sub Delete()
        Dim query As String = "UPDATE sintomas SET ENABLED=0 WHERE id=" & Id & ";"

        If HasConnection() Then
            Dim con = Conectar()

            Try
                con.Execute(query)
            Catch ex As Exception
                Throw New Exception("Error al eliminar síntoma.")
            Finally
                con.Close()
            End Try
        End If
    End Sub

    Public Function Modify() As Boolean
        Dim Updatequery As String = "UPDATE sintomas SET nombre='" & Nombre & "', descripcion='" & Descripcion & "', tipo=" & Tipo & " WHERE id= " & Me.Id & ""

        If HasConnection() Then
            Dim con = Conectar()
            Try
                con.BeginTrans()
                con.Execute(Updatequery)
                DelSintomaEnfermedad(con)

                For Each enfermeadad In Enfermedades
                    AddSintomaEnfermedad(Id, enfermeadad.Id, con)
                Next
                con.CommitTrans()
                Return True
            Catch ex As Exception
                con.RollbackTrans()
                Throw ex
                Return False
            Finally
                con.Close()
            End Try
        Else
            Throw New ApplicationException("No hay conexión con la base de datos")
        End If
    End Function

    Public Function GetEnfermedadesAsociadas() As List(Of DEnfermedad)
        Dim rs As New Recordset()
        Dim query = "SELECT ES.idEnfermedad, E.nombre FROM enfermedades_sintomas AS ES JOIN enfermedades AS E ON(ES.idEnfermedad = E.id) WHERE idSintoma=" & Id & ";"
        Dim enfermedades As New List(Of DEnfermedad)

        If HasConnection() Then
            Dim con = Conectar()
            Try
                rs = con.Execute(query)
                While Not rs.EOF
                    Dim id = CShort(rs.Fields("idEnfermedad").Value)
                    Dim nombre = rs.Fields("nombre").Value.ToString
                    enfermedades.Add(New DEnfermedad(id, nombre, ""))
                    rs.MoveNext()
                End While
            Catch ex As Exception
                Console.WriteLine("ERROR: " & ex.Message)
            Finally
                con.Close()
            End Try

        End If
        Return enfermedades
    End Function


End Class
