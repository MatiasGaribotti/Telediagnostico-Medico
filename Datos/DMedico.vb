Imports System.Data.Odbc
Imports ADODB
Public Class DMedico
    Inherits DEmpleado

    Public Property Especialidad As String

    Public Sub New(userType As Short)
        MyBase.New(userType)
    End Sub

    Public Sub New(userType As Short,
                  ci As Integer,
                nombre As String,
                ApellidoP As String,
                apellidoM As String,
                fecha_nacimiento As Date,
                direccion As DDireccion,
                Telefono As Integer,
                especialidad As String,
                password As String)
        MyBase.New(userType, ci, nombre, ApellidoP, apellidoM, direccion, Telefono, fecha_nacimiento, password)
        Me.Especialidad = especialidad
    End Sub

    Public Sub Insert()

        If HasConnection() Then

            Dim rs As Recordset

            ' Sentencia para ingresar la direccion
            Dim insertDireccion = "INSERT INTO direcciones" &
                                   "(calle, numero, localidad, departamento, detalle)" &
                                   "VALUES ('" &
                                   Me.Direccion.Calle & "'," &
                                   Me.Direccion.Nro & ",'" &
                                   Me.Direccion.Localidad & "','" &
                                   Me.Direccion.Departamento & "','" &
                                   Me.Direccion.Detalle & "');"

            ' Consulta para obtener el id de la dirección ingresada
            Dim getIdDireccion = "SELECT id FROM direcciones" &
                                  " WHERE calle='" & Me.Direccion.Calle & "'" &
                                  " AND numero='" & Me.Direccion.Nro & "'" &
                                  " AND localidad='" & Me.Direccion.Localidad & "'" &
                                  " AND departamento='" & Me.Direccion.Departamento & "';"

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
                                  Ci & ",'" &
                                  Nombre & "','" &
                                  ApellidoP & "','" &
                                  ApellidoM & "','" &
                                  Format(Fecha_Nacimiento, "yyyy-MM-dd") & "'," &
                                  Telefono & "," &
                                  "True" & ",'" &
                                  Especialidad & "','" &
                                  Me.User_Password & "'," &
                                  idDireccion &
                                  ");"
                'Ingreso los datos del médico a la DB
                con.Execute(insertMedico)
                con.CommitTrans()

            Catch ex As Exception
                'Hubo una excepción, por lo que debo hacer un rollback
                'para mantener la integridad de los datos.
                con.RollbackTrans()
                Throw New Exception("No se pudo insertar el médico.")
            End Try
        Else
            Throw New Exception("No hay conexión con la base de datos.")
        End If
    End Sub

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