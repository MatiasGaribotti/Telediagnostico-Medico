Imports Datos
Imports Dominio

Public Class AutoconsultaBUS

    Public Function GetDiagnosis(selectedSintomas As List(Of Sintoma)) As List(Of Diagnostico)
        Dim diagnosis As New List(Of Diagnostico)

        Dim EnfermedadBUS As New EnfermedadBUS
        Dim SintomaBUS As New SintomaBUS
        Dim listaEnfermedades As New List(Of Enfermedad)
        Dim summary As New List(Of Enfermedad)

        For Each sintoma As Sintoma In selectedSintomas
            'sintoma.Enfermedades = SintomaBUS.GetEnfermedadesAsociadas(sintoma.Id)

            For Each enfermedad In SintomaBUS.GetEnfermedadesAsociadas(sintoma.Id)
                If Not Contains(enfermedad.Id, summary) Then
                    summary.Add(enfermedad)

                End If
            Next
        Next

        For Each enfermedad In summary
            Console.WriteLine("ID: {0}, Nombre: {1}", enfermedad.Id, enfermedad.Nombre)
            Try
                enfermedad.Sintomas = EnfermedadBUS.GetSintomasAsociados(enfermedad.Id)

            Catch ex As Exception
                Console.WriteLine(ex.Message & vbCrLf & ex.StackTrace)
            End Try
        Next



        For Each enfermedad As Enfermedad In summary
            Dim count As Integer = enfermedad.Sintomas.Count

            ' El umbral para que una enfermedad sea diagnosticada será el 
            ' 50% +1 de matches.
            Dim threshold As Integer = Math.Round(count / 2) + 1
            Dim matches As Integer = 0

            For Each sintoma As Sintoma In enfermedad.Sintomas
                For Each selection In selectedSintomas
                    If sintoma.Id = selection.Id Then
                        matches += 1
                    End If
                Next
            Next

            If matches >= threshold Then
                diagnosis.Add(New Diagnostico(enfermedad))
            End If

        Next

        Return diagnosis
    End Function

    Public Function Contains(pId As Short, list As List(Of Enfermedad))
        For Each item In list
            If item.Id = pId Then
                Return True
            End If
        Next
        Return False
    End Function
End Class
