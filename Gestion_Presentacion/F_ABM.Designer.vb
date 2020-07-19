<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_ABM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_ABM))
        Me.PanelTotal = New System.Windows.Forms.Panel()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.btnCerrarSesion = New System.Windows.Forms.Button()
        Me.btnPacientes = New System.Windows.Forms.Button()
        Me.btnSintomas = New System.Windows.Forms.Button()
        Me.btnEnfermedades = New System.Windows.Forms.Button()
        Me.lblEnfermedades = New System.Windows.Forms.Label()
        Me.lblSintomas = New System.Windows.Forms.Label()
        Me.btnHorarios = New System.Windows.Forms.Button()
        Me.lblHorarios = New System.Windows.Forms.Label()
        Me.btnPersonal = New System.Windows.Forms.Button()
        Me.lblPersonal = New System.Windows.Forms.Label()
        Me.lblPacientes = New System.Windows.Forms.Label()
        Me.PanelTotal.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelTotal
        '
        Me.PanelTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.PanelTotal.Controls.Add(Me.btnCerrar)
        Me.PanelTotal.Controls.Add(Me.btnMinimizar)
        Me.PanelTotal.Controls.Add(Me.btnCerrarSesion)
        Me.PanelTotal.Controls.Add(Me.btnPacientes)
        Me.PanelTotal.Controls.Add(Me.btnSintomas)
        Me.PanelTotal.Controls.Add(Me.btnEnfermedades)
        Me.PanelTotal.Controls.Add(Me.lblEnfermedades)
        Me.PanelTotal.Controls.Add(Me.lblSintomas)
        Me.PanelTotal.Controls.Add(Me.btnHorarios)
        Me.PanelTotal.Controls.Add(Me.lblHorarios)
        Me.PanelTotal.Controls.Add(Me.btnPersonal)
        Me.PanelTotal.Controls.Add(Me.lblPersonal)
        Me.PanelTotal.Controls.Add(Me.lblPacientes)
        Me.PanelTotal.Location = New System.Drawing.Point(1, 0)
        Me.PanelTotal.Name = "PanelTotal"
        Me.PanelTotal.Size = New System.Drawing.Size(1920, 1080)
        Me.PanelTotal.TabIndex = 0
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.Color.Transparent
        Me.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.ForeColor = System.Drawing.Color.Transparent
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.Location = New System.Drawing.Point(1846, -1)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(58, 56)
        Me.btnCerrar.TabIndex = 12
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'btnMinimizar
        '
        Me.btnMinimizar.BackColor = System.Drawing.Color.Transparent
        Me.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnMinimizar.FlatAppearance.BorderSize = 0
        Me.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimizar.Image = CType(resources.GetObject("btnMinimizar.Image"), System.Drawing.Image)
        Me.btnMinimizar.Location = New System.Drawing.Point(1782, -1)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(58, 56)
        Me.btnMinimizar.TabIndex = 11
        Me.btnMinimizar.UseVisualStyleBackColor = False
        '
        'btnCerrarSesion
        '
        Me.btnCerrarSesion.FlatAppearance.BorderSize = 0
        Me.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrarSesion.Image = Global.Presentacion.My.Resources.Resources.btn_terminar_sesion
        Me.btnCerrarSesion.Location = New System.Drawing.Point(847, 859)
        Me.btnCerrarSesion.Name = "btnCerrarSesion"
        Me.btnCerrarSesion.Size = New System.Drawing.Size(228, 54)
        Me.btnCerrarSesion.TabIndex = 10
        Me.btnCerrarSesion.UseVisualStyleBackColor = True
        '
        'btnPacientes
        '
        Me.btnPacientes.Location = New System.Drawing.Point(576, 228)
        Me.btnPacientes.Name = "btnPacientes"
        Me.btnPacientes.Size = New System.Drawing.Size(250, 250)
        Me.btnPacientes.TabIndex = 0
        Me.btnPacientes.UseVisualStyleBackColor = True
        '
        'btnSintomas
        '
        Me.btnSintomas.Location = New System.Drawing.Point(709, 545)
        Me.btnSintomas.Name = "btnSintomas"
        Me.btnSintomas.Size = New System.Drawing.Size(250, 250)
        Me.btnSintomas.TabIndex = 6
        Me.btnSintomas.UseVisualStyleBackColor = True
        '
        'btnEnfermedades
        '
        Me.btnEnfermedades.Location = New System.Drawing.Point(980, 545)
        Me.btnEnfermedades.Name = "btnEnfermedades"
        Me.btnEnfermedades.Size = New System.Drawing.Size(250, 250)
        Me.btnEnfermedades.TabIndex = 9
        Me.btnEnfermedades.UseVisualStyleBackColor = True
        '
        'lblEnfermedades
        '
        Me.lblEnfermedades.BackColor = System.Drawing.Color.Transparent
        Me.lblEnfermedades.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnfermedades.Location = New System.Drawing.Point(980, 785)
        Me.lblEnfermedades.Name = "lblEnfermedades"
        Me.lblEnfermedades.Size = New System.Drawing.Size(250, 52)
        Me.lblEnfermedades.TabIndex = 8
        Me.lblEnfermedades.Text = "Enfermedades"
        Me.lblEnfermedades.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSintomas
        '
        Me.lblSintomas.BackColor = System.Drawing.Color.Transparent
        Me.lblSintomas.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSintomas.Location = New System.Drawing.Point(709, 785)
        Me.lblSintomas.Name = "lblSintomas"
        Me.lblSintomas.Size = New System.Drawing.Size(250, 52)
        Me.lblSintomas.TabIndex = 7
        Me.lblSintomas.Text = "Síntomas"
        Me.lblSintomas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnHorarios
        '
        Me.btnHorarios.Location = New System.Drawing.Point(1118, 228)
        Me.btnHorarios.Name = "btnHorarios"
        Me.btnHorarios.Size = New System.Drawing.Size(250, 250)
        Me.btnHorarios.TabIndex = 5
        Me.btnHorarios.UseVisualStyleBackColor = True
        '
        'lblHorarios
        '
        Me.lblHorarios.BackColor = System.Drawing.Color.Transparent
        Me.lblHorarios.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHorarios.Location = New System.Drawing.Point(1118, 468)
        Me.lblHorarios.Name = "lblHorarios"
        Me.lblHorarios.Size = New System.Drawing.Size(250, 52)
        Me.lblHorarios.TabIndex = 4
        Me.lblHorarios.Text = "Horarios"
        Me.lblHorarios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPersonal
        '
        Me.btnPersonal.Location = New System.Drawing.Point(847, 228)
        Me.btnPersonal.Name = "btnPersonal"
        Me.btnPersonal.Size = New System.Drawing.Size(250, 250)
        Me.btnPersonal.TabIndex = 3
        Me.btnPersonal.UseVisualStyleBackColor = True
        '
        'lblPersonal
        '
        Me.lblPersonal.BackColor = System.Drawing.Color.Transparent
        Me.lblPersonal.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPersonal.Location = New System.Drawing.Point(847, 468)
        Me.lblPersonal.Name = "lblPersonal"
        Me.lblPersonal.Size = New System.Drawing.Size(250, 52)
        Me.lblPersonal.TabIndex = 2
        Me.lblPersonal.Text = "Personal"
        Me.lblPersonal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPacientes
        '
        Me.lblPacientes.BackColor = System.Drawing.Color.Transparent
        Me.lblPacientes.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPacientes.Location = New System.Drawing.Point(576, 468)
        Me.lblPacientes.Name = "lblPacientes"
        Me.lblPacientes.Size = New System.Drawing.Size(250, 52)
        Me.lblPacientes.TabIndex = 1
        Me.lblPacientes.Text = "Pacientes"
        Me.lblPacientes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmGestionABM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1904, 1041)
        Me.Controls.Add(Me.PanelTotal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmGestionABM"
        Me.Text = "frmGestionABM"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelTotal.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelTotal As Panel
    Friend WithEvents lblPacientes As Label
    Friend WithEvents btnPacientes As Button
    Friend WithEvents btnPersonal As Button
    Friend WithEvents lblPersonal As Label
    Friend WithEvents btnSintomas As Button
    Friend WithEvents btnEnfermedades As Button
    Friend WithEvents lblEnfermedades As Label
    Friend WithEvents lblSintomas As Label
    Friend WithEvents btnHorarios As Button
    Friend WithEvents lblHorarios As Label
    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnMinimizar As Button
    Friend WithEvents btnCerrarSesion As Button
End Class
