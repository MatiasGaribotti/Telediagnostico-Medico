<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_Chat
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PnlSide = New Guna.UI2.WinForms.Guna2Panel()
        Me.BtnCerrarSesion = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnFinalizarChat = New Guna.UI2.WinForms.Guna2Button()
        Me.PnlDiagnosticos = New Guna.UI2.WinForms.Guna2Panel()
        Me.DgvDiagnosticos = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.BtnHistorialClinico = New Guna.UI2.WinForms.Guna2Button()
        Me.PnlSintomas = New Guna.UI2.WinForms.Guna2Panel()
        Me.DgvSintomas = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblSintomasRegistrados = New System.Windows.Forms.Label()
        Me.Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.PicAvatar = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Pnl_info_paciente = New Guna.UI2.WinForms.Guna2Panel()
        Me.LblEdadPaciente = New System.Windows.Forms.Label()
        Me.LblNamePaciente = New System.Windows.Forms.Label()
        Me.LblWaiting = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TimerChat = New System.Windows.Forms.Timer(Me.components)
        Me.PnlChat = New Guna.UI2.WinForms.Guna2Panel()
        Me.PicWaiting = New System.Windows.Forms.PictureBox()
        Me.BtnSend = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.TxtMsg = New Guna.UI2.WinForms.Guna2TextBox()
        Me.PnlSide.SuspendLayout()
        Me.PnlDiagnosticos.SuspendLayout()
        CType(Me.DgvDiagnosticos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlSintomas.SuspendLayout()
        CType(Me.DgvSintomas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicAvatar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pnl_info_paciente.SuspendLayout()
        Me.PnlChat.SuspendLayout()
        CType(Me.PicWaiting, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlSide
        '
        Me.PnlSide.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.PnlSide.Controls.Add(Me.BtnCerrarSesion)
        Me.PnlSide.Controls.Add(Me.BtnFinalizarChat)
        Me.PnlSide.Controls.Add(Me.PnlDiagnosticos)
        Me.PnlSide.Controls.Add(Me.BtnHistorialClinico)
        Me.PnlSide.Controls.Add(Me.PnlSintomas)
        Me.PnlSide.Controls.Add(Me.Label1)
        Me.PnlSide.Controls.Add(Me.LblSintomasRegistrados)
        Me.PnlSide.Controls.Add(Me.Separator1)
        Me.PnlSide.Controls.Add(Me.PicAvatar)
        Me.PnlSide.Controls.Add(Me.Pnl_info_paciente)
        Me.PnlSide.Location = New System.Drawing.Point(0, 0)
        Me.PnlSide.Margin = New System.Windows.Forms.Padding(0)
        Me.PnlSide.Name = "PnlSide"
        Me.PnlSide.ShadowDecoration.Parent = Me.PnlSide
        Me.PnlSide.Size = New System.Drawing.Size(480, 1080)
        Me.PnlSide.TabIndex = 0
        '
        'BtnCerrarSesion
        '
        Me.BtnCerrarSesion.Animated = True
        Me.BtnCerrarSesion.AutoRoundedCorners = True
        Me.BtnCerrarSesion.BorderRadius = 17
        Me.BtnCerrarSesion.CheckedState.Parent = Me.BtnCerrarSesion
        Me.BtnCerrarSesion.CustomImages.Parent = Me.BtnCerrarSesion
        Me.BtnCerrarSesion.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.BtnCerrarSesion.Font = New System.Drawing.Font("Roboto", 14.25!)
        Me.BtnCerrarSesion.ForeColor = System.Drawing.Color.White
        Me.BtnCerrarSesion.HoverState.Parent = Me.BtnCerrarSesion
        Me.BtnCerrarSesion.Location = New System.Drawing.Point(155, 1032)
        Me.BtnCerrarSesion.Name = "BtnCerrarSesion"
        Me.BtnCerrarSesion.ShadowDecoration.Parent = Me.BtnCerrarSesion
        Me.BtnCerrarSesion.Size = New System.Drawing.Size(162, 36)
        Me.BtnCerrarSesion.TabIndex = 73
        Me.BtnCerrarSesion.Text = "Cerrar Sesión"
        '
        'BtnFinalizarChat
        '
        Me.BtnFinalizarChat.Animated = True
        Me.BtnFinalizarChat.AutoRoundedCorners = True
        Me.BtnFinalizarChat.BorderRadius = 17
        Me.BtnFinalizarChat.CheckedState.Parent = Me.BtnFinalizarChat
        Me.BtnFinalizarChat.CustomImages.Parent = Me.BtnFinalizarChat
        Me.BtnFinalizarChat.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.BtnFinalizarChat.Font = New System.Drawing.Font("Roboto", 14.25!)
        Me.BtnFinalizarChat.ForeColor = System.Drawing.Color.White
        Me.BtnFinalizarChat.HoverState.Parent = Me.BtnFinalizarChat
        Me.BtnFinalizarChat.Location = New System.Drawing.Point(288, 986)
        Me.BtnFinalizarChat.Name = "BtnFinalizarChat"
        Me.BtnFinalizarChat.ShadowDecoration.Parent = Me.BtnFinalizarChat
        Me.BtnFinalizarChat.Size = New System.Drawing.Size(162, 36)
        Me.BtnFinalizarChat.TabIndex = 72
        Me.BtnFinalizarChat.Text = "Finalizar Chat"
        '
        'PnlDiagnosticos
        '
        Me.PnlDiagnosticos.AutoRoundedCorners = True
        Me.PnlDiagnosticos.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.PnlDiagnosticos.BorderRadius = 175
        Me.PnlDiagnosticos.Controls.Add(Me.DgvDiagnosticos)
        Me.PnlDiagnosticos.Location = New System.Drawing.Point(20, 628)
        Me.PnlDiagnosticos.Name = "PnlDiagnosticos"
        Me.PnlDiagnosticos.ShadowDecoration.Parent = Me.PnlDiagnosticos
        Me.PnlDiagnosticos.Size = New System.Drawing.Size(440, 352)
        Me.PnlDiagnosticos.TabIndex = 5
        '
        'DgvDiagnosticos
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DgvDiagnosticos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvDiagnosticos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvDiagnosticos.BackgroundColor = System.Drawing.Color.White
        Me.DgvDiagnosticos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvDiagnosticos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgvDiagnosticos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvDiagnosticos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgvDiagnosticos.ColumnHeadersHeight = 4
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvDiagnosticos.DefaultCellStyle = DataGridViewCellStyle3
        Me.DgvDiagnosticos.EnableHeadersVisualStyles = False
        Me.DgvDiagnosticos.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvDiagnosticos.Location = New System.Drawing.Point(10, 10)
        Me.DgvDiagnosticos.Margin = New System.Windows.Forms.Padding(10)
        Me.DgvDiagnosticos.Name = "DgvDiagnosticos"
        Me.DgvDiagnosticos.RowHeadersVisible = False
        Me.DgvDiagnosticos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvDiagnosticos.Size = New System.Drawing.Size(420, 332)
        Me.DgvDiagnosticos.TabIndex = 3
        Me.DgvDiagnosticos.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.DgvDiagnosticos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DgvDiagnosticos.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DgvDiagnosticos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DgvDiagnosticos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DgvDiagnosticos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DgvDiagnosticos.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DgvDiagnosticos.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvDiagnosticos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvDiagnosticos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvDiagnosticos.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DgvDiagnosticos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DgvDiagnosticos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DgvDiagnosticos.ThemeStyle.HeaderStyle.Height = 4
        Me.DgvDiagnosticos.ThemeStyle.ReadOnly = False
        Me.DgvDiagnosticos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DgvDiagnosticos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgvDiagnosticos.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DgvDiagnosticos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DgvDiagnosticos.ThemeStyle.RowsStyle.Height = 22
        Me.DgvDiagnosticos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvDiagnosticos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'BtnHistorialClinico
        '
        Me.BtnHistorialClinico.Animated = True
        Me.BtnHistorialClinico.AutoRoundedCorners = True
        Me.BtnHistorialClinico.BorderRadius = 17
        Me.BtnHistorialClinico.CheckedState.Parent = Me.BtnHistorialClinico
        Me.BtnHistorialClinico.CustomImages.Parent = Me.BtnHistorialClinico
        Me.BtnHistorialClinico.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.BtnHistorialClinico.Font = New System.Drawing.Font("Roboto", 14.25!)
        Me.BtnHistorialClinico.ForeColor = System.Drawing.Color.White
        Me.BtnHistorialClinico.HoverState.Parent = Me.BtnHistorialClinico
        Me.BtnHistorialClinico.Location = New System.Drawing.Point(30, 986)
        Me.BtnHistorialClinico.Name = "BtnHistorialClinico"
        Me.BtnHistorialClinico.ShadowDecoration.Parent = Me.BtnHistorialClinico
        Me.BtnHistorialClinico.Size = New System.Drawing.Size(162, 36)
        Me.BtnHistorialClinico.TabIndex = 71
        Me.BtnHistorialClinico.Text = "Historial Clínico"
        '
        'PnlSintomas
        '
        Me.PnlSintomas.AutoRoundedCorners = True
        Me.PnlSintomas.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.PnlSintomas.BorderRadius = 185
        Me.PnlSintomas.Controls.Add(Me.DgvSintomas)
        Me.PnlSintomas.Location = New System.Drawing.Point(20, 216)
        Me.PnlSintomas.Name = "PnlSintomas"
        Me.PnlSintomas.ShadowDecoration.Parent = Me.PnlSintomas
        Me.PnlSintomas.Size = New System.Drawing.Size(440, 372)
        Me.PnlSintomas.TabIndex = 4
        '
        'DgvSintomas
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.DgvSintomas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DgvSintomas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvSintomas.BackgroundColor = System.Drawing.Color.White
        Me.DgvSintomas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvSintomas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgvSintomas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvSintomas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DgvSintomas.ColumnHeadersHeight = 4
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvSintomas.DefaultCellStyle = DataGridViewCellStyle6
        Me.DgvSintomas.EnableHeadersVisualStyles = False
        Me.DgvSintomas.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvSintomas.Location = New System.Drawing.Point(10, 10)
        Me.DgvSintomas.Margin = New System.Windows.Forms.Padding(10)
        Me.DgvSintomas.Name = "DgvSintomas"
        Me.DgvSintomas.RowHeadersVisible = False
        Me.DgvSintomas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvSintomas.Size = New System.Drawing.Size(420, 352)
        Me.DgvSintomas.TabIndex = 3
        Me.DgvSintomas.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.DgvSintomas.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DgvSintomas.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DgvSintomas.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DgvSintomas.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DgvSintomas.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DgvSintomas.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DgvSintomas.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvSintomas.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvSintomas.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvSintomas.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DgvSintomas.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DgvSintomas.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DgvSintomas.ThemeStyle.HeaderStyle.Height = 4
        Me.DgvSintomas.ThemeStyle.ReadOnly = False
        Me.DgvSintomas.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DgvSintomas.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgvSintomas.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DgvSintomas.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DgvSintomas.ThemeStyle.RowsStyle.Height = 22
        Me.DgvSintomas.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvSintomas.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Roboto", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 603)
        Me.Label1.Margin = New System.Windows.Forms.Padding(20, 15, 0, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 23)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Posibles Diagnosticos"
        '
        'LblSintomasRegistrados
        '
        Me.LblSintomasRegistrados.AutoSize = True
        Me.LblSintomasRegistrados.Font = New System.Drawing.Font("Roboto", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSintomasRegistrados.Location = New System.Drawing.Point(20, 188)
        Me.LblSintomasRegistrados.Margin = New System.Windows.Forms.Padding(20, 15, 0, 15)
        Me.LblSintomasRegistrados.Name = "LblSintomasRegistrados"
        Me.LblSintomasRegistrados.Size = New System.Drawing.Size(197, 23)
        Me.LblSintomasRegistrados.TabIndex = 2
        Me.LblSintomasRegistrados.Text = "Síntomas Registrados"
        '
        'Separator1
        '
        Me.Separator1.FillColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.Separator1.FillThickness = 4
        Me.Separator1.Location = New System.Drawing.Point(20, 176)
        Me.Separator1.Margin = New System.Windows.Forms.Padding(20, 3, 20, 3)
        Me.Separator1.Name = "Separator1"
        Me.Separator1.Size = New System.Drawing.Size(440, 10)
        Me.Separator1.TabIndex = 2
        '
        'PicAvatar
        '
        Me.PicAvatar.Image = Global.Presentacion.My.Resources.Resources.male_avatar
        Me.PicAvatar.Location = New System.Drawing.Point(20, 20)
        Me.PicAvatar.Name = "PicAvatar"
        Me.PicAvatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.PicAvatar.ShadowDecoration.Parent = Me.PicAvatar
        Me.PicAvatar.Size = New System.Drawing.Size(150, 150)
        Me.PicAvatar.TabIndex = 0
        Me.PicAvatar.TabStop = False
        '
        'Pnl_info_paciente
        '
        Me.Pnl_info_paciente.AutoRoundedCorners = True
        Me.Pnl_info_paciente.BackColor = System.Drawing.Color.White
        Me.Pnl_info_paciente.BorderRadius = 41
        Me.Pnl_info_paciente.Controls.Add(Me.LblEdadPaciente)
        Me.Pnl_info_paciente.Controls.Add(Me.LblNamePaciente)
        Me.Pnl_info_paciente.Location = New System.Drawing.Point(78, 53)
        Me.Pnl_info_paciente.Name = "Pnl_info_paciente"
        Me.Pnl_info_paciente.ShadowDecoration.Parent = Me.Pnl_info_paciente
        Me.Pnl_info_paciente.Size = New System.Drawing.Size(306, 84)
        Me.Pnl_info_paciente.TabIndex = 1
        '
        'LblEdadPaciente
        '
        Me.LblEdadPaciente.AutoSize = True
        Me.LblEdadPaciente.Font = New System.Drawing.Font("Roboto", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEdadPaciente.Location = New System.Drawing.Point(108, 44)
        Me.LblEdadPaciente.Name = "LblEdadPaciente"
        Me.LblEdadPaciente.Size = New System.Drawing.Size(131, 23)
        Me.LblEdadPaciente.TabIndex = 1
        Me.LblEdadPaciente.Text = "Edad Paciente"
        '
        'LblNamePaciente
        '
        Me.LblNamePaciente.AutoSize = True
        Me.LblNamePaciente.Font = New System.Drawing.Font("Roboto", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNamePaciente.Location = New System.Drawing.Point(108, 14)
        Me.LblNamePaciente.Margin = New System.Windows.Forms.Padding(3, 0, 3, 7)
        Me.LblNamePaciente.Name = "LblNamePaciente"
        Me.LblNamePaciente.Size = New System.Drawing.Size(157, 23)
        Me.LblNamePaciente.TabIndex = 0
        Me.LblNamePaciente.Text = "Nombre Paciente"
        '
        'LblWaiting
        '
        Me.LblWaiting.BackColor = System.Drawing.Color.Transparent
        Me.LblWaiting.Font = New System.Drawing.Font("Roboto", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWaiting.Location = New System.Drawing.Point(238, 320)
        Me.LblWaiting.Name = "LblWaiting"
        Me.LblWaiting.Size = New System.Drawing.Size(726, 40)
        Me.LblWaiting.TabIndex = 3
        Me.LblWaiting.Text = "Por favor aguarde a ser atendido por un médico"
        '
        'TimerChat
        '
        Me.TimerChat.Interval = 1000
        '
        'PnlChat
        '
        Me.PnlChat.Controls.Add(Me.LblWaiting)
        Me.PnlChat.Controls.Add(Me.PicWaiting)
        Me.PnlChat.FillColor = System.Drawing.Color.White
        Me.PnlChat.Location = New System.Drawing.Point(480, 0)
        Me.PnlChat.Name = "PnlChat"
        Me.PnlChat.ShadowDecoration.Parent = Me.PnlChat
        Me.PnlChat.Size = New System.Drawing.Size(1440, 980)
        Me.PnlChat.TabIndex = 5
        '
        'PicWaiting
        '
        Me.PicWaiting.BackColor = System.Drawing.Color.Transparent
        Me.PicWaiting.Image = Global.Presentacion.My.Resources.Resources.waiting_gif
        Me.PicWaiting.Location = New System.Drawing.Point(495, 388)
        Me.PicWaiting.Name = "PicWaiting"
        Me.PicWaiting.Size = New System.Drawing.Size(200, 200)
        Me.PicWaiting.TabIndex = 4
        Me.PicWaiting.TabStop = False
        '
        'BtnSend
        '
        Me.BtnSend.BackColor = System.Drawing.Color.Transparent
        Me.BtnSend.CheckedState.Parent = Me.BtnSend
        Me.BtnSend.CustomImages.Parent = Me.BtnSend
        Me.BtnSend.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.BtnSend.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnSend.ForeColor = System.Drawing.Color.White
        Me.BtnSend.HoverState.Parent = Me.BtnSend
        Me.BtnSend.Image = Global.Presentacion.My.Resources.Resources.send_icon
        Me.BtnSend.ImageOffset = New System.Drawing.Point(2, 0)
        Me.BtnSend.ImageSize = New System.Drawing.Size(38, 34)
        Me.BtnSend.Location = New System.Drawing.Point(1823, 986)
        Me.BtnSend.Margin = New System.Windows.Forms.Padding(3, 25, 3, 25)
        Me.BtnSend.Name = "BtnSend"
        Me.BtnSend.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.BtnSend.ShadowDecoration.Parent = Me.BtnSend
        Me.BtnSend.Size = New System.Drawing.Size(70, 70)
        Me.BtnSend.TabIndex = 7
        '
        'TxtMsg
        '
        Me.TxtMsg.Animated = True
        Me.TxtMsg.AutoRoundedCorners = True
        Me.TxtMsg.BackColor = System.Drawing.Color.Transparent
        Me.TxtMsg.BorderRadius = 34
        Me.TxtMsg.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtMsg.DefaultText = ""
        Me.TxtMsg.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtMsg.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtMsg.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtMsg.DisabledState.Parent = Me.TxtMsg
        Me.TxtMsg.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtMsg.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtMsg.FocusedState.Parent = Me.TxtMsg
        Me.TxtMsg.Font = New System.Drawing.Font("Roboto", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMsg.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtMsg.HoverState.Parent = Me.TxtMsg
        Me.TxtMsg.Location = New System.Drawing.Point(500, 986)
        Me.TxtMsg.Margin = New System.Windows.Forms.Padding(20, 15, 20, 15)
        Me.TxtMsg.Name = "TxtMsg"
        Me.TxtMsg.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtMsg.PlaceholderText = ""
        Me.TxtMsg.SelectedText = ""
        Me.TxtMsg.ShadowDecoration.Parent = Me.TxtMsg
        Me.TxtMsg.Size = New System.Drawing.Size(1300, 70)
        Me.TxtMsg.TabIndex = 6
        '
        'F_Chat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1920, 1080)
        Me.Controls.Add(Me.BtnSend)
        Me.Controls.Add(Me.TxtMsg)
        Me.Controls.Add(Me.PnlSide)
        Me.Controls.Add(Me.PnlChat)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "F_Chat"
        Me.Text = "F_Main"
        Me.PnlSide.ResumeLayout(False)
        Me.PnlSide.PerformLayout()
        Me.PnlDiagnosticos.ResumeLayout(False)
        CType(Me.DgvDiagnosticos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlSintomas.ResumeLayout(False)
        CType(Me.DgvSintomas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicAvatar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pnl_info_paciente.ResumeLayout(False)
        Me.Pnl_info_paciente.PerformLayout()
        Me.PnlChat.ResumeLayout(False)
        Me.PnlChat.PerformLayout()
        CType(Me.PicWaiting, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlSide As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Pnl_info_paciente As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents PicAvatar As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents PnlSintomas As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents DgvSintomas As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents LblSintomasRegistrados As Label
    Friend WithEvents Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents LblEdadPaciente As Label
    Friend WithEvents LblNamePaciente As Label
    Friend WithEvents BtnCerrarSesion As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnFinalizarChat As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PnlDiagnosticos As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents DgvDiagnosticos As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents BtnHistorialClinico As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents LblWaiting As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TimerChat As Timer
    Friend WithEvents PnlChat As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents PicWaiting As PictureBox
    Friend WithEvents BtnSend As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents TxtMsg As Guna.UI2.WinForms.Guna2TextBox
End Class
