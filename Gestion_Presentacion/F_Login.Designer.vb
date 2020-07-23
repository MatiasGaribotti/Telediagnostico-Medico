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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_Login))
        Me.pic_background = New System.Windows.Forms.PictureBox()
        Me.Pnl_Login = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Pic_Login = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Lbl_password = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Lbl_ci = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Btn_Ingresar = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2TextBox2 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Txt_Ci = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Btn_Exit = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Btn_Minimize = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        CType(Me.pic_background, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pnl_Login.SuspendLayout()
        CType(Me.Pic_Login, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pic_background
        '
        resources.ApplyResources(Me.pic_background, "pic_background")
        Me.pic_background.Image = Global.Presentacion.My.Resources.Resources.background
        Me.pic_background.Name = "pic_background"
        Me.pic_background.TabStop = False
        '
        'Pnl_Login
        '
        resources.ApplyResources(Me.Pnl_Login, "Pnl_Login")
        Me.Pnl_Login.Controls.Add(Me.Guna2Button2)
        Me.Pnl_Login.Controls.Add(Me.Pic_Login)
        Me.Pnl_Login.Controls.Add(Me.Lbl_password)
        Me.Pnl_Login.Controls.Add(Me.Lbl_ci)
        Me.Pnl_Login.Controls.Add(Me.Btn_Ingresar)
        Me.Pnl_Login.Controls.Add(Me.Guna2TextBox2)
        Me.Pnl_Login.Controls.Add(Me.Txt_Ci)
        Me.Pnl_Login.FillColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Pnl_Login.Name = "Pnl_Login"
        Me.Pnl_Login.ShadowDecoration.Parent = Me.Pnl_Login
        '
        'Guna2Button2
        '
        resources.ApplyResources(Me.Guna2Button2, "Guna2Button2")
        Me.Guna2Button2.Animated = True
        Me.Guna2Button2.AutoRoundedCorners = True
        Me.Guna2Button2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button2.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2Button2.BorderRadius = 16
        Me.Guna2Button2.CheckedState.Parent = Me.Guna2Button2
        Me.Guna2Button2.CustomImages.Parent = Me.Guna2Button2
        Me.Guna2Button2.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button2.ForeColor = System.Drawing.Color.White
        Me.Guna2Button2.HoverState.Parent = Me.Guna2Button2
        Me.Guna2Button2.Image = CType(resources.GetObject("Guna2Button2.Image"), System.Drawing.Image)
        Me.Guna2Button2.ImageSize = New System.Drawing.Size(64, 45)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.ShadowDecoration.Parent = Me.Guna2Button2
        Me.Guna2Button2.UseTransparentBackground = True
        '
        'Pic_Login
        '
        resources.ApplyResources(Me.Pic_Login, "Pic_Login")
        Me.Pic_Login.BorderRadius = 33
        Me.Pic_Login.Image = Global.Presentacion.My.Resources.Resources.background
        Me.Pic_Login.Name = "Pic_Login"
        Me.Pic_Login.ShadowDecoration.Parent = Me.Pic_Login
        Me.Pic_Login.TabStop = False
        '
        'Lbl_password
        '
        resources.ApplyResources(Me.Lbl_password, "Lbl_password")
        Me.Lbl_password.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_password.Name = "Lbl_password"
        '
        'Lbl_ci
        '
        resources.ApplyResources(Me.Lbl_ci, "Lbl_ci")
        Me.Lbl_ci.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_ci.Name = "Lbl_ci"
        '
        'Btn_Ingresar
        '
        resources.ApplyResources(Me.Btn_Ingresar, "Btn_Ingresar")
        Me.Btn_Ingresar.Animated = True
        Me.Btn_Ingresar.AutoRoundedCorners = True
        Me.Btn_Ingresar.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Ingresar.BorderRadius = 22
        Me.Btn_Ingresar.CheckedState.Parent = Me.Btn_Ingresar
        Me.Btn_Ingresar.CustomImages.Parent = Me.Btn_Ingresar
        Me.Btn_Ingresar.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Btn_Ingresar.ForeColor = System.Drawing.Color.White
        Me.Btn_Ingresar.HoverState.Parent = Me.Btn_Ingresar
        Me.Btn_Ingresar.Name = "Btn_Ingresar"
        Me.Btn_Ingresar.ShadowDecoration.Parent = Me.Btn_Ingresar
        Me.Btn_Ingresar.UseTransparentBackground = True
        '
        'Guna2TextBox2
        '
        resources.ApplyResources(Me.Guna2TextBox2, "Guna2TextBox2")
        Me.Guna2TextBox2.Animated = True
        Me.Guna2TextBox2.BorderRadius = 16
        Me.Guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox2.DefaultText = ""
        Me.Guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.Parent = Me.Guna2TextBox2
        Me.Guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox2.FocusedState.Parent = Me.Guna2TextBox2
        Me.Guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox2.HoverState.Parent = Me.Guna2TextBox2
        Me.Guna2TextBox2.Name = "Guna2TextBox2"
        Me.Guna2TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox2.PlaceholderText = ""
        Me.Guna2TextBox2.SelectedText = ""
        Me.Guna2TextBox2.ShadowDecoration.Parent = Me.Guna2TextBox2
        '
        'Txt_Ci
        '
        resources.ApplyResources(Me.Txt_Ci, "Txt_Ci")
        Me.Txt_Ci.Animated = True
        Me.Txt_Ci.BorderRadius = 16
        Me.Txt_Ci.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_Ci.DefaultText = ""
        Me.Txt_Ci.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Txt_Ci.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Txt_Ci.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Txt_Ci.DisabledState.Parent = Me.Txt_Ci
        Me.Txt_Ci.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Txt_Ci.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Txt_Ci.FocusedState.Parent = Me.Txt_Ci
        Me.Txt_Ci.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Txt_Ci.HoverState.Parent = Me.Txt_Ci
        Me.Txt_Ci.Name = "Txt_Ci"
        Me.Txt_Ci.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Txt_Ci.PlaceholderText = ""
        Me.Txt_Ci.SelectedText = ""
        Me.Txt_Ci.ShadowDecoration.Parent = Me.Txt_Ci
        '
        'Btn_Exit
        '
        resources.ApplyResources(Me.Btn_Exit, "Btn_Exit")
        Me.Btn_Exit.Animated = True
        Me.Btn_Exit.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Btn_Exit.HoverState.Parent = Me.Btn_Exit
        Me.Btn_Exit.IconColor = System.Drawing.Color.White
        Me.Btn_Exit.Name = "Btn_Exit"
        Me.Btn_Exit.ShadowDecoration.Parent = Me.Btn_Exit
        '
        'Btn_Minimize
        '
        resources.ApplyResources(Me.Btn_Minimize, "Btn_Minimize")
        Me.Btn_Minimize.Animated = True
        Me.Btn_Minimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Btn_Minimize.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Btn_Minimize.HoverState.Parent = Me.Btn_Minimize
        Me.Btn_Minimize.IconColor = System.Drawing.Color.White
        Me.Btn_Minimize.Name = "Btn_Minimize"
        Me.Btn_Minimize.ShadowDecoration.Parent = Me.Btn_Minimize
        '
        'F_Login
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Controls.Add(Me.Btn_Minimize)
        Me.Controls.Add(Me.Btn_Exit)
        Me.Controls.Add(Me.Pnl_Login)
        Me.Controls.Add(Me.pic_background)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "F_Login"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.pic_background, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pnl_Login.ResumeLayout(False)
        Me.Pnl_Login.PerformLayout()
        CType(Me.Pic_Login, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pic_background As PictureBox
    Friend WithEvents Pnl_Login As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Pic_Login As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Lbl_password As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Lbl_ci As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Btn_Ingresar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2TextBox2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Txt_Ci As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Btn_Exit As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Btn_Minimize As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
End Class
