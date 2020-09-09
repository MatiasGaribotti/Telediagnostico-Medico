Imports Datos2
Imports Dominio
Public Class AuthenticationBUS
    Public Shared Sub LogOut()
        Env.CurrentUser = Nothing
        Env.ChangeLanguage(Env.Cultures.Espannol)
    End Sub

    Public Shared Function Authenticate(user As Persona) As Boolean
        Dim user_found As Persona
        Dim authenticated = False
        Dim DAuth As New DAuthentication()

        ' NOT IMPLEMENTED 
        'user.Password = Password.Hash(user.Password)

        Try
            user_found = DAuth.Find(user.Ci, user.Password)
            Env.CurrentUser = user_found
        Catch ex As Exception
            Return False
        End Try

        Select Case Env.CurrentApp
            Case Env.Apps.Gestion
                'Administrador
                If user_found.IsAdministrador Or user_found.IsRRHH Or user_found.IsRecepcionista Then
                    authenticated = True
                Else
                    LogOut()
                    Throw New Exception("Accesso denegado.")
                End If

            Case Env.Apps.Medico
                'Solo tienen acceso los médicos
                If user_found.IsAdministrador Then
                    authenticated = True
                Else
                    LogOut()
                    Throw New Exception("Accesso denegado.")
                End If

            Case Env.Apps.Paciente
                If user_found.IsPaciente Then
                    authenticated = True
                Else
                    LogOut()
                    Throw New Exception("Accesso denegado.")
                End If
        End Select

        Return authenticated
    End Function

    Public Shared Sub ValidateFields(ci As String, pwd As String)

        If Not ci.Length = 0 And Not pwd.Length = 0 Then
            If Not ci.Length > 8 Then
                Dim chars = ci.ToCharArray


                For Each caracter In chars
                    If Not Char.IsDigit(caracter) Then
                        Throw New FormatException("La cédula de identidad debe contener solo números.")
                    End If
                Next

            Else
                Throw New FormatException("La cédula de identidad es obligatoria.")
            End If

        Else
            Throw New FormatException("La CI y contraseña son obligatorias.")
        End If
    End Sub
End Class
