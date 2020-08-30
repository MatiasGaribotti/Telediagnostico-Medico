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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.BtnCross = New System.Windows.Forms.Button()
        Me.TxtBuscador = New System.Windows.Forms.TextBox()
        Me.PnlBackgroundBuscador = New System.Windows.Forms.Panel()
        Me.BtnVolver = New Guna.UI2.WinForms.Guna2Button()
        Me.DgvSintomas = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.PnlBackgroundBuscador.SuspendLayout()
        CType(Me.DgvSintomas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnSearch
        '
        Me.BtnSearch.BackColor = System.Drawing.Color.Transparent
        Me.BtnSearch.BackgroundImage = Global.Presentacion.My.Resources.Resources.search_65x65
        Me.BtnSearch.FlatAppearance.BorderSize = 0
        Me.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSearch.Location = New System.Drawing.Point(835, 151)
        Me.BtnSearch.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(65, 65)
        Me.BtnSearch.TabIndex = 4
        Me.BtnSearch.UseVisualStyleBackColor = False
        '
        'BtnCross
        '
        Me.BtnCross.BackColor = System.Drawing.Color.Transparent
        Me.BtnCross.BackgroundImage = Global.Presentacion.My.Resources.Resources.cross_65x65
        Me.BtnCross.FlatAppearance.BorderSize = 0
        Me.BtnCross.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCross.Location = New System.Drawing.Point(394, 151)
        Me.BtnCross.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnCross.Name = "BtnCross"
        Me.BtnCross.Size = New System.Drawing.Size(65, 65)
        Me.BtnCross.TabIndex = 5
        Me.BtnCross.UseVisualStyleBackColor = False
        '
        'TxtBuscador
        '
        Me.TxtBuscador.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtBuscador.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBuscador.Location = New System.Drawing.Point(1, 19)
        Me.TxtBuscador.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtBuscador.Name = "TxtBuscador"
        Me.TxtBuscador.Size = New System.Drawing.Size(375, 22)
        Me.TxtBuscador.TabIndex = 3
        '
        'PnlBackgroundBuscador
        '
        Me.PnlBackgroundBuscador.BackColor = System.Drawing.Color.White
        Me.PnlBackgroundBuscador.Controls.Add(Me.TxtBuscador)
        Me.PnlBackgroundBuscador.Location = New System.Drawing.Point(458, 151)
        Me.PnlBackgroundBuscador.Name = "PnlBackgroundBuscador"
        Me.PnlBackgroundBuscador.Size = New System.Drawing.Size(398, 65)
        Me.PnlBackgroundBuscador.TabIndex = 6
        '
        'BtnVolver
        '
        Me.BtnVolver.Animated = True
        Me.BtnVolver.AutoRoundedCorners = True
        Me.BtnVolver.BackColor = System.Drawing.Color.Transparent
        Me.BtnVolver.BorderRadius = 20
        Me.BtnVolver.CheckedState.Parent = Me.BtnVolver
        Me.BtnVolver.CustomImages.Parent = Me.BtnVolver
        Me.BtnVolver.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.BtnVolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.BtnVolver.ForeColor = System.Drawing.Color.White
        Me.BtnVolver.HoverState.Parent = Me.BtnVolver
        Me.BtnVolver.Location = New System.Drawing.Point(778, 958)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.ShadowDecoration.Parent = Me.BtnVolver
        Me.BtnVolver.Size = New System.Drawing.Size(122, 43)
        Me.BtnVolver.TabIndex = 92
        Me.BtnVolver.Text = "Volver"
        Me.BtnVolver.UseTransparentBackground = True
        '
        'DgvSintomas
        '
        Me.DgvSintomas.AllowUserToAddRows = False
        Me.DgvSintomas.AllowUserToDeleteRows = False
        Me.DgvSintomas.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(245, Byte), Integer))
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
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(222, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvSintomas.DefaultCellStyle = DataGridViewCellStyle3
        Me.DgvSintomas.EnableHeadersVisualStyles = False
        Me.DgvSintomas.GridColor = System.Drawing.Color.Gray
        Me.DgvSintomas.Location = New System.Drawing.Point(54, 254)
        Me.DgvSintomas.Margin = New System.Windows.Forms.Padding(20)
        Me.DgvSintomas.MultiSelect = False
        Me.DgvSintomas.Name = "DgvSintomas"
        Me.DgvSintomas.ReadOnly = True
        Me.DgvSintomas.RowHeadersVisible = False
        Me.DgvSintomas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DgvSintomas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvSintomas.Size = New System.Drawing.Size(846, 633)
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
        'F_Sintomas_Buscar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(960, 1080)
        Me.Controls.Add(Me.DgvSintomas)
        Me.Controls.Add(Me.BtnVolver)
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.BtnCross)
        Me.Controls.Add(Me.PnlBackgroundBuscador)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "F_Sintomas_Buscar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "F_Sintomas_Buscar"
        Me.PnlBackgroundBuscador.ResumeLayout(False)
        Me.PnlBackgroundBuscador.PerformLayout()
        CType(Me.DgvSintomas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnSearch As Button
    Friend WithEvents BtnCross As Button
    Friend WithEvents TxtBuscador As TextBox
    Friend WithEvents PnlBackgroundBuscador As Panel
    Friend WithEvents BtnVolver As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DgvSintomas As Guna.UI2.WinForms.Guna2DataGridView
End Class
