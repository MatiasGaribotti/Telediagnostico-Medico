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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_Pacientes))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnl_contenedor = New System.Windows.Forms.Panel()
        Me.BtnMinimize = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.BtnExit = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DgvPacientes = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.pnl_filtrar = New System.Windows.Forms.Panel()
        Me.CmblDepartamentoAlt = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.CmblDetalleAlt = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.TxtBFiltrar = New Guna.UI2.WinForms.Guna2Button()
        Me.TxtBEmailAlt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtBLocalidadAlt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtBCalleAlt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtBNumeroAlt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtBEdad = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtBTelefonoAlt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtBApellidos2 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtBApellidos1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtBNombreAlt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnl_ingresar = New System.Windows.Forms.Panel()
        Me.CmblMedicacion = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.CmblEnfermedad = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.CmblDetalle = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.CmbIDepartamento = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.BtnIngresar = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnVolver = New Guna.UI2.WinForms.Guna2Button()
        Me.TxtBAntLab = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtBTratamientos = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtBAntFam = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtBNFam = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtBEmail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtBLocalidad = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtBCalle = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtBNumero = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtBTelefono = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtBApellido2 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtBApellido1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtBNombre = New Guna.UI2.WinForms.Guna2TextBox()
        Me.DTPickerFNac = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.lbl_localidad = New System.Windows.Forms.Label()
        Me.lbl_detalle = New System.Windows.Forms.Label()
        Me.lbl_numero = New System.Windows.Forms.Label()
        Me.lbl_medicacion = New System.Windows.Forms.Label()
        Me.lbl_enfermedad = New System.Windows.Forms.Label()
        Me.lbl_antecedentesLab = New System.Windows.Forms.Label()
        Me.lbl_tratamientos = New System.Windows.Forms.Label()
        Me.lbl_antecedentesFlia = New System.Windows.Forms.Label()
        Me.lbl_nucleoFlia = New System.Windows.Forms.Label()
        Me.lbl_email = New System.Windows.Forms.Label()
        Me.lbl_departamento = New System.Windows.Forms.Label()
        Me.lbl_calle = New System.Windows.Forms.Label()
        Me.lbl_telefono = New System.Windows.Forms.Label()
        Me.lbl_fechaNacimiento = New System.Windows.Forms.Label()
        Me.lbl_apellidos = New System.Windows.Forms.Label()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.pnl_contenedor.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DgvPacientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_filtrar.SuspendLayout()
        Me.pnl_ingresar.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl_contenedor
        '
        Me.pnl_contenedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.pnl_contenedor.Controls.Add(Me.BtnMinimize)
        Me.pnl_contenedor.Controls.Add(Me.BtnExit)
        Me.pnl_contenedor.Controls.Add(Me.Panel1)
        Me.pnl_contenedor.Controls.Add(Me.pnl_filtrar)
        Me.pnl_contenedor.Controls.Add(Me.pnl_ingresar)
        resources.ApplyResources(Me.pnl_contenedor, "pnl_contenedor")
        Me.pnl_contenedor.Name = "pnl_contenedor"
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.Panel1.Controls.Add(Me.DgvPacientes)
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.Name = "Panel1"
        '
        'DgvPacientes
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DgvPacientes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvPacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvPacientes.BackgroundColor = System.Drawing.Color.White
        Me.DgvPacientes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvPacientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgvPacientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvPacientes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        resources.ApplyResources(Me.DgvPacientes, "DgvPacientes")
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvPacientes.DefaultCellStyle = DataGridViewCellStyle3
        Me.DgvPacientes.EnableHeadersVisualStyles = False
        Me.DgvPacientes.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvPacientes.Name = "DgvPacientes"
        Me.DgvPacientes.RowHeadersVisible = False
        Me.DgvPacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvPacientes.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.DgvPacientes.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DgvPacientes.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DgvPacientes.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DgvPacientes.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DgvPacientes.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DgvPacientes.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DgvPacientes.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvPacientes.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvPacientes.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvPacientes.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DgvPacientes.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DgvPacientes.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DgvPacientes.ThemeStyle.HeaderStyle.Height = 4
        Me.DgvPacientes.ThemeStyle.ReadOnly = False
        Me.DgvPacientes.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DgvPacientes.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgvPacientes.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DgvPacientes.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DgvPacientes.ThemeStyle.RowsStyle.Height = 22
        Me.DgvPacientes.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvPacientes.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'pnl_filtrar
        '
        Me.pnl_filtrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.pnl_filtrar.Controls.Add(Me.CmblDepartamentoAlt)
        Me.pnl_filtrar.Controls.Add(Me.CmblDetalleAlt)
        Me.pnl_filtrar.Controls.Add(Me.TxtBFiltrar)
        Me.pnl_filtrar.Controls.Add(Me.TxtBEmailAlt)
        Me.pnl_filtrar.Controls.Add(Me.Label10)
        Me.pnl_filtrar.Controls.Add(Me.TxtBLocalidadAlt)
        Me.pnl_filtrar.Controls.Add(Me.Label8)
        Me.pnl_filtrar.Controls.Add(Me.Label9)
        Me.pnl_filtrar.Controls.Add(Me.TxtBCalleAlt)
        Me.pnl_filtrar.Controls.Add(Me.TxtBNumeroAlt)
        Me.pnl_filtrar.Controls.Add(Me.Label5)
        Me.pnl_filtrar.Controls.Add(Me.Label6)
        Me.pnl_filtrar.Controls.Add(Me.Label7)
        Me.pnl_filtrar.Controls.Add(Me.TxtBEdad)
        Me.pnl_filtrar.Controls.Add(Me.Label4)
        Me.pnl_filtrar.Controls.Add(Me.TxtBTelefonoAlt)
        Me.pnl_filtrar.Controls.Add(Me.Label3)
        Me.pnl_filtrar.Controls.Add(Me.TxtBApellidos2)
        Me.pnl_filtrar.Controls.Add(Me.TxtBApellidos1)
        Me.pnl_filtrar.Controls.Add(Me.TxtBNombreAlt)
        Me.pnl_filtrar.Controls.Add(Me.Label1)
        Me.pnl_filtrar.Controls.Add(Me.Label2)
        resources.ApplyResources(Me.pnl_filtrar, "pnl_filtrar")
        Me.pnl_filtrar.Name = "pnl_filtrar"
        '
        'CmblDepartamentoAlt
        '
        Me.CmblDepartamentoAlt.Animated = True
        Me.CmblDepartamentoAlt.BackColor = System.Drawing.Color.Transparent
        Me.CmblDepartamentoAlt.BorderRadius = 6
        Me.CmblDepartamentoAlt.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CmblDepartamentoAlt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmblDepartamentoAlt.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmblDepartamentoAlt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmblDepartamentoAlt.FocusedState.Parent = Me.CmblDepartamentoAlt
        resources.ApplyResources(Me.CmblDepartamentoAlt, "CmblDepartamentoAlt")
        Me.CmblDepartamentoAlt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CmblDepartamentoAlt.HoverState.Parent = Me.CmblDepartamentoAlt
        Me.CmblDepartamentoAlt.ItemsAppearance.Parent = Me.CmblDepartamentoAlt
        Me.CmblDepartamentoAlt.Name = "CmblDepartamentoAlt"
        Me.CmblDepartamentoAlt.ShadowDecoration.Parent = Me.CmblDepartamentoAlt
        '
        'CmblDetalleAlt
        '
        Me.CmblDetalleAlt.Animated = True
        Me.CmblDetalleAlt.BackColor = System.Drawing.Color.Transparent
        Me.CmblDetalleAlt.BorderRadius = 6
        Me.CmblDetalleAlt.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CmblDetalleAlt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmblDetalleAlt.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmblDetalleAlt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmblDetalleAlt.FocusedState.Parent = Me.CmblDetalleAlt
        resources.ApplyResources(Me.CmblDetalleAlt, "CmblDetalleAlt")
        Me.CmblDetalleAlt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CmblDetalleAlt.HoverState.Parent = Me.CmblDetalleAlt
        Me.CmblDetalleAlt.ItemsAppearance.Parent = Me.CmblDetalleAlt
        Me.CmblDetalleAlt.Name = "CmblDetalleAlt"
        Me.CmblDetalleAlt.ShadowDecoration.Parent = Me.CmblDetalleAlt
        '
        'TxtBFiltrar
        '
        Me.TxtBFiltrar.Animated = True
        Me.TxtBFiltrar.AutoRoundedCorners = True
        Me.TxtBFiltrar.BackColor = System.Drawing.Color.Transparent
        Me.TxtBFiltrar.BorderRadius = 14
        Me.TxtBFiltrar.CheckedState.Parent = Me.TxtBFiltrar
        Me.TxtBFiltrar.CustomImages.Parent = Me.TxtBFiltrar
        Me.TxtBFiltrar.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(123, Byte), Integer))
        resources.ApplyResources(Me.TxtBFiltrar, "TxtBFiltrar")
        Me.TxtBFiltrar.ForeColor = System.Drawing.Color.White
        Me.TxtBFiltrar.HoverState.Parent = Me.TxtBFiltrar
        Me.TxtBFiltrar.Name = "TxtBFiltrar"
        Me.TxtBFiltrar.ShadowDecoration.Parent = Me.TxtBFiltrar
        Me.TxtBFiltrar.UseTransparentBackground = True
        '
        'TxtBEmailAlt
        '
        Me.TxtBEmailAlt.Animated = True
        Me.TxtBEmailAlt.BorderRadius = 6
        Me.TxtBEmailAlt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtBEmailAlt.DefaultText = ""
        Me.TxtBEmailAlt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtBEmailAlt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtBEmailAlt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtBEmailAlt.DisabledState.Parent = Me.TxtBEmailAlt
        Me.TxtBEmailAlt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtBEmailAlt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtBEmailAlt.FocusedState.Parent = Me.TxtBEmailAlt
        resources.ApplyResources(Me.TxtBEmailAlt, "TxtBEmailAlt")
        Me.TxtBEmailAlt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtBEmailAlt.HoverState.Parent = Me.TxtBEmailAlt
        Me.TxtBEmailAlt.Name = "TxtBEmailAlt"
        Me.TxtBEmailAlt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtBEmailAlt.PlaceholderText = ""
        Me.TxtBEmailAlt.SelectedText = ""
        Me.TxtBEmailAlt.ShadowDecoration.Parent = Me.TxtBEmailAlt
        '
        'Label10
        '
        resources.ApplyResources(Me.Label10, "Label10")
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Name = "Label10"
        '
        'TxtBLocalidadAlt
        '
        Me.TxtBLocalidadAlt.Animated = True
        Me.TxtBLocalidadAlt.BorderRadius = 6
        Me.TxtBLocalidadAlt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtBLocalidadAlt.DefaultText = ""
        Me.TxtBLocalidadAlt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtBLocalidadAlt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtBLocalidadAlt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtBLocalidadAlt.DisabledState.Parent = Me.TxtBLocalidadAlt
        Me.TxtBLocalidadAlt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtBLocalidadAlt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtBLocalidadAlt.FocusedState.Parent = Me.TxtBLocalidadAlt
        resources.ApplyResources(Me.TxtBLocalidadAlt, "TxtBLocalidadAlt")
        Me.TxtBLocalidadAlt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtBLocalidadAlt.HoverState.Parent = Me.TxtBLocalidadAlt
        Me.TxtBLocalidadAlt.Name = "TxtBLocalidadAlt"
        Me.TxtBLocalidadAlt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtBLocalidadAlt.PlaceholderText = ""
        Me.TxtBLocalidadAlt.SelectedText = ""
        Me.TxtBLocalidadAlt.ShadowDecoration.Parent = Me.TxtBLocalidadAlt
        '
        'Label8
        '
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Name = "Label8"
        '
        'Label9
        '
        resources.ApplyResources(Me.Label9, "Label9")
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Name = "Label9"
        '
        'TxtBCalleAlt
        '
        Me.TxtBCalleAlt.Animated = True
        Me.TxtBCalleAlt.BorderRadius = 6
        Me.TxtBCalleAlt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtBCalleAlt.DefaultText = ""
        Me.TxtBCalleAlt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtBCalleAlt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtBCalleAlt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtBCalleAlt.DisabledState.Parent = Me.TxtBCalleAlt
        Me.TxtBCalleAlt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtBCalleAlt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtBCalleAlt.FocusedState.Parent = Me.TxtBCalleAlt
        resources.ApplyResources(Me.TxtBCalleAlt, "TxtBCalleAlt")
        Me.TxtBCalleAlt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtBCalleAlt.HoverState.Parent = Me.TxtBCalleAlt
        Me.TxtBCalleAlt.Name = "TxtBCalleAlt"
        Me.TxtBCalleAlt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtBCalleAlt.PlaceholderText = ""
        Me.TxtBCalleAlt.SelectedText = ""
        Me.TxtBCalleAlt.ShadowDecoration.Parent = Me.TxtBCalleAlt
        '
        'TxtBNumeroAlt
        '
        Me.TxtBNumeroAlt.Animated = True
        Me.TxtBNumeroAlt.BorderRadius = 6
        Me.TxtBNumeroAlt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtBNumeroAlt.DefaultText = ""
        Me.TxtBNumeroAlt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtBNumeroAlt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtBNumeroAlt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtBNumeroAlt.DisabledState.Parent = Me.TxtBNumeroAlt
        Me.TxtBNumeroAlt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtBNumeroAlt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtBNumeroAlt.FocusedState.Parent = Me.TxtBNumeroAlt
        resources.ApplyResources(Me.TxtBNumeroAlt, "TxtBNumeroAlt")
        Me.TxtBNumeroAlt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtBNumeroAlt.HoverState.Parent = Me.TxtBNumeroAlt
        Me.TxtBNumeroAlt.Name = "TxtBNumeroAlt"
        Me.TxtBNumeroAlt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtBNumeroAlt.PlaceholderText = ""
        Me.TxtBNumeroAlt.SelectedText = ""
        Me.TxtBNumeroAlt.ShadowDecoration.Parent = Me.TxtBNumeroAlt
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Name = "Label5"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Name = "Label6"
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Name = "Label7"
        '
        'TxtBEdad
        '
        Me.TxtBEdad.Animated = True
        Me.TxtBEdad.BorderRadius = 6
        Me.TxtBEdad.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtBEdad.DefaultText = ""
        Me.TxtBEdad.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtBEdad.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtBEdad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtBEdad.DisabledState.Parent = Me.TxtBEdad
        Me.TxtBEdad.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtBEdad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtBEdad.FocusedState.Parent = Me.TxtBEdad
        resources.ApplyResources(Me.TxtBEdad, "TxtBEdad")
        Me.TxtBEdad.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtBEdad.HoverState.Parent = Me.TxtBEdad
        Me.TxtBEdad.Name = "TxtBEdad"
        Me.TxtBEdad.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtBEdad.PlaceholderText = ""
        Me.TxtBEdad.SelectedText = ""
        Me.TxtBEdad.ShadowDecoration.Parent = Me.TxtBEdad
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Name = "Label4"
        '
        'TxtBTelefonoAlt
        '
        Me.TxtBTelefonoAlt.Animated = True
        Me.TxtBTelefonoAlt.BorderRadius = 6
        Me.TxtBTelefonoAlt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtBTelefonoAlt.DefaultText = ""
        Me.TxtBTelefonoAlt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtBTelefonoAlt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtBTelefonoAlt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtBTelefonoAlt.DisabledState.Parent = Me.TxtBTelefonoAlt
        Me.TxtBTelefonoAlt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtBTelefonoAlt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtBTelefonoAlt.FocusedState.Parent = Me.TxtBTelefonoAlt
        resources.ApplyResources(Me.TxtBTelefonoAlt, "TxtBTelefonoAlt")
        Me.TxtBTelefonoAlt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtBTelefonoAlt.HoverState.Parent = Me.TxtBTelefonoAlt
        Me.TxtBTelefonoAlt.Name = "TxtBTelefonoAlt"
        Me.TxtBTelefonoAlt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtBTelefonoAlt.PlaceholderText = ""
        Me.TxtBTelefonoAlt.SelectedText = ""
        Me.TxtBTelefonoAlt.ShadowDecoration.Parent = Me.TxtBTelefonoAlt
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Name = "Label3"
        '
        'TxtBApellidos2
        '
        Me.TxtBApellidos2.Animated = True
        Me.TxtBApellidos2.BorderRadius = 6
        Me.TxtBApellidos2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtBApellidos2.DefaultText = ""
        Me.TxtBApellidos2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtBApellidos2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtBApellidos2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtBApellidos2.DisabledState.Parent = Me.TxtBApellidos2
        Me.TxtBApellidos2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtBApellidos2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtBApellidos2.FocusedState.Parent = Me.TxtBApellidos2
        resources.ApplyResources(Me.TxtBApellidos2, "TxtBApellidos2")
        Me.TxtBApellidos2.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtBApellidos2.HoverState.Parent = Me.TxtBApellidos2
        Me.TxtBApellidos2.Name = "TxtBApellidos2"
        Me.TxtBApellidos2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtBApellidos2.PlaceholderText = ""
        Me.TxtBApellidos2.SelectedText = ""
        Me.TxtBApellidos2.ShadowDecoration.Parent = Me.TxtBApellidos2
        '
        'TxtBApellidos1
        '
        Me.TxtBApellidos1.Animated = True
        Me.TxtBApellidos1.BorderRadius = 6
        Me.TxtBApellidos1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtBApellidos1.DefaultText = ""
        Me.TxtBApellidos1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtBApellidos1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtBApellidos1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtBApellidos1.DisabledState.Parent = Me.TxtBApellidos1
        Me.TxtBApellidos1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtBApellidos1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtBApellidos1.FocusedState.Parent = Me.TxtBApellidos1
        resources.ApplyResources(Me.TxtBApellidos1, "TxtBApellidos1")
        Me.TxtBApellidos1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtBApellidos1.HoverState.Parent = Me.TxtBApellidos1
        Me.TxtBApellidos1.Name = "TxtBApellidos1"
        Me.TxtBApellidos1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtBApellidos1.PlaceholderText = ""
        Me.TxtBApellidos1.SelectedText = ""
        Me.TxtBApellidos1.ShadowDecoration.Parent = Me.TxtBApellidos1
        '
        'TxtBNombreAlt
        '
        Me.TxtBNombreAlt.Animated = True
        Me.TxtBNombreAlt.BorderRadius = 6
        Me.TxtBNombreAlt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtBNombreAlt.DefaultText = ""
        Me.TxtBNombreAlt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtBNombreAlt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtBNombreAlt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtBNombreAlt.DisabledState.Parent = Me.TxtBNombreAlt
        Me.TxtBNombreAlt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtBNombreAlt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtBNombreAlt.FocusedState.Parent = Me.TxtBNombreAlt
        resources.ApplyResources(Me.TxtBNombreAlt, "TxtBNombreAlt")
        Me.TxtBNombreAlt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtBNombreAlt.HoverState.Parent = Me.TxtBNombreAlt
        Me.TxtBNombreAlt.Name = "TxtBNombreAlt"
        Me.TxtBNombreAlt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtBNombreAlt.PlaceholderText = ""
        Me.TxtBNombreAlt.SelectedText = ""
        Me.TxtBNombreAlt.ShadowDecoration.Parent = Me.TxtBNombreAlt
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Name = "Label1"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Name = "Label2"
        '
        'pnl_ingresar
        '
        Me.pnl_ingresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.pnl_ingresar.Controls.Add(Me.CmblMedicacion)
        Me.pnl_ingresar.Controls.Add(Me.CmblEnfermedad)
        Me.pnl_ingresar.Controls.Add(Me.CmblDetalle)
        Me.pnl_ingresar.Controls.Add(Me.CmbIDepartamento)
        Me.pnl_ingresar.Controls.Add(Me.BtnIngresar)
        Me.pnl_ingresar.Controls.Add(Me.BtnVolver)
        Me.pnl_ingresar.Controls.Add(Me.TxtBAntLab)
        Me.pnl_ingresar.Controls.Add(Me.TxtBTratamientos)
        Me.pnl_ingresar.Controls.Add(Me.TxtBAntFam)
        Me.pnl_ingresar.Controls.Add(Me.TxtBNFam)
        Me.pnl_ingresar.Controls.Add(Me.TxtBEmail)
        Me.pnl_ingresar.Controls.Add(Me.TxtBLocalidad)
        Me.pnl_ingresar.Controls.Add(Me.TxtBCalle)
        Me.pnl_ingresar.Controls.Add(Me.TxtBNumero)
        Me.pnl_ingresar.Controls.Add(Me.TxtBTelefono)
        Me.pnl_ingresar.Controls.Add(Me.TxtBApellido2)
        Me.pnl_ingresar.Controls.Add(Me.TxtBApellido1)
        Me.pnl_ingresar.Controls.Add(Me.TxtBNombre)
        Me.pnl_ingresar.Controls.Add(Me.DTPickerFNac)
        Me.pnl_ingresar.Controls.Add(Me.lbl_localidad)
        Me.pnl_ingresar.Controls.Add(Me.lbl_detalle)
        Me.pnl_ingresar.Controls.Add(Me.lbl_numero)
        Me.pnl_ingresar.Controls.Add(Me.lbl_medicacion)
        Me.pnl_ingresar.Controls.Add(Me.lbl_enfermedad)
        Me.pnl_ingresar.Controls.Add(Me.lbl_antecedentesLab)
        Me.pnl_ingresar.Controls.Add(Me.lbl_tratamientos)
        Me.pnl_ingresar.Controls.Add(Me.lbl_antecedentesFlia)
        Me.pnl_ingresar.Controls.Add(Me.lbl_nucleoFlia)
        Me.pnl_ingresar.Controls.Add(Me.lbl_email)
        Me.pnl_ingresar.Controls.Add(Me.lbl_departamento)
        Me.pnl_ingresar.Controls.Add(Me.lbl_calle)
        Me.pnl_ingresar.Controls.Add(Me.lbl_telefono)
        Me.pnl_ingresar.Controls.Add(Me.lbl_fechaNacimiento)
        Me.pnl_ingresar.Controls.Add(Me.lbl_apellidos)
        Me.pnl_ingresar.Controls.Add(Me.lbl_nombre)
        resources.ApplyResources(Me.pnl_ingresar, "pnl_ingresar")
        Me.pnl_ingresar.Name = "pnl_ingresar"
        '
        'CmblMedicacion
        '
        Me.CmblMedicacion.Animated = True
        Me.CmblMedicacion.BackColor = System.Drawing.Color.Transparent
        Me.CmblMedicacion.BorderRadius = 6
        Me.CmblMedicacion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CmblMedicacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmblMedicacion.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmblMedicacion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmblMedicacion.FocusedState.Parent = Me.CmblMedicacion
        resources.ApplyResources(Me.CmblMedicacion, "CmblMedicacion")
        Me.CmblMedicacion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CmblMedicacion.HoverState.Parent = Me.CmblMedicacion
        Me.CmblMedicacion.ItemsAppearance.Parent = Me.CmblMedicacion
        Me.CmblMedicacion.Name = "CmblMedicacion"
        Me.CmblMedicacion.ShadowDecoration.Parent = Me.CmblMedicacion
        '
        'CmblEnfermedad
        '
        Me.CmblEnfermedad.Animated = True
        Me.CmblEnfermedad.BackColor = System.Drawing.Color.Transparent
        Me.CmblEnfermedad.BorderRadius = 6
        Me.CmblEnfermedad.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CmblEnfermedad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmblEnfermedad.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmblEnfermedad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmblEnfermedad.FocusedState.Parent = Me.CmblEnfermedad
        resources.ApplyResources(Me.CmblEnfermedad, "CmblEnfermedad")
        Me.CmblEnfermedad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CmblEnfermedad.HoverState.Parent = Me.CmblEnfermedad
        Me.CmblEnfermedad.ItemsAppearance.Parent = Me.CmblEnfermedad
        Me.CmblEnfermedad.Name = "CmblEnfermedad"
        Me.CmblEnfermedad.ShadowDecoration.Parent = Me.CmblEnfermedad
        '
        'CmblDetalle
        '
        Me.CmblDetalle.Animated = True
        Me.CmblDetalle.BackColor = System.Drawing.Color.Transparent
        Me.CmblDetalle.BorderRadius = 6
        Me.CmblDetalle.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CmblDetalle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmblDetalle.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmblDetalle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmblDetalle.FocusedState.Parent = Me.CmblDetalle
        resources.ApplyResources(Me.CmblDetalle, "CmblDetalle")
        Me.CmblDetalle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CmblDetalle.HoverState.Parent = Me.CmblDetalle
        Me.CmblDetalle.ItemsAppearance.Parent = Me.CmblDetalle
        Me.CmblDetalle.Name = "CmblDetalle"
        Me.CmblDetalle.ShadowDecoration.Parent = Me.CmblDetalle
        '
        'CmbIDepartamento
        '
        Me.CmbIDepartamento.Animated = True
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
        'BtnIngresar
        '
        Me.BtnIngresar.Animated = True
        Me.BtnIngresar.AutoRoundedCorners = True
        Me.BtnIngresar.BackColor = System.Drawing.Color.Transparent
        Me.BtnIngresar.BorderRadius = 14
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
        'BtnVolver
        '
        Me.BtnVolver.Animated = True
        Me.BtnVolver.AutoRoundedCorners = True
        Me.BtnVolver.BackColor = System.Drawing.Color.Transparent
        Me.BtnVolver.BorderRadius = 14
        Me.BtnVolver.CheckedState.Parent = Me.BtnVolver
        Me.BtnVolver.CustomImages.Parent = Me.BtnVolver
        Me.BtnVolver.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(123, Byte), Integer))
        resources.ApplyResources(Me.BtnVolver, "BtnVolver")
        Me.BtnVolver.ForeColor = System.Drawing.Color.White
        Me.BtnVolver.HoverState.Parent = Me.BtnVolver
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.ShadowDecoration.Parent = Me.BtnVolver
        Me.BtnVolver.UseTransparentBackground = True
        '
        'TxtBAntLab
        '
        Me.TxtBAntLab.Animated = True
        Me.TxtBAntLab.BorderRadius = 6
        Me.TxtBAntLab.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtBAntLab.DefaultText = ""
        Me.TxtBAntLab.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtBAntLab.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtBAntLab.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtBAntLab.DisabledState.Parent = Me.TxtBAntLab
        Me.TxtBAntLab.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtBAntLab.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtBAntLab.FocusedState.Parent = Me.TxtBAntLab
        resources.ApplyResources(Me.TxtBAntLab, "TxtBAntLab")
        Me.TxtBAntLab.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtBAntLab.HoverState.Parent = Me.TxtBAntLab
        Me.TxtBAntLab.Multiline = True
        Me.TxtBAntLab.Name = "TxtBAntLab"
        Me.TxtBAntLab.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtBAntLab.PlaceholderText = ""
        Me.TxtBAntLab.SelectedText = ""
        Me.TxtBAntLab.ShadowDecoration.Parent = Me.TxtBAntLab
        '
        'TxtBTratamientos
        '
        Me.TxtBTratamientos.Animated = True
        Me.TxtBTratamientos.BorderRadius = 6
        Me.TxtBTratamientos.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtBTratamientos.DefaultText = ""
        Me.TxtBTratamientos.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtBTratamientos.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtBTratamientos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtBTratamientos.DisabledState.Parent = Me.TxtBTratamientos
        Me.TxtBTratamientos.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtBTratamientos.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtBTratamientos.FocusedState.Parent = Me.TxtBTratamientos
        resources.ApplyResources(Me.TxtBTratamientos, "TxtBTratamientos")
        Me.TxtBTratamientos.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtBTratamientos.HoverState.Parent = Me.TxtBTratamientos
        Me.TxtBTratamientos.Multiline = True
        Me.TxtBTratamientos.Name = "TxtBTratamientos"
        Me.TxtBTratamientos.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtBTratamientos.PlaceholderText = ""
        Me.TxtBTratamientos.SelectedText = ""
        Me.TxtBTratamientos.ShadowDecoration.Parent = Me.TxtBTratamientos
        '
        'TxtBAntFam
        '
        Me.TxtBAntFam.Animated = True
        Me.TxtBAntFam.BorderRadius = 6
        Me.TxtBAntFam.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtBAntFam.DefaultText = ""
        Me.TxtBAntFam.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtBAntFam.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtBAntFam.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtBAntFam.DisabledState.Parent = Me.TxtBAntFam
        Me.TxtBAntFam.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtBAntFam.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtBAntFam.FocusedState.Parent = Me.TxtBAntFam
        resources.ApplyResources(Me.TxtBAntFam, "TxtBAntFam")
        Me.TxtBAntFam.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtBAntFam.HoverState.Parent = Me.TxtBAntFam
        Me.TxtBAntFam.Multiline = True
        Me.TxtBAntFam.Name = "TxtBAntFam"
        Me.TxtBAntFam.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtBAntFam.PlaceholderText = ""
        Me.TxtBAntFam.SelectedText = ""
        Me.TxtBAntFam.ShadowDecoration.Parent = Me.TxtBAntFam
        '
        'TxtBNFam
        '
        Me.TxtBNFam.Animated = True
        Me.TxtBNFam.BorderRadius = 6
        Me.TxtBNFam.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtBNFam.DefaultText = ""
        Me.TxtBNFam.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtBNFam.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtBNFam.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtBNFam.DisabledState.Parent = Me.TxtBNFam
        Me.TxtBNFam.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtBNFam.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtBNFam.FocusedState.Parent = Me.TxtBNFam
        resources.ApplyResources(Me.TxtBNFam, "TxtBNFam")
        Me.TxtBNFam.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtBNFam.HoverState.Parent = Me.TxtBNFam
        Me.TxtBNFam.Multiline = True
        Me.TxtBNFam.Name = "TxtBNFam"
        Me.TxtBNFam.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtBNFam.PlaceholderText = ""
        Me.TxtBNFam.SelectedText = ""
        Me.TxtBNFam.ShadowDecoration.Parent = Me.TxtBNFam
        '
        'TxtBEmail
        '
        Me.TxtBEmail.Animated = True
        Me.TxtBEmail.BorderRadius = 6
        Me.TxtBEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtBEmail.DefaultText = ""
        Me.TxtBEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtBEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtBEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtBEmail.DisabledState.Parent = Me.TxtBEmail
        Me.TxtBEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtBEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtBEmail.FocusedState.Parent = Me.TxtBEmail
        resources.ApplyResources(Me.TxtBEmail, "TxtBEmail")
        Me.TxtBEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtBEmail.HoverState.Parent = Me.TxtBEmail
        Me.TxtBEmail.Name = "TxtBEmail"
        Me.TxtBEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtBEmail.PlaceholderText = ""
        Me.TxtBEmail.SelectedText = ""
        Me.TxtBEmail.ShadowDecoration.Parent = Me.TxtBEmail
        '
        'TxtBLocalidad
        '
        Me.TxtBLocalidad.Animated = True
        Me.TxtBLocalidad.BorderRadius = 6
        Me.TxtBLocalidad.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtBLocalidad.DefaultText = ""
        Me.TxtBLocalidad.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtBLocalidad.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtBLocalidad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtBLocalidad.DisabledState.Parent = Me.TxtBLocalidad
        Me.TxtBLocalidad.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtBLocalidad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtBLocalidad.FocusedState.Parent = Me.TxtBLocalidad
        resources.ApplyResources(Me.TxtBLocalidad, "TxtBLocalidad")
        Me.TxtBLocalidad.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtBLocalidad.HoverState.Parent = Me.TxtBLocalidad
        Me.TxtBLocalidad.Name = "TxtBLocalidad"
        Me.TxtBLocalidad.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtBLocalidad.PlaceholderText = ""
        Me.TxtBLocalidad.SelectedText = ""
        Me.TxtBLocalidad.ShadowDecoration.Parent = Me.TxtBLocalidad
        '
        'TxtBCalle
        '
        Me.TxtBCalle.Animated = True
        Me.TxtBCalle.BorderRadius = 6
        Me.TxtBCalle.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtBCalle.DefaultText = ""
        Me.TxtBCalle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtBCalle.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtBCalle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtBCalle.DisabledState.Parent = Me.TxtBCalle
        Me.TxtBCalle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtBCalle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtBCalle.FocusedState.Parent = Me.TxtBCalle
        resources.ApplyResources(Me.TxtBCalle, "TxtBCalle")
        Me.TxtBCalle.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtBCalle.HoverState.Parent = Me.TxtBCalle
        Me.TxtBCalle.Name = "TxtBCalle"
        Me.TxtBCalle.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtBCalle.PlaceholderText = ""
        Me.TxtBCalle.SelectedText = ""
        Me.TxtBCalle.ShadowDecoration.Parent = Me.TxtBCalle
        '
        'TxtBNumero
        '
        Me.TxtBNumero.Animated = True
        Me.TxtBNumero.BorderRadius = 6
        Me.TxtBNumero.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtBNumero.DefaultText = ""
        Me.TxtBNumero.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtBNumero.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtBNumero.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtBNumero.DisabledState.Parent = Me.TxtBNumero
        Me.TxtBNumero.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtBNumero.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtBNumero.FocusedState.Parent = Me.TxtBNumero
        resources.ApplyResources(Me.TxtBNumero, "TxtBNumero")
        Me.TxtBNumero.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtBNumero.HoverState.Parent = Me.TxtBNumero
        Me.TxtBNumero.Name = "TxtBNumero"
        Me.TxtBNumero.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtBNumero.PlaceholderText = ""
        Me.TxtBNumero.SelectedText = ""
        Me.TxtBNumero.ShadowDecoration.Parent = Me.TxtBNumero
        '
        'TxtBTelefono
        '
        Me.TxtBTelefono.Animated = True
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
        'TxtBApellido2
        '
        Me.TxtBApellido2.Animated = True
        Me.TxtBApellido2.BorderRadius = 6
        Me.TxtBApellido2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtBApellido2.DefaultText = ""
        Me.TxtBApellido2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtBApellido2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtBApellido2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtBApellido2.DisabledState.Parent = Me.TxtBApellido2
        Me.TxtBApellido2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtBApellido2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtBApellido2.FocusedState.Parent = Me.TxtBApellido2
        resources.ApplyResources(Me.TxtBApellido2, "TxtBApellido2")
        Me.TxtBApellido2.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtBApellido2.HoverState.Parent = Me.TxtBApellido2
        Me.TxtBApellido2.Name = "TxtBApellido2"
        Me.TxtBApellido2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtBApellido2.PlaceholderText = ""
        Me.TxtBApellido2.SelectedText = ""
        Me.TxtBApellido2.ShadowDecoration.Parent = Me.TxtBApellido2
        '
        'TxtBApellido1
        '
        Me.TxtBApellido1.Animated = True
        Me.TxtBApellido1.BorderRadius = 6
        Me.TxtBApellido1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtBApellido1.DefaultText = ""
        Me.TxtBApellido1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtBApellido1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtBApellido1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtBApellido1.DisabledState.Parent = Me.TxtBApellido1
        Me.TxtBApellido1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtBApellido1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtBApellido1.FocusedState.Parent = Me.TxtBApellido1
        resources.ApplyResources(Me.TxtBApellido1, "TxtBApellido1")
        Me.TxtBApellido1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtBApellido1.HoverState.Parent = Me.TxtBApellido1
        Me.TxtBApellido1.Name = "TxtBApellido1"
        Me.TxtBApellido1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtBApellido1.PlaceholderText = ""
        Me.TxtBApellido1.SelectedText = ""
        Me.TxtBApellido1.ShadowDecoration.Parent = Me.TxtBApellido1
        '
        'TxtBNombre
        '
        Me.TxtBNombre.Animated = True
        Me.TxtBNombre.BorderRadius = 6
        Me.TxtBNombre.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtBNombre.DefaultText = ""
        Me.TxtBNombre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtBNombre.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtBNombre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtBNombre.DisabledState.Parent = Me.TxtBNombre
        Me.TxtBNombre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtBNombre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtBNombre.FocusedState.Parent = Me.TxtBNombre
        resources.ApplyResources(Me.TxtBNombre, "TxtBNombre")
        Me.TxtBNombre.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtBNombre.HoverState.Parent = Me.TxtBNombre
        Me.TxtBNombre.Name = "TxtBNombre"
        Me.TxtBNombre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtBNombre.PlaceholderText = ""
        Me.TxtBNombre.SelectedText = ""
        Me.TxtBNombre.ShadowDecoration.Parent = Me.TxtBNombre
        '
        'DTPickerFNac
        '
        Me.DTPickerFNac.Animated = True
        Me.DTPickerFNac.AutoRoundedCorners = True
        Me.DTPickerFNac.BorderRadius = 16
        Me.DTPickerFNac.CheckedState.Parent = Me.DTPickerFNac
        Me.DTPickerFNac.FillColor = System.Drawing.Color.White
        Me.DTPickerFNac.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.DTPickerFNac.HoverState.Parent = Me.DTPickerFNac
        resources.ApplyResources(Me.DTPickerFNac, "DTPickerFNac")
        Me.DTPickerFNac.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DTPickerFNac.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.DTPickerFNac.Name = "DTPickerFNac"
        Me.DTPickerFNac.ShadowDecoration.Parent = Me.DTPickerFNac
        Me.DTPickerFNac.Value = New Date(2020, 7, 20, 18, 36, 52, 28)
        '
        'lbl_localidad
        '
        resources.ApplyResources(Me.lbl_localidad, "lbl_localidad")
        Me.lbl_localidad.BackColor = System.Drawing.Color.Transparent
        Me.lbl_localidad.Name = "lbl_localidad"
        '
        'lbl_detalle
        '
        resources.ApplyResources(Me.lbl_detalle, "lbl_detalle")
        Me.lbl_detalle.BackColor = System.Drawing.Color.Transparent
        Me.lbl_detalle.Name = "lbl_detalle"
        '
        'lbl_numero
        '
        resources.ApplyResources(Me.lbl_numero, "lbl_numero")
        Me.lbl_numero.BackColor = System.Drawing.Color.Transparent
        Me.lbl_numero.Name = "lbl_numero"
        '
        'lbl_medicacion
        '
        resources.ApplyResources(Me.lbl_medicacion, "lbl_medicacion")
        Me.lbl_medicacion.BackColor = System.Drawing.Color.Transparent
        Me.lbl_medicacion.Name = "lbl_medicacion"
        '
        'lbl_enfermedad
        '
        resources.ApplyResources(Me.lbl_enfermedad, "lbl_enfermedad")
        Me.lbl_enfermedad.BackColor = System.Drawing.Color.Transparent
        Me.lbl_enfermedad.Name = "lbl_enfermedad"
        '
        'lbl_antecedentesLab
        '
        resources.ApplyResources(Me.lbl_antecedentesLab, "lbl_antecedentesLab")
        Me.lbl_antecedentesLab.BackColor = System.Drawing.Color.Transparent
        Me.lbl_antecedentesLab.Name = "lbl_antecedentesLab"
        '
        'lbl_tratamientos
        '
        resources.ApplyResources(Me.lbl_tratamientos, "lbl_tratamientos")
        Me.lbl_tratamientos.BackColor = System.Drawing.Color.Transparent
        Me.lbl_tratamientos.Name = "lbl_tratamientos"
        '
        'lbl_antecedentesFlia
        '
        resources.ApplyResources(Me.lbl_antecedentesFlia, "lbl_antecedentesFlia")
        Me.lbl_antecedentesFlia.BackColor = System.Drawing.Color.Transparent
        Me.lbl_antecedentesFlia.Name = "lbl_antecedentesFlia"
        '
        'lbl_nucleoFlia
        '
        resources.ApplyResources(Me.lbl_nucleoFlia, "lbl_nucleoFlia")
        Me.lbl_nucleoFlia.BackColor = System.Drawing.Color.Transparent
        Me.lbl_nucleoFlia.Name = "lbl_nucleoFlia"
        '
        'lbl_email
        '
        resources.ApplyResources(Me.lbl_email, "lbl_email")
        Me.lbl_email.BackColor = System.Drawing.Color.Transparent
        Me.lbl_email.Name = "lbl_email"
        '
        'lbl_departamento
        '
        resources.ApplyResources(Me.lbl_departamento, "lbl_departamento")
        Me.lbl_departamento.BackColor = System.Drawing.Color.Transparent
        Me.lbl_departamento.Name = "lbl_departamento"
        '
        'lbl_calle
        '
        resources.ApplyResources(Me.lbl_calle, "lbl_calle")
        Me.lbl_calle.BackColor = System.Drawing.Color.Transparent
        Me.lbl_calle.Name = "lbl_calle"
        '
        'lbl_telefono
        '
        resources.ApplyResources(Me.lbl_telefono, "lbl_telefono")
        Me.lbl_telefono.BackColor = System.Drawing.Color.Transparent
        Me.lbl_telefono.Name = "lbl_telefono"
        '
        'lbl_fechaNacimiento
        '
        resources.ApplyResources(Me.lbl_fechaNacimiento, "lbl_fechaNacimiento")
        Me.lbl_fechaNacimiento.BackColor = System.Drawing.Color.Transparent
        Me.lbl_fechaNacimiento.Name = "lbl_fechaNacimiento"
        '
        'lbl_apellidos
        '
        resources.ApplyResources(Me.lbl_apellidos, "lbl_apellidos")
        Me.lbl_apellidos.BackColor = System.Drawing.Color.Transparent
        Me.lbl_apellidos.Name = "lbl_apellidos"
        '
        'lbl_nombre
        '
        resources.ApplyResources(Me.lbl_nombre, "lbl_nombre")
        Me.lbl_nombre.BackColor = System.Drawing.Color.Transparent
        Me.lbl_nombre.Name = "lbl_nombre"
        '
        'F_Pacientes
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnl_contenedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "F_Pacientes"
        Me.ShowInTaskbar = False
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnl_contenedor.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.DgvPacientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_filtrar.ResumeLayout(False)
        Me.pnl_filtrar.PerformLayout()
        Me.pnl_ingresar.ResumeLayout(False)
        Me.pnl_ingresar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnl_contenedor As Panel
    Friend WithEvents pnl_ingresar As Panel
    Friend WithEvents BtnIngresar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnVolver As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TxtBAntLab As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtBTratamientos As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtBAntFam As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtBNFam As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtBEmail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtBLocalidad As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtBCalle As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtBNumero As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtBTelefono As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtBApellido2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtBApellido1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtBNombre As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents DTPickerFNac As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents lbl_localidad As Label
    Friend WithEvents lbl_detalle As Label
    Friend WithEvents lbl_numero As Label
    Friend WithEvents lbl_medicacion As Label
    Friend WithEvents lbl_enfermedad As Label
    Friend WithEvents lbl_antecedentesLab As Label
    Friend WithEvents lbl_tratamientos As Label
    Friend WithEvents lbl_antecedentesFlia As Label
    Friend WithEvents lbl_nucleoFlia As Label
    Friend WithEvents lbl_email As Label
    Friend WithEvents lbl_departamento As Label
    Friend WithEvents lbl_calle As Label
    Friend WithEvents lbl_telefono As Label
    Friend WithEvents lbl_fechaNacimiento As Label
    Friend WithEvents lbl_apellidos As Label
    Friend WithEvents lbl_nombre As Label
    Friend WithEvents pnl_filtrar As Panel
    Friend WithEvents TxtBFiltrar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TxtBEmailAlt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtBLocalidadAlt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtBCalleAlt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtBNumeroAlt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtBEdad As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtBTelefonoAlt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtBApellidos2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtBApellidos1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtBNombreAlt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DgvPacientes As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents CmblDepartamentoAlt As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents CmblDetalleAlt As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents CmblMedicacion As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents CmblEnfermedad As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents CmblDetalle As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents CmbIDepartamento As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents BtnMinimize As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents BtnExit As Guna.UI2.WinForms.Guna2ControlBox
End Class
