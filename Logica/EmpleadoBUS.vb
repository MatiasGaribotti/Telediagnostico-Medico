Imports Datos
Imports Dominio
Public Class EmpleadoBUS
    Inherits PersonaBUS
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
    ''' <param name="telefono"></param>
    ''' <param name="rol"></param>
    Public Overloads Sub ValidateFields(ci As String,
                              nombres As String,
                              apellidoP As String,
                              apellidoM As String,
                              calle As String,
                              numero As String,
                              localidad As String,
                              telefono As String,
                              rol As String
                              )
        MyBase.ValidateFields(ci,
                              nombres,
                              apellidoP,
                              apellidoM,
                              calle,
                              numero,
                              localidad,
                              telefono
                              )

        If Not RoleExists(rol) Then
            Throw New ArgumentException("El rol '" & rol & " ' no existe.")
        End If

    End Sub

    Public Function GetRoles() As List(Of String)
        Dim roles = [Enum].GetNames(GetType(Env.Roles))
        Return roles.ToList
    End Function

    Protected Function RoleExists(rol As String) As Boolean
        Dim roles = GetRoles()
        Dim exist As Boolean = False

        For Each systemRole In roles
            If systemRole.Equals(rol) Then
                exist = True
            End If
        Next

        Return exist
    End Function

    Public Function GetEmpleados() As DataTable
        Dim db As New MedicoBUS
        Try
            Dim dt = db.GetEmpleados()
            Return dt

        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
