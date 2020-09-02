Imports System.Threading
Imports System.Globalization
Imports Logica

Public Class F_Pacientes

    Public Sub New()
        Thread.CurrentThread.CurrentUICulture = Logica.Env.CurrentLangugage
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
        Select Case Env.UserType
            Case Env.UserTypes.Recepcionista
                'Buttons
                BtnModificar.Enabled = False
                BtnEliminar.Enabled = False
                BtnAddEnfermedad.Enabled = False
                BtnDelEnfermedad.Enabled = False
                BtnIAddMed.Enabled = False
                BtnIDelMed.Enabled = False


                'Fields
                TxtINFam.Enabled = False
                TxtIAntFam.Enabled = False
                TxtITratamientos.Enabled = False
                TxtIAntLab.Enabled = False
                TxtIMedicacion.Enabled = False
                TxtIEnfermedad.Enabled = False
                CmbIEnfermedad.Enabled = False
                CmbIMedicacion.Enabled = False


            Case Env.UserTypes.RRHH
                BtnIngresar.Enabled = False
                BtnModificar.Enabled = False
                BtnEliminar.Enabled = False
                BtnResetPassword.Enabled = False
                BtnAddEnfermedad.Enabled = False
                BtnDelEnfermedad.Enabled = False
                BtnIAddMed.Enabled = False
                BtnIDelMed.Enabled = False


                'Fields
                TxtINFam.Enabled = False
                TxtIAntFam.Enabled = False
                TxtITratamientos.Enabled = False
                TxtIAntLab.Enabled = False
                TxtIMedicacion.Enabled = False

            Case Env.UserTypes.Administrador
                BtnResetPassword.Enabled = False
        End Select
    End Sub

    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        Try
            ValidateIngresarFields()
            Dim paciente = GetPaciente()

            Select Case Env.UserType
                Case Env.UserTypes.Recepcionista
                    Dim recepcionista As Recepcionista = Env.CurrentUser
                    Try
                        recepcionista.IngresarPaciente(paciente)
                        MsgBox("Paciente ingresado con éxito.", MsgBoxStyle.Information, "Usuario Ingresado")
                        LoadDgv()
                        ClearFields()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try

                Case Env.UserTypes.Administrador
                    Dim administrador As Administrador = Env.CurrentUser
                    Try
                        administrador.IngresarPaciente(paciente)
                        MsgBox("Paciente ingresado con éxito.", MsgBoxStyle.Information, "Usuario Ingresado")
                        LoadDgv()
                        ClearFields()
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
                    End Try
            End Select

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
                TxtITratamientos.ResetText()
                TxtIAntLab.ResetText()
                CmbIEnfermedad.Items.Clear()
                CmbIMedicacion.Items.Clear()
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
        'Longitud de la cédula
        If String.IsNullOrWhiteSpace(TxtICi.Text) Then
            Throw New FormatException("El campo cédula es obligatorio.")
        ElseIf TxtICi.TextLength <> 8 Then
            Throw New FormatException("La cédula de identidad debe tener una longitud de 8 dígitos.")
        ElseIf Not IsNumerical(TxtICi.Text) Then
            ' CI contiene letras o símbolos
            Throw New FormatException("La cédula de identidad solo puede contener dígitos.")

        ElseIf String.IsNullOrWhiteSpace(TxtINombre.Text) Then
            ' Nombre Vacio
            Throw New FormatException("El campo nombre es obligatorio.")

        ElseIf ContainsSymbol(TxtINombre.Text) Then
            Throw New FormatException("El formato del campo nombre no es correcto.")

        ElseIf String.IsNullOrWhiteSpace(TxtIApellidoP.Text) And String.IsNullOrWhiteSpace(TxtIApellidoM.Text) Then
            ' Ningún apellido ingresado
            Throw New FormatException("Por favor ingrese por lo menos un apellido.")

        ElseIf Not IsNumerical(TxtITelefono.Text) Then
            ' Teléfono contiene caracteres que no sean numéricos
            Throw New FormatException("El teléfono solo puede contener dígitos.")

        ElseIf String.IsNullOrWhiteSpace(TxtICalle.Text) Then
            ' Calle vacía
            Throw New FormatException("El campo calle es obligatorio.")

        ElseIf ContainsSymbol(TxtICalle.Text) Then
            ' Calle contiene símbolos
            Throw New FormatException("El formato del campo calle no es correcto.")

        ElseIf String.IsNullOrWhiteSpace(TxtINumero.Text) Then
            ' Campo numero vacío
            Throw New FormatException("El campo número es obligatorio.")

        ElseIf Not IsNumerical(TxtINumero.Text) Then
            ' Numero de puerta contiene caracteres que no sean numéricos
            Throw New FormatException("El formato del campo número no es correcto.")

        ElseIf String.IsNullOrWhiteSpace(TxtILocalidad.Text) Then
            ' Localidad vacía
            Throw New FormatException("El campo localidad es obligatorio.")

        ElseIf ContainsSymbol(TxtILocalidad.Text) Then
            ' Localidad contiene símbolos
            Throw New FormatException("El formato del campo localidad no es correcto.")

        ElseIf ContainsSymbol(TxtINFam.Text) Then
            ' Núcleo Familiar contiene símbolos
            Throw New FormatException("El formato del campo núcleo familiar no es correcto.")

        ElseIf ContainsSymbol(TxtIAntFam.Text) Then
            ' Antecedentes familiares contiene símbolos
            Throw New FormatException("El formato del campo antecedentes familiares no es correcto.")

        ElseIf ContainsSymbol(TxtITratamientos.Text) Then
            ' Tratamientos contiene símbolos
            Throw New FormatException("El formato del campo tratamiento no es correcto.")

        ElseIf ContainsSymbol(TxtIAntLab.Text) Then
            ' Antecedentes laborales contiene símbolos
            Throw New FormatException("El formato del campo antecedentes laborales no es correcto.")

            ' Enfermedades ingresadas no existen
            'ElseIf Not EnfermedadesExisten() Then


        End If
    End Sub

    ' Valida los campos de búsqueda
    Private Sub ValidateFiltrarFields()

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

    Private Sub BtnIAddItem_Click(sender As Object, e As EventArgs) Handles BtnIAddMed.Click
        CmbIMedicacion.Items.Add(TxtIMedicacion.Text)
    End Sub

    Private Sub BtnIDelItem_Click(sender As Object, e As EventArgs) Handles BtnIDelMed.Click
        CmbIMedicacion.Items.RemoveAt(CmbIMedicacion.SelectedIndex)
    End Sub

    Private Sub BtnAddEnfermedad_Click(sender As Object, e As EventArgs) Handles BtnAddEnfermedad.Click
        CmbIEnfermedad.Items.Add(TxtIEnfermedad.Text)
    End Sub

    Private Sub BtnDelEnfermedad_Click(sender As Object, e As EventArgs) Handles BtnDelEnfermedad.Click
        CmbIEnfermedad.Items.RemoveAt(CmbIEnfermedad.SelectedIndex)
    End Sub

    Private Function GetPaciente() As Paciente
        Dim paciente As Paciente

        ' Si el teléfono no fue ingresado, tendrá el valor -1
        Dim telefono As Integer
        If String.IsNullOrWhiteSpace(TxtITelefono.Text) Then
            telefono = -1
        Else
            telefono = CInt(TxtITelefono.Text)
        End If

        Select Case Env.UserType
            Case Env.UserTypes.Recepcionista
                paciente = New Paciente(
                    CInt(TxtICi.Text),
                    TxtINombre.Text,
                    TxtIApellidoP.Text,
                    TxtIApellidoM.Text,
                    New Direccion(TxtICalle.Text,
                                    CInt(TxtINumero.Text),
                                    TxtILocalidad.Text,
                                    CmbIDepartamento.SelectedIndex + 1),
                    telefono,
                    Format(DTPickerFNac.Value, "yyyy-MM-dd"),
                    Password.Generate(New Random),
                    TxtIEmail.Text
                    )

            Case Env.UserTypes.Administrador
                Dim medicacion As String = ""
                For i As Integer = 0 To CmbIMedicacion.Items.Count - 1
                    medicacion += CmbIMedicacion.Items.Item(i).ToString
                    If i < CmbIMedicacion.Items.Count - 1 Then
                        medicacion += ","
                    End If
                Next

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
                            CInt(TxtITelefono.Text),
                            Format(DTPickerFNac.Value, "yyyy-MM-dd"),
                            Password.Generate(New Random),
                            TxtIEmail.Text,
                            TxtINFam.Text,
                            TxtIAntFam.Text,
                            TxtIAntLab.Text,
                            medicacion,
                            TxtITratamientos.Text
                            )
        End Select
        Return paciente
    End Function
    Private Sub LoadDgv()
        Dim objPaciente As New Paciente()
        Try
            Dim dt As DataTable = objPaciente.GetPacientes()
            DgvPacientes.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnResetPassword_Click(sender As Object, e As EventArgs) Handles BtnResetPassword.Click
        Dim objRecepcionista As Recepcionista = Env.CurrentUser
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
        Try
            Dim paciente As Paciente = GetSelected()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class