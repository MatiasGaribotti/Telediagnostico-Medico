Imports System.Threading
Imports Dominio
Imports Guna.UI2.WinForms

Public Class Translator
    Public Shared Function TranslateKey(key As String) As String
        Dim translation As String = Nothing


        Select Case Env.CurrentLangugage.ToString
            Case "es-UY"
                translation = My.Resources.es_UY.ResourceManager.GetString(key)

            Case "en-US"
                translation = My.Resources.en_US.ResourceManager.GetString(key)

        End Select

        If translation Is Nothing Then
            translation = key
        End If

        Return translation
    End Function

    Public Shared Sub TranslateForm(ByRef form As Form)
        For Each control As Control In form.Controls

            If TypeOf control Is Guna2Panel Then
                Dim panel As Guna2Panel = DirectCast(control, Guna2Panel)
                TranslatePanel(panel)

            ElseIf TypeOf control Is Label Then
                TranslateLabel(control)

            ElseIf TypeOf control Is Guna2HtmlLabel Then
                TranslateGunaLabel(control)

            ElseIf TypeOf control Is Button Then
                TranslateButton(control)

            ElseIf TypeOf control Is Guna2Button Then
                TranslateGunaButton(control)

            End If
        Next
    End Sub

    Public Shared Sub TranslatePanel(ByRef panel As Panel)
        For Each control As Control In panel.Controls

            If TypeOf control Is Guna2HtmlLabel Then
                TranslateGunaLabel(control)

            ElseIf TypeOf control Is Label Then
                TranslateLabel(control)

            ElseIf TypeOf control Is Guna2Button Then
                TranslateGunaButton(control)

            ElseIf TypeOf control Is Button Then
                TranslateButton(control)

            End If
        Next
    End Sub

    Private Shared Sub TranslateLabel(ByRef control As Control)
        Dim label As Label = DirectCast(control, Label)
        label.Text = TranslateKey(label.Text)
    End Sub

    Private Shared Sub TranslateGunaLabel(ByRef control As Control)
        Dim label As Guna2HtmlLabel = DirectCast(control, Guna2HtmlLabel)
        label.Text = TranslateKey(label.Text)
    End Sub

    Private Shared Sub TranslateButton(ByRef control As Control)
        Dim button As Button = DirectCast(control, Button)
        button.Text = TranslateKey(button.Text)
    End Sub

    Private Shared Sub TranslateGunaButton(ByRef control As Control)
        Dim button As Guna2Button = DirectCast(control, Guna2Button)
        button.Text = TranslateKey(button.Text)
    End Sub
End Class
