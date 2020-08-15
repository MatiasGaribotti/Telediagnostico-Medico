<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F_Login
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
        Me.pnl_login = New System.Windows.Forms.Panel()
        Me.lbl_Paciente = New System.Windows.Forms.Label()
        Me.lbl_password = New System.Windows.Forms.Label()
        Me.lbl_ci = New System.Windows.Forms.Label()
        Me.pic_ = New System.Windows.Forms.PictureBox()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pic_background = New System.Windows.Forms.PictureBox()
        Me.TxtCi = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.pnl_login.SuspendLayout()
        CType(Me.pic_, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_background, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl_login
        '
        Me.pnl_login.Controls.Add(Me.TxtPassword)
        Me.pnl_login.Controls.Add(Me.TxtCi)
        Me.pnl_login.Controls.Add(Me.lbl_Paciente)
        Me.pnl_login.Controls.Add(Me.lbl_password)
        Me.pnl_login.Controls.Add(Me.lbl_ci)
        Me.pnl_login.Controls.Add(Me.pic_)
        Me.pnl_login.Controls.Add(Me.btnIngresar)
        Me.pnl_login.Controls.Add(Me.Button1)
        Me.pnl_login.Location = New System.Drawing.Point(0, 0)
        Me.pnl_login.Name = "pnl_login"
        Me.pnl_login.Size = New System.Drawing.Size(500, 1080)
        Me.pnl_login.TabIndex = 0
        '
        'lbl_Paciente
        '
        Me.lbl_Paciente.AutoSize = True
        Me.lbl_Paciente.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Paciente.Location = New System.Drawing.Point(3, 1055)
        Me.lbl_Paciente.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_Paciente.Name = "lbl_Paciente"
        Me.lbl_Paciente.Size = New System.Drawing.Size(67, 21)
        Me.lbl_Paciente.TabIndex = 3
        Me.lbl_Paciente.Text = "Paciente"
        '
        'lbl_password
        '
        Me.lbl_password.AutoSize = True
        Me.lbl_password.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_password.Location = New System.Drawing.Point(20, 627)
        Me.lbl_password.Name = "lbl_password"
        Me.lbl_password.Size = New System.Drawing.Size(135, 32)
        Me.lbl_password.TabIndex = 3
        Me.lbl_password.Text = "Contraseña"
        '
        'lbl_ci
        '
        Me.lbl_ci.AutoSize = True
        Me.lbl_ci.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ci.Location = New System.Drawing.Point(20, 574)
        Me.lbl_ci.Name = "lbl_ci"
        Me.lbl_ci.Size = New System.Drawing.Size(36, 32)
        Me.lbl_ci.TabIndex = 3
        Me.lbl_ci.Text = "CI"
        '
        'pic_
        '
        Me.pic_.Location = New System.Drawing.Point(101, 220)
        Me.pic_.Name = "pic_"
        Me.pic_.Size = New System.Drawing.Size(300, 300)
        Me.pic_.TabIndex = 1
        Me.pic_.TabStop = False
        '
        'btnIngresar
        '
        Me.btnIngresar.BackColor = System.Drawing.Color.Transparent
        Me.btnIngresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnIngresar.FlatAppearance.BorderSize = 0
        Me.btnIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIngresar.Image = Global.Presentacion.My.Resources.Resources.Ingresar_Button
        Me.btnIngresar.Location = New System.Drawing.Point(170, 700)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(162, 54)
        Me.btnIngresar.TabIndex = 0
        Me.btnIngresar.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.Presentacion.My.Resources.Resources.es_icon
        Me.Button1.Location = New System.Drawing.Point(7, 7)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(54, 45)
        Me.Button1.TabIndex = 0
        Me.Button1.UseVisualStyleBackColor = False
        '
        'pic_background
        '
        Me.pic_background.Image = Global.Presentacion.My.Resources.Resources.background
        Me.pic_background.Location = New System.Drawing.Point(499, 0)
        Me.pic_background.Margin = New System.Windows.Forms.Padding(0)
        Me.pic_background.Name = "pic_background"
        Me.pic_background.Size = New System.Drawing.Size(1420, 1080)
        Me.pic_background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_background.TabIndex = 1
        Me.pic_background.TabStop = False
        '
        'TxtCi
        '
        Me.TxtCi.Animated = True
        Me.TxtCi.BorderRadius = 16
        Me.TxtCi.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtCi.DefaultText = ""
        Me.TxtCi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtCi.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtCi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtCi.DisabledState.Parent = Me.TxtCi
        Me.TxtCi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtCi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtCi.FocusedState.Parent = Me.TxtCi
        Me.TxtCi.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtCi.HoverState.Parent = Me.TxtCi
        Me.TxtCi.Location = New System.Drawing.Point(201, 574)
        Me.TxtCi.Name = "TxtCi"
        Me.TxtCi.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtCi.PlaceholderText = ""
        Me.TxtCi.SelectedText = ""
        Me.TxtCi.ShadowDecoration.Parent = Me.TxtCi
        Me.TxtCi.Size = New System.Drawing.Size(200, 36)
        Me.TxtCi.TabIndex = 11
        '
        'TxtPassword
        '
        Me.TxtPassword.Animated = True
        Me.TxtPassword.BorderRadius = 16
        Me.TxtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtPassword.DefaultText = ""
        Me.TxtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtPassword.DisabledState.Parent = Me.TxtPassword
        Me.TxtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtPassword.FocusedState.Parent = Me.TxtPassword
        Me.TxtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtPassword.HoverState.Parent = Me.TxtPassword
        Me.TxtPassword.Location = New System.Drawing.Point(201, 627)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtPassword.PlaceholderText = ""
        Me.TxtPassword.SelectedText = ""
        Me.TxtPassword.ShadowDecoration.Parent = Me.TxtPassword
        Me.TxtPassword.Size = New System.Drawing.Size(200, 36)
        Me.TxtPassword.TabIndex = 12
        '
        'F_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1920, 1080)
        Me.Controls.Add(Me.pic_background)
        Me.Controls.Add(Me.pnl_login)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "F_Login"
        Me.Text = "Login"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnl_login.ResumeLayout(False)
        Me.pnl_login.PerformLayout()
        CType(Me.pic_, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_background, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnl_login As Panel
    Friend WithEvents pic_background As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents lbl_password As Label
    Friend WithEvents lbl_ci As Label
    Friend WithEvents pic_ As PictureBox
    Friend WithEvents btnIngresar As Button
    Friend WithEvents lbl_Paciente As Label
    Friend WithEvents TxtPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtCi As Guna.UI2.WinForms.Guna2TextBox
End Class
