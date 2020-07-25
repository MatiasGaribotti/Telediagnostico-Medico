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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnl_fondo = New System.Windows.Forms.Panel()
        Me.gbtn_nPassw = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_cerrar = New System.Windows.Forms.Button()
        Me.gbtn_ingresar = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_minimizar = New System.Windows.Forms.Button()
        Me.pnl_ingresarFiltrar = New System.Windows.Forms.Panel()
        Me.cbtn_menosEspecialidades = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.cbtn_masEspecialidades = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.dtp_fechaNac = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.cmb_detallesI = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cmb_departamentoI = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cmb_especialidadI = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cmb_especialidadF = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cmb_sucursalesF = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtb_telI = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtb_numPuertaI = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtb_direccionI = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtb_localidadI = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtb_apellidoPI = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtb_apellidoMI = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtb_apellidoPF = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtb_apellidoMF = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtb_ciI = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtb_nombresI = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtb_nombresF = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtb_ciF = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btn_filtrar = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_ingresar = New System.Windows.Forms.Button()
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
        Me.dgv_medicos = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.pnl_fondo.SuspendLayout()
        Me.pnl_ingresarFiltrar.SuspendLayout()
        CType(Me.dgv_medicos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl_fondo
        '
        Me.pnl_fondo.Controls.Add(Me.gbtn_nPassw)
        Me.pnl_fondo.Controls.Add(Me.btn_cerrar)
        Me.pnl_fondo.Controls.Add(Me.gbtn_ingresar)
        Me.pnl_fondo.Controls.Add(Me.btn_minimizar)
        Me.pnl_fondo.Controls.Add(Me.pnl_ingresarFiltrar)
        Me.pnl_fondo.Controls.Add(Me.dgv_medicos)
        resources.ApplyResources(Me.pnl_fondo, "pnl_fondo")
        Me.pnl_fondo.Name = "pnl_fondo"
        '
        'gbtn_nPassw
        '
        Me.gbtn_nPassw.Animated = True
        Me.gbtn_nPassw.BackColor = System.Drawing.Color.Transparent
        Me.gbtn_nPassw.BorderRadius = 26
        Me.gbtn_nPassw.CheckedState.Parent = Me.gbtn_nPassw
        Me.gbtn_nPassw.CustomImages.Parent = Me.gbtn_nPassw
        Me.gbtn_nPassw.FillColor = System.Drawing.Color.DarkCyan
        resources.ApplyResources(Me.gbtn_nPassw, "gbtn_nPassw")
        Me.gbtn_nPassw.ForeColor = System.Drawing.Color.White
        Me.gbtn_nPassw.HoverState.Parent = Me.gbtn_nPassw
        Me.gbtn_nPassw.Name = "gbtn_nPassw"
        Me.gbtn_nPassw.ShadowDecoration.Enabled = True
        Me.gbtn_nPassw.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.gbtn_nPassw.ShadowDecoration.Parent = Me.gbtn_nPassw
        '
        'btn_cerrar
        '
        Me.btn_cerrar.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.btn_cerrar, "btn_cerrar")
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.UseVisualStyleBackColor = True
        '
        'gbtn_ingresar
        '
        Me.gbtn_ingresar.Animated = True
        Me.gbtn_ingresar.BackColor = System.Drawing.Color.Transparent
        Me.gbtn_ingresar.BorderRadius = 26
        Me.gbtn_ingresar.CheckedState.Parent = Me.gbtn_ingresar
        Me.gbtn_ingresar.CustomImages.Parent = Me.gbtn_ingresar
        Me.gbtn_ingresar.FillColor = System.Drawing.Color.DarkCyan
        resources.ApplyResources(Me.gbtn_ingresar, "gbtn_ingresar")
        Me.gbtn_ingresar.ForeColor = System.Drawing.Color.White
        Me.gbtn_ingresar.HoverState.Parent = Me.gbtn_ingresar
        Me.gbtn_ingresar.Name = "gbtn_ingresar"
        Me.gbtn_ingresar.ShadowDecoration.Enabled = True
        Me.gbtn_ingresar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.gbtn_ingresar.ShadowDecoration.Parent = Me.gbtn_ingresar
        '
        'btn_minimizar
        '
        Me.btn_minimizar.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.btn_minimizar, "btn_minimizar")
        Me.btn_minimizar.Name = "btn_minimizar"
        Me.btn_minimizar.UseVisualStyleBackColor = True
        '
        'pnl_ingresarFiltrar
        '
        Me.pnl_ingresarFiltrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.pnl_ingresarFiltrar.Controls.Add(Me.cbtn_menosEspecialidades)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.cbtn_masEspecialidades)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.dtp_fechaNac)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.cmb_detallesI)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.cmb_departamentoI)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.cmb_especialidadI)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.cmb_especialidadF)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.cmb_sucursalesF)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.txtb_telI)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.txtb_numPuertaI)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.txtb_direccionI)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.txtb_localidadI)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.txtb_apellidoPI)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.txtb_apellidoMI)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.txtb_apellidoPF)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.txtb_apellidoMF)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.txtb_ciI)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.txtb_nombresI)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.txtb_nombresF)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.txtb_ciF)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.btn_filtrar)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.Guna2Button1)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.btn_ingresar)
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
        resources.ApplyResources(Me.pnl_ingresarFiltrar, "pnl_ingresarFiltrar")
        Me.pnl_ingresarFiltrar.Name = "pnl_ingresarFiltrar"
        '
        'cbtn_menosEspecialidades
        '
        Me.cbtn_menosEspecialidades.CheckedState.Parent = Me.cbtn_menosEspecialidades
        Me.cbtn_menosEspecialidades.CustomImages.Parent = Me.cbtn_menosEspecialidades
        Me.cbtn_menosEspecialidades.FillColor = System.Drawing.Color.DarkCyan
        resources.ApplyResources(Me.cbtn_menosEspecialidades, "cbtn_menosEspecialidades")
        Me.cbtn_menosEspecialidades.ForeColor = System.Drawing.Color.White
        Me.cbtn_menosEspecialidades.HoverState.Parent = Me.cbtn_menosEspecialidades
        Me.cbtn_menosEspecialidades.Name = "cbtn_menosEspecialidades"
        Me.cbtn_menosEspecialidades.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.cbtn_menosEspecialidades.ShadowDecoration.Parent = Me.cbtn_menosEspecialidades
        '
        'cbtn_masEspecialidades
        '
        Me.cbtn_masEspecialidades.CheckedState.Parent = Me.cbtn_masEspecialidades
        Me.cbtn_masEspecialidades.CustomImages.Parent = Me.cbtn_masEspecialidades
        Me.cbtn_masEspecialidades.FillColor = System.Drawing.Color.DarkCyan
        resources.ApplyResources(Me.cbtn_masEspecialidades, "cbtn_masEspecialidades")
        Me.cbtn_masEspecialidades.ForeColor = System.Drawing.Color.White
        Me.cbtn_masEspecialidades.HoverState.Parent = Me.cbtn_masEspecialidades
        Me.cbtn_masEspecialidades.Name = "cbtn_masEspecialidades"
        Me.cbtn_masEspecialidades.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.cbtn_masEspecialidades.ShadowDecoration.Parent = Me.cbtn_masEspecialidades
        '
        'dtp_fechaNac
        '
        Me.dtp_fechaNac.Animated = True
        Me.dtp_fechaNac.BorderRadius = 6
        Me.dtp_fechaNac.CheckedState.Parent = Me.dtp_fechaNac
        Me.dtp_fechaNac.FillColor = System.Drawing.Color.White
        resources.ApplyResources(Me.dtp_fechaNac, "dtp_fechaNac")
        Me.dtp_fechaNac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fechaNac.HoverState.Parent = Me.dtp_fechaNac
        Me.dtp_fechaNac.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtp_fechaNac.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtp_fechaNac.Name = "dtp_fechaNac"
        Me.dtp_fechaNac.ShadowDecoration.Parent = Me.dtp_fechaNac
        Me.dtp_fechaNac.Value = New Date(2020, 7, 24, 5, 29, 51, 255)
        '
        'cmb_detallesI
        '
        Me.cmb_detallesI.BackColor = System.Drawing.Color.Transparent
        Me.cmb_detallesI.BorderRadius = 6
        Me.cmb_detallesI.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_detallesI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_detallesI.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_detallesI.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_detallesI.FocusedState.Parent = Me.cmb_detallesI
        resources.ApplyResources(Me.cmb_detallesI, "cmb_detallesI")
        Me.cmb_detallesI.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmb_detallesI.HoverState.Parent = Me.cmb_detallesI
        Me.cmb_detallesI.ItemsAppearance.Parent = Me.cmb_detallesI
        Me.cmb_detallesI.Name = "cmb_detallesI"
        Me.cmb_detallesI.ShadowDecoration.Parent = Me.cmb_detallesI
        '
        'cmb_departamentoI
        '
        Me.cmb_departamentoI.BackColor = System.Drawing.Color.Transparent
        Me.cmb_departamentoI.BorderRadius = 6
        Me.cmb_departamentoI.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_departamentoI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_departamentoI.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_departamentoI.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_departamentoI.FocusedState.Parent = Me.cmb_departamentoI
        resources.ApplyResources(Me.cmb_departamentoI, "cmb_departamentoI")
        Me.cmb_departamentoI.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmb_departamentoI.HoverState.Parent = Me.cmb_departamentoI
        Me.cmb_departamentoI.ItemsAppearance.Parent = Me.cmb_departamentoI
        Me.cmb_departamentoI.Name = "cmb_departamentoI"
        Me.cmb_departamentoI.ShadowDecoration.Parent = Me.cmb_departamentoI
        '
        'cmb_especialidadI
        '
        Me.cmb_especialidadI.BackColor = System.Drawing.Color.Transparent
        Me.cmb_especialidadI.BorderRadius = 6
        Me.cmb_especialidadI.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_especialidadI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_especialidadI.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_especialidadI.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_especialidadI.FocusedState.Parent = Me.cmb_especialidadI
        resources.ApplyResources(Me.cmb_especialidadI, "cmb_especialidadI")
        Me.cmb_especialidadI.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmb_especialidadI.HoverState.Parent = Me.cmb_especialidadI
        Me.cmb_especialidadI.ItemsAppearance.Parent = Me.cmb_especialidadI
        Me.cmb_especialidadI.Name = "cmb_especialidadI"
        Me.cmb_especialidadI.ShadowDecoration.Parent = Me.cmb_especialidadI
        '
        'cmb_especialidadF
        '
        Me.cmb_especialidadF.BackColor = System.Drawing.Color.Transparent
        Me.cmb_especialidadF.BorderRadius = 6
        Me.cmb_especialidadF.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_especialidadF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_especialidadF.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_especialidadF.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_especialidadF.FocusedState.Parent = Me.cmb_especialidadF
        resources.ApplyResources(Me.cmb_especialidadF, "cmb_especialidadF")
        Me.cmb_especialidadF.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmb_especialidadF.HoverState.Parent = Me.cmb_especialidadF
        Me.cmb_especialidadF.ItemsAppearance.Parent = Me.cmb_especialidadF
        Me.cmb_especialidadF.Name = "cmb_especialidadF"
        Me.cmb_especialidadF.ShadowDecoration.Parent = Me.cmb_especialidadF
        '
        'cmb_sucursalesF
        '
        Me.cmb_sucursalesF.BackColor = System.Drawing.Color.Transparent
        Me.cmb_sucursalesF.BorderRadius = 6
        Me.cmb_sucursalesF.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_sucursalesF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_sucursalesF.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_sucursalesF.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_sucursalesF.FocusedState.Parent = Me.cmb_sucursalesF
        resources.ApplyResources(Me.cmb_sucursalesF, "cmb_sucursalesF")
        Me.cmb_sucursalesF.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmb_sucursalesF.HoverState.Parent = Me.cmb_sucursalesF
        Me.cmb_sucursalesF.ItemsAppearance.Parent = Me.cmb_sucursalesF
        Me.cmb_sucursalesF.Name = "cmb_sucursalesF"
        Me.cmb_sucursalesF.ShadowDecoration.Parent = Me.cmb_sucursalesF
        '
        'txtb_telI
        '
        Me.txtb_telI.BorderRadius = 6
        Me.txtb_telI.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtb_telI.DefaultText = ""
        Me.txtb_telI.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtb_telI.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtb_telI.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtb_telI.DisabledState.Parent = Me.txtb_telI
        Me.txtb_telI.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtb_telI.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtb_telI.FocusedState.Parent = Me.txtb_telI
        resources.ApplyResources(Me.txtb_telI, "txtb_telI")
        Me.txtb_telI.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtb_telI.HoverState.Parent = Me.txtb_telI
        Me.txtb_telI.Name = "txtb_telI"
        Me.txtb_telI.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtb_telI.PlaceholderText = ""
        Me.txtb_telI.SelectedText = ""
        Me.txtb_telI.ShadowDecoration.Parent = Me.txtb_telI
        '
        'txtb_numPuertaI
        '
        Me.txtb_numPuertaI.BorderRadius = 6
        Me.txtb_numPuertaI.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtb_numPuertaI.DefaultText = ""
        Me.txtb_numPuertaI.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtb_numPuertaI.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtb_numPuertaI.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtb_numPuertaI.DisabledState.Parent = Me.txtb_numPuertaI
        Me.txtb_numPuertaI.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtb_numPuertaI.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtb_numPuertaI.FocusedState.Parent = Me.txtb_numPuertaI
        resources.ApplyResources(Me.txtb_numPuertaI, "txtb_numPuertaI")
        Me.txtb_numPuertaI.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtb_numPuertaI.HoverState.Parent = Me.txtb_numPuertaI
        Me.txtb_numPuertaI.Name = "txtb_numPuertaI"
        Me.txtb_numPuertaI.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtb_numPuertaI.PlaceholderText = ""
        Me.txtb_numPuertaI.SelectedText = ""
        Me.txtb_numPuertaI.ShadowDecoration.Parent = Me.txtb_numPuertaI
        '
        'txtb_direccionI
        '
        Me.txtb_direccionI.BorderRadius = 6
        Me.txtb_direccionI.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtb_direccionI.DefaultText = ""
        Me.txtb_direccionI.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtb_direccionI.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtb_direccionI.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtb_direccionI.DisabledState.Parent = Me.txtb_direccionI
        Me.txtb_direccionI.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtb_direccionI.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtb_direccionI.FocusedState.Parent = Me.txtb_direccionI
        resources.ApplyResources(Me.txtb_direccionI, "txtb_direccionI")
        Me.txtb_direccionI.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtb_direccionI.HoverState.Parent = Me.txtb_direccionI
        Me.txtb_direccionI.Name = "txtb_direccionI"
        Me.txtb_direccionI.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtb_direccionI.PlaceholderText = ""
        Me.txtb_direccionI.SelectedText = ""
        Me.txtb_direccionI.ShadowDecoration.Parent = Me.txtb_direccionI
        '
        'txtb_localidadI
        '
        Me.txtb_localidadI.BorderRadius = 6
        Me.txtb_localidadI.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtb_localidadI.DefaultText = ""
        Me.txtb_localidadI.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtb_localidadI.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtb_localidadI.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtb_localidadI.DisabledState.Parent = Me.txtb_localidadI
        Me.txtb_localidadI.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtb_localidadI.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtb_localidadI.FocusedState.Parent = Me.txtb_localidadI
        resources.ApplyResources(Me.txtb_localidadI, "txtb_localidadI")
        Me.txtb_localidadI.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtb_localidadI.HoverState.Parent = Me.txtb_localidadI
        Me.txtb_localidadI.Name = "txtb_localidadI"
        Me.txtb_localidadI.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtb_localidadI.PlaceholderText = ""
        Me.txtb_localidadI.SelectedText = ""
        Me.txtb_localidadI.ShadowDecoration.Parent = Me.txtb_localidadI
        '
        'txtb_apellidoPI
        '
        Me.txtb_apellidoPI.BorderRadius = 6
        Me.txtb_apellidoPI.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtb_apellidoPI.DefaultText = ""
        Me.txtb_apellidoPI.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtb_apellidoPI.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtb_apellidoPI.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtb_apellidoPI.DisabledState.Parent = Me.txtb_apellidoPI
        Me.txtb_apellidoPI.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtb_apellidoPI.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtb_apellidoPI.FocusedState.Parent = Me.txtb_apellidoPI
        resources.ApplyResources(Me.txtb_apellidoPI, "txtb_apellidoPI")
        Me.txtb_apellidoPI.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtb_apellidoPI.HoverState.Parent = Me.txtb_apellidoPI
        Me.txtb_apellidoPI.Name = "txtb_apellidoPI"
        Me.txtb_apellidoPI.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtb_apellidoPI.PlaceholderText = ""
        Me.txtb_apellidoPI.SelectedText = ""
        Me.txtb_apellidoPI.ShadowDecoration.Parent = Me.txtb_apellidoPI
        '
        'txtb_apellidoMI
        '
        Me.txtb_apellidoMI.BorderRadius = 6
        Me.txtb_apellidoMI.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtb_apellidoMI.DefaultText = ""
        Me.txtb_apellidoMI.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtb_apellidoMI.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtb_apellidoMI.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtb_apellidoMI.DisabledState.Parent = Me.txtb_apellidoMI
        Me.txtb_apellidoMI.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtb_apellidoMI.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtb_apellidoMI.FocusedState.Parent = Me.txtb_apellidoMI
        resources.ApplyResources(Me.txtb_apellidoMI, "txtb_apellidoMI")
        Me.txtb_apellidoMI.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtb_apellidoMI.HoverState.Parent = Me.txtb_apellidoMI
        Me.txtb_apellidoMI.Name = "txtb_apellidoMI"
        Me.txtb_apellidoMI.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtb_apellidoMI.PlaceholderText = ""
        Me.txtb_apellidoMI.SelectedText = ""
        Me.txtb_apellidoMI.ShadowDecoration.Parent = Me.txtb_apellidoMI
        '
        'txtb_apellidoPF
        '
        Me.txtb_apellidoPF.BorderRadius = 6
        Me.txtb_apellidoPF.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtb_apellidoPF.DefaultText = ""
        Me.txtb_apellidoPF.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtb_apellidoPF.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtb_apellidoPF.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtb_apellidoPF.DisabledState.Parent = Me.txtb_apellidoPF
        Me.txtb_apellidoPF.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtb_apellidoPF.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtb_apellidoPF.FocusedState.Parent = Me.txtb_apellidoPF
        resources.ApplyResources(Me.txtb_apellidoPF, "txtb_apellidoPF")
        Me.txtb_apellidoPF.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtb_apellidoPF.HoverState.Parent = Me.txtb_apellidoPF
        Me.txtb_apellidoPF.Name = "txtb_apellidoPF"
        Me.txtb_apellidoPF.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtb_apellidoPF.PlaceholderText = ""
        Me.txtb_apellidoPF.SelectedText = ""
        Me.txtb_apellidoPF.ShadowDecoration.Parent = Me.txtb_apellidoPF
        '
        'txtb_apellidoMF
        '
        Me.txtb_apellidoMF.BorderRadius = 6
        Me.txtb_apellidoMF.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtb_apellidoMF.DefaultText = ""
        Me.txtb_apellidoMF.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtb_apellidoMF.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtb_apellidoMF.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtb_apellidoMF.DisabledState.Parent = Me.txtb_apellidoMF
        Me.txtb_apellidoMF.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtb_apellidoMF.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtb_apellidoMF.FocusedState.Parent = Me.txtb_apellidoMF
        resources.ApplyResources(Me.txtb_apellidoMF, "txtb_apellidoMF")
        Me.txtb_apellidoMF.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtb_apellidoMF.HoverState.Parent = Me.txtb_apellidoMF
        Me.txtb_apellidoMF.Name = "txtb_apellidoMF"
        Me.txtb_apellidoMF.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtb_apellidoMF.PlaceholderText = ""
        Me.txtb_apellidoMF.SelectedText = ""
        Me.txtb_apellidoMF.ShadowDecoration.Parent = Me.txtb_apellidoMF
        '
        'txtb_ciI
        '
        Me.txtb_ciI.BorderRadius = 6
        Me.txtb_ciI.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtb_ciI.DefaultText = ""
        Me.txtb_ciI.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtb_ciI.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtb_ciI.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtb_ciI.DisabledState.Parent = Me.txtb_ciI
        Me.txtb_ciI.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtb_ciI.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtb_ciI.FocusedState.Parent = Me.txtb_ciI
        resources.ApplyResources(Me.txtb_ciI, "txtb_ciI")
        Me.txtb_ciI.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtb_ciI.HoverState.Parent = Me.txtb_ciI
        Me.txtb_ciI.Name = "txtb_ciI"
        Me.txtb_ciI.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtb_ciI.PlaceholderText = ""
        Me.txtb_ciI.SelectedText = ""
        Me.txtb_ciI.ShadowDecoration.Parent = Me.txtb_ciI
        '
        'txtb_nombresI
        '
        Me.txtb_nombresI.BorderRadius = 6
        Me.txtb_nombresI.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtb_nombresI.DefaultText = ""
        Me.txtb_nombresI.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtb_nombresI.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtb_nombresI.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtb_nombresI.DisabledState.Parent = Me.txtb_nombresI
        Me.txtb_nombresI.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtb_nombresI.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtb_nombresI.FocusedState.Parent = Me.txtb_nombresI
        resources.ApplyResources(Me.txtb_nombresI, "txtb_nombresI")
        Me.txtb_nombresI.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtb_nombresI.HoverState.Parent = Me.txtb_nombresI
        Me.txtb_nombresI.Name = "txtb_nombresI"
        Me.txtb_nombresI.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtb_nombresI.PlaceholderText = ""
        Me.txtb_nombresI.SelectedText = ""
        Me.txtb_nombresI.ShadowDecoration.Parent = Me.txtb_nombresI
        '
        'txtb_nombresF
        '
        Me.txtb_nombresF.BorderRadius = 6
        Me.txtb_nombresF.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtb_nombresF.DefaultText = ""
        Me.txtb_nombresF.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtb_nombresF.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtb_nombresF.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtb_nombresF.DisabledState.Parent = Me.txtb_nombresF
        Me.txtb_nombresF.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtb_nombresF.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtb_nombresF.FocusedState.Parent = Me.txtb_nombresF
        resources.ApplyResources(Me.txtb_nombresF, "txtb_nombresF")
        Me.txtb_nombresF.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtb_nombresF.HoverState.Parent = Me.txtb_nombresF
        Me.txtb_nombresF.Name = "txtb_nombresF"
        Me.txtb_nombresF.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtb_nombresF.PlaceholderText = ""
        Me.txtb_nombresF.SelectedText = ""
        Me.txtb_nombresF.ShadowDecoration.Parent = Me.txtb_nombresF
        '
        'txtb_ciF
        '
        Me.txtb_ciF.BorderRadius = 6
        Me.txtb_ciF.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtb_ciF.DefaultText = ""
        Me.txtb_ciF.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtb_ciF.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtb_ciF.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtb_ciF.DisabledState.Parent = Me.txtb_ciF
        Me.txtb_ciF.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtb_ciF.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtb_ciF.FocusedState.Parent = Me.txtb_ciF
        resources.ApplyResources(Me.txtb_ciF, "txtb_ciF")
        Me.txtb_ciF.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtb_ciF.HoverState.Parent = Me.txtb_ciF
        Me.txtb_ciF.Name = "txtb_ciF"
        Me.txtb_ciF.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtb_ciF.PlaceholderText = ""
        Me.txtb_ciF.SelectedText = ""
        Me.txtb_ciF.ShadowDecoration.Parent = Me.txtb_ciF
        '
        'btn_filtrar
        '
        Me.btn_filtrar.Animated = True
        Me.btn_filtrar.BackColor = System.Drawing.Color.Transparent
        Me.btn_filtrar.BorderRadius = 26
        Me.btn_filtrar.CheckedState.Parent = Me.btn_filtrar
        Me.btn_filtrar.CustomImages.Parent = Me.btn_filtrar
        Me.btn_filtrar.FillColor = System.Drawing.Color.DarkCyan
        resources.ApplyResources(Me.btn_filtrar, "btn_filtrar")
        Me.btn_filtrar.ForeColor = System.Drawing.Color.White
        Me.btn_filtrar.HoverState.Parent = Me.btn_filtrar
        Me.btn_filtrar.Name = "btn_filtrar"
        Me.btn_filtrar.ShadowDecoration.Enabled = True
        Me.btn_filtrar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.btn_filtrar.ShadowDecoration.Parent = Me.btn_filtrar
        '
        'Guna2Button1
        '
        Me.Guna2Button1.Animated = True
        Me.Guna2Button1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.BorderRadius = 16
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.FillColor = System.Drawing.Color.DarkCyan
        resources.ApplyResources(Me.Guna2Button1, "Guna2Button1")
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.Enabled = True
        Me.Guna2Button1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        '
        'btn_ingresar
        '
        Me.btn_ingresar.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.btn_ingresar, "btn_ingresar")
        Me.btn_ingresar.Image = Global.Presentacion.My.Resources.Resources.Ingresar_Button
        Me.btn_ingresar.Name = "btn_ingresar"
        Me.btn_ingresar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'lbl_fecha
        '
        resources.ApplyResources(Me.lbl_fecha, "lbl_fecha")
        Me.lbl_fecha.Name = "lbl_fecha"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        Me.Label4.UseCompatibleTextRendering = True
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'Label11
        '
        resources.ApplyResources(Me.Label11, "Label11")
        Me.Label11.Name = "Label11"
        '
        'Label12
        '
        resources.ApplyResources(Me.Label12, "Label12")
        Me.Label12.Name = "Label12"
        '
        'lbl_localidad
        '
        resources.ApplyResources(Me.lbl_localidad, "lbl_localidad")
        Me.lbl_localidad.Name = "lbl_localidad"
        '
        'lbl_dirección
        '
        resources.ApplyResources(Me.lbl_dirección, "lbl_dirección")
        Me.lbl_dirección.Name = "lbl_dirección"
        '
        'lbl_especialidad
        '
        resources.ApplyResources(Me.lbl_especialidad, "lbl_especialidad")
        Me.lbl_especialidad.Name = "lbl_especialidad"
        '
        'lbl_sucursales
        '
        resources.ApplyResources(Me.lbl_sucursales, "lbl_sucursales")
        Me.lbl_sucursales.Name = "lbl_sucursales"
        '
        'lbl_ingresar
        '
        resources.ApplyResources(Me.lbl_ingresar, "lbl_ingresar")
        Me.lbl_ingresar.Name = "lbl_ingresar"
        '
        'lbl_apellidos
        '
        resources.ApplyResources(Me.lbl_apellidos, "lbl_apellidos")
        Me.lbl_apellidos.Name = "lbl_apellidos"
        '
        'lbl_nombres
        '
        resources.ApplyResources(Me.lbl_nombres, "lbl_nombres")
        Me.lbl_nombres.Name = "lbl_nombres"
        Me.lbl_nombres.UseCompatibleTextRendering = True
        '
        'lbl_CI
        '
        resources.ApplyResources(Me.lbl_CI, "lbl_CI")
        Me.lbl_CI.Name = "lbl_CI"
        '
        'lbl_busqueda
        '
        resources.ApplyResources(Me.lbl_busqueda, "lbl_busqueda")
        Me.lbl_busqueda.Name = "lbl_busqueda"
        '
        'dgv_medicos
        '
        Me.dgv_medicos.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgv_medicos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_medicos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_medicos.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgv_medicos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_medicos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgv_medicos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_medicos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        resources.ApplyResources(Me.dgv_medicos, "dgv_medicos")
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_medicos.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_medicos.EnableHeadersVisualStyles = False
        Me.dgv_medicos.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_medicos.Name = "dgv_medicos"
        Me.dgv_medicos.RowHeadersVisible = False
        Me.dgv_medicos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.ColumnHeaderSelect
        Me.dgv_medicos.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.dgv_medicos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgv_medicos.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgv_medicos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgv_medicos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgv_medicos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgv_medicos.ThemeStyle.BackColor = System.Drawing.Color.DarkGray
        Me.dgv_medicos.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_medicos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_medicos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgv_medicos.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgv_medicos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgv_medicos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgv_medicos.ThemeStyle.HeaderStyle.Height = 4
        Me.dgv_medicos.ThemeStyle.ReadOnly = False
        Me.dgv_medicos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgv_medicos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgv_medicos.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgv_medicos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgv_medicos.ThemeStyle.RowsStyle.Height = 22
        Me.dgv_medicos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_medicos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'F_Medicos
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnl_fondo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "F_Medicos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnl_fondo.ResumeLayout(False)
        Me.pnl_ingresarFiltrar.ResumeLayout(False)
        Me.pnl_ingresarFiltrar.PerformLayout()
        CType(Me.dgv_medicos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnl_fondo As Panel
    Friend WithEvents pnl_ingresarFiltrar As Panel
    Friend WithEvents lbl_busqueda As Label
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
    Friend WithEvents btn_cerrar As Button
    Friend WithEvents btn_minimizar As Button
    Friend WithEvents btn_ingresar As Button
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents gbtn_nPassw As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents gbtn_ingresar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cmb_sucursalesF As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtb_telI As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtb_numPuertaI As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtb_direccionI As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtb_localidadI As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtb_apellidoPI As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtb_apellidoMI As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtb_apellidoPF As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtb_apellidoMF As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtb_ciI As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtb_nombresI As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtb_nombresF As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtb_ciF As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btn_filtrar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cmb_especialidadF As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cbtn_menosEspecialidades As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents cbtn_masEspecialidades As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents dtp_fechaNac As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents cmb_detallesI As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cmb_departamentoI As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cmb_especialidadI As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents dgv_medicos As Guna.UI2.WinForms.Guna2DataGridView
End Class
