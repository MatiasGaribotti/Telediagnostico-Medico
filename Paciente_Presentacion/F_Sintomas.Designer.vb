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
        Me.lbl_SintomasIng = New System.Windows.Forms.Label()
        Me.LeftPanel = New System.Windows.Forms.Panel()
        Me.BtnDiagnosticoTest = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnHCE = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnCancelar = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnAceptar = New Guna.UI2.WinForms.Guna2Button()
        Me.DgvSintomas = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.LeftPanel.SuspendLayout()
        CType(Me.DgvSintomas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_SintomasIng
        '
        Me.lbl_SintomasIng.AutoSize = True
        Me.lbl_SintomasIng.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_SintomasIng.Location = New System.Drawing.Point(45, 276)
        Me.lbl_SintomasIng.Name = "lbl_SintomasIng"
        Me.lbl_SintomasIng.Size = New System.Drawing.Size(185, 24)
        Me.lbl_SintomasIng.TabIndex = 3
        Me.lbl_SintomasIng.Text = "Síntomas Ingresados"
        '
        'LeftPanel
        '
        Me.LeftPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.LeftPanel.Controls.Add(Me.BtnDiagnosticoTest)
        Me.LeftPanel.Controls.Add(Me.BtnHCE)
        Me.LeftPanel.Controls.Add(Me.BtnCancelar)
        Me.LeftPanel.Controls.Add(Me.BtnAceptar)
        Me.LeftPanel.Controls.Add(Me.DgvSintomas)
        Me.LeftPanel.Controls.Add(Me.lbl_SintomasIng)
        Me.LeftPanel.Location = New System.Drawing.Point(0, 0)
        Me.LeftPanel.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.LeftPanel.Name = "LeftPanel"
        Me.LeftPanel.Size = New System.Drawing.Size(960, 1080)
        Me.LeftPanel.TabIndex = 4
        '
        'BtnDiagnosticoTest
        '
        Me.BtnDiagnosticoTest.Animated = True
        Me.BtnDiagnosticoTest.AutoRoundedCorners = True
        Me.BtnDiagnosticoTest.BorderRadius = 21
        Me.BtnDiagnosticoTest.CheckedState.Parent = Me.BtnDiagnosticoTest
        Me.BtnDiagnosticoTest.CustomImages.Parent = Me.BtnDiagnosticoTest
        Me.BtnDiagnosticoTest.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.BtnDiagnosticoTest.Font = New System.Drawing.Font("Roboto", 14.25!)
        Me.BtnDiagnosticoTest.ForeColor = System.Drawing.Color.White
        Me.BtnDiagnosticoTest.HoverState.Parent = Me.BtnDiagnosticoTest
        Me.BtnDiagnosticoTest.Location = New System.Drawing.Point(726, 992)
        Me.BtnDiagnosticoTest.Margin = New System.Windows.Forms.Padding(3, 3, 15, 15)
        Me.BtnDiagnosticoTest.Name = "BtnDiagnosticoTest"
        Me.BtnDiagnosticoTest.ShadowDecoration.Parent = Me.BtnDiagnosticoTest
        Me.BtnDiagnosticoTest.Size = New System.Drawing.Size(170, 44)
        Me.BtnDiagnosticoTest.TabIndex = 118
        Me.BtnDiagnosticoTest.Text = "Diagnóstico Test"
        '
        'BtnHCE
        '
        Me.BtnHCE.Animated = True
        Me.BtnHCE.AutoRoundedCorners = True
        Me.BtnHCE.BorderRadius = 17
        Me.BtnHCE.CheckedState.Parent = Me.BtnHCE
        Me.BtnHCE.CustomImages.Parent = Me.BtnHCE
        Me.BtnHCE.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.BtnHCE.Font = New System.Drawing.Font("Roboto", 14.25!)
        Me.BtnHCE.ForeColor = System.Drawing.Color.White
        Me.BtnHCE.HoverState.Parent = Me.BtnHCE
        Me.BtnHCE.Location = New System.Drawing.Point(49, 3)
        Me.BtnHCE.Margin = New System.Windows.Forms.Padding(3, 3, 15, 15)
        Me.BtnHCE.Name = "BtnHCE"
        Me.BtnHCE.ShadowDecoration.Parent = Me.BtnHCE
        Me.BtnHCE.Size = New System.Drawing.Size(188, 36)
        Me.BtnHCE.TabIndex = 117
        Me.BtnHCE.Text = "Historial Clínico"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Animated = True
        Me.BtnCancelar.AutoRoundedCorners = True
        Me.BtnCancelar.BorderRadius = 17
        Me.BtnCancelar.CheckedState.Parent = Me.BtnCancelar
        Me.BtnCancelar.CustomImages.Parent = Me.BtnCancelar
        Me.BtnCancelar.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.BtnCancelar.Font = New System.Drawing.Font("Roboto", 14.25!)
        Me.BtnCancelar.ForeColor = System.Drawing.Color.White
        Me.BtnCancelar.HoverState.Parent = Me.BtnCancelar
        Me.BtnCancelar.Location = New System.Drawing.Point(49, 734)
        Me.BtnCancelar.Margin = New System.Windows.Forms.Padding(3, 3, 15, 15)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.ShadowDecoration.Parent = Me.BtnCancelar
        Me.BtnCancelar.Size = New System.Drawing.Size(147, 36)
        Me.BtnCancelar.TabIndex = 116
        Me.BtnCancelar.Text = "Cancelar"
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Animated = True
        Me.BtnAceptar.AutoRoundedCorners = True
        Me.BtnAceptar.BorderRadius = 17
        Me.BtnAceptar.CheckedState.Parent = Me.BtnAceptar
        Me.BtnAceptar.CustomImages.Parent = Me.BtnAceptar
        Me.BtnAceptar.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.BtnAceptar.Font = New System.Drawing.Font("Roboto", 14.25!)
        Me.BtnAceptar.ForeColor = System.Drawing.Color.White
        Me.BtnAceptar.HoverState.Parent = Me.BtnAceptar
        Me.BtnAceptar.Location = New System.Drawing.Point(749, 734)
        Me.BtnAceptar.Margin = New System.Windows.Forms.Padding(3, 3, 15, 15)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.ShadowDecoration.Parent = Me.BtnAceptar
        Me.BtnAceptar.Size = New System.Drawing.Size(147, 36)
        Me.BtnAceptar.TabIndex = 115
        Me.BtnAceptar.Text = "Aceptar"
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
        Me.DgvSintomas.Location = New System.Drawing.Point(50, 320)
        Me.DgvSintomas.Margin = New System.Windows.Forms.Padding(20)
        Me.DgvSintomas.MultiSelect = False
        Me.DgvSintomas.Name = "DgvSintomas"
        Me.DgvSintomas.ReadOnly = True
        Me.DgvSintomas.RowHeadersVisible = False
        Me.DgvSintomas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DgvSintomas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvSintomas.Size = New System.Drawing.Size(846, 391)
        Me.DgvSintomas.TabIndex = 5
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
        'F_Sintomas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1920, 1080)
        Me.Controls.Add(Me.LeftPanel)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.Name = "F_Sintomas"
        Me.Text = "Seleccionar Síntomas"
        Me.LeftPanel.ResumeLayout(False)
        Me.LeftPanel.PerformLayout()
        CType(Me.DgvSintomas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbl_SintomasIng As Label
    Friend WithEvents LeftPanel As Panel
    Friend WithEvents DgvSintomas As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents BtnHCE As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnCancelar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnAceptar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnDiagnosticoTest As Guna.UI2.WinForms.Guna2Button
End Class
