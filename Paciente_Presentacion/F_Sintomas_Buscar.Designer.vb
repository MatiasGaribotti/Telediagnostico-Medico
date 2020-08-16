<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F_Sintomas_Buscar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_Sintomas_Buscar))
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.BtnCross = New System.Windows.Forms.Button()
        Me.TxtBuscador = New System.Windows.Forms.TextBox()
        Me.PnlBackgroundBuscador = New System.Windows.Forms.Panel()
        Me.PicBgSintomasIngresados = New System.Windows.Forms.PictureBox()
        Me.tblPane = New System.Windows.Forms.TableLayoutPanel()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.BtnVolver = New Guna.UI2.WinForms.Guna2Button()
        Me.PnlBackgroundBuscador.SuspendLayout()
        CType(Me.PicBgSintomasIngresados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tblPane.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnSearch
        '
        Me.BtnSearch.BackColor = System.Drawing.Color.Transparent
        Me.BtnSearch.BackgroundImage = Global.Presentacion.My.Resources.Resources.search_65x65
        Me.BtnSearch.FlatAppearance.BorderSize = 0
        Me.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSearch.Location = New System.Drawing.Point(835, 151)
        Me.BtnSearch.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(65, 65)
        Me.BtnSearch.TabIndex = 4
        Me.BtnSearch.UseVisualStyleBackColor = False
        '
        'BtnCross
        '
        Me.BtnCross.BackColor = System.Drawing.Color.Transparent
        Me.BtnCross.BackgroundImage = Global.Presentacion.My.Resources.Resources.cross_65x65
        Me.BtnCross.FlatAppearance.BorderSize = 0
        Me.BtnCross.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCross.Location = New System.Drawing.Point(394, 151)
        Me.BtnCross.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnCross.Name = "BtnCross"
        Me.BtnCross.Size = New System.Drawing.Size(65, 65)
        Me.BtnCross.TabIndex = 5
        Me.BtnCross.UseVisualStyleBackColor = False
        '
        'TxtBuscador
        '
        Me.TxtBuscador.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtBuscador.Font = New System.Drawing.Font("Roboto", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBuscador.Location = New System.Drawing.Point(1, 19)
        Me.TxtBuscador.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtBuscador.Name = "TxtBuscador"
        Me.TxtBuscador.Size = New System.Drawing.Size(375, 23)
        Me.TxtBuscador.TabIndex = 3
        '
        'PnlBackgroundBuscador
        '
        Me.PnlBackgroundBuscador.BackColor = System.Drawing.Color.White
        Me.PnlBackgroundBuscador.Controls.Add(Me.TxtBuscador)
        Me.PnlBackgroundBuscador.Location = New System.Drawing.Point(458, 151)
        Me.PnlBackgroundBuscador.Name = "PnlBackgroundBuscador"
        Me.PnlBackgroundBuscador.Size = New System.Drawing.Size(398, 65)
        Me.PnlBackgroundBuscador.TabIndex = 6
        '
        'PicBgSintomasIngresados
        '
        Me.PicBgSintomasIngresados.BackgroundImage = Global.Presentacion.My.Resources.Resources.Síntomas_L
        Me.PicBgSintomasIngresados.Location = New System.Drawing.Point(47, 294)
        Me.PicBgSintomasIngresados.Margin = New System.Windows.Forms.Padding(0)
        Me.PicBgSintomasIngresados.Name = "PicBgSintomasIngresados"
        Me.PicBgSintomasIngresados.Size = New System.Drawing.Size(7, 391)
        Me.PicBgSintomasIngresados.TabIndex = 8
        Me.PicBgSintomasIngresados.TabStop = False
        '
        'tblPane
        '
        Me.tblPane.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.tblPane.ColumnCount = 1
        Me.tblPane.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblPane.Controls.Add(Me.Button10, 0, 8)
        Me.tblPane.Controls.Add(Me.Button9, 0, 7)
        Me.tblPane.Controls.Add(Me.Button8, 0, 6)
        Me.tblPane.Controls.Add(Me.Button1, 0, 6)
        Me.tblPane.Controls.Add(Me.Button2, 0, 3)
        Me.tblPane.Controls.Add(Me.Button3, 0, 1)
        Me.tblPane.Controls.Add(Me.Button4, 0, 2)
        Me.tblPane.Controls.Add(Me.Button5, 0, 5)
        Me.tblPane.Controls.Add(Me.Button6, 0, 4)
        Me.tblPane.Controls.Add(Me.Button7, 0, 0)
        Me.tblPane.Location = New System.Drawing.Point(54, 294)
        Me.tblPane.Name = "tblPane"
        Me.tblPane.RowCount = 9
        Me.tblPane.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tblPane.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tblPane.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tblPane.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.94203!))
        Me.tblPane.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.70048!))
        Me.tblPane.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.35749!))
        Me.tblPane.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69.0!))
        Me.tblPane.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68.0!))
        Me.tblPane.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63.0!))
        Me.tblPane.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71.0!))
        Me.tblPane.Size = New System.Drawing.Size(846, 633)
        Me.tblPane.TabIndex = 7
        '
        'Button10
        '
        Me.Button10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Button10.BackColor = System.Drawing.Color.Transparent
        Me.Button10.BackgroundImage = CType(resources.GetObject("Button10.BackgroundImage"), System.Drawing.Image)
        Me.Button10.FlatAppearance.BorderSize = 0
        Me.Button10.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver
        Me.Button10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.Button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.Location = New System.Drawing.Point(0, 563)
        Me.Button10.Margin = New System.Windows.Forms.Padding(0, 4, 0, 4)
        Me.Button10.Name = "Button10"
        Me.Button10.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
        Me.Button10.Size = New System.Drawing.Size(846, 66)
        Me.Button10.TabIndex = 8
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Button9.BackColor = System.Drawing.Color.Transparent
        Me.Button9.BackgroundImage = CType(resources.GetObject("Button9.BackgroundImage"), System.Drawing.Image)
        Me.Button9.FlatAppearance.BorderSize = 0
        Me.Button9.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver
        Me.Button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.Button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(0, 500)
        Me.Button9.Margin = New System.Windows.Forms.Padding(0, 4, 0, 4)
        Me.Button9.Name = "Button9"
        Me.Button9.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
        Me.Button9.Size = New System.Drawing.Size(846, 55)
        Me.Button9.TabIndex = 7
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Button8.BackColor = System.Drawing.Color.Transparent
        Me.Button8.BackgroundImage = CType(resources.GetObject("Button8.BackgroundImage"), System.Drawing.Image)
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver
        Me.Button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.Button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(0, 432)
        Me.Button8.Margin = New System.Windows.Forms.Padding(0, 4, 0, 4)
        Me.Button8.Name = "Button8"
        Me.Button8.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
        Me.Button8.Size = New System.Drawing.Size(846, 60)
        Me.Button8.TabIndex = 6
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(0, 363)
        Me.Button1.Margin = New System.Windows.Forms.Padding(0, 4, 0, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
        Me.Button1.Size = New System.Drawing.Size(846, 61)
        Me.Button1.TabIndex = 5
        Me.Button1.UseVisualStyleBackColor = False
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
        Me.Button2.Location = New System.Drawing.Point(0, 184)
        Me.Button2.Margin = New System.Windows.Forms.Padding(0, 4, 0, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
        Me.Button2.Size = New System.Drawing.Size(846, 49)
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
        Me.Button3.Location = New System.Drawing.Point(0, 64)
        Me.Button3.Margin = New System.Windows.Forms.Padding(0, 4, 0, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
        Me.Button3.Size = New System.Drawing.Size(846, 52)
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
        Me.Button4.Location = New System.Drawing.Point(0, 124)
        Me.Button4.Margin = New System.Windows.Forms.Padding(0, 4, 0, 4)
        Me.Button4.Name = "Button4"
        Me.Button4.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
        Me.Button4.Size = New System.Drawing.Size(846, 52)
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
        Me.Button5.Location = New System.Drawing.Point(0, 297)
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
        Me.Button6.Location = New System.Drawing.Point(0, 241)
        Me.Button6.Margin = New System.Windows.Forms.Padding(0, 4, 0, 4)
        Me.Button6.Name = "Button6"
        Me.Button6.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
        Me.Button6.Size = New System.Drawing.Size(846, 48)
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
        Me.Button7.Size = New System.Drawing.Size(846, 52)
        Me.Button7.TabIndex = 0
        Me.Button7.UseVisualStyleBackColor = False
        '
        'BtnVolver
        '
        Me.BtnVolver.Animated = True
        Me.BtnVolver.AutoRoundedCorners = True
        Me.BtnVolver.BackColor = System.Drawing.Color.Transparent
        Me.BtnVolver.BorderRadius = 20
        Me.BtnVolver.CheckedState.Parent = Me.BtnVolver
        Me.BtnVolver.CustomImages.Parent = Me.BtnVolver
        Me.BtnVolver.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.BtnVolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.BtnVolver.ForeColor = System.Drawing.Color.White
        Me.BtnVolver.HoverState.Parent = Me.BtnVolver
        Me.BtnVolver.Location = New System.Drawing.Point(778, 958)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.ShadowDecoration.Parent = Me.BtnVolver
        Me.BtnVolver.Size = New System.Drawing.Size(122, 43)
        Me.BtnVolver.TabIndex = 92
        Me.BtnVolver.Text = "Volver"
        Me.BtnVolver.UseTransparentBackground = True
        '
        'F_Sintomas_Buscar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(960, 1080)
        Me.Controls.Add(Me.BtnVolver)
        Me.Controls.Add(Me.PicBgSintomasIngresados)
        Me.Controls.Add(Me.tblPane)
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.BtnCross)
        Me.Controls.Add(Me.PnlBackgroundBuscador)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "F_Sintomas_Buscar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "F_Sintomas_Buscar"
        Me.PnlBackgroundBuscador.ResumeLayout(False)
        Me.PnlBackgroundBuscador.PerformLayout()
        CType(Me.PicBgSintomasIngresados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tblPane.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnSearch As Button
    Friend WithEvents BtnCross As Button
    Friend WithEvents TxtBuscador As TextBox
    Friend WithEvents PnlBackgroundBuscador As Panel
    Friend WithEvents PicBgSintomasIngresados As PictureBox
    Friend WithEvents tblPane As TableLayoutPanel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents BtnVolver As Guna.UI2.WinForms.Guna2Button
End Class
