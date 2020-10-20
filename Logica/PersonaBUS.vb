Imports Dominio
Imports Datos

''' <summary>
''' Clase madre de la lógica de personas.
''' </summary>
Public MustInherit Class PersonaBUS

    ''' <summary>
    ''' Comprueba que la cédula de identidad sea válida.
    ''' </summary>
    ''' <param name="pCi">Cédula de identidad a verificar</param>
    Public Sub ValidateCi(pCi As Integer)
        Dim matriz As Char() = "2987634".ToCharArray
        Dim ci As Char() = pCi.ToString.ToCharArray
        Dim verifyingDigit As Integer = Integer.Parse(ci.Last())

        If ci.Length <> 8 Then
            Throw New FormatException("error_formato_ci_longitud")
        End If

        Dim validDigit As Integer
        For i As Integer = 0 To 6
            Dim CIdigit = Integer.Parse(ci.ElementAt(i))
            Dim ArrayDigit = Integer.Parse(matriz.ElementAt(i))

            validDigit += CIdigit * ArrayDigit
        Next

        If validDigit Mod 10 = 0 Then
            validDigit = 0

        Else
            validDigit = 10 - (validDigit Mod 10)

        End If

        If validDigit <> verifyingDigit Then
            Throw New FormatException("error_ci_invalida")
        End If

    End Sub

    ''' <summary>
    ''' Valida los datos de entrada.
    ''' </summary>
    ''' <param name="ci">Cédula de identidad</param>
    ''' <param name="nombres">Nombre de la persona</param>
    ''' <param name="apellidoP">Apellido paterno o primero de la persona</param>
    ''' <param name="ApellidoM">Apellido materno o segundo de la persona</param>
    ''' <param name="calle">Calle en la que se encuentra la residencia en la que vive la persona</param>
    ''' <param name="numero">Numero de puerta del lugar de residencia de la persona</param>
    ''' <param name="localidad">Localidad del lugar donde la persona reside</param>
    ''' <param name="telefono">Teléfono móvil de la persona</param>
    Public Overloads Sub ValidateFields(ci As String,
                              nombres As String,
                              apellidoP As String,
                              ApellidoM As String,
                              calle As String,
                              numero As String,
                              localidad As String,
                              telefono As String
                              )
        If String.IsNullOrWhiteSpace(ci) Then
            Throw New FormatException("error_campo_obligatorio_ci.")

        ElseIf Not IsNumerical(ci) Then
            ' CI contiene letras o símbolos
            Throw New FormatException("error_formato_ci_numerico")

        ElseIf String.IsNullOrWhiteSpace(nombres) Then
            ' Nombre Vacio
            Throw New FormatException("error_campo_obligatorio_nombre")

        ElseIf ContainsSymbol(nombres) Then
            Throw New FormatException("error_formato_nombre")

        ElseIf String.IsNullOrWhiteSpace(apellidoP) And String.IsNullOrWhiteSpace(ApellidoM) Then
            ' Ningún apellido ingresado
            Throw New FormatException("error_campo_obligatorio_apellidos")

        ElseIf Not IsNumerical(telefono) Then
            ' Teléfono contiene caracteres que no sean numéricos
            Throw New FormatException("error_formato_telefono")

        ElseIf String.IsNullOrWhiteSpace(calle) Then
            ' Calle vacía
            Throw New FormatException("error_campo_obligatorio_calle")

        ElseIf ContainsSymbol(calle) Then
            ' Calle contiene símbolos
            Throw New FormatException("error_formato_calle")

        ElseIf String.IsNullOrWhiteSpace(numero) Then
            ' Campo numero vacío
            Throw New FormatException("error_campo_obligatorio_numero")

        ElseIf Not IsNumerical(numero) Then
            ' Numero de puerta contiene caracteres que no sean numéricos
            Throw New FormatException("error_formato_numero")

        ElseIf String.IsNullOrWhiteSpace(localidad) Then
            ' Localidad vacía
            Throw New FormatException("error_campo_obligatorio_localidad")

        ElseIf ContainsSymbol(localidad) Then
            ' Localidad contiene símbolos
            Throw New FormatException("error_formato_localidad")
        End If

        Try
            ValidateCi(ci)
        Catch ex As FormatException
            Throw ex
        End Try

    End Sub

    ''' <summary>
    ''' Función que evalua si una cadena de caracteres contiene símbolos.
    ''' </summary>
    ''' <param name="text">Cadena de caracteres a evaluar.</param>
    ''' <returns>Retorna True si contiene símbolos, de lo contrario retorna Flase.</returns>
    Public Function ContainsSymbol(text As String) As Boolean

        For Each caracter In text.ToCharArray
            If Char.IsSymbol(caracter) Then
                Return True
            End If
        Next
        Return False
    End Function

    ''' <summary>
    ''' Función que evalua si una cadena de caracteres contiene únicamente dígitos numéricos.
    ''' </summary>
    ''' <param name="text">Cadena de caracteres a evaluar.</param>
    ''' <returns>Retorna True si contiene solamente caracteres numéricos, de lo contrario retorna false.</returns>
    Public Function IsNumerical(text As String) As Boolean
        For Each caracter In text.ToCharArray
            If Not Char.IsDigit(caracter) Then
                Return False
            End If
        Next
        Return True
    End Function

    Public Sub ModifyPersona(pPersona As Persona)
        Dim PersonaDAO As New PersonaDAO

        Try
            PersonaDAO.ModifyPersona(pPersona)
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Protected Sub DeletePersona(ci As Integer)
        Dim PersonaDAO As New PersonaDAO

        Try
            PersonaDAO.DeletePersona(ci)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub ChangePassword(ci As Integer, newPassword As String)
        Dim PersonaDAO As New PersonaDAO

        Try
            newPassword = Password.Hash(newPassword)
            PersonaDAO.UpdatePassword(ci, newPassword)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class
