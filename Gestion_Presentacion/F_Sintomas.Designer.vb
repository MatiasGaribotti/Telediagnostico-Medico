<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_Sintomas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_Sintomas))
        Me.pnl_fondo = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_menosEnfermedadI = New System.Windows.Forms.Button()
        Me.btn_masEnfermedadI = New System.Windows.Forms.Button()
        Me.btn_menosEnfermedad = New System.Windows.Forms.Button()
        Me.btn_masEnfermedad = New System.Windows.Forms.Button()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.btn_importar = New System.Windows.Forms.Button()
        Me.btn_filtrar = New System.Windows.Forms.Button()
        Me.btn_ingresar = New System.Windows.Forms.Button()
        Me.txt_descripcion = New System.Windows.Forms.TextBox()
        Me.txt_sintomaI = New System.Windows.Forms.TextBox()
        Me.cmb_enfermedadesI = New System.Windows.Forms.ComboBox()
        Me.cmb_tipoI = New System.Windows.Forms.ComboBox()
        Me.cmb_enfermedades = New System.Windows.Forms.ComboBox()
        Me.cmb_tipo = New System.Windows.Forms.ComboBox()
        Me.txt_sintoma = New System.Windows.Forms.TextBox()
        Me.lbl_importar = New System.Windows.Forms.Label()
        Me.lbl_descripcion = New System.Windows.Forms.Label()
        Me.lbl_enfermedadesI = New System.Windows.Forms.Label()
        Me.lbl_tipoI = New System.Windows.Forms.Label()
        Me.lbl_sintomaI = New System.Windows.Forms.Label()
        Me.lbl_ingresar = New System.Windows.Forms.Label()
        Me.lbl_enfermedades = New System.Windows.Forms.Label()
        Me.lbl_tipo = New System.Windows.Forms.Label()
        Me.lbl_sintoma = New System.Windows.Forms.Label()
        Me.lbl_busqueda = New System.Windows.Forms.Label()
        Me.btn_volver = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btn_minimizar = New System.Windows.Forms.Button()
        Me.btn_cerrar = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl_fondo
        '
        Me.pnl_fondo.Location = New System.Drawing.Point(0, 0)
        Me.pnl_fondo.Name = "pnl_fondo"
        Me.pnl_fondo.Size = New System.Drawing.Size(200, 100)
        Me.pnl_fondo.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btn_menosEnfermedadI)
        Me.Panel1.Controls.Add(Me.btn_masEnfermedadI)
        Me.Panel1.Controls.Add(Me.btn_menosEnfermedad)
        Me.Panel1.Controls.Add(Me.btn_masEnfermedad)
        Me.Panel1.Controls.Add(Me.TextBox4)
        Me.Panel1.Controls.Add(Me.btn_importar)
        Me.Panel1.Controls.Add(Me.btn_filtrar)
        Me.Panel1.Controls.Add(Me.btn_ingresar)
        Me.Panel1.Controls.Add(Me.txt_descripcion)
        Me.Panel1.Controls.Add(Me.txt_sintomaI)
        Me.Panel1.Controls.Add(Me.cmb_enfermedadesI)
        Me.Panel1.Controls.Add(Me.cmb_tipoI)
        Me.Panel1.Controls.Add(Me.cmb_enfermedades)
        Me.Panel1.Controls.Add(Me.cmb_tipo)
        Me.Panel1.Controls.Add(Me.txt_sintoma)
        Me.Panel1.Controls.Add(Me.lbl_importar)
        Me.Panel1.Controls.Add(Me.lbl_descripcion)
        Me.Panel1.Controls.Add(Me.lbl_enfermedadesI)
        Me.Panel1.Controls.Add(Me.lbl_tipoI)
        Me.Panel1.Controls.Add(Me.lbl_sintomaI)
        Me.Panel1.Controls.Add(Me.lbl_ingresar)
        Me.Panel1.Controls.Add(Me.lbl_enfermedades)
        Me.Panel1.Controls.Add(Me.lbl_tipo)
        Me.Panel1.Controls.Add(Me.lbl_sintoma)
        Me.Panel1.Controls.Add(Me.lbl_busqueda)
        Me.Panel1.Controls.Add(Me.btn_volver)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(573, 1080)
        Me.Panel1.TabIndex = 1
        '
        'btn_menosEnfermedadI
        '
        Me.btn_menosEnfermedadI.FlatAppearance.BorderSize = 0
        Me.btn_menosEnfermedadI.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_menosEnfermedadI.Image = CType(resources.GetObject("btn_menosEnfermedadI.Image"), System.Drawing.Image)
        Me.btn_menosEnfermedadI.Location = New System.Drawing.Point(461, 415)
        Me.btn_menosEnfermedadI.Name = "btn_menosEnfermedadI"
        Me.btn_menosEnfermedadI.Size = New System.Drawing.Size(32, 32)
        Me.btn_menosEnfermedadI.TabIndex = 25
        Me.btn_menosEnfermedadI.UseVisualStyleBackColor = True
        '
        'btn_masEnfermedadI
        '
        Me.btn_masEnfermedadI.FlatAppearance.BorderSize = 0
        Me.btn_masEnfermedadI.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_masEnfermedadI.Image = CType(resources.GetObject("btn_masEnfermedadI.Image"), System.Drawing.Image)
        Me.btn_masEnfermedadI.Location = New System.Drawing.Point(423, 415)
        Me.btn_masEnfermedadI.Name = "btn_masEnfermedadI"
        Me.btn_masEnfermedadI.Size = New System.Drawing.Size(32, 32)
        Me.btn_masEnfermedadI.TabIndex = 24
        Me.btn_masEnfermedadI.UseVisualStyleBackColor = True
        '
        'btn_menosEnfermedad
        '
        Me.btn_menosEnfermedad.FlatAppearance.BorderSize = 0
        Me.btn_menosEnfermedad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_menosEnfermedad.Image = CType(resources.GetObject("btn_menosEnfermedad.Image"), System.Drawing.Image)
        Me.btn_menosEnfermedad.Location = New System.Drawing.Point(461, 223)
        Me.btn_menosEnfermedad.Name = "btn_menosEnfermedad"
        Me.btn_menosEnfermedad.Size = New System.Drawing.Size(32, 32)
        Me.btn_menosEnfermedad.TabIndex = 23
        Me.btn_menosEnfermedad.UseVisualStyleBackColor = True
        '
        'btn_masEnfermedad
        '
        Me.btn_masEnfermedad.FlatAppearance.BorderSize = 0
        Me.btn_masEnfermedad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_masEnfermedad.Image = CType(resources.GetObject("btn_masEnfermedad.Image"), System.Drawing.Image)
        Me.btn_masEnfermedad.Location = New System.Drawing.Point(423, 223)
        Me.btn_masEnfermedad.Name = "btn_masEnfermedad"
        Me.btn_masEnfermedad.Size = New System.Drawing.Size(32, 32)
        Me.btn_masEnfermedad.TabIndex = 22
        Me.btn_masEnfermedad.UseVisualStyleBackColor = True
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(144, 617)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(273, 29)
        Me.TextBox4.TabIndex = 21
        '
        'btn_importar
        '
        Me.btn_importar.FlatAppearance.BorderSize = 0
        Me.btn_importar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_importar.Image = Global.Presentacion.My.Resources.Resources.btn_importar
        Me.btn_importar.Location = New System.Drawing.Point(392, 668)
        Me.btn_importar.Name = "btn_importar"
        Me.btn_importar.Size = New System.Drawing.Size(97, 39)
        Me.btn_importar.TabIndex = 20
        Me.btn_importar.UseVisualStyleBackColor = True
        '
        'btn_filtrar
        '
        Me.btn_filtrar.FlatAppearance.BorderSize = 0
        Me.btn_filtrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_filtrar.Image = Global.Presentacion.My.Resources.Resources.btn_filtrar
        Me.btn_filtrar.Location = New System.Drawing.Point(367, 256)
        Me.btn_filtrar.Name = "btn_filtrar"
        Me.btn_filtrar.Size = New System.Drawing.Size(156, 64)
        Me.btn_filtrar.TabIndex = 19
        Me.btn_filtrar.UseVisualStyleBackColor = True
        '
        'btn_ingresar
        '
        Me.btn_ingresar.FlatAppearance.BorderSize = 0
        Me.btn_ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ingresar.Image = Global.Presentacion.My.Resources.Resources.Ingresar_Button
        Me.btn_ingresar.Location = New System.Drawing.Point(367, 516)
        Me.btn_ingresar.Name = "btn_ingresar"
        Me.btn_ingresar.Size = New System.Drawing.Size(156, 64)
        Me.btn_ingresar.TabIndex = 18
        Me.btn_ingresar.UseVisualStyleBackColor = True
        '
        'txt_descripcion
        '
        Me.txt_descripcion.Location = New System.Drawing.Point(181, 452)
        Me.txt_descripcion.Multiline = True
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Size = New System.Drawing.Size(289, 48)
        Me.txt_descripcion.TabIndex = 17
        '
        'txt_sintomaI
        '
        Me.txt_sintomaI.Location = New System.Drawing.Point(144, 326)
        Me.txt_sintomaI.Name = "txt_sintomaI"
        Me.txt_sintomaI.Size = New System.Drawing.Size(273, 29)
        Me.txt_sintomaI.TabIndex = 16
        '
        'cmb_enfermedadesI
        '
        Me.cmb_enfermedadesI.FormattingEnabled = True
        Me.cmb_enfermedadesI.Location = New System.Drawing.Point(201, 410)
        Me.cmb_enfermedadesI.Name = "cmb_enfermedadesI"
        Me.cmb_enfermedadesI.Size = New System.Drawing.Size(216, 32)
        Me.cmb_enfermedadesI.TabIndex = 15
        '
        'cmb_tipoI
        '
        Me.cmb_tipoI.FormattingEnabled = True
        Me.cmb_tipoI.Location = New System.Drawing.Point(144, 369)
        Me.cmb_tipoI.Name = "cmb_tipoI"
        Me.cmb_tipoI.Size = New System.Drawing.Size(273, 32)
        Me.cmb_tipoI.TabIndex = 14
        '
        'cmb_enfermedades
        '
        Me.cmb_enfermedades.FormattingEnabled = True
        Me.cmb_enfermedades.Location = New System.Drawing.Point(201, 218)
        Me.cmb_enfermedades.Name = "cmb_enfermedades"
        Me.cmb_enfermedades.Size = New System.Drawing.Size(216, 32)
        Me.cmb_enfermedades.TabIndex = 13
        '
        'cmb_tipo
        '
        Me.cmb_tipo.FormattingEnabled = True
        Me.cmb_tipo.Location = New System.Drawing.Point(165, 174)
        Me.cmb_tipo.Name = "cmb_tipo"
        Me.cmb_tipo.Size = New System.Drawing.Size(252, 32)
        Me.cmb_tipo.TabIndex = 12
        '
        'txt_sintoma
        '
        Me.txt_sintoma.Location = New System.Drawing.Point(165, 134)
        Me.txt_sintoma.Name = "txt_sintoma"
        Me.txt_sintoma.Size = New System.Drawing.Size(252, 29)
        Me.txt_sintoma.TabIndex = 11
        '
        'lbl_importar
        '
        Me.lbl_importar.AutoSize = True
        Me.lbl_importar.Location = New System.Drawing.Point(39, 622)
        Me.lbl_importar.Name = "lbl_importar"
        Me.lbl_importar.Size = New System.Drawing.Size(83, 24)
        Me.lbl_importar.TabIndex = 10
        Me.lbl_importar.Text = "Importar:"
        '
        'lbl_descripcion
        '
        Me.lbl_descripcion.AutoSize = True
        Me.lbl_descripcion.Location = New System.Drawing.Point(60, 452)
        Me.lbl_descripcion.Name = "lbl_descripcion"
        Me.lbl_descripcion.Size = New System.Drawing.Size(115, 24)
        Me.lbl_descripcion.TabIndex = 9
        Me.lbl_descripcion.Text = "Descripción:"
        '
        'lbl_enfermedadesI
        '
        Me.lbl_enfermedadesI.AutoSize = True
        Me.lbl_enfermedadesI.Location = New System.Drawing.Point(61, 410)
        Me.lbl_enfermedadesI.Name = "lbl_enfermedadesI"
        Me.lbl_enfermedadesI.Size = New System.Drawing.Size(139, 24)
        Me.lbl_enfermedadesI.TabIndex = 8
        Me.lbl_enfermedadesI.Text = "Enfermedades:"
        '
        'lbl_tipoI
        '
        Me.lbl_tipoI.AutoSize = True
        Me.lbl_tipoI.Location = New System.Drawing.Point(61, 369)
        Me.lbl_tipoI.Name = "lbl_tipoI"
        Me.lbl_tipoI.Size = New System.Drawing.Size(53, 24)
        Me.lbl_tipoI.TabIndex = 7
        Me.lbl_tipoI.Text = "Tipo:"
        '
        'lbl_sintomaI
        '
        Me.lbl_sintomaI.AutoSize = True
        Me.lbl_sintomaI.Location = New System.Drawing.Point(61, 326)
        Me.lbl_sintomaI.Name = "lbl_sintomaI"
        Me.lbl_sintomaI.Size = New System.Drawing.Size(78, 24)
        Me.lbl_sintomaI.TabIndex = 6
        Me.lbl_sintomaI.Text = "Síntoma"
        '
        'lbl_ingresar
        '
        Me.lbl_ingresar.AutoSize = True
        Me.lbl_ingresar.Location = New System.Drawing.Point(39, 281)
        Me.lbl_ingresar.Name = "lbl_ingresar"
        Me.lbl_ingresar.Size = New System.Drawing.Size(78, 24)
        Me.lbl_ingresar.TabIndex = 5
        Me.lbl_ingresar.Text = "Ingresar"
        '
        'lbl_enfermedades
        '
        Me.lbl_enfermedades.AutoSize = True
        Me.lbl_enfermedades.Location = New System.Drawing.Point(61, 226)
        Me.lbl_enfermedades.Name = "lbl_enfermedades"
        Me.lbl_enfermedades.Size = New System.Drawing.Size(139, 24)
        Me.lbl_enfermedades.TabIndex = 4
        Me.lbl_enfermedades.Text = "Enfermedades:"
        '
        'lbl_tipo
        '
        Me.lbl_tipo.AutoSize = True
        Me.lbl_tipo.Location = New System.Drawing.Point(61, 182)
        Me.lbl_tipo.Name = "lbl_tipo"
        Me.lbl_tipo.Size = New System.Drawing.Size(53, 24)
        Me.lbl_tipo.TabIndex = 3
        Me.lbl_tipo.Text = "Tipo:"
        '
        'lbl_sintoma
        '
        Me.lbl_sintoma.AutoSize = True
        Me.lbl_sintoma.Location = New System.Drawing.Point(61, 137)
        Me.lbl_sintoma.Name = "lbl_sintoma"
        Me.lbl_sintoma.Size = New System.Drawing.Size(78, 24)
        Me.lbl_sintoma.TabIndex = 2
        Me.lbl_sintoma.Text = "Síntoma"
        '
        'lbl_busqueda
        '
        Me.lbl_busqueda.AutoSize = True
        Me.lbl_busqueda.Location = New System.Drawing.Point(39, 91)
        Me.lbl_busqueda.Name = "lbl_busqueda"
        Me.lbl_busqueda.Size = New System.Drawing.Size(87, 24)
        Me.lbl_busqueda.TabIndex = 1
        Me.lbl_busqueda.Text = "Búqueda"
        '
        'btn_volver
        '
        Me.btn_volver.FlatAppearance.BorderSize = 0
        Me.btn_volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_volver.Image = Global.Presentacion.My.Resources.Resources.btn_volver
        Me.btn_volver.Location = New System.Drawing.Point(13, 13)
        Me.btn_volver.Name = "btn_volver"
        Me.btn_volver.Size = New System.Drawing.Size(156, 64)
        Me.btn_volver.TabIndex = 0
        Me.btn_volver.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btn_minimizar
        '
        Me.btn_minimizar.FlatAppearance.BorderSize = 0
        Me.btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_minimizar.Image = CType(resources.GetObject("btn_minimizar.Image"), System.Drawing.Image)
        Me.btn_minimizar.Location = New System.Drawing.Point(1799, -3)
        Me.btn_minimizar.Name = "btn_minimizar"
        Me.btn_minimizar.Size = New System.Drawing.Size(58, 65)
        Me.btn_minimizar.TabIndex = 20
        Me.btn_minimizar.UseVisualStyleBackColor = True
        '
        'btn_cerrar
        '
        Me.btn_cerrar.FlatAppearance.BorderSize = 0
        Me.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cerrar.Image = CType(resources.GetObject("btn_cerrar.Image"), System.Drawing.Image)
        Me.btn_cerrar.Location = New System.Drawing.Point(1863, 0)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(59, 59)
        Me.btn_cerrar.TabIndex = 21
        Me.btn_cerrar.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(595, 120)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(1300, 839)
        Me.DataGridView2.TabIndex = 22
        '
        'frm_SintomasIngresarFiltrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1920, 1080)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.btn_minimizar)
        Me.Controls.Add(Me.btn_cerrar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnl_fondo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_SintomasIngresarFiltrar"
        Me.Text = "frm_SintomasIngresarFiltrar"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnl_fondo As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_volver As Button
    Friend WithEvents lbl_importar As Label
    Friend WithEvents lbl_descripcion As Label
    Friend WithEvents lbl_enfermedadesI As Label
    Friend WithEvents lbl_tipoI As Label
    Friend WithEvents lbl_sintomaI As Label
    Friend WithEvents lbl_ingresar As Label
    Friend WithEvents lbl_enfermedades As Label
    Friend WithEvents lbl_tipo As Label
    Friend WithEvents lbl_sintoma As Label
    Friend WithEvents lbl_busqueda As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btn_menosEnfermedadI As Button
    Friend WithEvents btn_masEnfermedadI As Button
    Friend WithEvents btn_menosEnfermedad As Button
    Friend WithEvents btn_masEnfermedad As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents btn_importar As Button
    Friend WithEvents btn_filtrar As Button
    Friend WithEvents btn_ingresar As Button
    Friend WithEvents txt_descripcion As TextBox
    Friend WithEvents txt_sintomaI As TextBox
    Friend WithEvents cmb_enfermedadesI As ComboBox
    Friend WithEvents cmb_tipoI As ComboBox
    Friend WithEvents cmb_enfermedades As ComboBox
    Friend WithEvents cmb_tipo As ComboBox
    Friend WithEvents txt_sintoma As TextBox
    Friend WithEvents btn_minimizar As Button
    Friend WithEvents btn_cerrar As Button
    Friend WithEvents DataGridView2 As DataGridView
End Class
