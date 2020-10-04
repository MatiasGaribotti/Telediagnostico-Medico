Imports Datos
Imports Dominio

Public Class AutoconsultaBUS

    Public Shared instance As New AutoconsultaBUS
    Public Property consulta As Autoconsulta

    Private Sub New()
        consulta = New Autoconsulta()
    End Sub

    Public Sub ResetInstance()
        consulta = New Autoconsulta
    End Sub

    Public Sub AddSintoma(pSintoma As Sintoma)
        consulta.Sintomas.Add(pSintoma)
    End Sub

    Public Sub RemSintoma(pSintoma As Sintoma)
        consulta.Sintomas.Remove(pSintoma)
    End Sub


    Public Function GetDiagnosis() As List(Of Enfermedad)
        Dim diagnosis As New List(Of Enfermedad)

        Dim EnfermedadBUS As New EnfermedadBUS
        Dim SintomaBUS As New SintomaBUS
        Dim listaEnfermedades As New List(Of Enfermedad)
        Dim summary As New List(Of Enfermedad)

        For Each sintoma As Sintoma In consulta.Sintomas
            'sintoma.Enfermedades = SintomaBUS.GetEnfermedadesAsociadas(sintoma.Id)

            For Each enfermedad In SintomaBUS.GetEnfermedadesAsociadas(sintoma.Id)
                If Not ContainsEnfermedad(enfermedad.Id, summary) Then
                    summary.Add(enfermedad)

                End If
            Next
        Next

        For Each enfermedad In summary
            enfermedad.Sintomas = EnfermedadBUS.GetSintomasAsociados(enfermedad.Id)

        Next



        For Each enfermedad As Enfermedad In summary
            Dim count As Integer = enfermedad.Sintomas.Count

            ' El umbral para que una enfermedad sea diagnosticada será el 
            ' 50% +1 de matches.
            Dim threshold As Integer = Math.Round(count / 2) + 1
            Dim matches As Integer = 0

            For Each sintoma As Sintoma In enfermedad.Sintomas
                For Each selection In consulta.Sintomas
                    If sintoma.Id = selection.Id Then
                        matches += 1
                    End If
                Next
            Next

            If matches >= threshold Then
                diagnosis.Add(enfermedad)
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
        For Each item In consulta.Sintomas
            If item.Id = pId Then
                Return True
            End If
        Next
        Return False
    End Function

    Public Sub Insert()
        Dim AutoconsultaDAO As New ConsultaDAO
        Try
            consulta = AutoconsultaDAO.Insert(consulta)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class
