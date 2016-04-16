<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArquivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuáriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpcoesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ParametrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServicoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VersãoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tbLog = New System.Windows.Forms.TabPage()
        Me.btnAtuVisaoLog = New System.Windows.Forms.Button()
        Me.btnSairLog = New System.Windows.Forms.Button()
        Me.gbLog = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtusuariolog = New System.Windows.Forms.TextBox()
        Me.lbSetor = New System.Windows.Forms.Label()
        Me.txtxmllog = New System.Windows.Forms.TextBox()
        Me.txtsetorlog = New System.Windows.Forms.TextBox()
        Me.lbData = New System.Windows.Forms.Label()
        Me.txtDatalog = New System.Windows.Forms.TextBox()
        Me.lgXml = New System.Windows.Forms.Label()
        Me.dgLog = New System.Windows.Forms.DataGridView()
        Me.XML = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DATA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SETOR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.USUARIO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CTe = New System.Windows.Forms.TabPage()
        Me.gbNf = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbFilialcte = New System.Windows.Forms.Label()
        Me.txtfilialcte = New System.Windows.Forms.TextBox()
        Me.lbSepara = New System.Windows.Forms.Label()
        Me.lbSerie = New System.Windows.Forms.Label()
        Me.txtSerie = New System.Windows.Forms.TextBox()
        Me.lbNf = New System.Windows.Forms.Label()
        Me.txtNf = New System.Windows.Forms.TextBox()
        Me.dgCTe = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chkboxpo = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.XML_PO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DATAEMISSAO_XML_PO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CNPJ_PO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RAZAO_SOCIAL_PO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.img_po = New System.Windows.Forms.DataGridViewImageColumn()
        Me.NUMEROMOV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SERIE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIPO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CODFILIALPO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pbcte = New System.Windows.Forms.PictureBox()
        Me.gbCTe = New System.Windows.Forms.GroupBox()
        Me.lbdataemissaocte = New System.Windows.Forms.Label()
        Me.txtdataemissaocte = New System.Windows.Forms.TextBox()
        Me.lbCTe = New System.Windows.Forms.Label()
        Me.txtxmlcte = New System.Windows.Forms.TextBox()
        Me.gbcliforcte = New System.Windows.Forms.GroupBox()
        Me.txtrazaocte = New System.Windows.Forms.TextBox()
        Me.lbrazaocte = New System.Windows.Forms.Label()
        Me.lbcnpjcte = New System.Windows.Forms.Label()
        Me.txtcnpjcte = New System.Windows.Forms.TextBox()
        Me.gbacoescte = New System.Windows.Forms.GroupBox()
        Me.btnmanualcte = New System.Windows.Forms.Button()
        Me.btnexcluicte = New System.Windows.Forms.Button()
        Me.btnatuvisaocte = New System.Windows.Forms.Button()
        Me.btnmarcatodoscte = New System.Windows.Forms.Button()
        Me.btnsaircte = New System.Windows.Forms.Button()
        Me.btnreprocessacte = New System.Windows.Forms.Button()
        Me.Fiscal = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lbFilialFis = New System.Windows.Forms.Label()
        Me.txtfilialfis = New System.Windows.Forms.TextBox()
        Me.gbxmlfiscal = New System.Windows.Forms.GroupBox()
        Me.lbdataemissaofiscal = New System.Windows.Forms.Label()
        Me.txtdataemissaofiscal = New System.Windows.Forms.TextBox()
        Me.lbidxmlfiscal = New System.Windows.Forms.Label()
        Me.txtxmlfiscal = New System.Windows.Forms.TextBox()
        Me.gbcliforfiscal = New System.Windows.Forms.GroupBox()
        Me.txtrazaofiscal = New System.Windows.Forms.TextBox()
        Me.lbrazaofiscal = New System.Windows.Forms.Label()
        Me.lbcnpjfiscal = New System.Windows.Forms.Label()
        Me.txtcnpjfiscal = New System.Windows.Forms.TextBox()
        Me.gbacoesfiscal = New System.Windows.Forms.GroupBox()
        Me.btnManualFis = New System.Windows.Forms.Button()
        Me.btnExcluirFis = New System.Windows.Forms.Button()
        Me.btnAtuVisao = New System.Windows.Forms.Button()
        Me.btnSelSimNaoFiscal = New System.Windows.Forms.Button()
        Me.btnIgnorarCriticaFiscal = New System.Windows.Forms.Button()
        Me.btnsairfiscal = New System.Windows.Forms.Button()
        Me.btnreprocessarfiscal = New System.Windows.Forms.Button()
        Me.dgFiscal = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chkbox = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.XML_CRITICA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DATAEMISSAO_XML = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CNPJ_CRITICA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RAZAO_CRITICA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.img = New System.Windows.Forms.DataGridViewImageColumn()
        Me.TIPO_ERR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CODFILIAL_ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cadastros = New System.Windows.Forms.TabPage()
        Me.gbFilial = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtGrupo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCnpjInterno = New System.Windows.Forms.TextBox()
        Me.lbFilial = New System.Windows.Forms.Label()
        Me.txtFilial = New System.Windows.Forms.TextBox()
        Me.dgCadastros = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chk = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.NOME_XML = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DATAEMISSAO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CNPJ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RAZAO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.imgcad = New System.Windows.Forms.DataGridViewImageColumn()
        Me.TIPO_ERRO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CODFILIAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbxmlcad = New System.Windows.Forms.GroupBox()
        Me.lddataemissaocad = New System.Windows.Forms.Label()
        Me.txtdataemissaocad = New System.Windows.Forms.TextBox()
        Me.lbidxmlcad = New System.Windows.Forms.Label()
        Me.txtxmlcad = New System.Windows.Forms.TextBox()
        Me.gbcliforcad = New System.Windows.Forms.GroupBox()
        Me.txtrazaocad = New System.Windows.Forms.TextBox()
        Me.lbrazaocad = New System.Windows.Forms.Label()
        Me.lbcnpjcad = New System.Windows.Forms.Label()
        Me.txtcnpjcad = New System.Windows.Forms.TextBox()
        Me.gbacoescad = New System.Windows.Forms.GroupBox()
        Me.btnManualCad = New System.Windows.Forms.Button()
        Me.btnExcluirCad = New System.Windows.Forms.Button()
        Me.btnAtuTela = New System.Windows.Forms.Button()
        Me.btnSelSimNaoCad = New System.Windows.Forms.Button()
        Me.btnsaicad = New System.Windows.Forms.Button()
        Me.btnreprocessaxmlcad = New System.Windows.Forms.Button()
        Me.TabCritica = New System.Windows.Forms.TabControl()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.tbLog.SuspendLayout()
        Me.gbLog.SuspendLayout()
        CType(Me.dgLog, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CTe.SuspendLayout()
        Me.gbNf.SuspendLayout()
        CType(Me.dgCTe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbcte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbCTe.SuspendLayout()
        Me.gbcliforcte.SuspendLayout()
        Me.gbacoescte.SuspendLayout()
        Me.Fiscal.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxmlfiscal.SuspendLayout()
        Me.gbcliforfiscal.SuspendLayout()
        Me.gbacoesfiscal.SuspendLayout()
        CType(Me.dgFiscal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Cadastros.SuspendLayout()
        Me.gbFilial.SuspendLayout()
        CType(Me.dgCadastros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxmlcad.SuspendLayout()
        Me.gbcliforcad.SuspendLayout()
        Me.gbacoescad.SuspendLayout()
        Me.TabCritica.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArquivoToolStripMenuItem, Me.OpcoesToolStripMenuItem, Me.AjudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1008, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArquivoToolStripMenuItem
        '
        Me.ArquivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SairToolStripMenuItem, Me.UsuáriosToolStripMenuItem})
        Me.ArquivoToolStripMenuItem.Name = "ArquivoToolStripMenuItem"
        Me.ArquivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArquivoToolStripMenuItem.Text = "Sistema"
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.SairToolStripMenuItem.Text = "Sair"
        '
        'UsuáriosToolStripMenuItem
        '
        Me.UsuáriosToolStripMenuItem.Name = "UsuáriosToolStripMenuItem"
        Me.UsuáriosToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.UsuáriosToolStripMenuItem.Text = "Usuários"
        '
        'OpcoesToolStripMenuItem
        '
        Me.OpcoesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogToolStripMenuItem, Me.ParametrosToolStripMenuItem, Me.ServicoToolStripMenuItem})
        Me.OpcoesToolStripMenuItem.Name = "OpcoesToolStripMenuItem"
        Me.OpcoesToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.OpcoesToolStripMenuItem.Text = "Opções"
        '
        'LogToolStripMenuItem
        '
        Me.LogToolStripMenuItem.Enabled = False
        Me.LogToolStripMenuItem.Name = "LogToolStripMenuItem"
        Me.LogToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LogToolStripMenuItem.Text = "Log"
        '
        'ParametrosToolStripMenuItem
        '
        Me.ParametrosToolStripMenuItem.Name = "ParametrosToolStripMenuItem"
        Me.ParametrosToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ParametrosToolStripMenuItem.Text = "Parâmetros"
        '
        'ServicoToolStripMenuItem
        '
        Me.ServicoToolStripMenuItem.Enabled = False
        Me.ServicoToolStripMenuItem.Name = "ServicoToolStripMenuItem"
        Me.ServicoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ServicoToolStripMenuItem.Text = "Serviço"
        '
        'AjudaToolStripMenuItem
        '
        Me.AjudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VersãoToolStripMenuItem})
        Me.AjudaToolStripMenuItem.Name = "AjudaToolStripMenuItem"
        Me.AjudaToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.AjudaToolStripMenuItem.Text = "Ajuda"
        '
        'VersãoToolStripMenuItem
        '
        Me.VersãoToolStripMenuItem.Name = "VersãoToolStripMenuItem"
        Me.VersãoToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.VersãoToolStripMenuItem.Text = "Versão"
        '
        'tbLog
        '
        Me.tbLog.Controls.Add(Me.btnAtuVisaoLog)
        Me.tbLog.Controls.Add(Me.btnSairLog)
        Me.tbLog.Controls.Add(Me.gbLog)
        Me.tbLog.Controls.Add(Me.dgLog)
        Me.tbLog.Location = New System.Drawing.Point(4, 22)
        Me.tbLog.Name = "tbLog"
        Me.tbLog.Padding = New System.Windows.Forms.Padding(3)
        Me.tbLog.Size = New System.Drawing.Size(982, 572)
        Me.tbLog.TabIndex = 2
        Me.tbLog.Text = "Log"
        Me.tbLog.UseVisualStyleBackColor = True
        '
        'btnAtuVisaoLog
        '
        Me.btnAtuVisaoLog.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnAtuVisaoLog.Location = New System.Drawing.Point(741, 548)
        Me.btnAtuVisaoLog.Name = "btnAtuVisaoLog"
        Me.btnAtuVisaoLog.Size = New System.Drawing.Size(111, 29)
        Me.btnAtuVisaoLog.TabIndex = 22
        Me.btnAtuVisaoLog.Text = "Atualizar Visão"
        Me.btnAtuVisaoLog.UseVisualStyleBackColor = True
        '
        'btnSairLog
        '
        Me.btnSairLog.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSairLog.Location = New System.Drawing.Point(858, 548)
        Me.btnSairLog.Name = "btnSairLog"
        Me.btnSairLog.Size = New System.Drawing.Size(111, 29)
        Me.btnSairLog.TabIndex = 21
        Me.btnSairLog.Text = "Sair"
        Me.btnSairLog.UseVisualStyleBackColor = True
        '
        'gbLog
        '
        Me.gbLog.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.gbLog.Controls.Add(Me.Label1)
        Me.gbLog.Controls.Add(Me.txtusuariolog)
        Me.gbLog.Controls.Add(Me.lbSetor)
        Me.gbLog.Controls.Add(Me.txtxmllog)
        Me.gbLog.Controls.Add(Me.txtsetorlog)
        Me.gbLog.Controls.Add(Me.lbData)
        Me.gbLog.Controls.Add(Me.txtDatalog)
        Me.gbLog.Controls.Add(Me.lgXml)
        Me.gbLog.Location = New System.Drawing.Point(6, 508)
        Me.gbLog.Name = "gbLog"
        Me.gbLog.Size = New System.Drawing.Size(689, 69)
        Me.gbLog.TabIndex = 19
        Me.gbLog.TabStop = False
        Me.gbLog.Text = "LOG"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(546, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Partner"
        '
        'txtusuariolog
        '
        Me.txtusuariolog.Location = New System.Drawing.Point(549, 38)
        Me.txtusuariolog.Name = "txtusuariolog"
        Me.txtusuariolog.Size = New System.Drawing.Size(130, 20)
        Me.txtusuariolog.TabIndex = 10
        '
        'lbSetor
        '
        Me.lbSetor.AutoSize = True
        Me.lbSetor.Location = New System.Drawing.Point(437, 22)
        Me.lbSetor.Name = "lbSetor"
        Me.lbSetor.Size = New System.Drawing.Size(32, 13)
        Me.lbSetor.TabIndex = 9
        Me.lbSetor.Text = "Setor"
        '
        'txtxmllog
        '
        Me.txtxmllog.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtxmllog.Location = New System.Drawing.Point(8, 39)
        Me.txtxmllog.Name = "txtxmllog"
        Me.txtxmllog.Size = New System.Drawing.Size(317, 20)
        Me.txtxmllog.TabIndex = 0
        '
        'txtsetorlog
        '
        Me.txtsetorlog.Location = New System.Drawing.Point(440, 38)
        Me.txtsetorlog.Name = "txtsetorlog"
        Me.txtsetorlog.Size = New System.Drawing.Size(103, 20)
        Me.txtsetorlog.TabIndex = 8
        '
        'lbData
        '
        Me.lbData.AutoSize = True
        Me.lbData.Location = New System.Drawing.Point(328, 22)
        Me.lbData.Name = "lbData"
        Me.lbData.Size = New System.Drawing.Size(30, 13)
        Me.lbData.TabIndex = 7
        Me.lbData.Text = "Data"
        '
        'txtDatalog
        '
        Me.txtDatalog.Location = New System.Drawing.Point(331, 38)
        Me.txtDatalog.Name = "txtDatalog"
        Me.txtDatalog.Size = New System.Drawing.Size(103, 20)
        Me.txtDatalog.TabIndex = 6
        '
        'lgXml
        '
        Me.lgXml.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lgXml.AutoSize = True
        Me.lgXml.Location = New System.Drawing.Point(7, 22)
        Me.lgXml.Name = "lgXml"
        Me.lgXml.Size = New System.Drawing.Size(43, 13)
        Me.lgXml.TabIndex = 1
        Me.lgXml.Text = "ID XML"
        '
        'dgLog
        '
        Me.dgLog.AllowUserToAddRows = False
        Me.dgLog.AllowUserToDeleteRows = False
        Me.dgLog.AllowUserToResizeColumns = False
        Me.dgLog.AllowUserToResizeRows = False
        Me.dgLog.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgLog.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.XML, Me.DATA, Me.SETOR, Me.USUARIO})
        Me.dgLog.Location = New System.Drawing.Point(6, 6)
        Me.dgLog.Name = "dgLog"
        Me.dgLog.ReadOnly = True
        Me.dgLog.Size = New System.Drawing.Size(963, 496)
        Me.dgLog.TabIndex = 0
        '
        'XML
        '
        Me.XML.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.XML.DataPropertyName = "NOME_XML"
        Me.XML.HeaderText = "XML"
        Me.XML.Name = "XML"
        Me.XML.ReadOnly = True
        Me.XML.Width = 54
        '
        'DATA
        '
        Me.DATA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DATA.DataPropertyName = "DATAEMISSAO"
        Me.DATA.HeaderText = "DATA"
        Me.DATA.Name = "DATA"
        Me.DATA.ReadOnly = True
        Me.DATA.Width = 61
        '
        'SETOR
        '
        Me.SETOR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SETOR.DataPropertyName = "SETOR"
        Me.SETOR.HeaderText = "SETOR"
        Me.SETOR.Name = "SETOR"
        Me.SETOR.ReadOnly = True
        Me.SETOR.Visible = False
        '
        'USUARIO
        '
        Me.USUARIO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.USUARIO.DataPropertyName = "USUARIO"
        Me.USUARIO.HeaderText = "COLABORADOR"
        Me.USUARIO.Name = "USUARIO"
        Me.USUARIO.ReadOnly = True
        Me.USUARIO.Width = 114
        '
        'CTe
        '
        Me.CTe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CTe.Controls.Add(Me.gbNf)
        Me.CTe.Controls.Add(Me.dgCTe)
        Me.CTe.Controls.Add(Me.pbcte)
        Me.CTe.Controls.Add(Me.gbCTe)
        Me.CTe.Controls.Add(Me.gbcliforcte)
        Me.CTe.Controls.Add(Me.gbacoescte)
        Me.CTe.Location = New System.Drawing.Point(4, 22)
        Me.CTe.Name = "CTe"
        Me.CTe.Size = New System.Drawing.Size(982, 572)
        Me.CTe.TabIndex = 3
        Me.CTe.Text = "CT-e"
        Me.CTe.UseVisualStyleBackColor = True
        '
        'gbNf
        '
        Me.gbNf.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.gbNf.Controls.Add(Me.Label2)
        Me.gbNf.Controls.Add(Me.lbFilialcte)
        Me.gbNf.Controls.Add(Me.txtfilialcte)
        Me.gbNf.Controls.Add(Me.lbSepara)
        Me.gbNf.Controls.Add(Me.lbSerie)
        Me.gbNf.Controls.Add(Me.txtSerie)
        Me.gbNf.Controls.Add(Me.lbNf)
        Me.gbNf.Controls.Add(Me.txtNf)
        Me.gbNf.Location = New System.Drawing.Point(317, 633)
        Me.gbNf.Name = "gbNf"
        Me.gbNf.Size = New System.Drawing.Size(329, 64)
        Me.gbNf.TabIndex = 23
        Me.gbNf.TabStop = False
        Me.gbNf.Text = "Nota Fiscal"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(200, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 24)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "--"
        '
        'lbFilialcte
        '
        Me.lbFilialcte.AutoSize = True
        Me.lbFilialcte.Location = New System.Drawing.Point(226, 16)
        Me.lbFilialcte.Name = "lbFilialcte"
        Me.lbFilialcte.Size = New System.Drawing.Size(27, 13)
        Me.lbFilialcte.TabIndex = 28
        Me.lbFilialcte.Text = "Filial"
        '
        'txtfilialcte
        '
        Me.txtfilialcte.Location = New System.Drawing.Point(229, 32)
        Me.txtfilialcte.Name = "txtfilialcte"
        Me.txtfilialcte.Size = New System.Drawing.Size(94, 20)
        Me.txtfilialcte.TabIndex = 27
        '
        'lbSepara
        '
        Me.lbSepara.AutoSize = True
        Me.lbSepara.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSepara.Location = New System.Drawing.Point(117, 30)
        Me.lbSepara.Name = "lbSepara"
        Me.lbSepara.Size = New System.Drawing.Size(15, 24)
        Me.lbSepara.TabIndex = 12
        Me.lbSepara.Text = "/"
        '
        'lbSerie
        '
        Me.lbSerie.AutoSize = True
        Me.lbSerie.Location = New System.Drawing.Point(135, 16)
        Me.lbSerie.Name = "lbSerie"
        Me.lbSerie.Size = New System.Drawing.Size(31, 13)
        Me.lbSerie.TabIndex = 11
        Me.lbSerie.Text = "Serie"
        '
        'txtSerie
        '
        Me.txtSerie.Location = New System.Drawing.Point(138, 32)
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(56, 20)
        Me.txtSerie.TabIndex = 10
        '
        'lbNf
        '
        Me.lbNf.AutoSize = True
        Me.lbNf.Location = New System.Drawing.Point(6, 16)
        Me.lbNf.Name = "lbNf"
        Me.lbNf.Size = New System.Drawing.Size(18, 13)
        Me.lbNf.TabIndex = 9
        Me.lbNf.Text = "Nf"
        '
        'txtNf
        '
        Me.txtNf.Location = New System.Drawing.Point(9, 32)
        Me.txtNf.Name = "txtNf"
        Me.txtNf.Size = New System.Drawing.Size(102, 20)
        Me.txtNf.TabIndex = 8
        '
        'dgCTe
        '
        Me.dgCTe.AllowUserToAddRows = False
        Me.dgCTe.AllowUserToDeleteRows = False
        Me.dgCTe.AllowUserToResizeColumns = False
        Me.dgCTe.AllowUserToResizeRows = False
        Me.dgCTe.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgCTe.ColumnHeadersHeight = 21
        Me.dgCTe.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn, Me.chkboxpo, Me.XML_PO, Me.DATAEMISSAO_XML_PO, Me.CNPJ_PO, Me.RAZAO_SOCIAL_PO, Me.img_po, Me.NUMEROMOV, Me.SERIE, Me.TIPO, Me.CODFILIALPO})
        Me.dgCTe.Location = New System.Drawing.Point(9, 6)
        Me.dgCTe.Name = "dgCTe"
        Me.dgCTe.Size = New System.Drawing.Size(963, 332)
        Me.dgCTe.TabIndex = 22
        '
        'DataGridViewTextBoxColumn
        '
        Me.DataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn.Name = "DataGridViewTextBoxColumn"
        Me.DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn.Visible = False
        '
        'chkboxpo
        '
        Me.chkboxpo.FalseValue = "False"
        Me.chkboxpo.HeaderText = ""
        Me.chkboxpo.Name = "chkboxpo"
        Me.chkboxpo.TrueValue = "True"
        Me.chkboxpo.Width = 25
        '
        'XML_PO
        '
        Me.XML_PO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.XML_PO.DataPropertyName = "NOME_XML"
        Me.XML_PO.HeaderText = "CTE"
        Me.XML_PO.Name = "XML_PO"
        Me.XML_PO.Width = 53
        '
        'DATAEMISSAO_XML_PO
        '
        Me.DATAEMISSAO_XML_PO.DataPropertyName = "DATAEMISSAO"
        Me.DATAEMISSAO_XML_PO.HeaderText = "DATA EMISSAO"
        Me.DATAEMISSAO_XML_PO.Name = "DATAEMISSAO_XML_PO"
        Me.DATAEMISSAO_XML_PO.Width = 110
        '
        'CNPJ_PO
        '
        Me.CNPJ_PO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CNPJ_PO.DataPropertyName = "CNPJ"
        Me.CNPJ_PO.HeaderText = "CNPJ"
        Me.CNPJ_PO.Name = "CNPJ_PO"
        Me.CNPJ_PO.Width = 59
        '
        'RAZAO_SOCIAL_PO
        '
        Me.RAZAO_SOCIAL_PO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.RAZAO_SOCIAL_PO.DataPropertyName = "RAZAO"
        Me.RAZAO_SOCIAL_PO.HeaderText = "RAZAO SOCIAL"
        Me.RAZAO_SOCIAL_PO.Name = "RAZAO_SOCIAL_PO"
        Me.RAZAO_SOCIAL_PO.Width = 110
        '
        'img_po
        '
        Me.img_po.DataPropertyName = "FLAG_ERRO"
        Me.img_po.HeaderText = "FLAG"
        Me.img_po.Name = "img_po"
        Me.img_po.Width = 40
        '
        'NUMEROMOV
        '
        Me.NUMEROMOV.DataPropertyName = "NUMEROMOV"
        Me.NUMEROMOV.HeaderText = "NUMEROMOV"
        Me.NUMEROMOV.Name = "NUMEROMOV"
        Me.NUMEROMOV.Visible = False
        '
        'SERIE
        '
        Me.SERIE.DataPropertyName = "SERIE"
        Me.SERIE.HeaderText = "SERIE"
        Me.SERIE.Name = "SERIE"
        Me.SERIE.Visible = False
        '
        'TIPO
        '
        Me.TIPO.DataPropertyName = "TIPO"
        Me.TIPO.HeaderText = "TIPO"
        Me.TIPO.Name = "TIPO"
        Me.TIPO.Visible = False
        '
        'CODFILIALPO
        '
        Me.CODFILIALPO.DataPropertyName = "CODFILIAL"
        Me.CODFILIALPO.HeaderText = "CODFILIAL"
        Me.CODFILIALPO.Name = "CODFILIALPO"
        Me.CODFILIALPO.Visible = False
        '
        'pbcte
        '
        Me.pbcte.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.pbcte.Image = CType(resources.GetObject("pbcte.Image"), System.Drawing.Image)
        Me.pbcte.Location = New System.Drawing.Point(417, 351)
        Me.pbcte.Name = "pbcte"
        Me.pbcte.Size = New System.Drawing.Size(121, 106)
        Me.pbcte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbcte.TabIndex = 21
        Me.pbcte.TabStop = False
        '
        'gbCTe
        '
        Me.gbCTe.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.gbCTe.Controls.Add(Me.lbdataemissaocte)
        Me.gbCTe.Controls.Add(Me.txtdataemissaocte)
        Me.gbCTe.Controls.Add(Me.lbCTe)
        Me.gbCTe.Controls.Add(Me.txtxmlcte)
        Me.gbCTe.Location = New System.Drawing.Point(9, 344)
        Me.gbCTe.Name = "gbCTe"
        Me.gbCTe.Size = New System.Drawing.Size(405, 115)
        Me.gbCTe.TabIndex = 20
        Me.gbCTe.TabStop = False
        Me.gbCTe.Text = "CTe"
        '
        'lbdataemissaocte
        '
        Me.lbdataemissaocte.AutoSize = True
        Me.lbdataemissaocte.Location = New System.Drawing.Point(5, 22)
        Me.lbdataemissaocte.Name = "lbdataemissaocte"
        Me.lbdataemissaocte.Size = New System.Drawing.Size(72, 13)
        Me.lbdataemissaocte.TabIndex = 7
        Me.lbdataemissaocte.Text = "Data Emissão"
        '
        'txtdataemissaocte
        '
        Me.txtdataemissaocte.Location = New System.Drawing.Point(8, 38)
        Me.txtdataemissaocte.Name = "txtdataemissaocte"
        Me.txtdataemissaocte.Size = New System.Drawing.Size(83, 20)
        Me.txtdataemissaocte.TabIndex = 6
        '
        'lbCTe
        '
        Me.lbCTe.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbCTe.AutoSize = True
        Me.lbCTe.Location = New System.Drawing.Point(7, 64)
        Me.lbCTe.Name = "lbCTe"
        Me.lbCTe.Size = New System.Drawing.Size(41, 13)
        Me.lbCTe.TabIndex = 1
        Me.lbCTe.Text = "ID CTe"
        '
        'txtxmlcte
        '
        Me.txtxmlcte.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtxmlcte.Location = New System.Drawing.Point(8, 81)
        Me.txtxmlcte.Name = "txtxmlcte"
        Me.txtxmlcte.Size = New System.Drawing.Size(391, 20)
        Me.txtxmlcte.TabIndex = 0
        '
        'gbcliforcte
        '
        Me.gbcliforcte.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.gbcliforcte.Controls.Add(Me.txtrazaocte)
        Me.gbcliforcte.Controls.Add(Me.lbrazaocte)
        Me.gbcliforcte.Controls.Add(Me.lbcnpjcte)
        Me.gbcliforcte.Controls.Add(Me.txtcnpjcte)
        Me.gbcliforcte.Location = New System.Drawing.Point(541, 344)
        Me.gbcliforcte.Name = "gbcliforcte"
        Me.gbcliforcte.Size = New System.Drawing.Size(424, 115)
        Me.gbcliforcte.TabIndex = 19
        Me.gbcliforcte.TabStop = False
        Me.gbcliforcte.Text = "Cliente / Fornecedor"
        '
        'txtrazaocte
        '
        Me.txtrazaocte.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtrazaocte.Location = New System.Drawing.Point(9, 81)
        Me.txtrazaocte.Name = "txtrazaocte"
        Me.txtrazaocte.Size = New System.Drawing.Size(409, 20)
        Me.txtrazaocte.TabIndex = 5
        '
        'lbrazaocte
        '
        Me.lbrazaocte.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbrazaocte.AutoSize = True
        Me.lbrazaocte.Location = New System.Drawing.Point(6, 64)
        Me.lbrazaocte.Name = "lbrazaocte"
        Me.lbrazaocte.Size = New System.Drawing.Size(70, 13)
        Me.lbrazaocte.TabIndex = 4
        Me.lbrazaocte.Text = "Razão Social"
        '
        'lbcnpjcte
        '
        Me.lbcnpjcte.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbcnpjcte.AutoSize = True
        Me.lbcnpjcte.Location = New System.Drawing.Point(6, 22)
        Me.lbcnpjcte.Name = "lbcnpjcte"
        Me.lbcnpjcte.Size = New System.Drawing.Size(34, 13)
        Me.lbcnpjcte.TabIndex = 2
        Me.lbcnpjcte.Text = "CNPJ"
        '
        'txtcnpjcte
        '
        Me.txtcnpjcte.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtcnpjcte.Location = New System.Drawing.Point(9, 39)
        Me.txtcnpjcte.Name = "txtcnpjcte"
        Me.txtcnpjcte.Size = New System.Drawing.Size(118, 20)
        Me.txtcnpjcte.TabIndex = 3
        '
        'gbacoescte
        '
        Me.gbacoescte.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.gbacoescte.Controls.Add(Me.btnmanualcte)
        Me.gbacoescte.Controls.Add(Me.btnexcluicte)
        Me.gbacoescte.Controls.Add(Me.btnatuvisaocte)
        Me.gbacoescte.Controls.Add(Me.btnmarcatodoscte)
        Me.gbacoescte.Controls.Add(Me.btnsaircte)
        Me.gbacoescte.Controls.Add(Me.btnreprocessacte)
        Me.gbacoescte.Location = New System.Drawing.Point(153, 529)
        Me.gbacoescte.Name = "gbacoescte"
        Me.gbacoescte.Size = New System.Drawing.Size(662, 61)
        Me.gbacoescte.TabIndex = 18
        Me.gbacoescte.TabStop = False
        Me.gbacoescte.Text = "Ações"
        '
        'btnmanualcte
        '
        Me.btnmanualcte.Location = New System.Drawing.Point(443, 18)
        Me.btnmanualcte.Name = "btnmanualcte"
        Me.btnmanualcte.Size = New System.Drawing.Size(102, 29)
        Me.btnmanualcte.TabIndex = 21
        Me.btnmanualcte.Text = "CTe Manual"
        Me.btnmanualcte.UseVisualStyleBackColor = True
        '
        'btnexcluicte
        '
        Me.btnexcluicte.Location = New System.Drawing.Point(335, 19)
        Me.btnexcluicte.Name = "btnexcluicte"
        Me.btnexcluicte.Size = New System.Drawing.Size(102, 29)
        Me.btnexcluicte.TabIndex = 20
        Me.btnexcluicte.Text = "Excluir CTe"
        Me.btnexcluicte.UseVisualStyleBackColor = True
        '
        'btnatuvisaocte
        '
        Me.btnatuvisaocte.Location = New System.Drawing.Point(11, 19)
        Me.btnatuvisaocte.Name = "btnatuvisaocte"
        Me.btnatuvisaocte.Size = New System.Drawing.Size(102, 30)
        Me.btnatuvisaocte.TabIndex = 19
        Me.btnatuvisaocte.Text = "Atualizar Visão"
        Me.btnatuvisaocte.UseVisualStyleBackColor = True
        '
        'btnmarcatodoscte
        '
        Me.btnmarcatodoscte.Location = New System.Drawing.Point(119, 19)
        Me.btnmarcatodoscte.Name = "btnmarcatodoscte"
        Me.btnmarcatodoscte.Size = New System.Drawing.Size(102, 30)
        Me.btnmarcatodoscte.TabIndex = 18
        Me.btnmarcatodoscte.Text = "Marcar Todos"
        Me.btnmarcatodoscte.UseVisualStyleBackColor = True
        '
        'btnsaircte
        '
        Me.btnsaircte.Location = New System.Drawing.Point(551, 18)
        Me.btnsaircte.Name = "btnsaircte"
        Me.btnsaircte.Size = New System.Drawing.Size(102, 29)
        Me.btnsaircte.TabIndex = 16
        Me.btnsaircte.Text = "Sair"
        Me.btnsaircte.UseVisualStyleBackColor = True
        '
        'btnreprocessacte
        '
        Me.btnreprocessacte.Location = New System.Drawing.Point(227, 19)
        Me.btnreprocessacte.Name = "btnreprocessacte"
        Me.btnreprocessacte.Size = New System.Drawing.Size(102, 29)
        Me.btnreprocessacte.TabIndex = 14
        Me.btnreprocessacte.Text = "Reprocessar CTe"
        Me.btnreprocessacte.UseVisualStyleBackColor = True
        '
        'Fiscal
        '
        Me.Fiscal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Fiscal.Controls.Add(Me.GroupBox1)
        Me.Fiscal.Controls.Add(Me.gbxmlfiscal)
        Me.Fiscal.Controls.Add(Me.gbcliforfiscal)
        Me.Fiscal.Controls.Add(Me.gbacoesfiscal)
        Me.Fiscal.Controls.Add(Me.dgFiscal)
        Me.Fiscal.Location = New System.Drawing.Point(4, 22)
        Me.Fiscal.Name = "Fiscal"
        Me.Fiscal.Padding = New System.Windows.Forms.Padding(3)
        Me.Fiscal.Size = New System.Drawing.Size(982, 572)
        Me.Fiscal.TabIndex = 1
        Me.Fiscal.Text = "Fiscal"
        Me.Fiscal.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.lbFilialFis)
        Me.GroupBox1.Controls.Add(Me.txtfilialfis)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 409)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(129, 185)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(6, 19)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(117, 116)
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'lbFilialFis
        '
        Me.lbFilialFis.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbFilialFis.AutoSize = True
        Me.lbFilialFis.Location = New System.Drawing.Point(6, 138)
        Me.lbFilialFis.Name = "lbFilialFis"
        Me.lbFilialFis.Size = New System.Drawing.Size(27, 13)
        Me.lbFilialFis.TabIndex = 1
        Me.lbFilialFis.Text = "Filial"
        '
        'txtfilialfis
        '
        Me.txtfilialfis.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtfilialfis.Location = New System.Drawing.Point(6, 154)
        Me.txtfilialfis.Name = "txtfilialfis"
        Me.txtfilialfis.Size = New System.Drawing.Size(117, 20)
        Me.txtfilialfis.TabIndex = 0
        '
        'gbxmlfiscal
        '
        Me.gbxmlfiscal.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.gbxmlfiscal.Controls.Add(Me.lbdataemissaofiscal)
        Me.gbxmlfiscal.Controls.Add(Me.txtdataemissaofiscal)
        Me.gbxmlfiscal.Controls.Add(Me.lbidxmlfiscal)
        Me.gbxmlfiscal.Controls.Add(Me.txtxmlfiscal)
        Me.gbxmlfiscal.Location = New System.Drawing.Point(148, 409)
        Me.gbxmlfiscal.Name = "gbxmlfiscal"
        Me.gbxmlfiscal.Size = New System.Drawing.Size(397, 115)
        Me.gbxmlfiscal.TabIndex = 16
        Me.gbxmlfiscal.TabStop = False
        Me.gbxmlfiscal.Text = "XML"
        '
        'lbdataemissaofiscal
        '
        Me.lbdataemissaofiscal.AutoSize = True
        Me.lbdataemissaofiscal.Location = New System.Drawing.Point(9, 23)
        Me.lbdataemissaofiscal.Name = "lbdataemissaofiscal"
        Me.lbdataemissaofiscal.Size = New System.Drawing.Size(72, 13)
        Me.lbdataemissaofiscal.TabIndex = 7
        Me.lbdataemissaofiscal.Text = "Data Emissão"
        '
        'txtdataemissaofiscal
        '
        Me.txtdataemissaofiscal.Location = New System.Drawing.Point(9, 39)
        Me.txtdataemissaofiscal.Name = "txtdataemissaofiscal"
        Me.txtdataemissaofiscal.Size = New System.Drawing.Size(132, 20)
        Me.txtdataemissaofiscal.TabIndex = 6
        '
        'lbidxmlfiscal
        '
        Me.lbidxmlfiscal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbidxmlfiscal.AutoSize = True
        Me.lbidxmlfiscal.Location = New System.Drawing.Point(9, 63)
        Me.lbidxmlfiscal.Name = "lbidxmlfiscal"
        Me.lbidxmlfiscal.Size = New System.Drawing.Size(43, 13)
        Me.lbidxmlfiscal.TabIndex = 1
        Me.lbidxmlfiscal.Text = "ID XML"
        '
        'txtxmlfiscal
        '
        Me.txtxmlfiscal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtxmlfiscal.Location = New System.Drawing.Point(9, 79)
        Me.txtxmlfiscal.Name = "txtxmlfiscal"
        Me.txtxmlfiscal.Size = New System.Drawing.Size(384, 20)
        Me.txtxmlfiscal.TabIndex = 0
        '
        'gbcliforfiscal
        '
        Me.gbcliforfiscal.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.gbcliforfiscal.Controls.Add(Me.txtrazaofiscal)
        Me.gbcliforfiscal.Controls.Add(Me.lbrazaofiscal)
        Me.gbcliforfiscal.Controls.Add(Me.lbcnpjfiscal)
        Me.gbcliforfiscal.Controls.Add(Me.txtcnpjfiscal)
        Me.gbcliforfiscal.Location = New System.Drawing.Point(554, 409)
        Me.gbcliforfiscal.Name = "gbcliforfiscal"
        Me.gbcliforfiscal.Size = New System.Drawing.Size(418, 115)
        Me.gbcliforfiscal.TabIndex = 15
        Me.gbcliforfiscal.TabStop = False
        Me.gbcliforfiscal.Text = "Cliente / Fornecedor"
        '
        'txtrazaofiscal
        '
        Me.txtrazaofiscal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtrazaofiscal.Location = New System.Drawing.Point(9, 79)
        Me.txtrazaofiscal.Name = "txtrazaofiscal"
        Me.txtrazaofiscal.Size = New System.Drawing.Size(403, 20)
        Me.txtrazaofiscal.TabIndex = 5
        '
        'lbrazaofiscal
        '
        Me.lbrazaofiscal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbrazaofiscal.AutoSize = True
        Me.lbrazaofiscal.Location = New System.Drawing.Point(9, 62)
        Me.lbrazaofiscal.Name = "lbrazaofiscal"
        Me.lbrazaofiscal.Size = New System.Drawing.Size(70, 13)
        Me.lbrazaofiscal.TabIndex = 4
        Me.lbrazaofiscal.Text = "Razão Social"
        '
        'lbcnpjfiscal
        '
        Me.lbcnpjfiscal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbcnpjfiscal.AutoSize = True
        Me.lbcnpjfiscal.Location = New System.Drawing.Point(9, 22)
        Me.lbcnpjfiscal.Name = "lbcnpjfiscal"
        Me.lbcnpjfiscal.Size = New System.Drawing.Size(34, 13)
        Me.lbcnpjfiscal.TabIndex = 2
        Me.lbcnpjfiscal.Text = "CNPJ"
        '
        'txtcnpjfiscal
        '
        Me.txtcnpjfiscal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtcnpjfiscal.Location = New System.Drawing.Point(9, 39)
        Me.txtcnpjfiscal.Name = "txtcnpjfiscal"
        Me.txtcnpjfiscal.Size = New System.Drawing.Size(138, 20)
        Me.txtcnpjfiscal.TabIndex = 3
        '
        'gbacoesfiscal
        '
        Me.gbacoesfiscal.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.gbacoesfiscal.Controls.Add(Me.btnManualFis)
        Me.gbacoesfiscal.Controls.Add(Me.btnExcluirFis)
        Me.gbacoesfiscal.Controls.Add(Me.btnAtuVisao)
        Me.gbacoesfiscal.Controls.Add(Me.btnSelSimNaoFiscal)
        Me.gbacoesfiscal.Controls.Add(Me.btnIgnorarCriticaFiscal)
        Me.gbacoesfiscal.Controls.Add(Me.btnsairfiscal)
        Me.gbacoesfiscal.Controls.Add(Me.btnreprocessarfiscal)
        Me.gbacoesfiscal.Location = New System.Drawing.Point(148, 533)
        Me.gbacoesfiscal.Name = "gbacoesfiscal"
        Me.gbacoesfiscal.Size = New System.Drawing.Size(824, 61)
        Me.gbacoesfiscal.TabIndex = 14
        Me.gbacoesfiscal.TabStop = False
        Me.gbacoesfiscal.Text = "Ações"
        '
        'btnManualFis
        '
        Me.btnManualFis.Location = New System.Drawing.Point(576, 20)
        Me.btnManualFis.Name = "btnManualFis"
        Me.btnManualFis.Size = New System.Drawing.Size(102, 29)
        Me.btnManualFis.TabIndex = 21
        Me.btnManualFis.Text = "XML Manual"
        Me.btnManualFis.UseVisualStyleBackColor = True
        '
        'btnExcluirFis
        '
        Me.btnExcluirFis.Location = New System.Drawing.Point(468, 21)
        Me.btnExcluirFis.Name = "btnExcluirFis"
        Me.btnExcluirFis.Size = New System.Drawing.Size(102, 29)
        Me.btnExcluirFis.TabIndex = 20
        Me.btnExcluirFis.Text = "Excluir XML"
        Me.btnExcluirFis.UseVisualStyleBackColor = True
        '
        'btnAtuVisao
        '
        Me.btnAtuVisao.Location = New System.Drawing.Point(36, 20)
        Me.btnAtuVisao.Name = "btnAtuVisao"
        Me.btnAtuVisao.Size = New System.Drawing.Size(102, 30)
        Me.btnAtuVisao.TabIndex = 19
        Me.btnAtuVisao.Text = "Atualizar Visão"
        Me.btnAtuVisao.UseVisualStyleBackColor = True
        '
        'btnSelSimNaoFiscal
        '
        Me.btnSelSimNaoFiscal.Location = New System.Drawing.Point(144, 20)
        Me.btnSelSimNaoFiscal.Name = "btnSelSimNaoFiscal"
        Me.btnSelSimNaoFiscal.Size = New System.Drawing.Size(102, 30)
        Me.btnSelSimNaoFiscal.TabIndex = 18
        Me.btnSelSimNaoFiscal.Text = "Marcar Todos"
        Me.btnSelSimNaoFiscal.UseVisualStyleBackColor = True
        '
        'btnIgnorarCriticaFiscal
        '
        Me.btnIgnorarCriticaFiscal.Location = New System.Drawing.Point(252, 20)
        Me.btnIgnorarCriticaFiscal.Name = "btnIgnorarCriticaFiscal"
        Me.btnIgnorarCriticaFiscal.Size = New System.Drawing.Size(102, 30)
        Me.btnIgnorarCriticaFiscal.TabIndex = 13
        Me.btnIgnorarCriticaFiscal.Text = "Ignorar Críticas"
        Me.btnIgnorarCriticaFiscal.UseVisualStyleBackColor = True
        '
        'btnsairfiscal
        '
        Me.btnsairfiscal.Location = New System.Drawing.Point(684, 20)
        Me.btnsairfiscal.Name = "btnsairfiscal"
        Me.btnsairfiscal.Size = New System.Drawing.Size(102, 29)
        Me.btnsairfiscal.TabIndex = 16
        Me.btnsairfiscal.Text = "Sair"
        Me.btnsairfiscal.UseVisualStyleBackColor = True
        '
        'btnreprocessarfiscal
        '
        Me.btnreprocessarfiscal.Location = New System.Drawing.Point(360, 21)
        Me.btnreprocessarfiscal.Name = "btnreprocessarfiscal"
        Me.btnreprocessarfiscal.Size = New System.Drawing.Size(102, 29)
        Me.btnreprocessarfiscal.TabIndex = 14
        Me.btnreprocessarfiscal.Text = "Reprocessar XML"
        Me.btnreprocessarfiscal.UseVisualStyleBackColor = True
        '
        'dgFiscal
        '
        Me.dgFiscal.AllowUserToAddRows = False
        Me.dgFiscal.AllowUserToDeleteRows = False
        Me.dgFiscal.AllowUserToResizeColumns = False
        Me.dgFiscal.AllowUserToResizeRows = False
        Me.dgFiscal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgFiscal.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.chkbox, Me.XML_CRITICA, Me.DATAEMISSAO_XML, Me.CNPJ_CRITICA, Me.RAZAO_CRITICA, Me.img, Me.TIPO_ERR, Me.CODFILIAL_})
        Me.dgFiscal.Location = New System.Drawing.Point(9, 6)
        Me.dgFiscal.Name = "dgFiscal"
        Me.dgFiscal.Size = New System.Drawing.Size(963, 397)
        Me.dgFiscal.TabIndex = 8
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'chkbox
        '
        Me.chkbox.HeaderText = ""
        Me.chkbox.Name = "chkbox"
        Me.chkbox.Width = 25
        '
        'XML_CRITICA
        '
        Me.XML_CRITICA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.XML_CRITICA.DataPropertyName = "NOME_XML"
        Me.XML_CRITICA.HeaderText = "XML"
        Me.XML_CRITICA.Name = "XML_CRITICA"
        Me.XML_CRITICA.ReadOnly = True
        Me.XML_CRITICA.Width = 54
        '
        'DATAEMISSAO_XML
        '
        Me.DATAEMISSAO_XML.DataPropertyName = "DATAEMISSAO"
        Me.DATAEMISSAO_XML.HeaderText = "DATA EMISSAO"
        Me.DATAEMISSAO_XML.Name = "DATAEMISSAO_XML"
        Me.DATAEMISSAO_XML.ReadOnly = True
        Me.DATAEMISSAO_XML.Width = 110
        '
        'CNPJ_CRITICA
        '
        Me.CNPJ_CRITICA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CNPJ_CRITICA.DataPropertyName = "CNPJ"
        Me.CNPJ_CRITICA.HeaderText = "CNPJ"
        Me.CNPJ_CRITICA.Name = "CNPJ_CRITICA"
        Me.CNPJ_CRITICA.ReadOnly = True
        Me.CNPJ_CRITICA.Width = 59
        '
        'RAZAO_CRITICA
        '
        Me.RAZAO_CRITICA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.RAZAO_CRITICA.DataPropertyName = "RAZAO"
        Me.RAZAO_CRITICA.HeaderText = "RAZAO SOCIAL"
        Me.RAZAO_CRITICA.Name = "RAZAO_CRITICA"
        Me.RAZAO_CRITICA.ReadOnly = True
        Me.RAZAO_CRITICA.Width = 110
        '
        'img
        '
        Me.img.DataPropertyName = "FLAG_ERRO"
        Me.img.HeaderText = "FLAG"
        Me.img.Name = "img"
        Me.img.ReadOnly = True
        Me.img.Width = 40
        '
        'TIPO_ERR
        '
        Me.TIPO_ERR.DataPropertyName = "TIPO"
        Me.TIPO_ERR.HeaderText = "TIPO"
        Me.TIPO_ERR.Name = "TIPO_ERR"
        Me.TIPO_ERR.Visible = False
        '
        'CODFILIAL_
        '
        Me.CODFILIAL_.DataPropertyName = "CODFILIAL"
        Me.CODFILIAL_.HeaderText = "CODFILIAL"
        Me.CODFILIAL_.Name = "CODFILIAL_"
        Me.CODFILIAL_.Visible = False
        '
        'Cadastros
        '
        Me.Cadastros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Cadastros.Controls.Add(Me.gbFilial)
        Me.Cadastros.Controls.Add(Me.dgCadastros)
        Me.Cadastros.Controls.Add(Me.gbxmlcad)
        Me.Cadastros.Controls.Add(Me.gbcliforcad)
        Me.Cadastros.Controls.Add(Me.gbacoescad)
        Me.Cadastros.Location = New System.Drawing.Point(4, 22)
        Me.Cadastros.Name = "Cadastros"
        Me.Cadastros.Padding = New System.Windows.Forms.Padding(3)
        Me.Cadastros.Size = New System.Drawing.Size(982, 572)
        Me.Cadastros.TabIndex = 0
        Me.Cadastros.Text = "Cadastros"
        Me.Cadastros.UseVisualStyleBackColor = True
        '
        'gbFilial
        '
        Me.gbFilial.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.gbFilial.Controls.Add(Me.Label4)
        Me.gbFilial.Controls.Add(Me.txtGrupo)
        Me.gbFilial.Controls.Add(Me.Label3)
        Me.gbFilial.Controls.Add(Me.txtCnpjInterno)
        Me.gbFilial.Controls.Add(Me.lbFilial)
        Me.gbFilial.Controls.Add(Me.txtFilial)
        Me.gbFilial.Location = New System.Drawing.Point(6, 384)
        Me.gbFilial.Name = "gbFilial"
        Me.gbFilial.Size = New System.Drawing.Size(129, 185)
        Me.gbFilial.TabIndex = 22
        Me.gbFilial.TabStop = False
        Me.gbFilial.Text = "Dados Internos"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Grupo"
        '
        'txtGrupo
        '
        Me.txtGrupo.Location = New System.Drawing.Point(6, 72)
        Me.txtGrupo.Name = "txtGrupo"
        Me.txtGrupo.Size = New System.Drawing.Size(117, 20)
        Me.txtGrupo.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "CNPJ"
        '
        'txtCnpjInterno
        '
        Me.txtCnpjInterno.Location = New System.Drawing.Point(6, 34)
        Me.txtCnpjInterno.Name = "txtCnpjInterno"
        Me.txtCnpjInterno.Size = New System.Drawing.Size(117, 20)
        Me.txtCnpjInterno.TabIndex = 10
        '
        'lbFilial
        '
        Me.lbFilial.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbFilial.AutoSize = True
        Me.lbFilial.Location = New System.Drawing.Point(6, 95)
        Me.lbFilial.Name = "lbFilial"
        Me.lbFilial.Size = New System.Drawing.Size(27, 13)
        Me.lbFilial.TabIndex = 8
        Me.lbFilial.Text = "Filial"
        '
        'txtFilial
        '
        Me.txtFilial.Location = New System.Drawing.Point(6, 111)
        Me.txtFilial.Name = "txtFilial"
        Me.txtFilial.Size = New System.Drawing.Size(117, 20)
        Me.txtFilial.TabIndex = 6
        '
        'dgCadastros
        '
        Me.dgCadastros.AllowUserToAddRows = False
        Me.dgCadastros.AllowUserToDeleteRows = False
        Me.dgCadastros.AllowUserToResizeColumns = False
        Me.dgCadastros.AllowUserToResizeRows = False
        Me.dgCadastros.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgCadastros.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.chk, Me.NOME_XML, Me.DATAEMISSAO, Me.CNPJ, Me.RAZAO, Me.imgcad, Me.TIPO_ERRO, Me.CODFILIAL})
        Me.dgCadastros.Location = New System.Drawing.Point(9, 6)
        Me.dgCadastros.Name = "dgCadastros"
        Me.dgCadastros.Size = New System.Drawing.Size(963, 372)
        Me.dgCadastros.TabIndex = 22
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'chk
        '
        Me.chk.FalseValue = "false"
        Me.chk.HeaderText = ""
        Me.chk.Name = "chk"
        Me.chk.TrueValue = "true"
        Me.chk.Width = 25
        '
        'NOME_XML
        '
        Me.NOME_XML.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NOME_XML.DataPropertyName = "NOME_XML"
        Me.NOME_XML.HeaderText = "XML"
        Me.NOME_XML.Name = "NOME_XML"
        Me.NOME_XML.ReadOnly = True
        Me.NOME_XML.Width = 54
        '
        'DATAEMISSAO
        '
        Me.DATAEMISSAO.DataPropertyName = "DATAEMISSAO"
        Me.DATAEMISSAO.HeaderText = "DATA EMISSAO"
        Me.DATAEMISSAO.Name = "DATAEMISSAO"
        Me.DATAEMISSAO.ReadOnly = True
        Me.DATAEMISSAO.Width = 110
        '
        'CNPJ
        '
        Me.CNPJ.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CNPJ.DataPropertyName = "CNPJ"
        Me.CNPJ.HeaderText = "CNPJ"
        Me.CNPJ.Name = "CNPJ"
        Me.CNPJ.ReadOnly = True
        Me.CNPJ.Width = 59
        '
        'RAZAO
        '
        Me.RAZAO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.RAZAO.DataPropertyName = "RAZAO"
        Me.RAZAO.HeaderText = "RAZAO SOCIAL"
        Me.RAZAO.Name = "RAZAO"
        Me.RAZAO.ReadOnly = True
        Me.RAZAO.Width = 110
        '
        'imgcad
        '
        Me.imgcad.DataPropertyName = "FLAG_ERRO"
        Me.imgcad.HeaderText = "FLAG"
        Me.imgcad.Name = "imgcad"
        Me.imgcad.ReadOnly = True
        Me.imgcad.Width = 40
        '
        'TIPO_ERRO
        '
        Me.TIPO_ERRO.DataPropertyName = "TIPO"
        Me.TIPO_ERRO.HeaderText = "TIPO"
        Me.TIPO_ERRO.Name = "TIPO_ERRO"
        Me.TIPO_ERRO.Visible = False
        '
        'CODFILIAL
        '
        Me.CODFILIAL.DataPropertyName = "CODFILIAL"
        Me.CODFILIAL.HeaderText = "CODFILIAL"
        Me.CODFILIAL.Name = "CODFILIAL"
        Me.CODFILIAL.Visible = False
        '
        'gbxmlcad
        '
        Me.gbxmlcad.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.gbxmlcad.Controls.Add(Me.lddataemissaocad)
        Me.gbxmlcad.Controls.Add(Me.txtdataemissaocad)
        Me.gbxmlcad.Controls.Add(Me.lbidxmlcad)
        Me.gbxmlcad.Controls.Add(Me.txtxmlcad)
        Me.gbxmlcad.Location = New System.Drawing.Point(148, 384)
        Me.gbxmlcad.Name = "gbxmlcad"
        Me.gbxmlcad.Size = New System.Drawing.Size(397, 115)
        Me.gbxmlcad.TabIndex = 20
        Me.gbxmlcad.TabStop = False
        Me.gbxmlcad.Text = "XML"
        '
        'lddataemissaocad
        '
        Me.lddataemissaocad.AutoSize = True
        Me.lddataemissaocad.Location = New System.Drawing.Point(9, 23)
        Me.lddataemissaocad.Name = "lddataemissaocad"
        Me.lddataemissaocad.Size = New System.Drawing.Size(72, 13)
        Me.lddataemissaocad.TabIndex = 7
        Me.lddataemissaocad.Text = "Data Emissão"
        '
        'txtdataemissaocad
        '
        Me.txtdataemissaocad.Location = New System.Drawing.Point(9, 39)
        Me.txtdataemissaocad.Name = "txtdataemissaocad"
        Me.txtdataemissaocad.Size = New System.Drawing.Size(132, 20)
        Me.txtdataemissaocad.TabIndex = 6
        '
        'lbidxmlcad
        '
        Me.lbidxmlcad.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbidxmlcad.AutoSize = True
        Me.lbidxmlcad.Location = New System.Drawing.Point(9, 63)
        Me.lbidxmlcad.Name = "lbidxmlcad"
        Me.lbidxmlcad.Size = New System.Drawing.Size(43, 13)
        Me.lbidxmlcad.TabIndex = 1
        Me.lbidxmlcad.Text = "ID XML"
        '
        'txtxmlcad
        '
        Me.txtxmlcad.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtxmlcad.Location = New System.Drawing.Point(9, 79)
        Me.txtxmlcad.Name = "txtxmlcad"
        Me.txtxmlcad.Size = New System.Drawing.Size(384, 20)
        Me.txtxmlcad.TabIndex = 0
        '
        'gbcliforcad
        '
        Me.gbcliforcad.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.gbcliforcad.Controls.Add(Me.txtrazaocad)
        Me.gbcliforcad.Controls.Add(Me.lbrazaocad)
        Me.gbcliforcad.Controls.Add(Me.lbcnpjcad)
        Me.gbcliforcad.Controls.Add(Me.txtcnpjcad)
        Me.gbcliforcad.Location = New System.Drawing.Point(554, 384)
        Me.gbcliforcad.Name = "gbcliforcad"
        Me.gbcliforcad.Size = New System.Drawing.Size(418, 115)
        Me.gbcliforcad.TabIndex = 19
        Me.gbcliforcad.TabStop = False
        Me.gbcliforcad.Text = "Cliente / Fornecedor"
        '
        'txtrazaocad
        '
        Me.txtrazaocad.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtrazaocad.Location = New System.Drawing.Point(9, 79)
        Me.txtrazaocad.Name = "txtrazaocad"
        Me.txtrazaocad.Size = New System.Drawing.Size(403, 20)
        Me.txtrazaocad.TabIndex = 5
        '
        'lbrazaocad
        '
        Me.lbrazaocad.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbrazaocad.AutoSize = True
        Me.lbrazaocad.Location = New System.Drawing.Point(9, 62)
        Me.lbrazaocad.Name = "lbrazaocad"
        Me.lbrazaocad.Size = New System.Drawing.Size(70, 13)
        Me.lbrazaocad.TabIndex = 4
        Me.lbrazaocad.Text = "Razão Social"
        '
        'lbcnpjcad
        '
        Me.lbcnpjcad.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbcnpjcad.AutoSize = True
        Me.lbcnpjcad.Location = New System.Drawing.Point(9, 22)
        Me.lbcnpjcad.Name = "lbcnpjcad"
        Me.lbcnpjcad.Size = New System.Drawing.Size(34, 13)
        Me.lbcnpjcad.TabIndex = 2
        Me.lbcnpjcad.Text = "CNPJ"
        '
        'txtcnpjcad
        '
        Me.txtcnpjcad.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtcnpjcad.Location = New System.Drawing.Point(9, 39)
        Me.txtcnpjcad.Name = "txtcnpjcad"
        Me.txtcnpjcad.Size = New System.Drawing.Size(138, 20)
        Me.txtcnpjcad.TabIndex = 3
        '
        'gbacoescad
        '
        Me.gbacoescad.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.gbacoescad.Controls.Add(Me.btnManualCad)
        Me.gbacoescad.Controls.Add(Me.btnExcluirCad)
        Me.gbacoescad.Controls.Add(Me.btnAtuTela)
        Me.gbacoescad.Controls.Add(Me.btnSelSimNaoCad)
        Me.gbacoescad.Controls.Add(Me.btnsaicad)
        Me.gbacoescad.Controls.Add(Me.btnreprocessaxmlcad)
        Me.gbacoescad.Location = New System.Drawing.Point(148, 508)
        Me.gbacoescad.Name = "gbacoescad"
        Me.gbacoescad.Size = New System.Drawing.Size(824, 61)
        Me.gbacoescad.TabIndex = 18
        Me.gbacoescad.TabStop = False
        Me.gbacoescad.Text = "Ações"
        '
        'btnManualCad
        '
        Me.btnManualCad.Enabled = False
        Me.btnManualCad.Location = New System.Drawing.Point(514, 20)
        Me.btnManualCad.Name = "btnManualCad"
        Me.btnManualCad.Size = New System.Drawing.Size(102, 29)
        Me.btnManualCad.TabIndex = 26
        Me.btnManualCad.Text = "XML Manual"
        Me.btnManualCad.UseVisualStyleBackColor = True
        Me.btnManualCad.Visible = False
        '
        'btnExcluirCad
        '
        Me.btnExcluirCad.Location = New System.Drawing.Point(406, 20)
        Me.btnExcluirCad.Name = "btnExcluirCad"
        Me.btnExcluirCad.Size = New System.Drawing.Size(102, 29)
        Me.btnExcluirCad.TabIndex = 25
        Me.btnExcluirCad.Text = "Excluir XML"
        Me.btnExcluirCad.UseVisualStyleBackColor = True
        '
        'btnAtuTela
        '
        Me.btnAtuTela.Location = New System.Drawing.Point(82, 20)
        Me.btnAtuTela.Name = "btnAtuTela"
        Me.btnAtuTela.Size = New System.Drawing.Size(102, 29)
        Me.btnAtuTela.TabIndex = 24
        Me.btnAtuTela.Text = "Atualizar Visão"
        Me.btnAtuTela.UseVisualStyleBackColor = True
        '
        'btnSelSimNaoCad
        '
        Me.btnSelSimNaoCad.Location = New System.Drawing.Point(190, 20)
        Me.btnSelSimNaoCad.Name = "btnSelSimNaoCad"
        Me.btnSelSimNaoCad.Size = New System.Drawing.Size(102, 30)
        Me.btnSelSimNaoCad.TabIndex = 23
        Me.btnSelSimNaoCad.Text = "Marcar Todos"
        Me.btnSelSimNaoCad.UseVisualStyleBackColor = True
        '
        'btnsaicad
        '
        Me.btnsaicad.Location = New System.Drawing.Point(622, 20)
        Me.btnsaicad.Name = "btnsaicad"
        Me.btnsaicad.Size = New System.Drawing.Size(102, 29)
        Me.btnsaicad.TabIndex = 16
        Me.btnsaicad.Text = "Sair"
        Me.btnsaicad.UseVisualStyleBackColor = True
        '
        'btnreprocessaxmlcad
        '
        Me.btnreprocessaxmlcad.Location = New System.Drawing.Point(298, 20)
        Me.btnreprocessaxmlcad.Name = "btnreprocessaxmlcad"
        Me.btnreprocessaxmlcad.Size = New System.Drawing.Size(102, 29)
        Me.btnreprocessaxmlcad.TabIndex = 14
        Me.btnreprocessaxmlcad.Text = "Reprocessar XML"
        Me.btnreprocessaxmlcad.UseVisualStyleBackColor = True
        '
        'TabCritica
        '
        Me.TabCritica.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabCritica.Controls.Add(Me.Cadastros)
        Me.TabCritica.Controls.Add(Me.Fiscal)
        Me.TabCritica.Controls.Add(Me.CTe)
        Me.TabCritica.Controls.Add(Me.tbLog)
        Me.TabCritica.Location = New System.Drawing.Point(12, 27)
        Me.TabCritica.Name = "TabCritica"
        Me.TabCritica.SelectedIndex = 0
        Me.TabCritica.Size = New System.Drawing.Size(990, 598)
        Me.TabCritica.TabIndex = 1
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 637)
        Me.Controls.Add(Me.TabCritica)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "InspetorXML"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.tbLog.ResumeLayout(False)
        Me.gbLog.ResumeLayout(False)
        Me.gbLog.PerformLayout()
        CType(Me.dgLog, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CTe.ResumeLayout(False)
        Me.gbNf.ResumeLayout(False)
        Me.gbNf.PerformLayout()
        CType(Me.dgCTe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbcte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbCTe.ResumeLayout(False)
        Me.gbCTe.PerformLayout()
        Me.gbcliforcte.ResumeLayout(False)
        Me.gbcliforcte.PerformLayout()
        Me.gbacoescte.ResumeLayout(False)
        Me.Fiscal.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxmlfiscal.ResumeLayout(False)
        Me.gbxmlfiscal.PerformLayout()
        Me.gbcliforfiscal.ResumeLayout(False)
        Me.gbcliforfiscal.PerformLayout()
        Me.gbacoesfiscal.ResumeLayout(False)
        CType(Me.dgFiscal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Cadastros.ResumeLayout(False)
        Me.gbFilial.ResumeLayout(False)
        Me.gbFilial.PerformLayout()
        CType(Me.dgCadastros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxmlcad.ResumeLayout(False)
        Me.gbxmlcad.PerformLayout()
        Me.gbcliforcad.ResumeLayout(False)
        Me.gbcliforcad.PerformLayout()
        Me.gbacoescad.ResumeLayout(False)
        Me.TabCritica.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout

End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents OpcoesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ParametrosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AjudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VersãoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArquivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tbLog As System.Windows.Forms.TabPage
    Friend WithEvents btnAtuVisaoLog As System.Windows.Forms.Button
    Friend WithEvents btnSairLog As System.Windows.Forms.Button
    Friend WithEvents gbLog As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtusuariolog As System.Windows.Forms.TextBox
    Friend WithEvents lbSetor As System.Windows.Forms.Label
    Friend WithEvents txtxmllog As System.Windows.Forms.TextBox
    Friend WithEvents txtsetorlog As System.Windows.Forms.TextBox
    Friend WithEvents lbData As System.Windows.Forms.Label
    Friend WithEvents txtDatalog As System.Windows.Forms.TextBox
    Friend WithEvents lgXml As System.Windows.Forms.Label
    Friend WithEvents dgLog As System.Windows.Forms.DataGridView
    Friend WithEvents XML As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DATA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SETOR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents USUARIO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CTe As System.Windows.Forms.TabPage
    Friend WithEvents gbNf As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbFilialcte As System.Windows.Forms.Label
    Friend WithEvents txtfilialcte As System.Windows.Forms.TextBox
    Friend WithEvents lbSepara As System.Windows.Forms.Label
    Friend WithEvents lbSerie As System.Windows.Forms.Label
    Friend WithEvents txtSerie As System.Windows.Forms.TextBox
    Friend WithEvents lbNf As System.Windows.Forms.Label
    Friend WithEvents txtNf As System.Windows.Forms.TextBox
    Friend WithEvents dgCTe As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chkboxpo As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents XML_PO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DATAEMISSAO_XML_PO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CNPJ_PO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RAZAO_SOCIAL_PO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents img_po As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents NUMEROMOV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SERIE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TIPO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CODFILIALPO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pbcte As System.Windows.Forms.PictureBox
    Friend WithEvents gbCTe As System.Windows.Forms.GroupBox
    Friend WithEvents lbdataemissaocte As System.Windows.Forms.Label
    Friend WithEvents txtdataemissaocte As System.Windows.Forms.TextBox
    Friend WithEvents lbCTe As System.Windows.Forms.Label
    Friend WithEvents txtxmlcte As System.Windows.Forms.TextBox
    Friend WithEvents gbcliforcte As System.Windows.Forms.GroupBox
    Friend WithEvents txtrazaocte As System.Windows.Forms.TextBox
    Friend WithEvents lbrazaocte As System.Windows.Forms.Label
    Friend WithEvents lbcnpjcte As System.Windows.Forms.Label
    Friend WithEvents txtcnpjcte As System.Windows.Forms.TextBox
    Friend WithEvents gbacoescte As System.Windows.Forms.GroupBox
    Friend WithEvents btnmanualcte As System.Windows.Forms.Button
    Friend WithEvents btnexcluicte As System.Windows.Forms.Button
    Friend WithEvents btnatuvisaocte As System.Windows.Forms.Button
    Friend WithEvents btnmarcatodoscte As System.Windows.Forms.Button
    Friend WithEvents btnsaircte As System.Windows.Forms.Button
    Friend WithEvents btnreprocessacte As System.Windows.Forms.Button
    Friend WithEvents Fiscal As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbFilialFis As System.Windows.Forms.Label
    Friend WithEvents txtfilialfis As System.Windows.Forms.TextBox
    Friend WithEvents gbxmlfiscal As System.Windows.Forms.GroupBox
    Friend WithEvents lbdataemissaofiscal As System.Windows.Forms.Label
    Friend WithEvents txtdataemissaofiscal As System.Windows.Forms.TextBox
    Friend WithEvents lbidxmlfiscal As System.Windows.Forms.Label
    Friend WithEvents txtxmlfiscal As System.Windows.Forms.TextBox
    Friend WithEvents gbcliforfiscal As System.Windows.Forms.GroupBox
    Friend WithEvents txtrazaofiscal As System.Windows.Forms.TextBox
    Friend WithEvents lbrazaofiscal As System.Windows.Forms.Label
    Friend WithEvents lbcnpjfiscal As System.Windows.Forms.Label
    Friend WithEvents txtcnpjfiscal As System.Windows.Forms.TextBox
    Friend WithEvents gbacoesfiscal As System.Windows.Forms.GroupBox
    Friend WithEvents btnManualFis As System.Windows.Forms.Button
    Friend WithEvents btnExcluirFis As System.Windows.Forms.Button
    Friend WithEvents btnAtuVisao As System.Windows.Forms.Button
    Friend WithEvents btnSelSimNaoFiscal As System.Windows.Forms.Button
    Friend WithEvents btnIgnorarCriticaFiscal As System.Windows.Forms.Button
    Friend WithEvents btnsairfiscal As System.Windows.Forms.Button
    Friend WithEvents btnreprocessarfiscal As System.Windows.Forms.Button
    Friend WithEvents dgFiscal As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chkbox As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents XML_CRITICA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DATAEMISSAO_XML As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CNPJ_CRITICA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RAZAO_CRITICA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents img As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents TIPO_ERR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CODFILIAL_ As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cadastros As System.Windows.Forms.TabPage
    Friend WithEvents gbFilial As System.Windows.Forms.GroupBox
    Friend WithEvents lbFilial As System.Windows.Forms.Label
    Friend WithEvents txtFilial As System.Windows.Forms.TextBox
    Friend WithEvents dgCadastros As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chk As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents NOME_XML As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DATAEMISSAO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CNPJ As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RAZAO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents imgcad As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents TIPO_ERRO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CODFILIAL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gbxmlcad As System.Windows.Forms.GroupBox
    Friend WithEvents lddataemissaocad As System.Windows.Forms.Label
    Friend WithEvents txtdataemissaocad As System.Windows.Forms.TextBox
    Friend WithEvents lbidxmlcad As System.Windows.Forms.Label
    Friend WithEvents txtxmlcad As System.Windows.Forms.TextBox
    Friend WithEvents gbcliforcad As System.Windows.Forms.GroupBox
    Friend WithEvents txtrazaocad As System.Windows.Forms.TextBox
    Friend WithEvents lbrazaocad As System.Windows.Forms.Label
    Friend WithEvents lbcnpjcad As System.Windows.Forms.Label
    Friend WithEvents txtcnpjcad As System.Windows.Forms.TextBox
    Friend WithEvents gbacoescad As System.Windows.Forms.GroupBox
    Friend WithEvents btnManualCad As System.Windows.Forms.Button
    Friend WithEvents btnExcluirCad As System.Windows.Forms.Button
    Friend WithEvents btnAtuTela As System.Windows.Forms.Button
    Friend WithEvents btnSelSimNaoCad As System.Windows.Forms.Button
    Friend WithEvents btnsaicad As System.Windows.Forms.Button
    Friend WithEvents btnreprocessaxmlcad As System.Windows.Forms.Button
    Friend WithEvents TabCritica As System.Windows.Forms.TabControl
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents ServicoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsuáriosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCnpjInterno As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtGrupo As TextBox
End Class
