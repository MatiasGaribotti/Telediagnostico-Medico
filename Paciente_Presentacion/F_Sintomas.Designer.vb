<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F_Sintomas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_Sintomas))
        Me.lbl_SintomasIng = New System.Windows.Forms.Label()
        Me.Btn_HC = New System.Windows.Forms.Button()
        Me.LeftPanel = New System.Windows.Forms.Panel()
        Me.PicBgSintomasIngresados = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tblPane = New System.Windows.Forms.TableLayoutPanel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Btn_Cancelar = New System.Windows.Forms.Button()
        Me.Btn_Aceptar = New System.Windows.Forms.Button()
        Me.LeftPanel.SuspendLayout()
        CType(Me.PicBgSintomasIngresados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tblPane.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_SintomasIng
        '
        Me.lbl_SintomasIng.AutoSize = True
        Me.lbl_SintomasIng.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_SintomasIng.Location = New System.Drawing.Point(45, 276)
        Me.lbl_SintomasIng.Name = "lbl_SintomasIng"
        Me.lbl_SintomasIng.Size = New System.Drawing.Size(213, 25)
        Me.lbl_SintomasIng.TabIndex = 3
        Me.lbl_SintomasIng.Text = "Síntomas Ingresados"
        '
        'Btn_HC
        '
        Me.Btn_HC.BackColor = System.Drawing.Color.Transparent
        Me.Btn_HC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btn_HC.FlatAppearance.BorderSize = 0
        Me.Btn_HC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Btn_HC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_HC.Image = Global.Presentacion.My.Resources.Resources.btn_historial_clinico_solapa
        Me.Btn_HC.Location = New System.Drawing.Point(50, -1)
        Me.Btn_HC.Margin = New System.Windows.Forms.Padding(0)
        Me.Btn_HC.Name = "Btn_HC"
        Me.Btn_HC.Size = New System.Drawing.Size(193, 47)
        Me.Btn_HC.TabIndex = 1
        Me.Btn_HC.UseVisualStyleBackColor = False
        '
        'LeftPanel
        '
        Me.LeftPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.LeftPanel.Controls.Add(Me.PicBgSintomasIngresados)
        Me.LeftPanel.Controls.Add(Me.PictureBox1)
        Me.LeftPanel.Controls.Add(Me.tblPane)
        Me.LeftPanel.Controls.Add(Me.lbl_SintomasIng)
        Me.LeftPanel.Controls.Add(Me.Btn_Cancelar)
        Me.LeftPanel.Controls.Add(Me.Btn_Aceptar)
        Me.LeftPanel.Controls.Add(Me.Btn_HC)
        Me.LeftPanel.Location = New System.Drawing.Point(0, 0)
        Me.LeftPanel.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.LeftPanel.Name = "LeftPanel"
        Me.LeftPanel.Size = New System.Drawing.Size(960, 1080)
        Me.LeftPanel.TabIndex = 4
        '
        'PicBgSintomasIngresados
        '
        Me.PicBgSintomasIngresados.BackgroundImage = Global.Presentacion.My.Resources.Resources.Síntomas_L
        Me.PicBgSintomasIngresados.Location = New System.Drawing.Point(50, 323)
        Me.PicBgSintomasIngresados.Margin = New System.Windows.Forms.Padding(0)
        Me.PicBgSintomasIngresados.Name = "PicBgSintomasIngresados"
        Me.PicBgSintomasIngresados.Size = New System.Drawing.Size(7, 391)
        Me.PicBgSintomasIngresados.TabIndex = 5
        Me.PicBgSintomasIngresados.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Presentacion.My.Resources.Resources.Síntomas_R
        Me.PictureBox1.Location = New System.Drawing.Point(902, 323)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(7, 391)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'tblPane
        '
        Me.tblPane.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.tblPane.ColumnCount = 1
        Me.tblPane.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblPane.Controls.Add(Me.Button2, 0, 3)
        Me.tblPane.Controls.Add(Me.Button3, 0, 1)
        Me.tblPane.Controls.Add(Me.Button4, 0, 2)
        Me.tblPane.Controls.Add(Me.Button5, 0, 5)
        Me.tblPane.Controls.Add(Me.Button6, 0, 4)
        Me.tblPane.Controls.Add(Me.Button7, 0, 0)
        Me.tblPane.Location = New System.Drawing.Point(57, 323)
        Me.tblPane.Name = "tblPane"
        Me.tblPane.RowCount = 6
        Me.tblPane.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tblPane.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tblPane.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tblPane.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tblPane.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tblPane.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tblPane.Size = New System.Drawing.Size(846, 391)
        Me.tblPane.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(0, 199)
        Me.Button2.Margin = New System.Windows.Forms.Padding(0, 4, 0, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
        Me.Button2.Size = New System.Drawing.Size(846, 57)
        Me.Button2.TabIndex = 4
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(0, 69)
        Me.Button3.Margin = New System.Windows.Forms.Padding(0, 4, 0, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
        Me.Button3.Size = New System.Drawing.Size(846, 57)
        Me.Button3.TabIndex = 2
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(0, 134)
        Me.Button4.Margin = New System.Windows.Forms.Padding(0, 4, 0, 4)
        Me.Button4.Name = "Button4"
        Me.Button4.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
        Me.Button4.Size = New System.Drawing.Size(846, 57)
        Me.Button4.TabIndex = 3
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(0, 329)
        Me.Button5.Margin = New System.Windows.Forms.Padding(0, 4, 0, 4)
        Me.Button5.Name = "Button5"
        Me.Button5.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
        Me.Button5.Size = New System.Drawing.Size(846, 58)
        Me.Button5.TabIndex = 4
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Button6.BackColor = System.Drawing.Color.Transparent
        Me.Button6.BackgroundImage = CType(resources.GetObject("Button6.BackgroundImage"), System.Drawing.Image)
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver
        Me.Button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(0, 264)
        Me.Button6.Margin = New System.Windows.Forms.Padding(0, 4, 0, 4)
        Me.Button6.Name = "Button6"
        Me.Button6.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
        Me.Button6.Size = New System.Drawing.Size(846, 57)
        Me.Button6.TabIndex = 0
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Button7.BackColor = System.Drawing.Color.Transparent
        Me.Button7.BackgroundImage = CType(resources.GetObject("Button7.BackgroundImage"), System.Drawing.Image)
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver
        Me.Button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.Button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(0, 4)
        Me.Button7.Margin = New System.Windows.Forms.Padding(0, 4, 0, 4)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(846, 57)
        Me.Button7.TabIndex = 0
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Btn_Cancelar
        '
        Me.Btn_Cancelar.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btn_Cancelar.FlatAppearance.BorderSize = 0
        Me.Btn_Cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Cancelar.Image = Global.Presentacion.My.Resources.Resources.BtnCancelar
        Me.Btn_Cancelar.Location = New System.Drawing.Point(57, 744)
        Me.Btn_Cancelar.Margin = New System.Windows.Forms.Padding(0)
        Me.Btn_Cancelar.Name = "Btn_Cancelar"
        Me.Btn_Cancelar.Size = New System.Drawing.Size(162, 54)
        Me.Btn_Cancelar.TabIndex = 1
        Me.Btn_Cancelar.UseVisualStyleBackColor = False
        '
        'Btn_Aceptar
        '
        Me.Btn_Aceptar.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Aceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btn_Aceptar.FlatAppearance.BorderSize = 0
        Me.Btn_Aceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Btn_Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Aceptar.Image = Global.Presentacion.My.Resources.Resources.BtnAceptar
        Me.Btn_Aceptar.Location = New System.Drawing.Point(740, 744)
        Me.Btn_Aceptar.Margin = New System.Windows.Forms.Padding(0)
        Me.Btn_Aceptar.Name = "Btn_Aceptar"
        Me.Btn_Aceptar.Size = New System.Drawing.Size(162, 54)
        Me.Btn_Aceptar.TabIndex = 1
        Me.Btn_Aceptar.UseVisualStyleBackColor = False
        '
        'F_Sintomas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BackgroundImage = Global.Presentacion.My.Resources.Resources.Síntomas_Panel
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1920, 1080)
        Me.Controls.Add(Me.LeftPanel)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.Name = "F_Sintomas"
        Me.Text = "Seleccionar Síntomas"
        Me.LeftPanel.ResumeLayout(False)
        Me.LeftPanel.PerformLayout()
        CType(Me.PicBgSintomasIngresados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tblPane.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Btn_HC As Button
    Friend WithEvents lbl_SintomasIng As Label
    Friend WithEvents LeftPanel As Panel
    Friend WithEvents Btn_Cancelar As Button
    Friend WithEvents Btn_Aceptar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PicBgSintomasIngresados As PictureBox
    Friend WithEvents tblPane As TableLayoutPanel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
End Class
