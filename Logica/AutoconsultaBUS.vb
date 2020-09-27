Imports Datos
Imports Dominio

Public Class AutoconsultaBUS

    Public Shared instance As New AutoconsultaBUS
    Public Property selectedSintomas As New List(Of Sintoma)
    Private Sub New()

    End Sub

    Public Sub AddSintoma(pSintoma As Sintoma)
        selectedSintomas.Add(pSintoma)
    End Sub

    Public Sub RemSintoma(pSintoma As Sintoma)
        selectedSintomas.Remove(pSintoma)
    End Sub


    Public Function GetDiagnosis() As List(Of Diagnostico)
        Dim diagnosis As New List(Of Diagnostico)

        Dim EnfermedadBUS As New EnfermedadBUS
        Dim SintomaBUS As New SintomaBUS
        Dim listaEnfermedades As New List(Of Enfermedad)
        Dim summary As New List(Of Enfermedad)

        For Each sintoma As Sintoma In selectedSintomas
            'sintoma.Enfermedades = SintomaBUS.GetEnfermedadesAsociadas(sintoma.Id)

            For Each enfermedad In SintomaBUS.GetEnfermedadesAsociadas(sintoma.Id)
                If Not ContainsEnfermedad(enfermedad.Id, summary) Then
                    summary.Add(enfermedad)

                End If
            Next
        Next

        For Each enfermedad In summary
            Try
                enfermedad.Sintomas = EnfermedadBUS.GetSintomasAsociados(enfermedad.Id)

            Catch ex As Exception

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

    Private Function ContainsEnfermedad(pId As Short, list As List(Of Enfermedad)) As Boolean
        For Each item In list
            If item.Id = pId Then
                Return True
            End If
        Next
        Return False
    End Function
    Public Function SintomaAlreadySelected(pId As Short) As Boolean
        For Each item In selectedSintomas
            If item.Id = pId Then
                Return True
            End If
        Next
        Return False
    End Function
End Class
