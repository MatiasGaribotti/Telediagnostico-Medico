Imports System.Data.Odbc
Imports ADODB
Public Class DMedico
    Inherits DEmpleado

    Public Sub New(user As String, password As String)
        MyBase.New(user, password)
    End Sub

    Public Function Insert(
            ci As Integer,
            nombre As String,
            apellidoP As String,
            apellidoM As String,
            calle As String,
            nro As Integer,
            localidad As String,
            departamento As String,
            detalle As String,
            telefono As Integer,
            fecha_nacimiento As String,
            especialidad As String,
            Password As String) As Boolean

        If HasConnection() Then

            Dim rs As Recordset

            ' Sentencia para ingresar la direccion
            Dim insertDireccion = "INSERT INTO direcciones" &
                                   "(calle, numero, localidad, departamento, detalle)" &
                                   "VALUES ('" &
                                   calle & "'," &
                                   nro & ",'" &
                                   localidad & "','" &
                                   departamento & "','" &
                                   detalle & "');"

            ' Consulta para obtener el id de la dirección ingresada
            Dim getIdDireccion = "SELECT id FROM direcciones" &
                                  " WHERE calle='" & calle & "'" &
                                  " AND numero='" & nro & "'" &
                                  " AND localidad='" & localidad & "'" &
                                  " AND departamento='" & departamento & "';"

            'Abro la conexión con la base de datos
            Dim con As Connection = Conectar()

            Try
                'Abro transacción
                con.BeginTrans()
                MsgBox(insertDireccion)
                'Ingreso la dirección a la DB
                con.Execute(insertDireccion)

                'Obtener idDireccion
                MsgBox(getIdDireccion)
                rs = con.Execute(getIdDireccion)
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
                                  ci & ",'" &
                                  nombre & "','" &
                                  apellidoP & "','" &
                                  apellidoM & "','" &
                                  fecha_nacimiento & "'," &
                                  telefono & "," &
                                  "True" & ",'" &
                                  especialidad & "','" &
                                  Password & "'," &
                                  idDireccion &
                                  ");"
                MsgBox("Query Medico: " & insertMedico)

                'Ingreso los datos del médico a la DB
                con.Execute(insertMedico)

                'Hago el commit de la transacción y retorno True
                con.CommitTrans()
                Return True

            Catch ex As Exception
                'Hubo una excepción, por lo que debo hacer un rollback
                'para mantener la integridad de los datos.
                con.RollbackTrans()
                Console.WriteLine("No se pudo insertar el médico." & vbCrLf & ex.Message) ' Mensaje en consola para debug

                'Retorno False, significando esto que la transacción
                'no se pudo concretar.
                Return False

            End Try
        Else
            MsgBox("No hay conexión con la base de datos.", MsgBoxStyle.Critical, "Error")
            Return False
        End If
    End Function

    Public Function GetDgvData() As DataTable
        Dim dt As New DataTable()

        'Consulto los datos a la vista "pacientes"
        Dim query As String = "SELECT * FROM Medicos;"


        If HasConnection() Then

            Dim con As New OdbcConnection("dsn=VM_DB_sistema_telediagnostico;uid=" & DB_User & ";pwd=" & DB_Password & ";")
            con.Open()
            Dim cmd As New OdbcCommand(query, con)
            Dim dataReader = cmd.ExecuteReader()
            dt.Load(dataReader)

        End If
        Return dt
    End Function

End Class
