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
        Me.pnl_contenedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.pnl_contenedor.Controls.Add(Me.pnl_dgv_pacientes)
        Me.pnl_contenedor.Controls.Add(Me.pnl_filtrar)
        Me.pnl_contenedor.Controls.Add(Me.pnl_ingresar)
        Me.pnl_contenedor.Location = New System.Drawing.Point(0, 0)
        Me.pnl_contenedor.Name = "pnl_contenedor"
        Me.pnl_contenedor.Size = New System.Drawing.Size(1920, 1080)
        Me.pnl_contenedor.TabIndex = 0
        '
        'pnl_dgv_pacientes
        '
        Me.pnl_dgv_pacientes.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.pnl_dgv_pacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.pnl_dgv_pacientes.Location = New System.Drawing.Point(22, 575)
        Me.pnl_dgv_pacientes.Name = "pnl_dgv_pacientes"
        Me.pnl_dgv_pacientes.Size = New System.Drawing.Size(1878, 463)
        Me.pnl_dgv_pacientes.TabIndex = 2
        '
        'pnl_filtrar
        '
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
        Me.pnl_filtrar.Location = New System.Drawing.Point(1031, 7)
        Me.pnl_filtrar.Name = "pnl_filtrar"
        Me.pnl_filtrar.Size = New System.Drawing.Size(882, 559)
        Me.pnl_filtrar.TabIndex = 1
        '
        'btn_filtrar
        '
        Me.btn_filtrar.Image = Global.Presentacion.My.Resources.Resources.btn_filtrar
        Me.btn_filtrar.Location = New System.Drawing.Point(693, 300)
        Me.btn_filtrar.Name = "btn_filtrar"
        Me.btn_filtrar.Size = New System.Drawing.Size(119, 39)
        Me.btn_filtrar.TabIndex = 35
        Me.btn_filtrar.UseVisualStyleBackColor = True
        '
        'txt_emailFiltrar
        '
        Me.txt_emailFiltrar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_emailFiltrar.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.txt_emailFiltrar.Location = New System.Drawing.Point(99, 251)
        Me.txt_emailFiltrar.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_emailFiltrar.Multiline = True
        Me.txt_emailFiltrar.Name = "txt_emailFiltrar"
        Me.txt_emailFiltrar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_emailFiltrar.Size = New System.Drawing.Size(726, 30)
        Me.txt_emailFiltrar.TabIndex = 36
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(28, 251)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 30)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "Email:"
        '
        'txt_localidadFiltrar
        '
        Me.txt_localidadFiltrar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_localidadFiltrar.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.txt_localidadFiltrar.Location = New System.Drawing.Point(572, 209)
        Me.txt_localidadFiltrar.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_localidadFiltrar.Name = "txt_localidadFiltrar"
        Me.txt_localidadFiltrar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_localidadFiltrar.Size = New System.Drawing.Size(253, 29)
        Me.txt_localidadFiltrar.TabIndex = 38
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(463, 207)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 30)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Localidad:"
        '
        'txt_departamentoFiltrar
        '
        Me.txt_departamentoFiltrar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_departamentoFiltrar.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.txt_departamentoFiltrar.Location = New System.Drawing.Point(180, 209)
        Me.txt_departamentoFiltrar.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_departamentoFiltrar.Name = "txt_departamentoFiltrar"
        Me.txt_departamentoFiltrar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_departamentoFiltrar.Size = New System.Drawing.Size(279, 29)
        Me.txt_departamentoFiltrar.TabIndex = 36
        '
        'lbl_departamentpFiltrar
        '
        Me.lbl_departamentpFiltrar.AutoSize = True
        Me.lbl_departamentpFiltrar.BackColor = System.Drawing.Color.Transparent
        Me.lbl_departamentpFiltrar.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_departamentpFiltrar.Location = New System.Drawing.Point(28, 208)
        Me.lbl_departamentpFiltrar.Name = "lbl_departamentpFiltrar"
        Me.lbl_departamentpFiltrar.Size = New System.Drawing.Size(152, 30)
        Me.lbl_departamentpFiltrar.TabIndex = 35
        Me.lbl_departamentpFiltrar.Text = "Departamento:"
        '
        'txt_edadFiltrar
        '
        Me.txt_edadFiltrar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_edadFiltrar.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.txt_edadFiltrar.Location = New System.Drawing.Point(119, 124)
        Me.txt_edadFiltrar.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_edadFiltrar.Name = "txt_edadFiltrar"
        Me.txt_edadFiltrar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_edadFiltrar.Size = New System.Drawing.Size(65, 29)
        Me.txt_edadFiltrar.TabIndex = 50
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(629, 164)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 30)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Detalle:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(320, 83)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 30)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Apellidos:"
        '
        'cmb_detalleFiltrar
        '
        Me.cmb_detalleFiltrar.FormattingEnabled = True
        Me.cmb_detalleFiltrar.Location = New System.Drawing.Point(704, 171)
        Me.cmb_detalleFiltrar.Name = "cmb_detalleFiltrar"
        Me.cmb_detalleFiltrar.Size = New System.Drawing.Size(121, 21)
        Me.cmb_detalleFiltrar.TabIndex = 48
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(27, 83)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 30)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Nombre:"
        '
        'txt_numeroFiltrar
        '
        Me.txt_numeroFiltrar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_numeroFiltrar.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.txt_numeroFiltrar.Location = New System.Drawing.Point(484, 164)
        Me.txt_numeroFiltrar.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_numeroFiltrar.Name = "txt_numeroFiltrar"
        Me.txt_numeroFiltrar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_numeroFiltrar.Size = New System.Drawing.Size(142, 29)
        Me.txt_numeroFiltrar.TabIndex = 47
        '
        'lbl_edad
        '
        Me.lbl_edad.AutoSize = True
        Me.lbl_edad.BackColor = System.Drawing.Color.Transparent
        Me.lbl_edad.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_edad.Location = New System.Drawing.Point(27, 124)
        Me.lbl_edad.Name = "lbl_edad"
        Me.lbl_edad.Size = New System.Drawing.Size(64, 30)
        Me.lbl_edad.TabIndex = 37
        Me.lbl_edad.Text = "Edad:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(365, 162)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 30)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Número:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(320, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 30)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Teléfono:"
        '
        'txt_telefonoFiltrar
        '
        Me.txt_telefonoFiltrar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_telefonoFiltrar.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.txt_telefonoFiltrar.Location = New System.Drawing.Point(420, 124)
        Me.txt_telefonoFiltrar.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_telefonoFiltrar.Name = "txt_telefonoFiltrar"
        Me.txt_telefonoFiltrar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_telefonoFiltrar.Size = New System.Drawing.Size(205, 29)
        Me.txt_telefonoFiltrar.TabIndex = 45
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(27, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 30)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Dirección:"
        '
        'txt_apellidoMFiltrar
        '
        Me.txt_apellidoMFiltrar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_apellidoMFiltrar.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.txt_apellidoMFiltrar.Location = New System.Drawing.Point(634, 83)
        Me.txt_apellidoMFiltrar.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_apellidoMFiltrar.Name = "txt_apellidoMFiltrar"
        Me.txt_apellidoMFiltrar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_apellidoMFiltrar.Size = New System.Drawing.Size(191, 29)
        Me.txt_apellidoMFiltrar.TabIndex = 44
        '
        'txt_nombreFiltrar
        '
        Me.txt_nombreFiltrar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_nombreFiltrar.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.txt_nombreFiltrar.Location = New System.Drawing.Point(119, 84)
        Me.txt_nombreFiltrar.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_nombreFiltrar.Name = "txt_nombreFiltrar"
        Me.txt_nombreFiltrar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_nombreFiltrar.Size = New System.Drawing.Size(173, 29)
        Me.txt_nombreFiltrar.TabIndex = 40
        '
        'txt_apellidoPFiltrar
        '
        Me.txt_apellidoPFiltrar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_apellidoPFiltrar.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.txt_apellidoPFiltrar.Location = New System.Drawing.Point(442, 84)
        Me.txt_apellidoPFiltrar.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_apellidoPFiltrar.Name = "txt_apellidoPFiltrar"
        Me.txt_apellidoPFiltrar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_apellidoPFiltrar.Size = New System.Drawing.Size(183, 29)
        Me.txt_apellidoPFiltrar.TabIndex = 43
        '
        'txt_calleFiltrar
        '
        Me.txt_calleFiltrar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_calleFiltrar.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.txt_calleFiltrar.Location = New System.Drawing.Point(135, 165)
        Me.txt_calleFiltrar.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_calleFiltrar.Name = "txt_calleFiltrar"
        Me.txt_calleFiltrar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_calleFiltrar.Size = New System.Drawing.Size(227, 29)
        Me.txt_calleFiltrar.TabIndex = 42
        '
        'pnl_ingresar
        '
        Me.pnl_ingresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(222, Byte), Integer))
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
        Me.pnl_ingresar.Location = New System.Drawing.Point(7, 7)
        Me.pnl_ingresar.Name = "pnl_ingresar"
        Me.pnl_ingresar.Size = New System.Drawing.Size(1008, 559)
        Me.pnl_ingresar.TabIndex = 0
        '
        'btn_ingresar
        '
        Me.btn_ingresar.BackColor = System.Drawing.Color.Transparent
        Me.btn_ingresar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_ingresar.FlatAppearance.BorderSize = 0
        Me.btn_ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ingresar.Image = Global.Presentacion.My.Resources.Resources.btn_ingresar_87x32
        Me.btn_ingresar.Location = New System.Drawing.Point(854, 507)
        Me.btn_ingresar.Name = "btn_ingresar"
        Me.btn_ingresar.Size = New System.Drawing.Size(95, 40)
        Me.btn_ingresar.TabIndex = 34
        Me.btn_ingresar.UseVisualStyleBackColor = False
        '
        'txt_localidad
        '
        Me.txt_localidad.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_localidad.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.txt_localidad.Location = New System.Drawing.Point(603, 164)
        Me.txt_localidad.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_localidad.Name = "txt_localidad"
        Me.txt_localidad.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_localidad.Size = New System.Drawing.Size(355, 29)
        Me.txt_localidad.TabIndex = 33
        '
        'lbl_localidad
        '
        Me.lbl_localidad.AutoSize = True
        Me.lbl_localidad.BackColor = System.Drawing.Color.Transparent
        Me.lbl_localidad.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_localidad.Location = New System.Drawing.Point(481, 162)
        Me.lbl_localidad.Name = "lbl_localidad"
        Me.lbl_localidad.Size = New System.Drawing.Size(106, 30)
        Me.lbl_localidad.TabIndex = 32
        Me.lbl_localidad.Text = "Localidad:"
        '
        'lbl_detalle
        '
        Me.lbl_detalle.AutoSize = True
        Me.lbl_detalle.BackColor = System.Drawing.Color.Transparent
        Me.lbl_detalle.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_detalle.Location = New System.Drawing.Point(748, 124)
        Me.lbl_detalle.Name = "lbl_detalle"
        Me.lbl_detalle.Size = New System.Drawing.Size(83, 30)
        Me.lbl_detalle.TabIndex = 31
        Me.lbl_detalle.Text = "Detalle:"
        '
        'cmb_detalle
        '
        Me.cmb_detalle.FormattingEnabled = True
        Me.cmb_detalle.Location = New System.Drawing.Point(837, 131)
        Me.cmb_detalle.Name = "cmb_detalle"
        Me.cmb_detalle.Size = New System.Drawing.Size(121, 21)
        Me.cmb_detalle.TabIndex = 30
        '
        'txt_numero
        '
        Me.txt_numero.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_numero.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.txt_numero.Location = New System.Drawing.Point(603, 124)
        Me.txt_numero.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_numero.Name = "txt_numero"
        Me.txt_numero.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_numero.Size = New System.Drawing.Size(142, 29)
        Me.txt_numero.TabIndex = 29
        '
        'lbl_numero
        '
        Me.lbl_numero.AutoSize = True
        Me.lbl_numero.BackColor = System.Drawing.Color.Transparent
        Me.lbl_numero.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_numero.Location = New System.Drawing.Point(484, 122)
        Me.lbl_numero.Name = "lbl_numero"
        Me.lbl_numero.Size = New System.Drawing.Size(94, 30)
        Me.lbl_numero.TabIndex = 28
        Me.lbl_numero.Text = "Número:"
        '
        'txt_telefono
        '
        Me.txt_telefono.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_telefono.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.txt_telefono.Location = New System.Drawing.Point(603, 85)
        Me.txt_telefono.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_telefono.Size = New System.Drawing.Size(355, 29)
        Me.txt_telefono.TabIndex = 27
        '
        'txt_apellidoM
        '
        Me.txt_apellidoM.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_apellidoM.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.txt_apellidoM.Location = New System.Drawing.Point(795, 47)
        Me.txt_apellidoM.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_apellidoM.Name = "txt_apellidoM"
        Me.txt_apellidoM.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_apellidoM.Size = New System.Drawing.Size(163, 29)
        Me.txt_apellidoM.TabIndex = 26
        '
        'txt_apellidoP
        '
        Me.txt_apellidoP.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_apellidoP.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.txt_apellidoP.Location = New System.Drawing.Point(603, 48)
        Me.txt_apellidoP.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_apellidoP.Name = "txt_apellidoP"
        Me.txt_apellidoP.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_apellidoP.Size = New System.Drawing.Size(163, 29)
        Me.txt_apellidoP.TabIndex = 25
        '
        'lbl_medicacion
        '
        Me.lbl_medicacion.AutoSize = True
        Me.lbl_medicacion.BackColor = System.Drawing.Color.Transparent
        Me.lbl_medicacion.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_medicacion.Location = New System.Drawing.Point(598, 469)
        Me.lbl_medicacion.Name = "lbl_medicacion"
        Me.lbl_medicacion.Size = New System.Drawing.Size(125, 30)
        Me.lbl_medicacion.TabIndex = 24
        Me.lbl_medicacion.Text = "Medicación:"
        '
        'lbl_enfermedad
        '
        Me.lbl_enfermedad.AutoSize = True
        Me.lbl_enfermedad.BackColor = System.Drawing.Color.Transparent
        Me.lbl_enfermedad.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_enfermedad.Location = New System.Drawing.Point(51, 465)
        Me.lbl_enfermedad.Name = "lbl_enfermedad"
        Me.lbl_enfermedad.Size = New System.Drawing.Size(130, 30)
        Me.lbl_enfermedad.TabIndex = 23
        Me.lbl_enfermedad.Text = "Enfermedad:"
        '
        'lbl_antecedentesLab
        '
        Me.lbl_antecedentesLab.AutoSize = True
        Me.lbl_antecedentesLab.BackColor = System.Drawing.Color.Transparent
        Me.lbl_antecedentesLab.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_antecedentesLab.Location = New System.Drawing.Point(49, 407)
        Me.lbl_antecedentesLab.Name = "lbl_antecedentesLab"
        Me.lbl_antecedentesLab.Size = New System.Drawing.Size(234, 30)
        Me.lbl_antecedentesLab.TabIndex = 22
        Me.lbl_antecedentesLab.Text = "Antecedentes laborales:"
        '
        'lbl_tratamientos
        '
        Me.lbl_tratamientos.AutoSize = True
        Me.lbl_tratamientos.BackColor = System.Drawing.Color.Transparent
        Me.lbl_tratamientos.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tratamientos.Location = New System.Drawing.Point(51, 348)
        Me.lbl_tratamientos.Name = "lbl_tratamientos"
        Me.lbl_tratamientos.Size = New System.Drawing.Size(132, 30)
        Me.lbl_tratamientos.TabIndex = 21
        Me.lbl_tratamientos.Text = "Tratamientos"
        '
        'lbl_antecedentesFlia
        '
        Me.lbl_antecedentesFlia.AutoSize = True
        Me.lbl_antecedentesFlia.BackColor = System.Drawing.Color.Transparent
        Me.lbl_antecedentesFlia.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_antecedentesFlia.Location = New System.Drawing.Point(51, 300)
        Me.lbl_antecedentesFlia.Name = "lbl_antecedentesFlia"
        Me.lbl_antecedentesFlia.Size = New System.Drawing.Size(240, 30)
        Me.lbl_antecedentesFlia.TabIndex = 20
        Me.lbl_antecedentesFlia.Text = "Antecedentes familiares:"
        '
        'lbl_nucleoFlia
        '
        Me.lbl_nucleoFlia.AutoSize = True
        Me.lbl_nucleoFlia.BackColor = System.Drawing.Color.Transparent
        Me.lbl_nucleoFlia.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nucleoFlia.Location = New System.Drawing.Point(51, 251)
        Me.lbl_nucleoFlia.Name = "lbl_nucleoFlia"
        Me.lbl_nucleoFlia.Size = New System.Drawing.Size(161, 30)
        Me.lbl_nucleoFlia.TabIndex = 19
        Me.lbl_nucleoFlia.Text = "Núcleo Familiar:"
        '
        'txt_enfermedad
        '
        Me.txt_enfermedad.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_enfermedad.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.txt_enfermedad.Location = New System.Drawing.Point(184, 466)
        Me.txt_enfermedad.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_enfermedad.Name = "txt_enfermedad"
        Me.txt_enfermedad.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_enfermedad.Size = New System.Drawing.Size(315, 29)
        Me.txt_enfermedad.TabIndex = 18
        '
        'cmb_medicacion
        '
        Me.cmb_medicacion.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_medicacion.FormattingEnabled = True
        Me.cmb_medicacion.Location = New System.Drawing.Point(732, 463)
        Me.cmb_medicacion.Name = "cmb_medicacion"
        Me.cmb_medicacion.Size = New System.Drawing.Size(135, 38)
        Me.cmb_medicacion.TabIndex = 17
        '
        'txt_antecedentesLab
        '
        Me.txt_antecedentesLab.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_antecedentesLab.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.txt_antecedentesLab.Location = New System.Drawing.Point(286, 407)
        Me.txt_antecedentesLab.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_antecedentesLab.Multiline = True
        Me.txt_antecedentesLab.Name = "txt_antecedentesLab"
        Me.txt_antecedentesLab.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_antecedentesLab.Size = New System.Drawing.Size(672, 44)
        Me.txt_antecedentesLab.TabIndex = 16
        '
        'txt_tratamientos
        '
        Me.txt_tratamientos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_tratamientos.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.txt_tratamientos.Location = New System.Drawing.Point(184, 348)
        Me.txt_tratamientos.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_tratamientos.Multiline = True
        Me.txt_tratamientos.Name = "txt_tratamientos"
        Me.txt_tratamientos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_tratamientos.Size = New System.Drawing.Size(774, 46)
        Me.txt_tratamientos.TabIndex = 15
        '
        'txt_antecedentesFlia
        '
        Me.txt_antecedentesFlia.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_antecedentesFlia.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.txt_antecedentesFlia.Location = New System.Drawing.Point(292, 298)
        Me.txt_antecedentesFlia.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_antecedentesFlia.Multiline = True
        Me.txt_antecedentesFlia.Name = "txt_antecedentesFlia"
        Me.txt_antecedentesFlia.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_antecedentesFlia.Size = New System.Drawing.Size(666, 40)
        Me.txt_antecedentesFlia.TabIndex = 14
        '
        'txt_nucleoFlia
        '
        Me.txt_nucleoFlia.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_nucleoFlia.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.txt_nucleoFlia.Location = New System.Drawing.Point(213, 248)
        Me.txt_nucleoFlia.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_nucleoFlia.Multiline = True
        Me.txt_nucleoFlia.Name = "txt_nucleoFlia"
        Me.txt_nucleoFlia.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_nucleoFlia.Size = New System.Drawing.Size(745, 42)
        Me.txt_nucleoFlia.TabIndex = 13
        '
        'txt_email
        '
        Me.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_email.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.txt_email.Location = New System.Drawing.Point(120, 209)
        Me.txt_email.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_email.Multiline = True
        Me.txt_email.Name = "txt_email"
        Me.txt_email.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_email.Size = New System.Drawing.Size(838, 30)
        Me.txt_email.TabIndex = 12
        '
        'txt_departamento
        '
        Me.txt_departamento.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_departamento.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.txt_departamento.Location = New System.Drawing.Point(199, 163)
        Me.txt_departamento.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_departamento.Name = "txt_departamento"
        Me.txt_departamento.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_departamento.Size = New System.Drawing.Size(279, 29)
        Me.txt_departamento.TabIndex = 11
        '
        'txt_calle
        '
        Me.txt_calle.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_calle.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.txt_calle.Location = New System.Drawing.Point(121, 123)
        Me.txt_calle.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_calle.Name = "txt_calle"
        Me.txt_calle.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_calle.Size = New System.Drawing.Size(357, 29)
        Me.txt_calle.TabIndex = 10
        '
        'dtp_fechaNacimiento
        '
        Me.dtp_fechaNacimiento.Location = New System.Drawing.Point(260, 92)
        Me.dtp_fechaNacimiento.MaxDate = New Date(2020, 6, 9, 16, 24, 40, 0)
        Me.dtp_fechaNacimiento.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.dtp_fechaNacimiento.Name = "dtp_fechaNacimiento"
        Me.dtp_fechaNacimiento.Size = New System.Drawing.Size(218, 20)
        Me.dtp_fechaNacimiento.TabIndex = 9
        Me.dtp_fechaNacimiento.Value = New Date(2020, 6, 9, 0, 0, 0, 0)
        '
        'txt_nombre
        '
        Me.txt_nombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_nombre.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.txt_nombre.Location = New System.Drawing.Point(141, 48)
        Me.txt_nombre.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_nombre.Size = New System.Drawing.Size(337, 29)
        Me.txt_nombre.TabIndex = 8
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.BackColor = System.Drawing.Color.Transparent
        Me.lbl_email.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_email.Location = New System.Drawing.Point(51, 209)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(68, 30)
        Me.lbl_email.TabIndex = 7
        Me.lbl_email.Text = "Email:"
        '
        'lbl_departamento
        '
        Me.lbl_departamento.AutoSize = True
        Me.lbl_departamento.BackColor = System.Drawing.Color.Transparent
        Me.lbl_departamento.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_departamento.Location = New System.Drawing.Point(51, 164)
        Me.lbl_departamento.Name = "lbl_departamento"
        Me.lbl_departamento.Size = New System.Drawing.Size(152, 30)
        Me.lbl_departamento.TabIndex = 6
        Me.lbl_departamento.Text = "Departamento:"
        '
        'lbl_calle
        '
        Me.lbl_calle.AutoSize = True
        Me.lbl_calle.BackColor = System.Drawing.Color.Transparent
        Me.lbl_calle.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_calle.Location = New System.Drawing.Point(51, 124)
        Me.lbl_calle.Name = "lbl_calle"
        Me.lbl_calle.Size = New System.Drawing.Size(63, 30)
        Me.lbl_calle.TabIndex = 5
        Me.lbl_calle.Text = "Calle:"
        '
        'lbl_telefono
        '
        Me.lbl_telefono.AutoSize = True
        Me.lbl_telefono.BackColor = System.Drawing.Color.Transparent
        Me.lbl_telefono.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_telefono.Location = New System.Drawing.Point(481, 82)
        Me.lbl_telefono.Name = "lbl_telefono"
        Me.lbl_telefono.Size = New System.Drawing.Size(97, 30)
        Me.lbl_telefono.TabIndex = 4
        Me.lbl_telefono.Text = "Teléfono:"
        '
        'lbl_fechaNacimiento
        '
        Me.lbl_fechaNacimiento.AutoSize = True
        Me.lbl_fechaNacimiento.BackColor = System.Drawing.Color.Transparent
        Me.lbl_fechaNacimiento.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fechaNacimiento.Location = New System.Drawing.Point(49, 82)
        Me.lbl_fechaNacimiento.Name = "lbl_fechaNacimiento"
        Me.lbl_fechaNacimiento.Size = New System.Drawing.Size(210, 30)
        Me.lbl_fechaNacimiento.TabIndex = 3
        Me.lbl_fechaNacimiento.Text = "Fecha de nacimiento:"
        '
        'lbl_apellidos
        '
        Me.lbl_apellidos.AutoSize = True
        Me.lbl_apellidos.BackColor = System.Drawing.Color.Transparent
        Me.lbl_apellidos.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_apellidos.Location = New System.Drawing.Point(481, 47)
        Me.lbl_apellidos.Name = "lbl_apellidos"
        Me.lbl_apellidos.Size = New System.Drawing.Size(103, 30)
        Me.lbl_apellidos.TabIndex = 2
        Me.lbl_apellidos.Text = "Apellidos:"
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.BackColor = System.Drawing.Color.Transparent
        Me.lbl_nombre.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nombre.Location = New System.Drawing.Point(49, 47)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(94, 30)
        Me.lbl_nombre.TabIndex = 1
        Me.lbl_nombre.Text = "Nombre:"
        '
        'btn_volver
        '
        Me.btn_volver.BackColor = System.Drawing.Color.Transparent
        Me.btn_volver.FlatAppearance.BorderSize = 0
        Me.btn_volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_volver.Image = Global.Presentacion.My.Resources.Resources.btn_volver_85x30
        Me.btn_volver.Location = New System.Drawing.Point(21, 6)
        Me.btn_volver.Name = "btn_volver"
        Me.btn_volver.Size = New System.Drawing.Size(93, 38)
        Me.btn_volver.TabIndex = 0
        Me.btn_volver.UseVisualStyleBackColor = False
        '
        'F_Pacientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1920, 1080)
        Me.Controls.Add(Me.pnl_contenedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "F_Pacientes"
        Me.ShowInTaskbar = False
        Me.Text = "frmPacientesIngresarFiltrar"
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
End Class
