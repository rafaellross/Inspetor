<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmParametros
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmParametros))
        Me.btParamOK = New System.Windows.Forms.Button()
        Me.tbParamCaminhoLog = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbLog = New System.Windows.Forms.CheckBox()
        Me.btParamSalvar = New System.Windows.Forms.Button()
        Me.btParamCancelar = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btSelectFolderCriticados = New System.Windows.Forms.Button()
        Me.tSelectFolderManual = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btSelectFolderProcessados = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btSelectFolderProcessar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbParamREPCriticados = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbParamREPManual = New System.Windows.Forms.TextBox()
        Me.tbParamREPProcessar = New System.Windows.Forms.TextBox()
        Me.tbParamREPProcessados = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbParamBDAlias = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbParamBDServer = New System.Windows.Forms.TextBox()
        Me.tbParamBDPwd = New System.Windows.Forms.TextBox()
        Me.btParamTestaConex = New System.Windows.Forms.Button()
        Me.tbParamBDUser = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtUserErp = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtSenhaErp = New System.Windows.Forms.TextBox()
        Me.txtServidorErp = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtBancoErp = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btParamOK
        '
        Me.btParamOK.Location = New System.Drawing.Point(534, 329)
        Me.btParamOK.Name = "btParamOK"
        Me.btParamOK.Size = New System.Drawing.Size(75, 23)
        Me.btParamOK.TabIndex = 0
        Me.btParamOK.Text = "OK"
        Me.btParamOK.UseVisualStyleBackColor = True
        '
        'tbParamCaminhoLog
        '
        Me.tbParamCaminhoLog.Location = New System.Drawing.Point(113, 23)
        Me.tbParamCaminhoLog.Name = "tbParamCaminhoLog"
        Me.tbParamCaminhoLog.Size = New System.Drawing.Size(438, 20)
        Me.tbParamCaminhoLog.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Caminho do Log"
        '
        'cbLog
        '
        Me.cbLog.AutoSize = True
        Me.cbLog.Checked = True
        Me.cbLog.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbLog.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbLog.Location = New System.Drawing.Point(12, 70)
        Me.cbLog.Name = "cbLog"
        Me.cbLog.Size = New System.Drawing.Size(80, 17)
        Me.cbLog.TabIndex = 0
        Me.cbLog.Text = "Ativa Log"
        Me.cbLog.UseVisualStyleBackColor = True
        '
        'btParamSalvar
        '
        Me.btParamSalvar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btParamSalvar.Location = New System.Drawing.Point(372, 329)
        Me.btParamSalvar.Name = "btParamSalvar"
        Me.btParamSalvar.Size = New System.Drawing.Size(75, 23)
        Me.btParamSalvar.TabIndex = 5
        Me.btParamSalvar.Text = "Salvar"
        Me.btParamSalvar.UseVisualStyleBackColor = True
        '
        'btParamCancelar
        '
        Me.btParamCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btParamCancelar.Location = New System.Drawing.Point(453, 329)
        Me.btParamCancelar.Name = "btParamCancelar"
        Me.btParamCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btParamCancelar.TabIndex = 6
        Me.btParamCancelar.Text = "Cancelar"
        Me.btParamCancelar.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(12, 19)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(614, 304)
        Me.TabControl1.TabIndex = 8
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPage1.Controls.Add(Me.btSelectFolderCriticados)
        Me.TabPage1.Controls.Add(Me.tSelectFolderManual)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.btSelectFolderProcessados)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.btSelectFolderProcessar)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.tbParamREPCriticados)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.tbParamREPManual)
        Me.TabPage1.Controls.Add(Me.tbParamREPProcessar)
        Me.TabPage1.Controls.Add(Me.tbParamREPProcessados)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(606, 278)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Repositório"
        '
        'btSelectFolderCriticados
        '
        Me.btSelectFolderCriticados.Location = New System.Drawing.Point(531, 110)
        Me.btSelectFolderCriticados.Name = "btSelectFolderCriticados"
        Me.btSelectFolderCriticados.Size = New System.Drawing.Size(30, 23)
        Me.btSelectFolderCriticados.TabIndex = 13
        Me.btSelectFolderCriticados.Text = "..."
        Me.btSelectFolderCriticados.UseVisualStyleBackColor = True
        '
        'tSelectFolderManual
        '
        Me.tSelectFolderManual.Location = New System.Drawing.Point(531, 79)
        Me.tSelectFolderManual.Name = "tSelectFolderManual"
        Me.tSelectFolderManual.Size = New System.Drawing.Size(30, 23)
        Me.tSelectFolderManual.TabIndex = 12
        Me.tSelectFolderManual.Text = "..."
        Me.tSelectFolderManual.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(19, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Processar"
        '
        'btSelectFolderProcessados
        '
        Me.btSelectFolderProcessados.Location = New System.Drawing.Point(531, 48)
        Me.btSelectFolderProcessados.Name = "btSelectFolderProcessados"
        Me.btSelectFolderProcessados.Size = New System.Drawing.Size(30, 23)
        Me.btSelectFolderProcessados.TabIndex = 11
        Me.btSelectFolderProcessados.Text = "..."
        Me.btSelectFolderProcessados.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 54)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Processados"
        '
        'btSelectFolderProcessar
        '
        Me.btSelectFolderProcessar.Location = New System.Drawing.Point(531, 17)
        Me.btSelectFolderProcessar.Name = "btSelectFolderProcessar"
        Me.btSelectFolderProcessar.Size = New System.Drawing.Size(30, 23)
        Me.btSelectFolderProcessar.TabIndex = 10
        Me.btSelectFolderProcessar.Text = "..."
        Me.btSelectFolderProcessar.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(34, 85)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Manual"
        '
        'tbParamREPCriticados
        '
        Me.tbParamREPCriticados.Enabled = False
        Me.tbParamREPCriticados.Location = New System.Drawing.Point(92, 113)
        Me.tbParamREPCriticados.Name = "tbParamREPCriticados"
        Me.tbParamREPCriticados.Size = New System.Drawing.Size(433, 20)
        Me.tbParamREPCriticados.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(19, 116)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 13)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Criticados"
        '
        'tbParamREPManual
        '
        Me.tbParamREPManual.Enabled = False
        Me.tbParamREPManual.Location = New System.Drawing.Point(92, 82)
        Me.tbParamREPManual.Name = "tbParamREPManual"
        Me.tbParamREPManual.Size = New System.Drawing.Size(433, 20)
        Me.tbParamREPManual.TabIndex = 8
        '
        'tbParamREPProcessar
        '
        Me.tbParamREPProcessar.Enabled = False
        Me.tbParamREPProcessar.Location = New System.Drawing.Point(92, 20)
        Me.tbParamREPProcessar.Name = "tbParamREPProcessar"
        Me.tbParamREPProcessar.Size = New System.Drawing.Size(433, 20)
        Me.tbParamREPProcessar.TabIndex = 6
        '
        'tbParamREPProcessados
        '
        Me.tbParamREPProcessados.Enabled = False
        Me.tbParamREPProcessados.Location = New System.Drawing.Point(92, 51)
        Me.tbParamREPProcessados.Name = "tbParamREPProcessados"
        Me.tbParamREPProcessados.Size = New System.Drawing.Size(433, 20)
        Me.tbParamREPProcessados.TabIndex = 7
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(606, 278)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Banco de Dados"
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPage4.Controls.Add(Me.Button1)
        Me.TabPage4.Controls.Add(Me.tbParamCaminhoLog)
        Me.TabPage4.Controls.Add(Me.Label1)
        Me.TabPage4.Controls.Add(Me.cbLog)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(606, 278)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Log"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(557, 20)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(30, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(72, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Senha"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(61, 100)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 13)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Servidor"
        '
        'tbParamBDAlias
        '
        Me.tbParamBDAlias.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbParamBDAlias.Location = New System.Drawing.Point(135, 71)
        Me.tbParamBDAlias.Name = "tbParamBDAlias"
        Me.tbParamBDAlias.Size = New System.Drawing.Size(125, 20)
        Me.tbParamBDAlias.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(65, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Usuário"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Banco de Dados"
        '
        'tbParamBDServer
        '
        Me.tbParamBDServer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbParamBDServer.Location = New System.Drawing.Point(135, 97)
        Me.tbParamBDServer.Name = "tbParamBDServer"
        Me.tbParamBDServer.Size = New System.Drawing.Size(125, 20)
        Me.tbParamBDServer.TabIndex = 4
        '
        'tbParamBDPwd
        '
        Me.tbParamBDPwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbParamBDPwd.Location = New System.Drawing.Point(135, 45)
        Me.tbParamBDPwd.Name = "tbParamBDPwd"
        Me.tbParamBDPwd.Size = New System.Drawing.Size(125, 20)
        Me.tbParamBDPwd.TabIndex = 2
        '
        'btParamTestaConex
        '
        Me.btParamTestaConex.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btParamTestaConex.Location = New System.Drawing.Point(147, 123)
        Me.btParamTestaConex.Name = "btParamTestaConex"
        Me.btParamTestaConex.Size = New System.Drawing.Size(113, 23)
        Me.btParamTestaConex.TabIndex = 7
        Me.btParamTestaConex.Text = "Testar Conexão..."
        Me.btParamTestaConex.UseVisualStyleBackColor = True
        '
        'tbParamBDUser
        '
        Me.tbParamBDUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbParamBDUser.Location = New System.Drawing.Point(135, 19)
        Me.tbParamBDUser.Name = "tbParamBDUser"
        Me.tbParamBDUser.Size = New System.Drawing.Size(125, 20)
        Me.tbParamBDUser.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tbParamBDUser)
        Me.GroupBox1.Controls.Add(Me.btParamTestaConex)
        Me.GroupBox1.Controls.Add(Me.tbParamBDPwd)
        Me.GroupBox1.Controls.Add(Me.tbParamBDServer)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.tbParamBDAlias)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(279, 264)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "InspetorXML"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtUserErp)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.txtSenhaErp)
        Me.GroupBox2.Controls.Add(Me.txtServidorErp)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txtBancoErp)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Enabled = False
        Me.GroupBox2.Location = New System.Drawing.Point(288, 14)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(279, 264)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ERP"
        '
        'txtUserErp
        '
        Me.txtUserErp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserErp.Location = New System.Drawing.Point(135, 19)
        Me.txtUserErp.Name = "txtUserErp"
        Me.txtUserErp.Size = New System.Drawing.Size(125, 20)
        Me.txtUserErp.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(147, 123)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(113, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Testar Conexão..."
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtSenhaErp
        '
        Me.txtSenhaErp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSenhaErp.Location = New System.Drawing.Point(135, 45)
        Me.txtSenhaErp.Name = "txtSenhaErp"
        Me.txtSenhaErp.Size = New System.Drawing.Size(125, 20)
        Me.txtSenhaErp.TabIndex = 2
        '
        'txtServidorErp
        '
        Me.txtServidorErp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtServidorErp.Location = New System.Drawing.Point(135, 97)
        Me.txtServidorErp.Name = "txtServidorErp"
        Me.txtServidorErp.Size = New System.Drawing.Size(125, 20)
        Me.txtServidorErp.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(14, 74)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(101, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Banco de Dados"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(65, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(50, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Usuário"
        '
        'txtBancoErp
        '
        Me.txtBancoErp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBancoErp.Location = New System.Drawing.Point(135, 71)
        Me.txtBancoErp.Name = "txtBancoErp"
        Me.txtBancoErp.Size = New System.Drawing.Size(125, 20)
        Me.txtBancoErp.TabIndex = 3
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(61, 100)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(54, 13)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Servidor"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(72, 48)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(43, 13)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Senha"
        '
        'frmParametros
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(638, 372)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btParamCancelar)
        Me.Controls.Add(Me.btParamSalvar)
        Me.Controls.Add(Me.btParamOK)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmParametros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Parâmetros"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btParamOK As System.Windows.Forms.Button
    Protected Friend WithEvents cbLog As System.Windows.Forms.CheckBox
    Friend WithEvents tbParamCaminhoLog As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btParamSalvar As System.Windows.Forms.Button
    Friend WithEvents btParamCancelar As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents btSelectFolderCriticados As System.Windows.Forms.Button
    Friend WithEvents tSelectFolderManual As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btSelectFolderProcessados As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btSelectFolderProcessar As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tbParamREPCriticados As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tbParamREPManual As System.Windows.Forms.TextBox
    Friend WithEvents tbParamREPProcessar As System.Windows.Forms.TextBox
    Friend WithEvents tbParamREPProcessados As System.Windows.Forms.TextBox
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtUserErp As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents txtSenhaErp As TextBox
    Friend WithEvents txtServidorErp As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtBancoErp As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tbParamBDUser As TextBox
    Friend WithEvents btParamTestaConex As Button
    Friend WithEvents tbParamBDPwd As TextBox
    Friend WithEvents tbParamBDServer As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbParamBDAlias As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label3 As Label
End Class
