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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_Empleados_Horarios))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnl_fondo = New System.Windows.Forms.Panel()
        Me.DgvHorarios = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.BtnMinimize = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.BtnExit = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.BtnEliminar = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnModificar = New Guna.UI2.WinForms.Guna2Button()
        Me.pnl_ingresar = New System.Windows.Forms.Panel()
        Me.BtnVolver = New Guna.UI2.WinForms.Guna2Button()
        Me.TxtBSalida = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtBEntrada = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtISalida = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtIEntrada = New Guna.UI2.WinForms.Guna2TextBox()
        Me.ChkIDomingo = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.ChkISabado = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.ChkIViernes = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.ChkIJueves = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.ChkIMiercoles = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.ChkIMartes = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.ChkILunes = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.ChkBDomingo = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.ChkBSabado = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.ChkBViernes = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.ChkBJueves = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.ChkBMiercoles = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.ChkBMartes = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.ChkBLunes = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.BtnFiltrar = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnIngresar = New Guna.UI2.WinForms.Guna2Button()
        Me.TxtICi = New Guna.UI2.WinForms.Guna2TextBox()
        Me.LblBCi = New System.Windows.Forms.Label()
        Me.CmbISucursal = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.CmbBSucursal = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.TxtBCi = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lbl_a = New System.Windows.Forms.Label()
        Me.LblBRangoHorario = New System.Windows.Forms.Label()
        Me.LblBDias = New System.Windows.Forms.Label()
        Me.LblBSucursal = New System.Windows.Forms.Label()
        Me.LblIngreso = New System.Windows.Forms.Label()
        Me.LblIRango = New System.Windows.Forms.Label()
        Me.LblIDias = New System.Windows.Forms.Label()
        Me.LblISucursal = New System.Windows.Forms.Label()
        Me.LblBusqueda = New System.Windows.Forms.Label()
        Me.LblICi = New System.Windows.Forms.Label()
        Me.pnl_fondo.SuspendLayout()
        CType(Me.DgvHorarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_ingresar.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl_fondo
        '
        Me.pnl_fondo.Controls.Add(Me.DgvHorarios)
        Me.pnl_fondo.Controls.Add(Me.BtnMinimize)
        Me.pnl_fondo.Controls.Add(Me.BtnExit)
        Me.pnl_fondo.Controls.Add(Me.BtnEliminar)
        Me.pnl_fondo.Controls.Add(Me.BtnModificar)
        Me.pnl_fondo.Controls.Add(Me.pnl_ingresar)
        resources.ApplyResources(Me.pnl_fondo, "pnl_fondo")
        Me.pnl_fondo.Name = "pnl_fondo"
        '
        'DgvHorarios
        '
        Me.DgvHorarios.AllowUserToAddRows = False
        Me.DgvHorarios.AllowUserToDeleteRows = False
        Me.DgvHorarios.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.DgvHorarios.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvHorarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvHorarios.BackgroundColor = System.Drawing.Color.White
        Me.DgvHorarios.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvHorarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgvHorarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(123, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvHorarios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        resources.ApplyResources(Me.DgvHorarios, "DgvHorarios")
        Me.DgvHorarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(222, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvHorarios.DefaultCellStyle = DataGridViewCellStyle3
        Me.DgvHorarios.EnableHeadersVisualStyles = False
        Me.DgvHorarios.GridColor = System.Drawing.Color.Gray
        Me.DgvHorarios.Name = "DgvHorarios"
        Me.DgvHorarios.ReadOnly = True
        Me.DgvHorarios.RowHeadersVisible = False
        Me.DgvHorarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvHorarios.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.DgvHorarios.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.DgvHorarios.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DgvHorarios.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DgvHorarios.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DgvHorarios.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DgvHorarios.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DgvHorarios.ThemeStyle.GridColor = System.Drawing.Color.Gray
        Me.DgvHorarios.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.DgvHorarios.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvHorarios.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DgvHorarios.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DgvHorarios.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgvHorarios.ThemeStyle.HeaderStyle.Height = 40
        Me.DgvHorarios.ThemeStyle.ReadOnly = True
        Me.DgvHorarios.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DgvHorarios.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgvHorarios.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DgvHorarios.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DgvHorarios.ThemeStyle.RowsStyle.Height = 22
        Me.DgvHorarios.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.DgvHorarios.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
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
        Me.pnl_ingresar.Controls.Add(Me.BtnVolver)
        Me.pnl_ingresar.Controls.Add(Me.TxtBSalida)
        Me.pnl_ingresar.Controls.Add(Me.TxtBEntrada)
        Me.pnl_ingresar.Controls.Add(Me.Label1)
        Me.pnl_ingresar.Controls.Add(Me.TxtISalida)
        Me.pnl_ingresar.Controls.Add(Me.TxtIEntrada)
        Me.pnl_ingresar.Controls.Add(Me.ChkIDomingo)
        Me.pnl_ingresar.Controls.Add(Me.ChkISabado)
        Me.pnl_ingresar.Controls.Add(Me.ChkIViernes)
        Me.pnl_ingresar.Controls.Add(Me.ChkIJueves)
        Me.pnl_ingresar.Controls.Add(Me.ChkIMiercoles)
        Me.pnl_ingresar.Controls.Add(Me.ChkIMartes)
        Me.pnl_ingresar.Controls.Add(Me.ChkILunes)
        Me.pnl_ingresar.Controls.Add(Me.ChkBDomingo)
        Me.pnl_ingresar.Controls.Add(Me.ChkBSabado)
        Me.pnl_ingresar.Controls.Add(Me.ChkBViernes)
        Me.pnl_ingresar.Controls.Add(Me.ChkBJueves)
        Me.pnl_ingresar.Controls.Add(Me.ChkBMiercoles)
        Me.pnl_ingresar.Controls.Add(Me.ChkBMartes)
        Me.pnl_ingresar.Controls.Add(Me.ChkBLunes)
        Me.pnl_ingresar.Controls.Add(Me.BtnFiltrar)
        Me.pnl_ingresar.Controls.Add(Me.BtnIngresar)
        Me.pnl_ingresar.Controls.Add(Me.TxtICi)
        Me.pnl_ingresar.Controls.Add(Me.LblBCi)
        Me.pnl_ingresar.Controls.Add(Me.CmbISucursal)
        Me.pnl_ingresar.Controls.Add(Me.CmbBSucursal)
        Me.pnl_ingresar.Controls.Add(Me.TxtBCi)
        Me.pnl_ingresar.Controls.Add(Me.lbl_a)
        Me.pnl_ingresar.Controls.Add(Me.LblBRangoHorario)
        Me.pnl_ingresar.Controls.Add(Me.LblBDias)
        Me.pnl_ingresar.Controls.Add(Me.LblBSucursal)
        Me.pnl_ingresar.Controls.Add(Me.LblIngreso)
        Me.pnl_ingresar.Controls.Add(Me.LblIRango)
        Me.pnl_ingresar.Controls.Add(Me.LblIDias)
        Me.pnl_ingresar.Controls.Add(Me.LblISucursal)
        Me.pnl_ingresar.Controls.Add(Me.LblBusqueda)
        Me.pnl_ingresar.Controls.Add(Me.LblICi)
        resources.ApplyResources(Me.pnl_ingresar, "pnl_ingresar")
        Me.pnl_ingresar.Name = "pnl_ingresar"
        '
        'BtnVolver
        '
        Me.BtnVolver.Animated = True
        Me.BtnVolver.AutoRoundedCorners = True
        Me.BtnVolver.BorderRadius = 17
        Me.BtnVolver.CheckedState.Parent = Me.BtnVolver
        Me.BtnVolver.CustomImages.Parent = Me.BtnVolver
        Me.BtnVolver.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(123, Byte), Integer))
        resources.ApplyResources(Me.BtnVolver, "BtnVolver")
        Me.BtnVolver.ForeColor = System.Drawing.Color.White
        Me.BtnVolver.HoverState.Parent = Me.BtnVolver
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.ShadowDecoration.Parent = Me.BtnVolver
        '
        'TxtBSalida
        '
        Me.TxtBSalida.BorderRadius = 6
        Me.TxtBSalida.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtBSalida.DefaultText = ""
        Me.TxtBSalida.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtBSalida.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtBSalida.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtBSalida.DisabledState.Parent = Me.TxtBSalida
        Me.TxtBSalida.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtBSalida.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtBSalida.FocusedState.Parent = Me.TxtBSalida
        resources.ApplyResources(Me.TxtBSalida, "TxtBSalida")
        Me.TxtBSalida.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtBSalida.HoverState.Parent = Me.TxtBSalida
        Me.TxtBSalida.Name = "TxtBSalida"
        Me.TxtBSalida.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtBSalida.PlaceholderText = "21:10"
        Me.TxtBSalida.SelectedText = ""
        Me.TxtBSalida.ShadowDecoration.Parent = Me.TxtBSalida
        '
        'TxtBEntrada
        '
        Me.TxtBEntrada.BorderRadius = 6
        Me.TxtBEntrada.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtBEntrada.DefaultText = ""
        Me.TxtBEntrada.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtBEntrada.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtBEntrada.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtBEntrada.DisabledState.Parent = Me.TxtBEntrada
        Me.TxtBEntrada.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtBEntrada.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtBEntrada.FocusedState.Parent = Me.TxtBEntrada
        resources.ApplyResources(Me.TxtBEntrada, "TxtBEntrada")
        Me.TxtBEntrada.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtBEntrada.HoverState.Parent = Me.TxtBEntrada
        Me.TxtBEntrada.Name = "TxtBEntrada"
        Me.TxtBEntrada.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtBEntrada.PlaceholderText = "12:15"
        Me.TxtBEntrada.SelectedText = ""
        Me.TxtBEntrada.ShadowDecoration.Parent = Me.TxtBEntrada
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
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
        resources.ApplyResources(Me.TxtISalida, "TxtISalida")
        Me.TxtISalida.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtISalida.HoverState.Parent = Me.TxtISalida
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
        resources.ApplyResources(Me.TxtIEntrada, "TxtIEntrada")
        Me.TxtIEntrada.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtIEntrada.HoverState.Parent = Me.TxtIEntrada
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
        'ChkBDomingo
        '
        resources.ApplyResources(Me.ChkBDomingo, "ChkBDomingo")
        Me.ChkBDomingo.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkBDomingo.CheckedState.BorderRadius = 0
        Me.ChkBDomingo.CheckedState.BorderThickness = 0
        Me.ChkBDomingo.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkBDomingo.Name = "ChkBDomingo"
        Me.ChkBDomingo.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.ChkBDomingo.UncheckedState.BorderRadius = 0
        Me.ChkBDomingo.UncheckedState.BorderThickness = 0
        Me.ChkBDomingo.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'ChkBSabado
        '
        resources.ApplyResources(Me.ChkBSabado, "ChkBSabado")
        Me.ChkBSabado.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkBSabado.CheckedState.BorderRadius = 0
        Me.ChkBSabado.CheckedState.BorderThickness = 0
        Me.ChkBSabado.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkBSabado.Name = "ChkBSabado"
        Me.ChkBSabado.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.ChkBSabado.UncheckedState.BorderRadius = 0
        Me.ChkBSabado.UncheckedState.BorderThickness = 0
        Me.ChkBSabado.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'ChkBViernes
        '
        resources.ApplyResources(Me.ChkBViernes, "ChkBViernes")
        Me.ChkBViernes.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkBViernes.CheckedState.BorderRadius = 0
        Me.ChkBViernes.CheckedState.BorderThickness = 0
        Me.ChkBViernes.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkBViernes.Name = "ChkBViernes"
        Me.ChkBViernes.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.ChkBViernes.UncheckedState.BorderRadius = 0
        Me.ChkBViernes.UncheckedState.BorderThickness = 0
        Me.ChkBViernes.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'ChkBJueves
        '
        resources.ApplyResources(Me.ChkBJueves, "ChkBJueves")
        Me.ChkBJueves.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkBJueves.CheckedState.BorderRadius = 0
        Me.ChkBJueves.CheckedState.BorderThickness = 0
        Me.ChkBJueves.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkBJueves.Name = "ChkBJueves"
        Me.ChkBJueves.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.ChkBJueves.UncheckedState.BorderRadius = 0
        Me.ChkBJueves.UncheckedState.BorderThickness = 0
        Me.ChkBJueves.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'ChkBMiercoles
        '
        resources.ApplyResources(Me.ChkBMiercoles, "ChkBMiercoles")
        Me.ChkBMiercoles.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkBMiercoles.CheckedState.BorderRadius = 0
        Me.ChkBMiercoles.CheckedState.BorderThickness = 0
        Me.ChkBMiercoles.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkBMiercoles.Name = "ChkBMiercoles"
        Me.ChkBMiercoles.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.ChkBMiercoles.UncheckedState.BorderRadius = 0
        Me.ChkBMiercoles.UncheckedState.BorderThickness = 0
        Me.ChkBMiercoles.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'ChkBMartes
        '
        resources.ApplyResources(Me.ChkBMartes, "ChkBMartes")
        Me.ChkBMartes.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkBMartes.CheckedState.BorderRadius = 0
        Me.ChkBMartes.CheckedState.BorderThickness = 0
        Me.ChkBMartes.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkBMartes.Name = "ChkBMartes"
        Me.ChkBMartes.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.ChkBMartes.UncheckedState.BorderRadius = 0
        Me.ChkBMartes.UncheckedState.BorderThickness = 0
        Me.ChkBMartes.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'ChkBLunes
        '
        resources.ApplyResources(Me.ChkBLunes, "ChkBLunes")
        Me.ChkBLunes.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkBLunes.CheckedState.BorderRadius = 0
        Me.ChkBLunes.CheckedState.BorderThickness = 0
        Me.ChkBLunes.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkBLunes.Name = "ChkBLunes"
        Me.ChkBLunes.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.ChkBLunes.UncheckedState.BorderRadius = 0
        Me.ChkBLunes.UncheckedState.BorderThickness = 0
        Me.ChkBLunes.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
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
        resources.ApplyResources(Me.TxtICi, "TxtICi")
        Me.TxtICi.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtICi.HoverState.Parent = Me.TxtICi
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
        resources.ApplyResources(Me.TxtBCi, "TxtBCi")
        Me.TxtBCi.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtBCi.HoverState.Parent = Me.TxtBCi
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
        'LblBRangoHorario
        '
        resources.ApplyResources(Me.LblBRangoHorario, "LblBRangoHorario")
        Me.LblBRangoHorario.Name = "LblBRangoHorario"
        '
        'LblBDias
        '
        resources.ApplyResources(Me.LblBDias, "LblBDias")
        Me.LblBDias.Name = "LblBDias"
        '
        'LblBSucursal
        '
        resources.ApplyResources(Me.LblBSucursal, "LblBSucursal")
        Me.LblBSucursal.Name = "LblBSucursal"
        '
        'LblIngreso
        '
        resources.ApplyResources(Me.LblIngreso, "LblIngreso")
        Me.LblIngreso.Name = "LblIngreso"
        '
        'LblIRango
        '
        resources.ApplyResources(Me.LblIRango, "LblIRango")
        Me.LblIRango.Name = "LblIRango"
        '
        'LblIDias
        '
        resources.ApplyResources(Me.LblIDias, "LblIDias")
        Me.LblIDias.Name = "LblIDias"
        '
        'LblISucursal
        '
        resources.ApplyResources(Me.LblISucursal, "LblISucursal")
        Me.LblISucursal.Name = "LblISucursal"
        '
        'LblBusqueda
        '
        resources.ApplyResources(Me.LblBusqueda, "LblBusqueda")
        Me.LblBusqueda.Name = "LblBusqueda"
        '
        'LblICi
        '
        resources.ApplyResources(Me.LblICi, "LblICi")
        Me.LblICi.Name = "LblICi"
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
        CType(Me.DgvHorarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_ingresar.ResumeLayout(False)
        Me.pnl_ingresar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnl_fondo As Panel
    Friend WithEvents pnl_ingresar As Panel
    Friend WithEvents LblBRangoHorario As Label
    Friend WithEvents LblBDias As Label
    Friend WithEvents LblBSucursal As Label
    Friend WithEvents LblIngreso As Label
    Friend WithEvents LblIRango As Label
    Friend WithEvents LblIDias As Label
    Friend WithEvents LblISucursal As Label
    Friend WithEvents LblBusqueda As Label
    Friend WithEvents LblICi As Label
    Friend WithEvents lbl_a As Label
    Friend WithEvents TxtBCi As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents CmbBSucursal As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents CmbISucursal As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents TxtICi As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents LblBCi As Label
    Friend WithEvents BtnFiltrar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnEliminar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnModificar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnIngresar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnMinimize As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents BtnExit As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents DgvHorarios As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents ChkIDomingo As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents ChkISabado As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents ChkIViernes As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents ChkIJueves As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents ChkIMiercoles As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents ChkIMartes As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents ChkILunes As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents ChkBDomingo As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents ChkBSabado As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents ChkBViernes As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents ChkBJueves As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents ChkBMiercoles As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents ChkBMartes As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents ChkBLunes As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents TxtISalida As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtIEntrada As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtBSalida As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtBEntrada As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnVolver As Guna.UI2.WinForms.Guna2Button
End Class
