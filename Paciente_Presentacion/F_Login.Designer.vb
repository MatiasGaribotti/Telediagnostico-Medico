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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_Login))
        Me.pic_background = New System.Windows.Forms.PictureBox()
        Me.Btn_Minimize = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Btn_Exit = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.PnlLogin = New Guna.UI2.WinForms.Guna2Panel()
        Me.Btn_Ingresar = New Guna.UI2.WinForms.Guna2Button()
        Me.PicLogin = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TxtPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtCi = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BtnChangeLang = New System.Windows.Forms.Button()
        CType(Me.pic_background, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlLogin.SuspendLayout()
        CType(Me.PicLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Btn_Minimize.TabIndex = 10
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
        Me.Btn_Exit.TabIndex = 9
        '
        'PnlLogin
        '
        Me.PnlLogin.Controls.Add(Me.Btn_Ingresar)
        Me.PnlLogin.Controls.Add(Me.PicLogin)
        Me.PnlLogin.Controls.Add(Me.Guna2HtmlLabel3)
        Me.PnlLogin.Controls.Add(Me.Guna2HtmlLabel2)
        Me.PnlLogin.Controls.Add(Me.Guna2HtmlLabel1)
        Me.PnlLogin.Controls.Add(Me.TxtPassword)
        Me.PnlLogin.Controls.Add(Me.TxtCi)
        Me.PnlLogin.Controls.Add(Me.BtnChangeLang)
        Me.PnlLogin.FillColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.PnlLogin.Location = New System.Drawing.Point(0, 0)
        Me.PnlLogin.Margin = New System.Windows.Forms.Padding(0)
        Me.PnlLogin.Name = "PnlLogin"
        Me.PnlLogin.ShadowDecoration.Parent = Me.PnlLogin
        Me.PnlLogin.Size = New System.Drawing.Size(500, 1080)
        Me.PnlLogin.TabIndex = 11
        '
        'Btn_Ingresar
        '
        Me.Btn_Ingresar.Animated = True
        Me.Btn_Ingresar.AutoRoundedCorners = True
        Me.Btn_Ingresar.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Ingresar.BorderRadius = 22
        Me.Btn_Ingresar.CheckedState.Parent = Me.Btn_Ingresar
        Me.Btn_Ingresar.CustomImages.Parent = Me.Btn_Ingresar
        Me.Btn_Ingresar.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Btn_Ingresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Btn_Ingresar.ForeColor = System.Drawing.Color.White
        Me.Btn_Ingresar.HoverState.Parent = Me.Btn_Ingresar
        Me.Btn_Ingresar.Location = New System.Drawing.Point(202, 743)
        Me.Btn_Ingresar.Name = "Btn_Ingresar"
        Me.Btn_Ingresar.ShadowDecoration.Parent = Me.Btn_Ingresar
        Me.Btn_Ingresar.Size = New System.Drawing.Size(154, 46)
        Me.Btn_Ingresar.TabIndex = 23
        Me.Btn_Ingresar.Text = "ingresar"
        Me.Btn_Ingresar.UseTransparentBackground = True
        '
        'PicLogin
        '
        Me.PicLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PicLogin.BorderRadius = 33
        Me.PicLogin.Image = Global.Presentacion.My.Resources.Resources.Kartoffel_Solutions_Logo
        Me.PicLogin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PicLogin.InitialImage = Global.Presentacion.My.Resources.Resources.Kartoffel_Solutions_Logo
        Me.PicLogin.Location = New System.Drawing.Point(128, 271)
        Me.PicLogin.Name = "PicLogin"
        Me.PicLogin.ShadowDecoration.Parent = Me.PicLogin
        Me.PicLogin.Size = New System.Drawing.Size(300, 300)
        Me.PicLogin.TabIndex = 22
        Me.PicLogin.TabStop = False
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(3, 1049)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(83, 27)
        Me.Guna2HtmlLabel3.TabIndex = 21
        Me.Guna2HtmlLabel3.Text = "paciente"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Roboto", 16.0!)
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(128, 685)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(120, 27)
        Me.Guna2HtmlLabel2.TabIndex = 20
        Me.Guna2HtmlLabel2.Text = "contrasenna"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(128, 632)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(19, 27)
        Me.Guna2HtmlLabel1.TabIndex = 19
        Me.Guna2HtmlLabel1.Text = "ci"
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
        Me.TxtPassword.Location = New System.Drawing.Point(241, 680)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPassword.PlaceholderText = ""
        Me.TxtPassword.SelectedText = ""
        Me.TxtPassword.ShadowDecoration.Parent = Me.TxtPassword
        Me.TxtPassword.Size = New System.Drawing.Size(200, 36)
        Me.TxtPassword.TabIndex = 18
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
        Me.TxtCi.Location = New System.Drawing.Point(241, 627)
        Me.TxtCi.Name = "TxtCi"
        Me.TxtCi.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtCi.PlaceholderText = ""
        Me.TxtCi.SelectedText = ""
        Me.TxtCi.ShadowDecoration.Parent = Me.TxtCi
        Me.TxtCi.Size = New System.Drawing.Size(200, 36)
        Me.TxtCi.TabIndex = 17
        '
        'BtnChangeLang
        '
        Me.BtnChangeLang.BackColor = System.Drawing.Color.Transparent
        Me.BtnChangeLang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnChangeLang.FlatAppearance.BorderSize = 0
        Me.BtnChangeLang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnChangeLang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnChangeLang.Image = CType(resources.GetObject("BtnChangeLang.Image"), System.Drawing.Image)
        Me.BtnChangeLang.Location = New System.Drawing.Point(7, 3)
        Me.BtnChangeLang.Name = "BtnChangeLang"
        Me.BtnChangeLang.Size = New System.Drawing.Size(64, 34)
        Me.BtnChangeLang.TabIndex = 0
        Me.BtnChangeLang.UseVisualStyleBackColor = False
        '
        'F_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1920, 1080)
        Me.Controls.Add(Me.PnlLogin)
        Me.Controls.Add(Me.Btn_Minimize)
        Me.Controls.Add(Me.Btn_Exit)
        Me.Controls.Add(Me.pic_background)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "F_Login"
        Me.Text = "Login"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.pic_background, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlLogin.ResumeLayout(False)
        Me.PnlLogin.PerformLayout()
        CType(Me.PicLogin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pic_background As PictureBox
    Friend WithEvents Btn_Minimize As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Btn_Exit As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents PnlLogin As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Btn_Ingresar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PicLogin As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TxtPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtCi As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BtnChangeLang As Button
End Class
