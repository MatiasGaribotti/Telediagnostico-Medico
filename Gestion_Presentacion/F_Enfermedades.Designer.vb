<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_Enfermedades
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_Enfermedades))
        Me.pnl_fondo = New System.Windows.Forms.Panel()
        Me.btn_minimizar = New System.Windows.Forms.Button()
        Me.btn_cerrar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.pnl_ingresarFiltrar = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_medMenos = New System.Windows.Forms.Button()
        Me.btn_medMas = New System.Windows.Forms.Button()
        Me.btn_filtrar = New System.Windows.Forms.Button()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lbl_medicacion = New System.Windows.Forms.Label()
        Me.lbl_urgencia = New System.Windows.Forms.Label()
        Me.lbl_enfermedad = New System.Windows.Forms.Label()
        Me.lbl_ingresar = New System.Windows.Forms.Label()
        Me.btn_volver = New System.Windows.Forms.Button()
        Me.lbl_buqueda = New System.Windows.Forms.Label()
        Me.pnl_fondo.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_ingresarFiltrar.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl_fondo
        '
        Me.pnl_fondo.Controls.Add(Me.btn_minimizar)
        Me.pnl_fondo.Controls.Add(Me.btn_cerrar)
        Me.pnl_fondo.Controls.Add(Me.DataGridView1)
        Me.pnl_fondo.Controls.Add(Me.pnl_ingresarFiltrar)
        Me.pnl_fondo.Location = New System.Drawing.Point(0, 0)
        Me.pnl_fondo.Name = "pnl_fondo"
        Me.pnl_fondo.Size = New System.Drawing.Size(1920, 1080)
        Me.pnl_fondo.TabIndex = 0
        '
        'btn_minimizar
        '
        Me.btn_minimizar.FlatAppearance.BorderSize = 0
        Me.btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_minimizar.Image = CType(resources.GetObject("btn_minimizar.Image"), System.Drawing.Image)
        Me.btn_minimizar.Location = New System.Drawing.Point(1783, 0)
        Me.btn_minimizar.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_minimizar.Name = "btn_minimizar"
        Me.btn_minimizar.Size = New System.Drawing.Size(58, 56)
        Me.btn_minimizar.TabIndex = 3
        Me.btn_minimizar.UseVisualStyleBackColor = True
        '
        'btn_cerrar
        '
        Me.btn_cerrar.FlatAppearance.BorderSize = 0
        Me.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cerrar.Image = CType(resources.GetObject("btn_cerrar.Image"), System.Drawing.Image)
        Me.btn_cerrar.Location = New System.Drawing.Point(1853, 0)
        Me.btn_cerrar.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(58, 56)
        Me.btn_cerrar.TabIndex = 2
        Me.btn_cerrar.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(597, 120)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1300, 839)
        Me.DataGridView1.TabIndex = 1
        '
        'pnl_ingresarFiltrar
        '
        Me.pnl_ingresarFiltrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.pnl_ingresarFiltrar.Controls.Add(Me.Button1)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.Button2)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.Button3)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.ComboBox3)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.ComboBox4)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.TextBox2)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.Label1)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.Label2)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.Label3)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.btn_medMenos)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.btn_medMas)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.btn_filtrar)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.ComboBox2)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.ComboBox1)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.TextBox1)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.lbl_medicacion)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.lbl_urgencia)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.lbl_enfermedad)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.lbl_ingresar)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.btn_volver)
        Me.pnl_ingresarFiltrar.Controls.Add(Me.lbl_buqueda)
        Me.pnl_ingresarFiltrar.Location = New System.Drawing.Point(0, 0)
        Me.pnl_ingresarFiltrar.Name = "pnl_ingresarFiltrar"
        Me.pnl_ingresarFiltrar.Size = New System.Drawing.Size(573, 1080)
        Me.pnl_ingresarFiltrar.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(468, 517)
        Me.Button1.Margin = New System.Windows.Forms.Padding(0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(32, 32)
        Me.Button1.TabIndex = 23
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(432, 517)
        Me.Button2.Margin = New System.Windows.Forms.Padding(0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(32, 32)
        Me.Button2.TabIndex = 22
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Image = Global.Presentacion.My.Resources.Resources.Ingresar_Button
        Me.Button3.Location = New System.Drawing.Point(361, 562)
        Me.Button3.Margin = New System.Windows.Forms.Padding(0)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(162, 54)
        Me.Button3.TabIndex = 21
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(182, 517)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(236, 21)
        Me.ComboBox3.TabIndex = 20
        '
        'ComboBox4
        '
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(182, 470)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(236, 21)
        Me.ComboBox4.TabIndex = 19
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(182, 424)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(236, 30)
        Me.TextBox2.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Roboto", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(58, 513)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 23)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Medicación:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Roboto", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(58, 469)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 23)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Urgencia:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Roboto", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(58, 424)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 23)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Enfermedad:"
        '
        'btn_medMenos
        '
        Me.btn_medMenos.FlatAppearance.BorderSize = 0
        Me.btn_medMenos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_medMenos.Image = CType(resources.GetObject("btn_medMenos.Image"), System.Drawing.Image)
        Me.btn_medMenos.Location = New System.Drawing.Point(468, 226)
        Me.btn_medMenos.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_medMenos.Name = "btn_medMenos"
        Me.btn_medMenos.Size = New System.Drawing.Size(32, 32)
        Me.btn_medMenos.TabIndex = 14
        Me.btn_medMenos.UseVisualStyleBackColor = True
        '
        'btn_medMas
        '
        Me.btn_medMas.FlatAppearance.BorderSize = 0
        Me.btn_medMas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_medMas.Image = CType(resources.GetObject("btn_medMas.Image"), System.Drawing.Image)
        Me.btn_medMas.Location = New System.Drawing.Point(432, 226)
        Me.btn_medMas.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_medMas.Name = "btn_medMas"
        Me.btn_medMas.Size = New System.Drawing.Size(32, 32)
        Me.btn_medMas.TabIndex = 13
        Me.btn_medMas.UseVisualStyleBackColor = True
        '
        'btn_filtrar
        '
        Me.btn_filtrar.FlatAppearance.BorderSize = 0
        Me.btn_filtrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_filtrar.Image = Global.Presentacion.My.Resources.Resources.btn_filtrar
        Me.btn_filtrar.Location = New System.Drawing.Point(361, 267)
        Me.btn_filtrar.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_filtrar.Name = "btn_filtrar"
        Me.btn_filtrar.Size = New System.Drawing.Size(154, 51)
        Me.btn_filtrar.TabIndex = 12
        Me.btn_filtrar.UseVisualStyleBackColor = True
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(182, 226)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(236, 21)
        Me.ComboBox2.TabIndex = 11
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(182, 179)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(236, 21)
        Me.ComboBox1.TabIndex = 10
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(182, 133)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(236, 30)
        Me.TextBox1.TabIndex = 9
        '
        'lbl_medicacion
        '
        Me.lbl_medicacion.AutoSize = True
        Me.lbl_medicacion.Font = New System.Drawing.Font("Roboto", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_medicacion.Location = New System.Drawing.Point(58, 222)
        Me.lbl_medicacion.Name = "lbl_medicacion"
        Me.lbl_medicacion.Size = New System.Drawing.Size(114, 23)
        Me.lbl_medicacion.TabIndex = 8
        Me.lbl_medicacion.Text = "Medicación:"
        '
        'lbl_urgencia
        '
        Me.lbl_urgencia.AutoSize = True
        Me.lbl_urgencia.Font = New System.Drawing.Font("Roboto", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_urgencia.Location = New System.Drawing.Point(58, 178)
        Me.lbl_urgencia.Name = "lbl_urgencia"
        Me.lbl_urgencia.Size = New System.Drawing.Size(89, 23)
        Me.lbl_urgencia.TabIndex = 7
        Me.lbl_urgencia.Text = "Urgencia:"
        '
        'lbl_enfermedad
        '
        Me.lbl_enfermedad.AutoSize = True
        Me.lbl_enfermedad.Font = New System.Drawing.Font("Roboto", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_enfermedad.Location = New System.Drawing.Point(58, 133)
        Me.lbl_enfermedad.Name = "lbl_enfermedad"
        Me.lbl_enfermedad.Size = New System.Drawing.Size(118, 23)
        Me.lbl_enfermedad.TabIndex = 6
        Me.lbl_enfermedad.Text = "Enfermedad:"
        '
        'lbl_ingresar
        '
        Me.lbl_ingresar.AutoSize = True
        Me.lbl_ingresar.Font = New System.Drawing.Font("Roboto", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ingresar.Location = New System.Drawing.Point(47, 368)
        Me.lbl_ingresar.Name = "lbl_ingresar"
        Me.lbl_ingresar.Size = New System.Drawing.Size(86, 23)
        Me.lbl_ingresar.TabIndex = 5
        Me.lbl_ingresar.Text = "Ingresar"
        '
        'btn_volver
        '
        Me.btn_volver.FlatAppearance.BorderSize = 0
        Me.btn_volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_volver.Image = Global.Presentacion.My.Resources.Resources.btn_volver
        Me.btn_volver.Location = New System.Drawing.Point(9, 2)
        Me.btn_volver.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_volver.Name = "btn_volver"
        Me.btn_volver.Size = New System.Drawing.Size(156, 78)
        Me.btn_volver.TabIndex = 4
        Me.btn_volver.UseVisualStyleBackColor = True
        '
        'lbl_buqueda
        '
        Me.lbl_buqueda.AutoSize = True
        Me.lbl_buqueda.Font = New System.Drawing.Font("Roboto", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_buqueda.Location = New System.Drawing.Point(47, 80)
        Me.lbl_buqueda.Name = "lbl_buqueda"
        Me.lbl_buqueda.Size = New System.Drawing.Size(102, 23)
        Me.lbl_buqueda.TabIndex = 0
        Me.lbl_buqueda.Text = "Búsqueda"
        '
        'Enfermedades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1920, 1080)
        Me.Controls.Add(Me.pnl_fondo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Enfermedades"
        Me.Text = "Enfermedades"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.pnl_fondo.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_ingresarFiltrar.ResumeLayout(False)
        Me.pnl_ingresarFiltrar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnl_fondo As Panel
    Friend WithEvents pnl_ingresarFiltrar As Panel
    Friend WithEvents btn_minimizar As Button
    Friend WithEvents btn_cerrar As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btn_volver As Button
    Friend WithEvents lbl_buqueda As Label
    Friend WithEvents lbl_urgencia As Label
    Friend WithEvents lbl_enfermedad As Label
    Friend WithEvents lbl_ingresar As Label
    Friend WithEvents lbl_medicacion As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_medMenos As Button
    Friend WithEvents btn_medMas As Button
    Friend WithEvents btn_filtrar As Button
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox1 As TextBox
End Class
