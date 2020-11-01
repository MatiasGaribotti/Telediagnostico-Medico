Imports Dominio
Imports ADODB
Public Class PersonaDAO
    Inherits DBConnection

    Private Enum SearchResult
        NotFound
        Enabled
        Disabled
    End Enum

    Public Sub UpdatePassword(ci As Integer, password As String)
        Dim query As String = "UPDATE personas SET password='" & password & "' WHERE ci='" & ci & "';"

        Try
            Conn = Connect()

        Catch ex As Exception
            Throw ex
        End Try

        Try
            Conn.Execute(query)
        Catch ex As Exception
            Throw New Exception("error_actualizar_contrasenna")
        Finally
            Conn.Close()
        End Try
    End Sub

    ''' <summary>
    ''' Ingresa una nueva persona al sistema. 
    ''' La trasacción para esta operación deberá ser abiera y cerrada 
    ''' por el método específico que la implemente.
    ''' </summary>
    ''' <param name="pPersona">Persona a ingresar a la base de datos.</param>
    Protected Sub InsertPersona(pPersona As Persona)
        Dim DireccionDAO As New DireccionDAO

        Try

            If GetPersona(pPersona.Ci) = SearchResult.NotFound Then
                'Ingreso la dirección a la DB
                DireccionDAO.Insert(pPersona.Direccion)
                Dim idDireccion = DireccionDAO.GetId(pPersona.Direccion)
                ' Sentencia para ingresar un paciente
                Dim query = "INSERT INTO personas(" &
                              "ci," &
                              "nombre," &
                              " apellidoP," &
                              " apellidoM," &
                              " sexo," &
                              " fechaNacimiento," &
                              " telefono," &
                              " password," &
                              " idDireccion)" &
                              "VALUES(" &
                              pPersona.Ci & ",'" &
                              pPersona.Nombre & "','" &
                              pPersona.ApellidoP & "','" &
                              pPersona.ApellidoM & "'," &
                              pPersona.Sexo & ",'" &
                              Format(pPersona.Fecha_Nacimiento, "yyyy-MM-dd") & "'," &
                              pPersona.Telefono & ",'" &
                              pPersona.Password & "'," &
                              idDireccion &
                              ");"
                Conn.Execute(query)

            ElseIf GetPersona(pPersona.Ci) = SearchResult.Disabled Then
                ModifyPersona(pPersona)

            Else
                Throw New Exception("error_persona_existente")
            End If
        Catch ex As Exception
            Throw New Exception("error_ingresar_persona")
        End Try
    End Sub

    Public Sub ModifyPersona(pPersona As Persona)
        Dim DireccionDAO As New DireccionDAO
        Dim modifyPersona As String = "UPDATE personas SET " &
                              "nombre='" & pPersona.Nombre & "', " &
                              "apellidoP='" & pPersona.ApellidoP & "', " &
                              "apellidoM='" & pPersona.ApellidoM & "', " &
                              "sexo=" & pPersona.Sexo & ", " &
                              "fechaNacimiento='" & Format(pPersona.Fecha_Nacimiento, "yyyy-MM-dd") & "', " &
                              "telefono=" & pPersona.Telefono & ", " &
                              "ENABLED=1" &
                              " WHERE ci=" & pPersona.Ci & ";"

        Dim idDireccion = DireccionDAO.GetIdByCi(pPersona.Ci)

        Dim modifyDireccion As String = "UPDATE direcciones SET " &
                                        "calle='" & pPersona.Direccion.Calle & "', " &
                                        "numero=" & pPersona.Direccion.Nro & ", " &
                                        "localidad='" & pPersona.Direccion.Localidad & "', " &
                                        "departamento=" & pPersona.Direccion.Departamento & ", " &
                                        "detalle='" & pPersona.Direccion.Detalle & "'" &
                                        " WHERE id=" & idDireccion & ";"
        Try

            Conn.Execute(modifyPersona)
            Conn.Execute(modifyDireccion)

        Catch ex As Exception
            Throw New Exception("error_modificar_persona")
        End Try
    End Sub
    Public Sub DeletePersona(pCi As Integer)
        Dim query = "UPDATE personas SET ENABLED=0 WHERE ci='" & pCi & "';"

        Try
            Conn = Connect()
        Catch ex As ApplicationException
            Throw ex
        End Try

        Try
            Conn.Execute(query)
        Catch ex As Exception
            Throw New Exception("error_eliminar_persona")
        Finally
            Conn.Close()
        End Try
    End Sub

    Private Function GetPersona(ci As Integer) As SearchResult
        Dim query = "SELECT enabled FROM personas WHERE ci=" & ci & ";"
        Dim rs As Recordset
        Dim dt As New DataTable
        Dim da As New OleDb.OleDbDataAdapter

        rs = Conn.Execute(query)
        da.Fill(dt, rs)

        If dt.Rows.Count = 1 Then
            Dim enabled = CBool(dt.Rows.Item(0).Field(Of Int16)("ENABLED"))
            If enabled Then
                Return SearchResult.Enabled
            Else
                Return SearchResult.Disabled

            End If
        Else
            Return SearchResult.NotFound

        End If
    End Function
End Class
