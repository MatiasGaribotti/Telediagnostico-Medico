Imports System.Security.Cryptography
Imports System.Text

Public Class Password

    Public Shared Sub Validate(password As String)
        Dim pswMaxLength = 40

        If password.Length > pswMaxLength Then
            Throw New FormatException("La longitud de la contraseña no puede exceder los " & pswMaxLength & " caracteres.")
        End If

        For Each c In password.ToCharArray
            If Char.IsSymbol(c) Then
                Throw New FormatException("La contraseña contiene caracteres no válidos.")

            End If
        Next
    End Sub

    Public Shared Function Generate(r As Random) As String
        Dim password As New StringBuilder("#")

        ' Caracteres aceptados para la contraseña
        Dim accepetedChars As String = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz0123456789"

        'Longitud de la password entre 15 y 20 caracteres
        Dim lenght As Integer = r.Next(15, 20)

        ' Genero el caracter aleatorio n-1 veces
        ' porque el primer caracter siempre va a ser el #
        ' que es el que identifica a las contraseñas autogeneradas
        For i As Integer = 0 To lenght - 1
            Dim idx As Integer = r.Next(accepetedChars.Length)
            password.Append(accepetedChars.Substring(idx, 1))
        Next
        Return password.ToString
    End Function

    Public Shared Function IsGenerated(password As String) As Boolean
        Return password.StartsWith("#")
    End Function

    'Funcion que hashea la contraseña y devuelve el valor en hexadecimal del hash
    Public Shared Function Hash(pwd As String) As String
        Dim hasSvc = SHA256.Create()
        Dim bytes As Byte() = hasSvc.ComputeHash(Encoding.UTF8.GetBytes(pwd))

        ' 64 Bytes long HEX string
        Dim hex = BitConverter.ToString(bytes).Replace("-", "")
        Return hex
    End Function

End Class
