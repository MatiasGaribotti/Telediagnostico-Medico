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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnl_fondo = New System.Windows.Forms.Panel()
        Me.gbtn_nPassw = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_cerrar = New System.Windows.Forms.Button()
        Me.BtnIngresar = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_minimizar = New System.Windows.Forms.Button()
        Me.pnl_ingresarFiltrar = New System.Windows.Forms.Panel()
        Me.cbtn_menosEspecialidades = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.cbtn_masEspecialidades = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.DTPickerFNac = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.cmbDetalles = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.CmbIDepartamento = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cmb_especialidadI = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cmb_especialidadF = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cmb_sucursalesF = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.TxtITelefono = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtINumero = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtICalle = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtILocalidad = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtIApellidoP = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtIApellidoM = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtb_apellidoPF = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtb_apellidoMF = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtICi = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtINombre = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtb_nombresF = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtb_ciF = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BtnFiltrar = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
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
        Me.pnl_fondo.Controls.Add(Me.btn_cerrar)
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
        'BtnIngresar
        '
        Me.BtnIngresar.Animated = True
        Me.BtnIngresar.BackColor = System.Drawing.Color.Transparent
        Me.BtnIngresar.BorderRadius = 26
        Me.BtnIngresar.CheckedState.Parent = Me.BtnIngresar
        Me.BtnIngresar.CustomImages.Parent = Me.BtnIngresar
        Me.BtnIngresar.FillColor = System.Drawing.Color.DarkCyan
        resources.ApplyResources(Me.BtnIngresar, "BtnIngresar")
        Me.BtnIngresar.ForeColor = System.Drawing.Color.White
        Me.BtnIngresar.HoverState.Parent = Me.BtnIngresar
        Me.BtnIngresar.Name = "BtnIngresar"
        Me.BtnIngresar.ShadowDecoration.Enabled = True
        Me.BtnIngresar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.BtnIngresar.ShadowDecoration.Parent = Me.BtnIngresar
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
        Me.pnl_ingresarFiltrar.Controls.Add(Me.gbtn_nPassw)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.cbtn_menosEspecialidades)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.cbtn_masEspecialidades)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.BtnIngresar)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.DTPickerFNac)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.cmbDetalles)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.CmbIDepartamento)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.cmb_especialidadI)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.cmb_especialidadF)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.cmb_sucursalesF)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.TxtITelefono)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.TxtINumero)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.TxtICalle)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.TxtILocalidad)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.TxtIApellidoP)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.TxtIApellidoM)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.txtb_apellidoPF)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.txtb_apellidoMF)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.TxtICi)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.TxtINombre)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.txtb_nombresF)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.txtb_ciF)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.BtnFiltrar)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.Guna2Button1)
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
        'DTPickerFNac
        '
        Me.DTPickerFNac.Animated = True
        Me.DTPickerFNac.BorderRadius = 6
        Me.DTPickerFNac.CheckedState.Parent = Me.DTPickerFNac
        Me.DTPickerFNac.FillColor = System.Drawing.Color.White
        resources.ApplyResources(Me.DTPickerFNac, "DTPickerFNac")
        Me.DTPickerFNac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPickerFNac.HoverState.Parent = Me.DTPickerFNac
        Me.DTPickerFNac.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DTPickerFNac.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.DTPickerFNac.Name = "DTPickerFNac"
        Me.DTPickerFNac.ShadowDecoration.Parent = Me.DTPickerFNac
        Me.DTPickerFNac.Value = New Date(2020, 7, 24, 5, 29, 51, 255)
        '
        'cmbDetalles
        '
        Me.cmbDetalles.BackColor = System.Drawing.Color.Transparent
        Me.cmbDetalles.BorderRadius = 6
        Me.cmbDetalles.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbDetalles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDetalles.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbDetalles.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbDetalles.FocusedState.Parent = Me.cmbDetalles
        resources.ApplyResources(Me.cmbDetalles, "cmbDetalles")
        Me.cmbDetalles.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbDetalles.HoverState.Parent = Me.cmbDetalles
        Me.cmbDetalles.ItemsAppearance.Parent = Me.cmbDetalles
        Me.cmbDetalles.Name = "cmbDetalles"
        Me.cmbDetalles.ShadowDecoration.Parent = Me.cmbDetalles
        '
        'CmbIDepartamento
        '
        Me.CmbIDepartamento.BackColor = System.Drawing.Color.Transparent
        Me.CmbIDepartamento.BorderRadius = 6
        Me.CmbIDepartamento.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CmbIDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbIDepartamento.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmbIDepartamento.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmbIDepartamento.FocusedState.Parent = Me.CmbIDepartamento
        resources.ApplyResources(Me.CmbIDepartamento, "CmbIDepartamento")
        Me.CmbIDepartamento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CmbIDepartamento.HoverState.Parent = Me.CmbIDepartamento
        Me.CmbIDepartamento.ItemsAppearance.Parent = Me.CmbIDepartamento
        Me.CmbIDepartamento.Name = "CmbIDepartamento"
        Me.CmbIDepartamento.ShadowDecoration.Parent = Me.CmbIDepartamento
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
        'TxtITelefono
        '
        Me.TxtITelefono.BorderRadius = 6
        Me.TxtITelefono.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtITelefono.DefaultText = ""
        Me.TxtITelefono.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtITelefono.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtITelefono.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtITelefono.DisabledState.Parent = Me.TxtITelefono
        Me.TxtITelefono.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtITelefono.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtITelefono.FocusedState.Parent = Me.TxtITelefono
        resources.ApplyResources(Me.TxtITelefono, "TxtITelefono")
        Me.TxtITelefono.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtITelefono.HoverState.Parent = Me.TxtITelefono
        Me.TxtITelefono.Name = "TxtITelefono"
        Me.TxtITelefono.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtITelefono.PlaceholderText = ""
        Me.TxtITelefono.SelectedText = ""
        Me.TxtITelefono.ShadowDecoration.Parent = Me.TxtITelefono
        '
        'TxtINumero
        '
        Me.TxtINumero.BorderRadius = 6
        Me.TxtINumero.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtINumero.DefaultText = ""
        Me.TxtINumero.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtINumero.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtINumero.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtINumero.DisabledState.Parent = Me.TxtINumero
        Me.TxtINumero.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtINumero.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtINumero.FocusedState.Parent = Me.TxtINumero
        resources.ApplyResources(Me.TxtINumero, "TxtINumero")
        Me.TxtINumero.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtINumero.HoverState.Parent = Me.TxtINumero
        Me.TxtINumero.Name = "TxtINumero"
        Me.TxtINumero.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtINumero.PlaceholderText = ""
        Me.TxtINumero.SelectedText = ""
        Me.TxtINumero.ShadowDecoration.Parent = Me.TxtINumero
        '
        'TxtICalle
        '
        Me.TxtICalle.BorderRadius = 6
        Me.TxtICalle.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtICalle.DefaultText = ""
        Me.TxtICalle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtICalle.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtICalle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtICalle.DisabledState.Parent = Me.TxtICalle
        Me.TxtICalle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtICalle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtICalle.FocusedState.Parent = Me.TxtICalle
        resources.ApplyResources(Me.TxtICalle, "TxtICalle")
        Me.TxtICalle.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtICalle.HoverState.Parent = Me.TxtICalle
        Me.TxtICalle.Name = "TxtICalle"
        Me.TxtICalle.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtICalle.PlaceholderText = ""
        Me.TxtICalle.SelectedText = ""
        Me.TxtICalle.ShadowDecoration.Parent = Me.TxtICalle
        '
        'TxtILocalidad
        '
        Me.TxtILocalidad.BorderRadius = 6
        Me.TxtILocalidad.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtILocalidad.DefaultText = ""
        Me.TxtILocalidad.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtILocalidad.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtILocalidad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtILocalidad.DisabledState.Parent = Me.TxtILocalidad
        Me.TxtILocalidad.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtILocalidad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtILocalidad.FocusedState.Parent = Me.TxtILocalidad
        resources.ApplyResources(Me.TxtILocalidad, "TxtILocalidad")
        Me.TxtILocalidad.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtILocalidad.HoverState.Parent = Me.TxtILocalidad
        Me.TxtILocalidad.Name = "TxtILocalidad"
        Me.TxtILocalidad.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtILocalidad.PlaceholderText = ""
        Me.TxtILocalidad.SelectedText = ""
        Me.TxtILocalidad.ShadowDecoration.Parent = Me.TxtILocalidad
        '
        'TxtIApellidoP
        '
        Me.TxtIApellidoP.BorderRadius = 6
        Me.TxtIApellidoP.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtIApellidoP.DefaultText = ""
        Me.TxtIApellidoP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtIApellidoP.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtIApellidoP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtIApellidoP.DisabledState.Parent = Me.TxtIApellidoP
        Me.TxtIApellidoP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtIApellidoP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtIApellidoP.FocusedState.Parent = Me.TxtIApellidoP
        resources.ApplyResources(Me.TxtIApellidoP, "TxtIApellidoP")
        Me.TxtIApellidoP.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtIApellidoP.HoverState.Parent = Me.TxtIApellidoP
        Me.TxtIApellidoP.Name = "TxtIApellidoP"
        Me.TxtIApellidoP.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtIApellidoP.PlaceholderText = ""
        Me.TxtIApellidoP.SelectedText = ""
        Me.TxtIApellidoP.ShadowDecoration.Parent = Me.TxtIApellidoP
        '
        'TxtIApellidoM
        '
        Me.TxtIApellidoM.BorderRadius = 6
        Me.TxtIApellidoM.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtIApellidoM.DefaultText = ""
        Me.TxtIApellidoM.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtIApellidoM.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtIApellidoM.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtIApellidoM.DisabledState.Parent = Me.TxtIApellidoM
        Me.TxtIApellidoM.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtIApellidoM.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtIApellidoM.FocusedState.Parent = Me.TxtIApellidoM
        resources.ApplyResources(Me.TxtIApellidoM, "TxtIApellidoM")
        Me.TxtIApellidoM.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtIApellidoM.HoverState.Parent = Me.TxtIApellidoM
        Me.TxtIApellidoM.Name = "TxtIApellidoM"
        Me.TxtIApellidoM.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtIApellidoM.PlaceholderText = ""
        Me.TxtIApellidoM.SelectedText = ""
        Me.TxtIApellidoM.ShadowDecoration.Parent = Me.TxtIApellidoM
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
        'TxtICi
        '
        Me.TxtICi.BorderRadius = 6
        Me.TxtICi.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtICi.DefaultText = ""
        Me.TxtICi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtICi.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtICi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtICi.DisabledState.Parent = Me.TxtICi
        Me.TxtICi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtICi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtICi.FocusedState.Parent = Me.TxtICi
        resources.ApplyResources(Me.TxtICi, "TxtICi")
        Me.TxtICi.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtICi.HoverState.Parent = Me.TxtICi
        Me.TxtICi.Name = "TxtICi"
        Me.TxtICi.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtICi.PlaceholderText = ""
        Me.TxtICi.SelectedText = ""
        Me.TxtICi.ShadowDecoration.Parent = Me.TxtICi
        '
        'TxtINombre
        '
        Me.TxtINombre.BorderRadius = 6
        Me.TxtINombre.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtINombre.DefaultText = ""
        Me.TxtINombre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtINombre.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtINombre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtINombre.DisabledState.Parent = Me.TxtINombre
        Me.TxtINombre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtINombre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtINombre.FocusedState.Parent = Me.TxtINombre
        resources.ApplyResources(Me.TxtINombre, "TxtINombre")
        Me.TxtINombre.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtINombre.HoverState.Parent = Me.TxtINombre
        Me.TxtINombre.Name = "TxtINombre"
        Me.TxtINombre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtINombre.PlaceholderText = ""
        Me.TxtINombre.SelectedText = ""
        Me.TxtINombre.ShadowDecoration.Parent = Me.TxtINombre
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
        'BtnFiltrar
        '
        Me.BtnFiltrar.Animated = True
        Me.BtnFiltrar.BackColor = System.Drawing.Color.Transparent
        Me.BtnFiltrar.BorderRadius = 26
        Me.BtnFiltrar.CheckedState.Parent = Me.BtnFiltrar
        Me.BtnFiltrar.CustomImages.Parent = Me.BtnFiltrar
        Me.BtnFiltrar.FillColor = System.Drawing.Color.DarkCyan
        resources.ApplyResources(Me.BtnFiltrar, "BtnFiltrar")
        Me.BtnFiltrar.ForeColor = System.Drawing.Color.White
        Me.BtnFiltrar.HoverState.Parent = Me.BtnFiltrar
        Me.BtnFiltrar.Name = "BtnFiltrar"
        Me.BtnFiltrar.ShadowDecoration.Enabled = True
        Me.BtnFiltrar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.BtnFiltrar.ShadowDecoration.Parent = Me.BtnFiltrar
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
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.dgv_medicos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_medicos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_medicos.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgv_medicos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_medicos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgv_medicos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_medicos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        resources.ApplyResources(Me.dgv_medicos, "dgv_medicos")
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_medicos.DefaultCellStyle = DataGridViewCellStyle6
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
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents gbtn_nPassw As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnIngresar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cmb_sucursalesF As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents TxtITelefono As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtINumero As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtICalle As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtILocalidad As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtIApellidoP As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtIApellidoM As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtb_apellidoPF As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtb_apellidoMF As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtICi As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtINombre As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtb_nombresF As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtb_ciF As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BtnFiltrar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cmb_especialidadF As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cbtn_menosEspecialidades As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents cbtn_masEspecialidades As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents DTPickerFNac As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents cmbDetalles As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents CmbIDepartamento As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cmb_especialidadI As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents dgv_medicos As Guna.UI2.WinForms.Guna2DataGridView
End Class
