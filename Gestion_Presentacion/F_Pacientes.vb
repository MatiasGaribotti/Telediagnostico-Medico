Imports System.Threading
Imports Logica
Imports Dominio

Public Class F_Pacientes
    Public Property Modo As Modos
    Public Enum Modos
        Ingresar
        Modificar
    End Enum

    Public Sub New()
        Thread.CurrentThread.CurrentUICulture = Env.CurrentLangugage
        InitializeComponent()
        ' Fecha de nacimiento posterior a la actual no permitida
        DTPickerFNac.MaxDate = Date.Now()
        ConfigMode()
    End Sub

    Private Sub F_Pacientes_Load(sender As Object, e As EventArgs) Handles Me.Load
        Translator.TranslateForm(Me)
        Refresh()
        CmbIDepartamento.DataSource = [Enum].GetValues(GetType(Direccion.Departamentos))
        LoadDgv()
    End Sub

    Public Sub ConfigMode()

        If Env.CurrentUser.IsRecepcionista Then

            'Fields
            TxtINFam.Enabled = False
            TxtIAntFam.Enabled = False
            TxtIAntLab.Enabled = False

        ElseIf Env.CurrentUser.IsAdministrador Then
            BtnResetPassword.Enabled = False

        End If

        ChangeMode(Modos.Ingresar)
    End Sub

    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        Try
            Dim paciente = GetPaciente()

            If Modo = Modos.Ingresar Then
                ValidateIngresarFields()
                If Env.CurrentUser.IsRecepcionista Then
                    Dim recepcionista As New RecepcionistaBUS
                    Try
                        recepcionista.IngresarPaciente(paciente)
                        MsgBox(Translator.TranslateKey("paciente_ingresar_exito"), MsgBoxStyle.Information, Translator.TranslateKey("titulo_usuario_ingresado"))
                        LoadDgv()
                        ClearFields()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try

                Else
                    Try
                        Dim administrador As New AdministradorBUS
                        administrador.InsertPaciente(paciente)
                        MsgBox(Translator.TranslateKey("paciente_ingresar_exito"), MsgBoxStyle.Information, Translator.TranslateKey("titulo_usuario_ingresado"))
                        LoadDgv()
                        ClearFields()

                    Catch ex As Exception
                        MsgBox(Translator.TranslateKey(ex.Message), MsgBoxStyle.Critical, Translator.TranslateKey("error"))

                    End Try
                End If
            ElseIf Modo = Modos.Modificar Then

                If Env.CurrentUser.IsRecepcionista Then
                    Dim RecepcionistaBUS As New RecepcionistaBUS
                    RecepcionistaBUS.ModifyPaciente(paciente)


                ElseIf Env.CurrentUser.IsAdministrador Then
                    Dim AdministradorBUS As New AdministradorBUS
                    AdministradorBUS.ModifyPaciente(paciente)

                End If

                ChangeMode(Modos.Ingresar)
                ClearFields()
                LoadDgv()
                MsgBox(Translator.TranslateKey("paciente_modificar_exito"), MsgBoxStyle.Information, Translator.TranslateKey("información"))

            End If

        Catch ex As FormatException
            MsgBox(Translator.TranslateKey(ex.Message), MsgBoxStyle.Exclamation, Translator.TranslateKey("error_formato"))

        Catch ex As Exception
            MsgBox(Translator.TranslateKey("error_inesperado"))
        End Try

    End Sub

    'Procedimiento que limpia el contenido de los campos
    Private Sub ClearFields()
        Select Case Modo
            Case Modos.Ingresar
                'Se limpian los campos de ingreso
                TxtICi.ResetText()
                TxtINombre.ResetText()
                TxtIApellidoP.ResetText()
                TxtIApellidoM.ResetText()
                RadioIM.Checked = True
                RadioIF.Checked = False
                RadioIOtro.Checked = False
                TxtITelefono.ResetText()
                TxtICalle.ResetText()
                TxtINumero.ResetText()
                TxtBLocalidad.ResetText()
                CmbBDepartamento.SelectedItem = 0
                TxtIDetalle.ResetText()
                TxtIEmail.ResetText()
                TxtINFam.ResetText()
                TxtIAntFam.ResetText()
                TxtIAntLab.ResetText()
            Case Else
                'Se limpian los campos de búsqueda
                TxtBCi.ResetText()
                TxtBNombre.ResetText()
                TxtBApellidoP.ResetText()
                TxtBApellidoM.ResetText()
                TxtBTelefono.ResetText()
                TxtBCalle.ResetText()
                TxtBNumero.ResetText()
                TxtBLocalidad.ResetText()
                CmbBDepartamento.SelectedItem = 0
                TxtBDetalle.ResetText()
                TxtBEmail.ResetText()
        End Select
    End Sub

    ' Valida los campos de ingreso de pacientes
    Private Sub ValidateIngresarFields()
        Dim PacienteBUS As New PacienteBUS
        Try
            PacienteBUS.ValidateFields(TxtICi.Text,
                                   TxtINombre.Text,
                                   TxtIApellidoP.Text,
                                   TxtIApellidoM.Text,
                                   TxtICalle.Text,
                                   TxtINumero.Text,
                                   TxtILocalidad.Text,
                                   TxtITelefono.Text,
                                   TxtINFam.Text,
                                   TxtIAntFam.Text,
                                   TxtIAntLab.Text
                                   )

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    ' Valida los campos de búsqueda
    Private Sub ValidateFiltrarFields()
        Dim PacienteBUS As New PacienteBUS

        Try
            PacienteBUS.ValidateFields(TxtBCi.Text,
                                   TxtBNombre.Text,
                                   TxtBApellidoP.Text,
                                   TxtBApellidoM.Text,
                                   TxtBCalle.Text,
                                   TxtBNumero.Text,
                                   TxtBLocalidad.Text,
                                   TxtBTelefono.Text
                                   )
            If Not PacienteBUS.IsNumerical(TxtBEdad.Text) Then
                Throw New FormatException("La edad debe ser un valor numérico.")
            End If
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        F_ABM.Show()
        Close()
    End Sub

    Private Function GetPaciente() As Paciente
        Dim paciente As Paciente

        ' Si el teléfono no fue ingresado, tendrá el valor -1
        Dim telefono As Integer = -1
        If Not String.IsNullOrWhiteSpace(TxtITelefono.Text) Then
            telefono = CInt(TxtITelefono.Text)

        End If

        Dim sexo As Persona.Sexos

        If RadioIM.Checked Then
            sexo = Persona.Sexos.M

        ElseIf RadioIF.Checked Then
            sexo = Persona.Sexos.F

        Else
            sexo = Persona.Sexos.Otro
        End If

        Dim pwd As String = Password.Hash(Password.Generate(New Random))

        paciente = New Paciente(
                            CInt(TxtICi.Text),
                            TxtINombre.Text,
                            TxtIApellidoP.Text,
                            TxtIApellidoM.Text,
                            sexo,
                            New Direccion(TxtICalle.Text,
                                            CInt(TxtINumero.Text),
                                            TxtILocalidad.Text,
                                            CmbIDepartamento.SelectedIndex + 1,
                                            TxtIDetalle.Text),
                            telefono,
                            Format(DTPickerFNac.Value, "yyyy-MM-dd"),
                            pwd,
                            TxtIEmail.Text,
                            TxtINFam.Text,
                            TxtIAntFam.Text,
                            TxtIAntLab.Text
                            )
        Return paciente
    End Function
    Private Sub LoadDgv()
        Dim objPaciente As New PacienteBUS()
        Try
            Dim dt As DataTable = objPaciente.GetPacientes()
            DgvPacientes.DataSource = dt
            'DgvPacientes.Columns.Item(0).Visible = False
            'DgvPacientes.Columns.Item(1).Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnResetPassword_Click(sender As Object, e As EventArgs) Handles BtnResetPassword.Click
        Dim objRecepcionista As New RecepcionistaBUS
        Try
            Dim listaPacientes = GetSelected()
            If listaPacientes.Count = 1 Then
                Dim password As String = objRecepcionista.ResetPassword(listaPacientes.First)

                Dim printing As New F_Template_Printing(listaPacientes.First.Ci, password)
                printing.Show()
                printing.Print()
                printing.Close()

                MsgBox("Contraseña restablecida correctamente.", MsgBoxStyle.Information, "Información")

            Else
                MsgBox("No se puede restablecer la contraseña de más de un paciente a la vez.")
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Function GetSelected() As List(Of Paciente)
        Dim listaPacientes As New List(Of Paciente)

        Try
            For i As Integer = 0 To DgvPacientes.SelectedRows.Count - 1

                Dim paciente As New Paciente()
                Dim direccion As New Direccion()
                Dim cells As DataGridViewCellCollection = DgvPacientes.SelectedRows.Item(i).Cells

                paciente.Ci = cells.Item(0).Value

                ' La consulta concatena el la información de la siguiente manera
                ' nombre,apellidoP,apellidoM
                Dim nombreCompleto = cells.Item(1).Value.ToString.Split(",")


                paciente.Nombre = nombreCompleto.ElementAt(0)
                paciente.ApellidoP = nombreCompleto.ElementAt(1)
                paciente.ApellidoM = nombreCompleto.ElementAt(2)

                paciente.Sexo = [Enum].Parse(GetType(Persona.Sexos), cells.Item(2).Value.ToString)

                Dim tmpFechaNacimiento = cells.Item(3).Value.ToString.Substring(0, 10).Split(".")


                ' Obtengo la fecha de nacimiento
                Dim year, month, day As Integer
                year = tmpFechaNacimiento.ElementAt(2)
                month = tmpFechaNacimiento.ElementAt(1)
                day = tmpFechaNacimiento.ElementAt(0)

                paciente.Fecha_Nacimiento = New Date(year, month, day)

                paciente.Telefono = cells.Item(4).Value
                paciente.Email = cells.Item(5).Value

                ' Direccion
                ' Formato: calle,numero,localidad,departamento,detalle

                Dim tmpDireccion = cells.Item(6).Value.ToString.Split(",")

                direccion.Calle = tmpDireccion.ElementAt(0)
                direccion.Nro = Integer.Parse(tmpDireccion.ElementAt(1))
                direccion.Localidad = tmpDireccion.ElementAt(2)
                direccion.Departamento = [Enum].Parse(GetType(Direccion.Departamentos), tmpDireccion.ElementAt(3))
                direccion.Detalle = tmpDireccion.ElementAt(4)

                paciente.Direccion = direccion

                ' Nucleo Familiar
                paciente.NucleoFlia = cells.Item(7).Value.ToString

                ' Antecedentes Familiares
                paciente.AntecedentesFlia = cells.Item(8).Value.ToString

                'Antecedentes Laborales
                paciente.AntecedentesLab = cells.Item(9).Value.ToString

                listaPacientes.Add(paciente)
            Next

        Catch ex As Exception
            Throw New Exception("Error al procesar los datos del paciente.")
        End Try

        Return listaPacientes
    End Function

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        Dim AdministradorBUS As New AdministradorBUS

        Try

            Dim listaPacientes As List(Of Paciente) = GetSelected()

            If listaPacientes.Count = 1 Then
                ChangeMode(Modos.Modificar)
                LoadFields(listaPacientes.First)

            Else
                MsgBox("No se puede modificar más de un paciente a la vez.")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ChangeMode(pMode As Modos)
        Modo = pMode
        BtnIngresar.Text = Translator.TranslateKey(Modo.ToString.ToLower)

        If pMode = Modos.Ingresar Then
            BtnCancelar.Visible = False
        Else
            BtnCancelar.Visible = True
        End If
    End Sub

    Private Sub LoadFields(paciente As Paciente)

        TxtICi.Text = paciente.Ci
        TxtINombre.Text = paciente.Nombre
        TxtIApellidoP.Text = paciente.ApellidoP
        TxtIApellidoM.Text = paciente.ApellidoM

        If paciente.Sexo = Persona.Sexos.M Then
            RadioIM.Checked = True
            RadioIF.Checked = False
            RadioIOtro.Checked = False

        ElseIf paciente.Sexo = Persona.Sexos.F Then
            RadioIM.Checked = False
            RadioIF.Checked = True
            RadioIOtro.Checked = False

        Else
            RadioIM.Checked = False
            RadioIF.Checked = False
            RadioIOtro.Checked = True

        End If

        DTPickerFNac.Value = paciente.Fecha_Nacimiento
        TxtITelefono.Text = paciente.Telefono
        TxtICalle.Text = paciente.Direccion.Calle
        TxtINumero.Text = paciente.Direccion.Nro
        TxtILocalidad.Text = paciente.Direccion.Localidad
        CmbIDepartamento.SelectedIndex = paciente.Direccion.Departamento
        TxtIDetalle.Text = paciente.Direccion.Detalle
        TxtIEmail.Text = paciente.Email
        TxtINFam.Text = paciente.NucleoFlia
        TxtIAntFam.Text = paciente.AntecedentesFlia
        TxtIAntLab.Text = paciente.AntecedentesLab

    End Sub

    Private Sub BtnFiltrar_Click(sender As Object, e As EventArgs) Handles BtnFiltrar.Click
        Try
            ValidateFiltrarFields()
        Catch ex As FormatException
            MsgBox(Translator.TranslateKey(ex.Message), MsgBoxStyle.Critical, Translator.TranslateKey("error_formato"))
        End Try
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Try
            Dim count As Integer = DgvPacientes.SelectedRows.Count
            Dim confirmation As Boolean


            confirmation = MsgBox(Translator.TranslateKey("confirmacion_paciente_eliminar"), MsgBoxStyle.YesNo, Translator.TranslateKey("confirmacion"))

            If confirmation Then
                Dim listaPacientes As List(Of Paciente) = GetSelected()
                Dim RecepcionistaBUS As New RecepcionistaBUS

                Dim output_message As String = Translator.TranslateKey("mensaje_paciente_eliminar") & vbCrLf

                For Each paciente In listaPacientes
                    Try
                        RecepcionistaBUS.DeletePaciente(paciente)

                    Catch ex As Exception
                        output_message += Translator.TranslateKey(ex.Message) & paciente.Nombre & "." & vbCrLf
                        count -= 1
                    End Try
                Next

                output_message.Replace("[COUNT]", count)
                output_message.Replace(Translator.TranslateKey("persona"), Translator.TranslateKey("paciente"))

                MsgBox(output_message, MsgBoxStyle.Information, Translator.TranslateKey("informacion"))
                LoadDgv()
            End If

        Catch ex As Exception
            MsgBox(Translator.TranslateKey(ex.Message), MsgBoxStyle.Critical, Translator.TranslateKey("error"))
        End Try
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        ChangeMode(Modos.Ingresar)
        ClearFields()
    End Sub
End Class