<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalhaCTe
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalhaCTe))
        Me.dgDetalhaCTe = New System.Windows.Forms.DataGridView()
        Me.DATAEMISSAO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CNPJ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RAZAO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ITEM_XML = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COD_PRD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COD_PRD_AUX = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SKU = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESC_PRD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CRITICA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbDetalhescte = New System.Windows.Forms.GroupBox()
        Me.gbNf = New System.Windows.Forms.GroupBox()
        Me.lbSepara = New System.Windows.Forms.Label()
        Me.lbSerie = New System.Windows.Forms.Label()
        Me.txtSerie = New System.Windows.Forms.TextBox()
        Me.lbNf = New System.Windows.Forms.Label()
        Me.txtNf = New System.Windows.Forms.TextBox()
        Me.gbPrdcte = New System.Windows.Forms.GroupBox()
        Me.lbSku = New System.Windows.Forms.Label()
        Me.txtsku = New System.Windows.Forms.TextBox()
        Me.lbPrdProtheus = New System.Windows.Forms.Label()
        Me.txtprdprotheuscte = New System.Windows.Forms.TextBox()
        Me.lbPrdFornece = New System.Windows.Forms.Label()
        Me.txtprdforcte = New System.Windows.Forms.TextBox()
        Me.txtdescprdcte = New System.Windows.Forms.TextBox()
        Me.lbDescPrd = New System.Windows.Forms.Label()
        Me.gbcriticacte = New System.Windows.Forms.GroupBox()
        Me.txtcriticacte = New System.Windows.Forms.RichTextBox()
        Me.pbcte = New System.Windows.Forms.PictureBox()
        Me.gbcliforcte = New System.Windows.Forms.GroupBox()
        Me.lbcnpjcte = New System.Windows.Forms.Label()
        Me.txtcnpjcte = New System.Windows.Forms.TextBox()
        Me.txtrazaocte = New System.Windows.Forms.TextBox()
        Me.lbrazaocte = New System.Windows.Forms.Label()
        Me.gbxmlcte = New System.Windows.Forms.GroupBox()
        Me.lbdataemissaocte = New System.Windows.Forms.Label()
        Me.txtdataemissaocte = New System.Windows.Forms.TextBox()
        Me.lbidxmlcte = New System.Windows.Forms.Label()
        Me.txtxmlcte = New System.Windows.Forms.TextBox()
        CType(Me.dgDetalhaCTe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDetalhescte.SuspendLayout()
        Me.gbNf.SuspendLayout()
        Me.gbPrdcte.SuspendLayout()
        Me.gbcriticacte.SuspendLayout()
        CType(Me.pbcte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbcliforcte.SuspendLayout()
        Me.gbxmlcte.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgDetalhaCTe
        '
        Me.dgDetalhaCTe.AllowUserToAddRows = False
        Me.dgDetalhaCTe.AllowUserToDeleteRows = False
        Me.dgDetalhaCTe.AllowUserToResizeColumns = False
        Me.dgDetalhaCTe.AllowUserToResizeRows = False
        Me.dgDetalhaCTe.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgDetalhaCTe.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgDetalhaCTe.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DATAEMISSAO, Me.CNPJ, Me.RAZAO, Me.ITEM_XML, Me.COD_PRD, Me.COD_PRD_AUX, Me.SKU, Me.DESC_PRD, Me.CRITICA})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgDetalhaCTe.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgDetalhaCTe.Location = New System.Drawing.Point(13, 12)
        Me.dgDetalhaCTe.Name = "dgDetalhaCTe"
        Me.dgDetalhaCTe.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgDetalhaCTe.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgDetalhaCTe.Size = New System.Drawing.Size(973, 400)
        Me.dgDetalhaCTe.TabIndex = 0
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
        'COD_PRD
        '
        Me.COD_PRD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.COD_PRD.DataPropertyName = "COD_PRD"
        Me.COD_PRD.HeaderText = "PRD PROTHEUS"
        Me.COD_PRD.Name = "COD_PRD"
        Me.COD_PRD.ReadOnly = True
        Me.COD_PRD.Width = 118
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
        'SKU
        '
        Me.SKU.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SKU.DataPropertyName = "SKU"
        Me.SKU.HeaderText = "SKU"
        Me.SKU.Name = "SKU"
        Me.SKU.ReadOnly = True
        Me.SKU.Width = 54
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
        'gbDetalhescte
        '
        Me.gbDetalhescte.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.gbDetalhescte.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.gbDetalhescte.Controls.Add(Me.gbNf)
        Me.gbDetalhescte.Controls.Add(Me.gbPrdcte)
        Me.gbDetalhescte.Controls.Add(Me.gbcriticacte)
        Me.gbDetalhescte.Controls.Add(Me.pbcte)
        Me.gbDetalhescte.Controls.Add(Me.gbcliforcte)
        Me.gbDetalhescte.Controls.Add(Me.gbxmlcte)
        Me.gbDetalhescte.Location = New System.Drawing.Point(13, 418)
        Me.gbDetalhescte.Name = "gbDetalhescte"
        Me.gbDetalhescte.Size = New System.Drawing.Size(973, 303)
        Me.gbDetalhescte.TabIndex = 2
        Me.gbDetalhescte.TabStop = False
        Me.gbDetalhescte.Text = "Detalhes da Crítica"
        '
        'gbNf
        '
        Me.gbNf.Controls.Add(Me.lbSepara)
        Me.gbNf.Controls.Add(Me.lbSerie)
        Me.gbNf.Controls.Add(Me.txtSerie)
        Me.gbNf.Controls.Add(Me.lbNf)
        Me.gbNf.Controls.Add(Me.txtNf)
        Me.gbNf.Location = New System.Drawing.Point(63, 19)
        Me.gbNf.Name = "gbNf"
        Me.gbNf.Size = New System.Drawing.Size(170, 67)
        Me.gbNf.TabIndex = 56
        Me.gbNf.TabStop = False
        Me.gbNf.Text = "Nota Fiscal"
        '
        'lbSepara
        '
        Me.lbSepara.AutoSize = True
        Me.lbSepara.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSepara.Location = New System.Drawing.Point(103, 30)
        Me.lbSepara.Name = "lbSepara"
        Me.lbSepara.Size = New System.Drawing.Size(15, 24)
        Me.lbSepara.TabIndex = 12
        Me.lbSepara.Text = "/"
        '
        'lbSerie
        '
        Me.lbSerie.AutoSize = True
        Me.lbSerie.Location = New System.Drawing.Point(119, 16)
        Me.lbSerie.Name = "lbSerie"
        Me.lbSerie.Size = New System.Drawing.Size(31, 13)
        Me.lbSerie.TabIndex = 11
        Me.lbSerie.Text = "Serie"
        '
        'txtSerie
        '
        Me.txtSerie.Location = New System.Drawing.Point(122, 32)
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(42, 20)
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
        Me.txtNf.Size = New System.Drawing.Size(90, 20)
        Me.txtNf.TabIndex = 8
        '
        'gbPrdcte
        '
        Me.gbPrdcte.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.gbPrdcte.Controls.Add(Me.lbSku)
        Me.gbPrdcte.Controls.Add(Me.txtsku)
        Me.gbPrdcte.Controls.Add(Me.lbPrdProtheus)
        Me.gbPrdcte.Controls.Add(Me.txtprdprotheuscte)
        Me.gbPrdcte.Controls.Add(Me.lbPrdFornece)
        Me.gbPrdcte.Controls.Add(Me.txtprdforcte)
        Me.gbPrdcte.Controls.Add(Me.txtdescprdcte)
        Me.gbPrdcte.Controls.Add(Me.lbDescPrd)
        Me.gbPrdcte.Location = New System.Drawing.Point(63, 160)
        Me.gbPrdcte.Name = "gbPrdcte"
        Me.gbPrdcte.Size = New System.Drawing.Size(306, 132)
        Me.gbPrdcte.TabIndex = 50
        Me.gbPrdcte.TabStop = False
        Me.gbPrdcte.Text = "Produto"
        '
        'lbSku
        '
        Me.lbSku.AutoSize = True
        Me.lbSku.Location = New System.Drawing.Point(200, 23)
        Me.lbSku.Name = "lbSku"
        Me.lbSku.Size = New System.Drawing.Size(29, 13)
        Me.lbSku.TabIndex = 16
        Me.lbSku.Text = "SKU"
        '
        'txtsku
        '
        Me.txtsku.Location = New System.Drawing.Point(203, 39)
        Me.txtsku.Name = "txtsku"
        Me.txtsku.Size = New System.Drawing.Size(89, 20)
        Me.txtsku.TabIndex = 17
        '
        'lbPrdProtheus
        '
        Me.lbPrdProtheus.AutoSize = True
        Me.lbPrdProtheus.Location = New System.Drawing.Point(13, 23)
        Me.lbPrdProtheus.Name = "lbPrdProtheus"
        Me.lbPrdProtheus.Size = New System.Drawing.Size(68, 13)
        Me.lbPrdProtheus.TabIndex = 11
        Me.lbPrdProtheus.Text = "Prd Protheus"
        '
        'txtprdprotheuscte
        '
        Me.txtprdprotheuscte.Location = New System.Drawing.Point(13, 39)
        Me.txtprdprotheuscte.Name = "txtprdprotheuscte"
        Me.txtprdprotheuscte.Size = New System.Drawing.Size(89, 20)
        Me.txtprdprotheuscte.TabIndex = 10
        '
        'lbPrdFornece
        '
        Me.lbPrdFornece.AutoSize = True
        Me.lbPrdFornece.Location = New System.Drawing.Point(105, 23)
        Me.lbPrdFornece.Name = "lbPrdFornece"
        Me.lbPrdFornece.Size = New System.Drawing.Size(80, 13)
        Me.lbPrdFornece.TabIndex = 12
        Me.lbPrdFornece.Text = "Prd Fornecedor"
        '
        'txtprdforcte
        '
        Me.txtprdforcte.Location = New System.Drawing.Point(108, 39)
        Me.txtprdforcte.Name = "txtprdforcte"
        Me.txtprdforcte.Size = New System.Drawing.Size(89, 20)
        Me.txtprdforcte.TabIndex = 13
        '
        'txtdescprdcte
        '
        Me.txtdescprdcte.Location = New System.Drawing.Point(13, 91)
        Me.txtdescprdcte.Name = "txtdescprdcte"
        Me.txtdescprdcte.Size = New System.Drawing.Size(279, 20)
        Me.txtdescprdcte.TabIndex = 14
        '
        'lbDescPrd
        '
        Me.lbDescPrd.AutoSize = True
        Me.lbDescPrd.Location = New System.Drawing.Point(13, 75)
        Me.lbDescPrd.Name = "lbDescPrd"
        Me.lbDescPrd.Size = New System.Drawing.Size(72, 13)
        Me.lbDescPrd.TabIndex = 15
        Me.lbDescPrd.Text = "Desc Produto"
        '
        'gbcriticacte
        '
        Me.gbcriticacte.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.gbcriticacte.Controls.Add(Me.txtcriticacte)
        Me.gbcriticacte.Location = New System.Drawing.Point(375, 160)
        Me.gbcriticacte.Name = "gbcriticacte"
        Me.gbcriticacte.Size = New System.Drawing.Size(496, 132)
        Me.gbcriticacte.TabIndex = 54
        Me.gbcriticacte.TabStop = False
        Me.gbcriticacte.Text = "Crítica"
        '
        'txtcriticacte
        '
        Me.txtcriticacte.Location = New System.Drawing.Point(6, 19)
        Me.txtcriticacte.Name = "txtcriticacte"
        Me.txtcriticacte.Size = New System.Drawing.Size(484, 107)
        Me.txtcriticacte.TabIndex = 53
        Me.txtcriticacte.Text = ""
        '
        'pbcte
        '
        Me.pbcte.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.pbcte.Image = CType(resources.GetObject("pbcte.Image"), System.Drawing.Image)
        Me.pbcte.Location = New System.Drawing.Point(734, 28)
        Me.pbcte.Name = "pbcte"
        Me.pbcte.Size = New System.Drawing.Size(137, 123)
        Me.pbcte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbcte.TabIndex = 51
        Me.pbcte.TabStop = False
        '
        'gbcliforcte
        '
        Me.gbcliforcte.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.gbcliforcte.Controls.Add(Me.lbcnpjcte)
        Me.gbcliforcte.Controls.Add(Me.txtcnpjcte)
        Me.gbcliforcte.Controls.Add(Me.txtrazaocte)
        Me.gbcliforcte.Controls.Add(Me.lbrazaocte)
        Me.gbcliforcte.Location = New System.Drawing.Point(63, 87)
        Me.gbcliforcte.Name = "gbcliforcte"
        Me.gbcliforcte.Size = New System.Drawing.Size(665, 67)
        Me.gbcliforcte.TabIndex = 48
        Me.gbcliforcte.TabStop = False
        Me.gbcliforcte.Text = "Cliente / Fornecedor"
        '
        'lbcnpjcte
        '
        Me.lbcnpjcte.AutoSize = True
        Me.lbcnpjcte.Location = New System.Drawing.Point(6, 16)
        Me.lbcnpjcte.Name = "lbcnpjcte"
        Me.lbcnpjcte.Size = New System.Drawing.Size(34, 13)
        Me.lbcnpjcte.TabIndex = 7
        Me.lbcnpjcte.Text = "CNPJ"
        '
        'txtcnpjcte
        '
        Me.txtcnpjcte.Location = New System.Drawing.Point(9, 32)
        Me.txtcnpjcte.Name = "txtcnpjcte"
        Me.txtcnpjcte.Size = New System.Drawing.Size(129, 20)
        Me.txtcnpjcte.TabIndex = 6
        '
        'txtrazaocte
        '
        Me.txtrazaocte.Location = New System.Drawing.Point(144, 32)
        Me.txtrazaocte.Name = "txtrazaocte"
        Me.txtrazaocte.Size = New System.Drawing.Size(515, 20)
        Me.txtrazaocte.TabIndex = 8
        '
        'lbrazaocte
        '
        Me.lbrazaocte.AutoSize = True
        Me.lbrazaocte.Location = New System.Drawing.Point(141, 16)
        Me.lbrazaocte.Name = "lbrazaocte"
        Me.lbrazaocte.Size = New System.Drawing.Size(70, 13)
        Me.lbrazaocte.TabIndex = 9
        Me.lbrazaocte.Text = "Razão Social"
        '
        'gbxmlcte
        '
        Me.gbxmlcte.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.gbxmlcte.Controls.Add(Me.lbdataemissaocte)
        Me.gbxmlcte.Controls.Add(Me.txtdataemissaocte)
        Me.gbxmlcte.Controls.Add(Me.lbidxmlcte)
        Me.gbxmlcte.Controls.Add(Me.txtxmlcte)
        Me.gbxmlcte.Location = New System.Drawing.Point(241, 19)
        Me.gbxmlcte.Name = "gbxmlcte"
        Me.gbxmlcte.Size = New System.Drawing.Size(487, 67)
        Me.gbxmlcte.TabIndex = 47
        Me.gbxmlcte.TabStop = False
        Me.gbxmlcte.Text = "XML"
        '
        'lbdataemissaocte
        '
        Me.lbdataemissaocte.AutoSize = True
        Me.lbdataemissaocte.Location = New System.Drawing.Point(386, 16)
        Me.lbdataemissaocte.Name = "lbdataemissaocte"
        Me.lbdataemissaocte.Size = New System.Drawing.Size(72, 13)
        Me.lbdataemissaocte.TabIndex = 5
        Me.lbdataemissaocte.Text = "Data Emissão"
        '
        'txtdataemissaocte
        '
        Me.txtdataemissaocte.Location = New System.Drawing.Point(389, 32)
        Me.txtdataemissaocte.Name = "txtdataemissaocte"
        Me.txtdataemissaocte.Size = New System.Drawing.Size(92, 20)
        Me.txtdataemissaocte.TabIndex = 4
        '
        'lbidxmlcte
        '
        Me.lbidxmlcte.AutoSize = True
        Me.lbidxmlcte.Location = New System.Drawing.Point(6, 16)
        Me.lbidxmlcte.Name = "lbidxmlcte"
        Me.lbidxmlcte.Size = New System.Drawing.Size(43, 13)
        Me.lbidxmlcte.TabIndex = 1
        Me.lbidxmlcte.Text = "ID XML"
        '
        'txtxmlcte
        '
        Me.txtxmlcte.Location = New System.Drawing.Point(9, 32)
        Me.txtxmlcte.Name = "txtxmlcte"
        Me.txtxmlcte.Size = New System.Drawing.Size(374, 20)
        Me.txtxmlcte.TabIndex = 0
        '
        'frmDetalhaCTe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(998, 733)
        Me.Controls.Add(Me.gbDetalhescte)
        Me.Controls.Add(Me.dgDetalhaCTe)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDetalhaCTe"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalhes CT-e"
        CType(Me.dgDetalhaCTe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDetalhescte.ResumeLayout(False)
        Me.gbNf.ResumeLayout(False)
        Me.gbNf.PerformLayout()
        Me.gbPrdcte.ResumeLayout(False)
        Me.gbPrdcte.PerformLayout()
        Me.gbcriticacte.ResumeLayout(False)
        CType(Me.pbcte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbcliforcte.ResumeLayout(False)
        Me.gbcliforcte.PerformLayout()
        Me.gbxmlcte.ResumeLayout(False)
        Me.gbxmlcte.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgDetalhaCTe As System.Windows.Forms.DataGridView
    Friend WithEvents gbDetalhescte As System.Windows.Forms.GroupBox
    Friend WithEvents gbcriticacte As System.Windows.Forms.GroupBox
    Friend WithEvents txtcriticacte As System.Windows.Forms.RichTextBox
    Friend WithEvents pbcte As System.Windows.Forms.PictureBox
    Friend WithEvents gbcliforcte As System.Windows.Forms.GroupBox
    Friend WithEvents lbcnpjcte As System.Windows.Forms.Label
    Friend WithEvents txtcnpjcte As System.Windows.Forms.TextBox
    Friend WithEvents txtrazaocte As System.Windows.Forms.TextBox
    Friend WithEvents lbrazaocte As System.Windows.Forms.Label
    Friend WithEvents gbxmlcte As System.Windows.Forms.GroupBox
    Friend WithEvents lbdataemissaocte As System.Windows.Forms.Label
    Friend WithEvents txtdataemissaocte As System.Windows.Forms.TextBox
    Friend WithEvents lbidxmlcte As System.Windows.Forms.Label
    Friend WithEvents txtxmlcte As System.Windows.Forms.TextBox
    Friend WithEvents gbPrdcte As System.Windows.Forms.GroupBox
    Friend WithEvents lbPrdProtheus As System.Windows.Forms.Label
    Friend WithEvents txtprdprotheuscte As System.Windows.Forms.TextBox
    Friend WithEvents lbPrdFornece As System.Windows.Forms.Label
    Friend WithEvents txtprdforcte As System.Windows.Forms.TextBox
    Friend WithEvents txtdescprdcte As System.Windows.Forms.TextBox
    Friend WithEvents lbDescPrd As System.Windows.Forms.Label
    Friend WithEvents gbNf As System.Windows.Forms.GroupBox
    Friend WithEvents lbSepara As System.Windows.Forms.Label
    Friend WithEvents lbSerie As System.Windows.Forms.Label
    Friend WithEvents txtSerie As System.Windows.Forms.TextBox
    Friend WithEvents lbNf As System.Windows.Forms.Label
    Friend WithEvents txtNf As System.Windows.Forms.TextBox
    Friend WithEvents lbSku As System.Windows.Forms.Label
    Friend WithEvents txtsku As System.Windows.Forms.TextBox
    Friend WithEvents DATAEMISSAO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CNPJ As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RAZAO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ITEM_XML As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COD_PRD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COD_PRD_AUX As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SKU As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DESC_PRD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CRITICA As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
