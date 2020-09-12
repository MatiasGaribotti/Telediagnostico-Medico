<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F_ContrasennaAutogenerada
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
        Me.TxtNewPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtConfirmPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.LblContraseña = New System.Windows.Forms.Label()
        Me.LblConfirm = New System.Windows.Forms.Label()
        Me.LblSeDetecto = New System.Windows.Forms.Label()
        Me.BtnCancelar = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnAceptar = New Guna.UI2.WinForms.Guna2Button()
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
        Me.BtnCancelar.Location = New System.Drawing.Point(321, 143)
        Me.BtnCancelar.Margin = New System.Windows.Forms.Padding(3, 3, 15, 15)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.ShadowDecoration.Parent = Me.BtnCancelar
        Me.BtnCancelar.Size = New System.Drawing.Size(147, 36)
        Me.BtnCancelar.TabIndex = 118
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
        Me.BtnAceptar.Location = New System.Drawing.Point(486, 143)
        Me.BtnAceptar.Margin = New System.Windows.Forms.Padding(3, 3, 15, 15)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.ShadowDecoration.Parent = Me.BtnAceptar
        Me.BtnAceptar.Size = New System.Drawing.Size(147, 36)
        Me.BtnAceptar.TabIndex = 117
        Me.BtnAceptar.Text = "Aceptar"
        '
        'F_ContrasennaAutogenerada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(804, 218)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
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
    Friend WithEvents BtnCancelar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnAceptar As Guna.UI2.WinForms.Guna2Button
End Class
