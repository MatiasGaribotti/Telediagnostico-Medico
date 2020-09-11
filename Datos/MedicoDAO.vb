Imports ADODB
Imports Dominio
Public Class MedicoDAO
    Inherits EmpleadoDAO


    Public Sub Insert(medico As Medico)

        Dim rs As Recordset

        ' Sentencia para ingresar la direccion
        Dim insertDireccion = "INSERT INTO direcciones" &
                               "(calle, numero, localidad, departamento, detalle)" &
                               "VALUES ('" &
                               medico.Direccion.Calle & "'," &
                               medico.Direccion.Nro & ",'" &
                               medico.Direccion.Localidad & "','" &
                               medico.Direccion.Departamento & "','" &
                               medico.Direccion.Detalle & "');"

        ' Consulta para obtener el id de la dirección ingresada
        Dim getIdDireccion = "SELECT id FROM direcciones" &
                              " WHERE calle='" & medico.Direccion.Calle & "'" &
                              " AND numero='" & medico.Direccion.Nro & "'" &
                              " AND localidad='" & medico.Direccion.Localidad & "'" &
                              " AND departamento='" & medico.Direccion.Departamento & "';"

        'Abro la conexión con la base de datos
        Try
            Conn = Connect()

        Catch ex As Exception
            Throw ex
        End Try

        Try
            'Abro transacción
            Conn.BeginTrans()
            MsgBox(insertDireccion)
            'Ingreso la dirección a la DB
            Conn.Execute(insertDireccion)

            'Obtener idDireccion
            MsgBox(getIdDireccion)
            rs = Conn.Execute(getIdDireccion)
            MsgBox("ID Direccion: " & rs.Fields("id").Value)
            Dim idDireccion As Integer = rs.Fields("id").Value

            ' Sentencia para ingresar un paciente
            Dim insertMedico = "INSERT INTO personas(" &
                              "ci," &
                              "nombre," &
                              " apellidoP," &
                              " apellidoM," &
                              " fechaNacimiento," &
                              " telefono," &
                              " esMedico," &
                              " especialidad," &
                              " password," &
                              " idDireccion)" &
                              "VALUES(" &
                              medico.Ci & ",'" &
                              medico.Nombre & "','" &
                              medico.ApellidoP & "','" &
                              medico.ApellidoM & "','" &
                              Format(medico.Fecha_Nacimiento, "yyyy-MM-dd") & "'," &
                              medico.Telefono & "," &
                              "True" & ",'" &
                              medico.Especialidad & "','" &
                              medico.Password & "'," &
                              idDireccion &
                              ");"
            'Ingreso los datos del médico a la DB
            Conn.Execute(insertMedico)
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

    ''' <summary>
    ''' Extiende los privilegios del médico a los de un administrador del sistema.
    ''' </summary>
    ''' <param name="pCI">Cédula de identidad del médico.</param>
    Public Sub MakeAdministrator(pCI As Integer)
        Dim query = "UPDATE personas SET extendido=True WHERE ci='" & pCI & "';"

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