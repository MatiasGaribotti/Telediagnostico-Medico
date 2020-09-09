Public MustInherit Class PersonaBUS
    Public Function ValidateCi(ciAValidar As Integer) As Boolean
        'Valida que la cédula de identidad sea válida
        Dim valida As Boolean = True
        Dim ci As String = ciAValidar.ToString()

        If (ci.Length <> 8) Then

            valida = False

        ElseIf valida Then

            Dim digitoVerificador As Integer = Integer.Parse(ci.ToCharArray.Last.ToString)

            'ElseIF
        End If

        Return valida
    End Function

    ''' <summary>
    ''' Valida los datos de entrada.
    ''' </summary>
    ''' <param name="ci"></param>
    ''' <param name="nombres"></param>
    ''' <param name="apellidoP"></param>
    ''' <param name="ApellidoM"></param>
    ''' <param name="calle"></param>
    ''' <param name="numero"></param>
    ''' <param name="localidad"></param>
    ''' <param name="detalle"></param>
    ''' <param name="telefono"></param>
    Public Overloads Sub ValidateFields(ci As String,
                              nombres As String,
                              apellidoP As String,
                              ApellidoM As String,
                              calle As String,
                              numero As String,
                              localidad As String,
                              detalle As String,
                              telefono As String
                              )
        'Longitud de la cédula
        If String.IsNullOrWhiteSpace(ci) Then
            Throw New FormatException("El campo cédula es obligatorio.")
        ElseIf ci.Length <> 8 Then
            Throw New FormatException("La cédula de identidad debe tener una longitud de 8 dígitos.")
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

    End Sub

    Protected Function ContainsSymbol(text As String) As Boolean

        For Each caracter In text.ToCharArray
            If Char.IsSymbol(caracter) Then
                Return True
            End If
        Next
        Return False
    End Function

    Protected Function IsNumerical(text As String) As Boolean
        For Each caracter In text.ToCharArray
            If Not Char.IsDigit(caracter) Then
                Return False
            End If
        Next
        Return True
    End Function
End Class
