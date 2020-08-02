Public Class Password

    Public Shared Function Validate(Password As String) As Boolean

        Return True
    End Function

    Public Shared Function Generate() As String
        Dim password As String = "#"

        VBMath.Randomize()
        For i = 0 To 11
            If (CInt(2 * Rnd()) = 1) Then

            Else


            End If
        Next

        Return password
    End Function

    Public Shared Sub ResetPassword(user As Persona)

    End Sub

    Public Shared Function IsGenerated(password As String) As Boolean

        Return True
    End Function
End Class
