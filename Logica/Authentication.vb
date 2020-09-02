Imports Datos2
Public Class Authentication
    Public Shared Sub LogOut()
        Env.CurrentUser = Nothing
        Env.UserType = Nothing
        Env.ChangeLanguage(Env.Cultures.Espannol)
    End Sub

    Public Shared Function Authenticate(user As Persona) As Boolean
        Dim authenticated = False
        Dim DAuth As New DAuthentication()

        ' NOT IMPLEMENTED 
        'user.Password = Password.Hash(user.Password)

        Dim results As List(Of Boolean)
        Try
            results = DAuth.Find(user.Ci, user.Password)

        Catch ex As Exception
            Return False
        End Try

        If results.Count = 5 Then

            Select Case Env.CurrentApp
                Case Env.Apps.Gestion
                    'Administrador
                    If results.ElementAt(1) = True Then
                        Env.CurrentUser = New Administrador(user.Ci)
                        Env.UserType = Env.UserTypes.Administrador
                        authenticated = True

                        'RRHH
                    ElseIf results.ElementAt(3) = True Then
                        Env.CurrentUser = New RRHH(user.Ci)
                        Env.UserType = Env.UserTypes.RRHH
                        authenticated = True

                        'Recepcionista
                    ElseIf results.ElementAt(4) = True Then
                        Env.CurrentUser = New Recepcionista(user.Ci)
                        Env.UserType = Env.UserTypes.Recepcionista
                        authenticated = True

                        'Ninguno de los anteriores
                    Else
                        Throw New Exception("Accesso denegado.")
                        authenticated = False
                    End If

                Case Env.Apps.Medico
                    'Solo tienen acceso los médicos
                    If results.ElementAt(0) = True Then
                        Env.CurrentUser = New Medico(user.Ci)
                        Env.UserType = Env.UserTypes.Medico
                        authenticated = True
                    Else
                        Throw New Exception("Accesso denegado.")
                    End If

                Case Env.Apps.Paciente
                    If results.ElementAt(2) = True Then
                        Env.CurrentUser = New Paciente(user.Ci)
                        Env.UserType = Env.UserTypes.Paciente
                        authenticated = True
                    Else
                        Throw New Exception("Accesso denegado.")
                    End If
            End Select
        Else
            authenticated = False
        End If

        Return authenticated
    End Function
End Class
