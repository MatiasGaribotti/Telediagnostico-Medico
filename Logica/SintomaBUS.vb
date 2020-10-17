Imports Datos
Imports Dominio
Imports Microsoft.VisualBasic.FileIO

Public Class SintomaBUS


    Public Function GetSintomas() As DataTable
        Dim SintomaDAO As New SintomaDAO()
        Try
            Return SintomaDAO.GetSintomas()

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GetSintomas(pattern As Sintoma) As DataTable
        Dim db As New SintomaDAO()
        Dim dt As DataTable
        If pattern.Enfermedades.Count > 0 Then
            dt = db.GetSintomas(pattern.Nombre, pattern.Tipo, pattern.Enfermedades)
        Else
            dt = db.GetSintomas(pattern.Nombre, pattern.Tipo)
        End If

        Return dt
    End Function

    Public Function GetEnfermedadesAsociadas(idSintoma As Short) As List(Of Enfermedad)
        Dim SintomaDAO As New SintomaDAO()
        Try
            Return SintomaDAO.GetEnfermedadesAsociadas(idSintoma)

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub ImportCSV(path As String)
        Dim SintomaDAO As New SintomaDAO
        Dim listaSintomas As New List(Of Sintoma)
        Dim tfp As New TextFieldParser(path)
        tfp.SetDelimiters(";")

        Try
            'Salto los headers
            tfp.ReadFields()

            While Not tfp.EndOfData
                Dim fields = tfp.ReadFields
                Dim currentSintoma As Sintoma

                Dim nombre As String = fields(0)
                Dim tipo = [Enum].Parse(GetType(Sintoma.TiposSintomas), fields(1))
                Dim enfermedadesAsociadas As String() = fields(2).Trim.Split(",")
                Dim descripcion As String = fields(3)

                currentSintoma = New Sintoma(nombre, descripcion, tipo)

                For Each enfermedad In enfermedadesAsociadas
                    currentSintoma.Enfermedades.Add(New Enfermedad(enfermedad))
                Next

                listaSintomas.Add(currentSintoma)
            End While

            SintomaDAO.Insert(listaSintomas)

        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Throw New Exception("ex_csv_file")
        End Try
    End Sub
End Class
