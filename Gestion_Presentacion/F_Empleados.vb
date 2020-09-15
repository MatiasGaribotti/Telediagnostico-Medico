Imports System.Threading
Imports System.Globalization
Imports Dominio
Imports Logica

Public Class F_Empleados

    Public Sub New()
        Thread.CurrentThread.CurrentUICulture = Env.CurrentLangugage
        InitializeComponent()
        ConfigMode()
    End Sub

    ''' <summary>
    ''' Configura los controles de acuerdo con el usuario que a la ventana, dado que ciertos usuarios no pueden realizar determinadas tareas(Permisos en la base de datos).
    ''' </summary>
    Public Sub ConfigMode()

        If Env.CurrentUser.IsRecepcionista Or Env.CurrentUser.IsAdministrador Then
            BtnModificar.Enabled = False
            BtnEliminar.Enabled = False
            BtnResetPassword.Enabled = False
            BtnHacerAdmin.Enabled = False
            BtnIngresar.Enabled = False

        End If

    End Sub

    Public Sub ClearFields()
        TxtICi.ResetText()
        TxtINombre.ResetText()
        TxtIApellidoP.ResetText()
        TxtIApellidoM.ResetText()
        DTPickerFNac.Value = Date.Now
        TxtICalle.ResetText()
        TxtINumero.ResetText()
        TxtIDetalle.ResetText()
        TxtILocalidad.ResetText()
        CmbIDepartamento.SelectedIndex = 1
        TxtITelefono.ResetText()
        CmbIRol.SelectedIndex = 1
        CmbIngresadasEspecialidades.Items.Clear()
    End Sub

    Public Function GetSelected() As List(Of Empleado)
        Dim listaEmpleados As New List(Of Empleado)
        Dim rows = DgvMedicos.SelectedRows
        Try
            For i As Integer = 0 To rows.Count - 1
                Dim cells = rows.Item(i).Cells

                Dim ci As Integer = CInt(cells.Item(0).Value)
                Dim tempNombre = cells.Item(1).Value.ToString.Split(",")
                Dim tempFecha = cells.Item(2).Value.ToString.Substring(0, 10).Split(".")
                Dim telefono As Integer = CInt(cells.Item(3).Value)
                Dim tempEspecialidades = cells.Item(4).Value.ToString
                Dim tempDireccion = cells.Item(5).Value.ToString.Split(",")
                Dim isMedico As Boolean = CBool(cells.Item(6).Value)
                Dim isAdministrador As Boolean = CBool(cells.Item(7).Value)
                Dim isRecepcionista As Boolean = CBool(cells.Item(8).Value)
                Dim isRRHH As Boolean = CBool(cells.Item(9).Value)


                Dim nombre As String = tempNombre.ElementAt(0)
                Dim apellidoP As String = tempNombre.ElementAt(1)
                Dim apellidoM As String = tempNombre.ElementAt(2)


                ' Obtengo la fecha de nacimiento
                Dim year, month, day As Integer
                year = tempFecha.ElementAt(2)
                month = tempFecha.ElementAt(1)
                day = tempFecha.ElementAt(0)

                Dim fechaNacimiento As Date = New Date(year, month, day)

                Dim calle As String = tempDireccion.ElementAt(0).ToString
                Dim numero As Integer = CInt(tempDireccion.ElementAt(1).ToString)
                Dim localidad As String = tempDireccion.ElementAt(2).ToString
                Dim departamento As Direccion.Departamentos = [Enum].Parse(GetType(Direccion.Departamentos), tempDireccion.ElementAt(3).ToString)
                Dim detalle As String = tempDireccion.ElementAt(4).ToString

                Dim direccion As New Direccion(calle, numero, localidad, departamento, detalle)

                If isMedico Then
                    Dim MedicoBUS As New MedicoBUS
                    Dim especialidades As List(Of Especialidad) = MedicoBUS.ParseEspecialidades(tempEspecialidades, ";")



                    If isAdministrador Then
                        listaEmpleados.Add(New Administrador(ci, nombre, apellidoP, apellidoM, direccion, telefono, fechaNacimiento, especialidades))
                    Else
                        listaEmpleados.Add(New Medico(ci, nombre, apellidoP, apellidoM, direccion, telefono, fechaNacimiento, especialidades))
                    End If

                ElseIf isRecepcionista Then
                    listaEmpleados.Add(New Recepcionista(ci, nombre, apellidoP, apellidoM, direccion, telefono, fechaNacimiento))

                ElseIf isRRHH Then
                    listaEmpleados.Add(New RRHH(ci, nombre, apellidoP, apellidoM, direccion, telefono, fechaNacimiento))

                End If

            Next

        Catch ex As Exception
            Throw ex
        End Try

        Return listaEmpleados
    End Function


    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        Dim EmpleadoBUS As New EmpleadoBUS
        Dim empleado As Empleado

        Try
            EmpleadoBUS.ValidateFields(TxtICi.Text,
                                     TxtINombre.Text,
                                     TxtIApellidoP.Text,
                                     TxtIApellidoM.Text,
                                     TxtICalle.Text,
                                     TxtINumero.Text,
                                     TxtILocalidad.Text,
                                     TxtITelefono.Text,
                                     CmbIRol.SelectedItem.ToString
                                     )
            empleado = GetEmpleado()
            Dim RRHHBUS As New RRHHBUS
            RRHHBUS.InsertEmployee(empleado)
            LoadDgv()

            Dim exitMessage = " ingresado con éxito."
            If empleado.IsMedico Then
                exitMessage = "Medico" & exitMessage

            ElseIf empleado.IsRRHH Then
                exitMessage = "Personal de Recursos humanos" & exitMessage

            ElseIf empleado.IsRecepcionista Then
                exitMessage = "Recepcionista" & exitMessage

            End If

            MsgBox(exitMessage, MsgBoxStyle.Information, "Empleado Ingresado")
            ClearFields()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Function GetEmpleado() As Empleado
        Dim EmpleadoVO As Empleado

        Dim ci = CInt(TxtICi.Text)
        Dim nombre = TxtINombre.Text
        Dim apellidoP = TxtIApellidoP.Text
        Dim apellidoM = TxtIApellidoM.Text
        Dim fechaNacimiento As Date = Format(DTPickerFNac.Value, "yyyy-MM-dd")
        Dim calle = TxtICalle.Text
        Dim numero = CInt(TxtINumero.Text)
        Dim localidad = TxtILocalidad.Text
        Dim departamento = [Enum].Parse(GetType(Direccion.Departamentos), CmbIDepartamento.SelectedItem)
        Dim direccion As New Direccion(calle, numero, localidad, departamento)
        Dim telefono = CInt(TxtITelefono.Text)
        Dim password = Logica.Password.Generate(New Random)


        If CmbIRol.SelectedItem = "Medico" Then
            Dim especialidades As New List(Of Especialidad)

            For Each item In CmbIngresadasEspecialidades.Items
                especialidades.Add(New Especialidad(item.ToString))
            Next
            EmpleadoVO = New Medico(ci, nombre, apellidoP, apellidoM, direccion, telefono, fechaNacimiento, especialidades, password)

        Else

            If CmbIRol.SelectedItem = "Recursos_Humanos" Then
                EmpleadoVO = New RRHH(ci, nombre, apellidoP, apellidoM, direccion, telefono, fechaNacimiento, password)

            ElseIf CmbIRol.SelectedItem = "Recepcionista" Then
                EmpleadoVO = New Recepcionista(ci, nombre, apellidoP, apellidoM, direccion, telefono, fechaNacimiento, password)

            Else
                Throw New Exception("Error al obtener el empleado.")
            End If
        End If

        Return EmpleadoVO
    End Function

    Private Sub F_Pacientes_Load(sender As Object, e As EventArgs) Handles Me.Load
        DTPickerFNac.MaxDate = Date.Now
        ConfigComboBox()
        LoadDgv()
        ConfigDgvAppearance()
    End Sub

    Private Sub BtnHorarios_Click(sender As Object, e As EventArgs) Handles BtnHorarios.Click
        F_Empleados_Horarios.Show()
        Close()
    End Sub

    Private Sub LoadDgv()
        Dim MedicoBUS As New MedicoBUS()
        Try
            Dim dt As DataTable = MedicoBUS.GetEmpleados()
            DgvMedicos.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ConfigDgvAppearance()
        'Revisar
        DgvMedicos.Columns.Item(0).Width = 80
        DgvMedicos.Columns.Item(1).Width = 180
        DgvMedicos.Columns.Item(2).Width = 100
        DgvMedicos.Columns.Item(3).Width = 110
        DgvMedicos.Columns.Item(4).Width = 200
        DgvMedicos.Columns.Item(5).Width = 350
        'HideBooleansDgv()

    End Sub

    Public Sub HideBooleansDgv()
        Dim count = DgvMedicos.Columns.Count
        DgvMedicos.Columns.Item(count - 1).Visible = False
        DgvMedicos.Columns.Item(count - 2).Visible = False
        DgvMedicos.Columns.Item(count - 3).Visible = False
        DgvMedicos.Columns.Item(count - 4).Visible = False

    End Sub

    Public Sub ConfigComboBox()
        Dim MedicoBUS As New MedicoBUS
        Try
            CmbIDepartamento.DataSource = [Enum].GetValues(GetType(Direccion.Departamentos))

            Dim especialidades As List(Of Especialidad) = MedicoBUS.GetEspecialidades()

            For Each i As Especialidad In especialidades
                CmbBEspecialidades.Items.Add(i.Nombre)
                CmbIEspecialidades.Items.Add(i.Nombre)
            Next

            ' Roles
            Dim EmpleadoBUS As New EmpleadoBUS

            ' Es necesario que llame a GetRoles dos veces
            ' para que no se me linkeen los datasources y
            ' cuando cambie el item seleccionado en uno
            ' también cambie en el otro.

            Dim rolesIngreso As List(Of String) = EmpleadoBUS.GetRoles()
            Dim rolesBuscar As List(Of String) = EmpleadoBUS.GetRoles()
            rolesBuscar.Insert(0, "Todos")

            CmbIRol.DataSource = rolesIngreso
            CmbBRol.DataSource = rolesBuscar
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub BtnAddEspecialidad_Click(sender As Object, e As EventArgs) Handles BtnAddEspecialidad.Click
        CmbIngresadasEspecialidades.Items.Add(CmbIEspecialidades.SelectedItem)
    End Sub

    Private Sub BtnDelEspecialidad_Click(sender As Object, e As EventArgs) Handles BtnDelEspecialidad.Click
        CmbIngresadasEspecialidades.Items.RemoveAt(CmbIngresadasEspecialidades.SelectedIndex)
    End Sub

    Private Sub CmbRol_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbIRol.SelectedIndexChanged
        If CmbIRol.SelectedItem.ToString = "Medico" Then
            CmbIEspecialidades.Enabled = True
            CmbIngresadasEspecialidades.Enabled = True
            BtnAddEspecialidad.Enabled = True
            BtnDelEspecialidad.Enabled = True
        Else
            CmbIEspecialidades.Enabled = False
            CmbIngresadasEspecialidades.Enabled = False
            BtnAddEspecialidad.Enabled = False
            BtnDelEspecialidad.Enabled = False
        End If
    End Sub
    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        F_ABM.Show()
        Me.Close()
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click

    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim RRHHBUS As New RRHHBUS

        Try
            Dim seleccionados = GetSelected()
            Dim output As String = RRHHBUS.DeleteEmpleados(seleccionados)
            LoadDgv()
            MsgBox(output, MsgBoxStyle.Information, "Eliminación de Empleados")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub
End Class