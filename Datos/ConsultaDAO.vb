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

            InsertChat(pConsulta.Id)

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

    Public Sub InsertChat(idConsulta As Int64)
        Dim query As String = "INSERT INTO chats(idConsulta) VALUES(" & idConsulta & ");"

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

    Public Function GetChats() As DataTable
        Dim dt As New DataTable
        Dim rs As Recordset
        Dim da As New OleDb.OleDbDataAdapter

        Dim query As String = "SELECT * FROM Solicitudes_Chats;"

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
            Throw ex

        Finally
            Conn.Close()
        End Try

        Return dt
    End Function

    Public Sub StartChat(idConsulta As Int64, ciMedico As Integer)
        Dim query As String = "INSERT INTO atienden(idConsulta,ciMedico)" &
                               "VALUES(" & idConsulta & "," & ciMedico & ");"

        Try
            Conn = Connect()
        Catch ex As Exception
            Throw ex
        End Try

        Try
            Conn.Execute(query)
        Catch ex As Exception
            Throw ex

        Finally
            Conn.Close()
        End Try

    End Sub

    Public Function GetChatId(idConsulta As Long) As DataTable
        Dim rs As Recordset
        Dim da As New OleDb.OleDbDataAdapter
        Dim dt As New DataTable

        Dim query As String = "SELECT id FROM chats WHERE idConsulta=" & idConsulta & ";"

        Try
            Conn = Connect()
        Catch ex As Exception
            Throw ex
        End Try

        Try
            rs = Conn.Execute(query)
            da.Fill(dt, rs)
        Catch ex As Exception
            Throw ex
        Finally
            Conn.Close()
        End Try

        Return dt
    End Function

    Public Function GetMensajesChat(idChat As Long, Optional startIndex As Long = 0) As DataTable
        Dim rs As Recordset
        Dim dt As New DataTable
        Dim da As New OleDb.OleDbDataAdapter

        Dim query As String = "SELECT id, ciPersona, fechaHora FROM mensajes WHERE idChat=" & idChat & " AND id > " & startIndex & ";"

        Try
            Conn = Connect()
        Catch ex As Exception
            Throw ex
        End Try

        Try
            rs = Conn.Execute(query)
            da.Fill(dt, rs)

        Catch ex As Exception
            Throw ex

        Finally
            Conn.Close()
        End Try

        Return dt
    End Function

    Public Sub SendMsg(idChat As Long, msg As Mensaje)
        Dim query As String = "INSERT INTO mensajes(idChat,ciPersona,fechaHora,mensaje) VALUES(" & idChat & ", " & msg.CiPersona & ", '" & msg.Timestamp.ToString("yyyy-MM-dd H:mm:ss") & "','" & msg.Texto & "');"

        Try
            Conn = Connect()
        Catch ex As Exception
            Throw ex
        End Try

        Try
            Conn.Execute(query)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function GetChat(idConsulta As Long) As DataTable
        Dim rs As Recordset
        Dim dt As New DataTable
        Dim da As New OleDb.OleDbDataAdapter

        Dim query As String = "SELECT CH.id, A.ciMedico " &
                              "FROM consultas AS C " &
                               "JOIN chats AS CH " &
                                   "ON(C.id = CH.idConsulta) " &
                               "JOIN atienden AS A " &
                                   "ON(C.id = A.idConsulta) WHERE C.id=" & idConsulta & ";"

        Try
            Conn = Connect()
        Catch ex As Exception
            Throw ex
        End Try

        Try
            rs = Conn.Execute(query)
            da.Fill(dt, rs)

        Catch ex As Exception
            Throw ex

        Finally
            Conn.Close()
        End Try

        Return dt
    End Function
End Class
