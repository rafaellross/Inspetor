<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalhaFiscal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalhaFiscal))
        Me.dgDetalhaFiscal = New System.Windows.Forms.DataGridView()
        Me.ITEM_XML = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DATAEMISSAO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CNPJ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RAZAO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CRITICA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COD_PRD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COD_PRD_AUX = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESC_PRD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VALOR_PRD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CST = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ALIQ_ICMS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ALIQ_ICMSST = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RED_BC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VALOR_ICMS_XML = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VALOR_ICMS_CALC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VALOR_ICMSST_XML = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VALOR_ICMSST_CALC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VALOR_MVA_XML = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VALOR_MVA_PRD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VALOR_BCST_XML = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VALOR_BCST_CALC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VALOR_BCRED_XML = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VALOR_BCRED_CALC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbDetalhes = New System.Windows.Forms.GroupBox()
        Me.gbcritica = New System.Windows.Forms.GroupBox()
        Me.txtcritica = New System.Windows.Forms.RichTextBox()
        Me.gbvaltributos = New System.Windows.Forms.GroupBox()
        Me.txtvlbcstxml = New System.Windows.Forms.TextBox()
        Me.lbicmsxml = New System.Windows.Forms.Label()
        Me.txtvaloricmsxml = New System.Windows.Forms.TextBox()
        Me.txtvaloricmscalc = New System.Windows.Forms.TextBox()
        Me.lbicmscalm = New System.Windows.Forms.Label()
        Me.txtvaloricmsstxml = New System.Windows.Forms.TextBox()
        Me.lbicmsstxml = New System.Windows.Forms.Label()
        Me.txtvaloricmsstcalc = New System.Windows.Forms.TextBox()
        Me.lbvalorbcredcalc = New System.Windows.Forms.Label()
        Me.lbicmsstcalc = New System.Windows.Forms.Label()
        Me.txtvalorbcredcalc = New System.Windows.Forms.TextBox()
        Me.txtvalorbcredxml = New System.Windows.Forms.TextBox()
        Me.lbvalorbcstxml = New System.Windows.Forms.Label()
        Me.lbvalorbcredxml = New System.Windows.Forms.Label()
        Me.txtvalorbcstcalc = New System.Windows.Forms.TextBox()
        Me.lbvalorbcstcalc = New System.Windows.Forms.Label()
        Me.gbaliqtributos = New System.Windows.Forms.GroupBox()
        Me.lbcst = New System.Windows.Forms.Label()
        Me.lbvalormvaxml = New System.Windows.Forms.Label()
        Me.txtcst = New System.Windows.Forms.TextBox()
        Me.txtvalormvaprd = New System.Windows.Forms.TextBox()
        Me.lbaliqicms = New System.Windows.Forms.Label()
        Me.txtvalormvaxml = New System.Windows.Forms.TextBox()
        Me.lbredbc = New System.Windows.Forms.Label()
        Me.txtaliqicms = New System.Windows.Forms.TextBox()
        Me.lbvalormvaprd = New System.Windows.Forms.Label()
        Me.txtredbc = New System.Windows.Forms.TextBox()
        Me.txtaliqicmsst = New System.Windows.Forms.TextBox()
        Me.lbaliqicmsst = New System.Windows.Forms.Label()
        Me.gbproduto = New System.Windows.Forms.GroupBox()
        Me.lbprdrm = New System.Windows.Forms.Label()
        Me.txtprdrm = New System.Windows.Forms.TextBox()
        Me.lbprdfor = New System.Windows.Forms.Label()
        Me.txtprdfor = New System.Windows.Forms.TextBox()
        Me.txtdescprd = New System.Windows.Forms.TextBox()
        Me.lbdescprd = New System.Windows.Forms.Label()
        Me.txtvalprd = New System.Windows.Forms.TextBox()
        Me.lbvalprd = New System.Windows.Forms.Label()
        Me.gbclifor = New System.Windows.Forms.GroupBox()
        Me.lbcnpj = New System.Windows.Forms.Label()
        Me.txtcnpj = New System.Windows.Forms.TextBox()
        Me.txtrazao = New System.Windows.Forms.TextBox()
        Me.lbrazao = New System.Windows.Forms.Label()
        Me.gbxml = New System.Windows.Forms.GroupBox()
        Me.lbdataemissao = New System.Windows.Forms.Label()
        Me.txtdataemissao = New System.Windows.Forms.TextBox()
        Me.lbitem = New System.Windows.Forms.Label()
        Me.txtitem = New System.Windows.Forms.TextBox()
        Me.lbidxml = New System.Windows.Forms.Label()
        Me.txtxml = New System.Windows.Forms.TextBox()
        CType(Me.dgDetalhaFiscal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDetalhes.SuspendLayout()
        Me.gbcritica.SuspendLayout()
        Me.gbvaltributos.SuspendLayout()
        Me.gbaliqtributos.SuspendLayout()
        Me.gbproduto.SuspendLayout()
        Me.gbclifor.SuspendLayout()
        Me.gbxml.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgDetalhaFiscal
        '
        Me.dgDetalhaFiscal.AllowUserToAddRows = False
        Me.dgDetalhaFiscal.AllowUserToDeleteRows = False
        Me.dgDetalhaFiscal.AllowUserToResizeColumns = False
        Me.dgDetalhaFiscal.AllowUserToResizeRows = False
        Me.dgDetalhaFiscal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgDetalhaFiscal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDetalhaFiscal.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ITEM_XML, Me.DATAEMISSAO, Me.CNPJ, Me.RAZAO, Me.CRITICA, Me.COD_PRD, Me.COD_PRD_AUX, Me.DESC_PRD, Me.VALOR_PRD, Me.CST, Me.ALIQ_ICMS, Me.ALIQ_ICMSST, Me.RED_BC, Me.VALOR_ICMS_XML, Me.VALOR_ICMS_CALC, Me.VALOR_ICMSST_XML, Me.VALOR_ICMSST_CALC, Me.VALOR_MVA_XML, Me.VALOR_MVA_PRD, Me.VALOR_BCST_XML, Me.VALOR_BCST_CALC, Me.VALOR_BCRED_XML, Me.VALOR_BCRED_CALC})
        Me.dgDetalhaFiscal.Location = New System.Drawing.Point(18, 7)
        Me.dgDetalhaFiscal.Name = "dgDetalhaFiscal"
        Me.dgDetalhaFiscal.ReadOnly = True
        Me.dgDetalhaFiscal.Size = New System.Drawing.Size(975, 278)
        Me.dgDetalhaFiscal.TabIndex = 0
        '
        'ITEM_XML
        '
        Me.ITEM_XML.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ITEM_XML.DataPropertyName = "ITEM_XML"
        Me.ITEM_XML.HeaderText = "ITEM XML"
        Me.ITEM_XML.Name = "ITEM_XML"
        Me.ITEM_XML.ReadOnly = True
        Me.ITEM_XML.Width = 77
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
        Me.RAZAO.HeaderText = "RAZAO"
        Me.RAZAO.Name = "RAZAO"
        Me.RAZAO.ReadOnly = True
        Me.RAZAO.Width = 69
        '
        'CRITICA
        '
        Me.CRITICA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CRITICA.DataPropertyName = "CRITICA"
        Me.CRITICA.HeaderText = "CRITICA"
        Me.CRITICA.Name = "CRITICA"
        Me.CRITICA.ReadOnly = True
        Me.CRITICA.Width = 74
        '
        'COD_PRD
        '
        Me.COD_PRD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.COD_PRD.DataPropertyName = "COD_PRD"
        Me.COD_PRD.HeaderText = "PRD PROTHEUS"
        Me.COD_PRD.Name = "COD_PRD"
        Me.COD_PRD.ReadOnly = True
        Me.COD_PRD.Width = 108
        '
        'COD_PRD_AUX
        '
        Me.COD_PRD_AUX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.COD_PRD_AUX.DataPropertyName = "COD_PRD_AUX"
        Me.COD_PRD_AUX.HeaderText = "PRD FOR"
        Me.COD_PRD_AUX.Name = "COD_PRD_AUX"
        Me.COD_PRD_AUX.ReadOnly = True
        Me.COD_PRD_AUX.Width = 74
        '
        'DESC_PRD
        '
        Me.DESC_PRD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DESC_PRD.DataPropertyName = "DESC_PRD"
        Me.DESC_PRD.HeaderText = "DESC PRODUTO"
        Me.DESC_PRD.Name = "DESC_PRD"
        Me.DESC_PRD.ReadOnly = True
        Me.DESC_PRD.Width = 108
        '
        'VALOR_PRD
        '
        Me.VALOR_PRD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.VALOR_PRD.DataPropertyName = "VALOR_PRD"
        Me.VALOR_PRD.HeaderText = "VALOR PRODUTO"
        Me.VALOR_PRD.Name = "VALOR_PRD"
        Me.VALOR_PRD.ReadOnly = True
        Me.VALOR_PRD.Width = 114
        '
        'CST
        '
        Me.CST.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CST.DataPropertyName = "CST"
        Me.CST.HeaderText = "CST"
        Me.CST.Name = "CST"
        Me.CST.ReadOnly = True
        Me.CST.Width = 53
        '
        'ALIQ_ICMS
        '
        Me.ALIQ_ICMS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ALIQ_ICMS.DataPropertyName = "ALIQ_ICMS"
        Me.ALIQ_ICMS.HeaderText = "ALIQ ICMS"
        Me.ALIQ_ICMS.Name = "ALIQ_ICMS"
        Me.ALIQ_ICMS.ReadOnly = True
        Me.ALIQ_ICMS.Width = 78
        '
        'ALIQ_ICMSST
        '
        Me.ALIQ_ICMSST.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ALIQ_ICMSST.DataPropertyName = "ALIQ_ICMSST"
        Me.ALIQ_ICMSST.HeaderText = "ALIQ ICMSST"
        Me.ALIQ_ICMSST.Name = "ALIQ_ICMSST"
        Me.ALIQ_ICMSST.ReadOnly = True
        Me.ALIQ_ICMSST.Width = 91
        '
        'RED_BC
        '
        Me.RED_BC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.RED_BC.DataPropertyName = "RED_BC"
        Me.RED_BC.HeaderText = "RED BC"
        Me.RED_BC.Name = "RED_BC"
        Me.RED_BC.ReadOnly = True
        Me.RED_BC.Width = 67
        '
        'VALOR_ICMS_XML
        '
        Me.VALOR_ICMS_XML.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.VALOR_ICMS_XML.DataPropertyName = "VALOR_ICMS_XML"
        Me.VALOR_ICMS_XML.HeaderText = "ICMS XML"
        Me.VALOR_ICMS_XML.Name = "VALOR_ICMS_XML"
        Me.VALOR_ICMS_XML.ReadOnly = True
        Me.VALOR_ICMS_XML.Width = 77
        '
        'VALOR_ICMS_CALC
        '
        Me.VALOR_ICMS_CALC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.VALOR_ICMS_CALC.DataPropertyName = "VALOR_ICMS_CALC"
        Me.VALOR_ICMS_CALC.HeaderText = "ICMS CALC"
        Me.VALOR_ICMS_CALC.Name = "VALOR_ICMS_CALC"
        Me.VALOR_ICMS_CALC.ReadOnly = True
        Me.VALOR_ICMS_CALC.Width = 81
        '
        'VALOR_ICMSST_XML
        '
        Me.VALOR_ICMSST_XML.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.VALOR_ICMSST_XML.DataPropertyName = "VALOR_ICMSST_XML"
        Me.VALOR_ICMSST_XML.HeaderText = "ICMSST XML"
        Me.VALOR_ICMSST_XML.Name = "VALOR_ICMSST_XML"
        Me.VALOR_ICMSST_XML.ReadOnly = True
        Me.VALOR_ICMSST_XML.Width = 89
        '
        'VALOR_ICMSST_CALC
        '
        Me.VALOR_ICMSST_CALC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.VALOR_ICMSST_CALC.DataPropertyName = "VALOR_ICMSST_CALC"
        Me.VALOR_ICMSST_CALC.HeaderText = "ICMSST CALC"
        Me.VALOR_ICMSST_CALC.Name = "VALOR_ICMSST_CALC"
        Me.VALOR_ICMSST_CALC.ReadOnly = True
        Me.VALOR_ICMSST_CALC.Width = 94
        '
        'VALOR_MVA_XML
        '
        Me.VALOR_MVA_XML.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.VALOR_MVA_XML.DataPropertyName = "VALOR_MVA_XML"
        Me.VALOR_MVA_XML.HeaderText = "MVA XML"
        Me.VALOR_MVA_XML.Name = "VALOR_MVA_XML"
        Me.VALOR_MVA_XML.ReadOnly = True
        Me.VALOR_MVA_XML.Width = 74
        '
        'VALOR_MVA_PRD
        '
        Me.VALOR_MVA_PRD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.VALOR_MVA_PRD.DataPropertyName = "VALOR_MVA_PRD"
        Me.VALOR_MVA_PRD.HeaderText = "MVA PRD"
        Me.VALOR_MVA_PRD.Name = "VALOR_MVA_PRD"
        Me.VALOR_MVA_PRD.ReadOnly = True
        Me.VALOR_MVA_PRD.Width = 75
        '
        'VALOR_BCST_XML
        '
        Me.VALOR_BCST_XML.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.VALOR_BCST_XML.DataPropertyName = "VALOR_BCST_XML"
        Me.VALOR_BCST_XML.HeaderText = "BCST XML"
        Me.VALOR_BCST_XML.Name = "VALOR_BCST_XML"
        Me.VALOR_BCST_XML.ReadOnly = True
        Me.VALOR_BCST_XML.Width = 78
        '
        'VALOR_BCST_CALC
        '
        Me.VALOR_BCST_CALC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.VALOR_BCST_CALC.DataPropertyName = "VALOR_BCST_CALC"
        Me.VALOR_BCST_CALC.HeaderText = "BCST CALC"
        Me.VALOR_BCST_CALC.Name = "VALOR_BCST_CALC"
        Me.VALOR_BCST_CALC.ReadOnly = True
        Me.VALOR_BCST_CALC.Width = 83
        '
        'VALOR_BCRED_XML
        '
        Me.VALOR_BCRED_XML.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.VALOR_BCRED_XML.DataPropertyName = "VALOR_BCRED_XML"
        Me.VALOR_BCRED_XML.HeaderText = "BCRED XML"
        Me.VALOR_BCRED_XML.Name = "VALOR_BCRED_XML"
        Me.VALOR_BCRED_XML.ReadOnly = True
        Me.VALOR_BCRED_XML.Width = 87
        '
        'VALOR_BCRED_CALC
        '
        Me.VALOR_BCRED_CALC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.VALOR_BCRED_CALC.DataPropertyName = "VALOR_BCRED_CALC"
        Me.VALOR_BCRED_CALC.HeaderText = "BCRED CALC"
        Me.VALOR_BCRED_CALC.Name = "VALOR_BCRED_CALC"
        Me.VALOR_BCRED_CALC.ReadOnly = True
        Me.VALOR_BCRED_CALC.Width = 91
        '
        'gbDetalhes
        '
        Me.gbDetalhes.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.gbDetalhes.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.gbDetalhes.Controls.Add(Me.gbcritica)
        Me.gbDetalhes.Controls.Add(Me.gbvaltributos)
        Me.gbDetalhes.Controls.Add(Me.gbaliqtributos)
        Me.gbDetalhes.Controls.Add(Me.gbproduto)
        Me.gbDetalhes.Controls.Add(Me.gbclifor)
        Me.gbDetalhes.Controls.Add(Me.gbxml)
        Me.gbDetalhes.Location = New System.Drawing.Point(22, 291)
        Me.gbDetalhes.Name = "gbDetalhes"
        Me.gbDetalhes.Size = New System.Drawing.Size(967, 358)
        Me.gbDetalhes.TabIndex = 1
        Me.gbDetalhes.TabStop = False
        Me.gbDetalhes.Text = "Detalhes da Crítica"
        '
        'gbcritica
        '
        Me.gbcritica.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.gbcritica.Controls.Add(Me.txtcritica)
        Me.gbcritica.Location = New System.Drawing.Point(598, 153)
        Me.gbcritica.Name = "gbcritica"
        Me.gbcritica.Size = New System.Drawing.Size(359, 172)
        Me.gbcritica.TabIndex = 54
        Me.gbcritica.TabStop = False
        Me.gbcritica.Text = "Crítica"
        '
        'txtcritica
        '
        Me.txtcritica.Location = New System.Drawing.Point(6, 19)
        Me.txtcritica.Name = "txtcritica"
        Me.txtcritica.Size = New System.Drawing.Size(347, 142)
        Me.txtcritica.TabIndex = 53
        Me.txtcritica.Text = ""
        '
        'gbvaltributos
        '
        Me.gbvaltributos.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.gbvaltributos.Controls.Add(Me.txtvlbcstxml)
        Me.gbvaltributos.Controls.Add(Me.lbicmsxml)
        Me.gbvaltributos.Controls.Add(Me.txtvaloricmsxml)
        Me.gbvaltributos.Controls.Add(Me.txtvaloricmscalc)
        Me.gbvaltributos.Controls.Add(Me.lbicmscalm)
        Me.gbvaltributos.Controls.Add(Me.txtvaloricmsstxml)
        Me.gbvaltributos.Controls.Add(Me.lbicmsstxml)
        Me.gbvaltributos.Controls.Add(Me.txtvaloricmsstcalc)
        Me.gbvaltributos.Controls.Add(Me.lbvalorbcredcalc)
        Me.gbvaltributos.Controls.Add(Me.lbicmsstcalc)
        Me.gbvaltributos.Controls.Add(Me.txtvalorbcredcalc)
        Me.gbvaltributos.Controls.Add(Me.txtvalorbcredxml)
        Me.gbvaltributos.Controls.Add(Me.lbvalorbcstxml)
        Me.gbvaltributos.Controls.Add(Me.lbvalorbcredxml)
        Me.gbvaltributos.Controls.Add(Me.txtvalorbcstcalc)
        Me.gbvaltributos.Controls.Add(Me.lbvalorbcstcalc)
        Me.gbvaltributos.Location = New System.Drawing.Point(6, 153)
        Me.gbvaltributos.Name = "gbvaltributos"
        Me.gbvaltributos.Size = New System.Drawing.Size(396, 103)
        Me.gbvaltributos.TabIndex = 52
        Me.gbvaltributos.TabStop = False
        Me.gbvaltributos.Text = "Valores dos Tributos"
        '
        'txtvlbcstxml
        '
        Me.txtvlbcstxml.Location = New System.Drawing.Point(9, 74)
        Me.txtvlbcstxml.Name = "txtvlbcstxml"
        Me.txtvlbcstxml.Size = New System.Drawing.Size(90, 20)
        Me.txtvlbcstxml.TabIndex = 46
        '
        'lbicmsxml
        '
        Me.lbicmsxml.AutoSize = True
        Me.lbicmsxml.Location = New System.Drawing.Point(6, 16)
        Me.lbicmsxml.Name = "lbicmsxml"
        Me.lbicmsxml.Size = New System.Drawing.Size(58, 13)
        Me.lbicmsxml.TabIndex = 27
        Me.lbicmsxml.Text = "ICMS XML"
        '
        'txtvaloricmsxml
        '
        Me.txtvaloricmsxml.Location = New System.Drawing.Point(9, 32)
        Me.txtvaloricmsxml.Name = "txtvaloricmsxml"
        Me.txtvaloricmsxml.Size = New System.Drawing.Size(90, 20)
        Me.txtvaloricmsxml.TabIndex = 26
        '
        'txtvaloricmscalc
        '
        Me.txtvaloricmscalc.Location = New System.Drawing.Point(105, 32)
        Me.txtvaloricmscalc.Name = "txtvaloricmscalc"
        Me.txtvaloricmscalc.Size = New System.Drawing.Size(90, 20)
        Me.txtvaloricmscalc.TabIndex = 28
        '
        'lbicmscalm
        '
        Me.lbicmscalm.AutoSize = True
        Me.lbicmscalm.Location = New System.Drawing.Point(102, 16)
        Me.lbicmscalm.Name = "lbicmscalm"
        Me.lbicmscalm.Size = New System.Drawing.Size(57, 13)
        Me.lbicmscalm.TabIndex = 29
        Me.lbicmscalm.Text = "ICMS Calc"
        '
        'txtvaloricmsstxml
        '
        Me.txtvaloricmsstxml.Location = New System.Drawing.Point(201, 32)
        Me.txtvaloricmsstxml.Name = "txtvaloricmsstxml"
        Me.txtvaloricmsstxml.Size = New System.Drawing.Size(90, 20)
        Me.txtvaloricmsstxml.TabIndex = 30
        '
        'lbicmsstxml
        '
        Me.lbicmsstxml.AutoSize = True
        Me.lbicmsstxml.Location = New System.Drawing.Point(198, 16)
        Me.lbicmsstxml.Name = "lbicmsstxml"
        Me.lbicmsstxml.Size = New System.Drawing.Size(75, 13)
        Me.lbicmsstxml.TabIndex = 31
        Me.lbicmsstxml.Text = "ICMS ST XML"
        '
        'txtvaloricmsstcalc
        '
        Me.txtvaloricmsstcalc.Location = New System.Drawing.Point(297, 32)
        Me.txtvaloricmsstcalc.Name = "txtvaloricmsstcalc"
        Me.txtvaloricmsstcalc.Size = New System.Drawing.Size(90, 20)
        Me.txtvaloricmsstcalc.TabIndex = 32
        '
        'lbvalorbcredcalc
        '
        Me.lbvalorbcredcalc.AutoSize = True
        Me.lbvalorbcredcalc.Location = New System.Drawing.Point(297, 54)
        Me.lbvalorbcredcalc.Name = "lbvalorbcredcalc"
        Me.lbvalorbcredcalc.Size = New System.Drawing.Size(68, 13)
        Me.lbvalorbcredcalc.TabIndex = 45
        Me.lbvalorbcredcalc.Text = "BC Red Calc"
        '
        'lbicmsstcalc
        '
        Me.lbicmsstcalc.AutoSize = True
        Me.lbicmsstcalc.Location = New System.Drawing.Point(294, 16)
        Me.lbicmsstcalc.Name = "lbicmsstcalc"
        Me.lbicmsstcalc.Size = New System.Drawing.Size(74, 13)
        Me.lbicmsstcalc.TabIndex = 33
        Me.lbicmsstcalc.Text = "ICMS ST Calc"
        '
        'txtvalorbcredcalc
        '
        Me.txtvalorbcredcalc.Location = New System.Drawing.Point(297, 73)
        Me.txtvalorbcredcalc.Name = "txtvalorbcredcalc"
        Me.txtvalorbcredcalc.Size = New System.Drawing.Size(90, 20)
        Me.txtvalorbcredcalc.TabIndex = 44
        '
        'txtvalorbcredxml
        '
        Me.txtvalorbcredxml.Location = New System.Drawing.Point(201, 73)
        Me.txtvalorbcredxml.Name = "txtvalorbcredxml"
        Me.txtvalorbcredxml.Size = New System.Drawing.Size(90, 20)
        Me.txtvalorbcredxml.TabIndex = 43
        '
        'lbvalorbcstxml
        '
        Me.lbvalorbcstxml.AutoSize = True
        Me.lbvalorbcstxml.Location = New System.Drawing.Point(6, 57)
        Me.lbvalorbcstxml.Name = "lbvalorbcstxml"
        Me.lbvalorbcstxml.Size = New System.Drawing.Size(63, 13)
        Me.lbvalorbcstxml.TabIndex = 38
        Me.lbvalorbcstxml.Text = "BC ST XML"
        '
        'lbvalorbcredxml
        '
        Me.lbvalorbcredxml.AutoSize = True
        Me.lbvalorbcredxml.Location = New System.Drawing.Point(198, 57)
        Me.lbvalorbcredxml.Name = "lbvalorbcredxml"
        Me.lbvalorbcredxml.Size = New System.Drawing.Size(69, 13)
        Me.lbvalorbcredxml.TabIndex = 42
        Me.lbvalorbcredxml.Text = "BC Red XML"
        '
        'txtvalorbcstcalc
        '
        Me.txtvalorbcstcalc.Location = New System.Drawing.Point(105, 73)
        Me.txtvalorbcstcalc.Name = "txtvalorbcstcalc"
        Me.txtvalorbcstcalc.Size = New System.Drawing.Size(90, 20)
        Me.txtvalorbcstcalc.TabIndex = 40
        '
        'lbvalorbcstcalc
        '
        Me.lbvalorbcstcalc.AutoSize = True
        Me.lbvalorbcstcalc.Location = New System.Drawing.Point(102, 57)
        Me.lbvalorbcstcalc.Name = "lbvalorbcstcalc"
        Me.lbvalorbcstcalc.Size = New System.Drawing.Size(62, 13)
        Me.lbvalorbcstcalc.TabIndex = 41
        Me.lbvalorbcstcalc.Text = "BC ST Calc"
        '
        'gbaliqtributos
        '
        Me.gbaliqtributos.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.gbaliqtributos.Controls.Add(Me.lbcst)
        Me.gbaliqtributos.Controls.Add(Me.lbvalormvaxml)
        Me.gbaliqtributos.Controls.Add(Me.txtcst)
        Me.gbaliqtributos.Controls.Add(Me.txtvalormvaprd)
        Me.gbaliqtributos.Controls.Add(Me.lbaliqicms)
        Me.gbaliqtributos.Controls.Add(Me.txtvalormvaxml)
        Me.gbaliqtributos.Controls.Add(Me.lbredbc)
        Me.gbaliqtributos.Controls.Add(Me.txtaliqicms)
        Me.gbaliqtributos.Controls.Add(Me.lbvalormvaprd)
        Me.gbaliqtributos.Controls.Add(Me.txtredbc)
        Me.gbaliqtributos.Controls.Add(Me.txtaliqicmsst)
        Me.gbaliqtributos.Controls.Add(Me.lbaliqicmsst)
        Me.gbaliqtributos.Location = New System.Drawing.Point(6, 262)
        Me.gbaliqtributos.Name = "gbaliqtributos"
        Me.gbaliqtributos.Size = New System.Drawing.Size(586, 63)
        Me.gbaliqtributos.TabIndex = 50
        Me.gbaliqtributos.TabStop = False
        Me.gbaliqtributos.Text = "Aliquotas dos Tributos"
        '
        'lbcst
        '
        Me.lbcst.AutoSize = True
        Me.lbcst.Location = New System.Drawing.Point(6, 16)
        Me.lbcst.Name = "lbcst"
        Me.lbcst.Size = New System.Drawing.Size(28, 13)
        Me.lbcst.TabIndex = 18
        Me.lbcst.Text = "CST"
        '
        'lbvalormvaxml
        '
        Me.lbvalormvaxml.AutoSize = True
        Me.lbvalormvaxml.Location = New System.Drawing.Point(291, 16)
        Me.lbvalormvaxml.Name = "lbvalormvaxml"
        Me.lbvalormvaxml.Size = New System.Drawing.Size(55, 13)
        Me.lbvalormvaxml.TabIndex = 35
        Me.lbvalormvaxml.Text = "MVA XML"
        '
        'txtcst
        '
        Me.txtcst.Location = New System.Drawing.Point(9, 32)
        Me.txtcst.Name = "txtcst"
        Me.txtcst.Size = New System.Drawing.Size(82, 20)
        Me.txtcst.TabIndex = 19
        '
        'txtvalormvaprd
        '
        Me.txtvalormvaprd.Location = New System.Drawing.Point(385, 32)
        Me.txtvalormvaprd.Name = "txtvalormvaprd"
        Me.txtvalormvaprd.Size = New System.Drawing.Size(82, 20)
        Me.txtvalormvaprd.TabIndex = 36
        '
        'lbaliqicms
        '
        Me.lbaliqicms.AutoSize = True
        Me.lbaliqicms.Location = New System.Drawing.Point(100, 16)
        Me.lbaliqicms.Name = "lbaliqicms"
        Me.lbaliqicms.Size = New System.Drawing.Size(53, 13)
        Me.lbaliqicms.TabIndex = 21
        Me.lbaliqicms.Text = "Aliq ICMS"
        '
        'txtvalormvaxml
        '
        Me.txtvalormvaxml.Location = New System.Drawing.Point(291, 32)
        Me.txtvalormvaxml.Name = "txtvalormvaxml"
        Me.txtvalormvaxml.Size = New System.Drawing.Size(82, 20)
        Me.txtvalormvaxml.TabIndex = 34
        '
        'lbredbc
        '
        Me.lbredbc.AutoSize = True
        Me.lbredbc.Location = New System.Drawing.Point(476, 16)
        Me.lbredbc.Name = "lbredbc"
        Me.lbredbc.Size = New System.Drawing.Size(44, 13)
        Me.lbredbc.TabIndex = 25
        Me.lbredbc.Text = "Red BC"
        '
        'txtaliqicms
        '
        Me.txtaliqicms.Location = New System.Drawing.Point(103, 32)
        Me.txtaliqicms.Name = "txtaliqicms"
        Me.txtaliqicms.Size = New System.Drawing.Size(82, 20)
        Me.txtaliqicms.TabIndex = 20
        '
        'lbvalormvaprd
        '
        Me.lbvalormvaprd.AutoSize = True
        Me.lbvalormvaprd.Location = New System.Drawing.Point(382, 16)
        Me.lbvalormvaprd.Name = "lbvalormvaprd"
        Me.lbvalormvaprd.Size = New System.Drawing.Size(49, 13)
        Me.lbvalormvaprd.TabIndex = 37
        Me.lbvalormvaprd.Text = "MVA Prd"
        '
        'txtredbc
        '
        Me.txtredbc.Location = New System.Drawing.Point(479, 32)
        Me.txtredbc.Name = "txtredbc"
        Me.txtredbc.Size = New System.Drawing.Size(82, 20)
        Me.txtredbc.TabIndex = 24
        '
        'txtaliqicmsst
        '
        Me.txtaliqicmsst.Location = New System.Drawing.Point(197, 32)
        Me.txtaliqicmsst.Name = "txtaliqicmsst"
        Me.txtaliqicmsst.Size = New System.Drawing.Size(82, 20)
        Me.txtaliqicmsst.TabIndex = 23
        '
        'lbaliqicmsst
        '
        Me.lbaliqicmsst.AutoSize = True
        Me.lbaliqicmsst.Location = New System.Drawing.Point(194, 16)
        Me.lbaliqicmsst.Name = "lbaliqicmsst"
        Me.lbaliqicmsst.Size = New System.Drawing.Size(70, 13)
        Me.lbaliqicmsst.TabIndex = 22
        Me.lbaliqicmsst.Text = "Aliq ICMS ST"
        '
        'gbproduto
        '
        Me.gbproduto.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.gbproduto.Controls.Add(Me.lbprdrm)
        Me.gbproduto.Controls.Add(Me.txtprdrm)
        Me.gbproduto.Controls.Add(Me.lbprdfor)
        Me.gbproduto.Controls.Add(Me.txtprdfor)
        Me.gbproduto.Controls.Add(Me.txtdescprd)
        Me.gbproduto.Controls.Add(Me.lbdescprd)
        Me.gbproduto.Controls.Add(Me.txtvalprd)
        Me.gbproduto.Controls.Add(Me.lbvalprd)
        Me.gbproduto.Location = New System.Drawing.Point(6, 86)
        Me.gbproduto.Name = "gbproduto"
        Me.gbproduto.Size = New System.Drawing.Size(761, 61)
        Me.gbproduto.TabIndex = 49
        Me.gbproduto.TabStop = False
        Me.gbproduto.Text = "Produto"
        '
        'lbprdrm
        '
        Me.lbprdrm.AutoSize = True
        Me.lbprdrm.Location = New System.Drawing.Point(6, 16)
        Me.lbprdrm.Name = "lbprdrm"
        Me.lbprdrm.Size = New System.Drawing.Size(43, 13)
        Me.lbprdrm.TabIndex = 11
        Me.lbprdrm.Text = "Prd RM"
        '
        'txtprdrm
        '
        Me.txtprdrm.Location = New System.Drawing.Point(6, 32)
        Me.txtprdrm.Name = "txtprdrm"
        Me.txtprdrm.Size = New System.Drawing.Size(83, 20)
        Me.txtprdrm.TabIndex = 10
        '
        'lbprdfor
        '
        Me.lbprdfor.AutoSize = True
        Me.lbprdfor.Location = New System.Drawing.Point(92, 16)
        Me.lbprdfor.Name = "lbprdfor"
        Me.lbprdfor.Size = New System.Drawing.Size(41, 13)
        Me.lbprdfor.TabIndex = 12
        Me.lbprdfor.Text = "Prd For"
        '
        'txtprdfor
        '
        Me.txtprdfor.Location = New System.Drawing.Point(95, 32)
        Me.txtprdfor.Name = "txtprdfor"
        Me.txtprdfor.Size = New System.Drawing.Size(83, 20)
        Me.txtprdfor.TabIndex = 13
        '
        'txtdescprd
        '
        Me.txtdescprd.Location = New System.Drawing.Point(184, 32)
        Me.txtdescprd.Name = "txtdescprd"
        Me.txtdescprd.Size = New System.Drawing.Size(475, 20)
        Me.txtdescprd.TabIndex = 14
        '
        'lbdescprd
        '
        Me.lbdescprd.AutoSize = True
        Me.lbdescprd.Location = New System.Drawing.Point(184, 16)
        Me.lbdescprd.Name = "lbdescprd"
        Me.lbdescprd.Size = New System.Drawing.Size(72, 13)
        Me.lbdescprd.TabIndex = 15
        Me.lbdescprd.Text = "Desc Produto"
        '
        'txtvalprd
        '
        Me.txtvalprd.Location = New System.Drawing.Point(665, 32)
        Me.txtvalprd.Name = "txtvalprd"
        Me.txtvalprd.Size = New System.Drawing.Size(87, 20)
        Me.txtvalprd.TabIndex = 16
        '
        'lbvalprd
        '
        Me.lbvalprd.AutoSize = True
        Me.lbvalprd.Location = New System.Drawing.Point(662, 16)
        Me.lbvalprd.Name = "lbvalprd"
        Me.lbvalprd.Size = New System.Drawing.Size(71, 13)
        Me.lbvalprd.TabIndex = 17
        Me.lbvalprd.Text = "Valor Produto"
        '
        'gbclifor
        '
        Me.gbclifor.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.gbclifor.Controls.Add(Me.lbcnpj)
        Me.gbclifor.Controls.Add(Me.txtcnpj)
        Me.gbclifor.Controls.Add(Me.txtrazao)
        Me.gbclifor.Controls.Add(Me.lbrazao)
        Me.gbclifor.Location = New System.Drawing.Point(463, 19)
        Me.gbclifor.Name = "gbclifor"
        Me.gbclifor.Size = New System.Drawing.Size(494, 61)
        Me.gbclifor.TabIndex = 48
        Me.gbclifor.TabStop = False
        Me.gbclifor.Text = "Cliente / Fornecedor"
        '
        'lbcnpj
        '
        Me.lbcnpj.AutoSize = True
        Me.lbcnpj.Location = New System.Drawing.Point(6, 16)
        Me.lbcnpj.Name = "lbcnpj"
        Me.lbcnpj.Size = New System.Drawing.Size(34, 13)
        Me.lbcnpj.TabIndex = 7
        Me.lbcnpj.Text = "CNPJ"
        '
        'txtcnpj
        '
        Me.txtcnpj.Location = New System.Drawing.Point(9, 32)
        Me.txtcnpj.Name = "txtcnpj"
        Me.txtcnpj.Size = New System.Drawing.Size(116, 20)
        Me.txtcnpj.TabIndex = 6
        '
        'txtrazao
        '
        Me.txtrazao.Location = New System.Drawing.Point(131, 32)
        Me.txtrazao.Name = "txtrazao"
        Me.txtrazao.Size = New System.Drawing.Size(354, 20)
        Me.txtrazao.TabIndex = 8
        '
        'lbrazao
        '
        Me.lbrazao.AutoSize = True
        Me.lbrazao.Location = New System.Drawing.Point(128, 16)
        Me.lbrazao.Name = "lbrazao"
        Me.lbrazao.Size = New System.Drawing.Size(70, 13)
        Me.lbrazao.TabIndex = 9
        Me.lbrazao.Text = "Razão Social"
        '
        'gbxml
        '
        Me.gbxml.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.gbxml.Controls.Add(Me.lbdataemissao)
        Me.gbxml.Controls.Add(Me.txtdataemissao)
        Me.gbxml.Controls.Add(Me.lbitem)
        Me.gbxml.Controls.Add(Me.txtitem)
        Me.gbxml.Controls.Add(Me.lbidxml)
        Me.gbxml.Controls.Add(Me.txtxml)
        Me.gbxml.Location = New System.Drawing.Point(6, 19)
        Me.gbxml.Name = "gbxml"
        Me.gbxml.Size = New System.Drawing.Size(437, 61)
        Me.gbxml.TabIndex = 47
        Me.gbxml.TabStop = False
        Me.gbxml.Text = "XML"
        '
        'lbdataemissao
        '
        Me.lbdataemissao.AutoSize = True
        Me.lbdataemissao.Location = New System.Drawing.Point(359, 16)
        Me.lbdataemissao.Name = "lbdataemissao"
        Me.lbdataemissao.Size = New System.Drawing.Size(72, 13)
        Me.lbdataemissao.TabIndex = 5
        Me.lbdataemissao.Text = "Data Emissão"
        '
        'txtdataemissao
        '
        Me.txtdataemissao.Location = New System.Drawing.Point(362, 32)
        Me.txtdataemissao.Name = "txtdataemissao"
        Me.txtdataemissao.Size = New System.Drawing.Size(69, 20)
        Me.txtdataemissao.TabIndex = 4
        '
        'lbitem
        '
        Me.lbitem.AutoSize = True
        Me.lbitem.Location = New System.Drawing.Point(319, 16)
        Me.lbitem.Name = "lbitem"
        Me.lbitem.Size = New System.Drawing.Size(27, 13)
        Me.lbitem.TabIndex = 3
        Me.lbitem.Text = "Item"
        '
        'txtitem
        '
        Me.txtitem.Location = New System.Drawing.Point(322, 32)
        Me.txtitem.Name = "txtitem"
        Me.txtitem.Size = New System.Drawing.Size(34, 20)
        Me.txtitem.TabIndex = 2
        '
        'lbidxml
        '
        Me.lbidxml.AutoSize = True
        Me.lbidxml.Location = New System.Drawing.Point(6, 16)
        Me.lbidxml.Name = "lbidxml"
        Me.lbidxml.Size = New System.Drawing.Size(43, 13)
        Me.lbidxml.TabIndex = 1
        Me.lbidxml.Text = "ID XML"
        '
        'txtxml
        '
        Me.txtxml.Location = New System.Drawing.Point(9, 32)
        Me.txtxml.Name = "txtxml"
        Me.txtxml.Size = New System.Drawing.Size(307, 20)
        Me.txtxml.TabIndex = 0
        '
        'frmDetalhaFiscal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(1008, 662)
        Me.Controls.Add(Me.gbDetalhes)
        Me.Controls.Add(Me.dgDetalhaFiscal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDetalhaFiscal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalhes Fiscais"
        CType(Me.dgDetalhaFiscal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDetalhes.ResumeLayout(False)
        Me.gbcritica.ResumeLayout(False)
        Me.gbvaltributos.ResumeLayout(False)
        Me.gbvaltributos.PerformLayout()
        Me.gbaliqtributos.ResumeLayout(False)
        Me.gbaliqtributos.PerformLayout()
        Me.gbproduto.ResumeLayout(False)
        Me.gbproduto.PerformLayout()
        Me.gbclifor.ResumeLayout(False)
        Me.gbclifor.PerformLayout()
        Me.gbxml.ResumeLayout(False)
        Me.gbxml.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgDetalhaFiscal As System.Windows.Forms.DataGridView
    Friend WithEvents gbDetalhes As System.Windows.Forms.GroupBox
    Friend WithEvents lbvalormvaxml As System.Windows.Forms.Label
    Friend WithEvents txtvalormvaxml As System.Windows.Forms.TextBox
    Friend WithEvents lbicmsstcalc As System.Windows.Forms.Label
    Friend WithEvents txtvaloricmsstcalc As System.Windows.Forms.TextBox
    Friend WithEvents lbicmsstxml As System.Windows.Forms.Label
    Friend WithEvents txtvaloricmsstxml As System.Windows.Forms.TextBox
    Friend WithEvents lbicmscalm As System.Windows.Forms.Label
    Friend WithEvents txtvaloricmscalc As System.Windows.Forms.TextBox
    Friend WithEvents lbicmsxml As System.Windows.Forms.Label
    Friend WithEvents txtvaloricmsxml As System.Windows.Forms.TextBox
    Friend WithEvents lbredbc As System.Windows.Forms.Label
    Friend WithEvents txtredbc As System.Windows.Forms.TextBox
    Friend WithEvents txtaliqicmsst As System.Windows.Forms.TextBox
    Friend WithEvents lbaliqicmsst As System.Windows.Forms.Label
    Friend WithEvents lbaliqicms As System.Windows.Forms.Label
    Friend WithEvents txtaliqicms As System.Windows.Forms.TextBox
    Friend WithEvents txtcst As System.Windows.Forms.TextBox
    Friend WithEvents lbcst As System.Windows.Forms.Label
    Friend WithEvents lbvalprd As System.Windows.Forms.Label
    Friend WithEvents txtvalprd As System.Windows.Forms.TextBox
    Friend WithEvents lbdescprd As System.Windows.Forms.Label
    Friend WithEvents txtdescprd As System.Windows.Forms.TextBox
    Friend WithEvents txtprdfor As System.Windows.Forms.TextBox
    Friend WithEvents lbprdfor As System.Windows.Forms.Label
    Friend WithEvents lbprdrm As System.Windows.Forms.Label
    Friend WithEvents txtprdrm As System.Windows.Forms.TextBox
    Friend WithEvents lbrazao As System.Windows.Forms.Label
    Friend WithEvents txtrazao As System.Windows.Forms.TextBox
    Friend WithEvents lbcnpj As System.Windows.Forms.Label
    Friend WithEvents txtcnpj As System.Windows.Forms.TextBox
    Friend WithEvents lbdataemissao As System.Windows.Forms.Label
    Friend WithEvents txtdataemissao As System.Windows.Forms.TextBox
    Friend WithEvents lbitem As System.Windows.Forms.Label
    Friend WithEvents txtitem As System.Windows.Forms.TextBox
    Friend WithEvents lbidxml As System.Windows.Forms.Label
    Friend WithEvents txtxml As System.Windows.Forms.TextBox
    Friend WithEvents lbvalorbcredcalc As System.Windows.Forms.Label
    Friend WithEvents txtvalorbcredcalc As System.Windows.Forms.TextBox
    Friend WithEvents txtvalorbcredxml As System.Windows.Forms.TextBox
    Friend WithEvents lbvalorbcredxml As System.Windows.Forms.Label
    Friend WithEvents lbvalorbcstcalc As System.Windows.Forms.Label
    Friend WithEvents txtvalorbcstcalc As System.Windows.Forms.TextBox
    Friend WithEvents lbvalorbcstxml As System.Windows.Forms.Label
    Friend WithEvents lbvalormvaprd As System.Windows.Forms.Label
    Friend WithEvents txtvalormvaprd As System.Windows.Forms.TextBox
    Friend WithEvents gbxml As System.Windows.Forms.GroupBox
    Friend WithEvents gbaliqtributos As System.Windows.Forms.GroupBox
    Friend WithEvents gbproduto As System.Windows.Forms.GroupBox
    Friend WithEvents gbclifor As System.Windows.Forms.GroupBox
    Friend WithEvents gbvaltributos As System.Windows.Forms.GroupBox
    Friend WithEvents gbcritica As System.Windows.Forms.GroupBox
    Friend WithEvents txtcritica As System.Windows.Forms.RichTextBox
    Friend WithEvents txtvlbcstxml As System.Windows.Forms.TextBox
    Friend WithEvents ITEM_XML As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DATAEMISSAO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CNPJ As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RAZAO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CRITICA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COD_PRD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COD_PRD_AUX As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DESC_PRD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VALOR_PRD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CST As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ALIQ_ICMS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ALIQ_ICMSST As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RED_BC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VALOR_ICMS_XML As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VALOR_ICMS_CALC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VALOR_ICMSST_XML As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VALOR_ICMSST_CALC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VALOR_MVA_XML As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VALOR_MVA_PRD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VALOR_BCST_XML As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VALOR_BCST_CALC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VALOR_BCRED_XML As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VALOR_BCRED_CALC As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
