Imports ADODB
Imports Dominio
Public Class ConsultaDAO
    Inherits DBConnection

    Public Function Insert(pConsulta As Autoconsulta) As Autoconsulta
        Try
            Conn = Connect()
        Catch ex As Exception
            Throw ex
        End Try

        Dim formattedDate As String = pConsulta.FechaHora.ToString("yyyy-MM-dd HH:mm:ss")

        Dim query As String = "INSERT INTO consultas(idSucursal,ciPaciente, fechaHora) VALUES(" & pConsulta.Sucursal.Id & "," & pConsulta.Paciente.Ci & ", '" & formattedDate & "');"
        Dim getIdConsulta As String = "SELECT id FROM consultas WHERE idSucursal=" & pConsulta.Sucursal.Id & " AND ciPaciente=" & pConsulta.Paciente.Ci & " AND fechaHora ='" & formattedDate & "';"
        Try
            Conn.BeginTrans()
            Conn.Execute(query)
            pConsulta.Id = Int64.Parse(Conn.Execute(getIdConsulta).Fields.Item(0).Value)

            For Each sintoma In pConsulta.Sintomas
                InsertRegistra(pConsulta.Id, sintoma.Id)
            Next

            For Each enfermedad In pConsulta.Diagnosticos
                    InsertDiagnostico(pConsulta.Id, enfermedad.Id, True)
                Next

                Conn.CommitTrans()

        Catch ex As Exception
            Conn.RollbackTrans()
            Throw New Exception("Error al ingresar la consulta.")
        Finally
            Conn.Close()
        End Try

        Return pConsulta
    End Function

    Public Sub InsertDiagnostico(idConsulta As Int64, idEnfermedad As Short, autoconsulta As Boolean)
        Dim query As String = "INSERT INTO diagnostica(idConsulta, idEnfermedad, tipoConsulta) VALUES(" & idConsulta & "," & idEnfermedad & ","

        If autoconsulta Then
            query += "'Autoconsulta');"

        Else
            query += "'Médica');"

        End If

        If Conn.State = ObjectStateEnum.adStateOpen Then
            Try
                Conn.Execute(query)
            Catch ex As Exception
                Throw ex
            End Try
        Else
            Throw New Exception("Conexión con la base de datos cerrada.")
        End If
    End Sub

    Public Sub InsertRegistra(idConsulta As Int64, idSintoma As Short)
        Dim query As String = "INSERT INTO registra(idConsulta, idSintoma) VALUES(" & idConsulta & "," & idSintoma & ");"

        If Conn.State = ObjectStateEnum.adStateOpen Then
            Try
                Conn.Execute(query)

            Catch ex As Exception
                Throw ex
            End Try
        Else
            Throw New Exception("Conexión con la base de datos cerrada.")

        End If
    End Sub
End Class
