<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F_Sintomas
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_Sintomas))
        Me.PnlRight = New Guna.UI2.WinForms.Guna2Panel()
        Me.LblTodo = New System.Windows.Forms.Label()
        Me.BtnFullBody = New Guna.UI2.WinForms.Guna2Button()
        Me.LblExtremidades = New System.Windows.Forms.Label()
        Me.LblTorso = New System.Windows.Forms.Label()
        Me.LblCabeza = New System.Windows.Forms.Label()
        Me.BtnExtremidades = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnTorso = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnCabeza = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnCross = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.BtnSearch = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.TxtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.DgvAllSintomas = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.BtnHCE = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnCancelar = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnAceptar = New Guna.UI2.WinForms.Guna2Button()
        Me.DgvSelectedSintomas = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbl_SintomasIng = New System.Windows.Forms.Label()
        Me.PnlLeft = New Guna.UI2.WinForms.Guna2Panel()
        Me.PnlRight.SuspendLayout()
        CType(Me.DgvAllSintomas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvSelectedSintomas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlLeft.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlRight
        '
        Me.PnlRight.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.PnlRight.Controls.Add(Me.LblTodo)
        Me.PnlRight.Controls.Add(Me.BtnFullBody)
        Me.PnlRight.Controls.Add(Me.LblExtremidades)
        Me.PnlRight.Controls.Add(Me.LblTorso)
        Me.PnlRight.Controls.Add(Me.LblCabeza)
        Me.PnlRight.Controls.Add(Me.BtnExtremidades)
        Me.PnlRight.Controls.Add(Me.BtnTorso)
        Me.PnlRight.Controls.Add(Me.BtnCabeza)
        Me.PnlRight.Controls.Add(Me.BtnCross)
        Me.PnlRight.Controls.Add(Me.BtnSearch)
        Me.PnlRight.Controls.Add(Me.TxtSearch)
        Me.PnlRight.Controls.Add(Me.DgvAllSintomas)
        Me.PnlRight.Location = New System.Drawing.Point(960, 0)
        Me.PnlRight.Margin = New System.Windows.Forms.Padding(0)
        Me.PnlRight.Name = "PnlRight"
        Me.PnlRight.ShadowDecoration.Parent = Me.PnlRight
        Me.PnlRight.Size = New System.Drawing.Size(961, 1080)
        Me.PnlRight.TabIndex = 5
        '
        'LblTodo
        '
        Me.LblTodo.AutoSize = True
        Me.LblTodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.LblTodo.Location = New System.Drawing.Point(242, 189)
        Me.LblTodo.Name = "LblTodo"
        Me.LblTodo.Size = New System.Drawing.Size(47, 24)
        Me.LblTodo.TabIndex = 116
        Me.LblTodo.Text = "todo"
        Me.LblTodo.Visible = False
        '
        'BtnFullBody
        '
        Me.BtnFullBody.Animated = True
        Me.BtnFullBody.BorderRadius = 20
        Me.BtnFullBody.CheckedState.BorderColor = System.Drawing.Color.Black
        Me.BtnFullBody.CheckedState.CustomBorderColor = System.Drawing.Color.Black
        Me.BtnFullBody.CheckedState.FillColor = System.Drawing.Color.White
        Me.BtnFullBody.CheckedState.Parent = Me.BtnFullBody
        Me.BtnFullBody.CustomImages.Parent = Me.BtnFullBody
        Me.BtnFullBody.FillColor = System.Drawing.Color.White
        Me.BtnFullBody.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnFullBody.ForeColor = System.Drawing.Color.White
        Me.BtnFullBody.HoverState.Parent = Me.BtnFullBody
        Me.BtnFullBody.Image = Global.Presentacion.My.Resources.Resources.full_body_100
        Me.BtnFullBody.ImageSize = New System.Drawing.Size(100, 100)
        Me.BtnFullBody.Location = New System.Drawing.Point(209, 55)
        Me.BtnFullBody.Name = "BtnFullBody"
        Me.BtnFullBody.ShadowDecoration.Parent = Me.BtnFullBody
        Me.BtnFullBody.Size = New System.Drawing.Size(120, 120)
        Me.BtnFullBody.TabIndex = 115
        '
        'LblExtremidades
        '
        Me.LblExtremidades.AutoSize = True
        Me.LblExtremidades.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.LblExtremidades.Location = New System.Drawing.Point(626, 189)
        Me.LblExtremidades.Name = "LblExtremidades"
        Me.LblExtremidades.Size = New System.Drawing.Size(124, 24)
        Me.LblExtremidades.TabIndex = 114
        Me.LblExtremidades.Text = "extremidades"
        Me.LblExtremidades.Visible = False
        '
        'LblTorso
        '
        Me.LblTorso.AutoSize = True
        Me.LblTorso.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.LblTorso.Location = New System.Drawing.Point(521, 189)
        Me.LblTorso.Name = "LblTorso"
        Me.LblTorso.Size = New System.Drawing.Size(51, 24)
        Me.LblTorso.TabIndex = 113
        Me.LblTorso.Text = "torso"
        Me.LblTorso.Visible = False
        '
        'LblCabeza
        '
        Me.LblCabeza.AutoSize = True
        Me.LblCabeza.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.LblCabeza.Location = New System.Drawing.Point(377, 189)
        Me.LblCabeza.Name = "LblCabeza"
        Me.LblCabeza.Size = New System.Drawing.Size(71, 24)
        Me.LblCabeza.TabIndex = 112
        Me.LblCabeza.Text = "cabeza"
        Me.LblCabeza.Visible = False
        '
        'BtnExtremidades
        '
        Me.BtnExtremidades.Animated = True
        Me.BtnExtremidades.BorderRadius = 20
        Me.BtnExtremidades.CheckedState.BorderColor = System.Drawing.Color.Black
        Me.BtnExtremidades.CheckedState.CustomBorderColor = System.Drawing.Color.Black
        Me.BtnExtremidades.CheckedState.FillColor = System.Drawing.Color.White
        Me.BtnExtremidades.CheckedState.Parent = Me.BtnExtremidades
        Me.BtnExtremidades.CustomImages.Parent = Me.BtnExtremidades
        Me.BtnExtremidades.FillColor = System.Drawing.Color.White
        Me.BtnExtremidades.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnExtremidades.ForeColor = System.Drawing.Color.White
        Me.BtnExtremidades.HoverState.Parent = Me.BtnExtremidades
        Me.BtnExtremidades.Image = Global.Presentacion.My.Resources.Resources.arms_legs_100
        Me.BtnExtremidades.ImageSize = New System.Drawing.Size(100, 100)
        Me.BtnExtremidades.Location = New System.Drawing.Point(630, 55)
        Me.BtnExtremidades.Name = "BtnExtremidades"
        Me.BtnExtremidades.ShadowDecoration.Parent = Me.BtnExtremidades
        Me.BtnExtremidades.Size = New System.Drawing.Size(120, 120)
        Me.BtnExtremidades.TabIndex = 111
        '
        'BtnTorso
        '
        Me.BtnTorso.Animated = True
        Me.BtnTorso.BorderRadius = 20
        Me.BtnTorso.CheckedState.BorderColor = System.Drawing.Color.Black
        Me.BtnTorso.CheckedState.CustomBorderColor = System.Drawing.Color.Black
        Me.BtnTorso.CheckedState.FillColor = System.Drawing.Color.White
        Me.BtnTorso.CheckedState.Parent = Me.BtnTorso
        Me.BtnTorso.CustomImages.Parent = Me.BtnTorso
        Me.BtnTorso.FillColor = System.Drawing.Color.White
        Me.BtnTorso.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnTorso.ForeColor = System.Drawing.Color.White
        Me.BtnTorso.HoverState.Parent = Me.BtnTorso
        Me.BtnTorso.Image = Global.Presentacion.My.Resources.Resources.chest_100px
        Me.BtnTorso.ImageSize = New System.Drawing.Size(100, 100)
        Me.BtnTorso.Location = New System.Drawing.Point(489, 55)
        Me.BtnTorso.Name = "BtnTorso"
        Me.BtnTorso.ShadowDecoration.Parent = Me.BtnTorso
        Me.BtnTorso.Size = New System.Drawing.Size(120, 120)
        Me.BtnTorso.TabIndex = 110
        '
        'BtnCabeza
        '
        Me.BtnCabeza.Animated = True
        Me.BtnCabeza.BorderRadius = 20
        Me.BtnCabeza.CheckedState.BorderColor = System.Drawing.Color.Black
        Me.BtnCabeza.CheckedState.CustomBorderColor = System.Drawing.Color.Black
        Me.BtnCabeza.CheckedState.FillColor = System.Drawing.Color.White
        Me.BtnCabeza.CheckedState.Parent = Me.BtnCabeza
        Me.BtnCabeza.CustomImages.Parent = Me.BtnCabeza
        Me.BtnCabeza.FillColor = System.Drawing.Color.White
        Me.BtnCabeza.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnCabeza.ForeColor = System.Drawing.Color.White
        Me.BtnCabeza.HoverState.Parent = Me.BtnCabeza
        Me.BtnCabeza.Image = Global.Presentacion.My.Resources.Resources.head_100px
        Me.BtnCabeza.ImageSize = New System.Drawing.Size(100, 100)
        Me.BtnCabeza.Location = New System.Drawing.Point(351, 55)
        Me.BtnCabeza.Name = "BtnCabeza"
        Me.BtnCabeza.ShadowDecoration.Parent = Me.BtnCabeza
        Me.BtnCabeza.Size = New System.Drawing.Size(120, 120)
        Me.BtnCabeza.TabIndex = 109
        '
        'BtnCross
        '
        Me.BtnCross.Animated = True
        Me.BtnCross.CheckedState.Parent = Me.BtnCross
        Me.BtnCross.CustomImages.Parent = Me.BtnCross
        Me.BtnCross.FillColor = System.Drawing.Color.White
        Me.BtnCross.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnCross.ForeColor = System.Drawing.Color.White
        Me.BtnCross.HoverState.Parent = Me.BtnCross
        Me.BtnCross.Image = Global.Presentacion.My.Resources.Resources.BtnCross
        Me.BtnCross.ImageSize = New System.Drawing.Size(46, 46)
        Me.BtnCross.Location = New System.Drawing.Point(143, 242)
        Me.BtnCross.Name = "BtnCross"
        Me.BtnCross.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.BtnCross.ShadowDecoration.Parent = Me.BtnCross
        Me.BtnCross.Size = New System.Drawing.Size(70, 70)
        Me.BtnCross.TabIndex = 108
        '
        'BtnSearch
        '
        Me.BtnSearch.Animated = True
        Me.BtnSearch.CheckedState.Parent = Me.BtnSearch
        Me.BtnSearch.CustomImages.Parent = Me.BtnSearch
        Me.BtnSearch.FillColor = System.Drawing.Color.White
        Me.BtnSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnSearch.ForeColor = System.Drawing.Color.White
        Me.BtnSearch.HoverState.Parent = Me.BtnSearch
        Me.BtnSearch.Image = Global.Presentacion.My.Resources.Resources.BtnSearch
        Me.BtnSearch.ImageSize = New System.Drawing.Size(46, 46)
        Me.BtnSearch.Location = New System.Drawing.Point(745, 242)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.BtnSearch.ShadowDecoration.Parent = Me.BtnSearch
        Me.BtnSearch.Size = New System.Drawing.Size(70, 70)
        Me.BtnSearch.TabIndex = 107
        '
        'TxtSearch
        '
        Me.TxtSearch.AutoRoundedCorners = True
        Me.TxtSearch.BorderRadius = 34
        Me.TxtSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtSearch.DefaultText = ""
        Me.TxtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtSearch.DisabledState.Parent = Me.TxtSearch
        Me.TxtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtSearch.FocusedState.Parent = Me.TxtSearch
        Me.TxtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtSearch.HoverState.Parent = Me.TxtSearch
        Me.TxtSearch.Location = New System.Drawing.Point(219, 242)
        Me.TxtSearch.Margin = New System.Windows.Forms.Padding(9)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtSearch.PlaceholderText = ""
        Me.TxtSearch.SelectedText = ""
        Me.TxtSearch.ShadowDecoration.Parent = Me.TxtSearch
        Me.TxtSearch.Size = New System.Drawing.Size(520, 70)
        Me.TxtSearch.TabIndex = 106
        '
        'DgvAllSintomas
        '
        Me.DgvAllSintomas.AllowUserToAddRows = False
        Me.DgvAllSintomas.AllowUserToDeleteRows = False
        Me.DgvAllSintomas.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DgvAllSintomas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvAllSintomas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvAllSintomas.BackgroundColor = System.Drawing.Color.White
        Me.DgvAllSintomas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvAllSintomas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgvAllSintomas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(123, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvAllSintomas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgvAllSintomas.ColumnHeadersHeight = 40
        Me.DgvAllSintomas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgvAllSintomas.ColumnHeadersVisible = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(222, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvAllSintomas.DefaultCellStyle = DataGridViewCellStyle3
        Me.DgvAllSintomas.EnableHeadersVisualStyles = False
        Me.DgvAllSintomas.GridColor = System.Drawing.Color.Gray
        Me.DgvAllSintomas.Location = New System.Drawing.Point(57, 335)
        Me.DgvAllSintomas.Margin = New System.Windows.Forms.Padding(20)
        Me.DgvAllSintomas.MultiSelect = False
        Me.DgvAllSintomas.Name = "DgvAllSintomas"
        Me.DgvAllSintomas.ReadOnly = True
        Me.DgvAllSintomas.RowHeadersVisible = False
        Me.DgvAllSintomas.RowTemplate.Height = 50
        Me.DgvAllSintomas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DgvAllSintomas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvAllSintomas.Size = New System.Drawing.Size(846, 687)
        Me.DgvAllSintomas.TabIndex = 105
        Me.DgvAllSintomas.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.DgvAllSintomas.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DgvAllSintomas.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DgvAllSintomas.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DgvAllSintomas.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DgvAllSintomas.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DgvAllSintomas.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DgvAllSintomas.ThemeStyle.GridColor = System.Drawing.Color.Gray
        Me.DgvAllSintomas.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.DgvAllSintomas.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvAllSintomas.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DgvAllSintomas.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DgvAllSintomas.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgvAllSintomas.ThemeStyle.HeaderStyle.Height = 40
        Me.DgvAllSintomas.ThemeStyle.ReadOnly = True
        Me.DgvAllSintomas.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DgvAllSintomas.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgvAllSintomas.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvAllSintomas.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DgvAllSintomas.ThemeStyle.RowsStyle.Height = 50
        Me.DgvAllSintomas.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.DgvAllSintomas.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'BtnHCE
        '
        Me.BtnHCE.Animated = True
        Me.BtnHCE.BorderRadius = 15
        Me.BtnHCE.CheckedState.Parent = Me.BtnHCE
        Me.BtnHCE.CustomImages.Parent = Me.BtnHCE
        Me.BtnHCE.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.BtnHCE.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.BtnHCE.ForeColor = System.Drawing.Color.White
        Me.BtnHCE.HoverState.Parent = Me.BtnHCE
        Me.BtnHCE.Location = New System.Drawing.Point(38, -11)
        Me.BtnHCE.Margin = New System.Windows.Forms.Padding(3, 3, 15, 15)
        Me.BtnHCE.Name = "BtnHCE"
        Me.BtnHCE.ShadowDecoration.Parent = Me.BtnHCE
        Me.BtnHCE.Size = New System.Drawing.Size(188, 44)
        Me.BtnHCE.TabIndex = 122
        Me.BtnHCE.Text = "historial_clinico"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Animated = True
        Me.BtnCancelar.AutoRoundedCorners = True
        Me.BtnCancelar.BorderRadius = 17
        Me.BtnCancelar.CheckedState.Parent = Me.BtnCancelar
        Me.BtnCancelar.CustomImages.Parent = Me.BtnCancelar
        Me.BtnCancelar.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.BtnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.BtnCancelar.ForeColor = System.Drawing.Color.White
        Me.BtnCancelar.HoverState.Parent = Me.BtnCancelar
        Me.BtnCancelar.Location = New System.Drawing.Point(43, 802)
        Me.BtnCancelar.Margin = New System.Windows.Forms.Padding(3, 3, 15, 15)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.ShadowDecoration.Parent = Me.BtnCancelar
        Me.BtnCancelar.Size = New System.Drawing.Size(147, 36)
        Me.BtnCancelar.TabIndex = 121
        Me.BtnCancelar.Text = "cancelar"
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Animated = True
        Me.BtnAceptar.AutoRoundedCorners = True
        Me.BtnAceptar.BorderRadius = 17
        Me.BtnAceptar.CheckedState.Parent = Me.BtnAceptar
        Me.BtnAceptar.CustomImages.Parent = Me.BtnAceptar
        Me.BtnAceptar.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.BtnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.BtnAceptar.ForeColor = System.Drawing.Color.White
        Me.BtnAceptar.HoverState.Parent = Me.BtnAceptar
        Me.BtnAceptar.Location = New System.Drawing.Point(743, 802)
        Me.BtnAceptar.Margin = New System.Windows.Forms.Padding(3, 3, 15, 15)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.ShadowDecoration.Parent = Me.BtnAceptar
        Me.BtnAceptar.Size = New System.Drawing.Size(147, 36)
        Me.BtnAceptar.TabIndex = 120
        Me.BtnAceptar.Text = "aceptar"
        '
        'DgvSelectedSintomas
        '
        Me.DgvSelectedSintomas.AllowUserToAddRows = False
        Me.DgvSelectedSintomas.AllowUserToDeleteRows = False
        Me.DgvSelectedSintomas.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.DgvSelectedSintomas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DgvSelectedSintomas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvSelectedSintomas.BackgroundColor = System.Drawing.Color.White
        Me.DgvSelectedSintomas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvSelectedSintomas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgvSelectedSintomas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(123, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvSelectedSintomas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DgvSelectedSintomas.ColumnHeadersHeight = 40
        Me.DgvSelectedSintomas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgvSelectedSintomas.ColumnHeadersVisible = False
        Me.DgvSelectedSintomas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.nombre, Me.descripcion, Me.tipo})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(222, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvSelectedSintomas.DefaultCellStyle = DataGridViewCellStyle7
        Me.DgvSelectedSintomas.EnableHeadersVisualStyles = False
        Me.DgvSelectedSintomas.GridColor = System.Drawing.Color.Gray
        Me.DgvSelectedSintomas.Location = New System.Drawing.Point(44, 388)
        Me.DgvSelectedSintomas.Margin = New System.Windows.Forms.Padding(20)
        Me.DgvSelectedSintomas.MultiSelect = False
        Me.DgvSelectedSintomas.Name = "DgvSelectedSintomas"
        Me.DgvSelectedSintomas.ReadOnly = True
        Me.DgvSelectedSintomas.RowHeadersVisible = False
        Me.DgvSelectedSintomas.RowTemplate.Height = 50
        Me.DgvSelectedSintomas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DgvSelectedSintomas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvSelectedSintomas.Size = New System.Drawing.Size(846, 391)
        Me.DgvSelectedSintomas.TabIndex = 119
        Me.DgvSelectedSintomas.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.DgvSelectedSintomas.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DgvSelectedSintomas.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DgvSelectedSintomas.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DgvSelectedSintomas.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DgvSelectedSintomas.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DgvSelectedSintomas.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DgvSelectedSintomas.ThemeStyle.GridColor = System.Drawing.Color.Gray
        Me.DgvSelectedSintomas.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.DgvSelectedSintomas.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvSelectedSintomas.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DgvSelectedSintomas.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DgvSelectedSintomas.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgvSelectedSintomas.ThemeStyle.HeaderStyle.Height = 40
        Me.DgvSelectedSintomas.ThemeStyle.ReadOnly = True
        Me.DgvSelectedSintomas.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DgvSelectedSintomas.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgvSelectedSintomas.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvSelectedSintomas.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DgvSelectedSintomas.ThemeStyle.RowsStyle.Height = 50
        Me.DgvSelectedSintomas.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.DgvSelectedSintomas.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'id
        '
        Me.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.id.FillWeight = 1.0!
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        '
        'nombre
        '
        Me.nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.nombre.DefaultCellStyle = DataGridViewCellStyle6
        Me.nombre.FillWeight = 1000.0!
        Me.nombre.HeaderText = "nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        Me.nombre.Width = 876
        '
        'descripcion
        '
        Me.descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.descripcion.FillWeight = 1.0!
        Me.descripcion.HeaderText = "descripcion"
        Me.descripcion.Name = "descripcion"
        Me.descripcion.ReadOnly = True
        '
        'tipo
        '
        Me.tipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.tipo.FillWeight = 1.0!
        Me.tipo.HeaderText = "tipo"
        Me.tipo.MinimumWidth = 2
        Me.tipo.Name = "tipo"
        Me.tipo.ReadOnly = True
        Me.tipo.Width = 2
        '
        'lbl_SintomasIng
        '
        Me.lbl_SintomasIng.AutoSize = True
        Me.lbl_SintomasIng.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_SintomasIng.Location = New System.Drawing.Point(39, 344)
        Me.lbl_SintomasIng.Name = "lbl_SintomasIng"
        Me.lbl_SintomasIng.Size = New System.Drawing.Size(187, 24)
        Me.lbl_SintomasIng.TabIndex = 118
        Me.lbl_SintomasIng.Text = "sintomas_ingresados"
        '
        'PnlLeft
        '
        Me.PnlLeft.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.PnlLeft.Controls.Add(Me.BtnHCE)
        Me.PnlLeft.Controls.Add(Me.BtnCancelar)
        Me.PnlLeft.Controls.Add(Me.lbl_SintomasIng)
        Me.PnlLeft.Controls.Add(Me.BtnAceptar)
        Me.PnlLeft.Controls.Add(Me.DgvSelectedSintomas)
        Me.PnlLeft.FillColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.PnlLeft.Location = New System.Drawing.Point(0, 0)
        Me.PnlLeft.Margin = New System.Windows.Forms.Padding(0)
        Me.PnlLeft.Name = "PnlLeft"
        Me.PnlLeft.ShadowDecoration.Parent = Me.PnlLeft
        Me.PnlLeft.Size = New System.Drawing.Size(961, 1080)
        Me.PnlLeft.TabIndex = 117
        '
        'F_Sintomas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1920, 1080)
        Me.Controls.Add(Me.PnlLeft)
        Me.Controls.Add(Me.PnlRight)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "F_Sintomas"
        Me.Text = "Seleccionar Síntomas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PnlRight.ResumeLayout(False)
        Me.PnlRight.PerformLayout()
        CType(Me.DgvAllSintomas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvSelectedSintomas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlLeft.ResumeLayout(False)
        Me.PnlLeft.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PnlRight As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents LblTodo As Label
    Friend WithEvents BtnFullBody As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents LblExtremidades As Label
    Friend WithEvents LblTorso As Label
    Friend WithEvents LblCabeza As Label
    Friend WithEvents BtnExtremidades As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnTorso As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnCabeza As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnCross As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents BtnSearch As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents TxtSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents DgvAllSintomas As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents BtnHCE As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnCancelar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnAceptar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DgvSelectedSintomas As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents descripcion As DataGridViewTextBoxColumn
    Friend WithEvents tipo As DataGridViewTextBoxColumn
    Friend WithEvents lbl_SintomasIng As Label
    Friend WithEvents PnlLeft As Guna.UI2.WinForms.Guna2Panel
End Class
