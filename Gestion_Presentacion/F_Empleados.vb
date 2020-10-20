Imports System.Threading
Imports System.Globalization
Imports Dominio
Imports Logica

Public Class F_Empleados

    Public Sub New()
        Thread.CurrentThread.CurrentUICulture = Env.CurrentLangugage
        InitializeComponent()
        ConfigAccess()

    End Sub



    Private Enum Modos
        Ingresar
        Modificar
    End Enum

    Private Modo As Modos

    ''' <summary>
    ''' Configura los controles de acuerdo con el usuario que a la ventana, dado que ciertos usuarios no pueden realizar determinadas tareas(Permisos en la base de datos).
    ''' </summary>
    Public Sub ConfigAccess()

        If Env.CurrentUser.IsRecepcionista Or Env.CurrentUser.IsAdministrador Then
            BtnModificar.Enabled = False
            BtnEliminar.Enabled = False
            BtnResetPassword.Enabled = False
            BtnHacerAdmin.Enabled = False
            BtnIngresar.Enabled = False

        End If

    End Sub

    Private Sub ChangeMode(pMode As Modos)
        Modo = pMode

        If Modo = Modos.Modificar Then
            BtnIngresar.Text = Translator.TranslateKey("modificar")
            BtnHorarios.Text = Translator.TranslateKey("cancelar")

        Else
            BtnIngresar.Text = Translator.TranslateKey("ingreso_registro")
            BtnHorarios.Text = Translator.TranslateKey("horarios")
        End If
    End Sub

    Public Sub ClearFields()
        TxtICi.ResetText()
        TxtINombre.ResetText()
        TxtIApellidoP.ResetText()
        TxtIApellidoM.ResetText()
        RadioIM.Checked = True
        RadioIF.Checked = False
        RadioIOtro.Checked = False
        DTPickerFNac.Value = New Date(Today.Year, Today.Month, Today.Day)
        TxtICalle.ResetText()
        TxtINumero.ResetText()
        TxtIDetalle.ResetText()
        TxtILocalidad.ResetText()
        CmbIDepartamento.SelectedIndex = 0
        TxtITelefono.ResetText()
        CmbIRol.SelectedIndex = 0
        CmbIEspecialidades.SelectedIndex = 0
        CmbIngresadasEspecialidades.Items.Clear()
    End Sub

    Public Function GetSelected() As List(Of Empleado)
        Dim listaEmpleados As New List(Of Empleado)
        Dim rows = DgvEmpleados.SelectedRows
        Try
            For i As Integer = 0 To rows.Count - 1
                Dim cells = rows.Item(i).Cells

                Dim ci As Integer = CInt(cells.Item(0).Value)
                Dim tempNombre = cells.Item(1).Value.ToString.Split(",")
                Dim sexo As Persona.Sexos = [Enum].Parse(GetType(Persona.Sexos), cells.Item(2).Value.ToString)
                Dim tempFecha = cells.Item(3).Value.ToString.Substring(0, 10).Split(".")
                Dim telefono As Integer = CInt(cells.Item(4).Value)
                Dim tempEspecialidades = cells.Item(5).Value.ToString
                Dim tempDireccion = cells.Item(6).Value.ToString.Split(",")
                Dim isMedico As Boolean = CBool(cells.Item(7).Value)
                Dim isAdministrador As Boolean = CBool(cells.Item(8).Value)
                Dim isRecepcionista As Boolean = CBool(cells.Item(9).Value)
                Dim isRRHH As Boolean = CBool(cells.Item(10).Value)


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
                        listaEmpleados.Add(New Administrador(ci, nombre, apellidoP, apellidoM, sexo, direccion, telefono, fechaNacimiento, especialidades))
                    Else
                        listaEmpleados.Add(New Medico(ci, nombre, apellidoP, apellidoM, sexo, direccion, telefono, fechaNacimiento, especialidades))
                    End If

                ElseIf isRecepcionista Then
                    listaEmpleados.Add(New Recepcionista(ci, nombre, apellidoP, apellidoM, sexo, direccion, telefono, fechaNacimiento))

                ElseIf isRRHH Then
                    listaEmpleados.Add(New RRHH(ci, nombre, apellidoP, apellidoM, sexo, direccion, telefono, fechaNacimiento))

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

            If Modo = Modos.Ingresar Then
                RRHHBUS.InsertEmpleado(empleado)
                ClearFields()
                LoadDgv()

                Dim exitMessage = Translator.TranslateKey("empleado_ingresado_exito")

                If empleado.IsMedico Then
                    exitMessage.Replace("[TIPO_EMPLEADO]", Translator.TranslateKey("medico"))

                ElseIf empleado.IsRRHH Then
                    exitMessage.Replace("[TIPO_EMPLEADO]", Translator.TranslateKey("recursos_humanos"))

                ElseIf empleado.IsRecepcionista Then
                    exitMessage.Replace("[TIPO_EMPLEADO]", Translator.TranslateKey("recepcionista"))

                End If

                MsgBox(exitMessage, MsgBoxStyle.Information, "Empleado Ingresado")

            ElseIf Modo = Modos.Modificar Then
                RRHHBUS.ModifyEmpleado(empleado)
                ClearFields()
                LoadDgv()
                MsgBox(Translator.TranslateKey("empleado_modificado_exito"), MsgBoxStyle.Information, Translator.TranslateKey("informacion"))
            End If


        Catch ex As Exception
            MsgBox(Translator.TranslateKey(ex.Message), MsgBoxStyle.Critical, Translator.TranslateKey("error"))
        End Try
    End Sub

    Private Function GetEmpleado() As Empleado
        Dim EmpleadoVO As Empleado

        Dim ci = CInt(TxtICi.Text)
        Dim nombre = TxtINombre.Text
        Dim apellidoP = TxtIApellidoP.Text
        Dim apellidoM = TxtIApellidoM.Text
        Dim sexo As Persona.Sexos

        If RadioIM.Checked Then
            sexo = Persona.Sexos.M

        ElseIf RadioIF.Checked Then
            sexo = Persona.Sexos.F

        Else
            sexo = Persona.Sexos.Otro
        End If

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
            EmpleadoVO = New Medico(ci, nombre, apellidoP, apellidoM, sexo, direccion, telefono, fechaNacimiento, especialidades, password)

        Else

            If CmbIRol.SelectedItem = "Recursos_Humanos" Then
                EmpleadoVO = New RRHH(ci, nombre, apellidoP, apellidoM, sexo, direccion, telefono, fechaNacimiento, password)

            ElseIf CmbIRol.SelectedItem = "Recepcionista" Then
                EmpleadoVO = New Recepcionista(ci, nombre, apellidoP, apellidoM, sexo, direccion, telefono, fechaNacimiento, password)

            Else
                Throw New Exception("error_obtener_empleado")
            End If
        End If

        Return EmpleadoVO
    End Function

    Private Sub F_Pacientes_Load(sender As Object, e As EventArgs) Handles Me.Load
        Translator.TranslateForm(Me)
        DTPickerFNac.MaxDate = Date.Now
        ConfigComboBox()
        LoadDgv()
        ConfigDgvAppearance()
    End Sub

    Private Sub BtnHorarios_Click(sender As Object, e As EventArgs) Handles BtnHorarios.Click
        If Not Modo = Modos.Modificar Then
            F_Empleados_Horarios.Show()
            Close()

        Else
            ChangeMode(Modos.Ingresar)
            ClearFields()
        End If
    End Sub

    Private Sub LoadDgv()
        Dim MedicoBUS As New MedicoBUS()
        Try
            Dim dt As DataTable = MedicoBUS.GetEmpleados()
            DgvEmpleados.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub LoadFields(pEmpleado As Empleado)
        Try
            TxtICi.Text = pEmpleado.Ci
            TxtINombre.Text = pEmpleado.Nombre
            TxtIApellidoP.Text = pEmpleado.ApellidoP
            TxtIApellidoM.Text = pEmpleado.ApellidoM

            If pEmpleado.Sexo = Persona.Sexos.M Then
                RadioIM.Checked = True
                RadioIF.Checked = False
                RadioIOtro.Checked = False

            ElseIf pEmpleado.Sexo = Persona.Sexos.F Then
                RadioIM.Checked = False
                RadioIF.Checked = True
                RadioIOtro.Checked = False

            Else
                RadioIM.Checked = False
                RadioIF.Checked = False
                RadioIOtro.Checked = True

            End If

            DTPickerFNac.Value = pEmpleado.Fecha_Nacimiento
            TxtICalle.Text = pEmpleado.Direccion.Calle
            TxtINumero.Text = pEmpleado.Direccion.Nro
            TxtIDetalle.Text = pEmpleado.Direccion.Detalle
            TxtILocalidad.Text = pEmpleado.Direccion.Localidad
            CmbIDepartamento.SelectedItem = pEmpleado.Direccion.Departamento
            TxtITelefono.Text = pEmpleado.Telefono

            If pEmpleado.IsMedico Then
                CmbIRol.SelectedItem = Env.Roles.Medico.ToString
                LoadEspecialidades(pEmpleado)
                CmbIngresadasEspecialidades.SelectedItem = CmbIEspecialidades.Items.Item(1)

            ElseIf pEmpleado.IsRRHH Then
                CmbIRol.SelectedItem = Env.Roles.Recursos_Humanos.ToString

            ElseIf pEmpleado.IsRecepcionista Then
                CmbIRol.SelectedItem = Env.Roles.Recepcionista.ToString

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadEspecialidades(pMedico As Medico)
        Try
            For Each especialidad In pMedico.Especialidades
                CmbIngresadasEspecialidades.Items.Add(especialidad.Nombre)
            Next

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ConfigDgvAppearance()
        'Revisar
        DgvEmpleados.Columns.Item(0).Width = 80
        DgvEmpleados.Columns.Item(1).Width = 180
        DgvEmpleados.Columns.Item(2).Width = 100
        DgvEmpleados.Columns.Item(3).Width = 110
        DgvEmpleados.Columns.Item(4).Width = 200
        DgvEmpleados.Columns.Item(5).Width = 350
        'HideBooleansDgv()

    End Sub

    Public Sub HideBooleansDgv()
        Dim count = DgvEmpleados.Columns.Count
        DgvEmpleados.Columns.Item(count - 1).Visible = False
        DgvEmpleados.Columns.Item(count - 2).Visible = False
        DgvEmpleados.Columns.Item(count - 3).Visible = False
        DgvEmpleados.Columns.Item(count - 4).Visible = False

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
        Dim RRHHBUS As New RRHHBUS
        ChangeMode(Modos.Modificar)

        Try
            Dim seleccionados = GetSelected()
            If seleccionados.Count > 1 Then
                Throw New Exception("error_modificar_varios")

            Else
                LoadFields(seleccionados.First)

            End If

        Catch ex As Exception
            ChangeMode(Modos.Ingresar)
            Dim error_message = Translator.TranslateKey(ex.Message).Replace("[ENTIDAD]", Translator.TranslateKey("empleado"))
            MsgBox(error_message, MsgBoxStyle.Critical, Translator.TranslateKey("error"))

        End Try
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim RRHHBUS As New RRHHBUS

        Try
            Dim seleccionados = GetSelected()
            Dim output As String = RRHHBUS.DeleteEmpleados(seleccionados)
            output.Replace("empleados_eliminados_exito", Translator.TranslateKey("empleados_eliminados_exito"))
            output.Replace("error_eliminar_persona", Translator.TranslateKey("error_eliminar_empleado"))

            LoadDgv()
            MsgBox(output, MsgBoxStyle.Information, Translator.TranslateKey("titulo_eliminar_empleado"))

        Catch ex As Exception
            MsgBox(Translator.TranslateKey(ex.Message), MsgBoxStyle.Critical, Translator.TranslateKey("error"))
        End Try

    End Sub

    Private Sub BtnHacerAdmin_Click(sender As Object, e As EventArgs) Handles BtnHacerAdmin.Click
        Dim RRHHBUS As New RRHHBUS
        Dim count As Integer = DgvEmpleados.SelectedRows.Count

        Try
            If count = 1 Then
                Dim empleado = GetSelected().First
                If empleado.IsMedico Then
                    RRHHBUS.MakeAdministrator(empleado.Ci)
                    LoadDgv()

                    Dim output_message = Translator.TranslateKey("mensaje_empleado_ascendido").Replace("[NOMBRE_EMPLEADO]", empleado.Nombre)
                    MsgBox(output_message, MsgBoxStyle.Information, Translator.TranslateKey("información"))
                Else
                    Throw New Exception("error_ascender_no_medico")
                End If

            Else
                Throw New Exception("error_ascender_varios")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Translator.TranslateKey("error"))
        End Try
    End Sub
End Class