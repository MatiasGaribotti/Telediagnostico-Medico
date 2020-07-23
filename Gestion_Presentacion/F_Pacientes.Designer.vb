<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F_Pacientes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_Pacientes))
        Me.pnl_contenedor = New System.Windows.Forms.Panel()
        Me.pnl_dgv_pacientes = New System.Windows.Forms.DataGridView()
        Me.pnl_filtrar = New System.Windows.Forms.Panel()
        Me.btn_filtrar = New System.Windows.Forms.Button()
        Me.txt_emailFiltrar = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_localidadFiltrar = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_departamentoFiltrar = New System.Windows.Forms.TextBox()
        Me.lbl_departamentpFiltrar = New System.Windows.Forms.Label()
        Me.txt_edadFiltrar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmb_detalleFiltrar = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_numeroFiltrar = New System.Windows.Forms.TextBox()
        Me.lbl_edad = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_telefonoFiltrar = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_apellidoMFiltrar = New System.Windows.Forms.TextBox()
        Me.txt_nombreFiltrar = New System.Windows.Forms.TextBox()
        Me.txt_apellidoPFiltrar = New System.Windows.Forms.TextBox()
        Me.txt_calleFiltrar = New System.Windows.Forms.TextBox()
        Me.pnl_ingresar = New System.Windows.Forms.Panel()
        Me.Guna2DateTimePicker1 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.btn_ingresar = New System.Windows.Forms.Button()
        Me.txt_localidad = New System.Windows.Forms.TextBox()
        Me.lbl_localidad = New System.Windows.Forms.Label()
        Me.lbl_detalle = New System.Windows.Forms.Label()
        Me.cmb_detalle = New System.Windows.Forms.ComboBox()
        Me.txt_numero = New System.Windows.Forms.TextBox()
        Me.lbl_numero = New System.Windows.Forms.Label()
        Me.txt_telefono = New System.Windows.Forms.TextBox()
        Me.txt_apellidoM = New System.Windows.Forms.TextBox()
        Me.txt_apellidoP = New System.Windows.Forms.TextBox()
        Me.lbl_medicacion = New System.Windows.Forms.Label()
        Me.lbl_enfermedad = New System.Windows.Forms.Label()
        Me.lbl_antecedentesLab = New System.Windows.Forms.Label()
        Me.lbl_tratamientos = New System.Windows.Forms.Label()
        Me.lbl_antecedentesFlia = New System.Windows.Forms.Label()
        Me.lbl_nucleoFlia = New System.Windows.Forms.Label()
        Me.txt_enfermedad = New System.Windows.Forms.TextBox()
        Me.cmb_medicacion = New System.Windows.Forms.ComboBox()
        Me.txt_antecedentesLab = New System.Windows.Forms.TextBox()
        Me.txt_tratamientos = New System.Windows.Forms.TextBox()
        Me.txt_antecedentesFlia = New System.Windows.Forms.TextBox()
        Me.txt_nucleoFlia = New System.Windows.Forms.TextBox()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.txt_departamento = New System.Windows.Forms.TextBox()
        Me.txt_calle = New System.Windows.Forms.TextBox()
        Me.dtp_fechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.lbl_email = New System.Windows.Forms.Label()
        Me.lbl_departamento = New System.Windows.Forms.Label()
        Me.lbl_calle = New System.Windows.Forms.Label()
        Me.lbl_telefono = New System.Windows.Forms.Label()
        Me.lbl_fechaNacimiento = New System.Windows.Forms.Label()
        Me.lbl_apellidos = New System.Windows.Forms.Label()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.btn_volver = New System.Windows.Forms.Button()
        Me.pnl_contenedor.SuspendLayout()
        CType(Me.pnl_dgv_pacientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_filtrar.SuspendLayout()
        Me.pnl_ingresar.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl_contenedor
        '
        resources.ApplyResources(Me.pnl_contenedor, "pnl_contenedor")
        Me.pnl_contenedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.pnl_contenedor.Controls.Add(Me.pnl_dgv_pacientes)
        Me.pnl_contenedor.Controls.Add(Me.pnl_filtrar)
        Me.pnl_contenedor.Controls.Add(Me.pnl_ingresar)
        Me.pnl_contenedor.Name = "pnl_contenedor"
        '
        'pnl_dgv_pacientes
        '
        resources.ApplyResources(Me.pnl_dgv_pacientes, "pnl_dgv_pacientes")
        Me.pnl_dgv_pacientes.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.pnl_dgv_pacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.pnl_dgv_pacientes.Name = "pnl_dgv_pacientes"
        '
        'pnl_filtrar
        '
        resources.ApplyResources(Me.pnl_filtrar, "pnl_filtrar")
        Me.pnl_filtrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.pnl_filtrar.Controls.Add(Me.btn_filtrar)
        Me.pnl_filtrar.Controls.Add(Me.txt_emailFiltrar)
        Me.pnl_filtrar.Controls.Add(Me.Label9)
        Me.pnl_filtrar.Controls.Add(Me.txt_localidadFiltrar)
        Me.pnl_filtrar.Controls.Add(Me.Label5)
        Me.pnl_filtrar.Controls.Add(Me.txt_departamentoFiltrar)
        Me.pnl_filtrar.Controls.Add(Me.lbl_departamentpFiltrar)
        Me.pnl_filtrar.Controls.Add(Me.txt_edadFiltrar)
        Me.pnl_filtrar.Controls.Add(Me.Label1)
        Me.pnl_filtrar.Controls.Add(Me.Label6)
        Me.pnl_filtrar.Controls.Add(Me.cmb_detalleFiltrar)
        Me.pnl_filtrar.Controls.Add(Me.Label7)
        Me.pnl_filtrar.Controls.Add(Me.txt_numeroFiltrar)
        Me.pnl_filtrar.Controls.Add(Me.lbl_edad)
        Me.pnl_filtrar.Controls.Add(Me.Label2)
        Me.pnl_filtrar.Controls.Add(Me.Label4)
        Me.pnl_filtrar.Controls.Add(Me.txt_telefonoFiltrar)
        Me.pnl_filtrar.Controls.Add(Me.Label3)
        Me.pnl_filtrar.Controls.Add(Me.txt_apellidoMFiltrar)
        Me.pnl_filtrar.Controls.Add(Me.txt_nombreFiltrar)
        Me.pnl_filtrar.Controls.Add(Me.txt_apellidoPFiltrar)
        Me.pnl_filtrar.Controls.Add(Me.txt_calleFiltrar)
        Me.pnl_filtrar.Name = "pnl_filtrar"
        '
        'btn_filtrar
        '
        resources.ApplyResources(Me.btn_filtrar, "btn_filtrar")
        Me.btn_filtrar.Image = Global.Presentacion.My.Resources.Resources.btn_filtrar
        Me.btn_filtrar.Name = "btn_filtrar"
        Me.btn_filtrar.UseVisualStyleBackColor = True
        '
        'txt_emailFiltrar
        '
        resources.ApplyResources(Me.txt_emailFiltrar, "txt_emailFiltrar")
        Me.txt_emailFiltrar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_emailFiltrar.Name = "txt_emailFiltrar"
        '
        'Label9
        '
        resources.ApplyResources(Me.Label9, "Label9")
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Name = "Label9"
        '
        'txt_localidadFiltrar
        '
        resources.ApplyResources(Me.txt_localidadFiltrar, "txt_localidadFiltrar")
        Me.txt_localidadFiltrar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_localidadFiltrar.Name = "txt_localidadFiltrar"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Name = "Label5"
        '
        'txt_departamentoFiltrar
        '
        resources.ApplyResources(Me.txt_departamentoFiltrar, "txt_departamentoFiltrar")
        Me.txt_departamentoFiltrar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_departamentoFiltrar.Name = "txt_departamentoFiltrar"
        '
        'lbl_departamentpFiltrar
        '
        resources.ApplyResources(Me.lbl_departamentpFiltrar, "lbl_departamentpFiltrar")
        Me.lbl_departamentpFiltrar.BackColor = System.Drawing.Color.Transparent
        Me.lbl_departamentpFiltrar.Name = "lbl_departamentpFiltrar"
        '
        'txt_edadFiltrar
        '
        resources.ApplyResources(Me.txt_edadFiltrar, "txt_edadFiltrar")
        Me.txt_edadFiltrar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_edadFiltrar.Name = "txt_edadFiltrar"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Name = "Label1"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Name = "Label6"
        '
        'cmb_detalleFiltrar
        '
        resources.ApplyResources(Me.cmb_detalleFiltrar, "cmb_detalleFiltrar")
        Me.cmb_detalleFiltrar.FormattingEnabled = True
        Me.cmb_detalleFiltrar.Name = "cmb_detalleFiltrar"
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Name = "Label7"
        '
        'txt_numeroFiltrar
        '
        resources.ApplyResources(Me.txt_numeroFiltrar, "txt_numeroFiltrar")
        Me.txt_numeroFiltrar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_numeroFiltrar.Name = "txt_numeroFiltrar"
        '
        'lbl_edad
        '
        resources.ApplyResources(Me.lbl_edad, "lbl_edad")
        Me.lbl_edad.BackColor = System.Drawing.Color.Transparent
        Me.lbl_edad.Name = "lbl_edad"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Name = "Label2"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Name = "Label4"
        '
        'txt_telefonoFiltrar
        '
        resources.ApplyResources(Me.txt_telefonoFiltrar, "txt_telefonoFiltrar")
        Me.txt_telefonoFiltrar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_telefonoFiltrar.Name = "txt_telefonoFiltrar"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Name = "Label3"
        '
        'txt_apellidoMFiltrar
        '
        resources.ApplyResources(Me.txt_apellidoMFiltrar, "txt_apellidoMFiltrar")
        Me.txt_apellidoMFiltrar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_apellidoMFiltrar.Name = "txt_apellidoMFiltrar"
        '
        'txt_nombreFiltrar
        '
        resources.ApplyResources(Me.txt_nombreFiltrar, "txt_nombreFiltrar")
        Me.txt_nombreFiltrar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_nombreFiltrar.Name = "txt_nombreFiltrar"
        '
        'txt_apellidoPFiltrar
        '
        resources.ApplyResources(Me.txt_apellidoPFiltrar, "txt_apellidoPFiltrar")
        Me.txt_apellidoPFiltrar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_apellidoPFiltrar.Name = "txt_apellidoPFiltrar"
        '
        'txt_calleFiltrar
        '
        resources.ApplyResources(Me.txt_calleFiltrar, "txt_calleFiltrar")
        Me.txt_calleFiltrar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_calleFiltrar.Name = "txt_calleFiltrar"
        '
        'pnl_ingresar
        '
        resources.ApplyResources(Me.pnl_ingresar, "pnl_ingresar")
        Me.pnl_ingresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.pnl_ingresar.Controls.Add(Me.Guna2DateTimePicker1)
        Me.pnl_ingresar.Controls.Add(Me.btn_ingresar)
        Me.pnl_ingresar.Controls.Add(Me.txt_localidad)
        Me.pnl_ingresar.Controls.Add(Me.lbl_localidad)
        Me.pnl_ingresar.Controls.Add(Me.lbl_detalle)
        Me.pnl_ingresar.Controls.Add(Me.cmb_detalle)
        Me.pnl_ingresar.Controls.Add(Me.txt_numero)
        Me.pnl_ingresar.Controls.Add(Me.lbl_numero)
        Me.pnl_ingresar.Controls.Add(Me.txt_telefono)
        Me.pnl_ingresar.Controls.Add(Me.txt_apellidoM)
        Me.pnl_ingresar.Controls.Add(Me.txt_apellidoP)
        Me.pnl_ingresar.Controls.Add(Me.lbl_medicacion)
        Me.pnl_ingresar.Controls.Add(Me.lbl_enfermedad)
        Me.pnl_ingresar.Controls.Add(Me.lbl_antecedentesLab)
        Me.pnl_ingresar.Controls.Add(Me.lbl_tratamientos)
        Me.pnl_ingresar.Controls.Add(Me.lbl_antecedentesFlia)
        Me.pnl_ingresar.Controls.Add(Me.lbl_nucleoFlia)
        Me.pnl_ingresar.Controls.Add(Me.txt_enfermedad)
        Me.pnl_ingresar.Controls.Add(Me.cmb_medicacion)
        Me.pnl_ingresar.Controls.Add(Me.txt_antecedentesLab)
        Me.pnl_ingresar.Controls.Add(Me.txt_tratamientos)
        Me.pnl_ingresar.Controls.Add(Me.txt_antecedentesFlia)
        Me.pnl_ingresar.Controls.Add(Me.txt_nucleoFlia)
        Me.pnl_ingresar.Controls.Add(Me.txt_email)
        Me.pnl_ingresar.Controls.Add(Me.txt_departamento)
        Me.pnl_ingresar.Controls.Add(Me.txt_calle)
        Me.pnl_ingresar.Controls.Add(Me.dtp_fechaNacimiento)
        Me.pnl_ingresar.Controls.Add(Me.txt_nombre)
        Me.pnl_ingresar.Controls.Add(Me.lbl_email)
        Me.pnl_ingresar.Controls.Add(Me.lbl_departamento)
        Me.pnl_ingresar.Controls.Add(Me.lbl_calle)
        Me.pnl_ingresar.Controls.Add(Me.lbl_telefono)
        Me.pnl_ingresar.Controls.Add(Me.lbl_fechaNacimiento)
        Me.pnl_ingresar.Controls.Add(Me.lbl_apellidos)
        Me.pnl_ingresar.Controls.Add(Me.lbl_nombre)
        Me.pnl_ingresar.Controls.Add(Me.btn_volver)
        Me.pnl_ingresar.Name = "pnl_ingresar"
        '
        'Guna2DateTimePicker1
        '
        resources.ApplyResources(Me.Guna2DateTimePicker1, "Guna2DateTimePicker1")
        Me.Guna2DateTimePicker1.CheckedState.Parent = Me.Guna2DateTimePicker1
        Me.Guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.Guna2DateTimePicker1.HoverState.Parent = Me.Guna2DateTimePicker1
        Me.Guna2DateTimePicker1.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.Guna2DateTimePicker1.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.Guna2DateTimePicker1.Name = "Guna2DateTimePicker1"
        Me.Guna2DateTimePicker1.ShadowDecoration.Parent = Me.Guna2DateTimePicker1
        Me.Guna2DateTimePicker1.Value = New Date(2020, 7, 20, 18, 36, 52, 28)
        '
        'btn_ingresar
        '
        resources.ApplyResources(Me.btn_ingresar, "btn_ingresar")
        Me.btn_ingresar.BackColor = System.Drawing.Color.Transparent
        Me.btn_ingresar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_ingresar.FlatAppearance.BorderSize = 0
        Me.btn_ingresar.Image = Global.Presentacion.My.Resources.Resources.btn_ingresar_87x32
        Me.btn_ingresar.Name = "btn_ingresar"
        Me.btn_ingresar.UseVisualStyleBackColor = False
        '
        'txt_localidad
        '
        resources.ApplyResources(Me.txt_localidad, "txt_localidad")
        Me.txt_localidad.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_localidad.Name = "txt_localidad"
        '
        'lbl_localidad
        '
        resources.ApplyResources(Me.lbl_localidad, "lbl_localidad")
        Me.lbl_localidad.BackColor = System.Drawing.Color.Transparent
        Me.lbl_localidad.Name = "lbl_localidad"
        '
        'lbl_detalle
        '
        resources.ApplyResources(Me.lbl_detalle, "lbl_detalle")
        Me.lbl_detalle.BackColor = System.Drawing.Color.Transparent
        Me.lbl_detalle.Name = "lbl_detalle"
        '
        'cmb_detalle
        '
        resources.ApplyResources(Me.cmb_detalle, "cmb_detalle")
        Me.cmb_detalle.FormattingEnabled = True
        Me.cmb_detalle.Name = "cmb_detalle"
        '
        'txt_numero
        '
        resources.ApplyResources(Me.txt_numero, "txt_numero")
        Me.txt_numero.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_numero.Name = "txt_numero"
        '
        'lbl_numero
        '
        resources.ApplyResources(Me.lbl_numero, "lbl_numero")
        Me.lbl_numero.BackColor = System.Drawing.Color.Transparent
        Me.lbl_numero.Name = "lbl_numero"
        '
        'txt_telefono
        '
        resources.ApplyResources(Me.txt_telefono, "txt_telefono")
        Me.txt_telefono.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_telefono.Name = "txt_telefono"
        '
        'txt_apellidoM
        '
        resources.ApplyResources(Me.txt_apellidoM, "txt_apellidoM")
        Me.txt_apellidoM.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_apellidoM.Name = "txt_apellidoM"
        '
        'txt_apellidoP
        '
        resources.ApplyResources(Me.txt_apellidoP, "txt_apellidoP")
        Me.txt_apellidoP.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_apellidoP.Name = "txt_apellidoP"
        '
        'lbl_medicacion
        '
        resources.ApplyResources(Me.lbl_medicacion, "lbl_medicacion")
        Me.lbl_medicacion.BackColor = System.Drawing.Color.Transparent
        Me.lbl_medicacion.Name = "lbl_medicacion"
        '
        'lbl_enfermedad
        '
        resources.ApplyResources(Me.lbl_enfermedad, "lbl_enfermedad")
        Me.lbl_enfermedad.BackColor = System.Drawing.Color.Transparent
        Me.lbl_enfermedad.Name = "lbl_enfermedad"
        '
        'lbl_antecedentesLab
        '
        resources.ApplyResources(Me.lbl_antecedentesLab, "lbl_antecedentesLab")
        Me.lbl_antecedentesLab.BackColor = System.Drawing.Color.Transparent
        Me.lbl_antecedentesLab.Name = "lbl_antecedentesLab"
        '
        'lbl_tratamientos
        '
        resources.ApplyResources(Me.lbl_tratamientos, "lbl_tratamientos")
        Me.lbl_tratamientos.BackColor = System.Drawing.Color.Transparent
        Me.lbl_tratamientos.Name = "lbl_tratamientos"
        '
        'lbl_antecedentesFlia
        '
        resources.ApplyResources(Me.lbl_antecedentesFlia, "lbl_antecedentesFlia")
        Me.lbl_antecedentesFlia.BackColor = System.Drawing.Color.Transparent
        Me.lbl_antecedentesFlia.Name = "lbl_antecedentesFlia"
        '
        'lbl_nucleoFlia
        '
        resources.ApplyResources(Me.lbl_nucleoFlia, "lbl_nucleoFlia")
        Me.lbl_nucleoFlia.BackColor = System.Drawing.Color.Transparent
        Me.lbl_nucleoFlia.Name = "lbl_nucleoFlia"
        '
        'txt_enfermedad
        '
        resources.ApplyResources(Me.txt_enfermedad, "txt_enfermedad")
        Me.txt_enfermedad.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_enfermedad.Name = "txt_enfermedad"
        '
        'cmb_medicacion
        '
        resources.ApplyResources(Me.cmb_medicacion, "cmb_medicacion")
        Me.cmb_medicacion.FormattingEnabled = True
        Me.cmb_medicacion.Name = "cmb_medicacion"
        '
        'txt_antecedentesLab
        '
        resources.ApplyResources(Me.txt_antecedentesLab, "txt_antecedentesLab")
        Me.txt_antecedentesLab.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_antecedentesLab.Name = "txt_antecedentesLab"
        '
        'txt_tratamientos
        '
        resources.ApplyResources(Me.txt_tratamientos, "txt_tratamientos")
        Me.txt_tratamientos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_tratamientos.Name = "txt_tratamientos"
        '
        'txt_antecedentesFlia
        '
        resources.ApplyResources(Me.txt_antecedentesFlia, "txt_antecedentesFlia")
        Me.txt_antecedentesFlia.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_antecedentesFlia.Name = "txt_antecedentesFlia"
        '
        'txt_nucleoFlia
        '
        resources.ApplyResources(Me.txt_nucleoFlia, "txt_nucleoFlia")
        Me.txt_nucleoFlia.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_nucleoFlia.Name = "txt_nucleoFlia"
        '
        'txt_email
        '
        resources.ApplyResources(Me.txt_email, "txt_email")
        Me.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_email.Name = "txt_email"
        '
        'txt_departamento
        '
        resources.ApplyResources(Me.txt_departamento, "txt_departamento")
        Me.txt_departamento.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_departamento.Name = "txt_departamento"
        '
        'txt_calle
        '
        resources.ApplyResources(Me.txt_calle, "txt_calle")
        Me.txt_calle.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_calle.Name = "txt_calle"
        '
        'dtp_fechaNacimiento
        '
        resources.ApplyResources(Me.dtp_fechaNacimiento, "dtp_fechaNacimiento")
        Me.dtp_fechaNacimiento.MaxDate = New Date(2020, 6, 9, 16, 24, 40, 0)
        Me.dtp_fechaNacimiento.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.dtp_fechaNacimiento.Name = "dtp_fechaNacimiento"
        Me.dtp_fechaNacimiento.Value = New Date(2020, 6, 9, 0, 0, 0, 0)
        '
        'txt_nombre
        '
        resources.ApplyResources(Me.txt_nombre, "txt_nombre")
        Me.txt_nombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_nombre.Name = "txt_nombre"
        '
        'lbl_email
        '
        resources.ApplyResources(Me.lbl_email, "lbl_email")
        Me.lbl_email.BackColor = System.Drawing.Color.Transparent
        Me.lbl_email.Name = "lbl_email"
        '
        'lbl_departamento
        '
        resources.ApplyResources(Me.lbl_departamento, "lbl_departamento")
        Me.lbl_departamento.BackColor = System.Drawing.Color.Transparent
        Me.lbl_departamento.Name = "lbl_departamento"
        '
        'lbl_calle
        '
        resources.ApplyResources(Me.lbl_calle, "lbl_calle")
        Me.lbl_calle.BackColor = System.Drawing.Color.Transparent
        Me.lbl_calle.Name = "lbl_calle"
        '
        'lbl_telefono
        '
        resources.ApplyResources(Me.lbl_telefono, "lbl_telefono")
        Me.lbl_telefono.BackColor = System.Drawing.Color.Transparent
        Me.lbl_telefono.Name = "lbl_telefono"
        '
        'lbl_fechaNacimiento
        '
        resources.ApplyResources(Me.lbl_fechaNacimiento, "lbl_fechaNacimiento")
        Me.lbl_fechaNacimiento.BackColor = System.Drawing.Color.Transparent
        Me.lbl_fechaNacimiento.Name = "lbl_fechaNacimiento"
        '
        'lbl_apellidos
        '
        resources.ApplyResources(Me.lbl_apellidos, "lbl_apellidos")
        Me.lbl_apellidos.BackColor = System.Drawing.Color.Transparent
        Me.lbl_apellidos.Name = "lbl_apellidos"
        '
        'lbl_nombre
        '
        resources.ApplyResources(Me.lbl_nombre, "lbl_nombre")
        Me.lbl_nombre.BackColor = System.Drawing.Color.Transparent
        Me.lbl_nombre.Name = "lbl_nombre"
        '
        'btn_volver
        '
        resources.ApplyResources(Me.btn_volver, "btn_volver")
        Me.btn_volver.BackColor = System.Drawing.Color.Transparent
        Me.btn_volver.FlatAppearance.BorderSize = 0
        Me.btn_volver.Image = Global.Presentacion.My.Resources.Resources.btn_volver_85x30
        Me.btn_volver.Name = "btn_volver"
        Me.btn_volver.UseVisualStyleBackColor = False
        '
        'F_Pacientes
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnl_contenedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "F_Pacientes"
        Me.ShowInTaskbar = False
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnl_contenedor.ResumeLayout(False)
        CType(Me.pnl_dgv_pacientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_filtrar.ResumeLayout(False)
        Me.pnl_filtrar.PerformLayout()
        Me.pnl_ingresar.ResumeLayout(False)
        Me.pnl_ingresar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnl_contenedor As Panel
    Friend WithEvents pnl_dgv_pacientes As DataGridView
    Friend WithEvents pnl_filtrar As Panel
    Friend WithEvents pnl_ingresar As Panel
    Friend WithEvents btn_volver As Button
    Friend WithEvents lbl_nombre As Label
    Friend WithEvents lbl_departamento As Label
    Friend WithEvents lbl_calle As Label
    Friend WithEvents lbl_telefono As Label
    Friend WithEvents lbl_fechaNacimiento As Label
    Friend WithEvents lbl_apellidos As Label
    Friend WithEvents lbl_email As Label
    Friend WithEvents lbl_medicacion As Label
    Friend WithEvents lbl_enfermedad As Label
    Friend WithEvents lbl_antecedentesLab As Label
    Friend WithEvents lbl_tratamientos As Label
    Friend WithEvents lbl_antecedentesFlia As Label
    Friend WithEvents lbl_nucleoFlia As Label
    Friend WithEvents txt_enfermedad As TextBox
    Friend WithEvents cmb_medicacion As ComboBox
    Friend WithEvents txt_antecedentesLab As TextBox
    Friend WithEvents txt_tratamientos As TextBox
    Friend WithEvents txt_antecedentesFlia As TextBox
    Friend WithEvents txt_nucleoFlia As TextBox
    Friend WithEvents txt_email As TextBox
    Friend WithEvents txt_departamento As TextBox
    Friend WithEvents txt_calle As TextBox
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents txt_numero As TextBox
    Friend WithEvents lbl_numero As Label
    Friend WithEvents txt_telefono As TextBox
    Friend WithEvents txt_apellidoM As TextBox
    Friend WithEvents txt_apellidoP As TextBox
    Friend WithEvents dtp_fechaNacimiento As DateTimePicker
    Friend WithEvents btn_ingresar As Button
    Friend WithEvents txt_localidad As TextBox
    Friend WithEvents lbl_localidad As Label
    Friend WithEvents lbl_detalle As Label
    Friend WithEvents cmb_detalle As ComboBox
    Friend WithEvents txt_localidadFiltrar As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_departamentoFiltrar As TextBox
    Friend WithEvents lbl_departamentpFiltrar As Label
    Friend WithEvents txt_edadFiltrar As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cmb_detalleFiltrar As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_numeroFiltrar As TextBox
    Friend WithEvents lbl_edad As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_telefonoFiltrar As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_apellidoMFiltrar As TextBox
    Friend WithEvents txt_nombreFiltrar As TextBox
    Friend WithEvents txt_apellidoPFiltrar As TextBox
    Friend WithEvents txt_calleFiltrar As TextBox
    Friend WithEvents txt_emailFiltrar As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btn_filtrar As Button
    Friend WithEvents Guna2DateTimePicker1 As Guna.UI2.WinForms.Guna2DateTimePicker
End Class
