<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChatUtilities
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.BtnSend = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.TxtMsg = New Guna.UI2.WinForms.Guna2TextBox()
        Me.SuspendLayout()
        '
        'BtnSend
        '
        Me.BtnSend.CheckedState.Parent = Me.BtnSend
        Me.BtnSend.CustomImages.Parent = Me.BtnSend
        Me.BtnSend.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.BtnSend.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnSend.ForeColor = System.Drawing.Color.White
        Me.BtnSend.HoverState.Parent = Me.BtnSend
        Me.BtnSend.Image = Global.Medico_Presentacion.My.Resources.Resources.send_icon
        Me.BtnSend.ImageOffset = New System.Drawing.Point(2, 0)
        Me.BtnSend.ImageSize = New System.Drawing.Size(38, 34)
        Me.BtnSend.Location = New System.Drawing.Point(1313, 10)
        Me.BtnSend.Margin = New System.Windows.Forms.Padding(3, 25, 3, 25)
        Me.BtnSend.Name = "BtnSend"
        Me.BtnSend.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.BtnSend.ShadowDecoration.Parent = Me.BtnSend
        Me.BtnSend.Size = New System.Drawing.Size(70, 70)
        Me.BtnSend.TabIndex = 8
        '
        'TxtMsg
        '
        Me.TxtMsg.Animated = True
        Me.TxtMsg.AutoRoundedCorners = True
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
        Me.TxtMsg.Font = New System.Drawing.Font("Roboto", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMsg.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtMsg.HoverState.Parent = Me.TxtMsg
        Me.TxtMsg.Location = New System.Drawing.Point(0, 10)
        Me.TxtMsg.Margin = New System.Windows.Forms.Padding(40, 29, 40, 29)
        Me.TxtMsg.Name = "TxtMsg"
        Me.TxtMsg.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtMsg.PlaceholderText = ""
        Me.TxtMsg.SelectedText = ""
        Me.TxtMsg.ShadowDecoration.Parent = Me.TxtMsg
        Me.TxtMsg.Size = New System.Drawing.Size(1295, 70)
        Me.TxtMsg.TabIndex = 7
        '
        'ChatUtilities
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.BtnSend)
        Me.Controls.Add(Me.TxtMsg)
        Me.Name = "ChatUtilities"
        Me.Size = New System.Drawing.Size(1387, 86)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnSend As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents TxtMsg As Guna.UI2.WinForms.Guna2TextBox
End Class
