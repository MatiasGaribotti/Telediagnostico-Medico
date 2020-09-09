Imports ADODB
Imports Dominio
Public Class PacienteDAO
    Inherits PersonaDAO

    Public Sub Insert(paciente As Paciente)
        Dim rs As Recordset

        ' Sentencia para ingresar la direccion
        Dim insertDireccion = "INSERT INTO direcciones" &
                                   "(calle, numero, localidad, departamento, detalle)" &
                                   "VALUES ('" &
                                   paciente.Direccion.Calle & "'," &
                                   paciente.Direccion.Nro & ",'" &
                                   paciente.Direccion.Localidad & "','" &
                                   paciente.Direccion.Departamento & "','" &
                                   paciente.Direccion.Detalle & "');"

        ' Consulta para obtener el id de la dirección ingresada
        Dim getIdDireccion = "SELECT id FROM direcciones" &
                                  " WHERE calle='" & paciente.Direccion.Calle & "'" &
                                  " AND numero='" & paciente.Direccion.Nro & "'" &
                                  " AND localidad='" & paciente.Direccion.Localidad & "'" &
                                  " AND departamento=" & paciente.Direccion.Departamento & ";"

        'Abro la conexión con la base de datos
        Try
            Conn = Conectar()

        Catch ex As Exception
            Throw ex
        End Try

        Try
            'Abro transacción
            Conn.BeginTrans()

            'Ingreso la dirección a la DB
            Dim DireccionDAO As New DireccionDAO
            DireccionDAO.Insert(paciente.Direccion)

            'Obtener idDireccion
            'MsgBox(getIdDireccion)
            rs = Conn.Execute(getIdDireccion)
            'MsgBox("ID Direccion: " & rs.Fields("id").Value)
            Dim idDireccion As Integer = rs.Fields("id").Value

            ' Sentencia para ingresar un paciente
            Dim insertPaciente = "INSERT INTO personas(" &
                                  "ci," &
                                  "nombre," &
                                  " apellidoP," &
                                  " apellidoM," &
                                  " fechaNacimiento," &
                                  " telefono," &
                                  " esPaciente," &
                                  " email," &
                                  " nucleoFlia," &
                                  " antecedentesFlia," &
                                  " antecedentesLab," &
                                  " password," &
                                  " idDireccion)" &
                                  "VALUES(" &
                                  paciente.Ci & ",'" &
                                  paciente.Nombre & "','" &
                                  paciente.ApellidoP & "','" &
                                  paciente.ApellidoM & "','" &
                                  Format(paciente.Fecha_Nacimiento, "yyyy-MM-dd") & "'," &
                                  paciente.Telefono & "," &
                                  "True" & ",'" &
                                  paciente.Email & "','" &
                                  paciente.NucleoFlia & "','" &
                                  paciente.AntecedentesFlia & "','" &
                                  paciente.AntecedentesLab & "','" &
                                  paciente.Password & "'," &
                                  idDireccion &
                                  ");"
            'Ingreso los datos del paciente a la DB
            Conn.Execute(insertPaciente)

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

    Public Function GetPacientes() As DataTable
        Dim dt As New DataTable()
        Dim rs As Recordset
        Dim da As New OleDb.OleDbDataAdapter()

        'Consulto los datos a la vista "pacientes"
        Dim query As String = "SELECT * FROM Pacientes;"

        Try
            Conn = Conectar()

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


    Public Function Find(ci As Integer) As Paciente
        Dim paciente As Paciente

        Dim con = Conectar()
        Dim query As String = ""

        Return paciente
    End Function

End Class
