<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.txtSenha = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'button2
        '
        Me.button2.Location = New System.Drawing.Point(177, 92)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(75, 23)
        Me.button2.TabIndex = 11
        Me.button2.Text = "Cancelar"
        Me.button2.UseVisualStyleBackColor = True
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(96, 92)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(75, 23)
        Me.button1.TabIndex = 10
        Me.button1.Text = "Entrar"
        Me.button1.UseVisualStyleBackColor = True
        '
        'txtSenha
        '
        Me.txtSenha.Location = New System.Drawing.Point(116, 56)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenha.Size = New System.Drawing.Size(136, 20)
        Me.txtSenha.TabIndex = 9
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(64, 57)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(46, 15)
        Me.label2.TabIndex = 8
        Me.label2.Text = "Senha:"
        Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(116, 25)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(136, 20)
        Me.txtUsuario.TabIndex = 7
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(59, 26)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(53, 15)
        Me.label1.TabIndex = 6
        Me.label1.Text = "Usuário:"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(311, 140)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.txtSenha)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login Inspetor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents button2 As Button
    Private WithEvents button1 As Button
    Private WithEvents txtSenha As TextBox
    Private WithEvents label2 As Label
    Private WithEvents txtUsuario As TextBox
    Private WithEvents label1 As Label
End Class
