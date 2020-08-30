Imports ADODB
Imports System.Data.Odbc
Public Class DPaciente
    Inherits DPersona

    Public Property Email As String
    Public Property NucleoFlia As String
    Public Property AntecedentesFlia As String
    Public Property AntecedentesLab As String
    Public Property Medicacion As String
    Public Property Tratamiento As String

    Public Sub New(userType As Short)
        MyBase.New(userType)
    End Sub

    'Constructor comúm completo
    Public Sub New(
            userType As Short,
            Ci As Integer,
            nombre As String,
            apellidoP As String,
            apellidoM As String,
            direccion As DDireccion,
            telefono As Integer,
            fecha_nacimiento As Date,
            password As String,
            email As String,
            NucleoFlia As String,
            AntecedentesFlia As String,
            antecedentesLab As String,
            medicacion As String,
            tratamiento As String)
        MyBase.New(userType, Ci, nombre, apellidoP, apellidoM, direccion, telefono, fecha_nacimiento, password)
        Me.Ci = Ci
        Me.Nombre = nombre
        Me.ApellidoP = apellidoP
        Me.ApellidoM = apellidoM
        Me.Direccion = direccion
        Me.Telefono = telefono
        Me.Fecha_Nacimiento = fecha_nacimiento
        Me.User_Password = password
        Me.Email = email
        Me.NucleoFlia = NucleoFlia
        Me.AntecedentesFlia = AntecedentesFlia
        Me.AntecedentesLab = antecedentesLab
        Me.Medicacion = medicacion
        Me.Tratamiento = tratamiento
    End Sub

    ' Constructor común Parcial
    Public Sub New(
            userType As Short,
            ci As Integer,
            nombre As String,
            apellidoP As String,
            apellidoM As String,
            direccion As DDireccion,
            telefono As Integer,
            fecha_nacimiento As Date,
            password As String,
            email As String)
        MyBase.New(userType, ci, nombre, apellidoP, apellidoM, direccion, telefono, fecha_nacimiento, password)
        Me.Email = email
        Me.NucleoFlia = "Sin ingresar"
        Me.AntecedentesFlia = "Sin ingresar"
        Me.AntecedentesLab = "Sin ingresar"
        Me.Medicacion = "Sin ingresar"
        Me.Tratamiento = "Sin ingresar"
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
                                  " AND departamento=" & Me.Direccion.Departamento & ";"

            'Abro la conexión con la base de datos
            Dim con As Connection = Conectar()

            Try
                'Abro transacción
                con.BeginTrans()
                'MsgBox(insertDireccion)
                'Ingreso la dirección a la DB
                Dim dbDireccion As New DDireccion(Direccion.Calle, Direccion.Nro, Direccion.Localidad, Direccion.Departamento, Direccion.Detalle)
                dbDireccion.Insert(con)

                'Obtener idDireccion
                'MsgBox(getIdDireccion)
                rs = con.Execute(getIdDireccion)
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
                                  " medicacion," &
                                  " tratamiento," &
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
                                  Email & "','" &
                                  NucleoFlia & "','" &
                                  AntecedentesFlia & "','" &
                                  AntecedentesLab & "','" &
                                  Medicacion & "','" &
                                  Tratamiento & "','" &
                                  User_Password & "'," &
                                  idDireccion &
                                  ");"
                ' MsgBox("Query Paciente: " & insertPaciente)

                'Ingreso los datos del paciente a la DB
                con.Execute(insertPaciente)

                'Hago el commit de la transacción y retorno True
                con.CommitTrans()
                con.Close()

            Catch ex As Exception
                'Hubo una excepción, por lo que debo hacer un rollback
                'para mantener la integridad de los datos.
                con.RollbackTrans()
                Throw New Exception("Error al ingresar el paciente.")
            Finally
                con.Close()
            End Try
        Else
            Throw New Exception("No hay conexión con la base de datos.")
        End If
    End Sub

    Public Function GetPacientes() As DataTable
        Dim dt As New DataTable()
        Dim rs As Recordset
        Dim da As New OleDb.OleDbDataAdapter()

        'Consulto los datos a la vista "pacientes"
        Dim query As String = "SELECT * FROM Pacientes;"


        If HasConnection() Then

            Dim con = Conectar()
            Try
                rs = con.Execute(query)
                da.Fill(dt, rs)
            Catch ex As Exception
                Throw ex
            Finally
                con.Close()
            End Try
        End If
        Return dt
    End Function

End Class
