<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F_Medicos_Horarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_Medicos_Horarios))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnl_fondo = New System.Windows.Forms.Panel()
        Me.dgw_horarios = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.btn_minimizar = New System.Windows.Forms.Button()
        Me.btn_cerrar = New System.Windows.Forms.Button()
        Me.pnl_ingresar = New System.Windows.Forms.Panel()
        Me.btn_volver = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_filtrar = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_ingresar = New Guna.UI2.WinForms.Guna2Button()
        Me.dtp_rangoSalida = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.dtp_rangoEntrada = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.cmb_sucursalF = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.dtp_horaSalida = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.dtp_horaEntrada = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.rbtn_dF = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.rbtn_mF = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.rbtn_xF = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.rbtn_jF = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.rbnt_vF = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.rbtn_sF = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.rbtn_lF = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.rbt_d = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.rbtn_m = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.rbtn_x = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.rbtn_j = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.rbt_v = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.rbt_s = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.rbtn_l = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.cmb_sucursal = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtb_ci = New Guna.UI2.WinForms.Guna2TextBox()
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
        Me.lbl_profesional = New System.Windows.Forms.Label()
        Me.pnl_fondo.SuspendLayout()
        CType(Me.dgw_horarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_ingresar.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl_fondo
        '
        Me.pnl_fondo.Controls.Add(Me.dgw_horarios)
        Me.pnl_fondo.Controls.Add(Me.btn_minimizar)
        Me.pnl_fondo.Controls.Add(Me.btn_cerrar)
        Me.pnl_fondo.Controls.Add(Me.pnl_ingresar)
        resources.ApplyResources(Me.pnl_fondo, "pnl_fondo")
        Me.pnl_fondo.Name = "pnl_fondo"
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
        'btn_minimizar
        '
        Me.btn_minimizar.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.btn_minimizar, "btn_minimizar")
        Me.btn_minimizar.Name = "btn_minimizar"
        Me.btn_minimizar.UseVisualStyleBackColor = True
        '
        'btn_cerrar
        '
        Me.btn_cerrar.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.btn_cerrar, "btn_cerrar")
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.UseVisualStyleBackColor = True
        '
        'pnl_ingresar
        '
        Me.pnl_ingresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.pnl_ingresar.Controls.Add(Me.btn_volver)
        Me.pnl_ingresar.Controls.Add(Me.btn_filtrar)
        Me.pnl_ingresar.Controls.Add(Me.btn_ingresar)
        Me.pnl_ingresar.Controls.Add(Me.dtp_rangoSalida)
        Me.pnl_ingresar.Controls.Add(Me.dtp_rangoEntrada)
        Me.pnl_ingresar.Controls.Add(Me.cmb_sucursalF)
        Me.pnl_ingresar.Controls.Add(Me.dtp_horaSalida)
        Me.pnl_ingresar.Controls.Add(Me.dtp_horaEntrada)
        Me.pnl_ingresar.Controls.Add(Me.rbtn_dF)
        Me.pnl_ingresar.Controls.Add(Me.rbtn_mF)
        Me.pnl_ingresar.Controls.Add(Me.rbtn_xF)
        Me.pnl_ingresar.Controls.Add(Me.rbtn_jF)
        Me.pnl_ingresar.Controls.Add(Me.rbnt_vF)
        Me.pnl_ingresar.Controls.Add(Me.rbtn_sF)
        Me.pnl_ingresar.Controls.Add(Me.rbtn_lF)
        Me.pnl_ingresar.Controls.Add(Me.rbt_d)
        Me.pnl_ingresar.Controls.Add(Me.rbtn_m)
        Me.pnl_ingresar.Controls.Add(Me.rbtn_x)
        Me.pnl_ingresar.Controls.Add(Me.rbtn_j)
        Me.pnl_ingresar.Controls.Add(Me.rbt_v)
        Me.pnl_ingresar.Controls.Add(Me.rbt_s)
        Me.pnl_ingresar.Controls.Add(Me.rbtn_l)
        Me.pnl_ingresar.Controls.Add(Me.cmb_sucursal)
        Me.pnl_ingresar.Controls.Add(Me.txtb_ci)
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
        Me.pnl_ingresar.Controls.Add(Me.lbl_profesional)
        resources.ApplyResources(Me.pnl_ingresar, "pnl_ingresar")
        Me.pnl_ingresar.Name = "pnl_ingresar"
        '
        'btn_volver
        '
        Me.btn_volver.Animated = True
        Me.btn_volver.BackColor = System.Drawing.Color.Transparent
        Me.btn_volver.BorderRadius = 16
        Me.btn_volver.CheckedState.Parent = Me.btn_volver
        Me.btn_volver.CustomImages.Parent = Me.btn_volver
        Me.btn_volver.FillColor = System.Drawing.Color.DarkCyan
        resources.ApplyResources(Me.btn_volver, "btn_volver")
        Me.btn_volver.ForeColor = System.Drawing.Color.White
        Me.btn_volver.HoverState.Parent = Me.btn_volver
        Me.btn_volver.Name = "btn_volver"
        Me.btn_volver.ShadowDecoration.Enabled = True
        Me.btn_volver.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.btn_volver.ShadowDecoration.Parent = Me.btn_volver
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
        'btn_ingresar
        '
        Me.btn_ingresar.Animated = True
        Me.btn_ingresar.BackColor = System.Drawing.Color.Transparent
        Me.btn_ingresar.BorderRadius = 26
        Me.btn_ingresar.CheckedState.Parent = Me.btn_ingresar
        Me.btn_ingresar.CustomImages.Parent = Me.btn_ingresar
        Me.btn_ingresar.FillColor = System.Drawing.Color.DarkCyan
        resources.ApplyResources(Me.btn_ingresar, "btn_ingresar")
        Me.btn_ingresar.ForeColor = System.Drawing.Color.White
        Me.btn_ingresar.HoverState.Parent = Me.btn_ingresar
        Me.btn_ingresar.Name = "btn_ingresar"
        Me.btn_ingresar.ShadowDecoration.Enabled = True
        Me.btn_ingresar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.btn_ingresar.ShadowDecoration.Parent = Me.btn_ingresar
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
        Me.cmb_sucursalF.ItemsAppearance.Parent = Me.cmb_sucursalF
        Me.cmb_sucursalF.Name = "cmb_sucursalF"
        Me.cmb_sucursalF.ShadowDecoration.Parent = Me.cmb_sucursalF
        '
        'dtp_horaSalida
        '
        Me.dtp_horaSalida.Animated = True
        Me.dtp_horaSalida.BorderRadius = 6
        Me.dtp_horaSalida.CheckedState.Parent = Me.dtp_horaSalida
        Me.dtp_horaSalida.FillColor = System.Drawing.Color.White
        resources.ApplyResources(Me.dtp_horaSalida, "dtp_horaSalida")
        Me.dtp_horaSalida.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtp_horaSalida.HoverState.Parent = Me.dtp_horaSalida
        Me.dtp_horaSalida.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtp_horaSalida.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtp_horaSalida.Name = "dtp_horaSalida"
        Me.dtp_horaSalida.ShadowDecoration.Parent = Me.dtp_horaSalida
        Me.dtp_horaSalida.Value = New Date(2020, 7, 24, 4, 22, 9, 55)
        '
        'dtp_horaEntrada
        '
        Me.dtp_horaEntrada.Animated = True
        Me.dtp_horaEntrada.BorderRadius = 6
        Me.dtp_horaEntrada.CheckedState.Parent = Me.dtp_horaEntrada
        Me.dtp_horaEntrada.FillColor = System.Drawing.Color.White
        resources.ApplyResources(Me.dtp_horaEntrada, "dtp_horaEntrada")
        Me.dtp_horaEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtp_horaEntrada.HoverState.Parent = Me.dtp_horaEntrada
        Me.dtp_horaEntrada.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtp_horaEntrada.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtp_horaEntrada.Name = "dtp_horaEntrada"
        Me.dtp_horaEntrada.ShadowDecoration.Parent = Me.dtp_horaEntrada
        Me.dtp_horaEntrada.Value = New Date(2020, 7, 24, 4, 22, 9, 55)
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
        'rbt_d
        '
        resources.ApplyResources(Me.rbt_d, "rbt_d")
        Me.rbt_d.CheckedState.BorderColor = System.Drawing.Color.Silver
        Me.rbt_d.CheckedState.BorderThickness = 0
        Me.rbt_d.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rbt_d.CheckedState.InnerColor = System.Drawing.Color.White
        Me.rbt_d.CheckedState.InnerOffset = -4
        Me.rbt_d.Name = "rbt_d"
        Me.rbt_d.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.rbt_d.UncheckedState.BorderThickness = 1
        Me.rbt_d.UncheckedState.FillColor = System.Drawing.Color.White
        Me.rbt_d.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'rbtn_m
        '
        resources.ApplyResources(Me.rbtn_m, "rbtn_m")
        Me.rbtn_m.CheckedState.BorderColor = System.Drawing.Color.Silver
        Me.rbtn_m.CheckedState.BorderThickness = 0
        Me.rbtn_m.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rbtn_m.CheckedState.InnerColor = System.Drawing.Color.White
        Me.rbtn_m.CheckedState.InnerOffset = -4
        Me.rbtn_m.Name = "rbtn_m"
        Me.rbtn_m.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.rbtn_m.UncheckedState.BorderThickness = 1
        Me.rbtn_m.UncheckedState.FillColor = System.Drawing.Color.White
        Me.rbtn_m.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'rbtn_x
        '
        resources.ApplyResources(Me.rbtn_x, "rbtn_x")
        Me.rbtn_x.CheckedState.BorderColor = System.Drawing.Color.Silver
        Me.rbtn_x.CheckedState.BorderThickness = 0
        Me.rbtn_x.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rbtn_x.CheckedState.InnerColor = System.Drawing.Color.White
        Me.rbtn_x.CheckedState.InnerOffset = -4
        Me.rbtn_x.Name = "rbtn_x"
        Me.rbtn_x.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.rbtn_x.UncheckedState.BorderThickness = 1
        Me.rbtn_x.UncheckedState.FillColor = System.Drawing.Color.White
        Me.rbtn_x.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'rbtn_j
        '
        resources.ApplyResources(Me.rbtn_j, "rbtn_j")
        Me.rbtn_j.CheckedState.BorderColor = System.Drawing.Color.Silver
        Me.rbtn_j.CheckedState.BorderThickness = 0
        Me.rbtn_j.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rbtn_j.CheckedState.InnerColor = System.Drawing.Color.White
        Me.rbtn_j.CheckedState.InnerOffset = -4
        Me.rbtn_j.Name = "rbtn_j"
        Me.rbtn_j.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.rbtn_j.UncheckedState.BorderThickness = 1
        Me.rbtn_j.UncheckedState.FillColor = System.Drawing.Color.White
        Me.rbtn_j.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'rbt_v
        '
        resources.ApplyResources(Me.rbt_v, "rbt_v")
        Me.rbt_v.CheckedState.BorderColor = System.Drawing.Color.Silver
        Me.rbt_v.CheckedState.BorderThickness = 0
        Me.rbt_v.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rbt_v.CheckedState.InnerColor = System.Drawing.Color.White
        Me.rbt_v.CheckedState.InnerOffset = -4
        Me.rbt_v.Name = "rbt_v"
        Me.rbt_v.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.rbt_v.UncheckedState.BorderThickness = 1
        Me.rbt_v.UncheckedState.FillColor = System.Drawing.Color.White
        Me.rbt_v.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'rbt_s
        '
        resources.ApplyResources(Me.rbt_s, "rbt_s")
        Me.rbt_s.CheckedState.BorderColor = System.Drawing.Color.Silver
        Me.rbt_s.CheckedState.BorderThickness = 0
        Me.rbt_s.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rbt_s.CheckedState.InnerColor = System.Drawing.Color.White
        Me.rbt_s.CheckedState.InnerOffset = -4
        Me.rbt_s.Name = "rbt_s"
        Me.rbt_s.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.rbt_s.UncheckedState.BorderThickness = 1
        Me.rbt_s.UncheckedState.FillColor = System.Drawing.Color.White
        Me.rbt_s.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'rbtn_l
        '
        resources.ApplyResources(Me.rbtn_l, "rbtn_l")
        Me.rbtn_l.CheckedState.BorderColor = System.Drawing.Color.Silver
        Me.rbtn_l.CheckedState.BorderThickness = 0
        Me.rbtn_l.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rbtn_l.CheckedState.InnerColor = System.Drawing.Color.White
        Me.rbtn_l.CheckedState.InnerOffset = -4
        Me.rbtn_l.Name = "rbtn_l"
        Me.rbtn_l.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.rbtn_l.UncheckedState.BorderThickness = 1
        Me.rbtn_l.UncheckedState.FillColor = System.Drawing.Color.White
        Me.rbtn_l.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'cmb_sucursal
        '
        Me.cmb_sucursal.Animated = True
        Me.cmb_sucursal.BackColor = System.Drawing.Color.Transparent
        Me.cmb_sucursal.BorderRadius = 6
        Me.cmb_sucursal.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_sucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_sucursal.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_sucursal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_sucursal.FocusedState.Parent = Me.cmb_sucursal
        resources.ApplyResources(Me.cmb_sucursal, "cmb_sucursal")
        Me.cmb_sucursal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmb_sucursal.HoverState.Parent = Me.cmb_sucursal
        Me.cmb_sucursal.ItemsAppearance.Parent = Me.cmb_sucursal
        Me.cmb_sucursal.Name = "cmb_sucursal"
        Me.cmb_sucursal.ShadowDecoration.Parent = Me.cmb_sucursal
        '
        'txtb_ci
        '
        Me.txtb_ci.Animated = True
        Me.txtb_ci.BorderRadius = 6
        Me.txtb_ci.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtb_ci.DefaultText = ""
        Me.txtb_ci.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtb_ci.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtb_ci.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtb_ci.DisabledState.Parent = Me.txtb_ci
        Me.txtb_ci.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtb_ci.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtb_ci.FocusedState.Parent = Me.txtb_ci
        Me.txtb_ci.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtb_ci.HoverState.Parent = Me.txtb_ci
        resources.ApplyResources(Me.txtb_ci, "txtb_ci")
        Me.txtb_ci.Name = "txtb_ci"
        Me.txtb_ci.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtb_ci.PlaceholderText = ""
        Me.txtb_ci.SelectedText = ""
        Me.txtb_ci.ShadowDecoration.Parent = Me.txtb_ci
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
        'lbl_profesional
        '
        resources.ApplyResources(Me.lbl_profesional, "lbl_profesional")
        Me.lbl_profesional.Name = "lbl_profesional"
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
    Friend WithEvents lbl_profesional As Label
    Friend WithEvents btn_minimizar As Button
    Friend WithEvents btn_cerrar As Button
    Friend WithEvents lbl_a As Label
    Friend WithEvents txtb_ci As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cmb_sucursal As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents rbtn_j As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents rbt_v As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents rbtn_l As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents rbtn_m As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents rbtn_x As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents rbt_s As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents rbt_d As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents rbtn_dF As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents rbtn_mF As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents rbtn_xF As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents rbtn_jF As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents rbnt_vF As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents rbtn_sF As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents rbtn_lF As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents cmb_sucursalF As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents dtp_horaSalida As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents dtp_horaEntrada As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents btn_ingresar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dtp_rangoSalida As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents dtp_rangoEntrada As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents dgw_horarios As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents btn_volver As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_filtrar As Guna.UI2.WinForms.Guna2Button
End Class
