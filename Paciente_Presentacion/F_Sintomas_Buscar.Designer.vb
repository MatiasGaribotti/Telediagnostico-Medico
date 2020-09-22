<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F_Sintomas_Buscar
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DgvSintomas = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.BtnCross = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.BtnSearch = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.TxtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BtnCabeza = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnTorso = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnExtremidades = New Guna.UI2.WinForms.Guna2Button()
        Me.LblCabeza = New System.Windows.Forms.Label()
        Me.LblTorso = New System.Windows.Forms.Label()
        Me.LblExtremidades = New System.Windows.Forms.Label()
        Me.LblTodo = New System.Windows.Forms.Label()
        Me.BtnFullBody = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.DgvSintomas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvSintomas
        '
        Me.DgvSintomas.AllowUserToAddRows = False
        Me.DgvSintomas.AllowUserToDeleteRows = False
        Me.DgvSintomas.AllowUserToResizeRows = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.DgvSintomas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.DgvSintomas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvSintomas.BackgroundColor = System.Drawing.Color.White
        Me.DgvSintomas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvSintomas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgvSintomas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(123, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvSintomas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.DgvSintomas.ColumnHeadersHeight = 40
        Me.DgvSintomas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(222, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvSintomas.DefaultCellStyle = DataGridViewCellStyle9
        Me.DgvSintomas.EnableHeadersVisualStyles = False
        Me.DgvSintomas.GridColor = System.Drawing.Color.Gray
        Me.DgvSintomas.Location = New System.Drawing.Point(54, 306)
        Me.DgvSintomas.Margin = New System.Windows.Forms.Padding(20)
        Me.DgvSintomas.MultiSelect = False
        Me.DgvSintomas.Name = "DgvSintomas"
        Me.DgvSintomas.ReadOnly = True
        Me.DgvSintomas.RowHeadersVisible = False
        Me.DgvSintomas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DgvSintomas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvSintomas.Size = New System.Drawing.Size(846, 687)
        Me.DgvSintomas.TabIndex = 93
        Me.DgvSintomas.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.DgvSintomas.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(245, Byte), Integer))
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
        Me.DgvSintomas.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.DgvSintomas.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
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
        Me.BtnCross.Location = New System.Drawing.Point(140, 213)
        Me.BtnCross.Name = "BtnCross"
        Me.BtnCross.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.BtnCross.ShadowDecoration.Parent = Me.BtnCross
        Me.BtnCross.Size = New System.Drawing.Size(70, 70)
        Me.BtnCross.TabIndex = 96
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
        Me.BtnSearch.Location = New System.Drawing.Point(742, 213)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.BtnSearch.ShadowDecoration.Parent = Me.BtnSearch
        Me.BtnSearch.Size = New System.Drawing.Size(70, 70)
        Me.BtnSearch.TabIndex = 95
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
        Me.TxtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtSearch.HoverState.Parent = Me.TxtSearch
        Me.TxtSearch.Location = New System.Drawing.Point(216, 213)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtSearch.PlaceholderText = ""
        Me.TxtSearch.SelectedText = ""
        Me.TxtSearch.ShadowDecoration.Parent = Me.TxtSearch
        Me.TxtSearch.Size = New System.Drawing.Size(520, 70)
        Me.TxtSearch.TabIndex = 94
        '
        'BtnCabeza
        '
        Me.BtnCabeza.Animated = True
        Me.BtnCabeza.BorderColor = System.Drawing.Color.Transparent
        Me.BtnCabeza.BorderRadius = 20
        Me.BtnCabeza.CheckedState.Parent = Me.BtnCabeza
        Me.BtnCabeza.CustomImages.Parent = Me.BtnCabeza
        Me.BtnCabeza.FillColor = System.Drawing.Color.White
        Me.BtnCabeza.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnCabeza.ForeColor = System.Drawing.Color.White
        Me.BtnCabeza.HoverState.Parent = Me.BtnCabeza
        Me.BtnCabeza.Image = Global.Presentacion.My.Resources.Resources.head_100px
        Me.BtnCabeza.ImageSize = New System.Drawing.Size(100, 100)
        Me.BtnCabeza.Location = New System.Drawing.Point(321, 29)
        Me.BtnCabeza.Name = "BtnCabeza"
        Me.BtnCabeza.ShadowDecoration.Parent = Me.BtnCabeza
        Me.BtnCabeza.Size = New System.Drawing.Size(120, 120)
        Me.BtnCabeza.TabIndex = 97
        '
        'BtnTorso
        '
        Me.BtnTorso.Animated = True
        Me.BtnTorso.BorderColor = System.Drawing.Color.Transparent
        Me.BtnTorso.BorderRadius = 20
        Me.BtnTorso.CheckedState.Parent = Me.BtnTorso
        Me.BtnTorso.CustomImages.Parent = Me.BtnTorso
        Me.BtnTorso.FillColor = System.Drawing.Color.White
        Me.BtnTorso.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnTorso.ForeColor = System.Drawing.Color.White
        Me.BtnTorso.HoverState.Parent = Me.BtnTorso
        Me.BtnTorso.Image = Global.Presentacion.My.Resources.Resources.chest_100px
        Me.BtnTorso.ImageSize = New System.Drawing.Size(100, 100)
        Me.BtnTorso.Location = New System.Drawing.Point(459, 29)
        Me.BtnTorso.Name = "BtnTorso"
        Me.BtnTorso.ShadowDecoration.Parent = Me.BtnTorso
        Me.BtnTorso.Size = New System.Drawing.Size(120, 120)
        Me.BtnTorso.TabIndex = 98
        '
        'BtnExtremidades
        '
        Me.BtnExtremidades.Animated = True
        Me.BtnExtremidades.BorderColor = System.Drawing.Color.Transparent
        Me.BtnExtremidades.BorderRadius = 20
        Me.BtnExtremidades.CheckedState.Parent = Me.BtnExtremidades
        Me.BtnExtremidades.CustomImages.Parent = Me.BtnExtremidades
        Me.BtnExtremidades.FillColor = System.Drawing.Color.White
        Me.BtnExtremidades.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnExtremidades.ForeColor = System.Drawing.Color.White
        Me.BtnExtremidades.HoverState.Parent = Me.BtnExtremidades
        Me.BtnExtremidades.Image = Global.Presentacion.My.Resources.Resources.arms_legs_100
        Me.BtnExtremidades.ImageSize = New System.Drawing.Size(100, 100)
        Me.BtnExtremidades.Location = New System.Drawing.Point(600, 29)
        Me.BtnExtremidades.Name = "BtnExtremidades"
        Me.BtnExtremidades.ShadowDecoration.Parent = Me.BtnExtremidades
        Me.BtnExtremidades.Size = New System.Drawing.Size(120, 120)
        Me.BtnExtremidades.TabIndex = 99
        '
        'LblCabeza
        '
        Me.LblCabeza.AutoSize = True
        Me.LblCabeza.Font = New System.Drawing.Font("Roboto", 14.25!)
        Me.LblCabeza.Location = New System.Drawing.Point(347, 163)
        Me.LblCabeza.Name = "LblCabeza"
        Me.LblCabeza.Size = New System.Drawing.Size(72, 23)
        Me.LblCabeza.TabIndex = 100
        Me.LblCabeza.Text = "Cabeza"
        Me.LblCabeza.Visible = False
        '
        'LblTorso
        '
        Me.LblTorso.AutoSize = True
        Me.LblTorso.Font = New System.Drawing.Font("Roboto", 14.25!)
        Me.LblTorso.Location = New System.Drawing.Point(491, 163)
        Me.LblTorso.Name = "LblTorso"
        Me.LblTorso.Size = New System.Drawing.Size(58, 23)
        Me.LblTorso.TabIndex = 101
        Me.LblTorso.Text = "Torso"
        Me.LblTorso.Visible = False
        '
        'LblExtremidades
        '
        Me.LblExtremidades.AutoSize = True
        Me.LblExtremidades.Font = New System.Drawing.Font("Roboto", 14.25!)
        Me.LblExtremidades.Location = New System.Drawing.Point(596, 163)
        Me.LblExtremidades.Name = "LblExtremidades"
        Me.LblExtremidades.Size = New System.Drawing.Size(126, 23)
        Me.LblExtremidades.TabIndex = 102
        Me.LblExtremidades.Text = "Extremidades"
        Me.LblExtremidades.Visible = False
        '
        'LblTodo
        '
        Me.LblTodo.AutoSize = True
        Me.LblTodo.Font = New System.Drawing.Font("Roboto", 14.25!)
        Me.LblTodo.Location = New System.Drawing.Point(212, 163)
        Me.LblTodo.Name = "LblTodo"
        Me.LblTodo.Size = New System.Drawing.Size(53, 23)
        Me.LblTodo.TabIndex = 104
        Me.LblTodo.Text = "Todo"
        Me.LblTodo.Visible = False
        '
        'BtnFullBody
        '
        Me.BtnFullBody.Animated = True
        Me.BtnFullBody.BorderColor = System.Drawing.Color.Transparent
        Me.BtnFullBody.BorderRadius = 20
        Me.BtnFullBody.CheckedState.Parent = Me.BtnFullBody
        Me.BtnFullBody.CustomImages.Parent = Me.BtnFullBody
        Me.BtnFullBody.FillColor = System.Drawing.Color.White
        Me.BtnFullBody.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnFullBody.ForeColor = System.Drawing.Color.White
        Me.BtnFullBody.HoverState.Parent = Me.BtnFullBody
        Me.BtnFullBody.Image = Global.Presentacion.My.Resources.Resources.full_body_100
        Me.BtnFullBody.ImageSize = New System.Drawing.Size(100, 100)
        Me.BtnFullBody.Location = New System.Drawing.Point(179, 29)
        Me.BtnFullBody.Name = "BtnFullBody"
        Me.BtnFullBody.ShadowDecoration.Parent = Me.BtnFullBody
        Me.BtnFullBody.Size = New System.Drawing.Size(120, 120)
        Me.BtnFullBody.TabIndex = 103
        '
        'F_Sintomas_Buscar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(960, 1080)
        Me.Controls.Add(Me.LblTodo)
        Me.Controls.Add(Me.BtnFullBody)
        Me.Controls.Add(Me.LblExtremidades)
        Me.Controls.Add(Me.LblTorso)
        Me.Controls.Add(Me.LblCabeza)
        Me.Controls.Add(Me.BtnExtremidades)
        Me.Controls.Add(Me.BtnTorso)
        Me.Controls.Add(Me.BtnCabeza)
        Me.Controls.Add(Me.BtnCross)
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.TxtSearch)
        Me.Controls.Add(Me.DgvSintomas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "F_Sintomas_Buscar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "F_Sintomas_Buscar"
        CType(Me.DgvSintomas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DgvSintomas As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents BtnCross As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents BtnSearch As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents TxtSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BtnCabeza As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnTorso As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnExtremidades As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents LblCabeza As Label
    Friend WithEvents LblTorso As Label
    Friend WithEvents LblExtremidades As Label
    Friend WithEvents LblTodo As Label
    Friend WithEvents BtnFullBody As Guna.UI2.WinForms.Guna2Button
End Class
