Imports ADODB
Public Class DSintoma
    Inherits DBConnection
    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(user As String, password As String)
        MyBase.New(user, password)
    End Sub

    Public Function Insert(nombre As String, descripcion As String, tipo As String, enfermedades As List(Of Short)) As Boolean

        If HasConnection() Then
            Dim con As Connection = Conectar()
            Dim recordSet As Recordset
            Dim idSintoma As Short

            Dim insertSintoma = "INSERT INTO sintomas(nombre,decripcion,tipo) " &
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
                    AsociarSintomaEnfermedad(idSintoma, idEnfermedad)
                Next
                con.CommitTrans()
            Catch ex As Exception

                MsgBox("ERROR: " & ex.Message, MsgBoxStyle.Critical)
                con.RollbackTrans()
                Return False

            End Try
        Else
            MsgBox("Las enfermedades asociadas no existen.")
        End If

    End Function

    Public Function ExistEnfermedades(enfermedades As List(Of String)) As Boolean
        Dim exist = False

        Dim query As String
        If HasConnection() Then
            Dim con As Connection = Conectar()
            Dim recordSet As Recordset

            Try
                For Each enfermedad As String In enfermedades
                    query = "SELECT id FROM enfermedades " &
                            "WHERE nombre='" & enfermedad & "';"

                    recordSet = con.Execute(query)

                    If Not recordSet.RecordCount = 1 Then
                        Return exist = False
                    End If
                Next
            Catch ex As Exception
                MsgBox("ERROR: " & ex.Message, MsgBoxStyle.Critical)
            End Try
        End If

        Return exist
    End Function

    Public Sub AsociarSintomaEnfermedad(idSintoma As Short, idEnfermedad As Short)
        If HasConnection() Then
            Dim con As Connection = Conectar()
            Dim insert = "INSERT INTO enfermedades_sintomas(idSintoma, idEnfermedad) " &
                         "VALUES(" & idSintoma & "," & idEnfermedad & ");"
            Try
                Con.Execute(insert)
            Catch ex As Exception
                MsgBox("ERROR en asociar sintoma enfermedad: " & ex.Message)
                Con.RollbackTrans()
            End Try
        End If
    End Sub
End Class
