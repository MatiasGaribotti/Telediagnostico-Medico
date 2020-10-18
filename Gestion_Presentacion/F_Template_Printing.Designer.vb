<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_Template_Printing
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
        Me.PnlPrint = New Guna.UI2.WinForms.Guna2Panel()
        Me.PicLogo = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.LblPassword = New System.Windows.Forms.Label()
        Me.LblUser = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PrintDoc = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PnlPrint.SuspendLayout()
        CType(Me.PicLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlPrint
        '
        Me.PnlPrint.Controls.Add(Me.PicLogo)
        Me.PnlPrint.Controls.Add(Me.LblPassword)
        Me.PnlPrint.Controls.Add(Me.LblUser)
        Me.PnlPrint.Controls.Add(Me.Label2)
        Me.PnlPrint.Controls.Add(Me.Label1)
        Me.PnlPrint.FillColor = System.Drawing.Color.White
        Me.PnlPrint.Location = New System.Drawing.Point(3, 2)
        Me.PnlPrint.Name = "PnlPrint"
        Me.PnlPrint.ShadowDecoration.Parent = Me.PnlPrint
        Me.PnlPrint.Size = New System.Drawing.Size(187, 277)
        Me.PnlPrint.TabIndex = 1
        '
        'PicLogo
        '
        Me.PicLogo.Image = Global.Presentacion.My.Resources.Resources.st_logo_64x64
        Me.PicLogo.Location = New System.Drawing.Point(58, 16)
        Me.PicLogo.Name = "PicLogo"
        Me.PicLogo.ShadowDecoration.Parent = Me.PicLogo
        Me.PicLogo.Size = New System.Drawing.Size(64, 64)
        Me.PicLogo.TabIndex = 4
        Me.PicLogo.TabStop = False
        '
        'LblPassword
        '
        Me.LblPassword.AutoSize = True
        Me.LblPassword.BackColor = System.Drawing.Color.White
        Me.LblPassword.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPassword.Location = New System.Drawing.Point(15, 195)
        Me.LblPassword.Name = "LblPassword"
        Me.LblPassword.Size = New System.Drawing.Size(57, 14)
        Me.LblPassword.TabIndex = 3
        Me.LblPassword.Text = "contraseña"
        '
        'LblUser
        '
        Me.LblUser.AutoSize = True
        Me.LblUser.BackColor = System.Drawing.Color.White
        Me.LblUser.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUser.Location = New System.Drawing.Point(55, 126)
        Me.LblUser.Name = "LblUser"
        Me.LblUser.Size = New System.Drawing.Size(55, 14)
        Me.LblUser.TabIndex = 2
        Me.LblUser.Text = "11111111"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(48, 165)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Contraseña"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(54, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario"
        '
        'PrintDoc
        '
        '
        'PrintDialog1
        '
        Me.PrintDialog1.PrintToFile = True
        Me.PrintDialog1.UseEXDialog = True
        '
        'F_Template_Printing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(192, 282)
        Me.Controls.Add(Me.PnlPrint)
        Me.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "F_Template_Printing"
        Me.Text = "F_Template_Printing"
        Me.PnlPrint.ResumeLayout(False)
        Me.PnlPrint.PerformLayout()
        CType(Me.PicLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlPrint As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents PicLogo As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents LblPassword As Label
    Friend WithEvents LblUser As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PrintDoc As Printing.PrintDocument
    Friend WithEvents PrintDialog1 As PrintDialog
End Class
