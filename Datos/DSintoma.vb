Imports ADODB
Imports System.Data.Odbc
Public Class DSintoma
    Inherits DBConnection

    Public Property Id As Short
    Public Property Nombre As String
    Public Property Descripcion As String
    Public Property Tipo As TiposSintomas
    Public Property Enfermedades As List(Of DEnfermedad)

    Public Enum TiposSintomas
        Cabeza = 1 'inicializo en 1 el primer miembro para que coincida con la BD.
        Torso
        Extremidades
    End Enum

    Public Sub New(userType As Short)
        MyBase.New(userType)
        Me.Id = -1
        Me.Nombre = "Default"
        Me.Descripcion = "Default"
        Me.Tipo = TiposSintomas.Cabeza
        Me.Enfermedades = New List(Of DEnfermedad)
    End Sub

    Public Sub New(userType As Short, id As Short)
        MyBase.New(userType)
        Me.Id = id
        Me.Nombre = "Default"
        Me.Descripcion = "Default"
        Me.Tipo = TiposSintomas.Cabeza
        Me.Enfermedades = New List(Of DEnfermedad)
    End Sub

    Public Sub New()
        MyBase.New()
        Me.Id = -1
        Me.Nombre = "Default"
        Me.Descripcion = "Default"
        Me.Tipo = TiposSintomas.Cabeza
        Me.Enfermedades = New List(Of DEnfermedad)
    End Sub

    Public Sub New(userType As Short,
                  id As Short,
                   nombre As String,
                   descripcion As String,
                   tipo As TiposSintomas,
                   enfermedades As List(Of DEnfermedad))
        MyBase.New(userType)
        Me.Id = id
        Me.Nombre = nombre
        Me.Descripcion = descripcion
        Me.Tipo = tipo
        Me.Enfermedades = enfermedades
    End Sub

    Public Sub New(userType As Short, nombre As String, descripcion As String, Tipo As TiposSintomas)
        MyBase.New(userType)
        Me.Id = -1
        Me.Nombre = nombre
        Me.Descripcion = descripcion
        Me.Tipo = Tipo
        Me.Enfermedades = New List(Of DEnfermedad)
    End Sub

    Public Sub New(userType As Short, nombre As String, tipo As TiposSintomas)
        MyBase.New(userType)
        Me.Id = -1
        Me.Nombre = nombre
        Me.Descripcion = ""
        Me.Tipo = tipo
        Me.Enfermedades = New List(Of DEnfermedad)
    End Sub

    Public Sub New(userType As Short, nombre As String, tipo As TiposSintomas, enfermedades As List(Of DEnfermedad))
        MyBase.New(userType)
        Me.Id = -1
        Me.Nombre = nombre
        Me.Descripcion = ""
        Me.Tipo = tipo
        Me.Enfermedades = enfermedades
    End Sub



    Public Function Insert(nombre As String, descripcion As String, tipo As String, enfermedades As List(Of Short)) As Boolean
        If HasConnection() Then
            Dim con As Connection = Conectar()
            Dim recordSet As Recordset
            Dim idSintoma As Short

            Dim insertSintoma = "INSERT INTO sintomas(nombre,descripcion,tipo) " &
                                "VALUES('" &
                                nombre & "','" &
                                descripcion & "'," &
                                tipo & ");"

            Dim selectSintoma = "SELECT id FROM sintomas " &
                                "WHERE nombre='" & nombre & "' AND descripcion='" & descripcion & "' AND tipo=" & tipo & ";"

            Try
                con.BeginTrans()
                con.Execute(insertSintoma)
                recordSet = con.Execute(selectSintoma)

                'Asigno el valor del campo id
                'a la variable idSintoma
                idSintoma = recordSet.Fields("id").Value


                For Each idEnfermedad As Short In enfermedades
                    AsociarSintomaEnfermedad(idSintoma, idEnfermedad, con)
                Next
                con.CommitTrans()
                Return True

            Catch ex As Exception

                MsgBox("ERROR: " & ex.Message, MsgBoxStyle.Critical, "Insert Síntoma")
                con.RollbackTrans()
                Return False

            End Try

            con.Close()
        Else
            MsgBox("No hay conexión con la base de datos.")
            Return False
        End If

    End Function

    Public Sub AsociarSintomaEnfermedad(idSintoma As Short, idEnfermedad As Short, con As Connection)
        Dim insert = "INSERT INTO enfermedades_sintomas(idSintoma, idEnfermedad) " &
                     "VALUES(" & idSintoma & "," & idEnfermedad & ");"
        Try
            con.Execute(insert)
        Catch ex As Exception
            MsgBox("ERROR en asociar sintoma enfermedad: " & ex.Message)
            con.RollbackTrans()
        End Try
    End Sub

    Public Function GetDgvData() As DataTable
        Dim dt As New DataTable()
        Dim query As String = "SELECT id,nombre,descripcion,tipo FROM sintomas WHERE ENABLED=1"

        If HasConnection() Then

            Dim con As New OdbcConnection("dsn=VM_DB_sistema_telediagnostico;uid=" & DB_User & ";pwd=" & DB_Password & ";")
            con.Open()
            Dim cmd As New OdbcCommand(query, con)
            Dim dataReader = cmd.ExecuteReader()
            dt.Load(dataReader)
            con.Close()
        End If
        Return dt

        Return dt
    End Function


    Public Function GetSintomasFound() As DataTable
        Dim dt As New DataTable()
        Dim query As String = "SELECT S.id AS ID," &
                                "S.nombre AS Sintoma, " &
                                "S.descripcion AS Descripcion, " &
                                "S.tipo AS Tipo " &
                                "FROM sintomas AS S " &
                                "LEFT JOIN enfermedades_sintomas AS ES " &
                                "ON (S.ID = ES.idSintoma) " &
                                "WHERE S.nombre LIKE '%" & Nombre & "%' AND S.tipo=" & Tipo & " "

        If Enfermedades.Count > 0 Then
            For Each enfermedad As DEnfermedad In Enfermedades
                query += " OR E.nombre LIKE '%" & enfermedad.Nombre & "%' "
            Next
        End If
        query += "AND ENABLED=1 ORDER BY S.nombre;"

        Console.WriteLine(query)

        If HasConnection() Then

            Dim con As New OdbcConnection("dsn=VM_DB_sistema_telediagnostico;uid=" & DB_User & ";pwd=" & DB_Password & ";")
            con.Open()

            Dim cmd As New OdbcCommand(query, con)
            Dim dataReader = cmd.ExecuteReader()
            dt.Load(dataReader)
            con.Close()
        End If
        Return dt
    End Function

    Public Function Delete() As Boolean
        Dim query As String = "UPDATE sintomas SET ENABLED=0 WHERE id=" & Id & ";"

        If HasConnection() Then
            Dim con As New OdbcConnection("dsn=VM_DB_sistema_telediagnostico;uid=" & DB_User & ";pwd=" & DB_Password & ";")
            Try
                con.Open()
                Dim cmd As New OdbcCommand(query, con)
                cmd.ExecuteNonQuery()
                con.Close()
                Return True
            Catch ex As Exception
                con.Close()
                Return False
            End Try
        End If
    End Function

    Public Function Modify() As Boolean


        Dim updateSintoma As String = "UPDATE sintomas SET nombre='" & Nombre & "', descripcion='" & Descripcion & "', tipo=" & Tipo & ", "
        Dim updateEnfermedad As String = "UPDATE sintomas SET nombre='" & Nombre & "', descripcion='" & Descripcion & "', tipo=" & Tipo & ", "

        If HasConnection() Then
            Dim con = Conectar()

            Try
                con.BeginTransaction()
                con.Execute(updateSintoma)

                con.CommitTrans()
                con.Close()
                Return True
            Catch ex As Exception

                con.RollbackTrans()
                con.Close()
                Console.WriteLine("ERROR: " & ex.Message)
                Return False
            End Try

        End If

    End Function

End Class
