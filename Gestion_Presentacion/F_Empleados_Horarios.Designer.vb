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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_Empleados_Horarios))
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnl_fondo = New System.Windows.Forms.Panel()
        Me.DgvEmpleados = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.BtnMinimize = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.BtnExit = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.BtnEliminar = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnModificar = New Guna.UI2.WinForms.Guna2Button()
        Me.pnl_ingresar = New System.Windows.Forms.Panel()
        Me.TxtISalida = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtIEntrada = New Guna.UI2.WinForms.Guna2TextBox()
        Me.ChkIDomingo = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.ChkISabado = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.ChkIViernes = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.ChkIJueves = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.ChkIMiercoles = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.ChkIMartes = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.ChkILunes = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.Guna2CheckBox5 = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.Guna2CheckBox6 = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.Guna2CheckBox7 = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.Guna2CheckBox2 = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.Guna2CheckBox3 = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.Guna2CheckBox1 = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.ChkL = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.BtnFiltrar = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnIngresar = New Guna.UI2.WinForms.Guna2Button()
        Me.TxtICi = New Guna.UI2.WinForms.Guna2TextBox()
        Me.LblBCi = New System.Windows.Forms.Label()
        Me.TxtIHoraOut = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtIHoraIn = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btn_volver = New Guna.UI2.WinForms.Guna2Button()
        Me.CmbISucursal = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.CmbBSucursal = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.TxtBCi = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lbl_a = New System.Windows.Forms.Label()
        Me.lbl_rango = New System.Windows.Forms.Label()
        Me.lbl_diasB = New System.Windows.Forms.Label()
        Me.lbl_sucursalB = New System.Windows.Forms.Label()
        Me.LblIngreso = New System.Windows.Forms.Label()
        Me.lbl_horaSalida = New System.Windows.Forms.Label()
        Me.lbl_horaEntrada = New System.Windows.Forms.Label()
        Me.lbl_dias = New System.Windows.Forms.Label()
        Me.lbl_sucursal = New System.Windows.Forms.Label()
        Me.LblBusqueda = New System.Windows.Forms.Label()
        Me.LblCi = New System.Windows.Forms.Label()
        Me.pnl_fondo.SuspendLayout()
        CType(Me.DgvEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_ingresar.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl_fondo
        '
        Me.pnl_fondo.Controls.Add(Me.DgvEmpleados)
        Me.pnl_fondo.Controls.Add(Me.BtnMinimize)
        Me.pnl_fondo.Controls.Add(Me.BtnExit)
        Me.pnl_fondo.Controls.Add(Me.BtnEliminar)
        Me.pnl_fondo.Controls.Add(Me.BtnModificar)
        Me.pnl_fondo.Controls.Add(Me.pnl_ingresar)
        resources.ApplyResources(Me.pnl_fondo, "pnl_fondo")
        Me.pnl_fondo.Name = "pnl_fondo"
        '
        'DgvEmpleados
        '
        Me.DgvEmpleados.AllowUserToAddRows = False
        Me.DgvEmpleados.AllowUserToDeleteRows = False
        Me.DgvEmpleados.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.DgvEmpleados.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DgvEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvEmpleados.BackgroundColor = System.Drawing.Color.White
        Me.DgvEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvEmpleados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgvEmpleados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(123, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvEmpleados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        resources.ApplyResources(Me.DgvEmpleados, "DgvEmpleados")
        Me.DgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(222, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvEmpleados.DefaultCellStyle = DataGridViewCellStyle6
        Me.DgvEmpleados.EnableHeadersVisualStyles = False
        Me.DgvEmpleados.GridColor = System.Drawing.Color.Gray
        Me.DgvEmpleados.Name = "DgvEmpleados"
        Me.DgvEmpleados.ReadOnly = True
        Me.DgvEmpleados.RowHeadersVisible = False
        Me.DgvEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvEmpleados.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.DgvEmpleados.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.DgvEmpleados.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DgvEmpleados.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DgvEmpleados.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DgvEmpleados.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DgvEmpleados.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DgvEmpleados.ThemeStyle.GridColor = System.Drawing.Color.Gray
        Me.DgvEmpleados.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.DgvEmpleados.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvEmpleados.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DgvEmpleados.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DgvEmpleados.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgvEmpleados.ThemeStyle.HeaderStyle.Height = 40
        Me.DgvEmpleados.ThemeStyle.ReadOnly = True
        Me.DgvEmpleados.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DgvEmpleados.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgvEmpleados.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DgvEmpleados.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DgvEmpleados.ThemeStyle.RowsStyle.Height = 22
        Me.DgvEmpleados.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.DgvEmpleados.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
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
        'pnl_ingresar
        '
        Me.pnl_ingresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.pnl_ingresar.Controls.Add(Me.TxtISalida)
        Me.pnl_ingresar.Controls.Add(Me.TxtIEntrada)
        Me.pnl_ingresar.Controls.Add(Me.ChkIDomingo)
        Me.pnl_ingresar.Controls.Add(Me.ChkISabado)
        Me.pnl_ingresar.Controls.Add(Me.ChkIViernes)
        Me.pnl_ingresar.Controls.Add(Me.ChkIJueves)
        Me.pnl_ingresar.Controls.Add(Me.ChkIMiercoles)
        Me.pnl_ingresar.Controls.Add(Me.ChkIMartes)
        Me.pnl_ingresar.Controls.Add(Me.ChkILunes)
        Me.pnl_ingresar.Controls.Add(Me.Guna2CheckBox5)
        Me.pnl_ingresar.Controls.Add(Me.Guna2CheckBox6)
        Me.pnl_ingresar.Controls.Add(Me.Guna2CheckBox7)
        Me.pnl_ingresar.Controls.Add(Me.Guna2CheckBox2)
        Me.pnl_ingresar.Controls.Add(Me.Guna2CheckBox3)
        Me.pnl_ingresar.Controls.Add(Me.Guna2CheckBox1)
        Me.pnl_ingresar.Controls.Add(Me.ChkL)
        Me.pnl_ingresar.Controls.Add(Me.BtnFiltrar)
        Me.pnl_ingresar.Controls.Add(Me.BtnIngresar)
        Me.pnl_ingresar.Controls.Add(Me.TxtICi)
        Me.pnl_ingresar.Controls.Add(Me.LblBCi)
        Me.pnl_ingresar.Controls.Add(Me.TxtIHoraOut)
        Me.pnl_ingresar.Controls.Add(Me.TxtIHoraIn)
        Me.pnl_ingresar.Controls.Add(Me.btn_volver)
        Me.pnl_ingresar.Controls.Add(Me.CmbISucursal)
        Me.pnl_ingresar.Controls.Add(Me.CmbBSucursal)
        Me.pnl_ingresar.Controls.Add(Me.TxtBCi)
        Me.pnl_ingresar.Controls.Add(Me.lbl_a)
        Me.pnl_ingresar.Controls.Add(Me.lbl_rango)
        Me.pnl_ingresar.Controls.Add(Me.lbl_diasB)
        Me.pnl_ingresar.Controls.Add(Me.lbl_sucursalB)
        Me.pnl_ingresar.Controls.Add(Me.LblIngreso)
        Me.pnl_ingresar.Controls.Add(Me.lbl_horaSalida)
        Me.pnl_ingresar.Controls.Add(Me.lbl_horaEntrada)
        Me.pnl_ingresar.Controls.Add(Me.lbl_dias)
        Me.pnl_ingresar.Controls.Add(Me.lbl_sucursal)
        Me.pnl_ingresar.Controls.Add(Me.LblBusqueda)
        Me.pnl_ingresar.Controls.Add(Me.LblCi)
        resources.ApplyResources(Me.pnl_ingresar, "pnl_ingresar")
        Me.pnl_ingresar.Name = "pnl_ingresar"
        '
        'TxtISalida
        '
        Me.TxtISalida.BorderRadius = 6
        Me.TxtISalida.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtISalida.DefaultText = ""
        Me.TxtISalida.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtISalida.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtISalida.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtISalida.DisabledState.Parent = Me.TxtISalida
        Me.TxtISalida.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtISalida.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtISalida.FocusedState.Parent = Me.TxtISalida
        Me.TxtISalida.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtISalida.HoverState.Parent = Me.TxtISalida
        resources.ApplyResources(Me.TxtISalida, "TxtISalida")
        Me.TxtISalida.Name = "TxtISalida"
        Me.TxtISalida.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtISalida.PlaceholderText = "21:10"
        Me.TxtISalida.SelectedText = ""
        Me.TxtISalida.ShadowDecoration.Parent = Me.TxtISalida
        '
        'TxtIEntrada
        '
        Me.TxtIEntrada.BorderRadius = 6
        Me.TxtIEntrada.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtIEntrada.DefaultText = ""
        Me.TxtIEntrada.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtIEntrada.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtIEntrada.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtIEntrada.DisabledState.Parent = Me.TxtIEntrada
        Me.TxtIEntrada.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtIEntrada.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtIEntrada.FocusedState.Parent = Me.TxtIEntrada
        Me.TxtIEntrada.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtIEntrada.HoverState.Parent = Me.TxtIEntrada
        resources.ApplyResources(Me.TxtIEntrada, "TxtIEntrada")
        Me.TxtIEntrada.Name = "TxtIEntrada"
        Me.TxtIEntrada.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtIEntrada.PlaceholderText = "12:15"
        Me.TxtIEntrada.SelectedText = ""
        Me.TxtIEntrada.ShadowDecoration.Parent = Me.TxtIEntrada
        '
        'ChkIDomingo
        '
        resources.ApplyResources(Me.ChkIDomingo, "ChkIDomingo")
        Me.ChkIDomingo.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkIDomingo.CheckedState.BorderRadius = 0
        Me.ChkIDomingo.CheckedState.BorderThickness = 0
        Me.ChkIDomingo.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkIDomingo.Name = "ChkIDomingo"
        Me.ChkIDomingo.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.ChkIDomingo.UncheckedState.BorderRadius = 0
        Me.ChkIDomingo.UncheckedState.BorderThickness = 0
        Me.ChkIDomingo.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'ChkISabado
        '
        resources.ApplyResources(Me.ChkISabado, "ChkISabado")
        Me.ChkISabado.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkISabado.CheckedState.BorderRadius = 0
        Me.ChkISabado.CheckedState.BorderThickness = 0
        Me.ChkISabado.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkISabado.Name = "ChkISabado"
        Me.ChkISabado.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.ChkISabado.UncheckedState.BorderRadius = 0
        Me.ChkISabado.UncheckedState.BorderThickness = 0
        Me.ChkISabado.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'ChkIViernes
        '
        resources.ApplyResources(Me.ChkIViernes, "ChkIViernes")
        Me.ChkIViernes.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkIViernes.CheckedState.BorderRadius = 0
        Me.ChkIViernes.CheckedState.BorderThickness = 0
        Me.ChkIViernes.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkIViernes.Name = "ChkIViernes"
        Me.ChkIViernes.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.ChkIViernes.UncheckedState.BorderRadius = 0
        Me.ChkIViernes.UncheckedState.BorderThickness = 0
        Me.ChkIViernes.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'ChkIJueves
        '
        resources.ApplyResources(Me.ChkIJueves, "ChkIJueves")
        Me.ChkIJueves.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkIJueves.CheckedState.BorderRadius = 0
        Me.ChkIJueves.CheckedState.BorderThickness = 0
        Me.ChkIJueves.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkIJueves.Name = "ChkIJueves"
        Me.ChkIJueves.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.ChkIJueves.UncheckedState.BorderRadius = 0
        Me.ChkIJueves.UncheckedState.BorderThickness = 0
        Me.ChkIJueves.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'ChkIMiercoles
        '
        resources.ApplyResources(Me.ChkIMiercoles, "ChkIMiercoles")
        Me.ChkIMiercoles.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkIMiercoles.CheckedState.BorderRadius = 0
        Me.ChkIMiercoles.CheckedState.BorderThickness = 0
        Me.ChkIMiercoles.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkIMiercoles.Name = "ChkIMiercoles"
        Me.ChkIMiercoles.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.ChkIMiercoles.UncheckedState.BorderRadius = 0
        Me.ChkIMiercoles.UncheckedState.BorderThickness = 0
        Me.ChkIMiercoles.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'ChkIMartes
        '
        resources.ApplyResources(Me.ChkIMartes, "ChkIMartes")
        Me.ChkIMartes.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkIMartes.CheckedState.BorderRadius = 0
        Me.ChkIMartes.CheckedState.BorderThickness = 0
        Me.ChkIMartes.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkIMartes.Name = "ChkIMartes"
        Me.ChkIMartes.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.ChkIMartes.UncheckedState.BorderRadius = 0
        Me.ChkIMartes.UncheckedState.BorderThickness = 0
        Me.ChkIMartes.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'ChkILunes
        '
        resources.ApplyResources(Me.ChkILunes, "ChkILunes")
        Me.ChkILunes.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkILunes.CheckedState.BorderRadius = 0
        Me.ChkILunes.CheckedState.BorderThickness = 0
        Me.ChkILunes.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkILunes.Name = "ChkILunes"
        Me.ChkILunes.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.ChkILunes.UncheckedState.BorderRadius = 0
        Me.ChkILunes.UncheckedState.BorderThickness = 0
        Me.ChkILunes.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'Guna2CheckBox5
        '
        resources.ApplyResources(Me.Guna2CheckBox5, "Guna2CheckBox5")
        Me.Guna2CheckBox5.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2CheckBox5.CheckedState.BorderRadius = 0
        Me.Guna2CheckBox5.CheckedState.BorderThickness = 0
        Me.Guna2CheckBox5.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2CheckBox5.Name = "Guna2CheckBox5"
        Me.Guna2CheckBox5.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2CheckBox5.UncheckedState.BorderRadius = 0
        Me.Guna2CheckBox5.UncheckedState.BorderThickness = 0
        Me.Guna2CheckBox5.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'Guna2CheckBox6
        '
        resources.ApplyResources(Me.Guna2CheckBox6, "Guna2CheckBox6")
        Me.Guna2CheckBox6.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2CheckBox6.CheckedState.BorderRadius = 0
        Me.Guna2CheckBox6.CheckedState.BorderThickness = 0
        Me.Guna2CheckBox6.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2CheckBox6.Name = "Guna2CheckBox6"
        Me.Guna2CheckBox6.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2CheckBox6.UncheckedState.BorderRadius = 0
        Me.Guna2CheckBox6.UncheckedState.BorderThickness = 0
        Me.Guna2CheckBox6.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'Guna2CheckBox7
        '
        resources.ApplyResources(Me.Guna2CheckBox7, "Guna2CheckBox7")
        Me.Guna2CheckBox7.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2CheckBox7.CheckedState.BorderRadius = 0
        Me.Guna2CheckBox7.CheckedState.BorderThickness = 0
        Me.Guna2CheckBox7.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2CheckBox7.Name = "Guna2CheckBox7"
        Me.Guna2CheckBox7.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2CheckBox7.UncheckedState.BorderRadius = 0
        Me.Guna2CheckBox7.UncheckedState.BorderThickness = 0
        Me.Guna2CheckBox7.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'Guna2CheckBox2
        '
        resources.ApplyResources(Me.Guna2CheckBox2, "Guna2CheckBox2")
        Me.Guna2CheckBox2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2CheckBox2.CheckedState.BorderRadius = 0
        Me.Guna2CheckBox2.CheckedState.BorderThickness = 0
        Me.Guna2CheckBox2.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2CheckBox2.Name = "Guna2CheckBox2"
        Me.Guna2CheckBox2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2CheckBox2.UncheckedState.BorderRadius = 0
        Me.Guna2CheckBox2.UncheckedState.BorderThickness = 0
        Me.Guna2CheckBox2.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'Guna2CheckBox3
        '
        resources.ApplyResources(Me.Guna2CheckBox3, "Guna2CheckBox3")
        Me.Guna2CheckBox3.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2CheckBox3.CheckedState.BorderRadius = 0
        Me.Guna2CheckBox3.CheckedState.BorderThickness = 0
        Me.Guna2CheckBox3.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2CheckBox3.Name = "Guna2CheckBox3"
        Me.Guna2CheckBox3.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2CheckBox3.UncheckedState.BorderRadius = 0
        Me.Guna2CheckBox3.UncheckedState.BorderThickness = 0
        Me.Guna2CheckBox3.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'Guna2CheckBox1
        '
        resources.ApplyResources(Me.Guna2CheckBox1, "Guna2CheckBox1")
        Me.Guna2CheckBox1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2CheckBox1.CheckedState.BorderRadius = 0
        Me.Guna2CheckBox1.CheckedState.BorderThickness = 0
        Me.Guna2CheckBox1.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2CheckBox1.Name = "Guna2CheckBox1"
        Me.Guna2CheckBox1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2CheckBox1.UncheckedState.BorderRadius = 0
        Me.Guna2CheckBox1.UncheckedState.BorderThickness = 0
        Me.Guna2CheckBox1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'ChkL
        '
        resources.ApplyResources(Me.ChkL, "ChkL")
        Me.ChkL.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkL.CheckedState.BorderRadius = 0
        Me.ChkL.CheckedState.BorderThickness = 0
        Me.ChkL.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkL.Name = "ChkL"
        Me.ChkL.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.ChkL.UncheckedState.BorderRadius = 0
        Me.ChkL.UncheckedState.BorderThickness = 0
        Me.ChkL.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
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
        'CmbBSucursal
        '
        Me.CmbBSucursal.Animated = True
        Me.CmbBSucursal.BackColor = System.Drawing.Color.Transparent
        Me.CmbBSucursal.BorderRadius = 6
        Me.CmbBSucursal.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CmbBSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbBSucursal.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmbBSucursal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmbBSucursal.FocusedState.Parent = Me.CmbBSucursal
        resources.ApplyResources(Me.CmbBSucursal, "CmbBSucursal")
        Me.CmbBSucursal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CmbBSucursal.HoverState.Parent = Me.CmbBSucursal
        Me.CmbBSucursal.Items.AddRange(New Object() {resources.GetString("CmbBSucursal.Items"), resources.GetString("CmbBSucursal.Items1")})
        Me.CmbBSucursal.ItemsAppearance.Parent = Me.CmbBSucursal
        Me.CmbBSucursal.Name = "CmbBSucursal"
        Me.CmbBSucursal.ShadowDecoration.Parent = Me.CmbBSucursal
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
        'LblIngreso
        '
        resources.ApplyResources(Me.LblIngreso, "LblIngreso")
        Me.LblIngreso.Name = "LblIngreso"
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
        'LblBusqueda
        '
        resources.ApplyResources(Me.LblBusqueda, "LblBusqueda")
        Me.LblBusqueda.Name = "LblBusqueda"
        '
        'LblCi
        '
        resources.ApplyResources(Me.LblCi, "LblCi")
        Me.LblCi.Name = "LblCi"
        '
        'F_Empleados_Horarios
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnl_fondo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "F_Empleados_Horarios"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnl_fondo.ResumeLayout(False)
        CType(Me.DgvEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_ingresar.ResumeLayout(False)
        Me.pnl_ingresar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnl_fondo As Panel
    Friend WithEvents pnl_ingresar As Panel
    Friend WithEvents lbl_rango As Label
    Friend WithEvents lbl_diasB As Label
    Friend WithEvents lbl_sucursalB As Label
    Friend WithEvents LblIngreso As Label
    Friend WithEvents lbl_horaSalida As Label
    Friend WithEvents lbl_horaEntrada As Label
    Friend WithEvents lbl_dias As Label
    Friend WithEvents lbl_sucursal As Label
    Friend WithEvents LblBusqueda As Label
    Friend WithEvents LblCi As Label
    Friend WithEvents lbl_a As Label
    Friend WithEvents TxtBCi As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents CmbBSucursal As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents CmbISucursal As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents btn_volver As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TxtIHoraOut As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtIHoraIn As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtICi As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents LblBCi As Label
    Friend WithEvents BtnFiltrar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnEliminar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnModificar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnIngresar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnMinimize As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents BtnExit As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents DgvEmpleados As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents ChkIDomingo As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents ChkISabado As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents ChkIViernes As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents ChkIJueves As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents ChkIMiercoles As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents ChkIMartes As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents ChkILunes As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents Guna2CheckBox5 As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents Guna2CheckBox6 As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents Guna2CheckBox7 As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents Guna2CheckBox2 As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents Guna2CheckBox3 As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents Guna2CheckBox1 As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents ChkL As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents TxtISalida As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtIEntrada As Guna.UI2.WinForms.Guna2TextBox
End Class
