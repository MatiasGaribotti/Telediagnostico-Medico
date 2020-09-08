<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F_Empleados_Horarios
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_Empleados_Horarios))
        Me.pnl_fondo = New System.Windows.Forms.Panel()
        Me.BtnEliminar = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnModificar = New Guna.UI2.WinForms.Guna2Button()
        Me.dgw_horarios = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.pnl_ingresar = New System.Windows.Forms.Panel()
        Me.BtnFiltrar = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnIngresar = New Guna.UI2.WinForms.Guna2Button()
        Me.TxtBCi = New Guna.UI2.WinForms.Guna2TextBox()
        Me.LblBCi = New System.Windows.Forms.Label()
        Me.TxtIHoraOut = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtIHoraIn = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btn_volver = New Guna.UI2.WinForms.Guna2Button()
        Me.dtp_rangoSalida = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.dtp_rangoEntrada = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.cmb_sucursalF = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.rbtn_dF = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.rbtn_mF = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.rbtn_xF = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.rbtn_jF = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.rbnt_vF = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.rbtn_sF = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.rbtn_lF = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.RbtnD = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.RbtnM = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.RbtnX = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.RbtnJ = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.RbtnV = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.RbtnS = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.RbtnL = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.CmbISucursal = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.TxtICi = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lbl_a = New System.Windows.Forms.Label()
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
        Me.BtnMinimize = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.BtnExit = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.pnl_fondo.SuspendLayout()
        CType(Me.dgw_horarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_ingresar.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl_fondo
        '
        Me.pnl_fondo.Controls.Add(Me.BtnMinimize)
        Me.pnl_fondo.Controls.Add(Me.BtnExit)
        Me.pnl_fondo.Controls.Add(Me.BtnEliminar)
        Me.pnl_fondo.Controls.Add(Me.BtnModificar)
        Me.pnl_fondo.Controls.Add(Me.dgw_horarios)
        Me.pnl_fondo.Controls.Add(Me.pnl_ingresar)
        resources.ApplyResources(Me.pnl_fondo, "pnl_fondo")
        Me.pnl_fondo.Name = "pnl_fondo"
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
        'dgw_horarios
        '
        Me.dgw_horarios.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgw_horarios.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgw_horarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgw_horarios.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgw_horarios.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgw_horarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgw_horarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgw_horarios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        resources.ApplyResources(Me.dgw_horarios, "dgw_horarios")
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgw_horarios.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgw_horarios.EnableHeadersVisualStyles = False
        Me.dgw_horarios.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgw_horarios.Name = "dgw_horarios"
        Me.dgw_horarios.RowHeadersVisible = False
        Me.dgw_horarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.ColumnHeaderSelect
        Me.dgw_horarios.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.dgw_horarios.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgw_horarios.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgw_horarios.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgw_horarios.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgw_horarios.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgw_horarios.ThemeStyle.BackColor = System.Drawing.Color.DarkGray
        Me.dgw_horarios.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgw_horarios.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgw_horarios.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgw_horarios.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgw_horarios.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgw_horarios.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgw_horarios.ThemeStyle.HeaderStyle.Height = 4
        Me.dgw_horarios.ThemeStyle.ReadOnly = False
        Me.dgw_horarios.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgw_horarios.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgw_horarios.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgw_horarios.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgw_horarios.ThemeStyle.RowsStyle.Height = 22
        Me.dgw_horarios.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgw_horarios.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'pnl_ingresar
        '
        Me.pnl_ingresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.pnl_ingresar.Controls.Add(Me.BtnFiltrar)
        Me.pnl_ingresar.Controls.Add(Me.BtnIngresar)
        Me.pnl_ingresar.Controls.Add(Me.TxtBCi)
        Me.pnl_ingresar.Controls.Add(Me.LblBCi)
        Me.pnl_ingresar.Controls.Add(Me.TxtIHoraOut)
        Me.pnl_ingresar.Controls.Add(Me.TxtIHoraIn)
        Me.pnl_ingresar.Controls.Add(Me.btn_volver)
        Me.pnl_ingresar.Controls.Add(Me.dtp_rangoSalida)
        Me.pnl_ingresar.Controls.Add(Me.dtp_rangoEntrada)
        Me.pnl_ingresar.Controls.Add(Me.cmb_sucursalF)
        Me.pnl_ingresar.Controls.Add(Me.rbtn_dF)
        Me.pnl_ingresar.Controls.Add(Me.rbtn_mF)
        Me.pnl_ingresar.Controls.Add(Me.rbtn_xF)
        Me.pnl_ingresar.Controls.Add(Me.rbtn_jF)
        Me.pnl_ingresar.Controls.Add(Me.rbnt_vF)
        Me.pnl_ingresar.Controls.Add(Me.rbtn_sF)
        Me.pnl_ingresar.Controls.Add(Me.rbtn_lF)
        Me.pnl_ingresar.Controls.Add(Me.RbtnD)
        Me.pnl_ingresar.Controls.Add(Me.RbtnM)
        Me.pnl_ingresar.Controls.Add(Me.RbtnX)
        Me.pnl_ingresar.Controls.Add(Me.RbtnJ)
        Me.pnl_ingresar.Controls.Add(Me.RbtnV)
        Me.pnl_ingresar.Controls.Add(Me.RbtnS)
        Me.pnl_ingresar.Controls.Add(Me.RbtnL)
        Me.pnl_ingresar.Controls.Add(Me.CmbISucursal)
        Me.pnl_ingresar.Controls.Add(Me.TxtICi)
        Me.pnl_ingresar.Controls.Add(Me.lbl_a)
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
        resources.ApplyResources(Me.pnl_ingresar, "pnl_ingresar")
        Me.pnl_ingresar.Name = "pnl_ingresar"
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
        'TxtBCi
        '
        Me.TxtBCi.Animated = True
        Me.TxtBCi.BorderRadius = 6
        Me.TxtBCi.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtBCi.DefaultText = ""
        Me.TxtBCi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtBCi.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtBCi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtBCi.DisabledState.Parent = Me.TxtBCi
        Me.TxtBCi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtBCi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtBCi.FocusedState.Parent = Me.TxtBCi
        Me.TxtBCi.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtBCi.HoverState.Parent = Me.TxtBCi
        resources.ApplyResources(Me.TxtBCi, "TxtBCi")
        Me.TxtBCi.Name = "TxtBCi"
        Me.TxtBCi.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtBCi.PlaceholderText = ""
        Me.TxtBCi.SelectedText = ""
        Me.TxtBCi.ShadowDecoration.Parent = Me.TxtBCi
        '
        'LblBCi
        '
        resources.ApplyResources(Me.LblBCi, "LblBCi")
        Me.LblBCi.Name = "LblBCi"
        '
        'TxtIHoraOut
        '
        Me.TxtIHoraOut.Animated = True
        Me.TxtIHoraOut.BorderRadius = 6
        Me.TxtIHoraOut.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtIHoraOut.DefaultText = ""
        Me.TxtIHoraOut.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtIHoraOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtIHoraOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtIHoraOut.DisabledState.Parent = Me.TxtIHoraOut
        Me.TxtIHoraOut.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtIHoraOut.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtIHoraOut.FocusedState.Parent = Me.TxtIHoraOut
        Me.TxtIHoraOut.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtIHoraOut.HoverState.Parent = Me.TxtIHoraOut
        resources.ApplyResources(Me.TxtIHoraOut, "TxtIHoraOut")
        Me.TxtIHoraOut.Name = "TxtIHoraOut"
        Me.TxtIHoraOut.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtIHoraOut.PlaceholderText = ""
        Me.TxtIHoraOut.SelectedText = ""
        Me.TxtIHoraOut.ShadowDecoration.Parent = Me.TxtIHoraOut
        '
        'TxtIHoraIn
        '
        Me.TxtIHoraIn.Animated = True
        Me.TxtIHoraIn.BorderRadius = 6
        Me.TxtIHoraIn.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtIHoraIn.DefaultText = ""
        Me.TxtIHoraIn.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtIHoraIn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtIHoraIn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtIHoraIn.DisabledState.Parent = Me.TxtIHoraIn
        Me.TxtIHoraIn.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtIHoraIn.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtIHoraIn.FocusedState.Parent = Me.TxtIHoraIn
        Me.TxtIHoraIn.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtIHoraIn.HoverState.Parent = Me.TxtIHoraIn
        resources.ApplyResources(Me.TxtIHoraIn, "TxtIHoraIn")
        Me.TxtIHoraIn.Name = "TxtIHoraIn"
        Me.TxtIHoraIn.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtIHoraIn.PlaceholderText = ""
        Me.TxtIHoraIn.SelectedText = ""
        Me.TxtIHoraIn.ShadowDecoration.Parent = Me.TxtIHoraIn
        '
        'btn_volver
        '
        Me.btn_volver.Animated = True
        Me.btn_volver.BackColor = System.Drawing.Color.Transparent
        Me.btn_volver.BorderRadius = 16
        Me.btn_volver.CheckedState.Parent = Me.btn_volver
        Me.btn_volver.CustomImages.Parent = Me.btn_volver
        Me.btn_volver.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(123, Byte), Integer))
        resources.ApplyResources(Me.btn_volver, "btn_volver")
        Me.btn_volver.ForeColor = System.Drawing.Color.White
        Me.btn_volver.HoverState.Parent = Me.btn_volver
        Me.btn_volver.Name = "btn_volver"
        Me.btn_volver.ShadowDecoration.Enabled = True
        Me.btn_volver.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.btn_volver.ShadowDecoration.Parent = Me.btn_volver
        '
        'dtp_rangoSalida
        '
        Me.dtp_rangoSalida.Animated = True
        Me.dtp_rangoSalida.BorderRadius = 6
        Me.dtp_rangoSalida.CheckedState.Parent = Me.dtp_rangoSalida
        Me.dtp_rangoSalida.FillColor = System.Drawing.Color.White
        resources.ApplyResources(Me.dtp_rangoSalida, "dtp_rangoSalida")
        Me.dtp_rangoSalida.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtp_rangoSalida.HoverState.Parent = Me.dtp_rangoSalida
        Me.dtp_rangoSalida.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtp_rangoSalida.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtp_rangoSalida.Name = "dtp_rangoSalida"
        Me.dtp_rangoSalida.ShadowDecoration.Parent = Me.dtp_rangoSalida
        Me.dtp_rangoSalida.Value = New Date(2020, 7, 24, 4, 22, 9, 55)
        '
        'dtp_rangoEntrada
        '
        Me.dtp_rangoEntrada.Animated = True
        Me.dtp_rangoEntrada.BorderRadius = 6
        Me.dtp_rangoEntrada.CheckedState.Parent = Me.dtp_rangoEntrada
        Me.dtp_rangoEntrada.FillColor = System.Drawing.Color.White
        resources.ApplyResources(Me.dtp_rangoEntrada, "dtp_rangoEntrada")
        Me.dtp_rangoEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtp_rangoEntrada.HoverState.Parent = Me.dtp_rangoEntrada
        Me.dtp_rangoEntrada.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtp_rangoEntrada.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtp_rangoEntrada.Name = "dtp_rangoEntrada"
        Me.dtp_rangoEntrada.ShadowDecoration.Parent = Me.dtp_rangoEntrada
        Me.dtp_rangoEntrada.Value = New Date(2020, 7, 24, 4, 22, 9, 55)
        '
        'cmb_sucursalF
        '
        Me.cmb_sucursalF.Animated = True
        Me.cmb_sucursalF.BackColor = System.Drawing.Color.Transparent
        Me.cmb_sucursalF.BorderRadius = 6
        Me.cmb_sucursalF.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_sucursalF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_sucursalF.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_sucursalF.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_sucursalF.FocusedState.Parent = Me.cmb_sucursalF
        resources.ApplyResources(Me.cmb_sucursalF, "cmb_sucursalF")
        Me.cmb_sucursalF.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmb_sucursalF.HoverState.Parent = Me.cmb_sucursalF
        Me.cmb_sucursalF.Items.AddRange(New Object() {resources.GetString("cmb_sucursalF.Items"), resources.GetString("cmb_sucursalF.Items1")})
        Me.cmb_sucursalF.ItemsAppearance.Parent = Me.cmb_sucursalF
        Me.cmb_sucursalF.Name = "cmb_sucursalF"
        Me.cmb_sucursalF.ShadowDecoration.Parent = Me.cmb_sucursalF
        '
        'rbtn_dF
        '
        resources.ApplyResources(Me.rbtn_dF, "rbtn_dF")
        Me.rbtn_dF.CheckedState.BorderColor = System.Drawing.Color.Silver
        Me.rbtn_dF.CheckedState.BorderThickness = 0
        Me.rbtn_dF.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rbtn_dF.CheckedState.InnerColor = System.Drawing.Color.White
        Me.rbtn_dF.CheckedState.InnerOffset = -4
        Me.rbtn_dF.Name = "rbtn_dF"
        Me.rbtn_dF.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.rbtn_dF.UncheckedState.BorderThickness = 1
        Me.rbtn_dF.UncheckedState.FillColor = System.Drawing.Color.White
        Me.rbtn_dF.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'rbtn_mF
        '
        resources.ApplyResources(Me.rbtn_mF, "rbtn_mF")
        Me.rbtn_mF.CheckedState.BorderColor = System.Drawing.Color.Silver
        Me.rbtn_mF.CheckedState.BorderThickness = 0
        Me.rbtn_mF.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rbtn_mF.CheckedState.InnerColor = System.Drawing.Color.White
        Me.rbtn_mF.CheckedState.InnerOffset = -4
        Me.rbtn_mF.Name = "rbtn_mF"
        Me.rbtn_mF.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.rbtn_mF.UncheckedState.BorderThickness = 1
        Me.rbtn_mF.UncheckedState.FillColor = System.Drawing.Color.White
        Me.rbtn_mF.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'rbtn_xF
        '
        resources.ApplyResources(Me.rbtn_xF, "rbtn_xF")
        Me.rbtn_xF.CheckedState.BorderColor = System.Drawing.Color.Silver
        Me.rbtn_xF.CheckedState.BorderThickness = 0
        Me.rbtn_xF.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rbtn_xF.CheckedState.InnerColor = System.Drawing.Color.White
        Me.rbtn_xF.CheckedState.InnerOffset = -4
        Me.rbtn_xF.Name = "rbtn_xF"
        Me.rbtn_xF.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.rbtn_xF.UncheckedState.BorderThickness = 1
        Me.rbtn_xF.UncheckedState.FillColor = System.Drawing.Color.White
        Me.rbtn_xF.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'rbtn_jF
        '
        resources.ApplyResources(Me.rbtn_jF, "rbtn_jF")
        Me.rbtn_jF.CheckedState.BorderColor = System.Drawing.Color.Silver
        Me.rbtn_jF.CheckedState.BorderThickness = 0
        Me.rbtn_jF.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rbtn_jF.CheckedState.InnerColor = System.Drawing.Color.White
        Me.rbtn_jF.CheckedState.InnerOffset = -4
        Me.rbtn_jF.Name = "rbtn_jF"
        Me.rbtn_jF.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.rbtn_jF.UncheckedState.BorderThickness = 1
        Me.rbtn_jF.UncheckedState.FillColor = System.Drawing.Color.White
        Me.rbtn_jF.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'rbnt_vF
        '
        resources.ApplyResources(Me.rbnt_vF, "rbnt_vF")
        Me.rbnt_vF.CheckedState.BorderColor = System.Drawing.Color.Silver
        Me.rbnt_vF.CheckedState.BorderThickness = 0
        Me.rbnt_vF.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rbnt_vF.CheckedState.InnerColor = System.Drawing.Color.White
        Me.rbnt_vF.CheckedState.InnerOffset = -4
        Me.rbnt_vF.Name = "rbnt_vF"
        Me.rbnt_vF.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.rbnt_vF.UncheckedState.BorderThickness = 1
        Me.rbnt_vF.UncheckedState.FillColor = System.Drawing.Color.White
        Me.rbnt_vF.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'rbtn_sF
        '
        resources.ApplyResources(Me.rbtn_sF, "rbtn_sF")
        Me.rbtn_sF.CheckedState.BorderColor = System.Drawing.Color.Silver
        Me.rbtn_sF.CheckedState.BorderThickness = 0
        Me.rbtn_sF.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rbtn_sF.CheckedState.InnerColor = System.Drawing.Color.White
        Me.rbtn_sF.CheckedState.InnerOffset = -4
        Me.rbtn_sF.Name = "rbtn_sF"
        Me.rbtn_sF.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.rbtn_sF.UncheckedState.BorderThickness = 1
        Me.rbtn_sF.UncheckedState.FillColor = System.Drawing.Color.White
        Me.rbtn_sF.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'rbtn_lF
        '
        resources.ApplyResources(Me.rbtn_lF, "rbtn_lF")
        Me.rbtn_lF.CheckedState.BorderColor = System.Drawing.Color.Silver
        Me.rbtn_lF.CheckedState.BorderThickness = 0
        Me.rbtn_lF.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rbtn_lF.CheckedState.InnerColor = System.Drawing.Color.White
        Me.rbtn_lF.CheckedState.InnerOffset = -4
        Me.rbtn_lF.Name = "rbtn_lF"
        Me.rbtn_lF.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.rbtn_lF.UncheckedState.BorderThickness = 1
        Me.rbtn_lF.UncheckedState.FillColor = System.Drawing.Color.White
        Me.rbtn_lF.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'RbtnD
        '
        resources.ApplyResources(Me.RbtnD, "RbtnD")
        Me.RbtnD.CheckedState.BorderColor = System.Drawing.Color.Silver
        Me.RbtnD.CheckedState.BorderThickness = 0
        Me.RbtnD.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RbtnD.CheckedState.InnerColor = System.Drawing.Color.White
        Me.RbtnD.CheckedState.InnerOffset = -4
        Me.RbtnD.Name = "RbtnD"
        Me.RbtnD.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.RbtnD.UncheckedState.BorderThickness = 1
        Me.RbtnD.UncheckedState.FillColor = System.Drawing.Color.White
        Me.RbtnD.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'RbtnM
        '
        resources.ApplyResources(Me.RbtnM, "RbtnM")
        Me.RbtnM.CheckedState.BorderColor = System.Drawing.Color.Silver
        Me.RbtnM.CheckedState.BorderThickness = 0
        Me.RbtnM.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RbtnM.CheckedState.InnerColor = System.Drawing.Color.White
        Me.RbtnM.CheckedState.InnerOffset = -4
        Me.RbtnM.Name = "RbtnM"
        Me.RbtnM.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.RbtnM.UncheckedState.BorderThickness = 1
        Me.RbtnM.UncheckedState.FillColor = System.Drawing.Color.White
        Me.RbtnM.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'RbtnX
        '
        resources.ApplyResources(Me.RbtnX, "RbtnX")
        Me.RbtnX.CheckedState.BorderColor = System.Drawing.Color.Silver
        Me.RbtnX.CheckedState.BorderThickness = 0
        Me.RbtnX.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RbtnX.CheckedState.InnerColor = System.Drawing.Color.White
        Me.RbtnX.CheckedState.InnerOffset = -4
        Me.RbtnX.Name = "RbtnX"
        Me.RbtnX.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.RbtnX.UncheckedState.BorderThickness = 1
        Me.RbtnX.UncheckedState.FillColor = System.Drawing.Color.White
        Me.RbtnX.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'RbtnJ
        '
        resources.ApplyResources(Me.RbtnJ, "RbtnJ")
        Me.RbtnJ.CheckedState.BorderColor = System.Drawing.Color.Silver
        Me.RbtnJ.CheckedState.BorderThickness = 0
        Me.RbtnJ.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RbtnJ.CheckedState.InnerColor = System.Drawing.Color.White
        Me.RbtnJ.CheckedState.InnerOffset = -4
        Me.RbtnJ.Name = "RbtnJ"
        Me.RbtnJ.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.RbtnJ.UncheckedState.BorderThickness = 1
        Me.RbtnJ.UncheckedState.FillColor = System.Drawing.Color.White
        Me.RbtnJ.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'RbtnV
        '
        resources.ApplyResources(Me.RbtnV, "RbtnV")
        Me.RbtnV.CheckedState.BorderColor = System.Drawing.Color.Silver
        Me.RbtnV.CheckedState.BorderThickness = 0
        Me.RbtnV.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RbtnV.CheckedState.InnerColor = System.Drawing.Color.White
        Me.RbtnV.CheckedState.InnerOffset = -4
        Me.RbtnV.Name = "RbtnV"
        Me.RbtnV.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.RbtnV.UncheckedState.BorderThickness = 1
        Me.RbtnV.UncheckedState.FillColor = System.Drawing.Color.White
        Me.RbtnV.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'RbtnS
        '
        resources.ApplyResources(Me.RbtnS, "RbtnS")
        Me.RbtnS.CheckedState.BorderColor = System.Drawing.Color.Silver
        Me.RbtnS.CheckedState.BorderThickness = 0
        Me.RbtnS.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RbtnS.CheckedState.InnerColor = System.Drawing.Color.White
        Me.RbtnS.CheckedState.InnerOffset = -4
        Me.RbtnS.Name = "RbtnS"
        Me.RbtnS.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.RbtnS.UncheckedState.BorderThickness = 1
        Me.RbtnS.UncheckedState.FillColor = System.Drawing.Color.White
        Me.RbtnS.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'RbtnL
        '
        resources.ApplyResources(Me.RbtnL, "RbtnL")
        Me.RbtnL.CheckedState.BorderColor = System.Drawing.Color.Silver
        Me.RbtnL.CheckedState.BorderThickness = 0
        Me.RbtnL.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RbtnL.CheckedState.InnerColor = System.Drawing.Color.White
        Me.RbtnL.CheckedState.InnerOffset = -4
        Me.RbtnL.Name = "RbtnL"
        Me.RbtnL.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.RbtnL.UncheckedState.BorderThickness = 1
        Me.RbtnL.UncheckedState.FillColor = System.Drawing.Color.White
        Me.RbtnL.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'CmbISucursal
        '
        Me.CmbISucursal.Animated = True
        Me.CmbISucursal.BackColor = System.Drawing.Color.Transparent
        Me.CmbISucursal.BorderRadius = 6
        Me.CmbISucursal.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CmbISucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbISucursal.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmbISucursal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmbISucursal.FocusedState.Parent = Me.CmbISucursal
        resources.ApplyResources(Me.CmbISucursal, "CmbISucursal")
        Me.CmbISucursal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CmbISucursal.HoverState.Parent = Me.CmbISucursal
        Me.CmbISucursal.Items.AddRange(New Object() {resources.GetString("CmbISucursal.Items"), resources.GetString("CmbISucursal.Items1")})
        Me.CmbISucursal.ItemsAppearance.Parent = Me.CmbISucursal
        Me.CmbISucursal.Name = "CmbISucursal"
        Me.CmbISucursal.ShadowDecoration.Parent = Me.CmbISucursal
        '
        'TxtICi
        '
        Me.TxtICi.Animated = True
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
        Me.TxtICi.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtICi.HoverState.Parent = Me.TxtICi
        resources.ApplyResources(Me.TxtICi, "TxtICi")
        Me.TxtICi.Name = "TxtICi"
        Me.TxtICi.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtICi.PlaceholderText = ""
        Me.TxtICi.SelectedText = ""
        Me.TxtICi.ShadowDecoration.Parent = Me.TxtICi
        '
        'lbl_a
        '
        resources.ApplyResources(Me.lbl_a, "lbl_a")
        Me.lbl_a.Name = "lbl_a"
        '
        'lbl_rango
        '
        resources.ApplyResources(Me.lbl_rango, "lbl_rango")
        Me.lbl_rango.Name = "lbl_rango"
        '
        'lbl_diasB
        '
        resources.ApplyResources(Me.lbl_diasB, "lbl_diasB")
        Me.lbl_diasB.Name = "lbl_diasB"
        '
        'lbl_sucursalB
        '
        resources.ApplyResources(Me.lbl_sucursalB, "lbl_sucursalB")
        Me.lbl_sucursalB.Name = "lbl_sucursalB"
        '
        'lbl_busqueda
        '
        resources.ApplyResources(Me.lbl_busqueda, "lbl_busqueda")
        Me.lbl_busqueda.Name = "lbl_busqueda"
        '
        'lbl_horaSalida
        '
        resources.ApplyResources(Me.lbl_horaSalida, "lbl_horaSalida")
        Me.lbl_horaSalida.Name = "lbl_horaSalida"
        '
        'lbl_horaEntrada
        '
        resources.ApplyResources(Me.lbl_horaEntrada, "lbl_horaEntrada")
        Me.lbl_horaEntrada.Name = "lbl_horaEntrada"
        '
        'lbl_dias
        '
        resources.ApplyResources(Me.lbl_dias, "lbl_dias")
        Me.lbl_dias.Name = "lbl_dias"
        '
        'lbl_sucursal
        '
        resources.ApplyResources(Me.lbl_sucursal, "lbl_sucursal")
        Me.lbl_sucursal.Name = "lbl_sucursal"
        '
        'lbl_ingresoHorarios
        '
        resources.ApplyResources(Me.lbl_ingresoHorarios, "lbl_ingresoHorarios")
        Me.lbl_ingresoHorarios.Name = "lbl_ingresoHorarios"
        '
        'lbl_ci
        '
        resources.ApplyResources(Me.lbl_ci, "lbl_ci")
        Me.lbl_ci.Name = "lbl_ci"
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
        'F_Medicos_Horarios
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnl_fondo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "F_Medicos_Horarios"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnl_fondo.ResumeLayout(False)
        CType(Me.dgw_horarios, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents lbl_a As Label
    Friend WithEvents TxtICi As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents CmbISucursal As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents RbtnJ As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents RbtnV As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents RbtnL As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents RbtnM As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents RbtnX As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents RbtnS As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents RbtnD As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents rbtn_dF As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents rbtn_mF As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents rbtn_xF As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents rbtn_jF As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents rbnt_vF As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents rbtn_sF As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents rbtn_lF As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents cmb_sucursalF As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents dtp_rangoSalida As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents dtp_rangoEntrada As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents dgw_horarios As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents btn_volver As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TxtIHoraOut As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtIHoraIn As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtBCi As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents LblBCi As Label
    Friend WithEvents BtnFiltrar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnEliminar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnModificar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnIngresar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnMinimize As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents BtnExit As Guna.UI2.WinForms.Guna2ControlBox
End Class
