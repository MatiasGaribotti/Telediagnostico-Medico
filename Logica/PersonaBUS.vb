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
            Throw New FormatException("La cédula de identidad debe tener una longitud de 8 dígitos.")
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
            Throw New FormatException("La cédula ingresada no es válida.")
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
            Throw New FormatException("El campo cédula es obligatorio.")

        ElseIf Not IsNumerical(ci) Then
            ' CI contiene letras o símbolos
            Throw New FormatException("La cédula de identidad solo puede contener dígitos.")

        ElseIf String.IsNullOrWhiteSpace(nombres) Then
            ' Nombre Vacio
            Throw New FormatException("El campo nombre es obligatorio.")

        ElseIf ContainsSymbol(nombres) Then
            Throw New FormatException("El formato del campo nombre no es correcto.")

        ElseIf String.IsNullOrWhiteSpace(apellidoP) And String.IsNullOrWhiteSpace(ApellidoM) Then
            ' Ningún apellido ingresado
            Throw New FormatException("Por favor ingrese por lo menos un apellido.")

        ElseIf Not IsNumerical(telefono) Then
            ' Teléfono contiene caracteres que no sean numéricos
            Throw New FormatException("El teléfono solo puede contener dígitos.")

        ElseIf String.IsNullOrWhiteSpace(calle) Then
            ' Calle vacía
            Throw New FormatException("El campo calle es obligatorio.")

        ElseIf ContainsSymbol(calle) Then
            ' Calle contiene símbolos
            Throw New FormatException("El formato del campo calle no es correcto.")

        ElseIf String.IsNullOrWhiteSpace(numero) Then
            ' Campo numero vacío
            Throw New FormatException("El campo número es obligatorio.")

        ElseIf Not IsNumerical(numero) Then
            ' Numero de puerta contiene caracteres que no sean numéricos
            Throw New FormatException("El formato del campo número no es correcto.")

        ElseIf String.IsNullOrWhiteSpace(localidad) Then
            ' Localidad vacía
            Throw New FormatException("El campo localidad es obligatorio.")

        ElseIf ContainsSymbol(localidad) Then
            ' Localidad contiene símbolos
            Throw New FormatException("El formato del campo localidad no es correcto.")
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
End Class
