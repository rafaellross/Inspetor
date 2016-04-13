Imports System.Data.SqlClient
Public Class frmDetalhaFiscal
    Private ds As DataSet
    Private da As SqlDataAdapter

    Private Sub frmDetalhaFiscal_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txtxml.Text = String.Empty
        txtitem.Text = String.Empty
        txtdataemissao.Text = String.Empty
        txtcnpj.Text = String.Empty
        txtrazao.Text = String.Empty
        txtcritica.Text = String.Empty
        txtprdrm.Text = String.Empty
        txtprdfor.Text = String.Empty
        txtdescprd.Text = String.Empty
        txtvalprd.Text = String.Empty
        txtcst.Text = String.Empty
        txtaliqicms.Text = String.Empty
        txtaliqicmsst.Text = String.Empty
        txtredbc.Text = String.Empty
        txtvaloricmsxml.Text = String.Empty
        txtvaloricmscalc.Text = String.Empty
        txtvaloricmsstxml.Text = String.Empty
        txtvaloricmsstcalc.Text = String.Empty
        txtvalormvaxml.Text = String.Empty
        txtvalormvaprd.Text = String.Empty
        txtvlbcstxml.Text = String.Empty
        txtvalorbcstcalc.Text = String.Empty
        txtvlbcstxml.Text = String.Empty
        txtvalorbcredxml.Text = String.Empty
        ' Cria um novo SqlDataAdapter que servirá para actualizar o DataSet 
        Dim SQLFis As String = "SELECT ITEM_XML, DATAEMISSAO, CNPJ, RAZAO, CRITICA, COD_PRD, COD_PRD_AUX, DESC_PRD, VALOR_PRD, " +
            "CST, ALIQ_ICMS, ALIQ_ICMSST, RED_BC, VALOR_ICMS_XML, VALOR_ICMS_CALC, VALOR_ICMSST_XML, VALOR_ICMSST_CALC, VALOR_MVA_XML, " +
            "VALOR_MVA_PRD, VALOR_BCST_XML, VALOR_BCST_CALC, VALOR_BCRED_XML, VALOR_BCRED_CALC FROM CRITICAXML WHERE SETOR = 'FIS' " +
            "AND NOME_XML = '" & sArm_xml & "' AND TIPO = '" & sArm_Tipo & "'"
        da = New SqlDataAdapter(SQLFis, GetConnectionXML())
        ' Cria um DataSet, ou seja, uma representação em memória da informação
        ds = New DataSet
        ' Coloca a informação da tabela definida no DataSet 
        da.Fill(ds, "CRITICAXML")
        ' Define que a fonte de dados da DataGridView é a nossa DataSet
        ' criando automáticamente as colunas e linhas de dados
        Me.dgDetalhaFiscal.DataSource = ds.Tables("CRITICAXML")
        ' Limpa a ligação à base de dados. Não é necessário fechar a ligação
        ' porque esta não foi aberta através do comando .Open()
        GetConnectionXML().Dispose()
        'Dim i As Integer
        'i = dgDetalhaFiscal.CurrentRow.Index
        'exibeRegistro(i)
    End Sub
    Private Sub dgDetalhaFiscal_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgDetalhaFiscal.CellClick
        Dim i As Integer
        For i = 0 To dgDetalhaFiscal.Rows.Count - 1
            i = dgDetalhaFiscal.CurrentRow.Index
            exibeRegistro(i)
            Exit For
        Next
    End Sub
    Private Sub dgDetalhaFiscal_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgDetalhaFiscal.KeyUp
        Dim i As Integer
        For i = 0 To dgDetalhaFiscal.Rows.Count - 1
            i = dgDetalhaFiscal.CurrentRow.Index
            exibeRegistro(i)
            Exit For
        Next
    End Sub
    Private Sub dgDetalhaFiscal_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgDetalhaFiscal.KeyDown
        Dim i As Integer
        For i = 0 To dgDetalhaFiscal.Rows.Count - 1
            i = dgDetalhaFiscal.CurrentRow.Index
            exibeRegistro(i)
            Exit For
        Next
    End Sub
    Private Sub exibeRegistro(ByVal i As Integer)

        If Not sArm_xml = "" Then
            txtxml.Text = sArm_xml
        Else
            txtxml.Text = String.Empty
        End If
        If Not IsDBNull(Me.dgDetalhaFiscal.Item(0, i).Value) Then
            txtitem.Text = CStr(Me.dgDetalhaFiscal.Item(0, i).Value)
        Else
            txtitem.Text = String.Empty
        End If
        If Not IsDBNull(Me.dgDetalhaFiscal.Item(1, i).Value) Then
            txtdataemissao.Text = CStr(Me.dgDetalhaFiscal.Item(1, i).Value)
        Else
            txtdataemissao.Text = String.Empty
        End If
        If Not IsDBNull(Me.dgDetalhaFiscal.Item(2, i).Value) Then
            txtcnpj.Text = CStr(Me.dgDetalhaFiscal.Item(2, i).Value)
        Else
            txtcnpj.Text = String.Empty
        End If
        If Not IsDBNull(Me.dgDetalhaFiscal.Item(3, i).Value) Then
            txtrazao.Text = CStr(Me.dgDetalhaFiscal.Item(3, i).Value)
        Else
            txtrazao.Text = String.Empty
        End If
        If Not IsDBNull(Me.dgDetalhaFiscal.Item(4, i).Value) Then
            txtcritica.Text = CStr(Me.dgDetalhaFiscal.Item(4, i).Value)
        Else
            txtcritica.Text = String.Empty
        End If
        If Not IsDBNull(Me.dgDetalhaFiscal.Item(5, i).Value) Then
            txtprdrm.Text = CStr(Me.dgDetalhaFiscal.Item(5, i).Value)
        Else
            txtprdrm.Text = String.Empty
        End If
        If Not IsDBNull(Me.dgDetalhaFiscal.Item(6, i).Value) Then
            txtprdfor.Text = CStr(Me.dgDetalhaFiscal.Item(6, i).Value)
        Else
            txtprdfor.Text = String.Empty
        End If
        If Not IsDBNull(Me.dgDetalhaFiscal.Item(7, i).Value) Then
            txtdescprd.Text = CStr(Me.dgDetalhaFiscal.Item(7, i).Value)
        Else
            txtdescprd.Text = String.Empty
        End If
        If Not IsDBNull(Me.dgDetalhaFiscal.Item(8, i).Value) Then
            txtvalprd.Text = CStr(Me.dgDetalhaFiscal.Item(8, i).Value)
        Else
            txtvalprd.Text = String.Empty
        End If
        If Not IsDBNull(Me.dgDetalhaFiscal.Item(9, i).Value) Then
            txtcst.Text = CStr(Me.dgDetalhaFiscal.Item(9, i).Value)
        Else
            txtcst.Text = String.Empty
        End If
        If Not IsDBNull(Me.dgDetalhaFiscal.Item(10, i).Value) Then
            txtaliqicms.Text = CStr(Me.dgDetalhaFiscal.Item(10, i).Value)
        Else
            txtaliqicms.Text = String.Empty
        End If
        If Not IsDBNull(Me.dgDetalhaFiscal.Item(11, i).Value) Then
            txtaliqicmsst.Text = CStr(Me.dgDetalhaFiscal.Item(11, i).Value)
        Else
            txtaliqicmsst.Text = String.Empty
        End If
        If Not IsDBNull(Me.dgDetalhaFiscal.Item(12, i).Value) Then
            txtredbc.Text = CStr(Me.dgDetalhaFiscal.Item(12, i).Value)
        Else
            txtredbc.Text = String.Empty
        End If
        If Not IsDBNull(Me.dgDetalhaFiscal.Item(13, i).Value) Then
            txtvaloricmsxml.Text = CStr(Me.dgDetalhaFiscal.Item(13, i).Value)
        Else
            txtvaloricmsxml.Text = String.Empty
        End If
        If Not IsDBNull(Me.dgDetalhaFiscal.Item(14, i).Value) Then
            txtvaloricmscalc.Text = CStr(Me.dgDetalhaFiscal.Item(14, i).Value)
        Else
            txtvaloricmscalc.Text = String.Empty
        End If
        If Not IsDBNull(Me.dgDetalhaFiscal.Item(15, i).Value) Then
            txtvaloricmsstxml.Text = CStr(Me.dgDetalhaFiscal.Item(15, i).Value)
        Else
            txtvaloricmsstxml.Text = String.Empty
        End If
        If Not IsDBNull(Me.dgDetalhaFiscal.Item(16, i).Value) Then
            txtvaloricmsstcalc.Text = CStr(Me.dgDetalhaFiscal.Item(16, i).Value)
        Else
            txtvaloricmsstcalc.Text = String.Empty
        End If
        If Not IsDBNull(Me.dgDetalhaFiscal.Item(17, i).Value) Then
            txtvalormvaxml.Text = CStr(Me.dgDetalhaFiscal.Item(17, i).Value)
        Else
            txtvalormvaxml.Text = String.Empty
        End If
        If Not IsDBNull(Me.dgDetalhaFiscal.Item(18, i).Value) Then
            txtvalormvaprd.Text = CStr(Me.dgDetalhaFiscal.Item(18, i).Value)
        Else
            txtvalormvaprd.Text = String.Empty
        End If
        If Not IsDBNull(Me.dgDetalhaFiscal.Item(19, i).Value) Then
            txtvlbcstxml.Text = CStr(Me.dgDetalhaFiscal.Item(19, i).Value)
        Else
            txtvlbcstxml.Text = String.Empty
        End If
        If Not IsDBNull(Me.dgDetalhaFiscal.Item(20, i).Value) Then
            txtvalorbcstcalc.Text = CStr(Me.dgDetalhaFiscal.Item(20, i).Value)
        Else
            txtvalorbcstcalc.Text = String.Empty
        End If
        If Not IsDBNull(Me.dgDetalhaFiscal.Item(21, i).Value) Then
            txtvalorbcredxml.Text = CStr(Me.dgDetalhaFiscal.Item(21, i).Value)
        Else
            txtvalorbcredxml.Text = String.Empty
        End If
        If Not IsDBNull(Me.dgDetalhaFiscal.Item(22, i).Value) Then
            txtvalorbcredcalc.Text = CStr(Me.dgDetalhaFiscal.Item(22, i).Value)
        Else
            txtvalorbcredcalc.Text = String.Empty
        End If

    End Sub
End Class