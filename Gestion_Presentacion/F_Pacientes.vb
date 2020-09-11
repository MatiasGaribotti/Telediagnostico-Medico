Imports System.Threading
Imports System.Globalization
Imports Logica
Imports Dominio

Public Class F_Pacientes

    Public Sub New()
        Thread.CurrentThread.CurrentUICulture = Env.CurrentLangugage
        InitializeComponent()
        ' Fecha de nacimiento posterior a la actual no permitida
        'DTPickerFNac.MaxDate = Date.Now()
        ConfigMode()
    End Sub

    Public Property Modo As Modos

    Public Enum Modos
        Ingresar
        Modificar
    End Enum

    Public Sub ConfigMode()

        If Env.CurrentUser.IsRecepcionista Then
            'Buttons
            BtnModificar.Enabled = False
            BtnEliminar.Enabled = False


            'Fields
            TxtINFam.Enabled = False
            TxtIAntFam.Enabled = False
            TxtIAntLab.Enabled = False


        ElseIf Env.CurrentUser.IsRRHH Then
            BtnIngresar.Enabled = False
            BtnModificar.Enabled = False
            BtnEliminar.Enabled = False
            BtnResetPassword.Enabled = False

            'Fields
            TxtINFam.Enabled = False
            TxtIAntFam.Enabled = False
            TxtIAntLab.Enabled = False


        ElseIf Env.CurrentUser.IsAdministrador Then
            BtnResetPassword.Enabled = False

        End If
    End Sub

    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        Try
            ValidateIngresarFields()
            Dim paciente = GetPaciente()

            If Env.CurrentUser.IsRecepcionista Then
                Dim recepcionista As New RecepcionistaBUS
                Try
                    recepcionista.IngresarPaciente(paciente)
                    MsgBox("Paciente ingresado con éxito.", MsgBoxStyle.Information, "Usuario Ingresado")
                    LoadDgv()
                    ClearFields()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

            Else
                Try
                    Dim administrador As New AdministradoBUS
                    administrador.IngresarPaciente(paciente)
                    MsgBox("Paciente ingresado con éxito.", MsgBoxStyle.Information, "Usuario Ingresado")
                    LoadDgv()
                    ClearFields()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
                End Try
            End If

        Catch ex As FormatException
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Formato")
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
                                   TxtITelefono.Text
                                   )

        Catch ex As Exception
            MsgBox(ex.Message)
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


    Private Function ContainsSymbol(text As String) As Boolean

        For Each caracter In text.ToCharArray
            If Char.IsSymbol(caracter) Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Function IsNumerical(text As String) As Boolean
        For Each caracter In text.ToCharArray
            If Not Char.IsDigit(caracter) Then
                Return False
            End If
        Next
        Return True
    End Function

    Private Sub F_Pacientes_Load(sender As Object, e As EventArgs) Handles Me.Load
        CmbIDepartamento.DataSource = [Enum].GetValues(GetType(Direccion.Departamentos))
        LoadDgv()
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

        Dim pwd As String = Password.Hash(Password.Generate(New Random))

        paciente = New Paciente(
                            CInt(TxtICi.Text),
                            TxtINombre.Text,
                            TxtIApellidoP.Text,
                            TxtIApellidoM.Text,
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
            Dim paciente = GetSelected()
            objRecepcionista.ResetPassword(paciente)
            MsgBox("Contraseña restablecida correctamente.", MsgBoxStyle.Information, "Información")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Function GetSelected() As Paciente
        Dim paciente As New Paciente()
        Dim direccion As New Direccion()
        Dim cells As DataGridViewCellCollection = DgvPacientes.SelectedRows.Item(0).Cells

        Try
            paciente.Ci = cells.Item(0).Value

            ' La consulta concatena el la información de la siguiente manera
            ' nombre,apellidoP,apellidoM
            Dim nombreCompleto = cells.Item(1).Value.ToString.Split(" ")


            paciente.Nombre = nombreCompleto.ElementAt(0)
            paciente.ApellidoP = nombreCompleto.ElementAt(1)
            paciente.ApellidoM = nombreCompleto.ElementAt(2)

            Dim tmpFechaNacimiento = cells.Item(2).Value.ToString.Substring(0, 10).Split(".")


            ' Obtengo la fecha de nacimiento
            Dim year, month, day As Integer
            year = tmpFechaNacimiento.ElementAt(2)
            month = tmpFechaNacimiento.ElementAt(1)
            day = tmpFechaNacimiento.ElementAt(0)

            paciente.Fecha_Nacimiento = New Date(year, month, day)

            paciente.Telefono = cells.Item(3).Value
            paciente.Email = cells.Item(4).Value

            ' Direccion
            ' Formato: calle,numero,localidad,departamento,detalle

            Dim tmpDireccion = cells.Item(5).Value.ToString.Split(",")

            direccion.Calle = tmpDireccion.ElementAt(0)
            direccion.Nro = Integer.Parse(tmpDireccion.ElementAt(1))
            direccion.Localidad = tmpDireccion.ElementAt(2)
            direccion.Departamento = [Enum].Parse(GetType(Direccion.Departamentos), tmpDireccion.ElementAt(3))
            direccion.Detalle = tmpDireccion.ElementAt(4)

            ' Nucleo Familiar
            paciente.NucleoFlia = cells.Item(6).Value.ToString

            ' Antecedentes Familiares
            paciente.AntecedentesFlia = cells.Item(7).Value.ToString

            'Antecedentes Laborales
            paciente.AntecedentesLab = cells.Item(8).Value.ToString

        Catch ex As Exception
            Throw New Exception("Error al procesar los datos del paciente.")
        End Try
        Return paciente
    End Function

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        ' NOT IMPLEMENTED
        Dim admin As Administrador = Env.CurrentUser
        Try
            Dim paciente As Paciente = GetSelected()
            'Dim enfermedades As List(Of Enfermedad) = admin.GetPaciente(ci)
            'LoadFields(paciente)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub LoadFields(p As Paciente, enfermedades As List(Of Enfermedad))

        TxtICi.Text = p.Ci
        TxtINombre.Text = p.Nombre
        TxtIApellidoP.Text = p.ApellidoP
        TxtIApellidoM.Text = p.ApellidoM
        DTPickerFNac.Value = p.Fecha_Nacimiento
        TxtITelefono.Text = p.Telefono
        TxtICalle.Text = p.Direccion.Calle
        TxtINumero.Text = p.Direccion.Nro
        CmbIDepartamento.SelectedIndex = p.Direccion.Departamento
        TxtIDetalle.Text = p.Direccion.Detalle
        TxtIEmail.Text = p.Email
        TxtINFam.Text = p.NucleoFlia
        TxtIAntFam.Text = p.AntecedentesFlia
        TxtIAntLab.Text = p.AntecedentesLab

    End Sub

    Private Sub BtnFiltrar_Click(sender As Object, e As EventArgs) Handles BtnFiltrar.Click
        Try
            ValidateFiltrarFields()
        Catch ex As FormatException
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Formato")
        End Try
    End Sub
End Class