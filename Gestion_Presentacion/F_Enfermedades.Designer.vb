<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F_Enfermedades
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PnlSide = New Guna.UI2.WinForms.Guna2Panel()
        Me.LblImportar = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TxtImportar = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BtnIngresar = New Guna.UI2.WinForms.Guna2Button()
        Me.TxtIDescripcion = New Guna.UI2.WinForms.Guna2TextBox()
        Me.LblIDescripcion = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.BtnImportar = New Guna.UI2.WinForms.Guna2Button()
        Me.LblIngresar = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.BtnIDelItem = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.BtnIAddItem = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.CmbIMedicacion = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.CmbIUrgencia = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.LblIMedicacion = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.LblIUrgencia = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.LblIEnfermedad = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TxtIEnfermedad = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BtnFiltrar = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnVolver = New Guna.UI2.WinForms.Guna2Button()
        Me.LblBusqueda = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.BtnBDelItem = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.BtnBAddItem = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.CmbBMedicacion = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.CmbBUrgencia = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.LblEnfermedades = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.LblBUrgencia = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.LblBEnfermedad = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TxtBEnfermedad = New Guna.UI2.WinForms.Guna2TextBox()
        Me.PnlDgv = New Guna.UI2.WinForms.Guna2Panel()
        Me.BtnMinimize = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.BtnExit = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.DgvEnfermedades = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.PnlSide.SuspendLayout()
        Me.PnlDgv.SuspendLayout()
        CType(Me.DgvEnfermedades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlSide
        '
        Me.PnlSide.Controls.Add(Me.LblImportar)
        Me.PnlSide.Controls.Add(Me.TxtImportar)
        Me.PnlSide.Controls.Add(Me.BtnIngresar)
        Me.PnlSide.Controls.Add(Me.TxtIDescripcion)
        Me.PnlSide.Controls.Add(Me.LblIDescripcion)
        Me.PnlSide.Controls.Add(Me.BtnImportar)
        Me.PnlSide.Controls.Add(Me.LblIngresar)
        Me.PnlSide.Controls.Add(Me.BtnIDelItem)
        Me.PnlSide.Controls.Add(Me.BtnIAddItem)
        Me.PnlSide.Controls.Add(Me.CmbIMedicacion)
        Me.PnlSide.Controls.Add(Me.CmbIUrgencia)
        Me.PnlSide.Controls.Add(Me.LblIMedicacion)
        Me.PnlSide.Controls.Add(Me.LblIUrgencia)
        Me.PnlSide.Controls.Add(Me.LblIEnfermedad)
        Me.PnlSide.Controls.Add(Me.TxtIEnfermedad)
        Me.PnlSide.Controls.Add(Me.BtnFiltrar)
        Me.PnlSide.Controls.Add(Me.BtnVolver)
        Me.PnlSide.Controls.Add(Me.LblBusqueda)
        Me.PnlSide.Controls.Add(Me.BtnBDelItem)
        Me.PnlSide.Controls.Add(Me.BtnBAddItem)
        Me.PnlSide.Controls.Add(Me.CmbBMedicacion)
        Me.PnlSide.Controls.Add(Me.CmbBUrgencia)
        Me.PnlSide.Controls.Add(Me.LblEnfermedades)
        Me.PnlSide.Controls.Add(Me.LblBUrgencia)
        Me.PnlSide.Controls.Add(Me.LblBEnfermedad)
        Me.PnlSide.Controls.Add(Me.TxtBEnfermedad)
        Me.PnlSide.FillColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.PnlSide.Location = New System.Drawing.Point(0, 0)
        Me.PnlSide.Margin = New System.Windows.Forms.Padding(0)
        Me.PnlSide.Name = "PnlSide"
        Me.PnlSide.ShadowDecoration.Parent = Me.PnlSide
        Me.PnlSide.Size = New System.Drawing.Size(573, 1080)
        Me.PnlSide.TabIndex = 0
        '
        'LblImportar
        '
        Me.LblImportar.BackColor = System.Drawing.Color.Transparent
        Me.LblImportar.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblImportar.Location = New System.Drawing.Point(56, 592)
        Me.LblImportar.Name = "LblImportar"
        Me.LblImportar.Size = New System.Drawing.Size(83, 27)
        Me.LblImportar.TabIndex = 106
        Me.LblImportar.Text = "Importar"
        '
        'TxtImportar
        '
        Me.TxtImportar.Animated = True
        Me.TxtImportar.BackColor = System.Drawing.Color.Transparent
        Me.TxtImportar.BorderRadius = 6
        Me.TxtImportar.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtImportar.DefaultText = ""
        Me.TxtImportar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtImportar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtImportar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtImportar.DisabledState.Parent = Me.TxtImportar
        Me.TxtImportar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtImportar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtImportar.FocusedState.Parent = Me.TxtImportar
        Me.TxtImportar.Font = New System.Drawing.Font("Roboto", 16.0!)
        Me.TxtImportar.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtImportar.HoverState.Parent = Me.TxtImportar
        Me.TxtImportar.Location = New System.Drawing.Point(155, 589)
        Me.TxtImportar.Margin = New System.Windows.Forms.Padding(0, 0, 0, 7)
        Me.TxtImportar.Name = "TxtImportar"
        Me.TxtImportar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtImportar.PlaceholderText = ""
        Me.TxtImportar.SelectedText = ""
        Me.TxtImportar.ShadowDecoration.Parent = Me.TxtImportar
        Me.TxtImportar.Size = New System.Drawing.Size(382, 32)
        Me.TxtImportar.TabIndex = 105
        '
        'BtnIngresar
        '
        Me.BtnIngresar.Animated = True
        Me.BtnIngresar.AutoRoundedCorners = True
        Me.BtnIngresar.BackColor = System.Drawing.Color.Transparent
        Me.BtnIngresar.BorderRadius = 15
        Me.BtnIngresar.CheckedState.Parent = Me.BtnIngresar
        Me.BtnIngresar.CustomImages.Parent = Me.BtnIngresar
        Me.BtnIngresar.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.BtnIngresar.Font = New System.Drawing.Font("Roboto", 14.0!)
        Me.BtnIngresar.ForeColor = System.Drawing.Color.White
        Me.BtnIngresar.HoverState.Parent = Me.BtnIngresar
        Me.BtnIngresar.Location = New System.Drawing.Point(446, 520)
        Me.BtnIngresar.Margin = New System.Windows.Forms.Padding(3, 23, 3, 3)
        Me.BtnIngresar.Name = "BtnIngresar"
        Me.BtnIngresar.ShadowDecoration.Parent = Me.BtnIngresar
        Me.BtnIngresar.Size = New System.Drawing.Size(91, 32)
        Me.BtnIngresar.TabIndex = 104
        Me.BtnIngresar.Text = "Ingresar"
        Me.BtnIngresar.UseTransparentBackground = True
        '
        'TxtIDescripcion
        '
        Me.TxtIDescripcion.Animated = True
        Me.TxtIDescripcion.BackColor = System.Drawing.Color.Transparent
        Me.TxtIDescripcion.BorderRadius = 6
        Me.TxtIDescripcion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtIDescripcion.DefaultText = ""
        Me.TxtIDescripcion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtIDescripcion.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtIDescripcion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtIDescripcion.DisabledState.Parent = Me.TxtIDescripcion
        Me.TxtIDescripcion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtIDescripcion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtIDescripcion.FocusedState.Parent = Me.TxtIDescripcion
        Me.TxtIDescripcion.Font = New System.Drawing.Font("Roboto", 16.0!)
        Me.TxtIDescripcion.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtIDescripcion.HoverState.Parent = Me.TxtIDescripcion
        Me.TxtIDescripcion.Location = New System.Drawing.Point(236, 451)
        Me.TxtIDescripcion.Margin = New System.Windows.Forms.Padding(0, 0, 0, 7)
        Me.TxtIDescripcion.Multiline = True
        Me.TxtIDescripcion.Name = "TxtIDescripcion"
        Me.TxtIDescripcion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtIDescripcion.PlaceholderText = ""
        Me.TxtIDescripcion.SelectedText = ""
        Me.TxtIDescripcion.ShadowDecoration.Parent = Me.TxtIDescripcion
        Me.TxtIDescripcion.Size = New System.Drawing.Size(301, 64)
        Me.TxtIDescripcion.TabIndex = 103
        '
        'LblIDescripcion
        '
        Me.LblIDescripcion.BackColor = System.Drawing.Color.Transparent
        Me.LblIDescripcion.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblIDescripcion.Location = New System.Drawing.Point(56, 451)
        Me.LblIDescripcion.Name = "LblIDescripcion"
        Me.LblIDescripcion.Size = New System.Drawing.Size(114, 27)
        Me.LblIDescripcion.TabIndex = 102
        Me.LblIDescripcion.Text = "Descripción"
        '
        'BtnImportar
        '
        Me.BtnImportar.Animated = True
        Me.BtnImportar.AutoRoundedCorners = True
        Me.BtnImportar.BackColor = System.Drawing.Color.Transparent
        Me.BtnImportar.BorderRadius = 15
        Me.BtnImportar.CheckedState.Parent = Me.BtnImportar
        Me.BtnImportar.CustomImages.Parent = Me.BtnImportar
        Me.BtnImportar.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.BtnImportar.Font = New System.Drawing.Font("Roboto", 14.0!)
        Me.BtnImportar.ForeColor = System.Drawing.Color.White
        Me.BtnImportar.HoverState.Parent = Me.BtnImportar
        Me.BtnImportar.Location = New System.Drawing.Point(449, 648)
        Me.BtnImportar.Margin = New System.Windows.Forms.Padding(3, 23, 3, 3)
        Me.BtnImportar.Name = "BtnImportar"
        Me.BtnImportar.ShadowDecoration.Parent = Me.BtnImportar
        Me.BtnImportar.Size = New System.Drawing.Size(91, 32)
        Me.BtnImportar.TabIndex = 101
        Me.BtnImportar.Text = "Importar"
        Me.BtnImportar.UseTransparentBackground = True
        '
        'LblIngresar
        '
        Me.LblIngresar.BackColor = System.Drawing.Color.Transparent
        Me.LblIngresar.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblIngresar.Location = New System.Drawing.Point(56, 281)
        Me.LblIngresar.Margin = New System.Windows.Forms.Padding(3, 3, 3, 18)
        Me.LblIngresar.Name = "LblIngresar"
        Me.LblIngresar.Size = New System.Drawing.Size(88, 27)
        Me.LblIngresar.TabIndex = 100
        Me.LblIngresar.Text = "Ingresar"
        '
        'BtnIDelItem
        '
        Me.BtnIDelItem.Animated = True
        Me.BtnIDelItem.BackColor = System.Drawing.Color.Transparent
        Me.BtnIDelItem.CheckedState.Parent = Me.BtnIDelItem
        Me.BtnIDelItem.CustomImages.Parent = Me.BtnIDelItem
        Me.BtnIDelItem.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.BtnIDelItem.Font = New System.Drawing.Font("Roboto", 16.0!)
        Me.BtnIDelItem.ForeColor = System.Drawing.Color.White
        Me.BtnIDelItem.HoverState.Parent = Me.BtnIDelItem
        Me.BtnIDelItem.Location = New System.Drawing.Point(506, 414)
        Me.BtnIDelItem.Name = "BtnIDelItem"
        Me.BtnIDelItem.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.BtnIDelItem.ShadowDecoration.Parent = Me.BtnIDelItem
        Me.BtnIDelItem.Size = New System.Drawing.Size(24, 24)
        Me.BtnIDelItem.TabIndex = 99
        Me.BtnIDelItem.Text = "-"
        '
        'BtnIAddItem
        '
        Me.BtnIAddItem.Animated = True
        Me.BtnIAddItem.BackColor = System.Drawing.Color.Transparent
        Me.BtnIAddItem.CheckedState.Parent = Me.BtnIAddItem
        Me.BtnIAddItem.CustomImages.Parent = Me.BtnIAddItem
        Me.BtnIAddItem.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.BtnIAddItem.Font = New System.Drawing.Font("Roboto", 16.0!)
        Me.BtnIAddItem.ForeColor = System.Drawing.Color.White
        Me.BtnIAddItem.HoverState.Parent = Me.BtnIAddItem
        Me.BtnIAddItem.Location = New System.Drawing.Point(476, 414)
        Me.BtnIAddItem.Name = "BtnIAddItem"
        Me.BtnIAddItem.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.BtnIAddItem.ShadowDecoration.Parent = Me.BtnIAddItem
        Me.BtnIAddItem.Size = New System.Drawing.Size(24, 24)
        Me.BtnIAddItem.TabIndex = 98
        Me.BtnIAddItem.Text = "+"
        '
        'CmbIMedicacion
        '
        Me.CmbIMedicacion.Animated = True
        Me.CmbIMedicacion.BackColor = System.Drawing.Color.Transparent
        Me.CmbIMedicacion.BorderRadius = 6
        Me.CmbIMedicacion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CmbIMedicacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbIMedicacion.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmbIMedicacion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmbIMedicacion.FocusedState.Parent = Me.CmbIMedicacion
        Me.CmbIMedicacion.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CmbIMedicacion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CmbIMedicacion.HoverState.Parent = Me.CmbIMedicacion
        Me.CmbIMedicacion.ItemHeight = 30
        Me.CmbIMedicacion.ItemsAppearance.Parent = Me.CmbIMedicacion
        Me.CmbIMedicacion.Location = New System.Drawing.Point(236, 408)
        Me.CmbIMedicacion.Margin = New System.Windows.Forms.Padding(0, 0, 0, 7)
        Me.CmbIMedicacion.Name = "CmbIMedicacion"
        Me.CmbIMedicacion.ShadowDecoration.Parent = Me.CmbIMedicacion
        Me.CmbIMedicacion.Size = New System.Drawing.Size(230, 36)
        Me.CmbIMedicacion.TabIndex = 97
        '
        'CmbIUrgencia
        '
        Me.CmbIUrgencia.Animated = True
        Me.CmbIUrgencia.BackColor = System.Drawing.Color.Transparent
        Me.CmbIUrgencia.BorderRadius = 6
        Me.CmbIUrgencia.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CmbIUrgencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbIUrgencia.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmbIUrgencia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmbIUrgencia.FocusedState.Parent = Me.CmbIUrgencia
        Me.CmbIUrgencia.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CmbIUrgencia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CmbIUrgencia.HoverState.Parent = Me.CmbIUrgencia
        Me.CmbIUrgencia.ItemHeight = 30
        Me.CmbIUrgencia.ItemsAppearance.Parent = Me.CmbIUrgencia
        Me.CmbIUrgencia.Location = New System.Drawing.Point(236, 365)
        Me.CmbIUrgencia.Margin = New System.Windows.Forms.Padding(0, 0, 0, 7)
        Me.CmbIUrgencia.Name = "CmbIUrgencia"
        Me.CmbIUrgencia.ShadowDecoration.Parent = Me.CmbIUrgencia
        Me.CmbIUrgencia.Size = New System.Drawing.Size(230, 36)
        Me.CmbIUrgencia.TabIndex = 96
        '
        'LblIMedicacion
        '
        Me.LblIMedicacion.BackColor = System.Drawing.Color.Transparent
        Me.LblIMedicacion.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblIMedicacion.Location = New System.Drawing.Point(56, 413)
        Me.LblIMedicacion.Name = "LblIMedicacion"
        Me.LblIMedicacion.Size = New System.Drawing.Size(111, 27)
        Me.LblIMedicacion.TabIndex = 95
        Me.LblIMedicacion.Text = "Medicación"
        '
        'LblIUrgencia
        '
        Me.LblIUrgencia.BackColor = System.Drawing.Color.Transparent
        Me.LblIUrgencia.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblIUrgencia.Location = New System.Drawing.Point(56, 370)
        Me.LblIUrgencia.Name = "LblIUrgencia"
        Me.LblIUrgencia.Size = New System.Drawing.Size(86, 27)
        Me.LblIUrgencia.TabIndex = 94
        Me.LblIUrgencia.Text = "Urgencia"
        '
        'LblIEnfermedad
        '
        Me.LblIEnfermedad.BackColor = System.Drawing.Color.Transparent
        Me.LblIEnfermedad.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblIEnfermedad.Location = New System.Drawing.Point(56, 329)
        Me.LblIEnfermedad.Name = "LblIEnfermedad"
        Me.LblIEnfermedad.Size = New System.Drawing.Size(116, 27)
        Me.LblIEnfermedad.TabIndex = 93
        Me.LblIEnfermedad.Text = "Enfermedad"
        '
        'TxtIEnfermedad
        '
        Me.TxtIEnfermedad.Animated = True
        Me.TxtIEnfermedad.BackColor = System.Drawing.Color.Transparent
        Me.TxtIEnfermedad.BorderRadius = 6
        Me.TxtIEnfermedad.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtIEnfermedad.DefaultText = ""
        Me.TxtIEnfermedad.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtIEnfermedad.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtIEnfermedad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtIEnfermedad.DisabledState.Parent = Me.TxtIEnfermedad
        Me.TxtIEnfermedad.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtIEnfermedad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtIEnfermedad.FocusedState.Parent = Me.TxtIEnfermedad
        Me.TxtIEnfermedad.Font = New System.Drawing.Font("Roboto", 16.0!)
        Me.TxtIEnfermedad.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtIEnfermedad.HoverState.Parent = Me.TxtIEnfermedad
        Me.TxtIEnfermedad.Location = New System.Drawing.Point(236, 326)
        Me.TxtIEnfermedad.Margin = New System.Windows.Forms.Padding(0, 0, 0, 7)
        Me.TxtIEnfermedad.Name = "TxtIEnfermedad"
        Me.TxtIEnfermedad.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtIEnfermedad.PlaceholderText = ""
        Me.TxtIEnfermedad.SelectedText = ""
        Me.TxtIEnfermedad.ShadowDecoration.Parent = Me.TxtIEnfermedad
        Me.TxtIEnfermedad.Size = New System.Drawing.Size(230, 32)
        Me.TxtIEnfermedad.TabIndex = 92
        '
        'BtnFiltrar
        '
        Me.BtnFiltrar.Animated = True
        Me.BtnFiltrar.AutoRoundedCorners = True
        Me.BtnFiltrar.BackColor = System.Drawing.Color.Transparent
        Me.BtnFiltrar.BorderRadius = 15
        Me.BtnFiltrar.CheckedState.Parent = Me.BtnFiltrar
        Me.BtnFiltrar.CustomImages.Parent = Me.BtnFiltrar
        Me.BtnFiltrar.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.BtnFiltrar.Font = New System.Drawing.Font("Roboto", 14.0!)
        Me.BtnFiltrar.ForeColor = System.Drawing.Color.White
        Me.BtnFiltrar.HoverState.Parent = Me.BtnFiltrar
        Me.BtnFiltrar.Location = New System.Drawing.Point(449, 261)
        Me.BtnFiltrar.Margin = New System.Windows.Forms.Padding(3, 23, 3, 3)
        Me.BtnFiltrar.Name = "BtnFiltrar"
        Me.BtnFiltrar.ShadowDecoration.Parent = Me.BtnFiltrar
        Me.BtnFiltrar.Size = New System.Drawing.Size(81, 32)
        Me.BtnFiltrar.TabIndex = 91
        Me.BtnFiltrar.Text = "Filtrar"
        Me.BtnFiltrar.UseTransparentBackground = True
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
        Me.BtnVolver.Font = New System.Drawing.Font("Roboto", 16.0!)
        Me.BtnVolver.ForeColor = System.Drawing.Color.White
        Me.BtnVolver.HoverState.Parent = Me.BtnVolver
        Me.BtnVolver.Location = New System.Drawing.Point(16, 15)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.ShadowDecoration.Parent = Me.BtnVolver
        Me.BtnVolver.Size = New System.Drawing.Size(85, 30)
        Me.BtnVolver.TabIndex = 90
        Me.BtnVolver.Text = "Volver"
        Me.BtnVolver.UseTransparentBackground = True
        '
        'LblBusqueda
        '
        Me.LblBusqueda.BackColor = System.Drawing.Color.Transparent
        Me.LblBusqueda.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBusqueda.Location = New System.Drawing.Point(56, 67)
        Me.LblBusqueda.Margin = New System.Windows.Forms.Padding(3, 3, 3, 18)
        Me.LblBusqueda.Name = "LblBusqueda"
        Me.LblBusqueda.Size = New System.Drawing.Size(105, 27)
        Me.LblBusqueda.TabIndex = 89
        Me.LblBusqueda.Text = "Búsqueda"
        '
        'BtnBDelItem
        '
        Me.BtnBDelItem.Animated = True
        Me.BtnBDelItem.BackColor = System.Drawing.Color.Transparent
        Me.BtnBDelItem.CheckedState.Parent = Me.BtnBDelItem
        Me.BtnBDelItem.CustomImages.Parent = Me.BtnBDelItem
        Me.BtnBDelItem.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.BtnBDelItem.Font = New System.Drawing.Font("Roboto", 16.0!)
        Me.BtnBDelItem.ForeColor = System.Drawing.Color.White
        Me.BtnBDelItem.HoverState.Parent = Me.BtnBDelItem
        Me.BtnBDelItem.Location = New System.Drawing.Point(506, 197)
        Me.BtnBDelItem.Margin = New System.Windows.Forms.Padding(0, 0, 0, 7)
        Me.BtnBDelItem.Name = "BtnBDelItem"
        Me.BtnBDelItem.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.BtnBDelItem.ShadowDecoration.Parent = Me.BtnBDelItem
        Me.BtnBDelItem.Size = New System.Drawing.Size(24, 24)
        Me.BtnBDelItem.TabIndex = 88
        Me.BtnBDelItem.Text = "-"
        '
        'BtnBAddItem
        '
        Me.BtnBAddItem.Animated = True
        Me.BtnBAddItem.BackColor = System.Drawing.Color.Transparent
        Me.BtnBAddItem.CheckedState.Parent = Me.BtnBAddItem
        Me.BtnBAddItem.CustomImages.Parent = Me.BtnBAddItem
        Me.BtnBAddItem.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.BtnBAddItem.Font = New System.Drawing.Font("Roboto", 16.0!)
        Me.BtnBAddItem.ForeColor = System.Drawing.Color.White
        Me.BtnBAddItem.HoverState.Parent = Me.BtnBAddItem
        Me.BtnBAddItem.Location = New System.Drawing.Point(476, 197)
        Me.BtnBAddItem.Margin = New System.Windows.Forms.Padding(0, 0, 0, 7)
        Me.BtnBAddItem.Name = "BtnBAddItem"
        Me.BtnBAddItem.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.BtnBAddItem.ShadowDecoration.Parent = Me.BtnBAddItem
        Me.BtnBAddItem.Size = New System.Drawing.Size(24, 24)
        Me.BtnBAddItem.TabIndex = 87
        Me.BtnBAddItem.Text = "+"
        '
        'CmbBMedicacion
        '
        Me.CmbBMedicacion.Animated = True
        Me.CmbBMedicacion.BackColor = System.Drawing.Color.Transparent
        Me.CmbBMedicacion.BorderRadius = 6
        Me.CmbBMedicacion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CmbBMedicacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbBMedicacion.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmbBMedicacion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmbBMedicacion.FocusedState.Parent = Me.CmbBMedicacion
        Me.CmbBMedicacion.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CmbBMedicacion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CmbBMedicacion.HoverState.Parent = Me.CmbBMedicacion
        Me.CmbBMedicacion.ItemHeight = 30
        Me.CmbBMedicacion.ItemsAppearance.Parent = Me.CmbBMedicacion
        Me.CmbBMedicacion.Location = New System.Drawing.Point(236, 191)
        Me.CmbBMedicacion.Margin = New System.Windows.Forms.Padding(0, 0, 0, 7)
        Me.CmbBMedicacion.Name = "CmbBMedicacion"
        Me.CmbBMedicacion.ShadowDecoration.Parent = Me.CmbBMedicacion
        Me.CmbBMedicacion.Size = New System.Drawing.Size(230, 36)
        Me.CmbBMedicacion.TabIndex = 86
        '
        'CmbBUrgencia
        '
        Me.CmbBUrgencia.Animated = True
        Me.CmbBUrgencia.BackColor = System.Drawing.Color.Transparent
        Me.CmbBUrgencia.BorderRadius = 6
        Me.CmbBUrgencia.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CmbBUrgencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbBUrgencia.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmbBUrgencia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmbBUrgencia.FocusedState.Parent = Me.CmbBUrgencia
        Me.CmbBUrgencia.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CmbBUrgencia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CmbBUrgencia.HoverState.Parent = Me.CmbBUrgencia
        Me.CmbBUrgencia.ItemHeight = 30
        Me.CmbBUrgencia.ItemsAppearance.Parent = Me.CmbBUrgencia
        Me.CmbBUrgencia.Location = New System.Drawing.Point(236, 148)
        Me.CmbBUrgencia.Margin = New System.Windows.Forms.Padding(0, 0, 0, 7)
        Me.CmbBUrgencia.Name = "CmbBUrgencia"
        Me.CmbBUrgencia.ShadowDecoration.Parent = Me.CmbBUrgencia
        Me.CmbBUrgencia.Size = New System.Drawing.Size(230, 36)
        Me.CmbBUrgencia.TabIndex = 85
        '
        'LblEnfermedades
        '
        Me.LblEnfermedades.BackColor = System.Drawing.Color.Transparent
        Me.LblEnfermedades.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEnfermedades.Location = New System.Drawing.Point(56, 196)
        Me.LblEnfermedades.Margin = New System.Windows.Forms.Padding(0, 0, 0, 7)
        Me.LblEnfermedades.Name = "LblEnfermedades"
        Me.LblEnfermedades.Size = New System.Drawing.Size(111, 27)
        Me.LblEnfermedades.TabIndex = 84
        Me.LblEnfermedades.Text = "Medicación"
        '
        'LblBUrgencia
        '
        Me.LblBUrgencia.BackColor = System.Drawing.Color.Transparent
        Me.LblBUrgencia.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBUrgencia.Location = New System.Drawing.Point(56, 153)
        Me.LblBUrgencia.Margin = New System.Windows.Forms.Padding(0, 0, 0, 7)
        Me.LblBUrgencia.Name = "LblBUrgencia"
        Me.LblBUrgencia.Size = New System.Drawing.Size(86, 27)
        Me.LblBUrgencia.TabIndex = 83
        Me.LblBUrgencia.Text = "Urgencia"
        '
        'LblBEnfermedad
        '
        Me.LblBEnfermedad.BackColor = System.Drawing.Color.Transparent
        Me.LblBEnfermedad.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBEnfermedad.Location = New System.Drawing.Point(56, 112)
        Me.LblBEnfermedad.Margin = New System.Windows.Forms.Padding(0, 0, 0, 7)
        Me.LblBEnfermedad.Name = "LblBEnfermedad"
        Me.LblBEnfermedad.Size = New System.Drawing.Size(116, 27)
        Me.LblBEnfermedad.TabIndex = 82
        Me.LblBEnfermedad.Text = "Enfermedad"
        '
        'TxtBEnfermedad
        '
        Me.TxtBEnfermedad.Animated = True
        Me.TxtBEnfermedad.BackColor = System.Drawing.Color.Transparent
        Me.TxtBEnfermedad.BorderRadius = 6
        Me.TxtBEnfermedad.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtBEnfermedad.DefaultText = ""
        Me.TxtBEnfermedad.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtBEnfermedad.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtBEnfermedad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtBEnfermedad.DisabledState.Parent = Me.TxtBEnfermedad
        Me.TxtBEnfermedad.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtBEnfermedad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtBEnfermedad.FocusedState.Parent = Me.TxtBEnfermedad
        Me.TxtBEnfermedad.Font = New System.Drawing.Font("Roboto", 16.0!)
        Me.TxtBEnfermedad.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtBEnfermedad.HoverState.Parent = Me.TxtBEnfermedad
        Me.TxtBEnfermedad.Location = New System.Drawing.Point(236, 109)
        Me.TxtBEnfermedad.Margin = New System.Windows.Forms.Padding(0, 0, 0, 7)
        Me.TxtBEnfermedad.Name = "TxtBEnfermedad"
        Me.TxtBEnfermedad.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtBEnfermedad.PlaceholderText = ""
        Me.TxtBEnfermedad.SelectedText = ""
        Me.TxtBEnfermedad.ShadowDecoration.Parent = Me.TxtBEnfermedad
        Me.TxtBEnfermedad.Size = New System.Drawing.Size(230, 32)
        Me.TxtBEnfermedad.TabIndex = 81
        '
        'PnlDgv
        '
        Me.PnlDgv.Controls.Add(Me.BtnMinimize)
        Me.PnlDgv.Controls.Add(Me.BtnExit)
        Me.PnlDgv.Controls.Add(Me.DgvEnfermedades)
        Me.PnlDgv.FillColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.PnlDgv.Location = New System.Drawing.Point(573, 0)
        Me.PnlDgv.Margin = New System.Windows.Forms.Padding(0)
        Me.PnlDgv.Name = "PnlDgv"
        Me.PnlDgv.ShadowDecoration.Parent = Me.PnlDgv
        Me.PnlDgv.Size = New System.Drawing.Size(1347, 1080)
        Me.PnlDgv.TabIndex = 1
        '
        'BtnMinimize
        '
        Me.BtnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMinimize.Animated = True
        Me.BtnMinimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.BtnMinimize.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.BtnMinimize.HoverState.Parent = Me.BtnMinimize
        Me.BtnMinimize.IconColor = System.Drawing.Color.White
        Me.BtnMinimize.Location = New System.Drawing.Point(1257, 0)
        Me.BtnMinimize.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnMinimize.Name = "BtnMinimize"
        Me.BtnMinimize.ShadowDecoration.Parent = Me.BtnMinimize
        Me.BtnMinimize.Size = New System.Drawing.Size(45, 29)
        Me.BtnMinimize.TabIndex = 28
        '
        'BtnExit
        '
        Me.BtnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnExit.Animated = True
        Me.BtnExit.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.BtnExit.HoverState.Parent = Me.BtnExit
        Me.BtnExit.IconColor = System.Drawing.Color.White
        Me.BtnExit.Location = New System.Drawing.Point(1302, 0)
        Me.BtnExit.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.ShadowDecoration.Parent = Me.BtnExit
        Me.BtnExit.Size = New System.Drawing.Size(45, 29)
        Me.BtnExit.TabIndex = 27
        '
        'DgvEnfermedades
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.DgvEnfermedades.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DgvEnfermedades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvEnfermedades.BackgroundColor = System.Drawing.Color.White
        Me.DgvEnfermedades.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvEnfermedades.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgvEnfermedades.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvEnfermedades.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DgvEnfermedades.ColumnHeadersHeight = 4
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvEnfermedades.DefaultCellStyle = DataGridViewCellStyle6
        Me.DgvEnfermedades.EnableHeadersVisualStyles = False
        Me.DgvEnfermedades.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvEnfermedades.Location = New System.Drawing.Point(21, 121)
        Me.DgvEnfermedades.Name = "DgvEnfermedades"
        Me.DgvEnfermedades.RowHeadersVisible = False
        Me.DgvEnfermedades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvEnfermedades.Size = New System.Drawing.Size(1300, 839)
        Me.DgvEnfermedades.TabIndex = 26
        Me.DgvEnfermedades.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.DgvEnfermedades.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DgvEnfermedades.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DgvEnfermedades.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DgvEnfermedades.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DgvEnfermedades.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DgvEnfermedades.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DgvEnfermedades.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvEnfermedades.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvEnfermedades.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvEnfermedades.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DgvEnfermedades.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DgvEnfermedades.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DgvEnfermedades.ThemeStyle.HeaderStyle.Height = 4
        Me.DgvEnfermedades.ThemeStyle.ReadOnly = False
        Me.DgvEnfermedades.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DgvEnfermedades.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgvEnfermedades.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DgvEnfermedades.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DgvEnfermedades.ThemeStyle.RowsStyle.Height = 22
        Me.DgvEnfermedades.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvEnfermedades.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'F_Enfermedades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1920, 1080)
        Me.Controls.Add(Me.PnlDgv)
        Me.Controls.Add(Me.PnlSide)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "F_Enfermedades"
        Me.Text = "Enfermedades"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PnlSide.ResumeLayout(False)
        Me.PnlSide.PerformLayout()
        Me.PnlDgv.ResumeLayout(False)
        CType(Me.DgvEnfermedades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlSide As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents PnlDgv As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BtnMinimize As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents BtnExit As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents DgvEnfermedades As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents LblImportar As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TxtImportar As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BtnIngresar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TxtIDescripcion As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents LblIDescripcion As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents BtnImportar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents LblIngresar As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents BtnIDelItem As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents BtnIAddItem As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents CmbIMedicacion As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents CmbIUrgencia As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents LblIMedicacion As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents LblIUrgencia As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents LblIEnfermedad As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TxtIEnfermedad As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BtnFiltrar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnVolver As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents LblBusqueda As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents BtnBDelItem As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents BtnBAddItem As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents CmbBMedicacion As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents CmbBUrgencia As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents LblEnfermedades As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents LblBUrgencia As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents LblBEnfermedad As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TxtBEnfermedad As Guna.UI2.WinForms.Guna2TextBox
End Class
