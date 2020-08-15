Imports Datos2
Public Class Enfermedad
    Public Property Id As Short
    Public Property Nombre As String
    Public Property Descripcion As String
    Public Property Urgencia As Urgencias
    Public Enum Urgencias
        Baja = 1 'inicializo en 1 el primer miembro para que coincida con la BD.
        Media
        Alta
    End Enum

    Public Sub New()
        Me.Id = -1
        Me.Nombre = "Default"
        Me.Descripcion = "Default"
        Me.Urgencia = Urgencias.Baja
    End Sub

    Public Sub New(nombre As String)
        Me.Id = -1
        Me.Nombre = nombre
        Me.Descripcion = "Default"
        Me.Urgencia = Urgencias.Baja
    End Sub

    Public Sub New(nombre As String, descripcion As String, urgencia As Urgencias)
        Me.Nombre = nombre
        Me.Descripcion = descripcion
        Me.Urgencia = urgencia
    End Sub

    Public Sub New(id As Short, nombre As String, descripcion As String, urgencia As Urgencias)
        Me.Id = id
        Me.Nombre = nombre
        Me.Descripcion = descripcion
        Me.Urgencia = urgencia
    End Sub

    Public Function Insert() As Boolean
        Dim saved = False

        Dim db As New DEnfermedad("admin", "123456789")
        Dim idFound = db.Find(Nombre)
        Console.WriteLine("Enfermedad encontrada:" & idFound)
        MsgBox("Urgencia seleccionada: " & Urgencia)

        If idFound = -1 Then
            saved = db.Insert(Nombre, Descripcion, Urgencia)
        Else
            saved = False
        End If

        Return saved
    End Function

End Class
