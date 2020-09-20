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
        Me.TxtBDetalle = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BtnFiltrar = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnResetPassword = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnEliminar = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnModificar = New Guna.UI2.WinForms.Guna2Button()
        Me.TxtBCi = New Guna.UI2.WinForms.Guna2TextBox()
        Me.LblBCi = New System.Windows.Forms.Label()
        Me.CmbBDepartamento = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.TxtBEmail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtBLocalidad = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtBCalle = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtBNumero = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtBEdad = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtBTelefono = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtBApellidoM = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtBApellidoP = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtBNombre = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnl_ingresar = New System.Windows.Forms.Panel()
        Me.TxtIDetalle = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtICi = New Guna.UI2.WinForms.Guna2TextBox()
        Me.LblCi = New System.Windows.Forms.Label()
        Me.CmbIDepartamento = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.BtnIngresar = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnVolver = New Guna.UI2.WinForms.Guna2Button()
        Me.TxtIAntLab = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtIAntFam = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtINFam = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtIEmail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtILocalidad = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtICalle = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtINumero = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtITelefono = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtIApellidoM = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtIApellidoP = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtINombre = New Guna.UI2.WinForms.Guna2TextBox()
        Me.DTPickerFNac = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.lbl_localidad = New System.Windows.Forms.Label()
        Me.lbl_detalle = New System.Windows.Forms.Label()
        Me.lbl_numero = New System.Windows.Forms.Label()
        Me.lbl_antecedentesLab = New System.Windows.Forms.Label()
        Me.lbl_antecedentesFlia = New System.Windows.Forms.Label()
        Me.lbl_nucleoFlia = New System.Windows.Forms.Label()
        Me.lbl_email = New System.Windows.Forms.Label()
        Me.lbl_departamento = New System.Windows.Forms.Label()
        Me.lbl_calle = New System.Windows.Forms.Label()
        Me.lbl_telefono = New System.Windows.Forms.Label()
        Me.lbl_fechaNacimiento = New System.Windows.Forms.Label()
        Me.lbl_apellidos = New System.Windows.Forms.Label()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.BtnCancelar = New Guna.UI2.WinForms.Guna2Button()
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
        Me.DgvPacientes.AllowUserToAddRows = False
        Me.DgvPacientes.AllowUserToDeleteRows = False
        Me.DgvPacientes.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.DgvPacientes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvPacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvPacientes.BackgroundColor = System.Drawing.Color.White
        Me.DgvPacientes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvPacientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgvPacientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(123, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvPacientes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        resources.ApplyResources(Me.DgvPacientes, "DgvPacientes")
        Me.DgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Roboto", 11.25!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(222, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvPacientes.DefaultCellStyle = DataGridViewCellStyle3
        Me.DgvPacientes.EnableHeadersVisualStyles = False
        Me.DgvPacientes.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvPacientes.Name = "DgvPacientes"
        Me.DgvPacientes.ReadOnly = True
        Me.DgvPacientes.RowHeadersVisible = False
        Me.DgvPacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvPacientes.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.DgvPacientes.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.DgvPacientes.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DgvPacientes.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DgvPacientes.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DgvPacientes.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DgvPacientes.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DgvPacientes.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvPacientes.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.DgvPacientes.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvPacientes.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DgvPacientes.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DgvPacientes.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgvPacientes.ThemeStyle.HeaderStyle.Height = 40
        Me.DgvPacientes.ThemeStyle.ReadOnly = True
        Me.DgvPacientes.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DgvPacientes.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgvPacientes.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Roboto", 11.25!)
        Me.DgvPacientes.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DgvPacientes.ThemeStyle.RowsStyle.Height = 22
        Me.DgvPacientes.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.DgvPacientes.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'pnl_filtrar
        '
        Me.pnl_filtrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.pnl_filtrar.Controls.Add(Me.TxtBDetalle)
        Me.pnl_filtrar.Controls.Add(Me.BtnFiltrar)
        Me.pnl_filtrar.Controls.Add(Me.BtnResetPassword)
        Me.pnl_filtrar.Controls.Add(Me.BtnEliminar)
        Me.pnl_filtrar.Controls.Add(Me.BtnModificar)
        Me.pnl_filtrar.Controls.Add(Me.TxtBCi)
        Me.pnl_filtrar.Controls.Add(Me.LblBCi)
        Me.pnl_filtrar.Controls.Add(Me.CmbBDepartamento)
        Me.pnl_filtrar.Controls.Add(Me.TxtBEmail)
        Me.pnl_filtrar.Controls.Add(Me.Label10)
        Me.pnl_filtrar.Controls.Add(Me.TxtBLocalidad)
        Me.pnl_filtrar.Controls.Add(Me.Label8)
        Me.pnl_filtrar.Controls.Add(Me.Label9)
        Me.pnl_filtrar.Controls.Add(Me.TxtBCalle)
        Me.pnl_filtrar.Controls.Add(Me.TxtBNumero)
        Me.pnl_filtrar.Controls.Add(Me.Label5)
        Me.pnl_filtrar.Controls.Add(Me.Label6)
        Me.pnl_filtrar.Controls.Add(Me.Label7)
        Me.pnl_filtrar.Controls.Add(Me.TxtBEdad)
        Me.pnl_filtrar.Controls.Add(Me.Label4)
        Me.pnl_filtrar.Controls.Add(Me.TxtBTelefono)
        Me.pnl_filtrar.Controls.Add(Me.Label3)
        Me.pnl_filtrar.Controls.Add(Me.TxtBApellidoM)
        Me.pnl_filtrar.Controls.Add(Me.TxtBApellidoP)
        Me.pnl_filtrar.Controls.Add(Me.TxtBNombre)
        Me.pnl_filtrar.Controls.Add(Me.Label1)
        Me.pnl_filtrar.Controls.Add(Me.Label2)
        resources.ApplyResources(Me.pnl_filtrar, "pnl_filtrar")
        Me.pnl_filtrar.Name = "pnl_filtrar"
        '
        'TxtBDetalle
        '
        Me.TxtBDetalle.Animated = True
        Me.TxtBDetalle.BorderRadius = 6
        Me.TxtBDetalle.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtBDetalle.DefaultText = ""
        Me.TxtBDetalle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtBDetalle.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtBDetalle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtBDetalle.DisabledState.Parent = Me.TxtBDetalle
        Me.TxtBDetalle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtBDetalle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtBDetalle.FocusedState.Parent = Me.TxtBDetalle
        resources.ApplyResources(Me.TxtBDetalle, "TxtBDetalle")
        Me.TxtBDetalle.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtBDetalle.HoverState.Parent = Me.TxtBDetalle
        Me.TxtBDetalle.Name = "TxtBDetalle"
        Me.TxtBDetalle.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtBDetalle.PlaceholderText = ""
        Me.TxtBDetalle.SelectedText = ""
        Me.TxtBDetalle.ShadowDecoration.Parent = Me.TxtBDetalle
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
        'LblBCi
        '
        resources.ApplyResources(Me.LblBCi, "LblBCi")
        Me.LblBCi.BackColor = System.Drawing.Color.Transparent
        Me.LblBCi.Name = "LblBCi"
        '
        'CmbBDepartamento
        '
        Me.CmbBDepartamento.Animated = True
        Me.CmbBDepartamento.BackColor = System.Drawing.Color.Transparent
        Me.CmbBDepartamento.BorderRadius = 6
        Me.CmbBDepartamento.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CmbBDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbBDepartamento.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmbBDepartamento.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmbBDepartamento.FocusedState.Parent = Me.CmbBDepartamento
        resources.ApplyResources(Me.CmbBDepartamento, "CmbBDepartamento")
        Me.CmbBDepartamento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CmbBDepartamento.HoverState.Parent = Me.CmbBDepartamento
        Me.CmbBDepartamento.ItemsAppearance.Parent = Me.CmbBDepartamento
        Me.CmbBDepartamento.Name = "CmbBDepartamento"
        Me.CmbBDepartamento.ShadowDecoration.Parent = Me.CmbBDepartamento
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
        'Label10
        '
        resources.ApplyResources(Me.Label10, "Label10")
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Name = "Label10"
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
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Name = "Label3"
        '
        'TxtBApellidoM
        '
        Me.TxtBApellidoM.Animated = True
        Me.TxtBApellidoM.BorderRadius = 6
        Me.TxtBApellidoM.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtBApellidoM.DefaultText = ""
        Me.TxtBApellidoM.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtBApellidoM.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtBApellidoM.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtBApellidoM.DisabledState.Parent = Me.TxtBApellidoM
        Me.TxtBApellidoM.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtBApellidoM.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtBApellidoM.FocusedState.Parent = Me.TxtBApellidoM
        resources.ApplyResources(Me.TxtBApellidoM, "TxtBApellidoM")
        Me.TxtBApellidoM.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtBApellidoM.HoverState.Parent = Me.TxtBApellidoM
        Me.TxtBApellidoM.Name = "TxtBApellidoM"
        Me.TxtBApellidoM.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtBApellidoM.PlaceholderText = ""
        Me.TxtBApellidoM.SelectedText = ""
        Me.TxtBApellidoM.ShadowDecoration.Parent = Me.TxtBApellidoM
        '
        'TxtBApellidoP
        '
        Me.TxtBApellidoP.Animated = True
        Me.TxtBApellidoP.BorderRadius = 6
        Me.TxtBApellidoP.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtBApellidoP.DefaultText = ""
        Me.TxtBApellidoP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtBApellidoP.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtBApellidoP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtBApellidoP.DisabledState.Parent = Me.TxtBApellidoP
        Me.TxtBApellidoP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtBApellidoP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtBApellidoP.FocusedState.Parent = Me.TxtBApellidoP
        resources.ApplyResources(Me.TxtBApellidoP, "TxtBApellidoP")
        Me.TxtBApellidoP.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtBApellidoP.HoverState.Parent = Me.TxtBApellidoP
        Me.TxtBApellidoP.Name = "TxtBApellidoP"
        Me.TxtBApellidoP.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtBApellidoP.PlaceholderText = ""
        Me.TxtBApellidoP.SelectedText = ""
        Me.TxtBApellidoP.ShadowDecoration.Parent = Me.TxtBApellidoP
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
        Me.pnl_ingresar.Controls.Add(Me.BtnCancelar)
        Me.pnl_ingresar.Controls.Add(Me.TxtIDetalle)
        Me.pnl_ingresar.Controls.Add(Me.TxtICi)
        Me.pnl_ingresar.Controls.Add(Me.LblCi)
        Me.pnl_ingresar.Controls.Add(Me.CmbIDepartamento)
        Me.pnl_ingresar.Controls.Add(Me.BtnIngresar)
        Me.pnl_ingresar.Controls.Add(Me.BtnVolver)
        Me.pnl_ingresar.Controls.Add(Me.TxtIAntLab)
        Me.pnl_ingresar.Controls.Add(Me.TxtIAntFam)
        Me.pnl_ingresar.Controls.Add(Me.TxtINFam)
        Me.pnl_ingresar.Controls.Add(Me.TxtIEmail)
        Me.pnl_ingresar.Controls.Add(Me.TxtILocalidad)
        Me.pnl_ingresar.Controls.Add(Me.TxtICalle)
        Me.pnl_ingresar.Controls.Add(Me.TxtINumero)
        Me.pnl_ingresar.Controls.Add(Me.TxtITelefono)
        Me.pnl_ingresar.Controls.Add(Me.TxtIApellidoM)
        Me.pnl_ingresar.Controls.Add(Me.TxtIApellidoP)
        Me.pnl_ingresar.Controls.Add(Me.TxtINombre)
        Me.pnl_ingresar.Controls.Add(Me.DTPickerFNac)
        Me.pnl_ingresar.Controls.Add(Me.lbl_localidad)
        Me.pnl_ingresar.Controls.Add(Me.lbl_detalle)
        Me.pnl_ingresar.Controls.Add(Me.lbl_numero)
        Me.pnl_ingresar.Controls.Add(Me.lbl_antecedentesLab)
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
        'TxtIDetalle
        '
        Me.TxtIDetalle.Animated = True
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
        'LblCi
        '
        resources.ApplyResources(Me.LblCi, "LblCi")
        Me.LblCi.BackColor = System.Drawing.Color.Transparent
        Me.LblCi.Name = "LblCi"
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
        'TxtIAntLab
        '
        Me.TxtIAntLab.Animated = True
        Me.TxtIAntLab.BorderRadius = 6
        Me.TxtIAntLab.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtIAntLab.DefaultText = ""
        Me.TxtIAntLab.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtIAntLab.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtIAntLab.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtIAntLab.DisabledState.Parent = Me.TxtIAntLab
        Me.TxtIAntLab.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtIAntLab.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtIAntLab.FocusedState.Parent = Me.TxtIAntLab
        resources.ApplyResources(Me.TxtIAntLab, "TxtIAntLab")
        Me.TxtIAntLab.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtIAntLab.HoverState.Parent = Me.TxtIAntLab
        Me.TxtIAntLab.Multiline = True
        Me.TxtIAntLab.Name = "TxtIAntLab"
        Me.TxtIAntLab.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtIAntLab.PlaceholderText = ""
        Me.TxtIAntLab.SelectedText = ""
        Me.TxtIAntLab.ShadowDecoration.Parent = Me.TxtIAntLab
        '
        'TxtIAntFam
        '
        Me.TxtIAntFam.Animated = True
        Me.TxtIAntFam.BorderRadius = 6
        Me.TxtIAntFam.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtIAntFam.DefaultText = ""
        Me.TxtIAntFam.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtIAntFam.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtIAntFam.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtIAntFam.DisabledState.Parent = Me.TxtIAntFam
        Me.TxtIAntFam.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtIAntFam.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtIAntFam.FocusedState.Parent = Me.TxtIAntFam
        resources.ApplyResources(Me.TxtIAntFam, "TxtIAntFam")
        Me.TxtIAntFam.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtIAntFam.HoverState.Parent = Me.TxtIAntFam
        Me.TxtIAntFam.Multiline = True
        Me.TxtIAntFam.Name = "TxtIAntFam"
        Me.TxtIAntFam.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtIAntFam.PlaceholderText = ""
        Me.TxtIAntFam.SelectedText = ""
        Me.TxtIAntFam.ShadowDecoration.Parent = Me.TxtIAntFam
        '
        'TxtINFam
        '
        Me.TxtINFam.Animated = True
        Me.TxtINFam.BorderRadius = 6
        Me.TxtINFam.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtINFam.DefaultText = ""
        Me.TxtINFam.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtINFam.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtINFam.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtINFam.DisabledState.Parent = Me.TxtINFam
        Me.TxtINFam.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtINFam.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtINFam.FocusedState.Parent = Me.TxtINFam
        resources.ApplyResources(Me.TxtINFam, "TxtINFam")
        Me.TxtINFam.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtINFam.HoverState.Parent = Me.TxtINFam
        Me.TxtINFam.Name = "TxtINFam"
        Me.TxtINFam.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtINFam.PlaceholderText = ""
        Me.TxtINFam.SelectedText = ""
        Me.TxtINFam.ShadowDecoration.Parent = Me.TxtINFam
        '
        'TxtIEmail
        '
        Me.TxtIEmail.Animated = True
        Me.TxtIEmail.BorderRadius = 6
        Me.TxtIEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtIEmail.DefaultText = ""
        Me.TxtIEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtIEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtIEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtIEmail.DisabledState.Parent = Me.TxtIEmail
        Me.TxtIEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtIEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtIEmail.FocusedState.Parent = Me.TxtIEmail
        resources.ApplyResources(Me.TxtIEmail, "TxtIEmail")
        Me.TxtIEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtIEmail.HoverState.Parent = Me.TxtIEmail
        Me.TxtIEmail.Name = "TxtIEmail"
        Me.TxtIEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtIEmail.PlaceholderText = ""
        Me.TxtIEmail.SelectedText = ""
        Me.TxtIEmail.ShadowDecoration.Parent = Me.TxtIEmail
        '
        'TxtILocalidad
        '
        Me.TxtILocalidad.Animated = True
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
        'TxtICalle
        '
        Me.TxtICalle.Animated = True
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
        'TxtINumero
        '
        Me.TxtINumero.Animated = True
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
        'TxtITelefono
        '
        Me.TxtITelefono.Animated = True
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
        'TxtIApellidoM
        '
        Me.TxtIApellidoM.Animated = True
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
        'TxtIApellidoP
        '
        Me.TxtIApellidoP.Animated = True
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
        'TxtINombre
        '
        Me.TxtINombre.Animated = True
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
        'DTPickerFNac
        '
        Me.DTPickerFNac.Animated = True
        Me.DTPickerFNac.AutoRoundedCorners = True
        Me.DTPickerFNac.BorderRadius = 16
        Me.DTPickerFNac.CheckedState.Parent = Me.DTPickerFNac
        Me.DTPickerFNac.FillColor = System.Drawing.Color.White
        resources.ApplyResources(Me.DTPickerFNac, "DTPickerFNac")
        Me.DTPickerFNac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPickerFNac.HoverState.Parent = Me.DTPickerFNac
        Me.DTPickerFNac.MaxDate = New Date(2020, 8, 30, 0, 0, 0, 0)
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
        'lbl_antecedentesLab
        '
        resources.ApplyResources(Me.lbl_antecedentesLab, "lbl_antecedentesLab")
        Me.lbl_antecedentesLab.BackColor = System.Drawing.Color.Transparent
        Me.lbl_antecedentesLab.Name = "lbl_antecedentesLab"
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
        'BtnCancelar
        '
        Me.BtnCancelar.Animated = True
        Me.BtnCancelar.AutoRoundedCorners = True
        Me.BtnCancelar.BackColor = System.Drawing.Color.Transparent
        Me.BtnCancelar.BorderRadius = 17
        Me.BtnCancelar.CheckedState.Parent = Me.BtnCancelar
        Me.BtnCancelar.CustomImages.Parent = Me.BtnCancelar
        Me.BtnCancelar.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(123, Byte), Integer))
        resources.ApplyResources(Me.BtnCancelar, "BtnCancelar")
        Me.BtnCancelar.ForeColor = System.Drawing.Color.White
        Me.BtnCancelar.HoverState.Parent = Me.BtnCancelar
        Me.BtnCancelar.ImageSize = New System.Drawing.Size(0, 0)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.ShadowDecoration.Parent = Me.BtnCancelar
        Me.BtnCancelar.UseTransparentBackground = True
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
    Friend WithEvents TxtIAntLab As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtIAntFam As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtINFam As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtIEmail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtILocalidad As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtICalle As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtINumero As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtITelefono As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtIApellidoM As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtIApellidoP As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtINombre As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents DTPickerFNac As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents lbl_localidad As Label
    Friend WithEvents lbl_detalle As Label
    Friend WithEvents lbl_numero As Label
    Friend WithEvents lbl_antecedentesLab As Label
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
    Friend WithEvents TxtBEmail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtBLocalidad As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtBCalle As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtBNumero As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtBEdad As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtBTelefono As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtBApellidoM As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtBApellidoP As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtBNombre As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CmbBDepartamento As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents CmbIDepartamento As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents BtnMinimize As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents BtnExit As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents TxtBCi As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents LblBCi As Label
    Friend WithEvents TxtICi As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents LblCi As Label
    Friend WithEvents BtnFiltrar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnResetPassword As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnEliminar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnModificar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DgvPacientes As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents TxtIDetalle As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtBDetalle As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BtnCancelar As Guna.UI2.WinForms.Guna2Button
End Class
