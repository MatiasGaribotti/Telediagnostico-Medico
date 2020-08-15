<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_Sintomas_Buscar_Tipo
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
        Me.TxtBuscador = New System.Windows.Forms.TextBox()
        Me.BtnCross = New System.Windows.Forms.Button()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.PnlBackgroundBuscador = New System.Windows.Forms.Panel()
        Me.PicCabeza = New System.Windows.Forms.PictureBox()
        Me.PicTorso = New System.Windows.Forms.PictureBox()
        Me.PicExtremidades = New System.Windows.Forms.PictureBox()
        Me.lblCabeza = New System.Windows.Forms.Label()
        Me.LblTorso = New System.Windows.Forms.Label()
        Me.LblExtremidades = New System.Windows.Forms.Label()
        CType(Me.PicCabeza, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicTorso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicExtremidades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtBuscador
        '
        Me.TxtBuscador.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtBuscador.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!)
        Me.TxtBuscador.Location = New System.Drawing.Point(291, 82)
        Me.TxtBuscador.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtBuscador.Name = "TxtBuscador"
        Me.TxtBuscador.Size = New System.Drawing.Size(375, 43)
        Me.TxtBuscador.TabIndex = 0
        '
        'BtnCross
        '
        Me.BtnCross.BackColor = System.Drawing.Color.Transparent
        Me.BtnCross.BackgroundImage = Global.Presentacion.My.Resources.Resources.cross_65x65
        Me.BtnCross.FlatAppearance.BorderSize = 0
        Me.BtnCross.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCross.Location = New System.Drawing.Point(226, 73)
        Me.BtnCross.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnCross.Name = "BtnCross"
        Me.BtnCross.Size = New System.Drawing.Size(65, 65)
        Me.BtnCross.TabIndex = 1
        Me.BtnCross.UseVisualStyleBackColor = False
        '
        'BtnSearch
        '
        Me.BtnSearch.BackColor = System.Drawing.Color.Transparent
        Me.BtnSearch.BackgroundImage = Global.Presentacion.My.Resources.Resources.search_65x65
        Me.BtnSearch.FlatAppearance.BorderSize = 0
        Me.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSearch.Location = New System.Drawing.Point(667, 73)
        Me.BtnSearch.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(65, 65)
        Me.BtnSearch.TabIndex = 1
        Me.BtnSearch.UseVisualStyleBackColor = False
        '
        'PnlBackgroundBuscador
        '
        Me.PnlBackgroundBuscador.BackColor = System.Drawing.Color.White
        Me.PnlBackgroundBuscador.Location = New System.Drawing.Point(290, 73)
        Me.PnlBackgroundBuscador.Name = "PnlBackgroundBuscador"
        Me.PnlBackgroundBuscador.Size = New System.Drawing.Size(376, 65)
        Me.PnlBackgroundBuscador.TabIndex = 2
        '
        'PicCabeza
        '
        Me.PicCabeza.Location = New System.Drawing.Point(85, 400)
        Me.PicCabeza.Margin = New System.Windows.Forms.Padding(20)
        Me.PicCabeza.Name = "PicCabeza"
        Me.PicCabeza.Size = New System.Drawing.Size(250, 250)
        Me.PicCabeza.TabIndex = 3
        Me.PicCabeza.TabStop = False
        '
        'PicTorso
        '
        Me.PicTorso.Location = New System.Drawing.Point(355, 400)
        Me.PicTorso.Margin = New System.Windows.Forms.Padding(20)
        Me.PicTorso.Name = "PicTorso"
        Me.PicTorso.Size = New System.Drawing.Size(250, 250)
        Me.PicTorso.TabIndex = 3
        Me.PicTorso.TabStop = False
        '
        'PicExtremidades
        '
        Me.PicExtremidades.Location = New System.Drawing.Point(624, 400)
        Me.PicExtremidades.Margin = New System.Windows.Forms.Padding(20)
        Me.PicExtremidades.Name = "PicExtremidades"
        Me.PicExtremidades.Size = New System.Drawing.Size(250, 250)
        Me.PicExtremidades.TabIndex = 3
        Me.PicExtremidades.TabStop = False
        '
        'lblCabeza
        '
        Me.lblCabeza.AutoSize = True
        Me.lblCabeza.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCabeza.Location = New System.Drawing.Point(164, 670)
        Me.lblCabeza.Name = "lblCabeza"
        Me.lblCabeza.Size = New System.Drawing.Size(86, 25)
        Me.lblCabeza.TabIndex = 4
        Me.lblCabeza.Text = "Cabeza"
        '
        'LblTorso
        '
        Me.LblTorso.AutoSize = True
        Me.LblTorso.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTorso.Location = New System.Drawing.Point(438, 670)
        Me.LblTorso.Name = "LblTorso"
        Me.LblTorso.Size = New System.Drawing.Size(67, 25)
        Me.LblTorso.TabIndex = 4
        Me.LblTorso.Text = "Torso"
        '
        'LblExtremidades
        '
        Me.LblExtremidades.AutoSize = True
        Me.LblExtremidades.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblExtremidades.Location = New System.Drawing.Point(689, 670)
        Me.LblExtremidades.Name = "LblExtremidades"
        Me.LblExtremidades.Size = New System.Drawing.Size(143, 25)
        Me.LblExtremidades.TabIndex = 4
        Me.LblExtremidades.Text = "Extremidades"
        '
        'F_Sintomas_Buscar_Tipo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(960, 1080)
        Me.Controls.Add(Me.LblExtremidades)
        Me.Controls.Add(Me.LblTorso)
        Me.Controls.Add(Me.lblCabeza)
        Me.Controls.Add(Me.PicExtremidades)
        Me.Controls.Add(Me.PicTorso)
        Me.Controls.Add(Me.PicCabeza)
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.BtnCross)
        Me.Controls.Add(Me.TxtBuscador)
        Me.Controls.Add(Me.PnlBackgroundBuscador)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "F_Sintomas_Buscar_Tipo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Frm_Sintomas_Buscar_Tipo"
        CType(Me.PicCabeza, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicTorso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicExtremidades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtBuscador As TextBox
    Friend WithEvents BtnCross As Button
    Friend WithEvents BtnSearch As Button
    Friend WithEvents PnlBackgroundBuscador As Panel
    Friend WithEvents PicCabeza As PictureBox
    Friend WithEvents PicTorso As PictureBox
    Friend WithEvents PicExtremidades As PictureBox
    Friend WithEvents lblCabeza As Label
    Friend WithEvents LblTorso As Label
    Friend WithEvents LblExtremidades As Label
End Class
