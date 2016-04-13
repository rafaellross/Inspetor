Imports System.Data.SqlClient

Public Class frmSelecaoEmpresa
    Public Property usuario As String
    Public Property administrador As String
    Public Property da As SqlDataAdapter
    Public Property commandBuilder As SqlCommandBuilder
    Public Property bindingSource1 As BindingSource

    Private ds As DataSet


    Public Sub New(ByVal usuarioParam As String, ByVal administradorParam As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        usuario = usuarioParam
        administrador = administradorParam


    End Sub
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        usuario = "rafaellross"
        administrador = "True"
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub frmSelecaoEmpresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetUserData()
    End Sub

    Public Sub GetUserData()
        Dim qryEmpresas As String = ""
        If administrador = "True" Then
            qryEmpresas = "SELECT M0_CODIGO, M0_CODFIL, M0_FILIAL, M0_CGC, M0_NOMECOM FROM SIGAMAT"
        Else
            qryEmpresas = "SELECT M0_CODIGO, M0_CODFIL, M0_FILIAL, M0_CGC, M0_NOMECOM FROM SIGAMAT join usuario_empresa usr on sigamat.M0_CODIGO = usr.CODEMP and sigamat.M0_CODFIL = usr.CODFILIAL and usr.usuario = '" + usuario + "'"

        End If

        Dim connString As String = connectionString()

        ' Texto de ligação à base de dados 
        Dim myConnectionString As String = connectionString()
        ' Cria uma nova ligação à base de dados 
        Dim connection As New SqlConnection(myConnectionString)
        ' Cria um novo SqlDataAdapter que servirá para actualizar o DataSet 

        da = New SqlDataAdapter(qryEmpresas, connection)
        ' Cria um DataSet, ou seja, uma representação em memória da informação 
        ds = New DataSet
        ' Coloca a informação da tabela definida no DataSet 
        da.Fill(ds, "SIGAMAT")
        ' Define que a fonte de dados da DataGridView é a nossa DataSet 
        ' criando automáticamente as colunas e linhas de dados 
        Me.dgEmpresas.DataSource = ds.Tables("SIGAMAT")
        ' Limpa a ligação à base de dados. Não é necessário fechar a ligação 
        ' porque esta não foi aberta através do comando .Open() 
        dgEmpresas.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
        connection = Nothing
    End Sub

    Public Function connectionString() As String
        Dim strUsuarioBanco, strSenhaUsuarioBanco, strBanco, strServidor As String
        Dim configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader()
        strUsuarioBanco = configurationAppSettings.GetValue("userBD", GetType(System.String))
        strSenhaUsuarioBanco = configurationAppSettings.GetValue("passBD", GetType(System.String))
        strBanco = configurationAppSettings.GetValue("DBXML", GetType(System.String))
        strServidor = configurationAppSettings.GetValue("Server", GetType(System.String))
        'Obtem a string de conexão 
        Dim sConnString As String = "Data Source = " + strServidor + "; Initial Catalog = " + strBanco + "; User Id =" + strUsuarioBanco + "; Password =" + strSenhaUsuarioBanco
        Return sConnString
    End Function

    Private Sub frmSelecaoEmpresa_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        System.Windows.Forms.Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim i As Integer
        Dim empresas As New List(Of String)
        For Each row As DataGridViewRow In dgEmpresas.Rows
            Dim valor = row.Cells(0).Value
            If valor IsNot Nothing Then
                If valor.ToString() = "True" Then
                    empresas.Add(row.Cells(4).Value.ToString())
                End If
            End If
        Next
        Dim principal = New frmPrincipal()
        Dim filtro As String = "CNPJINTERNO IN ("
        If empresas.Count > 0 Then
            For Each item As String In empresas

                filtro += "'" + item + "',"
            Next
            filtro += "'0')"
        End If
        principal.filtro = filtro
        principal.Show()

        Me.Hide()

    End Sub

    Private Sub dgEmpresas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgEmpresas.CellClick

        If (e.ColumnIndex = 0) Then
            If dgEmpresas.Rows(e.RowIndex).Cells(0).Value = Nothing Or dgEmpresas.Rows(e.RowIndex).Cells(0).Value <> "True" Then
                dgEmpresas.Rows(e.RowIndex).Cells(0).Value = "True"
            Else
                dgEmpresas.Rows(e.RowIndex).Cells(0).Value = "False"
            End If
        End If
    End Sub
End Class