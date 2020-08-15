Imports ADODB
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

    Public Sub New(user As String, password As String)
        MyBase.New(user, password)
    End Sub

    Public Sub New()
        MyBase.New()
        Me.Id = -1
        Me.Nombre = "Default"
        Me.Descripcion = "Default"
        Me.Tipo = TiposSintomas.Cabeza
        Me.Enfermedades = New List(Of DEnfermedad)
    End Sub

    Public Sub New(id As Short,
                   nombre As String,
                   descripcion As String,
                   tipo As TiposSintomas,
                   enfermedades As List(Of DEnfermedad))
        Me.Id = id
        Me.Nombre = nombre
        Me.Descripcion = descripcion
        Me.Tipo = tipo
        Me.Enfermedades = enfermedades
    End Sub

    Public Sub New(nombre As String, descripcion As String, Tipo As TiposSintomas)
        Me.Id = -1
        Me.Nombre = nombre
        Me.Descripcion = descripcion
        Me.Tipo = Tipo
        Me.Enfermedades = New List(Of DEnfermedad)
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
End Class
