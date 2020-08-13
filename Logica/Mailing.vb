Imports System.Net.Mail
Public Class Mailing
    Private Const USER As String = "kartoffelsolutions@gmail.com"
    Private Const PSW As String = "" 'AGREGAR CONTRASEÑA
    Private _SMTPServer As SmtpClient
    Private _Mail As MailMessage
    Private Const _CHAT_COPY_SUBJECT As String = "Copia de Chat - Sistema de Telediagnóstico"
    Private Const _CHAT_COPY_BODY As String = "Aqui está la copia de su conversación."


    Public Property SMTPServer As SmtpClient
        Get
            Return _SMTPServer
        End Get
        Set(value As SmtpClient)
            _SMTPServer = value
        End Set
    End Property

    Public Property Mail As MailMessage
        Get
            Return _Mail
        End Get
        Set(value As MailMessage)
            _Mail = value
        End Set
    End Property

    Public Shared ReadOnly Property CHAT_COPY_SUBJECT As String
        Get
            Return _CHAT_COPY_SUBJECT
        End Get
    End Property

    Public Shared ReadOnly Property CHAT_COPY_BODY As String
        Get
            Return _CHAT_COPY_BODY
        End Get
    End Property

    Public Sub New()
        'SERVIDOR SMTP
        _SMTPServer = New SmtpClient("smtp.gmail.com") With {
            .Port = 587,
            .UseDefaultCredentials = False,
            .Credentials = New System.Net.NetworkCredential(USER, PSW),
            .EnableSsl = True
        }

        'MAIL
        _Mail = New MailMessage With {
            .From = New MailAddress("kartoffelsolutions@gmail.com")
        }
    End Sub

    Public Sub SendEmail(destination As String, subject As String, body As String, attachmentPath As String)
        _Mail.To.Add(destination)
        _Mail.Subject = subject
        _Mail.Body = body
        Try
            _SMTPServer.Send(Mail)
            MsgBox("Mail enviado con éxito.", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("No se pudo enviar el mail." & vbCrLf & ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub
End Class
