<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_Medicos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_Medicos))
        Me.pnl_fondo = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btn_cerrar = New System.Windows.Forms.Button()
        Me.btn_minimizar = New System.Windows.Forms.Button()
        Me.pnl_ingresarFiltrar = New System.Windows.Forms.Panel()
        Me.btn_ingresar = New System.Windows.Forms.Button()
        Me.btn_filtrar = New System.Windows.Forms.Button()
        Me.btn_menosEspecialidad = New System.Windows.Forms.Button()
        Me.cmb_detalles = New System.Windows.Forms.ComboBox()
        Me.btn_masEspecialidad = New System.Windows.Forms.Button()
        Me.txt_numero = New System.Windows.Forms.TextBox()
        Me.dtp_fecha = New System.Windows.Forms.DateTimePicker()
        Me.cmb_espacialidadI = New System.Windows.Forms.ComboBox()
        Me.cmb_departamento = New System.Windows.Forms.ComboBox()
        Me.cmb_especialidad = New System.Windows.Forms.ComboBox()
        Me.cmb_sucursales = New System.Windows.Forms.ComboBox()
        Me.txt_apellidoM = New System.Windows.Forms.TextBox()
        Me.txt_apellidoP = New System.Windows.Forms.TextBox()
        Me.txt_nombres = New System.Windows.Forms.TextBox()
        Me.txt_ci = New System.Windows.Forms.TextBox()
        Me.txt_telefono = New System.Windows.Forms.TextBox()
        Me.txt_localidad = New System.Windows.Forms.TextBox()
        Me.txt_direccion = New System.Windows.Forms.TextBox()
        Me.txt_apellidoMI = New System.Windows.Forms.TextBox()
        Me.txt_apellidoPI = New System.Windows.Forms.TextBox()
        Me.txt_nombresI = New System.Windows.Forms.TextBox()
        Me.txt_ciI = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_fecha = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lbl_localidad = New System.Windows.Forms.Label()
        Me.lbl_dirección = New System.Windows.Forms.Label()
        Me.lbl_especialidad = New System.Windows.Forms.Label()
        Me.lbl_sucursales = New System.Windows.Forms.Label()
        Me.lbl_ingresar = New System.Windows.Forms.Label()
        Me.lbl_apellidos = New System.Windows.Forms.Label()
        Me.lbl_nombres = New System.Windows.Forms.Label()
        Me.lbl_CI = New System.Windows.Forms.Label()
        Me.lbl_busqueda = New System.Windows.Forms.Label()
        Me.btn_volver = New System.Windows.Forms.Button()
        Me.pnl_fondo.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_ingresarFiltrar.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl_fondo
        '
        Me.pnl_fondo.Controls.Add(Me.DataGridView1)
        Me.pnl_fondo.Controls.Add(Me.btn_cerrar)
        Me.pnl_fondo.Controls.Add(Me.btn_minimizar)
        Me.pnl_fondo.Controls.Add(Me.pnl_ingresarFiltrar)
        Me.pnl_fondo.Location = New System.Drawing.Point(0, 0)
        Me.pnl_fondo.Name = "pnl_fondo"
        Me.pnl_fondo.Size = New System.Drawing.Size(1920, 1080)
        Me.pnl_fondo.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(597, 120)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1300, 839)
        Me.DataGridView1.TabIndex = 47
        '
        'btn_cerrar
        '
        Me.btn_cerrar.FlatAppearance.BorderSize = 0
        Me.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cerrar.Image = CType(resources.GetObject("btn_cerrar.Image"), System.Drawing.Image)
        Me.btn_cerrar.Location = New System.Drawing.Point(1861, 1)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(56, 61)
        Me.btn_cerrar.TabIndex = 46
        Me.btn_cerrar.UseVisualStyleBackColor = True
        '
        'btn_minimizar
        '
        Me.btn_minimizar.FlatAppearance.BorderSize = 0
        Me.btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_minimizar.Image = CType(resources.GetObject("btn_minimizar.Image"), System.Drawing.Image)
        Me.btn_minimizar.Location = New System.Drawing.Point(1795, 1)
        Me.btn_minimizar.Name = "btn_minimizar"
        Me.btn_minimizar.Size = New System.Drawing.Size(60, 61)
        Me.btn_minimizar.TabIndex = 45
        Me.btn_minimizar.UseVisualStyleBackColor = True
        '
        'pnl_ingresarFiltrar
        '
        Me.pnl_ingresarFiltrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.pnl_ingresarFiltrar.Controls.Add(Me.btn_ingresar)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.btn_filtrar)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.btn_menosEspecialidad)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.cmb_detalles)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.btn_masEspecialidad)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.txt_numero)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.dtp_fecha)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.cmb_espacialidadI)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.cmb_departamento)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.cmb_especialidad)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.cmb_sucursales)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.txt_apellidoM)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.txt_apellidoP)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.txt_nombres)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.txt_ci)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.txt_telefono)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.txt_localidad)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.txt_direccion)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.txt_apellidoMI)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.txt_apellidoPI)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.txt_nombresI)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.txt_ciI)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.Label1)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.lbl_fecha)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.Label3)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.Label4)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.Label5)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.Label11)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.Label12)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.lbl_localidad)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.lbl_dirección)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.lbl_especialidad)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.lbl_sucursales)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.lbl_ingresar)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.lbl_apellidos)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.lbl_nombres)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.lbl_CI)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.lbl_busqueda)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.btn_volver)
        Me.pnl_ingresarFiltrar.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnl_ingresarFiltrar.Location = New System.Drawing.Point(0, 0)
        Me.pnl_ingresarFiltrar.Name = "pnl_ingresarFiltrar"
        Me.pnl_ingresarFiltrar.Size = New System.Drawing.Size(573, 1080)
        Me.pnl_ingresarFiltrar.TabIndex = 0
        '
        'btn_ingresar
        '
        Me.btn_ingresar.FlatAppearance.BorderSize = 0
        Me.btn_ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ingresar.Image = Global.Presentacion.My.Resources.Resources.Ingresar_Button
        Me.btn_ingresar.Location = New System.Drawing.Point(345, 940)
        Me.btn_ingresar.Name = "btn_ingresar"
        Me.btn_ingresar.Size = New System.Drawing.Size(155, 51)
        Me.btn_ingresar.TabIndex = 42
        Me.btn_ingresar.UseVisualStyleBackColor = True
        '
        'btn_filtrar
        '
        Me.btn_filtrar.FlatAppearance.BorderSize = 0
        Me.btn_filtrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_filtrar.Image = Global.Presentacion.My.Resources.Resources.btn_filtrar
        Me.btn_filtrar.Location = New System.Drawing.Point(381, 362)
        Me.btn_filtrar.Name = "btn_filtrar"
        Me.btn_filtrar.Size = New System.Drawing.Size(155, 51)
        Me.btn_filtrar.TabIndex = 41
        Me.btn_filtrar.UseVisualStyleBackColor = True
        '
        'btn_menosEspecialidad
        '
        Me.btn_menosEspecialidad.FlatAppearance.BorderSize = 0
        Me.btn_menosEspecialidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_menosEspecialidad.Image = CType(resources.GetObject("btn_menosEspecialidad.Image"), System.Drawing.Image)
        Me.btn_menosEspecialidad.Location = New System.Drawing.Point(508, 831)
        Me.btn_menosEspecialidad.Name = "btn_menosEspecialidad"
        Me.btn_menosEspecialidad.Size = New System.Drawing.Size(28, 35)
        Me.btn_menosEspecialidad.TabIndex = 44
        Me.btn_menosEspecialidad.UseVisualStyleBackColor = True
        '
        'cmb_detalles
        '
        Me.cmb_detalles.FormattingEnabled = True
        Me.cmb_detalles.Location = New System.Drawing.Point(475, 644)
        Me.cmb_detalles.Name = "cmb_detalles"
        Me.cmb_detalles.Size = New System.Drawing.Size(84, 33)
        Me.cmb_detalles.TabIndex = 40
        '
        'btn_masEspecialidad
        '
        Me.btn_masEspecialidad.FlatAppearance.BorderSize = 0
        Me.btn_masEspecialidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_masEspecialidad.Image = CType(resources.GetObject("btn_masEspecialidad.Image"), System.Drawing.Image)
        Me.btn_masEspecialidad.Location = New System.Drawing.Point(475, 833)
        Me.btn_masEspecialidad.Name = "btn_masEspecialidad"
        Me.btn_masEspecialidad.Size = New System.Drawing.Size(27, 33)
        Me.btn_masEspecialidad.TabIndex = 43
        Me.btn_masEspecialidad.UseVisualStyleBackColor = True
        '
        'txt_numero
        '
        Me.txt_numero.Location = New System.Drawing.Point(371, 644)
        Me.txt_numero.Name = "txt_numero"
        Me.txt_numero.Size = New System.Drawing.Size(98, 33)
        Me.txt_numero.TabIndex = 39
        '
        'dtp_fecha
        '
        Me.dtp_fecha.Location = New System.Drawing.Point(271, 597)
        Me.dtp_fecha.Name = "dtp_fecha"
        Me.dtp_fecha.Size = New System.Drawing.Size(200, 33)
        Me.dtp_fecha.TabIndex = 38
        '
        'cmb_espacialidadI
        '
        Me.cmb_espacialidadI.FormattingEnabled = True
        Me.cmb_espacialidadI.Location = New System.Drawing.Point(217, 828)
        Me.cmb_espacialidadI.Name = "cmb_espacialidadI"
        Me.cmb_espacialidadI.Size = New System.Drawing.Size(252, 33)
        Me.cmb_espacialidadI.TabIndex = 37
        '
        'cmb_departamento
        '
        Me.cmb_departamento.FormattingEnabled = True
        Me.cmb_departamento.Location = New System.Drawing.Point(217, 741)
        Me.cmb_departamento.Name = "cmb_departamento"
        Me.cmb_departamento.Size = New System.Drawing.Size(252, 33)
        Me.cmb_departamento.TabIndex = 36
        '
        'cmb_especialidad
        '
        Me.cmb_especialidad.FormattingEnabled = True
        Me.cmb_especialidad.Location = New System.Drawing.Point(189, 323)
        Me.cmb_especialidad.Name = "cmb_especialidad"
        Me.cmb_especialidad.Size = New System.Drawing.Size(229, 33)
        Me.cmb_especialidad.TabIndex = 35
        '
        'cmb_sucursales
        '
        Me.cmb_sucursales.FormattingEnabled = True
        Me.cmb_sucursales.Location = New System.Drawing.Point(189, 284)
        Me.cmb_sucursales.Name = "cmb_sucursales"
        Me.cmb_sucursales.Size = New System.Drawing.Size(229, 33)
        Me.cmb_sucursales.TabIndex = 34
        '
        'txt_apellidoM
        '
        Me.txt_apellidoM.Location = New System.Drawing.Point(299, 232)
        Me.txt_apellidoM.Name = "txt_apellidoM"
        Me.txt_apellidoM.Size = New System.Drawing.Size(119, 33)
        Me.txt_apellidoM.TabIndex = 33
        '
        'txt_apellidoP
        '
        Me.txt_apellidoP.Location = New System.Drawing.Point(182, 232)
        Me.txt_apellidoP.Name = "txt_apellidoP"
        Me.txt_apellidoP.Size = New System.Drawing.Size(111, 33)
        Me.txt_apellidoP.TabIndex = 32
        '
        'txt_nombres
        '
        Me.txt_nombres.Location = New System.Drawing.Point(180, 190)
        Me.txt_nombres.Name = "txt_nombres"
        Me.txt_nombres.Size = New System.Drawing.Size(236, 33)
        Me.txt_nombres.TabIndex = 31
        '
        'txt_ci
        '
        Me.txt_ci.Location = New System.Drawing.Point(180, 136)
        Me.txt_ci.Name = "txt_ci"
        Me.txt_ci.Size = New System.Drawing.Size(236, 33)
        Me.txt_ci.TabIndex = 30
        '
        'txt_telefono
        '
        Me.txt_telefono.Location = New System.Drawing.Point(217, 780)
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(252, 33)
        Me.txt_telefono.TabIndex = 29
        '
        'txt_localidad
        '
        Me.txt_localidad.Location = New System.Drawing.Point(189, 690)
        Me.txt_localidad.Name = "txt_localidad"
        Me.txt_localidad.Size = New System.Drawing.Size(280, 33)
        Me.txt_localidad.TabIndex = 27
        '
        'txt_direccion
        '
        Me.txt_direccion.Location = New System.Drawing.Point(186, 644)
        Me.txt_direccion.Name = "txt_direccion"
        Me.txt_direccion.Size = New System.Drawing.Size(179, 33)
        Me.txt_direccion.TabIndex = 26
        '
        'txt_apellidoMI
        '
        Me.txt_apellidoMI.Location = New System.Drawing.Point(323, 552)
        Me.txt_apellidoMI.Name = "txt_apellidoMI"
        Me.txt_apellidoMI.Size = New System.Drawing.Size(148, 33)
        Me.txt_apellidoMI.TabIndex = 25
        '
        'txt_apellidoPI
        '
        Me.txt_apellidoPI.Location = New System.Drawing.Point(170, 552)
        Me.txt_apellidoPI.Name = "txt_apellidoPI"
        Me.txt_apellidoPI.Size = New System.Drawing.Size(147, 33)
        Me.txt_apellidoPI.TabIndex = 24
        '
        'txt_nombresI
        '
        Me.txt_nombresI.Location = New System.Drawing.Point(170, 504)
        Me.txt_nombresI.Name = "txt_nombresI"
        Me.txt_nombresI.Size = New System.Drawing.Size(301, 33)
        Me.txt_nombresI.TabIndex = 23
        '
        'txt_ciI
        '
        Me.txt_ciI.Location = New System.Drawing.Point(170, 456)
        Me.txt_ciI.Name = "txt_ciI"
        Me.txt_ciI.Size = New System.Drawing.Size(301, 33)
        Me.txt_ciI.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(86, 831)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 25)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Especialidad:"
        '
        'lbl_fecha
        '
        Me.lbl_fecha.AutoSize = True
        Me.lbl_fecha.Location = New System.Drawing.Point(86, 603)
        Me.lbl_fecha.Name = "lbl_fecha"
        Me.lbl_fecha.Size = New System.Drawing.Size(190, 25)
        Me.lbl_fecha.TabIndex = 20
        Me.lbl_fecha.Text = "Fecha de nacimiento:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(84, 555)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 25)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Apellidos:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(84, 507)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 31)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Nombres:"
        Me.Label4.UseCompatibleTextRendering = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(84, 459)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 25)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "C.I:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(86, 783)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 25)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Teléfono:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(86, 742)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(137, 25)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Departamento:"
        '
        'lbl_localidad
        '
        Me.lbl_localidad.AutoSize = True
        Me.lbl_localidad.Location = New System.Drawing.Point(86, 693)
        Me.lbl_localidad.Name = "lbl_localidad"
        Me.lbl_localidad.Size = New System.Drawing.Size(97, 25)
        Me.lbl_localidad.TabIndex = 14
        Me.lbl_localidad.Text = "Localidad:"
        '
        'lbl_dirección
        '
        Me.lbl_dirección.AutoSize = True
        Me.lbl_dirección.Location = New System.Drawing.Point(84, 647)
        Me.lbl_dirección.Name = "lbl_dirección"
        Me.lbl_dirección.Size = New System.Drawing.Size(96, 25)
        Me.lbl_dirección.TabIndex = 13
        Me.lbl_dirección.Text = "Dirección:"
        '
        'lbl_especialidad
        '
        Me.lbl_especialidad.AutoSize = True
        Me.lbl_especialidad.Location = New System.Drawing.Point(75, 330)
        Me.lbl_especialidad.Name = "lbl_especialidad"
        Me.lbl_especialidad.Size = New System.Drawing.Size(121, 25)
        Me.lbl_especialidad.TabIndex = 7
        Me.lbl_especialidad.Text = "Especialidad:"
        '
        'lbl_sucursales
        '
        Me.lbl_sucursales.AutoSize = True
        Me.lbl_sucursales.Location = New System.Drawing.Point(75, 287)
        Me.lbl_sucursales.Name = "lbl_sucursales"
        Me.lbl_sucursales.Size = New System.Drawing.Size(105, 25)
        Me.lbl_sucursales.TabIndex = 6
        Me.lbl_sucursales.Text = "Sucursales:"
        '
        'lbl_ingresar
        '
        Me.lbl_ingresar.AutoSize = True
        Me.lbl_ingresar.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ingresar.Location = New System.Drawing.Point(81, 417)
        Me.lbl_ingresar.Name = "lbl_ingresar"
        Me.lbl_ingresar.Size = New System.Drawing.Size(86, 25)
        Me.lbl_ingresar.TabIndex = 5
        Me.lbl_ingresar.Text = "Ingresar"
        '
        'lbl_apellidos
        '
        Me.lbl_apellidos.AutoSize = True
        Me.lbl_apellidos.Location = New System.Drawing.Point(79, 240)
        Me.lbl_apellidos.Name = "lbl_apellidos"
        Me.lbl_apellidos.Size = New System.Drawing.Size(94, 25)
        Me.lbl_apellidos.TabIndex = 4
        Me.lbl_apellidos.Text = "Apellidos:"
        '
        'lbl_nombres
        '
        Me.lbl_nombres.AutoSize = True
        Me.lbl_nombres.Location = New System.Drawing.Point(80, 193)
        Me.lbl_nombres.Name = "lbl_nombres"
        Me.lbl_nombres.Size = New System.Drawing.Size(91, 31)
        Me.lbl_nombres.TabIndex = 3
        Me.lbl_nombres.Text = "Nombres:"
        Me.lbl_nombres.UseCompatibleTextRendering = True
        '
        'lbl_CI
        '
        Me.lbl_CI.AutoSize = True
        Me.lbl_CI.Location = New System.Drawing.Point(80, 144)
        Me.lbl_CI.Name = "lbl_CI"
        Me.lbl_CI.Size = New System.Drawing.Size(37, 25)
        Me.lbl_CI.TabIndex = 2
        Me.lbl_CI.Text = "C.I:"
        '
        'lbl_busqueda
        '
        Me.lbl_busqueda.AutoSize = True
        Me.lbl_busqueda.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_busqueda.Location = New System.Drawing.Point(75, 101)
        Me.lbl_busqueda.Name = "lbl_busqueda"
        Me.lbl_busqueda.Size = New System.Drawing.Size(92, 25)
        Me.lbl_busqueda.TabIndex = 1
        Me.lbl_busqueda.Text = "Búqueda"
        '
        'btn_volver
        '
        Me.btn_volver.FlatAppearance.BorderSize = 0
        Me.btn_volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_volver.Image = Global.Presentacion.My.Resources.Resources.btn_volver
        Me.btn_volver.Location = New System.Drawing.Point(3, 3)
        Me.btn_volver.Name = "btn_volver"
        Me.btn_volver.Size = New System.Drawing.Size(155, 51)
        Me.btn_volver.TabIndex = 0
        Me.btn_volver.UseVisualStyleBackColor = True
        '
        'frm_MedicosIngresarFiltrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1920, 1080)
        Me.Controls.Add(Me.pnl_fondo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_MedicosIngresarFiltrar"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnl_fondo.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_ingresarFiltrar.ResumeLayout(False)
        Me.pnl_ingresarFiltrar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnl_fondo As Panel
    Friend WithEvents pnl_ingresarFiltrar As Panel
    Friend WithEvents lbl_busqueda As Label
    Friend WithEvents btn_volver As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lbl_localidad As Label
    Friend WithEvents lbl_dirección As Label
    Friend WithEvents lbl_especialidad As Label
    Friend WithEvents lbl_sucursales As Label
    Friend WithEvents lbl_ingresar As Label
    Friend WithEvents lbl_apellidos As Label
    Friend WithEvents lbl_nombres As Label
    Friend WithEvents lbl_CI As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_fecha As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cmb_especialidad As ComboBox
    Friend WithEvents cmb_sucursales As ComboBox
    Friend WithEvents txt_apellidoM As TextBox
    Friend WithEvents txt_apellidoP As TextBox
    Friend WithEvents txt_nombres As TextBox
    Friend WithEvents txt_ci As TextBox
    Friend WithEvents txt_telefono As TextBox
    Friend WithEvents txt_localidad As TextBox
    Friend WithEvents txt_direccion As TextBox
    Friend WithEvents txt_apellidoMI As TextBox
    Friend WithEvents txt_apellidoPI As TextBox
    Friend WithEvents txt_nombresI As TextBox
    Friend WithEvents txt_ciI As TextBox
    Friend WithEvents dtp_fecha As DateTimePicker
    Friend WithEvents cmb_espacialidadI As ComboBox
    Friend WithEvents cmb_departamento As ComboBox
    Friend WithEvents cmb_detalles As ComboBox
    Friend WithEvents txt_numero As TextBox
    Friend WithEvents btn_cerrar As Button
    Friend WithEvents btn_minimizar As Button
    Friend WithEvents btn_ingresar As Button
    Friend WithEvents btn_filtrar As Button
    Friend WithEvents btn_menosEspecialidad As Button
    Friend WithEvents btn_masEspecialidad As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
