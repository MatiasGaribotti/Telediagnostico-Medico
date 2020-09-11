Imports Datos
Imports Dominio

''' <summary>
''' Clase que contiene la lógica de administradores.
''' </summary>
Public Class AdministradoBUS
    Inherits EmpleadoBUS

    ''' <summary>
    ''' Procedimiento que ingresa un paciente.
    ''' </summary>
    ''' <param name="paciente">Paciente a ingresar.</param>
    Public Sub IngresarPaciente(paciente As Paciente)
        Dim PacienteDAO As New PacienteDAO()
        Try
            PacienteDAO.Insert(paciente)

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
End Class
