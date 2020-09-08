Imports Datos2
Public Class Empleado
    Inherits Persona

    Public Property Horarios As List(Of Horario)
    Public Sub New()
        MyBase.New()
        Horarios = New List(Of Horario)
    End Sub

    Public Sub New(ci As Integer)
        MyBase.New(ci)
        Horarios = New List(Of Horario)
    End Sub

    Public Sub New(ci As Integer, password As String)
        MyBase.New(ci, password)
        Horarios = New List(Of Horario)
    End Sub

    Public Sub New(ci As Integer,
                   nombre As String,
                   apellidoP As String,
                   apellidoM As String,
                   direccion As Direccion,
                   telefono As Integer,
                   fecha_nacimiento As Date,
                   password As String
                   )
        MyBase.New(ci,
                   nombre,
                   apellidoP,
                   apellidoM,
                   direccion,
                   telefono,
                   fecha_nacimiento,
                   password)
    End Sub

    Public Sub New(ci As Integer,
                   nombre As String,
                   apellidoP As String,
                   apellidoM As String,
                   direccion As Direccion,
                   telefono As Integer,
                   fecha_nacimiento As Date,
                   horarios As List(Of Horario),
                   Password As String
                   )
        MyBase.New(ci,
                   nombre,
                   apellidoP,
                   apellidoM,
                   direccion,
                   telefono,
                   fecha_nacimiento,
                   Password)
        Me.Horarios = horarios
    End Sub

    'Public Function NuevoTrabajo(horario As Horario) As Boolean
    '    Dim Db As New DHorario(Env.UserType, Me.Ci, horario.Sucursal, horario.Dia, horario.HoraInicio, horario.HoraFin)

    '    Try
    '        Db.Insert()
    '        Horarios.Add(horario)
    '        Return True
    '    Catch ex As Exception
    '        Return False
    '    End Try
    'End Function


    ''' <summary>
    ''' Valida los datos de entrada para empleados.
    ''' </summary>
    ''' <param name="ci"></param>
    ''' <param name="nombres"></param>
    ''' <param name="apellidoP"></param>
    ''' <param name="apellidoM"></param>
    ''' <param name="calle"></param>
    ''' <param name="numero"></param>
    ''' <param name="localidad"></param>
    ''' <param name="detalle"></param>
    ''' <param name="telefono"></param>
    ''' <param name="rol"></param>
    ''' <param name="especialidades"></param>
    Public Overloads Sub ValidateFields(ci As String,
                              nombres As String,
                              apellidoP As String,
                              apellidoM As String,
                              calle As String,
                              numero As String,
                              localidad As String,
                              detalle As String,
                              telefono As String,
                              rol As String,
                              especialidades As List(Of String)
                              )
        MyBase.ValidateFields(ci,
                              nombres,
                              apellidoP,
                              apellidoM,
                              calle,
                              numero,
                              localidad,
                              detalle,
                              telefono
                              )

        If Not RoleExists(rol) Then
            Throw New ArgumentException("El rol '" & rol & " ' no existe.")
        Else
            If rol = Env.UserTypes.Medico Then
                Try
                    ValidateEspecialidades(especialidades)

                Catch ex As KeyNotFoundException
                    Throw ex
                End Try
            End If
        End If

    End Sub

    Public Function GetRoles() As List(Of String)
        Dim roles = [Enum].GetNames(GetType(Env.UserTypes))
        Return roles.ToList
    End Function

    Protected Function RoleExists(rol As String) As Boolean
        Dim ROLES = [Enum].GetValues(GetType(Env.UserTypes))
        Dim exist As Boolean = False

        For Each systemRole In ROLES
            If systemRole.Equals(rol) Then
                exist = True
            End If
        Next

        Return exist
    End Function

    Public Function GetEspecialidades() As List(Of Especialidad)
        Dim MedicoDBO As New DMedico(Env.UserType)
        Dim data = MedicoDBO.GetEspecialidades()
        Dim especialidades As New List(Of Especialidad)


        For Each row As DataRow In data.Rows
            Dim especialidad As New Especialidad
            especialidad.Id = row.Field(Of Integer)(0)
            especialidad.Nombre = row.Field(Of String)(1)

            especialidades.Add(especialidad)
        Next
        Return especialidades
    End Function

    Protected Sub ValidateEspecialidades(pEspecialidades As List(Of String))
        Dim ListaEspecialidades As List(Of Especialidad) = GetEspecialidades()

        For Each especialidad In pEspecialidades
            If Not ListaEspecialidades.Contains(New Logica.Especialidad(especialidad)) Then
                Throw New KeyNotFoundException("Especialidad '" & especialidad & "' no encontrada")

            End If
        Next

    End Sub
End Class
