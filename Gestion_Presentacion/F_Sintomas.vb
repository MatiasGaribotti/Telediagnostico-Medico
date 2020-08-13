Imports Logica
Public Class F_Sintomas

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        F_ABM.Show()
        Me.Close()
    End Sub

    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        Dim sintoma = GetSintoma()
        sintoma.Insert()

    End Sub

    Private Function ValidateFields() As Boolean

        Return True
    End Function
    Private Function GetSintoma() As Sintoma
        If ValidateFields() Then
            Dim sintoma As New Sintoma() With {
                .Nombre = TxtISintoma.Text,
                .Descripcion = TxtIDescripcion.Text,
                .Tipo = CmbITipo.SelectedItem.ToString()
            }
            Return sintoma
        Else
            Return Nothing
        End If
    End Function
End Class