Imports System.Data.SqlClient
Public Class frmDetalhaCTe
    Private ds As DataSet
    Private da As SqlDataAdapter
    Dim SQLCTe As String
    Dim sNf As String = ""
    Dim sSerieCTe As String = ""
    Dim sSku As String = ""
    Private Sub frmDetalhaPo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txtxmlcte.Text = String.Empty
        txtdataemissaocte.Text = String.Empty
        txtcnpjcte.Text = String.Empty
        txtrazaocte.Text = String.Empty
        txtprdprotheuscte.Text = String.Empty
        txtprdforcte.Text = String.Empty
        txtdescprdcte.Text = String.Empty
        txtcriticacte.Text = String.Empty
        txtNf.Text = String.Empty
        txtSerie.Text = String.Empty
        ' Cria um novo SqlDataAdapter que servirá para actualizar o DataSet 
        SQLCTe = "SELECT DATAEMISSAO, CNPJ, RAZAO, COD_PRD, COD_PRD_AUX, DESC_PRD, CRITICA, ITEM_XML, NUMEROMOV, SERIE, SKU " +
            "FROM CRITICAXML WHERE SETOR = 'CTE' AND NOME_XML = '" & sArm_xml & "' AND FLAG_STATUS NOT IN ('A','I')"
        da = New SqlDataAdapter(SQLCTe, GetConnectionXML())
        ' Cria um DataSet, ou seja, uma representação em memória da informação
        ds = New DataSet
        ' Coloca a informação da tabela definida no DataSet 
        da.Fill(ds, "CRITICAXML")
        ' Define que a fonte de dados da DataGridView é a nossa DataSet
        ' criando automáticamente as colunas e linhas de dados
        Me.dgDetalhaCTe.DataSource = ds.Tables("CRITICAXML")
        ' Limpa a ligação à base de dados. Não é necessário fechar a ligação
        ' porque esta não foi aberta através do comando .Open()
        GetConnectionXML().Dispose()
        If Not sArm_xml = "" Then
            txtxmlcte.Text = sArm_xml
        Else
            txtxmlcte.Text = String.Empty
        End If
        If Not IsDBNull(Me.dgDetalhaCTe.Item(0, 0).Value) Then
            txtdataemissaocte.Text = CStr(Me.dgDetalhaCTe.Item(0, 0).Value)
        Else
            txtdataemissaocte.Text = String.Empty
        End If
        If Not IsDBNull(Me.dgDetalhaCTe.Item(1, 0).Value) Then
            txtcnpjcte.Text = CStr(Me.dgDetalhaCTe.Item(1, 0).Value)
        Else
            txtcnpjcte.Text = String.Empty
        End If
        If Not IsDBNull(Me.dgDetalhaCTe.Item(2, 0).Value) Then
            txtrazaocte.Text = CStr(Me.dgDetalhaCTe.Item(2, 0).Value)
        Else
            txtrazaocte.Text = String.Empty
        End If
        If Not IsDBNull(Me.dgDetalhaCTe.Item(3, 0).Value) Then
            txtprdprotheuscte.Text = CStr(Me.dgDetalhaCTe.Item(3, 0).Value)
        Else
            txtprdprotheuscte.Text = String.Empty
        End If
        If Not IsDBNull(Me.dgDetalhaCTe.Item(4, 0).Value) Then
            txtprdforcte.Text = CStr(Me.dgDetalhaCTe.Item(4, 0).Value)
        Else
            txtprdforcte.Text = String.Empty
        End If
        If Not IsDBNull(Me.dgDetalhaCTe.Item(10, 0).Value) Then
            txtsku.Text = CStr(Me.dgDetalhaCTe.Item(10, 0).Value)
        Else
            txtsku.Text = String.Empty
        End If
        If Not IsDBNull(Me.dgDetalhaCTe.Item(5, 0).Value) Then
            txtdescprdcte.Text = CStr(Me.dgDetalhaCTe.Item(5, 0).Value)
        Else
            txtdescprdcte.Text = String.Empty
        End If
        If Not IsDBNull(Me.dgDetalhaCTe.Item(6, 0).Value) Then
            txtcriticacte.Text = CStr(Me.dgDetalhaCTe.Item(6, 0).Value)
        Else
            txtcriticacte.Text = String.Empty
        End If
        If Not IsDBNull(Me.dgDetalhaCTe.Item(8, 0).Value) Then
            txtNf.Text = CStr(Me.dgDetalhaCTe.Item(8, 0).Value)
        Else
            txtNf.Text = String.Empty
        End If
        If Not IsDBNull(Me.dgDetalhaCTe.Item(9, 0).Value) Then
            txtSerie.Text = CStr(Me.dgDetalhaCTe.Item(9, 0).Value)
        Else
            txtSerie.Text = String.Empty
        End If
        sNf = txtNf.Text
        sSerieCTe = txtSerie.Text
        sSku = txtsku.Text
    End Sub
    Private Sub dgDetalhaCTe_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgDetalhaCTe.CellClick
        Dim i As Integer
        For i = 0 To dgDetalhaCTe.Rows.Count - 1
            i = dgDetalhaCTe.CurrentRow.Index
            exibeRegistro(i)
            Exit For
        Next
    End Sub
    Private Sub dgDetalhaCTe_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgDetalhaCTe.KeyUp
        Dim i As Integer
        For i = 0 To dgDetalhaCTe.Rows.Count - 1
            i = dgDetalhaCTe.CurrentRow.Index
            exibeRegistro(i)
            Exit For
        Next
    End Sub
    Private Sub dgDetalhaCTe_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgDetalhaCTe.KeyDown
        Dim i As Integer
        For i = 0 To dgDetalhaCTe.Rows.Count - 1
            i = dgDetalhaCTe.CurrentRow.Index
            exibeRegistro(i)
            Exit For
        Next
    End Sub
    Private Sub exibeRegistro(ByVal i As Integer)
        If Not sArm_xml = "" Then
            txtxmlcte.Text = sArm_xml
        Else
            txtxmlcte.Text = String.Empty
        End If
        If Not IsDBNull(Me.dgDetalhaCTe.Item(0, i).Value) Then
            txtdataemissaocte.Text = CStr(Me.dgDetalhaCTe.Item(0, i).Value)
        Else
            txtdataemissaocte.Text = String.Empty
        End If
        If Not IsDBNull(Me.dgDetalhaCTe.Item(1, i).Value) Then
            txtcnpjcte.Text = CStr(Me.dgDetalhaCTe.Item(1, i).Value)
        Else
            txtcnpjcte.Text = String.Empty
        End If
        If Not IsDBNull(Me.dgDetalhaCTe.Item(2, i).Value) Then
            txtrazaocte.Text = CStr(Me.dgDetalhaCTe.Item(2, i).Value)
        Else
            txtrazaocte.Text = String.Empty
        End If
        If Not IsDBNull(Me.dgDetalhaCTe.Item(3, i).Value) Then
            txtprdprotheuscte.Text = CStr(Me.dgDetalhaCTe.Item(3, i).Value)
        Else
            txtprdprotheuscte.Text = String.Empty
        End If
        If Not IsDBNull(Me.dgDetalhaCTe.Item(4, i).Value) Then
            txtprdforcte.Text = CStr(Me.dgDetalhaCTe.Item(4, i).Value)
        Else
            txtprdforcte.Text = String.Empty
        End If
        If Not IsDBNull(Me.dgDetalhaCTe.Item(10, i).Value) Then
            txtsku.Text = CStr(Me.dgDetalhaCTe.Item(10, i).Value)
        Else
            txtsku.Text = String.Empty
        End If
        If Not IsDBNull(Me.dgDetalhaCTe.Item(5, i).Value) Then
            txtdescprdcte.Text = CStr(Me.dgDetalhaCTe.Item(5, i).Value)
        Else
            txtdescprdcte.Text = String.Empty
        End If
        If Not IsDBNull(Me.dgDetalhaCTe.Item(6, i).Value) Then
            txtcriticacte.Text = CStr(Me.dgDetalhaCTe.Item(6, i).Value)
        Else
            txtcriticacte.Text = String.Empty
        End If
        If Not IsDBNull(Me.dgDetalhaCTe.Item(8, i).Value) Then
            txtNf.Text = CStr(Me.dgDetalhaCTe.Item(8, i).Value)
        Else
            txtNf.Text = String.Empty
        End If
        If Not IsDBNull(Me.dgDetalhaCTe.Item(9, i).Value) Then
            txtSerie.Text = CStr(Me.dgDetalhaCTe.Item(9, i).Value)
        Else
            txtSerie.Text = String.Empty
        End If
        sNf = txtNf.Text
        sSerieCTe = txtSerie.Text
        sSku = txtSku.Text
    End Sub

    Private Sub btnassociarcte_Click(sender As System.Object, e As System.EventArgs)
        Dim bVal As Boolean = True
        Using con As SqlConnection = GetConnectionXML()
            Try
                con.Open()
                Dim cmd As New SqlCommand
                cmd.Connection = con
                Dim dr As SqlDataReader
                cmd.CommandText = "SELECT PEDIDO FROM CRITICAXML WHERE NOME_XML = '" & sArm_xml & "'"
                dr = cmd.ExecuteReader()
                dr.Read()
                If dr.HasRows Then
                    If Not IsDBNull(dr.Item(0)) Then
                        If dr.Item(0) <> "" Then
                            bVal = False
                        End If
                    End If
                End If
                con.Dispose()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End Using

    End Sub

End Class