Imports ADODB
Public Class DEnfermedad
    Inherits DBConnection
    Public Property Id As Short
    Public Property Nombre As String
    Public Property Descripcion As String
    Public Property Urgencia As Urgencias
    Public Enum Urgencias
        Baja = 1 'inicializo en 1 el primer miembro para que coincida con la BD.
        Media
        Alta
    End Enum


    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(userType As Short)
        MyBase.New(userType)
        Me.Id = -1
        Me.Nombre = "Default"
        Me.Descripcion = "Default"
        Me.Urgencia = Urgencias.Baja
    End Sub

    Public Sub New(userType As Short, nombre As String)
        MyBase.New(userType)
        Me.Id = -1
        Me.Nombre = nombre
        Me.Descripcion = "Default"
        Me.Urgencia = Urgencias.Baja
    End Sub

    Public Sub New(userType As Short, id As Short, nombre As String)
        MyBase.New(userType)
        Me.Id = id
        Me.Nombre = nombre
        Me.Descripcion = "Default"
        Me.Urgencia = Urgencias.Baja
    End Sub

    Public Sub New(id As Short, nombre As String, descripcion As String)
        MyBase.New()
        Me.Id = id
        Me.Nombre = nombre
        Me.Descripcion = descripcion
        Me.Urgencia = Urgencias.Baja
    End Sub

    Public Sub New(userType As Short, nombre As String, descripcion As String, urgencia As Urgencias)
        MyBase.New(userType)
        Me.Nombre = nombre
        Me.Descripcion = descripcion
        Me.Urgencia = urgencia
    End Sub

    Public Sub New(userType As Short, id As Short, nombre As String, descripcion As String, urgencia As Urgencias)
        MyBase.New(userType)
        Me.Id = id
        Me.Nombre = nombre
        Me.Descripcion = descripcion
        Me.Urgencia = urgencia
    End Sub

    Public Function Find(nombre As String) As Short
        Dim id As Short = -1
        Dim recordSet As Recordset
        Dim query = "SELECT id FROM enfermedades " &
                    "WHERE nombre='" & nombre & "';"

        If HasConnection() Then
            'Obtengo la conexión
            Dim con = Conectar()

            Try
                recordSet = con.Execute(query)


                'Si BOF (antes del primer registro) es verdadero
                'quiere decir que no hay registros.
                'No se encontró ninguna enfermedad con ese nombre.
                If Not recordSet.BOF Then

                    'Cuento la cantidad de registros
                    'Solo me servirá si el nombre coincide con
                    'una única enfermedad
                    Dim count As Integer = 0

                    ' Mientras que no esté mas adelante que
                    ' el último registro (EOF), ejecuto.
                    While Not recordSet.EOF
                        count += 1
                        id = CShort(recordSet.Fields("id").Value)
                        recordSet.MoveNext()
                    End While

                    If count > 1 Then
                        Throw New Exception("Más de una enfermedad encontrada para el nombre: " & nombre)
                    Else
                        Return id
                    End If
                Else
                    'No se encontraron registros
                    Throw New KeyNotFoundException("No se encontró ninguna enfermedad con el nombre: " & nombre)
                End If

            Catch ex As Exception
                Throw ex

            Finally
                con.Close()
            End Try
        End If
    End Function

    Public Function Insert(nombre As String, descripcion As String, urgencia As String) As Boolean
        Dim saved = False

        If HasConnection() Then
            Dim con = Conectar()
            Dim insertQuery = "INSERT INTO enfermedades(nombre, descripcion, urgencia) " &
                              "VALUES('" & nombre & "','" & descripcion & "'," & urgencia & ");"

            Try
                con.Execute(insertQuery)
                saved = True
            Catch ex As Exception
                Console.WriteLine("Exception at DEnfermedad insert" & vbCrLf & ex.Message)
                saved = False
            End Try
            con.Close()
        End If
        Return saved
    End Function

    ' Funcion que obtiene de la BD las enfermedades
    ' que se encuentran en el sistema
    Public Function GetEnfermedades() As DataTable
        Dim dt As DataTable


        Return dt
    End Function

End Class
