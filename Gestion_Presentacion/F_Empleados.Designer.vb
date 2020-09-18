<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_Empleados
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_Empleados))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnl_fondo = New System.Windows.Forms.Panel()
        Me.DgvMedicos = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.BtnMinimize = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.BtnExit = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.BtnResetPassword = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnHacerAdmin = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnEliminar = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnModificar = New Guna.UI2.WinForms.Guna2Button()
        Me.pnl_ingresarFiltrar = New System.Windows.Forms.Panel()
        Me.BtnVolver = New Guna.UI2.WinForms.Guna2Button()
        Me.CmbIEspecialidades = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.TxtBTelefono = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CmbBRol = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.LblBRol = New System.Windows.Forms.Label()
        Me.TxtIDetalle = New Guna.UI2.WinForms.Guna2TextBox()
        Me.CmbIRol = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.lblRol = New System.Windows.Forms.Label()
        Me.BtnHorarios = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnFiltrar = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnIngresar = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnDelEspecialidad = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.BtnAddEspecialidad = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.DTPickerFNac = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.CmbIDepartamento = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.CmbIngresadasEspecialidades = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.CmbBEspecialidades = New Guna.UI2.WinForms.Guna2ComboBox()
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
        Me.pnl_fondo.SuspendLayout()
        CType(Me.DgvMedicos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_ingresarFiltrar.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl_fondo
        '
        Me.pnl_fondo.Controls.Add(Me.DgvMedicos)
        Me.pnl_fondo.Controls.Add(Me.BtnMinimize)
        Me.pnl_fondo.Controls.Add(Me.BtnExit)
        Me.pnl_fondo.Controls.Add(Me.BtnResetPassword)
        Me.pnl_fondo.Controls.Add(Me.BtnHacerAdmin)
        Me.pnl_fondo.Controls.Add(Me.BtnEliminar)
        Me.pnl_fondo.Controls.Add(Me.BtnModificar)
        Me.pnl_fondo.Controls.Add(Me.pnl_ingresarFiltrar)
        resources.ApplyResources(Me.pnl_fondo, "pnl_fondo")
        Me.pnl_fondo.Name = "pnl_fondo"
        '
        'DgvMedicos
        '
        Me.DgvMedicos.AllowUserToAddRows = False
        Me.DgvMedicos.AllowUserToDeleteRows = False
        Me.DgvMedicos.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.DgvMedicos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvMedicos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvMedicos.BackgroundColor = System.Drawing.Color.White
        Me.DgvMedicos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvMedicos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgvMedicos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(123, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvMedicos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        resources.ApplyResources(Me.DgvMedicos, "DgvMedicos")
        Me.DgvMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(222, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvMedicos.DefaultCellStyle = DataGridViewCellStyle3
        Me.DgvMedicos.EnableHeadersVisualStyles = False
        Me.DgvMedicos.GridColor = System.Drawing.Color.Gray
        Me.DgvMedicos.Name = "DgvMedicos"
        Me.DgvMedicos.ReadOnly = True
        Me.DgvMedicos.RowHeadersVisible = False
        Me.DgvMedicos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvMedicos.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.DgvMedicos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.DgvMedicos.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DgvMedicos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DgvMedicos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DgvMedicos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DgvMedicos.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DgvMedicos.ThemeStyle.GridColor = System.Drawing.Color.Gray
        Me.DgvMedicos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.DgvMedicos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvMedicos.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DgvMedicos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DgvMedicos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgvMedicos.ThemeStyle.HeaderStyle.Height = 40
        Me.DgvMedicos.ThemeStyle.ReadOnly = True
        Me.DgvMedicos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DgvMedicos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgvMedicos.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DgvMedicos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DgvMedicos.ThemeStyle.RowsStyle.Height = 22
        Me.DgvMedicos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.DgvMedicos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'BtnMinimize
        '
        resources.ApplyResources(Me.BtnMinimize, "BtnMinimize")
        Me.BtnMinimize.Animated = True
        Me.BtnMinimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.BtnMinimize.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.BtnMinimize.HoverState.Parent = Me.BtnMinimize
        Me.BtnMinimize.IconColor = System.Drawing.Color.White
        Me.BtnMinimize.Name = "BtnMinimize"
        Me.BtnMinimize.ShadowDecoration.Parent = Me.BtnMinimize
        '
        'BtnExit
        '
        resources.ApplyResources(Me.BtnExit, "BtnExit")
        Me.BtnExit.Animated = True
        Me.BtnExit.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.BtnExit.HoverState.Parent = Me.BtnExit
        Me.BtnExit.IconColor = System.Drawing.Color.White
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.ShadowDecoration.Parent = Me.BtnExit
        '
        'BtnResetPassword
        '
        Me.BtnResetPassword.Animated = True
        Me.BtnResetPassword.AutoRoundedCorners = True
        Me.BtnResetPassword.BorderRadius = 17
        Me.BtnResetPassword.CheckedState.Parent = Me.BtnResetPassword
        Me.BtnResetPassword.CustomImages.Parent = Me.BtnResetPassword
        Me.BtnResetPassword.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(123, Byte), Integer))
        resources.ApplyResources(Me.BtnResetPassword, "BtnResetPassword")
        Me.BtnResetPassword.ForeColor = System.Drawing.Color.White
        Me.BtnResetPassword.HoverState.Parent = Me.BtnResetPassword
        Me.BtnResetPassword.Name = "BtnResetPassword"
        Me.BtnResetPassword.ShadowDecoration.Parent = Me.BtnResetPassword
        '
        'BtnHacerAdmin
        '
        Me.BtnHacerAdmin.Animated = True
        Me.BtnHacerAdmin.AutoRoundedCorners = True
        Me.BtnHacerAdmin.BorderRadius = 17
        Me.BtnHacerAdmin.CheckedState.Parent = Me.BtnHacerAdmin
        Me.BtnHacerAdmin.CustomImages.Parent = Me.BtnHacerAdmin
        Me.BtnHacerAdmin.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(123, Byte), Integer))
        resources.ApplyResources(Me.BtnHacerAdmin, "BtnHacerAdmin")
        Me.BtnHacerAdmin.ForeColor = System.Drawing.Color.White
        Me.BtnHacerAdmin.HoverState.Parent = Me.BtnHacerAdmin
        Me.BtnHacerAdmin.Name = "BtnHacerAdmin"
        Me.BtnHacerAdmin.ShadowDecoration.Parent = Me.BtnHacerAdmin
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Animated = True
        Me.BtnEliminar.AutoRoundedCorners = True
        Me.BtnEliminar.BorderRadius = 17
        Me.BtnEliminar.CheckedState.Parent = Me.BtnEliminar
        Me.BtnEliminar.CustomImages.Parent = Me.BtnEliminar
        Me.BtnEliminar.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(123, Byte), Integer))
        resources.ApplyResources(Me.BtnEliminar, "BtnEliminar")
        Me.BtnEliminar.ForeColor = System.Drawing.Color.White
        Me.BtnEliminar.HoverState.Parent = Me.BtnEliminar
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.ShadowDecoration.Parent = Me.BtnEliminar
        '
        'BtnModificar
        '
        Me.BtnModificar.Animated = True
        Me.BtnModificar.AutoRoundedCorners = True
        Me.BtnModificar.BorderRadius = 17
        Me.BtnModificar.CheckedState.Parent = Me.BtnModificar
        Me.BtnModificar.CustomImages.Parent = Me.BtnModificar
        Me.BtnModificar.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(123, Byte), Integer))
        resources.ApplyResources(Me.BtnModificar, "BtnModificar")
        Me.BtnModificar.ForeColor = System.Drawing.Color.White
        Me.BtnModificar.HoverState.Parent = Me.BtnModificar
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.ShadowDecoration.Parent = Me.BtnModificar
        '
        'pnl_ingresarFiltrar
        '
        Me.pnl_ingresarFiltrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.pnl_ingresarFiltrar.Controls.Add(Me.BtnVolver)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.CmbIEspecialidades)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.TxtBTelefono)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.Label2)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.CmbBRol)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.LblBRol)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.TxtIDetalle)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.CmbIRol)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.lblRol)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.BtnHorarios)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.BtnFiltrar)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.BtnIngresar)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.BtnDelEspecialidad)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.BtnAddEspecialidad)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.DTPickerFNac)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.CmbIDepartamento)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.CmbIngresadasEspecialidades)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.CmbBEspecialidades)
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
        'BtnVolver
        '
        Me.BtnVolver.Animated = True
        Me.BtnVolver.AutoRoundedCorners = True
        Me.BtnVolver.BorderRadius = 13
        Me.BtnVolver.CheckedState.Parent = Me.BtnVolver
        Me.BtnVolver.CustomImages.Parent = Me.BtnVolver
        Me.BtnVolver.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(123, Byte), Integer))
        resources.ApplyResources(Me.BtnVolver, "BtnVolver")
        Me.BtnVolver.ForeColor = System.Drawing.Color.White
        Me.BtnVolver.HoverState.Parent = Me.BtnVolver
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.ShadowDecoration.Parent = Me.BtnVolver
        '
        'CmbIEspecialidades
        '
        Me.CmbIEspecialidades.BackColor = System.Drawing.Color.Transparent
        Me.CmbIEspecialidades.BorderRadius = 6
        Me.CmbIEspecialidades.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CmbIEspecialidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbIEspecialidades.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmbIEspecialidades.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmbIEspecialidades.FocusedState.Parent = Me.CmbIEspecialidades
        resources.ApplyResources(Me.CmbIEspecialidades, "CmbIEspecialidades")
        Me.CmbIEspecialidades.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CmbIEspecialidades.HoverState.Parent = Me.CmbIEspecialidades
        Me.CmbIEspecialidades.ItemsAppearance.Parent = Me.CmbIEspecialidades
        Me.CmbIEspecialidades.Name = "CmbIEspecialidades"
        Me.CmbIEspecialidades.ShadowDecoration.Parent = Me.CmbIEspecialidades
        '
        'TxtBTelefono
        '
        Me.TxtBTelefono.BorderRadius = 6
        Me.TxtBTelefono.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtBTelefono.DefaultText = ""
        Me.TxtBTelefono.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtBTelefono.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtBTelefono.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtBTelefono.DisabledState.Parent = Me.TxtBTelefono
        Me.TxtBTelefono.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtBTelefono.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtBTelefono.FocusedState.Parent = Me.TxtBTelefono
        resources.ApplyResources(Me.TxtBTelefono, "TxtBTelefono")
        Me.TxtBTelefono.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtBTelefono.HoverState.Parent = Me.TxtBTelefono
        Me.TxtBTelefono.Name = "TxtBTelefono"
        Me.TxtBTelefono.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtBTelefono.PlaceholderText = ""
        Me.TxtBTelefono.SelectedText = ""
        Me.TxtBTelefono.ShadowDecoration.Parent = Me.TxtBTelefono
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'CmbBRol
        '
        Me.CmbBRol.BackColor = System.Drawing.Color.Transparent
        Me.CmbBRol.BorderRadius = 6
        Me.CmbBRol.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CmbBRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbBRol.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmbBRol.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmbBRol.FocusedState.Parent = Me.CmbBRol
        resources.ApplyResources(Me.CmbBRol, "CmbBRol")
        Me.CmbBRol.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CmbBRol.HoverState.Parent = Me.CmbBRol
        Me.CmbBRol.ItemsAppearance.Parent = Me.CmbBRol
        Me.CmbBRol.Name = "CmbBRol"
        Me.CmbBRol.ShadowDecoration.Parent = Me.CmbBRol
        '
        'LblBRol
        '
        resources.ApplyResources(Me.LblBRol, "LblBRol")
        Me.LblBRol.Name = "LblBRol"
        '
        'TxtIDetalle
        '
        Me.TxtIDetalle.BorderRadius = 6
        Me.TxtIDetalle.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtIDetalle.DefaultText = ""
        Me.TxtIDetalle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtIDetalle.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtIDetalle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtIDetalle.DisabledState.Parent = Me.TxtIDetalle
        Me.TxtIDetalle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtIDetalle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtIDetalle.FocusedState.Parent = Me.TxtIDetalle
        resources.ApplyResources(Me.TxtIDetalle, "TxtIDetalle")
        Me.TxtIDetalle.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtIDetalle.HoverState.Parent = Me.TxtIDetalle
        Me.TxtIDetalle.Name = "TxtIDetalle"
        Me.TxtIDetalle.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtIDetalle.PlaceholderText = ""
        Me.TxtIDetalle.SelectedText = ""
        Me.TxtIDetalle.ShadowDecoration.Parent = Me.TxtIDetalle
        '
        'CmbIRol
        '
        Me.CmbIRol.BackColor = System.Drawing.Color.Transparent
        Me.CmbIRol.BorderRadius = 6
        Me.CmbIRol.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CmbIRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbIRol.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmbIRol.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmbIRol.FocusedState.Parent = Me.CmbIRol
        resources.ApplyResources(Me.CmbIRol, "CmbIRol")
        Me.CmbIRol.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CmbIRol.HoverState.Parent = Me.CmbIRol
        Me.CmbIRol.ItemsAppearance.Parent = Me.CmbIRol
        Me.CmbIRol.Name = "CmbIRol"
        Me.CmbIRol.ShadowDecoration.Parent = Me.CmbIRol
        '
        'lblRol
        '
        resources.ApplyResources(Me.lblRol, "lblRol")
        Me.lblRol.Name = "lblRol"
        '
        'BtnHorarios
        '
        Me.BtnHorarios.Animated = True
        Me.BtnHorarios.AutoRoundedCorners = True
        Me.BtnHorarios.BackColor = System.Drawing.Color.Transparent
        Me.BtnHorarios.BorderRadius = 17
        Me.BtnHorarios.CheckedState.Parent = Me.BtnHorarios
        Me.BtnHorarios.CustomImages.Parent = Me.BtnHorarios
        Me.BtnHorarios.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(123, Byte), Integer))
        resources.ApplyResources(Me.BtnHorarios, "BtnHorarios")
        Me.BtnHorarios.ForeColor = System.Drawing.Color.White
        Me.BtnHorarios.HoverState.Parent = Me.BtnHorarios
        Me.BtnHorarios.Name = "BtnHorarios"
        Me.BtnHorarios.ShadowDecoration.Parent = Me.BtnHorarios
        Me.BtnHorarios.UseTransparentBackground = True
        '
        'BtnFiltrar
        '
        Me.BtnFiltrar.Animated = True
        Me.BtnFiltrar.AutoRoundedCorners = True
        Me.BtnFiltrar.BorderRadius = 17
        Me.BtnFiltrar.CheckedState.Parent = Me.BtnFiltrar
        Me.BtnFiltrar.CustomImages.Parent = Me.BtnFiltrar
        Me.BtnFiltrar.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(123, Byte), Integer))
        resources.ApplyResources(Me.BtnFiltrar, "BtnFiltrar")
        Me.BtnFiltrar.ForeColor = System.Drawing.Color.White
        Me.BtnFiltrar.HoverState.Parent = Me.BtnFiltrar
        Me.BtnFiltrar.Name = "BtnFiltrar"
        Me.BtnFiltrar.ShadowDecoration.Parent = Me.BtnFiltrar
        '
        'BtnIngresar
        '
        Me.BtnIngresar.Animated = True
        Me.BtnIngresar.AutoRoundedCorners = True
        Me.BtnIngresar.BackColor = System.Drawing.Color.Transparent
        Me.BtnIngresar.BorderRadius = 17
        Me.BtnIngresar.CheckedState.Parent = Me.BtnIngresar
        Me.BtnIngresar.CustomImages.Parent = Me.BtnIngresar
        Me.BtnIngresar.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(123, Byte), Integer))
        resources.ApplyResources(Me.BtnIngresar, "BtnIngresar")
        Me.BtnIngresar.ForeColor = System.Drawing.Color.White
        Me.BtnIngresar.HoverState.Parent = Me.BtnIngresar
        Me.BtnIngresar.Name = "BtnIngresar"
        Me.BtnIngresar.ShadowDecoration.Parent = Me.BtnIngresar
        Me.BtnIngresar.UseTransparentBackground = True
        '
        'BtnDelEspecialidad
        '
        Me.BtnDelEspecialidad.CheckedState.Parent = Me.BtnDelEspecialidad
        Me.BtnDelEspecialidad.CustomImages.Parent = Me.BtnDelEspecialidad
        Me.BtnDelEspecialidad.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(123, Byte), Integer))
        resources.ApplyResources(Me.BtnDelEspecialidad, "BtnDelEspecialidad")
        Me.BtnDelEspecialidad.ForeColor = System.Drawing.Color.White
        Me.BtnDelEspecialidad.HoverState.Parent = Me.BtnDelEspecialidad
        Me.BtnDelEspecialidad.Name = "BtnDelEspecialidad"
        Me.BtnDelEspecialidad.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.BtnDelEspecialidad.ShadowDecoration.Parent = Me.BtnDelEspecialidad
        '
        'BtnAddEspecialidad
        '
        Me.BtnAddEspecialidad.CheckedState.Parent = Me.BtnAddEspecialidad
        Me.BtnAddEspecialidad.CustomImages.Parent = Me.BtnAddEspecialidad
        Me.BtnAddEspecialidad.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(123, Byte), Integer))
        resources.ApplyResources(Me.BtnAddEspecialidad, "BtnAddEspecialidad")
        Me.BtnAddEspecialidad.ForeColor = System.Drawing.Color.White
        Me.BtnAddEspecialidad.HoverState.Parent = Me.BtnAddEspecialidad
        Me.BtnAddEspecialidad.Name = "BtnAddEspecialidad"
        Me.BtnAddEspecialidad.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.BtnAddEspecialidad.ShadowDecoration.Parent = Me.BtnAddEspecialidad
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
        'CmbIngresadasEspecialidades
        '
        Me.CmbIngresadasEspecialidades.BackColor = System.Drawing.Color.Transparent
        Me.CmbIngresadasEspecialidades.BorderRadius = 6
        Me.CmbIngresadasEspecialidades.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CmbIngresadasEspecialidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbIngresadasEspecialidades.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmbIngresadasEspecialidades.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmbIngresadasEspecialidades.FocusedState.Parent = Me.CmbIngresadasEspecialidades
        resources.ApplyResources(Me.CmbIngresadasEspecialidades, "CmbIngresadasEspecialidades")
        Me.CmbIngresadasEspecialidades.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CmbIngresadasEspecialidades.HoverState.Parent = Me.CmbIngresadasEspecialidades
        Me.CmbIngresadasEspecialidades.ItemsAppearance.Parent = Me.CmbIngresadasEspecialidades
        Me.CmbIngresadasEspecialidades.Name = "CmbIngresadasEspecialidades"
        Me.CmbIngresadasEspecialidades.ShadowDecoration.Parent = Me.CmbIngresadasEspecialidades
        '
        'CmbBEspecialidades
        '
        Me.CmbBEspecialidades.BackColor = System.Drawing.Color.Transparent
        Me.CmbBEspecialidades.BorderRadius = 6
        Me.CmbBEspecialidades.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CmbBEspecialidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbBEspecialidades.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmbBEspecialidades.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmbBEspecialidades.FocusedState.Parent = Me.CmbBEspecialidades
        resources.ApplyResources(Me.CmbBEspecialidades, "CmbBEspecialidades")
        Me.CmbBEspecialidades.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CmbBEspecialidades.HoverState.Parent = Me.CmbBEspecialidades
        Me.CmbBEspecialidades.ItemsAppearance.Parent = Me.CmbBEspecialidades
        Me.CmbBEspecialidades.Name = "CmbBEspecialidades"
        Me.CmbBEspecialidades.ShadowDecoration.Parent = Me.CmbBEspecialidades
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
        'F_Empleados
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnl_fondo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "F_Empleados"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnl_fondo.ResumeLayout(False)
        CType(Me.DgvMedicos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_ingresarFiltrar.ResumeLayout(False)
        Me.pnl_ingresarFiltrar.PerformLayout()
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
    Friend WithEvents CmbBEspecialidades As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents BtnDelEspecialidad As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents BtnAddEspecialidad As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents DTPickerFNac As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents CmbIDepartamento As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents CmbIngresadasEspecialidades As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents BtnEliminar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnModificar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnResetPassword As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnHacerAdmin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnHorarios As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnFiltrar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnIngresar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnMinimize As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents BtnExit As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents DgvMedicos As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents CmbBRol As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents LblBRol As Label
    Friend WithEvents TxtIDetalle As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents CmbIRol As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents lblRol As Label
    Friend WithEvents TxtBTelefono As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CmbIEspecialidades As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents BtnVolver As Guna.UI2.WinForms.Guna2Button
End Class
