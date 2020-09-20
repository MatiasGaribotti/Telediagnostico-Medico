Imports ADODB
Imports Dominio
Public Class MedicoDAO
    Inherits EmpleadoDAO


    Public Sub Insert(medico As Medico)
        Dim DireccionDAO As New DireccionDAO
        Dim query As String = "UPDATE personas SET esMedico=1 WHERE ci=" & medico.Ci & ";"
        Try
            Conn = Connect()
        Catch ex As Exception
            Throw ex
        End Try

        Try
            'Abro transacción
            Conn.BeginTrans()
            InsertEmpleado(medico)

            For Each especialidad In medico.Especialidades
                InsertMedicoEspecialidad(medico.Ci, especialidad.Id)
            Next

            Conn.CommitTrans()

        Catch ex As Exception
            'Hubo una excepción, por lo que debo hacer un rollback
            'para mantener la integridad de los datos.
            Conn.RollbackTrans()
            Throw New Exception("No se pudo insertar el médico.")
        Finally
            Conn.Close()
        End Try
    End Sub

    Public Sub InsertMedicoEspecialidad(ci As Integer, idEspecialidad As Integer)
        Dim query As String = "INSERT INTO medicos_especialidades(ciMedico, idEspecialidad) " &
                              "VALUES(" & ci & ", " & idEspecialidad & ");"

        Try
            Conn.Execute(query)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub DeleteMedicoEspecialidades(ci As Integer)
        Dim query As String = "DELETE FROM medicos_especialidades WHERE ciMedico=" & ci & ";"

        Try
            Conn.Execute(query)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub ModifyMedico(pMedico As Medico)

        Try
            Conn = Connect()
        Catch ex As Exception
            Throw ex
        End Try

        Try
            Conn.BeginTrans()
            ModifyPersona(pMedico)
            DeleteMedicoEspecialidades(pMedico.Ci)

            For Each especialidad In pMedico.Especialidades
                InsertMedicoEspecialidad(pMedico.Ci, especialidad.Id)

            Next

            Conn.CommitTrans
        Catch ex As Exception
            Conn.RollbackTrans()
            Throw New Exception("No se pudo modificar el médico.")

        Finally
            Conn.Close()
        End Try
    End Sub

    Public Function GetEmpleados() As DataTable
        Dim rs As Recordset
        Dim dt As New DataTable()
        Dim da As New OleDb.OleDbDataAdapter

        'Consulto los datos a la vista "pacientes"
        Dim query As String = "SELECT * FROM Empleados;"

        Try
            Conn = Connect()

        Catch ex As Exception
            Throw ex
        End Try
        Try
            rs = Conn.Execute(query)

            da.Fill(dt, rs)

        Catch ex As Exception
            Throw New Exception("Error al obtener los datos de los Empeleados.")
        Finally
            Conn.Close()
        End Try

        Return dt
    End Function

    Public Function GetEspecialidades() As DataTable
        Dim rs As Recordset
        Dim da As New OleDb.OleDbDataAdapter
        Dim dt As New DataTable

        Dim query = "SELECT * FROM especialidades;"

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
            Throw New Exception("Error al buscar especialidades.")
        Finally
            Conn.Close()
        End Try
    End Function

    Public Function GetEspecialidad(pNombre As String) As DataTable
        Dim dt As New DataTable
        Dim rs As Recordset
        Dim da As New OleDb.OleDbDataAdapter
        Dim query = "SELECT * FROM especialidades WHERE nombre='" & pNombre & "';"

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
            Throw New Exception("Error al obtener la especialidad " & pNombre & ".")
        End Try
    End Function

    Public Function GetMedicoEspecialidades(pCi As Integer) As DataTable
        Dim dt As New DataTable
        Dim da As New OleDb.OleDbDataAdapter
        Dim rs As Recordset

        Dim query As String = "SELECT idEspecialidad, nombre " &
                              "FROM medicos_especialidades AS ME" &
                              "JOIN especialidades AS E " &
                              "ON (ME.idEspecialidad = E.id) WHERE ci=" & pCi & ";"

        Try
            Conn = Connect
        Catch ex As Exception
            Throw ex
        End Try

        Try
            rs = Conn.Execute(query)
            da.Fill(dt, rs)
            Return dt
        Catch ex As Exception
            Throw New Exception("Error al obtener las especialidades del médico.")
        End Try
    End Function

    ''' <summary>
    ''' Extiende los privilegios del médico a los de un administrador del sistema.
    ''' </summary>
    ''' <param name="pCI">Cédula de identidad del médico.</param>
    Public Sub MakeAdministrator(pCI As Integer)
        Dim query = "UPDATE personas SET extendido=TRUE WHERE ci='" & pCI & "';"

        Try
            Conn = Connect()
        Catch ex As ApplicationException
            Throw ex
        End Try

        Try
            Conn.Execute(query)
        Catch ex As Exception
            Throw New Exception("Error al intenter hacer administrador al usuario.")
        Finally
            Conn.Close()
        End Try
    End Sub

End Class