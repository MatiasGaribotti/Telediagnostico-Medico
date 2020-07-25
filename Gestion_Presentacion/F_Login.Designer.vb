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
        Me.PicBackground = New System.Windows.Forms.PictureBox()
        Me.Pnl_Login = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.PicLogin = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.LblPassword = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.LblCi = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Btn_Ingresar = New Guna.UI2.WinForms.Guna2Button()
        Me.TxtPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtCi = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BtnExit = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.BtnMinimize = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        CType(Me.PicBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pnl_Login.SuspendLayout()
        CType(Me.PicLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PicBackground
        '
        resources.ApplyResources(Me.PicBackground, "PicBackground")
        Me.PicBackground.Image = Global.Presentacion.My.Resources.Resources.background
        Me.PicBackground.Name = "PicBackground"
        Me.PicBackground.TabStop = False
        '
        'Pnl_Login
        '
        resources.ApplyResources(Me.Pnl_Login, "Pnl_Login")
        Me.Pnl_Login.Controls.Add(Me.Guna2Button2)
        Me.Pnl_Login.Controls.Add(Me.PicLogin)
        Me.Pnl_Login.Controls.Add(Me.LblPassword)
        Me.Pnl_Login.Controls.Add(Me.LblCi)
        Me.Pnl_Login.Controls.Add(Me.Btn_Ingresar)
        Me.Pnl_Login.Controls.Add(Me.TxtPassword)
        Me.Pnl_Login.Controls.Add(Me.TxtCi)
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
        'PicLogin
        '
        resources.ApplyResources(Me.PicLogin, "PicLogin")
        Me.PicLogin.BorderRadius = 33
        Me.PicLogin.Image = Global.Presentacion.My.Resources.Resources.background
        Me.PicLogin.Name = "PicLogin"
        Me.PicLogin.ShadowDecoration.Parent = Me.PicLogin
        Me.PicLogin.TabStop = False
        '
        'LblPassword
        '
        resources.ApplyResources(Me.LblPassword, "LblPassword")
        Me.LblPassword.BackColor = System.Drawing.Color.Transparent
        Me.LblPassword.Name = "LblPassword"
        '
        'LblCi
        '
        resources.ApplyResources(Me.LblCi, "LblCi")
        Me.LblCi.BackColor = System.Drawing.Color.Transparent
        Me.LblCi.Name = "LblCi"
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
        'TxtPassword
        '
        resources.ApplyResources(Me.TxtPassword, "TxtPassword")
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
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPassword.PlaceholderText = ""
        Me.TxtPassword.SelectedText = ""
        Me.TxtPassword.ShadowDecoration.Parent = Me.TxtPassword
        '
        'TxtCi
        '
        resources.ApplyResources(Me.TxtCi, "TxtCi")
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
        Me.TxtCi.Name = "TxtCi"
        Me.TxtCi.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtCi.PlaceholderText = ""
        Me.TxtCi.SelectedText = ""
        Me.TxtCi.ShadowDecoration.Parent = Me.TxtCi
        '
        'BtnExit
        '
        resources.ApplyResources(Me.BtnExit, "BtnExit")
        Me.BtnExit.Animated = True
        Me.BtnExit.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.BtnExit.HoverState.Parent = Me.BtnExit
        Me.BtnExit.IconColor = System.Drawing.Color.White
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.ShadowDecoration.Parent = Me.BtnExit
        '
        'BtnMinimize
        '
        resources.ApplyResources(Me.BtnMinimize, "BtnMinimize")
        Me.BtnMinimize.Animated = True
        Me.BtnMinimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.BtnMinimize.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.BtnMinimize.HoverState.Parent = Me.BtnMinimize
        Me.BtnMinimize.IconColor = System.Drawing.Color.White
        Me.BtnMinimize.Name = "BtnMinimize"
        Me.BtnMinimize.ShadowDecoration.Parent = Me.BtnMinimize
        '
        'F_Login
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Controls.Add(Me.BtnMinimize)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.Pnl_Login)
        Me.Controls.Add(Me.PicBackground)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "F_Login"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PicBackground, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pnl_Login.ResumeLayout(False)
        Me.Pnl_Login.PerformLayout()
        CType(Me.PicLogin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PicBackground As PictureBox
    Friend WithEvents Pnl_Login As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PicLogin As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents LblPassword As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents LblCi As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Btn_Ingresar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TxtPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtCi As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BtnExit As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents BtnMinimize As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
End Class
