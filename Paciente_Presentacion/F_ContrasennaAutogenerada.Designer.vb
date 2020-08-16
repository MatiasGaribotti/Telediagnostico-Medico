<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_ContrasennaAutogenerada
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
        Me.TxtNewPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtConfirmPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.LblContraseña = New System.Windows.Forms.Label()
        Me.LblConfirm = New System.Windows.Forms.Label()
        Me.LblSeDetecto = New System.Windows.Forms.Label()
        Me.Btn_Aceptar = New System.Windows.Forms.Button()
        Me.Btn_Cancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtNewPassword
        '
        Me.TxtNewPassword.Animated = True
        Me.TxtNewPassword.BorderRadius = 16
        Me.TxtNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtNewPassword.DefaultText = ""
        Me.TxtNewPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtNewPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtNewPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtNewPassword.DisabledState.Parent = Me.TxtNewPassword
        Me.TxtNewPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtNewPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtNewPassword.FocusedState.Parent = Me.TxtNewPassword
        Me.TxtNewPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtNewPassword.HoverState.Parent = Me.TxtNewPassword
        Me.TxtNewPassword.Location = New System.Drawing.Point(372, 43)
        Me.TxtNewPassword.Name = "TxtNewPassword"
        Me.TxtNewPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtNewPassword.PlaceholderText = ""
        Me.TxtNewPassword.SelectedText = ""
        Me.TxtNewPassword.ShadowDecoration.Parent = Me.TxtNewPassword
        Me.TxtNewPassword.Size = New System.Drawing.Size(230, 28)
        Me.TxtNewPassword.TabIndex = 12
        '
        'TxtConfirmPassword
        '
        Me.TxtConfirmPassword.Animated = True
        Me.TxtConfirmPassword.BorderRadius = 16
        Me.TxtConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtConfirmPassword.DefaultText = ""
        Me.TxtConfirmPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtConfirmPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtConfirmPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtConfirmPassword.DisabledState.Parent = Me.TxtConfirmPassword
        Me.TxtConfirmPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtConfirmPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtConfirmPassword.FocusedState.Parent = Me.TxtConfirmPassword
        Me.TxtConfirmPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtConfirmPassword.HoverState.Parent = Me.TxtConfirmPassword
        Me.TxtConfirmPassword.Location = New System.Drawing.Point(372, 77)
        Me.TxtConfirmPassword.Name = "TxtConfirmPassword"
        Me.TxtConfirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtConfirmPassword.PlaceholderText = ""
        Me.TxtConfirmPassword.SelectedText = ""
        Me.TxtConfirmPassword.ShadowDecoration.Parent = Me.TxtConfirmPassword
        Me.TxtConfirmPassword.Size = New System.Drawing.Size(230, 28)
        Me.TxtConfirmPassword.TabIndex = 13
        '
        'LblContraseña
        '
        Me.LblContraseña.AutoSize = True
        Me.LblContraseña.Font = New System.Drawing.Font("Roboto", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblContraseña.Location = New System.Drawing.Point(64, 43)
        Me.LblContraseña.Name = "LblContraseña"
        Me.LblContraseña.Size = New System.Drawing.Size(161, 23)
        Me.LblContraseña.TabIndex = 14
        Me.LblContraseña.Text = "Nueva contraseña"
        '
        'LblConfirm
        '
        Me.LblConfirm.AutoSize = True
        Me.LblConfirm.Font = New System.Drawing.Font("Roboto", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblConfirm.Location = New System.Drawing.Point(64, 77)
        Me.LblConfirm.Name = "LblConfirm"
        Me.LblConfirm.Size = New System.Drawing.Size(245, 23)
        Me.LblConfirm.TabIndex = 15
        Me.LblConfirm.Text = "Confirmar nueva nontraseña"
        '
        'LblSeDetecto
        '
        Me.LblSeDetecto.AutoSize = True
        Me.LblSeDetecto.Font = New System.Drawing.Font("Roboto", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSeDetecto.Location = New System.Drawing.Point(47, 13)
        Me.LblSeDetecto.Name = "LblSeDetecto"
        Me.LblSeDetecto.Size = New System.Drawing.Size(353, 23)
        Me.LblSeDetecto.TabIndex = 16
        Me.LblSeDetecto.Text = "Se detectó una contraseña autogenerada"
        '
        'Btn_Aceptar
        '
        Me.Btn_Aceptar.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Aceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btn_Aceptar.FlatAppearance.BorderSize = 0
        Me.Btn_Aceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Btn_Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Aceptar.Image = Global.Presentacion.My.Resources.Resources.BtnAceptar
        Me.Btn_Aceptar.Location = New System.Drawing.Point(438, 134)
        Me.Btn_Aceptar.Margin = New System.Windows.Forms.Padding(0)
        Me.Btn_Aceptar.Name = "Btn_Aceptar"
        Me.Btn_Aceptar.Size = New System.Drawing.Size(178, 38)
        Me.Btn_Aceptar.TabIndex = 17
        Me.Btn_Aceptar.UseVisualStyleBackColor = False
        '
        'Btn_Cancelar
        '
        Me.Btn_Cancelar.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btn_Cancelar.FlatAppearance.BorderSize = 0
        Me.Btn_Cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Cancelar.Image = Global.Presentacion.My.Resources.Resources.BtnCancelar
        Me.Btn_Cancelar.Location = New System.Drawing.Point(616, 134)
        Me.Btn_Cancelar.Margin = New System.Windows.Forms.Padding(0)
        Me.Btn_Cancelar.Name = "Btn_Cancelar"
        Me.Btn_Cancelar.Size = New System.Drawing.Size(178, 38)
        Me.Btn_Cancelar.TabIndex = 18
        Me.Btn_Cancelar.UseVisualStyleBackColor = False
        '
        'F_ContrasennaAutogenerada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(804, 218)
        Me.Controls.Add(Me.Btn_Cancelar)
        Me.Controls.Add(Me.Btn_Aceptar)
        Me.Controls.Add(Me.LblSeDetecto)
        Me.Controls.Add(Me.LblConfirm)
        Me.Controls.Add(Me.LblContraseña)
        Me.Controls.Add(Me.TxtConfirmPassword)
        Me.Controls.Add(Me.TxtNewPassword)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "F_ContrasennaAutogenerada"
        Me.Text = "F_ContrasennaAutogenerada"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtNewPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtConfirmPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents LblContraseña As Label
    Friend WithEvents LblConfirm As Label
    Friend WithEvents LblSeDetecto As Label
    Friend WithEvents Btn_Aceptar As Button
    Friend WithEvents Btn_Cancelar As Button
End Class
