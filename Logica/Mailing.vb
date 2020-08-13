Imports System.Net.Mail
Public Class Mailing
    Private Const USER As String = "kartoffelsolutions@gmail.com"
    Private Const PSW As String = "" 'AGREGAR CONTRASEÑA
    Public Shared ReadOnly Property CHAT_COPY_SUBJECT As String = "Copia de Chat - Sistema de Telediagnóstico"
    Public Shared ReadOnly Property CHAT_COPY_BODY As String = "Aqui está la copia de su conversación."
    Public Property SMTPServer As SmtpClient
    Public Property Mail As MailMessage

    Public Sub New()
        'SERVIDOR SMTP
        SMTPServer = New SmtpClient("smtp.gmail.com") With {
            .Port = 587,
            .UseDefaultCredentials = False,
            .Credentials = New System.Net.NetworkCredential(USER, PSW),
            .EnableSsl = True
        }

        'MAIL
        Mail = New MailMessage With {
            .From = New MailAddress("kartoffelsolutions@gmail.com")
        }
    End Sub

    Public Sub SendEmail(destination As String, subject As String, body As String, attachmentPath As String)
        Mail.To.Add(destination)
        Mail.Subject = subject
        Mail.Body = body
        Try
            SMTPServer.Send(Mail)
            MsgBox("Mail enviado con éxito.", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("No se pudo enviar el mail." & vbCrLf & ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub
End Class
