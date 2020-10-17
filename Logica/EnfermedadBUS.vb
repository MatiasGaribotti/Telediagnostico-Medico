Imports Datos
Imports Dominio
Imports Microsoft.VisualBasic.FileIO

Public Class EnfermedadBUS

    ''' <summary>
    ''' Funcion que retorna la información de las enfermedades asociadas a un síntoma, si es que existen
    ''' </summary>
    ''' <param name="enfermedades"></param>
    ''' <returns></returns>
    Public Function GetInfoEnfermedades(enfermedades As List(Of Enfermedad)) As List(Of Enfermedad)
        Dim EnfermedadDAO As New EnfermedadDAO()
        Dim found As New List(Of Enfermedad)

        'Veifico que existan las enfermedades y las agrego a la lista de enfermedades
        For Each enfermedad In enfermedades
            Try
                Dim id = EnfermedadDAO.GetEnfermedadByName(enfermedad.Nombre)
                found.Add(New Enfermedad(id, enfermedad.Nombre))

            Catch ex As Exception
                Throw ex
            End Try
        Next
        Return found
    End Function

    ''' <summary>
    ''' Obtiene todas las enfermedades ingresadas en el sistema.
    ''' </summary>
    ''' <returns>Retorna un DataTable con todas las enfermedades.</returns>
    Public Function GetEnfermedades() As DataTable
        Dim EnfermedadDAO As New EnfermedadDAO()
        Return EnfermedadDAO.GetEnfermedades()
    End Function

    Public Function GetEnfermedades(pattern As Enfermedad) As DataTable
        Dim EnfermedadDAO As New EnfermedadDAO()
        Try
            Return EnfermedadDAO.GetEnfermedades(pattern.Nombre, pattern.Urgencia, pattern.Cronica)

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function GetSintomasAsociados(pIdEnfermedad As Short) As List(Of Sintoma)
        Dim EnfermedadDAO As New EnfermedadDAO
        Dim dt As DataTable
        Dim listaSintomas As New List(Of Sintoma)

        Try
            dt = EnfermedadDAO.GetSintomasAsociados(pIdEnfermedad)
        Catch ex As Exception
            Throw ex
        End Try

        Try
            For row As Integer = 0 To dt.Rows.Count - 1
                Dim column = dt.Rows.Item(row)
                Dim id As Short = CShort(column.Field(Of Integer)("idSintoma"))
                Dim nombre As String = column.Field(Of String)("nombre")
                Dim descripcion As String = column.Field(Of String)("descripcion")
                Dim tipo As Sintoma.TiposSintomas = [Enum].Parse(GetType(Sintoma.TiposSintomas), column.Field(Of String)("tipo"))

                listaSintomas.Add(New Sintoma(id, nombre, descripcion, tipo))

            Next
            Return listaSintomas
        Catch ex As Exception
            Throw New Exception("Error al convertir la información obtenida.")
        End Try
    End Function

    Public Sub ImportCSV(path As String)
        Dim EnfermedadDAO As New EnfermedadDAO
        Dim listaEnfermedades As New List(Of Enfermedad)
        Dim tfp As New TextFieldParser(path)
        tfp.SetDelimiters(";")

        Try
            'Salto los headers
            tfp.ReadFields()

            While Not tfp.EndOfData
                Dim fields = tfp.ReadFields
                Dim currentEnfermedad As Enfermedad

                Dim nombre As String = fields(0)
                Dim urgencia = [Enum].Parse(GetType(Enfermedad.Urgencias), fields(1))
                Dim tipoEnfermedad = fields(2)
                Dim descripcion As String = fields(3)

                currentEnfermedad = New Enfermedad(nombre, descripcion, urgencia)

                listaEnfermedades.Add(currentEnfermedad)
            End While

            EnfermedadDAO.Insert(listaEnfermedades)

        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Throw New Exception("ex_csv_file")
        End Try
    End Sub
End Class
