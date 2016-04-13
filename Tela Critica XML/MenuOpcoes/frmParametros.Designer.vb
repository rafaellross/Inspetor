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
        Me.btParamTestaConex = New System.Windows.Forms.Button()
        Me.tbParamBDServer = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbParamBDAlias = New System.Windows.Forms.TextBox()
        Me.tbParamBDPwd = New System.Windows.Forms.TextBox()
        Me.tbParamBDUser = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
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
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.cbMail = New System.Windows.Forms.CheckBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.tbParamMailHora4 = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.tbParamMailHora3 = New System.Windows.Forms.TextBox()
        Me.tbParamMailHora2 = New System.Windows.Forms.TextBox()
        Me.tbParamMailHora1 = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.tbParamMailParaPO = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.tbParamMailParaCadastro = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.tbParamMailParaFiscal = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbParamMailPorta = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tbParamMailSMTP = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tbParamMailConta = New System.Windows.Forms.TextBox()
        Me.tbParamMailSenha = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.TabPage4.SuspendLayout()
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
        'btParamTestaConex
        '
        Me.btParamTestaConex.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btParamTestaConex.Location = New System.Drawing.Point(140, 123)
        Me.btParamTestaConex.Name = "btParamTestaConex"
        Me.btParamTestaConex.Size = New System.Drawing.Size(113, 23)
        Me.btParamTestaConex.TabIndex = 7
        Me.btParamTestaConex.Text = "Testar Conexão..."
        Me.btParamTestaConex.UseVisualStyleBackColor = True
        '
        'tbParamBDServer
        '
        Me.tbParamBDServer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbParamBDServer.Location = New System.Drawing.Point(128, 97)
        Me.tbParamBDServer.Name = "tbParamBDServer"
        Me.tbParamBDServer.Size = New System.Drawing.Size(125, 20)
        Me.tbParamBDServer.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(54, 100)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 13)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Servidor"
        '
        'tbParamBDAlias
        '
        Me.tbParamBDAlias.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbParamBDAlias.Location = New System.Drawing.Point(128, 71)
        Me.tbParamBDAlias.Name = "tbParamBDAlias"
        Me.tbParamBDAlias.Size = New System.Drawing.Size(125, 20)
        Me.tbParamBDAlias.TabIndex = 5
        '
        'tbParamBDPwd
        '
        Me.tbParamBDPwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbParamBDPwd.Location = New System.Drawing.Point(128, 45)
        Me.tbParamBDPwd.Name = "tbParamBDPwd"
        Me.tbParamBDPwd.Size = New System.Drawing.Size(125, 20)
        Me.tbParamBDPwd.TabIndex = 4
        '
        'tbParamBDUser
        '
        Me.tbParamBDUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbParamBDUser.Location = New System.Drawing.Point(128, 19)
        Me.tbParamBDUser.Name = "tbParamBDUser"
        Me.tbParamBDUser.Size = New System.Drawing.Size(125, 20)
        Me.tbParamBDUser.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Banco de Dados"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(65, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Senha"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(58, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Usuário"
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
        Me.TabControl1.Controls.Add(Me.TabPage3)
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
        Me.TabPage2.Controls.Add(Me.btParamTestaConex)
        Me.TabPage2.Controls.Add(Me.tbParamBDServer)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.tbParamBDAlias)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.tbParamBDPwd)
        Me.TabPage2.Controls.Add(Me.tbParamBDUser)
        Me.TabPage2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(606, 278)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Banco de Dados"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPage3.Controls.Add(Me.GroupBox7)
        Me.TabPage3.Controls.Add(Me.GroupBox6)
        Me.TabPage3.Controls.Add(Me.GroupBox5)
        Me.TabPage3.Controls.Add(Me.GroupBox4)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(606, 278)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "e-Mail"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.cbMail)
        Me.GroupBox7.Location = New System.Drawing.Point(379, 140)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(214, 102)
        Me.GroupBox7.TabIndex = 42
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Ativa Envio"
        '
        'cbMail
        '
        Me.cbMail.AutoSize = True
        Me.cbMail.Location = New System.Drawing.Point(77, 47)
        Me.cbMail.Name = "cbMail"
        Me.cbMail.Size = New System.Drawing.Size(50, 17)
        Me.cbMail.TabIndex = 0
        Me.cbMail.Text = "Ativo"
        Me.cbMail.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label20)
        Me.GroupBox6.Controls.Add(Me.tbParamMailHora4)
        Me.GroupBox6.Controls.Add(Me.Label19)
        Me.GroupBox6.Controls.Add(Me.Label18)
        Me.GroupBox6.Controls.Add(Me.Label17)
        Me.GroupBox6.Controls.Add(Me.tbParamMailHora3)
        Me.GroupBox6.Controls.Add(Me.tbParamMailHora2)
        Me.GroupBox6.Controls.Add(Me.tbParamMailHora1)
        Me.GroupBox6.Location = New System.Drawing.Point(379, 3)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(216, 131)
        Me.GroupBox6.TabIndex = 41
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Envio Diário"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(13, 100)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(39, 13)
        Me.Label20.TabIndex = 45
        Me.Label20.Text = "Hora 4"
        '
        'tbParamMailHora4
        '
        Me.tbParamMailHora4.Location = New System.Drawing.Point(58, 97)
        Me.tbParamMailHora4.Name = "tbParamMailHora4"
        Me.tbParamMailHora4.Size = New System.Drawing.Size(100, 20)
        Me.tbParamMailHora4.TabIndex = 44
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(13, 74)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(39, 13)
        Me.Label19.TabIndex = 43
        Me.Label19.Text = "Hora 3"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(13, 48)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(39, 13)
        Me.Label18.TabIndex = 42
        Me.Label18.Text = "Hora 2"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(13, 22)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(39, 13)
        Me.Label17.TabIndex = 41
        Me.Label17.Text = "Hora 1"
        '
        'tbParamMailHora3
        '
        Me.tbParamMailHora3.Location = New System.Drawing.Point(58, 71)
        Me.tbParamMailHora3.Name = "tbParamMailHora3"
        Me.tbParamMailHora3.Size = New System.Drawing.Size(100, 20)
        Me.tbParamMailHora3.TabIndex = 2
        '
        'tbParamMailHora2
        '
        Me.tbParamMailHora2.Location = New System.Drawing.Point(58, 45)
        Me.tbParamMailHora2.Name = "tbParamMailHora2"
        Me.tbParamMailHora2.Size = New System.Drawing.Size(100, 20)
        Me.tbParamMailHora2.TabIndex = 1
        '
        'tbParamMailHora1
        '
        Me.tbParamMailHora1.Location = New System.Drawing.Point(58, 19)
        Me.tbParamMailHora1.Name = "tbParamMailHora1"
        Me.tbParamMailHora1.Size = New System.Drawing.Size(100, 20)
        Me.tbParamMailHora1.TabIndex = 0
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label16)
        Me.GroupBox5.Controls.Add(Me.tbParamMailParaPO)
        Me.GroupBox5.Controls.Add(Me.Label15)
        Me.GroupBox5.Controls.Add(Me.tbParamMailParaCadastro)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Controls.Add(Me.tbParamMailParaFiscal)
        Me.GroupBox5.Location = New System.Drawing.Point(3, 140)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(370, 102)
        Me.GroupBox5.TabIndex = 39
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Campo Para"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(24, 74)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(22, 13)
        Me.Label16.TabIndex = 39
        Me.Label16.Text = "PO"
        '
        'tbParamMailParaPO
        '
        Me.tbParamMailParaPO.Location = New System.Drawing.Point(52, 71)
        Me.tbParamMailParaPO.Name = "tbParamMailParaPO"
        Me.tbParamMailParaPO.Size = New System.Drawing.Size(298, 20)
        Me.tbParamMailParaPO.TabIndex = 40
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(1, 48)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(49, 13)
        Me.Label15.TabIndex = 37
        Me.Label15.Text = "Cadastro"
        '
        'tbParamMailParaCadastro
        '
        Me.tbParamMailParaCadastro.Location = New System.Drawing.Point(52, 45)
        Me.tbParamMailParaCadastro.Name = "tbParamMailParaCadastro"
        Me.tbParamMailParaCadastro.Size = New System.Drawing.Size(298, 20)
        Me.tbParamMailParaCadastro.TabIndex = 38
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(15, 22)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(34, 13)
        Me.Label14.TabIndex = 35
        Me.Label14.Text = "Fiscal"
        '
        'tbParamMailParaFiscal
        '
        Me.tbParamMailParaFiscal.Location = New System.Drawing.Point(52, 19)
        Me.tbParamMailParaFiscal.Name = "tbParamMailParaFiscal"
        Me.tbParamMailParaFiscal.Size = New System.Drawing.Size(298, 20)
        Me.tbParamMailParaFiscal.TabIndex = 36
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.tbParamMailPorta)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.tbParamMailSMTP)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.tbParamMailConta)
        Me.GroupBox4.Controls.Add(Me.tbParamMailSenha)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(370, 131)
        Me.GroupBox4.TabIndex = 38
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Dados Envio"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(15, 22)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 13)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "Conta"
        '
        'tbParamMailPorta
        '
        Me.tbParamMailPorta.Location = New System.Drawing.Point(52, 97)
        Me.tbParamMailPorta.Name = "tbParamMailPorta"
        Me.tbParamMailPorta.Size = New System.Drawing.Size(53, 20)
        Me.tbParamMailPorta.TabIndex = 37
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(18, 100)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(32, 13)
        Me.Label13.TabIndex = 33
        Me.Label13.Text = "Porta"
        '
        'tbParamMailSMTP
        '
        Me.tbParamMailSMTP.Location = New System.Drawing.Point(52, 71)
        Me.tbParamMailSMTP.Name = "tbParamMailSMTP"
        Me.tbParamMailSMTP.Size = New System.Drawing.Size(298, 20)
        Me.tbParamMailSMTP.TabIndex = 36
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(13, 74)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(37, 13)
        Me.Label12.TabIndex = 32
        Me.Label12.Text = "SMTP"
        '
        'tbParamMailConta
        '
        Me.tbParamMailConta.Location = New System.Drawing.Point(52, 19)
        Me.tbParamMailConta.Name = "tbParamMailConta"
        Me.tbParamMailConta.Size = New System.Drawing.Size(298, 20)
        Me.tbParamMailConta.TabIndex = 34
        '
        'tbParamMailSenha
        '
        Me.tbParamMailSenha.Location = New System.Drawing.Point(52, 45)
        Me.tbParamMailSenha.Name = "tbParamMailSenha"
        Me.tbParamMailSenha.Size = New System.Drawing.Size(127, 20)
        Me.tbParamMailSenha.TabIndex = 35
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 48)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(38, 13)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "Senha"
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
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btParamOK As System.Windows.Forms.Button
    Protected Friend WithEvents cbLog As System.Windows.Forms.CheckBox
    Friend WithEvents tbParamCaminhoLog As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbParamBDAlias As System.Windows.Forms.TextBox
    Friend WithEvents tbParamBDPwd As System.Windows.Forms.TextBox
    Friend WithEvents tbParamBDUser As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbParamBDServer As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btParamSalvar As System.Windows.Forms.Button
    Friend WithEvents btParamCancelar As System.Windows.Forms.Button
    Friend WithEvents btParamTestaConex As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents tbParamMailPorta As System.Windows.Forms.TextBox
    Friend WithEvents tbParamMailSMTP As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents tbParamMailSenha As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents tbParamMailConta As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents tbParamMailHora4 As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents tbParamMailHora3 As System.Windows.Forms.TextBox
    Friend WithEvents tbParamMailHora2 As System.Windows.Forms.TextBox
    Friend WithEvents tbParamMailHora1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents tbParamMailParaPO As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents tbParamMailParaCadastro As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents tbParamMailParaFiscal As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents cbMail As System.Windows.Forms.CheckBox
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
End Class
