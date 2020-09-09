
Public Class Persona
    Public Property Ci As Integer
    Public Property Nombre As String
    Public Property ApellidoP As String
    Public Property ApellidoM As String
    Public Property Direccion As Direccion
    Public Property Telefono As Integer
    Public Property Fecha_Nacimiento As Date
    Public Property Password As String
    Public Property IsPaciente As Boolean
    Public Property IsEmpleado As Boolean
    Public Property IsMedico As Boolean
    Public Property IsAdministrador As Boolean
    Public Property IsRRHH As Boolean
    Public Property IsRecepcionista As Boolean

    Protected Sub New()
        Me.Ci = 11111111
        Me.Nombre = "Default"
        Me.ApellidoP = "Default"
        Me.ApellidoM = "Default"
        Me.Direccion = New Direccion()
        Me.Telefono = -1
        Me.Fecha_Nacimiento = New Date(1, 1, 1)
        Me.Password = "Default"
        Me.IsPaciente = False
        Me.IsEmpleado = False
        Me.IsMedico = False
        Me.IsAdministrador = False
        Me.IsRRHH = False
        Me.IsRecepcionista = False
    End Sub

    Protected Sub New(ci As Integer)
        Me.Ci = ci
        Me.Nombre = "Default"
        Me.ApellidoP = "Default"
        Me.ApellidoM = "Default"
        Me.Direccion = New Direccion()
        Me.Telefono = -1
        Me.Fecha_Nacimiento = New Date(1, 1, 1)
        Me.Password = "Default"
        Me.IsPaciente = False
        Me.IsEmpleado = False
        Me.IsMedico = False
        Me.IsAdministrador = False
        Me.IsRRHH = False
        Me.IsRecepcionista = False
    End Sub

    ''' <summary>
    ''' Constructur para autenticar usuarios.
    ''' </summary>
    ''' <param name="ci">CI del usuario</param>
    ''' <param name="password">CI del usuario</param>
    Public Sub New(ci As Integer,
                   password As String,
                   Optional ByVal isPaciente As Boolean = False,
                   Optional ByVal isEmpleado As Boolean = False,
                   Optional ByVal isMedico As Boolean = False,
                   Optional ByVal isAdministrador As Boolean = False,
                   Optional ByVal isRRHH As Boolean = False,
                   Optional ByVal isRecepcionista As Boolean = False)
        Me.Ci = ci
        Me.Nombre = "Default"
        Me.ApellidoP = "Default"
        Me.ApellidoM = "Default"
        Me.Direccion = New Direccion()
        Me.Telefono = -1
        Me.Fecha_Nacimiento = New Date(1, 1, 1)
        Me.Password = password
        Me.IsPaciente = isPaciente
        Me.IsEmpleado = isEmpleado
        Me.IsMedico = isMedico
        Me.IsAdministrador = isAdministrador
        Me.IsRRHH = isRRHH
        Me.IsRecepcionista = isRecepcionista
    End Sub

    Protected Sub New(ci As Integer,
                   nombre As String,
                   apellidoP As String,
                   apellidoM As String,
                   direccion As Direccion,
                   telefono As Integer,
                   fecha_Nacimiento As Date,
                   password As String)
        Me.Ci = ci
        Me.Nombre = nombre
        Me.ApellidoP = apellidoP
        Me.ApellidoM = apellidoM
        Me.Direccion = direccion
        Me.Telefono = telefono
        Me.Fecha_Nacimiento = fecha_Nacimiento
        Me.Password = password
        Me.IsPaciente = False
        Me.IsEmpleado = False
        Me.IsMedico = False
        Me.IsAdministrador = False
        Me.IsRRHH = False
        Me.IsRecepcionista = False
    End Sub
End Class
