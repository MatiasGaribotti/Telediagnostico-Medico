<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F_ABM
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
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.LblEmpleados = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Btn_Empleados = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnCerrarSesion = New Guna.UI2.WinForms.Guna2Button()
        Me.Btn_Minimize = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Btn_Exit = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.LblPacientes = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Btn_Enfermedades = New Guna.UI2.WinForms.Guna2Button()
        Me.Btn_Sitnomas = New Guna.UI2.WinForms.Guna2Button()
        Me.Btn_Pacientes = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.LblEmpleados)
        Me.Guna2Panel1.Controls.Add(Me.Btn_Empleados)
        Me.Guna2Panel1.Controls.Add(Me.BtnCerrarSesion)
        Me.Guna2Panel1.Controls.Add(Me.Btn_Minimize)
        Me.Guna2Panel1.Controls.Add(Me.Btn_Exit)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel5)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Guna2Panel1.Controls.Add(Me.LblPacientes)
        Me.Guna2Panel1.Controls.Add(Me.Btn_Enfermedades)
        Me.Guna2Panel1.Controls.Add(Me.Btn_Sitnomas)
        Me.Guna2Panel1.Controls.Add(Me.Btn_Pacientes)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(1920, 1080)
        Me.Guna2Panel1.TabIndex = 0
        '
        'LblEmpleados
        '
        Me.LblEmpleados.BackColor = System.Drawing.Color.Transparent
        Me.LblEmpleados.Font = New System.Drawing.Font("Roboto", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEmpleados.Location = New System.Drawing.Point(969, 478)
        Me.LblEmpleados.Name = "LblEmpleados"
        Me.LblEmpleados.Size = New System.Drawing.Size(161, 40)
        Me.LblEmpleados.TabIndex = 93
        Me.LblEmpleados.Text = "empleados"
        '
        'Btn_Empleados
        '
        Me.Btn_Empleados.Animated = True
        Me.Btn_Empleados.BorderRadius = 33
        Me.Btn_Empleados.CheckedState.Parent = Me.Btn_Empleados
        Me.Btn_Empleados.CustomImages.Parent = Me.Btn_Empleados
        Me.Btn_Empleados.FillColor = System.Drawing.Color.White
        Me.Btn_Empleados.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Btn_Empleados.ForeColor = System.Drawing.Color.White
        Me.Btn_Empleados.HoverState.Parent = Me.Btn_Empleados
        Me.Btn_Empleados.Location = New System.Drawing.Point(925, 222)
        Me.Btn_Empleados.Margin = New System.Windows.Forms.Padding(3, 3, 27, 3)
        Me.Btn_Empleados.Name = "Btn_Empleados"
        Me.Btn_Empleados.ShadowDecoration.Parent = Me.Btn_Empleados
        Me.Btn_Empleados.Size = New System.Drawing.Size(250, 250)
        Me.Btn_Empleados.TabIndex = 92
        '
        'BtnCerrarSesion
        '
        Me.BtnCerrarSesion.Animated = True
        Me.BtnCerrarSesion.AutoRoundedCorners = True
        Me.BtnCerrarSesion.BackColor = System.Drawing.Color.Transparent
        Me.BtnCerrarSesion.BorderRadius = 22
        Me.BtnCerrarSesion.CheckedState.Parent = Me.BtnCerrarSesion
        Me.BtnCerrarSesion.CustomImages.Parent = Me.BtnCerrarSesion
        Me.BtnCerrarSesion.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.BtnCerrarSesion.Font = New System.Drawing.Font("Roboto", 18.0!)
        Me.BtnCerrarSesion.ForeColor = System.Drawing.Color.White
        Me.BtnCerrarSesion.HoverState.Parent = Me.BtnCerrarSesion
        Me.BtnCerrarSesion.Location = New System.Drawing.Point(809, 855)
        Me.BtnCerrarSesion.Margin = New System.Windows.Forms.Padding(3, 17, 3, 3)
        Me.BtnCerrarSesion.Name = "BtnCerrarSesion"
        Me.BtnCerrarSesion.ShadowDecoration.Parent = Me.BtnCerrarSesion
        Me.BtnCerrarSesion.Size = New System.Drawing.Size(198, 46)
        Me.BtnCerrarSesion.TabIndex = 91
        Me.BtnCerrarSesion.Text = "cerrar_sesion"
        Me.BtnCerrarSesion.UseTransparentBackground = True
        '
        'Btn_Minimize
        '
        Me.Btn_Minimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Minimize.Animated = True
        Me.Btn_Minimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Btn_Minimize.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Btn_Minimize.HoverState.Parent = Me.Btn_Minimize
        Me.Btn_Minimize.IconColor = System.Drawing.Color.White
        Me.Btn_Minimize.Location = New System.Drawing.Point(1830, 0)
        Me.Btn_Minimize.Margin = New System.Windows.Forms.Padding(0)
        Me.Btn_Minimize.Name = "Btn_Minimize"
        Me.Btn_Minimize.ShadowDecoration.Parent = Me.Btn_Minimize
        Me.Btn_Minimize.Size = New System.Drawing.Size(45, 29)
        Me.Btn_Minimize.TabIndex = 6
        '
        'Btn_Exit
        '
        Me.Btn_Exit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Exit.Animated = True
        Me.Btn_Exit.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Btn_Exit.HoverState.Parent = Me.Btn_Exit
        Me.Btn_Exit.IconColor = System.Drawing.Color.White
        Me.Btn_Exit.Location = New System.Drawing.Point(1875, 0)
        Me.Btn_Exit.Margin = New System.Windows.Forms.Padding(0)
        Me.Btn_Exit.Name = "Btn_Exit"
        Me.Btn_Exit.ShadowDecoration.Parent = Me.Btn_Exit
        Me.Btn_Exit.Size = New System.Drawing.Size(45, 29)
        Me.Btn_Exit.TabIndex = 5
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Roboto", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(942, 795)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(209, 40)
        Me.Guna2HtmlLabel5.TabIndex = 2
        Me.Guna2HtmlLabel5.Text = "enfermedades"
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Roboto", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(706, 795)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(136, 40)
        Me.Guna2HtmlLabel4.TabIndex = 2
        Me.Guna2HtmlLabel4.Text = "sintomas"
        '
        'LblPacientes
        '
        Me.LblPacientes.BackColor = System.Drawing.Color.Transparent
        Me.LblPacientes.Font = New System.Drawing.Font("Roboto", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPacientes.Location = New System.Drawing.Point(709, 478)
        Me.LblPacientes.Name = "LblPacientes"
        Me.LblPacientes.Size = New System.Drawing.Size(142, 40)
        Me.LblPacientes.TabIndex = 2
        Me.LblPacientes.Text = "pacientes"
        '
        'Btn_Enfermedades
        '
        Me.Btn_Enfermedades.Animated = True
        Me.Btn_Enfermedades.BorderRadius = 33
        Me.Btn_Enfermedades.CheckedState.Parent = Me.Btn_Enfermedades
        Me.Btn_Enfermedades.CustomImages.Parent = Me.Btn_Enfermedades
        Me.Btn_Enfermedades.FillColor = System.Drawing.Color.White
        Me.Btn_Enfermedades.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Btn_Enfermedades.ForeColor = System.Drawing.Color.White
        Me.Btn_Enfermedades.HoverState.Parent = Me.Btn_Enfermedades
        Me.Btn_Enfermedades.Location = New System.Drawing.Point(925, 539)
        Me.Btn_Enfermedades.Name = "Btn_Enfermedades"
        Me.Btn_Enfermedades.ShadowDecoration.Parent = Me.Btn_Enfermedades
        Me.Btn_Enfermedades.Size = New System.Drawing.Size(250, 250)
        Me.Btn_Enfermedades.TabIndex = 1
        '
        'Btn_Sitnomas
        '
        Me.Btn_Sitnomas.Animated = True
        Me.Btn_Sitnomas.BorderRadius = 33
        Me.Btn_Sitnomas.CheckedState.Parent = Me.Btn_Sitnomas
        Me.Btn_Sitnomas.CustomImages.Parent = Me.Btn_Sitnomas
        Me.Btn_Sitnomas.FillColor = System.Drawing.Color.White
        Me.Btn_Sitnomas.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Btn_Sitnomas.ForeColor = System.Drawing.Color.White
        Me.Btn_Sitnomas.HoverState.Parent = Me.Btn_Sitnomas
        Me.Btn_Sitnomas.Location = New System.Drawing.Point(651, 539)
        Me.Btn_Sitnomas.Margin = New System.Windows.Forms.Padding(3, 3, 21, 3)
        Me.Btn_Sitnomas.Name = "Btn_Sitnomas"
        Me.Btn_Sitnomas.ShadowDecoration.Parent = Me.Btn_Sitnomas
        Me.Btn_Sitnomas.Size = New System.Drawing.Size(250, 250)
        Me.Btn_Sitnomas.TabIndex = 1
        '
        'Btn_Pacientes
        '
        Me.Btn_Pacientes.Animated = True
        Me.Btn_Pacientes.BorderRadius = 33
        Me.Btn_Pacientes.CheckedState.Parent = Me.Btn_Pacientes
        Me.Btn_Pacientes.CustomImages.Parent = Me.Btn_Pacientes
        Me.Btn_Pacientes.FillColor = System.Drawing.Color.White
        Me.Btn_Pacientes.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Btn_Pacientes.ForeColor = System.Drawing.Color.White
        Me.Btn_Pacientes.HoverState.Parent = Me.Btn_Pacientes
        Me.Btn_Pacientes.Location = New System.Drawing.Point(651, 222)
        Me.Btn_Pacientes.Margin = New System.Windows.Forms.Padding(3, 3, 27, 3)
        Me.Btn_Pacientes.Name = "Btn_Pacientes"
        Me.Btn_Pacientes.ShadowDecoration.Parent = Me.Btn_Pacientes
        Me.Btn_Pacientes.Size = New System.Drawing.Size(250, 250)
        Me.Btn_Pacientes.TabIndex = 1
        '
        'F_ABM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1920, 1080)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "F_ABM"
        Me.Text = "frmGestionABM"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents LblPacientes As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Btn_Enfermedades As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Btn_Sitnomas As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Btn_Pacientes As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Btn_Minimize As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Btn_Exit As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents BtnCerrarSesion As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents LblEmpleados As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Btn_Empleados As Guna.UI2.WinForms.Guna2Button
End Class
