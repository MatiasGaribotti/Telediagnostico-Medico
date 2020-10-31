<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F_Main
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.BtnCerrarSesion = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnFinalizarChat = New Guna.UI2.WinForms.Guna2Button()
        Me.PnlDiagnosticos = New Guna.UI2.WinForms.Guna2Panel()
        Me.DgvDiagnosticos = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.urgencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cronica = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnHistorialClinico = New Guna.UI2.WinForms.Guna2Button()
        Me.PnlSintomas = New Guna.UI2.WinForms.Guna2Panel()
        Me.DgvSintomas = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.idSintoma = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombreSintoma = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descipcionSintoma = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipoSintoma = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblSintomasRegistrados = New System.Windows.Forms.Label()
        Me.Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.PicAvatar = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Pnl_info_paciente = New Guna.UI2.WinForms.Guna2Panel()
        Me.LblEdadPaciente = New System.Windows.Forms.Label()
        Me.LblNamePaciente = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabSolicitudesChats = New System.Windows.Forms.TabPage()
        Me.DgvChats = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Btn_Minimize = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Btn_Exit = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.TimerMensajes = New System.Windows.Forms.Timer(Me.components)
        Me.TimerSolicitudes = New System.Windows.Forms.Timer(Me.components)
        Me.TimerChatStatus = New System.Windows.Forms.Timer(Me.components)
        Me.Guna2Panel1.SuspendLayout()
        Me.PnlDiagnosticos.SuspendLayout()
        CType(Me.DgvDiagnosticos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlSintomas.SuspendLayout()
        CType(Me.DgvSintomas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicAvatar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pnl_info_paciente.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabSolicitudesChats.SuspendLayout()
        CType(Me.DgvChats, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Guna2Panel1.Controls.Add(Me.BtnCerrarSesion)
        Me.Guna2Panel1.Controls.Add(Me.BtnFinalizarChat)
        Me.Guna2Panel1.Controls.Add(Me.PnlDiagnosticos)
        Me.Guna2Panel1.Controls.Add(Me.BtnHistorialClinico)
        Me.Guna2Panel1.Controls.Add(Me.PnlSintomas)
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.Controls.Add(Me.LblSintomasRegistrados)
        Me.Guna2Panel1.Controls.Add(Me.Separator1)
        Me.Guna2Panel1.Controls.Add(Me.PicAvatar)
        Me.Guna2Panel1.Controls.Add(Me.Pnl_info_paciente)
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(480, 1080)
        Me.Guna2Panel1.TabIndex = 0
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
        Me.BtnCerrarSesion.Text = "cerrar_sesion"
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
        Me.BtnFinalizarChat.Text = "finalizar_chat"
        '
        'PnlDiagnosticos
        '
        Me.PnlDiagnosticos.BorderRadius = 10
        Me.PnlDiagnosticos.Controls.Add(Me.DgvDiagnosticos)
        Me.PnlDiagnosticos.FillColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.PnlDiagnosticos.Location = New System.Drawing.Point(20, 628)
        Me.PnlDiagnosticos.Name = "PnlDiagnosticos"
        Me.PnlDiagnosticos.ShadowDecoration.Parent = Me.PnlDiagnosticos
        Me.PnlDiagnosticos.Size = New System.Drawing.Size(440, 352)
        Me.PnlDiagnosticos.TabIndex = 5
        '
        'DgvDiagnosticos
        '
        Me.DgvDiagnosticos.AllowUserToAddRows = False
        Me.DgvDiagnosticos.AllowUserToDeleteRows = False
        Me.DgvDiagnosticos.AllowUserToResizeColumns = False
        Me.DgvDiagnosticos.AllowUserToResizeRows = False
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
        Me.DgvDiagnosticos.ColumnHeadersVisible = False
        Me.DgvDiagnosticos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.nombre, Me.descripcion, Me.urgencia, Me.cronica})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Roboto", 15.75!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(245, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvDiagnosticos.DefaultCellStyle = DataGridViewCellStyle3
        Me.DgvDiagnosticos.EnableHeadersVisualStyles = False
        Me.DgvDiagnosticos.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvDiagnosticos.Location = New System.Drawing.Point(10, 10)
        Me.DgvDiagnosticos.Margin = New System.Windows.Forms.Padding(10)
        Me.DgvDiagnosticos.Name = "DgvDiagnosticos"
        Me.DgvDiagnosticos.ReadOnly = True
        Me.DgvDiagnosticos.RowHeadersVisible = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DgvDiagnosticos.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DgvDiagnosticos.RowTemplate.Height = 50
        Me.DgvDiagnosticos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvDiagnosticos.Size = New System.Drawing.Size(420, 332)
        Me.DgvDiagnosticos.TabIndex = 75
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
        Me.DgvDiagnosticos.ThemeStyle.ReadOnly = True
        Me.DgvDiagnosticos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DgvDiagnosticos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgvDiagnosticos.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Roboto", 15.75!)
        Me.DgvDiagnosticos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.DgvDiagnosticos.ThemeStyle.RowsStyle.Height = 50
        Me.DgvDiagnosticos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.DgvDiagnosticos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'id
        '
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        '
        'nombre
        '
        Me.nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.nombre.FillWeight = 197.0!
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        Me.nombre.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'descripcion
        '
        Me.descripcion.HeaderText = "descripcion"
        Me.descripcion.Name = "descripcion"
        Me.descripcion.ReadOnly = True
        Me.descripcion.Visible = False
        '
        'urgencia
        '
        Me.urgencia.HeaderText = "urgencia"
        Me.urgencia.Name = "urgencia"
        Me.urgencia.ReadOnly = True
        Me.urgencia.Visible = False
        '
        'cronica
        '
        Me.cronica.HeaderText = "cronica"
        Me.cronica.Name = "cronica"
        Me.cronica.ReadOnly = True
        Me.cronica.Visible = False
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
        Me.BtnHistorialClinico.Text = "historial_clinico"
        '
        'PnlSintomas
        '
        Me.PnlSintomas.BorderRadius = 10
        Me.PnlSintomas.Controls.Add(Me.DgvSintomas)
        Me.PnlSintomas.FillColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.PnlSintomas.Location = New System.Drawing.Point(20, 216)
        Me.PnlSintomas.Name = "PnlSintomas"
        Me.PnlSintomas.ShadowDecoration.Parent = Me.PnlSintomas
        Me.PnlSintomas.Size = New System.Drawing.Size(440, 372)
        Me.PnlSintomas.TabIndex = 4
        '
        'DgvSintomas
        '
        Me.DgvSintomas.AllowUserToAddRows = False
        Me.DgvSintomas.AllowUserToDeleteRows = False
        Me.DgvSintomas.AllowUserToResizeColumns = False
        Me.DgvSintomas.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        Me.DgvSintomas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DgvSintomas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvSintomas.BackgroundColor = System.Drawing.Color.White
        Me.DgvSintomas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvSintomas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgvSintomas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvSintomas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DgvSintomas.ColumnHeadersHeight = 4
        Me.DgvSintomas.ColumnHeadersVisible = False
        Me.DgvSintomas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idSintoma, Me.nombreSintoma, Me.descipcionSintoma, Me.tipoSintoma})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Roboto", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(245, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvSintomas.DefaultCellStyle = DataGridViewCellStyle7
        Me.DgvSintomas.EnableHeadersVisualStyles = False
        Me.DgvSintomas.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvSintomas.Location = New System.Drawing.Point(10, 10)
        Me.DgvSintomas.Margin = New System.Windows.Forms.Padding(10)
        Me.DgvSintomas.Name = "DgvSintomas"
        Me.DgvSintomas.ReadOnly = True
        Me.DgvSintomas.RowHeadersVisible = False
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DgvSintomas.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.DgvSintomas.RowTemplate.Height = 50
        Me.DgvSintomas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvSintomas.Size = New System.Drawing.Size(420, 352)
        Me.DgvSintomas.TabIndex = 74
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
        Me.DgvSintomas.ThemeStyle.ReadOnly = True
        Me.DgvSintomas.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DgvSintomas.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgvSintomas.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Roboto", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvSintomas.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.DgvSintomas.ThemeStyle.RowsStyle.Height = 50
        Me.DgvSintomas.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.DgvSintomas.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'idSintoma
        '
        Me.idSintoma.HeaderText = "ID"
        Me.idSintoma.Name = "idSintoma"
        Me.idSintoma.ReadOnly = True
        Me.idSintoma.Visible = False
        '
        'nombreSintoma
        '
        Me.nombreSintoma.HeaderText = "Nombre"
        Me.nombreSintoma.Name = "nombreSintoma"
        Me.nombreSintoma.ReadOnly = True
        '
        'descipcionSintoma
        '
        Me.descipcionSintoma.HeaderText = "Descripción"
        Me.descipcionSintoma.Name = "descipcionSintoma"
        Me.descipcionSintoma.ReadOnly = True
        Me.descipcionSintoma.Visible = False
        '
        'tipoSintoma
        '
        Me.tipoSintoma.HeaderText = "Tipo"
        Me.tipoSintoma.Name = "tipoSintoma"
        Me.tipoSintoma.ReadOnly = True
        Me.tipoSintoma.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Roboto", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 603)
        Me.Label1.Margin = New System.Windows.Forms.Padding(20, 15, 0, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 23)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "posibles_diagnosticos"
        '
        'LblSintomasRegistrados
        '
        Me.LblSintomasRegistrados.AutoSize = True
        Me.LblSintomasRegistrados.Font = New System.Drawing.Font("Roboto", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSintomasRegistrados.Location = New System.Drawing.Point(20, 188)
        Me.LblSintomasRegistrados.Margin = New System.Windows.Forms.Padding(20, 15, 0, 15)
        Me.LblSintomasRegistrados.Name = "LblSintomasRegistrados"
        Me.LblSintomasRegistrados.Size = New System.Drawing.Size(194, 23)
        Me.LblSintomasRegistrados.TabIndex = 2
        Me.LblSintomasRegistrados.Text = "sintomas_registrados"
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
        Me.PicAvatar.BackColor = System.Drawing.Color.Transparent
        Me.PicAvatar.FillColor = System.Drawing.Color.Transparent
        Me.PicAvatar.Image = Global.Medico_Presentacion.My.Resources.Resources.male_avatar
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
        Me.Pnl_info_paciente.BackColor = System.Drawing.Color.Transparent
        Me.Pnl_info_paciente.BorderRadius = 41
        Me.Pnl_info_paciente.Controls.Add(Me.LblEdadPaciente)
        Me.Pnl_info_paciente.Controls.Add(Me.LblNamePaciente)
        Me.Pnl_info_paciente.FillColor = System.Drawing.Color.White
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
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabSolicitudesChats)
        Me.TabControl1.Location = New System.Drawing.Point(483, 20)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1437, 1060)
        Me.TabControl1.TabIndex = 3
        '
        'TabSolicitudesChats
        '
        Me.TabSolicitudesChats.Controls.Add(Me.DgvChats)
        Me.TabSolicitudesChats.Font = New System.Drawing.Font("Roboto", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabSolicitudesChats.Location = New System.Drawing.Point(4, 22)
        Me.TabSolicitudesChats.Name = "TabSolicitudesChats"
        Me.TabSolicitudesChats.Padding = New System.Windows.Forms.Padding(3)
        Me.TabSolicitudesChats.Size = New System.Drawing.Size(1429, 1034)
        Me.TabSolicitudesChats.TabIndex = 0
        Me.TabSolicitudesChats.Text = "Chats"
        Me.TabSolicitudesChats.UseVisualStyleBackColor = True
        '
        'DgvChats
        '
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        Me.DgvChats.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.DgvChats.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvChats.BackgroundColor = System.Drawing.Color.White
        Me.DgvChats.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvChats.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgvChats.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(123, Byte), Integer))
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Roboto", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvChats.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.DgvChats.ColumnHeadersHeight = 25
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Roboto", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(245, Byte), Integer))
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvChats.DefaultCellStyle = DataGridViewCellStyle11
        Me.DgvChats.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvChats.EnableHeadersVisualStyles = False
        Me.DgvChats.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvChats.Location = New System.Drawing.Point(3, 3)
        Me.DgvChats.Name = "DgvChats"
        Me.DgvChats.RowHeadersVisible = False
        Me.DgvChats.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvChats.Size = New System.Drawing.Size(1423, 1028)
        Me.DgvChats.TabIndex = 0
        Me.DgvChats.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.DgvChats.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DgvChats.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DgvChats.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DgvChats.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DgvChats.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DgvChats.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DgvChats.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvChats.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.DgvChats.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvChats.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Roboto", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvChats.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DgvChats.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DgvChats.ThemeStyle.HeaderStyle.Height = 25
        Me.DgvChats.ThemeStyle.ReadOnly = False
        Me.DgvChats.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DgvChats.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgvChats.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Roboto", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvChats.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.DgvChats.ThemeStyle.RowsStyle.Height = 22
        Me.DgvChats.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.DgvChats.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
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
        Me.Btn_Minimize.TabIndex = 8
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
        Me.Btn_Exit.TabIndex = 7
        '
        'TimerMensajes
        '
        Me.TimerMensajes.Interval = 1000
        '
        'TimerSolicitudes
        '
        Me.TimerSolicitudes.Interval = 5000
        '
        'TimerChatStatus
        '
        Me.TimerChatStatus.Interval = 1000
        '
        'F_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1920, 1080)
        Me.Controls.Add(Me.Btn_Minimize)
        Me.Controls.Add(Me.Btn_Exit)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "F_Main"
        Me.Text = "F_Main"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.PnlDiagnosticos.ResumeLayout(False)
        CType(Me.DgvDiagnosticos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlSintomas.ResumeLayout(False)
        CType(Me.DgvSintomas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicAvatar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pnl_info_paciente.ResumeLayout(False)
        Me.Pnl_info_paciente.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabSolicitudesChats.ResumeLayout(False)
        CType(Me.DgvChats, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Pnl_info_paciente As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents PicAvatar As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents PnlSintomas As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents LblSintomasRegistrados As Label
    Friend WithEvents Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents LblEdadPaciente As Label
    Friend WithEvents LblNamePaciente As Label
    Friend WithEvents BtnCerrarSesion As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnFinalizarChat As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PnlDiagnosticos As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BtnHistorialClinico As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabSolicitudesChats As TabPage
    Friend WithEvents Btn_Minimize As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Btn_Exit As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents DgvChats As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents TimerMensajes As Timer
    Friend WithEvents TimerSolicitudes As Timer
    Friend WithEvents DgvDiagnosticos As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents descripcion As DataGridViewTextBoxColumn
    Friend WithEvents urgencia As DataGridViewTextBoxColumn
    Friend WithEvents cronica As DataGridViewTextBoxColumn
    Friend WithEvents DgvSintomas As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents idSintoma As DataGridViewTextBoxColumn
    Friend WithEvents nombreSintoma As DataGridViewTextBoxColumn
    Friend WithEvents descipcionSintoma As DataGridViewTextBoxColumn
    Friend WithEvents tipoSintoma As DataGridViewTextBoxColumn
    Friend WithEvents TimerChatStatus As Timer
End Class
