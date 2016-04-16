'Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.Net.Mail
Imports System.IO
Imports System.Timers
Imports System.Data.Odbc
Imports System.Data.OleDb

Public Class frmPrincipal
    Private dsCTe As DataSet
    Private daCTe As SqlDataAdapter
    Private dsCad As DataSet
    Private daCad As SqlDataAdapter
    Private dsFis As DataSet
    Private daFis As SqlDataAdapter
    Private dsLog As DataSet
    Private daLog As SqlDataAdapter
    Dim tempo As New Timer()
    Public Property filtro As String = "1=1"

    Private Sub Principal_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader()

        ' Cria um novo SqlDataAdapter que servirá para actualizar o DataSet 
        Dim SQLCTe As String = "SELECT DISTINCT C.NOME_XML, C.DATAEMISSAO, C.CNPJ, C.RAZAO, (SELECT FLAG_ERRO FROM TIPO_FLAG WHERE TIPO = C.TIPO) AS FLAG_ERRO, C.NUMEROMOV, C.SERIE, " +
            "C.TIPO, C.CODFILIAL FROM CRITICAXML C WHERE C.SETOR = 'CTE' AND C.FLAG_STATUS NOT IN ('A','I')  and " + filtro
        daCTe = New SqlDataAdapter(SQLCTe, GetConnectionXML())
        ' Cria um DataSet, ou seja, uma representação em memória da informação
        dsCTe = New DataSet
        ' Coloca a informação da tabela definida no DataSet 
        daCTe.Fill(dsCTe, "CRITICAXML")
        ' Define que a fonte de dados da DataGridView é a nossa DataSet
        ' criando automáticamente as colunas e linhas de dados
        Me.dgCTe.DataSource = dsCTe.Tables("CRITICAXML")
        GetConnectionXML().Dispose()
        ' Cria um novo SqlDataAdapter que servirá para actualizar o DataSet 
        Dim SQLCmp As String = "SELECT DISTINCT C.NOME_XML, C.DATAEMISSAO, C.CNPJ, C.RAZAO, (SELECT FLAG_ERRO FROM TIPO_FLAG WHERE TIPO = C.TIPO) AS FLAG_ERRO, C.TIPO, C.CODFILIAL, C.CNPJINTERNO, C.GRUPO, (SELECT TOP 1 M0_NOMECOM FROM SIGAMAT WHERE M0_CODIGO = C.GRUPO AND M0_CODFIL = C.CODFILIAL) AS EMPRESA " +
            "FROM CRITICAXML C WHERE C.SETOR = 'CMP' AND C.FLAG_STATUS NOT IN ('A','I') and " + filtro
        daCad = New SqlDataAdapter(SQLCmp, GetConnectionXML())
        ' Cria um DataSet, ou seja, uma representação em memória da informação
        dsCad = New DataSet
        ' Coloca a informação da tabela definida no DataSet 
        daCad.Fill(dsCad, "CRITICAXML")
        ' Define que a fonte de dados da DataGridView é a nossa DataSet
        ' criando automáticamente as colunas e linhas de dados
        Me.dgCadastros.DataSource = dsCad.Tables("CRITICAXML")
        GetConnectionXML().Dispose()
        ' Cria um novo SqlDataAdapter que servirá para actualizar o DataSet 
        Dim SQLFis As String = "SELECT DISTINCT C.NOME_XML, C.DATAEMISSAO, C.CNPJ, C.RAZAO, (SELECT FLAG_ERRO FROM TIPO_FLAG WHERE TIPO = C.TIPO) AS FLAG_ERRO, C.TIPO, C.CODFILIAL " +
            "FROM CRITICAXML C WHERE C.SETOR = 'FIS' AND C.FLAG_STATUS NOT IN ('A','I') and " + filtro
        daFis = New SqlDataAdapter(SQLFis, GetConnectionXML())
        ' Cria um DataSet, ou seja, uma representação em memória da informação
        dsFis = New DataSet
        ' Coloca a informação da tabela definida no DataSet 
        daFis.Fill(dsFis, "CRITICAXML")
        ' Define que a fonte de dados da DataGridView é a nossa DataSet
        ' criando automáticamente as colunas e linhas de dados
        Me.dgFiscal.DataSource = dsFis.Tables("CRITICAXML")
        GetConnectionXML().Dispose()
        Dim SQLLog As String = "SELECT DISTINCT NOME_XML, DATAEMISSAO, SETOR, USUARIO FROM LOGEVENTOSXML"
        daLog = New SqlDataAdapter(SQLLog, GetConnectionXML())
        ' Cria um DataSet, ou seja, uma representação em memória da informação
        dsLog = New DataSet
        ' Coloca a informação da tabela definida no DataSet 
        daLog.Fill(dsLog, "CRITICAXML")
        ' Define que a fonte de dados da DataGridView é a nossa DataSet
        ' criando automáticamente as colunas e linhas de dados
        Me.dgLog.DataSource = dsLog.Tables("CRITICAXML")
        GetConnectionXML().Dispose()
    End Sub

    Private Sub dgCTe_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgCTe.CellClick
        Dim i As Integer
        For i = 0 To dgCTe.Rows.Count - 1
            i = dgCTe.CurrentRow.Index
            exibeRegistroPo(i)
            Exit For
        Next
    End Sub
    Private Sub dgCTe_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgCTe.KeyUp
        Dim i As Integer
        For i = 0 To dgCTe.Rows.Count - 1
            i = dgCTe.CurrentRow.Index
            exibeRegistroPo(i)
            Exit For
        Next
    End Sub
    Private Sub dgCTe_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgCTe.KeyDown
        Dim i As Integer
        For i = 0 To dgCTe.Rows.Count - 1
            i = dgCTe.CurrentRow.Index
            exibeRegistroPo(i)
            Exit For
        Next
    End Sub
    Private Sub dgFiscal_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgFiscal.CellClick
        Dim i As Integer
        For i = 0 To dgFiscal.Rows.Count - 1
            i = dgFiscal.CurrentRow.Index
            exibeRegistroFiscal(i)
            Exit For
        Next
    End Sub
    Private Sub dgFiscal_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgFiscal.KeyUp
        Dim i As Integer
        For i = 0 To dgFiscal.Rows.Count - 1
            i = dgFiscal.CurrentRow.Index
            exibeRegistroFiscal(i)
            Exit For
        Next
    End Sub
    Private Sub dgFiscal_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgFiscal.KeyDown
        Dim i As Integer
        For i = 0 To dgFiscal.Rows.Count - 1
            i = dgFiscal.CurrentRow.Index
            exibeRegistroFiscal(i)
            Exit For
        Next
    End Sub
    Private Sub dgCadastros_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgCadastros.CellClick
        Dim i As Integer
        For i = 0 To dgCadastros.Rows.Count - 1
            i = dgCadastros.CurrentRow.Index
            exibeRegistroCadastros(i)
            Exit For
        Next
    End Sub
    Private Sub dgCadastros_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgCadastros.KeyUp
        Dim i As Integer
        For i = 0 To dgCadastros.Rows.Count - 1
            i = dgCadastros.CurrentRow.Index
            exibeRegistroCadastros(i)
            Exit For
        Next
    End Sub
    Private Sub dgCadastros_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgCadastros.KeyDown
        Dim i As Integer
        For i = 0 To dgCadastros.Rows.Count - 1
            i = dgCadastros.CurrentRow.Index
            exibeRegistroCadastros(i)
            Exit For
        Next
    End Sub
    Private Sub dgLog_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgLog.CellClick
        Dim i As Integer
        For i = 0 To dgLog.Rows.Count - 1
            i = dgLog.CurrentRow.Index
            exibeRegistroLog(i)
            Exit For
        Next
    End Sub
    Private Sub dgLog_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgLog.KeyUp
        Dim i As Integer
        For i = 0 To dgLog.Rows.Count - 1
            i = dgLog.CurrentRow.Index
            exibeRegistroLog(i)
            Exit For
        Next
    End Sub
    Private Sub dgLog_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgLog.KeyDown
        Dim i As Integer
        For i = 0 To dgLog.Rows.Count - 1
            i = dgLog.CurrentRow.Index
            exibeRegistroLog(i)
            Exit For
        Next
    End Sub
    Private Sub exibeRegistroCadastros(ByVal i As Integer)
        If Not IsDBNull(Me.dgCadastros.Item(2, i).Value) Then
            txtxmlcad.Text = CStr(Me.dgCadastros.Item(2, i).Value)
        Else
            txtxmlcad.Text = String.Empty
        End If
        If Not IsDBNull(Me.dgCadastros.Item(3, i).Value) Then
            txtdataemissaocad.Text = CStr(Me.dgCadastros.Item(3, i).Value)
        Else
            txtdataemissaocad.Text = String.Empty
        End If
        If Not IsDBNull(Me.dgCadastros.Item(4, i).Value) Then
            txtcnpjcad.Text = CStr(Me.dgCadastros.Item(4, i).Value)
        Else
            txtcnpjcad.Text = String.Empty
        End If
        If Not IsDBNull(Me.dgCadastros.Item(5, i).Value) Then
            txtrazaocad.Text = CStr(Me.dgCadastros.Item(5, i).Value)
        Else
            txtrazaocad.Text = String.Empty
        End If
        If Not IsDBNull(Me.dgCadastros.Item(8, i).Value) Then
            txtFilial.Text = CStr(Me.dgCadastros.Item(8, i).Value)
        Else
            txtFilial.Text = String.Empty
        End If

        If Not IsDBNull(Me.dgCadastros.Item(9, i).Value) Then
            txtCnpjInterno.Text = CStr(Me.dgCadastros.Item(9, i).Value)
        Else
            txtCnpjInterno.Text = String.Empty
        End If

        If Not IsDBNull(Me.dgCadastros.Item(10, i).Value) Then
            txtGrupo.Text = CStr(Me.dgCadastros.Item(10, i).Value)
        Else
            txtGrupo.Text = String.Empty
        End If


    End Sub

    Private Sub exibeRegistroPo(ByVal i As Integer)
        If Not IsDBNull(Me.dgCTe.Item(2, i).Value) Then
            txtxmlcte.Text = CStr(Me.dgCTe.Item(2, i).Value)
        Else
            txtxmlcte.Text = String.Empty
        End If
        If Not IsDBNull(Me.dgCTe.Item(3, i).Value) Then
            txtdataemissaocte.Text = CStr(Me.dgCTe.Item(3, i).Value)
        Else
            txtdataemissaocte.Text = String.Empty
        End If
        If Not IsDBNull(Me.dgCTe.Item(4, i).Value) Then
            txtcnpjcte.Text = CStr(Me.dgCTe.Item(4, i).Value)
        Else
            txtcnpjcte.Text = String.Empty
        End If
        If Not IsDBNull(Me.dgCTe.Item(5, i).Value) Then
            txtrazaocte.Text = CStr(Me.dgCTe.Item(5, i).Value)
        Else
            txtrazaocte.Text = String.Empty
        End If
        If Not IsDBNull(Me.dgCTe.Item(7, i).Value) Then
            txtNf.Text = CStr(Me.dgCTe.Item(7, i).Value)
        Else
            txtNf.Text = String.Empty
        End If
        If Not IsDBNull(Me.dgCTe.Item(8, i).Value) Then
            txtSerie.Text = CStr(Me.dgCTe.Item(8, i).Value)
        Else
            txtSerie.Text = String.Empty
        End If
        If Not IsDBNull(Me.dgCTe.Item(10, i).Value) Then
            txtfilialcte.Text = CStr(Me.dgCTe.Item(10, i).Value)
        Else
            txtfilialcte.Text = String.Empty
        End If
    End Sub

    Private Sub exibeRegistroFiscal(ByVal i As Integer)
        If Not IsDBNull(Me.dgFiscal.Item(2, i).Value) Then
            txtxmlfiscal.Text = CStr(Me.dgFiscal.Item(2, i).Value)
        Else
            txtxmlfiscal.Text = String.Empty
        End If
        If Not IsDBNull(Me.dgFiscal.Item(3, i).Value) Then
            txtdataemissaofiscal.Text = CStr(Me.dgFiscal.Item(3, i).Value)
        Else
            txtdataemissaofiscal.Text = String.Empty
        End If
        If Not IsDBNull(Me.dgFiscal.Item(4, i).Value) Then
            txtcnpjfiscal.Text = CStr(Me.dgFiscal.Item(4, i).Value)
        Else
            txtcnpjfiscal.Text = String.Empty
        End If
        If Not IsDBNull(Me.dgFiscal.Item(5, i).Value) Then
            txtrazaofiscal.Text = CStr(Me.dgFiscal.Item(5, i).Value)
        Else
            txtrazaofiscal.Text = String.Empty
        End If
        If Not IsDBNull(Me.dgFiscal.Item(8, i).Value) Then
            txtfilialfis.Text = CStr(Me.dgFiscal.Item(8, i).Value)
        Else
            txtfilialfis.Text = String.Empty
        End If
    End Sub
    Private Sub exibeRegistroLog(ByVal i As Integer)
        If Not IsDBNull(Me.dgLog.Item(0, i).Value) Then
            txtxmllog.Text = CStr(Me.dgLog.Item(0, i).Value)
        Else
            txtxmllog.Text = String.Empty
        End If
        If Not IsDBNull(Me.dgLog.Item(1, i).Value) Then
            txtDatalog.Text = CStr(Me.dgLog.Item(1, i).Value)
        Else
            txtDatalog.Text = String.Empty
        End If
        If Not IsDBNull(Me.dgLog.Item(2, i).Value) Then
            If CStr(Me.dgLog.Item(2, i).Value) = "CMP" Then
                txtsetorlog.Text = "Cadastro"
            ElseIf CStr(Me.dgLog.Item(2, i).Value) = "FIS" Then
                txtsetorlog.Text = "Fiscal"
            End If
        Else
            txtsetorlog.Text = String.Empty
        End If
        If Not IsDBNull(Me.dgLog.Item(3, i).Value) Then
            txtusuariolog.Text = CStr(Me.dgLog.Item(3, i).Value)
        Else
            txtusuariolog.Text = String.Empty
        End If
    End Sub

    Sub dgCTe_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgCTe.CellDoubleClick
        txtxmlcte.Text = String.Empty
        txtdataemissaocte.Text = String.Empty
        txtcnpjcte.Text = String.Empty
        txtrazaocte.Text = String.Empty
        txtNf.Text = String.Empty
        txtSerie.Text = String.Empty
        If dgCTe.RowCount > 0 Then
            Dim xml, tipo As String
            xml = dgCTe.Rows(e.RowIndex).Cells(2).Value.ToString
            tipo = dgCTe.Rows(e.RowIndex).Cells(9).Value.ToString
            fArmazenaXml(xml, tipo)
            frmDetalhaCTe.ShowDialog()
        End If
    End Sub
    Sub dgFiscal_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgFiscal.CellDoubleClick
        txtxmlfiscal.Text = String.Empty
        txtdataemissaofiscal.Text = String.Empty
        txtcnpjfiscal.Text = String.Empty
        txtrazaofiscal.Text = String.Empty
        If dgFiscal.RowCount > 0 Then
            Dim xml, tipo As String
            xml = dgFiscal.Rows(e.RowIndex).Cells(2).Value.ToString
            tipo = dgFiscal.Rows(e.RowIndex).Cells(7).Value.ToString
            fArmazenaXml(xml, tipo)
            frmDetalhaFiscal.ShowDialog()
        End If
    End Sub
    Sub dgCadastros_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgCadastros.CellDoubleClick
        txtxmlcad.Text = String.Empty
        txtdataemissaocad.Text = String.Empty
        txtcnpjcad.Text = String.Empty
        txtrazaocad.Text = String.Empty
        If dgCadastros.Rows.Count > 0 Then
            Dim xml, tipo As String
            xml = dgCadastros.Rows(e.RowIndex).Cells(2).Value.ToString
            tipo = dgCadastros.Rows(e.RowIndex).Cells(7).Value.ToString
            fArmazenaXml(xml, tipo)
            frmDetalhaCadastro.ShowDialog()
        End If
    End Sub
    Sub dgLog_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgLog.CellDoubleClick
        txtxmllog.Text = String.Empty
        txtDatalog.Text = String.Empty
        txtsetorlog.Text = String.Empty
        txtsetorlog.Text = String.Empty
        txtusuariolog.Text = String.Empty
        If dgLog.Rows.Count > 0 Then
            Dim xml As String
            xml = dgLog.Rows(e.RowIndex).Cells(0).Value.ToString
            fArmazenaXml(xml, "")
            frmLog.ShowDialog()
        End If
    End Sub

    Sub fAtualizaDG(ByVal sSetor As String)
        If sSetor = "CTE" Then
            dsCTe.Clear()
            Dim SQLCTe As String = "SELECT DISTINCT C.NOME_XML, C.DATAEMISSAO, C.CNPJ, C.RAZAO, (SELECT FLAG_ERRO FROM TIPO_FLAG WHERE TIPO = C.TIPO) AS FLAG_ERRO, C.TIPO, C.CODFILIAL " +
                "FROM CRITICAXML C WHERE C.SETOR = '" & sSetor & "' AND C.FLAG_STATUS NOT IN ('A','I') and " + filtro
            daCTe = New SqlDataAdapter(SQLCTe, GetConnectionXML())
            daCTe.Fill(dsCTe, "CRITICAXML")
            Me.dgCTe.DataSource = dsCTe.Tables("CRITICAXML")
            GetConnectionXML().Dispose()
        ElseIf sSetor = "CMP" Then
            dsCad.Clear()
            Dim SQLCad As String = "SELECT DISTINCT C.NOME_XML, C.DATAEMISSAO, C.CNPJ, C.RAZAO, (SELECT FLAG_ERRO FROM TIPO_FLAG WHERE TIPO = C.TIPO) AS FLAG_ERRO, C.TIPO, C.CODFILIAL " +
                "FROM CRITICAXML C WHERE C.SETOR = '" & sSetor & "' AND C.FLAG_STATUS NOT IN ('A','I') and " + filtro
            daCad = New SqlDataAdapter(SQLCad, GetConnectionXML())
            daCad.Fill(dsCad, "CRITICAXML")
            Me.dgCadastros.DataSource = dsCad.Tables("CRITICAXML")
            GetConnectionXML().Dispose()
        ElseIf sSetor = "FIS" Then
            dsFis.Clear()
            Dim SQLFis As String = "SELECT DISTINCT C.NOME_XML, C.DATAEMISSAO, C.CNPJ, C.RAZAO, (SELECT FLAG_ERRO FROM TIPO_FLAG WHERE TIPO = C.TIPO) AS FLAG_ERRO, C.TIPO, C.CODFILIAL " +
                "FROM CRITICAXML C WHERE C.SETOR = '" & sSetor & "' AND C.FLAG_STATUS NOT IN ('A','I') and " + filtro
            daFis = New SqlDataAdapter(SQLFis, GetConnectionXML())
            daFis.Fill(dsFis, "CRITICAXML")
            Me.dgFiscal.DataSource = dsFis.Tables("CRITICAXML")
            GetConnectionXML().Dispose()
        ElseIf sSetor = "LOG" Then
            dsLog.Clear()
            Dim SQLLog As String = "SELECT DISTINCT NOME_XML, DATAEMISSAO, SETOR, USUARIO FROM LOGEVENTOSXML"
            daLog = New SqlDataAdapter(SQLLog, GetConnectionXML())
            daLog.Fill(dsLog, "CRITICAXML")
            Me.dgLog.DataSource = dsLog.Tables("CRITICAXML")
            GetConnectionXML().Dispose()
        End If
    End Sub

    Private Sub btnreprocessacte_Click(sender As System.Object, e As System.EventArgs) Handles btnreprocessacte.Click
        Dim bVal As Boolean = False
        For Each row As DataGridViewRow In dgCTe.Rows
            For i = 0 To dgCTe.Rows.Count - 1
                If dgCTe.Item(1, i).Value Then
                    Dim xml As String
                    If Not IsDBNull(Me.dgCTe.Item(2, i).Value) Then
                        xml = CStr(Me.dgCTe.Item(2, i).Value)
                    Else
                        xml = String.Empty
                    End If
                    Using con As SqlConnection = GetConnectionXML()
                        Try
                            con.Open()
                            Dim cmd As New SqlCommand
                            cmd.Connection = con
                            Dim dr As SqlDataReader
                            cmd.CommandText = "DELETE FROM CRITICAXML WHERE NOME_XML = '" & xml & "'"
                            dr = cmd.ExecuteReader()
                            con.Dispose()
                            bVal = True
                        Catch ex As Exception
                            MsgBox(ex.ToString)
                        End Try
                    End Using
                End If
            Next
            Exit For
        Next
        If bVal Then
            fAtualizaDG("CTE")
            MsgBox("Os arquivos XMLs selecionados serão processados novamente.", MsgBoxStyle.Information, "Informação")
            txtxmlcte.Text = String.Empty
            txtdataemissaocte.Text = String.Empty
            txtcnpjcte.Text = String.Empty
            txtrazaocte.Text = String.Empty
            txtNf.Text = String.Empty
            txtSerie.Text = String.Empty
        Else
            MsgBox("Nenhum arquivo XML selecionado.", MsgBoxStyle.Critical, "Atenção")
        End If
    End Sub

    Private Sub btnreprocessarfiscal_Click(sender As System.Object, e As System.EventArgs) Handles btnreprocessarfiscal.Click
        Dim i As Integer
        Dim bVal As Boolean = False
        For Each row As DataGridViewRow In dgFiscal.Rows
            For i = 0 To dgFiscal.Rows.Count - 1
                If dgFiscal.Item(1, i).Value Then
                    Dim xml As String
                    If Not IsDBNull(Me.dgFiscal.Item(2, i).Value) Then
                        xml = CStr(Me.dgFiscal.Item(2, i).Value)
                    Else
                        xml = String.Empty
                    End If
                    Using con As SqlConnection = GetConnectionXML()
                        Try
                            con.Open()
                            Dim cmd As New SqlCommand
                            cmd.Connection = con
                            Dim dr As SqlDataReader
                            cmd.CommandText = "DELETE FROM CRITICAXML WHERE NOME_XML = '" & xml & "'"
                            dr = cmd.ExecuteReader()
                            con.Dispose()
                            bVal = True
                        Catch ex As Exception
                            MsgBox(ex.ToString)
                        End Try
                    End Using
                    'i += 1
                End If
            Next
            Exit For
        Next
        If bVal Then
            fAtualizaDG("FIS")
            MsgBox("Os arquivos XMLs selecionados serão processados novamente.", MsgBoxStyle.Information, "Informação")
        End If
        txtxmlfiscal.Text = String.Empty
        txtdataemissaofiscal.Text = String.Empty
        txtcnpjfiscal.Text = String.Empty
        txtrazaofiscal.Text = String.Empty
    End Sub

    Private Sub btnreprocessaxmlcad_Click(sender As System.Object, e As System.EventArgs) Handles btnreprocessaxmlcad.Click
        Dim i As Integer
        Dim bVal As Boolean = False
        For Each row As DataGridViewRow In dgCadastros.Rows
            For i = 0 To dgCadastros.Rows.Count - 1
                If dgCadastros.Item(1, i).Value Then
                    Dim xml As String
        
                    If Not IsDBNull(Me.dgCadastros.Item(2, i).Value) Then
                        xml = CStr(Me.dgCadastros.Item(2, i).Value)
                    Else
                        xml = String.Empty
                    End If
                    Using con As SqlConnection = GetConnectionXML()
                        Try
                            con.Open()
                            Dim cmd As New SqlCommand
                            cmd.Connection = con
                            Dim dr As SqlDataReader
                            cmd.CommandText = "DELETE FROM CRITICAXML WHERE NOME_XML = '" & xml & "'"
                            dr = cmd.ExecuteReader()
                            con.Dispose()
                            bVal = True
                        Catch ex As Exception
                            MsgBox(ex.ToString)
                        End Try
                    End Using
                End If
            Next
            Exit For
        Next
        If bVal Then
            fAtualizaDG("CMP")
            MsgBox("Os arquivos XMLs selecionados serão processados novamente.", MsgBoxStyle.Information, "Informação")
        End If
        txtxmlcad.Text = String.Empty
        txtdataemissaocad.Text = String.Empty
        txtcnpjcad.Text = String.Empty
        txtrazaocad.Text = String.Empty
    End Sub

    Private Sub btnsairfiscal_Click(sender As System.Object, e As System.EventArgs) Handles btnsairfiscal.Click
        Me.Close()
    End Sub

    Private Sub btnsaicad_Click(sender As System.Object, e As System.EventArgs) Handles btnsaicad.Click
        Application.Exit()
    End Sub

    Private Sub btnSairLog_Click(sender As System.Object, e As System.EventArgs) Handles btnSairLog.Click
        Me.Close()
    End Sub

    Private Sub btnsaircte_Click(sender As System.Object, e As System.EventArgs) Handles btnsaircte.Click
        Me.Close()
    End Sub

    Private Sub btnIgnorarCriticaFiscal_Click(sender As System.Object, e As System.EventArgs) Handles btnIgnorarCriticaFiscal.Click
        Dim i As Integer
        Dim bVal As Boolean = False
        Dim bValSim As Boolean = False
        Dim bValAtuTela As Boolean = False
        For Each row As DataGridViewRow In dgFiscal.Rows
            For i = 0 To dgFiscal.Rows.Count - 1
                bVal = False
                If dgFiscal.Item(1, i).Value Then
                    Dim xml As String
                    'i = dgFiscal.CurrentRow.Index
                    If Not IsDBNull(Me.dgFiscal.Item(2, i).Value) Then
                        xml = CStr(Me.dgFiscal.Item(2, i).Value)
                    Else
                        xml = String.Empty
                    End If
                    Using con As SqlConnection = GetConnectionXML() 'Verifica o cadastro do produto
                        Try
                            con.Open()
                            Dim cmd As New SqlCommand
                            cmd.Connection = con
                            cmd.CommandText = "SELECT TIPO FROM CRITICAXML WHERE NOME_XML = '" & xml & "' AND TIPO = 'C' AND FLAG_STATUS NOT IN ('A','I') and " + filtro
                            Dim dr As SqlDataReader = cmd.ExecuteReader()
                            dr.Read()
                            If dr.HasRows Then
                                bVal = True
                            End If
                            con.Dispose()
                        Catch ex As Exception
                            MsgBox(ex.ToString)
                        End Try
                    End Using
                    If bVal Then
                        bVal = False
                        MsgBox("O XML " & xml & " não pode ser processado com Status Crítico.", MsgBoxStyle.Critical, "Atenção")
                        Exit For
                    Else
                        If bValSim Then
                            bValAtuTela = True
                            Using con As SqlConnection = GetConnectionXML() 'Verifica o cadastro do produto
                                Try
                                    con.Open()
                                    Dim cmd As New SqlCommand
                                    cmd.Connection = con
                                    cmd.CommandText = "SELECT CRITICA, COD_PRD, CST, ALIQ_ICMS, ALIQ_ICMSST, RED_BC FROM CRITICAXML WHERE NOME_XML = '" & xml & "'"
                                    Dim dr As SqlDataReader = cmd.ExecuteReader()
                                    If dr.HasRows Then
                                        While dr.Read()
                                            Using con2 As SqlConnection = GetConnectionXML()  'Grava log com o usuario que ignorou a critica
                                                Try
                                                    con2.Open()
                                                    Dim cmd2 As New SqlCommand
                                                    cmd2.Connection = con2
                                                    cmd2.CommandText = "INSERT INTO LOGEVENTOSXML (NOME_XML, DATAEMISSAO, SETOR, USUARIO, EVENTO, CRITICA, COD_PRD, CST, ALIQ_ICMS, ALIQ_ICMSST, RED_BC) " +
                                                        "VALUES ('" & xml & "',convert(datetime, '" & String.Format("{0:yyyy-MM-dd}", Today) & "', 121), 'FIS', " +
                                                        "'" & System.Environment.UserName & "', 'I', '" & dr.Item(0) & "', '" & dr.Item(1) & "', '" & dr.Item(2) & "', " +
                                                        "'" & Str(IIf(IsDBNull(dr.Item(3)), 0, dr.Item(3))) & "', '" & Str(IIf(IsDBNull(dr.Item(4)), 0, dr.Item(4))) & "', '" & Str(IIf(IsDBNull(dr.Item(5)), 0, dr.Item(5))) & "')"
                                                    cmd2.ExecuteReader()
                                                    con2.Dispose()
                                                Catch ex As Exception
                                                    MsgBox(ex.ToString)
                                                End Try
                                            End Using
                                        End While
                                    End If
                                    con.Dispose()
                                Catch ex As Exception
                                    MsgBox(ex.ToString)
                                End Try
                            End Using
                            Using con As SqlConnection = GetConnectionXML() 'Atualiza Flag para I (Critica Ignorada)
                                Try
                                    con.Open()
                                    Dim cmd As New SqlCommand
                                    cmd.Connection = con
                                    Dim dr As SqlDataReader
                                    cmd.CommandText = "UPDATE CRITICAXML SET FLAG_STATUS = 'I' WHERE NOME_XML = '" & xml & "' AND SETOR = 'FIS'"
                                    dr = cmd.ExecuteReader()
                                    con.Dispose()
                                Catch ex As Exception
                                    MsgBox(ex.ToString)
                                End Try
                            End Using
                            bVal = True
                        Else
                            Dim style As MsgBoxStyle
                            Dim response As MsgBoxResult
                            style = MsgBoxStyle.DefaultButton2 Or _
                               MsgBoxStyle.Exclamation Or MsgBoxStyle.YesNo
                            response = MsgBox("Deseja realmente ignorar as críticas do arquivo XML?", style, "Confirmação")
                            If response = MsgBoxResult.Yes Then
                                bValSim = True
                                bValAtuTela = True
                                Using con As SqlConnection = GetConnectionXML() 'Verifica o cadastro do produto
                                    Try
                                        con.Open()
                                        Dim cmd As New SqlCommand
                                        cmd.Connection = con
                                        cmd.CommandText = "SELECT CRITICA, COD_PRD, CST, ALIQ_ICMS, ALIQ_ICMSST, RED_BC FROM CRITICAXML WHERE NOME_XML = '" & xml & "'"
                                        Dim dr As SqlDataReader = cmd.ExecuteReader()
                                        If dr.HasRows Then
                                            While dr.Read()
                                                Using con2 As SqlConnection = GetConnectionXML()  'Grava log com o usuario que ignorou a critica
                                                    Try
                                                        con2.Open()
                                                        Dim cmd2 As New SqlCommand
                                                        cmd2.Connection = con2
                                                        cmd2.CommandText = "INSERT INTO LOGEVENTOSXML (NOME_XML, DATAEMISSAO, SETOR, USUARIO, EVENTO, CRITICA, COD_PRD, CST, ALIQ_ICMS, ALIQ_ICMSST, RED_BC) " +
                                                            "VALUES ('" & xml & "',convert(datetime, '" & String.Format("{0:yyyy-MM-dd}", Today) & "', 121), 'FIS', " +
                                                            "'" & System.Environment.UserName & "', 'I', '" & dr.Item(0) & "', '" & dr.Item(1) & "', '" & dr.Item(2) & "', " +
                                                            "'" & Str(IIf(IsDBNull(dr.Item(3)), 0, dr.Item(3))) & "', '" & Str(IIf(IsDBNull(dr.Item(4)), 0, dr.Item(4))) & "', '" & Str(IIf(IsDBNull(dr.Item(5)), 0, dr.Item(5))) & "')"
                                                        cmd2.ExecuteReader()
                                                        con2.Dispose()
                                                    Catch ex As Exception
                                                        MsgBox(ex.ToString)
                                                    End Try
                                                End Using
                                            End While
                                        End If
                                        con.Dispose()
                                    Catch ex As Exception
                                        MsgBox(ex.ToString)
                                    End Try
                                End Using
                                Using con As SqlConnection = GetConnectionXML() 'Atualiza Flag para I (Critica Ignorada)
                                    Try
                                        con.Open()
                                        Dim cmd As New SqlCommand
                                        cmd.Connection = con
                                        Dim dr As SqlDataReader
                                        cmd.CommandText = "UPDATE CRITICAXML SET FLAG_STATUS = 'I' WHERE NOME_XML = '" & xml & "' AND SETOR = 'FIS'"
                                        dr = cmd.ExecuteReader()
                                        con.Dispose()
                                    Catch ex As Exception
                                        MsgBox(ex.ToString)
                                    End Try
                                End Using
                                bVal = True
                            Else
                                Continue For
                            End If
                        End If
                    End If
                End If
            Next
            If bValAtuTela Then
                fAtualizaDG("FIS")
                MsgBox("Críticas ignoradas com sucesso.", MsgBoxStyle.Information, "Informação")
            End If
            Exit For
        Next
    End Sub

    Private Sub btnmarcatodoscte_Click(sender As System.Object, e As System.EventArgs) Handles btnmarcatodoscte.Click
        For Each row As DataGridViewRow In dgCTe.Rows
            If row.Cells(1).Value Then
                row.Cells(1).Value = False
            Else
                row.Cells(1).Value = True
            End If
        Next
    End Sub

    Private Sub btnSelSimNaoFiscal_Click(sender As System.Object, e As System.EventArgs) Handles btnSelSimNaoFiscal.Click
        For Each row As DataGridViewRow In dgFiscal.Rows
            If row.Cells(1).Value Then
                row.Cells(1).Value = False
            Else
                row.Cells(1).Value = True
            End If
        Next
    End Sub

    Private Sub btnSelSimNaoCad_Click(sender As System.Object, e As System.EventArgs) Handles btnSelSimNaoCad.Click
        For Each row As DataGridViewRow In dgCadastros.Rows
            If row.Cells(1).Value Then
                row.Cells(1).Value = False
            Else
                row.Cells(1).Value = True
            End If
        Next
    End Sub

    Private Sub btnatuvisaocte_Click(sender As System.Object, e As System.EventArgs) Handles btnatuvisaocte.Click
        fAtualizaDG("CTE")
    End Sub

    Private Sub btnAtuTela_Click(sender As System.Object, e As System.EventArgs) Handles btnAtuTela.Click
        fAtualizaDG("CMP")
    End Sub

    Private Sub btnAtuVisao_Click(sender As System.Object, e As System.EventArgs) Handles btnAtuVisao.Click
        fAtualizaDG("FIS")
    End Sub

    Private Sub btnAtuVisaoLog_Click(sender As System.Object, e As System.EventArgs) Handles btnAtuVisaoLog.Click
        fAtualizaDG("LOG")
    End Sub

    Private Sub btnexcluicte_Click(sender As System.Object, e As System.EventArgs) Handles btnexcluicte.Click
        Dim configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader()
        Dim caminho, sProcessado, sCriticados As String
        caminho = configurationAppSettings.GetValue("RepositorioCTE", GetType(System.String))
        sProcessado = configurationAppSettings.GetValue("ProcessadosCTE", GetType(System.String))
        sCriticados = configurationAppSettings.GetValue("CriticadosCTE", GetType(System.String))
        Dim i As Integer
        Dim bVal As Boolean = False
        Dim bValPerg As Boolean = False
        Dim xml As String
        For Each row As DataGridViewRow In dgCTe.Rows
            For i = 0 To dgCTe.Rows.Count - 1
                If dgCTe.Item(1, i).Value Then
                    If Not IsDBNull(Me.dgCTe.Item(2, i).Value) Then
                        xml = CStr(Me.dgCTe.Item(2, i).Value)
                    Else
                        xml = String.Empty
                    End If
                    If Not bValPerg Then
                        Dim style As MsgBoxStyle
                        Dim response As MsgBoxResult
                        style = MsgBoxStyle.DefaultButton2 Or _
                           MsgBoxStyle.Exclamation Or MsgBoxStyle.YesNo
                        response = MsgBox("Deseja realmente excluir o arquivo XML?", style, "Confirmação")
                        If response = MsgBoxResult.Yes Then
                            bVal = True
                            bValPerg = True
                        Else
                            bValPerg = True
                        End If
                    End If
                    If bVal Then
                        If Not System.IO.File.Exists(Application.StartupPath & caminho & "\" & xml.ToString) Then
                            Using con As SqlConnection = GetConnectionXML()
                                Try
                                    con.Open()
                                    Dim cmd As New SqlCommand
                                    cmd.Connection = con
                                    Dim dr As SqlDataReader
                                    cmd.CommandText = "DELETE FROM CRITICAXML WHERE NOME_XML = '" & xml & "'"
                                    dr = cmd.ExecuteReader()
                                    con.Dispose()
                                Catch ex As Exception
                                    MsgBox(ex.ToString)
                                End Try
                            End Using
                        Else
                            Using con As SqlConnection = GetConnectionXML() 'Verifica o cadastro do produto
                                Try
                                    con.Open()
                                    Dim cmd As New SqlCommand
                                    cmd.Connection = con
                                    cmd.CommandText = "SELECT CRITICA FROM CRITICAXML WHERE NOME_XML = '" & xml & "'"
                                    Dim dr As SqlDataReader = cmd.ExecuteReader()
                                    If dr.HasRows Then
                                        While dr.Read()
                                            Using con2 As SqlConnection = GetConnectionXML()  'Grava log com o usuario que ignorou a critica
                                                Try
                                                    con2.Open()
                                                    Dim cmd2 As New SqlCommand
                                                    cmd2.Connection = con2
                                                    cmd2.CommandText = "INSERT INTO LOGEVENTOSXML (NOME_XML, DATAEMISSAO, SETOR, USUARIO, EVENTO, CRITICA) " +
                                                        "VALUES ('" & xml & "',convert(datetime, '" & String.Format("{0:yyyy-MM-dd}", Today) & "', 121), 'PO', '" & System.Environment.UserName & "', 'D', '" & dr.Item(0) & "')"
                                                    cmd2.ExecuteReader()
                                                    con2.Dispose()
                                                Catch ex As Exception
                                                    MsgBox(ex.ToString)
                                                End Try
                                            End Using
                                        End While
                                    End If
                                    con.Dispose()
                                Catch ex As Exception
                                    MsgBox(ex.ToString)
                                End Try
                            End Using
                            Using con As SqlConnection = GetConnectionXML() 'Atualiza Flag para I (Critica Ignorada)
                                Try
                                    con.Open()
                                    Dim cmd As New SqlCommand
                                    cmd.Connection = con
                                    Dim dr As SqlDataReader
                                    cmd.CommandText = "DELETE FROM CRITICAXML WHERE NOME_XML = '" & xml & "'"
                                    dr = cmd.ExecuteReader()
                                    con.Dispose()
                                Catch ex As Exception
                                    MsgBox(ex.ToString)
                                End Try
                            End Using
                            File.Delete(sCriticados & "\" & xml.ToString)
                            File.Copy(caminho & "\" & xml.ToString, sCriticados & "\" & xml.ToString)
                            File.Delete(caminho & "\" & xml.ToString)
                        End If
                    End If
                End If
            Next
            If bVal Then
                fAtualizaDG("CTE")
                MsgBox("XML excluído com sucesso.", MsgBoxStyle.Information, "Informação")
            End If
            Exit For
        Next
    End Sub

    Private Sub btnExcluirFis_Click(sender As System.Object, e As System.EventArgs) Handles btnExcluirFis.Click
        Dim configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader()
        Dim caminho, sProcessado, sCriticados As String
        caminho = configurationAppSettings.GetValue("RepositorioXML", GetType(System.String))
        sProcessado = configurationAppSettings.GetValue("ProcessadosXML", GetType(System.String))
        sCriticados = configurationAppSettings.GetValue("CriticadosXML", GetType(System.String))
        Dim i As Integer
        Dim bVal As Boolean = False
        Dim bValPerg As Boolean = False
        Dim xml As String
        For Each row As DataGridViewRow In dgFiscal.Rows
            For i = 0 To dgFiscal.Rows.Count - 1
                If dgFiscal.Item(1, i).Value Then
                    'i = dgFiscal.CurrentRow.Index
                    If Not IsDBNull(Me.dgFiscal.Item(2, i).Value) Then
                        xml = CStr(Me.dgFiscal.Item(2, i).Value)
                    Else
                        xml = String.Empty
                    End If
                    If Not bValPerg Then
                        Dim style As MsgBoxStyle
                        Dim response As MsgBoxResult
                        style = MsgBoxStyle.DefaultButton2 Or _
                           MsgBoxStyle.Exclamation Or MsgBoxStyle.YesNo
                        response = MsgBox("Deseja realmente excluir o arquivo XML?", style, "Confirmação")
                        If response = MsgBoxResult.Yes Then
                            bVal = True
                            bValPerg = True
                        Else
                            bValPerg = True
                        End If
                    End If
                    If bVal Then
                        If Not System.IO.File.Exists(Application.StartupPath & caminho & "\" & xml.ToString) Then
                            Using con As SqlConnection = GetConnectionXML()
                                Try
                                    con.Open()
                                    Dim cmd As New SqlCommand
                                    cmd.Connection = con
                                    Dim dr As SqlDataReader
                                    cmd.CommandText = "DELETE FROM CRITICAXML WHERE NOME_XML = '" & xml & "'"
                                    dr = cmd.ExecuteReader()
                                    con.Dispose()
                                Catch ex As Exception
                                    MsgBox(ex.ToString)
                                End Try
                            End Using
                        Else
                            Using con As SqlConnection = GetConnectionXML() 'Verifica o cadastro do produto
                                Try
                                    con.Open()
                                    Dim cmd As New SqlCommand
                                    cmd.Connection = con
                                    cmd.CommandText = "SELECT CRITICA FROM CRITICAXML WHERE NOME_XML = '" & xml & "'"
                                    Dim dr As SqlDataReader = cmd.ExecuteReader()
                                    If dr.HasRows Then
                                        While dr.Read()
                                            Using con2 As SqlConnection = GetConnectionXML()  'Grava log com o usuario que ignorou a critica
                                                Try
                                                    con2.Open()
                                                    Dim cmd2 As New SqlCommand
                                                    cmd2.Connection = con2
                                                    cmd2.CommandText = "INSERT INTO LOGEVENTOSXML (NOME_XML, DATAEMISSAO, SETOR, USUARIO, EVENTO, CRITICA) " +
                                                        "VALUES ('" & xml & "',convert(datetime, '" & String.Format("{0:yyyy-MM-dd}", Today) & "', 121), 'FIS', '" & System.Environment.UserName & "', 'D', '" & dr.Item(0) & "')"
                                                    cmd2.ExecuteReader()
                                                    con2.Dispose()
                                                Catch ex As Exception
                                                    MsgBox(ex.ToString)
                                                End Try
                                            End Using
                                        End While
                                    End If
                                    con.Dispose()
                                Catch ex As Exception
                                    MsgBox(ex.ToString)
                                End Try
                            End Using
                            Using con As SqlConnection = GetConnectionXML()
                                Try
                                    con.Open()
                                    Dim cmd As New SqlCommand
                                    cmd.Connection = con
                                    Dim dr As SqlDataReader
                                    cmd.CommandText = "DELETE FROM CRITICAXML WHERE NOME_XML = '" & xml & "'"
                                    dr = cmd.ExecuteReader()
                                    con.Dispose()
                                Catch ex As Exception
                                    MsgBox(ex.ToString)
                                End Try
                            End Using
                            File.Delete(sCriticados & "\" & xml.ToString)
                            File.Copy(caminho & "\" & xml.ToString, sCriticados & "\" & xml.ToString)
                            File.Delete(caminho & "\" & xml.ToString)
                        End If
                    End If
                End If
            Next
            If bVal Then
                fAtualizaDG("FIS")
                MsgBox("XML excluído com sucesso.", MsgBoxStyle.Information, "Informação")
            End If
            Exit For
        Next
    End Sub

    Private Sub btnExcluirCad_Click(sender As System.Object, e As System.EventArgs) Handles btnExcluirCad.Click
        Dim configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader()
        Dim caminho, sProcessado, sCriticados As String
        caminho = configurationAppSettings.GetValue("RepositorioXML", GetType(System.String))
        sProcessado = configurationAppSettings.GetValue("ProcessadosXML", GetType(System.String))
        sCriticados = configurationAppSettings.GetValue("CriticadosXML", GetType(System.String))
        Dim i As Integer
        Dim bVal As Boolean = False
        Dim bValPerg As Boolean = False
        Dim xml As String
        For Each row As DataGridViewRow In dgCadastros.Rows
            For i = 0 To dgCadastros.Rows.Count - 1
                If dgCadastros.Item(1, i).Value Then
                    'i = dgCadastros.CurrentRow.Index
                    If Not IsDBNull(Me.dgCadastros.Item(2, i).Value) Then
                        xml = CStr(Me.dgCadastros.Item(2, i).Value)
                    Else
                        xml = String.Empty
                    End If
                    If Not bValPerg Then
                        Dim style As MsgBoxStyle
                        Dim response As MsgBoxResult
                        style = MsgBoxStyle.DefaultButton2 Or _
                           MsgBoxStyle.Exclamation Or MsgBoxStyle.YesNo
                        response = MsgBox("Deseja realmente excluir o arquivo XML?", style, "Confirmação")
                        If response = MsgBoxResult.Yes Then
                            bVal = True
                            bValPerg = True
                        Else
                            bValPerg = True
                        End If
                    End If
                    If bVal Then
                        If Not System.IO.File.Exists(Application.StartupPath & caminho & "\" & xml.ToString) Then
                            Using con As SqlConnection = GetConnectionXML()
                                Try
                                    con.Open()
                                    Dim cmd As New SqlCommand
                                    cmd.Connection = con
                                    Dim dr As SqlDataReader
                                    cmd.CommandText = "DELETE FROM CRITICAXML WHERE NOME_XML = '" & xml & "'"
                                    dr = cmd.ExecuteReader()
                                    con.Dispose()
                                Catch ex As Exception
                                    MsgBox(ex.ToString)
                                End Try
                            End Using
                        Else
                            Using con As SqlConnection = GetConnectionXML() 'Verifica o cadastro do produto
                                Try
                                    con.Open()
                                    Dim cmd As New SqlCommand
                                    cmd.Connection = con
                                    cmd.CommandText = "SELECT CRITICA FROM CRITICAXML WHERE NOME_XML = '" & xml & "'"
                                    Dim dr As SqlDataReader = cmd.ExecuteReader()
                                    If dr.HasRows Then
                                        While dr.Read()
                                            Using con2 As SqlConnection = GetConnectionXML()  'Grava log com o usuario que ignorou a critica
                                                Try
                                                    con2.Open()
                                                    Dim cmd2 As New SqlCommand
                                                    cmd2.Connection = con2
                                                    cmd2.CommandText = "INSERT INTO LOGEVENTOSXML (NOME_XML, DATAEMISSAO, SETOR, USUARIO, EVENTO, CRITICA) " +
                                                        "VALUES ('" & xml & "',convert(datetime, '" & String.Format("{0:yyyy-MM-dd}", Today) & "', 121), 'CMP', '" & System.Environment.UserName & "', 'D', '" & dr.Item(0) & "')"
                                                    cmd2.ExecuteReader()
                                                    con2.Dispose()
                                                Catch ex As Exception
                                                    MsgBox(ex.ToString)
                                                End Try
                                            End Using
                                        End While
                                    End If
                                    con.Dispose()
                                Catch ex As Exception
                                    MsgBox(ex.ToString)
                                End Try
                            End Using
                            Using con As SqlConnection = GetConnectionXML()
                                Try
                                    con.Open()
                                    Dim cmd As New SqlCommand
                                    cmd.Connection = con
                                    Dim dr As SqlDataReader
                                    cmd.CommandText = "DELETE FROM CRITICAXML WHERE NOME_XML = '" & xml & "'"
                                    dr = cmd.ExecuteReader()
                                    con.Dispose()
                                Catch ex As Exception
                                    MsgBox(ex.ToString)
                                End Try
                            End Using
                            File.Delete(sCriticados & "\" & xml.ToString)
                            File.Copy(caminho & "\" & xml.ToString, sCriticados & "\" & xml.ToString)
                            File.Delete(caminho & "\" & xml.ToString)
                        End If
                    End If
                End If
            Next
            If bVal Then
                fAtualizaDG("CMP")
                MsgBox("XML excluído com sucesso.", MsgBoxStyle.Information, "Informação")
            End If
            Exit For
        Next
    End Sub

    Private Sub btnmanualcte_Click(sender As System.Object, e As System.EventArgs) Handles btnmanualcte.Click
        Dim configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader()
        Dim caminho, sManual, sCriticados As String
        caminho = configurationAppSettings.GetValue("RepositorioCTE", GetType(System.String))
        sManual = configurationAppSettings.GetValue("ManualCTE", GetType(System.String))
        sCriticados = configurationAppSettings.GetValue("CriticadosCTE", GetType(System.String))
        Dim i As Integer
        Dim bVal As Boolean = False
        Dim bValPerg As Boolean = False
        Dim xml As String
        For Each row As DataGridViewRow In dgCTe.Rows
            For i = 0 To dgCTe.Rows.Count - 1
                If dgCTe.Item(1, i).Value Then
                    If Not IsDBNull(Me.dgCTe.Item(2, i).Value) Then
                        xml = CStr(Me.dgCTe.Item(2, i).Value)
                    Else
                        xml = String.Empty
                    End If
                    If Not bValPerg Then
                        Dim style As MsgBoxStyle
                        Dim response As MsgBoxResult
                        style = MsgBoxStyle.DefaultButton2 Or _
                           MsgBoxStyle.Exclamation Or MsgBoxStyle.YesNo
                        response = MsgBox("Deseja realmente transferir o arquivo XML para a pasta Manual?", style, "Confirmação")
                        If response = MsgBoxResult.Yes Then
                            bVal = True
                            bValPerg = True
                        Else
                            bValPerg = True
                        End If
                    End If
                    If bVal Then
                        If Not System.IO.File.Exists(Application.StartupPath & caminho & "\" & xml.ToString) Then
                            Using con As SqlConnection = GetConnectionXML()
                                Try
                                    con.Open()
                                    Dim cmd As New SqlCommand
                                    cmd.Connection = con
                                    Dim dr As SqlDataReader
                                    cmd.CommandText = "DELETE FROM CRITICAXML WHERE NOME_XML = '" & xml & "'"
                                    dr = cmd.ExecuteReader()
                                    con.Dispose()
                                Catch ex As Exception
                                    MsgBox(ex.ToString)
                                End Try
                            End Using
                        Else
                            Using con As SqlConnection = GetConnectionXML() 'Verifica o cadastro do produto
                                Try
                                    con.Open()
                                    Dim cmd As New SqlCommand
                                    cmd.Connection = con
                                    cmd.CommandText = "SELECT CRITICA FROM CRITICAXML WHERE NOME_XML = '" & xml & "'"
                                    Dim dr As SqlDataReader = cmd.ExecuteReader()
                                    If dr.HasRows Then
                                        While dr.Read()
                                            Using con2 As SqlConnection = GetConnectionXML()  'Grava log com o usuario que ignorou a critica
                                                Try
                                                    con2.Open()
                                                    Dim cmd2 As New SqlCommand
                                                    cmd2.Connection = con2
                                                    cmd2.CommandText = "INSERT INTO LOGEVENTOSXML (NOME_XML, DATAEMISSAO, SETOR, USUARIO, EVENTO, CRITICA) " +
                                                        "VALUES ('" & xml & "',convert(datetime, '" & String.Format("{0:yyyy-MM-dd}", Today) & "', 121), 'PO', '" & System.Environment.UserName & "', 'M', '" & dr.Item(0) & "')"
                                                    cmd2.ExecuteReader()
                                                    con2.Dispose()
                                                Catch ex As Exception
                                                    MsgBox(ex.ToString)
                                                End Try
                                            End Using
                                        End While
                                    End If
                                    con.Dispose()
                                Catch ex As Exception
                                    MsgBox(ex.ToString)
                                End Try
                            End Using
                            Using con As SqlConnection = GetConnectionXML()
                                Try
                                    con.Open()
                                    Dim cmd As New SqlCommand
                                    cmd.Connection = con
                                    Dim dr As SqlDataReader
                                    cmd.CommandText = "DELETE FROM CRITICAXML WHERE NOME_XML = '" & xml & "'"
                                    dr = cmd.ExecuteReader()
                                    con.Dispose()
                                Catch ex As Exception
                                    MsgBox(ex.ToString)
                                End Try
                            End Using
                            File.Delete(sManual & "\" & xml.ToString)
                            File.Copy(caminho & "\" & xml.ToString, sManual & "\" & xml.ToString)
                            File.Delete(caminho & "\" & xml.ToString)
                        End If
                    End If
                End If
            Next
            If bVal Then
                fAtualizaDG("CTE")
                MsgBox("XML transferido para a pasta Manual. A NF em questão deverá ser lançada manualmente.", MsgBoxStyle.Information, "Informação")
            End If
            Exit For
        Next
    End Sub

    Private Sub btnManualFis_Click(sender As System.Object, e As System.EventArgs) Handles btnManualFis.Click
        Dim configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader()
        Dim caminho, sManual, sCriticados As String
        caminho = configurationAppSettings.GetValue("RepositorioXML", GetType(System.String))
        sManual = configurationAppSettings.GetValue("ManualXML", GetType(System.String))
        sCriticados = configurationAppSettings.GetValue("CriticadosXML", GetType(System.String))
        Dim i As Integer
        Dim bVal As Boolean = False
        Dim bValPerg As Boolean = False
        Dim xml As String
        For Each row As DataGridViewRow In dgFiscal.Rows
            For i = 0 To dgFiscal.Rows.Count - 1
                If dgFiscal.Item(1, i).Value Then
                    If Not IsDBNull(Me.dgFiscal.Item(2, i).Value) Then
                        xml = CStr(Me.dgFiscal.Item(2, i).Value)
                    Else
                        xml = String.Empty
                    End If
                    If Not bValPerg Then
                        Dim style As MsgBoxStyle
                        Dim response As MsgBoxResult
                        style = MsgBoxStyle.DefaultButton2 Or _
                           MsgBoxStyle.Exclamation Or MsgBoxStyle.YesNo
                        response = MsgBox("Deseja realmente transferir o arquivo XML para a pasta Manual?", style, "Confirmação")
                        If response = MsgBoxResult.Yes Then
                            bVal = True
                            bValPerg = True
                        Else
                            bValPerg = True
                        End If
                    End If
                    If bVal Then
                        If Not System.IO.File.Exists(Application.StartupPath & caminho & "\" & xml.ToString) Then
                            Using con As SqlConnection = GetConnectionXML()
                                Try
                                    con.Open()
                                    Dim cmd As New SqlCommand
                                    cmd.Connection = con
                                    Dim dr As SqlDataReader
                                    cmd.CommandText = "DELETE FROM CRITICAXML WHERE NOME_XML = '" & xml & "'"
                                    dr = cmd.ExecuteReader()
                                    con.Dispose()
                                Catch ex As Exception
                                    MsgBox(ex.ToString)
                                End Try
                            End Using
                        Else
                            Using con As SqlConnection = GetConnectionXML() 'Verifica o cadastro do produto
                                Try
                                    con.Open()
                                    Dim cmd As New SqlCommand
                                    cmd.Connection = con
                                    cmd.CommandText = "SELECT CRITICA FROM CRITICAXML WHERE NOME_XML = '" & xml & "'"
                                    Dim dr As SqlDataReader = cmd.ExecuteReader()
                                    If dr.HasRows Then
                                        While dr.Read()
                                            Using con2 As SqlConnection = GetConnectionXML()  'Grava log com o usuario que ignorou a critica
                                                Try
                                                    con2.Open()
                                                    Dim cmd2 As New SqlCommand
                                                    cmd2.Connection = con2
                                                    cmd2.CommandText = "INSERT INTO LOGEVENTOSXML (NOME_XML, DATAEMISSAO, SETOR, USUARIO, EVENTO, CRITICA) " +
                                                        "VALUES ('" & xml & "',convert(datetime, '" & String.Format("{0:yyyy-MM-dd}", Today) & "', 121), 'FIS', '" & System.Environment.UserName & "', 'M', '" & dr.Item(0) & "')"
                                                    cmd2.ExecuteReader()
                                                    con2.Dispose()
                                                Catch ex As Exception
                                                    MsgBox(ex.ToString)
                                                End Try
                                            End Using
                                        End While
                                    End If
                                    con.Dispose()
                                Catch ex As Exception
                                    MsgBox(ex.ToString)
                                End Try
                            End Using
                            Using con As SqlConnection = GetConnectionXML()
                                Try
                                    con.Open()
                                    Dim cmd As New SqlCommand
                                    cmd.Connection = con
                                    Dim dr As SqlDataReader
                                    cmd.CommandText = "DELETE FROM CRITICAXML WHERE NOME_XML = '" & xml & "'"
                                    dr = cmd.ExecuteReader()
                                    con.Dispose()
                                Catch ex As Exception
                                    MsgBox(ex.ToString)
                                End Try
                            End Using
                            File.Delete(sManual & "\" & xml.ToString)
                            File.Copy(caminho & "\" & xml.ToString, sManual & "\" & xml.ToString)
                            File.Delete(caminho & "\" & xml.ToString)
                        End If
                    End If
                End If
            Next
            If bVal Then
                fAtualizaDG("FIS")
                MsgBox("XML transferido para a pasta Manual. A NF em questão deverá ser lançada manualmente.", MsgBoxStyle.Information, "Informação")
            End If
            Exit For
        Next
    End Sub

    Private Sub btnManualCad_Click(sender As System.Object, e As System.EventArgs) Handles btnManualCad.Click
        Dim configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader()
        Dim caminho, sManual, sCriticados As String
        caminho = configurationAppSettings.GetValue("RepositorioXML", GetType(System.String))
        sManual = configurationAppSettings.GetValue("ManualXML", GetType(System.String))
        sCriticados = configurationAppSettings.GetValue("CriticadosXML", GetType(System.String))
        Dim i As Integer
        Dim bVal As Boolean = False
        Dim bValPerg As Boolean = False
        Dim xml As String
        For Each row As DataGridViewRow In dgCadastros.Rows
            For i = 0 To dgCadastros.Rows.Count - 1
                If dgCadastros.Item(1, i).Value Then
                    If Not IsDBNull(Me.dgCadastros.Item(2, i).Value) Then
                        xml = CStr(Me.dgCadastros.Item(2, i).Value)
                    Else
                        xml = String.Empty
                    End If
                    If Not bValPerg Then
                        Dim style As MsgBoxStyle
                        Dim response As MsgBoxResult
                        style = MsgBoxStyle.DefaultButton2 Or _
                           MsgBoxStyle.Exclamation Or MsgBoxStyle.YesNo
                        response = MsgBox("Deseja realmente transferir o arquivo XML para a pasta Manual?", style, "Confirmação")
                        If response = MsgBoxResult.Yes Then
                            bVal = True
                            bValPerg = True
                        Else
                            bValPerg = True
                        End If
                    End If
                    If bVal Then
                        If Not System.IO.File.Exists(Application.StartupPath & caminho & "\" & xml.ToString) Then
                            Using con As SqlConnection = GetConnectionXML()
                                Try
                                    con.Open()
                                    Dim cmd As New SqlCommand
                                    cmd.Connection = con
                                    Dim dr As SqlDataReader
                                    cmd.CommandText = "DELETE FROM CRITICAXML WHERE NOME_XML = '" & xml & "'"
                                    dr = cmd.ExecuteReader()
                                    con.Dispose()
                                Catch ex As Exception
                                    MsgBox(ex.ToString)
                                End Try
                            End Using
                        Else
                            Using con As SqlConnection = GetConnectionXML() 'Verifica o cadastro do produto
                                Try
                                    con.Open()
                                    Dim cmd As New SqlCommand
                                    cmd.Connection = con
                                    cmd.CommandText = "SELECT CRITICA FROM CRITICAXML WHERE NOME_XML = '" & xml & "'"
                                    Dim dr As SqlDataReader = cmd.ExecuteReader()
                                    If dr.HasRows Then
                                        While dr.Read()
                                            Using con2 As SqlConnection = GetConnectionXML()  'Grava log com o usuario que ignorou a critica
                                                Try
                                                    con2.Open()
                                                    Dim cmd2 As New SqlCommand
                                                    cmd2.Connection = con2
                                                    cmd2.CommandText = "INSERT INTO LOGEVENTOSXML (NOME_XML, DATAEMISSAO, SETOR, USUARIO, EVENTO, CRITICA) " +
                                                        "VALUES ('" & xml & "',convert(datetime, '" & String.Format("{0:yyyy-MM-dd}", Today) & "', 121), 'CMP', '" & System.Environment.UserName & "', 'M', '" & dr.Item(0) & "')"
                                                    cmd2.ExecuteReader()
                                                    con2.Dispose()
                                                Catch ex As Exception
                                                    MsgBox(ex.ToString)
                                                End Try
                                            End Using
                                        End While
                                    End If
                                    con.Dispose()
                                Catch ex As Exception
                                    MsgBox(ex.ToString)
                                End Try
                            End Using
                            Using con As SqlConnection = GetConnectionXML()
                                Try
                                    con.Open()
                                    Dim cmd As New SqlCommand
                                    cmd.Connection = con
                                    Dim dr As SqlDataReader
                                    cmd.CommandText = "DELETE FROM CRITICAXML WHERE NOME_XML = '" & xml & "'"
                                    dr = cmd.ExecuteReader()
                                    con.Dispose()
                                Catch ex As Exception
                                    MsgBox(ex.ToString)
                                End Try
                            End Using
                            File.Delete(sManual & "\" & xml.ToString)
                            File.Copy(caminho & "\" & xml.ToString, sManual & "\" & xml.ToString)
                            File.Delete(caminho & "\" & xml.ToString)
                        End If
                    End If
                End If
            Next
            If bVal Then
                fAtualizaDG("CMP")
                MsgBox("XML transferido para a pasta Manual. A NF em questão deverá ser lançada manualmente.", MsgBoxStyle.Information, "Informação")
            End If
            Exit For
        Next
    End Sub

    Private Sub LogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogToolStripMenuItem.Click
        frmLogEventos.Show()
    End Sub

    Private Sub ParametrosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ParametrosToolStripMenuItem.Click
        frmParametros.Show()
    End Sub

    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub VersãoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VersãoToolStripMenuItem.Click
        frmVersao.Show()
    End Sub

    Private Sub ServicoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ServicoToolStripMenuItem.Click
        frmServico.Show()
    End Sub

    Private Sub UsuáriosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuáriosToolStripMenuItem.Click
        System.Diagnostics.Process.Start("CadastroUsuario.exe")
    End Sub

    Private Sub Principal_Closing()

    End Sub

    Private Sub frmPrincipal_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub txtFilial_TextChanged(sender As Object, e As EventArgs) Handles txtFilial.TextChanged

    End Sub
End Class