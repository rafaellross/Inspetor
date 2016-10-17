<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLog))
        Me.dgLog = New System.Windows.Forms.DataGridView()
        Me.NOME_XML = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DATAEMISSAO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.USUARIO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CRITICA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbDetalhescad = New System.Windows.Forms.GroupBox()
        Me.gbItem = New System.Windows.Forms.GroupBox()
        Me.lbredbc = New System.Windows.Forms.Label()
        Me.txtredbc = New System.Windows.Forms.TextBox()
        Me.lbaliqicmsst = New System.Windows.Forms.Label()
        Me.txtaliqicmsst = New System.Windows.Forms.TextBox()
        Me.lbaliqicms = New System.Windows.Forms.Label()
        Me.txtaliqicms = New System.Windows.Forms.TextBox()
        Me.lbcst = New System.Windows.Forms.Label()
        Me.txtcst = New System.Windows.Forms.TextBox()
        Me.lbCodPrd = New System.Windows.Forms.Label()
        Me.txtprd = New System.Windows.Forms.TextBox()
        Me.gbcriticalog = New System.Windows.Forms.GroupBox()
        Me.txtcriticalog = New System.Windows.Forms.RichTextBox()
        Me.pblog = New System.Windows.Forms.PictureBox()
        Me.gbcliforlog = New System.Windows.Forms.GroupBox()
        Me.lbuserlog = New System.Windows.Forms.Label()
        Me.txtuserlog = New System.Windows.Forms.TextBox()
        Me.gbxmllog = New System.Windows.Forms.GroupBox()
        Me.lbdataemissaolog = New System.Windows.Forms.Label()
        Me.txtdataemissaolog = New System.Windows.Forms.TextBox()
        Me.lbidxmllog = New System.Windows.Forms.Label()
        Me.txtxmllog = New System.Windows.Forms.TextBox()
        CType(Me.dgLog, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDetalhescad.SuspendLayout()
        Me.gbItem.SuspendLayout()
        Me.gbcriticalog.SuspendLayout()
        CType(Me.pblog, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbcliforlog.SuspendLayout()
        Me.gbxmllog.SuspendLayout()
        Me.SuspendLayout()
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
        Me.dgLog.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NOME_XML, Me.DATAEMISSAO, Me.USUARIO, Me.CRITICA})
        Me.dgLog.Location = New System.Drawing.Point(13, 12)
        Me.dgLog.Name = "dgLog"
        Me.dgLog.ReadOnly = True
        Me.dgLog.Size = New System.Drawing.Size(973, 428)
        Me.dgLog.TabIndex = 0
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
        Me.DATAEMISSAO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DATAEMISSAO.DataPropertyName = "DATAEMISSAO"
        Me.DATAEMISSAO.HeaderText = "DATA EMISSAO"
        Me.DATAEMISSAO.Name = "DATAEMISSAO"
        Me.DATAEMISSAO.ReadOnly = True
        Me.DATAEMISSAO.Width = 112
        '
        'USUARIO
        '
        Me.USUARIO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.USUARIO.DataPropertyName = "USUARIO"
        Me.USUARIO.HeaderText = "USUARIO"
        Me.USUARIO.Name = "USUARIO"
        Me.USUARIO.ReadOnly = True
        Me.USUARIO.Width = 81
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
        Me.gbDetalhescad.Controls.Add(Me.gbItem)
        Me.gbDetalhescad.Controls.Add(Me.gbcriticalog)
        Me.gbDetalhescad.Controls.Add(Me.pblog)
        Me.gbDetalhescad.Controls.Add(Me.gbcliforlog)
        Me.gbDetalhescad.Controls.Add(Me.gbxmllog)
        Me.gbDetalhescad.Location = New System.Drawing.Point(13, 446)
        Me.gbDetalhescad.Name = "gbDetalhescad"
        Me.gbDetalhescad.Size = New System.Drawing.Size(973, 358)
        Me.gbDetalhescad.TabIndex = 2
        Me.gbDetalhescad.TabStop = False
        Me.gbDetalhescad.Text = "Detalhes da Crítica"
        '
        'gbItem
        '
        Me.gbItem.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.gbItem.Controls.Add(Me.lbredbc)
        Me.gbItem.Controls.Add(Me.txtredbc)
        Me.gbItem.Controls.Add(Me.lbaliqicmsst)
        Me.gbItem.Controls.Add(Me.txtaliqicmsst)
        Me.gbItem.Controls.Add(Me.lbaliqicms)
        Me.gbItem.Controls.Add(Me.txtaliqicms)
        Me.gbItem.Controls.Add(Me.lbcst)
        Me.gbItem.Controls.Add(Me.txtcst)
        Me.gbItem.Controls.Add(Me.lbCodPrd)
        Me.gbItem.Controls.Add(Me.txtprd)
        Me.gbItem.Location = New System.Drawing.Point(13, 88)
        Me.gbItem.Name = "gbItem"
        Me.gbItem.Size = New System.Drawing.Size(805, 61)
        Me.gbItem.TabIndex = 49
        Me.gbItem.TabStop = False
        Me.gbItem.Text = "Detalhes do Item"
        '
        'lbredbc
        '
        Me.lbredbc.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lbredbc.AutoSize = True
        Me.lbredbc.Location = New System.Drawing.Point(644, 16)
        Me.lbredbc.Name = "lbredbc"
        Me.lbredbc.Size = New System.Drawing.Size(83, 13)
        Me.lbredbc.TabIndex = 15
        Me.lbredbc.Text = "Redução da BC"
        '
        'txtredbc
        '
        Me.txtredbc.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txtredbc.Location = New System.Drawing.Point(647, 32)
        Me.txtredbc.Name = "txtredbc"
        Me.txtredbc.Size = New System.Drawing.Size(152, 20)
        Me.txtredbc.TabIndex = 14
        '
        'lbaliqicmsst
        '
        Me.lbaliqicmsst.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lbaliqicmsst.AutoSize = True
        Me.lbaliqicmsst.Location = New System.Drawing.Point(483, 16)
        Me.lbaliqicmsst.Name = "lbaliqicmsst"
        Me.lbaliqicmsst.Size = New System.Drawing.Size(103, 13)
        Me.lbaliqicmsst.TabIndex = 13
        Me.lbaliqicmsst.Text = "Aliquota do ICMSST"
        '
        'txtaliqicmsst
        '
        Me.txtaliqicmsst.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txtaliqicmsst.Location = New System.Drawing.Point(486, 32)
        Me.txtaliqicmsst.Name = "txtaliqicmsst"
        Me.txtaliqicmsst.Size = New System.Drawing.Size(152, 20)
        Me.txtaliqicmsst.TabIndex = 12
        '
        'lbaliqicms
        '
        Me.lbaliqicms.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lbaliqicms.AutoSize = True
        Me.lbaliqicms.Location = New System.Drawing.Point(324, 16)
        Me.lbaliqicms.Name = "lbaliqicms"
        Me.lbaliqicms.Size = New System.Drawing.Size(89, 13)
        Me.lbaliqicms.TabIndex = 11
        Me.lbaliqicms.Text = "Aliquota do ICMS"
        '
        'txtaliqicms
        '
        Me.txtaliqicms.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txtaliqicms.Location = New System.Drawing.Point(327, 32)
        Me.txtaliqicms.Name = "txtaliqicms"
        Me.txtaliqicms.Size = New System.Drawing.Size(152, 20)
        Me.txtaliqicms.TabIndex = 10
        '
        'lbcst
        '
        Me.lbcst.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lbcst.AutoSize = True
        Me.lbcst.Location = New System.Drawing.Point(165, 16)
        Me.lbcst.Name = "lbcst"
        Me.lbcst.Size = New System.Drawing.Size(28, 13)
        Me.lbcst.TabIndex = 9
        Me.lbcst.Text = "CST"
        '
        'txtcst
        '
        Me.txtcst.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txtcst.Location = New System.Drawing.Point(168, 32)
        Me.txtcst.Name = "txtcst"
        Me.txtcst.Size = New System.Drawing.Size(152, 20)
        Me.txtcst.TabIndex = 8
        '
        'lbCodPrd
        '
        Me.lbCodPrd.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lbCodPrd.AutoSize = True
        Me.lbCodPrd.Location = New System.Drawing.Point(6, 16)
        Me.lbCodPrd.Name = "lbCodPrd"
        Me.lbCodPrd.Size = New System.Drawing.Size(95, 13)
        Me.lbCodPrd.TabIndex = 7
        Me.lbCodPrd.Text = "Codigo do Produto"
        '
        'txtprd
        '
        Me.txtprd.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txtprd.Location = New System.Drawing.Point(9, 32)
        Me.txtprd.Name = "txtprd"
        Me.txtprd.Size = New System.Drawing.Size(152, 20)
        Me.txtprd.TabIndex = 6
        '
        'gbcriticalog
        '
        Me.gbcriticalog.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.gbcriticalog.Controls.Add(Me.txtcriticalog)
        Me.gbcriticalog.Location = New System.Drawing.Point(13, 161)
        Me.gbcriticalog.Name = "gbcriticalog"
        Me.gbcriticalog.Size = New System.Drawing.Size(947, 191)
        Me.gbcriticalog.TabIndex = 54
        Me.gbcriticalog.TabStop = False
        Me.gbcriticalog.Text = "Crítica"
        '
        'txtcriticalog
        '
        Me.txtcriticalog.Location = New System.Drawing.Point(6, 19)
        Me.txtcriticalog.Name = "txtcriticalog"
        Me.txtcriticalog.Size = New System.Drawing.Size(935, 166)
        Me.txtcriticalog.TabIndex = 53
        Me.txtcriticalog.Text = ""
        '
        'pblog
        '
        Me.pblog.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.pblog.Image = CType(resources.GetObject("pblog.Image"), System.Drawing.Image)
        Me.pblog.Location = New System.Drawing.Point(824, 22)
        Me.pblog.Name = "pblog"
        Me.pblog.Size = New System.Drawing.Size(136, 125)
        Me.pblog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pblog.TabIndex = 51
        Me.pblog.TabStop = False
        '
        'gbcliforlog
        '
        Me.gbcliforlog.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.gbcliforlog.Controls.Add(Me.lbuserlog)
        Me.gbcliforlog.Controls.Add(Me.txtuserlog)
        Me.gbcliforlog.Location = New System.Drawing.Point(582, 14)
        Me.gbcliforlog.Name = "gbcliforlog"
        Me.gbcliforlog.Size = New System.Drawing.Size(236, 61)
        Me.gbcliforlog.TabIndex = 48
        Me.gbcliforlog.TabStop = False
        Me.gbcliforlog.Text = "Log User"
        '
        'lbuserlog
        '
        Me.lbuserlog.AutoSize = True
        Me.lbuserlog.Location = New System.Drawing.Point(6, 16)
        Me.lbuserlog.Name = "lbuserlog"
        Me.lbuserlog.Size = New System.Drawing.Size(41, 13)
        Me.lbuserlog.TabIndex = 7
        Me.lbuserlog.Text = "Partner"
        '
        'txtuserlog
        '
        Me.txtuserlog.Location = New System.Drawing.Point(9, 32)
        Me.txtuserlog.Name = "txtuserlog"
        Me.txtuserlog.Size = New System.Drawing.Size(221, 20)
        Me.txtuserlog.TabIndex = 6
        '
        'gbxmllog
        '
        Me.gbxmllog.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.gbxmllog.Controls.Add(Me.lbdataemissaolog)
        Me.gbxmllog.Controls.Add(Me.txtdataemissaolog)
        Me.gbxmllog.Controls.Add(Me.lbidxmllog)
        Me.gbxmllog.Controls.Add(Me.txtxmllog)
        Me.gbxmllog.Location = New System.Drawing.Point(13, 14)
        Me.gbxmllog.Name = "gbxmllog"
        Me.gbxmllog.Size = New System.Drawing.Size(563, 61)
        Me.gbxmllog.TabIndex = 47
        Me.gbxmllog.TabStop = False
        Me.gbxmllog.Text = "XML"
        '
        'lbdataemissaolog
        '
        Me.lbdataemissaolog.AutoSize = True
        Me.lbdataemissaolog.Location = New System.Drawing.Point(463, 16)
        Me.lbdataemissaolog.Name = "lbdataemissaolog"
        Me.lbdataemissaolog.Size = New System.Drawing.Size(72, 13)
        Me.lbdataemissaolog.TabIndex = 5
        Me.lbdataemissaolog.Text = "Data Emissão"
        '
        'txtdataemissaolog
        '
        Me.txtdataemissaolog.Location = New System.Drawing.Point(466, 32)
        Me.txtdataemissaolog.Name = "txtdataemissaolog"
        Me.txtdataemissaolog.Size = New System.Drawing.Size(94, 20)
        Me.txtdataemissaolog.TabIndex = 4
        '
        'lbidxmllog
        '
        Me.lbidxmllog.AutoSize = True
        Me.lbidxmllog.Location = New System.Drawing.Point(6, 16)
        Me.lbidxmllog.Name = "lbidxmllog"
        Me.lbidxmllog.Size = New System.Drawing.Size(43, 13)
        Me.lbidxmllog.TabIndex = 1
        Me.lbidxmllog.Text = "ID XML"
        '
        'txtxmllog
        '
        Me.txtxmllog.Location = New System.Drawing.Point(9, 32)
        Me.txtxmllog.Name = "txtxmllog"
        Me.txtxmllog.Size = New System.Drawing.Size(451, 20)
        Me.txtxmllog.TabIndex = 0
        '
        'frmLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(998, 816)
        Me.Controls.Add(Me.gbDetalhescad)
        Me.Controls.Add(Me.dgLog)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalhes Cadastros"
        CType(Me.dgLog, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDetalhescad.ResumeLayout(False)
        Me.gbItem.ResumeLayout(False)
        Me.gbItem.PerformLayout()
        Me.gbcriticalog.ResumeLayout(False)
        CType(Me.pblog, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbcliforlog.ResumeLayout(False)
        Me.gbcliforlog.PerformLayout()
        Me.gbxmllog.ResumeLayout(False)
        Me.gbxmllog.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgLog As System.Windows.Forms.DataGridView
    Friend WithEvents gbDetalhescad As System.Windows.Forms.GroupBox
    Friend WithEvents gbcriticalog As System.Windows.Forms.GroupBox
    Friend WithEvents txtcriticalog As System.Windows.Forms.RichTextBox
    Friend WithEvents pblog As System.Windows.Forms.PictureBox
    Friend WithEvents gbcliforlog As System.Windows.Forms.GroupBox
    Friend WithEvents lbuserlog As System.Windows.Forms.Label
    Friend WithEvents txtuserlog As System.Windows.Forms.TextBox
    Friend WithEvents gbxmllog As System.Windows.Forms.GroupBox
    Friend WithEvents lbdataemissaolog As System.Windows.Forms.Label
    Friend WithEvents txtdataemissaolog As System.Windows.Forms.TextBox
    Friend WithEvents lbidxmllog As System.Windows.Forms.Label
    Friend WithEvents txtxmllog As System.Windows.Forms.TextBox
    Friend WithEvents NOME_XML As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DATAEMISSAO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents USUARIO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CRITICA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gbItem As System.Windows.Forms.GroupBox
    Friend WithEvents lbCodPrd As System.Windows.Forms.Label
    Friend WithEvents txtprd As System.Windows.Forms.TextBox
    Friend WithEvents lbredbc As System.Windows.Forms.Label
    Friend WithEvents txtredbc As System.Windows.Forms.TextBox
    Friend WithEvents lbaliqicmsst As System.Windows.Forms.Label
    Friend WithEvents txtaliqicmsst As System.Windows.Forms.TextBox
    Friend WithEvents lbaliqicms As System.Windows.Forms.Label
    Friend WithEvents txtaliqicms As System.Windows.Forms.TextBox
    Friend WithEvents lbcst As System.Windows.Forms.Label
    Friend WithEvents txtcst As System.Windows.Forms.TextBox
End Class
