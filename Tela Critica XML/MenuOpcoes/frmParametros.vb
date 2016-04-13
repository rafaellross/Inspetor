Imports System.Data.SqlClient

Public Class frmParametros

    Dim sVltbParamREPProcessar As String
    Dim sVltbParamREPProcessados As String
    Dim sVltbParamREPManual As String
    Dim sVltbParamREPCriticados As String
    Dim sVltbParamBDUser As String
    Dim sVltbParamBDPwd As String
    Dim sVltbParamBDAlias As String
    Dim sVltbParamBDServer As String
    Dim cVlcbLog As Boolean
    Dim sVltbParamCaminhoLog As String

    Private Sub frmParametros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'REPOSITORIOXML
        'processar
        Using con As SqlConnection = GetConnectionXML()
            Try
                con.Open()
                Dim cmd As New SqlCommand
                cmd.Connection = con
                Dim dr As SqlDataReader
                cmd.CommandText = "SELECT REPPROCESSAR FROM INSPETORXMLPARAM"
                dr = cmd.ExecuteReader()
                While (dr.Read())
                    tbParamREPProcessar.Text = dr("REPPROCESSAR").ToString()
                End While
            Catch ex As Exception
                MsgBox("Erro de acesso ao banco de dados: " + ex.ToString())
            End Try
            con.Dispose()
        End Using

        'processados
        Using con As SqlConnection = GetConnectionXML()
            Try
                con.Open()
                Dim cmd As New SqlCommand
                cmd.Connection = con
                Dim dr As SqlDataReader
                cmd.CommandText = "SELECT REPPROCESSADOS FROM INSPETORXMLPARAM"
                dr = cmd.ExecuteReader()
                While (dr.Read())
                    tbParamREPProcessados.Text = dr("REPPROCESSADOS").ToString()
                End While
            Catch ex As Exception

            End Try
            con.Dispose()
        End Using

        'manual
        Using con As SqlConnection = GetConnectionXML()
            Try
                con.Open()
                Dim cmd As New SqlCommand
                cmd.Connection = con
                Dim dr As SqlDataReader
                cmd.CommandText = "SELECT REPMANUAL FROM INSPETORXMLPARAM"
                dr = cmd.ExecuteReader()
                While (dr.Read())
                    tbParamREPManual.Text = dr("REPMANUAL").ToString()
                End While
            Catch ex As Exception
                MsgBox("Nao")
            End Try
            con.Dispose()
        End Using

        'criticados
        Using con As SqlConnection = GetConnectionXML()
            Try
                con.Open()
                Dim cmd As New SqlCommand
                cmd.Connection = con
                Dim dr As SqlDataReader
                cmd.CommandText = "SELECT REPCRITICADOS FROM INSPETORXMLPARAM"
                dr = cmd.ExecuteReader()
                While (dr.Read())
                    tbParamREPCriticados.Text = dr("REPCRITICADOS").ToString()
                End While
            Catch ex As Exception
                MsgBox("Nao")
            End Try
            con.Dispose()
        End Using

        'BANCO DE DADOS
        'usuário
        Using con As SqlConnection = GetConnectionXML()
            Try
                con.Open()
                Dim cmd As New SqlCommand
                cmd.Connection = con
                Dim dr As SqlDataReader
                cmd.CommandText = "SELECT BDUSER FROM INSPETORXMLPARAM"
                dr = cmd.ExecuteReader()
                While (dr.Read())
                    tbParamBDUser.Text = dr("BDUSER").ToString()
                End While
            Catch ex As Exception
                MsgBox("Nao")
            End Try
            con.Dispose()
        End Using

        'senha
        Using con As SqlConnection = GetConnectionXML()
            Try
                con.Open()
                Dim cmd As New SqlCommand
                cmd.Connection = con
                Dim dr As SqlDataReader
                cmd.CommandText = "SELECT BDPWD FROM INSPETORXMLPARAM"
                dr = cmd.ExecuteReader()
                While (dr.Read())
                    tbParamBDPwd.Text = dr("BDPWD").ToString()
                End While
            Catch ex As Exception
                MsgBox("Nao")
            End Try
            con.Dispose()
        End Using

        'alias
        Using con As SqlConnection = GetConnectionXML()
            Try
                con.Open()
                Dim cmd As New SqlCommand
                cmd.Connection = con
                Dim dr As SqlDataReader
                cmd.CommandText = "SELECT BDALIAS FROM INSPETORXMLPARAM"
                dr = cmd.ExecuteReader()
                While (dr.Read())
                    tbParamBDAlias.Text = dr("BDALIAS").ToString()
                End While
            Catch ex As Exception
                MsgBox("Nao")
            End Try
            con.Dispose()
        End Using

        'server
        Using con As SqlConnection = GetConnectionXML()
            Try
                con.Open()
                Dim cmd As New SqlCommand
                cmd.Connection = con
                Dim dr As SqlDataReader
                cmd.CommandText = "SELECT BDSERVER FROM INSPETORXMLPARAM"
                dr = cmd.ExecuteReader()
                While (dr.Read())
                    tbParamBDServer.Text = dr("BDSERVER").ToString()
                End While
            Catch ex As Exception
                MsgBox("Nao")
            End Try
            con.Dispose()
        End Using

        'MAIL
        'conta
        Using con As SqlConnection = GetConnectionXML()
            Try
                con.Open()
                Dim cmd As New SqlCommand
                cmd.Connection = con
                Dim dr As SqlDataReader
                cmd.CommandText = "SELECT CONTAEMAIL FROM INSPETORXMLPARAM"
                dr = cmd.ExecuteReader()
                While (dr.Read())
                    tbParamMailConta.Text = dr("CONTAEMAIL").ToString()
                End While
            Catch ex As Exception
                MsgBox("Nao")
            End Try
            con.Dispose()
        End Using

        'ativa e-mail
        Using con As SqlConnection = GetConnectionXML()
            Try
                con.Open()
                Dim cmd As New SqlCommand
                cmd.Connection = con
                Dim dr As SqlDataReader
                cmd.CommandText = "SELECT ENVIAEMAIL FROM INSPETORXMLPARAM"
                dr = cmd.ExecuteReader()
                If dr.HasRows Then
                    cbMail.Checked = True
                Else : cbMail.Checked = False
                End If
            Catch ex As Exception
                MsgBox("Nao")
            End Try
            con.Dispose()
        End Using

        'LOG
        'ativalog
        Using con As SqlConnection = GetConnectionXML()
            Try
                con.Open()
                Dim cmd As New SqlCommand
                cmd.Connection = con
                Dim dr As SqlDataReader
                cmd.CommandText = "SELECT ATIVALOG FROM INSPETORXMLPARAM WHERE ATIVALOG = 1"
                dr = cmd.ExecuteReader()
                If dr.HasRows Then
                    cbLog.Checked = True
                Else : cbLog.Checked = False
                End If
            Catch ex As Exception
                MsgBox("Nao")
            End Try
            con.Dispose()
        End Using

        'caminho log
        Using con As SqlConnection = GetConnectionXML()
            Try
                con.Open()
                Dim cmd As New SqlCommand
                cmd.Connection = con
                Dim dr As SqlDataReader
                cmd.CommandText = "SELECT CAMINHOLOG FROM INSPETORXMLPARAM"
                dr = cmd.ExecuteReader()
                While (dr.Read())
                    tbParamCaminhoLog.Text = dr("CAMINHOLOG").ToString()
                End While
            Catch ex As Exception
                MsgBox("Nao")
            End Try
            con.Dispose()
        End Using

        'valida atualização dos campos
        sVltbParamREPProcessar = tbParamREPProcessar.Text
        sVltbParamREPProcessados = tbParamREPProcessados.Text
        sVltbParamREPManual = tbParamREPManual.Text
        sVltbParamREPCriticados = tbParamREPCriticados.Text
        sVltbParamBDUser = tbParamBDUser.Text
        sVltbParamBDPwd = tbParamBDPwd.Text
        sVltbParamBDAlias = tbParamBDAlias.Text
        sVltbParamBDServer = tbParamBDServer.Text
        cVlcbLog = cbLog.Checked
        sVltbParamCaminhoLog = tbParamCaminhoLog.Text

    End Sub

    Private Sub btParamOK_Click(sender As Object, e As EventArgs) Handles btParamOK.Click

        If cbLog.Checked = True And String.IsNullOrEmpty(tbParamCaminhoLog.Text) Then

            MsgBox("Caminho do log não pode ser nulo!", MsgBoxStyle.Information, "Aviso")

        ElseIf String.IsNullOrEmpty(tbParamREPProcessar.Text) Or String.IsNullOrEmpty(tbParamREPProcessados.Text) Or
            String.IsNullOrEmpty(tbParamREPManual.Text) Or String.IsNullOrEmpty(tbParamREPCriticados.Text) Or
            String.IsNullOrEmpty(tbParamBDUser.Text) Or String.IsNullOrEmpty(tbParamBDPwd.Text) Or
            String.IsNullOrEmpty(tbParamBDAlias.Text) Or String.IsNullOrEmpty(tbParamBDServer.Text) Then

            MsgBox("Existem campos vazios!", MsgBoxStyle.Information, "Aviso")

        ElseIf tbParamREPProcessar.Text = sVltbParamREPProcessar And tbParamREPProcessados.Text = sVltbParamREPProcessados And
            tbParamREPManual.Text = sVltbParamREPManual And tbParamREPCriticados.Text = sVltbParamREPCriticados And
            tbParamBDUser.Text = sVltbParamBDUser And tbParamBDPwd.Text = sVltbParamBDPwd And
            tbParamBDAlias.Text = sVltbParamBDAlias And tbParamBDServer.Text = sVltbParamBDServer And
            cbLog.Checked = cVlcbLog And tbParamCaminhoLog.Text = sVltbParamCaminhoLog Then

            Me.Close()

        Else

            MsgBox("Existem alterações não salvas!", MsgBoxStyle.Information, "Alerta")

        End If

    End Sub

    Private Sub btParamSalvar_Click(sender As Object, e As EventArgs) Handles btParamSalvar.Click

        Dim vetor(1) As Integer

        'valida tab parametros
        If String.IsNullOrEmpty(tbParamREPProcessar.Text) Or String.IsNullOrEmpty(tbParamREPProcessados.Text) Or
            String.IsNullOrEmpty(tbParamREPManual.Text) Or String.IsNullOrEmpty(tbParamREPCriticados.Text) Then

            MsgBox("Existem campos vazios!", MsgBoxStyle.Information, "Aviso")

        ElseIf tbParamREPProcessar.Text <> sVltbParamREPProcessar Or tbParamREPProcessados.Text <> sVltbParamREPProcessados Or
            tbParamREPManual.Text <> sVltbParamREPManual Or tbParamREPCriticados.Text <> sVltbParamREPCriticados Then

            Using con As SqlConnection = GetConnectionXML()
                Try
                    con.Open()
                    Dim cmd As New SqlCommand
                    cmd.Connection = con
                    Dim dr As SqlDataReader
                    cmd.CommandText = "UPDATE INSPETORXMLPARAM SET REPPROCESSAR = '" & tbParamREPProcessar.Text & "', REPPROCESSADOS = '" & tbParamREPProcessados.Text & "', REPMANUAL = '" & tbParamREPManual.Text & "', REPCRITICADOS = '" & tbParamREPCriticados.Text & "'"
                    dr = cmd.ExecuteReader()
                    sVltbParamREPProcessar = tbParamREPProcessar.Text
                    sVltbParamREPProcessados = tbParamREPProcessados.Text
                    sVltbParamREPManual = tbParamREPManual.Text
                    sVltbParamREPCriticados = tbParamREPCriticados.Text
                Catch ex As Exception
                    MsgBox("Ocorreram erros ao salvar as alterações, verifique a aba Parâmetros!", MsgBoxStyle.Information, "Aviso")
                    con.Dispose()
                    Exit Sub
                End Try
                con.Dispose()
                vetor(0) = 2
            End Using
        Else : vetor(0) = 1
        End If

        'valida tab log
        If cbLog.Checked = True And String.IsNullOrEmpty(tbParamCaminhoLog.Text) Then

            MsgBox("Caminho do log não pode ser nulo!", MsgBoxStyle.Information, "Aviso")

        ElseIf cbLog.Checked <> cVlcbLog Or tbParamCaminhoLog.Text <> sVltbParamCaminhoLog Then

            Using con As SqlConnection = GetConnectionXML()
                Try
                    con.Open()
                    Dim cmd As New SqlCommand
                    cmd.Connection = con
                    Dim dr As SqlDataReader
                    cmd.CommandText = "UPDATE INSPETORXMLPARAM SET CAMINHOLOG = '" & tbParamCaminhoLog.Text & "' , ATIVALOG = '" & cbLog.Checked & "'"
                    dr = cmd.ExecuteReader()
                    cVlcbLog = cbLog.Checked
                    sVltbParamCaminhoLog = tbParamCaminhoLog.Text
                Catch ex As Exception
                    MsgBox("Ocorreram erros ao salvar as alterações, verifique a aba Log!", MsgBoxStyle.Information, "Aviso")
                    con.Dispose()
                    Exit Sub
                End Try
                con.Dispose()
                vetor(1) = 2
            End Using
        Else : vetor(1) = 1
        End If

        Dim X As Boolean

        For Each i In vetor
            If i > 1 Then
                X = True
                Exit For
            Else
                X = False
            End If
        Next i

        If X Then
            MsgBox("Salvo com sucesso!", MsgBoxStyle.Information, "Aviso")
        Else
            MsgBox("Não houve alterações!", MsgBoxStyle.Information, "Aviso")
        End If

    End Sub

    Private Sub btParamCancelar_Click(sender As Object, e As EventArgs) Handles btParamCancelar.Click

        Me.Close()

    End Sub

    Private Sub btParamTestaConex_Click(sender As Object, e As EventArgs) Handles btParamTestaConex.Click
        Dim con As SqlConnection

        con = New SqlConnection("server=" + tbParamBDServer.Text + ";uid=" + tbParamBDUser.Text + ";pwd=" + tbParamBDPwd.Text + ";database=" + tbParamBDAlias.Text)

        If String.IsNullOrEmpty(tbParamBDUser.Text) Or String.IsNullOrEmpty(tbParamBDPwd.Text) Or
            String.IsNullOrEmpty(tbParamBDAlias.Text) Or String.IsNullOrEmpty(tbParamBDServer.Text) Then
            MsgBox("Existem campos vazios!", MsgBoxStyle.Information, "Aviso")
        Else
            Try
                con.Open()
                If con.State = ConnectionState.Open Then
                    MsgBox("Conectado com Sucesso!", MsgBoxStyle.Information, "Aviso")
                End If
            Catch ex As Exception
                MsgBox("Erro na conexão!", MsgBoxStyle.Information, "Aviso")
            End Try
        End If
        con.Dispose()
    End Sub

    Private Sub btSelectFolderProcessar_Click(sender As Object, e As EventArgs) Handles btSelectFolderProcessar.Click
        If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
            tbParamREPProcessar.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub btSelectFolderProcessados_Click(sender As Object, e As EventArgs) Handles btSelectFolderProcessados.Click
        If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
            tbParamREPProcessados.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub tSelectFolderManual_Click(sender As Object, e As EventArgs) Handles tSelectFolderManual.Click
        If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
            tbParamREPManual.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub btSelectFolderCriticados_Click(sender As Object, e As EventArgs) Handles btSelectFolderCriticados.Click
        If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
            tbParamREPCriticados.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
            tbParamCaminhoLog.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub
End Class