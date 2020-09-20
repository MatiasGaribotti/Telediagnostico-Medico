Imports ADODB
Imports Dominio
Public Class PacienteDAO
    Inherits PersonaDAO

    Public Sub Insert(paciente As Paciente)
        'Abro la conexión con la base de datos
        Try
            Conn = Connect()

        Catch ex As Exception
            Throw ex
        End Try

        Try
            'Abro transacción
            Conn.BeginTrans()
            InsertPersona(paciente)

            ' Sentencia para ingresar un paciente
            Dim updatePaciente = "UPDATE personas SET" &
                                  " esPaciente=TRUE," &
                                  " email='" & paciente.Email & "'," &
                                  " nucleoFlia='" & paciente.NucleoFlia & "'," &
                                  " antecedentesFlia='" & paciente.AntecedentesFlia & "'," &
                                  " antecedentesLab='" & paciente.AntecedentesLab & "'" &
                                  " WHERE ci=" & paciente.Ci & ";"
            'Ingreso los datos del paciente a la DB
            Conn.Execute(updatePaciente)

            'Hago el commit de la transacción y retorno True
            Conn.CommitTrans()

        Catch ex As ApplicationException
            'Excepcion que se produce durante el ingreso de direcciones
            Throw ex

        Catch ex As Exception
            'Hubo una excepción, por lo que debo hacer un rollback
            'para mantener la integridad de los datos.
            Conn.RollbackTrans()
            Throw New Exception("Error al ingresar el paciente.")
        Finally
            Conn.Close()
        End Try
    End Sub

    Public Sub Modify(pPaciente As Paciente)
        Dim query As String = "UPDATE personas SET " &
                               "email='" & pPaciente.Email & "', " &
                               "nucleoFlia='" & pPaciente.NucleoFlia & "', " &
                               "antecedentesFlia='" & pPaciente.AntecedentesFlia & "', " &
                               "antecedentesLab='" & pPaciente.AntecedentesLab & "' " &
                               "WHERE ci=" & pPaciente.Ci & ";"


        Try
            Conn = Connect()
        Catch ex As Exception
            Throw ex
        End Try

        Try
            Conn.BeginTrans()

            ModifyPersona(pPaciente)
            Conn.Execute(query)

            Conn.CommitTrans()
        Catch ex As Exception
            Conn.RollbackTrans()
            Throw New Exception("No se pudo modificar al paciente.")

        Finally
            Conn.Close()
        End Try

    End Sub

    Public Function GetPacienteByCi(ci As Integer) As DataTable
        Dim dt As New DataTable
        Dim rs As Recordset
        Dim da As New OleDb.OleDbDataAdapter

        Dim query = "SELECT * FROM pacientes WHERE ci=" & ci & ";"

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
            Throw New Exception("Error al obtener el paciente.")

        Finally
            Conn.Close()
        End Try
    End Function

    Public Function GetPacientes() As DataTable
        Dim dt As New DataTable()
        Dim rs As Recordset
        Dim da As New OleDb.OleDbDataAdapter()

        'Consulto los datos a la vista "pacientes"
        Dim query As String = "SELECT * FROM Pacientes;"

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
