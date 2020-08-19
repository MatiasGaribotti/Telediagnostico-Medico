<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_Sintomas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_Sintomas))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btn_minimizar = New System.Windows.Forms.Button()
        Me.btn_cerrar = New System.Windows.Forms.Button()
        Me.PnlSide = New Guna.UI2.WinForms.Guna2Panel()
        Me.TxtBEnfermedad = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtIEnfermedad = New Guna.UI2.WinForms.Guna2TextBox()
        Me.LblImportar = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TxtImportar = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BtnIngresar = New Guna.UI2.WinForms.Guna2Button()
        Me.TxtIDescripcion = New Guna.UI2.WinForms.Guna2TextBox()
        Me.LblIDescripcion = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.BtnImportar = New Guna.UI2.WinForms.Guna2Button()
        Me.LblIngresar = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.BtnIDelItem = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.BtnIAddItem = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.CmbIEnfermedad = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.CmbITipo = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.LblIEnfermedades = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.LblITipo = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.LblISintoma = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TxtISintoma = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BtnFiltrar = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnVolver = New Guna.UI2.WinForms.Guna2Button()
        Me.LblBusqueda = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.BtnBDelItem = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.BtnBAddItem = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.CmbBEnfermedad = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.CmbBTipo = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.LblEnfermedades = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.LblBTipo = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.LblBSintoma = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TxtBSintoma = New Guna.UI2.WinForms.Guna2TextBox()
        Me.PnlDgv = New Guna.UI2.WinForms.Guna2Panel()
        Me.BtnEliminar = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnModificar = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnMinimize = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.BtnExit = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.DgvSintomas = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.PnlSide.SuspendLayout()
        Me.PnlDgv.SuspendLayout()
        CType(Me.DgvSintomas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_minimizar
        '
        Me.btn_minimizar.FlatAppearance.BorderSize = 0
        Me.btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_minimizar.Image = CType(resources.GetObject("btn_minimizar.Image"), System.Drawing.Image)
        Me.btn_minimizar.Location = New System.Drawing.Point(1799, -3)
        Me.btn_minimizar.Name = "btn_minimizar"
        Me.btn_minimizar.Size = New System.Drawing.Size(58, 65)
        Me.btn_minimizar.TabIndex = 20
        Me.btn_minimizar.UseVisualStyleBackColor = True
        '
        'btn_cerrar
        '
        Me.btn_cerrar.FlatAppearance.BorderSize = 0
        Me.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cerrar.Image = CType(resources.GetObject("btn_cerrar.Image"), System.Drawing.Image)
        Me.btn_cerrar.Location = New System.Drawing.Point(1863, 0)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(59, 59)
        Me.btn_cerrar.TabIndex = 21
        Me.btn_cerrar.UseVisualStyleBackColor = True
        '
        'PnlSide
        '
        Me.PnlSide.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.PnlSide.Controls.Add(Me.TxtBEnfermedad)
        Me.PnlSide.Controls.Add(Me.TxtIEnfermedad)
        Me.PnlSide.Controls.Add(Me.LblImportar)
        Me.PnlSide.Controls.Add(Me.TxtImportar)
        Me.PnlSide.Controls.Add(Me.BtnIngresar)
        Me.PnlSide.Controls.Add(Me.TxtIDescripcion)
        Me.PnlSide.Controls.Add(Me.LblIDescripcion)
        Me.PnlSide.Controls.Add(Me.BtnImportar)
        Me.PnlSide.Controls.Add(Me.LblIngresar)
        Me.PnlSide.Controls.Add(Me.BtnIDelItem)
        Me.PnlSide.Controls.Add(Me.BtnIAddItem)
        Me.PnlSide.Controls.Add(Me.CmbIEnfermedad)
        Me.PnlSide.Controls.Add(Me.CmbITipo)
        Me.PnlSide.Controls.Add(Me.LblIEnfermedades)
        Me.PnlSide.Controls.Add(Me.LblITipo)
        Me.PnlSide.Controls.Add(Me.LblISintoma)
        Me.PnlSide.Controls.Add(Me.TxtISintoma)
        Me.PnlSide.Controls.Add(Me.BtnFiltrar)
        Me.PnlSide.Controls.Add(Me.BtnVolver)
        Me.PnlSide.Controls.Add(Me.LblBusqueda)
        Me.PnlSide.Controls.Add(Me.BtnBDelItem)
        Me.PnlSide.Controls.Add(Me.BtnBAddItem)
        Me.PnlSide.Controls.Add(Me.CmbBEnfermedad)
        Me.PnlSide.Controls.Add(Me.CmbBTipo)
        Me.PnlSide.Controls.Add(Me.LblEnfermedades)
        Me.PnlSide.Controls.Add(Me.LblBTipo)
        Me.PnlSide.Controls.Add(Me.LblBSintoma)
        Me.PnlSide.Controls.Add(Me.TxtBSintoma)
        Me.PnlSide.Location = New System.Drawing.Point(0, 0)
        Me.PnlSide.Margin = New System.Windows.Forms.Padding(0)
        Me.PnlSide.Name = "PnlSide"
        Me.PnlSide.ShadowDecoration.Parent = Me.PnlSide
        Me.PnlSide.Size = New System.Drawing.Size(573, 1080)
        Me.PnlSide.TabIndex = 23
        '
        'TxtBEnfermedad
        '
        Me.TxtBEnfermedad.Animated = True
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
        Me.TxtBEnfermedad.Location = New System.Drawing.Point(236, 191)
        Me.TxtBEnfermedad.Margin = New System.Windows.Forms.Padding(0, 0, 0, 7)
        Me.TxtBEnfermedad.Name = "TxtBEnfermedad"
        Me.TxtBEnfermedad.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtBEnfermedad.PlaceholderText = ""
        Me.TxtBEnfermedad.SelectedText = ""
        Me.TxtBEnfermedad.ShadowDecoration.Parent = Me.TxtBEnfermedad
        Me.TxtBEnfermedad.Size = New System.Drawing.Size(230, 32)
        Me.TxtBEnfermedad.TabIndex = 82
        '
        'TxtIEnfermedad
        '
        Me.TxtIEnfermedad.Animated = True
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
        Me.TxtIEnfermedad.Location = New System.Drawing.Point(236, 408)
        Me.TxtIEnfermedad.Margin = New System.Windows.Forms.Padding(0, 0, 0, 7)
        Me.TxtIEnfermedad.Name = "TxtIEnfermedad"
        Me.TxtIEnfermedad.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtIEnfermedad.PlaceholderText = ""
        Me.TxtIEnfermedad.SelectedText = ""
        Me.TxtIEnfermedad.ShadowDecoration.Parent = Me.TxtIEnfermedad
        Me.TxtIEnfermedad.Size = New System.Drawing.Size(230, 32)
        Me.TxtIEnfermedad.TabIndex = 81
        '
        'LblImportar
        '
        Me.LblImportar.BackColor = System.Drawing.Color.Transparent
        Me.LblImportar.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblImportar.Location = New System.Drawing.Point(56, 651)
        Me.LblImportar.Name = "LblImportar"
        Me.LblImportar.Size = New System.Drawing.Size(83, 27)
        Me.LblImportar.TabIndex = 80
        Me.LblImportar.Text = "Importar"
        '
        'TxtImportar
        '
        Me.TxtImportar.Animated = True
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
        Me.TxtImportar.Location = New System.Drawing.Point(155, 648)
        Me.TxtImportar.Margin = New System.Windows.Forms.Padding(0, 0, 0, 7)
        Me.TxtImportar.Name = "TxtImportar"
        Me.TxtImportar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtImportar.PlaceholderText = ""
        Me.TxtImportar.SelectedText = ""
        Me.TxtImportar.ShadowDecoration.Parent = Me.TxtImportar
        Me.TxtImportar.Size = New System.Drawing.Size(382, 32)
        Me.TxtImportar.TabIndex = 79
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
        Me.BtnIngresar.ImageSize = New System.Drawing.Size(0, 0)
        Me.BtnIngresar.Location = New System.Drawing.Point(446, 568)
        Me.BtnIngresar.Margin = New System.Windows.Forms.Padding(3, 23, 3, 3)
        Me.BtnIngresar.Name = "BtnIngresar"
        Me.BtnIngresar.ShadowDecoration.Parent = Me.BtnIngresar
        Me.BtnIngresar.Size = New System.Drawing.Size(91, 32)
        Me.BtnIngresar.TabIndex = 78
        Me.BtnIngresar.Text = "Ingresar"
        Me.BtnIngresar.UseTransparentBackground = True
        '
        'TxtIDescripcion
        '
        Me.TxtIDescripcion.Animated = True
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
        Me.TxtIDescripcion.Location = New System.Drawing.Point(236, 491)
        Me.TxtIDescripcion.Margin = New System.Windows.Forms.Padding(0, 0, 0, 7)
        Me.TxtIDescripcion.Multiline = True
        Me.TxtIDescripcion.Name = "TxtIDescripcion"
        Me.TxtIDescripcion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtIDescripcion.PlaceholderText = ""
        Me.TxtIDescripcion.SelectedText = ""
        Me.TxtIDescripcion.ShadowDecoration.Parent = Me.TxtIDescripcion
        Me.TxtIDescripcion.Size = New System.Drawing.Size(301, 64)
        Me.TxtIDescripcion.TabIndex = 77
        '
        'LblIDescripcion
        '
        Me.LblIDescripcion.BackColor = System.Drawing.Color.Transparent
        Me.LblIDescripcion.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblIDescripcion.Location = New System.Drawing.Point(56, 491)
        Me.LblIDescripcion.Name = "LblIDescripcion"
        Me.LblIDescripcion.Size = New System.Drawing.Size(114, 27)
        Me.LblIDescripcion.TabIndex = 76
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
        Me.BtnImportar.Location = New System.Drawing.Point(449, 710)
        Me.BtnImportar.Margin = New System.Windows.Forms.Padding(3, 23, 3, 3)
        Me.BtnImportar.Name = "BtnImportar"
        Me.BtnImportar.ShadowDecoration.Parent = Me.BtnImportar
        Me.BtnImportar.Size = New System.Drawing.Size(91, 32)
        Me.BtnImportar.TabIndex = 75
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
        Me.LblIngresar.TabIndex = 74
        Me.LblIngresar.Text = "Ingresar"
        '
        'BtnIDelItem
        '
        Me.BtnIDelItem.CheckedState.Parent = Me.BtnIDelItem
        Me.BtnIDelItem.CustomImages.Parent = Me.BtnIDelItem
        Me.BtnIDelItem.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.BtnIDelItem.Font = New System.Drawing.Font("Roboto", 16.0!)
        Me.BtnIDelItem.ForeColor = System.Drawing.Color.White
        Me.BtnIDelItem.HoverState.Parent = Me.BtnIDelItem
        Me.BtnIDelItem.Location = New System.Drawing.Point(476, 453)
        Me.BtnIDelItem.Name = "BtnIDelItem"
        Me.BtnIDelItem.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.BtnIDelItem.ShadowDecoration.Parent = Me.BtnIDelItem
        Me.BtnIDelItem.Size = New System.Drawing.Size(24, 24)
        Me.BtnIDelItem.TabIndex = 73
        Me.BtnIDelItem.Text = "-"
        '
        'BtnIAddItem
        '
        Me.BtnIAddItem.CheckedState.Parent = Me.BtnIAddItem
        Me.BtnIAddItem.CustomImages.Parent = Me.BtnIAddItem
        Me.BtnIAddItem.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.BtnIAddItem.Font = New System.Drawing.Font("Roboto", 16.0!)
        Me.BtnIAddItem.ForeColor = System.Drawing.Color.White
        Me.BtnIAddItem.HoverState.Parent = Me.BtnIAddItem
        Me.BtnIAddItem.Location = New System.Drawing.Point(476, 411)
        Me.BtnIAddItem.Name = "BtnIAddItem"
        Me.BtnIAddItem.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.BtnIAddItem.ShadowDecoration.Parent = Me.BtnIAddItem
        Me.BtnIAddItem.Size = New System.Drawing.Size(24, 24)
        Me.BtnIAddItem.TabIndex = 72
        Me.BtnIAddItem.Text = "+"
        '
        'CmbIEnfermedad
        '
        Me.CmbIEnfermedad.Animated = True
        Me.CmbIEnfermedad.AutoCompleteCustomSource.AddRange(New String() {"Hola", "Chau"})
        Me.CmbIEnfermedad.BackColor = System.Drawing.Color.Transparent
        Me.CmbIEnfermedad.BorderRadius = 6
        Me.CmbIEnfermedad.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CmbIEnfermedad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbIEnfermedad.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmbIEnfermedad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmbIEnfermedad.FocusedState.Parent = Me.CmbIEnfermedad
        Me.CmbIEnfermedad.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CmbIEnfermedad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CmbIEnfermedad.HoverState.Parent = Me.CmbIEnfermedad
        Me.CmbIEnfermedad.ItemHeight = 30
        Me.CmbIEnfermedad.ItemsAppearance.Parent = Me.CmbIEnfermedad
        Me.CmbIEnfermedad.Location = New System.Drawing.Point(236, 447)
        Me.CmbIEnfermedad.Margin = New System.Windows.Forms.Padding(0, 0, 0, 7)
        Me.CmbIEnfermedad.Name = "CmbIEnfermedad"
        Me.CmbIEnfermedad.ShadowDecoration.Parent = Me.CmbIEnfermedad
        Me.CmbIEnfermedad.Size = New System.Drawing.Size(230, 36)
        Me.CmbIEnfermedad.TabIndex = 71
        '
        'CmbITipo
        '
        Me.CmbITipo.Animated = True
        Me.CmbITipo.BackColor = System.Drawing.Color.Transparent
        Me.CmbITipo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CmbITipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbITipo.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmbITipo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmbITipo.FocusedState.Parent = Me.CmbITipo
        Me.CmbITipo.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CmbITipo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CmbITipo.HoverState.Parent = Me.CmbITipo
        Me.CmbITipo.ItemHeight = 30
        Me.CmbITipo.ItemsAppearance.Parent = Me.CmbITipo
        Me.CmbITipo.Location = New System.Drawing.Point(236, 365)
        Me.CmbITipo.Margin = New System.Windows.Forms.Padding(0, 0, 0, 7)
        Me.CmbITipo.Name = "CmbITipo"
        Me.CmbITipo.ShadowDecoration.Parent = Me.CmbITipo
        Me.CmbITipo.Size = New System.Drawing.Size(230, 36)
        Me.CmbITipo.TabIndex = 70
        '
        'LblIEnfermedades
        '
        Me.LblIEnfermedades.BackColor = System.Drawing.Color.Transparent
        Me.LblIEnfermedades.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblIEnfermedades.Location = New System.Drawing.Point(56, 410)
        Me.LblIEnfermedades.Name = "LblIEnfermedades"
        Me.LblIEnfermedades.Size = New System.Drawing.Size(138, 27)
        Me.LblIEnfermedades.TabIndex = 69
        Me.LblIEnfermedades.Text = "Enfermedades"
        '
        'LblITipo
        '
        Me.LblITipo.BackColor = System.Drawing.Color.Transparent
        Me.LblITipo.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblITipo.Location = New System.Drawing.Point(56, 370)
        Me.LblITipo.Name = "LblITipo"
        Me.LblITipo.Size = New System.Drawing.Size(45, 27)
        Me.LblITipo.TabIndex = 68
        Me.LblITipo.Text = "Tipo"
        '
        'LblISintoma
        '
        Me.LblISintoma.BackColor = System.Drawing.Color.Transparent
        Me.LblISintoma.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblISintoma.Location = New System.Drawing.Point(56, 329)
        Me.LblISintoma.Name = "LblISintoma"
        Me.LblISintoma.Size = New System.Drawing.Size(80, 27)
        Me.LblISintoma.TabIndex = 67
        Me.LblISintoma.Text = "Síntoma"
        '
        'TxtISintoma
        '
        Me.TxtISintoma.Animated = True
        Me.TxtISintoma.BorderRadius = 6
        Me.TxtISintoma.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtISintoma.DefaultText = ""
        Me.TxtISintoma.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtISintoma.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtISintoma.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtISintoma.DisabledState.Parent = Me.TxtISintoma
        Me.TxtISintoma.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtISintoma.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtISintoma.FocusedState.Parent = Me.TxtISintoma
        Me.TxtISintoma.Font = New System.Drawing.Font("Roboto", 16.0!)
        Me.TxtISintoma.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtISintoma.HoverState.Parent = Me.TxtISintoma
        Me.TxtISintoma.Location = New System.Drawing.Point(236, 326)
        Me.TxtISintoma.Margin = New System.Windows.Forms.Padding(0, 0, 0, 7)
        Me.TxtISintoma.Name = "TxtISintoma"
        Me.TxtISintoma.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtISintoma.PlaceholderText = ""
        Me.TxtISintoma.SelectedText = ""
        Me.TxtISintoma.ShadowDecoration.Parent = Me.TxtISintoma
        Me.TxtISintoma.Size = New System.Drawing.Size(230, 32)
        Me.TxtISintoma.TabIndex = 66
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
        Me.BtnFiltrar.Location = New System.Drawing.Point(449, 276)
        Me.BtnFiltrar.Margin = New System.Windows.Forms.Padding(3, 23, 3, 3)
        Me.BtnFiltrar.Name = "BtnFiltrar"
        Me.BtnFiltrar.ShadowDecoration.Parent = Me.BtnFiltrar
        Me.BtnFiltrar.Size = New System.Drawing.Size(81, 32)
        Me.BtnFiltrar.TabIndex = 65
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
        Me.BtnVolver.TabIndex = 64
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
        Me.LblBusqueda.TabIndex = 63
        Me.LblBusqueda.Text = "Búsqueda"
        '
        'BtnBDelItem
        '
        Me.BtnBDelItem.CheckedState.Parent = Me.BtnBDelItem
        Me.BtnBDelItem.CustomImages.Parent = Me.BtnBDelItem
        Me.BtnBDelItem.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.BtnBDelItem.Font = New System.Drawing.Font("Roboto", 16.0!)
        Me.BtnBDelItem.ForeColor = System.Drawing.Color.White
        Me.BtnBDelItem.HoverState.Parent = Me.BtnBDelItem
        Me.BtnBDelItem.Location = New System.Drawing.Point(476, 236)
        Me.BtnBDelItem.Margin = New System.Windows.Forms.Padding(0, 0, 0, 7)
        Me.BtnBDelItem.Name = "BtnBDelItem"
        Me.BtnBDelItem.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.BtnBDelItem.ShadowDecoration.Parent = Me.BtnBDelItem
        Me.BtnBDelItem.Size = New System.Drawing.Size(24, 24)
        Me.BtnBDelItem.TabIndex = 62
        Me.BtnBDelItem.Text = "-"
        '
        'BtnBAddItem
        '
        Me.BtnBAddItem.CheckedState.Parent = Me.BtnBAddItem
        Me.BtnBAddItem.CustomImages.Parent = Me.BtnBAddItem
        Me.BtnBAddItem.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.BtnBAddItem.Font = New System.Drawing.Font("Roboto", 16.0!)
        Me.BtnBAddItem.ForeColor = System.Drawing.Color.White
        Me.BtnBAddItem.HoverState.Parent = Me.BtnBAddItem
        Me.BtnBAddItem.Location = New System.Drawing.Point(476, 195)
        Me.BtnBAddItem.Margin = New System.Windows.Forms.Padding(0, 0, 0, 7)
        Me.BtnBAddItem.Name = "BtnBAddItem"
        Me.BtnBAddItem.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.BtnBAddItem.ShadowDecoration.Parent = Me.BtnBAddItem
        Me.BtnBAddItem.Size = New System.Drawing.Size(24, 24)
        Me.BtnBAddItem.TabIndex = 61
        Me.BtnBAddItem.Text = "+"
        '
        'CmbBEnfermedad
        '
        Me.CmbBEnfermedad.Animated = True
        Me.CmbBEnfermedad.BackColor = System.Drawing.Color.Transparent
        Me.CmbBEnfermedad.BorderRadius = 6
        Me.CmbBEnfermedad.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CmbBEnfermedad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbBEnfermedad.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmbBEnfermedad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmbBEnfermedad.FocusedState.Parent = Me.CmbBEnfermedad
        Me.CmbBEnfermedad.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CmbBEnfermedad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CmbBEnfermedad.HoverState.Parent = Me.CmbBEnfermedad
        Me.CmbBEnfermedad.ItemHeight = 30
        Me.CmbBEnfermedad.ItemsAppearance.Parent = Me.CmbBEnfermedad
        Me.CmbBEnfermedad.Location = New System.Drawing.Point(236, 230)
        Me.CmbBEnfermedad.Margin = New System.Windows.Forms.Padding(0, 0, 0, 7)
        Me.CmbBEnfermedad.Name = "CmbBEnfermedad"
        Me.CmbBEnfermedad.ShadowDecoration.Parent = Me.CmbBEnfermedad
        Me.CmbBEnfermedad.Size = New System.Drawing.Size(230, 36)
        Me.CmbBEnfermedad.TabIndex = 60
        '
        'CmbBTipo
        '
        Me.CmbBTipo.Animated = True
        Me.CmbBTipo.BackColor = System.Drawing.Color.Transparent
        Me.CmbBTipo.BorderRadius = 6
        Me.CmbBTipo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CmbBTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbBTipo.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmbBTipo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmbBTipo.FocusedState.Parent = Me.CmbBTipo
        Me.CmbBTipo.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CmbBTipo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CmbBTipo.HoverState.Parent = Me.CmbBTipo
        Me.CmbBTipo.ItemHeight = 30
        Me.CmbBTipo.ItemsAppearance.Parent = Me.CmbBTipo
        Me.CmbBTipo.Location = New System.Drawing.Point(236, 148)
        Me.CmbBTipo.Margin = New System.Windows.Forms.Padding(0, 0, 0, 7)
        Me.CmbBTipo.Name = "CmbBTipo"
        Me.CmbBTipo.ShadowDecoration.Parent = Me.CmbBTipo
        Me.CmbBTipo.Size = New System.Drawing.Size(230, 36)
        Me.CmbBTipo.TabIndex = 59
        '
        'LblEnfermedades
        '
        Me.LblEnfermedades.BackColor = System.Drawing.Color.Transparent
        Me.LblEnfermedades.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEnfermedades.Location = New System.Drawing.Point(56, 196)
        Me.LblEnfermedades.Margin = New System.Windows.Forms.Padding(0, 0, 0, 7)
        Me.LblEnfermedades.Name = "LblEnfermedades"
        Me.LblEnfermedades.Size = New System.Drawing.Size(138, 27)
        Me.LblEnfermedades.TabIndex = 58
        Me.LblEnfermedades.Text = "Enfermedades"
        '
        'LblBTipo
        '
        Me.LblBTipo.BackColor = System.Drawing.Color.Transparent
        Me.LblBTipo.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBTipo.Location = New System.Drawing.Point(56, 153)
        Me.LblBTipo.Margin = New System.Windows.Forms.Padding(0, 0, 0, 7)
        Me.LblBTipo.Name = "LblBTipo"
        Me.LblBTipo.Size = New System.Drawing.Size(45, 27)
        Me.LblBTipo.TabIndex = 57
        Me.LblBTipo.Text = "Tipo"
        '
        'LblBSintoma
        '
        Me.LblBSintoma.BackColor = System.Drawing.Color.Transparent
        Me.LblBSintoma.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBSintoma.Location = New System.Drawing.Point(56, 112)
        Me.LblBSintoma.Margin = New System.Windows.Forms.Padding(0, 0, 0, 7)
        Me.LblBSintoma.Name = "LblBSintoma"
        Me.LblBSintoma.Size = New System.Drawing.Size(80, 27)
        Me.LblBSintoma.TabIndex = 56
        Me.LblBSintoma.Text = "Síntoma"
        '
        'TxtBSintoma
        '
        Me.TxtBSintoma.Animated = True
        Me.TxtBSintoma.BorderRadius = 6
        Me.TxtBSintoma.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtBSintoma.DefaultText = ""
        Me.TxtBSintoma.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtBSintoma.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtBSintoma.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtBSintoma.DisabledState.Parent = Me.TxtBSintoma
        Me.TxtBSintoma.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtBSintoma.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtBSintoma.FocusedState.Parent = Me.TxtBSintoma
        Me.TxtBSintoma.Font = New System.Drawing.Font("Roboto", 16.0!)
        Me.TxtBSintoma.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtBSintoma.HoverState.Parent = Me.TxtBSintoma
        Me.TxtBSintoma.Location = New System.Drawing.Point(236, 109)
        Me.TxtBSintoma.Margin = New System.Windows.Forms.Padding(0, 0, 0, 7)
        Me.TxtBSintoma.Name = "TxtBSintoma"
        Me.TxtBSintoma.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtBSintoma.PlaceholderText = ""
        Me.TxtBSintoma.SelectedText = ""
        Me.TxtBSintoma.ShadowDecoration.Parent = Me.TxtBSintoma
        Me.TxtBSintoma.Size = New System.Drawing.Size(230, 32)
        Me.TxtBSintoma.TabIndex = 55
        '
        'PnlDgv
        '
        Me.PnlDgv.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.PnlDgv.Controls.Add(Me.BtnEliminar)
        Me.PnlDgv.Controls.Add(Me.BtnModificar)
        Me.PnlDgv.Controls.Add(Me.BtnMinimize)
        Me.PnlDgv.Controls.Add(Me.BtnExit)
        Me.PnlDgv.Controls.Add(Me.DgvSintomas)
        Me.PnlDgv.Location = New System.Drawing.Point(573, 0)
        Me.PnlDgv.Name = "PnlDgv"
        Me.PnlDgv.ShadowDecoration.Parent = Me.PnlDgv
        Me.PnlDgv.Size = New System.Drawing.Size(1347, 1080)
        Me.PnlDgv.TabIndex = 24
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Animated = True
        Me.BtnEliminar.AutoRoundedCorners = True
        Me.BtnEliminar.BorderRadius = 17
        Me.BtnEliminar.CheckedState.Parent = Me.BtnEliminar
        Me.BtnEliminar.CustomImages.Parent = Me.BtnEliminar
        Me.BtnEliminar.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.BtnEliminar.Font = New System.Drawing.Font("Roboto", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.ForeColor = System.Drawing.Color.White
        Me.BtnEliminar.HoverState.Parent = Me.BtnEliminar
        Me.BtnEliminar.Location = New System.Drawing.Point(180, 58)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.ShadowDecoration.Parent = Me.BtnEliminar
        Me.BtnEliminar.Size = New System.Drawing.Size(137, 36)
        Me.BtnEliminar.TabIndex = 68
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
        Me.BtnModificar.Font = New System.Drawing.Font("Roboto", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModificar.ForeColor = System.Drawing.Color.White
        Me.BtnModificar.HoverState.Parent = Me.BtnModificar
        Me.BtnModificar.Location = New System.Drawing.Point(23, 58)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.ShadowDecoration.Parent = Me.BtnModificar
        Me.BtnModificar.Size = New System.Drawing.Size(137, 36)
        Me.BtnModificar.TabIndex = 67
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
        Me.BtnMinimize.Location = New System.Drawing.Point(1259, 0)
        Me.BtnMinimize.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnMinimize.Name = "BtnMinimize"
        Me.BtnMinimize.ShadowDecoration.Parent = Me.BtnMinimize
        Me.BtnMinimize.Size = New System.Drawing.Size(45, 29)
        Me.BtnMinimize.TabIndex = 25
        '
        'BtnExit
        '
        Me.BtnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnExit.Animated = True
        Me.BtnExit.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.BtnExit.HoverState.Parent = Me.BtnExit
        Me.BtnExit.IconColor = System.Drawing.Color.White
        Me.BtnExit.Location = New System.Drawing.Point(1304, 0)
        Me.BtnExit.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.ShadowDecoration.Parent = Me.BtnExit
        Me.BtnExit.Size = New System.Drawing.Size(45, 29)
        Me.BtnExit.TabIndex = 24
        '
        'DgvSintomas
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DgvSintomas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvSintomas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvSintomas.BackgroundColor = System.Drawing.Color.White
        Me.DgvSintomas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvSintomas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgvSintomas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(123, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvSintomas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgvSintomas.ColumnHeadersHeight = 40
        Me.DgvSintomas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvSintomas.DefaultCellStyle = DataGridViewCellStyle3
        Me.DgvSintomas.EnableHeadersVisualStyles = False
        Me.DgvSintomas.GridColor = System.Drawing.Color.Gray
        Me.DgvSintomas.Location = New System.Drawing.Point(23, 121)
        Me.DgvSintomas.Name = "DgvSintomas"
        Me.DgvSintomas.ReadOnly = True
        Me.DgvSintomas.RowHeadersVisible = False
        Me.DgvSintomas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvSintomas.Size = New System.Drawing.Size(1300, 839)
        Me.DgvSintomas.TabIndex = 23
        Me.DgvSintomas.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.DgvSintomas.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DgvSintomas.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DgvSintomas.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DgvSintomas.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DgvSintomas.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DgvSintomas.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DgvSintomas.ThemeStyle.GridColor = System.Drawing.Color.Gray
        Me.DgvSintomas.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.DgvSintomas.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvSintomas.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DgvSintomas.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DgvSintomas.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgvSintomas.ThemeStyle.HeaderStyle.Height = 40
        Me.DgvSintomas.ThemeStyle.ReadOnly = True
        Me.DgvSintomas.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DgvSintomas.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgvSintomas.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DgvSintomas.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DgvSintomas.ThemeStyle.RowsStyle.Height = 22
        Me.DgvSintomas.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvSintomas.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'F_Sintomas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1920, 1080)
        Me.Controls.Add(Me.PnlDgv)
        Me.Controls.Add(Me.PnlSide)
        Me.Controls.Add(Me.btn_minimizar)
        Me.Controls.Add(Me.btn_cerrar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "F_Sintomas"
        Me.Text = "frm_SintomasIngresarFiltrar"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PnlSide.ResumeLayout(False)
        Me.PnlSide.PerformLayout()
        Me.PnlDgv.ResumeLayout(False)
        CType(Me.DgvSintomas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_minimizar As Button
    Friend WithEvents btn_cerrar As Button
    Friend WithEvents PnlSide As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents LblImportar As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TxtImportar As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BtnIngresar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TxtIDescripcion As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents LblIDescripcion As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents BtnImportar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents LblIngresar As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents BtnIDelItem As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents BtnIAddItem As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents CmbIEnfermedad As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents CmbITipo As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents LblIEnfermedades As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents LblITipo As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents LblISintoma As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TxtISintoma As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BtnFiltrar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnVolver As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents LblBusqueda As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents BtnBDelItem As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents BtnBAddItem As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents CmbBEnfermedad As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents CmbBTipo As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents LblEnfermedades As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents LblBTipo As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents LblBSintoma As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TxtBSintoma As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents PnlDgv As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents DgvSintomas As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents BtnMinimize As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents BtnExit As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents TxtBEnfermedad As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtIEnfermedad As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BtnModificar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnEliminar As Guna.UI2.WinForms.Guna2Button
End Class
