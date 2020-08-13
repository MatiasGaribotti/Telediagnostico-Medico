Imports System.Net.Mail
Public Class Mailing
    Private Const USER As String = "kartoffelsolutions@gmail.com"
    Private Const PSW As String = "" 'AGREGAR CONTRASEÑA
    Public Shared ReadOnly Property CHAT_COPY_SUBJECT As String = "Copia de Chat - Sistema de Telediagnóstico"
    Public Shared ReadOnly Property CHAT_COPY_BODY As String = "Aqui está la copia de su conversación."

    Public Sub New()

    End Sub

    Public Shared Function SendEmail(destination As String, subject As String, body As String) As Boolean
        'SERVIDOR SMTP
        Dim SMTPServer As SmtpClient = New SmtpClient("smtp.gmail.com") With {
            .Port = 587,
            .UseDefaultCredentials = False,
            .Credentials = New System.Net.NetworkCredential(USER, PSW),
            .EnableSsl = True
        }

        Dim Mail = New MailMessage With {
            .From = New MailAddress("kartoffelsolutions@gmail.com")
        }
        Mail.To.Add(destination)
        Mail.Subject = subject
        Mail.Body = body
        Try
            SMTPServer.Send(Mail)
            MsgBox("Mail enviado con éxito.", MsgBoxStyle.Information)
            Return True
        Catch ex As Exception
            MsgBox("No se pudo enviar el mail." & vbCrLf & ex.Message, MsgBoxStyle.Critical)
            Return False
        End Try
    End Function

    Public Shared Function SendEmail(destination As String, subject As String, body As String, attachmentPath As String) As Boolean
        'SERVIDOR SMTP
        Dim SMTPServer As SmtpClient = New SmtpClient("smtp.gmail.com") With {
            .Port = 587,
            .UseDefaultCredentials = False,
            .Credentials = New System.Net.NetworkCredential(USER, PSW),
            .EnableSsl = True
        }

        Dim Mail = New MailMessage With {
            .From = New MailAddress("kartoffelsolutions@gmail.com")
        }

        Dim Attachment As New Attachment(attachmentPath)

        Mail.To.Add(destination)
        Mail.Subject = subject
        Mail.Body = body
        Mail.Attachments.Add(Attachment)
        Try
            SMTPServer.Send(Mail)
            MsgBox("Mail enviado con éxito.", MsgBoxStyle.Information)
            Return True
        Catch ex As Exception
            MsgBox("No se pudo enviar el mail." & vbCrLf & ex.Message, MsgBoxStyle.Critical)
            Return False
        End Try
    End Function
End Class
