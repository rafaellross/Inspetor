Imports System.Data.SqlClient
Public Class frmLog
    Private ds As DataSet
    Private da As SqlDataAdapter
    Private Sub frmLog_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txtxmllog.Text = String.Empty
        txtdataemissaolog.Text = String.Empty
        txtuserlog.Text = String.Empty
        txtcriticalog.Text = String.Empty
        txtprd.Text = String.Empty
        txtcst.Text = String.Empty
        txtaliqicms.Text = String.Empty
        txtaliqicmsst.Text = String.Empty
        txtredbc.Text = String.Empty
        ' Cria um novo SqlDataAdapter que servirá para actualizar o DataSet 
        Dim SQLLog As String = "SELECT NOME_XML, DATAEMISSAO, USUARIO, CRITICA, COD_PRD, CST, ALIQ_ICMS, ALIQ_ICMSST, RED_BC FROM LOGEVENTOSXML WHERE NOME_XML = '" & sArm_xml & "'"
        da = New SqlDataAdapter(SQLLog, GetConnectionXML())
        ' Cria um DataSet, ou seja, uma representação em memória da informação
        ds = New DataSet
        ' Coloca a informação da tabela definida no DataSet 
        da.Fill(ds, "LOGEVENTOSXML")
        ' Define que a fonte de dados da DataGridView é a nossa DataSet
        ' criando automáticamente as colunas e linhas de dados
        Me.dgLog.DataSource = ds.Tables("LOGEVENTOSXML")
        ' Limpa a ligação à base de dados. Não é necessário fechar a ligação
        ' porque esta não foi aberta através do comando .Open()
        GetConnectionXML().Dispose()
        'Dim i As Integer
        'i = dgDetalhaCadastro.CurrentRow.Index
        'exibeRegistro(i)
    End Sub
    Private Sub dgLog_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgLog.CellClick
        Dim i As Integer
        For i = 0 To dgLog.Rows.Count - 1
            i = dgLog.CurrentRow.Index
            exibeRegistro(i)
            Exit For
        Next
    End Sub
    Private Sub dgLog_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgLog.KeyUp
        Dim i As Integer
        For i = 0 To dgLog.Rows.Count - 1
            i = dgLog.CurrentRow.Index
            exibeRegistro(i)
            Exit For
        Next
    End Sub
    Private Sub dgLog_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgLog.KeyDown
        Dim i As Integer
        For i = 0 To dgLog.Rows.Count - 1
            i = dgLog.CurrentRow.Index
            exibeRegistro(i)
            Exit For
        Next
    End Sub
    Private Sub exibeRegistro(ByVal i As Integer)
        If Not IsDBNull(Me.dgLog.Item(0, i).Value) Then
            txtxmllog.Text = CStr(Me.dgLog.Item(0, i).Value)
        Else
            txtxmllog.Text = String.Empty
        End If
        If Not IsDBNull(Me.dgLog.Item(1, i).Value) Then
            txtdataemissaolog.Text = CStr(Me.dgLog.Item(1, i).Value)
        Else
            txtdataemissaolog.Text = String.Empty
        End If
        If Not IsDBNull(Me.dgLog.Item(2, i).Value) Then
            txtuserlog.Text = CStr(Me.dgLog.Item(2, i).Value)
        Else
            txtuserlog.Text = String.Empty
        End If
        If Not IsDBNull(Me.dgLog.Item(3, i).Value) Then
            txtcriticalog.Text = CStr(Me.dgLog.Item(3, i).Value)
        Else
            txtcriticalog.Text = String.Empty
        End If
        If Not IsDBNull(Me.dgLog.Item(4, i).Value) Then
            txtprd.Text = CStr(Me.dgLog.Item(4, i).Value)
        Else
            txtprd.Text = String.Empty
        End If
        If Not IsDBNull(Me.dgLog.Item(5, i).Value) Then
            txtcst.Text = CStr(Me.dgLog.Item(5, i).Value)
        Else
            txtcst.Text = String.Empty
        End If
        If Not IsDBNull(Me.dgLog.Item(6, i).Value) Then
            txtaliqicms.Text = CStr(Me.dgLog.Item(6, i).Value)
        Else
            txtaliqicms.Text = String.Empty
        End If
        If Not IsDBNull(Me.dgLog.Item(7, i).Value) Then
            txtaliqicmsst.Text = CStr(Me.dgLog.Item(7, i).Value)
        Else
            txtaliqicmsst.Text = String.Empty
        End If
        If Not IsDBNull(Me.dgLog.Item(8, i).Value) Then
            txtredbc.Text = CStr(Me.dgLog.Item(8, i).Value)
        Else
            txtredbc.Text = String.Empty
        End If
    End Sub
End Class