<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F_Sintomas_Buscar_Tipo
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
        Me.lblCabeza = New System.Windows.Forms.Label()
        Me.LblTorso = New System.Windows.Forms.Label()
        Me.LblExtremidades = New System.Windows.Forms.Label()
        Me.PicCabeza = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.PicTorso = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.PicExtremidades = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.TxtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BtnSearch = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.BtnCross = New Guna.UI2.WinForms.Guna2CircleButton()
        CType(Me.PicCabeza, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicTorso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicExtremidades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCabeza
        '
        Me.lblCabeza.AutoSize = True
        Me.lblCabeza.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCabeza.Location = New System.Drawing.Point(166, 670)
        Me.lblCabeza.Name = "lblCabeza"
        Me.lblCabeza.Size = New System.Drawing.Size(74, 24)
        Me.lblCabeza.TabIndex = 4
        Me.lblCabeza.Text = "Cabeza"
        '
        'LblTorso
        '
        Me.LblTorso.AutoSize = True
        Me.LblTorso.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTorso.Location = New System.Drawing.Point(449, 670)
        Me.LblTorso.Name = "LblTorso"
        Me.LblTorso.Size = New System.Drawing.Size(59, 24)
        Me.LblTorso.TabIndex = 4
        Me.LblTorso.Text = "Torso"
        '
        'LblExtremidades
        '
        Me.LblExtremidades.AutoSize = True
        Me.LblExtremidades.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblExtremidades.Location = New System.Drawing.Point(690, 670)
        Me.LblExtremidades.Name = "LblExtremidades"
        Me.LblExtremidades.Size = New System.Drawing.Size(126, 24)
        Me.LblExtremidades.TabIndex = 4
        Me.LblExtremidades.Text = "Extremidades"
        '
        'PicCabeza
        '
        Me.PicCabeza.AutoRoundedCorners = True
        Me.PicCabeza.BackColor = System.Drawing.Color.White
        Me.PicCabeza.BorderRadius = 124
        Me.PicCabeza.Location = New System.Drawing.Point(78, 400)
        Me.PicCabeza.Name = "PicCabeza"
        Me.PicCabeza.ShadowDecoration.Parent = Me.PicCabeza
        Me.PicCabeza.Size = New System.Drawing.Size(250, 250)
        Me.PicCabeza.TabIndex = 5
        Me.PicCabeza.TabStop = False
        '
        'PicTorso
        '
        Me.PicTorso.AutoRoundedCorners = True
        Me.PicTorso.BackColor = System.Drawing.Color.White
        Me.PicTorso.BorderRadius = 124
        Me.PicTorso.Location = New System.Drawing.Point(353, 400)
        Me.PicTorso.Name = "PicTorso"
        Me.PicTorso.ShadowDecoration.Parent = Me.PicTorso
        Me.PicTorso.Size = New System.Drawing.Size(250, 250)
        Me.PicTorso.TabIndex = 6
        Me.PicTorso.TabStop = False
        '
        'PicExtremidades
        '
        Me.PicExtremidades.AutoRoundedCorners = True
        Me.PicExtremidades.BackColor = System.Drawing.Color.White
        Me.PicExtremidades.BorderRadius = 124
        Me.PicExtremidades.Location = New System.Drawing.Point(628, 400)
        Me.PicExtremidades.Name = "PicExtremidades"
        Me.PicExtremidades.ShadowDecoration.Parent = Me.PicExtremidades
        Me.PicExtremidades.Size = New System.Drawing.Size(250, 250)
        Me.PicExtremidades.TabIndex = 7
        Me.PicExtremidades.TabStop = False
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
        Me.TxtSearch.Location = New System.Drawing.Point(216, 193)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtSearch.PlaceholderText = ""
        Me.TxtSearch.SelectedText = ""
        Me.TxtSearch.ShadowDecoration.Parent = Me.TxtSearch
        Me.TxtSearch.Size = New System.Drawing.Size(520, 70)
        Me.TxtSearch.TabIndex = 8
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
        Me.BtnSearch.Location = New System.Drawing.Point(746, 193)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.BtnSearch.ShadowDecoration.Parent = Me.BtnSearch
        Me.BtnSearch.Size = New System.Drawing.Size(70, 70)
        Me.BtnSearch.TabIndex = 9
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
        Me.BtnCross.Location = New System.Drawing.Point(140, 193)
        Me.BtnCross.Name = "BtnCross"
        Me.BtnCross.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.BtnCross.ShadowDecoration.Parent = Me.BtnCross
        Me.BtnCross.Size = New System.Drawing.Size(70, 70)
        Me.BtnCross.TabIndex = 10
        '
        'F_Sintomas_Buscar_Tipo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(960, 1080)
        Me.Controls.Add(Me.BtnCross)
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.TxtSearch)
        Me.Controls.Add(Me.PicExtremidades)
        Me.Controls.Add(Me.PicTorso)
        Me.Controls.Add(Me.PicCabeza)
        Me.Controls.Add(Me.LblExtremidades)
        Me.Controls.Add(Me.LblTorso)
        Me.Controls.Add(Me.lblCabeza)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "F_Sintomas_Buscar_Tipo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Frm_Sintomas_Buscar_Tipo"
        CType(Me.PicCabeza, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicTorso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicExtremidades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCabeza As Label
    Friend WithEvents LblTorso As Label
    Friend WithEvents LblExtremidades As Label
    Friend WithEvents PicCabeza As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents PicTorso As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents PicExtremidades As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents TxtSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BtnSearch As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents BtnCross As Guna.UI2.WinForms.Guna2CircleButton
End Class
