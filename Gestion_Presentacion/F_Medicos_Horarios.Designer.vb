<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_Medicos_Horarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_Medicos_Horarios))
        Me.pnl_fondo = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btn_minimizar = New System.Windows.Forms.Button()
        Me.btn_cerrar = New System.Windows.Forms.Button()
        Me.pnl_ingresar = New System.Windows.Forms.Panel()
        Me.cmb_sucursalF = New System.Windows.Forms.ComboBox()
        Me.cmb_sucursal = New System.Windows.Forms.ComboBox()
        Me.txt_ci = New System.Windows.Forms.TextBox()
        Me.lbl_a = New System.Windows.Forms.Label()
        Me.dtp_rangoSalida = New System.Windows.Forms.DateTimePicker()
        Me.dtp_rangoEntrada = New System.Windows.Forms.DateTimePicker()
        Me.dtp_horaSalida = New System.Windows.Forms.DateTimePicker()
        Me.dtp_horaEntrada = New System.Windows.Forms.DateTimePicker()
        Me.rdb_dF = New System.Windows.Forms.RadioButton()
        Me.rdb_sF = New System.Windows.Forms.RadioButton()
        Me.rdb_vF = New System.Windows.Forms.RadioButton()
        Me.rdb_jF = New System.Windows.Forms.RadioButton()
        Me.rdb_xF = New System.Windows.Forms.RadioButton()
        Me.rdb_mF = New System.Windows.Forms.RadioButton()
        Me.rdb_lF = New System.Windows.Forms.RadioButton()
        Me.rdb_d = New System.Windows.Forms.RadioButton()
        Me.rdb_s = New System.Windows.Forms.RadioButton()
        Me.rdb_v = New System.Windows.Forms.RadioButton()
        Me.rdb_j = New System.Windows.Forms.RadioButton()
        Me.rdb_x = New System.Windows.Forms.RadioButton()
        Me.rdb_m = New System.Windows.Forms.RadioButton()
        Me.rdb_l = New System.Windows.Forms.RadioButton()
        Me.btn_filtrar = New System.Windows.Forms.Button()
        Me.btn_ingresar = New System.Windows.Forms.Button()
        Me.btn_volver = New System.Windows.Forms.Button()
        Me.lbl_rango = New System.Windows.Forms.Label()
        Me.lbl_diasB = New System.Windows.Forms.Label()
        Me.lbl_sucursalB = New System.Windows.Forms.Label()
        Me.lbl_busqueda = New System.Windows.Forms.Label()
        Me.lbl_horaSalida = New System.Windows.Forms.Label()
        Me.lbl_horaEntrada = New System.Windows.Forms.Label()
        Me.lbl_dias = New System.Windows.Forms.Label()
        Me.lbl_sucursal = New System.Windows.Forms.Label()
        Me.lbl_ingresoHorarios = New System.Windows.Forms.Label()
        Me.lbl_ci = New System.Windows.Forms.Label()
        Me.lbl_profesional = New System.Windows.Forms.Label()
        Me.pnl_fondo.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_ingresar.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl_fondo
        '
        Me.pnl_fondo.Controls.Add(Me.DataGridView1)
        Me.pnl_fondo.Controls.Add(Me.btn_minimizar)
        Me.pnl_fondo.Controls.Add(Me.btn_cerrar)
        Me.pnl_fondo.Controls.Add(Me.pnl_ingresar)
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
        Me.DataGridView1.TabIndex = 16
        '
        'btn_minimizar
        '
        Me.btn_minimizar.FlatAppearance.BorderSize = 0
        Me.btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_minimizar.Image = CType(resources.GetObject("btn_minimizar.Image"), System.Drawing.Image)
        Me.btn_minimizar.Location = New System.Drawing.Point(1798, 0)
        Me.btn_minimizar.Name = "btn_minimizar"
        Me.btn_minimizar.Size = New System.Drawing.Size(61, 56)
        Me.btn_minimizar.TabIndex = 15
        Me.btn_minimizar.UseVisualStyleBackColor = True
        '
        'btn_cerrar
        '
        Me.btn_cerrar.FlatAppearance.BorderSize = 0
        Me.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cerrar.Image = CType(resources.GetObject("btn_cerrar.Image"), System.Drawing.Image)
        Me.btn_cerrar.Location = New System.Drawing.Point(1858, 3)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(62, 53)
        Me.btn_cerrar.TabIndex = 14
        Me.btn_cerrar.UseVisualStyleBackColor = True
        '
        'pnl_ingresar
        '
        Me.pnl_ingresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.pnl_ingresar.Controls.Add(Me.cmb_sucursalF)
        Me.pnl_ingresar.Controls.Add(Me.cmb_sucursal)
        Me.pnl_ingresar.Controls.Add(Me.txt_ci)
        Me.pnl_ingresar.Controls.Add(Me.lbl_a)
        Me.pnl_ingresar.Controls.Add(Me.dtp_rangoSalida)
        Me.pnl_ingresar.Controls.Add(Me.dtp_rangoEntrada)
        Me.pnl_ingresar.Controls.Add(Me.dtp_horaSalida)
        Me.pnl_ingresar.Controls.Add(Me.dtp_horaEntrada)
        Me.pnl_ingresar.Controls.Add(Me.rdb_dF)
        Me.pnl_ingresar.Controls.Add(Me.rdb_sF)
        Me.pnl_ingresar.Controls.Add(Me.rdb_vF)
        Me.pnl_ingresar.Controls.Add(Me.rdb_jF)
        Me.pnl_ingresar.Controls.Add(Me.rdb_xF)
        Me.pnl_ingresar.Controls.Add(Me.rdb_mF)
        Me.pnl_ingresar.Controls.Add(Me.rdb_lF)
        Me.pnl_ingresar.Controls.Add(Me.rdb_d)
        Me.pnl_ingresar.Controls.Add(Me.rdb_s)
        Me.pnl_ingresar.Controls.Add(Me.rdb_v)
        Me.pnl_ingresar.Controls.Add(Me.rdb_j)
        Me.pnl_ingresar.Controls.Add(Me.rdb_x)
        Me.pnl_ingresar.Controls.Add(Me.rdb_m)
        Me.pnl_ingresar.Controls.Add(Me.rdb_l)
        Me.pnl_ingresar.Controls.Add(Me.btn_filtrar)
        Me.pnl_ingresar.Controls.Add(Me.btn_ingresar)
        Me.pnl_ingresar.Controls.Add(Me.btn_volver)
        Me.pnl_ingresar.Controls.Add(Me.lbl_rango)
        Me.pnl_ingresar.Controls.Add(Me.lbl_diasB)
        Me.pnl_ingresar.Controls.Add(Me.lbl_sucursalB)
        Me.pnl_ingresar.Controls.Add(Me.lbl_busqueda)
        Me.pnl_ingresar.Controls.Add(Me.lbl_horaSalida)
        Me.pnl_ingresar.Controls.Add(Me.lbl_horaEntrada)
        Me.pnl_ingresar.Controls.Add(Me.lbl_dias)
        Me.pnl_ingresar.Controls.Add(Me.lbl_sucursal)
        Me.pnl_ingresar.Controls.Add(Me.lbl_ingresoHorarios)
        Me.pnl_ingresar.Controls.Add(Me.lbl_ci)
        Me.pnl_ingresar.Controls.Add(Me.lbl_profesional)
        Me.pnl_ingresar.Location = New System.Drawing.Point(0, 0)
        Me.pnl_ingresar.Name = "pnl_ingresar"
        Me.pnl_ingresar.Size = New System.Drawing.Size(573, 1080)
        Me.pnl_ingresar.TabIndex = 0
        '
        'cmb_sucursalF
        '
        Me.cmb_sucursalF.FormattingEnabled = True
        Me.cmb_sucursalF.Location = New System.Drawing.Point(172, 474)
        Me.cmb_sucursalF.Name = "cmb_sucursalF"
        Me.cmb_sucursalF.Size = New System.Drawing.Size(317, 21)
        Me.cmb_sucursalF.TabIndex = 35
        '
        'cmb_sucursal
        '
        Me.cmb_sucursal.FormattingEnabled = True
        Me.cmb_sucursal.Location = New System.Drawing.Point(172, 224)
        Me.cmb_sucursal.Name = "cmb_sucursal"
        Me.cmb_sucursal.Size = New System.Drawing.Size(317, 21)
        Me.cmb_sucursal.TabIndex = 34
        '
        'txt_ci
        '
        Me.txt_ci.Location = New System.Drawing.Point(123, 130)
        Me.txt_ci.Name = "txt_ci"
        Me.txt_ci.Size = New System.Drawing.Size(366, 20)
        Me.txt_ci.TabIndex = 33
        '
        'lbl_a
        '
        Me.lbl_a.AutoSize = True
        Me.lbl_a.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_a.Location = New System.Drawing.Point(340, 558)
        Me.lbl_a.Name = "lbl_a"
        Me.lbl_a.Size = New System.Drawing.Size(22, 25)
        Me.lbl_a.TabIndex = 32
        Me.lbl_a.Text = "a"
        '
        'dtp_rangoSalida
        '
        Me.dtp_rangoSalida.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtp_rangoSalida.Location = New System.Drawing.Point(368, 561)
        Me.dtp_rangoSalida.Name = "dtp_rangoSalida"
        Me.dtp_rangoSalida.Size = New System.Drawing.Size(123, 20)
        Me.dtp_rangoSalida.TabIndex = 31
        '
        'dtp_rangoEntrada
        '
        Me.dtp_rangoEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtp_rangoEntrada.Location = New System.Drawing.Point(222, 561)
        Me.dtp_rangoEntrada.Name = "dtp_rangoEntrada"
        Me.dtp_rangoEntrada.Size = New System.Drawing.Size(112, 20)
        Me.dtp_rangoEntrada.TabIndex = 30
        '
        'dtp_horaSalida
        '
        Me.dtp_horaSalida.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtp_horaSalida.Location = New System.Drawing.Point(234, 335)
        Me.dtp_horaSalida.Name = "dtp_horaSalida"
        Me.dtp_horaSalida.Size = New System.Drawing.Size(255, 20)
        Me.dtp_horaSalida.TabIndex = 29
        '
        'dtp_horaEntrada
        '
        Me.dtp_horaEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtp_horaEntrada.Location = New System.Drawing.Point(234, 294)
        Me.dtp_horaEntrada.Name = "dtp_horaEntrada"
        Me.dtp_horaEntrada.Size = New System.Drawing.Size(255, 20)
        Me.dtp_horaEntrada.TabIndex = 28
        '
        'rdb_dF
        '
        Me.rdb_dF.AutoSize = True
        Me.rdb_dF.Location = New System.Drawing.Point(456, 520)
        Me.rdb_dF.Name = "rdb_dF"
        Me.rdb_dF.Size = New System.Drawing.Size(33, 17)
        Me.rdb_dF.TabIndex = 27
        Me.rdb_dF.TabStop = True
        Me.rdb_dF.Text = "D"
        Me.rdb_dF.UseVisualStyleBackColor = True
        '
        'rdb_sF
        '
        Me.rdb_sF.AutoSize = True
        Me.rdb_sF.Location = New System.Drawing.Point(419, 520)
        Me.rdb_sF.Name = "rdb_sF"
        Me.rdb_sF.Size = New System.Drawing.Size(32, 17)
        Me.rdb_sF.TabIndex = 26
        Me.rdb_sF.TabStop = True
        Me.rdb_sF.Text = "S"
        Me.rdb_sF.UseVisualStyleBackColor = True
        '
        'rdb_vF
        '
        Me.rdb_vF.AutoSize = True
        Me.rdb_vF.Location = New System.Drawing.Point(382, 521)
        Me.rdb_vF.Name = "rdb_vF"
        Me.rdb_vF.Size = New System.Drawing.Size(32, 17)
        Me.rdb_vF.TabIndex = 25
        Me.rdb_vF.TabStop = True
        Me.rdb_vF.Text = "V"
        Me.rdb_vF.UseVisualStyleBackColor = True
        '
        'rdb_jF
        '
        Me.rdb_jF.AutoSize = True
        Me.rdb_jF.Location = New System.Drawing.Point(345, 521)
        Me.rdb_jF.Name = "rdb_jF"
        Me.rdb_jF.Size = New System.Drawing.Size(30, 17)
        Me.rdb_jF.TabIndex = 24
        Me.rdb_jF.TabStop = True
        Me.rdb_jF.Text = "J"
        Me.rdb_jF.UseVisualStyleBackColor = True
        '
        'rdb_xF
        '
        Me.rdb_xF.AutoSize = True
        Me.rdb_xF.Location = New System.Drawing.Point(308, 520)
        Me.rdb_xF.Name = "rdb_xF"
        Me.rdb_xF.Size = New System.Drawing.Size(32, 17)
        Me.rdb_xF.TabIndex = 23
        Me.rdb_xF.TabStop = True
        Me.rdb_xF.Text = "X"
        Me.rdb_xF.UseVisualStyleBackColor = True
        '
        'rdb_mF
        '
        Me.rdb_mF.AutoSize = True
        Me.rdb_mF.Location = New System.Drawing.Point(271, 521)
        Me.rdb_mF.Name = "rdb_mF"
        Me.rdb_mF.Size = New System.Drawing.Size(34, 17)
        Me.rdb_mF.TabIndex = 22
        Me.rdb_mF.TabStop = True
        Me.rdb_mF.Text = "M"
        Me.rdb_mF.UseVisualStyleBackColor = True
        '
        'rdb_lF
        '
        Me.rdb_lF.AutoSize = True
        Me.rdb_lF.Location = New System.Drawing.Point(234, 520)
        Me.rdb_lF.Name = "rdb_lF"
        Me.rdb_lF.Size = New System.Drawing.Size(31, 17)
        Me.rdb_lF.TabIndex = 21
        Me.rdb_lF.TabStop = True
        Me.rdb_lF.Text = "L"
        Me.rdb_lF.UseVisualStyleBackColor = True
        '
        'rdb_d
        '
        Me.rdb_d.AutoSize = True
        Me.rdb_d.Location = New System.Drawing.Point(456, 259)
        Me.rdb_d.Name = "rdb_d"
        Me.rdb_d.Size = New System.Drawing.Size(33, 17)
        Me.rdb_d.TabIndex = 20
        Me.rdb_d.TabStop = True
        Me.rdb_d.Text = "D"
        Me.rdb_d.UseVisualStyleBackColor = True
        '
        'rdb_s
        '
        Me.rdb_s.AutoSize = True
        Me.rdb_s.Location = New System.Drawing.Point(419, 259)
        Me.rdb_s.Name = "rdb_s"
        Me.rdb_s.Size = New System.Drawing.Size(32, 17)
        Me.rdb_s.TabIndex = 19
        Me.rdb_s.TabStop = True
        Me.rdb_s.Text = "S"
        Me.rdb_s.UseVisualStyleBackColor = True
        '
        'rdb_v
        '
        Me.rdb_v.AutoSize = True
        Me.rdb_v.Location = New System.Drawing.Point(382, 260)
        Me.rdb_v.Name = "rdb_v"
        Me.rdb_v.Size = New System.Drawing.Size(32, 17)
        Me.rdb_v.TabIndex = 18
        Me.rdb_v.TabStop = True
        Me.rdb_v.Text = "V"
        Me.rdb_v.UseVisualStyleBackColor = True
        '
        'rdb_j
        '
        Me.rdb_j.AutoSize = True
        Me.rdb_j.Location = New System.Drawing.Point(345, 260)
        Me.rdb_j.Name = "rdb_j"
        Me.rdb_j.Size = New System.Drawing.Size(30, 17)
        Me.rdb_j.TabIndex = 17
        Me.rdb_j.TabStop = True
        Me.rdb_j.Text = "J"
        Me.rdb_j.UseVisualStyleBackColor = True
        '
        'rdb_x
        '
        Me.rdb_x.AutoSize = True
        Me.rdb_x.Location = New System.Drawing.Point(308, 259)
        Me.rdb_x.Name = "rdb_x"
        Me.rdb_x.Size = New System.Drawing.Size(32, 17)
        Me.rdb_x.TabIndex = 16
        Me.rdb_x.TabStop = True
        Me.rdb_x.Text = "X"
        Me.rdb_x.UseVisualStyleBackColor = True
        '
        'rdb_m
        '
        Me.rdb_m.AutoSize = True
        Me.rdb_m.Location = New System.Drawing.Point(271, 260)
        Me.rdb_m.Name = "rdb_m"
        Me.rdb_m.Size = New System.Drawing.Size(34, 17)
        Me.rdb_m.TabIndex = 15
        Me.rdb_m.TabStop = True
        Me.rdb_m.Text = "M"
        Me.rdb_m.UseVisualStyleBackColor = True
        '
        'rdb_l
        '
        Me.rdb_l.AutoSize = True
        Me.rdb_l.Location = New System.Drawing.Point(234, 259)
        Me.rdb_l.Name = "rdb_l"
        Me.rdb_l.Size = New System.Drawing.Size(31, 17)
        Me.rdb_l.TabIndex = 14
        Me.rdb_l.TabStop = True
        Me.rdb_l.Text = "L"
        Me.rdb_l.UseVisualStyleBackColor = True
        '
        'btn_filtrar
        '
        Me.btn_filtrar.FlatAppearance.BorderSize = 0
        Me.btn_filtrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_filtrar.Image = Global.Presentacion.My.Resources.Resources.btn_filtrar
        Me.btn_filtrar.Location = New System.Drawing.Point(332, 605)
        Me.btn_filtrar.Name = "btn_filtrar"
        Me.btn_filtrar.Size = New System.Drawing.Size(157, 64)
        Me.btn_filtrar.TabIndex = 13
        Me.btn_filtrar.UseVisualStyleBackColor = True
        '
        'btn_ingresar
        '
        Me.btn_ingresar.FlatAppearance.BorderSize = 0
        Me.btn_ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ingresar.Image = Global.Presentacion.My.Resources.Resources.Ingresar_Button
        Me.btn_ingresar.Location = New System.Drawing.Point(332, 362)
        Me.btn_ingresar.Name = "btn_ingresar"
        Me.btn_ingresar.Size = New System.Drawing.Size(159, 61)
        Me.btn_ingresar.TabIndex = 12
        Me.btn_ingresar.UseVisualStyleBackColor = True
        '
        'btn_volver
        '
        Me.btn_volver.FlatAppearance.BorderSize = 0
        Me.btn_volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_volver.Image = Global.Presentacion.My.Resources.Resources.btn_volver_85x30
        Me.btn_volver.Location = New System.Drawing.Point(12, 12)
        Me.btn_volver.Name = "btn_volver"
        Me.btn_volver.Size = New System.Drawing.Size(91, 40)
        Me.btn_volver.TabIndex = 11
        Me.btn_volver.UseVisualStyleBackColor = True
        '
        'lbl_rango
        '
        Me.lbl_rango.AutoSize = True
        Me.lbl_rango.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_rango.Location = New System.Drawing.Point(79, 556)
        Me.lbl_rango.Name = "lbl_rango"
        Me.lbl_rango.Size = New System.Drawing.Size(137, 25)
        Me.lbl_rango.TabIndex = 10
        Me.lbl_rango.Text = "Rango horario:"
        '
        'lbl_diasB
        '
        Me.lbl_diasB.AutoSize = True
        Me.lbl_diasB.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_diasB.Location = New System.Drawing.Point(79, 513)
        Me.lbl_diasB.Name = "lbl_diasB"
        Me.lbl_diasB.Size = New System.Drawing.Size(148, 25)
        Me.lbl_diasB.TabIndex = 9
        Me.lbl_diasB.Text = "Días de guardia:"
        '
        'lbl_sucursalB
        '
        Me.lbl_sucursalB.AutoSize = True
        Me.lbl_sucursalB.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_sucursalB.Location = New System.Drawing.Point(79, 474)
        Me.lbl_sucursalB.Name = "lbl_sucursalB"
        Me.lbl_sucursalB.Size = New System.Drawing.Size(87, 25)
        Me.lbl_sucursalB.TabIndex = 8
        Me.lbl_sucursalB.Text = "Sucursal:"
        '
        'lbl_busqueda
        '
        Me.lbl_busqueda.AutoSize = True
        Me.lbl_busqueda.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_busqueda.Location = New System.Drawing.Point(64, 432)
        Me.lbl_busqueda.Name = "lbl_busqueda"
        Me.lbl_busqueda.Size = New System.Drawing.Size(100, 25)
        Me.lbl_busqueda.TabIndex = 7
        Me.lbl_busqueda.Text = "Búsqueda"
        '
        'lbl_horaSalida
        '
        Me.lbl_horaSalida.AutoSize = True
        Me.lbl_horaSalida.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_horaSalida.Location = New System.Drawing.Point(79, 330)
        Me.lbl_horaSalida.Name = "lbl_horaSalida"
        Me.lbl_horaSalida.Size = New System.Drawing.Size(111, 25)
        Me.lbl_horaSalida.TabIndex = 6
        Me.lbl_horaSalida.Text = "Hora salida:"
        '
        'lbl_horaEntrada
        '
        Me.lbl_horaEntrada.AutoSize = True
        Me.lbl_horaEntrada.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_horaEntrada.Location = New System.Drawing.Point(79, 290)
        Me.lbl_horaEntrada.Name = "lbl_horaEntrada"
        Me.lbl_horaEntrada.Size = New System.Drawing.Size(127, 25)
        Me.lbl_horaEntrada.TabIndex = 5
        Me.lbl_horaEntrada.Text = "Hora entrada:"
        '
        'lbl_dias
        '
        Me.lbl_dias.AutoSize = True
        Me.lbl_dias.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_dias.Location = New System.Drawing.Point(79, 252)
        Me.lbl_dias.Name = "lbl_dias"
        Me.lbl_dias.Size = New System.Drawing.Size(148, 25)
        Me.lbl_dias.TabIndex = 4
        Me.lbl_dias.Text = "Días de guardia:"
        '
        'lbl_sucursal
        '
        Me.lbl_sucursal.AutoSize = True
        Me.lbl_sucursal.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_sucursal.Location = New System.Drawing.Point(79, 218)
        Me.lbl_sucursal.Name = "lbl_sucursal"
        Me.lbl_sucursal.Size = New System.Drawing.Size(87, 25)
        Me.lbl_sucursal.TabIndex = 3
        Me.lbl_sucursal.Text = "Sucursal:"
        '
        'lbl_ingresoHorarios
        '
        Me.lbl_ingresoHorarios.AutoSize = True
        Me.lbl_ingresoHorarios.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ingresoHorarios.Location = New System.Drawing.Point(67, 179)
        Me.lbl_ingresoHorarios.Name = "lbl_ingresoHorarios"
        Me.lbl_ingresoHorarios.Size = New System.Drawing.Size(190, 25)
        Me.lbl_ingresoHorarios.TabIndex = 2
        Me.lbl_ingresoHorarios.Text = "Ingreso de Horarios"
        '
        'lbl_ci
        '
        Me.lbl_ci.AutoSize = True
        Me.lbl_ci.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ci.Location = New System.Drawing.Point(79, 126)
        Me.lbl_ci.Name = "lbl_ci"
        Me.lbl_ci.Size = New System.Drawing.Size(37, 25)
        Me.lbl_ci.TabIndex = 1
        Me.lbl_ci.Text = "C.I:"
        '
        'lbl_profesional
        '
        Me.lbl_profesional.AutoSize = True
        Me.lbl_profesional.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_profesional.Location = New System.Drawing.Point(67, 94)
        Me.lbl_profesional.Name = "lbl_profesional"
        Me.lbl_profesional.Size = New System.Drawing.Size(168, 25)
        Me.lbl_profesional.TabIndex = 0
        Me.lbl_profesional.Text = "CI del Profesional"
        '
        'F_Medicos_Horarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1920, 1080)
        Me.Controls.Add(Me.pnl_fondo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "F_Medicos_Horarios"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnl_fondo.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_ingresar.ResumeLayout(False)
        Me.pnl_ingresar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnl_fondo As Panel
    Friend WithEvents pnl_ingresar As Panel
    Friend WithEvents lbl_rango As Label
    Friend WithEvents lbl_diasB As Label
    Friend WithEvents lbl_sucursalB As Label
    Friend WithEvents lbl_busqueda As Label
    Friend WithEvents lbl_horaSalida As Label
    Friend WithEvents lbl_horaEntrada As Label
    Friend WithEvents lbl_dias As Label
    Friend WithEvents lbl_sucursal As Label
    Friend WithEvents lbl_ingresoHorarios As Label
    Friend WithEvents lbl_ci As Label
    Friend WithEvents lbl_profesional As Label
    Friend WithEvents btn_minimizar As Button
    Friend WithEvents btn_cerrar As Button
    Friend WithEvents btn_filtrar As Button
    Friend WithEvents btn_ingresar As Button
    Friend WithEvents btn_volver As Button
    Friend WithEvents rdb_d As RadioButton
    Friend WithEvents rdb_s As RadioButton
    Friend WithEvents rdb_v As RadioButton
    Friend WithEvents rdb_j As RadioButton
    Friend WithEvents rdb_x As RadioButton
    Friend WithEvents rdb_m As RadioButton
    Friend WithEvents rdb_l As RadioButton
    Friend WithEvents cmb_sucursalF As ComboBox
    Friend WithEvents cmb_sucursal As ComboBox
    Friend WithEvents txt_ci As TextBox
    Friend WithEvents lbl_a As Label
    Friend WithEvents dtp_rangoSalida As DateTimePicker
    Friend WithEvents dtp_rangoEntrada As DateTimePicker
    Friend WithEvents dtp_horaSalida As DateTimePicker
    Friend WithEvents dtp_horaEntrada As DateTimePicker
    Friend WithEvents rdb_dF As RadioButton
    Friend WithEvents rdb_sF As RadioButton
    Friend WithEvents rdb_vF As RadioButton
    Friend WithEvents rdb_jF As RadioButton
    Friend WithEvents rdb_xF As RadioButton
    Friend WithEvents rdb_mF As RadioButton
    Friend WithEvents rdb_lF As RadioButton
    Friend WithEvents DataGridView1 As DataGridView
End Class
