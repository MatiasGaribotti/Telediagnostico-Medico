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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PnlSide = New Guna.UI2.WinForms.Guna2Panel()
        Me.ChkCronica = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.BtnCancelar = New Guna.UI2.WinForms.Guna2Button()
        Me.LblImportar = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TxtImportar = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BtnIngresar = New Guna.UI2.WinForms.Guna2Button()
        Me.TxtIDescripcion = New Guna.UI2.WinForms.Guna2TextBox()
        Me.LblIDescripcion = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.BtnImportar = New Guna.UI2.WinForms.Guna2Button()
        Me.LblIngresar = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.CmbIUrgencia = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.LblIUrgencia = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.LblIEnfermedad = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TxtIEnfermedad = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BtnFiltrar = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnVolver = New Guna.UI2.WinForms.Guna2Button()
        Me.LblBusqueda = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.CmbBUrgencia = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.LblBUrgencia = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.LblBEnfermedad = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TxtBEnfermedad = New Guna.UI2.WinForms.Guna2TextBox()
        Me.PnlDgv = New Guna.UI2.WinForms.Guna2Panel()
        Me.BtnEliminar = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnModificar = New Guna.UI2.WinForms.Guna2Button()
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
        Me.PnlSide.Controls.Add(Me.ChkCronica)
        Me.PnlSide.Controls.Add(Me.BtnCancelar)
        Me.PnlSide.Controls.Add(Me.LblImportar)
        Me.PnlSide.Controls.Add(Me.TxtImportar)
        Me.PnlSide.Controls.Add(Me.BtnIngresar)
        Me.PnlSide.Controls.Add(Me.TxtIDescripcion)
        Me.PnlSide.Controls.Add(Me.LblIDescripcion)
        Me.PnlSide.Controls.Add(Me.BtnImportar)
        Me.PnlSide.Controls.Add(Me.LblIngresar)
        Me.PnlSide.Controls.Add(Me.CmbIUrgencia)
        Me.PnlSide.Controls.Add(Me.LblIUrgencia)
        Me.PnlSide.Controls.Add(Me.LblIEnfermedad)
        Me.PnlSide.Controls.Add(Me.TxtIEnfermedad)
        Me.PnlSide.Controls.Add(Me.BtnFiltrar)
        Me.PnlSide.Controls.Add(Me.BtnVolver)
        Me.PnlSide.Controls.Add(Me.LblBusqueda)
        Me.PnlSide.Controls.Add(Me.CmbBUrgencia)
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
        'ChkCronica
        '
        Me.ChkCronica.Animated = True
        Me.ChkCronica.AutoSize = True
        Me.ChkCronica.BackColor = System.Drawing.Color.Transparent
        Me.ChkCronica.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkCronica.CheckedState.BorderRadius = 0
        Me.ChkCronica.CheckedState.BorderThickness = 0
        Me.ChkCronica.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkCronica.Font = New System.Drawing.Font("Roboto", 16.0!)
        Me.ChkCronica.Location = New System.Drawing.Point(237, 456)
        Me.ChkCronica.Name = "ChkCronica"
        Me.ChkCronica.Size = New System.Drawing.Size(106, 31)
        Me.ChkCronica.TabIndex = 108
        Me.ChkCronica.Text = "Crónica"
        Me.ChkCronica.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.ChkCronica.UncheckedState.BorderRadius = 0
        Me.ChkCronica.UncheckedState.BorderThickness = 0
        Me.ChkCronica.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.ChkCronica.UseVisualStyleBackColor = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Animated = True
        Me.BtnCancelar.AutoRoundedCorners = True
        Me.BtnCancelar.BackColor = System.Drawing.Color.Transparent
        Me.BtnCancelar.BorderRadius = 15
        Me.BtnCancelar.CheckedState.Parent = Me.BtnCancelar
        Me.BtnCancelar.CustomImages.Parent = Me.BtnCancelar
        Me.BtnCancelar.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.BtnCancelar.Font = New System.Drawing.Font("Roboto", 14.0!)
        Me.BtnCancelar.ForeColor = System.Drawing.Color.White
        Me.BtnCancelar.HoverState.Parent = Me.BtnCancelar
        Me.BtnCancelar.ImageSize = New System.Drawing.Size(0, 0)
        Me.BtnCancelar.Location = New System.Drawing.Point(349, 507)
        Me.BtnCancelar.Margin = New System.Windows.Forms.Padding(3, 23, 3, 3)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.ShadowDecoration.Parent = Me.BtnCancelar
        Me.BtnCancelar.Size = New System.Drawing.Size(91, 32)
        Me.BtnCancelar.TabIndex = 107
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseTransparentBackground = True
        '
        'LblImportar
        '
        Me.LblImportar.BackColor = System.Drawing.Color.Transparent
        Me.LblImportar.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblImportar.Location = New System.Drawing.Point(56, 561)
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
        Me.TxtImportar.Location = New System.Drawing.Point(236, 558)
        Me.TxtImportar.Margin = New System.Windows.Forms.Padding(0, 0, 0, 7)
        Me.TxtImportar.Name = "TxtImportar"
        Me.TxtImportar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtImportar.PlaceholderText = ""
        Me.TxtImportar.SelectedText = ""
        Me.TxtImportar.ShadowDecoration.Parent = Me.TxtImportar
        Me.TxtImportar.Size = New System.Drawing.Size(301, 32)
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
        Me.BtnIngresar.Location = New System.Drawing.Point(446, 507)
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
        Me.TxtIDescripcion.Location = New System.Drawing.Point(236, 382)
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
        Me.LblIDescripcion.Location = New System.Drawing.Point(56, 382)
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
        Me.BtnImportar.Location = New System.Drawing.Point(449, 617)
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
        Me.LblIngresar.Location = New System.Drawing.Point(56, 246)
        Me.LblIngresar.Margin = New System.Windows.Forms.Padding(3, 3, 3, 18)
        Me.LblIngresar.Name = "LblIngresar"
        Me.LblIngresar.Size = New System.Drawing.Size(88, 27)
        Me.LblIngresar.TabIndex = 100
        Me.LblIngresar.Text = "Ingresar"
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
        Me.CmbIUrgencia.Location = New System.Drawing.Point(236, 330)
        Me.CmbIUrgencia.Margin = New System.Windows.Forms.Padding(0, 0, 0, 7)
        Me.CmbIUrgencia.Name = "CmbIUrgencia"
        Me.CmbIUrgencia.ShadowDecoration.Parent = Me.CmbIUrgencia
        Me.CmbIUrgencia.Size = New System.Drawing.Size(230, 36)
        Me.CmbIUrgencia.TabIndex = 96
        '
        'LblIUrgencia
        '
        Me.LblIUrgencia.BackColor = System.Drawing.Color.Transparent
        Me.LblIUrgencia.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblIUrgencia.Location = New System.Drawing.Point(56, 335)
        Me.LblIUrgencia.Name = "LblIUrgencia"
        Me.LblIUrgencia.Size = New System.Drawing.Size(86, 27)
        Me.LblIUrgencia.TabIndex = 94
        Me.LblIUrgencia.Text = "Urgencia"
        '
        'LblIEnfermedad
        '
        Me.LblIEnfermedad.BackColor = System.Drawing.Color.Transparent
        Me.LblIEnfermedad.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblIEnfermedad.Location = New System.Drawing.Point(56, 294)
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
        Me.TxtIEnfermedad.Location = New System.Drawing.Point(236, 291)
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
        Me.BtnFiltrar.Location = New System.Drawing.Point(449, 200)
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
        Me.PnlDgv.Controls.Add(Me.BtnEliminar)
        Me.PnlDgv.Controls.Add(Me.BtnModificar)
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
        'BtnEliminar
        '
        Me.BtnEliminar.Animated = True
        Me.BtnEliminar.AutoRoundedCorners = True
        Me.BtnEliminar.BorderRadius = 17
        Me.BtnEliminar.CheckedState.Parent = Me.BtnEliminar
        Me.BtnEliminar.CustomImages.Parent = Me.BtnEliminar
        Me.BtnEliminar.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.BtnEliminar.Font = New System.Drawing.Font("Roboto", 14.25!)
        Me.BtnEliminar.ForeColor = System.Drawing.Color.White
        Me.BtnEliminar.HoverState.Parent = Me.BtnEliminar
        Me.BtnEliminar.Location = New System.Drawing.Point(138, 67)
        Me.BtnEliminar.Margin = New System.Windows.Forms.Padding(3, 3, 15, 15)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.ShadowDecoration.Parent = Me.BtnEliminar
        Me.BtnEliminar.Size = New System.Drawing.Size(103, 36)
        Me.BtnEliminar.TabIndex = 108
        Me.BtnEliminar.Text = "Eliminar"
        '
        'BtnModificar
        '
        Me.BtnModificar.Animated = True
        Me.BtnModificar.AutoRoundedCorners = True
        Me.BtnModificar.BorderRadius = 17
        Me.BtnModificar.CheckedState.Parent = Me.BtnModificar
        Me.BtnModificar.CustomImages.Parent = Me.BtnModificar
        Me.BtnModificar.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.BtnModificar.Font = New System.Drawing.Font("Roboto", 14.25!)
        Me.BtnModificar.ForeColor = System.Drawing.Color.White
        Me.BtnModificar.HoverState.Parent = Me.BtnModificar
        Me.BtnModificar.Location = New System.Drawing.Point(21, 67)
        Me.BtnModificar.Margin = New System.Windows.Forms.Padding(3, 3, 15, 15)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.ShadowDecoration.Parent = Me.BtnModificar
        Me.BtnModificar.Size = New System.Drawing.Size(99, 36)
        Me.BtnModificar.TabIndex = 107
        Me.BtnModificar.Text = "Modificar"
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
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DgvEnfermedades.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvEnfermedades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvEnfermedades.BackgroundColor = System.Drawing.Color.White
        Me.DgvEnfermedades.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvEnfermedades.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgvEnfermedades.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(123, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvEnfermedades.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgvEnfermedades.ColumnHeadersHeight = 25
        Me.DgvEnfermedades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(222, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvEnfermedades.DefaultCellStyle = DataGridViewCellStyle3
        Me.DgvEnfermedades.EnableHeadersVisualStyles = False
        Me.DgvEnfermedades.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvEnfermedades.Location = New System.Drawing.Point(21, 121)
        Me.DgvEnfermedades.Name = "DgvEnfermedades"
        Me.DgvEnfermedades.ReadOnly = True
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
        Me.DgvEnfermedades.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.DgvEnfermedades.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvEnfermedades.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvEnfermedades.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DgvEnfermedades.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgvEnfermedades.ThemeStyle.HeaderStyle.Height = 25
        Me.DgvEnfermedades.ThemeStyle.ReadOnly = True
        Me.DgvEnfermedades.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DgvEnfermedades.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgvEnfermedades.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvEnfermedades.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DgvEnfermedades.ThemeStyle.RowsStyle.Height = 22
        Me.DgvEnfermedades.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(222, Byte), Integer))
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
    Friend WithEvents CmbIUrgencia As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents LblIUrgencia As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents LblIEnfermedad As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TxtIEnfermedad As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BtnFiltrar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnVolver As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents LblBusqueda As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents CmbBUrgencia As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents LblBUrgencia As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents LblBEnfermedad As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TxtBEnfermedad As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BtnEliminar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnModificar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnCancelar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ChkCronica As Guna.UI2.WinForms.Guna2CheckBox
End Class
