Imports Datos
Imports Dominio

''' <summary>
''' Clase que contiene la lógica de administradores.
''' </summary>
Public Class AdministradorBUS
    Inherits EmpleadoBUS

    ''' <summary>
    ''' Procedimiento que ingresa un paciente.
    ''' </summary>
    ''' <param name="paciente">Paciente a ingresar.</param>
    Public Sub InsertPaciente(paciente As Paciente)
        Dim PacienteDAO As New PacienteDAO()
        Try
            PacienteDAO.Insert(paciente)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub ModifyPaciente(pPaciente As Paciente)
        Dim PacienteDAO As New PacienteDAO
        Try
            PacienteDAO.Modify(pPaciente)
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeletePaciente(pPaciente As Paciente)
        Dim PacienteDAO As New PacienteDAO

        Try
            DeletePersona(pPaciente.Ci)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    ''' <summary>
    ''' Función que obtiene un paciente a partir de su cédula.
    ''' </summary>
    ''' <param name="pCi">Cédula del paciente.</param>
    ''' <returns></returns>
    Public Function GetPaciente(pCi As Integer) As Paciente
        Dim PacienteDAO As New PacienteDAO()
        Dim dt As DataTable

        Dim ci, telefono, numero As Integer
        Dim nombreCompleto, nombre, apellidoP, apellidoM, email, direccion, calle, localidad, departamento, detalle, NucFamiliar, AntFamiliares, AntLaborales As String
        Dim fechaNacimiento As Date

        Try
            dt = PacienteDAO.GetPacienteByCi(pCi)
        Catch ex As Exception
            Throw ex

        End Try

        Dim row As DataRow = dt.Rows.Item(0)

        Try
            ci = row.Field(Of Integer)("Cedula")
            nombreCompleto = row.Field(Of String)("Nombre Completo")
            fechaNacimiento = row.Field(Of Date)("Fecha Nacimiento")
            telefono = row.Field(Of Integer)("Telefono")
            email = row.Field(Of Integer)("Email")
            direccion = row.Field(Of Integer)("Direccion")
            NucFamiliar = row.Field(Of Integer)("Nucleo Familiar")
            AntFamiliares = row.Field(Of Integer)("Antecedentes Familiares")
            AntLaborales = row.Field(Of Integer)("Antecedentes Laborales")

        Catch ex As InvalidCastException
            Throw New InvalidCastException("Falló en el cast idiota.")
        End Try

        Dim splitedName As String() = nombreCompleto.Split(",")
        nombre = splitedName.ElementAt(0)
        apellidoP = splitedName.ElementAt(1)
        apellidoM = splitedName.ElementAt(2)

        Dim splittedDir As String() = direccion.Split(",")
        calle = splittedDir.ElementAt(0)
        numero = CInt(splittedDir.ElementAt(1))
        localidad = splittedDir.ElementAt(2)
        departamento = splittedDir.ElementAt(3)
        detalle = splittedDir.ElementAt(4)

        Dim direccionVO As New Direccion(calle, numero, localidad, departamento, detalle)

        Return New Paciente(ci, nombre, apellidoP, apellidoM, direccionVO, telefono, fechaNacimiento, "", email)
    End Function

    ''' <summary>
    ''' Ingresa una nueva enfermedad al sistema.
    ''' </summary>
    ''' <param name="enfermedad">Enfermedad a ingresar.</param>
    Public Sub InsertEnfermedad(enfermedad As Enfermedad)
        Dim EnfermedadDAO As New EnfermedadDAO

        ' Si la enfermedad no se está en la BD la ingreso
        If Not EnfermedadDAO.ExistsEnfermedad(enfermedad.Nombre) Then
            EnfermedadDAO.Insert(enfermedad)
        Else
            Throw New DuplicateNameException("La enfermedad ya se encuentra en el sistema.")
        End If
    End Sub

    Public Sub ModifyEnfermedad(enfermedad As Enfermedad)
        Dim EnfermedadDAO As New EnfermedadDAO

        Try
            EnfermedadDAO.Modify(enfermedad)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub


    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="id"></param>
    Public Sub DeleteEnfermedad(id As Short)
        Dim EnfermedadDAO As New EnfermedadDAO
        Try
            EnfermedadDAO.Delete(id)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub


    Public Sub InsertSintoma(sintoma As Sintoma)

        Dim DBSintoma As New SintomaDAO()
        Dim objEnfermedad As New Enfermedad()

        For Each enfermedad In GetEnfermedadesAsociadas(sintoma.Id)
            sintoma.Enfermedades.Add(enfermedad)
        Next

        Try
            DBSintoma.Insert(sintoma)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub AsociarEnfermedad(ByRef sintoma As Sintoma, enfermedad As Enfermedad)
        sintoma.Enfermedades.Add(enfermedad)
    End Sub

    Public Function GetEnfermedadesAsociadas(id As Short) As List(Of Enfermedad)
        Dim SintomaDAO As New SintomaDAO()
        Try
            Return SintomaDAO.GetEnfermedadesAsociadas(id)

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub DeleteSintoma(idSintoma As Short)
        Dim db As New SintomaDAO()
        Try
            db.Delete(idSintoma)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub DeleteSintoma(pSintomas As List(Of Sintoma))
        Dim SintomaDAO As New SintomaDAO()
        Dim count = pSintomas.Count

        Dim msg As String = ""

        For Each sintoma In pSintomas
            Try
                DeleteSintoma(sintoma.Id)

            Catch ex As Exception
                msg += ex.Message & sintoma.Nombre & "." & vbCrLf
                count -= 1
            End Try
        Next

        msg = count & msg

        If msg.Contains("No se pudo") Then
            Throw New Exception(msg)
        End If
    End Sub

    Public Sub ModifySintoma(sintoma As Sintoma)

        'Creo el objeto del sintoma con los datos modificados
        Dim SintomaDAO As New SintomaDAO()

        Try
            SintomaDAO.Modify(sintoma)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

End Class
