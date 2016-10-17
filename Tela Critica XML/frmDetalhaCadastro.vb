Imports System.Data.SqlClient
Public Class frmDetalhaCadastro
    Private ds As DataSet
    Private da As SqlDataAdapter
    Private Sub frmDetalhaCadastro_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txtxmlcad.Text = String.Empty
        txtitemcad.Text = String.Empty
        txtdataemissaocad.Text = String.Empty
        txtcnpjcad.Text = String.Empty
        txtrazaocad.Text = String.Empty
        txtprdrmcad.Text = String.Empty
        txtprdforcad.Text = String.Empty
        txtdescprdcad.Text = String.Empty
        txtcriticacad.Text = String.Empty
        txtund.Text = String.Empty
        ' Cria um novo SqlDataAdapter que servirá para actualizar o DataSet 
        Dim SQLCad As String = "SELECT ITEM_XML, DATAEMISSAO, CNPJ, RAZAO, COD_PRD, COD_PRD_AUX, DESC_PRD, CRITICA, UND_MED " +
            "FROM CRITICAXML WHERE SETOR = 'CMP' AND NOME_XML = '" & sArm_xml & "'"
        da = New SqlDataAdapter(SQLCad, GetConnectionXML())
        ' Cria um DataSet, ou seja, uma representação em memória da informação
        ds = New DataSet
        ' Coloca a informação da tabela definida no DataSet 
        da.Fill(ds, "CRITICAXML")
        ' Define que a fonte de dados da DataGridView é a nossa DataSet
        ' criando automáticamente as colunas e linhas de dados
        Me.dgDetalhaCadastro.DataSource = ds.Tables("CRITICAXML")
        ' Limpa a ligação à base de dados. Não é necessário fechar a ligação
        ' porque esta não foi aberta através do comando .Open()
        GetConnectionXML().Dispose()
        'Dim i As Integer
        'i = dgDetalhaCadastro.CurrentRow.Index
        'exibeRegistro(i)
    End Sub
    Private Sub dgDetalhaCadastro_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgDetalhaCadastro.CellClick
        Dim i As Integer
        For i = 0 To dgDetalhaCadastro.Rows.Count - 1
            i = dgDetalhaCadastro.CurrentRow.Index
            exibeRegistro(i)
            Exit For
        Next
    End Sub
    Private Sub dgDetalhaCadastro_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgDetalhaCadastro.KeyUp
        Dim i As Integer
        For i = 0 To dgDetalhaCadastro.Rows.Count - 1
            i = dgDetalhaCadastro.CurrentRow.Index
            exibeRegistro(i)
            Exit For
        Next
    End Sub
    Private Sub dgDetalhaCadastro_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgDetalhaCadastro.KeyDown
        Dim i As Integer
        For i = 0 To dgDetalhaCadastro.Rows.Count - 1
            i = dgDetalhaCadastro.CurrentRow.Index
            exibeRegistro(i)
            Exit For
        Next
    End Sub
    Private Sub exibeRegistro(ByVal i As Integer)

        If Not sArm_xml = "" Then
            txtxmlcad.Text = sArm_xml
        Else
            txtxmlcad.Text = String.Empty
        End If
        If Not IsDBNull(Me.dgDetalhaCadastro.Item(1, i).Value) Then
            txtitemcad.Text = CStr(Me.dgDetalhaCadastro.Item(1, i).Value)
        Else
            txtitemcad.Text = String.Empty
        End If
        If Not IsDBNull(Me.dgDetalhaCadastro.Item(2, i).Value) Then
            txtdataemissaocad.Text = CStr(Me.dgDetalhaCadastro.Item(2, i).Value)
        Else
            txtdataemissaocad.Text = String.Empty
        End If
        If Not IsDBNull(Me.dgDetalhaCadastro.Item(3, i).Value) Then
            txtcnpjcad.Text = CStr(Me.dgDetalhaCadastro.Item(3, i).Value)
        Else
            txtcnpjcad.Text = String.Empty
        End If
        If Not IsDBNull(Me.dgDetalhaCadastro.Item(4, i).Value) Then
            txtrazaocad.Text = CStr(Me.dgDetalhaCadastro.Item(4, i).Value)
        Else
            txtrazaocad.Text = String.Empty
        End If
        If Not IsDBNull(Me.dgDetalhaCadastro.Item(5, i).Value) Then
            txtprdrmcad.Text = CStr(Me.dgDetalhaCadastro.Item(5, i).Value)
        Else
            txtprdrmcad.Text = String.Empty
        End If
        If Not IsDBNull(Me.dgDetalhaCadastro.Item(6, i).Value) Then
            txtprdforcad.Text = CStr(Me.dgDetalhaCadastro.Item(6, i).Value)
        Else
            txtprdforcad.Text = String.Empty
        End If
        If Not IsDBNull(Me.dgDetalhaCadastro.Item(7, i).Value) Then
            txtdescprdcad.Text = CStr(Me.dgDetalhaCadastro.Item(7, i).Value)
        Else
            txtdescprdcad.Text = String.Empty
        End If
        If Not IsDBNull(Me.dgDetalhaCadastro.Item(8, i).Value) Then
            txtcriticacad.Text = CStr(Me.dgDetalhaCadastro.Item(8, i).Value)
        Else
            txtcriticacad.Text = String.Empty
        End If
        If Not IsDBNull(Me.dgDetalhaCadastro.Item(9, i).Value) Then
            txtund.Text = CStr(Me.dgDetalhaCadastro.Item(9, i).Value)
        Else
            txtund.Text = String.Empty
        End If
        
    End Sub

End Class