<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalhaCadastro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalhaCadastro))
        Me.dgDetalhaCadastro = New System.Windows.Forms.DataGridView()
        Me.DATAEMISSAO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CNPJ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RAZAO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ITEM_XML = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CODPRD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COD_PRD_AUX = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESC_PRD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CRITICA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbDetalhescad = New System.Windows.Forms.GroupBox()
        Me.gbcriticacad = New System.Windows.Forms.GroupBox()
        Me.txtcriticacad = New System.Windows.Forms.RichTextBox()
        Me.gbprodutocad = New System.Windows.Forms.GroupBox()
        Me.lbund = New System.Windows.Forms.Label()
        Me.txtund = New System.Windows.Forms.TextBox()
        Me.lbprdrmcad = New System.Windows.Forms.Label()
        Me.txtprdrmcad = New System.Windows.Forms.TextBox()
        Me.lbprdforcad = New System.Windows.Forms.Label()
        Me.txtprdforcad = New System.Windows.Forms.TextBox()
        Me.txtdescprdcad = New System.Windows.Forms.TextBox()
        Me.lbdescprdcad = New System.Windows.Forms.Label()
        Me.gbcliforcad = New System.Windows.Forms.GroupBox()
        Me.lbcnpjcad = New System.Windows.Forms.Label()
        Me.txtcnpjcad = New System.Windows.Forms.TextBox()
        Me.txtrazaocad = New System.Windows.Forms.TextBox()
        Me.lbrazaocad = New System.Windows.Forms.Label()
        Me.gbxmlcad = New System.Windows.Forms.GroupBox()
        Me.lbdataemissaocad = New System.Windows.Forms.Label()
        Me.txtdataemissaocad = New System.Windows.Forms.TextBox()
        Me.lbitemcad = New System.Windows.Forms.Label()
        Me.txtitemcad = New System.Windows.Forms.TextBox()
        Me.lbidxml = New System.Windows.Forms.Label()
        Me.txtxmlcad = New System.Windows.Forms.TextBox()
        CType(Me.dgDetalhaCadastro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDetalhescad.SuspendLayout()
        Me.gbcriticacad.SuspendLayout()
        Me.gbprodutocad.SuspendLayout()
        Me.gbcliforcad.SuspendLayout()
        Me.gbxmlcad.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgDetalhaCadastro
        '
        Me.dgDetalhaCadastro.AllowUserToAddRows = False
        Me.dgDetalhaCadastro.AllowUserToDeleteRows = False
        Me.dgDetalhaCadastro.AllowUserToResizeColumns = False
        Me.dgDetalhaCadastro.AllowUserToResizeRows = False
        Me.dgDetalhaCadastro.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgDetalhaCadastro.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DATAEMISSAO, Me.CNPJ, Me.RAZAO, Me.ITEM_XML, Me.CODPRD, Me.COD_PRD_AUX, Me.DESC_PRD, Me.CRITICA})
        Me.dgDetalhaCadastro.Location = New System.Drawing.Point(13, 12)
        Me.dgDetalhaCadastro.Name = "dgDetalhaCadastro"
        Me.dgDetalhaCadastro.ReadOnly = True
        Me.dgDetalhaCadastro.Size = New System.Drawing.Size(983, 398)
        Me.dgDetalhaCadastro.TabIndex = 0
        '
        'DATAEMISSAO
        '
        Me.DATAEMISSAO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DATAEMISSAO.DataPropertyName = "DATAEMISSAO"
        Me.DATAEMISSAO.HeaderText = "DATA EMISSAO"
        Me.DATAEMISSAO.Name = "DATAEMISSAO"
        Me.DATAEMISSAO.ReadOnly = True
        Me.DATAEMISSAO.Width = 112
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
        'ITEM_XML
        '
        Me.ITEM_XML.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ITEM_XML.DataPropertyName = "ITEM_XML"
        Me.ITEM_XML.HeaderText = "ITEM"
        Me.ITEM_XML.Name = "ITEM_XML"
        Me.ITEM_XML.ReadOnly = True
        Me.ITEM_XML.Width = 58
        '
        'CODPRD
        '
        Me.CODPRD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CODPRD.DataPropertyName = "CODPRD"
        Me.CODPRD.HeaderText = "PRD PROTHEUS"
        Me.CODPRD.Name = "CODPRD"
        Me.CODPRD.ReadOnly = True
        Me.CODPRD.Width = 118
        '
        'COD_PRD_AUX
        '
        Me.COD_PRD_AUX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.COD_PRD_AUX.DataPropertyName = "COD_PRD_AUX"
        Me.COD_PRD_AUX.HeaderText = "PRD FOR"
        Me.COD_PRD_AUX.Name = "COD_PRD_AUX"
        Me.COD_PRD_AUX.ReadOnly = True
        Me.COD_PRD_AUX.Width = 80
        '
        'DESC_PRD
        '
        Me.DESC_PRD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DESC_PRD.DataPropertyName = "DESC_PRD"
        Me.DESC_PRD.HeaderText = "DESC PRODUTO"
        Me.DESC_PRD.Name = "DESC_PRD"
        Me.DESC_PRD.ReadOnly = True
        Me.DESC_PRD.Width = 118
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
        'gbDetalhescad
        '
        Me.gbDetalhescad.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.gbDetalhescad.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.gbDetalhescad.Controls.Add(Me.gbcriticacad)
        Me.gbDetalhescad.Controls.Add(Me.gbprodutocad)
        Me.gbDetalhescad.Controls.Add(Me.gbcliforcad)
        Me.gbDetalhescad.Controls.Add(Me.gbxmlcad)
        Me.gbDetalhescad.Location = New System.Drawing.Point(17, 416)
        Me.gbDetalhescad.Name = "gbDetalhescad"
        Me.gbDetalhescad.Size = New System.Drawing.Size(973, 234)
        Me.gbDetalhescad.TabIndex = 2
        Me.gbDetalhescad.TabStop = False
        Me.gbDetalhescad.Text = "Detalhes da Crítica"
        '
        'gbcriticacad
        '
        Me.gbcriticacad.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.gbcriticacad.Controls.Add(Me.txtcriticacad)
        Me.gbcriticacad.Location = New System.Drawing.Point(578, 19)
        Me.gbcriticacad.Name = "gbcriticacad"
        Me.gbcriticacad.Size = New System.Drawing.Size(377, 132)
        Me.gbcriticacad.TabIndex = 54
        Me.gbcriticacad.TabStop = False
        Me.gbcriticacad.Text = "Crítica"
        '
        'txtcriticacad
        '
        Me.txtcriticacad.Location = New System.Drawing.Point(6, 19)
        Me.txtcriticacad.Name = "txtcriticacad"
        Me.txtcriticacad.Size = New System.Drawing.Size(366, 107)
        Me.txtcriticacad.TabIndex = 53
        Me.txtcriticacad.Text = ""
        '
        'gbprodutocad
        '
        Me.gbprodutocad.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.gbprodutocad.Controls.Add(Me.lbund)
        Me.gbprodutocad.Controls.Add(Me.txtund)
        Me.gbprodutocad.Controls.Add(Me.lbprdrmcad)
        Me.gbprodutocad.Controls.Add(Me.txtprdrmcad)
        Me.gbprodutocad.Controls.Add(Me.lbprdforcad)
        Me.gbprodutocad.Controls.Add(Me.txtprdforcad)
        Me.gbprodutocad.Controls.Add(Me.txtdescprdcad)
        Me.gbprodutocad.Controls.Add(Me.lbdescprdcad)
        Me.gbprodutocad.Location = New System.Drawing.Point(6, 152)
        Me.gbprodutocad.Name = "gbprodutocad"
        Me.gbprodutocad.Size = New System.Drawing.Size(708, 61)
        Me.gbprodutocad.TabIndex = 49
        Me.gbprodutocad.TabStop = False
        Me.gbprodutocad.Text = "Produto"
        '
        'lbund
        '
        Me.lbund.AutoSize = True
        Me.lbund.Location = New System.Drawing.Point(616, 16)
        Me.lbund.Name = "lbund"
        Me.lbund.Size = New System.Drawing.Size(70, 13)
        Me.lbund.TabIndex = 16
        Me.lbund.Text = "Unid. Medida"
        '
        'txtund
        '
        Me.txtund.Location = New System.Drawing.Point(619, 32)
        Me.txtund.Name = "txtund"
        Me.txtund.Size = New System.Drawing.Size(83, 20)
        Me.txtund.TabIndex = 17
        '
        'lbprdrmcad
        '
        Me.lbprdrmcad.AutoSize = True
        Me.lbprdrmcad.Location = New System.Drawing.Point(6, 16)
        Me.lbprdrmcad.Name = "lbprdrmcad"
        Me.lbprdrmcad.Size = New System.Drawing.Size(68, 13)
        Me.lbprdrmcad.TabIndex = 11
        Me.lbprdrmcad.Text = "Prd Protheus"
        '
        'txtprdrmcad
        '
        Me.txtprdrmcad.Location = New System.Drawing.Point(6, 32)
        Me.txtprdrmcad.Name = "txtprdrmcad"
        Me.txtprdrmcad.Size = New System.Drawing.Size(83, 20)
        Me.txtprdrmcad.TabIndex = 10
        '
        'lbprdforcad
        '
        Me.lbprdforcad.AutoSize = True
        Me.lbprdforcad.Location = New System.Drawing.Point(92, 16)
        Me.lbprdforcad.Name = "lbprdforcad"
        Me.lbprdforcad.Size = New System.Drawing.Size(41, 13)
        Me.lbprdforcad.TabIndex = 12
        Me.lbprdforcad.Text = "Prd For"
        '
        'txtprdforcad
        '
        Me.txtprdforcad.Location = New System.Drawing.Point(95, 32)
        Me.txtprdforcad.Name = "txtprdforcad"
        Me.txtprdforcad.Size = New System.Drawing.Size(83, 20)
        Me.txtprdforcad.TabIndex = 13
        '
        'txtdescprdcad
        '
        Me.txtdescprdcad.Location = New System.Drawing.Point(184, 32)
        Me.txtdescprdcad.Name = "txtdescprdcad"
        Me.txtdescprdcad.Size = New System.Drawing.Size(429, 20)
        Me.txtdescprdcad.TabIndex = 14
        '
        'lbdescprdcad
        '
        Me.lbdescprdcad.AutoSize = True
        Me.lbdescprdcad.Location = New System.Drawing.Point(181, 16)
        Me.lbdescprdcad.Name = "lbdescprdcad"
        Me.lbdescprdcad.Size = New System.Drawing.Size(72, 13)
        Me.lbdescprdcad.TabIndex = 15
        Me.lbdescprdcad.Text = "Desc Produto"
        '
        'gbcliforcad
        '
        Me.gbcliforcad.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.gbcliforcad.Controls.Add(Me.lbcnpjcad)
        Me.gbcliforcad.Controls.Add(Me.txtcnpjcad)
        Me.gbcliforcad.Controls.Add(Me.txtrazaocad)
        Me.gbcliforcad.Controls.Add(Me.lbrazaocad)
        Me.gbcliforcad.Location = New System.Drawing.Point(6, 86)
        Me.gbcliforcad.Name = "gbcliforcad"
        Me.gbcliforcad.Size = New System.Drawing.Size(566, 61)
        Me.gbcliforcad.TabIndex = 48
        Me.gbcliforcad.TabStop = False
        Me.gbcliforcad.Text = "Cliente / Fornecedor"
        '
        'lbcnpjcad
        '
        Me.lbcnpjcad.AutoSize = True
        Me.lbcnpjcad.Location = New System.Drawing.Point(6, 16)
        Me.lbcnpjcad.Name = "lbcnpjcad"
        Me.lbcnpjcad.Size = New System.Drawing.Size(34, 13)
        Me.lbcnpjcad.TabIndex = 7
        Me.lbcnpjcad.Text = "CNPJ"
        '
        'txtcnpjcad
        '
        Me.txtcnpjcad.Location = New System.Drawing.Point(9, 32)
        Me.txtcnpjcad.Name = "txtcnpjcad"
        Me.txtcnpjcad.Size = New System.Drawing.Size(116, 20)
        Me.txtcnpjcad.TabIndex = 6
        '
        'txtrazaocad
        '
        Me.txtrazaocad.Location = New System.Drawing.Point(131, 32)
        Me.txtrazaocad.Name = "txtrazaocad"
        Me.txtrazaocad.Size = New System.Drawing.Size(429, 20)
        Me.txtrazaocad.TabIndex = 8
        '
        'lbrazaocad
        '
        Me.lbrazaocad.AutoSize = True
        Me.lbrazaocad.Location = New System.Drawing.Point(128, 16)
        Me.lbrazaocad.Name = "lbrazaocad"
        Me.lbrazaocad.Size = New System.Drawing.Size(70, 13)
        Me.lbrazaocad.TabIndex = 9
        Me.lbrazaocad.Text = "Razão Social"
        '
        'gbxmlcad
        '
        Me.gbxmlcad.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.gbxmlcad.Controls.Add(Me.lbdataemissaocad)
        Me.gbxmlcad.Controls.Add(Me.txtdataemissaocad)
        Me.gbxmlcad.Controls.Add(Me.lbitemcad)
        Me.gbxmlcad.Controls.Add(Me.txtitemcad)
        Me.gbxmlcad.Controls.Add(Me.lbidxml)
        Me.gbxmlcad.Controls.Add(Me.txtxmlcad)
        Me.gbxmlcad.Location = New System.Drawing.Point(6, 19)
        Me.gbxmlcad.Name = "gbxmlcad"
        Me.gbxmlcad.Size = New System.Drawing.Size(566, 61)
        Me.gbxmlcad.TabIndex = 47
        Me.gbxmlcad.TabStop = False
        Me.gbxmlcad.Text = "XML"
        '
        'lbdataemissaocad
        '
        Me.lbdataemissaocad.AutoSize = True
        Me.lbdataemissaocad.Location = New System.Drawing.Point(463, 16)
        Me.lbdataemissaocad.Name = "lbdataemissaocad"
        Me.lbdataemissaocad.Size = New System.Drawing.Size(72, 13)
        Me.lbdataemissaocad.TabIndex = 5
        Me.lbdataemissaocad.Text = "Data Emissão"
        '
        'txtdataemissaocad
        '
        Me.txtdataemissaocad.Location = New System.Drawing.Point(466, 32)
        Me.txtdataemissaocad.Name = "txtdataemissaocad"
        Me.txtdataemissaocad.Size = New System.Drawing.Size(94, 20)
        Me.txtdataemissaocad.TabIndex = 4
        '
        'lbitemcad
        '
        Me.lbitemcad.AutoSize = True
        Me.lbitemcad.Location = New System.Drawing.Point(414, 16)
        Me.lbitemcad.Name = "lbitemcad"
        Me.lbitemcad.Size = New System.Drawing.Size(27, 13)
        Me.lbitemcad.TabIndex = 3
        Me.lbitemcad.Text = "Item"
        '
        'txtitemcad
        '
        Me.txtitemcad.Location = New System.Drawing.Point(417, 32)
        Me.txtitemcad.Name = "txtitemcad"
        Me.txtitemcad.Size = New System.Drawing.Size(40, 20)
        Me.txtitemcad.TabIndex = 2
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
        'txtxmlcad
        '
        Me.txtxmlcad.Location = New System.Drawing.Point(9, 32)
        Me.txtxmlcad.Name = "txtxmlcad"
        Me.txtxmlcad.Size = New System.Drawing.Size(402, 20)
        Me.txtxmlcad.TabIndex = 0
        '
        'frmDetalhaCadastro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 662)
        Me.Controls.Add(Me.gbDetalhescad)
        Me.Controls.Add(Me.dgDetalhaCadastro)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDetalhaCadastro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalhes Cadastros"
        CType(Me.dgDetalhaCadastro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDetalhescad.ResumeLayout(False)
        Me.gbcriticacad.ResumeLayout(False)
        Me.gbprodutocad.ResumeLayout(False)
        Me.gbprodutocad.PerformLayout()
        Me.gbcliforcad.ResumeLayout(False)
        Me.gbcliforcad.PerformLayout()
        Me.gbxmlcad.ResumeLayout(False)
        Me.gbxmlcad.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgDetalhaCadastro As System.Windows.Forms.DataGridView
    Friend WithEvents gbDetalhescad As System.Windows.Forms.GroupBox
    Friend WithEvents gbcriticacad As System.Windows.Forms.GroupBox
    Friend WithEvents txtcriticacad As System.Windows.Forms.RichTextBox
    Friend WithEvents gbprodutocad As System.Windows.Forms.GroupBox
    Friend WithEvents lbprdrmcad As System.Windows.Forms.Label
    Friend WithEvents txtprdrmcad As System.Windows.Forms.TextBox
    Friend WithEvents lbprdforcad As System.Windows.Forms.Label
    Friend WithEvents txtprdforcad As System.Windows.Forms.TextBox
    Friend WithEvents txtdescprdcad As System.Windows.Forms.TextBox
    Friend WithEvents lbdescprdcad As System.Windows.Forms.Label
    Friend WithEvents gbcliforcad As System.Windows.Forms.GroupBox
    Friend WithEvents lbcnpjcad As System.Windows.Forms.Label
    Friend WithEvents txtcnpjcad As System.Windows.Forms.TextBox
    Friend WithEvents txtrazaocad As System.Windows.Forms.TextBox
    Friend WithEvents lbrazaocad As System.Windows.Forms.Label
    Friend WithEvents gbxmlcad As System.Windows.Forms.GroupBox
    Friend WithEvents lbdataemissaocad As System.Windows.Forms.Label
    Friend WithEvents txtdataemissaocad As System.Windows.Forms.TextBox
    Friend WithEvents lbitemcad As System.Windows.Forms.Label
    Friend WithEvents txtitemcad As System.Windows.Forms.TextBox
    Friend WithEvents lbidxml As System.Windows.Forms.Label
    Friend WithEvents txtxmlcad As System.Windows.Forms.TextBox
    Friend WithEvents lbund As System.Windows.Forms.Label
    Friend WithEvents txtund As System.Windows.Forms.TextBox
    Friend WithEvents DATAEMISSAO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CNPJ As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RAZAO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ITEM_XML As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CODPRD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COD_PRD_AUX As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DESC_PRD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CRITICA As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
